﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFrm
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
        Me.RPTview = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'RPTview
        '
        Me.RPTview.ActiveViewIndex = -1
        Me.RPTview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RPTview.Cursor = System.Windows.Forms.Cursors.Default
        Me.RPTview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPTview.Location = New System.Drawing.Point(0, 0)
        Me.RPTview.Name = "RPTview"
        Me.RPTview.Size = New System.Drawing.Size(978, 655)
        Me.RPTview.TabIndex = 0
        Me.RPTview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 655)
        Me.Controls.Add(Me.RPTview)
        Me.Name = "ReportFrm"
        Me.Text = "ReportFrm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTview As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
