<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SKappDetailfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SKappDetailfrm))
        Me.ReportBtn = New System.Windows.Forms.Button()
        Me.DGVSK = New System.Windows.Forms.DataGridView()
        Me.P_UseDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_FUNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_Ordate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_DELDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_ORDER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_PRDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_PRDT_T = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_SPEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVMEMO = New System.Windows.Forms.DataGridView()
        Me.E_SEQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_MEMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVlog = New System.Windows.Forms.DataGridView()
        Me.SKL_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKL_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKL_ACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKL_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKL_GROUP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBProd = New System.Windows.Forms.GroupBox()
        Me.BtnsetBomCode = New System.Windows.Forms.Button()
        Me.btnSetDeldate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBApp = New System.Windows.Forms.GroupBox()
        Me.Marcb1 = New System.Windows.Forms.TextBox()
        Me.Marcb = New System.Windows.Forms.CheckBox()
        Me.Excb1 = New System.Windows.Forms.TextBox()
        Me.Excb = New System.Windows.Forms.CheckBox()
        Me.PROCB1 = New System.Windows.Forms.TextBox()
        Me.PROCB = New System.Windows.Forms.CheckBox()
        Me.QCCB1 = New System.Windows.Forms.TextBox()
        Me.QCCB = New System.Windows.Forms.CheckBox()
        Me.btnAddnote = New System.Windows.Forms.Button()
        Me.CSMRLBL = New System.Windows.Forms.Label()
        Me.lblSpe = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVUpload = New System.Windows.Forms.DataGridView()
        Me.OPEN = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SK_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Skf_FNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.sklbl = New System.Windows.Forms.TextBox()
        Me.CsmrnoLBL = New System.Windows.Forms.TextBox()
        Me.lblREV = New System.Windows.Forms.TextBox()
        Me.txtOrdate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrdtDel = New System.Windows.Forms.Button()
        Me.btnPrdtadd = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtaddQTY = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CBoption = New System.Windows.Forms.ComboBox()
        Me.btnPrdtSave = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtaddPrdt_t = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtaddPrdt = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblMode = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNewSK = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        CType(Me.DGVSK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMEMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVlog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBProd.SuspendLayout()
        Me.GBApp.SuspendLayout()
        CType(Me.DGVUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportBtn
        '
        Me.ReportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ReportBtn.Location = New System.Drawing.Point(1277, 66)
        Me.ReportBtn.Name = "ReportBtn"
        Me.ReportBtn.Size = New System.Drawing.Size(121, 45)
        Me.ReportBtn.TabIndex = 0
        Me.ReportBtn.Text = "Report"
        Me.ReportBtn.UseVisualStyleBackColor = True
        '
        'DGVSK
        '
        Me.DGVSK.AllowUserToAddRows = False
        Me.DGVSK.AllowUserToDeleteRows = False
        Me.DGVSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.P_UseDB, Me.E_FUNC, Me.E_Ordate, Me.E_DELDATE, Me.E_ORDER, Me.E_PRDT, Me.E_PRDT_T, Me.E_SPEC, Me.E_QTY})
        Me.DGVSK.Location = New System.Drawing.Point(11, 127)
        Me.DGVSK.Name = "DGVSK"
        Me.DGVSK.RowHeadersVisible = False
        Me.DGVSK.Size = New System.Drawing.Size(896, 184)
        Me.DGVSK.TabIndex = 1
        '
        'P_UseDB
        '
        Me.P_UseDB.DataPropertyName = "P_UseDB"
        Me.P_UseDB.HeaderText = "UseDB"
        Me.P_UseDB.Name = "P_UseDB"
        '
        'E_FUNC
        '
        Me.E_FUNC.DataPropertyName = "E_FUNC"
        Me.E_FUNC.HeaderText = "FUNC"
        Me.E_FUNC.Name = "E_FUNC"
        '
        'E_Ordate
        '
        Me.E_Ordate.DataPropertyName = "E_Ordate"
        Me.E_Ordate.HeaderText = "Order Date"
        Me.E_Ordate.Name = "E_Ordate"
        '
        'E_DELDATE
        '
        Me.E_DELDATE.DataPropertyName = "E_DELDATE"
        Me.E_DELDATE.HeaderText = "DELDATE"
        Me.E_DELDATE.Name = "E_DELDATE"
        '
        'E_ORDER
        '
        Me.E_ORDER.DataPropertyName = "E_ORDER"
        Me.E_ORDER.HeaderText = "ORDER"
        Me.E_ORDER.Name = "E_ORDER"
        Me.E_ORDER.Width = 40
        '
        'E_PRDT
        '
        Me.E_PRDT.DataPropertyName = "E_PRDT"
        Me.E_PRDT.HeaderText = "PRDT"
        Me.E_PRDT.Name = "E_PRDT"
        '
        'E_PRDT_T
        '
        Me.E_PRDT_T.DataPropertyName = "E_PRDT_T"
        Me.E_PRDT_T.HeaderText = "PRDT_T"
        Me.E_PRDT_T.Name = "E_PRDT_T"
        '
        'E_SPEC
        '
        Me.E_SPEC.DataPropertyName = "E_SPEC"
        Me.E_SPEC.HeaderText = "SPEC"
        Me.E_SPEC.Name = "E_SPEC"
        Me.E_SPEC.Width = 150
        '
        'E_QTY
        '
        Me.E_QTY.DataPropertyName = "E_QTY"
        Me.E_QTY.HeaderText = "QTY"
        Me.E_QTY.Name = "E_QTY"
        '
        'DGVMEMO
        '
        Me.DGVMEMO.AllowUserToAddRows = False
        Me.DGVMEMO.AllowUserToDeleteRows = False
        Me.DGVMEMO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMEMO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.E_SEQ, Me.E_MEMO})
        Me.DGVMEMO.Location = New System.Drawing.Point(12, 317)
        Me.DGVMEMO.Name = "DGVMEMO"
        Me.DGVMEMO.RowHeadersVisible = False
        Me.DGVMEMO.Size = New System.Drawing.Size(896, 187)
        Me.DGVMEMO.TabIndex = 2
        '
        'E_SEQ
        '
        Me.E_SEQ.DataPropertyName = "E_SEQ"
        Me.E_SEQ.HeaderText = "SEQ"
        Me.E_SEQ.Name = "E_SEQ"
        Me.E_SEQ.Width = 50
        '
        'E_MEMO
        '
        Me.E_MEMO.DataPropertyName = "E_MEMO"
        Me.E_MEMO.HeaderText = "MEMO"
        Me.E_MEMO.Name = "E_MEMO"
        Me.E_MEMO.Width = 800
        '
        'DGVlog
        '
        Me.DGVlog.AllowUserToAddRows = False
        Me.DGVlog.AllowUserToDeleteRows = False
        Me.DGVlog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKL_STATUS, Me.SKL_TIME, Me.SKL_ACT, Me.SKL_NAME, Me.SKL_GROUP})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVlog.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVlog.Location = New System.Drawing.Point(914, 127)
        Me.DGVlog.Name = "DGVlog"
        Me.DGVlog.RowHeadersVisible = False
        Me.DGVlog.Size = New System.Drawing.Size(845, 590)
        Me.DGVlog.TabIndex = 3
        '
        'SKL_STATUS
        '
        Me.SKL_STATUS.DataPropertyName = "SKL_STATUS"
        Me.SKL_STATUS.HeaderText = "MSG"
        Me.SKL_STATUS.Name = "SKL_STATUS"
        Me.SKL_STATUS.Width = 500
        '
        'SKL_TIME
        '
        Me.SKL_TIME.DataPropertyName = "SKL_TIME"
        Me.SKL_TIME.HeaderText = "TIME"
        Me.SKL_TIME.Name = "SKL_TIME"
        '
        'SKL_ACT
        '
        Me.SKL_ACT.DataPropertyName = "SKL_ACT"
        Me.SKL_ACT.HeaderText = "ACT"
        Me.SKL_ACT.Name = "SKL_ACT"
        Me.SKL_ACT.Width = 40
        '
        'SKL_NAME
        '
        Me.SKL_NAME.DataPropertyName = "SKL_NAME"
        Me.SKL_NAME.HeaderText = "NAME"
        Me.SKL_NAME.Name = "SKL_NAME"
        '
        'SKL_GROUP
        '
        Me.SKL_GROUP.DataPropertyName = "SKL_GROUP"
        Me.SKL_GROUP.HeaderText = "GROUP"
        Me.SKL_GROUP.Name = "SKL_GROUP"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNote.Location = New System.Drawing.Point(1425, 47)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(268, 63)
        Me.txtNote.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(1374, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Note:"
        '
        'GBProd
        '
        Me.GBProd.Controls.Add(Me.BtnsetBomCode)
        Me.GBProd.Controls.Add(Me.btnSetDeldate)
        Me.GBProd.Controls.Add(Me.Label3)
        Me.GBProd.Controls.Add(Me.TextBox3)
        Me.GBProd.Controls.Add(Me.Label2)
        Me.GBProd.Controls.Add(Me.TextBox2)
        Me.GBProd.Location = New System.Drawing.Point(934, 723)
        Me.GBProd.Name = "GBProd"
        Me.GBProd.Size = New System.Drawing.Size(524, 100)
        Me.GBProd.TabIndex = 10
        Me.GBProd.TabStop = False
        Me.GBProd.Text = "Production"
        Me.GBProd.Visible = False
        '
        'BtnsetBomCode
        '
        Me.BtnsetBomCode.Location = New System.Drawing.Point(433, 57)
        Me.BtnsetBomCode.Name = "BtnsetBomCode"
        Me.BtnsetBomCode.Size = New System.Drawing.Size(47, 28)
        Me.BtnsetBomCode.TabIndex = 15
        Me.BtnsetBomCode.Text = "Set"
        Me.BtnsetBomCode.UseVisualStyleBackColor = True
        '
        'btnSetDeldate
        '
        Me.btnSetDeldate.Location = New System.Drawing.Point(433, 25)
        Me.btnSetDeldate.Name = "btnSetDeldate"
        Me.btnSetDeldate.Size = New System.Drawing.Size(47, 28)
        Me.btnSetDeldate.TabIndex = 14
        Me.btnSetDeldate.Text = "Set"
        Me.btnSetDeldate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Update Air :"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(270, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(157, 22)
        Me.TextBox3.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Confirm Delivery Date :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(270, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 22)
        Me.TextBox2.TabIndex = 10
        '
        'GBApp
        '
        Me.GBApp.Controls.Add(Me.Marcb1)
        Me.GBApp.Controls.Add(Me.Marcb)
        Me.GBApp.Controls.Add(Me.Excb1)
        Me.GBApp.Controls.Add(Me.Excb)
        Me.GBApp.Controls.Add(Me.PROCB1)
        Me.GBApp.Controls.Add(Me.PROCB)
        Me.GBApp.Controls.Add(Me.QCCB1)
        Me.GBApp.Controls.Add(Me.QCCB)
        Me.GBApp.Location = New System.Drawing.Point(12, 510)
        Me.GBApp.Name = "GBApp"
        Me.GBApp.Size = New System.Drawing.Size(516, 100)
        Me.GBApp.TabIndex = 11
        Me.GBApp.TabStop = False
        Me.GBApp.Text = "Approval"
        '
        'Marcb1
        '
        Me.Marcb1.Enabled = False
        Me.Marcb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Marcb1.Location = New System.Drawing.Point(378, 64)
        Me.Marcb1.Name = "Marcb1"
        Me.Marcb1.Size = New System.Drawing.Size(113, 22)
        Me.Marcb1.TabIndex = 17
        '
        'Marcb
        '
        Me.Marcb.AutoSize = True
        Me.Marcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Marcb.Location = New System.Drawing.Point(378, 30)
        Me.Marcb.Name = "Marcb"
        Me.Marcb.Size = New System.Drawing.Size(113, 28)
        Me.Marcb.TabIndex = 16
        Me.Marcb.Text = "Handling"
        Me.Marcb.UseVisualStyleBackColor = True
        '
        'Excb1
        '
        Me.Excb1.Enabled = False
        Me.Excb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Excb1.Location = New System.Drawing.Point(259, 64)
        Me.Excb1.Name = "Excb1"
        Me.Excb1.Size = New System.Drawing.Size(113, 22)
        Me.Excb1.TabIndex = 15
        '
        'Excb
        '
        Me.Excb.AutoSize = True
        Me.Excb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Excb.Location = New System.Drawing.Point(259, 30)
        Me.Excb.Name = "Excb"
        Me.Excb.Size = New System.Drawing.Size(111, 28)
        Me.Excb.TabIndex = 14
        Me.Excb.Text = "Examine"
        Me.Excb.UseVisualStyleBackColor = True
        '
        'PROCB1
        '
        Me.PROCB1.Enabled = False
        Me.PROCB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROCB1.Location = New System.Drawing.Point(140, 64)
        Me.PROCB1.Name = "PROCB1"
        Me.PROCB1.Size = New System.Drawing.Size(113, 22)
        Me.PROCB1.TabIndex = 13
        '
        'PROCB
        '
        Me.PROCB.AutoSize = True
        Me.PROCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PROCB.Location = New System.Drawing.Point(140, 30)
        Me.PROCB.Name = "PROCB"
        Me.PROCB.Size = New System.Drawing.Size(73, 28)
        Me.PROCB.TabIndex = 12
        Me.PROCB.Text = "Prod"
        Me.PROCB.UseVisualStyleBackColor = True
        '
        'QCCB1
        '
        Me.QCCB1.Enabled = False
        Me.QCCB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.QCCB1.Location = New System.Drawing.Point(22, 64)
        Me.QCCB1.Name = "QCCB1"
        Me.QCCB1.Size = New System.Drawing.Size(113, 22)
        Me.QCCB1.TabIndex = 11
        '
        'QCCB
        '
        Me.QCCB.AutoSize = True
        Me.QCCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.QCCB.Location = New System.Drawing.Point(22, 30)
        Me.QCCB.Name = "QCCB"
        Me.QCCB.Size = New System.Drawing.Size(59, 28)
        Me.QCCB.TabIndex = 0
        Me.QCCB.Text = "QC"
        Me.QCCB.UseVisualStyleBackColor = True
        '
        'btnAddnote
        '
        Me.btnAddnote.Location = New System.Drawing.Point(1698, 82)
        Me.btnAddnote.Name = "btnAddnote"
        Me.btnAddnote.Size = New System.Drawing.Size(47, 28)
        Me.btnAddnote.TabIndex = 12
        Me.btnAddnote.Text = "ADD"
        Me.btnAddnote.UseVisualStyleBackColor = True
        '
        'CSMRLBL
        '
        Me.CSMRLBL.AutoSize = True
        Me.CSMRLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CSMRLBL.Location = New System.Drawing.Point(961, 34)
        Me.CSMRLBL.Name = "CSMRLBL"
        Me.CSMRLBL.Size = New System.Drawing.Size(59, 20)
        Me.CSMRLBL.TabIndex = 15
        Me.CSMRLBL.Text = "10412"
        '
        'lblSpe
        '
        Me.lblSpe.AutoSize = True
        Me.lblSpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSpe.ForeColor = System.Drawing.Color.Red
        Me.lblSpe.Location = New System.Drawing.Point(352, 746)
        Me.lblSpe.Name = "lblSpe"
        Me.lblSpe.Size = New System.Drawing.Size(48, 16)
        Me.lblSpe.TabIndex = 16
        Me.lblSpe.Text = "10412"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 746)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Special :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "SKNO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(715, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "C_NO :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(885, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CSMR :"
        '
        'DGVUpload
        '
        Me.DGVUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUpload.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OPEN, Me.Delete, Me.SK_NAME, Me.Skf_FNAME})
        Me.DGVUpload.Location = New System.Drawing.Point(17, 616)
        Me.DGVUpload.Name = "DGVUpload"
        Me.DGVUpload.RowHeadersVisible = False
        Me.DGVUpload.Size = New System.Drawing.Size(671, 119)
        Me.DGVUpload.TabIndex = 21
        '
        'OPEN
        '
        Me.OPEN.DataPropertyName = "OPEN"
        Me.OPEN.HeaderText = "OPEN"
        Me.OPEN.Name = "OPEN"
        Me.OPEN.Text = "OPEN"
        Me.OPEN.UseColumnTextForButtonValue = True
        Me.OPEN.Width = 80
        '
        'Delete
        '
        Me.Delete.DataPropertyName = "DELETE"
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Visible = False
        Me.Delete.Width = 80
        '
        'SK_NAME
        '
        Me.SK_NAME.DataPropertyName = "SkF_NAME"
        Me.SK_NAME.HeaderText = "Name"
        Me.SK_NAME.Name = "SK_NAME"
        Me.SK_NAME.Width = 150
        '
        'Skf_FNAME
        '
        Me.Skf_FNAME.DataPropertyName = "Skf_FNAME"
        Me.Skf_FNAME.HeaderText = "FileNAME"
        Me.Skf_FNAME.Name = "Skf_FNAME"
        Me.Skf_FNAME.Width = 300
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtFilename
        '
        Me.txtFilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFilename.Location = New System.Drawing.Point(87, 749)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(109, 22)
        Me.txtFilename.TabIndex = 22
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(202, 746)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(51, 28)
        Me.btnUpload.TabIndex = 24
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 752)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "ชื่อเอกสาร"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(215, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "REV:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(777, 720)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 28)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "testBallon"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'sklbl
        '
        Me.sklbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.sklbl.Location = New System.Drawing.Point(96, 30)
        Me.sklbl.Name = "sklbl"
        Me.sklbl.Size = New System.Drawing.Size(113, 29)
        Me.sklbl.TabIndex = 29
        '
        'CsmrnoLBL
        '
        Me.CsmrnoLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CsmrnoLBL.Location = New System.Drawing.Point(809, 29)
        Me.CsmrnoLBL.Name = "CsmrnoLBL"
        Me.CsmrnoLBL.Size = New System.Drawing.Size(70, 29)
        Me.CsmrnoLBL.TabIndex = 30
        '
        'lblREV
        '
        Me.lblREV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblREV.Location = New System.Drawing.Point(280, 29)
        Me.lblREV.Name = "lblREV"
        Me.lblREV.Size = New System.Drawing.Size(32, 29)
        Me.lblREV.TabIndex = 31
        '
        'txtOrdate
        '
        Me.txtOrdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOrdate.Location = New System.Drawing.Point(153, 66)
        Me.txtOrdate.Name = "txtOrdate"
        Me.txtOrdate.Size = New System.Drawing.Size(120, 29)
        Me.txtOrdate.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 25)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Order Date :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(426, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 29)
        Me.TextBox1.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(279, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 25)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "PROD Date :"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(426, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(120, 29)
        Me.TextBox4.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(322, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 25)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "PO NO :"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(650, 29)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(59, 29)
        Me.TextBox5.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(552, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 25)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "CSMR :"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(678, 67)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 29)
        Me.TextBox6.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(564, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 25)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Exp Del :"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(946, 67)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(120, 29)
        Me.TextBox7.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(816, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 25)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Saleman : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrdtDel)
        Me.GroupBox1.Controls.Add(Me.btnPrdtadd)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtaddQTY)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.CBoption)
        Me.GroupBox1.Controls.Add(Me.btnPrdtSave)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtaddPrdt_t)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtaddPrdt)
        Me.GroupBox1.Location = New System.Drawing.Point(534, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 100)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order"
        Me.GroupBox1.Visible = False
        '
        'btnPrdtDel
        '
        Me.btnPrdtDel.Location = New System.Drawing.Point(323, 71)
        Me.btnPrdtDel.Name = "btnPrdtDel"
        Me.btnPrdtDel.Size = New System.Drawing.Size(68, 28)
        Me.btnPrdtDel.TabIndex = 22
        Me.btnPrdtDel.Text = "DELETE"
        Me.btnPrdtDel.UseVisualStyleBackColor = True
        '
        'btnPrdtadd
        '
        Me.btnPrdtadd.Location = New System.Drawing.Point(217, 71)
        Me.btnPrdtadd.Name = "btnPrdtadd"
        Me.btnPrdtadd.Size = New System.Drawing.Size(47, 28)
        Me.btnPrdtadd.TabIndex = 21
        Me.btnPrdtadd.Text = "ADD"
        Me.btnPrdtadd.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "lbladdprdt"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(270, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 16)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "QTY :"
        '
        'txtaddQTY
        '
        Me.txtaddQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtaddQTY.Location = New System.Drawing.Point(323, 43)
        Me.txtaddQTY.Name = "txtaddQTY"
        Me.txtaddQTY.Size = New System.Drawing.Size(56, 22)
        Me.txtaddQTY.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "BOM PRDT :"
        '
        'CBoption
        '
        Me.CBoption.FormattingEnabled = True
        Me.CBoption.Location = New System.Drawing.Point(270, 11)
        Me.CBoption.Name = "CBoption"
        Me.CBoption.Size = New System.Drawing.Size(121, 21)
        Me.CBoption.TabIndex = 16
        '
        'btnPrdtSave
        '
        Me.btnPrdtSave.Location = New System.Drawing.Point(270, 71)
        Me.btnPrdtSave.Name = "btnPrdtSave"
        Me.btnPrdtSave.Size = New System.Drawing.Size(47, 28)
        Me.btnPrdtSave.TabIndex = 15
        Me.btnPrdtSave.Text = "SAVE"
        Me.btnPrdtSave.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(209, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Option"
        '
        'txtaddPrdt_t
        '
        Me.txtaddPrdt_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtaddPrdt_t.Location = New System.Drawing.Point(107, 43)
        Me.txtaddPrdt_t.Name = "txtaddPrdt_t"
        Me.txtaddPrdt_t.Size = New System.Drawing.Size(157, 22)
        Me.txtaddPrdt_t.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "PRDT :"
        '
        'txtaddPrdt
        '
        Me.txtaddPrdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtaddPrdt.Location = New System.Drawing.Point(70, 13)
        Me.txtaddPrdt.Name = "txtaddPrdt"
        Me.txtaddPrdt.Size = New System.Drawing.Size(133, 22)
        Me.txtaddPrdt.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMode, Me.ToolStripSeparator1, Me.btnNewSK, Me.btnAdd, Me.btnSave, Me.BtnDelete, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1759, 25)
        Me.ToolStrip1.TabIndex = 45
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblMode
        '
        Me.lblMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.Red
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(51, 22)
        Me.lblMode.Text = "VIEW"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNewSK
        '
        Me.btnNewSK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNewSK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSK.Image = CType(resources.GetObject("btnNewSK.Image"), System.Drawing.Image)
        Me.btnNewSK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewSK.Name = "btnNewSK"
        Me.btnNewSK.Size = New System.Drawing.Size(58, 22)
        Me.btnNewSK.Text = "New SK"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(41, 22)
        Me.btnAdd.Text = "ADD"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(43, 22)
        Me.btnSave.Text = "SAVE"
        '
        'BtnDelete
        '
        Me.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(58, 22)
        Me.BtnDelete.Text = "DELETE"
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'SKappDetailfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1759, 785)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtOrdate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblREV)
        Me.Controls.Add(Me.CsmrnoLBL)
        Me.Controls.Add(Me.sklbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.DGVUpload)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSpe)
        Me.Controls.Add(Me.CSMRLBL)
        Me.Controls.Add(Me.btnAddnote)
        Me.Controls.Add(Me.GBApp)
        Me.Controls.Add(Me.GBProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.DGVlog)
        Me.Controls.Add(Me.DGVMEMO)
        Me.Controls.Add(Me.DGVSK)
        Me.Controls.Add(Me.ReportBtn)
        Me.Name = "SKappDetailfrm"
        Me.Text = "SKappDetailfrm"
        CType(Me.DGVSK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMEMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVlog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBProd.ResumeLayout(False)
        Me.GBProd.PerformLayout()
        Me.GBApp.ResumeLayout(False)
        Me.GBApp.PerformLayout()
        CType(Me.DGVUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportBtn As Button
    Friend WithEvents DGVSK As DataGridView
    Friend WithEvents DGVMEMO As DataGridView
    Friend WithEvents DGVlog As DataGridView
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBProd As GroupBox
    Friend WithEvents BtnsetBomCode As Button
    Friend WithEvents btnSetDeldate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GBApp As GroupBox
    Friend WithEvents QCCB1 As TextBox
    Friend WithEvents QCCB As CheckBox
    Friend WithEvents btnAddnote As Button
    Friend WithEvents Marcb1 As TextBox
    Friend WithEvents Marcb As CheckBox
    Friend WithEvents Excb1 As TextBox
    Friend WithEvents Excb As CheckBox
    Friend WithEvents PROCB1 As TextBox
    Friend WithEvents PROCB As CheckBox
    Friend WithEvents E_SEQ As DataGridViewTextBoxColumn
    Friend WithEvents E_MEMO As DataGridViewTextBoxColumn
    Friend WithEvents CSMRLBL As Label
    Friend WithEvents lblSpe As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SKL_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents SKL_TIME As DataGridViewTextBoxColumn
    Friend WithEvents SKL_ACT As DataGridViewTextBoxColumn
    Friend WithEvents SKL_NAME As DataGridViewTextBoxColumn
    Friend WithEvents SKL_GROUP As DataGridViewTextBoxColumn
    Friend WithEvents DGVUpload As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents OPEN As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents SK_NAME As DataGridViewTextBoxColumn
    Friend WithEvents Skf_FNAME As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents sklbl As TextBox
    Friend WithEvents CsmrnoLBL As TextBox
    Friend WithEvents lblREV As TextBox
    Friend WithEvents txtOrdate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents P_UseDB As DataGridViewTextBoxColumn
    Friend WithEvents E_FUNC As DataGridViewTextBoxColumn
    Friend WithEvents E_Ordate As DataGridViewTextBoxColumn
    Friend WithEvents E_DELDATE As DataGridViewTextBoxColumn
    Friend WithEvents E_ORDER As DataGridViewTextBoxColumn
    Friend WithEvents E_PRDT As DataGridViewTextBoxColumn
    Friend WithEvents E_PRDT_T As DataGridViewTextBoxColumn
    Friend WithEvents E_SPEC As DataGridViewTextBoxColumn
    Friend WithEvents E_QTY As DataGridViewTextBoxColumn
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBoption As ComboBox
    Friend WithEvents btnPrdtSave As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtaddPrdt_t As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtaddPrdt As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtaddQTY As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnPrdtDel As Button
    Friend WithEvents btnPrdtadd As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNewSK As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents lblMode As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnCancel As ToolStripButton
End Class
