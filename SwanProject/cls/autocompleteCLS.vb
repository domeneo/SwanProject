Public Class autocompleteCLS


    Sub AutoCompleteTextBox(ByVal tb As TextBox, ByVal dt As DataTable)
        tb.AutoCompleteMode = AutoCompleteMode.Suggest

        tb.AutoCompleteCustomSource.Clear()
        tb.AutoCompleteSource = AutoCompleteSource.None


        Dim pgb As New ProgressFrm
        pgb.PGB.Maximum = dt.Rows.Count + 1
        pgb.PGB.Value = 0
        pgb.Show()
        pgb.PGB.Value += 1
        For Each dr As DataRow In dt.Rows
            If Not dr(0) Is DBNull.Value Then
                tb.AutoCompleteCustomSource.Add(dr(0))

            End If
            'pgb.PGB.Value += 1
        Next
        pgb.PGB.Value += 1
        pgb.Close()
        tb.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
End Class
