<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MASlipfrm
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInlot = New System.Windows.Forms.TextBox()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(90, 42)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(722, 530)
        Me.DGV1.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(116, 13)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'DBCB
        '
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(12, 13)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 2
        Me.DBCB.Text = "BOI"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(197, 13)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "รายการLOT"
        '
        'txtInlot
        '
        Me.txtInlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInlot.Location = New System.Drawing.Point(12, 56)
        Me.txtInlot.Multiline = True
        Me.txtInlot.Name = "txtInlot"
        Me.txtInlot.Size = New System.Drawing.Size(72, 516)
        Me.txtInlot.TabIndex = 51
        '
        'MASlipfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 584)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInlot)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DGV1)
        Me.Name = "MASlipfrm"
        Me.Text = "MASlipfrm"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents DBCB As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInlot As TextBox
End Class
