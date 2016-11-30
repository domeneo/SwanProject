Public Class LockLOTfrm
    Dim dtacc As New dataACCcls
    Dim connstr As String
    Function LoadData(Optional strWhere As String = "")
        Dim sqlstr As String


        If DBCB.Text = "BOI" Then
            connstr = Project.md7_boi
        Else
            connstr = Project.md7_tax

        End If
        Dim dt As New DataTable
        sqlstr = "select mc_date,mc_lot,mc_close,mc_lock from LOT"
        sqlstr += strWhere
        sqlstr += " order by mc_date desc"
        dt = dtacc.QryDT(sqlstr, connstr)
        Return dt
    End Function
    Private Sub LockLOTfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Sub UpdateLock(value As String, fromDate As String, toDate As String, Optional inlot As String = "")
        Dim sqlstr As String

        If DBCB.Text = "BOI" Then
            connstr = Project.md7_boi
        Else
            connstr = Project.md7_tax

        End If

        If inlot <> "" Then
            'Dim tmptable As String = "tempLOCKLOT" & Project.User
            'If dtacc.ExistsTable(tmptable, connstr) = False Then
            '    dtacc.RunCommand("Create Table " & tmptable & " (LOT CHAR)", connstr)
            'Else
            '    dtacc.RunCommand("delete * from " & tmptable, connstr)

            'End If
            'For Each str As String In inlot.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            '    If str = "" Then Continue For
            '    dtacc.RunCommand(" insert into " & tmptable & "(LOT) values('" & str & "')", connstr)

            'Next

            'sqlstr = "update LOT inner join  " & tmptable & " on lot.mc_lot=" & tmptable & ".LOT set mc_lock=" & value
            'dtacc.RunCommand(sqlstr, connstr)
            'dtacc.RunCommand("drop table " & tmptable, connstr)


            inlot = "'" & inlot.Trim.Replace(vbCrLf, "','") & "'"
            sqlstr = "update LOT set mc_lock=" & value & " where mc_lot in (" & inlot & ")"
            dtacc.RunCommand(sqlstr, connstr)



        Else

            If txtFromDate.Text = "" Then

                sqlstr = "update LOT set mc_lock=" & value
            Else
                sqlstr = "update LOT Set mc_lock=" & value & " where mc_date between '" & txtFromDate.Text & "' and '" & txtTodate.Text & "'"

        End If



            dtacc.RunCommand(sqlstr, connstr)

        End If


    End Sub
    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        UpdateLock("1", txtFromDate.Text, txtTodate.Text, txtInlot.Text)
        DGV1.DataSource = LoadData()
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        UpdateLock("0", txtFromDate.Text, txtTodate.Text, txtInlot.Text)
        DGV1.DataSource = LoadData()
    End Sub

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged
        DGV1.DataSource = LoadData()
    End Sub

    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles ShowBtn.Click
        Dim inlot As String = txtInlot.Text

        If inlot <> "" Then
            inlot = "'" & inlot.Trim.Replace(vbCrLf, "','") & "'"
            DGV1.DataSource = LoadData(" where mc_lot in (" & inlot & ") ")
        Else

            If txtFromDate.Text = "" Then
                DGV1.DataSource = LoadData()
            Else

                DGV1.DataSource = LoadData(" where mc_date between '" & txtFromDate.Text & "' and '" & txtTodate.Text & "'")
            End If

        End If
    End Sub
End Class