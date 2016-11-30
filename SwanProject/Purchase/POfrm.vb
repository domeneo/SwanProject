Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class POfrm

    Dim Bsource As New BindingSource
    Dim dbAcc As New dataACCcls
    Dim db As New dataSQLcls
    Dim PODT, POsubDT As New DataTable

    Dim autocon As New autocompleteCLS
    Dim dtprdt As New DataTable
    Dim dtprdtname As New DataTable
    Dim prdt As New PrdtCls

    Sub FindinList(ByVal DGV As DataGridView, ByVal strFind As String, Column As String)
        Dim i As Integer = 0
        DGV.MultiSelect = False
        For Each dr As DataGridViewRow In DGV.Rows
            If dr.Cells(Column).Value = strFind Then
                dr.Cells(0).Selected = True
                Exit Sub
            End If
        Next

        'MsgBox("Not Found", MsgBoxStyle.OkOnly)
    End Sub
    Public Function UpdateBind(Dt As DataTable)

        Dim SQLstr As String = "select * from po_profile"
        Dim conn As New SqlConnection(Project.swanSQL)
        Try

            Dim cmdBuilder As New SqlCommandBuilder
            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(SQLstr, conn)
            cmdBuilder.DataAdapter = da
            'da.SelectCommand.CommandText = SQLstr
            da.UpdateCommand = cmdBuilder.GetUpdateCommand
            da.DeleteCommand = cmdBuilder.GetDeleteCommand
            '  da.ContinueUpdateOnError = True

            'da.Update(Dt)
            'Dt.AcceptChanges()
            da.Update(Dt)
            Dt.AcceptChanges()
            ' End Using
            'Dim cmdBuilder As New System.Data.SqlClient.SqlCommandBuilder(da)


            ' MsgBox("Succressfull")
            Return True
        Catch ex As Exception
            '  ErrHandler(ex)
            ' Return False
            Dim str As String
            If ex.Message.Contains("Concurrency violation") Then
                str = "ควรปิดโปรแกรมแล้วเปิดใหม่ : " & ex.Message
            Else
                str = ex.Message

            End If
            MsgBox(str)
        Finally
            conn.Close()
            conn.Dispose()

        End Try


    End Function
    Sub FormatDGV()
        DGV1.Columns(0).Width = 30
        DGV1.Columns(1).Width = 120
        DGV1.Columns(2).Width = 120
        DGV1.Columns(3).Width = 120
        'DGV1.Columns(4).Width = 60
        'DGV1.Columns(5).Width = 60
        'DGV1.Columns(6).Width = 60
        'DGV1.Columns(7).Width = 60
        'DGV1.Columns(8).Width = 60
        'DGV1.Columns(9).Width = 60
        'DGV1.Columns(10).Width = 60
        'DGV1.Columns(11).Width = 60
        'DGV1.Columns(12).Width = 40
        'DGV1.Columns(12).ReadOnly = True

        'Dim btn As New DataGridViewButtonColumn()
        'btn.HeaderText = "PrintMI"
        'btn.Text = "PrintMI"
        'btn.Name = "PrintMIbtn"
        'btn.UseColumnTextForButtonValue = True
        'btn.Width = 60
        'DGV1.Columns.Add(btn)


        'Dim btnExportMI As New DataGridViewButtonColumn()
        'btnExportMI.HeaderText = "ExportMI"
        'btnExportMI.Text = "ExportMI"
        'btnExportMI.Name = "ExportMIbtn"
        'btnExportMI.UseColumnTextForButtonValue = True
        'btnExportMI.Width = 60
        'DGV1.Columns.Add(btnExportMI)

        'Dim btnopenMI As New DataGridViewButtonColumn()
        'btnopenMI.HeaderText = "OpenMI"
        'btnopenMI.Text = "OpenMI"
        'btnopenMI.Name = "OpenMIbtn"
        'btnopenMI.UseColumnTextForButtonValue = True
        'btnopenMI.Width = 60
        'DGV1.Columns.Add(btnopenMI)
    End Sub
    Dim dtSup, dtEMP, dtLot, dtpr As New DataTable

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case (Keys.Control Or Keys.S)
                SaveBtn.PerformClick()
            Case (Keys.Control Or Keys.N)
                newBtn.PerformClick()
            Case (Keys.Control Or Keys.Q)
                cancelbtn.PerformClick()
                'Do Nothing
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Public Function GetPOlist(Optional TOP As String = "", Optional sqlwhere As String = "")

        Return db.QryDT("select " & TOP & " * from PO_profile pf " & sqlwhere & " order by pf.po_code desc", Project.swanSQL)
    End Function

    Function GetPOData(Optional code As String = "")
        Dim sqlstr As String
        sqlstr = "select * from PO inner join po_profile as PP on po.po_code=pp.po_code"
        If code <> "" Then sqlstr += " where pp.po_code like '" & code & "'"
        Return db.QryDT(sqlstr, Project.swanSQL)
    End Function
    Function GetPODetail(Optional code As String = "")
        Dim sqlstr As String
        sqlstr = "select [PO_ORDER] as [Order],[PO_CODE],[PO_PRDT],[PO_PNAME],[PO_QTY],[PO_PRICE],[PO_QTY]*[PO_PRICE] as amount,[PO_DATE],[PO_UNIT] from  po"
        If code <> "" Then sqlstr += " where po_code like '" & code & "'"
        Return db.QryDT(sqlstr, Project.swanSQL)
    End Function

    Function getSup(code As String)

        dbAcc.QryDT("select * from supmast where s_sup like '" & code & "'", strAccess(Project.md5_tax))
    End Function
    Private Sub PO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            DGVList.AutoGenerateColumns = False
            Me.WindowState = FormWindowState.Maximized


            db.openConn(Project.swanSQL)
            AddSendtab(POGrp)
            AddSendtab(GBinput)
            AddSendtab(GBTotal)
            '  ChkPermission()



            dtprdt = db.QryDT("select cast(P_PRDT as nvarchar(20)) + ':' + cast(P_TNAME  as nvarchar(max)) + ':' + cast(P_SPEC  as nvarchar(max)) from PRDT_TAX order by P_PRDT", Project.swanSQL)
            autocon.AutoCompleteTextBox(txtPrdt, dtprdt)


            dtprdt = db.QryDT("select distinct PO_pname from PO order by PO_pname", Project.swanSQL)
            autocon.AutoCompleteTextBox(txtPrdtname, dtprdtname)

            dtSup = dbAcc.QryDT("select s_sup from supmast order by s_sup", strAccess(Project.md5_tax))
            autocon.AutoCompleteTextBox(txtSupNo, dtSup)


            PODT = GetPOData()
            Bsource.DataSource = PODT
            BindingData()

            FilterGV()
            POsubDT = GetPOData(txtPOno.Text)
            DGV1.DataSource = POsubDT
            ' CalPrice()
            FormatDGV()
            'GetorderName()
            'GetlotPR()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function GetSumPrice(DT As DataTable)
        Dim sumprice As Double
        For Each dr As DataRow In DT.Rows
            sumprice += dr.Item("amount")
        Next
        Return sumprice
    End Function
    Sub CalPrice()
        'If IsNumeric(txtDiscount.Text) = False Then txtDiscount.Text = 0
        Dim dt As DataTable = DGV1.DataSource
        'If dt.Select("isnull(cancel,false) <> True").Count > 0 Then
        '    dt = dt.Select("isnull(cancel,false) <> True").CopyToDataTable
        'End If

        txtTotal.Text = (GetSumPrice(dt))
        If txtVat.Text <> "0" Then
            txtVat.Text = (CDbl(txtTotal.Text) * 0.07).ToString("#.00")
        End If

        txtGrandTotal.Text = (CDbl(txtTotal.Text) + CDbl(txtVat.Text)).ToString("#.00")
    End Sub
    Sub updatePrice()
        Dim sqlstr As String

        sqlstr = "update PO_PROFILE set PO_TOTAL=" & txtTotal.Text & ",PO_VAT=" & txtVat.Text & ",PO_GTOTAL=" & txtGrandTotal.Text & " where PO_CODE like '" & txtPOno.Text & "'"
        db.RunCommand(sqlstr)
    End Sub
    Sub BindingData()
        On Error Resume Next
        'For Each tp As TabPage In TB1.Controls

        'For Each tb As Control In SupplierGrp.Controls
        '    If TypeOf tb Is TextBox Or TypeOf tb Is ComboBox Then
        '        'Dim Bs As New BindingSource
        '        'Bs.DataSource = ds
        '        'Bs.DataMember = tb.Text
        '        'tb.DataBindings.Add("Text", Bs, )
        '        tb.DataBindings.Add("Text", Bsource, tb.Name)
        '    End If
        '    'If TypeOf tb Is NumericUpDown Then tb.DataBindings.Add("Value", Employee.ds, "Showdata." & tb.Name)

        'Next

        'Next



        For Each GRP As Control In Me.Controls

            If TypeOf GRP Is GroupBox Then

                For Each tb As Control In GRP.Controls
                    If TypeOf tb Is TextBox Or TypeOf tb Is ComboBox Then
                        If tb.Text <> "" Then
                            tb.DataBindings.Add("Text", Bsource, tb.Text)
                        End If

                    End If

                Next
            End If
        Next


        'For Each tb As Control In GRPinfo.Controls
        '    If Not TypeOf tb Is Label Then tb.DataBindings.Add("Text", Bsource, tb.Text)

        'Next


    End Sub

    Private Sub cmdMovePrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMovePrev.Click
        If DGVList.SelectedRows.Count Then
            If DGVList.SelectedRows(0).Index > 0 Then DGVList.Rows(DGVList.SelectedRows(0).Index - 1).Selected = True

        End If

    End Sub

    Private Sub cmdMoveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveNext.Click
        If DGVList.SelectedRows.Count Then
            If DGVList.SelectedRows(0).Index < DGVList.Rows.Count - 1 Then DGVList.Rows(DGVList.SelectedRows(0).Index + 1).Selected = True

        End If

    End Sub


    'Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Bsource.CancelEdit()
    '    BindingContext(PODT).Position = ListBox1.SelectedIndex
    '    Bsource.Position = ListBox1.SelectedIndex
    '    Call cancelbtn_Click(sender, e)
    '    GetorderName()
    '    GetlotPR()
    '    GetPrDetail()
    '    If txtCheckname.Text.Trim <> "" Then
    '        CBapp2.Text = "Approve"
    '        CBapp2.Checked = True
    '    Else
    '        CBapp2.Text = "No Approve"
    '        CBapp2.Checked = False
    '    End If
    '    ' reloadPO()
    '    'LoadIMG()
    '    'ShowTraining()
    '    'ShowChangeDEP()

    '    ChkPermission()
    'End Sub




    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Try

            Bsource.CancelEdit()
            LBLStatus.Text = "View"
            newBtn.Enabled = True
            'delBtn.Enabled = True
            btnAdd.Enabled = True
            ' showLOTDetail()
            '   reloadPO()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtPrdt_LostFocus(sender As Object, e As EventArgs) Handles txtPrdt.LostFocus
        If txtPrdt.Text.Trim <> "" Then
            Dim th As New Thread(AddressOf GetPrdt)

            th.IsBackground = True
            th.Start()
        End If
    End Sub

    Sub GetPrdt()
        Dim dt As New DataTable
        dt = db.QryDT("select * from prdt where p_prdt like '" & txtPrdt.Text & "'", strAccess(Project.md2_tax))
        AccessControl(dt)

    End Sub
    Delegate Sub SetTextCallback(dt As DataTable)
    Sub AccessControl(dt As DataTable)
        Try


            If Me.InvokeRequired Then
                Me.Invoke(New SetTextCallback(AddressOf AccessControl), New Object() {dt})
            Else
                ' Code wasn't working in the threading sub
                If dt Is Nothing Then Exit Sub
                If dt.Rows.Count > 0 Then

                    txtPname.Text = dt(0)("P_ENAME").ToString
                    txtPspec.Text = dt(0)("P_SPEC").ToString
                    txtPsTock.Text = dt(0)("P_BAL").ToString
                    txtpLPrice.Text = dt(0)("P_LPrice").ToString
                    txtBacklog.Text = dt(0)("P_BACKLOG").ToString
                    ' txtLfrom.Text = dt(0)("P_Lfrom").ToString

                Else
                    ClearPRDTDetail()
                    'MsgBox("No Prdt DATA")
                End If


                txtPname.Enabled = True
                txtPspec.Enabled = True
                txtpLPrice.Enabled = True
                txtPsTock.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ClearPRDTDetail()
        txtPname.Text = ""
        txtPspec.Text = ""
        txtPsTock.Text = ""
        txtpLPrice.Text = ""
        txtBacklog.Text = ""
        txtLfrom.Text = ""
        txtLfromDes.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtQty.Text = "" Or txtPrice.Text = "" Then
            MsgBox("กรุณาใส่ข้อมูลกังต่อไปนี้ PRDT,QTY,PRICE", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
        'If txtPname.Text = "" Then
        '    MsgBox("No Part Data", MsgBoxStyle.OkOnly, "Error")
        '    txtPrdt.Focus()
        '    txtPrdt.SelectAll()
        '    Exit Sub
        'End If
        If DGV1.Rows.Count > 5 Then
            MsgBox("Purchase Order Maximum is 5")
            Exit Sub
        End If
        If txtpLPrice.Text = "" Then
            txtpLPrice.Text = 0
        End If
        Dim bufPOno, bufprdt, bufqty, bufBacklog, bufBal, bufPOPrice, bufLastPrice As String
        ' buforder = txtorder.Text
        bufPOno = txtPOno.Text
        bufprdt = txtPrdt.Text
        bufqty = txtQty.Text
        bufPOPrice = txtPrice.Text
        bufLastPrice = txtpLPrice.Text
        bufBacklog = txtBacklog.Text
        bufBal = txtPsTock.Text
        ' bufDelqty = txtDelqty.Text
        ' bufBal = txtBalQty.Text
        If LBLStatus.Text = "New" Then
            SaveBtn_Click(sender, e)
            If LBLStatus.Text = "New" Then Exit Sub
            txtPOno.Text = bufPOno
            txtPrdt.Text = bufprdt
            txtQty.Text = bufqty
            txtpLPrice.Text = bufLastPrice
            txtPrice.Text = bufPOPrice
            txtPsTock.Text = bufBal
            txtBacklog.Text = bufBacklog

        End If

        Dim Max As Integer = 0
        For Each dr As DataGridViewRow In DGV1.Rows
            If dr.Cells("order").Value Is Nothing Then Continue For
            If dr.Cells("PO_PRDT").Value.ToString() = txtPrdt.Text Then
                MsgBox("Duplicate Product")
                Exit Sub
            End If
            If dr.Cells("order").Value.ToString() <> "" Then
                If dr.Cells("order").Value.ToString() > Max Then
                    Max = dr.Cells("order").Value.ToString()
                End If
            End If
        Next
        Max += 1

        Dim sqlstr As String
        sqlstr = "insert into [PO]([PO_order],[po_Pname],[PO_code],[PO_prdt],[PO_qty],[PO_Price])" ',[PO_LastPrice],[PO_STOCK],[PO_BACKLOG])"
        sqlstr += " Values("
        sqlstr += "" & Max & ","
        sqlstr += "'" & txtPOno.Text & "',"
        sqlstr += "'" & txtPrdtname.Text & "',"
        sqlstr += "'" & txtPrdt.Text & "',"
        sqlstr += "" & SpaceTOZero(txtQty.Text) & ","
        sqlstr += "" & SpaceTOZero(txtPrice.Text) & ")"
        'sqlstr += "" & SpaceTOZero(txtpLPrice.Text) & ","
        'sqlstr += "" & SpaceTOZero(txtPsTock.Text) & ","
        ' sqlstr += "" & SpaceTOZero(txtBacklog.Text) & ")"
        db.RunCommand(sqlstr)

        'SaveLog("PRDT:" & txtPrdt.Text & ",PO:" & txtPOno.Text, "insert PRDT", Me.Name)

        'MrDetail.insertToStock("MR", txtPrdt.Text, txtDelDate.Text, txtMRNo.Text, txtrea.Text, txtDelqty.Text, txtJobNo.Text, txthand.Text)
        'ClosePO(txtPOno.Text)
        'UpdateBacklog(txtQty.Text, txtPrdt.Text)


        LoadDetail()


        'If LBLStatus.Text = "New" Then
        '    '  ListBox1.SetSelected(ListBox1.Items.Count - 1, True)
        '    'DGVList.Rows(DGVList.RowCount - 1).Selected = True
        '    'CalPrice()
        'Else
        '    LoadDetail()
        'End If

        'If LBLStatus.Text.ToUpper.Contains("NEW") Then
        '    db.incNO("PO")
        '    LBLStatus.Text = "View"
        '    SaveLog("insert PO:" & txtPOno.Text, "insert", Me.Name)



        'Else
        '    '  SaveLog("update PO:" & txtPOno.Text, "update", Me.Name)
        '    ' Bsource.EndEdit()

        '    ' BindingContext(PODT).EndCurrentEdit()

        '    ' UpdateBind(PODT)
        'End If




        ClearPRDTDetail()
        txtPrdt.Focus()
        lblPRDT.Text = ""
        updatePrice()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If txtPOno.Text.Trim = "" Or txtRea.Text.Trim = "" Then

            MsgBox("กรุณาใส่ข้อมูลดังต่อไปนี้ PO NO.,REA", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If
        If LBLStatus.Text = "New PO" Then
            'If DuplicateData("PO_CODE", txtPOno.Text, PODT) Then
            '    MsgBox("Duplicate Data", MsgBoxStyle.OkOnly, "Error")
            '    Exit Sub
            'End If
        End If



        'If LBLStatus.Text = "View" Then
        '    Dim sqlstr As String
        '    sqlstr = "update MR_Detail set "
        '    sqlstr += " mr_code=" & txtorder.Text & ","
        '    sqlstr += " where mr_code like '" & txtMRNo.Text & "'"
        '    MrDetail.RunSQL(sqlstr)
        'End If
        Try
            Bsource.EndEdit()

            BindingContext(PODT).EndCurrentEdit()

            UpdateBind(PODT)



            Dim OldID As String = Me.Text.Split(":")(1).Trim
            If OldID <> txtPOno.Text Then

                Dim sqls As String
                sqls = "update PO set PO_CODE='" & txtPOno.Text & "' where PO_CODE like '" & OldID & "'"
                ' RunCommand(sqls)
            End If

            'If LBLStatus.Text = "New MI" Then MIOBJ.RunningMIno(txtMINo.Text)
            If LBLStatus.Text.ToUpper.Contains("NEW") Then
                incNO("PO")
                'SaveLog("insert PO:" & txtPOno.Text, "insert", Me.Name)
            Else
                'SaveLog("update PO:" & txtPOno.Text, "update", Me.Name)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim txtno As String
        txtno = txtPOno.Text
        FilterGV()
        FindinList(DGVList, txtno, "PO_CODE")

        LBLStatus.Text = "View"
        DGV1.Enabled = True
        '  delBtn.Enabled = True
        btnAdd.Enabled = True
        LoadDetail()
        ' MsgBox("บันทึกเรียบร้อย")
        updatePrice()
    End Sub
    Dim ListBoxValue() As String
    Sub LoadList(DT As DataTable)

    End Sub

    Sub LoadDetail()

        POsubDT = (GetPODetail(txtPOno.Text))
        DGV1.DataSource = POsubDT
        CalPrice()
        'txtorder.Text = ""
        txtPrdt.Text = ""
        txtQty.Text = ""
        txtPrice.Text = ""
        txtpLPrice.Text = ""
        txtPsTock.Text = ""


        Me.Text = "Purchase Order : " & txtPOno.Text

    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        Bsource.AddNew()

        LBLStatus.Text = "New"





        txtPOno.Text = "SS" & db.ExScalar("Select  Format(GETDATE(),'yy', 'en-us')") & "/" & getno("PO")
        ' txtPOno.Text = "PO" & Now.ToString("yy-MM-") & db.getno("PO")
        txtPOno.Focus()
        txtRea.Text = "S"
        txtordername.Text = ""

        txtVat.Text = ""
        txtState.Text = 0
        ' txtOrderby.Text = UserName
        txtOrderDate.Text = db.ExScalar("Select  Format(GETDATE(),'dd/MM/yyyy', 'en-us')")

        ' btnAdd.Enabled = False
        newBtn.Enabled = False
        'delBtn.Enabled = False
        LoadDetail()


    End Sub

    Private Sub txtSupNo_LostFocus(sender As Object, e As EventArgs) Handles txtSupNo.LostFocus
        If txtSupNo.Text = "" Then Exit Sub
        Try


            Dim dt As New DataTable
            dt = GetSup(txtSupNo.Text)
            If dt.Rows.Count = 0 Then
                txtsupname.Text = ""
                txtSupAddress.Text = ""
                txtSupContact.Text = ""
                Exit Sub
            End If
            For Each dr As DataRow In dt.Rows
                txtsupname.Text = dr("s_name").ToString
                txtSupAddress.Text = dr("s_addr").ToString
                txtSupContact.Text = dr("s_cone").ToString

            Next
            dt.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim BeforePrdt As String

    Private Sub Updatebtn_Click(sender As Object, e As EventArgs) Handles Updatebtn.Click
        If txtPOno.Text = "" Or txtPrdt.Text = "" Then
            MsgBox("Please input Data", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        If txtPname.Text = "" Then
            MsgBox("No Part Data", MsgBoxStyle.OkOnly, "Error")
            txtPrdt.Focus()
            txtPrdt.SelectAll()
            Exit Sub
        End If

        BeforePrdt = lblPRDT.Text
        Dim sqlstr As String
        sqlstr = "update PO set "
        ' sqlstr += " Mr_order=" & SpaceTOZero(txtorder.Text) & ","
        sqlstr += " PO_PRDT='" & txtPrdt.Text & "',"
        sqlstr += " PO_QTY=" & SpaceTOZero(txtQty.Text) & ","
        sqlstr += " PO_PRICE=" & SpaceTOZero(txtPrice.Text) & ","
        '    sqlstr += " PO_LastPRICE=" & SpaceTOZero(txtpLPrice.Text) & ","
        '   sqlstr += " PO_stock=" & SpaceTOZero(txtPsTock.Text) & ""
        sqlstr += " where PO_CODE like '" & txtPOno.Text & "'"
        sqlstr += " and PO_PNAME like '" & BeforePrdt & "'"
        db.RunCommand(sqlstr)




        '        SaveLog("PRDT:" & txtPrdt.Text & ",PO:" & txtPOno.Text, "Update PRDT", Me.Name)
        ' MrDetail.MRupdateStock("MR", txtPrdt.Text, txtDelDate.Text, txtMRNo.Text, txtrea.Text, txtDelqty.Text, txtJobNo.Text, txthand.Text, BeforePrdt, txtMRNo.Text)


        'Dim thead As New Thread(AddressOf prdt.UpdateBacklogSQL)
        'thead.Start(txtPrdt.Text)

        'db.ClosePO(txtPOno.Text)
        '        prdt.UpdateBacklogSQL(txtPrdt.Text)



        If txtPrdt.Text <> BeforePrdt Then
            '  Dim thead2 As New Thread(Sub()
            '    prdt.UpdateBacklogSQL(BeforePrdt)
            '                         End Sub)
            ' thead2.Start()
        End If
        LoadDetail()

        Bsource.EndEdit()
        BindingContext(PODT).EndCurrentEdit()
        UpdateBind(PODT)
        lblPRDT.Text = ""
        updatePrice()
    End Sub

    Private Sub DelPrdtbtn_Click(sender As Object, e As EventArgs) Handles DelPrdtbtn.Click
        If txtPOno.Text = "" Or txtPrdt.Text = "" Then
            MsgBox("Please input Data", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        If MsgBox("Do you want  to Delete Code: " & txtPrdt.Text, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim sqlstr As String
        sqlstr = "delete  from PO"
        sqlstr += " where PO_code like '" & txtPOno.Text & "'"
        sqlstr += " and PO_prdt like '" & txtPrdt.Text & "'"
        db.RunCommand(sqlstr)


        ' SaveLog("PRDT:" & txtPrdt.Text & ",PO:" & txtPOno.Text, "Delete PRDT", Me.Name)


        ' db.ClosePO(txtPOno.Text)
        'prdt.UpdateBacklog(txtQty.Text * -1, txtPrdt.Text)

        LoadDetail()

        Bsource.EndEdit()
        BindingContext(PODT).EndCurrentEdit()
        UpdateBind(PODT)
        lblPRDT.Text = ""
        updatePrice()
    End Sub
    Private Sub DGV1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellClick

        If e.RowIndex = -1 Then
            ' txtorder.Text = ""
            txtPrdt.Text = ""
            txtQty.Text = ""
            txtPrice.Text = ""
            txtpLPrice.Text = ""
            txtPsTock.Text = ""
            Exit Sub
        End If
        'End Cancel Region

        DGV1.Rows(e.RowIndex).Selected = True
        ' txtorder.Text = dbNullToStr(DGV1.Item(0, e.RowIndex).Value)
        txtPrdt.Text = DGV1.Rows(e.RowIndex).Cells("PO_PRDT").Value.ToString
        txtPrdtname.Text = DGV1.Rows(e.RowIndex).Cells("PO_name").Value.ToString
        lblPRDT.Text = txtPrdtname.Text

        txtQty.Text = DGV1.Rows(e.RowIndex).Cells("PO_QTY").Value.ToString
        txtPrice.Text = DGV1.Rows(e.RowIndex).Cells("PO_PRICE").Value.ToString
        ' txtpLPrice.Text = DGV1.Rows(e.RowIndex).Cells("LastPRICE").Value.ToString
        'txtPsTock.Text = DGV1.Rows(e.RowIndex).Cells("STOCK").Value.ToString
        '  txtpLPrice.Enabled = True
        ' txtPsTock.Enabled = True

        If txtPrdt.Text.Trim <> "" Then
            Dim th As New Thread(AddressOf GetPrdt)

            th.IsBackground = True
            th.Start()
        End If



    End Sub





    Private Sub txtDiscount_Leave(sender As Object, e As EventArgs)
        CalPrice()
    End Sub



    Private Sub btnPrintPO_Click(sender As Object, e As EventArgs) Handles btnPrintPO.Click
        ''Dim creport As New CrystalReport1()
        'Dim frmReport As New POreportview
        'Dim rpt As New POrpt
        '' Dim tmpDT As New DataTable

        '' rpt.SetParameterValue("POCODE", txtPOno.Text)
        'If CBapp1.Checked = False Then
        '    MsgBox("PO not Approve")
        '    Exit Sub
        'End If
        'If txtState.Text = "" Or txtState.Text < "5" Then

        '    If txtState.Text = "" Then
        '        btnExportMI_Click(sender, e)
        '    End If
        '    txtState.Text = 5
        '    RunCommand("update PO_Profile set PO_STATE=5 where PO_CODE LIKE '" & txtPOno.Text & "'")

        'End If


        'Dim PrintDT As DataTable = GetPODetailAll(txtPOno.Text)
        'If PrintDT.Rows.Count = 0 Then Exit Sub


        'If PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_NOTE").ToString.Trim() <> "" Then
        '    PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_NOTE") = "หมายเหตุ:" & PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_NOTE")
        'End If

        'If PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_TOTAL").ToString <> "" Then
        '    PrintDT.Rows(PrintDT.Rows.Count - 1)("TOTAL_TEXT") = ContoThai.NumberToThaiWord(PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_TOTAL"))
        'End If




        'rpt.SetDataSource(PrintDT)

        'frmReport.CRV1.ReportSource = rpt
        ''  rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, txtPOno.Text)
        'frmReport.ShowDialog(Me)



    End Sub




    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        If MsgBox("Do you want  to Delete Code: " & txtPOno.Text, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'MIOBJ.DelStock(txtMINo.Text, "MI")

            For Each dr As DataGridViewRow In DGV1.Rows

                Try

                    If dr.Cells("PO_QTY").Value Is Nothing Then Continue For
                    '   prdt.UpdateBacklog(dr.Cells("PO_QTY").Value.ToString * -1, dr.Cells("PO_PRDT").Value.ToString)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            'SaveLog("delete PO:" & txtPOno.Text, "delete", Me.Name)

            ' prdt.UpdateBacklogPO(txtQty.Text * -1, txtPrdt.Text)
            Dim sqlstr As String
            sqlstr = "delete  from PO"
            sqlstr += " where PO_code like '" & txtPOno.Text & "'"
            db.RunCommand(sqlstr)

            Bsource.RemoveCurrent()

            UpdateBind(PODT)

            FilterGV()


            If DGVList.Rows.Count = 0 Then
                ' showLOTDetail()
                delBtn.Enabled = False
            End If

        End If
    End Sub

















    Private Sub DGV1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV1.DataBindingComplete
        Try


            For Each row As DataGridViewRow In DGV1.Rows
                If row.Index >= DGV1.RowCount - 1 Then Continue For

                Dim Order As String = ""

                If row.Cells("ORDER").Value.ToString <> (row.Index + 1).ToString Then
                    ' If row.Cells("PO_ORDER").Value.ToString <> (row.Index + 1).ToString Then
                    Order = row.Index + 1
                    row.Cells("ORDER").Value = Order
                    db.RunCommand("update PO set PO_ORDER='" & Order & "' where PO_code like '" & txtPOno.Text & "' and  PO_PNAME like '" & row.Cells("PO_PNAME").Value & "'")

                End If



                'If row.Cells("CANCEL").Value.ToString = "True" Then


                '    row.DefaultCellStyle.ForeColor = Color.Gray
                '    Continue For
                'End If


                'If IsDBNull(row.Cells("MIQTY").Value) Then
                '    row.DefaultCellStyle.ForeColor = Color.Red
                '    Continue For
                'End If
                'If row.Cells("MIQTY").Value <> row.Cells("PO_qty").Value Then
                '    row.DefaultCellStyle.ForeColor = Color.Red

                'ElseIf row.Cells("MIQTY").Value <> row.Cells("Recieve").Value Then
                '    row.DefaultCellStyle.ForeColor = Color.LimeGreen
                'Else
                '    row.DefaultCellStyle.ForeColor = Color.Green

                'End If


            Next
            '  CalPrice()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOrderUp_Click(sender As Object, e As EventArgs)
        AdjustOrder("UP")
    End Sub
    Sub AdjustOrder(Direct As String)
        If DGV1.SelectedRows.Count = 0 Then Exit Sub
        Dim dr As DataGridViewRow = DGV1.SelectedRows(0)
        Dim index As Integer = dr.Index
        If index = -1 Then Exit Sub
        Dim POS As Integer = dr.Cells("order").Value
        If Direct.ToUpper = "UP" Then
            If dr.Index = 0 Then Exit Sub

            db.RunCommand("update PO set PO_ORDER='0' where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '" & POS - 1 & "'")
            db.RunCommand("update PO set PO_ORDER=PO_ORDER-1 where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '" & POS & "'")
            db.RunCommand("update PO set PO_ORDER='" & POS & "' where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '0'")

        ElseIf Direct.ToUpper = "DOWN" Then
            If dr.Index >= DGV1.Rows.Count - 2 Then Exit Sub
            db.RunCommand("update PO set PO_ORDER='0' where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '" & POS + 1 & "'")
            db.RunCommand("update PO set PO_ORDER=PO_ORDER+1 where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '" & POS & "'")
            db.RunCommand("update PO set PO_ORDER='" & POS & "' where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '0'")

        End If
        POsubDT = (GetPODetail(txtPOno.Text))
        DGV1.DataSource = POsubDT
        DGV1.ClearSelection()
        If Direct.ToUpper = "UP" Then

            DGV1.Rows(index - 1).Selected = True
        ElseIf Direct.ToUpper = "DOWN" Then
            DGV1.Rows(index + 1).Selected = True
        End If

    End Sub


    Private Sub btnOrderDown_Click(sender As Object, e As EventArgs)
        AdjustOrder("DOWN")
    End Sub



    Private Sub btnPrintPOpdf_Click(sender As Object, e As EventArgs) Handles btnPrintPOpdf.Click
        'If CBapp1.Checked = False Then
        '    MsgBox("PO not Approve")
        '    Exit Sub
        'End If
        'Dim frmReport As New POreportview
        'Dim rpt As New PO_PDFrpt
        '' Dim tmpDT As New DataTable

        '' rpt.SetParameterValue("POCODE", txtPOno.Text)


        'If txtState.Text = "" Or txtState.Text < "5" Then

        '    If txtState.Text = "" Then
        '        btnExportMI_Click(sender, e)
        '    End If
        '    txtState.Text = 5
        '    RunCommand("update PO_Profile set PO_STATE=5 where PO_CODE LIKE '" & txtPOno.Text & "'")

        'End If
        'Dim PrintDT As DataTable = GetPODetailAll(txtPOno.Text)
        'If PrintDT.Rows.Count = 0 Then
        '    MsgBox("No Data")
        '    Exit Sub
        'End If

        ''PrintDT.Columns("PO_ORDER").DataType = GetType(String)

        ''Dim dtCloned As DataTable = PrintDT.Clone
        ''dtCloned.Columns("PO_ORDER").DataType = GetType(String)
        ''dtCloned.Columns("PO_PRICE").DataType = GetType(String)
        ''dtCloned.Columns("PO_QTY").DataType = GetType(String)
        ''dtCloned.Columns("AMT").DataType = GetType(String)
        ''For Each dr As DataRow In PrintDT.Rows

        ''    dtCloned.ImportRow(dr)
        ''Next


        ''While dtCloned.Rows.Count < 5
        ''    Dim dr As DataRow = dtCloned.NewRow
        ''    dr.ItemArray = dtCloned.Rows(0).ItemArray

        ''    dr("PO_prdt") = ""
        ''    dr("P_Tname") = ""
        ''    dr("PO_ORDER") = ""
        ''    dr("AMT") = ""
        ''    dr("PO_PRICE") = ""
        ''    dr("PO_QTY") = ""
        ''    PrintDT.Rows.Add(dr)
        ''End While

        'While PrintDT.Rows.Count < 5
        '    Dim dr As DataRow = PrintDT.NewRow
        '    '    dr.ItemArray = dtCloned.Rows(0).ItemArray

        '    dr("PO_discount") = PrintDT.Rows(0)("PO_discount")
        '    dr("PO_SUM") = PrintDT.Rows(0)("PO_SUM")
        '    dr("PO_VAT") = PrintDT.Rows(0)("PO_VAT")
        '    dr("PO_TOTAL") = PrintDT.Rows(0)("PO_TOTAL")
        '    dr("PO_orderby") = PrintDT.Rows(0)("PO_orderby")
        '    dr("E_TNAME") = PrintDT.Rows(0)("E_TNAME")
        '    dr("PO_app2") = PrintDT.Rows(0)("PO_app2")
        '    dr("sup_crday") = PrintDT.Rows(0)("sup_crday")


        '    dr("PO_NOTE") = PrintDT.Rows(0)("PO_NOTE").ToString()
        '    '   If Not CBapp2.Checked Then
        '    '   dr("CHECKNAME") = dr("PO_app2").ToString
        '    '  dr("PO_app2") = ""
        '    '  End If

        '    PrintDT.Rows.Add(dr)
        'End While
        'If PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_TOTAL").ToString <> "" Then
        '    PrintDT.Rows(PrintDT.Rows.Count - 1)("TOTAL_TEXT") = ContoThai.NumberToThaiWord(PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_TOTAL"))
        'End If
        'If PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_NOTE").ToString.Trim() <> "" Then
        '    PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_NOTE") = "หมายเหตุ:" & PrintDT.Rows(PrintDT.Rows.Count - 1)("PO_NOTE")
        'End If

        'If CBapp1.Checked Then
        '    DirectCast(rpt.ReportDefinition.ReportObjects("Picapp1"), CrystalDecisions.CrystalReports.Engine.PictureObject).ObjectFormat.EnableSuppress = False
        'End If



        'rpt.SetDataSource(PrintDT)

        ''  frmReport.CRV1.ReportSource = rpt
        'SaveFileDialog1.Filter = "PDF Files | *.pdf"
        'SaveFileDialog1.FileName = txtPOno.Text & ".pdf"
        'SaveFileDialog1.ShowDialog()
        'If SaveFileDialog1.FileName <> "" Then


        '    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, SaveFileDialog1.FileName & "")
        'End If
        '' frmReport.ShowDialog(Me)
    End Sub







    Private Sub CBapp1_CheckStateChanged(sender As Object, e As EventArgs) Handles CBapp1.CheckStateChanged
        If CBapp1.Checked Then
            CBapp1.Text = "Approve"
        Else
            CBapp1.Text = "No Approve"
        End If
    End Sub







    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCheckname.TextChanged
        If txtCheckname.Text.Trim <> "" Then
            CBapp2.Text = "Approve"
            CBapp2.Checked = True
        Else
            CBapp2.Text = "No Approve"
            CBapp2.Checked = False
        End If
    End Sub


    Private Sub txtVat_Leave(sender As Object, e As EventArgs) Handles txtVat.Leave
        If IsNumeric(txtVat.Text) = False And txtVat.Text <> "" Then
            MsgBox("Please input number.")
            txtVat.Focus()
        End If


        txtTotal.Text = (GetSumPrice(DGV1.DataSource).ToString).ToString("#.00")
        If txtVat.Text <> "0" Then

            txtVat.Text = (CDbl(txtTotal.Text) * 0.07).ToString("#.00")
        End If
        txtGrandTotal.Text = (CDbl(txtTotal.Text) + CDbl(txtVat.Text)).ToString("#.00")
    End Sub





    Private Sub btnSetOrderNum_Click(sender As Object, e As EventArgs) Handles btnSetOrderNum.Click
        If DGV1.SelectedRows.Count = 0 Then Exit Sub
        Dim dr As DataGridViewRow = DGV1.SelectedRows(0)
        Dim index As Integer = dr.Index
        If index = -1 Then Exit Sub

        Dim order As String = InputBox("Set order number:")
        If order = "" Then Exit Sub
        Dim POS As Integer = dr.Cells("order").Value



        db.RunCommand("update PO set PO_ORDER='" & order & "' where PO_CODE like '" & txtPOno.Text & "' and PO_ORDER like '" & POS & "'")
        POsubDT = (GetPODetail(txtPOno.Text))
        DGV1.DataSource = POsubDT
        DGV1.ClearSelection()
    End Sub




    Private Sub CBpr_Urgent_Click(sender As Object, e As EventArgs) Handles CBpr_Urgent.Click
        CBpr_Urgent.Checked = Not CBpr_Urgent.Checked
    End Sub

    Private Sub txtPrdt_TextChanged(sender As Object, e As EventArgs) Handles txtPrdt.TextChanged
        If txtPrdt.Text.Length > 15 Then
            txtPrdt.Text = txtPrdt.Text.Split(":")(0)

        End If
    End Sub
    Function getSQLWhere()
        Dim strSelect As String = ""


        If txtFindID.Text.Trim() <> "" Then strSelect &= "and pp.PO_code like '" & txtFindID.Text & "%'"


        If txtFindsup.Text.Trim() <> "" Then strSelect &= "and PO_sup like '" & txtFindsup.Text & "%'"
        If txtFindOrderDate.Text.Trim() <> "" Then strSelect &= "and PO_ORDATE like '" & txtFindOrderDate.Text & "%'"
        If txtFindDeliveryDate.Text.Trim() <> "" Then strSelect &= "and PO_DELDATE like '" & txtFindDeliveryDate.Text & "%'"


        If strSelect <> "" Then
            strSelect = strSelect.Substring(3, strSelect.Length - 3)
        End If

        Return strSelect
    End Function
    Sub FilterGV()
        Try


            Dim DTfilter As DataTable


            Dim strSelect As String = ""

            strSelect = getSQLWhere()

            If strSelect = "" Then
                DGVList.DataSource = GetPOlist("TOP 500")

                lblCount.Text = "จำนวน : " & DGVList.Rows.Count & " จาก " & db.ExScalar("select count(PO_code) from PO_Profile")

            Else
                '  DTfilter = MIOBJ.GetMIlist()


                '  DTfilter = PODT.Select(strSelect, "PO_code Desc").CopyToDataTable

                DTfilter = GetPOlist("", "where " & strSelect)
                DGVList.DataSource = DTfilter
                lblCount.Text = "จำนวน : " & DGVList.Rows.Count


            End If
        Catch ex As Exception
            DGV1.DataSource = Nothing
        End Try
    End Sub
    Private Sub DGVlist_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGVList.DataBindingComplete
        If DGVList.RowCount = 0 Then Exit Sub
        Dim index As Integer = Bsource.Find("PO_CODE", DGVList.Rows(0).Cells("PO_CODE").Value)
        SelectDGVlist(Bsource.Find("PO_CODE", DGVList.Rows(0).Cells("PO_CODE").Value))



        'For Each row As DataGridViewRow In DGVList.Rows


        '    If IsDBNull(row.Cells("PO_STATE").Value) Then
        '        row.DefaultCellStyle.ForeColor = Color.Red
        '        Continue For
        '    End If
        '    If row.Cells("PO_STATE").Value = "0" Then
        '        row.DefaultCellStyle.ForeColor = Color.Red
        '    ElseIf row.Cells("PO_STATE").Value = "3" Then
        '        row.DefaultCellStyle.ForeColor = Color.Orange
        '    ElseIf row.Cells("PO_STATE").Value = "5" Then
        '        row.DefaultCellStyle.ForeColor = Color.Blue
        '    ElseIf row.Cells("PO_STATE").Value = "7" Then
        '        row.DefaultCellStyle.ForeColor = Color.Lime
        '    ElseIf row.Cells("PO_STATE").Value = "9" Then
        '        row.DefaultCellStyle.ForeColor = Color.Green

        '    End If

        'Next



    End Sub

    Private Sub DGVlist_SelectionChanged(sender As Object, e As EventArgs) Handles DGVList.SelectionChanged
        If DGVList.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        SelectDGVlist(Bsource.Find("PO_CODE", DGVList.Rows(DGVList.SelectedRows(0).Index).Cells("PO_CODE").Value))


        LBLStatus.Text = "View"



        LoadDetail()


    End Sub
    Sub SelectDGVlist(index As Integer)

        Bsource.CancelEdit()

        BindingContext(PODT).Position = index
        Bsource.Position = index
        'showLOTDetail()
        Call cancelbtn_Click(New Object, New System.EventArgs)
    End Sub

    Private Sub LBLStatus_Click(sender As Object, e As EventArgs) Handles LBLStatus.Click

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub CBapp1_CheckedChanged(sender As Object, e As EventArgs) Handles CBapp1.CheckedChanged

    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        FilterGV()
    End Sub



    Private Sub btnFindexport_Click(sender As Object, e As EventArgs) Handles btnFindexport.Click
        'Dim DTexcel As New DataTable
        'Dim export As New ExporttoExcel

        'Dim sqlselect As String
        'sqlselect = getSQLWhere()
        'If sqlselect = "" Then
        '    DTexcel = db.GetPOlistreport()
        'Else
        '    DTexcel = db.GetPOlistreport("", "where " & sqlselect)
        'End If


        'If DTexcel.Rows.Count = 0 Then
        '    MsgBox("ไม่พบข้อมูล")
        '    Exit Sub
        'End If

        '' DataTable dtQueryTable = view.ToTable(false, new string[] { "PROVIDER_ID", "PRODUCT_NAME", "MIN_QUANTITY", "MAX_QUANTITY", "COMISSION_TEMPLATE" });

        ''DTexcel = DTexcel.AsDataView.ToTable(False, New String() {"PR_CODE", "PR_PRDT", "P_TNAME", "P_ENAME", "P_SPEC", "PR_QTY"})
        'export.SetDt = DTexcel
        'export.Title = "PO report"
        'export.BeginCloumn = "A"
        'export.QuickShow2()
    End Sub
End Class
