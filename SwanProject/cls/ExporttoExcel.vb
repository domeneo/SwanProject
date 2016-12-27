Imports Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.InteropServices
Public Class ExporttoExcel

    ' Dim xlsApp As New Microsoft.Office.Interop.Excel.Application

    Dim xlsBook As Workbook
    Dim xlsSheet As Worksheet
    Dim DT As System.Data.DataTable
    Dim columsBeg, HTitle As String
    Dim GroupBool As Boolean
    Dim GroupCol As Integer
    Dim SumColumn As Integer

    Private Sub ExporttoExcel()
        columsBeg = "A"
        GroupBool = False
        SumColumn = -1
    End Sub
    Function RunChar(ByVal i As Integer) As String
        Dim B, F As Integer
        'If Int(i / 27) > 0 Then B = i Mod (26) Else B = i Mod (27)
        B = i Mod (26)
        F = Int(i / 26)
        RunChar = IIf(F > 0, Chr(F + 64), "") & Chr(B + 65)
        'RunChar = str(F) & str(B)

    End Function
    Public WriteOnly Property SetDt() As System.Data.DataTable

        Set(ByVal dttmp As System.Data.DataTable)
            DT = dttmp
        End Set

    End Property

    Public Property BeginCloumn() As String
        Get
            Return columsBeg
        End Get
        Set(ByVal value As String)
            columsBeg = value
        End Set


    End Property

    Public WriteOnly Property SumColumnNum() As String

        Set(ByVal value As String)
            If value > 0 Then SumColumn = value - 1 Else SumColumn = 0

        End Set


    End Property

    Public Property GroupFields() As Integer
        Get
            Return GroupCol
        End Get
        Set(ByVal value As Integer)
            GroupCol = value
            GroupBool = True
        End Set


    End Property


    Public Property Title() As String
        Get
            Return HTitle
        End Get
        Set(ByVal value As String)
            HTitle = value
        End Set


    End Property


    Sub CopyDataToClipboard(ByVal cDT As Data.DataTable)
        Dim sb As String = ""

        'var sb = new StringBuilder();

        Dim pgb As New ProgressFrm
        pgb.PGB.Maximum = DT.Rows.Count
        pgb.PGB.Value = 0
        pgb.Show()


        Dim i, x As Integer
        x = 0
        For Each dr As DataRow In DT.Rows

            For i = 0 To DT.Columns.Count - 1
                sb &= dr(i) & vbTab
            Next
            sb &= vbCrLf
            pgb.PGB.Value = x
            '   pgb.Text = "Export " & pgb.PGB.Value & " OF " & pgb.PGB.Maximum
            x = x + 1
        Next
        Clipboard.Clear()
        Clipboard.SetText(sb)
        pgb.Close()

        'for (var i = 0; i < dataTable.Columns.Count; i++)
        'sb.Append(dataTable.Columns[i].ColumnName).Append("\t");
        'sb.AppendLine();

        'foreach (DataRow row in dataTable.Rows)
        '{
        'for (var i = 0; i < dataTable.Columns.Count; i++)
        'sb.Append(row[i] ?? string.Empty).Append("\t");
        'sb.AppendLine();
        '}


        '}
        '}
    End Sub

    Public Sub QuickShow()
        On Error GoTo ErrorHandler
        ' If rs.RecordCount = 0 Then Exit Sub
        Dim xlsApp As New Application
        xlsBook = xlsApp.Workbooks.Add
        xlsSheet = xlsBook.Sheets.Item(1)

        Dim COL As Integer
        With xlsSheet


            .Range(columsBeg & "1").Value = HTitle
            .Range(columsBeg & "1").Font.Bold = True

            COL = 0
            For Each dc As DataColumn In DT.Columns
                .Range(RunChar(COL) & Trim(Str(2))).Value = dc.ToString
                COL += 1
            Next

           
            '.Range("A2:I2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A2:" & RunChar(COL - 1) & "2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A2:" & RunChar(COL - 1) & "2").Font.Underline = True
            Dim str1 As String

            'str1 = rs.GetString(adClipString, rs.RecordCount)
            ' Clipboard.Clear()
            CopyDataToClipboard(DT)
            .Range("A3").PasteSpecial(XlPasteType.xlPasteAll)

            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            ' .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders.Weight = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders._Default(XlBordersIndex.xlInsideHorizontal).LineStyle = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders._Default(XlBordersIndex.xlInsideVertical).LineStyle = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & "2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Application.Visible = True
        End With

        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, , "Error")
    End Sub
    '    Public Sub show()
    '        On Error GoTo ErrorHandler
    '        If rs.RecordCount = 0 Then Exit Sub

    '        xlsBook = xlsApp.Workbooks.Add
    '        xlsSheet = xlsBook.Sheets.Item(1)

    '        frmprogress.show()
    '        frmprogress.ProgressBar1.Max = 3
    '        frmprogress.ProgressBar1 = 0
    '        frmprogress.Caption = "Exporting..."
    '        With xlsSheet

    '            rs.MoveFirst()
    '            .Range(columsBeg & "1") = HTitle
    '            .Range(columsBeg & "1").Font.Bold = True

    '            For r = 0 To rs.Fields.Count - 1
    '                .Range(Chr(Asc(columsBeg) + r) & "2") = rs.Fields(r).Name
    '            Next r

    '            .Range(columsBeg & "2:" & Chr(Asc(columsBeg) + r - 1) & "2").Font.Underline = True

    '            i = 3
    '            Dim GroupValue As String
    '            Dim GroupBegin As Integer

    '            GroupValue = ""

    '            frmprogress.ProgressBar1 = frmprogress.ProgressBar1 + 1
    '            Do While Not rs.EOF

    '                If rs.Fields(GroupCol) <> GroupValue And GroupBool Then
    '                    .Range(Chr(Asc(columsBeg)) & Trim(Str(i))) = rs.Fields(GroupCol)
    '                    .Range(columsBeg & Trim(Str(i))).Font.Bold = True

    '                    If GroupValue <> "" Then
    '                        If GroupBegin <> i - 2 Then .Range(columsBeg & GroupBegin & ":" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i - 2))).Borders(xlInsideHorizontal).LineStyle = xlContinuous

    '                        .Range(columsBeg & GroupBegin & ":" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i - 1))).Borders(xlInsideVertical).LineStyle = xlContinuous
    '                        .Range(columsBeg & GroupBegin & ":" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i - 1))).BorderAround(xlContinuous)
    '                    End If

    '                    GroupValue = rs.Fields(GroupCol)
    '                    GroupBegin = i + 1
    '                Else

    '                    For r = 0 To rs.Fields.Count - 1
    '                        .Range(Chr(Asc(columsBeg) + r) & Trim(Str(i))) = nullvalue(rs.Fields(r))
    '                    Next r

    '                    rs.MoveNext()
    '                End If

    '                i = i + 1

    '                If rs.EOF And SumColumn > -1 And GroupBool Then
    '                    .Range(Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i))) = "=SUM(" & Chr(Asc(columsBeg) + SumColumn) & GroupBegin & ":" & Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i - 1)) & ")"
    '                    .Range(Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i))).BorderAround(xlContinuous)
    '                    .Range(Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i))).Font.Bold = True
    '                    i = i + 1
    '                ElseIf Not rs.EOF Then
    '                    If rs.Fields(GroupCol) <> GroupValue And GroupBool And SumColumn > -1 Then
    '                        .Range(Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i))) = "=SUM(" & Chr(Asc(columsBeg) + SumColumn) & GroupBegin & ":" & Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i - 1)) & ")"
    '                        .Range(Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i))).BorderAround(xlContinuous)
    '                        .Range(Chr(Asc(columsBeg) + SumColumn) & Trim(Str(i))).Font.Bold = True
    '                        i = i + 1
    '                    End If
    '                End If

    '            Loop
    '            frmprogress.ProgressBar1 = frmprogress.ProgressBar1 + 1
    '            i = i - 1

    '            If GroupBool = False Then
    '                .Range(columsBeg & "2:" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).Borders(xlInsideHorizontal).LineStyle = xlContinuous
    '                .Range(columsBeg & "2:" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).Borders(xlInsideVertical).LineStyle = xlContinuous
    '                .Range(columsBeg & "2:" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).BorderAround(xlContinuous)
    '            Else

    '                If GroupBegin <> i Then .Range(columsBeg & GroupBegin & ":" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).Borders(xlInsideHorizontal).LineStyle = xlContinuous
    '                .Range(columsBeg & GroupBegin & ":" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).Borders(xlInsideVertical).LineStyle = xlContinuous
    '                .Range(columsBeg & GroupBegin & ":" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).BorderAround(xlContinuous)
    '            End If

    '            .Range(columsBeg & "2:" & Chr(Asc(columsBeg) + r - 1) & Trim(Str(i))).ShrinkToFit = True
    '            .Application.Visible = True
    '        End With
    '        frmprogress.ProgressBar1 = frmprogress.ProgressBar1.Max
    '        Unload(frmprogress)
    '        Exit Sub
    'ErrorHandler:
    '        MsgBox(Err.Description, , "Error")
    '    End Sub






    Public Sub Show()
        'On Error GoTo ErrorHandler
        ' If rs.RecordCount = 0 Then Exit Sub
        Dim xlsApp As New Application
        xlsBook = xlsApp.Workbooks.Add
        xlsSheet = xlsBook.Sheets.Item(1)

        Dim pgb As New ProgressFrm
        pgb.PGB.Maximum = DT.Rows.Count
        pgb.PGB.Value = 0
        pgb.Show()
        Dim COL, ROW As Integer
        With xlsSheet


            .Range(columsBeg & "1").Value = HTitle
            .Range(columsBeg & "1").Font.Bold = True

            COL = 0
            For Each dc As DataColumn In DT.Columns
                .Range(RunChar(COL) & Trim(Str(2))).Value = dc.ToString
                COL += 1
            Next



            '.Range("A2:I2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A2:" & RunChar(COL - 1) & "2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A2:" & RunChar(COL - 1) & "2").Font.Underline = True
            'Dim str1 As String

            'str1 = rs.GetString(adClipString, rs.RecordCount)
            ' Clipboard.Clear()

            ROW = 3
            For Each dr As DataRow In DT.Rows

                For COL = 0 To DT.Columns.Count - 1
  
                    .Range(RunChar(COL) & ROW).Value = dr(COL)
                Next
                pgb.PGB.Value = ROW - 3
                pgb.Text = "INPUT " & pgb.PGB.Value & " OF " & pgb.PGB.Maximum
                ROW += 1
                
            Next


            'CopyDataToClipboard(DT)
            '.Range("A3").PasteSpecial(XlPasteType.xlPasteAll)

            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            ' .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders.Weight = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders._Default(XlBordersIndex.xlInsideHorizontal).LineStyle = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders._Default(XlBordersIndex.xlInsideVertical).LineStyle = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & "2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)

            pgb.Close()
            .Application.Visible = True

        End With

        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, , "Error")
    End Sub


    Public Sub QuickShow2()
        On Error GoTo ErrorHandler
        ' If rs.RecordCount = 0 Then Exit Sub
        Dim xlsApp As New Application
        xlsBook = xlsApp.Workbooks.Add
        xlsSheet = xlsBook.Sheets.Item(1)

        Dim COL As Integer
        With xlsSheet


            .Range(columsBeg & "1").Value = HTitle
            .Range(columsBeg & "1").Font.Bold = True

            COL = 0
            For Each dc As DataColumn In DT.Columns
                .Range(RunChar(COL) & Trim(Str(2))).Value = dc.ToString
                COL += 1
            Next


            '.Range("A2:I2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A2:" & RunChar(COL - 1) & "2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Range("A2:" & RunChar(COL - 1) & "2").Font.Underline = True
            Dim str1 As String

            'str1 = rs.GetString(adClipString, rs.RecordCount)
            ' Clipboard.Clear()
            ' CopyDataToClipboard(DT)
            Dim R As Integer = 0
            Dim pgb As New ProgressFrm
            pgb.PGB.Maximum = DT.Rows.Count + 1
            pgb.PGB.Value = 0
            pgb.Show()
            Dim StrAR(DT.Rows.Count, DT.Columns.Count) As String
            For Each dr As DataRow In DT.Rows

                For i = 0 To DT.Columns.Count - 1
                    StrAR(R, i) = dr(i).ToString
                Next

                pgb.PGB.Value = R
                pgb.Text = "Export " & pgb.PGB.Value & " OF " & pgb.PGB.Maximum
                R += 1
            Next
            pgb.Close()
            .Range("A3:" & RunChar(COL - 1) & DT.Rows.Count + 2).Value2 = StrAR
            ' .Range("A3").PasteSpecial(XlPasteType.xlPasteAll)

            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            ' .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders.Weight = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders._Default(XlBordersIndex.xlInsideHorizontal).LineStyle = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & DT.Rows.Count + 2).Borders._Default(XlBordersIndex.xlInsideVertical).LineStyle = XlBorderWeight.xlHairline
            .Range("A2:" & RunChar(COL - 1) & "2").BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium)
            .Application.Visible = True
        End With

        Exit Sub
