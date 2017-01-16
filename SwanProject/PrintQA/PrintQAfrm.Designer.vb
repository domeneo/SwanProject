<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintQAfrm
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
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_C = New System.Windows.Forms.RadioButton()
        Me.RB_S = New System.Windows.Forms.RadioButton()
        Me.RB_M = New System.Windows.Forms.RadioButton()
        Me.cbNotPrint = New System.Windows.Forms.CheckBox()
        Me.btnPrintLabel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtINV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DBCB
        '
        Me.DBCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(12, 12)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(69, 32)
        Me.DBCB.TabIndex = 2
        Me.DBCB.Text = "BOI"
        '
        'PrintBtn
        '
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PrintBtn.Location = New System.Drawing.Point(597, 12)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(75, 48)
        Me.PrintBtn.TabIndex = 16
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(276, 12)
        Me.txtCode.MaxLength = 0
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCode.Size = New System.Drawing.Size(255, 317)
        Me.txtCode.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "LOT :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_C)
        Me.GroupBox1.Controls.Add(Me.RB_S)
        Me.GroupBox1.Controls.Add(Me.RB_M)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 121)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกแบบฟอร์ม"
        '
        'RB_C
        '
        Me.RB_C.AutoSize = True
        Me.RB_C.Location = New System.Drawing.Point(23, 73)
        Me.RB_C.Name = "RB_C"
        Me.RB_C.Size = New System.Drawing.Size(108, 28)
        Me.RB_C.TabIndex = 23
        Me.RB_C.Text = "QA Claim"
        Me.RB_C.UseVisualStyleBackColor = True
        '
        'RB_S
        '
        Me.RB_S.AutoSize = True
        Me.RB_S.Location = New System.Drawing.Point(23, 50)
        Me.RB_S.Name = "RB_S"
        Me.RB_S.Size = New System.Drawing.Size(73, 28)
        Me.RB_S.TabIndex = 22
        Me.RB_S.Text = "QA S"
        Me.RB_S.UseVisualStyleBackColor = True
        '
        'RB_M
        '
        Me.RB_M.AutoSize = True
        Me.RB_M.Checked = True
        Me.RB_M.Location = New System.Drawing.Point(23, 28)
        Me.RB_M.Name = "RB_M"
        Me.RB_M.Size = New System.Drawing.Size(95, 28)
        Me.RB_M.TabIndex = 21
        Me.RB_M.TabStop = True
        Me.RB_M.Text = "QA M,D"
        Me.RB_M.UseVisualStyleBackColor = True
        '
        'cbNotPrint
        '
        Me.cbNotPrint.AutoSize = True
        Me.cbNotPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbNotPrint.Location = New System.Drawing.Point(12, 177)
        Me.cbNotPrint.Name = "cbNotPrint"
        Me.cbNotPrint.Size = New System.Drawing.Size(237, 28)
        Me.cbNotPrint.TabIndex = 22
        Me.cbNotPrint.Text = "Print ที่ยังไม่Print ทั้งหมด"
        Me.cbNotPrint.UseVisualStyleBackColor = True
        '
        'btnPrintLabel
        '
        Me.btnPrintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrintLabel.Location = New System.Drawing.Point(597, 80)
        Me.btnPrintLabel.Name = "btnPrintLabel"
        Me.btnPrintLabel.Size = New System.Drawing.Size(75, 65)
        Me.btnPrintLabel.TabIndex = 23
        Me.btnPrintLabel.Text = "Print Label"
        Me.btnPrintLabel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(619, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ตั้งกระดาษให้มีขนาด"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "กว้าง 8.6นิ้ว x 5.5นิ้ว"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(620, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "และตั้งDefault Printer ไว้"
        '
        'txtINV
        '
        Me.txtINV.Location = New System.Drawing.Point(101, 221)
        Me.txtINV.Name = "txtINV"
        Me.txtINV.Size = New System.Drawing.Size(148, 20)
        Me.txtINV.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "INVOICE NO."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "ตัวอย่างการใส่ INV 538493-11001123"
        '
        'PrintQAfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(868, 404)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtINV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintLabel)
        Me.Controls.Add(Me.cbNotPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.DBCB)
        Me.Name = "PrintQAfrm"
        Me.Text = "PrintQAfrm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBCB As ComboBox
    Friend WithEvents PrintBtn As Button
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB_S As RadioButton
    Friend WithEvents RB_M As RadioButton
    Friend WithEvents cbNotPrint As CheckBox
    Friend WithEvents btnPrintLabel As Button
    Friend WithEvents RB_C As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtINV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
