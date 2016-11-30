<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WIPNOTE_EXCEL
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
        Me.WSCB = New System.Windows.Forms.ComboBox()
        Me.Uploadbtn = New System.Windows.Forms.Button()
        Me.txtUpload = New System.Windows.Forms.TextBox()
        Me.BrownsBtn = New System.Windows.Forms.Button()
        Me.OpenDLG1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtLOTcol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrdtCol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNotecol = New System.Windows.Forms.TextBox()
        Me.CBDB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(560, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Sheet:"
        '
        'WSCB
        '
        Me.WSCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WSCB.FormattingEnabled = True
        Me.WSCB.Location = New System.Drawing.Point(625, 48)
        Me.WSCB.Margin = New System.Windows.Forms.Padding(4)
        Me.WSCB.Name = "WSCB"
        Me.WSCB.Size = New System.Drawing.Size(275, 28)
        Me.WSCB.TabIndex = 33
        '
        'Uploadbtn
        '
        Me.Uploadbtn.Location = New System.Drawing.Point(17, 160)
        Me.Uploadbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Uploadbtn.Name = "Uploadbtn"
        Me.Uploadbtn.Size = New System.Drawing.Size(100, 28)
        Me.Uploadbtn.TabIndex = 32
        Me.Uploadbtn.Text = "Upload"
        Me.Uploadbtn.UseVisualStyleBackColor = True
        '
        'txtUpload
        '
        Me.txtUpload.Location = New System.Drawing.Point(13, 52)
        Me.txtUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUpload.Name = "txtUpload"
        Me.txtUpload.Size = New System.Drawing.Size(413, 22)
        Me.txtUpload.TabIndex = 31
        '
        'BrownsBtn
        '
        Me.BrownsBtn.Location = New System.Drawing.Point(435, 48)
        Me.BrownsBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.BrownsBtn.Name = "BrownsBtn"
        Me.BrownsBtn.Size = New System.Drawing.Size(100, 28)
        Me.BrownsBtn.TabIndex = 30
        Me.BrownsBtn.Text = "Browse"
        Me.BrownsBtn.UseVisualStyleBackColor = True
        '
        'OpenDLG1
        '
        '
        'txtLOTcol
        '
        Me.txtLOTcol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLOTcol.Location = New System.Drawing.Point(134, 104)
        Me.txtLOTcol.Name = "txtLOTcol"
        Me.txtLOTcol.Size = New System.Drawing.Size(33, 27)
        Me.txtLOTcol.TabIndex = 35
        Me.txtLOTcol.Text = "B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Lot Column:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Prdt Column:"
        '
        'txtPrdtCol
        '
        Me.txtPrdtCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPrdtCol.Location = New System.Drawing.Point(312, 104)
        Me.txtPrdtCol.Name = "txtPrdtCol"
        Me.txtPrdtCol.Size = New System.Drawing.Size(33, 27)
        Me.txtPrdtCol.TabIndex = 37
        Me.txtPrdtCol.Text = "I"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Note Column:"
        '
        'txtNotecol
        '
        Me.txtNotecol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNotecol.Location = New System.Drawing.Point(502, 103)
        Me.txtNotecol.Name = "txtNotecol"
        Me.txtNotecol.Size = New System.Drawing.Size(33, 27)
        Me.txtNotecol.TabIndex = 39
        Me.txtNotecol.Text = "U"
        '
        'CBDB
        '
        Me.CBDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CBDB.FormattingEnabled = True
        Me.CBDB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.CBDB.Location = New System.Drawing.Point(564, 102)
        Me.CBDB.Name = "CBDB"
        Me.CBDB.Size = New System.Drawing.Size(73, 28)
        Me.CBDB.TabIndex = 41
        Me.CBDB.Text = "BOI"
        '
        'WIPNOTE_EXCEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 253)
        Me.Controls.Add(Me.CBDB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNotecol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrdtCol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLOTcol)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WSCB)
        Me.Controls.Add(Me.Uploadbtn)
        Me.Controls.Add(Me.txtUpload)
        Me.Controls.Add(Me.BrownsBtn)
        Me.Name = "WIPNOTE_EXCEL"
        Me.Text = "Add note WIP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents WSCB As ComboBox
    Friend WithEvents Uploadbtn As Button
    Friend WithEvents txtUpload As TextBox
    Friend WithEvents BrownsBtn As Button
    Friend WithEvents OpenDLG1 As OpenFileDialog
    Friend WithEvents txtLOTcol As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrdtCol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNotecol As TextBox
    Friend WithEvents CBDB As ComboBox
End Class
