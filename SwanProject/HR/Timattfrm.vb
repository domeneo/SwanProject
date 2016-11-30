Imports System
Imports System.IO
Imports System.Data.SqlClient
Public Class Timattfrm
    Dim dtsql As New dataSQLcls

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Dim frmPGB As New ProgressFrm
        frmPGB.Show()

        Try
            ' Open the file using a stream reader.

            Dim opt As New OpenFileDialog
            opt.Multiselect = True
            If opt.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            frmPGB.PGB.Maximum = opt.FileNames.Count
            frmPGB.PGB.Value = 0
            Using conn As New SqlConnection(Project.swanSQL)
                conn.Open()
                For Each filename As String In opt.FileNames

                    frmPGB.PGB.Value += 1
                    Using sr As New StreamReader(filename)
                        Dim line As String
                        ' Read the stream to a string and write the string to the console.
                        line = sr.ReadToEnd()
                        Dim sqlstr As String = ""
                        Dim timestr As String = ""
                        For Each strline As String In line.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)



                            timestr = strline.Substring(14, 11)
                            Dim timeatt As String = ""
                            Try
                                timeatt = "20" + timestr.Substring(0, 2) & "-" & timestr.Substring(2, 2) & "-" & timestr.Substring(4, 2) & " " & timestr.Substring(7, 2) & ":" & timestr.Substring(9, 2) & ":00"
                            Catch ex As Exception

                            End Try
                            sqlstr += "insert into timeatt (t_dept,t_code,t_datestr,t_timestr,t_s1,t_state,t_datetime)"
                            sqlstr += " values('" & strline.Substring(0, 3) & "'"
                            sqlstr += " ,'" & strline.Substring(3, 4) & "'"
                            sqlstr += " ,'" & timestr.Substring(0, 6) & "'"
                            sqlstr += " ,'" & timestr.Substring(7, 4) & "'"
                            sqlstr += " ,'" & strline.Substring(26, 2) & "'"
                            sqlstr += " ,'" & strline.Substring(29, 1) & "'"
                            sqlstr += " ,'" & timeatt & "');"
                        Next
                        dtsql.conn = conn

                        dtsql.RunCommand("delete  from timeatt where t_datestr like '" & timestr.Substring(0, 6) & "'")
                        dtsql.RunCommand(sqlstr)

                    End Using
                Next
            End Using
        Catch ex As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(ex.Message)
        Finally
            frmPGB.Close()
        End Try
    End Sub
End Class