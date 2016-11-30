Imports System.Configuration
Imports System.Data.SqlClient
Public Class LOGCLS


    Dim SQLstr As String

    Enum DBTYPE
        SQLSERVER = 1
        ACCESS = 2
    End Enum
    Public Shared Sub SaveLOG(DB As String, Code As String, ACT As String, DBType As DBTYPE, Optional MSG As String = "", Optional user As String = "")

        Dim SQLstr As String
        Dim dtSQL As New dataSQLcls
        Dim dtACC As New dataACCcls
        Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
        Dim connAcc As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
        SQLstr = "insert into stock_log ([SL_DB],[SL_CODE],[SL_TIME],[SL_USER],[SL_ACT],[SL_MSG]) values("
        SQLstr = SQLstr & "'" & DB & "'"
        SQLstr = SQLstr & ",'" & Code & "'"

        If DBType = 1 Then
            SQLstr = SQLstr & ",getdate()"
        Else
            SQLstr = SQLstr & ",now()"

        End If



        SQLstr = SQLstr & ",'" & System.Security.Principal.WindowsIdentity.GetCurrent().Name & "'"
        SQLstr = SQLstr & ",'" & ACT & "','" & MSG & "')"
        ' dtACC.RunCommand(SQLstr)
        'dtSQL.RunCommand(SQLstr)

        If DBType = 1 Then
            If dtSQL.conn Is Nothing Then dtSQL.conn = conn
            dtSQL.RunCommand(SQLstr)
        Else
            If dtACC.conn Is Nothing Then dtACC.conn = connAcc
            dtACC.RunCommand(SQLstr)

        End If
    End Sub


End Class
