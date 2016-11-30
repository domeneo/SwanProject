Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports System.Data.Sql
Imports System.Configuration
Imports System.Net
Imports System.Data.OleDb




Public Module Modcls



    Public Function objTostr(obj As Object) As String

        Dim str As String
        If obj Is Nothing Then
            str = ""
        Else
            str = obj.ToString()
        End If
        Return str

    End Function


    Public Sub BinddingControl(ByVal DD As ComboBox, ByVal tbl As String, ByVal txtF As String, ByVal ValF As String, ByVal conn As Object, Optional ByVal OtherExp As String = "")
        Dim sql As String
        If conn.[GetType]() Is GetType(SqlConnection) Then
            conn = DirectCast(conn, SqlConnection)
        ElseIf conn.[GetType]() Is GetType(OleDbConnection) Then
            conn = DirectCast(conn, OleDbConnection)
        End If


        Dim bcd As New dataSQLcls()
        Dim DS As New DataSet()
        sql = "select * from " & tbl & " " & OtherExp
        bcd.conn = conn
        bcd.QryDT(sql)
        ' da = new SqlDataAdapter(sql, conn);
        'da.Fill(DS, "Bind");

        DD.DisplayMember = txtF
        DD.ValueMember = ValF
        DD.DataSource = bcd.dt


    End Sub
#Region "Null"
    Public Function NullstringtoNull(ByVal strTmp As String) As String
        If strTmp = "" OrElse strTmp = "&nbsp;" Then
            strTmp = "null"
        End If
        Return strTmp
    End Function
    Public Function NullstringToZero(ByVal strTmp As String) As String
        If strTmp = "" OrElse strTmp = "&nbsp;" Then
            strTmp = "0"
        End If
        Return strTmp
    End Function
    Public Function NullDate(ByVal strTmp As String) As String
        If strTmp = "" OrElse strTmp = "&nbsp;" Then
            strTmp = "null"
        Else
            strTmp = "'" & strTmp & "'"
        End If
        Return strTmp
    End Function
    Public Function Nullnbsp(ByVal strTmp As String) As String
        Return If(strTmp = "&nbsp;", "", strTmp)
    End Function

#End Region

    Public Function ConvertDate(ByVal strtmp As String) As String
        Dim testdate As DateTime
        If strtmp <> "" Then
            testdate = Convert.ToDateTime(strtmp)
            strtmp = Convert.ToString(testdate.ToString("dd/MM/yyyy HH:mm:ss"))
        Else
            strtmp = ""
        End If
        Return strtmp
    End Function



    Public Sub ClearBox(ByVal ctrlG As Control)
        For Each ctrl As Control In ctrlG.Controls
            If ctrl.[GetType]() Is GetType(TextBox) Then
                DirectCast(ctrl, TextBox).Text = ""
            End If
        Next

    End Sub
    Sub SendTab(ByVal KeyAscii As Integer)
        If KeyAscii = 13 Then
            SendKeys.Send("{tab}")
            KeyAscii = 0
        End If
    End Sub
    Function strAccess(ByVal strPath As String) As String
        strAccess = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strPath & ";Persist Security Info=False"

    End Function
    Function strSqlserver(ByVal server As String, ByVal DBname As String, ByVal username As String, ByVal yourpassword As String) As String
        strSqlserver = "server=" & server & ";initial catalog=" & DBname & ";user=" & username & ";password=" & yourpassword & ";"
    End Function

    Function strSqlserver(ByVal server As String, ByVal DBname As String) As String
        strSqlserver = "data source=" & server & ";initial catalog=" & DBname & ";integrated security=SSPI;persist security info=False;Trusted_Connection=Yes"
    End Function


    Function isExistTable(ByVal tablename As String, ByVal ds As DataSet) As Boolean
        isExistTable = False
        For Each dt As DataTable In ds.Tables
            If dt.TableName = tablename Then
                isExistTable = True
                Exit Function
            End If

        Next
    End Function


    Sub OpenConn(ByVal conn As SqlClient.SqlConnection, ByVal strConn As String)
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With
    End Sub



    Function FillNull(ByVal obj As Object) As String
        If (obj) Is DBNull.Value Then
            FillNull = ""
        Else
            FillNull = obj
        End If
    End Function
    Function Add0(ByVal value As Integer) As String
        If value < 10 Then
            Add0 = "0" & CStr(value)
        Else
            Add0 = CStr(value)
        End If
    End Function

    Sub OpenNewConn(ByVal conn As OleDb.OleDbConnection, ByVal strConn As String)
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With
    End Sub
