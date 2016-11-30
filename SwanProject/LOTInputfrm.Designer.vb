<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOTInputfrm
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
        Me.TXTPRDT = New System.Windows.Forms.TextBox()
        Me.TXTMA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTDEPT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTCODE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTISDATE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCOMDATE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTREA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTSKNO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCUNO = New System.Windows.Forms.TextBox()
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTCLOSE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTBOM = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTAQTY = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTAREA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTNOTE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXTSN1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTSN2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnPrintQA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVBOM = New System.Windows.Forms.DataGridView()
        CType(Me.DGVBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRDT:"
        '
        'TXTPRDT
        '
        Me.TXTPRDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTPRDT.Location = New System.Drawing.Point(88, 84)
        Me.TXTPRDT.MaxLength = 11
        Me.TXTPRDT.Name = "TXTPRDT"
        Me.TXTPRDT.Size = New System.Drawing.Size(223, 31)
        Me.TXTPRDT.TabIndex = 4
        '
        'TXTMA
        '
        Me.TXTMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTMA.Location = New System.Drawing.Point(247, 44)
        Me.TXTMA.MaxLength = 1
        Me.TXTMA.Name = "TXTMA"
        Me.TXTMA.Size = New System.Drawing.Size(38, 31)
        Me.TXTMA.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MA:"
        '
        'TXTDEPT
        '
        Me.TXTDEPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTDEPT.Location = New System.Drawing.Point(95, 129)
        Me.TXTDEPT.MaxLength = 3
        Me.TXTDEPT.Name = "TXTDEPT"
        Me.TXTDEPT.Size = New System.Drawing.Size(100, 31)
        Me.TXTDEPT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DEPT:"
        '
        'TXTCODE
        '
        Me.TXTCODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTCODE.Location = New System.Drawing.Point(72, 44)
        Me.TXTCODE.MaxLength = 6
        Me.TXTCODE.Name = "TXTCODE"
        Me.TXTCODE.Size = New System.Drawing.Size(120, 31)
        Me.TXTCODE.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LOT:"
        '
        'TXTISDATE
        '
        Me.TXTISDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTISDATE.Location = New System.Drawing.Point(159, 169)
        Me.TXTISDATE.MaxLength = 8
        Me.TXTISDATE.Name = "TXTISDATE"
        Me.TXTISDATE.Size = New System.Drawing.Size(139, 31)
        Me.TXTISDATE.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ISSUE DATE:"
        '
        'TXTCOMDATE
        '
        Me.TXTCOMDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTCOMDATE.Location = New System.Drawing.Point(521, 169)
        Me.TXTCOMDATE.MaxLength = 8
        Me.TXTCOMDATE.Name = "TXTCOMDATE"
        Me.TXTCOMDATE.Size = New System.Drawing.Size(146, 31)
        Me.TXTCOMDATE.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "COMPLETED DATE:"
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(83, 207)
        Me.txtQTY.MaxLength = 15
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(120, 31)
        Me.txtQTY.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "QTY:"
        '
        'TXTREA
        '
        Me.TXTREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTREA.Location = New System.Drawing.Point(139, 244)
        Me.TXTREA.MaxLength = 1
        Me.TXTREA.Name = "TXTREA"
        Me.TXTREA.Size = New System.Drawing.Size(100, 31)
        Me.TXTREA.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "REASON:"
        '
        'TXTSKNO
        '
        Me.TXTSKNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTSKNO.Location = New System.Drawing.Point(95, 279)
        Me.TXTSKNO.MaxLength = 6
        Me.TXTSKNO.Name = "TXTSKNO"
        Me.TXTSKNO.Size = New System.Drawing.Size(144, 31)
        Me.TXTSKNO.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 25)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "SKNO:"
        '
        'TXTCUNO
        '
        Me.TXTCUNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTCUNO.Location = New System.Drawing.Point(351, 279)
        Me.TXTCUNO.MaxLength = 8
        Me.TXTCUNO.Name = "TXTCUNO"
        Me.TXTCUNO.Size = New System.Drawing.Size(164, 31)
        Me.TXTCUNO.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(254, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "CU.NO.:"
        '
        'DBCB
        '
        Me.DBCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(72, 7)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(66, 33)
        Me.DBCB.TabIndex = 1
        Me.DBCB.Text = "BOI"
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(19, 460)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(96, 48)
        Me.AddBtn.TabIndex = 18
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(323, 460)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(95, 48)
        Me.DelBtn.TabIndex = 21
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'lblKEY
        '
        Me.lblKEY.AutoSize = True
        Me.lblKEY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKEY.Location = New System.Drawing.Point(254, 10)
        Me.lblKEY.Name = "lblKEY"
        Me.lblKEY.Size = New System.Drawing.Size(0, 25)
        Me.lblKEY.TabIndex = 25
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(121, 460)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(95, 48)
        Me.SaveBtn.TabIndex = 19
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'LBLSTATUS
        '
        Me.LBLSTATUS.AutoSize = True
        Me.LBLSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LBLSTATUS.Location = New System.Drawing.Point(195, 10)
        Me.LBLSTATUS.Name = "LBLSTATUS"
        Me.LBLSTATUS.Size = New System.Drawing.Size(0, 25)
        Me.LBLSTATUS.TabIndex = 27
        '
        'GetBtn
        '
        Me.GetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GetBtn.Location = New System.Drawing.Point(525, 42)
        Me.GetBtn.Name = "GetBtn"
        Me.GetBtn.Size = New System.Drawing.Size(124, 33)
        Me.GetBtn.TabIndex = 28
        Me.GetBtn.Text = "GetDATA"
        Me.GetBtn.UseVisualStyleBackColor = True
        '
        'cmdNEW
        '
        Me.cmdNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdNEW.Location = New System.Drawing.Point(433, 42)
        Me.cmdNEW.Name = "cmdNEW"
        Me.cmdNEW.Size = New System.Drawing.Size(83, 33)
        Me.cmdNEW.TabIndex = 29
        Me.cmdNEW.Text = "NEW"
        Me.cmdNEW.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(222, 460)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 48)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 25)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "LOT"
        '
        'TXTCLOSE
        '
        Me.TXTCLOSE.Enabled = False
        Me.TXTCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTCLOSE.Location = New System.Drawing.Point(377, 44)
        Me.TXTCLOSE.MaxLength = 1
        Me.TXTCLOSE.Name = "TXTCLOSE"
        Me.TXTCLOSE.Size = New System.Drawing.Size(40, 31)
        Me.TXTCLOSE.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(301, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 25)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Close:"
        '
        'TXTBOM
        '
        Me.TXTBOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTBOM.Location = New System.Drawing.Point(389, 84)
        Me.TXTBOM.MaxLength = 11
        Me.TXTBOM.Name = "TXTBOM"
        Me.TXTBOM.Size = New System.Drawing.Size(260, 31)
        Me.TXTBOM.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(317, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 25)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "BOM:"
        '
        'TXTAQTY
        '
        Me.TXTAQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTAQTY.Location = New System.Drawing.Point(291, 207)
        Me.TXTAQTY.MaxLength = 15
        Me.TXTAQTY.Name = "TXTAQTY"
        Me.TXTAQTY.Size = New System.Drawing.Size(118, 31)
        Me.TXTAQTY.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 25)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "AQTY:"
        '
        'TXTAREA
        '
        Me.TXTAREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTAREA.Location = New System.Drawing.Point(95, 316)
        Me.TXTAREA.MaxLength = 300
        Me.TXTAREA.Name = "TXTAREA"
        Me.TXTAREA.Size = New System.Drawing.Size(304, 31)
        Me.TXTAREA.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 319)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 25)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "AREA:"
        '
        'TXTNOTE
        '
        Me.TXTNOTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTNOTE.Location = New System.Drawing.Point(95, 353)
        Me.TXTNOTE.MaxLength = 300
        Me.TXTNOTE.Name = "TXTNOTE"
        Me.TXTNOTE.Size = New System.Drawing.Size(572, 31)
        Me.TXTNOTE.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 356)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 25)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "NOTE:"
        '
        'TXTSN1
        '
        Me.TXTSN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTSN1.Location = New System.Drawing.Point(148, 390)
        Me.TXTSN1.MaxLength = 8
        Me.TXTSN1.Name = "TXTSN1"
        Me.TXTSN1.Size = New System.Drawing.Size(197, 31)
        Me.TXTSN1.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 393)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 25)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "SERAIL NO:"
        '
        'TXTSN2
        '
        Me.TXTSN2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTSN2.Location = New System.Drawing.Point(405, 390)
        Me.TXTSN2.MaxLength = 8
        Me.TXTSN2.Name = "TXTSN2"
        Me.TXTSN2.Size = New System.Drawing.Size(244, 31)
        Me.TXTSN2.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(358, 393)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 25)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "TO"
        '
        'btnPrintQA
        '
        Me.btnPrintQA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrintQA.Location = New System.Drawing.Point(655, 43)
        Me.btnPrintQA.Name = "btnPrintQA"
        Me.btnPrintQA.Size = New System.Drawing.Size(148, 33)
        Me.btnPrintQA.TabIndex = 46
        Me.btnPrintQA.Text = "Set PrintQA"
        Me.btnPrintQA.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(521, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 33)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "testsetseno"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DGVBOM
        '
        Me.DGVBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBOM.Location = New System.Drawing.Point(12, 514)
        Me.DGVBOM.Name = "DGVBOM"
        Me.DGVBOM.RowHeadersVisible = False
        Me.DGVBOM.Size = New System.Drawing.Size(1132, 204)
        Me.DGVBOM.TabIndex = 48
        Me.DGVBOM.Visible = False
        '
        'LOTInputfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 730)
        Me.Controls.Add(Me.DGVBOM)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPrintQA)
        Me.Controls.Add(Me.TXTSN2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TXTSN1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TXTNOTE)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TXTAREA)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXTAQTY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTBOM)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXTCLOSE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmdNEW)
        Me.Controls.Add(Me.GetBtn)
        Me.Controls.Add(Me.LBLSTATUS)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.lblKEY)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.TXTCUNO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTSKNO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXTREA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTCOMDATE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTISDATE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTCODE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTDEPT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTMA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTPRDT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LOTInputfrm"
        Me.Text = "LOT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVBOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTPRDT As System.Windows.Forms.TextBox
    Friend WithEvents TXTMA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTDEPT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTISDATE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTCOMDATE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTREA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTSKNO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTCUNO As System.Windows.Forms.TextBox
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTCLOSE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXTBOM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXTAQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTAREA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTNOTE As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TXTSN1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TXTSN2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnPrintQA As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DGVBOM As DataGridView
End Class
