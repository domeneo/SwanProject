Imports System.Data.SqlClient
Imports System.Configuration
Public Class LOTInputfrm
    Dim mc As New matchControl
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim SQLstr As String
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connAcc As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    Dim ScCLS As New StockCLS
    Dim Datec As New DateCls
    Dim LogC As New LOGCLS
    Dim autoCom As New autocompleteCLS
    Dim dtPrdt As New DataTable
    Dim dtBom As New DataTable
#Region "FUNCTION"



    Function CheckString() As Boolean
        If TXTCODE.Text = "" Or TXTPRDT.Text = "" Or TXTISDATE.Text = "" Or txtQTY.Text = "" Then

            Return False
        Else

            Return True

        End If
    End Function
    Function GETQA(ByVal ID As String) As DataTable

        dtACC.QryDT("select * from LOT_" & DBCB.Text & " where mc_lot like '" & ID & "' ")
        Return dtACC.dt

    End Function
    Sub GETSK(ByVal ID As String)

        dtACC.QryDT("SELECT * FROM [MEMO] WHERE E_SKNO LIKE '" & ID & "' ")
        With dtACC.dt
            If .Rows.Count > 0 Then
                TXTAREA.Text = .Rows(0)("E_NCSMR").ToString
                TXTCUNO.Text = .Rows(0)("E_TCCSMR").ToString


            End If
        End With

    End Sub


    Sub SwitchMode(ByVal Mode As String)
        LBLSTATUS.Text = Mode
        If Mode = "Edit" Then
            AddBtn.Visible = False
            SaveBtn.Visible = True
            DelBtn.Visible = True
            btnCancel.Visible = True
            TXTAQTY.Enabled = True
        ElseIf Mode = "Add" Then
            ClearBox(Me)
            '  txtCode.Text = dtSQL.ExScalar("select we_no from weno_" & DBCB.Text)
            'txtCode.Enabled = False
            AddBtn.Visible = True
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = True
            TXTAQTY.Text = 0
            TXTAQTY.Enabled = False


            TXTISDATE.Text = Now.ToString("yyyyMMdd")

            '   TXTCODE.Focus()
        ElseIf Mode.ToUpper = "IDLE" Then

            ClearBox(Me)

            lblKEY.Text = ""
            TXTCODE.Enabled = True
            TXTPRDT.Enabled = True
            TXTMA.Enabled = True
            TXTISDATE.Enabled = True
            txtQTY.Enabled = True


            AddBtn.Visible = False
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = False
            LBLSTATUS.Text = ""
            TXTAQTY.Enabled = True

        End If

    End Sub
    Sub NewDATA()

        SwitchMode("Add")
        'txtCode.Text = ScCLS.getMANO(DBCB.Text)
        'lblKEY.Text = txtCode.Text
        ' GV1.Rows.Clear()


    End Sub
    Sub EDITDATA()

        Dim dt As New DataTable
        dt = GETQA(TXTCODE.Text)
        If dt.Rows.Count = 0 Then
            ' MsgBox("No Data")
            Dim tempLOT As String = TXTCODE.Text
            SwitchMode("Add")
            TXTCODE.Text = tempLOT
            lblKEY.Text = ""
            '  TXTMA.Focus()
            Exit Sub

        End If
        mc.DTrowtocon("LOTinput", dt, Me)
        GETSK(TXTSKNO.Text)
        SwitchMode("Edit")




    End Sub

