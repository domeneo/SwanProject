Imports System.Data.SqlClient
Imports System.Configuration
Public Class PRDTfrm
    Dim mc As New matchControl
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim SQLstr As String
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connAcc As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    Dim ScCLS As New StockCLS
    Dim Datec As New DateCls
    Dim LogC As New LOGCLS

    Function CheckString() As Boolean
        If txtcode.Text = "" Then

            Return False
        Else

            Return True

        End If
    End Function

    Sub SwitchMode(ByVal Mode As String)
        LBLSTATUS.Text = Mode
        If Mode = "Edit" Then
            AddBtn.Visible = False
            SaveBtn.Visible = True
            DelBtn.Visible = True
            btnCancel.Visible = True
        ElseIf Mode = "Add" Then
            ClearBox(Me)
            '  txtCode.Text = dtSQL.ExScalar("select we_no from weno_" & DBCB.Text)
            ' txtCode.Enabled = False
            AddBtn.Visible = True
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = True
            lblBOI.Visible = False
            lblTAX.Visible = False
            lblKey.Text = ""
        ElseIf Mode.ToUpper = "IDLE" Then

            ClearBox(Me)

            lblKEY.Text = ""
            txtcode.Enabled = True
            txtEname.Enabled = True

            txtcode.Enabled = True
            txtBOIPlace.Enabled = True


            AddBtn.Visible = False
            SaveBtn.Visible = False
            DelBtn.Visible = False
            btnCancel.Visible = False
            LBLSTATUS.Text = ""


        End If

    End Sub
    Sub NewDATA()

        SwitchMode("Add")
        'txtCode.Text = ScCLS.getMANO(DBCB.Text)
        'lblKEY.Text = txtCode.Text
        ' GV1.Rows.Clear()

        txtcode.Focus()
    End Sub
    Sub EDITDATA()
        lblBOI.Visible = False
        lblTAX.Visible = False
        Dim dtBOI, dtTAX As New DataTable
        dtBOI = GETDATA(txtFind.Text, "BOI")
        dtTAX = GETDATA(txtFind.Text, "TAX")
        If dtBOI.Rows.Count > 0 Then
            lblBOI.Visible = True
            mc.DTrowtocon("PRDTinput", dtBOI, Me)
            txtBOIPlace.Text = dtBOI.Rows(0)("P_PLACE").ToString
        End If

        If dtTAX.Rows.Count > 0 Then
            lblTAX.Visible = True
            If lblBOI.Visible = False Then
                mc.DTrowtocon("PRDTinput", dtTAX, Me)

            End If
            txtTAXPlace.Text = dtTAX.Rows(0)("P_PLACE").ToString
        End If

        If lblBOI.Visible = False And lblTAX.Visible = False Then

            '  MsgBox("No Data")
            Exit Sub
        End If
        SwitchMode("Edit")
        txtcode.Focus()



    End Sub
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        ' Try

        If Not CheckString() Then

            MsgBox("Please Input Data")
            Exit Sub
        End If

        txtSet.Text = "*"
        If txtWeight.Text = "" Then
            txtWeight.Text = 0
        End If


        mc.insertSQL("PRDT_BOI", "PRDTInput", Me, "p_prdt", conn, True)
        mc.insertSQL("PRDT_BOI", "PRDTInput", Me, "p_prdt", connAcc, True)

        mc.insertSQL("PRDT_TAX", "PRDTInput", Me, "p_prdt", conn, True)
        mc.insertSQL("PRDT_TAX", "PRDTInput", Me, "p_prdt", connAcc, True)

        dtACC.RunCommand("update prdt_boi set P_PLACE='" & txtBOIPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")
        dtACC.RunCommand("update prdt_tax set P_PLACE='" & txtTAXPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")

        dtSQL.RunCommand("update prdt_boi set P_PLACE='" & txtBOIPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")
        dtSQL.RunCommand("update prdt_tax set P_PLACE='" & txtTAXPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")

        SwitchMode("IDLE")
        txtEname.Focus()
        MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")
        'Catch ex As Exception
        ' MsgBox(ex.Message)
        ' End Try
    End Sub
    Function GETDATA(ByVal ID As String, DB As String) As DataTable

        dtSQL.QryDT("select * from PRDT_" & DB & " where p_prdt like '" & ID & "' ")
        Return dtSQL.dt

    End Function
    Dim autocom As New autocompleteCLS
    Dim dtEname As New DataTable
    Private Sub QAfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'init 
        dtSQL.conn = conn
        dtACC.conn = connAcc


        dtEname = dtSQL.QryDT("select distinct p_ename,p_Tname from PRDT_BOI order by p_ENAME", Project.swanSQL)
        autocom.AutoCompleteTextBox(txtEname, dtEname)

        mc.OutConnSQL = conn
        mc.OutConnAcc = connAcc
        mc.OutDB = "SQL"
        AddSendtab(Me)
        ' DBCB.SelectedIndex = 0

        If lblKEY.Text <> "" Then
            EDITDATA()
        Else
            NewDATA()
        End If

    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If MsgBox("Confirm to Delete?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then

            dtSQL.RunCommand("delete  from PRDT_BOI where P_PRDT like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from PRDT_BOI where P_PRDT like '" & lblKEY.Text & "'")

            dtSQL.RunCommand("delete  from PRDT_TAX where P_PRDT like '" & lblKEY.Text & "'")
            dtACC.RunCommand("delete  from PRDT_TAX where P_PRDT like '" & lblKEY.Text & "'")
            SwitchMode("IDLE")

        End If

    End Sub


    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            If Not CheckString() Then
                MsgBox("Please Input Data")
                Exit Sub
            End If

            If txtWeight.Text = "" Then
                txtWeight.Text = 0
            End If
            If lblBOI.Visible And lblstatus.Text.ToUpper = "EDIT" Then

                mc.updateSQL("PRDT_BOI", "PRDTInput", Me, "p_Prdt", conn)
                mc.updateSQL("PRDT_BOI", "PRDTInput", Me, "p_Prdt", connAcc)
            Else
                mc.insertSQL("PRDT_BOI", "PRDTInput", Me, "p_Prdt", conn, True)
                mc.insertSQL("PRDT_BOI", "PRDTInput", Me, "p_Prdt", connAcc, True)
            End If

            If lblTAX.Visible And lblstatus.Text.ToUpper = "EDIT" Then
                mc.updateSQL("PRDT_TAX", "PRDTInput", Me, "p_Prdt", conn)
                mc.updateSQL("PRDT_TAX", "PRDTInput", Me, "p_Prdt", connAcc)
            Else
                mc.insertSQL("PRDT_TAX", "PRDTInput", Me, "p_Prdt", conn, True)
                mc.insertSQL("PRDT_TAX", "PRDTInput", Me, "p_Prdt", connAcc, True)

            End If

            dtACC.RunCommand("update prdt_boi set P_PLACE='" & txtBOIPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")
            dtACC.RunCommand("update prdt_tax set P_PLACE='" & txtTAXPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")

            dtSQL.RunCommand("update prdt_boi set P_PLACE='" & txtBOIPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")
            dtSQL.RunCommand("update prdt_tax set P_PLACE='" & txtTAXPlace.Text & "' where p_prdt like '" & lblKEY.Text & "'")
        


            SwitchMode("IDLE")
            txtEname.Focus()

            MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly, "Success")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 

    Private Sub GetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetBtn.Click
        EDITDATA()
    End Sub

    Private Sub cmdNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNEW.Click
        NewDATA()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SwitchMode("IDLE")
    End Sub


    Private Sub txtFind_LostFocus(sender As Object, e As EventArgs) Handles txtFind.LostFocus
        If txtcode.Text <> "" Then

            EDITDATA()
            If txtcode.Text = "" Then SwitchMode("ADD")
        End If
    End Sub


    'Public Shared Sub KeyPress(ByVal TargetControl As Control, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            e.SuppressKeyPress = True
    '            e.Handled = True
    '            SendKeys.Send("{TAB}")
    '        ElseIf e.KeyCode = Keys.Escape Then
    '            e.SuppressKeyPress = True
    '            e.Handled = True
    '            'Clear(TargetControl.)
    '        End If
    '    Catch ex As Exception
    '        ' showMessagebox_Warning(ex.Message)
    '    End Try
    'End Sub





    Private Sub txtEname_LostFocus(sender As Object, e As EventArgs) Handles txtEname.LostFocus
        Dim str As String = ""
        Try
            For Each dr As DataRow In dtEname.Select("p_Ename='" & txtEname.Text & "'")
                str = dr("p_Tname").ToString
            Next
        Catch ex As Exception

        End Try

        If str <> "" Then
            txtTname.Text = str
            txtTname.SelectAll()
        End If
    End Sub
End Class
