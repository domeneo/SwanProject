Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions
Public Class SKappDetailfrm
    Dim Dal As New dataACCcls
    Dim sqlstr As String
    Private Sub ReportBtn_Click(sender As Object, e As EventArgs) Handles ReportBtn.Click


        Dim dt, dtmemo As New DataTable

        sqlstr = "select * from exp_sk where e_skno like '590173'"
        dt = Dal.QryDT(sqlstr, Project.swanpath)
        Dim rpt As New ReportFrm
        Dim rpts As New rptSK



        Dim subreportName As String
        Dim subreportObject As SubreportObject
        Dim subreport As New ReportDocument()





        rpts.SetDataSource(dt)
        rpt.RPTview.ReportSource = rpts

        If TypeOf (rpts.ReportDefinition.ReportObjects.
            Item("SubReport1")) Is SubreportObject Then
            subreportObject = rpts.ReportDefinition.ReportObjects.
                Item("SubReport1")
            subreportName = subreportObject.SubreportName
            subreport = rpts.OpenSubreport(subreportName)



            sqlstr = "select E_SEQ,[E_MEMO],E_TCCSMR,E_MEMO2,E_NCSMR from [MEMO]  where E_SKNO like '590173' order by E_SEQ"

            dtmemo = Dal.QryDT(sqlstr, Project.swanpath)

            subreport.SetDataSource(dtmemo)
        End If


        rpt.ShowDialog(Me)
    End Sub
End Class