#End Region
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ' Try

        If Not CheckString() Then

            MsgBox("Please Input Data")
            Exit Sub
        End If
        If TXTDEPT.Text.Substring(0, 2) = "24" And TXTCODE.Text.Substring(0, 1).ToUpper <> "G" Then

            If check = False Then
                MsgBox("ของไม่พอเปิดLOT")
                Exit Sub
            End If
        End If

        lblKEY.Text = TXTCODE.Text


        mc.insertSQL("lot_" & DBCB.Text, "LOTinput", Me, "MC_LOT", conn, True)
        mc.insertSQL("lot_" & DBCB.Text, "LOTinput", Me, "MC_LOT", connAcc, True)



        SQLstr = "update  prdt_" & DBCB.Text & " set p_backlog=p_backlog+" & txtQTY.Text & " where p_prdt like '" & TXTISDATE.Text & "'"
        dtSQL.RunCommand(SQLstr)
        dtACC.RunCommand(SQLstr)


        setSENO(TXTPRDT.Text, TXTSN2.Text)

        '  LogC.SaveLOG(DBCB.Text, TXTCODE.Text, "INSERT_LOT", LOGCLS.DBTYPE.ACCESS)
        LogC.SaveLOG(DBCB.Text, TXTCODE.Text, "INSERT_LOT", LOGCLS.DBTYPE.SQLSERVER)

        ClearBox(Me)
        SwitchMode("ADD")

        MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")
        TXTCODE.Focus()
        TXTCODE.Focus()
        'Catch ex As Exception
        ' MsgBox(ex.Message)
        ' End Try
    End Sub

    Private Sub QAfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'init 
        dtSQL.conn = conn
        dtACC.conn = connAcc

        mc.OutConnSQL = conn
        mc.OutConnAcc = connAcc

        AddSendtab(Me)
        ' DBCB.SelectedIndex = 0
        dtACC.QryDT("select P_PRDT from PRDT_BOI order by P_PRDT")
        dtBom = dtACC.dt.Copy()
        dtPrdt = dtACC.dt.Copy()
        autoCom.AutoCompleteTextBox(TXTPRDT, dtPrdt)
        autoCom.AutoCompleteTextBox(TXTBOM, dtBom)
        If lblKEY.Text <> "" Then
            EDITDATA()
        Else
            NewDATA()
        End If

    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If MsgBox("Confirm to Delete?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            dtSQL.RunCommand("delete  from lot_" & DBCB.Text & " where MC_LOT like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from lot_" & DBCB.Text & " where MC_LOT like '" & lblKEY.Text & "'")

            SQLstr = "update  prdt_" & DBCB.Text & " set p_backlog=p_backlog-" & txtQTY.Text & " where p_prdt like '" & TXTISDATE.Text & "'"
            dtSQL.RunCommand(SQLstr)
            dtACC.RunCommand(SQLstr)


           ' LogC.SaveLOG(DBCB.Text, TXTCODE.Text, "DELETE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, TXTCODE.Text, "DELETE", LOGCLS.DBTYPE.SQLSERVER)

            SwitchMode("IDLE")

        End If

    End Sub


    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            If Not CheckString() Then
                MsgBox("Please Input Data")
                Exit Sub
            End If


            mc.updateSQL("LOT_" & DBCB.Text, "LOTinput", Me, "MC_LOT", conn)
            mc.updateSQL("LOT_" & DBCB.Text, "LOTinput", Me, "MC_LOT", connAcc)

            ' LogC.SaveLOG(DBCB.Text, TXTCODE.Text, "UPDATE", LOGCLS.DBTYPE.ACCESS)
            LogC.SaveLOG(DBCB.Text, TXTCODE.Text, "UPDATE", LOGCLS.DBTYPE.SQLSERVER)


            SwitchMode("IDLE")
            TXTPRDT.Focus()

            MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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


    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTISDATE.KeyDown
        If e.KeyCode <> Keys.Enter Then Exit Sub
        If TXTPRDT.Text = "" Then
            TXTPRDT.Focus()
            MsgBox("Please input PRDT")

            Exit Sub
        End If

        If TXTISDATE.Text = "" Then

        End If
        If Not Datec.Checkdate(TXTISDATE.Text) Then
            TXTISDATE.Focus()
            Exit Sub
        End If
        If TXTPRDT.Text.Substring(0, 1).ToUpper <> "C" Then
            Dim DT As Date = Datec.StrtoDatetime(TXTISDATE.Text, "00000")
            DT = DT.AddMonths(1)

            TXTCOMDATE.Text = Datec.DateTOstring(DT)
        End If

        ' SendTab(e.KeyCode)
    End Sub

    Private Sub TXTSKNO_LostFocus(sender As Object, e As EventArgs) Handles TXTSKNO.LostFocus
        GETSK(TXTSKNO.Text)
        If TXTSKNO.Text <> "" Then
            TXTNOTE.Text = "SK-" & TXTSKNO.Text & "     " & TXTAREA.Text
        End If
    End Sub
    Function getSENO(Prdt As String)
        dtSQL.QryDT("select * from LOT_SENO where s_model like '" & Prdt.Substring(4, 3) & "'")
        With dtSQL.dt
            If .Rows.Count > 0 Then
                Dim Seno As String = .Rows(0)("s_seno").ToString
                If Seno = "" Then
                    Return ""
                    Exit Function
                End If
                '  If Seno.Substring(0, 2) <> Now.Year.ToString.Substring(2, 2) Then

                ' Seno = Now.Year.ToString.Substring(2, 2) & Seno.Substring(2, 2) & "0001"
                ' End If
                Return Seno
            Else

                Return ""
            End If
        End With
    End Function
    Sub setSENO(Prdt As String, Seno As String)
        If Seno = "" Then Exit Sub
        If Prdt.Substring(0, 1).ToUpper <> "C" Then Exit Sub
        Dim model As String = Prdt.Substring(4, 3)
        dtSQL.RunCommand("update LOT_SENO set s_seno=" & Seno + 1 & " where s_model like '" & model & "'")

    End Sub

    Private Sub txtQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQTY.KeyDown
        If e.KeyCode = Keys.Enter Then

            If TXTPRDT.Text.Substring(0, 1).ToUpper = "C" Then

                TXTSN1.Text = getSENO(TXTPRDT.Text)
                If TXTSN1.Text <> "" And txtQTY.Text <> "" Then
                    TXTSN2.Text = Val(TXTSN1.Text) + Val(txtQTY.Text) - 1

                End If

            End If
            checkBomP1()
        End If
    End Sub


    Private Sub TXTCODE_LostFocus(sender As Object, e As EventArgs) Handles TXTCODE.LostFocus
        If TXTCODE.Text <> "" Then

            EDITDATA()
            If TXTCODE.Text = "" Then SwitchMode("ADD")
        End If
    End Sub

    Private Sub TXTPRDT_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPRDT.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TXTPRDT.Text.Substring(0, 1).ToUpper <> "C" Then
                TXTBOM.Text = TXTPRDT.Text
                TXTCLOSE.Text = ""
            Else
                TXTBOM.Text = TXTPRDT.Text
                TXTCLOSE.Text = 5
            End If

        End If
    End Sub

    Private Sub DBCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBCB.SelectedIndexChanged
        If DBCB.Text = "BOI" Then
            Me.BackColor = Color.White
        Else
            Me.BackColor = Color.LightBlue

        End If
    End Sub

    Private Sub TXTCODE_TextChanged(sender As Object, e As EventArgs) Handles TXTCODE.TextChanged

    End Sub

    Private Sub btnPrintQA_Click(sender As Object, e As EventArgs) Handles btnPrintQA.Click
        If TXTCLOSE.Text = "5" Then
            TXTCLOSE.Text = ""

        ElseIf TXTCLOSE.Text = "" Then
            TXTCLOSE.Text = "5"
        Else
            MsgBox("Can't Print QA this LOT.")
            Exit Sub
        End If
        dtACC.RunCommand("update LOT_" & DBCB.Text & " set mc_close = '" & TXTCLOSE.Text & "'  where mc_lot like '" & TXTCODE.Text & "'")
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setSENO(TXTPRDT.Text, TXTSN2.Text)
    End Sub

    Private Sub TXTISDATE_TextChanged(sender As Object, e As EventArgs) Handles TXTISDATE.TextChanged

    End Sub

    Private Sub TXTISDATE_GotFocus(sender As Object, e As EventArgs) Handles TXTISDATE.GotFocus
        TXTISDATE.SelectAll()
    End Sub

    Private Sub TXTCOMDATE_TextChanged(sender As Object, e As EventArgs) Handles TXTCOMDATE.TextChanged

    End Sub

    Private Sub TXTCOMDATE_GotFocus(sender As Object, e As EventArgs) Handles TXTCOMDATE.GotFocus
        TXTCOMDATE.SelectAll()
    End Sub


    Private Sub txtQTY_LostFocus(sender As Object, e As EventArgs) Handles txtQTY.LostFocus


    End Sub

    Dim check As Boolean
    Sub checkBomP1()
        If TXTDEPT.Text.Length < 3 Then Exit Sub
        If TXTDEPT.Text.Substring(0, 2) <> "24" Or TXTCODE.Text.Substring(0, 1).ToUpper = "G" Then
            TXTAQTY.Focus()
            DGVBOM.Visible = False
            Exit Sub
        End If

        If txtQTY.Text = "" Then Exit Sub
        Dim frmp As New ProgressFrm
        frmp.Show()
        frmp.PGB.Maximum = 2

        Try
            DGVBOM.Visible = True

            SQLstr = "select b_scode,b_qty,b_qty * " & txtQTY.Text & " as QTY,p_ename,p_bal,p_backlog from bom_" & DBCB.Text & " as b inner join prdt_" & DBCB.Text & " as p"
            SQLstr += " on b.b_scode=p.p_prdt"
            SQLstr += " where b_pcode like '" & TXTPRDT.Text & "'"
            DGVBOM.DataSource = dtACC.QryDT(SQLstr, Project.swanpath)
            If DGVBOM.RowCount = 0 Then Exit Sub


            check = True
            For Each dr As DataGridViewRow In DGVBOM.Rows
                If dr.Cells("QTY").Value > dr.Cells("p_bal").Value Then
                    dr.DefaultCellStyle.ForeColor = Color.Red
                    check = False
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmp.Close()
        End Try

        If check = False Then
                MsgBox("ของไม่พอเปิด LOT")
                TXTCOMDATE.Focus()
                TXTCOMDATE.Focus()


            Else

            txtQTY.Focus()
            txtQTY.Focus()
        End If


    End Sub

    Private Sub txtQTY_Layout(sender As Object, e As LayoutEventArgs) Handles txtQTY.Layout

    End Sub
End Class