ErrorHandler:
        MsgBox(Err.Description, , "Error")
    End Sub

    Public Shared Function ExcelColumnFromNumber(column As Integer) As String
        Dim columnString As String = ""
        Dim columnNumber As Integer = column
        While columnNumber > 0
            Dim currentLetterNumber As Integer = (columnNumber - 1) Mod 26
            Dim currentLetter As Char = Chr(currentLetterNumber + 65)
            columnString = currentLetter & columnString
            columnNumber = (columnNumber - (currentLetterNumber + 1)) / 26
        End While
        Return columnString
    End Function

    ''' <summary>
    ''' A -> 1<br/>
    ''' B -> 2<br/>
    ''' C -> 3<br/>
    ''' ...
    ''' </summary>
    ''' <param name="column"></param>
    ''' <returns></returns>
    Public Shared Function NumberFromExcelColumn(column As String) As Integer
        Dim retVal As Integer = 0
        Dim col As String = column.ToUpper()
        For iChar As Integer = col.Length - 1 To 0 Step -1
            Dim colPiece As String = col(iChar)
            Dim colNum As Integer = colPiece - 64
            retVal = retVal + colNum * CInt(Math.Pow(26, col.Length - (iChar + 1)))
        Next
        Return retVal
    End Function

    Sub WriteExcel(PathExcel As String)
        Dim oldCI As System.Globalization.CultureInfo =
         System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture =
                New System.Globalization.CultureInfo("en-US")



        Dim oApp As New Application
        Dim oWBa As Workbook
        Try


            Using TryCast(oApp, IDisposable)



                Dim oWS As Worksheet

                Dim odlg As New OpenFileDialog
                odlg.ShowDialog()

                Dim f As New IO.FileInfo(odlg.FileName)


                oWBa = oApp.Workbooks.Open(odlg.FileName)
                oWS = oWBa.Sheets(1)
                oApp.Visible = False

                oWS.Range("B2").Value = "1"
                oWS.Range("C2").Value = "1"




                Dim pss As New Printing.PrinterSettings
                oWS.PrintOutEx(1, 1, 1, False, pss.PrinterName, False, pss.Collate, False, False)
                'If PGF Is Nothing Then PGF = New ProgressFrm

                'PGF.PGB.Value = 0
                'PGF.PGB.Maximum = 5
                'PGF.Show()
                ''Dim xlRange As Excel.Range

                'Dim dt As New DataTable
                'dt.Columns.Add("Time_ID", GetType(System.String))
                'dt.Columns.Add("Shift", GetType(System.String))
                'dt.Columns.Add("Station", GetType(System.String))
                'dt.Columns.Add("Time", GetType(System.DateTime))
                'dt.Columns.Add("Begin", GetType(System.DateTime))
                'dt.Columns.Add("End", GetType(System.DateTime))
                'dt.Columns.Add("Period", GetType(Double))
                '' dt.Columns.Add("Lenght", GetType(Integer))

                'Dim Cel As Object
                'Dim i As Integer
                ''For R = 1 To xlRange.Row
                'PGF.PGB.Value += 1

                'Cel = oWS.Range("B" & 3 & ":e" & 500).Value
                'i = 3

                'Dim Befid As String = ""
                'Dim DTime, sBegin, sEnd As DateTime
                'Dim Period As Double
                'For i = 3 To 500
                '    If oWS.Range("E" & i).Value Is Nothing Then Exit For
                '    If Not oWS.Range("B" & i).Value Is Nothing Then
                '        If Befid <> oWS.Range("B" & i).Value Then

                '            Befid = oWS.Range("B" & i).Value
                '            sBegin = Befid.Substring(0, 19)
                '            sEnd = Befid.Substring(Befid.Length - 19, 19)
                '            Period = DateDiff(DateInterval.Minute, sBegin, sEnd)
                '        End If

                '    End If

                '    If IsDate(oWS.Range("E" & i).Value) Then
                '        DTime = oWS.Range("E" & i).Value
                '    Else
                '        DTime = Nothing
                '    End If
                '    dt.Rows.Add(Befid, oWS.Range("C" & i & ":C" & i).Value, oWS.Range("D" & i).Value, DTime, sBegin, sEnd, Period)

                'Next
                'Return dt

                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End Using

        Catch ex As Exception
        Finally



            GC.Collect()
            GC.WaitForPendingFinalizers()

            If Not oWBa Is Nothing Then
                Marshal.FinalReleaseComObject(oWBa.Worksheets)

                oWBa.Close(False, Type.Missing, Type.Missing)

                Marshal.FinalReleaseComObject(oWBa)
            End If





            If Not oApp Is Nothing Then
                oApp.Quit()

                Marshal.FinalReleaseComObject(oApp)
            End If




        End Try
    End Sub
End Class
