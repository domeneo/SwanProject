<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editstockfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLOT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrdt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBlot = New System.Windows.Forms.TextBox()
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
        Me.GV1 = New System.Windows.Forms.DataGridView()
        Me.addPrdtbtn = New System.Windows.Forms.Button()
        Me.lblslip = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DelPrdtbtn = New System.Windows.Forms.Button()
        Me.CBREA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtCond = New System.Windows.Forms.TextBox()
        Me.txtSUP = New System.Windows.Forms.TextBox()
        Me.GBPrdt = New System.Windows.Forms.GroupBox()
        Me.TXTBAL = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPrdtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrdtSpec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBLOT = New System.Windows.Forms.GroupBox()
        Me.txtLotDEPT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtLotClose = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLotDate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnnew_editcode = New System.Windows.Forms.Button()
        Me.btnget_editcode = New System.Windows.Forms.Button()
        Me.txtedtior = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEditNote = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEditreq = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEditcode = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtedittime = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtINV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstime = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PRDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_NOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPrdt.SuspendLayout()
        Me.GBLOT.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOT:"
        '
        'txtLOT
        '
        Me.txtLOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLOT.Location = New System.Drawing.Point(63, 75)
        Me.txtLOT.MaxLength = 6
        Me.txtLOT.Name = "txtLOT"
        Me.txtLOT.Size = New System.Drawing.Size(84, 22)
        Me.txtLOT.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 496)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reason:"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate.Location = New System.Drawing.Point(200, 76)
        Me.txtDate.MaxLength = 8
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(75, 22)
        Me.txtDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 78)
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
        Me.txtPrdt.Location = New System.Drawing.Point(63, 493)
        Me.txtPrdt.MaxLength = 11
        Me.txtPrdt.Name = "txtPrdt"
        Me.txtPrdt.Size = New System.Drawing.Size(121, 22)
        Me.txtPrdt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 493)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Prdt:"
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(239, 493)
        Me.txtQTY.MaxLength = 8
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(58, 22)
        Me.txtQTY.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(190, 496)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "QTY:"
        '
        'txtBlot
        '
        Me.txtBlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBlot.Location = New System.Drawing.Point(340, 76)
        Me.txtBlot.MaxLength = 8
        Me.txtBlot.Name = "txtBlot"
        Me.txtBlot.Size = New System.Drawing.Size(80, 22)
        Me.txtBlot.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(287, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "BLOT:"
        '
        'txtHand
        '
        Me.txtHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHand.Location = New System.Drawing.Point(722, 492)
        Me.txtHand.MaxLength = 6
        Me.txtHand.Name = "txtHand"
        Me.txtHand.Size = New System.Drawing.Size(100, 22)
        Me.txtHand.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(668, 498)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Hand:"
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(100, 17)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 1
        Me.DBCB.Text = "BOI"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(583, 17)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 48)
        Me.AddBtn.TabIndex = 12
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(583, 124)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 48)
        Me.DelBtn.TabIndex = 14
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'lblKEY
        '
        Me.lblKEY.AutoSize = True
        Me.lblKEY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKEY.Location = New System.Drawing.Point(253, 12)
        Me.lblKEY.Name = "lblKEY"
        Me.lblKEY.Size = New System.Drawing.Size(0, 24)
        Me.lblKEY.TabIndex = 25
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(583, 17)
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
        Me.LBLSTATUS.Location = New System.Drawing.Point(168, 12)
        Me.LBLSTATUS.Name = "LBLSTATUS"
        Me.LBLSTATUS.Size = New System.Drawing.Size(0, 24)
        Me.LBLSTATUS.TabIndex = 27
        '
        'GetBtn
        '
        Me.GetBtn.Location = New System.Drawing.Point(144, 43)
        Me.GetBtn.Name = "GetBtn"
        Me.GetBtn.Size = New System.Drawing.Size(66, 24)
        Me.GetBtn.TabIndex = 28
        Me.GetBtn.Text = "GetDATA"
        Me.GetBtn.UseVisualStyleBackColor = True
        '
        'GV1
        '
        Me.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRDT, Me.QTY, Me.REA, Me.COND, Me.DEPT, Me.SUP, Me.PRICE, Me.INV, Me.BAL, Me.KG, Me.MONTH, Me.S_NOTE})
        Me.GV1.Location = New System.Drawing.Point(17, 184)
        Me.GV1.Name = "GV1"
        Me.GV1.ReadOnly = True
        Me.GV1.Size = New System.Drawing.Size(1164, 301)
        Me.GV1.TabIndex = 30
        '
        'addPrdtbtn
        '
        Me.addPrdtbtn.Location = New System.Drawing.Point(561, 491)
        Me.addPrdtbtn.Name = "addPrdtbtn"
        Me.addPrdtbtn.Size = New System.Drawing.Size(75, 23)
        Me.addPrdtbtn.TabIndex = 11
        Me.addPrdtbtn.Text = "ADD PRDT"
        Me.addPrdtbtn.UseVisualStyleBackColor = True
        '
        'lblslip
        '
        Me.lblslip.AutoSize = True
        Me.lblslip.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblslip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblslip.Location = New System.Drawing.Point(11, 7)
        Me.lblslip.Name = "lblslip"
        Me.lblslip.Size = New System.Drawing.Size(81, 31)
        Me.lblslip.TabIndex = 37
        Me.lblslip.Text = "EDIT"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(583, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 48)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DelPrdtbtn
        '
        Me.DelPrdtbtn.Location = New System.Drawing.Point(561, 520)
        Me.DelPrdtbtn.Name = "DelPrdtbtn"
        Me.DelPrdtbtn.Size = New System.Drawing.Size(75, 23)
        Me.DelPrdtbtn.TabIndex = 46
        Me.DelPrdtbtn.TabStop = False
        Me.DelPrdtbtn.Text = "DELETE PRDT"
        Me.DelPrdtbtn.UseVisualStyleBackColor = True
        '
        'CBREA
        '
        Me.CBREA.FormattingEnabled = True
        Me.CBREA.Items.AddRange(New Object() {"S", "R", "A", "B"})
        Me.CBREA.Location = New System.Drawing.Point(384, 492)
        Me.CBREA.Name = "CBREA"
        Me.CBREA.Size = New System.Drawing.Size(39, 21)
        Me.CBREA.TabIndex = 7
        Me.CBREA.Text = "S"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(149, 523)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Condition:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 523)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "DEPT:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(305, 523)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Supplier:"
        '
        'txtDept
        '
        Me.txtDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDept.Location = New System.Drawing.Point(72, 520)
        Me.txtDept.MaxLength = 3
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(58, 22)
        Me.txtDept.TabIndex = 8
        '
        'txtCond
        '
        Me.txtCond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCond.Location = New System.Drawing.Point(232, 520)
        Me.txtCond.MaxLength = 8
        Me.txtCond.Name = "txtCond"
        Me.txtCond.Size = New System.Drawing.Size(58, 22)
        Me.txtCond.TabIndex = 9
        '
        'txtSUP
        '
        Me.txtSUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSUP.Location = New System.Drawing.Point(381, 521)
        Me.txtSUP.MaxLength = 8
        Me.txtSUP.Name = "txtSUP"
        Me.txtSUP.Size = New System.Drawing.Size(58, 22)
        Me.txtSUP.TabIndex = 10
        '
        'GBPrdt
        '
        Me.GBPrdt.Controls.Add(Me.TXTBAL)
        Me.GBPrdt.Controls.Add(Me.txtPlace)
        Me.GBPrdt.Controls.Add(Me.txtPrice)
        Me.GBPrdt.Controls.Add(Me.txtPrdtName)
        Me.GBPrdt.Controls.Add(Me.Label9)
        Me.GBPrdt.Controls.Add(Me.txtPrdtSpec)
        Me.GBPrdt.Controls.Add(Me.Label7)
        Me.GBPrdt.Location = New System.Drawing.Point(19, 548)
        Me.GBPrdt.Name = "GBPrdt"
        Me.GBPrdt.Size = New System.Drawing.Size(639, 82)
        Me.GBPrdt.TabIndex = 56
        Me.GBPrdt.TabStop = False
        Me.GBPrdt.Text = "Prdt Detail"
        '
        'TXTBAL
        '
        Me.TXTBAL.Enabled = False
        Me.TXTBAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBAL.Location = New System.Drawing.Point(488, 22)
        Me.TXTBAL.MaxLength = 20
        Me.TXTBAL.Name = "TXTBAL"
        Me.TXTBAL.Size = New System.Drawing.Size(90, 21)
        Me.TXTBAL.TabIndex = 49
        Me.TXTBAL.TabStop = False
        Me.TXTBAL.Visible = False
        '
        'txtPlace
        '
        Me.txtPlace.Enabled = False
        Me.txtPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPlace.Location = New System.Drawing.Point(434, 22)
        Me.txtPlace.MaxLength = 20
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(47, 21)
        Me.txtPlace.TabIndex = 48
        Me.txtPlace.TabStop = False
        Me.txtPlace.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(330, 22)
        Me.txtPrice.MaxLength = 20
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(90, 21)
        Me.txtPrice.TabIndex = 47
        Me.txtPrice.TabStop = False
        Me.txtPrice.Visible = False
        '
        'txtPrdtName
        '
        Me.txtPrdtName.Enabled = False
        Me.txtPrdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtName.Location = New System.Drawing.Point(70, 22)
        Me.txtPrdtName.MaxLength = 20
        Me.txtPrdtName.Name = "txtPrdtName"
        Me.txtPrdtName.Size = New System.Drawing.Size(168, 21)
        Me.txtPrdtName.TabIndex = 46
        Me.txtPrdtName.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "NAME:"
        '
        'txtPrdtSpec
        '
        Me.txtPrdtSpec.Enabled = False
        Me.txtPrdtSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtSpec.Location = New System.Drawing.Point(70, 49)
        Me.txtPrdtSpec.MaxLength = 20
        Me.txtPrdtSpec.Name = "txtPrdtSpec"
        Me.txtPrdtSpec.Size = New System.Drawing.Size(226, 21)
        Me.txtPrdtSpec.TabIndex = 44
        Me.txtPrdtSpec.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "SPEC:"
        '
        'GBLOT
        '
        Me.GBLOT.Controls.Add(Me.txtLotDEPT)
        Me.GBLOT.Controls.Add(Me.Label12)
        Me.GBLOT.Controls.Add(Me.TxtLotClose)
        Me.GBLOT.Controls.Add(Me.Label16)
        Me.GBLOT.Controls.Add(Me.txtLotDate)
        Me.GBLOT.Controls.Add(Me.Label15)
        Me.GBLOT.Location = New System.Drawing.Point(17, 103)
        Me.GBLOT.Name = "GBLOT"
        Me.GBLOT.Size = New System.Drawing.Size(524, 65)
        Me.GBLOT.TabIndex = 57
        Me.GBLOT.TabStop = False
        Me.GBLOT.Text = "LOT Detail"
        '
        'txtLotDEPT
        '
        Me.txtLotDEPT.Enabled = False
        Me.txtLotDEPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLotDEPT.Location = New System.Drawing.Point(450, 22)
        Me.txtLotDEPT.MaxLength = 6
        Me.txtLotDEPT.Name = "txtLotDEPT"
        Me.txtLotDEPT.Size = New System.Drawing.Size(61, 22)
        Me.txtLotDEPT.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(362, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "LOTDEPT:"
        '
        'TxtLotClose
        '
        Me.TxtLotClose.Enabled = False
        Me.TxtLotClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtLotClose.Location = New System.Drawing.Point(295, 22)
        Me.TxtLotClose.MaxLength = 6
        Me.TxtLotClose.Name = "TxtLotClose"
        Me.TxtLotClose.Size = New System.Drawing.Size(61, 22)
        Me.TxtLotClose.TabIndex = 52
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(200, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 16)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "LOTCLOSE:"
        '
        'txtLotDate
        '
        Me.txtLotDate.Enabled = False
        Me.txtLotDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLotDate.Location = New System.Drawing.Point(94, 22)
        Me.txtLotDate.MaxLength = 6
        Me.txtLotDate.Name = "txtLotDate"
        Me.txtLotDate.Size = New System.Drawing.Size(100, 22)
        Me.txtLotDate.TabIndex = 50
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 16)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "LOTDATE:"
        '
        'btnnew_editcode
        '
        Me.btnnew_editcode.Location = New System.Drawing.Point(843, 7)
        Me.btnnew_editcode.Name = "btnnew_editcode"
        Me.btnnew_editcode.Size = New System.Drawing.Size(46, 24)
        Me.btnnew_editcode.TabIndex = 58
        Me.btnnew_editcode.Text = "NEW"
        Me.btnnew_editcode.UseVisualStyleBackColor = True
        '
        'btnget_editcode
        '
        Me.btnget_editcode.Location = New System.Drawing.Point(890, 7)
        Me.btnget_editcode.Name = "btnget_editcode"
        Me.btnget_editcode.Size = New System.Drawing.Size(38, 24)
        Me.btnget_editcode.TabIndex = 57
        Me.btnget_editcode.Text = "Get"
        Me.btnget_editcode.UseVisualStyleBackColor = True
        '
        'txtedtior
        '
        Me.txtedtior.Enabled = False
        Me.txtedtior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtedtior.Location = New System.Drawing.Point(746, 129)
        Me.txtedtior.MaxLength = 6
        Me.txtedtior.Name = "txtedtior"
        Me.txtedtior.Size = New System.Drawing.Size(145, 22)
        Me.txtedtior.TabIndex = 56
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(704, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 16)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "ผู้แก้:"
        '
        'txtEditNote
        '
        Me.txtEditNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEditNote.Location = New System.Drawing.Point(704, 78)
        Me.txtEditNote.MaxLength = 0
        Me.txtEditNote.Multiline = True
        Me.txtEditNote.Name = "txtEditNote"
        Me.txtEditNote.Size = New System.Drawing.Size(188, 48)
        Me.txtEditNote.TabIndex = 54
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(704, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "รายละเอียด:"
        '
        'txtEditreq
        '
        Me.txtEditreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEditreq.Location = New System.Drawing.Point(777, 37)
        Me.txtEditreq.MaxLength = 30
        Me.txtEditreq.Name = "txtEditreq"
        Me.txtEditreq.Size = New System.Drawing.Size(114, 22)
        Me.txtEditreq.TabIndex = 52
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(704, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "ผู้ขอให้แก้:"
        '
        'txtEditcode
        '
        Me.txtEditcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEditcode.Location = New System.Drawing.Point(777, 11)
        Me.txtEditcode.MaxLength = 6
        Me.txtEditcode.Name = "txtEditcode"
        Me.txtEditcode.Size = New System.Drawing.Size(61, 22)
        Me.txtEditcode.TabIndex = 50
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(704, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 16)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Edit Code:"
        '
        'txtedittime
        '
        Me.txtedittime.Enabled = False
        Me.txtedittime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtedittime.Location = New System.Drawing.Point(763, 157)
        Me.txtedittime.MaxLength = 6
        Me.txtedittime.Name = "txtedittime"
        Me.txtedittime.Size = New System.Drawing.Size(127, 22)
        Me.txtedittime.TabIndex = 60
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(702, 158)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 16)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "เวลาแก้:"
        '
        'txtINV
        '
        Me.txtINV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtINV.Location = New System.Drawing.Point(487, 521)
        Me.txtINV.MaxLength = 8
        Me.txtINV.Name = "txtINV"
        Me.txtINV.Size = New System.Drawing.Size(58, 22)
        Me.txtINV.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 523)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "INVO:"
        '
        'txtstime
        '
        Me.txtstime.Enabled = False
        Me.txtstime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtstime.Location = New System.Drawing.Point(724, 519)
        Me.txtstime.MaxLength = 6
        Me.txtstime.Name = "txtstime"
        Me.txtstime.Size = New System.Drawing.Size(173, 22)
        Me.txtstime.TabIndex = 63
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(668, 522)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 16)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Time:"
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
        'REA
        '
        Me.REA.HeaderText = "REA"
        Me.REA.Name = "REA"
        Me.REA.ReadOnly = True
        '
        'COND
        '
        Me.COND.HeaderText = "COND"
        Me.COND.Name = "COND"
        Me.COND.ReadOnly = True
        '
        'DEPT
        '
        Me.DEPT.HeaderText = "DEPT"
        Me.DEPT.Name = "DEPT"
        Me.DEPT.ReadOnly = True
        '
        'SUP
        '
        Me.SUP.HeaderText = "SUP"
        Me.SUP.Name = "SUP"
        Me.SUP.ReadOnly = True
        '
        'PRICE
        '
        Me.PRICE.HeaderText = "PRICE"
        Me.PRICE.Name = "PRICE"
        Me.PRICE.ReadOnly = True
        '
        'INV
        '
        Me.INV.HeaderText = "INV"
        Me.INV.Name = "INV"
        Me.INV.ReadOnly = True
        '
        'BAL
        '
        Me.BAL.HeaderText = "BAL"
        Me.BAL.Name = "BAL"
        Me.BAL.ReadOnly = True
        '
        'KG
        '
        Me.KG.HeaderText = "KG"
        Me.KG.Name = "KG"
        Me.KG.ReadOnly = True
        '
        'MONTH
        '
        Me.MONTH.HeaderText = "MONTH"
        Me.MONTH.Name = "MONTH"
        Me.MONTH.ReadOnly = True
        '
        'S_NOTE
        '
        Me.S_NOTE.HeaderText = "NOTE"
        Me.S_NOTE.Name = "S_NOTE"
        Me.S_NOTE.ReadOnly = True
        Me.S_NOTE.Width = 150
        '
        'editstockfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1193, 658)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtstime)
        Me.Controls.Add(Me.txtINV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtedittime)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnnew_editcode)
        Me.Controls.Add(Me.btnget_editcode)
        Me.Controls.Add(Me.GBLOT)
        Me.Controls.Add(Me.txtedtior)
        Me.Controls.Add(Me.GBPrdt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtSUP)
        Me.Controls.Add(Me.txtEditNote)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCond)
        Me.Controls.Add(Me.txtEditreq)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtEditcode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CBREA)
        Me.Controls.Add(Me.DelPrdtbtn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblslip)
        Me.Controls.Add(Me.addPrdtbtn)
        Me.Controls.Add(Me.GV1)
        Me.Controls.Add(Me.GetBtn)
        Me.Controls.Add(Me.LBLSTATUS)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.lblKEY)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.txtHand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBlot)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrdt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLOT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editstockfrm"
        Me.Text = "Editstock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPrdt.ResumeLayout(False)
        Me.GBPrdt.PerformLayout()
        Me.GBLOT.ResumeLayout(False)
        Me.GBLOT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLOT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrdt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBlot As System.Windows.Forms.TextBox
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
    Friend WithEvents GV1 As System.Windows.Forms.DataGridView
    Friend WithEvents addPrdtbtn As System.Windows.Forms.Button
    Friend WithEvents lblslip As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DelPrdtbtn As System.Windows.Forms.Button
    Friend WithEvents CBREA As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents txtCond As System.Windows.Forms.TextBox
    Friend WithEvents txtSUP As System.Windows.Forms.TextBox
    Friend WithEvents GBPrdt As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtPrdtName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrdtSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GBLOT As System.Windows.Forms.GroupBox
    Friend WithEvents txtLotDEPT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtLotClose As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLotDate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents TXTBAL As System.Windows.Forms.TextBox
    Friend WithEvents txtedtior As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtEditNote As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEditreq As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtEditcode As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnnew_editcode As Button
    Friend WithEvents btnget_editcode As Button
    Friend WithEvents txtedittime As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtINV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstime As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents PRDT As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents REA As DataGridViewTextBoxColumn
    Friend WithEvents COND As DataGridViewTextBoxColumn
    Friend WithEvents DEPT As DataGridViewTextBoxColumn
    Friend WithEvents SUP As DataGridViewTextBoxColumn
    Friend WithEvents PRICE As DataGridViewTextBoxColumn
    Friend WithEvents INV As DataGridViewTextBoxColumn
    Friend WithEvents BAL As DataGridViewTextBoxColumn
    Friend WithEvents KG As DataGridViewTextBoxColumn
    Friend WithEvents MONTH As DataGridViewTextBoxColumn
    Friend WithEvents S_NOTE As DataGridViewTextBoxColumn
End Class
