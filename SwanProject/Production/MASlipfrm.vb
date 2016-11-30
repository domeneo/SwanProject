Public Class MASlipfrm

    Dim dal As New dataACCcls
    Function getData()

        Dim pgb As New ProgressFrm
        Dim dt As DataTable
        Try
            pgb.Show()
            pgb.PGB.Maximum = 4
            pgb.PGB.Value = 0


            Dim sqlwhere As String

            If txtInlot.Text <> "" Then
                Dim inlot As String

                inlot = "'" & txtInlot.Text.Trim.Replace(vbCrLf, "','") & "'"
                If inlot.Contains(",") Then

                    sqlwhere = " where mc_lot in (" & inlot & ")"
                Else
                    sqlwhere = " where mc_lot like " & inlot & ""
                End If


            Else
                sqlwhere = " where  (mc_ma='' and (mc_close like '5' or mc_close like '')) or  mc_ma ='s'"

            End If


            Dim Sqlstr As String
            Sqlstr = "SELECT IIf([PRDT_BOI.P_USEDB] Is Null,'BOI',[PRDT_BOI.p_USEDB]) AS DB" +
",iif(DB like 'BOI',PRDT_BOI.P_PLACE,PRDT_TAX.P_PLACE) as PLACE,0 as page,0 as morder" +
", PRDT_BOI.P_ENAME, PRDT_BOI.P_SPEC, [MC_LOTQTY]*[b_QTY] AS QTY, PRDT_BOI.P_BAL as BOIBAL, PRDT_TAX.P_BAL as TAXBAL, PRDT_BOI.P_UNIT, BOM_BOI.B_SCODE,BOM_BOI.B_SCODE as B_SCODE2 ,mc_lot" +
",p2.P_SPEC as LOTENAME,mc_PRDT,MC_PRDT_THAI,MC_REA,MC_LOTQTY,MC_SKNO " +
        " FROM (PRDT_TAX RIGHT JOIN (PRDT_BOI RIGHT JOIN (BOM_BOI RIGHT JOIN LOT_BOI ON BOM_BOI.B_PCODE = LOT_BOI.MC_PRDT_THAI)" +
