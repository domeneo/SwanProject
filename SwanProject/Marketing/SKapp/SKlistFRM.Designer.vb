<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SKlistFRM
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TC = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVSK = New System.Windows.Forms.DataGridView()
        Me.TPnotApp = New System.Windows.Forms.TabPage()
        Me.DGVNotApp = New System.Windows.Forms.DataGridView()
        Me.TPNotprint = New System.Windows.Forms.TabPage()
        Me.DGVNotPrint = New System.Windows.Forms.DataGridView()
        Me.TC.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVSK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPnotApp.SuspendLayout()
        CType(Me.DGVNotApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPNotprint.SuspendLayout()
        CType(Me.DGVNotPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'TC
        '
        Me.TC.Controls.Add(Me.TabPage1)
        Me.TC.Controls.Add(Me.TPnotApp)
        Me.TC.Controls.Add(Me.TPNotprint)
        Me.TC.Location = New System.Drawing.Point(12, 24)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(1174, 538)
        Me.TC.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVSK)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1166, 512)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ALL SK"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVSK
        '
        Me.DGVSK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSK.Location = New System.Drawing.Point(6, 5)
        Me.DGVSK.Name = "DGVSK"
        Me.DGVSK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSK.Size = New System.Drawing.Size(1155, 503)
        Me.DGVSK.TabIndex = 2
        '
        'TPnotApp
        '
        Me.TPnotApp.Controls.Add(Me.DGVNotApp)
        Me.TPnotApp.Location = New System.Drawing.Point(4, 22)
        Me.TPnotApp.Name = "TPnotApp"
        Me.TPnotApp.Padding = New System.Windows.Forms.Padding(3)
        Me.TPnotApp.Size = New System.Drawing.Size(1166, 512)
        Me.TPnotApp.TabIndex = 1
        Me.TPnotApp.Text = "Not Approve"
        Me.TPnotApp.UseVisualStyleBackColor = True
        '
        'DGVNotApp
        '
        Me.DGVNotApp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVNotApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVNotApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNotApp.Location = New System.Drawing.Point(6, 5)
        Me.DGVNotApp.Name = "DGVNotApp"
        Me.DGVNotApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVNotApp.Size = New System.Drawing.Size(1155, 503)
        Me.DGVNotApp.TabIndex = 3
        '
        'TPNotprint
        '
        Me.TPNotprint.Controls.Add(Me.DGVNotPrint)
        Me.TPNotprint.Location = New System.Drawing.Point(4, 22)
        Me.TPNotprint.Name = "TPNotprint"
        Me.TPNotprint.Padding = New System.Windows.Forms.Padding(3)
        Me.TPNotprint.Size = New System.Drawing.Size(1166, 512)
        Me.TPNotprint.TabIndex = 2
        Me.TPNotprint.Text = "Not Print"
        Me.TPNotprint.UseVisualStyleBackColor = True
        '
        'DGVNotPrint
        '
        Me.DGVNotPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVNotPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVNotPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNotPrint.Location = New System.Drawing.Point(6, 5)
        Me.DGVNotPrint.Name = "DGVNotPrint"
        Me.DGVNotPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVNotPrint.Size = New System.Drawing.Size(1155, 503)
        Me.DGVNotPrint.TabIndex = 3
        '
        'SKlistFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 563)
        Me.Controls.Add(Me.TC)
        Me.Name = "SKlistFRM"
        Me.Text = "SKlistFRM"
        Me.TC.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGVSK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPnotApp.ResumeLayout(False)
        CType(Me.DGVNotApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPNotprint.ResumeLayout(False)
        CType(Me.DGVNotPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TC As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGVSK As DataGridView
    Friend WithEvents TPnotApp As TabPage
    Friend WithEvents TPNotprint As TabPage
    Friend WithEvents DGVNotApp As DataGridView
    Friend WithEvents DGVNotPrint As DataGridView
End Class
