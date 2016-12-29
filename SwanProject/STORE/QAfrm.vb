Imports System.Data.SqlClient
Imports System.Configuration
Public Class QAfrm
    Dim mc As New matchControl
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim SQLstr As String
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connAcc As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    Dim ScCLS As New StockCLS
    Dim Datec As New DateCls
    Dim LogC As New LOGCLS

    Function CheckString() As Boolean
        If txtRea.Text = "" Or txtLOT.Text = "" Or txtPrdt.Text = "" Or txtQTY.Text = "" Then

            Return False
        Else

            Return True

        End If
    End Function

    Sub SwitchMode(ByVal Mode As String)
        LBLSTATUS.Text = Mode
        If Mode = "Edit" Then
            AddBtn.Visible = False
            SaveBtn.Visible = True
            DelBtn.Visible = True
            btnCancel.Visible = True
            txtQTY.Enabled = False
            txtPrdt.Enabled = False
        ElseIf Mode = "Add" Then
            ClearBox(Me)
            '  txtCode.Text = dtSQL.ExScalar("select we_no from weno_" & DBCB.Text)
            txtCode.Enabled = False ' ชั่วคราว
            AddBtn.Visible = True
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = True
            txtQTY.Enabled = True
            txtPrdt.Enabled = True
            txtRea.Focus()
        ElseIf Mode.ToUpper = "IDLE" Then

            ClearBox(Me)

            lblKEY.Text = ""
            txtCode.Enabled = True
            txtLOT.Enabled = True
            txtRea.Enabled = True
            txtPrdt.Enabled = True
            txtQTY.Enabled = True


            AddBtn.Visible = False
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = False
            LBLSTATUS.Text = ""


        End If

    End Sub
    Sub NewDATA()

        SwitchMode("Add")
        'txtCode.Text = ScCLS.getMANO(DBCB.Text)
        'lblKEY.Text = txtCode.Text
        ' GV1.Rows.Clear()

        txtRea.Focus()
    End Sub
    Sub EDITDATA()

        Dim dt As New DataTable
        dt = GETQA(txtCode.Text)
        If dt.Rows.Count = 0 Then
            MsgBox("No Data")
            Exit Sub
        End If
        mc.DTrowtocon("QA", dt, Me)

        SwitchMode("Edit")




    End Sub
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click


        If Datec.Checkdate(txtDate.Text) = False Then
            Exit Sub
        End If


        If Not CheckString() Then

            MsgBox("Please Input Data")
            Exit Sub
        End If

        If CDbl(txtLOTQTY.Text) < CDbl(txtMCQTY.Text) + CDbl(txtQTY.Text) Then
            If txtRea.Text.ToUpper = "S" Then
                MsgBox("จำนวนที่เปิด PO น้อยกว่าจำนวนที่ของเข้า กรุณาติอต่อจัดซื้อ")
            Else
                MsgBox("จำนวนที่เปิด LOT น้อยกว่าจำนวนที่ของเข้า กรุณาติอต่อ Production")
            End If
            Exit Sub
        End If

        Dim PGB As New ProgressFrm
        Try


            txtmonth.Text = "*"
            txtbal.Text = 0


            pgb.PGB.Maximum = 5
            pgb.PGB.Value = 0
            PGB.Show()

            Dim TCODE As String
            txtCode.Text = ScCLS.getWENO(DBCB.Text) 'ชั่วคราว
            TCODE = txtCode.Text
            lblKEY.Text = txtCode.Text

            If TXTSUP.Text.Length > 28 Then
                TXTSUP.Text = TXTSUP.Text.Substring(0, 28)
            End If

            PGB.Text = "INSERT STOCK"
            pgb.PGB.Value += 1
            mc.insertSQL("Stock_" & DBCB.Text, "QA", Me, "s_code", conn, True)
            mc.insertSQL("Stock_" & DBCB.Text, "QA", Me, "s_code", connAcc, True)



            If txtRea.Text.ToUpper = "D" Then

                SQLstr = "insert into WED (s_pre,s_date,s_prdt,s_sup,s_qty)"
                SQLstr += " Values("
                SQLstr += "'" & txtLOT.Text & "',"
                SQLstr += "'" & txtDate.Text & "',"
                SQLstr += "'" & txtPrdt.Text & "',"
                SQLstr += "'" & txtSupno.Text & "',"
                SQLstr += "" & txtQTY.Text & ")"
                dtACC.RunCommand(SQLstr, Project.swanpath)
            End If
            PGB.Text = "UPDATE LOT"
            pgb.PGB.Value += 1
            If txtRea.Text.ToUpper = "S" Then
                'เพิ่มLot จัดซื้อ
                SQLstr = "update  odfile_" & DBCB.Text & " set we_dqty=we_dqty +" & txtQTY.Text & " where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
                '  dtSQL.RunCommand(SQLstr)
                dtACC.RunCommand(SQLstr)

            Else
                'เพิ่มLot  ผลิต
                SQLstr = "update  lot_" & DBCB.Text & " set mc_qty=mc_qty +" & txtQTY.Text & ",mc_clsd='" & txtDate.Text & "' where mc_lot like '" & txtLOT.Text & "'"
                ' dtSQL.RunCommand(SQLstr)
                dtACC.RunCommand(SQLstr)

            End If


            PGB.Text = "CLOSE LOT"
            pgb.PGB.Value += 1
            CloseLOT()


            PGB.Text = "UPDATE BAL"
            pgb.PGB.Value += 1
            SQLstr = "update  weno_" & DBCB.Text & " set we_no=we_no + 1"
            '  dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr) 'ชั่วคราว

            SQLstr = "update  prdt_" & DBCB.Text & " set p_BAL=p_BAL + " & txtQTY.Text & ",p_backlog=p_backlog-" & txtQTY.Text & ",p_set='*',p_ldate='" & txtDate.Text & "',p_source='" & txtRea.Text & "'" & IIf(txtRea.Text.ToUpper = "S" Or txtRea.Text.ToUpper = "C", ",P_last=" & txtPrice.Text, "") & "  where p_prdt like '" & txtPrdt.Text & "'"
            'dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)

            Try
                SQLstr = "update stock_" & DBCB.Text & " set s_time=now() where s_code ='" & TCODE & "'"
                dtACC.RunCommand(SQLstr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                SQLstr = "update stock_" & DBCB.Text & " set s_time=getdate() where s_code ='" & TCODE & "'"
                dtSQL.RunCommand(SQLstr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



            ' LogC.SaveLOG(DBCB.Text, txtCode.Text, "INSERT", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "INSERT", LOGCLS.DBTYPE.SQLSERVER)


            SwitchMode("Add")

            MsgBox("บันทึกสำเร็จ CODE : " & TCODE, MsgBoxStyle.OkOnly, "Success")
            txtRea.Focus()
            'txtRea.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            PGB.Close()
        End Try
    End Sub
    Function GETQA(ByVal ID As String) As DataTable

        dtSQL.QryDT("select * from stock_" & DBCB.Text & " where s_code like '" & ID & "' ")
        GETQA = dtSQL.dt

    End Function
    Private Sub QAfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'init 
        dtSQL.conn = conn
        dtACC.conn = connAcc

        mc.OutConnSQL = conn
        mc.OutConnAcc = connAcc
        mc.OutDB = "SQL"
        AddSendtab(Me, "txthand")
        ' DBCB.SelectedIndex = 0

        If lblKEY.Text <> "" Then
            EDITDATA()
        Else
            NewDATA()
        End If

    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If MsgBox("Confirm to Delete?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            dtSQL.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")

            SQLstr = "update  prdt_" & DBCB.Text & " set p_qty=p_qty - " & txtQTY.Text & ",p_backlog=p_backlog+" & txtQTY.Text & " where p_prdt like '" & txtPrdt.Text & "'"
            dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)

            'เพิ่มLot  ผลิต
            SQLstr = "update  lot_" & DBCB.Text & " set mc_qty=mc_qty -" & txtQTY.Text & " where mc_lot like '" & txtLOT.Text & "'"
            dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)
            'เพิ่มLot จัดซื้อ
            SQLstr = "update  odfile_" & DBCB.Text & " set we_dqty=we_dqty -" & txtQTY.Text & " where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
            dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)
            CloseLOT()

            LogC.SaveLOG(DBCB.Text, txtCode.Text, "DELETE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "DELETE", LOGCLS.DBTYPE.SQLSERVER)

            SwitchMode("IDLE")

        End If

    End Sub
    Sub CloseLOT()


        If txtRea.Text.ToUpper = "S" Then



            'ปิดLot จัดซื้อ
            SQLstr = "update  odfile_" & DBCB.Text & " set we_CHK=IIF(we_qty<=we_dqty,'9',IIF(we_qty>we_dqty and we_dqty>0,'4','3'))  where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
            '  dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)
        Else
            'ปิดLot ผลิต

            SQLstr = "update  LOT_" & DBCB.Text & " set mc_close=IIF(mc_lotqty<=mc_qty,'7','5') where mc_lot like '" & txtLOT.Text & "'"
            ' dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)
        End If


    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            If Not CheckString() Then
                MsgBox("Please Input Data")
                Exit Sub
            End If


            mc.updateSQL("Stock_" & DBCB.Text, "QA", Me, "s_code", conn)
            mc.updateSQL("Stock_" & DBCB.Text, "QA", Me, "s_code", connAcc)

            LogC.SaveLOG(DBCB.Text, txtCode.Text, "UPDATE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "UPDATE", LOGCLS.DBTYPE.SQLSERVER)


            SwitchMode("IDLE")
            txtLOT.Focus()

            MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtLOT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLOT.LostFocus
        If txtLOT.Text <> "" Then
            If txtRea.Text.ToUpper = "S" Then
                '  dtACC.QryDT("select WE_PRDT,WE_QTY-WE_DQTY as QTY,WE_CHK,S_SUP,S_name,WE_PRICE from ODFILE_" & DBCB.Text & " as t1 left join  SUPMAST_" & DBCB.Text & " AS t2 on t1.WE_SUP=t2.s_SUP where WE_CODE like '" & txtLOT.Text & "'")

                Dim connstr As String
                If DBCB.Text = "BOI" Then
                    connstr = Project.md5_boi
                Else
                    connstr = Project.md5_tax
                End If
                Dim dt As New DataTable
                dt = dtACC.QryDT("select WE_PRDT,WE_QTY,WE_DQTY,WE_QTY-WE_DQTY as QTY,WE_CHK,S_SUP,S_name,WE_PRICE from ODFILE as t1 left join  SUPMAST AS t2 on t1.WE_SUP=t2.s_SUP where WE_CODE like '" & txtLOT.Text & "'", connstr)

                If dt.Rows.Count > 0 Then
                    ' dt.Rows(0)("WE_CHK") = 0 'ชั่วคราว
                    If dt.Rows(0)("WE_CHK").ToString <> "9" Then


                        txtPrdt.Text = dt.Rows(0)("WE_prdt").ToString
                        txtQTY.Text = dt.Rows(0)("qty").ToString
                        txtSupno.Text = dt.Rows(0)("S_SUP").ToString
                        TXTSUP.Text = dt.Rows(0)("S_name").ToString
                        txtPrice.Text = dt.Rows(0)("we_price").ToString
                        txtLOTQTY.Text = dt.Rows(0)("WE_QTY").ToString
                        txtMCQTY.Text = dt.Rows(0)("WE_DQTY").ToString
                    Else


                    End If
                    txtLotClose.Text = dt.Rows(0)("WE_CHK").ToString
                End If
            Else



                ' dtACC.QryDT("select mc_prdt,mc_lotqty-mc_qty as QTY,mc_close,mc_dept from lot_" & DBCB.Text & " where mc_lot like '" & txtLOT.Text & "'")

                If txtLOT.Text.Substring(0, 1) = "G" Then
                    txtRea.Text = "D"
                End If
                Dim connstr As String
                If DBCB.Text = "BOI" Then
                    connstr = Project.md7_boi
                Else
                    connstr = Project.md7_tax
                End If
                Dim dt As New DataTable
                dt = dtACC.QryDT("select mc_prdt,mc_lotqty,mc_qty,mc_lotqty-mc_qty as QTY,mc_close,mc_dept,mc_lock from lot where mc_lot like '" & txtLOT.Text & "'", connstr)


                If dt.Rows.Count = 0 And txtRea.Text.ToUpper = "D" Then
                    dt = dtACC.QryDT("select c_prdt as mc_prdt,c_qty as QTY,c_qty as mc_lotqty,0 as mc_qty,'5' as mc_close,c_sup as mc_dept,false as mc_lock from claim where c_lot like '" & txtLOT.Text & "'", Project.swanpath)

                End If
                If dt.Rows.Count > 0 Then
                    cbLotlock.Checked = dt.Rows(0)("mc_lock")

                    txtPrdt.Text = ""
                    txtQTY.Text = ""
                    txtSupno.Text = ""
                    txtPrice.Text = ""
                    txtLOTQTY.Text = ""
                    txtMCQTY.Text = ""


                    If dt.Rows(0)("mc_close").ToString = "9" Then

                        MsgBox("LOT is Close")
                        txtLOT.Focus()
                        txtLOT.SelectAll()
                    ElseIf cbLotlock.Checked Then
                        MsgBox("LOT is Lock")
                        txtLOT.Focus()
                        txtLOT.SelectAll()
                    Else
                        txtPrdt.Text = dt.Rows(0)("mc_prdt").ToString
                        txtQTY.Text = dt.Rows(0)("qty").ToString
                        txtSupno.Text = dt.Rows(0)("mc_dept").ToString
                        txtPrice.Text = 0
                        txtLOTQTY.Text = dt.Rows(0)("mc_lotqty").ToString
                        txtMCQTY.Text = dt.Rows(0)("mc_qty").ToString
                        '  txtPrice.Text = ScCLS.getLastPrice(DBCB.Text, txtPrdt.Text)
                    End If

                    txtLotClose.Text = dt.Rows(0)("mc_close").ToString
                End If

            End If
            If txtPrdt.Text <> "" Then
                Dim prdt As New PrdtCls
                txtStock.Text = prdt.GETBAL(txtPrdt.Text, DBCB.Text)

            End If
            Dim datestr As String
            datestr = dtSQL.ExScalar("select convert(varchar,getdate(),120)")
            datestr = Datec.Date120TOstring(datestr)
            txtDate.Text = datestr
        End If
    End Sub


    Private Sub GetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetBtn.Click
        EDITDATA()
    End Sub

    Private Sub cmdNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNEW.Click
        NewDATA()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SwitchMode("IDLE")
    End Sub




    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode <> Keys.Enter Then Exit Sub
        If txtDate.Text = "" Then
            txtDate.Focus()
            MsgBox("Please input Date")

            Exit Sub
        End If
        If Not Datec.Checkdate(txtDate.Text) Then
            txtDate.Focus()
            Exit Sub
        End If

        'If txtDate.Text < txtLotDate.Text Then

        '    SelectTextTB(txtDate)
        '    MsgBox("Date before lot date")
        '    txtDate.Focus()
        'End If
        If txtDate.Text <= ScCLS.getLockDate(DBCB.Text) Then
            txtDate.Focus()
            SelectTextTB(txtDate)
            MsgBox("STOCK CARD IS PRINT")

            Exit Sub
        End If
        SendTab(e.KeyCode)
    End Sub

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged
        If DBCB.Text = "BOI" Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.LightBlue

        End If
    End Sub



    Private Sub txtRea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRea.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub txtLOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLOT.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub txtHand_TextChanged(sender As Object, e As EventArgs) Handles txtHand.TextChanged

    End Sub

    Private Sub txtHand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHand.KeyPress

    End Sub

    Private Sub txtHand_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHand.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddBtn.PerformClick()
        End If
    End Sub

    Private Sub txtLOT_TextChanged(sender As Object, e As EventArgs) Handles txtLOT.TextChanged

    End Sub
End Class
