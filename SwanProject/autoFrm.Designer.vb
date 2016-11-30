<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autoFrm
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
        Me.txtNowTime = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastUpdate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBackup = New System.Windows.Forms.TextBox()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNowTime
        '
        Me.txtNowTime.BackColor = System.Drawing.Color.Black
        Me.txtNowTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNowTime.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtNowTime.Location = New System.Drawing.Point(200, 29)
        Me.txtNowTime.Name = "txtNowTime"
        Me.txtNowTime.Size = New System.Drawing.Size(216, 35)
        Me.txtNowTime.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Update"
        '
        'txtLastUpdate
        '
        Me.txtLastUpdate.BackColor = System.Drawing.Color.Black
        Me.txtLastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastUpdate.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtLastUpdate.Location = New System.Drawing.Point(200, 105)
        Me.txtLastUpdate.Name = "txtLastUpdate"
        Me.txtLastUpdate.Size = New System.Drawing.Size(274, 29)
        Me.txtLastUpdate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Backup"
        '
        'txtBackup
        '
        Me.txtBackup.BackColor = System.Drawing.Color.Black
        Me.txtBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBackup.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtBackup.Location = New System.Drawing.Point(200, 140)
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.Size = New System.Drawing.Size(274, 29)
        Me.txtBackup.TabIndex = 4
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblErr.ForeColor = System.Drawing.Color.Red
        Me.lblErr.Location = New System.Drawing.Point(12, 266)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(0, 18)
        Me.lblErr.TabIndex = 6
        '
        'autoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 293)
        Me.Controls.Add(Me.lblErr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBackup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLastUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNowTime)
        Me.Name = "autoFrm"
        Me.Text = "autoFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNowTime As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastUpdate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBackup As TextBox
    Friend WithEvents lblErr As Label
End Class
