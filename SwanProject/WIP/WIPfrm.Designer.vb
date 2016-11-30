<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WIPfrm
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
        Me.txtFromDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTodate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GV1 = New System.Windows.Forms.DataGridView()
        Me.DBCB = New System.Windows.Forms.ComboBox()
        Me.GBLotClose = New System.Windows.Forms.GroupBox()
        Me.ChkLot9 = New System.Windows.Forms.CheckBox()
        Me.chkLot7 = New System.Windows.Forms.CheckBox()
        Me.ChkLOT5 = New System.Windows.Forms.CheckBox()
        Me.GBFilter = New System.Windows.Forms.GroupBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.wheretxt = New System.Windows.Forms.TextBox()
        Me.ColCB = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.BtnNoFilter = New System.Windows.Forms.Button()
        Me.CBShow = New System.Windows.Forms.ComboBox()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInlot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStockDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLotClose.SuspendLayout()
        Me.GBFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFromDate
        '
        Me.txtFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFromDate.Location = New System.Drawing.Point(128, 26)
        Me.txtFromDate.MaxLength = 8
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(100, 22)
        Me.txtFromDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "From"
        '
        'txtTodate
        '
        Me.txtTodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTodate.Location = New System.Drawing.Point(266, 26)
        Me.txtTodate.MaxLength = 8
        Me.txtTodate.Name = "txtTodate"
        Me.txtTodate.Size = New System.Drawing.Size(100, 22)
        Me.txtTodate.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "To"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShow.Location = New System.Drawing.Point(695, 18)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 35)
        Me.btnShow.TabIndex = 14
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'GV1
        '
        Me.GV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GV1.Location = New System.Drawing.Point(89, 123)
        Me.GV1.Name = "GV1"
        Me.GV1.ReadOnly = True
        Me.GV1.Size = New System.Drawing.Size(947, 291)
        Me.GV1.TabIndex = 31
        '
        'DBCB
        '
        Me.DBCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DBCB.FormattingEnabled = True
        Me.DBCB.Items.AddRange(New Object() {"BOI", "TAX"})
        Me.DBCB.Location = New System.Drawing.Point(12, 27)
        Me.DBCB.Name = "DBCB"
        Me.DBCB.Size = New System.Drawing.Size(59, 21)
        Me.DBCB.TabIndex = 36
        Me.DBCB.Text = "BOI"
        '
        'GBLotClose
        '
        Me.GBLotClose.Controls.Add(Me.ChkLot9)
        Me.GBLotClose.Controls.Add(Me.chkLot7)
        Me.GBLotClose.Controls.Add(Me.ChkLOT5)
        Me.GBLotClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GBLotClose.Location = New System.Drawing.Point(394, 12)
        Me.GBLotClose.Name = "GBLotClose"
        Me.GBLotClose.Size = New System.Drawing.Size(187, 41)
        Me.GBLotClose.TabIndex = 40
        Me.GBLotClose.TabStop = False
        Me.GBLotClose.Text = "LOT CLOSE"
        '
        'ChkLot9
        '
        Me.ChkLot9.AutoSize = True
        Me.ChkLot9.Checked = True
        Me.ChkLot9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLot9.Location = New System.Drawing.Point(121, 19)
        Me.ChkLot9.Name = "ChkLot9"
        Me.ChkLot9.Size = New System.Drawing.Size(57, 17)
        Me.ChkLot9.TabIndex = 42
        Me.ChkLot9.Text = "LOT9"
        Me.ChkLot9.UseVisualStyleBackColor = True
        '
        'chkLot7
        '
        Me.chkLot7.AutoSize = True
        Me.chkLot7.Checked = True
        Me.chkLot7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLot7.Location = New System.Drawing.Point(65, 19)
        Me.chkLot7.Name = "chkLot7"
        Me.chkLot7.Size = New System.Drawing.Size(57, 17)
        Me.chkLot7.TabIndex = 41
        Me.chkLot7.Text = "LOT7"
        Me.chkLot7.UseVisualStyleBackColor = True
        '
        'ChkLOT5
        '
        Me.ChkLOT5.AutoSize = True
        Me.ChkLOT5.Checked = True
        Me.ChkLOT5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLOT5.Location = New System.Drawing.Point(6, 19)
        Me.ChkLOT5.Name = "ChkLOT5"
        Me.ChkLOT5.Size = New System.Drawing.Size(57, 17)
        Me.ChkLOT5.TabIndex = 40
        Me.ChkLOT5.Text = "LOT5"
        Me.ChkLOT5.UseVisualStyleBackColor = True
        '
        'GBFilter
        '
        Me.GBFilter.Controls.Add(Me.btnDel)
        Me.GBFilter.Controls.Add(Me.btnAdd)
        Me.GBFilter.Controls.Add(Me.wheretxt)
        Me.GBFilter.Controls.Add(Me.ColCB)
        Me.GBFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GBFilter.Location = New System.Drawing.Point(77, 76)
        Me.GBFilter.Name = "GBFilter"
        Me.GBFilter.Size = New System.Drawing.Size(269, 41)
        Me.GBFilter.TabIndex = 41
        Me.GBFilter.TabStop = False
        Me.GBFilter.Text = "Filter"
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDel.Location = New System.Drawing.Point(230, 13)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(24, 22)
        Me.btnDel.TabIndex = 41
        Me.btnDel.Text = "-"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(200, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(24, 22)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'wheretxt
        '
        Me.wheretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.wheretxt.Location = New System.Drawing.Point(94, 14)
        Me.wheretxt.MaxLength = 8
        Me.wheretxt.Name = "wheretxt"
        Me.wheretxt.Size = New System.Drawing.Size(100, 22)
        Me.wheretxt.TabIndex = 38
        '
        'ColCB
        '
        Me.ColCB.FormattingEnabled = True
        Me.ColCB.Items.AddRange(New Object() {"MC_LOT", "MC_PRDT", "MC_CLOSE", "S_PRDT", "MC_DATE", "Diff"})
        Me.ColCB.Location = New System.Drawing.Point(6, 14)
        Me.ColCB.Name = "ColCB"
        Me.ColCB.Size = New System.Drawing.Size(82, 21)
        Me.ColCB.TabIndex = 37
        Me.ColCB.Text = "MC_LOT"
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(12, 54)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(59, 28)
        Me.btnFilter.TabIndex = 42
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(776, 18)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 35)
        Me.btnExcel.TabIndex = 43
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCount.Location = New System.Drawing.Point(857, 32)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(91, 13)
        Me.lblCount.TabIndex = 44
        Me.lblCount.Text = "จำนวนทั้งหมด :"
        '
        'BtnNoFilter
        '
        Me.BtnNoFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnNoFilter.Location = New System.Drawing.Point(12, 88)
        Me.BtnNoFilter.Name = "BtnNoFilter"
        Me.BtnNoFilter.Size = New System.Drawing.Size(59, 29)
        Me.BtnNoFilter.TabIndex = 45
        Me.BtnNoFilter.Text = "NoFilter"
        Me.BtnNoFilter.UseVisualStyleBackColor = True
        '
        'CBShow
        '
        Me.CBShow.FormattingEnabled = True
        Me.CBShow.Items.AddRange(New Object() {"ALL", "G&CL"})
        Me.CBShow.Location = New System.Drawing.Point(77, 54)
        Me.CBShow.Name = "CBShow"
        Me.CBShow.Size = New System.Drawing.Size(66, 21)
        Me.CBShow.TabIndex = 46
        Me.CBShow.Text = "ALL"
        '
        'txtdept
        '
        Me.txtdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtdept.Location = New System.Drawing.Point(629, 26)
        Me.txtdept.MaxLength = 8
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(44, 22)
        Me.txtdept.TabIndex = 47
        Me.txtdept.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(586, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Dept"
        '
        'txtInlot
        '
        Me.txtInlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInlot.Location = New System.Drawing.Point(11, 139)
        Me.txtInlot.Multiline = True
        Me.txtInlot.Name = "txtInlot"
        Me.txtInlot.Size = New System.Drawing.Size(72, 275)
        Me.txtInlot.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "รายการLOT"
        '
        'txtStockDate
        '
        Me.txtStockDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStockDate.Location = New System.Drawing.Point(459, 60)
        Me.txtStockDate.MaxLength = 8
        Me.txtStockDate.Name = "txtStockDate"
        Me.txtStockDate.Size = New System.Drawing.Size(100, 22)
        Me.txtStockDate.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "StockDate"
        '
        'WIPfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 426)
        Me.Controls.Add(Me.txtStockDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInlot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdept)
        Me.Controls.Add(Me.CBShow)
        Me.Controls.Add(Me.BtnNoFilter)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.GBFilter)
        Me.Controls.Add(Me.GBLotClose)
        Me.Controls.Add(Me.DBCB)
        Me.Controls.Add(Me.GV1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtTodate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFromDate)
        Me.Controls.Add(Me.Label3)
        Me.Name = "WIPfrm"
        Me.Text = "WIPfrm"
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLotClose.ResumeLayout(False)
        Me.GBLotClose.PerformLayout()
        Me.GBFilter.ResumeLayout(False)
        Me.GBFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFromDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTodate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GV1 As System.Windows.Forms.DataGridView
    Friend WithEvents DBCB As System.Windows.Forms.ComboBox
    Friend WithEvents GBLotClose As System.Windows.Forms.GroupBox
    Friend WithEvents ChkLot9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkLot7 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLOT5 As System.Windows.Forms.CheckBox
    Friend WithEvents GBFilter As System.Windows.Forms.GroupBox
    Friend WithEvents ColCB As System.Windows.Forms.ComboBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents wheretxt As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents BtnNoFilter As System.Windows.Forms.Button
    Friend WithEvents CBShow As System.Windows.Forms.ComboBox
    Friend WithEvents txtdept As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInlot As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStockDate As TextBox
    Friend WithEvents Label6 As Label
End Class
