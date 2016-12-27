Imports System.Threading
Public Class SKlistFRM

    Dim dal As New dataACCcls
    Dim dalSQL As New dataSQLcls
    Dim sqlstr As String

    Dim timer As Timer
    Dim timecall As TimerCallback
    Function getDATA()
        sqlstr = "select EXP_SK.E_SKNO,E_R as REV,E_FUNC,E_TCCSMR as CSMR,E_DELDATE,E_ORDER,E_PRDT as PRDT,E_PRDT_T,E_QTY,E_AQTY,SKA_QC as QC,SKA_PROD as Production,SKA_EXAMINE as EXAMINE,SKA_Handling as Handling from (EXP_SK left join SK_APPROVE on EXP_SK.E_SKNO=SK_APPROVE.SKA_NO) left join MEMO_CSMR on MEMO_CSMR.E_SKNO=EXP_SK.E_SKNO where E_QTY-E_AQTY>0  order by EXP_SK.E_SKNO desc,E_order "

        Return dal.QryDT(sqlstr, Project.swanpath)
    End Function
    Function getUnapprove()

        Dim dt As New DataTable
        sqlstr = "select EXP_SK.E_SKNO,E_R as REV,E_FUNC,E_TCCSMR as CSMR,E_DELDATE,E_ORDER,E_PRDT as PRDT,E_PRDT_T,E_QTY,E_AQTY,SKA_QC as QC,SKA_PROD as Production,SKA_EXAMINE as EXAMINE,SKA_Handling as Handling from (EXP_SK left join SK_APPROVE on EXP_SK.E_SKNO=SK_APPROVE.SKA_NO) left join MEMO_CSMR on MEMO_CSMR.E_SKNO=EXP_SK.E_SKNO "
        sqlstr += " where E_QTY-E_AQTY>0  "


        If Project.Group = "ProductionHead" Then

            sqlstr += " and ska_Prod is null"
        ElseIf Project.Group = "QC" Then


            sqlstr += " and [SKA_ QC] is null"
        ElseIf Project.Group = "Marketing" Then
            sqlstr += " and [SKA_Hand] is null"
        ElseIf Project.Group = "Suzie" Then
            sqlstr += " and [SKA_Examine] is null"

        End If

        sqlstr += " order by EXP_SK.E_SKNO desc,E_order "

        dt = dal.QryDT(sqlstr, Project.swanpath)
        Return dt
    End Function
    Function getUnPrint()
        Dim dt As New DataTable
        sqlstr = "select EXP_SK.E_SKNO,E_R as REV,E_FUNC,E_TCCSMR as CSMR,E_DELDATE,E_ORDER,E_PRDT as PRDT,E_PRDT_T,E_QTY,E_AQTY,SKA_QC as QC,SKA_PROD as Production,SKA_EXAMINE as EXAMINE,SKA_Handling as Handling from (EXP_SK left join SK_APPROVE on EXP_SK.E_SKNO=SK_APPROVE.SKA_NO) left join MEMO_CSMR on MEMO_CSMR.E_SKNO=EXP_SK.E_SKNO "
        sqlstr += " where E_QTY-E_AQTY>0  "


        sqlstr += " and ska_Prod is  not null"

        sqlstr += " and [SKA_QC] is not null"

        sqlstr += " and [SKA_Handling] is not null"

        sqlstr += " and [SKA_Examine] is not null"

        If Project.Group = "Production" Then

            sqlstr += " and ska_P_Prod is null"
        ElseIf Project.Group = "QC" Then

            sqlstr += " and ska_P_QC is null"

        ElseIf Project.Group = "Marketing" Then

            sqlstr += " and ska_P_Mar is null"
        End If
        sqlstr += " order by EXP_SK.E_SKNO desc,E_order "

        dt = dal.QryDT(sqlstr, Project.swanpath)

        Return dt

    End Function

    Function getUnNote()
        Dim dt As New DataTable
        sqlstr = "Select  [SKL_NO],max(Convert(varchar(255), [SKL_TIME], 120) + ' ' + SKL_ACT) as NoteTime"

        sqlstr += "  From [SWAN].[dbo].[SK_LOG] Where (skl_ACT Like 'Read' and SKL_NAME like '" & Project.User & "') or skl_act like 'NOTE' group by skl_no  having max(convert(varchar(255),[SKL_TIME],120)  + SKL_ACT) not like '%Read'"
        dt = dalSQL.QryDT(sqlstr, Project.swanSQL)

        Return dt
    End Function
    Private Sub SKlistFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CheckForIllegalCrossThreadCalls = False



        ' Dim CommandLineArgs() As String = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData

        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs


        If CommandLineArgs.Count >= 2 Then

            Dim Login As New LoginCls
            Login.authenticate(CommandLineArgs(0), CommandLineArgs(1))


            Project.User = Login.Uname
            Project.Group = Login.Group

        End If

        DGVSK.DataSource = getDATA()


        timecall = New TimerCallback(AddressOf Process)
        timer = New Timer(timecall, Nothing, 1000, 5000)


        'timecall_plc = New TimerCallback(readplc);
        '        timer_plc = New System.Threading.Timer(New TimerCallback(timecall_plc), null, 5000, 1000);
    End Sub

    Function CountSK(dt As DataTable)

        Dim c As Integer = 0
        Dim b As String = ""
        For Each dr As DataRow In dt.Rows
            If dr(0).ToString <> b Then
                c += 1
            End If
        Next
        Return c
    End Function



    Private Sub SKlistFRM_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Icon = SystemIcons.Application
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            'NotifyIcon1.BalloonTipTitle = "Verificador corriendo"
            'NotifyIcon1.BalloonTipText = "Verificador corriendo"
            '  NotifyIcon1.ShowBalloonTip(50000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub


    Dim processt As New Object
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'SyncLock processt

        '    Dim thd As New Thread(AddressOf Process)
        '    thd.IsBackground = True
        '    thd.Start()




        'End SyncLock


    End Sub
    Sub Process()
        timer.Change(Timeout.Infinite, Timeout.Infinite)
        Try


            Dim noticestr As String = ""
            Dim dtnotPrint As New DataTable
            Dim skcount As Integer


            dtnotPrint = getUnPrint()

            skcount = CountSK(dtnotPrint)
            TPNotprint.Text = "NotPrint - " & skcount
            DGVNotPrint.DataSource = dtnotPrint
            If skcount > 0 Then noticestr = "SK " & skcount & " รายการยังไม่ได้ปริ๊น" & vbCrLf


            Dim dtnotAPP As New DataTable

            dtnotPrint = getUnPrint()


            skcount = CountSK(dtnotAPP)
            TPnotApp.Text = "NotApp - " & skcount
            DGVNotApp.DataSource = dtnotAPP
            If skcount > 0 Then noticestr += "SK " & skcount & " รายการยังไม่ได้Approve" & vbCrLf



            Dim dtunnote As New DataTable

            dtunnote = getUnNote()


            skcount = CountSK(dtunnote)
            'TPnotApp.Text = "NewNOTE - " & skcount
            '  DGVNotApp.DataSource = dtunnote
            If skcount > 0 Then noticestr += "SK " & skcount & " รายการ มี Noteใหม่"



            If Me.WindowState = FormWindowState.Minimized Then



                NotifyIcon1.BalloonTipTitle = "Warning"
                NotifyIcon1.BalloonTipText = noticestr
                NotifyIcon1.ShowBalloonTip(20000)
            End If
        Catch ex As Exception

        Finally
            timer.Change(5000, 5000)

        End Try


    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub


    Private Sub DGVSK_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSK.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        Dim frm As New SKappDetailfrm
        frm.sklbl.Text = DGVSK.Rows(e.RowIndex).Cells("E_SKNO").Value
        frm.Show()
    End Sub
End Class