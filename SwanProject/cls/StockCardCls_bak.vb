Imports System.Data.OleDb
Public Class StockCardCls
    Dim dt As New DataTable
    Dim dtc As New datacls
    Dim conn As New OleDbConnection
    Dim sqlstr As String
    Sub New(Pathdb As String)

        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & Pathdb
        conn.Open()
    End Sub
    Function NullZero(ByVal val As String) As Double

        If val = "" Then NullZero = 0 Else NullZero = val

    End Function
    Sub Getdata(ByVal DB As String)


        dtc.RunCommand(conn, "drop table tempSTOCK")

        'ข้อมูลเทส

        sqlstr = "SELECT * into tempSTOCK FROM ("
        sqlstr = sqlstr + " SELECT STOCK_" & DB & "_TEST.s_prdt & STOCK_" & DB & "_TEST.s_code & STOCK_" & DB & "_TEST.s_pre & STOCK_" & DB & "_TEST.s_rea & STOCK_" & DB & "_TEST.s_reades & STOCK_" & DB & "_TEST.s_qty   AS iKey, STOCK_" & DB & "_TEST.S_PRDT, STOCK_" & DB & "_TEST.S_DATE, STOCK_" & DB & "_TEST.S_CODE, STOCK_" & DB & "_TEST.S_SLIP, STOCK_" & DB & "_TEST.S_REA, STOCK_" & DB & "_TEST.S_READES, STOCK_" & DB & "_TEST.S_QTY, STOCK_" & DB & "_TEST.S_PRICE,STOCK_" & DB & "_TEST.S_KG, STOCK_" & DB & "_TEST.S_BQTY, STOCK_" & DB & "_TEST.S_BPRICE, STOCK_" & DB & "_TEST.S_BAMT"
        sqlstr = sqlstr + " FROM STOCK_CARD_" & DB & " RIGHT JOIN (STOCK_" & DB & "_TEST inner join MovePrdt_" & DB & " on STOCK_" & DB & "_TEST.s_prdt=MovePrdt_" & DB & ".prdt) ON STOCK_CARD_" & DB & ".S_PRDT = STOCK_" & DB & "_TEST.S_PRDT"
        sqlstr = sqlstr + " WHERE IIf(IsNull([STOCK_CARD_" & DB & "].[s_date]),'0',[STOCK_CARD_" & DB & "].[s_date])<=[STOCK_" & DB & "_TEST].[s_date]"


        sqlstr = sqlstr + " UNION SELECT STOCK_CARD_" & DB & ".S_PRDT & 'STOCKC' as iKey,STOCK_CARD_" & DB & ".S_PRDT, STOCK_CARD_" & DB & ".S_DATE,'STOCKCARD' AS scode"
        sqlstr = sqlstr + " , 'STOCKCARD' AS Expr1, '' AS Expr2,'' as ww, STOCK_CARD_" & DB & ".S_QTY, STOCK_CARD_" & DB & ".S_PRICE,'' AS KG, STOCK_CARD_" & DB & ".S_QTY"
        sqlstr = sqlstr + " , [S_PRICE] AS Expr3, STOCK_CARD_" & DB & ".S_AMOUNT FROM STOCK_CARD_" & DB & " inner join MovePrdt_" & DB & " on STOCK_CARD_" & DB & ".s_prdt=MovePrdt_" & DB & ".prdt"

        sqlstr = sqlstr + " UNION SELECT STOCK_ADJ_" & DB & ".PRDT & 'ADJ' as iKey,STOCK_ADJ_" & DB & ".PRDT, STOCK_ADJ_" & DB & ".DATE,'ADJ' AS scode"
        sqlstr = sqlstr + " , 'ADJ' AS Expr1, '' AS Expr2,'' as ww, STOCK_ADJ_" & DB & ".QTY, STOCK_ADJ_" & DB & ".PRICE,'' AS KG, STOCK_ADJ_" & DB & ".QTY"
        sqlstr = sqlstr + " , [PRICE] AS Expr3, STOCK_ADJ_" & DB & ".AMT FROM STOCK_ADJ_" & DB & " inner join MovePrdt_" & DB & " on STOCK_ADJ_" & DB & ".prdt=MovePrdt_" & DB & ".prdt"

        sqlstr = sqlstr + " ) AS tb1 order by s_prdt,s_date,s_slip desc,s_code"

        dtc.RunCommand(conn, sqlstr)

        'ข้อมูลจริง

        sqlstr = "SELECT * into tempSTOCK FROM ("
        sqlstr = sqlstr + " SELECT STOCK_" & DB & ".s_prdt & STOCK_" & DB & ".s_code & STOCK_" & DB & ".s_pre & STOCK_" & DB & ".s_rea & STOCK_" & DB & ".s_reades & STOCK_" & DB & ".s_qty   AS iKey, STOCK_" & DB & ".S_PRDT, STOCK_" & DB & ".S_DATE, STOCK_" & DB & ".S_CODE, STOCK_" & DB & ".S_SLIP, STOCK_" & DB & ".S_REA, STOCK_" & DB & ".S_READES, STOCK_" & DB & ".S_QTY, STOCK_" & DB & ".S_PRICE,STOCK_" & DB & ".S_KG, STOCK_" & DB & ".S_BQTY, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_BAMT"
        sqlstr = sqlstr + " FROM STOCK_CARD_" & DB & " RIGHT JOIN (STOCK_" & DB & " inner join MovePrdt_" & DB & " on STOCK_" & DB & ".s_prdt=MovePrdt_" & DB & ".prdt) ON STOCK_CARD_" & DB & ".S_PRDT = STOCK_" & DB & ".S_PRDT"
        sqlstr = sqlstr + " WHERE IIf(IsNull([STOCK_CARD_" & DB & "].[s_date]),'0',[STOCK_CARD_" & DB & "].[s_date])<=[STOCK_" & DB & "].[s_date]"


        sqlstr = sqlstr + " UNION SELECT STOCK_CARD_" & DB & ".S_PRDT & 'STOCKC' as iKey,STOCK_CARD_" & DB & ".S_PRDT, STOCK_CARD_" & DB & ".S_DATE,'STOCKCARD' AS scode"
        sqlstr = sqlstr + " , 'STOCKCARD' AS Expr1, '' AS Expr2,'' as ww, STOCK_CARD_" & DB & ".S_QTY, STOCK_CARD_" & DB & ".S_PRICE,'' AS KG, STOCK_CARD_" & DB & ".S_QTY"
        sqlstr = sqlstr + " , [S_PRICE] AS Expr3, STOCK_CARD_" & DB & ".S_AMOUNT FROM STOCK_CARD_" & DB & " inner join MovePrdt_" & DB & " on STOCK_CARD_" & DB & ".s_prdt=MovePrdt_" & DB & ".prdt"

        sqlstr = sqlstr + " UNION SELECT STOCK_ADJ_" & DB & ".PRDT & 'ADJ' as iKey,STOCK_ADJ_" & DB & ".PRDT, STOCK_ADJ_" & DB & ".DATE,'ADJ' AS scode"
        sqlstr = sqlstr + " , 'ADJ' AS Expr1, '' AS Expr2,'' as ww, STOCK_ADJ_" & DB & ".QTY, STOCK_ADJ_" & DB & ".PRICE,'' AS KG, STOCK_ADJ_" & DB & ".QTY"
        sqlstr = sqlstr + " , [PRICE] AS Expr3, STOCK_ADJ_" & DB & ".AMT FROM STOCK_ADJ_" & DB & " inner join MovePrdt_" & DB & " on STOCK_ADJ_" & DB & ".prdt=MovePrdt_" & DB & ".prdt"

        sqlstr = sqlstr + " ) AS tb1 order by s_prdt,s_date,s_slip desc,s_code"



        sqlstr = "ALTER TABLE tempSTOCK ADD PRIMARY KEY (iKey)"
        dtc.RunCommand(conn, sqlstr)



    End Sub
    Function UpPriceComplte(ByVal DB As String) As DataTable
        Getdata(DB)

        UpdatePrice()

        UpdatetoServer(DB)
        Return dt

    End Function



    Sub UpdatePrice_bak()

        sqlstr = "SELECT * from tempSTOCK order by s_prdt,s_date,s_slip desc,s_code"


        Dim da As New OleDb.OleDbDataAdapter(sqlstr, conn)
        'Dim ds As New DataSet
        'da.Fill(ds, "tb2") 
        da.Fill(dt)
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        da.UpdateCommand = cb.GetUpdateCommand()
        da.InsertCommand = cb.GetInsertCommand()
        da.DeleteCommand = cb.GetDeleteCommand()

        da.UpdateCommand.UpdatedRowSource = UpdateRowSource.None
        da.InsertCommand.UpdatedRowSource = UpdateRowSource.None
        da.DeleteCommand.UpdatedRowSource = UpdateRowSource.None

        'dtc.QryDT(conn, sqlstr)
        'dt = dtc.dt
        Dim BEFprdt As String
        Dim BEFbal, befBprice, BEFamount, befPrice As Double
        Dim price, amount As Double
        BEFprdt = ""
        For Each dr As DataRow In dt.Rows
            If BEFprdt <> dr("s_prdt") Then

                BEFbal = 0
                befPrice = 0
                befBprice = 0
                BEFamount = 0
            End If
            'If dr("ikey") = "R1010060500735108BML10.5" Then Stop

            If dr("s_slip") = "WE" Then

                dr("s_price") = Format(dr("s_price"), "00.00")
                dr("s_BQTY") = CDbl(BEFbal + dr("s_qty")).ToString("00.0000")
                If NullZero(dr("s_kg").ToString) > 0 Then

                    amount = dr("s_kg")
                Else
                    amount = Format(dr("S_PRICE") * dr("s_qty"), "00.00")
                End If

                If BEFbal < 0.001 Then BEFamount = 0

                dr("S_BAMT") = Format(BEFamount + amount, "00.00")
                dr("S_BPRICE") = Format(dr("S_BAMT") / dr("s_BQTY"), "00.00")
            End If
            If dr("s_slip") = "MA" Then

                If BEFbal - dr("s_qty") <= 0.001 And BEFbal - dr("s_qty") >= -0.001 Then
                    dr("s_BQTY") = 0

                Else

                    dr("s_BQTY") = CDbl(BEFbal - dr("s_qty")).ToString("00.0000")
                End If

                If BEFbal < 0.001 Then BEFamount = 0

                If dr("s_BQTY") > 0 Then
                    dr("S_PRICE") = Format(BEFamount / BEFbal, "00.00")
                    amount = (dr("S_PRICE") * dr("s_qty"))
                    dr("S_BAMT") = Format(BEFamount - amount, "00.00")
                    dr("S_BPRICE") = Format(dr("S_BAMT") / dr("s_BQTY"), "00.00")

                Else
                    dr("S_PRICE") = Format(befBprice, "00.00")
                    dr("S_BPRICE") = 0
                    dr("S_BAMT") = BEFamount

                End If
            End If
            If dr("s_slip") = "MB" Then
                If befBprice = 0 Then befBprice = befPrice

                If dr("s_rea") = "B" Then
                    dr("s_BQTY") = CDbl(BEFbal + dr("s_qty")).ToString("00.0000")

                    dr("S_PRICE") = befBprice.ToString("0.00")
                    amount = (dr("S_PRICE") * dr("s_qty"))
                    If BEFbal < 0.001 Then BEFamount = 0
                    dr("S_BAMT") = (BEFamount + amount).ToString("0.00")
                    dr("S_BPRICE") = CDbl(dr("S_BAMT") / dr("s_BQTY")).ToString("0.00")

                Else

                    dr("s_BQTY") = BEFbal

                    dr("S_PRICE") = befBprice.ToString("00.00")
                    dr("S_BPRICE") = befBprice.ToString("00.00")
                    dr("S_BAMT") = BEFamount.ToString("00.00")
                End If

            End If
            BEFprdt = dr("s_prdt")
            befPrice = dr("s_price")
            BEFbal = Format(dr("s_BQTY"), "00.00")
            befBprice = Format(dr("S_BPRICE"), "00.00")
            BEFamount = Format(dr("S_BAMT"), "00.00")
        Next


        ' da.UpdateBatchSize = 10
        da.Update(dt)
    End Sub
    Sub UpdatePrice()

        sqlstr = "SELECT * from tempSTOCK order by s_prdt,s_date,s_slip desc,s_code"


        Dim da As New OleDb.OleDbDataAdapter(sqlstr, conn)
        'Dim ds As New DataSet
        'da.Fill(ds, "tb2") 
        da.Fill(dt)
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        da.UpdateCommand = cb.GetUpdateCommand()
        da.InsertCommand = cb.GetInsertCommand()
        da.DeleteCommand = cb.GetDeleteCommand()

        da.UpdateCommand.UpdatedRowSource = UpdateRowSource.None
        da.InsertCommand.UpdatedRowSource = UpdateRowSource.None
        da.DeleteCommand.UpdatedRowSource = UpdateRowSource.None

        'dtc.QryDT(conn, sqlstr)
        'dt = dtc.dt
        Dim BEFprdt As String
        Dim BEFbal, befBprice, BEFamount, befPrice As Double
        Dim price, amount As Double
        BEFprdt = ""
        For Each dr As DataRow In dt.Rows
            If BEFprdt <> dr("s_prdt") Then

                BEFbal = 0
                befPrice = 0
                befBprice = 0
                BEFamount = 0
            End If
            ' If dr("s_date") = "20110730" Then Stop

            If dr("s_slip") = "WE" Then

                If dr("s_rea") = "D" Then
                    dr("s_BQTY") = CDbl(BEFbal + dr("s_qty")).ToString("00.0000")

                    dr("S_PRICE") = befBprice.ToString("0.00")
                    If dr("S_PRICE") = 0 Then dr("S_PRICE") = befPrice.ToString("0.00")
                    amount = (dr("S_PRICE") * dr("s_qty"))
                    If BEFbal < 0.001 Then BEFamount = 0
                    dr("S_BAMT") = (BEFamount + amount).ToString("0.00")
                    dr("S_BPRICE") = CDbl(dr("S_BAMT") / dr("s_BQTY")).ToString("0.00")


                Else

                    dr("s_price") = Format(dr("s_price"), "00.00")
                    dr("s_BQTY") = CDbl(BEFbal + dr("s_qty")).ToString("00.0000")
                    If NullZero(dr("s_kg").ToString) > 0 Then

                        amount = dr("s_kg")
                    Else
                        amount = Format(dr("S_PRICE") * dr("s_qty"), "00.00")
                    End If

                    If BEFbal < 0.001 Then BEFamount = 0


                End If

                'If dr("S_date") = "20121022" Then Stop
                dr("S_BAMT") = Format(BEFamount + amount, "00.00")
                If dr("s_BQTY") = 0 Then
                    dr("S_BPRICE") = 0
                Else
                    dr("S_BPRICE") = Format(dr("S_BAMT") / dr("s_BQTY"), "00.00")

                End If
            End If
            If dr("s_slip") = "MA" Then

                If BEFbal - dr("s_qty") <= 0.001 And BEFbal - dr("s_qty") >= -0.001 Then
                    dr("s_BQTY") = 0

                Else

                    dr("s_BQTY") = CDbl(BEFbal - dr("s_qty")).ToString("00.0000")
                End If

                If BEFbal < 0.001 Then BEFamount = 0

                If dr("s_BQTY") > 0 Then
                    dr("S_PRICE") = Format(BEFamount / BEFbal, "00.00")
                    amount = (dr("S_PRICE") * dr("s_qty"))
                    dr("S_BAMT") = Format(BEFamount - amount, "00.00")
                    dr("S_BPRICE") = Format(dr("S_BAMT") / dr("s_BQTY"), "00.00")

                Else
                    dr("S_PRICE") = Format(befBprice, "00.00")
                    dr("S_BPRICE") = 0
                    dr("S_BAMT") = BEFamount

                End If
            End If
            If dr("s_slip") = "MB" Then
                If befBprice = 0 Then befBprice = befPrice

                If dr("s_rea") = "B" Then
                    dr("s_BQTY") = CDbl(BEFbal + dr("s_qty")).ToString("00.0000")

                    dr("S_PRICE") = befBprice.ToString("0.00")
                    amount = (dr("S_PRICE") * dr("s_qty"))
                    If BEFbal < 0.001 Then BEFamount = 0
                    dr("S_BAMT") = (BEFamount + amount).ToString("0.00")
                    dr("S_BPRICE") = CDbl(dr("S_BAMT") / dr("s_BQTY")).ToString("0.00")

                Else

                    dr("s_BQTY") = BEFbal

                    ' dr("S_PRICE") = befBprice.ToString("00.00")
                    dr("S_BPRICE") = befBprice.ToString("00.00")
                    dr("S_PRICE") = 0
                    'dr("S_BPRICE") = 0
                    dr("S_BAMT") = BEFamount.ToString("00.00")
                End If

            End If

            'สุดท้ายของทั้งหมด
            BEFprdt = dr("s_prdt")
            befPrice = dr("s_price")
            BEFbal = Format(dr("s_BQTY"), "00.0000")
            befBprice = Format(dr("S_BPRICE"), "00.00")
            BEFamount = Format(dr("S_BAMT"), "00.00")
        Next


        ' da.UpdateBatchSize = 10
        da.Update(dt)
    End Sub
    Sub UpdatetoServer(ByVal DB As String)
        'update Test
        sqlstr = "UPDATE STOCK_" & DB & "_test INNER JOIN tempstock ON (tempstock.ikey=STOCK_" & DB & "_TEST.s_prdt & STOCK_" & DB & "_TEST.s_code & STOCK_" & DB & "_TEST.s_pre  & STOCK_" & DB & "_TEST.s_rea & STOCK_" & DB & "_TEST.s_reades & STOCK_" & DB & "_TEST.s_qty) SET "
        sqlstr = sqlstr + " STOCK_" & DB & "_test.s_price = [tempstock.s_price]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_test.s_bqty = [tempstock.s_bqty]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_test.s_bprice = [tempstock.s_bprice]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_test.s_bamt = [tempstock.s_bamt]"
        dtc.RunCommand(conn, sqlstr)

        'update จริง
        sqlstr = "UPDATE STOCK_" & DB & " INNER JOIN tempstock ON (tempstock.ikey=STOCK_" & DB & ".s_prdt & STOCK_" & DB & ".s_code & STOCK_" & DB & ".s_pre  & STOCK_" & DB & ".s_rea & STOCK_" & DB & ".s_reades & STOCK_" & DB & ".s_qty) SET "
        sqlstr = sqlstr + " STOCK_" & DB & ".s_price = [tempstock.s_price]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bqty = [tempstock.s_bqty]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bprice = [tempstock.s_bprice]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bamt = [tempstock.s_bamt]"


    End Sub
    Function GetStocksummary(ByVal DB As String, ByVal iDate As String) As DataTable



        sqlstr = "SELECT tb2.S_PRDT, tb2.MaxDATE, STOCK_" & DB & "_TEST.S_CODE, STOCK_" & DB & "_TEST.S_DATE, STOCK_" & DB & "_TEST.S_SLIP, STOCK_" & DB & "_TEST.S_REA, STOCK_" & DB & "_TEST.S_PRE, STOCK_" & DB & "_TEST.S_BQTY, STOCK_" & DB & "_TEST.S_BPRICE, STOCK_" & DB & "_TEST.S_BAMT, STOCK_SA.A_DATE, STOCK_SA.A_amt, iif( STOCK_" & DB & "_TEST.S_DATE>= STOCK_SA.a_DATE or isnull( STOCK_SA.A_DATE), STOCK_" & DB & "_TEST.S_BQTY, STOCK_SA.a_QTY) AS QTY, iif( STOCK_" & DB & "_TEST.S_DATE>= STOCK_SA.A_DATE or isnull( STOCK_SA.a_DATE),IIF( STOCK_" & DB & "_TEST.S_BPRICE>0, STOCK_" & DB & "_TEST.S_BPRICE, STOCK_" & DB & "_TEST.S_PRICE), STOCK_SA.a_PRICE) AS Price, iif( STOCK_" & DB & "_TEST.S_DATE>= STOCK_SA.a_DATE or isnull( STOCK_SA.a_DATE), STOCK_" & DB & "_TEST.S_BAMT"
        sqlstr = sqlstr & " , STOCK_SA.a_amt) AS AMT INTO testSTOCKCARD_" & DB & ""
        sqlstr = sqlstr & " FROM (SELECT STOCK_CARD_" & DB & ".S_PRDT, IIf([date]>[s_date],[date],[s_date]) AS A_DATE"
        sqlstr = sqlstr & " , IIf([date]>[s_date],[qty],[s_qty]) AS A_qty"
        sqlstr = sqlstr & " , IIf([date]>[s_date],[price],[s_price]) AS A_price"
        sqlstr = sqlstr & " , IIf([date]>[s_date],[amt],[s_amount]) AS A_amt"
        sqlstr = sqlstr & " FROM STOCK_CARD_" & DB & " LEFT JOIN STOCK_ADJ_" & DB & " ON STOCK_CARD_" & DB & ".S_PRDT = STOCK_ADJ_" & DB & ".PRDT"
        sqlstr = sqlstr & " union SELECT STOCK_CARD_" & DB & ".S_PRDT, IIf([date]>[s_date],[date],[s_date]) AS A_DATE"
        sqlstr = sqlstr & " , IIf([date]>[s_date],[qty],[s_qty]) AS A_qty"
        sqlstr = sqlstr & " , IIf([date]>[s_date],[price],[s_price]) AS A_price"
        sqlstr = sqlstr & " , IIf([date]>[s_date],[amt],[s_amount]) AS A_amt"
        sqlstr = sqlstr & " FROM STOCK_CARD_" & DB & " right JOIN STOCK_ADJ_" & DB & " ON STOCK_CARD_" & DB & ".S_PRDT = STOCK_ADJ_" & DB & ".PRDT"
        sqlstr = sqlstr & " ) AS STOCK_SA RIGHT JOIN (STOCK_" & DB & "_TEST INNER JOIN (SELECT tb1.S_PRDT, Max(tb1.S_DATE & SLIP  & s_code & s_rea & s_reades & s_pre) AS MaxDATE "
        sqlstr = sqlstr & " FROM (SELECT STOCK_" & DB & "_TEST.S_PRDT, STOCK_" & DB & "_TEST.S_DATE,s_code,iif(s_slip like 'we','a',iif(s_slip like 'mb','b','c')) as SLIP,s_rea,s_reades,s_pre, STOCK_" & DB & "_TEST.S_BQTY, STOCK_" & DB & "_TEST.S_BPRICE, STOCK_" & DB & "_TEST.S_BAMT"
        sqlstr = sqlstr & " FROM STOCK_" & DB & "_TEST   WHERE STOCK_" & DB & "_TEST.S_DATE<='20121231'"
        sqlstr = sqlstr & " ) AS tb1 left JOIN BAL2012_" & DB & " ON tb1.S_PRDT = BAL2012_" & DB & ".prdt"
        sqlstr = sqlstr & " GROUP BY tb1.S_PRDT) AS tb2 ON (STOCK_" & DB & "_TEST.S_PRDT = tb2.S_PRDT) AND (STOCK_" & DB & "_TEST.S_DATE &  iif(s_slip like 'we','a',iif(s_slip like 'mb','b','c')) &  STOCK_" & DB & "_TEST.S_code & s_rea & s_reades & s_pre = tb2.MaxDATE)) ON STOCK_SA.S_PRDT = STOCK_" & DB & "_TEST.S_PRDT;"
        dtc.RunCommand(conn, sqlstr)



        sqlstr = " SELECT testSTOCKCARD_" & DB & ".S_PRDT, PRDT_" & DB & ".P_ENAME, PRDT_" & DB & ".P_SPEC, Format([QTY],'#,##0.00') AS Quantity, Format([Price],'#,##0.00') AS UnitePrice, Format([AMT],'#,##0.00') AS Amount"
        sqlstr = sqlstr & " FROM PRDT_" & DB & " RIGHT JOIN testSTOCKCARD_" & DB & " ON PRDT_" & DB & ".P_PRDT = testSTOCKCARD_" & DB & ".S_PRDT"
        sqlstr = sqlstr & " WHERE (((testSTOCKCARD_" & DB & ".QTY)>0))"
        sqlstr = sqlstr & " ORDER BY testSTOCKCARD_" & DB & ".S_PRDT;"
        dtc.QryDT(conn, sqlstr)

        Return dt

    End Function
End Class
