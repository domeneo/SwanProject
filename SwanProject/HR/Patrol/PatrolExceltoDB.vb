Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Linq

Public Class PatrolExceltoDB
    Dim oWBa As Excel.Workbook
    Dim oWS As Excel.Worksheet
    Dim oApp As Excel.Application
    Dim ReadROW As Integer = 2000
    Dim ReadCol As Integer = 100
    Dim sqlstr, LOT, Model, LINE As String
    'Dim Plan, Speed, TOTAL, rSpeed, JIG, QC As Double
    Dim startTime, EndTime As DateTime

    Dim EndCol As Integer

    Dim RunningNum As Integer
    Dim PlanDate As Date
    Dim PGF As New ProgressFrm

    '  Dim DAL As New DB.SqlConnect
    '   Dim SQL_Conn As SqlConnection

    'Dim R As Integer
    Function RunChar(ByVal i As Integer) As String
        Dim B, F As Integer
        'If Int(i / 27) > 0 Then B = i Mod (26) Else B = i Mod (27)
        B = i Mod (26)
        F = Int(i / 26)
        RunChar = IIf(F > 0, Chr(F + 64), "") & Chr(B + 65)
        'RunChar = str(F) & str(B)

    End Function

    Function GetWorksheetName(ByVal PathExcel As String) As DataTable

        Dim oApp As New Excel.Application

        Dim oWBa As Excel.Workbook
        Try
            Dim dt As New DataTable
            If Not PathExcel.ToUpper.Contains(".XLS") Then
                MsgBox("Upload Excel file only")
                Return dt

                Exit Function
            End If
            oWBa = oApp.Workbooks.Open(PathExcel)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US") 'doesn't help


            dt.Columns.Add("WsID")
            dt.Columns.Add("Wsname")
            Dim i As Integer = 1
            For Each ws As Excel.Worksheet In oWBa.Sheets

                dt.Rows.Add(i, ws.Name)
                i = i + 1
            Next
            Return dt
            dt = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ReleaseComObject(oWS)
            oWBa.Close(SaveChanges:=False)
            ReleaseComObject(oWBa)

            oApp.Quit()
            ReleaseComObject(oApp)
            GC.Collect()
        End Try


    End Function
    Function LoadExcel(ByVal PathExcel As String, ByVal Sheetindex As Integer)
        Try
            If Not PathExcel.ToUpper.Contains(".XLS") Then
                MsgBox("Upload Excel file only")
                Exit Function
            End If


            'Dim strUp As String = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties='Excel 8.0;HDR=YES';Data Source=" & PathExcel & ";"
            'connXls = New OleDbConnection(strUp)
            'Dim dt As New DataTable
            'dt = dtc.ExReader(connXls, "select * from [" & Sheetname & "$]")

            'Dim Fmanual As String
            'For Each dc As DataColumn In dt.Columns
            '    If Not Fmanual.Contains(dc.ColumnName) Then
            '        MsgBox("ชื่อColumn ไม่ถูกต้อง", , "error")
            '        Exit Sub
            '    End If

            'Next


            ' DAL.GetExecute("delete from SORAYA_ALC022P", SQL_Conn)

            Dim oldCI As System.Globalization.CultureInfo = _
         System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = _
                New System.Globalization.CultureInfo("en-US")




            If oApp Is Nothing Then
                oApp = New Excel.Application
            End If




            oWBa = oApp.Workbooks.Open(PathExcel)
            oWS = oWBa.Sheets(Sheetindex)
            oApp.Visible = False
            'MsgBox(oWS.Cells(2, 1)) 'Return err: Argument converted to type 'String'
            'MsgBox(oWS.Cells(2, 1).ToString) ' <---- Return : System.__Comobjec

            ' Dim oRng As Excel.Range

            ' oRng = oWS.Range("A8")


            'PlanDate = oWS.Range("I6").Value
            'LINE = "AF05"
            'style.Interior.Color = Color.Yellow
            'oWS.Range("G1").Style = style
            'style = oWS.Range("G10").Interior.Color
            ' Debug.Print(style.Interior.Color)
            'style.Interior.Color.ToString()
            'ColorTranslator.FromOle(style.Interior.Color)
            ' Debug.Print(ColorTranslator.ToOle(style.Interior.Color))
            RunningNum = 1


            If PGF Is Nothing Then PGF = New ProgressFrm

            PGF.PGB.Value = 0
            PGF.PGB.Maximum = 5
            PGF.Show()
            'Dim xlRange As Excel.Range

            Dim dt As New DataTable
            dt.Columns.Add("Time_ID", GetType(System.String))
            dt.Columns.Add("Shift", GetType(System.String))
            dt.Columns.Add("Station", GetType(System.String))
            dt.Columns.Add("Time", GetType(System.DateTime))
            dt.Columns.Add("Begin", GetType(System.DateTime))
            dt.Columns.Add("End", GetType(System.DateTime))
            dt.Columns.Add("Period", GetType(Double))
            ' dt.Columns.Add("Lenght", GetType(Integer))

            Dim Cel As Object
            Dim i As Integer
            'For R = 1 To xlRange.Row
            PGF.PGB.Value += 1

            Cel = oWS.Range("B" & 3 & ":e" & 500).Value
            i = 3

            Dim Befid As String = ""
            Dim DTime, sBegin, sEnd As DateTime
            Dim Period As Double
            For i = 3 To 500
                If oWS.Range("E" & i).Value Is Nothing Then Exit For
                If Not oWS.Range("B" & i).Value Is Nothing Then
                    If Befid <> oWS.Range("B" & i).Value Then

                        Befid = oWS.Range("B" & i).Value
                        sBegin = Befid.Substring(0, 19)
                        sEnd = Befid.Substring(Befid.Length - 19, 19)
                        Period = DateDiff(DateInterval.Minute, sBegin, sEnd)
                    End If

                End If

                If IsDate(oWS.Range("E" & i).Value) Then
                    DTime = oWS.Range("E" & i).Value
                Else
                    DTime = Nothing
                End If
                dt.Rows.Add(Befid, oWS.Range("C" & i & ":C" & i).Value, oWS.Range("D" & i).Value, DTime, sBegin, sEnd, Period)

            Next
            Return dt

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI


            '  MsgBox("โหลดข้อมูลสำเร็จ")

        Catch ex As Exception
            MsgBox(ex.Message)


        Finally
            ReleaseComObject(oWS)
            oWBa.Close(SaveChanges:=False)
            ReleaseComObject(oWBa)
            PGF.Hide()
            oApp.Quit()
            ReleaseComObject(oApp)
            GC.Collect()
        End Try


    End Function

    Private Sub ReleaseComObject(ByRef Reference As Object)
        Try
            Do Until _
             System.Runtime.InteropServices.Marshal.ReleaseComObject(Reference) <= 0
            Loop
        Catch
        Finally
            Reference = Nothing
        End Try
    End Sub
    Function ConvertLOT(ByVal LOTname As String)
        Do While LOTname.Length < 3
            LOTname = "0" & LOTname

        Loop
        Return LOTname
    End Function



    Function Numtocol(ByVal num As Integer) As String

        Dim str As String = ""
        If num < 26 Then
            str = str & Chr(num Mod 26 + 64)
        Else
            str = Chr(num / 26 + 64)
            str = str & Chr(num Mod 26 + 64)
        End If

        Return str
    End Function
End Class


