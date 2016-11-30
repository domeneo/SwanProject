Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class MAListfrm
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connacc As New OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    Dim connCtrl As New SqlConnection(ConfigurationManager.ConnectionStrings("CTRL").ConnectionString)

    Dim dtt As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim mc As New matchControl
    Dim MA As MAfrm
    Dim ShowEXP As String = ""
    Function GetData(Optional TOP As Boolean = True, Optional Orderby As String = "") As DataTable
        Dim strCol As String = mc.SelectbyOrder("Mainput", False)
        'If dtACC.conn Is Nothing Then dtACC.conn = connacc
        Dim connstr As String
        If DBCB.Text = "BOI" Then
            connstr = Project.md2_boi
        Else
            connstr = Project.md2_tax
        End If
        Dim dt As New DataTable
        dt = dtACC.QryDT("select " & IIf(TOP, "top " & txtSelectTOP.Text & " ", "") & strCol & " from STOCK where s_slip like 'MA'  " & ShowEXP & " " & IIf(Orderby = "", "order by s_id desc", Orderby), connstr)
        lblCount.Text = "จำนวนทั้งหมด : " & dt.Rows.Count
        Return dt
    End Function

    Private Sub QAOUT_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        conn.Close()
        connCtrl.Close()
    End Sub
    Private Sub QAOUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_FAG_Monitor_DBDataSet.ALC022P' table. You can move, or remove it, as needed.
        AddSendtab(Me)
        dtt.conn = conn
        dtACC.conn = connacc
        BinddingControl(ColCB, "match_control", "m_fields", "m_fields", connCtrl, " where m_table like 'Mainput' order by m_order")

        GV1.DataSource = GetData().DefaultView
        FilterDV()
    End Sub



    Private Sub GV1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GV1.CellContentDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        MA = New MAfrm
        MA.lblKEY.Text = GV1.Rows(e.RowIndex).Cells("s_code").Value
        MA.txtCode.Text = MA.lblKEY.Text
        MA.Show()
    End Sub
    Sub Edit()
        MA = New MAfrm

        MA.DBCB.Text = DBCB.Text
        MA.lblKEY.Text = GV1.SelectedRows.Item(0).Cells("s_code").Value
        MA.txtCode.Text = MA.lblKEY.Text
        MA.Show()
        MA.txtCode.Focus()
    End Sub
    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        Edit()
    End Sub


    Private Sub refeshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refeshBtn.Click
        GV1.DataSource = GetData().DefaultView
        FilterDV()
    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If MsgBox("Confirm to Delete?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Dim Serial As String
            For Each row As DataGridViewRow In GV1.SelectedRows
                Serial = row.Cells("s_code").Value.ToString()
                dtt.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & Serial & "'")
            Next

            GV1.DataSource = GetData()
        End If
    End Sub

    Private Sub QAOUT_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GV1.Width = Me.Width - GV1.Left - 30
        GV1.Height = Me.Height - GV1.Top - 40
    End Sub

    Private Sub FilterBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub wheretxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wheretxt.TextChanged
        FilterDV()


    End Sub
    Sub FilterDV()
        Try

            Dim dv As DataView
            dv = GV1.DataSource


            If GV1.Columns(ColCB.Text).ValueType Is GetType(String) Then
                dv.RowFilter = "[" & ColCB.Text & "] like '" & wheretxt.Text & "%'"
            ElseIf GV1.Columns(ColCB.Text).ValueType Is GetType(Integer) Then
                If wheretxt.Text.Length <= 1 Then Exit Sub
                Dim opt As String
                If wheretxt.Text.Substring(0, 1) = "<" Or wheretxt.Text.Substring(0, 1) = ">" Then
                    opt = ""
                    If wheretxt.Text.Length <= 2 Then Exit Sub
                Else
                    opt = "="
                End If
                dv.RowFilter = "[" & ColCB.Text & "] " & opt & " " & wheretxt.Text & ""
            End If
            GV1.DataSource = dv
            lblCount.Text = "จำนวนทั้งหมด : " & dv.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SortCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not GV1.DataSource Is Nothing Then FilterDV()
    End Sub




    Private Sub ExcelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelBtn.Click
        'Dim Excelexp As New ExporttoExcel
        'Dim dt As New DataTable
        'Dim dv As DataView
        'If GV1.DataSource.GetType Is GetType(DataTable) Then

        '    dt = GV1.DataSource
        'Else
        '    dv = GV1.DataSource
        '    dt = dv.ToTable()
        'End If

        'With Excelexp
        '    .BeginCloumn = "A"
        '    .SetDt = dt
        '    .Title = "MA List "
        '    .QuickShow()
        'End With


        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel File|*.xls"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "MA"

        SaveFileDialog1.ShowDialog(Me)

        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If

        Dim excelexp As New ExporttoExcel_EP

        Dim dv As DataView = GV1.DataSource

        excelexp.CreateSheet(dv.ToTable, SaveFileDialog1.FileName, "MA")
    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click
        MA = New MAfrm
        MA.DBCB.Text = DBCB.Text
        MA.Show()
    End Sub


    Sub Showall(ByVal Show As Boolean)
        If Show Then
            ' ShowEXP = ""
        Else
            '  ShowEXP = "and  Date_Receive > '20120101'"

        End If

    End Sub

    Private Sub GV1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV1.KeyDown
        If e.KeyData = 13 Then
            wheretxt.Focus()
            Edit()

            e.SuppressKeyPress = True

        End If
    End Sub


    Private Sub GV1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GV1.KeyPress
        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
        '    e.KeyChar = ""
        'End If
    End Sub







    Private Sub ShowAllbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllbtn.Click
        ShowEXP = ""
        GV1.DataSource = GetData().DefaultView
    End Sub

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged
        If dtACC.conn Is Nothing Then Exit Sub
        GV1.DataSource = GetData().DefaultView
        FilterDV()
    End Sub

    Private Sub btnShowCode_Click(sender As Object, e As EventArgs) Handles btnShowCode.Click
        ShowEXP = "and s_code between '" & txtFromCode.Text & "' and '" & txtTocode.Text & "'"
        GV1.DataSource = GetData(False, "order by s_code,s_prdt")
    End Sub
End Class