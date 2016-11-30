<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOMlist
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
        Me.TV1 = New System.Windows.Forms.TreeView()
        Me.txtPRDT = New System.Windows.Forms.TextBox()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TV1
        '
        Me.TV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TV1.Location = New System.Drawing.Point(149, 12)
        Me.TV1.Name = "TV1"
        Me.TV1.Size = New System.Drawing.Size(845, 554)
        Me.TV1.TabIndex = 1
        '
        'txtPRDT
        '
        Me.txtPRDT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPRDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPRDT.Location = New System.Drawing.Point(12, 125)
        Me.txtPRDT.Multiline = True
        Me.txtPRDT.Name = "txtPRDT"
        Me.txtPRDT.Size = New System.Drawing.Size(131, 441)
        Me.txtPRDT.TabIndex = 2
        '
        'DBCB
        '
        Me.DBCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(12, 12)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(66, 33)
        Me.DBCB.TabIndex = 3
        Me.DBCB.Text = "BOI"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.Location = New System.Drawing.Point(19, 86)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(59, 33)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(78, 54)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(65, 26)
        Me.txtQTY.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "QTY : "
        '
        'btnExcel
        '
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(84, 86)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(59, 33)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "EXCEL"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'BOMlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 578)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.txtPRDT)
        Me.Controls.Add(Me.TV1)
        Me.Name = "BOMlist"
        Me.Text = "BOMlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TV1 As TreeView
    Friend WithEvents txtPRDT As TextBox
    Friend WithEvents DBCB As ComboBox
    Friend WithEvents btnShow As Button
    Friend WithEvents txtQTY As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExcel As Button
End Class
