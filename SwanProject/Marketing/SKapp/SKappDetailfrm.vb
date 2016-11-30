Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions
Imports System.IO
Public Class SKappDetailfrm
    Dim Dal As New dataACCcls
    Dim DalSQL As New dataSQLcls
    Dim sqlstr As String


    Sub InsertLOG(ByVal name As String, ByVal dept As String, ByVal msg As String, ByVal skno As String, Optional ACT As String = "ACT")
        sqlstr = "use swan insert into SK_LOG([SKL_NAME],[SKL_DEPT],[SKL_STATUS],[SKL_TIME],[SKL_NO],[SKL_ACT]) values("
        sqlstr &= "'" & name & "'"
        sqlstr &= ",'" & dept & "'"
        sqlstr &= ",'" & msg & "'"
        sqlstr &= ",getdate()"
        sqlstr &= ",'" & skno & "'"
        sqlstr &= ",'" & ACT & "')"

        DalSQL.RunCommand(sqlstr, Project.swanSQL)
        SKLOGtoGV()
    End Sub
    Sub CHKpermit(ByVal grp As String, ByVal SKNO As String)

        If grp = "Production" Then
            ProCB.Enabled = True
        ElseIf grp = "QC" Then
            QCCB.Enabled = True
        ElseIf grp = "Marketing" Then
            Marcb.Enabled = True

            DGVUpload.Columns("Delete").Visible = True
            btnUpload.Visible = True
        ElseIf grp = "Suzie" Then
            ExCB.Enabled = True

        End If
        btnUpload.Visible = True
        If grp = "Marketing" Then

            DGVSK.Columns(10).Visible = True
            ' btnsetOPT.Visible = True
        Else
            'DGVSK.Columns(9).Visible = True
            'btnsetOPT.Visible = True

        End If


        For Each dc As DataGridViewColumn In DGVSK.Columns
            dc.ReadOnly = True
        Next


        If grp.ToUpper = "PRODUCTIONHEAD" Or grp.ToUpper = "ADMIN" Then
            DGVSK.Columns("E_PRDT_T").ReadOnly = False
            DGVSK.Columns("E_DELDATE").ReadOnly = False
        End If
        For Each dc As DataGridViewColumn In DGVSK.Columns
            If dc.ReadOnly = False Then
                dc.DefaultCellStyle.BackColor = Color.Cyan
            End If
        Next

        'Sqlstr = "SELECT   E_SKNO, MIN(E_DELDATE) AS deldate FROM EXP_SK"
        'Sqlstr &= " GROUP BY E_SKNO having MIN(E_DELDATE) like ''  and E_SKNO like '" & SKNO & "'  ORDER BY deldate"
        If (grp = "ProductionHead" Or grp = "admin") Then 'And dtc.ExScalar(Sqlstr) <> "" Then

            GBProd.Visible = True
        End If
    End Sub
    Function getappDATA(ByVal skno As String) As DataTable
        sqlstr = "select *  from sk_approve where ska_no like '" & skno & "'"
        Return DalSQL.QryDT(sqlstr, Project.swanSQL)

    End Function
    Sub getAPP(ByVal skno As String)
        For Each dr As DataRow In getappDATA(skno).Rows

            If Not dr("SKA_PROD").ToString = "" Then
                ProCB.Enabled = False
                ProCB.Checked = True
                ProCB1.Text = dr("SKA_PROD").ToString
            End If
            If Not dr("SKA_QC").ToString = "" Then
                QCCB.Enabled = False
                QCCB.Checked = True
                qcCB1.Text = dr("SKA_QC").ToString
            End If
            If Not dr("SKA_Examine").ToString = "" Then
                ExCB.Enabled = False
                ExCB.Checked = True
                ExCB1.Text = dr("SKA_EXAMINE").ToString
            End If
            If Not dr("SKA_Handling").ToString = "" Then
                MarCB.Enabled = False
                MarCB.Checked = True
                MarCB1.Text = dr("SKA_Handling").ToString
            End If

        Next

    End Sub

    Sub getAppSign(ByVal skno As String, ByVal rpt As ReportDocument)
        Dim datet As DateTime

        Dim dt As New DataTable
        dt = getappDATA(skno)
        For Each dr As DataRow In dt.Rows


            DirectCast(rpt.ReportDefinition.ReportObjects("signProd"), TextObject).Text = dr("SKA_PROD").ToString
            DirectCast(rpt.ReportDefinition.ReportObjects("signQC"), TextObject).Text = dr("SKA_QC").ToString
            DirectCast(rpt.ReportDefinition.ReportObjects("signExam"), TextObject).Text = dr("SKA_Examine").ToString
            DirectCast(rpt.ReportDefinition.ReportObjects("signHand"), TextObject).Text = dr("SKA_Handling").ToString

            If Not TypeOf (dr("SKA_PROD_DATE")) Is DBNull Then
                DirectCast(rpt.ReportDefinition.ReportObjects("signProd_date"), TextObject).Text = CDate(dr("SKA_PROD_DATE")).ToString("yyyyMMdd HH:mm:ss")
            End If

            If dr("SKA_QC_DATE").ToString <> "" Then
                DirectCast(rpt.ReportDefinition.ReportObjects("signQC_date"), TextObject).Text = CDate(dr("SKA_QC_DATE")).ToString("yyyyMMdd HH:mm:ss")
            End If
            If dr("SKA_Examine_DATE").ToString <> "" Then
                DirectCast(rpt.ReportDefinition.ReportObjects("signExam_date"), TextObject).Text = CDate(dr("SKA_Examine_DATE")).ToString("yyyyMMdd HH:mm:ss")
            End If
            If dr("SKA_Handling_DATE").ToString <> "" Then
                DirectCast(rpt.ReportDefinition.ReportObjects("signHand_date"), TextObject).Text = CDate(dr("SKA_Handling_DATE")).ToString("yyyyMMdd HH:mm:ss")
            End If



        Next

    End Sub

    Function GetBom(ByVal Prdt As String, ByVal number As String, ByVal csmr As String)
        If Prdt.Substring(0, 1) = "C" Then
            Dim Ename As String = Dal.ExScalar("select P_ENAME from PRDT_BOI where P_PRDT like '" & Prdt & "'", Project.swanpath)
            If Ename.ToUpper.Contains("BARE") Then
                Return Prdt
            Else
                Return Dal.ExScalar("select B_PRDT_T from BOMCODE where B_PRDT like '" & Prdt & "' and B_OPT like '" & number & "' and B_CSMR like '" & csmr & "'", Project.swanpath)

            End If

        Else
            Return Prdt

        End If
    End Function
    Sub SKtoGV()
        ' Sqlstr = "use swan select E_SKNO,E_DELDATE ,[E_ORDATE],[E_PRDT],[E_PRDT_T],[E_QTY] from EXP_SK where E_SKNO like '" & SKNO & "'"
        'Sqlstr = "select [EXP_SK].[E_SKNO],[E_DELDATE] ,[E_ORDATE],[E_ORDER],[E_PRDT],[E_PRDT_T],[E_SPEC],[E_QTY],E_BOM,[E_TCCSMR] from [EXP_SK] left join [MEMO] as t2 on [exp_sk].[E_SKNO]=t2.[E_SKNO] where EXP_SK.E_SKNO like '" & SKlbl.Text & "'"
        Dim dt As New DataTable
        sqlstr = "select iif(prdt_boi.p_usedb='TAX','TAX','BOI') as p_usedb,[EXP_SK].[E_SKNO],E_R,E_FUNC,[E_DELDATE] ,[E_ORDATE],[E_ORDER],[E_PRDT],[E_PRDT_T],[E_SPEC],[E_QTY],E_BOM,SK_OPT.SK_NAME from ([EXP_SK] left join sk_opt on EXP_SK.E_BOM=SK_OPT.SK_ID) left join prdt_boi on exp_sk.e_prdt=prdt_boi.p_prdt  where EXP_SK.E_SKNO  like '" & sklbl.Text & "'"

        dt = Dal.QryDT(sqlstr, Project.swanpath)
        DGVSK.DataSource = dt

        If dt.Rows.Count > 0 Then

            lblREV.Text = dt.Rows(0)("E_R").ToString
        End If

        sqlstr = "select E_SEQ,[E_MEMO],E_TCCSMR,E_MEMO2,E_NCSMR from [MEMO]  where E_SKNO like '" & SKlbl.Text & "' order by E_SEQ"


        dt = Dal.QryDT(sqlstr, Project.swanpath)

        DGVMEMO.DataSource = dt


        If DGVMEMO.RowCount > 0 Then
            CsmrnoLBL.Text = dt.Rows(0)("E_TCCSMR").ToString
            CsmrLBL.Text = dt.Rows(0)("E_NCSMR").ToString
            lblSpe.Text = dt.Rows(0)("E_MEMO2").ToString
        End If





    End Sub
    Sub SKLOGtoGV()
        sqlstr = "use swan SELECT [SKL_NAME] ,SKL_DEPT ,[SKL_STATUS] ,CONVERT(VARCHAR(10),SKL_TIME,112) + ' ' + CONVERT(VARCHAR(10),SKL_TIME,108) as SKL_TIME,SKL_ACT FROM [SWAN].[dbo].[SK_LOG] where [SKL_NO] like '" & sklbl.Text & "' order by [SKL_TIME] desc"

        DGVlog.DataSource = DalSQL.QryDT(sqlstr, Project.swanSQL)

    End Sub
    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click


        Dim dt, dtmemo As New DataTable

        sqlstr = "select * from exp_sk where e_skno like '" & sklbl.Text & "'"
        dt = Dal.QryDT(sqlstr, Project.swanpath)
        Dim rpt As New ReportFrm
        Dim rpts As New rptSK







        If dt.Rows.Count = 0 Then Exit Sub
        DirectCast(rpts.ReportDefinition.ReportObjects("txtspe"), TextObject).Text = lblSpe.Text

        DirectCast(rpts.ReportDefinition.ReportObjects("txtcuno"), TextObject).Text = CsmrnoLBL.Text
        DirectCast(rpts.ReportDefinition.ReportObjects("txtcu"), TextObject).Text = CSMRLBL.Text


        getAppSign(sklbl.Text, rpts)



        Dim subreportName As String
        Dim subreportObject As SubreportObject
        Dim subreport As New ReportDocument()





        rpts.SetDataSource(dt)
        rpt.RPTview.ReportSource = rpts

        If TypeOf (rpts.ReportDefinition.ReportObjects.
            Item("SubReport1")) Is SubreportObject Then
            subreportObject = rpts.ReportDefinition.ReportObjects.
                Item("SubReport1")
            subreportName = subreportObject.SubreportName
            subreport = rpts.OpenSubreport(subreportName)



            sqlstr = "select '' as E_ORDER,E_SEQ,[E_MEMO],E_TCCSMR,E_MEMO2,E_NCSMR from [MEMO]  where E_SKNO like '" & sklbl.Text & "' order by E_SEQ"

            dtmemo = Dal.QryDT(sqlstr, Project.swanpath)
            Dim i = 1
            For Each dr As DataRow In dtmemo.Rows
                If i Mod 2 = 1 Then
                    dr("E_ORDER") = i - ((i - 1) / 2) & "."


                End If
                i += 1
            Next
            subreport.SetDataSource(dtmemo)

        End If



        Dim skG As String = ""

        If Project.Group.ToUpper = "PRODUCTION" Then
            skG = "PROD"
        ElseIf Project.Group.ToUpper = "QC" Then
            skG = "QC"
        ElseIf Project.Group.ToUpper = "MARKETING" Then
            skG = "MAR"

        End If

        If skG <> "" Then DalSQL.RunCommand("update SK_APPROVE set SKA_P_" & skG & "=getdate() where SKA_NO like '" & sklbl.Text & "'", Project.swanSQL)
        rpt.ShowDialog(Me)
    End Sub
    Sub FillName(ByVal ctrl As String)

        Dim chkBX As CheckBox = FindControlRecursive(GBApp, ctrl)
        Dim txtBX As TextBox = FindControlRecursive(GBApp, ctrl & "1")

        If chkBX.Checked Then
            txtBX.Text = Project.User

            sqlstr = "UPDATE sk_approve SET SKA_" & chkBX.Text & " = '" & txtBX.Text & "',SKA_" & chkBX.Text & "_DATE=GETDATE() WHERE SKA_NO ='" & sklbl.Text & "'"
            sqlstr &= " IF @@ROWCOUNT=0"
            sqlstr &= "  INSERT INTO sk_approve(SKA_NO,SKA_" & chkBX.Text & ",SKA_" & chkBX.Text & "_DATE) VALUES ('" & Trim(sklbl.Text) & "', '" & Trim(txtBX.Text) & "',getdate())"

            DalSQL.RunCommand(sqlstr, Project.swanSQL)
            InsertLOG(Project.User, Project.Group, "Approve", sklbl.Text)
        Else

            txtBX.Text = ""

            sqlstr = "UPDATE sk_approve SET SKA_" & chkBX.Text & " = '',SKA_" & chkBX.Text & "_DATE = '' WHERE SKA_NO ='" & sklbl.Text & "'"
            DalSQL.RunCommand(sqlstr, Project.swanSQL)
            InsertLOG(Project.User, Project.Group, "UnApprove", sklbl.Text)
        End If

    End Sub


    Private Class Data


        Public Property Name As String
        Public Property Value As String

    End Class


    Private Sub SKappDetailfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized
        DGVSK.AutoGenerateColumns = False
        DGVMEMO.AutoGenerateColumns = False
        ' DGVlog.AutoGenerateColumns = False
        CHKpermit(Project.Group, sklbl.Text)




        'GetUpload()
        'If Project.Group <> "Marketing" And Project.Group <> "admin" Then
        '    ReportGV.Columns(1).Visible = False
        '    UploadBTN.Visible = False
        'Else

        'End If






        If sklbl.Text = "" Then Exit Sub
        ' If Project.Group <> "admin" Then
        '  If DalSQL.ExScalar("select skl_name from sk_log where skl_name like '" & Project.User & "' and skl_DEPT like '" & Project.Group & "'", Project.swanSQL) = "" Then
        InsertLOG(Project.User, Project.Group, "Read", sklbl.Text, "Read")
        '   End If
        '  End If


        SKtoGV()
        SKLOGtoGV()
        GetUpload()
        getAPP(sklbl.Text)



        Dim cmb As New DataGridViewComboBoxColumn
        cmb.HeaderText = "OPTION"
        cmb.Name = "E_BOM"

        cmb.Items.Add(New KeyValuePair(Of String, String)("W/O motor W mag", "1"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W motor W mag", "2"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W motor W/O mag", "3"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W/O motor W/O mag", "4"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W mag W check Valve", "5"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W/O mag W check Valve", "6"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W engine", "7"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("W/O engine", "8"))
        cmb.Items.Add(New KeyValuePair(Of String, String)("none", ""))



        cmb.DisplayMember = "Key"
        cmb.ValueMember = "Value"
        cmb.DisplayIndex = 6


        For Each i As KeyValuePair(Of String, String) In cmb.Items
            CBoption.Items.Add(i)
        Next
        CBoption.DisplayMember = "Key"
        CBoption.ValueMember = "Value"

        DGVSK.Columns.Add(cmb)

    End Sub
    Private Sub QCCB_Click(sender As Object, e As EventArgs) Handles QCCB.Click
        FillName(DirectCast(sender, CheckBox).Name)
    End Sub
    Private Sub PROCB_Click(sender As Object, e As EventArgs) Handles PROCB.Click
        FillName(DirectCast(sender, CheckBox).Name)
    End Sub
    Private Sub Excb_Click(sender As Object, e As EventArgs) Handles Excb.Click
        FillName(DirectCast(sender, CheckBox).Name)
    End Sub
    Private Sub Marcb_Click(sender As Object, e As EventArgs) Handles Marcb.Click
        FillName(DirectCast(sender, CheckBox).Name)
    End Sub

    'Private Sub QCCB_CheckedChanged(sender As Object, e As EventArgs) Handles QCCB.CheckedChanged
    '    FillName(DirectCast(sender, CheckBox).Name)
    'End Sub

    'Private Sub PROCB_CheckedChanged(sender As Object, e As EventArgs) Handles PROCB.CheckedChanged
    '    FillName(DirectCast(sender, CheckBox).Name)
    'End Sub

    'Private Sub Excb_CheckedChanged(sender As Object, e As EventArgs) Handles Excb.CheckedChanged
    '    FillName(DirectCast(sender, CheckBox).Name)
    'End Sub

    'Private Sub Marcb_CheckedChanged(sender As Object, e As EventArgs) Handles Marcb.CheckedChanged
    '    FillName(DirectCast(sender, CheckBox).Name)
    'End Sub


    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        Console.WriteLine("Row: {0}, Value: {1}", DGVSK.CurrentCell.RowIndex, combo.SelectedItem)

        Dim rows As Integer = DGVSK.CurrentCell.RowIndex
        Dim k As New KeyValuePair(Of String, String)
        k = combo.SelectedItem

        sqlstr = "update exp_sk set e_bom ='" & k.Value & "',e_prdt_t='" & GetBom(DGVSK.Rows(rows).Cells("E_PRDT").Value, k.Value, CsmrnoLBL.Text) & "' where e_order like '" & DGVSK.Rows(rows).Cells("E_ORDER").Value & "' and e_skno like '" & sklbl.Text & "'"
        '  Dal.RunCommand(sqlstr, Project.swanpath)
        Debug.WriteLine(sqlstr)

        InsertLOG(Project.User, Project.User, "Change Option to " & k.Key, sklbl.Text)
    End Sub

    Private Sub DGVSK_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVSK.EditingControlShowing

        If DGVSK.CurrentCell.ColumnIndex = 7 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then


                If Project.Group.ToUpper <> "MARKETING" Then
                    DGVSK.CurrentCell.ReadOnly = True
                    combo.Enabled = False
                    Exit Sub
                End If
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub


    Private Sub DGVSK_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSK.CellEndEdit
        Dim sqlstr As String
        sqlstr = "update exp_sk set e_deldate='" & DGVSK.Rows(e.RowIndex).Cells("E_DELDATE").Value & "',e_PRDT_T='" & DGVSK.Rows(e.RowIndex).Cells("E_PRDT_T").Value & "' where e_skno like '" & sklbl.Text & "' and e_order like '" & DGVSK.Rows(e.RowIndex).Cells("E_ORDER").Value & "'"
        Dal.RunCommand(sqlstr, Project.swanpath)





        InsertLOG(Project.User, Project.User, "Change " & DGVSK.Columns(e.ColumnIndex).HeaderText & " from" & DGVSK.Tag & " to " & DGVSK.CurrentCell.Value, sklbl.Text)
    End Sub

    Private Sub DGVSK_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVSK.CellBeginEdit


        DGVSK.Tag = DGVSK.CurrentCell.Value
    End Sub

    Private Sub btnAddnote_Click(sender As Object, e As EventArgs) Handles btnAddnote.Click
        InsertLOG(Project.User, Project.Group, txtNote.Text, sklbl.Text, "NOTE")
    End Sub

    Private Sub DGVlog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVlog.CellContentClick

    End Sub

    Private Sub DGVlog_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGVlog.DataBindingComplete
        If DGVlog.RowCount = 0 Then Exit Sub

        For Each row As DataGridViewRow In DGVlog.Rows

            If IsDBNull(row.Cells("SKL_ACT").Value) Then

                Continue For
            End If

            If row.Cells("SKL_ACT").Value = "NOTE" Then
                row.DefaultCellStyle.ForeColor = Color.Red


            End If

        Next
    End Sub

    Private Sub DGVSK_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVSK.CellFormatting
        'Dim dcgv As New DataGridViewComboBoxCell
        'For Each dr As DataGridViewRow In DGVSK.Rows
        '    dcgv = CType(dr.Cells(6), DataGridViewComboBoxCell)
        '    dcgv.ReadOnly = True
        'Next
    End Sub
    Dim PathSaveFilereal As String = "\\server\siamvb\sk_file\"
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using dialog As New OpenFileDialog
            dialog.Title = "Upload"

            dialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            '  fd.FilterIndex = 2
            '  fd.RestoreDirectory = True

            If dialog.ShowDialog() <> DialogResult.OK Then Return


            Dim fn As String = System.IO.Path.GetFileName(dialog.FileName)
            File.Copy(dialog.FileName, PathSaveFilereal + sklbl.Text + "_" + fn)


            InsertLOG(Project.User, Project.Group, "insert file " & fn, sklbl.Text)

            sqlstr = "insert into SK_File values('" + sklbl.Text + "','" + PathSaveFilereal + sklbl.Text + "_" + fn + "','" + txtFilename.Text + "')" ' // set ecn_filename ='" + fn + "' where ecn_no='" + txtEcnno.Text + "' and part_no='" + txtPartno.Text + "' ";
            DalSQL.RunCommand(sqlstr, Project.swanSQL)

            GetUpload()
        End Using
    End Sub

    Sub GetUpload()


        sqlstr = "select 'OPEN' as [OPEN],'DELETE' as [DELETE],SKF_Fname,sKF_NAME from  sk_file  where SKF_skno='" + sklbl.Text + "'"



        DGVUpload.DataSource = DalSQL.QryDT(sqlstr, Project.swanSQL)


    End Sub



    Private Sub DGVUpload_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUpload.CellClick
        If DGVUpload.Columns(e.ColumnIndex).Name = "OPEN" Then

            ' File.Open(DGVUpload.Rows(e.RowIndex).Cells("SKF_FNAME").Value, FileMode.Open)
            System.Diagnostics.Process.Start(DGVUpload.Rows(e.RowIndex).Cells("SKF_FNAME").Value)

        ElseIf DGVUpload.Columns(e.ColumnIndex).Name = "Delete" Then
            If MsgBox("Do you want Confirm to Delete?", vbYesNo) = MsgBoxResult.Yes Then


                sqlstr = "delete from SK_File where SKF_SKNO like '" + sklbl.Text + "' and SKF_FNAME like '" + DGVUpload.Rows(e.RowIndex).Cells("SKF_FNAME").Value + "'"

                DalSQL.RunCommand(sqlstr, Project.swanSQL)
                File.Delete(DGVUpload.Rows(e.RowIndex).Cells("SKF_FNAME").Value)
                GetUpload()
            End If
        End If
    End Sub

    Private Sub DGVUpload_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUpload.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim notifyIcon1 As New NotifyIcon
        notifyIcon1.Icon = SystemIcons.Exclamation
        notifyIcon1.BalloonTipTitle = "Balloon Tip Title"
        notifyIcon1.BalloonTipText = "Balloon Tip Text."
        notifyIcon1.BalloonTipIcon = ToolTipIcon.Error

        notifyIcon1.Visible = True
        notifyIcon1.ShowBalloonTip(30000)
    End Sub



    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick

    End Sub

    Private Sub CBoption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoption.SelectedIndexChanged
        txtaddPrdt_t.Text = GetBom(txtaddPrdt.Text, CBoption.SelectedValue, CsmrnoLBL.Text)
    End Sub
#Region "ManageMode"


    Private Sub btnNewSK_Click(sender As Object, e As EventArgs) Handles btnNewSK.Click
        ClearBox(Me)
        sklbl.Text = Dal.ExScalar("select E_SKNO from EXP_SKNO")
        ChangeMode("ADD")
    End Sub
    Sub ChangeMode(mode As String)
        lblMode.Text = mode
        If mode.ToUpper = "ADD" Then

            btnNewSK.Visible = False
            btnAdd.Visible = True
            btnSave.Visible = False
            BtnDelete.Visible = False
            btnCancel.Visible = True
        ElseIf mode.ToUpper = "VIEW" Then
            btnNewSK.Visible = True
            btnAdd.Visible = False
            btnSave.Visible = True
            BtnDelete.Visible = True
            btnCancel.Visible = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearBox(Me)
        ChangeMode("View")
    End Sub


    Private Sub sklbl_KeyDown(sender As Object, e As KeyEventArgs) Handles sklbl.KeyDown
        If e.KeyCode = Keys.Enter Then
            SKtoGV()
            SKLOGtoGV()
            GetUpload()
            getAPP(sklbl.Text)
            ChangeMode("View")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPrdtadd.Click
        Dim sqlstr As String
        If lblMode.Text = "View" Then
            sqlstr = "insert into exp_sk (E_SKNO,E_PRDT,E_PRDT_T,E_QTY,E_R,E_BOM,E_DELDATE,E_ORDATE,E_UPDATE,E_ORDER"
        End If
        Dim dr As New DataGridViewRow
        dr = DGVSK.Rows.Item(0).Clone
        dr.Cells("E_PRDT").Value = txtaddPrdt.Text
        dr.Cells("E_PRDT_T").Value = txtaddPrdt_t.Text
        dr.Cells("E_BOM").Value = CBoption.SelectedValue
        dr.Cells("E_QTY").Value = txtaddQTY.Text
        DGVSK.Rows.Add(dr)
    End Sub
#End Region
End Class