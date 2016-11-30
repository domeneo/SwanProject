Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Linq

Public Class ExceltoDB
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

    Dim DAL As New dataACCcls
    Dim SQL_Conn As SqlConnection

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
    Function stringtoNumber(str)
        Return Asc(str) - 65
    End Function
    Sub LoadExcel(ByVal PathExcel As String, ByVal Sheetindex As Integer, ByVal Sheetname As String, ByVal lotCol As String, ByVal prdtCol As String, ByVal noteCol As String, DB As String)
        Try
            If Not PathExcel.ToUpper.Contains(".XLS") And Not Not PathExcel.ToUpper.Contains(".XLSX") Then
                MsgBox("Upload Excel file only")
                Exit Sub
            End If



            Dim oldCI As System.Globalization.CultureInfo =
         System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture =
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

            Dim dtHead, dtData, dtResult As New DataTable
            Dim cnRange As String = "provider=Microsoft.Jet.OLEDB.4.0; " &
    "data source='" & PathExcel.Replace("'", "''") & "';" &
    "Extended Properties=""Excel 8.0; IMEX=1; HDR=Yes;"""

            Using MyConnection As New System.Data.OleDb.OleDbConnection(cnRange)


                MyConnection.Open()

                Using cmd As OleDbCommand = New OleDbCommand(
     "SELECT * FROM [" & Sheetname & "$a2:" & noteCol & "8000]", MyConnection)
                    Dim dr2 As System.Data.IDataReader = cmd.ExecuteReader
                    dtData.Load(dr2)
                End Using
            End Using




            dtResult = dtData.Clone


            For Each dr As DataRow In dtData.Rows


                If dr(stringtoNumber(noteCol)).ToString <> "" Then
                    dtResult.Rows.Add(dr.ItemArray)

                End If
            Next
            Dim connstr As String
            If DB = "BOI" Then
                connstr = Project.md7_boi
            Else
                connstr = Project.md7_tax
            End If
            For Each dr As DataRow In dtResult.Rows
                Dim sqlstr As String

                sqlstr = "update BOMFILE set b_note='" & dr(stringtoNumber(noteCol)).ToString() & "' where b_lot='" & dr(stringtoNumber(lotCol)).ToString() & "' and b_scode='" & dr(stringtoNumber(prdtCol)).ToString() & "'"



                If DAL.RunCommand(sqlstr, connstr) < 1 Then

                    sqlstr = "insert into BOMFILE (b_note,b_lot,b_scode) values('" & dr(stringtoNumber(noteCol)).ToString() & "','" & dr(stringtoNumber(lotCol)).ToString() & "','" & dr(stringtoNumber(prdtCol)).ToString() & "')"
                    DAL.RunCommand(sqlstr, connstr)
                End If

            Next
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI


            MsgBox("โหลดข้อมูลสำเร็จ")

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


    End Sub

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


