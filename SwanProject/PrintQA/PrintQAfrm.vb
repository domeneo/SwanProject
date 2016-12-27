Imports CrystalDecisions.CrystalReports.Engine
Imports OfficeOpenXml
Imports System.IO
Public Class PrintQAfrm
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click


        Dim pgbfrm As New ProgressFrm
        pgbfrm.Show()

        Try
            pgbfrm.Text = "Loading..."
            pgbfrm.PGB.Value = 0
            pgbfrm.PGB.Maximum = 4
            pgbfrm.PGB.Value += 1
            Dim rpt As New ReportFrm
            Dim rpt_M As New PrintQA_310
            Dim rpt_s As New PrintQA_S_310

            Dim sqlstr As String


            If RB_M.Checked Then

                sqlstr = "SELECT MC_REA, MC_LOT, MC_DEPT, P_PLACE, MC_PRDT, MC_QTY, MC_LOTQTY, P_ENAME, P_SPEC, MC_DATE, MC_PRED, p_unit" +
" FROM PRDT_" & DBCB.Text & " RIGHT JOIN LOT_" & DBCB.Text & " ON PRDT_" & DBCB.Text & ".P_PRDT = LOT_" & DBCB.Text & ".MC_PRDT "

            ElseIf RB_S.Checked Then

                sqlstr = "SELECT WE_REA, WE_CODE, WE_SUP, S_NAME, P_PLACE, WE_USE, WE_PDATE, P_ENAME, P_TNAME, P_SPEC, P_UNIT, WE_QTY, WE_DQTY, [WE_QTY]-[WE_DQTY] AS useQTY, WE_PRDT" +
    " FROM (ODFILE_" & DBCB.Text & " LEFT JOIN PRDT_" & DBCB.Text & " ON ODFILE_" & DBCB.Text & ".WE_PRDT = PRDT_" & DBCB.Text & ".P_PRDT) LEFT JOIN SUPMAST_" & DBCB.Text & " ON ODFILE_" & DBCB.Text & ".WE_SUP = SUPMAST_" & DBCB.Text & ".S_SUP"
            ElseIf RB_C.Checked Then
                sqlstr = "SELECT 'D' as we_rea, C_LOT as WE_CODE, c_sup as WE_SUP, S_NAME, P_PLACE,'' as WE_USE,c_date as  WE_PDATE, P_ENAME, P_TNAME, P_SPEC, P_UNIT,'' as  WE_QTY,'' as  WE_DQTY, c_qty AS useQTY, c_prdt as WE_PRDT" +
    " FROM (claim LEFT JOIN PRDT_" & DBCB.Text & " ON claim.c_PRDT = PRDT_" & DBCB.Text & ".P_PRDT) LEFT JOIN SUPMAST_" & DBCB.Text & " ON claim.c_sup = SUPMAST_BOI.S_SUP"


            End If


            ' sqlstr += " where mc_lot in '4C2804'"

            If cbNotPrint.Visible And cbNotPrint.Checked Then
                sqlstr += " where mc_close =''"
            Else
                ' txtCode.Text = txtCode.Text.Replace(vbCrLf, "")
                If txtCode.Text = "" Then

                    MsgBox("กรุณาใส่ข้อมูล")
                    Exit Sub
                End If


                Dim inLot As String = "'" & txtCode.Text.Trim.Replace(vbCrLf, "','") & "'"


                If RB_M.Checked Then
                    sqlstr += " where mc_lot in (" & inLot & ")"
                ElseIf RB_S.Checked Then
                    sqlstr += " where WE_CODE in (" & inLot & ")"
                ElseIf RB_C.Checked Then
                    sqlstr += " where c_lot in (" & inLot & ")"
                End If

            End If
            pgbfrm.PGB.Value += 1
            Dim dtc As New dataACCcls
            Dim dt As New DataTable
            dt = dtc.QryDT(sqlstr, Project.swanpath)
            'dtc.conn = conn
            'dtc.QryDT("select * from cer order by serial")
            'If TypeOf GV1.Rows(0).Cells("MaxAllow").Value Is DBNull Or GV1.Rows(0).Cells("MaxAllow").Value = "" Then


            '    DirectCast(testrpt.ReportDefinition.ReportObjects("txt10412"), TextObject).Text = ""


            'End If
            If dt.Rows.Count = 0 Then

                MsgBox("No Data")
                Exit Sub
            End If


            If txtCode.Text.Contains(vbCrLf) Then
                Dim LOTcol As String
                If RB_M.Checked Then
                    LOTcol = "MC_LOT"
                Else
                    LOTcol = "WE_CODE"
                End If
                Dim dttemp As New DataTable
                dttemp = dt.Clone
                For Each str As String In txtCode.Text.Split(vbCrLf)
                    For Each dr In dt.Select(LOTcol & " ='" & str.Replace(vbLf, "") & "'")
                        dttemp.Rows.Add(dr.ItemArray)

                    Next
                Next
                dt = dttemp.Copy
            End If


            pgbfrm.PGB.Value += 1

            ' Dim pDiag As New PrintDialog


            'If pDiag.ShowDialog() = DialogResult.Cancel Then
            '    Exit Sub
            'End If
            Dim rawKind As Integer
            Dim pss As New Printing.PrinterSettings
            For Each ps As Printing.PaperSize In pss.PaperSizes
                If ps.Width = 860 And ps.Height = 550 Then
                    rawKind =
