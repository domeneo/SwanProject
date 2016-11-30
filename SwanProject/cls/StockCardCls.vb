Imports System.Data.OleDb
Public Class StockCardCls
    Dim dt As New DataTable
    Dim dtc As New datacls
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=\\server\siamvb\webstockcard.mdb")
    Dim sqlstr As String
    Dim dateC As DateCls
    Dim NullC As NullCLS
    Public OldData As Boolean
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
    Function NullZero(ByVal val As String) As Double

        If val = "" Then NullZero = 0 Else NullZero = val

    End Function
    Sub New(Pathdb As String)

        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & Pathdb
        conn.Open()
    End Sub

    Sub PrePRDT(ByVal DB As String, ByVal whereArea As String)
        Try
            dtc.RunCommand(conn, "drop table tempPRDT")
        Catch ex As Exception
        End Try

        sqlstr = "select distinct P_prdt as prdt into tempPRDT from PRDT_" & DB
        If whereArea <> "" Then sqlstr = sqlstr + " where " & whereArea
        sqlstr = sqlstr + " order by P_prdt"

        dtc.RunCommand(conn, sqlstr)
    End Sub
    Sub Getdata(ByVal DB As String)

        Try
            dtc.RunCommand(conn, "drop table tempSTOCK")

        Catch ex As Exception

        End Try

        'ข้อมูลจริง test

        sqlstr = "SELECT * into tempSTOCK FROM ("
        sqlstr = sqlstr + " SELECT  s_ID,STOCK_" & DB & "_TEST.s_prdt & STOCK_" & DB & "_TEST.s_code & STOCK_" & DB & "_TEST.s_pre & STOCK_" & DB & "_TEST.s_rea & STOCK_" & DB & "_TEST.s_reades & STOCK_" & DB & "_TEST.s_qty & S_ID   AS iKey, STOCK_" & DB & "_TEST.S_PRDT, STOCK_" & DB & "_TEST.S_DATE, STOCK_" & DB & "_TEST.S_CODE, STOCK_" & DB & "_TEST.S_SLIP, STOCK_" & DB & "_TEST.S_REA, STOCK_" & DB & "_TEST.S_READES, STOCK_" & DB & "_TEST.S_QTY, STOCK_" & DB & "_TEST.S_PRICE,STOCK_" & DB & "_TEST.S_KG, STOCK_" & DB & "_TEST.S_BQTY, STOCK_" & DB & "_TEST.S_BPRICE, STOCK_" & DB & "_TEST.S_BAMT"
        sqlstr = sqlstr + " FROM STOCK_CARD_" & DB & " RIGHT JOIN (STOCK_" & DB & "_TEST inner join tempPrdt on STOCK_" & DB & "_TEST.s_prdt=tempPrdt.prdt) ON STOCK_CARD_" & DB & ".S_PRDT = STOCK_" & DB & "_TEST.S_PRDT"
        sqlstr = sqlstr + " WHERE IIf(IsNull([STOCK_CARD_" & DB & "].[s_date]),'0',[STOCK_CARD_" & DB & "].[s_date])<=[STOCK_" & DB & "_TEST].[s_date]"

        sqlstr = sqlstr + " UNION SELECT S_PRDT & 'SC',STOCK_CARD_" & DB & ".S_PRDT & 'STOCKC' as iKey,STOCK_CARD_" & DB & ".S_PRDT, STOCK_CARD_" & DB & ".S_DATE,'STOCKCARD' AS scode"
        sqlstr = sqlstr + " , 'STOCKCARD' AS Expr1, '' AS Expr2,'' as ww, STOCK_CARD_" & DB & ".S_QTY, STOCK_CARD_" & DB & ".S_PRICE,'' AS KG, STOCK_CARD_" & DB & ".S_QTY"
        sqlstr = sqlstr + " , [S_PRICE] AS Expr3, STOCK_CARD_" & DB & ".S_AMOUNT FROM STOCK_CARD_" & DB & " inner join tempPrdt on STOCK_CARD_" & DB & ".s_prdt=tempPrdt.prdt"

        sqlstr = sqlstr + " UNION SELECT STOCK_ADJ_" & DB & ".PRDT & 'ADJ',STOCK_ADJ_" & DB & ".PRDT & 'ADJ' as iKey,STOCK_ADJ_" & DB & ".PRDT, STOCK_ADJ_" & DB & ".DATE,'ADJ' AS scode"
        sqlstr = sqlstr + " , 'ADJ' AS Expr1, '' AS Expr2,'' as ww, STOCK_ADJ_" & DB & ".QTY, STOCK_ADJ_" & DB & ".PRICE,'' AS KG, STOCK_ADJ_" & DB & ".QTY"
        sqlstr = sqlstr + " , [PRICE] AS Expr3, STOCK_ADJ_" & DB & ".AMT FROM STOCK_ADJ_" & DB & " inner join tempPrdt on STOCK_ADJ_" & DB & ".prdt=tempPrdt.prdt"

        sqlstr = sqlstr + " ) AS tb1 order by s_prdt,s_date,s_slip desc,s_code"
        dtc.RunCommand(conn, sqlstr)

        'ข้อมูลจริง

        sqlstr = "SELECT * into tempSTOCK FROM ("
        sqlstr = sqlstr + " SELECT  s_ID,STOCK_" & DB & ".s_prdt & STOCK_" & DB & ".s_code & STOCK_" & DB & ".s_pre & STOCK_" & DB & ".s_rea & STOCK_" & DB & ".s_reades & STOCK_" & DB & ".s_qty & S_ID   AS iKey, STOCK_" & DB & ".S_PRDT, STOCK_" & DB & ".S_DATE, STOCK_" & DB & ".S_CODE, STOCK_" & DB & ".S_SLIP, STOCK_" & DB & ".S_REA, STOCK_" & DB & ".S_READES, STOCK_" & DB & ".S_QTY, STOCK_" & DB & ".S_PRICE,STOCK_" & DB & ".S_KG, STOCK_" & DB & ".S_BQTY, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_BAMT"
        sqlstr = sqlstr + " FROM STOCK_CARD_" & DB & " RIGHT JOIN (STOCK_" & DB & " inner join tempPrdt on STOCK_" & DB & ".s_prdt=tempPrdt.prdt) ON STOCK_CARD_" & DB & ".S_PRDT = STOCK_" & DB & ".S_PRDT"
        sqlstr = sqlstr + " WHERE IIf(IsNull([STOCK_CARD_" & DB & "].[s_date]),'0',[STOCK_CARD_" & DB & "].[s_date])<=[STOCK_" & DB & "].[s_date]"

        sqlstr = sqlstr + " UNION SELECT S_PRDT & 'SC',STOCK_CARD_" & DB & ".S_PRDT & 'STOCKC' as iKey,STOCK_CARD_" & DB & ".S_PRDT, STOCK_CARD_" & DB & ".S_DATE,'STOCKCARD' AS scode"
        sqlstr = sqlstr + " , 'STOCKCARD' AS Expr1, '' AS Expr2,'' as ww, STOCK_CARD_" & DB & ".S_QTY, STOCK_CARD_" & DB & ".S_PRICE,'' AS KG, STOCK_CARD_" & DB & ".S_QTY"
        sqlstr = sqlstr + " , [S_PRICE] AS Expr3, STOCK_CARD_" & DB & ".S_AMOUNT FROM STOCK_CARD_" & DB & " inner join tempPrdt on STOCK_CARD_" & DB & ".s_prdt=tempPrdt.prdt"

        sqlstr = sqlstr + " UNION SELECT STOCK_ADJ_" & DB & ".PRDT & 'ADJ',STOCK_ADJ_" & DB & ".PRDT & 'ADJ' as iKey,STOCK_ADJ_" & DB & ".PRDT, STOCK_ADJ_" & DB & ".DATE,'ADJ' AS scode"
        sqlstr = sqlstr + " , 'ADJ' AS Expr1, '' AS Expr2,'' as ww, STOCK_ADJ_" & DB & ".QTY, STOCK_ADJ_" & DB & ".PRICE,'' AS KG, STOCK_ADJ_" & DB & ".QTY"
        sqlstr = sqlstr + " , [PRICE] AS Expr3, STOCK_ADJ_" & DB & ".AMT FROM STOCK_ADJ_" & DB & " inner join tempPrdt on STOCK_ADJ_" & DB & ".prdt=tempPrdt.prdt"

        sqlstr = sqlstr + " ) AS tb1 order by s_prdt,s_date,s_slip desc,s_code"




        sqlstr = "ALTER TABLE tempSTOCK ADD PRIMARY KEY (s_ID)"
        dtc.RunCommand(conn, sqlstr)



    End Sub
    Function UpPriceComplte(ByVal DB As String, ByVal whereArea As String) As DataTable
        PrePRDT(DB, whereArea)
        Getdata(DB)

        UpdatePrice()

        UpdatetoServer(DB)
        Return dt

    End Function
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
        sqlstr = "UPDATE STOCK_" & DB & "_test INNER JOIN tempstock ON (tempstock.ikey=STOCK_" & DB & "_TEST.s_prdt & STOCK_" & DB & "_TEST.s_code & STOCK_" & DB & "_TEST.s_pre  & STOCK_" & DB & "_TEST.s_rea & STOCK_" & DB & "_TEST.s_reades & STOCK_" & DB & "_TEST.s_qty) SET "
        sqlstr = sqlstr + " STOCK_" & DB & "_test.s_price = [tempstock.s_price]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_test.s_bqty = [tempstock.s_bqty]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_test.s_bprice = [tempstock.s_bprice]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_test.s_bamt = [tempstock.s_bamt]"


        sqlstr = "UPDATE STOCK_" & DB & " INNER JOIN tempstock ON (tempstock.ikey= STOCK_" & DB & ".s_prdt & STOCK_" & DB & ".s_code & STOCK_" & DB & ".s_pre  & STOCK_" & DB & ".s_rea & STOCK_" & DB & ".s_reades & STOCK_" & DB & ".s_qty & S_ID) SET "
        sqlstr = sqlstr + " STOCK_" & DB & ".s_price = [tempstock.s_price]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bqty = [tempstock.s_bqty]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bprice = [tempstock.s_bprice]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bamt = [tempstock.s_bamt]"

        'ข้อมูลtest
        sqlstr = "UPDATE STOCK_" & DB & "_TEST INNER JOIN tempstock ON (val(tempstock.S_ID)= STOCK_" & DB & "_TEST.S_ID) SET "
        sqlstr = sqlstr + " STOCK_" & DB & "_TEST.s_price = [tempstock.s_price]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_TEST.s_bqty = [tempstock.s_bqty]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_TEST.s_bprice = [tempstock.s_bprice]"
        sqlstr = sqlstr + " , STOCK_" & DB & "_TEST.s_bamt = [tempstock.s_bamt]"

        dtc.RunCommand(conn, sqlstr)


        'ข้อมูลจริง
        sqlstr = "UPDATE STOCK_" & DB & " INNER JOIN tempstock ON (val(tempstock.S_ID)= STOCK_" & DB & ".S_ID) SET "
        sqlstr = sqlstr + " STOCK_" & DB & ".s_price = [tempstock.s_price]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bqty = [tempstock.s_bqty]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bprice = [tempstock.s_bprice]"
        sqlstr = sqlstr + " , STOCK_" & DB & ".s_bamt = [tempstock.s_bamt]"



    End Sub
    Function GetStocksummary(ByVal DB As String, ByVal iDate As String, ByVal WhereArea As String, ByVal ShowZero As Boolean) As DataTable
        Try
            dtc.RunCommand(conn, "drop table lastrec")
        Catch ex As Exception

        End Try


        PrePRDT(DB, WhereArea)

        sqlstr = "SELECT tb2.S_PRDT, tb2.MaxDATE, STOCK_" & DB & ".S_CODE, STOCK_" & DB & ".S_DATE, STOCK_" & DB & ".S_SLIP, STOCK_" & DB & ".S_REA, STOCK_" & DB & ".S_PRE, STOCK_" & DB & ".S_BQTY, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_BAMT, STOCK_SA.A_DATE, STOCK_SA.A_amt"
        sqlstr = sqlstr & " , iif( STOCK_" & DB & ".S_DATE>= STOCK_SA.a_DATE or isnull( STOCK_SA.A_DATE), STOCK_" & DB & ".S_BQTY, STOCK_SA.a_QTY) AS QTY"
        sqlstr = sqlstr & " , iif( STOCK_" & DB & ".S_DATE>= STOCK_SA.A_DATE or isnull( STOCK_SA.a_DATE),IIF( STOCK_" & DB & ".S_BPRICE>0, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_PRICE), STOCK_SA.a_PRICE) AS Price"
        sqlstr = sqlstr & " , iif( STOCK_" & DB & ".S_DATE>= STOCK_SA.a_DATE or isnull( STOCK_SA.a_DATE), STOCK_" & DB & ".S_BAMT, STOCK_SA.a_amt) AS AMT "
        sqlstr = sqlstr & " INTO testSTOCKCARD_" & DB
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
        sqlstr = sqlstr & " ) AS STOCK_SA RIGHT JOIN (STOCK_" & DB & " INNER JOIN (SELECT tb1.S_PRDT, Max(tb1.S_DATE & SLIP  & s_code & s_rea & s_reades & s_pre) AS MaxDATE "
        sqlstr = sqlstr & " FROM (SELECT STOCK_" & DB & ".S_PRDT, STOCK_" & DB & ".S_DATE,s_code,iif(s_slip like 'we','a',iif(s_slip like 'mb','b','c')) as SLIP,s_rea,s_reades,s_pre, STOCK_" & DB & ".S_BQTY, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_BAMT"
        sqlstr = sqlstr & " FROM STOCK_" & DB & "   WHERE STOCK_" & DB & ".S_DATE<='" & iDate & "'"
        sqlstr = sqlstr & " ) AS tb1 "
        sqlstr = sqlstr & " GROUP BY tb1.S_PRDT) AS tb2 ON (STOCK_" & DB & ".S_PRDT = tb2.S_PRDT) AND (STOCK_" & DB & ".S_DATE &  iif(s_slip like 'we','a',iif(s_slip like 'mb','b','c')) &  STOCK_" & DB & ".S_code & s_rea & s_reades & s_pre = tb2.MaxDATE)) ON STOCK_SA.S_PRDT = STOCK_" & DB & ".S_PRDT;"






        sqlstr = "SELECT tb2.S_PRDT, tb2.MaxDATE, STOCK_" & DB & ".S_CODE, STOCK_" & DB & ".S_DATE, STOCK_" & DB & ".S_SLIP, STOCK_" & DB & ".S_REA, STOCK_" & DB & ".S_PRE, STOCK_" & DB & ".S_BQTY, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_BAMT, STOCK_SA.A_DATE, STOCK_SA.A_amt"
        sqlstr = sqlstr & " , iif( STOCK_" & DB & ".S_DATE>= STOCK_SA.a_DATE or isnull( STOCK_SA.A_DATE), STOCK_" & DB & ".S_BQTY, STOCK_SA.a_QTY) AS QTY"
        sqlstr = sqlstr & " , iif( STOCK_" & DB & ".S_DATE>= STOCK_SA.A_DATE or isnull( STOCK_SA.a_DATE),IIF( STOCK_" & DB & ".S_BPRICE>0, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_PRICE), STOCK_SA.a_PRICE) AS Price"
        sqlstr = sqlstr & " , iif( STOCK_" & DB & ".S_DATE>= STOCK_SA.a_DATE or isnull( STOCK_SA.a_DATE), STOCK_" & DB & ".S_BAMT, STOCK_SA.a_amt) AS AMT "
        sqlstr = sqlstr & " INTO testSTOCKCARD_" & DB
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
        sqlstr = sqlstr & " ) AS STOCK_SA RIGHT JOIN (STOCK_" & DB & " INNER JOIN (SELECT tb1.S_PRDT, Max(tb1.S_DATE & SLIP  & s_code & s_rea & s_reades & s_pre) AS MaxDATE "
        sqlstr = sqlstr & " FROM (SELECT STOCK_" & DB & ".S_PRDT, STOCK_" & DB & ".S_DATE,s_code,iif(s_slip like 'we','a',iif(s_slip like 'mb','b','c')) as SLIP,s_rea,s_reades,s_pre, STOCK_" & DB & ".S_BQTY, STOCK_" & DB & ".S_BPRICE, STOCK_" & DB & ".S_BAMT"
        sqlstr = sqlstr & " FROM STOCK_" & DB & "   WHERE STOCK_" & DB & ".S_DATE<='" & iDate & "'"

        sqlstr = sqlstr & " ) AS tb1 "
        sqlstr = sqlstr & " GROUP BY tb1.S_PRDT) AS tb2 ON (STOCK_" & DB & ".S_PRDT = tb2.S_PRDT) AND (STOCK_" & DB & ".S_DATE &  iif(s_slip like 'we','a',iif(s_slip like 'mb','b','c')) &  STOCK_" & DB & ".S_code & s_rea & s_reades & s_pre = tb2.MaxDATE)) ON STOCK_SA.S_PRDT = STOCK_" & DB & ".S_PRDT;"

        Dim StockDB As String = DB
        If OldData Then StockDB = StockDB & "_OLD"

        sqlstr = "SELECT tb1.S_PRDT, Max(tb1.S_DATE & SLIP  & s_code & s_rea & s_reades & s_pre ) AS MaxDATE into lastrec  FROM "
        sqlstr &= "(SELECT S_PRDT, S_DATE,s_code"
        sqlstr &= ",iif(s_slip like 'we','c',iif(s_slip like 'mb','d','e')) as SLIP,0-s_BQTY as BQTY"
        sqlstr &= ",s_rea,s_reades,s_pre FROM STOCK_" & StockDB & " as t1  inner join tempprdt as t2 on t1.s_prdt=t2.prdt   WHERE S_DATE<='" & iDate & "'"
        sqlstr &= "union select  S_PRDT,S_DATE,'','a',0,'STOCKCARD','','' FROM STOCK_card_" & StockDB & "  as t1  inner join tempprdt as t2 on t1.s_prdt=t2.prdt   WHERE S_DATE<='" & iDate & "'"
        sqlstr &= "union select  t1.PRDT,DATE,'','b',0,'ADJ','','' FROM STOCK_ADJ_" & DB & "  as t1  inner join tempprdt as t2 on t1.prdt=t2.prdt  WHERE DATE<='" & iDate & "'"

        sqlstr &= ") AS tb1 GROUP BY tb1.S_PRDT"

        dtc.RunCommand(conn, sqlstr)



        sqlstr = " SELECT S_PRDT as PRDT, PRDT_" & DB & ".P_ENAME As Name, PRDT_" & DB & ".P_SPEC as SPEC"
        ' sqlstr &= " , Format([S_BQTY],'#,##0.00') AS Quantity, Format([S_BPRICE],'#,##0.00') AS UnitePrice, Format([S_BAMT],'#,##0.00') AS Amount"
        sqlstr &= " , round([S_BQTY],2) AS Quantity, round([SPRICE],2) AS UnitePrice, round([S_BAMT],2) AS Amount"

        sqlstr &= " FROM PRDT_" & DB & " RIGHT JOIN "

        sqlstr &= "(SELECT Lastrec.S_PRDT, Lastrec.MaxDATE, S_CODE, S_DATE, S_SLIP, S_REA, S_PRE, S_BQTY, iif(S_BPRICE=0,s_price,s_bprice) as SPRICE, S_BAMT"
        sqlstr &= " FROM STOCK_" & StockDB & " INNER JOIN Lastrec"
        sqlstr &= " ON (STOCK_" & StockDB & ".S_PRDT = Lastrec.S_PRDT) AND (STOCK_" & StockDB & ".S_DATE &  iif(s_slip like 'we','c',iif(s_slip like 'mb','d','e')) &  STOCK_" & StockDB & ".S_code & s_rea & s_reades & s_pre = Lastrec.MaxDATE) "
        sqlstr &= " union SELECT Lastrec.S_PRDT, Lastrec.MaxDATE, 'STOCKCARD', S_DATE, '','', '', S_QTY, S_PRICE, S_amount"
        sqlstr &= " FROM STOCK_card_" & StockDB & " INNER JOIN Lastrec"
        sqlstr &= " ON (STOCK_card_" & StockDB & ".S_PRDT = Lastrec.S_PRDT) AND (STOCK_card_" & StockDB & ".S_DATE &  'aSTOCKCARD' = Lastrec.MaxDATE) "
        sqlstr &= " Union SELECT Lastrec.S_PRDT, Lastrec.MaxDATE, 'ADJ', DATE, '','', '', QTY, PRICE, amt"
        sqlstr &= " FROM STOCK_adj_" & DB & " INNER JOIN Lastrec"
        sqlstr &= " ON (STOCK_adj_" & DB & ".PRDT = Lastrec.S_PRDT) AND (STOCK_adj_" & DB & ".DATE &  'bADJ' = Lastrec.MaxDATE) "


        sqlstr &= ") as t1 ON PRDT_" & DB & ".P_PRDT = t1.S_PRDT"
        ' sqlstr = sqlstr & " WHERE "

        If ShowZero = False Then

            If WhereArea <> "" Then WhereArea = " and " & WhereArea
            WhereArea = " where t1.S_BQTY>0 " & WhereArea
        Else
            If WhereArea <> "" Then WhereArea = " where " & WhereArea
        End If
        'sqlstr = sqlstr & "(((t1.S_BQTY)>0) "

        sqlstr = sqlstr & WhereArea
        sqlstr = sqlstr & " ORDER BY t1.S_PRDT;"
        dtc.QryDT(conn, sqlstr)

        Return dtc.dt

    End Function


    Function GetStocksummary2(ByVal DB As String, ByVal iDate As String, ByVal WhereArea As String, ByVal ShowZero As Boolean) As DataTable



        Dim dt As DataTable



        sqlstr = "select s_prdt,P_ename,p_SPEC,s_date,s_bqty as Quantity,s_bprice as Price,s_bamt as Amount from (select s_prdt,P_ename,p_SPEC,s_date,s_slip,s_code,s_bqty,s_bprice,s_bamt from stock_" & DB
        sqlstr &= " as t1 inner join prdt_" & DB & " as t2 on t1.s_prdt=t2.p_prdt where  s_date <='" & iDate & "' and  " & WhereArea
        sqlstr &= " union select s_prdt,P_ename,p_SPEC,s_date,'z','',s_qty,s_price,s_amount from stock_card_" & DB
        sqlstr &= " as t1 inner join prdt_" & DB & " as t2 on t1.s_prdt=t2.p_prdt where  " & WhereArea

        sqlstr &= ") as t3 order by s_prdt,s_date,s_slip desc,s_code,s_bqty desc "


        dtc.QryDT(conn, sqlstr)
        dt = dtc.dt.Clone()
        dt.Clear()

        Dim befPrdt As String = ""
        Dim befQTY, befPrice, BefAMT As Double
        Dim addPrdt As String = ""
        Dim Befdr As DataRow
        dtc.dt.Rows.Add("s_prdt", "P_ename", "p_SPEC", "s_date", 0, 0, 0)
        For Each dr As DataRow In dtc.dt.Rows
            If dr("s_prdt").ToString <> addPrdt Then
                If befPrdt <> dr("s_prdt").ToString And befPrdt <> "" And befPrdt <> addPrdt Then
                    'insertDAta(dr("s_prdt").ToString)
                    dt.ImportRow(Befdr)
                    'iDate = FromDate
                End If
                If dr("s_date") > iDate Then 'dateC.DateTOstring()
                    If befPrdt = dr("s_prdt").ToString Then
                        addPrdt = dr("s_prdt").ToString
                        dt.ImportRow(Befdr)
                    End If

                End If
                befPrdt = dr("s_prdt").ToString
                Befdr = dr
            End If
            ' befQTY = CDbl(NullC.NulltoDBL(dr("s_bqty"))).ToString("00.00")
            'befPrice = CDbl(NullC.NulltoDBL(dr("s_bprice"))).ToString("00.00")
            'BefAMT = CDbl(NullC.NulltoDBL(dr("s_bamt"))).ToString("00.00")
        Next
        If ShowZero = False Then
            Dim dv As DataView
            ' dv = dt.Selec("s_bQTY >0")
            dv = dt.DefaultView
            dv.RowFilter = "Quantity >0"
            dt = dv.ToTable
        End If
        Return dt
    End Function



End Class
