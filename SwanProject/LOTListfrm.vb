Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class LOTListfrm
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim SQLstr As String
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connacc As New OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    Dim connCtrl As New SqlConnection(ConfigurationManager.ConnectionStrings("ctrl").ConnectionString)

    Dim mc As New matchControl
    Dim QA_Detail As LOTInputfrm
    Dim ShowEXP As String = "" '"where  s_date > '" & Year(Now) & "0501' and s_slip like 'WE'"
    'Function GetData() As DataTable

    '    dtSQL.QryDT("select * from stock_" & DBCB.Text & " " & ShowEXP & " order by s_code desc")
    '    GetData = dtSQL.dt
    'End Function

    Function GetData(Optional TOP As Boolean = True, Optional Orderby As String = "") As DataTable
        ' Dim strCol As String = mc.SelectbyOrder("LOTINPUT", False)
        Dim strCol As String = "*"
        With dtACC




            If .conn Is Nothing Then .conn = connacc
            'If dtACC.conn Is Nothing Then dtACC.conn = connacc
            .QryDT("select " & IIf(TOP, "top " & txtSelectTOP.Text & " ", "") & strCol & " from LOT_" & DBCB.Text & "  " & ShowEXP & " " & IIf(Orderby = "", "order by mc_close ", Orderby))
            lblCount.Text = "จำนวนทั้งหมด : " & .dt.Rows.Count
            Return .dt
        End With
    End Function

    Private Sub QAOUT_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        conn.Close()

    End Sub
    Private Sub QAOUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_FAG_Monitor_DBDataSet.ALC022P' table. You can move, or remove it, as needed.
        AddSendtab(Me)

        BinddingControl(ColCB, "match_control", "M_fields", "m_fields", connCtrl, " where m_table like 'LOTINPUT' order by m_order")

        dtSQL.conn = conn
        GV1.DataSource = GetData().DefaultView
        FilterDV()
    End Sub



    Private Sub GV1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GV1.CellContentDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        QA_Detail = New LOTInputfrm
        LOTInputfrm.lblKEY.Text = GV1.Rows(e.RowIndex).Cells("MC_LOT").Value
        QA_Detail.Show()
    End Sub
    Sub Edit()
        QA_Detail = New LOTInputfrm
        With QA_Detail
            .DBCB.Text = DBCB.Text
            .lblKEY.Text = GV1.SelectedRows.Item(0).Cells("MC_LOT").Value
            .TXTCODE.Text = .lblKEY.Text
            .Show()
            .TXTPRDT.Focus()

        End With

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
            Dim QA_ID As String = GV1.SelectedRows.Item(0).Cells("MC_LOT").Value.ToString
            dtSQL.RunCommand("delete  from lot_" & DBCB.Text & " where mc_LOT like '" & QA_ID & "'")
            dtACC.RunCommand("delete  from lot_" & DBCB.Text & " where mc_LOT like '" & QA_ID & "'")
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
        'Try

        Dim dv As DataView
        If GV1.DataSource.GetType Is GetType(DataTable) Then
            Dim dttemp As DataTable = GV1.DataSource
            dv = dttemp.DefaultView
        Else
            dv = GV1.DataSource

        End If



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
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub SortCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not GV1.DataSource Is Nothing Then FilterDV()
    End Sub




    Private Sub ExcelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelBtn.Click
        Dim Excelexp As New ExporttoExcel
        Dim dt As New DataTable
        Dim dv As DataView
        dv = GV1.DataSource
        dt = dv.ToTable()
        With Excelexp
            .BeginCloumn = "A"
            .SetDt = dt
            .Title = "LOT"
            .QuickShow()
        End With
    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click
        QA_Detail = New LOTInputfrm

        QA_Detail.Show()
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

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged
        If dtSQL.conn Is Nothing Then Exit Sub
        GV1.DataSource = GetData().DefaultView
        FilterDV()
    End Sub

    Private Sub ShowAllbtn_Click(sender As Object, e As EventArgs) Handles ShowAllbtn.Click
        GV1.DataSource = GetData().DefaultView
    End Sub

    Private Sub btnShowCode_Click(sender As Object, e As EventArgs) Handles btnShowCode.Click

        ShowEXP = " where mc_lot between '" & txtFromCode.Text & "' and '" & txtTocode.Text & "'"
        GV1.DataSource = GetData(False, "order by mc_lot")

    End Sub
End Class