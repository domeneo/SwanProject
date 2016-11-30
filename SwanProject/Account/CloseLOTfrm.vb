Public Class CloseLOTfrm
    Dim dtacc As New dataACCcls
    Dim Connstr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\server\siamvb\lot9.mdb;Jet OLEDB:Database Password=lot9"

    Dim dt As New DataTable

    Function Loaddata()
        Dim frmprogress As New ProgressFrm
        frmprogress.Show()
        frmprogress.PGB.Maximum = 3
        frmprogress.PGB.Value = 0

        Try



            Dim sqlstr As String
            sqlstr = "SELECT MC_DATE, MC_PRED, MC_DEPT, MC_LOT, MC_CLOSE as Close_B,Maxdate as Lastwe, [LOT].[CLOSE] as Close_A,lot.lot_date, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, P_ENAME, P_SPEC"
            sqlstr = sqlstr + " FROM ([LOT] RIGHT JOIN (PRDT" & DBCB.Text & " RIGHT JOIN LOT" & DBCB.Text & " ON PRDT" & DBCB.Text & ".P_PRDT = LOT" & DBCB.Text & ".MC_PRDT_THAI) ON [LOT].[LOT] = LOT" & DBCB.Text & ".MC_LOT) left join Lastwe_" & DBCB.Text & " on Lastwe_" & DBCB.Text & ".s_pre=LOT" & DBCB.Text & ".MC_LOT"
            sqlstr = sqlstr + " WHERE ((MC_DATE)>='20080101') AND ([LOT].DB='" & DBCB.Text & "' or LOT.DB is null)"
            sqlstr += " ORDER BY MC_DATE"
            dt = dtacc.QryDT(sqlstr, Connstr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            frmprogress.Close()
        End Try

    End Function
    Private Sub CloseLOTfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Sub UpdateLotState(LotState As String)

        If MsgBox("ต้องการเปลี่ยนสถานะ LOT หรือไม่", vbYesNo) = vbNo Then Exit Sub
        Dim frmprogress As New ProgressFrm
        frmprogress.Show()
        frmprogress.PGB.Maximum = 3
        frmprogress.PGB.Value = 0


        frmprogress.PGB.Value += 1
        'sqlstr = "select * from LOT"
        'OpenRS sqlstr, rs3, conn

        Dim lotDate As String
        Dim sqlstr As String
        'lotDate = InputBox("Input date change lot state.", "Please input date")



        lotDate = Now.ToString("yyyyMMdd")


        Dim inlot As String = "'" & txtInlot.Text.Trim.Replace(vbCrLf, "','") & "'"


        If LotState = 9 Then

            sqlstr = "delete * from MAFILE_BOI where MA_CODE in (" & inlot & ")"
            'dtacc.RunCommand(sqlstr, Connstr)

            sqlstr = "delete * from MAFILE_TAX where MA_CODE in (" & inlot & ")"
            ' dtacc.RunCommand(sqlstr, Connstr)
        End If


        sqlstr = "Update LOT" & DBCB.Text
        sqlstr += " set MC_CLOSE='" & LotState & "'"
        sqlstr += " Where MC_LOT  in (" & inlot & ")"
        dtacc.RunCommand(sqlstr, Connstr)


        sqlstr = "delete * from lot where lot in (" & inlot & ") and DB like '" & DBCB.Text & "'"
        dtacc.RunCommand(sqlstr, Connstr)

        For Each str As String In txtInlot.Text.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            If str = "" Then Continue For





            'If rs3.EOF Then
            sqlstr = "Insert into LOT ([lot],[close],[DB],[lot_date]) values ('" & str & "','" & LotState & "','" & DBCB.Text & "','" & lotDate & "')"
            dtacc.RunCommand(sqlstr, Connstr)
            'Else




        Next


        DGV1.DataSource = Loaddata()
        lblcount.Text = "จำนวน : " & DGV1.RowCount
        frmprogress.Close()
    End Sub

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged
        DGV1.DataSource = Loaddata()
        lblcount.Text = "จำนวน : " & DGV1.RowCount
    End Sub

    Private Sub Findbtn_Click(sender As Object, e As EventArgs) Handles Findbtn.Click


        Dim sqlwhere As String = ""

        If txtFlot.Text <> "" Then
            sqlwhere = " AND MC_LOT like '" & txtFlot.Text & "%'"

        End If
        Dim Fclose As String = ""

        If CBLot5.Checked Then
            Fclose += " OR close_B ='5'"
        End If
        If cbLot7.Checked Then
            Fclose += " OR close_B ='7'"
        End If
        If cbLot9.Checked Then
            Fclose += " OR close_B ='9'"
        End If

        If Fclose <> "" Then

            Fclose = " AND (" & Fclose.Substring(3, Fclose.Length - 3) & ")"
            sqlwhere += Fclose
        End If


        If sqlwhere <> "" Then
            sqlwhere = "" & sqlwhere.Substring(4, sqlwhere.Length - 4) & ""
            Try
                DGV1.DataSource = dt.Select(sqlwhere).CopyToDataTable
            Catch ex As Exception
                DGV1.DataSource = Nothing
            End Try


            lblcount.Text = "จำนวน : " & DGV1.RowCount
        End If


    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel File|*.xls"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "CloseLOT"

        SaveFileDialog1.ShowDialog(Me)


        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        Dim excelexp As New ExporttoExcel_EP

        ' Dim dv As DataView = DGV1.DataSource

        excelexp.CreateSheet(DGV1.DataSource, SaveFileDialog1.FileName, "CloseLOT")
    End Sub

    Private Sub btnTo5_Click(sender As Object, e As EventArgs) Handles btnTo5.Click
        UpdateLotState("5")
    End Sub

    Private Sub btnto7_Click(sender As Object, e As EventArgs) Handles btnto7.Click
        UpdateLotState("7")
    End Sub

    Private Sub btnTo9_Click(sender As Object, e As EventArgs) Handles btnTo9.Click
        UpdateLotState("9")
    End Sub
End Class