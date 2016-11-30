Imports System.Data.SqlClient
Imports System.Configuration
Public Class MAfrm
    Dim mc As New matchControl
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim AutoCom As New autocompleteCLS
    Dim SQLstr As String
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connAcc As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)

    Dim ScCLS As New StockCLS
    Dim PrdtC As New PrdtCls
    Dim Datec As New DateCls
    Dim LogC As New LOGCLS
    Function CheckString() As Boolean
        If GV1.Rows.Count = 0 And txtRea.Text = "" And txtDate.Text = "" And txtHand.Text = "" Then

            Return False

        Else
            Return True

        End If
    End Function

    Sub SwitchMode(ByVal Mode As String)
        LBLSTATUS.Text = Mode
        If Mode.ToUpper = "EDIT" Then
            AddBtn.Visible = False
            ' SaveBtn.Visible = True
            '  DelBtn.Visible = True
            btnCancel.Visible = True

            txtLOT.Enabled = True
            txtRea.Enabled = True
            txtPrdt.Enabled = True
            txtQTY.Enabled = True
        ElseIf Mode.ToUpper = "ADD" Then
            ClearBox(Me)
            ' txtCode.Text = ScCLS.getMANO(DBCB.Text)
            GV1.Rows.Clear()
            txtCode.Enabled = False
            AddBtn.Visible = True
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = True

            txtLOT.Enabled = True
            txtRea.Enabled = True
            txtPrdt.Enabled = True
            txtQTY.Enabled = True


            Dim datestr As String
            datestr = dtSQL.ExScalar("select convert(varchar,getdate(),120)")
            datestr = Datec.Date120TOstring(datestr)
            txtDate.Text = datestr
        ElseIf Mode.ToUpper = "IDLE" Then

            ClearBox(Me)
            GV1.Rows.Clear()
            lblKEY.Text = ""
            txtCode.Enabled = True
            txtLOT.Enabled = True
            txtRea.Enabled = True
            txtPrdt.Enabled = True
            txtQTY.Enabled = True
            addPrdtbtn.Enabled = True
            DelPrdtbtn.Enabled = True

            AddBtn.Visible = False
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = False
            LBLSTATUS.Text = ""
        End If

    End Sub
    Private Sub MAfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtSQL.conn = conn
        dtACC.conn = connAcc
        mc.OutConnSQL = conn
        mc.OutConnAcc = connAcc
        mc.OutDB = "SQL"


        AutocomPRDT()


        AddSendtab(PnMAM)
        'AddSendtab(Me)
        ' Dim Autocom As New autocompleteCLS
        'Dim AUTOdtc As New dataSQLcls
        '  AUTOdtc.conn = conn
        '  AUTOdtc.QryDT("select P_PRDT from Prdt_BOI order by P_PRDT")

        ' SwitchMode("IDLE")
        If lblKEY.Text <> "" Then
            EDITDATA()
            'SwitchMode("Edit")
            'mc.DTrowtocon("Mainput", GETQA(lblKEY.Text), Me)
            'txtFin.Focus()
        Else
            NewDATA()
        End If

    End Sub
    Dim LOTDT As New DataTable
    Sub AutocomLOT()
        dtSQL.conn = conn
        dtSQL.QryDT("select MC_LOT from LOT_" & DBCB.Text & "  order by MC_LOT")
        LOTDT = dtSQL.dt
        AutoCom.AutoCompleteTextBox(txtLOT, LOTDT)
    End Sub
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ' Try
        If Not CheckString() Then
            MsgBox("Please Input Data")
            Exit Sub

        End If
        If Not CheckBalInGV() Then

            MsgBox("Please Check QTY")
            Exit Sub
        End If

        If TxtLotClose.Text = "9" Then
            MsgBox("LOT is close")
            Exit Sub
        End If


        txtCode.Text = ScCLS.getMANO(DBCB.Text)
        lblKEY.Text = txtCode.Text

        Dim MD7connSTR, MD2connSTR As String
        If DBCB.Text = "BOI" Then
            MD7connSTR = Project.md7_boi
            MD2connSTR = Project.md2_boi
        Else

            MD7connSTR = Project.md7_tax
            MD2connSTR = Project.md2_tax
        End If

        'If dr.Cells("QTY").Value > dr.Cells("BAL").Value Then
        '    SQLstr = "insert into stock_" & DBCB.Text & "(s_prdt,s_qty,s_code,s_slip,s_rea,s_date,s_inv"

        Dim pgb As New ProgressFrm

        pgb.PGB.Maximum = 3
        pgb.PGB.Value = 0
        pgb.Show()




        pgb.Text = "Insert DATA"

        mc.insertSQLGV_CONNstrSQL("stock_" & DBCB.Text, "MAinput", Me, GV1, txtCode.Text, ConfigurationManager.ConnectionStrings("swan").ConnectionString, "QTY", "s_time")
        ' mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, conn)

        '   mc.insertSQLGV("stock_" & DBCB.Text, "MAinput", Me, GV1, txtCode.Text, connAcc)
        ' mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, connAcc)

        mc.insertSQLGV_CONNstr("stock", "MAinput", Me, GV1, txtCode.Text, MD2connSTR, "QTY", "s_time")

        Dim SQLbatch As String = ""



        pgb.Text = "Update MAFILE"
        pgb.PGB.Value += 1

        Dim prdtin As String = ""
        Try


            For Each dr As DataGridViewRow In GV1.Rows
                If dr.Cells("PRDT").Value Is Nothing Then Continue For
                prdtin += ",'" & dr.Cells("PRDT").Value & "'"
        Next

            prdtin = prdtin.Substring(1)
            Dim SQLSTR2 As String
            SQLstr = "SELECT p_prdt,p_BAL from prdt where p_prdt in (" & prdtin & ") order by P_PLACE"
            SQLSTR2 = "SELECT MA_code,MA_PRDT,MA_RQTY from MAFILE_" & DBCB.Text & " where MA_CODE LIKE '" & txtLOT.Text & "' order by MA_PRDT"


            'Dim dt, dt2 As New DataTable
            'Using conn As New OleDb.OleDbConnection
            '    conn.ConnectionString = MD2connSTR
            '    conn.Open()

            '    Using da As New OleDb.OleDbDataAdapter(SQLstr, conn)

            '        Using da2 As New OleDb.OleDbDataAdapter(SQLSTR2, conn)



            ' da.Fill(dt)
            'Dim cb As New OleDb.OleDbCommandBuilder(da)

            'da.UpdateCommand = cb.GetUpdateCommand()
            'da.InsertCommand = cb.GetInsertCommand()
            'da.DeleteCommand = cb.GetDeleteCommand()

            'da.UpdateCommand.UpdatedRowSource = UpdateRowSource.None
            'da.InsertCommand.UpdatedRowSource = UpdateRowSource.None
            'da.DeleteCommand.UpdatedRowSource = UpdateRowSource.None


            'da2.Fill(dt2)
            'Dim cb2 As New OleDb.OleDbCommandBuilder(da2)

            'da2.UpdateCommand = cb2.GetUpdateCommand()
            'da2.InsertCommand = cb2.GetInsertCommand()
            'da2.DeleteCommand = cb2.GetDeleteCommand()

            'da2.UpdateCommand.UpdatedRowSource = UpdateRowSource.None
            'da2.InsertCommand.UpdatedRowSource = UpdateRowSource.None
            'da2.DeleteCommand.UpdatedRowSource = UpdateRowSource.None



            Dim i, i2 As Integer

                    For Each dr As DataGridViewRow In GV1.Rows
                        If dr.Cells("PRDT").Value Is Nothing Then Continue For
                        If dr.Cells("QTY").Value = 0 Then Continue For
                'For i = 0 To dt.Rows.Count - 1
                '    If dt.Rows(i)("P_PRDT").ToString = dr.Cells("PRDT").Value Then

                '        Exit For
                '    End If
                'Next

                'i = 0
                'While dt.Rows(i)("P_PRDT").ToString <> dr.Cells("PRDT").Value And i < dt.Rows.Count
                '    Exit While
                '    i += 1

                'End While


                '    For i2 = 0 To dt2.Rows.Count - 1
                '        If dt2.Rows(i2)("MA_PRDT").ToString = dr.Cells("PRDT").Value Then

                '            Exit For
                '        End If
                '    Next
                '    If i = dt.Rows.Count Then Continue For
                ' SQLstr = "update  prdt_" & DBCB.Text & " set p_BAL=p_BAL - " & dr.Cells("QTY").Value & " where p_prdt like '" & dr.Cells("PRDT").Value & "'"
                SQLstr = "update  prdt set p_BAL=p_BAL - " & dr.Cells("QTY").Value & ",P_LDATE='" & txtDate.Text & "' where p_prdt = '" & dr.Cells("PRDT").Value & "'"
                dtACC.RunCommand(SQLstr, MD2connSTR)


                        ' dtSQL.RunCommand(SQLstr)
                        'dtACC.RunCommand(SQLstr)
                        '  dt.Rows(i)("p_bal") = dt.Rows(i)("p_bal") - dr.Cells("QTY").Value






                        SQLbatch += SQLstr + vbCrLf

                If txtRea.Text = "M" Or txtRea.Text = "A" Then
                    ' SQLstr = "update  MAFILE_" & DBCB.Text & " set MA_RQTY=MA_RQTY + " & dr.Cells("QTY").Value & " where MA_PRDT like '" & dr.Cells("PRDT").Value & "' and MA_CODE like '" & txtLOT.Text & "'"
                    '   dtSQL.RunCommand(SQLstr)


                    SQLstr = "update  MAFILE set MA_RQTY=MA_RQTY + " & dr.Cells("QTY").Value & " where MA_PRDT = '" & dr.Cells("PRDT").Value & "' and MA_CODE = '" & txtLOT.Text & "'"


                    dtACC.RunCommand(SQLstr, MD7connSTR)


                    ' dt2.Rows(i)("MA_RQTY") = dt2.Rows(i)("MA_RQTY") + dr.Cells("QTY").Value
                    ' cmd.CommandText = SQLstr
                    ' cmd.ExecuteNonQuery()
                    SQLbatch += SQLstr + vbCrLf

                ElseIf txtRea.Text = "S" Or txtRea.Text = "E" Then

                    SQLstr = "update  MAEXP set MA_RQTY=MA_RQTY + " & dr.Cells("QTY").Value & " where MA_PRDT like '" & dr.Cells("PRDT").Value & "' and  replace(ma_code,'/','') like '" & txtLOT.Text & "'"

                    Dim lot As String = txtLOT.Text

                    If txtRea.Text = "S" Then
                        lot = lot.Substring(0, 2) + "/" + lot.Substring(2, lot.Length - 2)

                    End If
                    SQLstr = "update  MAEXP set MA_RQTY=MA_RQTY + " & dr.Cells("QTY").Value & " where MA_PRDT like '" & dr.Cells("PRDT").Value & "' and  ma_code like '" & lot & "'"

                    '  dtSQL.RunCommand(SQLstr)
                    dtACC.RunCommand(SQLstr, Project.md7_boi)
                            ' cmd.CommandText = SQLstr
                            ' cmd.ExecuteNonQuery()
                            SQLbatch += SQLstr + vbCrLf
                        End If
                    Next


            ' da.Update(dt)
            ' da2.Update(dt2)
            ' End Using
            ' End Using
            'End Using

        Catch ex As Exception
            MsgBox("UPDATE BALANCE ERR:" & ex.Message)
        End Try

        pgb.Text = "Update MAFILE"
        pgb.PGB.Value += 1
        If txtRea.Text = "M" Then

            SQLstr = "delete from MAFILE_" & DBCB.Text & " where MA_QTY=MA_RQTY"
            ' dtACC.RunCommand(SQLstr)
            ' dtSQL.RunCommand(SQLstr)
            '  SQLbatch += SQLstr + vbCrLf
        ElseIf txtRea.Text = "S" Or txtRea.Text = "E" Then

            SQLstr = "delete from MAEXP_BOI where MA_QTY=MA_RQTY"
            'dtACC.RunCommand(SQLstr)
            '    dtSQL.RunCommand(SQLstr)
            ' SQLbatch += SQLstr + vbCrLf
        End If




        '  LogC.SaveLOG(DBCB.Text, txtCode.Text, "INSERT", LOGCLS.DBTYPE.ACCESS)
        LogC.SaveLOG(DBCB.Text, txtCode.Text, "INSERT", LOGCLS.DBTYPE.SQLSERVER)
        ScCLS.incMANO(DBCB.Text)

        '  dtSQL.RunCommand(SQLbatch)

        Try
            SQLstr = "update stock_" & DBCB.Text & " set s_time=now() where s_code ='" & txtCode.Text & "'"
            '  dtACC.RunCommand(SQLstr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    SQLstr = "update stock_" & DBCB.Text & " set s_time=getdate() where s_code ='" & txtCode.Text & "'"
        '    dtSQL.RunCommand(SQLstr)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        lblKEY.Text = txtCode.Text

        pgb.Close()
        MsgBox("บันทึกสำเร็จ Code is " & lblKEY.Text, MsgBoxStyle.OkOnly, "Success")
        'Catch ex As Exception
        ' MsgBox(ex.Message)
        ' End Try

        SwitchMode("ADD")
        txtRea.Focus()
    End Sub
    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If MsgBox("Confirm to Delete?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            ' dtSQL.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")

            ' SQLstr = "update  prdt_" & DBCB.Text & " set p_qty=p_qty - " & txtQTY.Text & " where p_prdt like '" & txtPrdt.Text & "'"
            ' dtSQL.RunCommand(SQLstr)
            For Each dr As DataGridViewRow In GV1.Rows
                If dr.Cells("PRDT").Value Is Nothing Then Continue For
                SQLstr = "update  prdt_" & DBCB.Text & " set p_BAL=p_BAL + " & dr.Cells("QTY").Value & " where p_prdt like '" & dr.Cells("prdt").Value & "'"
                dtACC.RunCommand(SQLstr)

            Next





            'LogC.SaveLOG(DBCB.Text, txtCode.Text, "DELETE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "DELETE", LOGCLS.DBTYPE.SQLSERVER)


            SwitchMode("IDLE")
        End If

    End Sub
    Function GETQA(ByVal ID As String) As DataTable

        dtACC.QryDT("select s_code,s_id,s_date,s_prdt,s_rea,s_reades,s_slip,s_qty,s_pre,s_price,s_hand,s_invo,p_bal,p_last from stock_" & DBCB.Text & " as t1 left join prdt_" & DBCB.Text & " as t2 on t1.s_prdt=t2.p_prdt where s_code like '" & ID & "' ")
        Return dtACC.dt

    End Function
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            If Not CheckString() Then
                MsgBox("Please Input Data")
                Exit Sub

            End If

            'If Not CheckBalInGV() Then

            '    MsgBox("Please Check QTY")
            '    Exit Sub
            'End If

            If TxtLotClose.Text = "9" Then
                MsgBox("LOT is close")
                Exit Sub
            End If

            ' dtSQL.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")

            mc.insertSQLGV("stock_" & DBCB.Text, "MAinput", Me, GV1, txtCode.Text, connAcc)

            For Each dr As DataGridViewRow In GV1.Rows

                '  mc.insertSQLGV("stock_" & DBCB.Text, "MAinput", Me, GV1, txtCode.Text, conn)
                ' mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, conn)

                '  mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, connAcc)

            Next

            'LogC.SaveLOG(DBCB.Text, txtCode.Text, "UPDATE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "UPDATE", LOGCLS.DBTYPE.SQLSERVER)


            txtCode.Focus()
            MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")
            SwitchMode("IDLE")
            GetBtn.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub AutocomPRDT()
        dtSQL.conn = conn
        dtSQL.QryDT("select P_PRDT from PRDT_" & DBCB.Text & " where P_PRDT not like '' order by P_PRDT")
        AutoCom.AutoCompleteTextBox(txtPrdt, dtSQL.dt)
    End Sub



    Sub CloseLOT()
        'ปิดLot ผลิต
        SQLstr = "update  LOT_" & DBCB.Text & " set mc_close=case when mc_lotqty=mc_qty then '7' when we_qty<>we_dqty then '5'  end where mc_lot like '" & txtLOT.Text & "'"
        dtSQL.RunCommand(SQLstr)

        SQLstr = "update  LOT_" & DBCB.Text & " set mc_close=case when mc_lotqty=mc_qty then '7' when we_qty<>we_dqty then '5'  end where mc_lot like '" & txtLOT.Text & "'"
        dtACC.RunCommand(SQLstr)

        'ปิดLot จัดซื้อ
        SQLstr = "update  odfile_" & DBCB.Text & " set we_close=case when we_qty=we_dqty then '9' when we_qty<>we_dqty and we_dqty<>0 then '4' else '3' end where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
        dtSQL.RunCommand(SQLstr)

        SQLstr = "update  odfile_" & DBCB.Text & " set we_close=case when we_qty=we_dqty then '9' when we_qty<>we_dqty and we_dqty<>0 then '4' else '3' end where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
        dtACC.RunCommand(SQLstr)
    End Sub


    Sub CheckLOT()
        Try


            If txtLOT.Text = "" Then Exit Sub
            If txtRea.Text = "R" Or txtRea.Text = "T" Or txtRea.Text = "S" Or txtRea.Text = "E" Then Exit Sub

            Dim ProGbar As New ProgressFrm
            ProGbar.Text = "กำลังตรวจสอบ LOT"
            ProGbar.Show()
            ProGbar.PGB.Maximum = 2
            ProGbar.PGB.Value = 0
            SQLstr = "select LOTDB,mc_lot,mc_PRDT_THAI,mc_close,mc_date,mc_lock from lotall where mc_lot like '" & txtLOT.Text & "' order by mc_lot"
            dtACC.QryDT(SQLstr)
            ProGbar.PGB.Value = ProGbar.PGB.Value + 1
            If dtACC.dt.Rows.Count > 0 Then

                TxtLotClose.Text = dtACC.dt.Rows(0)("mc_close").ToString
                cbLotlock.Checked = dtACC.dt.Rows(0)("mc_lock")

                If cbLotlock.Checked Then
                    cbLotlock.ForeColor = Color.Red
                Else
                    cbLotlock.ForeColor = Color.Black

                End If
                If dtACC.dt.Rows(0)("MC_CLOSE") = "9" Then
                    '        If MsgBox("Lot is close.Do you want to continue?", vbYesNo, "Lot is close") = vbYes Then
                    '            txtdate.SetFocus
                    '            Exit Sub
                    '        End If
                    MsgBox("Lot is close.")

                    ProGbar.Close()
                ElseIf cbLotlock.Checked Then


                    MsgBox("Lot is Lock.")

                    ProGbar.Close()

                Else


                    'SQLstr = "select *  from BOM_" & rs!LOTDB & " where b_PCODE like '" & rs!mc_prdt_thai & "'"
                    'OpenRS(SQLstr, rsBOM, conn2)
                    'txtDate.SetFocus()
                    'Unload(ProGbar)
                    'Exit Sub
                    txtLotDate.Text = dtACC.dt.Rows(0)("mc_date").ToString


                    ProGbar.Close()
                    Exit Sub
                End If
            Else
                If MsgBox("Lot not found.Do you want to continue?", vbYesNo, "Lot not found") = vbYes Then

                    ProGbar.Close()
                    Exit Sub
                End If
            End If

            'txtDate.Focus()

            ProGbar.Close()

            SelectTextTB(txtLOT)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            txtPrdt.Focus()

        End Try


    End Sub
    Private Sub txtLOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLOT.KeyDown
        If e.KeyCode <> Keys.Enter Then Exit Sub
        CheckLOT()
    End Sub


    Sub NewDATA()

        SwitchMode("Add")
        'txtCode.Text = ScCLS.getMANO(DBCB.Text)
        'lblKEY.Text = txtCode.Text
        GV1.Rows.Clear()
        txtRea.Focus()
    End Sub
    Sub EDITDATA()

        If txtCode.Text.Trim = "" Then
            Exit Sub
        End If
        Dim dt As New DataTable
        dt = GETQA(txtCode.Text)
        If dt.Rows.Count = 0 Then
            MsgBox("No Data")
            Exit Sub
        End If
        mc.DTrowtocon("Mainput", dt, Me)

        ' Dim Bal, Price As Double
        For Each dr As DataRow In dt.Rows
            ' Bal = PrdtC.GETBAL(dr("S_PRDT").ToString, DBCB.Text)
            ' Price = PrdtC.GETPrice(dr("S_PRDT").ToString, DBCB.Text)
            GV1.Rows.Add(dr("S_PRDT").ToString, dr("S_QTY").ToString, dr("P_BAL").ToString, dr("P_LAST").ToString)

        Next
        lblKEY.Text = txtCode.Text
        SwitchMode("Edit")

        CheckLOT()

        GV1.ReadOnly = False
        GV1.Columns("PRDT").ReadOnly = True
        GV1.Columns("BAL").ReadOnly = True
    End Sub
    Private Sub GetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetBtn.Click
        EDITDATA()
    End Sub

    Private Sub cmdNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNEW.Click
        NewDATA()
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

        If txtDate.Text < txtLotDate.Text Then

            SelectTextTB(txtDate)
            MsgBox("Date before lot date")
            txtDate.Focus()
        End If
        If txtDate.Text <= ScCLS.getLockDate(DBCB.Text) Then
            txtDate.Focus()
            SelectTextTB(txtDate)
            MsgBox("STOCK CARD IS PRINT")

            Exit Sub
        End If
        SendTab(e.KeyCode)
    End Sub



    Private Sub addPrdtbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addPrdtbtn.Click
        If txtPrdt.Text = "" Or txtQTY.Text = "" Then

            MsgBox("Please Input Data")
            Exit Sub
        End If
        '  SQLstr = "select P_prdt from prdt_" & DBCB.Text & " where p_prdt ='" + txtPrdt.Text + "'"

        '   If dtSQL.ExScalar(SQLstr) = "" Then
        ' MsgBox("PRDT Not Found", , "Error")
        ' SelectTextTB(txtPrdt)

        'Exit Sub
        '  End If
        'If rsBOM.State = 1 Then
        '    If rsBOM.RecordCount > 0 Then
        '        rsBOM.MoveFirst()
        '        Do While Not rsBOM.EOF
        '            If txtPrdt.Text = rsBOM!b_SCODE Or txtPrdt.Text = rsBOM!b_PCODE Then
        '                Exit Do
        '            End If
        '            rsBOM.MoveNext()
        '        Loop
        '        If rsBOM.EOF Then
        '            If MsgBox("Prdt Not In BOM.Do you want to continue?", vbYesNo) = vbNo Then Exit Sub
        '        End If
        '    End If

        'Dim Dgvr As New DataGridViewRow
        'Dgvr = GV1.Rows(0).Clone
        'Dgvr.Cells("PRDT").Value = txtPrdt.Text
        'Dgvr.Cells("QTY").Value = txtQTY.Text
        'Dgvr.Cells("BAL").Value = txtStock.Text


        For Each row As DataGridViewRow In GV1.Rows
            If Not row.Cells(0).Value Is Nothing Then
                If row.Cells(0).Value.ToString().Equals(txtPrdt.Text) Then
                    MsgBox("Prdtนี้ได้ถูกใส่แล้ว", MsgBoxStyle.OkOnly, "Error")
                    Exit Sub
                End If
            End If
        Next
        If IsNumeric(txtStock.Text) = False Then
            txtStock.Text = 0
        End If
        If CDbl(txtQTY.Text) > CDbl(txtStock.Text) Then
            MsgBox("เบิกของเกินจำนวน")
            Exit Sub
        End If
        ' GV1.Rows.Add(txtPrdt.Text, txtQTY.Text, txtStock.Text)
        ' mc.DTtoGV("MAinput", GV1, Me)
        GV1.Rows.Add(txtPrdt.Text.ToUpper, txtQTY.Text, txtStock.Text, txtPrice.Text)

            txtQTY.Text = ""
            SelectTextTB(txtPrdt)
            'txtreason.Text = ""
            'txtreasondes.Text = ""
            'txtdep.Text = ""


    End Sub

    Private Sub DBCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBCB.SelectedIndexChanged
        If DBCB.Text = "BOI" Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.LightBlue

        End If
        AutocomLOT()
        'AutocomPRDT()

    End Sub

    Private Sub txtPrdt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrdt.KeyDown
        If e.Shift And e.KeyCode = Keys.Enter Then
            txtHand.Focus()
        Else
            SendTab(e.KeyCode)

            If Len(txtPrdt.Text) = 11 Then
                PrdtC.GetDATA(txtPrdt.Text, DBCB.Text)
                txtStock.Text = PrdtC.Bal
                txtPrdtName.Text = PrdtC.Name
                txtPrdtSpec.Text = PrdtC.SPEC
                txtPrice.Text = PrdtC.Price
            End If

        End If

    End Sub

    Private Sub txtPrdt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrdt.LostFocus

    End Sub

    Private Sub txtRea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRea.KeyDown
        If e.KeyCode = Keys.M Then
            'e.Handled = True
            e.SuppressKeyPress = True
        End If

        SendTab(e.KeyCode)
    End Sub


    Private Sub btnMam_Click(sender As Object, e As EventArgs) Handles btnMam.Click
        If txtReaGet.Text.ToUpper <> "M" And txtReaGet.Text.ToUpper <> "S" And txtReaGet.Text.ToUpper <> "E" And txtReaGet.Text.ToUpper <> "C" Then
            MsgBox(" กรุณาใส่ข้อมูลในช่อง rea ให้ถูกต้อง")
            txtRea.Focus()
            Exit Sub
        End If
        SwitchMode("Add")
        Dim dt As DataTable
        If txtReaGet.Text.ToUpper = "M" Or txtReaGet.Text.ToUpper = "C" Then
            dt = GETMAFile(txtMLot.Text, txtMPage.Text)

            ' Dim Bal, Price As Double
            If dt.Rows.Count > 0 Then
                GV1.Rows.Clear()
                For Each dr As DataRow In dt.Rows
                    ' Bal = PrdtC.GETBAL(dr("MA_PRDT").ToString, DBCB.Text)
                    ' Price = PrdtC.GETPrice(dr("MA_PRDT").ToString, DBCB.Text)
                    GV1.Rows.Add(dr("MA_PRDT").ToString, dr("MA_QTY").ToString - dr("MA_RQTY").ToString, dr("P_BAL").ToString, dr("P_LAST").ToString)
                    '  txtRea.Text = dr("MA_REA").ToString

                Next
                txtRea.Text = dt.Rows(0)("MA_REA").ToString
                ' txtDate.Text = dt.Rows(0)("MA_DATE").ToString
                ' txtHand.Focus()
            End If

            txtDate.Enabled = False 'ชั่วคราว
        Else
            txtDate.Enabled = False
            Dim lot As String = txtMLot.Text
            If txtReaGet.Text = "S" Then
                lot = lot.Substring(0, 2) + "/" + lot.Substring(2, lot.Length - 2)

            End If
            dt = GETMAEXP(lot, txtMPage.Text)
            If dt.Rows.Count > 0 Then
                GV1.Rows.Clear()

                For Each dr As DataRow In dt.Rows
                    ' Bal = PrdtC.GETBAL(dr("MA_PRDT").ToString, DBCB.Text)
                    GV1.Rows.Add(dr("MA_PRDT").ToString, dr("MA_QTY").ToString - dr("MA_RQTY").ToString, dr("P_BAL").ToString, dr("P_LAST").ToString)


                Next
                txtRea.Text = dt.Rows(0)("MA_REA").ToString
                '  txtDate.Text = Datec.DateTOstring(Now)
                Dim datestr As String
                datestr = dtSQL.ExScalar("Select convert(varchar,getdate(),120)")
                datestr = Datec.Date120TOstring(datestr)
                txtDate.Text = datestr
                ' txtDate.Text = dt.Rows(0)("MA_DATE").ToString
                ' txtHand.Focus()
            Else
                MsgBox("No Data")
                Exit Sub

            End If
        End If




        ' txtCode.Text = ScCLS.getMANO(DBCB.Text)
        ' lblKEY.Text = txtCode.Text

        txtLOT.Text = txtMLot.Text.ToUpper
        txtLOT.Text = txtLOT.Text.Replace("/", "")
        ' txtRea.Enabled = False
        txtLOT.Enabled = False
        txtPrdt.Enabled = False
        txtQTY.Enabled = False
        addPrdtbtn.Enabled = False
        DelPrdtbtn.Enabled = False
        GV1.ReadOnly = False
        GV1.Columns("PRDT").ReadOnly = True
        GV1.Columns("BAL").ReadOnly = True

        txtHand.Focus()
        ColorGV()

    End Sub
    Sub ColorGV()

        For Each dr As DataGridViewRow In GV1.Rows
            If dr.Cells("BAL").Value Is Nothing Then
                Continue For
            End If
            If dr.Cells("BAL").Value.ToString = "" Then
                dr.Cells("BAL").Value = 0
            End If
            If dr.Cells("QTY").Value > dr.Cells("BAL").Value Then
                dr.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
    Function CheckBalInGV() As Boolean

        For Each dr As DataGridViewRow In GV1.Rows
            Dim bal As Double = CDbl(dr.Cells("BAL").Value)
            If bal < 0 Then
                bal = 0
            End If
            If CDbl(dr.Cells("QTY").Value) > bal Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Function GETMAFile(ByVal Code As String, Page As String) As DataTable

        dtACC.QryDT("Select MA_CODE,MA_PRDT,MA_SEQ,MA_REA,MA_DATE,MA_HAND,MA_QTY,MA_RQTY,P_BAL,P_LAST from MAFILE_" & DBCB.Text & " As t1 left join prdt_" & DBCB.Text & " As t2 On t1.ma_prdt=t2.p_prdt where MA_CODE Like '" & Code & "' and MA_SEQ LIKE '" & Page & "' AND MA_QTY-MA_RQTY>0 order by p_place")
        Return dtACC.dt

    End Function
    Function GETMAEXP(ByVal Code As String, Page As String) As DataTable

        dtACC.QryDT("select MA_CODE,MA_PRDT,MA_SEQ,MA_REA,MA_DATE,MA_HAND,MA_QTY,MA_RQTY,P_BAL,P_LAST from MAEXP_BOI as t1 left join prdt_" & DBCB.Text & " as t2 on t1.ma_prdt=t2.p_prdt where MA_CODE like '" & Code & "' and MA_SEQ LIKE '" & Page & "' order by p_place,MA_PRDT")
        Return dtACC.dt

    End Function


    Private Sub GV1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GV1.CellEndEdit
        If CDbl(GV1.Rows(e.RowIndex).Cells("QTY").Value) > CDbl(GV1.Rows(e.RowIndex).Cells("BAL").Value) Then
            MsgBox("QTY Error")


        End If
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        SendTab(e.KeyCode)
    End Sub

    Private Sub txtInv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInv.KeyDown
        SendTab(e.KeyCode)
    End Sub

    Private Sub txtQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQTY.KeyDown
        SendTab(e.KeyCode)
    End Sub





    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SwitchMode("idle")
    End Sub

    Private Sub txtHand_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHand.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddBtn_Click(sender, e)
        End If
    End Sub

    Private Sub txtMLot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLot.KeyDown
        'SendTab(e.KeyCode)
    End Sub

    Private Sub txtMPage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMPage.KeyDown
        ' SendTab(e.KeyCode)
    End Sub






  
    Private Sub DelPrdtbtn_Click(sender As Object, e As EventArgs) Handles DelPrdtbtn.Click
        If MsgBox("Do you want to Delete Prdt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim i As Integer = GV1.CurrentCell.RowIndex

            If i > -1 Then
                GV1.Rows.RemoveAt(i)
                GV1.Refresh()

            End If
         

            End If
    End Sub





    Private Sub GV1_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles GV1.RowStateChanged
        If GV1.RowCount - 1 > 0 Then
            lblGVCount.Text = GV1.RowCount - 1 & " รายการ"
        Else
            lblGVCount.Text = ""

        End If

    End Sub

    Private Sub txtMLot_TextChanged(sender As Object, e As EventArgs) Handles txtMLot.TextChanged

    End Sub

    Private Sub txtRea_TextChanged(sender As Object, e As EventArgs) Handles txtRea.TextChanged
        txtRea.Text = txtRea.Text.ToUpper
    End Sub

    Private Sub txtRea_LostFocus(sender As Object, e As EventArgs) Handles txtRea.LostFocus
        Dim datestr As String
        datestr = dtSQL.ExScalar("select convert(varchar,getdate(),120)")
        datestr = Datec.Date120TOstring(datestr)
        txtDate.Text = datestr

        'If txtRea.Text.ToUpper = "S" Or txtRea.Text.ToUpper = "E" Then

        '    txtDate.Enabled = True
        'Else
        txtDate.Enabled = False 'ชั่วคราว

        If txtRea.Text <> "M" Then
            addPrdtbtn.Visible = True
            addPrdtbtn.Enabled = True
        End If
        ' End If

    End Sub


    Private Sub txtReaGet_GotFocus(sender As Object, e As EventArgs) Handles txtReaGet.GotFocus
        txtRea.SelectAll()
    End Sub

    Private Sub txtMLot_GotFocus(sender As Object, e As EventArgs) Handles txtMLot.GotFocus
        txtMLot.SelectAll()
    End Sub


    Private Sub txtMPage_GotFocus(sender As Object, e As EventArgs) Handles txtMPage.GotFocus
        txtMPage.SelectAll()
    End Sub

    Private Sub txtPrdt_TextChanged(sender As Object, e As EventArgs) Handles txtPrdt.TextChanged

    End Sub

    Private Sub txtLOT_TextChanged(sender As Object, e As EventArgs) Handles txtLOT.TextChanged

    End Sub

    Private Sub BtnSK_Click(sender As Object, e As EventArgs) Handles BtnSK.Click

        ' SwitchMode("Add")
        Dim dt As DataTable

        txtDate.Enabled = False
        '  Dim lot As String = txtMLot.Text

        ' dt = GETMAEXP(lot, txtMPage.Text)
        dt = dtACC.QryDT("select E_PRDT,E_QTY-E_AQTY as QTY,p_bal,p_last from EXP_SK left join Prdt_" & DBCB.Text & " as P on EXP_SK.E_PRDT=p.p_prdt where E_SKNO like '" & txtLOT.Text & "'", Project.swanpath)

        If dt.Rows.Count > 0 Then
            ' GV1.Rows.Clear()

            For Each dr As DataRow In dt.Rows
                ' Bal = PrdtC.GETBAL(dr("MA_PRDT").ToString, DBCB.Text)
                GV1.Rows.Add(dr("E_PRDT").ToString, dr("QTY").ToString, dr("P_BAL").ToString, dr("P_LAST").ToString)


            Next
            ' txtRea.Text = dt.Rows(0)("MA_REA").ToString
            '  txtDate.Text = Datec.DateTOstring(Now)
            Dim datestr As String
                datestr = dtSQL.ExScalar("select convert(varchar,getdate(),120)")
                datestr = Datec.Date120TOstring(datestr)
                txtDate.Text = datestr
                ' txtDate.Text = dt.Rows(0)("MA_DATE").ToString
                ' txtHand.Focus()
            Else
                MsgBox("No Data")
                Exit Sub

            End If





        ' txtCode.Text = ScCLS.getMANO(DBCB.Text)
        ' lblKEY.Text = txtCode.Text

        ' txtLOT.Text = txtMLot.Text.ToUpper
        ' txtLOT.Text = txtLOT.Text.Replace("/", "")
        ' txtRea.Enabled = False
        ' txtLOT.Enabled = False
        ' txtPrdt.Enabled = False
        ' txtQTY.Enabled = False
        ' addPrdtbtn.Enabled = False
        ' DelPrdtbtn.Enabled = False
        GV1.ReadOnly = False
        GV1.Columns("PRDT").ReadOnly = True
        GV1.Columns("BAL").ReadOnly = True

        txtHand.Focus()
        ColorGV()
    End Sub
End Class
