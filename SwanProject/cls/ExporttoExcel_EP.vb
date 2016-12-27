Imports OfficeOpenXml
Imports System.IO
Public Class ExporttoExcel_EP
    '   Private Static ExcelWorksheet CreateSheet(ExcelPackage p, String sheetName)
    '{
    '   p.Workbook.Worksheets.Add(sheetName);
    '   ExcelWorksheet ws = p.Workbook.Worksheets[1];
    '   ws.Name = sheetName; //Setting Sheet's name
    '   ws.Cells.Style.Font.Size = 11; //Default font size for whole sheet
    '   ws.Cells.Style.Font.Name = "Calibri"; //Default Font name for whole sheet

    '   Return ws;
    '}
    Sub CreateSheet(DT As DataTable, path As String, Optional Headtext As String = "")


        '   Dim R As Integer = 0
        ' Dim StrAR(DT.Rows.Count, DT.Columns.Count) As String.

        'Dim StrAR = New List(Of Object())

        'Dim obj(DT.Columns.Count) As Object
        'obj(DT.Columns.Count) = New Object
        'For Each dc As DataColumn In DT.Columns


        '    obj(R) = dc.ColumnName



        '    R += 1
        'Next
        'StrAR.Add(obj)
        'For Each dr As DataRow In DT.Rows
        '    ' obj = ""

        '    'obj() = New Object
        '    For i = 0 To DT.Columns.Count - 1
        '        '  StrAR(R, i) = dr(i).ToString
        '    obj(i) = dr(i).ToString

        '    Next

        '    StrAR.Add(New Object() {})

        'Next
        Dim newFile As New FileInfo(path)
        Using pck As New ExcelPackage()


            'pck.File.Create()
            Dim ws As ExcelWorksheet = pck.Workbook.Worksheets.Add("Content")


            Dim str As String
            'ws.View.ShowGridLines = False

            ' ws.Cells("A3:" & RunChar(DT.Columns.Count - 1) & DT.Rows.Count + 2).Value = StrAR
            ' ws.Cells("A3").Value = StrAR

            ws.Cells("A1").Value = Headtext
            ws.Cells("A2").LoadFromDataTable(DT, True)
            pck.SaveAs(newFile)

        End Using
    End Sub
    Function RunChar(ByVal i As Integer) As String
        Dim B, F As Integer
        'If Int(i / 27) > 0 Then B = i Mod (26) Else B = i Mod (27)
        B = i Mod (26)
        F = Int(i / 26)
        RunChar = IIf(F > 0, Chr(F + 64), "") & Chr(B + 65)
        'RunChar = str(F) & str(B)

    End Function

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
    Sub WriteExcel()

        Dim path As String
        Dim fileinfo As New FileInfo(path)
        If fileinfo.Exists = False Then
            MsgBox("File not Exist")
            Exit Sub
        End If
        Using pakage As New ExcelPackage(fileinfo)
            Dim ws As ExcelWorksheet = pakage.Workbook.Worksheets(0)
            ws.Cells(1, 1).Value = "sad"
            ws.Cells(2, 1).Value = "Dad"
            ws.Cells(3, 1).Value = "Dad"
            pakage.Save()

        End Using

    End Sub

End Class
