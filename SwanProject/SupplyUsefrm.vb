Public Class SupplyUsefrm
    Dim dal As New dataACCcls
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If IsNumeric(txtCompare.Text) = False Then
            MsgBox("กรุณาใส่ตัวเลข")
            Exit Sub
        End If
        Dim sqlstr As String

        Try
            sqlstr = "drop table supplyuse"
            dal.RunCommand(sqlstr, Project.md2_boi)

        Catch ex As Exception

        End Try


        'sqlstr = "SELECT  Left([S_PRE],3) AS DEP,STOCK.S_PRDT"
        Dim mothnow, MonthBefore As Date
        mothnow = "01/" & txtMonth.Text.Substring(4, 2) & "/" & txtMonth.Text.Substring(0, 4)
        'sqlstr = sqlstr + " , Sum(IIf(STOCK.S_DATE Between '" & mothnow & "01' And '" & mothnow & "31',s_qty,0)) AS " & mothnow
        'sqlstr = "SELECT stock.DEP, stock.S_PRDT, stock.P_ENAME, stock.P_TNAME, stock.P_SPEC, Sum(IIf(S_DATE Like '200807*',s_qty,0)) AS 200807"
        sqlstr = "SELECT p_type,stock.DEP, stock.S_PRDT, stock.P_ENAME, stock.P_TNAME, stock.P_SPEC, Sum(IIf(S_DATE Like '" & txtMonth.Text & "%',[MA],0)) AS M" & txtMonth.Text


        Dim i As Integer = 1
        MonthBefore = mothnow
        Do While i < txtCompare.Text

            MonthBefore = MonthBefore.AddMonths(-1)
            sqlstr = sqlstr + " , Sum(IIf(S_DATE like '" & MonthBefore.ToString("yyyyMM") & "%' ,[MA],0)) As M" & MonthBefore.ToString("yyyyMM")
            i = i + 1
        Loop
        sqlstr = sqlstr + " , IIf([DB]='TAX',[BAL]) AS BALTAX, IIf([DB]='BOI',[BAL]) AS BALBOI, IIf([DB]='BOI',[BACKLOG]) AS BACKBOI, IIf([DB]='TAX',[BACKLOG]) AS BACKTAX, IIf([DB]='BOI',[P_LPRICE]) AS P_LPRICEBOI, IIf([DB]='TAX',[P_LPRICE]) AS P_LPRICETAX"
        sqlstr = sqlstr + " into supplyuse FROM (SELECT 'TAX' as DB,p_type,STOCK.S_PRDT,stock.s_code,IIf([s_slip] Like 'MA',[s_qty],0) AS MA, (IIf([s_slip] Like 'MB' and s_rea like 'B',[s_qty],0)) AS MBB, STOCK.S_DATE, Left(STOCK.S_PRE,3) AS DEP, prdt.P_ENAME, prdt.P_TNAME, prdt.P_SPEC, iif(stock.s_date like '" & txtMonth.Text & "%',prdt.P_BAL,0) as BAL, iif(stock.s_date like '" & txtMonth.Text & "%',prdt.P_BACKLOG,0) as BACKLOG ,iif(stock.s_date like '" & txtMonth.Text & "%', prdt.P_LPRICE,0) as P_LPRICE"
        sqlstr = sqlstr + " FROM STOCK LEFT JOIN prdt ON STOCK.S_PRDT = prdt.P_PRDT IN '\\server\pneumatic\md2.mdb' WHERE p_type not in ('AS','RM','FG') and  (((STOCK.S_DATE) between '" & MonthBefore.ToString("yyyyMM") & "01' And '" & txtMonth.Text & "31') AND ((STOCK.S_PRE) Between '21%' And '25%')) union"
        sqlstr = sqlstr + " SELECT 'BOI' as DB,p_type, STOCK.S_PRDT,stock.s_code,IIf([s_slip] Like 'MA',[s_qty],0) AS MA, (IIf([s_slip] Like 'MB' and s_rea like 'B',[s_qty],0)) AS MBB, STOCK.S_DATE, Left(STOCK.S_PRE,3) AS DEP, prdt.P_ENAME, prdt.P_TNAME, prdt.P_SPEC, iif(stock.s_date like '" & txtMonth.Text & "%',prdt.P_BAL,0) as BAL, iif(stock.s_date like '" & txtMonth.Text & "%',prdt.P_BACKLOG,0) as BACKLOG ,iif(stock.s_date like '" & txtMonth.Text & "%', prdt.P_LPRICE,0) as P_LPRICE  "
        sqlstr = sqlstr + " FROM STOCK LEFT JOIN prdt ON STOCK.S_PRDT = prdt.P_PRDT  WHERE p_type not in ('AS','RM','FG') and  (((STOCK.S_DATE) between '" & MonthBefore.ToString("yyyyMM") & "01' And '" & txtMonth.Text & "31') AND ((STOCK.S_PRE) Between '21%' And '25%'))) AS stock"
        sqlstr = sqlstr + " GROUP BY p_type,stock.DEP, stock.S_PRDT, stock.P_ENAME, stock.P_TNAME, stock.P_SPEC, stock.DB, IIf([DB]='TAX',[BAL]), IIf([DB]='BOI',[BAL]), IIf([DB]='BOI',[BACKLOG]), IIf([DB]='TAX',[BACKLOG]), IIf([DB]='BOI',[P_LPRICE]), IIf([DB]='TAX',[P_LPRICE])"
        'sqlstr = sqlstr + " HAVING (((Sum(IIf([S_DATE] Like '" & txttime & "%',[s_qty],0)))>0)) ORDER BY stock.DEP"



        dal.RunCommand(sqlstr, Project.md2_boi)


        sqlstr = "SELECT SupplyUse.DEP,P_type, SupplyUse.S_PRDT, SupplyUse.P_ENAME, SupplyUse.P_TNAME, SupplyUse.P_SPEC, Sum(SupplyUse.[M" & txtMonth.Text & "]) AS " & txtMonth.Text
        i = 1


        MonthBefore = mothnow
        Do While i < txtCompare.Text

            MonthBefore = MonthBefore.AddMonths(-1)

            sqlstr = sqlstr + " , iif(Sum(SupplyUse.[M" & MonthBefore.ToString("yyyyMM") & "]),Sum(SupplyUse.[M" & MonthBefore.ToString("yyyyMM") & "])) AS " & MonthBefore.ToString("yyyyMM")
            i = i + 1
        Loop

        sqlstr = sqlstr + " ,IIf(IsNull(Sum(SupplyUse.BALTAX)),Sum(SupplyUse.BALBOI),Sum(SupplyUse.BALTAX)) AS BAL, IIf(IsNull(Sum(SupplyUse.BACKTAX)),"
        sqlstr = sqlstr + " Sum(SupplyUse.BACKBOI),Sum(SupplyUse.BACKTAX)) AS BACKLOG"
        sqlstr = sqlstr + " , IIf(IsNull(Sum(SupplyUse.P_LPRICETAX)),Sum(SupplyUse.P_LPRICEBOI) ,Sum(SupplyUse.P_LPRICETAX)) AS LPRICE"

        sqlstr = sqlstr + " , IIf(IsNull(Sum([SupplyUse].[P_LPRICETAX])),Sum([SupplyUse].[P_LPRICEBOI]),Sum([SupplyUse].[P_LPRICETAX]))*Sum(SupplyUse.[M" & txtMonth.Text & "]) AS Total"

        sqlstr = sqlstr + " From SupplyUse GROUP BY SupplyUse.DEP,p_type, SupplyUse.S_PRDT, SupplyUse.P_ENAME, SupplyUse.P_TNAME, SupplyUse.P_SPEC"
        sqlstr = sqlstr + " Having (((Sum(SupplyUse.[M" & txtMonth.Text & "])) > 0))"
        sqlstr = sqlstr + " order by SupplyUse.DEP,IIf(IsNull(Sum([SupplyUse].[P_LPRICETAX])),Sum([SupplyUse].[P_LPRICEBOI]),Sum([SupplyUse].[P_LPRICETAX]))*Sum(SupplyUse.[M" & txtMonth.Text & "]) desc"
        'sqlstr = sqlstr + " order by  SupplyUse.DEP,SupplyUse.S_PRDT"


        DGV1.DataSource = dal.QryDT(sqlstr, Project.md2_boi)




        Try
            sqlstr = "drop table supplyuse"
            dal.RunCommand(sqlstr, Project.md2_boi)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim SaveFileDialog1 As New SaveFileDialog

        SaveFileDialog1.Filter = "Excel File|*.xlsx"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "SupplyUse" & txtMonth.Text
        ' SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.ShowDialog(Me)


        Dim excelexp As New ExporttoExcel_EP



        excelexp.CreateSheet(DGV1.DataSource, SaveFileDialog1.FileName, "SupplyUse")


    End Sub

    Private Sub txtMonth_TextChanged(sender As Object, e As EventArgs) Handles txtMonth.TextChanged

    End Sub

    Private Sub txtMonth_GotFocus(sender As Object, e As EventArgs) Handles txtMonth.GotFocus
        txtMonth.SelectAll()
    End Sub

    Private Sub SupplyUsefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        txtMonth.Text = Now.ToString("yyyyMM")
    End Sub
End Class