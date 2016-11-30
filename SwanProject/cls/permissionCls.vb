Imports System.Data.SqlClient


Public Class permissionCls



    Function getGroup() As String
        Dim GetCK As HttpCookie = myPage.Request.Cookies("toolUSR")
        If GetCK Is Nothing Then
            getGroup = ""
        Else
            getGroup = FillNull(GetCK.Values("group"))
        End If

    End Function
    Function getUser() As String
        Dim GetCK As HttpCookie = myPage.Request.Cookies("toolUSR")
        If GetCK Is Nothing Then
            getUser = ""
        Else
            getUser = FillNull(GetCK.Values("username"))
        End If

    End Function
    Sub Checkpermission()

        Dim username As String
        'If myPage.Session("UserAuthentication") Is Nothing Then username = "Guest" Else username = myPage.Session("UserAuthentication")


        Dim GetCK As HttpCookie = myPage.Request.Cookies("toolUSR")
        If GetCK Is Nothing Then
            username = "Guest"
            myPage.Response.Redirect("~\Notpermission.aspx")
        Else

            username = GetCK.Values("username")

        End If



        Dim strConn As String
        'strConn = WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString
        strConn = webDBsql
        Dim Conn As New sqlConnection(strConn)
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
        sqlUserName = "SELECT username.U_name,P_FORM FROM permission right join username "
        sqlUserName &= " on username.U_group=permission.P_group"
        sqlUserName &= " WHERE username.U_name = @UserName"
        sqlUserName &= " AND (P_FORM = @P_FORM or P_FORM='ALL')"

        Dim com As New SqlCommand(sqlUserName, Conn)
        com.Parameters.AddWithValue("@UserName", username)
        com.Parameters.AddWithValue("@P_FORM", myPage.AppRelativeVirtualPath)
        '******************************************************************

        Dim CurrentName As String
        CurrentName = CStr(com.ExecuteScalar)

        If CurrentName = "" Then


            myPage.Response.Redirect("~\Notpermission.aspx")

        End If

    End Sub
End Class
