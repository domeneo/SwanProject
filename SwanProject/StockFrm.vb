Public Class StockFrm
    Dim datac As New dataACCcls

    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        Dim stockDB As String = ""
        Dim connStr As String
        If RDDB.Text = "BOI" And chkOldStock.Checked Then

            stockDB = "_BOI_OLD"

        ElseIf RDDB.Text = "BOI" And chkOldStock.Checked = False Then

            stockDB = "_BOI"

        ElseIf RDDB.Text = "TAX" And chkOldStock.Checked Then


            stockDB = "_TAX_OLD"

        ElseIf RDDB.Text = "TAX" And chkOldStock.Checked = False Then

            stockDB = "_TAX"

        End If
        connStr = Project.swanpath
        'PathDB = "c:\md2.mdb;Jet OLEDB:Database Password=chenht"

        Dim pgb As New ProgressFrm
        Try

            pgb.PGB.Value = 0
            pgb.PGB.Maximum = 4
            pgb.Text = "Get Stockcard"
            pgb.Show()
            Dim scDate As String = "%"
            Dim scQTY As Single = 0
            Dim dt As New DataTable
            dt = datac.QryDT("SELECT S_qty,S_date from Stock_Card" & stockDB & " where S_prdt like '" & TXTPRDT.Text & "'", connStr)


            For Each dr As DataRow In dt.Rows
                scDate = dr("s_date")
                scQTY = dr("s_qty")
            Next
            Dim prdtconn As String
            If RDDB.Text = "BOI" Then
                prdtconn = Project.md2_boi
            Else
                prdtconn = Project.md2_tax
            End If
            lblPRDT.Text = "Stock Card Date:" & scDate & ",QTY:" & scQTY & ",Name:" & datac.ExScalar("select p_ename from prdt where p_prdt like '" & TXTPRDT.Text & "'", prdtconn)

            pgb.Text = "Get DATA"
            pgb.PGB.Value = pgb.PGB.Value + 1
            Dim Sqlstr As String

            Sqlstr = "SELECT S_DATE,S_CODE,S_SLIP,S_REA,S_PRE,S_QTY,S_CSMR,S_HAND,S_KK,S_PRICE,S_BPRICE,S_BAMT,MC_PRDT,MC_PRDT_THAI,MC_CLOSE,MC_LOTQTY,MC_QTY,MC_SKNO,E_TCCSMR,E_NCSMR FROM (STOCK" & stockDB & " "
            Sqlstr &= " left join LOT_" & RDDB.Text & " on STOCK" & stockDB & ".s_pre =LOT_" & RDDB.Text & ".MC_LOT) "
            Sqlstr &= " left join MEMO_CSMR on MEMO_CSMR.E_SKNO =LOT_" & RDDB.Text & ".MC_SKNO "
            Sqlstr &= " WHERE s_prdt like '" & TXTPRDT.Text & "'  and s_date >='" & scDate & "' order by s_date,s_slip desc,s_code"


            'Sqlstr = "SELECT S_DATE,S_PRDT,S_CODE,S_SLIP,S_REA,S_READES,S_QTY,S_PRE,S_CSMR,S_HAND FROM STOCK "
            'Sqlstr &= " WHERE S_PRDT Like '%" & TXTPRDTCODE.Text & "%' AND S_DATE LIKE '%" & TXTDATE.Text & "%'"
            dt = datac.QryDT(Sqlstr, connStr)

            If dt.Rows.Count <= 0 Then
                MsgBox("ไม่พบข้อมูล")
                Exit Sub

            End If
            If dt.Columns.Contains("BAL") = False Then
                dt.Columns.Add("BAL")
                dt.Columns("BAL").SetOrdinal(6)

            End If

            pgb.Text = "Bal"
            pgb.PGB.Value += 1
            With dt
                Dim i As Integer = 0
                Dim befI As Double
                While .Rows.Count > i
                    If i = 0 Then
                        befI = scQTY
                    Else
                        befI = CDbl(.Rows(i - 1)("BAL")).ToString("0.00")
                    End If
                    If .Rows(i)("S_SLIP") = "WE" Then
                        .Rows(i)("BAL") = CDbl(befI + .Rows(i)("S_QTY")).ToString("0.00")
                    ElseIf .Rows(i)("S_SLIP") = "MA" Then
                        .Rows(i)("BAL") = CDbl(befI - .Rows(i)("S_QTY")).ToString("0.00")
                    ElseIf .Rows(i)("S_SLIP") = "MB" And .Rows(i)("S_Rea") = "B" Then

                        .Rows(i)("BAL") = CDbl(befI + .Rows(i)("S_QTY")).ToString("0.00")
                    Else

                        .Rows(i)("BAL") = CDbl(befI).ToString("0.00")
                    End If

                    i += 1
                End While

            End With
            Dim sdt As DataTable = dt.Clone

            'For Each row As DataRow In STOCKDATA.ActiveDT.Select("s_date like '" & txtdate.Text & "*'", "S_date desc,s_slip,s_code desc")
            Dim OrderData, ShowDate As String

            If DDorder.Text = "มากไปน้อย" Then
                OrderData = "S_date desc,s_slip,s_code desc"
            Else
                OrderData = "S_date,s_slip desc,s_code"
            End If

            txtFromDate.Text = addDatestr(txtFromDate.Text)
            txtToDate.Text = addDatestr(txtToDate.Text)


            If txtFromDate.Text <> "" And txtToDate.Text = "" Then
                ShowDate = "s_date >='" & txtFromDate.Text & "'"
            ElseIf txtFromDate.Text = "" And txtToDate.Text <> "" Then
                ShowDate = "s_date <='" & txtToDate.Text & "'"
            ElseIf txtFromDate.Text <> "" And txtToDate.Text <> "" Then
                ShowDate = "s_date >= '" & txtFromDate.Text & "' and s_date<='" & txtToDate.Text & "'"
            Else
                ShowDate = ""
            End If

            pgb.Text = "Sort"
            pgb.PGB.Value += 1
            For Each row As DataRow In dt.Select(ShowDate, OrderData)

                sdt.ImportRow(row)
            Next

            DGV1.DataSource = sdt
            DGV1.Columns(6).DefaultCellStyle.BackColor = Color.Aqua
            DGV1.Columns(6).DefaultCellStyle.Font = New Drawing.Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold)
            For Each dgr As DataGridViewRow In DGV1.Rows

                If dgr.Cells(6).Value < 0 Then
                    dgr.Cells(6).Style.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            pgb.Close()
        End Try
    End Sub
    Function addDatestr(str As String)

        If str.Length = 4 Then
            str += "0101"
        ElseIf str.Length = 6 Then
            str += "01"
        End If
        Return str
    End Function
    Dim autoCom As New autocompleteCLS
    Private Sub StockFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim dtprdt As New DataTable
        dtprdt = datac.QryDT("select P_PRDT from PRDT order by P_PRDT", Project.md2_boi)

        autoCom.AutoCompleteTextBox(TXTPRDT, dtprdt)
        AddSendtab(Me)
    End Sub

    Private Sub txtToDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdShow.PerformClick()
        End If
    End Sub

    Private Sub txtToDate_TextChanged(sender As Object, e As EventArgs) Handles txtToDate.TextChanged

    End Sub

    Private Sub RDDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RDDB.SelectedIndexChanged
        If RDDB.Text = "BOI" Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.LightBlue

        End If
    End Sub

    Private Sub ExcelBtn_Click(sender As Object, e As EventArgs) Handles ExcelBtn.Click
        Dim Excelexp As New ExporttoExcel
        Dim dt As New DataTable
        Dim dv As DataView
        If DGV1.DataSource Is Nothing Then
            Exit Sub
        End If

        If DGV1.DataSource.GetType Is GetType(DataTable) Then

            dt = DGV1.DataSource
        Else
            dv = DGV1.DataSource
            dt = dv.ToTable()
        End If

        With Excelexp
            .BeginCloumn = "A"
            .SetDt = dt
            .Title = TXTPRDT.Text
            .QuickShow()
        End With
    End Sub
End Class