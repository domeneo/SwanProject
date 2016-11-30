<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRDTListfrm
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
        Me.refeshBtn = New System.Windows.Forms.Button()
        Me.wheretxt = New System.Windows.Forms.TextBox()
        Me.ColCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ExcelBtn = New System.Windows.Forms.Button()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSelectTOP = New System.Windows.Forms.TextBox()
        Me.ShowAllbtn = New System.Windows.Forms.Button()
        Me.btnShowCode = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTocode = New System.Windows.Forms.TextBox()
        Me.txtFromCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GBEDIT = New System.Windows.Forms.GroupBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEDIT.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV1
        '
        Me.GV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GV1.Location = New System.Drawing.Point(12, 86)
        Me.GV1.Name = "GV1"
        Me.GV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GV1.Size = New System.Drawing.Size(1038, 478)
        Me.GV1.TabIndex = 28
        '
        'refeshBtn
        '
        Me.refeshBtn.Location = New System.Drawing.Point(12, 43)
        Me.refeshBtn.Name = "refeshBtn"
        Me.refeshBtn.Size = New System.Drawing.Size(75, 23)
        Me.refeshBtn.TabIndex = 26
        Me.refeshBtn.Text = "REFRESH"
        Me.refeshBtn.UseVisualStyleBackColor = True
        '
        'wheretxt
        '
        Me.wheretxt.Location = New System.Drawing.Point(261, 12)
        Me.wheretxt.Name = "wheretxt"
        Me.wheretxt.Size = New System.Drawing.Size(100, 20)
        Me.wheretxt.TabIndex = 27
        '
        'ColCB
        '
        Me.ColCB.FormattingEnabled = True
        Me.ColCB.Items.AddRange(New Object() {"P_PRDT", "P_ENAME", "P_TNAME", "P_SPEC"})
        Me.ColCB.Location = New System.Drawing.Point(143, 12)
        Me.ColCB.Name = "ColCB"
        Me.ColCB.Size = New System.Drawing.Size(112, 21)
        Me.ColCB.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Filter:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCount.Location = New System.Drawing.Point(12, 68)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(91, 13)
        Me.lblCount.TabIndex = 32
        Me.lblCount.Text = "จำนวนทั้งหมด :"
        '
        'ExcelBtn
        '
        Me.ExcelBtn.Location = New System.Drawing.Point(93, 43)
        Me.ExcelBtn.Name = "ExcelBtn"
        Me.ExcelBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExcelBtn.TabIndex = 33
        Me.ExcelBtn.Text = "EXCEL"
        Me.ExcelBtn.UseVisualStyleBackColor = True
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(12, 12)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 35
        Me.DBCB.Text = "BOI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(551, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "รายการ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "แสดงรายการล่าสุด "
        '
        'txtSelectTOP
        '
        Me.txtSelectTOP.Location = New System.Drawing.Point(486, 14)
        Me.txtSelectTOP.Name = "txtSelectTOP"
        Me.txtSelectTOP.Size = New System.Drawing.Size(59, 20)
        Me.txtSelectTOP.TabIndex = 49
        Me.txtSelectTOP.Text = "200"
        '
        'ShowAllbtn
        '
        Me.ShowAllbtn.Location = New System.Drawing.Point(605, 13)
        Me.ShowAllbtn.Name = "ShowAllbtn"
        Me.ShowAllbtn.Size = New System.Drawing.Size(75, 23)
        Me.ShowAllbtn.TabIndex = 48
        Me.ShowAllbtn.Text = "Show"
        Me.ShowAllbtn.UseVisualStyleBackColor = True
        '
        'btnShowCode
        '
        Me.btnShowCode.Location = New System.Drawing.Point(447, 43)
        Me.btnShowCode.Name = "btnShowCode"
        Me.btnShowCode.Size = New System.Drawing.Size(75, 23)
        Me.btnShowCode.TabIndex = 57
        Me.btnShowCode.Text = "Show"
        Me.btnShowCode.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(354, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "ถึง"
        '
        'txtTocode
        '
        Me.txtTocode.Location = New System.Drawing.Point(382, 46)
        Me.txtTocode.MaxLength = 6
        Me.txtTocode.Name = "txtTocode"
        Me.txtTocode.Size = New System.Drawing.Size(59, 20)
        Me.txtTocode.TabIndex = 55
        '
        'txtFromCode
        '
        Me.txtFromCode.Location = New System.Drawing.Point(289, 45)
        Me.txtFromCode.MaxLength = 6
        Me.txtFromCode.Name = "txtFromCode"
        Me.txtFromCode.Size = New System.Drawing.Size(59, 20)
        Me.txtFromCode.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "แสดงตั้งแต่รหัส"
        '
        'GBEDIT
        '
        Me.GBEDIT.Controls.Add(Me.btnDel)
        Me.GBEDIT.Controls.Add(Me.btnAdd)
        Me.GBEDIT.Controls.Add(Me.btnEdit)
        Me.GBEDIT.Location = New System.Drawing.Point(528, 35)
        Me.GBEDIT.Name = "GBEDIT"
        Me.GBEDIT.Size = New System.Drawing.Size(252, 31)
        Me.GBEDIT.TabIndex = 60
        Me.GBEDIT.TabStop = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(168, 7)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 63
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(87, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 60
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'PRDTListfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1062, 576)
        Me.Controls.Add(Me.GBEDIT)
        Me.Controls.Add(Me.btnShowCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTocode)
        Me.Controls.Add(Me.txtFromCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSelectTOP)
        Me.Controls.Add(Me.ShowAllbtn)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.ExcelBtn)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColCB)
        Me.Controls.Add(Me.wheretxt)
        Me.Controls.Add(Me.refeshBtn)
        Me.Controls.Add(Me.GV1)
        Me.Name = "PRDTListfrm"
        Me.Text = "PRDT"
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEDIT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GV1 As System.Windows.Forms.DataGridView
    Friend WithEvents refeshBtn As System.Windows.Forms.Button
    Friend WithEvents wheretxt As System.Windows.Forms.TextBox
    Friend WithEvents ColCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents ExcelBtn As System.Windows.Forms.Button
    Friend WithEvents DBCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSelectTOP As System.Windows.Forms.TextBox
    Friend WithEvents ShowAllbtn As System.Windows.Forms.Button
    Friend WithEvents btnShowCode As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTocode As System.Windows.Forms.TextBox
    Friend WithEvents txtFromCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GBEDIT As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
