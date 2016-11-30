<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MBListfrm
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
        Me.GV1 = New System.Windows.Forms.DataGridView()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.refeshBtn = New System.Windows.Forms.Button()
        Me.wheretxt = New System.Windows.Forms.TextBox()
        Me.ColCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ExcelBtn = New System.Windows.Forms.Button()
        Me.ShowAllbtn = New System.Windows.Forms.Button()
        Me.txtSelectTOP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFromCode = New System.Windows.Forms.TextBox()
        Me.txtTocode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnShowCode = New System.Windows.Forms.Button()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV1
        '
        Me.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GV1.Location = New System.Drawing.Point(12, 85)
        Me.GV1.Name = "GV1"
        Me.GV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GV1.Size = New System.Drawing.Size(535, 244)
        Me.GV1.TabIndex = 28
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(174, 42)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 23)
        Me.DelBtn.TabIndex = 25
        Me.DelBtn.Text = "DELETE"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(93, 42)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 23)
        Me.EditBtn.TabIndex = 24
        Me.EditBtn.Text = "EDIT"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(12, 42)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 23)
        Me.addBtn.TabIndex = 23
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'refeshBtn
        '
        Me.refeshBtn.Location = New System.Drawing.Point(255, 42)
        Me.refeshBtn.Name = "refeshBtn"
        Me.refeshBtn.Size = New System.Drawing.Size(75, 23)
        Me.refeshBtn.TabIndex = 26
        Me.refeshBtn.Text = "REFRESH"
        Me.refeshBtn.UseVisualStyleBackColor = True
        '
        'wheretxt
        '
        Me.wheretxt.Location = New System.Drawing.Point(255, 13)
        Me.wheretxt.Name = "wheretxt"
        Me.wheretxt.Size = New System.Drawing.Size(100, 20)
        Me.wheretxt.TabIndex = 27
        '
        'ColCB
        '
        Me.ColCB.FormattingEnabled = True
        Me.ColCB.Location = New System.Drawing.Point(174, 12)
        Me.ColCB.Name = "ColCB"
        Me.ColCB.Size = New System.Drawing.Size(75, 21)
        Me.ColCB.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Filter:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCount.Location = New System.Drawing.Point(16, 68)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(91, 13)
        Me.lblCount.TabIndex = 32
        Me.lblCount.Text = "จำนวนทั้งหมด :"
        '
        'ExcelBtn
        '
        Me.ExcelBtn.Location = New System.Drawing.Point(336, 42)
        Me.ExcelBtn.Name = "ExcelBtn"
        Me.ExcelBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExcelBtn.TabIndex = 33
        Me.ExcelBtn.Text = "EXCEL"
        Me.ExcelBtn.UseVisualStyleBackColor = True
        '
        'ShowAllbtn
        '
        Me.ShowAllbtn.Location = New System.Drawing.Point(647, 11)
        Me.ShowAllbtn.Name = "ShowAllbtn"
        Me.ShowAllbtn.Size = New System.Drawing.Size(75, 23)
        Me.ShowAllbtn.TabIndex = 42
        Me.ShowAllbtn.Text = "Show"
        Me.ShowAllbtn.UseVisualStyleBackColor = True
        '
        'txtSelectTOP
        '
        Me.txtSelectTOP.Location = New System.Drawing.Point(528, 12)
        Me.txtSelectTOP.Name = "txtSelectTOP"
        Me.txtSelectTOP.Size = New System.Drawing.Size(59, 20)
        Me.txtSelectTOP.TabIndex = 43
        Me.txtSelectTOP.Text = "200"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "แสดงรายการล่าสุด "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "DB:"
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(48, 13)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 46
        Me.DBCB.Text = "BOI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(593, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "รายการ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "แสดงตั้งแต่เลขที่"
        '
        'txtFromCode
        '
        Me.txtFromCode.Location = New System.Drawing.Point(519, 44)
        Me.txtFromCode.MaxLength = 6
        Me.txtFromCode.Name = "txtFromCode"
        Me.txtFromCode.Size = New System.Drawing.Size(59, 20)
        Me.txtFromCode.TabIndex = 49
        '
        'txtTocode
        '
        Me.txtTocode.Location = New System.Drawing.Point(612, 45)
        Me.txtTocode.MaxLength = 6
        Me.txtTocode.Name = "txtTocode"
        Me.txtTocode.Size = New System.Drawing.Size(59, 20)
        Me.txtTocode.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(584, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "ถึง"
        '
        'btnShowCode
        '
        Me.btnShowCode.Location = New System.Drawing.Point(677, 42)
        Me.btnShowCode.Name = "btnShowCode"
        Me.btnShowCode.Size = New System.Drawing.Size(75, 23)
        Me.btnShowCode.TabIndex = 52
        Me.btnShowCode.Text = "Show"
        Me.btnShowCode.UseVisualStyleBackColor = True
        '
        'MAListfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(781, 374)
        Me.Controls.Add(Me.btnShowCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTocode)
        Me.Controls.Add(Me.txtFromCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSelectTOP)
        Me.Controls.Add(Me.ShowAllbtn)
        Me.Controls.Add(Me.ExcelBtn)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColCB)
        Me.Controls.Add(Me.wheretxt)
        Me.Controls.Add(Me.refeshBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.GV1)
        Me.Name = "MAListfrm"
        Me.Text = "MB List"
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GV1 As System.Windows.Forms.DataGridView
    Friend WithEvents DelBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents refeshBtn As System.Windows.Forms.Button
    Friend WithEvents wheretxt As System.Windows.Forms.TextBox
    Friend WithEvents ColCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents ExcelBtn As System.Windows.Forms.Button
    Friend WithEvents ShowAllbtn As System.Windows.Forms.Button
    Friend WithEvents txtSelectTOP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DBCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFromCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTocode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnShowCode As System.Windows.Forms.Button
End Class
