<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QAlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MBlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(843, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StoreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QAToolStripMenuItem, Me.MAToolStripMenuItem, Me.MBToolStripMenuItem, Me.QAlistToolStripMenuItem, Me.MAlistToolStripMenuItem, Me.MBlistToolStripMenuItem})
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.StoreToolStripMenuItem.Text = "Store"
        '
        'QAToolStripMenuItem
        '
        Me.QAToolStripMenuItem.Name = "QAToolStripMenuItem"
        Me.QAToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.QAToolStripMenuItem.Text = "QA"
        '
        'MAToolStripMenuItem
        '
        Me.MAToolStripMenuItem.Name = "MAToolStripMenuItem"
        Me.MAToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.MAToolStripMenuItem.Text = "MA"
        '
        'MBToolStripMenuItem
        '
        Me.MBToolStripMenuItem.Name = "MBToolStripMenuItem"
        Me.MBToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.MBToolStripMenuItem.Text = "MB"
        '
        'QAlistToolStripMenuItem
        '
        Me.QAlistToolStripMenuItem.Name = "QAlistToolStripMenuItem"
        Me.QAlistToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.QAlistToolStripMenuItem.Text = "QAlist"
        '
        'MAlistToolStripMenuItem
        '
        Me.MAlistToolStripMenuItem.Name = "MAlistToolStripMenuItem"
        Me.MAlistToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.MAlistToolStripMenuItem.Text = "MAlist"
        '
        'MBlistToolStripMenuItem
        '
        Me.MBlistToolStripMenuItem.Name = "MBlistToolStripMenuItem"
        Me.MBlistToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.MBlistToolStripMenuItem.Text = "MBlist"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 558)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MDI"
        Me.Text = "MDI"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QAlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MAlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MBlistToolStripMenuItem As ToolStripMenuItem
End Class
