<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockFrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RDDB = New System.Windows.Forms.ComboBox()
        Me.TXTPRDT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFromDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtToDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.DDorder = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkOldStock = New System.Windows.Forms.CheckBox()
        Me.ExcelBtn = New System.Windows.Forms.Button()
        Me.lblPRDT = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RDDB
        '
        Me.RDDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RDDB.FormattingEnabled = True
        Me.RDDB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.RDDB.Location = New System.Drawing.Point(13, 13)
        Me.RDDB.Margin = New System.Windows.Forms.Padding(4)
        Me.RDDB.Name = "RDDB"
        Me.RDDB.Size = New System.Drawing.Size(87, 38)
        Me.RDDB.TabIndex = 2
        Me.RDDB.Text = "BOI"
        '
        'TXTPRDT
        '
        Me.TXTPRDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TXTPRDT.Location = New System.Drawing.Point(206, 12)
        Me.TXTPRDT.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTPRDT.MaxLength = 11
        Me.TXTPRDT.Name = "TXTPRDT"
        Me.TXTPRDT.Size = New System.Drawing.Size(271, 37)
        Me.TXTPRDT.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PRDT:"
        '
        'txtFromDate
        '
        Me.txtFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFromDate.Location = New System.Drawing.Point(634, 12)
        Me.txtFromDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFromDate.MaxLength = 8
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(153, 37)
        Me.txtFromDate.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "From Date:"
        '
        'txtToDate
        '
        Me.txtToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtToDate.Location = New System.Drawing.Point(853, 13)
        Me.txtToDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtToDate.MaxLength = 8
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Size = New System.Drawing.Size(153, 37)
        Me.txtToDate.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(791, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To:"
        '
        'DGV1
        '
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1.Location = New System.Drawing.Point(12, 102)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(1103, 380)
        Me.DGV1.TabIndex = 11
        '
        'cmdShow
        '
        Me.cmdShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdShow.Location = New System.Drawing.Point(1014, 10)
        Me.cmdShow.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(100, 41)
        Me.cmdShow.TabIndex = 30
        Me.cmdShow.Text = "Show"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'DDorder
        '
        Me.DDorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DDorder.FormattingEnabled = True
        Me.DDorder.Items.AddRange(New Object() {"น้อยไปมาก", "มากไปน้อย"})
        Me.DDorder.Location = New System.Drawing.Point(136, 57)
        Me.DDorder.Margin = New System.Windows.Forms.Padding(4)
        Me.DDorder.Name = "DDorder"
        Me.DDorder.Size = New System.Drawing.Size(157, 38)
        Me.DDorder.TabIndex = 31
        Me.DDorder.Text = "น้อยไปมาก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 31)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "เรียงลำดับ"
        '
        'chkOldStock
        '
        Me.chkOldStock.AutoSize = True
        Me.chkOldStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOldStock.Location = New System.Drawing.Point(311, 64)
        Me.chkOldStock.Name = "chkOldStock"
        Me.chkOldStock.Size = New System.Drawing.Size(140, 24)
        Me.chkOldStock.TabIndex = 33
        Me.chkOldStock.Text = "แสดง Stockเก่า"
        Me.chkOldStock.UseVisualStyleBackColor = True
        '
        'ExcelBtn
        '
        Me.ExcelBtn.Location = New System.Drawing.Point(468, 62)
        Me.ExcelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExcelBtn.Name = "ExcelBtn"
        Me.ExcelBtn.Size = New System.Drawing.Size(100, 28)
        Me.ExcelBtn.TabIndex = 34
        Me.ExcelBtn.Text = "EXCEL"
        Me.ExcelBtn.UseVisualStyleBackColor = True
        '
        'lblPRDT
        '
        Me.lblPRDT.AutoSize = True
        Me.lblPRDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPRDT.Location = New System.Drawing.Point(591, 60)
        Me.lblPRDT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPRDT.Name = "lblPRDT"
        Me.lblPRDT.Size = New System.Drawing.Size(0, 25)
        Me.lblPRDT.TabIndex = 35
        '
        'StockFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1127, 494)
        Me.Controls.Add(Me.lblPRDT)
        Me.Controls.Add(Me.ExcelBtn)
        Me.Controls.Add(Me.chkOldStock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DDorder)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.txtToDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFromDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTPRDT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RDDB)
        Me.Name = "StockFrm"
        Me.Text = "STOCK"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RDDB As ComboBox
    Friend WithEvents TXTPRDT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFromDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtToDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents cmdShow As Button
    Friend WithEvents DDorder As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkOldStock As CheckBox
    Friend WithEvents ExcelBtn As Button
    Friend WithEvents lblPRDT As Label
End Class
