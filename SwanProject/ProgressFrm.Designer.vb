<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressFrm
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
        Me.PGB = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'PGB
        '
        Me.PGB.Location = New System.Drawing.Point(2, 2)
        Me.PGB.Name = "PGB"
        Me.PGB.Size = New System.Drawing.Size(347, 29)
        Me.PGB.TabIndex = 0
        '
        'ProgressFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 34)
        Me.Controls.Add(Me.PGB)
        Me.MaximizeBox = False
        Me.Name = "ProgressFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progress"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PGB As System.Windows.Forms.ProgressBar
End Class
