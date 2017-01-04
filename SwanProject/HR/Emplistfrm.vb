Imports System.Data.SqlClient
Public Class Emplistfrm
    Dim dt As New DataTable
    Dim sqlstr As String
    Dim datasql As New dataSQLcls
    Sub FilterDV()
        Dim exp As String
        If txtname.Text <> "" Then exp += "and [EmpFName] like '" & txtname.Text & "%'"
        If txtcode.Text <> "" Then exp += "and [EMPID] like '" & txtcode.Text & "%'"
        If txtTname.Text <> "" Then exp += "and [EmpFNameT] like '" & txtTname.Text & "%'"
        If exp <> "" Then
            exp = exp.Substring(4)
            Dim rows = dt.Select(exp)
            If rows.Any Then
                DGV1.DataSource = rows.CopyToDataTable
            Else
                DGV1.DataSource = Nothing
            End If
        Else
            DGV1.DataSource = dt
        End If


    End Sub
    Sub Loadata()
        sqlstr = "SELECT       [EmpID] ,[EmpFNameT],[EmpLNameT],[EmpFName]  ,[EmpLName]"
        sqlstr += "  FROM [HR-SWAN].[dbo].[Employee]"
        dt = datasql.QryDT(sqlstr, Project.swanSQL)



    End Sub
    Private Sub Emplistfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadata()
        FilterDV()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        FilterDV()
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        FilterDV()
    End Sub

    Private Sub txtTname_TextChanged(sender As Object, e As EventArgs) Handles txtTname.TextChanged
        FilterDV()
    End Sub
End Class