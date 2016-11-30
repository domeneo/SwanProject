<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseLOTfrm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInlot = New System.Windows.Forms.TextBox()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnTo5 = New System.Windows.Forms.Button()
        Me.btnto7 = New System.Windows.Forms.Button()
        Me.btnTo9 = New System.Windows.Forms.Button()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.txtFlot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBLot5 = New System.Windows.Forms.CheckBox()
        Me.cbLot7 = New System.Windows.Forms.CheckBox()
        Me.cbLot9 = New System.Windows.Forms.CheckBox()
        Me.Findbtn = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "รายการLOT"
        '
        'txtInlot
        '
        Me.txtInlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInlot.Location = New System.Drawing.Point(12, 52)
        Me.txtInlot.Multiline = True
        Me.txtInlot.Name = "txtInlot"
        Me.txtInlot.Size = New System.Drawing.Size(72, 502)
        Me.txtInlot.TabIndex = 51
        '
        'DBCB
        '
        Me.DBCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(12, 12)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(72, 21)
        Me.DBCB.TabIndex = 53
        Me.DBCB.Text = "BOI"
        '
        'DGV1
        '
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(175, 52)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(1044, 502)
        Me.DGV1.TabIndex = 54
        '
        'btnTo5
        '
        Me.btnTo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTo5.Location = New System.Drawing.Point(94, 82)
        Me.btnTo5.Name = "btnTo5"
        Me.btnTo5.Size = New System.Drawing.Size(75, 44)
        Me.btnTo5.TabIndex = 55
        Me.btnTo5.Text = ">>5"
        Me.btnTo5.UseVisualStyleBackColor = True
        '
        'btnto7
        '
        Me.btnto7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnto7.Location = New System.Drawing.Point(94, 238)
        Me.btnto7.Name = "btnto7"
        Me.btnto7.Size = New System.Drawing.Size(75, 44)
        Me.btnto7.TabIndex = 56
        Me.btnto7.Text = ">>7"
        Me.btnto7.UseVisualStyleBackColor = True
        '
        'btnTo9
        '
        Me.btnTo9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTo9.Location = New System.Drawing.Point(94, 394)
        Me.btnTo9.Name = "btnTo9"
        Me.btnTo9.Size = New System.Drawing.Size(75, 44)
        Me.btnTo9.TabIndex = 57
        Me.btnTo9.Text = ">>9"
        Me.btnTo9.UseVisualStyleBackColor = True
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblcount.Location = New System.Drawing.Point(996, 36)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(45, 13)
        Me.lblcount.TabIndex = 58
        Me.lblcount.Text = "จำนวน"
        '
        'txtFlot
        '
        Me.txtFlot.Location = New System.Drawing.Point(253, 26)
        Me.txtFlot.Name = "txtFlot"
        Me.txtFlot.Size = New System.Drawing.Size(100, 20)
        Me.txtFlot.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ค้นหา LOT"
        '
        'CBLot5
        '
        Me.CBLot5.AutoSize = True
        Me.CBLot5.Checked = True
        Me.CBLot5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBLot5.Location = New System.Drawing.Point(368, 28)
        Me.CBLot5.Name = "CBLot5"
        Me.CBLot5.Size = New System.Drawing.Size(47, 17)
        Me.CBLot5.TabIndex = 61
        Me.CBLot5.Text = "Lot5"
        Me.CBLot5.UseVisualStyleBackColor = True
        '
        'cbLot7
        '
        Me.cbLot7.AutoSize = True
        Me.cbLot7.Checked = True
        Me.cbLot7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLot7.Location = New System.Drawing.Point(421, 28)
        Me.cbLot7.Name = "cbLot7"
        Me.cbLot7.Size = New System.Drawing.Size(47, 17)
        Me.cbLot7.TabIndex = 62
        Me.cbLot7.Text = "Lot7"
        Me.cbLot7.UseVisualStyleBackColor = True
        '
        'cbLot9
        '
        Me.cbLot9.AutoSize = True
        Me.cbLot9.Checked = True
        Me.cbLot9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLot9.Location = New System.Drawing.Point(474, 28)
        Me.cbLot9.Name = "cbLot9"
        Me.cbLot9.Size = New System.Drawing.Size(47, 17)
        Me.cbLot9.TabIndex = 63
        Me.cbLot9.Text = "Lot9"
        Me.cbLot9.UseVisualStyleBackColor = True
        '
        'Findbtn
        '
        Me.Findbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Findbtn.Location = New System.Drawing.Point(527, 12)
        Me.Findbtn.Name = "Findbtn"
        Me.Findbtn.Size = New System.Drawing.Size(75, 35)
        Me.Findbtn.TabIndex = 64
        Me.Findbtn.Text = "ค้นหา"
        Me.Findbtn.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(608, 12)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 35)
        Me.btnExcel.TabIndex = 65
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'CloseLOTfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 566)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Findbtn)
        Me.Controls.Add(Me.cbLot9)
        Me.Controls.Add(Me.cbLot7)
        Me.Controls.Add(Me.CBLot5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFlot)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.btnTo9)
        Me.Controls.Add(Me.btnto7)
        Me.Controls.Add(Me.btnTo5)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInlot)
        Me.Name = "CloseLOTfrm"
        Me.Text = "CloseLOTfrm"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtInlot As TextBox
    Friend WithEvents DBCB As ComboBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btnTo5 As Button
    Friend WithEvents btnto7 As Button
    Friend WithEvents btnTo9 As Button
    Friend WithEvents lblcount As Label
    Friend WithEvents txtFlot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBLot5 As CheckBox
    Friend WithEvents cbLot7 As CheckBox
    Friend WithEvents cbLot9 As CheckBox
    Friend WithEvents Findbtn As Button
    Friend WithEvents btnExcel As Button
End Class
