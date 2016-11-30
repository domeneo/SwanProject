Public Class SlipNOfrm
    Dim dal As New dataACCcls
    Private Sub SlipNOfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtQABOI.Text = dal.ExScalar("select WE_NO from WENO", Project.md2_boi)
        txtQATAX.Text = dal.ExScalar("select WE_NO from WENO", Project.md2_tax)
        txtMABOI.Text = dal.ExScalar("select MA_NO from MANO", Project.md2_boi)
        txtMATAX.Text = dal.ExScalar("select MA_NO from MANO", Project.md2_tax)
        txtMBBOI.Text = dal.ExScalar("select MB_NO from MBNO", Project.md2_boi)
        txtMBTAX.Text = dal.ExScalar("select MB_NO from MBNO", Project.md2_tax)
    End Sub

    Private Sub btnQABOI_Click(sender As Object, e As EventArgs) Handles btnQABOI.Click
        dal.RunCommand("update WENO set WE_NO='" & txtQABOI.Text & "'", Project.md2_boi)
    End Sub

    Private Sub btnQATAX_Click(sender As Object, e As EventArgs) Handles btnQATAX.Click
        dal.RunCommand("update WENO set WE_NO='" & txtQATAX.Text & "'", Project.md2_tax)
    End Sub

    Private Sub btnMABOI_Click(sender As Object, e As EventArgs) Handles btnMABOI.Click
        dal.RunCommand("update MANO set MA_NO='" & txtMABOI.Text & "'", Project.md2_boi)
    End Sub

    Private Sub btnMATAX_Click(sender As Object, e As EventArgs) Handles btnMATAX.Click
        dal.RunCommand("update MANO set MA_NO='" & txtMATAX.Text & "'", Project.md2_tax)
    End Sub

    Private Sub btnMBBOI_Click(sender As Object, e As EventArgs) Handles btnMBBOI.Click
        dal.RunCommand("update MBNO set MB_NO='" & txtMBBOI.Text & "'", Project.md2_boi)
    End Sub

    Private Sub btnMBTAX_Click(sender As Object, e As EventArgs) Handles btnMBTAX.Click
        dal.RunCommand("update MBNO set MB_NO='" & txtMBTAX.Text & "'", Project.md2_tax)
    End Sub
End Class