#Region "DATETIME"
    Function getThisDATE()


        Return Year(Now) & Add0(Month(Now)) & Add0(Now.Day)
    End Function
    Function getThisMonth()


        Return Year(Now) & Add0(Month(Now))
    End Function

    Function runMonth(ByVal month As String, ByVal num As Integer)
        Dim nextMonth, nextYear As Integer
        nextMonth = Mid(month, 5, 2) + num

        nextYear = Mid(month, 1, 4) + (nextMonth \ 12)

        nextMonth = nextMonth Mod 12
        If nextMonth = 0 Then
            nextMonth = 12
            nextYear -= 1
        End If


        Return nextYear & Add0(nextMonth)

    End Function
    Function runyear(ByVal year As String, ByVal num As Integer)
        runyear = (Mid(year, 1, 4) + num) & Mid(year, 5, 2)


    End Function
#End Region

#Region "addTab"
    Sub AddSendtab(ByVal Pctrl As Control, Optional exclude As String = "")
        Try
            For Each ctrl As Control In Pctrl.Controls
                If ctrl.[GetType]() Is GetType(TextBox) Then
                    If exclude.ToUpper.Contains(ctrl.Name.ToUpper) Then Continue For



                    AddHandler DirectCast(ctrl, TextBox).KeyDown, AddressOf TextBox_Keydown
                ElseIf ctrl.[GetType]() Is GetType(ComboBox) Then
                    If exclude.ToUpper.Contains(ctrl.Name.ToUpper) Then Continue For
                    AddHandler DirectCast(ctrl, ComboBox).KeyDown, AddressOf TextBox_Keydown

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub TextBox_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        SendTab(e.KeyCode)
    End Sub
#End Region
    Sub SelectTextTB(ByVal tb As TextBox)

        tb.Focus()
        tb.SelectionStart = 0
        tb.SelectionLength = Len(tb.Text)
    End Sub
    Dim db As New dataSQLcls
    Sub incNO(ByVal Slip As String)

        db.RunCommand("update DocNo set no = FORMAT(no + 1,'0000') where type like '" & Slip & "'", Project.swanSQL)
    End Sub
    Public Function getno(ByVal Slip As String) As String

        getno = db.ExScalar("select no from DocNo where type like '" & Slip & "'", Project.swanSQL)
    End Function
    Function SpaceTOZero(ByVal str As String)
        If str = "" Then
            str = 0

        End If
        Return str
    End Function
    Public Function SortDatatable(ByVal dt_data As DataTable, ByVal sort_field As String, Optional ByVal sort_direction As String = "ASC") As DataTable

        Dim dv_data As New DataView

        dv_data = dt_data.DefaultView

        dv_data.Sort() = sort_field & " " & sort_direction

        dt_data = dv_data.ToTable()

        Return dt_data

    End Function

    Public Function FindControlRecursive(control As Control, id As String) As Object

        If control Is Nothing Then Return Nothing

        Dim ctrl As Object = control.Controls(id)
        If control.GetType() Is GetType(StatusStrip) Then
            Dim sm As StatusStrip = control

            ctrl = DirectCast(sm.Items(id), Object)

        End If
        If ctrl Is Nothing Then
            For Each child As Control In control.Controls
                ctrl = FindControlRecursive(child, id)
                If Not ctrl Is Nothing Then
                    Return ctrl
                    Exit Function
                End If

            Next
        Else
            Return ctrl

        End If

        Return Nothing

    End Function
End Module
