<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockLOTfrm
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
        Me.txtTodate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFromDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.ShowBtn = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "รายการLOT"
        '
        'txtInlot
        '
        Me.txtInlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInlot.Location = New System.Drawing.Point(28, 63)
        Me.txtInlot.Multiline = True
        Me.txtInlot.Name = "txtInlot"
        Me.txtInlot.Size = New System.Drawing.Size(72, 498)
        Me.txtInlot.TabIndex = 56
        '
        'DBCB
        '
        Me.DBCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(28, 12)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 55
        Me.DBCB.Text = "BOI"
        '
        'txtTodate
        '
        Me.txtTodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTodate.Location = New System.Drawing.Point(282, 11)
        Me.txtTodate.MaxLength = 8
        Me.txtTodate.Name = "txtTodate"
        Me.txtTodate.Size = New System.Drawing.Size(100, 22)
        Me.txtTodate.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "To"
        '
        'txtFromDate
        '
        Me.txtFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFromDate.Location = New System.Drawing.Point(144, 11)
        Me.txtFromDate.MaxLength = 8
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(100, 22)
        Me.txtFromDate.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "From"
        '
        'btnLock
        '
        Me.btnLock.Location = New System.Drawing.Point(405, 10)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(75, 23)
        Me.btnLock.TabIndex = 58
        Me.btnLock.Text = "Lock"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'btnUnlock
        '
        Me.btnUnlock.Location = New System.Drawing.Point(486, 11)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(75, 23)
        Me.btnUnlock.TabIndex = 59
        Me.btnUnlock.Text = "Unlock"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(104, 47)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.Size = New System.Drawing.Size(808, 514)
        Me.DGV1.TabIndex = 60
        '
        'ShowBtn
        '
        Me.ShowBtn.Location = New System.Drawing.Point(567, 11)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(75, 23)
        Me.ShowBtn.TabIndex = 61
        Me.ShowBtn.Text = "Show"
        Me.ShowBtn.UseVisualStyleBackColor = True
        '
        'LockLOTfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 573)
        Me.Controls.Add(Me.ShowBtn)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.btnUnlock)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInlot)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.txtTodate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFromDate)
        Me.Controls.Add(Me.Label3)
        Me.Name = "LockLOTfrm"
        Me.Text = "LOT LOCK"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtInlot As TextBox
    Friend WithEvents DBCB As ComboBox
    Friend WithEvents txtTodate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFromDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLock As Button
    Friend WithEvents btnUnlock As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents ShowBtn As Button
End Class
