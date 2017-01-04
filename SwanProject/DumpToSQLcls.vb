Public Class DumpToSQLcls
    Dim dalAcc As New dataACCcls
    Dim dal As New dataSQLcls
    Sub DumptoSQL(table As String)
        Dim pgb As New ProgressFrm
        pgb.Show()
        pgb.PGB.Value = 0
        Dim sqlstr As String
        Try
            dal.RunCommand("delete from " & table, Project.swanSQL)
        Catch ex As Exception

        End Try

        pgb.PGB.Value += 1
        sqlstr = "insert into " & table & "_SQL select * from " & table
        dalAcc.RunCommand(sqlstr, Project.swanpath)
        pgb.Close()
    End Sub
    Sub DumptoACCESS(Sourcetable As String, DesTable As String)
        Dim pgb As New ProgressFrm
        pgb.Show()
        Dim sqlstr As String
        Try
            dalAcc.RunCommand("delete from " & DesTable, Project.swanSQL)
        Catch ex As Exception

        End Try

        pgb.PGB.Value += 1
        sqlstr = "insert into " & DesTable & " select * from " & Sourcetable
        dalAcc.RunCommand(sqlstr, Project.swanpath)
        pgb.Close()
    End Sub

    Public Sub Run()
        'Dim pgb As New ProgressFrm
        'pgb.Show()
        'pgb.PGB.Maximum = 5
        'pgb.PGB.Value = 0
        DumptoSQL("PRDT_BOI")
        ' pgb.PGB.Value += 1
        DumptoSQL("PRDT_TAX")
        '  pgb.PGB.Value += 1

        DumptoSQL("BOM_BOI")
        '  pgb.PGB.Value += 1
        DumptoSQL("BOM_TAX")
        ' pgb.PGB.Value += 1

        DumptoSQL("LOT_BOI")
        ' pgb.PGB.Value += 1
        DumptoSQL("LOT_TAX")
        ' pgb.PGB.Value += 1

        ' pgb.Close()
    End Sub
End Class
