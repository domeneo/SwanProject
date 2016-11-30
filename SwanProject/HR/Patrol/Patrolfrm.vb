Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Public Class Patrolfrm

    Dim xlsApp As New Microsoft.Office.Interop.Excel.Application
    Dim xlsBook As Workbook
    Dim xlsSheet As Worksheet

    Dim sStart, sEnd, Scheck, Echeck As DateTime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If txtPath.Text = "" Then Exit Sub
        Dim ex As New PatrolExceltoDB
        Dim dt As Data.DataTable = ex.LoadExcel(txtPath.Text, 1)
        '  Dgv1.DataSource = dt





        Dim noTimeDT As New Data.DataTable
        noTimeDT.Columns.Add("Begin", GetType(System.DateTime))
        noTimeDT.Columns.Add("End", GetType(System.DateTime))

        sStart = dt.AsEnumerable().Min(Function(row) row.Field(Of Date)("Begin"))
        sEnd = dt.AsEnumerable().Max(Function(row) row.Field(Of Date)("End"))

        Scheck = sStart.Year & "/" & sStart.Month & "/" & sStart.Day & " " & sStart.Hour & ":00:00"
        Echeck = Scheck.AddHours(1)
        Do While sEnd >= Echeck

            For Each dr As DataRow In dt.Rows
                If dr("Begin").ToString <> "" Then
                    If dr("Begin") >= Scheck And dr("Begin") <= Echeck Then
                        If ShiftChkTime() = -1 Then

                            Exit Do
                        End If
                        Continue Do
                    End If
                End If
                If dr("End").ToString <> "" Then
                    If dr("End") >= Scheck And dr("End") <= Echeck Then
                        If ShiftChkTime() = -1 Then
                            Exit Do
                        End If
                        Continue Do
                    End If
                End If

            Next

            noTimeDT.Rows.Add(Scheck, Echeck)
            If ShiftChkTime() = -1 Then
                Exit Do
            End If
        Loop
        '  NotimeDGV.DataSource = noTimeDT


        Dim NoStamp As New Data.DataTable

        NoStamp = dt.Select("[time] ='01/01/0001 12:00:00 AM'").CopyToDataTable()


        '  NoStampDGV.DataSource = NoStamp




        xlsBook = xlsApp.Workbooks.Add
        xlsSheet = xlsBook.Sheets.Item(1)
        Dim sRow As Integer
        sRow = AddExcel(noTimeDT, 1, "Hour not stamp")
        sRow = AddExcel(NoStamp, sRow, "No Stamp")
        sRow = AddExcel(dt.Select("Period<30").CopyToDataTable, sRow, "Time Less than 30 Minute")

        xlsSheet.Application.Visible = True


    End Sub
    Function AddExcel(DT As Data.DataTable, Row As Integer, Caption As String)

        Dim COL As Integer
        With xlsSheet





            .Range("A" & Row).Value = Caption
            .Range("A" & Row).Font.Bold = True
            Row += 1
            COL = 0
            For Each dc As DataColumn In DT.Columns
                .Range(RunChar(COL) & Trim(Str(Row))).Value = dc.ToString
                COL += 1
            Next


            '.Range("A2:I2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A" & Row & ":" & RunChar(COL - 1) & Row).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A" & Row & ":" & RunChar(COL - 1) & Row).Font.Underline = True
            Dim str1 As String

            'str1 = rs.GetString(adClipString, rs.RecordCount)
            ' Clipboard.Clear()
            ' CopyDataToClipboard(DT)
            Dim R As Integer = 0
            'Dim pgb As New ProgressFrm
            'pgb.PGB.Maximum = dt.Rows.Count + 1
            'pgb.PGB.Value = 0
            'pgb.Show()
            Dim StrAR(DT.Rows.Count, DT.Columns.Count) As String
            For Each dr As DataRow In DT.Rows

                For i = 0 To DT.Columns.Count - 1
                    StrAR(R, i) = dr(i).ToString
                Next

                'pgb.PGB.Value = R
                'pgb.Text = "Export " & pgb.PGB.Value & " OF " & pgb.PGB.Maximum
                R += 1
            Next
            Row += 1
            '  pgb.Close()
            .Range("A" & Row & ":" & RunChar(COL - 1) & Row + DT.Rows.Count - 1).Value2 = StrAR
            ' .Range("A3").PasteSpecial(XlPasteType.xlPasteAll)

            .Range("A" & Row & ":" & RunChar(COL - 1) & Row + DT.Rows.Count - 1).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            ' .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders.Weight = XlBorderWeight.xlHairline
            .Range("A" & Row & ":" & RunChar(COL - 1) & Row + DT.Rows.Count - 1).Borders._Default(XlBordersIndex.xlInsideHorizontal).LineStyle = XlBorderWeight.xlHairline
            .Range("A" & Row & ":" & RunChar(COL - 1) & Row + DT.Rows.Count - 1).Borders._Default(XlBordersIndex.xlInsideVertical).LineStyle = XlBorderWeight.xlHairline
            .Range("A" & Row & ":" & RunChar(COL - 1) & Row).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            Row += DT.Rows.Count + 1
            Return Row
        End With
    End Function
    Function ShiftChkTime()
        Scheck = Scheck.AddHours(1)
        Echeck = Scheck.AddHours(1)
        If sEnd <= Echeck Then Return -1
    End Function

    Function RunChar(ByVal i As Integer) As String
        Dim B, F As Integer
        'If Int(i / 27) > 0 Then B = i Mod (26) Else B = i Mod (27)
        B = i Mod (26)
        F = Int(i / 26)
        RunChar = IIf(F > 0, Chr(F + 64), "") & Chr(B + 65)
        'RunChar = str(F) & str(B)

    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        OpenFileDialog1.Filter = "Excel files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenDLG1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        txtPath.Text = OpenFileDialog1.FileName
        'WSCB.DataSource = ExToDb.GetWorksheetName(txtUpload.Text)
        'WSCB.ValueMember = "WsID"
        'WSCB.DisplayMember = "WsName"
    End Sub


End Class
