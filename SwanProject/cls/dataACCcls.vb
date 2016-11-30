
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data
Imports System.Data.OleDb



Public Class dataACCcls
    Public dt As DataTable
    Private cmd As OleDbCommand
    Public conn As OleDbConnection
    Public Constring As String
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
    Sub openConn(ByVal connstring As String)
        conn = New OleDbConnection(connstring)
        Constring = connstring
    End Sub

    Function ExistsTable(ByVal Tablename As String)
        Dim SchemaTable As DataTable

        If conn.State = ConnectionState.Closed Then conn.Open()
        SchemaTable = conn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, Tablename})

        If SchemaTable.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
        conn.Close()
    End Function
    Function ExistsTable(ByVal Tablename As String, Connstr As String)
        Dim SchemaTable As DataTable
        Using conn As New OleDbConnection(Connstr)
            conn.Open()
            SchemaTable = conn.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, Tablename})

            If SchemaTable.Rows.Count <> 0 Then
                Return True
            Else
                Return False
            End If
        End Using

    End Function
    Public Sub QryDT(ByVal sql As String)
        If Constring = "" Then
            Constring = conn.ConnectionString
        End If
        '  Dim conn1 = New OleDbConnection(Constring)
        Try

            Using conn1 As New OleDbConnection(Constring)


                Dim da As OleDbDataAdapter

                Dim DS As New DataSet()
                If conn1.State = ConnectionState.Closed Then
                    conn1.Open()
                End If
                da = New OleDbDataAdapter(sql, conn1)
                da.Fill(DS, "temp")
                dt = DS.Tables("temp")

            End Using


            ' return dt;

        Catch ex As Exception
            '  Throw ex
            MsgBox(ex.Message)
        Finally
            '  conn1.Dispose()
        End Try
    End Sub
    Public Function QryDT(ByVal sql As String, Constring As String)

        '  Dim conn1 = New OleDbConnection(Constring)
        Try
            Dim dt As New DataTable
            Using conn1 As New OleDbConnection(Constring)


                Dim da As OleDbDataAdapter

                Dim DS As New DataSet()
                If conn1.State = ConnectionState.Closed Then
                    conn1.Open()
                End If
                da = New OleDbDataAdapter(sql, conn1)
                da.Fill(DS, "temp")
                dt = DS.Tables("temp")

            End Using


            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            '  conn1.Dispose()
        End Try
    End Function
    Public Function RunCommand(ByVal sql As String)
        'Try
        cmd = New OleDbCommand(sql, conn)
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return cmd.ExecuteNonQuery()
        conn.Close()

        ' Catch ex As Exception

        ' End Try
    End Function

    Public Function RunCommand(ByVal sql As String, Connstr As String, Optional StoreProc As Boolean = False)
        'Try
        Using conn As New OleDb.OleDbConnection


            conn.ConnectionString = Connstr
            conn.Open()

            Using cmd As New OleDb.OleDbCommand(sql, conn)
                If StoreProc Then
                    cmd.CommandType = CommandType.StoredProcedure
                End If


                Return cmd.ExecuteNonQuery()

            End Using
        End Using


        ' Catch ex As Exception

        ' End Try
    End Function
    Public Function ExScalar(ByVal sql As String) As String
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
        conn.Close()
    End Function
    Public Function ExScalar(ByVal sql As String, Connstr As String) As String
        Dim result As String

        Using conn As New OleDbConnection(Connstr)
            conn.Open()

            Using cmd As New OleDbCommand(sql, conn)
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
    Public Sub UpdateDA(sqlstr As String)

    End Sub
End Class


