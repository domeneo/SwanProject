
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient

Imports System.Data.OleDb

Public Class datacls
    Public dt As DataTable
    Private cmd As OleDbCommand
    Public Sub QryDT(ByVal conn As OleDbConnection, ByVal sql As String)
        Dim da As OleDbDataAdapter

        Dim DS As New DataSet()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(DS, "temp")
        dt = DS.Tables("temp")
        ' return dt;
    End Sub
    Public Sub RunCommand(ByVal conn As OleDbConnection, ByVal sql As String)
        Try
            cmd = New OleDbCommand(sql, conn)
            cmd.Connection = conn
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub
    Public Function ExScalar(ByVal conn As OleDbConnection, ByVal sql As String) As String
        Dim result As String
        cmd = New OleDbCommand(sql, conn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim obj As [Object] = cmd.ExecuteScalar()
        If obj IsNot Nothing Then
            result = obj.ToString()
        Else
            result = ""
        End If
        Return result

    End Function
End Class


