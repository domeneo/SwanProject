
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient



Public Class dataSQLcls
    Public dt As DataTable
    Private cmd As SqlCommand
    Public conn As SqlConnection
    Public Constr As String
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
    Sub openConn(ByVal connstring As String)
        conn = New SqlConnection(connstring)
    End Sub

    Function ExistsTable(ByVal Tablename As String)
        Dim SchemaTable As DataTable

        If conn.State = ConnectionState.Closed Then conn.Open()
        SchemaTable = conn.GetSchema(Tablename)
      
        If SchemaTable.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub QryDT(ByVal sql As String)

        If Constr = "" Then
            Constr = conn.ConnectionString
        End If
        Dim Conn1 As New SqlConnection(Constr)
        Try


            Dim da As SqlDataAdapter

            Dim DS As New DataSet()
            If Conn1.State = ConnectionState.Closed Then
                Conn1.Open()
            End If
            da = New SqlDataAdapter(sql, Conn1)
            da.Fill(DS, "temp")
            dt = DS.Tables("temp")
            ' return dt;

        Catch ex As Exception

            Throw ex
        Finally
            Conn1.Dispose()
        End Try
    End Sub

    Public Function QryDT(ByVal sql As String, Connstr As String)

        Try
            Using Conn1 As New SqlConnection(Connstr)



                If Conn1.State = ConnectionState.Closed Then
                    Conn1.Open()
                End If

                Using da As New SqlDataAdapter(sql, Conn1)

                    Dim DS As New DataSet()


                    da.Fill(DS, "temp")
                    Return DS.Tables("temp")
                End Using


                ' return dt;
            End Using
        Catch ex As Exception

            Throw ex
        Finally

        End Try
    End Function
    Public Sub RunCommand(ByVal sql As String, connstr As String)
        Try
            Using conn As New SqlConnection(connstr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)

                    cmd.ExecuteNonQuery()

                End Using



            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RunCommand(ByVal sql As String)
        Try
            cmd = New SqlCommand(sql, conn)
            cmd.Connection = conn
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function ExScalar(ByVal sql As String) As String
        Dim result As String
        cmd = New SqlCommand(sql, conn)
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
    Public Function ExScalar(ByVal sql As String, Connstr As String) As String
        Dim result As String

        Using conn As New SqlConnection(Connstr)
            conn.Open()

            Using cmd As New SqlCommand(sql, conn)

                Dim obj As [Object] = cmd.ExecuteScalar()
                If obj IsNot Nothing Then
                    result = obj.ToString()
                Else
                    result = ""
                End If
                Return result


            End Using

        End Using


    End Function
End Class


