Imports System.IO.Compression
Imports System.IO


Public Class autoFrm

    Dim balPath As String = "\\server\siamvb\checkbal.mdb"
    Dim dal As New dataACCcls
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try


            txtNowTime.Text = Now.ToString("HH:mm:ss")

            If Now.ToString("mmss") = "0000" And Now.ToString("HH") > "08" And Now.ToString("HH") <= "17" Then
                '                Dim frm As New ProgressFrm
                '                frm.Show()
                '                frm.PGB.Maximum = 3
                '                frm.PGB.Value = 0
                '                Try


                '                    dal.RunCommand("drop table tempbal" & Project.User, Project.md2_boi)
                '                    dal.RunCommand("drop table tempbal" & Project.User, Project.md2_tax)
                '                Catch ex As Exception

                '                End Try

                '                Dim sqlstr As String

                '                sqlstr = " select * into tempbal" & Project.User & " from (SELECT STOCK_CARD.S_PRDT" +
                '", STOCK_CARD.s_qty+ Sum(IIf(s_slip='we' And (stock.s_date)>=(STOCK_CARD.s_date),stock.s_qty,0))- Sum((IIf(s_slip='ma' And (stock.s_date)>=(STOCK_CARD.s_date),stock.s_qty,0)))+ Sum(IIf(s_slip='MB' And s_rea='B' And (stock.s_date)>=(STOCK_CARD.s_date),stock.s_qty,0)) AS QTY" +
                '" FROM STOCK_CARD LEFT JOIN stock On STOCK_CARD.S_PRDT=stock.S_PRDT " +
                '" GROUP BY STOCK_CARD.S_PRDT, STOCK_CARD.s_qty " +
                '" union " +
                '" SELECT STOCK.S_PRDT, Sum(IIf([s_slip]='WE',STOCK.s_qty,0)) - Sum(IIf([s_slip]='MA',STOCK.s_qty,0)) + Sum(IIf([s_slip]='MB' And [s_rea]='B',STOCK.s_qty,0)) AS MBB" +
                '" FROM STOCK LEFT JOIN STOCK_CARD ON STOCK.S_PRDT=STOCK_CARD.S_PRDT " +
                '" WHERE (((STOCK.S_DATE)>='20100101')) " +
                '" GROUP BY STOCK.S_PRDT,STOCK_CARD.S_PRDT " +
                '" HAVING (((STOCK_CARD.S_PRDT) Is Null)))"
                '                Try


                '                    frm.Text = "get data BOI"
                '                    dal.RunCommand(sqlstr, Project.md2_boi)
                '                    frm.PGB.Value += 1
                '                    frm.Text = "get data Tax"
                '                    dal.RunCommand(sqlstr, Project.md2_tax)
                '                    frm.PGB.Value += 1
                '                    sqlstr = "UPDATE prdt INNER JOIN tempbal" & Project.User & " as c ON prdt.p_prdt=c.s_prdt SET prdt.p_bal = c.qty;"
                '                    frm.Text = "Update BOI"
                '                    dal.RunCommand(sqlstr, Project.md2_boi)
                '                    frm.PGB.Value += 1
                '                    frm.Text = "Update Tax"
                '                    dal.RunCommand(sqlstr, Project.md2_tax)
                '                Catch ex As Exception

                '                Finally
                '                    frm.Close()
                '                End Try


                '                Try

                '                    dal.RunCommand("drop table tempbal" & Project.User, Project.md2_boi)
                '                    dal.RunCommand("drop table tempbal" & Project.User, Project.md2_tax)

                '                Catch ex As Exception

                '                End Try

                Dim pr As MDIParent1 = Me.ParentForm

                pr.UpdateBacklog()
                pr.UpdateBAL()
                pr.UpdateLOTQTY()
                pr.UpdateMAFile()
                pr.UpdateODQTY()
                txtLastUpdate.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")
            End If
            'Using conn As New OleDb.OleDbConnection(strAccess(balPath))
            '    conn.Open()
            '    Using cmd As New OleDb.OleDbCommand("stockCardboiqry", conn)

            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Parameters.Item("todate").Value = "99999999"

            '        cmd.ExecuteNonQuery()
            '    End Using
            'End Using
            '    prdt.UpdatePriceMI_PO()
            '    prdt.UpdateBacklogSQL("%")
            '    prdt.UpdateBalSQL("%")
            '    prdt.UpdatePrice()

            '    Dim probj As New PRcls
            '    probj.UpdatePRState()

            '    Lotobj.SetLOTPrice()
            '    txtLastUpdate.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")
            'ElseIf Now.ToString("HHmmss") = "210000" Then
            '    Dim s, z As String

            '    ' s = SaveFileDialog1.FileName
            '    z = pathBackup & "YCHERP - " & Now.ToString("yyyy-MM-dd") & ".BAK"

            '    s = z & ".BAK"
            '    If My.Computer.FileSystem.FileExists(s & ".gz") Then

            '        Exit Sub
            '    End If

            '    '   My.Computer.FileSystem.CreateDirectory(z)
            '    dataOBJ.QryCommand("backup database YCHERP to disk='" & z & "'")
            '    ' ZipFile.CreateFromDirectory(z, z & ".zip")
            '    Compress(z)
            '    My.Computer.FileSystem.DeleteFile(z)
            '    txtBackup.Text = Now.ToString("yyyy/MM/dd HH:mm:ss")
            'End If
        Catch ex As Exception
            lblErr.Text = Now.ToString("yyyy/MM/dd HH:mm:ss") & " : " & ex.Message
        End Try
    End Sub
    Private Sub Compress(path As String)
        ' Get the stream of the source file.

        Dim fi As New FileInfo(path)
        Using inFile As FileStream = fi.OpenRead()
            ' Compressing:
            ' Prevent compressing hidden and already compressed files.

            If (File.GetAttributes(fi.FullName) And FileAttributes.Hidden) _
                <> FileAttributes.Hidden And fi.Extension <> ".gz" Then
            ' Create the compressed file.
            Using outFile As FileStream = File.Create(fi.FullName + ".gz")
                Using Compress As GZipStream =
                        New GZipStream(outFile, CompressionMode.Compress)

                    ' Copy the source file into the compression stream.
                    inFile.CopyTo(Compress)

                    Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                                          fi.Name, fi.Length.ToString(), outFile.Length.ToString())

                End Using
            End Using
        End If
        End Using
    End Sub

    Private Sub autoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPRDTsql_Click(sender As Object, e As EventArgs) Handles btnPRDTsql.Click

    End Sub
End Class