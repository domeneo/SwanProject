Imports System.Data.SqlClient
Imports System.Configuration
Public Class editstockfrm
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
        If GV1.Rows.Count = 0 And txtDate.Text = "" And txtHand.Text = "" Then

            Return False

        Else
            Return True

        End If
    End Function

    Sub SwitchMode(ByVal Mode As String)
        LBLSTATUS.Text = Mode
        If Mode.ToUpper = "EDIT" Then
            AddBtn.Visible = False
            SaveBtn.Visible = True
            DelBtn.Visible = True
            btnCancel.Visible = True

            txtLOT.Enabled = True

            txtPrdt.Enabled = True
            txtQTY.Enabled = True
        ElseIf Mode.ToUpper = "ADD" Then
            ClearBox(Me)
            ' txtCode.Text = ScCLS.getMANO(DBCB.Text)
            txtCode.Enabled = True
            AddBtn.Visible = True
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = True

            txtLOT.Enabled = True

            txtPrdt.Enabled = True
            txtQTY.Enabled = True
            Dim datestr As String
            datestr = dtSQL.ExScalar("select convert(varchar,getdate(),120)")
            datestr = Datec.Date120TOstring(datestr)
            txtDate.Text = datestr
            ' datestr = dtACC.ExScalar("select Format(Now(), 'yyyyMMdd')")

            '  txtDate.Text = Datec.DateTOstring(datestr)
        ElseIf Mode.ToUpper = "IDLE" Then

            ClearBox(Me)
            GV1.Rows.Clear()
            lblKEY.Text = ""
            txtCode.Enabled = True
            txtLOT.Enabled = True

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
        CheckForIllegalCrossThreadCalls = False
        dtSQL.conn = conn
        dtACC.conn = connAcc
        mc.OutConnSQL = conn
        mc.OutConnAcc = connAcc
        mc.OutDB = "SQL"


        AddSendtab(Me)
        RemoveHandler txtPrdt.KeyDown, AddressOf TextBox_Keydown
        RemoveHandler txtHand.KeyDown, AddressOf TextBox_Keydown
        'Dim Autocom As New autocompleteCLS
        'Dim AUTOdtc As New dataSQLcls
        'AUTOdtc.conn = conn
        'AUTOdtc.QryDT("select P_PRDT from Prdt_BOI order by P_PRDT")

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
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ' Try
        If Not CheckString() Then
            MsgBox("Please Input Data")
            Exit Sub

        End If
        ' If Not CheckBalInGV() Then

        '   MsgBox("Please Check QTY")
        '  Exit Sub
        'End If

        If TxtLotClose.Text = "9" Then
            MsgBox("LOT is close")
            Exit Sub
        End If


        txtCode.Text = ScCLS.getMBNO(DBCB.Text)
        lblKEY.Text = txtCode.Text

        'If dr.Cells("QTY").Value > dr.Cells("BAL").Value Then
        '    SQLstr = "insert into stock_" & DBCB.Text & "(s_prdt,s_qty,s_code,s_slip,s_rea,s_date,s_inv"


        ' mc.insertSQLGV("stock_" & DBCB.Text, "MBinput", Me, GV1, txtCode.Text, conn)
        ' mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, conn)

        mc.insertSQLGV("stock_" & DBCB.Text, "MBinput", Me, GV1, txtCode.Text, connAcc)
        ' mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, connAcc)


        For Each dr As DataGridViewRow In GV1.Rows
            If dr.Cells("PRDT").Value Is Nothing Then Continue For
            If dr.Cells("REA").Value.ToString.ToUpper = "B" Then
                SQLstr = "update  prdt_" & DBCB.Text & " set p_BAL=p_BAL + " & dr.Cells("QTY").Value & ",P_SET='*' where p_prdt like '" & dr.Cells("PRDT").Value & "'"
                ' dtSQL.RunCommand(SQLstr)
                dtACC.RunCommand(SQLstr)

            End If

            If txtLotDEPT.Text.Length > 2 Then



                If txtLotDEPT.Text.Substring(1, 2) = "23" Or txtLotDEPT.Text = "221" Then

                    SQLstr = "update  MAFILE_" & DBCB.Text & " set MA_RQTY=MA_RQTY -" & txtQTY.Text & " where ma_code like '" & txtLOT.Text & "' and ma_prdt like '" & dr.Cells("PRDT").Value & "'"
                    '  dtSQL.RunCommand(SQLstr)
                    If dtACC.RunCommand(SQLstr) = 0 Then

                        SQLstr = "insert into  MAFILE_" & DBCB.Text & " values(MA_CODE,MA_SEQ,MA_PRDT,MA_QTY,MA_PLACE) values('" & txtLOT.Text & "',0,'" & dr.Cells("PRDT").Value & "'," & txtQTY.Text & ",'" & dr.Cells("PLACE").Value & "')"
                        ' dtSQL.RunCommand(SQLstr)
                        dtACC.RunCommand(SQLstr)
                    End If
                End If

                If txtLotDEPT.Text.Substring(1, 2) = "24" Or txtLotDEPT.Text = "313" Then
                    SQLstr = "update  lot_" & DBCB.Text & " set mc_qty=mc_qty +" & dr.Cells("qty").Value & ",mc_clsd='" & txtDate.Text & "' where mc_lot like '" & txtLOT.Text & "'"
                    ' dtSQL.RunCommand(SQLstr)
                    '    dtACC.RunCommand(SQLstr)
                End If
            End If


        Next
        If txtLotDEPT.Text.Length > 2 Then


            If txtLotDEPT.Text.Substring(1, 2) = "24" Or txtLotDEPT.Text = "313" Then




                SQLstr = "update  LOT_" & DBCB.Text & " set mc_close=case when mc_lotqty<=mc_qty then '7' when mc_lotqty>mc_qty then '5'  end where mc_lot like '" & txtLOT.Text & "'"
                ' dtSQL.RunCommand(SQLstr)
                ' dtACC.RunCommand(SQLstr)


            End If

        End If




        ' LogC.SaveLOG(DBCB.Text, txtCode.Text, "INSERT", LOGCLS.DBTYPE.ACCESS)
        LogC.SaveLOG(DBCB.Text, txtCode.Text, "INSERT", LOGCLS.DBTYPE.SQLSERVER)

        ScCLS.incMBNO(DBCB.Text)

        Try
            SQLstr = "update stock_" & DBCB.Text & " set s_time=now() where s_code ='" & lblKEY.Text & "'"
            dtACC.RunCommand(SQLstr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgBox("บันทึกสำเร็จ Code is " & lblKEY.Text, MsgBoxStyle.OkOnly, "Success")
        'Catch ex As Exception
        ' MsgBox(ex.Message)
        ' End Try

        SwitchMode("IDLE")
        cmdNEW_Click(sender, e)
        'txtLOT.Focus()
    End Sub
    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If MsgBox("Confirm to Delete?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            'dtSQL.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")
            For Each dr As DataGridViewRow In GV1.Rows


                If dr.Cells("PRDT").Value Is Nothing Then Continue For
                SQLstr = "update  prdt_" & DBCB.Text & " set p_BAL=p_BAL - " & dr.Cells("qty").Value & " where p_prdt like '" & dr.Cells("PRDT").Value & "'"
                '  dtSQL.RunCommand(SQLstr)

                SQLstr = "update  prdt_" & DBCB.Text & " set p_BAL=p_BAL - " & dr.Cells("qty").Value & " where p_prdt like '" & dr.Cells("PRDT").Value & "'"
                dtACC.RunCommand(SQLstr)
            Next



            ' LogC.SaveLOG(DBCB.Text, txtCode.Text, "DELETE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "DELETE", LOGCLS.DBTYPE.SQLSERVER)


            SwitchMode("IDLE")
        End If

    End Sub
    Function GETQA(ByVal ID As String) As DataTable
        Dim connstr As String
        If DBCB.Text = "BOI" Then
            connstr = Project.md2_boi
        Else
            connstr = Project.md2_tax
        End If

        Return dtACC.QryDT("select * from stock where s_code like '" & ID & "' ", connstr)


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


            If txtEditcode.Text.Trim = "" Then

                MsgBox("กรุณารันหมายเลขการแก้ไข")
                Exit Sub
            End If
            saveedit()

            Dim Connstr As String
            If DBCB.Text = "BOI" Then
                Connstr = Project.md2_boi
            Else
                Connstr = Project.md2_tax
            End If


            dtACC.RunCommand("delete  from stock where s_code like '" & lblKEY.Text & "'", Connstr)


            Using conn As New OleDb.OleDbConnection(Connstr)

                conn.Open()
                mc.insertSQLGV("stock", "editinput", Me, GV1, txtCode.Text, conn)

            End Using



            dtSQL.RunCommand("delete  from stock_" & DBCB.Text & " where s_code like '" & lblKEY.Text & "'")
            mc.insertSQLGV_CONNstrSQL("stock_" & DBCB.Text, "editinput", Me, GV1, txtCode.Text, Project.swanSQL)
            For Each dr As DataGridViewRow In GV1.Rows

                ' mc.insertSQLGV("stock_" & DBCB.Text, "MAinput", Me, GV1, txtCode.Text, conn)
                ' mc.updateSQL("stock_" & DBCB.Text, "MAinput", Me, txtCode.Text, conn)
                '  mc.insertSQLGV("stock_" & DBCB.Text, "MBinput", Me, GV1, txtCode.Text, connAcc)
                '  mc.updateSQL("stock_" & DBCB.Text, "MBinput", Me, txtCode.Text, connAcc)

            Next

            '  LogC.SaveLOG(DBCB.Text, txtCode.Text, "UPDATE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, txtCode.Text, "UPDATE", LOGCLS.DBTYPE.SQLSERVER)


            txtCode.Focus()
            MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")
            SwitchMode("IDLE")
            GetBtn.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim PRDTDT As New DataTable
    Sub AutocomPRDT()
        dtSQL.conn = conn
        dtSQL.QryDT("select P_PRDT from PRDT_" & DBCB.Text & " where P_PRDT not like '' order by P_PRDT")
        PRDTDT = dtSQL.dt
        AutoCom.AutoCompleteTextBox(txtPrdt, PRDTDT)
    End Sub
    Dim LOTDT As New DataTable
    Sub AutocomLOT()
        dtSQL.conn = conn
        dtSQL.QryDT("select MC_LOT from LOT_" & DBCB.Text & " where MC_LOT not like '' order by MC_LOT")
        LOTDT = dtSQL.dt
        AutoCom.AutoCompleteTextBox(txtLOT, LOTDT)
    End Sub

    Sub CloseLOT()
        'ปิดLot ผลิต
        SQLstr = "update  LOT_" & DBCB.Text & " set mc_close=case when mc_lotqty=mc_qty then '7' when we_qty<>we_dqty then '5'  end where mc_lot like '" & txtLOT.Text & "'"
        ' dtSQL.RunCommand(SQLstr)

        SQLstr = "update  LOT_" & DBCB.Text & " set mc_close=case when mc_lotqty=mc_qty then '7' when we_qty<>we_dqty then '5'  end where mc_lot like '" & txtLOT.Text & "'"
        dtACC.RunCommand(SQLstr)

        'ปิดLot จัดซื้อ
        SQLstr = "update  odfile_" & DBCB.Text & " set we_close=case when we_qty=we_dqty then '9' when we_qty<>we_dqty and we_dqty<>0 then '4' else '3' end where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
        '  dtSQL.RunCommand(SQLstr)

        SQLstr = "update  odfile_" & DBCB.Text & " set we_close=case when we_qty=we_dqty then '9' when we_qty<>we_dqty and we_dqty<>0 then '4' else '3' end where we_prdt like '" & txtPrdt.Text & "' and we_code like '" & txtLOT.Text & "'"
        dtACC.RunCommand(SQLstr)
    End Sub


    Sub CheckLOT()
        Dim ProGbar As New ProgressFrm
        Try
            'If Me.InvokeRequired Then
            '    Me.Invoke(New MethodInvoker(delegate
            '                    { })
            'End If


            ProGbar.Text = "กำลังตรวจสอบ LOT"
            ProGbar.Show()
            ProGbar.PGB.Maximum = 2
            ProGbar.PGB.Value = 0

            If txtLOT.Text = "" Then Exit Sub
            SQLstr = "select LOTDB,mc_lot,mc_PRDT_THAI,mc_close,mc_date,mc_dept from lotall where mc_lot like '" & txtLOT.Text & "' "
            dtACC.QryDT(SQLstr)
            ProGbar.PGB.Value += 1
            If dtACC.dt.Rows.Count > 0 Then
                If dtACC.dt.Rows(0)("MC_CLOSE") = "9" Then
                    '        If MsgBox("Lot is close.Do you want to continue?", vbYesNo, "Lot is close") = vbYes Then
                    '            txtdate.SetFocus
                    '            Exit Sub
                    '        End If
                    MsgBox("Lot is close.")
                    TxtLotClose.Text = dtACC.dt.Rows(0)("mc_close").ToString
                    '  ProGbar.Close()
                Else
                    'SQLstr = "select *  from BOM_" & rs!LOTDB & " where b_PCODE like '" & rs!mc_prdt_thai & "'"
                    'OpenRS(SQLstr, rsBOM, conn2)
                    'txtDate.SetFocus()
                    'Unload(ProGbar)
                    'Exit Sub
                    txtLotDate.Text = dtACC.dt.Rows(0)("mc_date").ToString
                    TxtLotClose.Text = dtACC.dt.Rows(0)("mc_close").ToString
                    txtLotDEPT.Text = dtACC.dt.Rows(0)("mc_dept").ToString
                    'txtDate.Focus()
                    'ProGbar.Close()
                    Exit Sub
                End If
            Else
                If MsgBox("Lot not found.Do you want to continue?", vbYesNo, "Lot not found") = vbYes Then
                    txtDate.Focus()
                    '  ProGbar.Close()
                    Exit Sub
                End If
            End If

            'txtDate.Focus()

            '  ProGbar.Close()

            SelectTextTB(txtLOT)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            ProGbar.Close()
            ProGbar.Dispose()
        End Try


    End Sub
    Private Sub txtLOT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLOT.KeyDown
        If e.KeyCode <> Keys.Enter Then Exit Sub
        'Dim thd As New Threading.Thread(AddressOf CheckLOT)


        'thd.IsBackground = True
        'thd.Start()
        CheckLOT()
    End Sub


    Sub NewDATA()

        SwitchMode("Add")
        'txtCode.Text = ScCLS.getMANO(DBCB.Text)
        'lblKEY.Text = txtCode.Text
        GV1.Rows.Clear()
        txtLOT.Focus()
    End Sub
    Public Sub EDITDATA()
        Try

            If txtCode.Text.Trim = "" Then
                Exit Sub
            End If
            Dim dt As New DataTable
            dt = GETQA(txtCode.Text)
            If dt.Rows.Count = 0 Then
                MsgBox("No Data")
                Exit Sub
            End If
            mc.DTrowtocon("editinput", dt, Me)
            Try


                txtstime.Text = CDate(dt.Rows(0)("s_time")).ToString("yyyy-MM-dd HH:mm:ss")
            Catch ex As Exception

            End Try
            GV1.Rows.Clear()
            ' Dim Bal, Price As Double
            ' mc.DTtoGV("Mbinput", GV1, Me, dt)
            For Each dr As DataRow In dt.Rows
                ' Bal = PrdtC.GETBAL(dr("S_PRDT").ToString, DBCB.Text)
                ' Price = PrdtC.GETPrice(dr("S_PRDT").ToString, DBCB.Text)
                GV1.Rows.Add(dr("S_PRDT").ToString, dr("S_QTY").ToString, dr("S_REA").ToString, dr("s_reades").ToString, dr("S_CSMR").ToString, dr("S_supno").ToString, dr("s_price").ToString, dr("s_invo").ToString, dr("S_bal").ToString, dr("s_KG").ToString, dr("s_month").ToString, dr("s_note").ToString)

                ' GV1.Rows.Add(txtPrdt.Text.ToUpper, txtQTY.Text, CBREA.Text.ToUpper, txtDept.Text.ToUpper, txtCond.Text.ToUpper, txtSUP.Text.ToUpper, txtPrice.Text, txtPlace.Text, TXTBAL.Text)

            Next

            lblKEY.Text = txtCode.Text
            SwitchMode("Edit")


            getedit_detail()
            '  CheckLOT()

            GV1.ReadOnly = False
            ' GV1.Columns("PRDT").ReadOnly = True
            GV1.Columns("BAL").ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetBtn.Click
        EDITDATA()
    End Sub

    Private Sub cmdNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
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
            MsgBox("รูปแบบวันที่ไม่ถูกต้อง")
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
        '  SQLstr = "select P_prdt from prdt_" & DBCB.Text & " where p_prdt ='" + txtPrdt.Text + "'"

        ' If dtSQL.ExScalar(SQLstr) = "" Then
        If txtPrdt.Text = "" Then
            MsgBox("PRDT Not Found", , "Error")
            SelectTextTB(txtPrdt)

            Exit Sub
        End If
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


        'For Each row As DataGridViewRow In GV1.Rows
        '    If Not row.Cells(0).Value Is Nothing Then
        '        If row.Cells(0).Value.ToString().Equals(txtPrdt.Text) Then
        '            MsgBox("Prdtนี้ได้ถูกใส่แล้ว", MsgBoxStyle.OkOnly, "Error")
        '            Exit Sub
        '        End If
        '    End If
        'Next

        ' GV1.Rows.Add(txtPrdt.Text, txtQTY.Text, txtStock.Text)
        ' mc.DTtoGV("MAinput", GV1, Me)

        Dim westr As String = ""
        If lblslip.Text = "WE" And CBREA.Text = "S" Then
            westr = "#"
        End If
        GV1.Rows.Add(txtPrdt.Text.ToUpper, txtQTY.Text, CBREA.Text.ToUpper, txtCond.Text.ToUpper, txtDept.Text.ToUpper, txtSUP.Text.ToUpper, txtPrice.Text, txtINV.Text, TXTBAL.Text, 0, westr)



        txtQTY.Text = ""
        txtDept.Text = ""
        txtCond.Text = ""
        txtSUP.Text = ""
        SelectTextTB(txtPrdt)
        'txtreason.Text = ""
        'txtreasondes.Text = ""
        'txtdep.Text = ""


    End Sub

    Private Sub DBCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBCB.SelectedIndexChanged

        '  Dim lotthd As New Threading.Thread(AddressOf AutocomLOT)
        ' lotthd.IsBackground = True
        ' lotthd.Start()
        '  AutocomPRDT()
        ' Dim prdtthd As New Threading.Thread(AddressOf AutocomPRDT)
        '   prdtthd.IsBackground = True
        ' prdtthd.Start()
        If DBCB.Text = "BOI" Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.LightBlue

        End If

        AutocomLOT()
        AutocomPRDT()
    End Sub

    Private Sub txtPrdt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrdt.KeyDown
        If e.Shift And e.KeyCode = Keys.Enter Then
            txtHand.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            txtQTY.Focus()
            '  SendTab(e.KeyCode)
        End If

    End Sub

    Private Sub txtPrdt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrdt.LostFocus
        If Len(txtPrdt.Text) = 11 Then
            PrdtC.GetDATA(txtPrdt.Text, DBCB.Text)
            'txtStock.Text = PrdtC.Bal
            txtPrdtName.Text = PrdtC.Name
            txtPrdtSpec.Text = PrdtC.SPEC
            txtPrice.Text = PrdtC.Price
            txtPlace.Text = PrdtC.PLACE
            TXTBAL.Text = PrdtC.Bal
        End If
    End Sub

    Private Sub txtRea_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.M Or e.KeyCode = Keys.S Then
            'e.Handled = True
            e.SuppressKeyPress = True
        End If

        SendTab(e.KeyCode)
    End Sub



    Sub ColorGV()

        For Each dr As DataGridViewRow In GV1.Rows
            If dr.Cells("QTY").Value > dr.Cells("BAL").Value Then
                dr.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
    Function CheckBalInGV() As Boolean

        For Each dr As DataGridViewRow In GV1.Rows
            If CDbl(dr.Cells("QTY").Value) > CDbl(dr.Cells("BAL").Value) Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Function GETMAFile(ByVal Code As String, Page As String) As DataTable

        dtACC.QryDT("select MA_CODE,MA_PRDT,MA_SEQ,MA_REA,MA_DATE,MA_HAND,MA_QTY,MA_RQTY,P_BAL,P_LAST from MAFILE_" & DBCB.Text & " as t1 left join prdt_" & DBCB.Text & " as t2 on t1.ma_prdt=t2.p_prdt where MA_CODE like '" & Code & "' and MA_SEQ LIKE '" & Page & "'")
        Return dtACC.dt

    End Function
    Function GETMAEXP(ByVal Code As String, Page As String) As DataTable


        dtACC.QryDT("select MA_CODE,MA_PRDT,MA_SEQ,MA_REA,MA_DATE,MA_HAND,MA_QTY,MA_RQTY,P_BAL,P_LAST from MAEXP_" & DBCB.Text & " as t1 left join prdt_" & DBCB.Text & " as t2 on t1.ma_prdt=t2.p_prdt where MA_CODE like '" & Code & "' and MA_SEQ LIKE '" & Page & "'")
        Return dtACC.dt

    End Function

    Private Sub GV1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GV1.CellEndEdit
        'If CDbl(GV1.Rows(e.RowIndex).Cells("QTY").Value) > CDbl(GV1.Rows(e.RowIndex).Cells("BAL").Value) Then
        'MsgBox("QTY Error")


        '  End If
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        'SendTab(e.KeyCode)
        If e.KeyCode = Keys.Enter Then


            If txtCode.Text <> "" Then

                EDITDATA()
                If txtCode.Text = "" Then SwitchMode("ADD")
            End If

        End If
    End Sub

    Private Sub txtBlot_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBlot.KeyDown
        'SendTab(e.KeyCode)
    End Sub

    Private Sub txtQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQTY.KeyDown
        'SendTab(e.KeyCode)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SwitchMode("idle")
    End Sub

    Private Sub txtHand_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHand.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddBtn_Click(sender, e)
        End If
    End Sub

    Private Sub txtMLot_KeyDown(sender As Object, e As KeyEventArgs)
        SendTab(e.KeyCode)
    End Sub

    Private Sub txtMPage_KeyDown(sender As Object, e As KeyEventArgs)
        SendTab(e.KeyCode)
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

    Private Sub txtPrdt_TextChanged(sender As Object, e As EventArgs) Handles txtPrdt.TextChanged

    End Sub

    Private Sub btnnew_editcode_Click(sender As Object, e As EventArgs) Handles btnnew_editcode.Click
        txtEditcode.Text = dtSQL.ExScalar("select top 1 e_id from stock_edit order by e_id desc")
        Try
            txtEditcode.Text += 1
        Catch ex As Exception
            txtEditcode.Text = 1
        End Try
    End Sub
    Sub getedit_detail()
        If txtEditcode.Text.Trim = "" Then
            txtEditreq.Text = ""
            txtedittime.Text = ""
            txtedtior.Text = ""
            txtEditNote.Text = ""
            Exit Sub
        End If
        dtSQL.QryDT("select * from stock_edit where e_id ='" & txtEditcode.Text & "'")



        For Each dr As DataRow In dtSQL.dt.Rows

            txtEditreq.Text = dr("E_REQ").ToString()
            txtEditNote.Text = dr("E_DETAIL").ToString()
            txtedtior.Text = dr("E_EDITOR").ToString()
            txtedittime.Text = dr("E_TIME").ToString()
        Next
    End Sub
    Sub saveedit()

        txtedtior.Text = Project.User
        Dim sqlstr As String

        sqlstr = " Update stock_edit SET E_REQ='" & txtEditreq.Text & "',E_DETAIL='" & txtEditNote.Text & "',E_EDITOR='" & txtedtior.Text & "',E_TIME=getdate() WHERE e_id='" & txtEditcode.Text & "'"

        sqlstr += "  If @@ROWCOUNT = 0 "
        sqlstr += "   INSERT INTO stock_edit (e_id,E_REQ,E_DETAIL,E_EDITOR,E_TIME) VALUES ('" & txtEditcode.Text & "','" & txtEditreq.Text & "','" & txtEditNote.Text & "','" & txtedtior.Text & "',getdate()) "
        dtSQL.RunCommand(sqlstr)
    End Sub

    Private Sub btnget_editcode_Click(sender As Object, e As EventArgs) Handles btnget_editcode.Click
        getedit_detail()
    End Sub
End Class