" ON PRDT_BOI.P_PRDT = BOM_BOI.B_SCODE) ON PRDT_TAX.P_PRDT = BOM_BOI.B_SCODE) left join prdt_boi as p2 on  p2.p_prdt=lot_boi.mc_prdt"
            ' Sqlstr += " where  (mc_ma='' and (mc_close like '5' or mc_close like '')) or  mc_ma ='s'" +



            'Sqlstr += " where  mc_lot like '3A2539'"

            Sqlstr += sqlwhere
            Sqlstr += " order by mc_lot,1,2,b_scode"

            If DBCB.Text = "TAX" Then

                Sqlstr = "SELECT 'TAX' AS DB" +
    ",PRDT_TAX.P_PLACE as PLACE,0 as page,0 as morder" +
    ", PRDT_TAX.P_ENAME, PRDT_TAX.P_SPEC, [MC_LOTQTY]*[b_QTY] AS QTY,'' as BOIBAL, PRDT_TAX.P_BAL as TAXBAL, PRDT_TAX.P_UNIT, BOM_TAX.B_SCODE,BOM_TAX.B_SCODE as B_SCODE2,mc_lot" +
    ",p2.P_SPEC as LOTENAME,mc_PRDT,MC_PRDT_THAI,MC_REA,MC_LOTQTY,MC_SKNO " +
            " FROM (PRDT_TAX RIGHT JOIN (BOM_TAX RIGHT JOIN LOT_TAX ON BOM_TAX.B_PCODE = LOT_TAX.MC_PRDT_THAI)  ON PRDT_TAX.P_PRDT = BOM_TAX.B_SCODE)  left join prdt_tax as p2 on  p2.p_prdt=lot_tax.mc_prdt "
                Sqlstr += sqlwhere
                Sqlstr += " order by mc_lot,1,2,b_scode"
            End If

            dt = dal.QryDT(Sqlstr, Project.swanpath)

            If dt.Rows.Count = 0 Then

                Return dt
                Exit Function
            End If


            Dim mPage, Morder As Integer
            mPage = 1
            Morder = 1

            Dim oldPLace, oldDB, oldLOT As String


            Try
                oldPLace = dt.Rows(0)("PLACE").ToString.Substring(0, 1)

            Catch ex As Exception
                oldPLace = ""
            End Try
            oldDB = dt.Rows(0)("DB").ToString
            oldLOT = dt.Rows(0)("mc_lot").ToString


            For Each dr As DataRow In dt.Rows
                Dim splace As String
                Try
                    splace = dr("PLACE").ToString.Substring(0, 1)

                Catch ex As Exception
                    splace = ""
                End Try

                If Morder > 12 Or splace <> oldPLace Or oldDB <> dr("DB").ToString Then
                    mPage += 1
                    Morder = 1
                End If
                If dr("mc_lot").ToString <> oldLOT Then
                    mPage = 1
                    Morder = 1

                End If

                If dr("B_SCODE").ToString = "" Then

                    MsgBox("LOT : " & dr("MC_PRDT_THAI").ToString & " NO BOM")
                    Exit Function
                End If

                dr("B_SCODE") = dr("B_SCODE").ToString().Substring(0, 4) & "-" & dr("B_SCODE").ToString().Substring(4, 4) & "-" & dr("B_SCODE").ToString().Substring(8, 3)
                oldPLace = splace
                oldDB = dr("DB").ToString

                oldLOT = dr("mc_lot").ToString
                dr("Page") = mPage
                dr("morder") = Morder
                Morder += 1
            Next


            Return dt

        Catch ex As Exception


        Finally
            pgb.Close()

        End Try
    End Function

    Function getLOT()

        Dim Sqlstr As String
        Sqlstr = "select * from lot_" & DBCB.Text
        Sqlstr += " where  (mc_ma='' and (mc_close like '5' or mc_close like '')) or  mc_ma ='s' order by mc_lot"
        Dim dt As DataTable
        dt = dal.QryDT(Sqlstr, Project.swanpath)
        Return dt
    End Function

    Dim PrintDT
    Private Sub MASlipfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV1.DataSource = getLOT()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        DGV1.DataSource = getLOT()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptF As New ReportFrm
        Dim RPT As New MAslipRPT_310

        Dim dt As New DataTable
        dt = getData()
        If dt Is Nothing Then

            MsgBox("Err")
            Exit Sub
        End If
        If dt.Rows.Count <= 0 Then
            MsgBox("No DATA")
            Exit Sub
        End If





        RPT.SetDataSource(dt)

        RPT.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait


        rptF.RPTview.ReportSource = RPT
        rptF.ShowDialog(Me)
        'If txtInlot.Text = "" Then

        ' If MsgBox("ต้องการ SET LOT เป็น Print แล้วหรือไม่", vbYesNo) Then
        ' Exit Sub

        Dim frmpgb As New ProgressFrm
            frmpgb.PGB.Value = 0
            frmpgb.Text = "กรุณารอสักครู่ กำลังUpdate MAFILE"

            frmpgb.Show()

        Dim sqlstr As String

            Dim LOT As String = ""
            For Each dr As DataRow In dt.DefaultView.ToTable(True, "MC_LOT").Rows

                If LOT <> "" Then
                    LOT += ",'" & dr("MC_LOT").ToString & "'"
                Else
                    LOT += "'" & dr("MC_LOT").ToString & "'"
                End If

            Next

            If LOT.Contains(",") Then

                LOT = " in (" & LOT & ")"

            Else
                LOT = " like " & LOT & ""
            End If



            sqlstr = "delete * from mafile where ma_code " & LOT

            dal.RunCommand(sqlstr, Project.md7_boi)
            dal.RunCommand(sqlstr, Project.md7_tax)



            sqlstr = "delete * from BOMFILE where B_LOT " & LOT

            dal.RunCommand(sqlstr, Project.md7_boi)
            dal.RunCommand(sqlstr, Project.md7_tax)

        frmpgb.PGB.Maximum = dt.Rows.Count + 1


        dal.RunCommand("update lot_" & DBCB.Text & " set mc_ma='*' where MC_LOT " & LOT, Project.swanpath)
        For Each dr As DataRow In dt.Rows




            sqlstr = "insert into MAFILE(MA_CODE,MA_PRDT,MA_SEQ,MA_REA,MA_DATE,MA_HAND,MA_QTY,MA_PLACE,MA_RQTY,MA_CSMR)"
                sqlstr = sqlstr + " values('" & dr("MC_LOT").ToString & "','" & dr("b_scode2").ToString & "','" & dr("page").ToString & "','" & dr("MC_REA").ToString & "','" & Now.ToString("yyyyMMdd") & "','225022',"
                sqlstr = sqlstr & "" & dr("QTY").ToString & ",'" & dr("PLACE").ToString & "',0,'     ')"
                If dr("DB").ToString = "BOI" Then
                    dal.RunCommand(sqlstr, Project.md7_boi)
                Else
                    dal.RunCommand(sqlstr, Project.md7_tax)
                End If
                'ãÊèBOM File
                sqlstr = "insert into BOMFILE(B_LOT,B_SCODE,B_QTY,B_USEDB,B_date)"
                sqlstr = sqlstr + " values('" & dr("MC_LOT").ToString & "','" & dr("b_scode2").ToString & "',"
                sqlstr = sqlstr & "" & dr("QTY").ToString & ",'" & dr("DB").ToString & "','" & Now.ToString("yyyyMMdd") & "')"

                If DBCB.Text = "BOI" Then
                    dal.RunCommand(sqlstr, Project.md7_boi)
                ElseIf DBCB.Text = "TAX" Then
                    dal.RunCommand(sqlstr, Project.md7_tax)
                End If
                frmpgb.PGB.Value += 1
            Next
            frmpgb.Close()
        ' End If
        '  End If


    End Sub
End Class