Imports System.Windows.Forms.Control
Public Class WIPfrm
    Dim wip As New WIPCls
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtFromDate.Text = "" Or txtTodate.Text = "" Then

            ' MsgBox("Please input date")
            ' Exit Sub
        End If



        Dim Lotclose As String = ""

        If ChkLOT5.Checked Then
            Lotclose = "MC_CLOSE like '5'"
        End If
        If chkLot7.Checked Then
            If Lotclose <> "" Then Lotclose += " OR "
            Lotclose += "MC_CLOSE like '7'"
        End If
        If ChkLot9.Checked Then
            If Lotclose <> "" Then Lotclose += " OR "
            Lotclose += "MC_CLOSE like '9'"
        End If
        If Not ChkLOT5.Checked And Not chkLot7.Checked And Not ChkLot9.Checked Then
            Lotclose = ""
        End If

        If ChkLOT5.Checked And chkLot7.Checked And ChkLot9.Checked Then
            Lotclose = ""
        End If

        If Lotclose <> "" Then
            Lotclose = " and ( " & Lotclose & ")"
        End If
        If txtdept.Text.Trim = "" Then
            txtdept.Text = "%"
        End If
        wip.LoadWIP(DBCB.Text, txtFromDate.Text, txtTodate.Text, txtdept.Text, Lotclose, txtInlot.Text, txtStockDate.Text.Trim)
        GV1.DataSource = wip.ALLdt


        lblCount.Text = "จำนวนทั้งหมด : " & GV1.Rows.Count
    End Sub

    Private Sub WIPfrm_resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' GV1.Width = Me.Width - GV1.Left - 30
        ' GV1.Height = Me.Height - GV1.Top - 40
    End Sub

    'Sub FilterDV()
    '    'Try

    '    Dim dv As DataView
    '    dv = GV1.DataSource


    '    If GV1.Columns(ColCB.Text).ValueType Is GetType(String) Then
    '        dv.RowFilter = "[" & ColCB.Text & "] like '" & wheretxt.Text & "%'"
    '    ElseIf GV1.Columns(ColCB.Text).ValueType Is GetType(Integer) Then
    '        If wheretxt.Text.Length <= 1 Then Exit Sub
    '        Dim opt As String
    '        If wheretxt.Text.Substring(0, 1) = "<" Or wheretxt.Text.Substring(0, 1) = ">" Then
    '            opt = ""
    '            If wheretxt.Text.Length <= 2 Then Exit Sub
    '        Else
    '            opt = "="
    '        End If
    '        dv.RowFilter = "[" & ColCB.Text & "] " & opt & " " & wheretxt.Text & ""
    '    End If
    '    GV1.DataSource = dv
    '    lblCount.Text = "จำนวนทั้งหมด : " & dv.Count
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try
    'End Sub
    Dim CBCOLAR(20), CBAndOrAR(20) As ComboBox
    Dim GBfilterAR(20) As GroupBox
    Dim WheretxtAR(20) As TextBox
    Dim WhereCount As Integer = 0
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If WhereCount > 20 Then
            MsgBox("Maximum Filter")
            Exit Sub
        End If
        Do Until GBfilterAR(WhereCount) Is Nothing
            WhereCount += 1

        Loop
        Dim newfilter As New GroupBox
        Dim newCBCOL, newAndOR As New ComboBox
        Dim newWheretxt As New TextBox
        With newfilter

            .Name = "GBFilter" & WhereCount
            .Width = GBFilter.Width
            .Height = GBFilter.Height
            .Text = GBFilter.Text
            .Font = GBFilter.Font
        End With
        With newCBCOL

            For Each Value In ColCB.Items
                .Items.Add(Value)

            Next
            '.Items.Add("MC_PRDT")
            '.Items.Add("MC_CLOSE")
            '.Items.Add("MC_DATE")
            '.Items.Add("S_PRDT")
            .Name = "COLCB" & WhereCount
            .Text = ColCB.Text
            .Width = ColCB.Width
            .Location = ColCB.Location
            .Left += ColCB.Width - 20
        End With
        With newAndOR
            .Items.Add("AND")
            .Items.Add("OR")
            .Text = "AND"
            .Name = "CBAndOR1"
            .Width = ColCB.Width - 30
            .Location = ColCB.Location
        End With
        With newWheretxt
            .Name = "wheretxt" & WhereCount
            .Width = wheretxt.Width
            .Location = wheretxt.Location
            .Left += ColCB.Width - 20
        End With

        newfilter.Controls.Add(newCBCOL)
        newfilter.Controls.Add(newAndOR)
        newfilter.Controls.Add(newWheretxt)
        Me.Controls.Add(newfilter)
       


        GBfilterAR(WhereCount) = newfilter
        WheretxtAR(WhereCount) = newWheretxt
        CBCOLAR(WhereCount) = newCBCOL
        CBAndOrAR(WhereCount) = newAndOR


        If WhereCount = 0 Then
            newfilter.Top = GBFilter.Top
            newfilter.Left = GBFilter.Left + GBFilter.Width + 10

        Else
            newfilter.Top = GBfilterAR(WhereCount - 1).Top
            newfilter.Left = GBfilterAR(WhereCount - 1).Left + GBfilterAR(WhereCount - 1).Width + 10
            If newfilter.Left + newfilter.Width > Me.Width Then
                newfilter.Left = GBFilter.Left
                newfilter.Top = GBfilterAR(WhereCount - 1).Top + newfilter.Height + 10
                GV1.Top = GV1.Top + newfilter.Height + 10
                GV1.Height = GV1.Height - newfilter.Height + 10
            Else


            End If

        End If


        WhereCount += 1

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If WhereCount >= 1 Then
            If GBfilterAR(WhereCount - 1).Left = GBFilter.Left Then

                GV1.Top = GV1.Top - GBfilterAR(WhereCount - 1).Height - 10
                GV1.Height = GV1.Height + GBfilterAR(WhereCount - 1).Height - 10
            End If
            GBfilterAR(WhereCount - 1).Dispose()
            WheretxtAR(WhereCount - 1).Dispose()
            CBCOLAR(WhereCount - 1).Dispose()
            CBAndOrAR(WhereCount - 1).Dispose()

            GBfilterAR(WhereCount - 1) = Nothing
            WheretxtAR(WhereCount - 1) = Nothing
            CBCOLAR(WhereCount - 1) = Nothing
            CBAndOrAR(WhereCount - 1) = Nothing

            WhereCount -= 1
        End If

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim dt As DataTable
        If CBShow.Text = "ALL" Then
            dt = wip.ALLdt
        Else
            dt = wip.Gdt
        End If


        If dt Is Nothing Then
            MsgBox("Please Show Data First")
            Exit Sub
        End If

        Dim EXP As String
        If ColCB.Text = "Diff" Then
            EXP = " Diff <>0"
        Else
            EXP = ColCB.Text & " like '" & wheretxt.Text & "'"
        End If

        Dim i As Integer = 0
        Do Until GBfilterAR(i) Is Nothing
            If CBAndOrAR(i).Text = "" Or CBCOLAR(i).Text = "" Then

                MsgBox("Please input Data")
                Exit Sub
            End If

            If CBCOLAR(i).Text = "Diff" Then
                EXP += " " & CBAndOrAR(i).Text & " Diff <>0"
            Else
                EXP += " " & CBAndOrAR(i).Text & " " & CBCOLAR(i).Text & " like '" & WheretxtAR(i).Text & "'"
            End If

            i += 1

        Loop
        Dim dr() As DataRow = dt.Select(EXP, "MC_LOT ASC, MC_PRDT ASC")
        If dr.Count = 0 Then
            GV1.DataSource = Nothing
            GV1.Rows.Clear()
        Else

            GV1.DataSource = dr.CopyToDataTable
        End If
        lblCount.Text = "จำนวนทั้งหมด : " & GV1.Rows.Count


    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Dim Excelexp As New ExporttoExcel
        'Dim dt As New DataTable
        'Dim dv As DataView
        'dt = GV1.DataSource
        ''dt = dv.ToTable()
        'With Excelexp
        '    .BeginCloumn = "A"
        '    .SetDt = dt
        '    .Title = "WIP " & txtFromDate.Text & " to " & txtTodate.Text
        '    .QuickShow2()
        'End With


        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.Filter = "Excel File|*.xlsx"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "WIP"

        If SaveFileDialog1.ShowDialog(Me) = DialogResult.Cancel Then

            Exit Sub
        End If


        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If
        Dim excelexp As New ExporttoExcel_EP

        ' Dim dv As DataView = GV1.DataSource

        excelexp.CreateSheet(GV1.DataSource, SaveFileDialog1.FileName, "WIP")
    End Sub

    Private Sub BtnNoFilter_Click(sender As Object, e As EventArgs) Handles BtnNoFilter.Click
        ShowAllDATA()
    End Sub

    Private Sub CBShow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBShow.SelectedIndexChanged
ShowAllDATA

    End Sub

    Private Sub WIPfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ShowAllDATA()

        If CBShow.Text = "ALL" Then
            GV1.DataSource = wip.ALLdt
        Else
            GV1.DataSource = wip.Gdt
        End If
        lblCount.Text = "จำนวนทั้งหมด : " & GV1.Rows.Count - 1
    End Sub
End Class