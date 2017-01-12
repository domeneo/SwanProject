<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAfrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLOT = New System.Windows.Forms.TextBox()
        Me.txtRea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrdt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHand = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.lblKEY = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.LBLSTATUS = New System.Windows.Forms.Label()
        Me.GetBtn = New System.Windows.Forms.Button()
        Me.cmdNEW = New System.Windows.Forms.Button()
        Me.GV1 = New System.Windows.Forms.DataGridView()
        Me.PRDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addPrdtbtn = New System.Windows.Forms.Button()
        Me.txtPrdtSpec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrdtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMA = New System.Windows.Forms.Label()
        Me.PnMAM = New System.Windows.Forms.Panel()
        Me.txtReaGet = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnMam = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMPage = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMLot = New System.Windows.Forms.TextBox()
        Me.txtLotDate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TxtLotClose = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DelPrdtbtn = New System.Windows.Forms.Button()
        Me.lblGVCount = New System.Windows.Forms.Label()
        Me.cbLotlock = New System.Windows.Forms.CheckBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnSK = New System.Windows.Forms.Button()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnMAM.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOT:"
        '
        'txtLOT
        '
        Me.txtLOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLOT.Location = New System.Drawing.Point(167, 72)
        Me.txtLOT.MaxLength = 6
        Me.txtLOT.Name = "txtLOT"
        Me.txtLOT.Size = New System.Drawing.Size(100, 22)
        Me.txtLOT.TabIndex = 3
        '
        'txtRea
        '
        Me.txtRea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRea.Location = New System.Drawing.Point(86, 72)
        Me.txtRea.MaxLength = 1
        Me.txtRea.Name = "txtRea"
        Me.txtRea.Size = New System.Drawing.Size(28, 22)
        Me.txtRea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reason:"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate.Location = New System.Drawing.Point(65, 100)
        Me.txtDate.MaxLength = 8
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date:"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(65, 44)
        Me.txtCode.MaxLength = 8
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(74, 22)
        Me.txtCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Code:"
        '
        'txtPrdt
        '
        Me.txtPrdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdt.Location = New System.Drawing.Point(65, 476)
        Me.txtPrdt.MaxLength = 11
        Me.txtPrdt.Name = "txtPrdt"
        Me.txtPrdt.Size = New System.Drawing.Size(121, 22)
        Me.txtPrdt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Prdt:"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStock.Location = New System.Drawing.Point(316, 507)
        Me.txtStock.MaxLength = 20
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(39, 22)
        Me.txtStock.TabIndex = 11
        Me.txtStock.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(259, 510)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Stock:"
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(241, 476)
        Me.txtQTY.MaxLength = 8
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(58, 22)
        Me.txtQTY.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(192, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "QTY:"
        '
        'txtInv
        '
        Me.txtInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInv.Location = New System.Drawing.Point(239, 100)
        Me.txtInv.MaxLength = 8
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(100, 22)
        Me.txtInv.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Invoice:"
        '
        'txtHand
        '
        Me.txtHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHand.Location = New System.Drawing.Point(453, 537)
        Me.txtHand.MaxLength = 6
        Me.txtHand.Name = "txtHand"
        Me.txtHand.Size = New System.Drawing.Size(100, 22)
        Me.txtHand.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(398, 543)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Hand:"
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(73, 17)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 1
        Me.DBCB.Text = "BOI"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(592, 11)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 48)
        Me.AddBtn.TabIndex = 12
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(592, 118)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 48)
        Me.DelBtn.TabIndex = 14
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        Me.DelBtn.Visible = False
        '
        'lblKEY
        '
        Me.lblKEY.AutoSize = True
        Me.lblKEY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKEY.Location = New System.Drawing.Point(226, 12)
        Me.lblKEY.Name = "lblKEY"
        Me.lblKEY.Size = New System.Drawing.Size(0, 24)
        Me.lblKEY.TabIndex = 25
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(592, 11)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 48)
        Me.SaveBtn.TabIndex = 13
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'LBLSTATUS
        '
        Me.LBLSTATUS.AutoSize = True
        Me.LBLSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBLSTATUS.Location = New System.Drawing.Point(141, 12)
        Me.LBLSTATUS.Name = "LBLSTATUS"
        Me.LBLSTATUS.Size = New System.Drawing.Size(0, 24)
        Me.LBLSTATUS.TabIndex = 27
        '
        'GetBtn
        '
        Me.GetBtn.Location = New System.Drawing.Point(197, 43)
        Me.GetBtn.Name = "GetBtn"
        Me.GetBtn.Size = New System.Drawing.Size(66, 24)
        Me.GetBtn.TabIndex = 28
        Me.GetBtn.Text = "GetDATA"
        Me.GetBtn.UseVisualStyleBackColor = True
        '
        'cmdNEW
        '
        Me.cmdNEW.Location = New System.Drawing.Point(145, 43)
        Me.cmdNEW.Name = "cmdNEW"
        Me.cmdNEW.Size = New System.Drawing.Size(46, 24)
        Me.cmdNEW.TabIndex = 29
        Me.cmdNEW.Text = "NEW"
        Me.cmdNEW.UseVisualStyleBackColor = True
        '
        'GV1
        '
        Me.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRDT, Me.QTY, Me.BAL, Me.PRICE})
        Me.GV1.Location = New System.Drawing.Point(17, 172)
        Me.GV1.Name = "GV1"
        Me.GV1.ReadOnly = True
        Me.GV1.Size = New System.Drawing.Size(527, 289)
        Me.GV1.TabIndex = 30
        '
        'PRDT
        '
        Me.PRDT.HeaderText = "PRDT"
        Me.PRDT.Name = "PRDT"
        Me.PRDT.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        '
        'BAL
        '
        Me.BAL.HeaderText = "BAL"
        Me.BAL.Name = "BAL"
        Me.BAL.ReadOnly = True
        '
        'PRICE
        '
        Me.PRICE.HeaderText = "PRICE"
        Me.PRICE.Name = "PRICE"
        Me.PRICE.ReadOnly = True
        Me.PRICE.Visible = False
        '
        'addPrdtbtn
        '
        Me.addPrdtbtn.Location = New System.Drawing.Point(319, 475)
        Me.addPrdtbtn.Name = "addPrdtbtn"
        Me.addPrdtbtn.Size = New System.Drawing.Size(75, 23)
        Me.addPrdtbtn.TabIndex = 8
        Me.addPrdtbtn.Text = "ADD PRDT"
        Me.addPrdtbtn.UseVisualStyleBackColor = True
        '
        'txtPrdtSpec
        '
        Me.txtPrdtSpec.Enabled = False
        Me.txtPrdtSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtSpec.Location = New System.Drawing.Point(84, 534)
        Me.txtPrdtSpec.MaxLength = 20
        Me.txtPrdtSpec.Name = "txtPrdtSpec"
        Me.txtPrdtSpec.Size = New System.Drawing.Size(226, 21)
        Me.txtPrdtSpec.TabIndex = 34
        Me.txtPrdtSpec.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "SPEC:"
        '
        'txtPrdtName
        '
        Me.txtPrdtName.Enabled = False
        Me.txtPrdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtName.Location = New System.Drawing.Point(84, 507)
        Me.txtPrdtName.MaxLength = 20
        Me.txtPrdtName.Name = "txtPrdtName"
        Me.txtPrdtName.Size = New System.Drawing.Size(168, 21)
        Me.txtPrdtName.TabIndex = 36
        Me.txtPrdtName.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "NAME:"
        '
        'lblMA
        '
        Me.lblMA.AutoSize = True
        Me.lblMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMA.Location = New System.Drawing.Point(11, 7)
        Me.lblMA.Name = "lblMA"
        Me.lblMA.Size = New System.Drawing.Size(56, 31)
        Me.lblMA.TabIndex = 37
        Me.lblMA.Text = "MA"
        '
        'PnMAM
        '
        Me.PnMAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnMAM.Controls.Add(Me.txtReaGet)
        Me.PnMAM.Controls.Add(Me.Label17)
        Me.PnMAM.Controls.Add(Me.Label14)
        Me.PnMAM.Controls.Add(Me.btnMam)
        Me.PnMAM.Controls.Add(Me.Label13)
        Me.PnMAM.Controls.Add(Me.txtMPage)
        Me.PnMAM.Controls.Add(Me.Label12)
        Me.PnMAM.Controls.Add(Me.txtMLot)
        Me.PnMAM.Location = New System.Drawing.Point(433, 11)
        Me.PnMAM.Name = "PnMAM"
        Me.PnMAM.Size = New System.Drawing.Size(153, 155)
        Me.PnMAM.TabIndex = 39
        '
        'txtReaGet
        '
        Me.txtReaGet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReaGet.Location = New System.Drawing.Point(75, 35)
        Me.txtReaGet.MaxLength = 1
        Me.txtReaGet.Name = "txtReaGet"
        Me.txtReaGet.Size = New System.Drawing.Size(28, 22)
        Me.txtReaGet.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 16)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Reason:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 16)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Auto Assign "
        '
        'btnMam
        '
        Me.btnMam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMam.Location = New System.Drawing.Point(59, 118)
        Me.btnMam.Name = "btnMam"
        Me.btnMam.Size = New System.Drawing.Size(75, 25)
        Me.btnMam.TabIndex = 41
        Me.btnMam.Text = "Get"
        Me.btnMam.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Page:"
        '
        'txtMPage
        '
        Me.txtMPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMPage.Location = New System.Drawing.Point(58, 91)
        Me.txtMPage.MaxLength = 8
        Me.txtMPage.Name = "txtMPage"
        Me.txtMPage.Size = New System.Drawing.Size(75, 22)
        Me.txtMPage.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "LOT:"
        '
        'txtMLot
        '
        Me.txtMLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMLot.Location = New System.Drawing.Point(59, 63)
        Me.txtMLot.MaxLength = 8
        Me.txtMLot.Name = "txtMLot"
        Me.txtMLot.Size = New System.Drawing.Size(74, 22)
        Me.txtMLot.TabIndex = 39
        '
        'txtLotDate
        '
        Me.txtLotDate.Enabled = False
        Me.txtLotDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLotDate.Location = New System.Drawing.Point(101, 128)
        Me.txtLotDate.MaxLength = 6
        Me.txtLotDate.Name = "txtLotDate"
        Me.txtLotDate.Size = New System.Drawing.Size(85, 22)
        Me.txtLotDate.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 16)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "LOTDATE:"
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(84, 561)
        Me.txtPrice.MaxLength = 20
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(90, 21)
        Me.txtPrice.TabIndex = 42
        Me.txtPrice.TabStop = False
        Me.txtPrice.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(592, 65)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 48)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TxtLotClose
        '
        Me.TxtLotClose.Enabled = False
        Me.TxtLotClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtLotClose.Location = New System.Drawing.Point(288, 128)
        Me.TxtLotClose.MaxLength = 6
        Me.TxtLotClose.Name = "TxtLotClose"
        Me.TxtLotClose.Size = New System.Drawing.Size(35, 22)
        Me.TxtLotClose.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(192, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "LOTCLOSE:"
        '
        'DelPrdtbtn
        '
        Me.DelPrdtbtn.Location = New System.Drawing.Point(400, 476)
        Me.DelPrdtbtn.Name = "DelPrdtbtn"
        Me.DelPrdtbtn.Size = New System.Drawing.Size(75, 23)
        Me.DelPrdtbtn.TabIndex = 46
        Me.DelPrdtbtn.Text = "DELETE PRDT"
        Me.DelPrdtbtn.UseVisualStyleBackColor = True
        Me.DelPrdtbtn.Visible = False
        '
        'lblGVCount
        '
        Me.lblGVCount.AutoSize = True
        Me.lblGVCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGVCount.Location = New System.Drawing.Point(491, 479)
        Me.lblGVCount.Name = "lblGVCount"
        Me.lblGVCount.Size = New System.Drawing.Size(0, 16)
        Me.lblGVCount.TabIndex = 47
        '
        'cbLotlock
        '
        Me.cbLotlock.AutoSize = True
        Me.cbLotlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbLotlock.Location = New System.Drawing.Point(329, 129)
        Me.cbLotlock.Name = "cbLotlock"
        Me.cbLotlock.Size = New System.Drawing.Size(98, 20)
        Me.cbLotlock.TabIndex = 48
        Me.cbLotlock.Text = "LOT LOCK"
        Me.cbLotlock.UseVisualStyleBackColor = True
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNote.Location = New System.Drawing.Point(567, 191)
        Me.txtNote.MaxLength = 0
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(252, 270)
        Me.txtNote.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(564, 172)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "NOTE:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(445, 564)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(222, 16)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "SHIFT+ENTER เพื่อมาที่ช่อง Hand"
        '
        'BtnSK
        '
        Me.BtnSK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnSK.Location = New System.Drawing.Point(273, 69)
        Me.BtnSK.Name = "BtnSK"
        Me.BtnSK.Size = New System.Drawing.Size(94, 25)
        Me.BtnSK.TabIndex = 43
        Me.BtnSK.Text = "GetFromSK"
        Me.BtnSK.UseVisualStyleBackColor = True
        '
        'MAfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(848, 606)
        Me.Controls.Add(Me.BtnSK)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbLotlock)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.lblGVCount)
        Me.Controls.Add(Me.DelPrdtbtn)
        Me.Controls.Add(Me.TxtLotClose)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtLotDate)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PnMAM)
        Me.Controls.Add(Me.lblMA)
        Me.Controls.Add(Me.txtPrdtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrdtSpec)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.addPrdtbtn)
        Me.Controls.Add(Me.GV1)
        Me.Controls.Add(Me.cmdNEW)
        Me.Controls.Add(Me.GetBtn)
        Me.Controls.Add(Me.LBLSTATUS)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.lblKEY)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.txtHand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtInv)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrdt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLOT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MAfrm"
        Me.Text = "MA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnMAM.ResumeLayout(False)
        Me.PnMAM.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLOT As System.Windows.Forms.TextBox
    Friend WithEvents txtRea As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrdt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInv As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHand As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DBCB As System.Windows.Forms.ComboBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents DelBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents LBLSTATUS As System.Windows.Forms.Label
    Public WithEvents lblKEY As System.Windows.Forms.Label
    Friend WithEvents GetBtn As System.Windows.Forms.Button
    Friend WithEvents cmdNEW As System.Windows.Forms.Button
    Friend WithEvents GV1 As System.Windows.Forms.DataGridView
    Friend WithEvents addPrdtbtn As System.Windows.Forms.Button
    Friend WithEvents txtPrdtSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrdtName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMA As System.Windows.Forms.Label
    Friend WithEvents PnMAM As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnMam As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMPage As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMLot As System.Windows.Forms.TextBox
    Friend WithEvents txtLotDate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PRDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtLotClose As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DelPrdtbtn As System.Windows.Forms.Button
    Friend WithEvents lblGVCount As System.Windows.Forms.Label
    Friend WithEvents txtReaGet As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbLotlock As CheckBox
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnSK As Button
End Class
