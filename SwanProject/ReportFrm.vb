Imports System.ComponentModel

Public Class ReportFrm

    Private Sub ReportFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' RPTview.ReportSource = Nothing
        'GC.Collect()
    End Sub

    Private Sub RPTview_Load(sender As Object, e As EventArgs) Handles RPTview.Load

    End Sub

    Private Sub ReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class