Imports System.Data.OleDb
Public Class StockCard
    Dim dt As New DataTable
    Dim dtc As New datacls
    Dim Errlg As New ErrorLogger
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\server\siamvb\swan.mdb")
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtc.QryDT(conn, "select p_sprdt from prdt_boi order by p_prdt")
            ' AutoCompleteTextBox(TextBox1, dtc.dt)


            dtc.QryDT(conn, "select mc_lot from lot_boi where mc_close<>'9' order by mc_lot")
            ' AutoCompleteTextBox(TextBox2, dtc.dt)
        Catch ex As Exception
            Errlg.WriteToErrorLog(ex.Message, ex.StackTrace, "Frm1_load")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Sc As New StockCardCls(txtPath.Text)
        DGV1.DataSource = Sc.UpPriceComplte(DBCB.Text, txtWhere.Text)

    End Sub
End Class
