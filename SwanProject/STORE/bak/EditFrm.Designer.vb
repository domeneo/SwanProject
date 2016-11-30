<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editfrm

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
        Me.addPrdtbtn = New System.Windows.Forms.Button()
        Me.txtPrdtSpec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrdtName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMA = New System.Windows.Forms.Label()
        Me.txtLotDate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TxtLotClose = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DelPrdtbtn = New System.Windows.Forms.Button()
        Me.lblGVCount = New System.Windows.Forms.Label()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtREQ = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEditdetail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnNewEdit = New System.Windows.Forms.Button()
        Me.btnEditGet = New System.Windows.Forms.Button()
        Me.txtedittime = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PRDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOT:"
        '
        'txtLOT
        '
        Me.txtLOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLOT.Location = New System.Drawing.Point(223, 89)
        Me.txtLOT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLOT.MaxLength = 6
        Me.txtLOT.Name = "txtLOT"
        Me.txtLOT.Size = New System.Drawing.Size(132, 26)
        Me.txtLOT.TabIndex = 3
        '
        'txtRea
        '
        Me.txtRea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRea.Location = New System.Drawing.Point(115, 89)
        Me.txtRea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRea.MaxLength = 1
        Me.txtRea.Name = "txtRea"
        Me.txtRea.Size = New System.Drawing.Size(36, 26)
        Me.txtRea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reason:"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate.Location = New System.Drawing.Point(87, 123)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.MaxLength = 8
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(132, 26)
        Me.txtDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date:"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(87, 54)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.MaxLength = 8
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(124, 26)
        Me.txtCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Code:"
        '
        'txtPrdt
        '
        Me.txtPrdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdt.Location = New System.Drawing.Point(87, 602)
        Me.txtPrdt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrdt.MaxLength = 11
        Me.txtPrdt.Name = "txtPrdt"
        Me.txtPrdt.Size = New System.Drawing.Size(160, 26)
        Me.txtPrdt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 602)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Prdt:"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStock.Location = New System.Drawing.Point(421, 640)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.MaxLength = 20
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(51, 26)
        Me.txtStock.TabIndex = 11
        Me.txtStock.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(345, 644)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Stock:"
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(321, 602)
        Me.txtQTY.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQTY.MaxLength = 8
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(76, 26)
        Me.txtQTY.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(256, 606)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "QTY:"
        '
        'txtInv
        '
        Me.txtInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInv.Location = New System.Drawing.Point(319, 123)
        Me.txtInv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInv.MaxLength = 20
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(132, 26)
        Me.txtInv.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(228, 127)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Invoice:"
        '
        'txtHand
        '
        Me.txtHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHand.Location = New System.Drawing.Point(604, 677)
        Me.txtHand.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHand.MaxLength = 6
        Me.txtHand.Name = "txtHand"
        Me.txtHand.Size = New System.Drawing.Size(132, 26)
        Me.txtHand.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(531, 684)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Hand:"
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(176, 18)
        Me.DBCB.Margin = New System.Windows.Forms.Padding(4)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(77, 24)
        Me.DBCB.TabIndex = 1
        Me.DBCB.Text = "BOI"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(865, 13)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(100, 59)
        Me.AddBtn.TabIndex = 12
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(865, 145)
        Me.DelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(100, 59)
        Me.DelBtn.TabIndex = 14
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        Me.DelBtn.Visible = False
        '
        'lblKEY
        '
        Me.lblKEY.AutoSize = True
        Me.lblKEY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKEY.Location = New System.Drawing.Point(380, 12)
        Me.lblKEY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKEY.Name = "lblKEY"
        Me.lblKEY.Size = New System.Drawing.Size(0, 29)
        Me.lblKEY.TabIndex = 25
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(865, 12)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(100, 59)
        Me.SaveBtn.TabIndex = 13
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'LBLSTATUS
        '
        Me.LBLSTATUS.AutoSize = True
        Me.LBLSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBLSTATUS.Location = New System.Drawing.Point(267, 12)
        Me.LBLSTATUS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLSTATUS.Name = "LBLSTATUS"
        Me.LBLSTATUS.Size = New System.Drawing.Size(0, 29)
        Me.LBLSTATUS.TabIndex = 27
        '
        'GetBtn
        '
        Me.GetBtn.Location = New System.Drawing.Point(219, 53)
        Me.GetBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.GetBtn.Name = "GetBtn"
        Me.GetBtn.Size = New System.Drawing.Size(88, 30)
        Me.GetBtn.TabIndex = 28
        Me.GetBtn.Text = "GetDATA"
        Me.GetBtn.UseVisualStyleBackColor = True
        '
        'cmdNEW
        '
        Me.cmdNEW.Location = New System.Drawing.Point(409, 27)
        Me.cmdNEW.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNEW.Name = "cmdNEW"
        Me.cmdNEW.Size = New System.Drawing.Size(61, 30)
        Me.cmdNEW.TabIndex = 29
        Me.cmdNEW.Text = "NEW"
        Me.cmdNEW.UseVisualStyleBackColor = True
        Me.cmdNEW.Visible = False
        '
        'GV1
        '
        Me.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRDT, Me.QTY, Me.BAL, Me.PRICE, Me.DEPT})
        Me.GV1.Location = New System.Drawing.Point(23, 233)
        Me.GV1.Margin = New System.Windows.Forms.Padding(4)
        Me.GV1.Name = "GV1"
        Me.GV1.ReadOnly = True
        Me.GV1.Size = New System.Drawing.Size(703, 361)
        Me.GV1.TabIndex = 30
        '
        'addPrdtbtn
        '
        Me.addPrdtbtn.Location = New System.Drawing.Point(425, 601)
        Me.addPrdtbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addPrdtbtn.Name = "addPrdtbtn"
        Me.addPrdtbtn.Size = New System.Drawing.Size(100, 28)
        Me.addPrdtbtn.TabIndex = 8
        Me.addPrdtbtn.Text = "ADD PRDT"
        Me.addPrdtbtn.UseVisualStyleBackColor = True
        '
        'txtPrdtSpec
        '
        Me.txtPrdtSpec.Enabled = False
        Me.txtPrdtSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtSpec.Location = New System.Drawing.Point(112, 673)
        Me.txtPrdtSpec.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrdtSpec.MaxLength = 20
        Me.txtPrdtSpec.Name = "txtPrdtSpec"
        Me.txtPrdtSpec.Size = New System.Drawing.Size(300, 24)
        Me.txtPrdtSpec.TabIndex = 34
        Me.txtPrdtSpec.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 677)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "SPEC:"
        '
        'txtPrdtName
        '
        Me.txtPrdtName.Enabled = False
        Me.txtPrdtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtName.Location = New System.Drawing.Point(112, 640)
        Me.txtPrdtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrdtName.MaxLength = 20
        Me.txtPrdtName.Name = "txtPrdtName"
        Me.txtPrdtName.Size = New System.Drawing.Size(223, 24)
        Me.txtPrdtName.TabIndex = 36
        Me.txtPrdtName.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 644)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "NAME:"
        '
        'lblMA
        '
        Me.lblMA.AutoSize = True
        Me.lblMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMA.Location = New System.Drawing.Point(17, 12)
        Me.lblMA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMA.Name = "lblMA"
        Me.lblMA.Size = New System.Drawing.Size(134, 29)
        Me.lblMA.TabIndex = 37
        Me.lblMA.Text = "EDIT SLIP"
        '
        'txtLotDate
        '
        Me.txtLotDate.Enabled = False
        Me.txtLotDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLotDate.Location = New System.Drawing.Point(141, 158)
        Me.txtLotDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLotDate.MaxLength = 6
        Me.txtLotDate.Name = "txtLotDate"
        Me.txtLotDate.Size = New System.Drawing.Size(132, 26)
        Me.txtLotDate.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 161)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 20)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "LOTDATE:"
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(112, 706)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.MaxLength = 20
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(119, 24)
        Me.txtPrice.TabIndex = 42
        Me.txtPrice.TabStop = False
        Me.txtPrice.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(865, 79)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 59)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TxtLotClose
        '
        Me.TxtLotClose.Enabled = False
        Me.TxtLotClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TxtLotClose.Location = New System.Drawing.Point(409, 158)
        Me.TxtLotClose.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLotClose.MaxLength = 6
        Me.TxtLotClose.Name = "TxtLotClose"
        Me.TxtLotClose.Size = New System.Drawing.Size(80, 26)
        Me.TxtLotClose.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(283, 161)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 20)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "LOTCLOSE:"
        '
        'DelPrdtbtn
        '
        Me.DelPrdtbtn.Location = New System.Drawing.Point(533, 602)
        Me.DelPrdtbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DelPrdtbtn.Name = "DelPrdtbtn"
        Me.DelPrdtbtn.Size = New System.Drawing.Size(100, 28)
        Me.DelPrdtbtn.TabIndex = 46
        Me.DelPrdtbtn.Text = "DELETE PRDT"
        Me.DelPrdtbtn.UseVisualStyleBackColor = True
        Me.DelPrdtbtn.Visible = False
        '
        'lblGVCount
        '
        Me.lblGVCount.AutoSize = True
        Me.lblGVCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGVCount.Location = New System.Drawing.Point(655, 606)
        Me.lblGVCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGVCount.Name = "lblGVCount"
        Me.lblGVCount.Size = New System.Drawing.Size(0, 20)
        Me.lblGVCount.TabIndex = 47
        '
        'txtEdit
        '
        Me.txtEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEdit.Location = New System.Drawing.Point(629, 9)
        Me.txtEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEdit.MaxLength = 6
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(97, 26)
        Me.txtEdit.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(505, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 20)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "EDIT CODE:"
        '
        'txtEditor
        '
        Me.txtEditor.Enabled = False
        Me.txtEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEditor.Location = New System.Drawing.Point(603, 43)
        Me.txtEditor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditor.MaxLength = 6
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.Size = New System.Drawing.Size(123, 26)
        Me.txtEditor.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(505, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "EDITOR :"
        '
        'txtREQ
        '
        Me.txtREQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtREQ.Location = New System.Drawing.Point(603, 77)
        Me.txtREQ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtREQ.MaxLength = 6
        Me.txtREQ.Name = "txtREQ"
        Me.txtREQ.Size = New System.Drawing.Size(123, 26)
        Me.txtREQ.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(505, 80)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "ผู้ขอให้แก้ :"
        '
        'txtEditdetail
        '
        Me.txtEditdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEditdetail.Location = New System.Drawing.Point(509, 132)
        Me.txtEditdetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditdetail.MaxLength = 0
        Me.txtEditdetail.Multiline = True
        Me.txtEditdetail.Name = "txtEditdetail"
        Me.txtEditdetail.Size = New System.Drawing.Size(227, 72)
        Me.txtEditdetail.TabIndex = 55
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(505, 108)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(172, 20)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "รายละเอียดการแก้ไข:"
        '
        'btnNewEdit
        '
        Me.btnNewEdit.Location = New System.Drawing.Point(734, 8)
        Me.btnNewEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewEdit.Name = "btnNewEdit"
        Me.btnNewEdit.Size = New System.Drawing.Size(61, 30)
        Me.btnNewEdit.TabIndex = 57
        Me.btnNewEdit.Text = "NEW"
        Me.btnNewEdit.UseVisualStyleBackColor = True
        '
        'btnEditGet
        '
        Me.btnEditGet.Location = New System.Drawing.Point(734, 46)
        Me.btnEditGet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditGet.Name = "btnEditGet"
        Me.btnEditGet.Size = New System.Drawing.Size(61, 30)
        Me.btnEditGet.TabIndex = 58
        Me.btnEditGet.Text = "Get"
        Me.btnEditGet.UseVisualStyleBackColor = True
        '
        'txtedittime
        '
        Me.txtedittime.Enabled = False
        Me.txtedittime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtedittime.Location = New System.Drawing.Point(509, 205)
        Me.txtedittime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtedittime.MaxLength = 6
        Me.txtedittime.Name = "txtedittime"
        Me.txtedittime.Size = New System.Drawing.Size(227, 26)
        Me.txtedittime.TabIndex = 60
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(445, 208)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 20)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "time :"
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
        '
        'DEPT
        '
        Me.DEPT.HeaderText = "DEPT"
        Me.DEPT.Name = "DEPT"
        Me.DEPT.ReadOnly = True
        '
        'Editfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1061, 746)
        Me.Controls.Add(Me.txtedittime)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnEditGet)
        Me.Controls.Add(Me.btnNewEdit)
        Me.Controls.Add(Me.txtEditdetail)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtREQ)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtEditor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblGVCount)
        Me.Controls.Add(Me.DelPrdtbtn)
        Me.Controls.Add(Me.TxtLotClose)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtLotDate)
        Me.Controls.Add(Me.Label15)
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
        Me.Controls.Add(Me.AddBtn)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Editfrm"
        Me.Text = "MA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtLotDate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtLotClose As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DelPrdtbtn As System.Windows.Forms.Button
    Friend WithEvents lblGVCount As System.Windows.Forms.Label
    Friend WithEvents txtEdit As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEditor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtREQ As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEditdetail As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnNewEdit As Button
    Friend WithEvents btnEditGet As Button
    Friend WithEvents txtedittime As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents PRDT As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents BAL As DataGridViewTextBoxColumn
    Friend WithEvents PRICE As DataGridViewTextBoxColumn
    Friend WithEvents DEPT As DataGridViewTextBoxColumn
End Class
