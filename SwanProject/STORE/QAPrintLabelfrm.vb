Imports OfficeOpenXml
Imports System.IO
Public Class QAPrintLabelfrm

    Dim dataAcc As New dataACCcls
    Dim path As String
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel File|*.xlsx"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "QA Label"
        ' SaveFileDialog1.CheckFileExists = True
        If SaveFileDialog1.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub


        Dim sqlstr As String
        If DBCB.Text = "TAX" Then
            sqlstr = " Select STOCK_tax.S_PRE, STOCK_tax.S_PRDT, STOCK_tax.S_CSMR, PRDT_tax.P_ENAME, PRDT_tax.P_SPEC, STOCK_tax.S_QTY,PRDT_tax.P_UNIT,STOCK_tax.S_code"
            sqlstr = sqlstr + " FROM STOCK_tax INNER JOIN PRDT_tax On STOCK_tax.S_PRDT = PRDT_tax.P_PRDT"
            sqlstr = sqlstr + " GROUP BY STOCK_TAX.S_PRE, STOCK_TAX.S_PRDT, STOCK_TAX.S_CSMR, PRDT_tax.P_ENAME,PRDT_tax.P_SPEC,STOCK_tax.S_QTY,PRDT_tax.P_UNIT,STOCK_TAX.S_SLIP,STOCK_TAX.S_DATE,STOCK_tax.S_code"
            sqlstr = sqlstr + " HAVING STOCK_TAX.s_code >='" + txtCode.Text + "' AND STOCK_TAX.S_SLIP='we'"
        ElseIf DBCB.Text = "BOI" Then
            sqlstr = "SELECT STOCK_boi.S_PRE, STOCK_boi.S_PRDT, STOCK_boi.S_CSMR, PRDT_boi.P_ENAME, PRDT_boi.P_SPEC, STOCK_boi.S_QTY,PRDT_boi.P_UNIT,STOCK_boi.S_code"
            sqlstr = sqlstr + " FROM STOCK_boi INNER JOIN PRDT_boi ON STOCK_boi.S_PRDT = PRDT_boi.P_PRDT"
            sqlstr = sqlstr + " GROUP BY STOCK_boi.S_PRE, STOCK_boi.S_PRDT, STOCK_boi.S_CSMR, PRDT_boi.P_ENAME,PRDT_boi.P_SPEC,STOCK_boi.S_QTY,PRDT_boi.P_UNIT,STOCK_boi.S_SLIP,STOCK_boi.S_DATE,STOCK_boi.S_code"
            sqlstr = sqlstr + " HAVING STOCK_boi.s_code >='" + txtCode.Text + "' AND STOCK_boi.S_SLIP='we'"
        End If
        Dim frmprogress As New ProgressFrm
        frmprogress.Show()
        frmprogress.PGB.Maximum = 4
        frmprogress.PGB.Value = 0
        frmprogress.PGB.Value += 1
        frmprogress.Text = "Load"
        Dim dt As New DataTable
        dt = dataAcc.QryDT(sqlstr, Project.swanpath)


        frmprogress.PGB.Value += 1



        Using pck As New ExcelPackage()

            Dim ws As ExcelWorksheet = pck.Workbook.Worksheets.Add("Content")



            Dim Col As String = "B"
            Dim i As Integer = 1
            For Each dr As DataRow In dt.Rows

                For r = 0 To 6
                    With ws.Cells(Col & Trim(Str(i + r)))
                        ws.Row(i + r).Height = 31
                        .Style.Font.Name = "AngsanaUPC"
                        .Style.Font.Size = 16

                        ' If r = 4 Or r = 3 Then .Style.Font.Size = 10

                        .Style.Border.Bottom.Style = Style.ExcelBorderStyle.Thin

                    End With
                Next r


                ws.Cells(Col & Trim(Str(i))).Value = dr("s_pre").ToString
                ws.Cells(Col & Trim(Str(i + 1))).Value = dr("s_prdt").ToString
                ws.Cells(Col & Trim(Str(i + 2))).Value = dr("s_csmr").ToString
                ws.Cells(Col & Trim(Str(i + 3))).Value = dr("P_ENAME").ToString
                ws.Cells(Col & Trim(Str(i + 4))).Value = dr("P_SPEC").ToString
                ws.Cells(Col & Trim(Str(i + 4))).Style.ShrinkToFit = True
                ws.Cells(Col & Trim(Str(i + 5))).Style.ShrinkToFit = True
                ws.Cells(Col & Trim(Str(i + 5))).Value = dr("s_qty").ToString & dr("P_UNIT").ToString
                ws.Cells(Col & Trim(Str(i + 5))).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                ws.Cells(Col & Trim(Str(i + 6))).Value = txtreciever.Text

                ws.Row(i + 7).Height = 10

                Dim colstr As String = Chr(Asc(Col) - 1) & Trim(Str(i) - 1) & ":" & Chr(Asc(Col) + 1) & Trim(Str(i + 7))

                With ws.Cells(colstr)
                    .Style.Border.BorderAround(Style.ExcelBorderStyle.Dashed)
                    '.Style.Border.Bottom.Style = Style.ExcelBorderStyle.Dashed
                    '.Style.Border.Left.Style = Style.ExcelBorderStyle.Dashed
                    '.Style.Border.Top.Style = Style.ExcelBorderStyle.Dashed

                    '.Style.Border.Right.Style = Style.ExcelBorderStyle.Dashed

                End With




                Col = Chr(Asc(Col) + 3)
                If Col = "K" Then
                    Col = "B"
                    i = i + 8
                End If


                '.Range(A & Trim(Str(i))) = rs!s_pre
                '.Range(A & Trim(Str(i + 1))) = rs!s_prdt
                '.Range(A & Trim(Str(i + 2))) = rs!s_csmr
                '.Range(A & Trim(Str(i + 3))) = rs!P_ENAME
                '.Range(A & Trim(Str(i + 4))) = rs!P_SPEC
                '.Range(A & Trim(Str(i + 5))) = rs!s_qty & " " & rs!P_UNIT
                '.Range(A & Trim(Str(i + 5))).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                '.Range(A & Trim(Str(i + 6))) = txtreciever.Text
                '.Range(A & Trim(Str(i + 7))).RowHeight = 10



            Next

            ws.Column(1).Width = 0.5
            ws.Column(2).Width = 24
            ws.Column(3).Width = 0.5
            ws.Column(4).Width = 0.5
            ws.Column(5).Width = 24
            ws.Column(6).Width = 0.5
            ws.Column(7).Width = 0.5
            ws.Column(8).Width = 24
            ws.Column(9).Width = 0.5
            Dim newFile As New FileInfo(SaveFileDialog1.FileName)
            pck.SaveAs(newFile)
            frmprogress.Close()

            MsgBox("Complete")
        End Using




    End Sub

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged

    End Sub
End Class