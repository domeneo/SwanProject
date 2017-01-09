Imports System.Windows.Forms
Imports System.Net

Public Class MDIParent1
    Dim dataACC As New dataACCcls
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer









    Private Sub MAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAlistMnu.Click

        Dim frm As New MAListfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MAinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAinMnu.Click
        Dim frm As New MAfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QAlistmnu_Click(sender As Object, e As EventArgs) Handles QAlistmnu.Click
        Dim frm As New QAListfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub QAinMnu_Click(sender As Object, e As EventArgs) Handles QAinMnu.Click
        Dim frm As New QAfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MBListMnu_Click(sender As Object, e As EventArgs) Handles MBListMnu.Click
        Dim frm As New MBListfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MBinMnu_Click(sender As Object, e As EventArgs) Handles MBinMnu.Click
        Dim frm As New MBfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PRDTlistmnu_Click(sender As Object, e As EventArgs) Handles PRDTlistmnu.Click
        Dim frm As New PRDTListfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub WIPmnu_Click(sender As Object, e As EventArgs) Handles WIPmnu.Click
        Dim frm As New WIPfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PRDTinputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRDTinputToolStripMenuItem.Click
        Dim frm As New PRDTfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LOTlistMNU_Click(sender As Object, e As EventArgs) Handles LOTlistMNU.Click
        Dim frm As New LOTListfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LOTinputMNU_Click(sender As Object, e As EventArgs) Handles LOTinputMNU.Click
        Dim frm As New LOTInputfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim ipaddress As String = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(Function(a As IPAddress) Not a.IsIPv6LinkLocal AndAlso Not a.IsIPv6Multicast AndAlso Not a.IsIPv6SiteLocal).First().ToString()


            ' Dim ipaddress As String = Dns.GetHostEntry(Dns.GetHostName).AddressList(2).ToString
            lblIP.Text = ipaddress

        Catch ex As Exception

        End Try
        If lblGroup.Text.ToUpper = "STORE" Or lblGroup.Text.ToUpper = "ADMIN" Then
            STOREmnu.Visible = True
        End If
        If lblGroup.Text.ToUpper.Contains("PRODUCTION") Or lblGroup.Text.ToUpper = "STORE" Or lblGroup.Text.ToUpper = "ADMIN" Then
            AdminMnu.Visible = True
        End If
        If lblGroup.Text.ToUpper = "PRODUCTION" Or lblGroup.Text.ToUpper = "ADMIN" Then
            LOTinputMNU.Visible = True
        End If

        If lblGroup.Text.ToUpper = "ACCOUNT" Or lblGroup.Text.ToUpper = "ADMIN" Then
            AccountBtn.Visible = True
        End If
    End Sub

    Private Sub PatrolMnu_Click(sender As Object, e As EventArgs) Handles PatrolMnu.Click
        Dim frm As New Patrolfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EDITSTOCKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITSTOCKToolStripMenuItem.Click
        Dim frm As New editstockfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        LoginFrm.Show()
        Me.Close()
    End Sub

    Private Sub WIPAddNOTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIPAddNOTEToolStripMenuItem.Click
        Dim frm As New WIPNOTE_EXCEL
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TSstock_Click(sender As Object, e As EventArgs) Handles TSstock.Click
        Dim frm As New StockFrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub



    Private Sub QAPrintLABELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QAPrintLABELToolStripMenuItem.Click
        Dim frm As New QAPrintLabelfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintQAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintQAToolStripMenuItem.Click
        Dim frm As New PrintQAfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SETSLIPNOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETSLIPNOToolStripMenuItem.Click
        Dim frm As New SlipNOfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LOTLOCKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOTLOCKToolStripMenuItem.Click
        If lblGroup.Text.ToUpper = "PRODUCTIONHEAD" Or lblGroup.Text.ToUpper = "ADMIN" Or lblGroup.Text.ToUpper = "Production" Then
            LOTinputMNU.Visible = True

            Dim frm As New LockLOTfrm
            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("คุณไม่มีสิทธิ์ใช้โปรแกรมนี้")
        End If
    End Sub

    Private Sub CloseLOTBtn_Click(sender As Object, e As EventArgs) Handles CloseLOTBtn.Click
        Dim frm As New CloseLOTfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrintMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintMAToolStripMenuItem.Click
        Dim frm As New MASlipfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AutosystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutosystemToolStripMenuItem.Click
        Dim frm As New autoFrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BOMTreeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOMTreeToolStripMenuItem.Click
        Dim frm As New BOMlist
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SupplyUseBTN_Click(sender As Object, e As EventArgs) Handles SupplyUseBTN.Click
        Dim frm As New SupplyUsefrm
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub PObtn_Click(sender As Object, e As EventArgs) Handles PObtn.Click
        Dim frm As New POfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub UPDATELOTQTYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATELOTQTYToolStripMenuItem.Click
        Dim sw As Stopwatch = Stopwatch.StartNew()


        If UpdateLOTQTY() Then
            sw.Stop()
            MsgBox("UPDATE LOTQTY SUCCESS time : " & sw.ElapsedMilliseconds / 1000 & " Sec")
        Else
            sw.Stop()
        End If
    End Sub
    Private Sub UPDATEMAFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEMAFILEToolStripMenuItem.Click



        Dim sw As Stopwatch = Stopwatch.StartNew()


        If UpdateMAFile() Then
            sw.Stop()
            MsgBox("UPDATE MAFILE SUCCESS time : " & sw.ElapsedMilliseconds / 1000 & " Sec")
        Else
            sw.Stop()
        End If
    End Sub
    Private Sub UPDATEBALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEBALToolStripMenuItem.Click
        Dim sw As Stopwatch = Stopwatch.StartNew()
        If UpdateBAL() Then
            sw.Stop()
            MsgBox("UPDATE BAL SUCCESS time : " & sw.ElapsedMilliseconds / 1000 & " Sec")
        Else
            sw.Stop()
        End If
    End Sub

    Private Sub UPDATEBACKLOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEBACKLOGToolStripMenuItem.Click
        Dim sw As Stopwatch = Stopwatch.StartNew()
        Try


            If UpdateBacklog() Then
                sw.Stop()
                MsgBox("UPDATE Backlog SUCCESS time : " & sw.ElapsedMilliseconds / 1000 & " Sec")

            End If
        Catch ex As Exception
        Finally
              sw.Stop()
        End Try
    End Sub

    Private Sub UPDATEALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEALLToolStripMenuItem.Click
        UpdateMAFile()
        UpdateBAL()
        UpdateODQTY()
        UpdateLOTQTY()
        UpdateBacklog()
    End Sub
    Public Function UpdateBAL()

        Dim proG As New ProgressFrm
        Try


            proG.Show()

            proG.PGB.Maximum = 3
            proG.PGB.Value = 0
            proG.PGB.Value += 1

            For i = 1 To 2
                Dim db As String
                If i = 1 Then
                    db = "BOI"
                Else
                    db = "TAX"
                End If

                proG.Text = "Update BAL " & db
                Try
                    dataACC.RunCommand("drop table check" & db, Project.checkbal)

                Catch ex As Exception

                End Try

                dataACC.RunCommand("stockCard" & db & "qry", Project.checkbal, True)
                dataACC.RunCommand("update" & db, Project.checkbal, True)

                proG.PGB.Value += 1
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            proG.Close()

        End Try



    End Function

    Public Function UpdateMAFile()
        Dim proG As New ProgressFrm
        Try


            proG.Show()

            proG.PGB.Maximum = 3
            proG.PGB.Value = 0
            proG.PGB.Value += 1

            For i = 1 To 2
                Dim db As String
                If i = 1 Then
                    db = "BOI"
                Else
                    db = "TAX"
                End If

                proG.Text = "Update MAFile " & db
                Try
                    dataACC.RunCommand("drop table MAFILEstock_" & db, Project.swanpath)

                Catch ex As Exception

                End Try

                Dim sqlstr As String
                sqlstr = "Select MAFILE_" & db & ".MA_CODE, MAFILE_" & db & ".MA_PRDT, MAFILE_" & db & ".MA_QTY, MAFILE_" & db & ".MA_RQTY, Sum(IIf(s_slip Like 'MA',S_QTY,0))-Sum(iif(s_slip like 'MB',S_QTY,0)) AS SumQTY INTO MAFILEstock_" & db
                sqlstr += " FROM STOCK_" & db & " RIGHT JOIN MAFILE_" & db & " ON (STOCK_" & db & ".S_PRDT = MAFILE_" & db & ".MA_PRDT) AND (STOCK_" & db & ".S_PRE = MAFILE_" & db & ".MA_CODE)"
                'sqlstr += " WHERE(((STOCK_" & DB & ".S_SLIP) Like 'MA' Or (STOCK_" & DB & ".S_SLIP) Is Null))"
                sqlstr += " GROUP BY MA_CODE, MA_PRDT, MA_QTY, MA_RQTY;"
                dataACC.RunCommand(sqlstr, Project.swanpath)

                sqlstr = "UPDATE MAFILE_" & db & " INNER JOIN MAFILEstock_" & db & " ON "
                sqlstr += " (MAFILEstock_" & db & ".MA_CODE = MAFILE_" & db & ".MA_CODE) "
                sqlstr += " AND (MAFILE_" & db & ".MA_PRDT = MAFILEstock_" & db & ".MA_PRDT) "
                sqlstr += " SET MAFILE_" & db & ".MA_RQTY = MAFILEstock_" & db & ".SumQTY where MAFILEstock_" & db & ".SumQTY>0;"
                dataACC.RunCommand(sqlstr, Project.swanpath)
                proG.PGB.Value += 1
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            proG.Close()

        End Try

    End Function
    Public Function UpdateLOTQTY()
        Dim proG As New ProgressFrm
        Try


            proG.Show()

            proG.PGB.Maximum = 3
            proG.PGB.Value = 0
            proG.PGB.Value += 1

            For i = 1 To 2
                Dim db As String
                If i = 1 Then
                    db = "BOI"
                Else
                    db = "TAX"
                End If

                proG.Text = "Update LOTQTY " & db
                Try
                    dataACC.RunCommand("drop table LOTQTY", Project.swanpath)

                Catch ex As Exception

                End Try

                Dim sqlstr As String
                sqlstr = " Select  MC_DATE, MC_LOT, MC_PRDT, MC_LOTQTY, MC_QTY, Sum(st.S_QTY) As SQTY, MC_CLOSE into LOTQTY"
                sqlstr += "  From STOCK_" & db & " As st right Join LOT_" & db & " As lot On (st.S_PRDT = LOT.MC_PRDT) And (st.S_PRE = LOT.MC_LOT) Where S_SLIP ='WE'"
                sqlstr += "  GROUP BY MC_DATE, MC_LOT, MC_PRDT, MC_LOTQTY, MC_QTY, MC_CLOSE"
                sqlstr += "  HAVING Sum(S_QTY) <> [MC_QTY]"
                dataACC.RunCommand(sqlstr, Project.swanpath)




                sqlstr = "update lot_" & db & " as lot inner join lotqty on lot.mc_lot=lotqty.mc_lot"
                sqlstr += " set lot.mc_qty=lotqty.sqty"
                dataACC.RunCommand(sqlstr, Project.swanpath)
                proG.PGB.Value += 1
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            proG.Close()

        End Try

    End Function
    Public Function UpdateODQTY()
        Dim proG As New ProgressFrm
        Try


            proG.Show()

            proG.PGB.Maximum = 3
            proG.PGB.Value = 0
            proG.PGB.Value += 1

            For i = 1 To 2
                Dim db As String
                If i = 1 Then
                    db = "BOI"
                Else
                    db = "TAX"
                End If

                proG.Text = "Update ODQTY " & db
                Try
                    dataACC.RunCommand("drop table ODQTY", Project.swanpath)

                Catch ex As Exception

                End Try

                Dim sqlstr As String
                sqlstr = " Select  WE_DATE, WE_CODE, WE_PRDT, WE_QTY, WE_DQTY, WE_CHK, Sum(st.S_QTY) As SQTY into ODQTY"
                sqlstr += "  From STOCK_" & db & " As st right Join ODFILE_" & db & " As lot On  (st.S_PRE = LOT.WE_CODE) Where S_SLIP ='WE'"
                sqlstr += "  GROUP BY WE_DATE, WE_CODE, WE_PRDT, WE_QTY, WE_DQTY, WE_CHK"
                sqlstr += "  HAVING Sum(S_QTY) <> [WE_DQTY] and WE_DATE>'20160101'"
                dataACC.RunCommand(sqlstr, Project.swanpath)




                sqlstr = "update ODFILE_" & db & " as lot inner join ODQTY on lot.WE_CODE=ODQTY.WE_CODE"
                sqlstr += " set lot.WE_DQTY=ODQTY.sqty"
                dataACC.RunCommand(sqlstr, Project.swanpath)





                sqlstr = " Update ODFILE_" & db & " "
                sqlstr += " set we_chk=iif(WE_DQTY=0,'3',iif(we_DQTY<>WE_QTY,'4','9'))"
                sqlstr += " where we_DQTY <> WE_QTY And WE_DATE >'20160101' and we_CHK<>'10'"
                dataACC.RunCommand(sqlstr, Project.swanpath)
                proG.PGB.Value += 1
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            proG.Close()

        End Try

    End Function
    Public Function UpdateBacklog()
        Dim proG As New ProgressFrm
        Try


            proG.Show()

            proG.PGB.Maximum = 3
            proG.PGB.Value = 0
            proG.PGB.Value += 1

            For i = 1 To 2
                Dim db As String
                If i = 1 Then
                    db = "BOI"
                Else
                    db = "TAX"
                End If

                proG.Text = "Update Backlogqty " & db
                Try
                    dataACC.RunCommand("drop table backlogqty", Project.swanpath)

                Catch ex As Exception

                End Try

                Dim sqlstr As String





                sqlstr = " Select  t1.prdt, Sum(t1.qty) As sQTY into backlogqty"
                sqlstr += "  FROM (Select 'lot',MC_PRDT as prdt, Sum([MC_LOTQTY]-[mc_QTY]) AS QTY "
                sqlstr += "  From LOT_" & db
                sqlstr += "  Where (((MC_CLOSE) <> '9'))"
                sqlstr += "  Group By MC_PRDT union"
                sqlstr += "  Select 'od',WE_PRDT, sum([WE_QTY]-[WE_DQTY]) AS QTY"
                sqlstr += "  From ODFILE_" & db & " Where WE_CHK <> '9'"
                sqlstr += "  Group By WE_PRDT )  As t1 Group By t1.prdt"
                dataACC.RunCommand(sqlstr, Project.swanpath)


                sqlstr = "update prdt_" & db & " as prdt"
                sqlstr += " set prdt.p_backlog=0"
                dataACC.RunCommand(sqlstr, Project.swanpath)


                sqlstr = "update prdt_" & db & " as prdt inner join backlogqty on prdt.p_prdt=backlogqty.prdt"
                sqlstr += " set prdt.p_backlog=backlogqty.sqty"
                dataACC.RunCommand(sqlstr, Project.swanpath)
                proG.PGB.Value += 1
            Next
            Return True
        Catch ex As Exception
            '  MsgBox(ex.Message)
            Return False
        Finally
            proG.Close()

        End Try

    End Function

    Private Sub SKapprovalBtn_Click(sender As Object, e As EventArgs) Handles SKapprovalBtn.Click
        Dim frm As New SKlistFRM
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UPDATEODFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEODFILEToolStripMenuItem.Click
        Dim sw As Stopwatch = Stopwatch.StartNew()
        If UpdateODQTY() Then
            sw.Stop()
            MsgBox("UPDATE ODFILE SUCCESS time : " & sw.ElapsedMilliseconds / 1000 & " Sec")
        Else
            sw.Stop()
        End If
    End Sub

    Private Sub TimeAttToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeAttToolStripMenuItem.Click
        Dim frm As New Timattfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MDIParent1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.HasChildren Then
            For Each frm As Form In Me.MdiChildren
                frm.Close()
            Next
        End If
        GC.Collect()
    End Sub
    Dim dumpsql As New DumpToSQLcls
    Private Sub PRDTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRDTToolStripMenuItem.Click
        dumpsql.DumptoSQL("PRDT_BOI")
        dumpsql.DumptoSQL("PRDT_TAX")
    End Sub

    Private Sub BOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOMToolStripMenuItem.Click
        dumpsql.DumptoSQL("BOM_BOI")
        dumpsql.DumptoSQL("BOM_TAX")
    End Sub

    Private Sub LOTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOTToolStripMenuItem.Click
        dumpsql.DumptoSQL("LOT_BOI")
        dumpsql.DumptoSQL("LOT_TAX")
    End Sub

    Private Sub ALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALLToolStripMenuItem.Click
        dumpsql.Run()
    End Sub

    Private Sub EMPLOYEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPLOYEEToolStripMenuItem.Click
        Dim frm As New Emplistfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EMPlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPlistToolStripMenuItem.Click
        Dim frm As New Emplistfrm
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
