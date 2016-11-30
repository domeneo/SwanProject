Imports System.Data.SqlClient
Imports System.Configuration
Public Class LoginCls

    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("webdb").ConnectionString)
    Dim _DirectTo As String
    Dim _uname As String
    Dim _group As String
    Property DirectTo()
        Get
            Return _DirectTo
        End Get
        Set(ByVal value)
            _DirectTo = value
        End Set
    End Property
    Property Uname()
        Get
            Return _uname
        End Get
        Set(ByVal value)
            _uname = value
        End Set
    End Property
    Property Group()
        Get
            Return _group
        End Get
        Set(ByVal value)
            _group = value
        End Set
    End Property
    Sub New()

    End Sub
    Sub authenticate(ByVal username As String, ByVal pwd As String)



        ' Dim strConn As String
        'strConn = WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
        '  strConn = Conn
        'Dim Conn As New SqlConnection(strConn)
        Conn.Open()


        'คิวรี่ข้อมูลแบบปกติ************************************************
        'Dim sqlUserName As String
        'sqlUserName = "SELECT UserName,Password FROM UserName "
        'sqlUserName &= " WHERE (UserName ='" & username & "')"
        'sqlUserName &= " AND (Password ='" & pwd & "')"

        'Dim com As New OleDbCommand(sqlUserName, Conn)
        '******************************************************************

        'ป้องกันการทำ SQL Injection**************************************
        Dim sqlUserName As String
        sqlUserName = "SELECT U_NAME,G_name FROM UserName inner join usergroup on username.u_group=usergroup.g_id"
        sqlUserName &= " WHERE (U_name = @UserName"
        sqlUserName &= " AND Password = @Password)"

        Dim com As New SqlCommand(sqlUserName, Conn)
        com.Parameters.AddWithValue("@UserName", username)
        com.Parameters.AddWithValue("@Password", pwd)
        '******************************************************************


        Dim dr As SqlDataReader
        dr = com.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            _uname = dr(0)
            _group = dr(1)
            dr.Close()
        Else
            _uname = ""
            _group = ""
        End If
    End Sub
End Class