CInt(ps.GetType().GetField("kind",
Reflection.BindingFlags.Instance Or
Reflection.BindingFlags.NonPublic).GetValue(ps))
                    Exit For
                End If
            Next



            If RB_M.Checked Then
                DirectCast(rpt_M.ReportDefinition.ReportObjects("txtSWAN1"), TextObject).Text = "SWAN " & DBCB.Text & " STOCK"
                DirectCast(rpt_M.ReportDefinition.ReportObjects("txtSWAN2"), TextObject).Text = "SWAN " & DBCB.Text & " STOCK"
                rpt_M.SetDataSource(dt)


                ' rpt_M.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                '  rpt_M.PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
                rpt_M.PrintOptions.PaperSize = rawKind
                rpt_M.PrintOptions.PrinterName = pss.PrinterName
                rpt_M.PrintToPrinter(0, False, 0, 0)
                ' rpt.RPTview.ReportSource = rpt_M

            Else
                '  DirectCast(rpt_M.ReportDefinition.ReportObjects("txtSWAN1"), TextObject).Text = "SWAN" & DBCB.Text & "STOCK"
                '  DirectCast(rpt_M.ReportDefinition.ReportObjects("txtSWAN2"), TextObject).Text = "SWAN" & DBCB.Text & "STOCK"
                rpt_s.SetDataSource(dt)

                rpt_s.PrintOptions.PaperSize = rawKind
                rpt_s.PrintOptions.PrinterName = pss.PrinterName
                rpt_s.PrintToPrinter(1, False, 0, 0)
                ' rpt.RPTview.ReportSource = rpt_s
            End If



            'rpt.ShowDialog(Me)
            If cbNotPrint.Visible And cbNotPrint.Checked Then

                sqlstr = "update lot_" & DBCB.Text & " set mc_close=5 where mc_close=''"
                dtc.RunCommand(sqlstr, Project.swanpath)
            End If
            dt.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            pgbfrm.Close()
        End Try
    End Sub
    Sub ChangeBG()
        If RB_M.Checked Then
            Me.BackColor = Color.White
            cbNotPrint.Visible = True
        Else
            Me.BackColor = Color.LightGray
            cbNotPrint.Visible = False
        End If
    End Sub
    Private Sub RB_M_CheckedChanged(sender As Object, e As EventArgs) Handles RB_M.CheckedChanged
        ChangeBG()
    End Sub

    Private Sub RB_S_CheckedChanged(sender As Object, e As EventArgs) Handles RB_S.CheckedChanged
        ChangeBG()
    End Sub

    Private Sub btnPrintLabel_Click(sender As Object, e As EventArgs) Handles btnPrintLabel.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel File|*.xlsx"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "QA Label"
        ' SaveFileDialog1.CheckFileExists = True
        If SaveFileDialog1.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub

        Dim dtc As New dataACCcls
        Dim inLot As String = "'" & txtCode.Text.Trim.Replace(vbCrLf, "','") & "'"
        Dim sqlstr As String

        sqlstr = "SELECT mc_lot as LOT,mc_prdt as PRDT,mc_lotqty-mc_qty as qty,P_ENAME,p_spec,P_UNIT,mc_dept as sup "
        sqlstr = sqlstr + " FROM lot_" & DBCB.Text & " INNER JOIN PRDT_" & DBCB.Text & " On lot_" & DBCB.Text & ".mc_PRDT = PRDT_" & DBCB.Text & ".P_PRDT"
        sqlstr = sqlstr + " where  mc_Lot in (" & inLot & ")"

        sqlstr += " union "
        sqlstr += "SELECT we_code as LOT,we_prdt as PRDT,we_qty-we_dqty as qty,P_ENAME,p_spec,P_UNIT ,s_name as sup"
        sqlstr = sqlstr + " FROM (odfile_" & DBCB.Text & " INNER JOIN PRDT_" & DBCB.Text & " On odfile_" & DBCB.Text & ".we_PRDT = PRDT_" & DBCB.Text & ".P_PRDT"

        sqlstr += ") LEFT JOIN SUPMAST_" & DBCB.Text & " ON ODFILE_" & DBCB.Text & ".WE_SUP = SUPMAST_" & DBCB.Text & ".S_SUP"
        sqlstr = sqlstr + " where  we_code in (" & inLot & ")"


        Dim frmprogress As New ProgressFrm
        frmprogress.Show()
        frmprogress.PGB.Maximum = 4
        frmprogress.PGB.Value = 0
        frmprogress.PGB.Value += 1
        frmprogress.Text = "Load"
        Dim dt As New DataTable
        dt = dtc.QryDT(sqlstr, Project.swanpath)


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


                ws.Cells(Col & Trim(Str(i))).Value = dr("LOT").ToString
                ws.Cells(Col & Trim(Str(i + 1))).Value = dr("prdt").ToString
                If dr("sup").ToString.Length > 25 Then
                    ws.Cells(Col & Trim(Str(i + 2))).Value = dr("sup").ToString.Substring(0, 25)
                Else
                    ws.Cells(Col & Trim(Str(i + 2))).Value = dr("sup").ToString
                End If
                ws.Cells(Col & Trim(Str(i + 2))).Style.ShrinkToFit = True
                ws.Cells(Col & Trim(Str(i + 3))).Value = dr("P_ENAME").ToString
                ws.Cells(Col & Trim(Str(i + 4))).Value = dr("P_SPEC").ToString
                ws.Cells(Col & Trim(Str(i + 3))).Style.ShrinkToFit = True
                ws.Cells(Col & Trim(Str(i + 4))).Style.ShrinkToFit = True
                ws.Cells(Col & Trim(Str(i + 5))).Style.ShrinkToFit = True
                ws.Cells(Col & Trim(Str(i + 5))).Value = dr("QTY").ToString & dr("P_UNIT").ToString
                ws.Cells(Col & Trim(Str(i + 5))).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                ws.Cells(Col & Trim(Str(i + 6))).Value = Now.ToString("yyyyMMdd")

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
End Class