Public Class WIPNOTE_EXCEL

    Dim ExToDb As New ExceltoDB
    Private Sub BrownsBtn_Click(sender As Object, e As EventArgs) Handles BrownsBtn.Click
        OpenDLG1.Filter = "Excel files|*.xls;*.xlsx"
        OpenDLG1.ShowDialog()
    End Sub

    Private Sub OpenDLG1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenDLG1.FileOk
        txtUpload.Text = OpenDLG1.FileName
        WSCB.DataSource = ExToDb.GetWorksheetName(txtUpload.Text)
        WSCB.ValueMember = "WsID"
        WSCB.DisplayMember = "WsName"
    End Sub

    Private Sub Uploadbtn_Click(sender As Object, e As EventArgs) Handles Uploadbtn.Click
        ExToDb.LoadExcel(txtUpload.Text, WSCB.SelectedValue, WSCB.Text, txtLOTcol.Text, txtPrdtCol.Text, txtNotecol.Text, CBDB.Text)
    End Sub

    Private Sub WSCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WSCB.SelectedIndexChanged
        If WSCB.Text.Contains("BOI") Then
            CBDB.Text = "BOI"
        ElseIf WSCB.Text.Contains("TAX") Then
            CBDB.Text = "TAX"
        End If
    End Sub
End Class