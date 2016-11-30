<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QAfrm
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
        Me.txtSupno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LBLSLIP = New System.Windows.Forms.Label()
        Me.txtLotClose = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTSUP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbal = New System.Windows.Forms.TextBox()
        Me.txtmonth = New System.Windows.Forms.TextBox()
        Me.txtLOTQTY = New System.Windows.Forms.TextBox()
        Me.txtMCQTY = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbLotlock = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOT:"
        '
        'txtLOT
        '
        Me.txtLOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLOT.Location = New System.Drawing.Point(65, 100)
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
        Me.txtDate.Location = New System.Drawing.Point(65, 128)
        Me.txtDate.MaxLength = 8
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 131)
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
        Me.txtPrdt.Location = New System.Drawing.Point(65, 156)
        Me.txtPrdt.MaxLength = 11
        Me.txtPrdt.Name = "txtPrdt"
        Me.txtPrdt.Size = New System.Drawing.Size(121, 22)
        Me.txtPrdt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Prdt:"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStock.Location = New System.Drawing.Point(65, 184)
        Me.txtStock.MaxLength = 20
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 22)
        Me.txtStock.TabIndex = 11
        Me.txtStock.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Stock:"
        '
        'txtSupno
        '
        Me.txtSupno.Enabled = False
        Me.txtSupno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSupno.Location = New System.Drawing.Point(86, 212)
        Me.txtSupno.MaxLength = 8
        Me.txtSupno.Name = "txtSupno"
        Me.txtSupno.Size = New System.Drawing.Size(100, 22)
        Me.txtSupno.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Supcode:"
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(86, 268)
        Me.txtQTY.MaxLength = 8
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(100, 22)
        Me.txtQTY.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "QTY:"
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(86, 297)
        Me.txtPrice.MaxLength = 300
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Price:"
        '
        'txtInv
        '
        Me.txtInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInv.Location = New System.Drawing.Point(86, 324)
        Me.txtInv.MaxLength = 20
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Size = New System.Drawing.Size(100, 22)
        Me.txtInv.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Invoice:"
        '
        'txtHand
        '
        Me.txtHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHand.Location = New System.Drawing.Point(86, 353)
        Me.txtHand.MaxLength = 6
        Me.txtHand.Name = "txtHand"
        Me.txtHand.Size = New System.Drawing.Size(100, 22)
        Me.txtHand.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Hand:"
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(65, 13)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 1
        Me.DBCB.Text = "BOI"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(205, 187)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 48)
        Me.AddBtn.TabIndex = 12
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(205, 296)
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
        Me.lblKEY.Location = New System.Drawing.Point(201, 8)
        Me.lblKEY.Name = "lblKEY"
        Me.lblKEY.Size = New System.Drawing.Size(0, 24)
        Me.lblKEY.TabIndex = 25
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(205, 187)
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
        Me.LBLSTATUS.Location = New System.Drawing.Point(136, 10)
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
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(205, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 48)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'LBLSLIP
        '
        Me.LBLSLIP.AutoSize = True
        Me.LBLSLIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBLSLIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBLSLIP.Location = New System.Drawing.Point(10, 3)
        Me.LBLSLIP.Name = "LBLSLIP"
        Me.LBLSLIP.Size = New System.Drawing.Size(53, 29)
        Me.LBLSLIP.TabIndex = 31
        Me.LBLSLIP.Text = "WE"
        '
        'txtLotClose
        '
        Me.txtLotClose.Enabled = False
        Me.txtLotClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLotClose.Location = New System.Drawing.Point(240, 100)
        Me.txtLotClose.MaxLength = 6
        Me.txtLotClose.Name = "txtLotClose"
        Me.txtLotClose.Size = New System.Drawing.Size(40, 22)
        Me.txtLotClose.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(182, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Close:"
        '
        'TXTSUP
        '
        Me.TXTSUP.Enabled = False
        Me.TXTSUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTSUP.Location = New System.Drawing.Point(86, 240)
        Me.TXTSUP.MaxLength = 8
        Me.TXTSUP.Name = "TXTSUP"
        Me.TXTSUP.Size = New System.Drawing.Size(100, 22)
        Me.TXTSUP.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Sup:"
        '
        'txtbal
        '
        Me.txtbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtbal.Location = New System.Drawing.Point(258, 380)
        Me.txtbal.MaxLength = 8
        Me.txtbal.Name = "txtbal"
        Me.txtbal.ReadOnly = True
        Me.txtbal.Size = New System.Drawing.Size(27, 22)
        Me.txtbal.TabIndex = 36
        Me.txtbal.TabStop = False
        Me.txtbal.Text = "0"
        Me.txtbal.Visible = False
        '
        'txtmonth
        '
        Me.txtmonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmonth.Location = New System.Drawing.Point(226, 380)
        Me.txtmonth.MaxLength = 8
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.ReadOnly = True
        Me.txtmonth.Size = New System.Drawing.Size(27, 22)
        Me.txtmonth.TabIndex = 37
        Me.txtmonth.TabStop = False
        Me.txtmonth.Text = "*"
        Me.txtmonth.Visible = False
        '
        'txtLOTQTY
        '
        Me.txtLOTQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLOTQTY.Location = New System.Drawing.Point(99, 381)
        Me.txtLOTQTY.MaxLength = 8
        Me.txtLOTQTY.Name = "txtLOTQTY"
        Me.txtLOTQTY.ReadOnly = True
        Me.txtLOTQTY.Size = New System.Drawing.Size(66, 22)
        Me.txtLOTQTY.TabIndex = 38
        Me.txtLOTQTY.TabStop = False
        '
        'txtMCQTY
        '
        Me.txtMCQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMCQTY.Location = New System.Drawing.Point(99, 409)
        Me.txtMCQTY.MaxLength = 8
        Me.txtMCQTY.Name = "txtMCQTY"
        Me.txtMCQTY.ReadOnly = True
        Me.txtMCQTY.Size = New System.Drawing.Size(66, 22)
        Me.txtMCQTY.TabIndex = 39
        Me.txtMCQTY.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 16)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "LOT QTY:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 412)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "QTY:"
        '
        'cbLotlock
        '
        Me.cbLotlock.AutoSize = True
        Me.cbLotlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbLotlock.Location = New System.Drawing.Point(185, 128)
        Me.cbLotlock.Name = "cbLotlock"
        Me.cbLotlock.Size = New System.Drawing.Size(98, 20)
        Me.cbLotlock.TabIndex = 56
        Me.cbLotlock.Text = "LOT LOCK"
        Me.cbLotlock.UseVisualStyleBackColor = True
        '
        'QAfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 454)
        Me.Controls.Add(Me.cbLotlock)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMCQTY)
        Me.Controls.Add(Me.txtLOTQTY)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.txtbal)
        Me.Controls.Add(Me.TXTSUP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtLotClose)
        Me.Controls.Add(Me.LBLSLIP)
        Me.Controls.Add(Me.btnCancel)
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
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSupno)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "QAfrm"
        Me.Text = "QA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents txtSupno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LBLSLIP As System.Windows.Forms.Label
    Friend WithEvents txtLotClose As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXTSUP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbal As TextBox
    Friend WithEvents txtmonth As TextBox
    Friend WithEvents txtLOTQTY As TextBox
    Friend WithEvents txtMCQTY As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbLotlock As CheckBox
End Class
