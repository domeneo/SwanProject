Imports System.Data.SqlClient
Imports System.Configuration
Public Class WIPCls
    'Inherits DataTool
    Dim SQLstr As String

    Dim _ALLdt As DataTable
    Dim _Gdt As DataTable
    Dim ds As New DataSet
    Dim _Result As String

    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    ' Dim connACC As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    ' Dim connACC As New OleDb.OleDbConnection
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim Pathdb As String
    Dim ConnectionString As String

    Sub New()
        PathDB = "\\server\siamvb\WIPdb.mdb"
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pathdb & ";Persist Security Info=False"
        ' connACC.Open()
        'dtACC.conn = connACC
    End Sub

    ReadOnly Property Result()
        Get
            Return _Result
        End Get

    End Property
    Property ALLdt()
        Get
            Return _ALLdt
        End Get
        Set(ByVal value)
            _ALLdt = value
        End Set
    End Property


    Property Gdt()
        Get
            Return _Gdt
        End Get
        Set(ByVal value)
            _Gdt = value
        End Set
    End Property
    Function AddSingleQoute(ByVal str As String)
        str = Replace(str, ",", "','")
        str = "'" & str & "'"
        Return str
    End Function

    Function getQTY(ByVal Pcode As String, ByVal scode As String, ByVal db As String)

        sqlstr = "select B_SCODE,B_QTY from BOM_" & db
        sqlstr += " where B_PCODE like '" & Pcode & "' and B_scode like '" & scode & "'"
        Return dtACC.ExScalar(SQLstr)
       
    End Function
    Function getREFcode(ByVal code As String)
        SQLstr = "select p_REF from prdt_BOI"
        SQLstr += " where p_PRDT like '" & code & "'"

        Return dtACC.ExScalar(SQLstr)
       


    End Function

    Sub ShowPrdtWip(ByVal DB As String, ByVal LOTno As String, ByVal Prdt As String)

        sqlstr = "SELECT MC_PRDT_THAI,S_PRDT, S_DATE, S_SLIP, S_REA, S_QTY, 'BOI' AS STOCK"
        sqlstr += " FROM STOCK_BOI inner join LOT_" & DB & " on LOT_" & DB & ".MC_LOT=STOCK_BOI.s_PRE"
        sqlstr += " WHERE (((s_pre)='" & LOTno & "')) and (S_SLIP like 'WE' or s_PRDT like '" & Prdt & "')"
        sqlstr += " union"
        sqlstr += " SELECT MC_PRDT_Thai,S_PRDT, S_DATE, S_SLIP, S_REA, S_QTY, 'TAX' AS STOCK"
        sqlstr += " FROM STOCK_TAX  inner join LOT_" & DB & " on LOT_" & DB & ".MC_LOT=STOCK_tax.s_PRE"
        sqlstr += " WHERE (((s_pre)='" & LOTno & "')) and (S_SLIP like 'WE' or s_PRDT like '" & Prdt & "')"
        dtACC.QryDT(SQLstr)
        _ALLdt = dtACC.dt
        Dim WEBOI, WETAX, MABOI, MATAX, MBBOI, MBTAX, BOMBOI, BOMTAX As Integer
        Dim WEPrdt As String
        WEBOI = 0
        WETAX = 0
        MABOI = 0
        MATAX = 0
        MBBOI = 0
        MBTAX = 0
        For Each dr As DataRow In _ALLdt.Rows
            If dr("S_SLIP") = "WE" Then
                WEPrdt = dr("s_prdt")
                If dr("STOCK") = "BOI" Then
                    WEBOI += dr("s_QTY")
                ElseIf dr("STOCK") = "TAX" Then
                    WETAX += dr("s_QTY")
                End If
            End If
            If dr("S_SLIP") = "MA" Then
                If dr("STOCK") = "BOI" Then
                    MABOI += dr("s_QTY")
                ElseIf dr("STOCK") = "TAX" Then
                    MATAX += dr("s_QTY")
                End If
            End If
            If dr("S_SLIP") = "MB" Then
                If dr("STOCK") = "BOI" Then
                    MBBOI += dr("s_QTY")
                ElseIf dr("STOCK") = "TAX" Then
                    MBTAX += dr("s_QTY")
                End If
            End If

        Next
        BOMBOI = getQTY(WEPrdt, Prdt, "BOI")
        BOMTAX = getQTY(WEPrdt, Prdt, "TAX")

        WEBOI = WEBOI * BOMBOI
        WETAX = WETAX * BOMTAX


        _Result = "WEBOI: " & WEBOI & vbCrLf & "WETAX: " & WETAX & vbCrLf
        _Result += "BOMBOI: " & BOMBOI & vbCrLf & "BOMTAX: " & BOMTAX & vbCrLf
        _Result += "MABOI:" & MABOI & vbCrLf & "MATAX:" & MATAX & vbCrLf & "MBBOI:" & MBBOI & vbCrLf & "MBTAX:" & MBTAX & vbCrLf
        _Result += "DIFF:" & (MABOI + MATAX) - (WEBOI + WETAX) - (MBBOI + MBTAX)

    End Sub
    Sub makeWIPDB(ByVal DB As String)

        If dtACC.ExistsTable("stock") Then
            SQLstr = "drop table stock"
            dtACC.RunCommand(SQLstr)
        End If

        If dtACC.ExistsTable("ShowG") Then
            SQLstr = "drop table ShowG"
            dtACC.RunCommand(SQLstr)
        End If
        If dtACC.ExistsTable("LOT") Then
            SQLstr = "drop table LOT"
            dtACC.RunCommand(SQLstr)
        End If


        sqlstr = "SELECT MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
        sqlstr += " into LOT FROM LOT_" & DB
        sqlstr += " WHERE LOT_BOI.MC_DATE >= '20090101' "
        dtACC.RunCommand(SQLstr)


        sqlstr = "SELECT * INTO stock"
        sqlstr = sqlstr + " FROM (SELECT 'BOI' as DB,max(s_date) as maxDate,STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, Sum(STOCK_BOI.S_QTY) AS SumOfS_QTY, STOCK_BOI.S_PRE"
        sqlstr = sqlstr + " From STOCK_BOI inner join LOT on STOCK_BOI.S_PRE = LOT.MC_LOT"
        'sqlstr = sqlstr + " where mc_date between '" & FromDate & "' and '" & toDate & "'" 'เงื่อนไข
        sqlstr = sqlstr + " GROUP BY STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, STOCK_BOI.S_PRE"
        sqlstr = sqlstr + " union SELECT 'TAX' as DB,max(s_date) as maxDate,STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, Sum(STOCK_TAX.S_QTY) AS SumOfS_QTY, STOCK_TAX.S_PRE"
        sqlstr = sqlstr + " From STOCK_TAX inner join LOT  on STOCK_tax.S_PRE = LOT.MC_LOT"
        'sqlstr = sqlstr + " where mc_date between '" & FromDate & "' and '" & toDate & "' "
        sqlstr = sqlstr + " GROUP BY STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, STOCK_TAX.S_PRE) AS [stock];"

        dtACC.RunCommand(SQLstr)


        sqlstr = "SELECT MC_LOT, step1.MC_PRDT_THAI,StockDATA.s_prdt, step1.WEBOI, step1.WETAX, step1.s_date, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX, ([MATAX]+[MABOI])-([MBBOI]+[MBTAX])-([WEBOI]+[WETAX]) AS diff"
        sqlstr = sqlstr + " into ShowG FROM StockDATA right JOIN step1 ON StockDATA.S_PRE = step1.MC_LOT WHERE (((step1.MC_LOT) Like 'G%' Or (step1.MC_LOT) Like 'CL%')) OR (((step1.MC_PRDT_THAI)=[s_prdt]))"

        dtACC.RunCommand(SQLstr)

        sqlstr = "SELECT MC_DATE, MC_LOT, MC_DEPT, MC_PRDT, MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, DATA1.S_PRDT, prdt_" & DB & ".P_ENAME"
        sqlstr = sqlstr + ",P_TNAME, P_SPEC, DATA1.WEBOI, DATA1.WETAX, DATA1.s_date, DATA1.MABOI, DATA1.MATAX, DATA1.MBBOI, DATA1.MBTAX, DATA1.BOMBOI, DATA1.BOMTAX, (iif(isnull(maboi),0,maboi)+iif(isnull(matax),0,matax))-(iif(isnull(mbboi),0,mbboi)+iif(isnull(mbtax),0,mbtax))-(iif(isnull(weboi*bomboi),0,weboi*bomboi))-(iif(isnull(wetax*bomtax),0,wetax*bomtax)) AS diff"

        sqlstr = sqlstr + " into WIPDB" & DB & " FROM ((SELECT StockDATA.S_PRE, StockDATA.S_PRDT, step2.WEBOI, step2.WETAX, step2.s_date, step2.BOMBOI, step2.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"

        sqlstr = sqlstr + " FROM StockDATA LEFT JOIN step2 ON (StockDATA.S_PRE = step2.MC_LOT) AND (StockDATA.S_PRDT = step2.B_SCODE) where StockDATA.S_PRE not in (select MC_LOT from showG)   union SELECT step2.MC_LOT, step2.B_SCODE, step2.WEBOI, step2.WETAX, step2.s_date, step2.BOMBOI, step2.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        sqlstr = sqlstr + " FROM StockDATA RIGHT JOIN step2 ON (StockDATA.S_PRDT = step2.B_SCODE) AND (StockDATA.S_PRE = step2.MC_LOT) ) AS DATA1 INNER JOIN LOT ON DATA1.S_PRE = LOT.MC_LOT) LEFT JOIN prdt_" & DB & " ON DATA1.S_PRDT = prdt_" & DB & ".P_PRDT"
        'sqlstr = sqlstr + " WHERE (((Left([S_PRE],1))<>'G') AND ((Left([S_PRE],2))<>'CL')) "
        sqlstr = sqlstr + " order by mc_lot,s_prdt"


        dtACC.RunCommand(SQLstr)


    End Sub
    Sub DropView(ByVal ViewName As String)
        On Error Resume Next
        sqlstr = "drop view " & ViewName
        dtACC.RunCommand(SQLstr)

    End Sub

    Sub LoadWIP(ByVal DB As String, ByVal FromDate As String, ByVal toDate As String, Optional DEP As String = "%", Optional LOTCLOSE As String = "", Optional inLOT As String = "", Optional Stockdate As String = "")
        Dim pgb As New ProgressFrm

        If FromDate = "" Then FromDate = "%"
        If toDate = "" Then toDate = "%"
        pgb.PGB.Maximum = 5
        pgb.PGB.Value = 0
        pgb.Show()






        pgb.Text = "Prepare DB"
        If dtACC.ExistsTable("stock", ConnectionString) Then
            SQLstr = "drop table stock"
            dtACC.RunCommand(SQLstr, ConnectionString)
        End If

        If dtACC.ExistsTable("ShowG", ConnectionString) Then
            SQLstr = "drop table ShowG"
            dtACC.RunCommand(SQLstr, ConnectionString)
        End If
        If dtACC.ExistsTable("LOT", ConnectionString) Then
            SQLstr = "drop table LOT"
            dtACC.RunCommand(SQLstr, ConnectionString)
        End If


        'DropView("step2")

        pgb.PGB.Value += 1
        pgb.Text = "Load LOT & STOCK"



        If inLOT <> "" Then
            'If dtACC.ExistsTable("tempinlot", ConnectionString) = False Then
            '    dtACC.RunCommand("Create Table tempinlot (LOT CHAR)", ConnectionString)
            'Else
            '    dtACC.RunCommand("delete * from tempinlot", ConnectionString)

            'End If
            'For Each str As String In inLOT.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            '    If str = "" Then Continue For
            '    dtACC.RunCommand(" insert into tempinlot(LOT) values('" & str & "')", ConnectionString)

            'Next





            'SQLstr = "Select MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
            'SQLstr += " into LOT FROM LOT_" & DB & " as l inner join tempinlot as t  on l.mc_lot=t.lot "
            '' SQLstr += " WHERE (((MC_DATE) Between '" & FromDate & "' And '" & toDate & "')) and MC_DEPT like '" & DEP & "' " & LOTCLOSE
            'dtACC.RunCommand(SQLstr, ConnectionString)

            inLOT = "'" & inLOT.Trim.Replace(vbCrLf, "','") & "'"
            SQLstr = "Select MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
            SQLstr += " into LOT FROM LOT_" & DB & " as l "
            SQLstr += " where mc_lot in (" & inLOT & ")"
            dtACC.RunCommand(SQLstr, ConnectionString)


        Else
            SQLstr = "Select MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
            SQLstr += " into LOT FROM LOT_" & DB
            SQLstr += " WHERE (((MC_DATE) Between '" & FromDate & "' And '" & toDate & "')) and MC_DEPT like '" & DEP & "' " & LOTCLOSE
            dtACC.RunCommand(SQLstr, ConnectionString)

        End If





        SQLstr = "SELECT * INTO stock"
        SQLstr = SQLstr + " FROM (SELECT 'BOI' as DB,max(s_date) as maxDate,STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, Sum(STOCK_BOI.S_QTY) AS SumOfS_QTY, STOCK_BOI.S_PRE,Sum(STOCK_BOI.S_price) AS Sprice"
        SQLstr = SQLstr + " From STOCK_BOI inner join LOT on STOCK_BOI.S_PRE = LOT.MC_LOT"
        If Stockdate <> "" Then SQLstr = SQLstr + " where s_date <='" & Stockdate & "'"

        'sqlstr = sqlstr + " where mc_date between '" & FromDate & "' and '" & toDate & "'" 'เงื่อนไข
        SQLstr = SQLstr + " GROUP BY STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, STOCK_BOI.S_PRE"
        SQLstr = SQLstr + " union SELECT 'TAX' as DB,max(s_date) as maxDate,STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, Sum(STOCK_TAX.S_QTY) AS SumOfS_QTY, STOCK_TAX.S_PRE,Sum(STOCK_TAX.S_price) AS Sprice"
        SQLstr = SQLstr + " From STOCK_TAX inner join LOT  on STOCK_tax.S_PRE = LOT.MC_LOT"
        If Stockdate <> "" Then SQLstr = SQLstr + " where s_date <='" & Stockdate & "'"
        'sqlstr = sqlstr + " where mc_date between '" & FromDate & "' and '" & toDate & "' "
        SQLstr = SQLstr + " GROUP BY STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, STOCK_TAX.S_PRE) AS [stock];"

        dtACC.RunCommand(SQLstr, ConnectionString)
        pgb.PGB.Value += 1

        'MAKE BOMDB
        SQLstr = "CREATE  VIEW  BOMDB  AS "
        SQLstr &= "SELECT BOM.B_PCODE, BOM.B_SCODE, Sum(IIf([db] Like 'BOI',[b_qty],0)) AS BOMBOI, Sum(IIf([db] Like 'TAX',[b_qty],0)) AS BOMTAX "
        SQLstr = SQLstr + " FROM (SELECT 'BOI' as db,B_PCODE, B_SCODE, B_QTY"
        SQLstr = SQLstr + " From BOM_BOI Union"
        SQLstr = SQLstr + " SELECT 'TAX' as db,BOM_TAX.B_PCODE, BOM_TAX.B_SCODE, BOM_TAX.B_QTY"
        SQLstr = SQLstr + " FROM BOM_TAX) AS BOM"
        SQLstr = SQLstr + " GROUP BY BOM.B_PCODE, BOM.B_SCODE"
        ' RunCommand(sqlstr)


        'make STOCKLOT
        pgb.PGB.Value += 1

        SQLstr = "CREATE  VIEW  StockDATA  AS "
        SQLstr &= "SELECT stock.S_PRE, stock.S_PRDT, Sum(IIf(s_slip Like 'MA' And db Like 'BOI',SumOfS_QTY,0)) AS MABOI, Sum(IIf(s_slip Like 'MA' And db Like 'TAX',SumOfS_QTY,0)) AS MATAX, Sum(IIf(s_slip Like 'MB' And db Like 'BOI',SumOfS_QTY,0)) AS MBBOI, Sum(IIf(s_slip Like 'MB' And db Like 'TAX',SumOfS_QTY,0)) AS MBTAX "
        SQLstr = SQLstr + " FROM stock INNER JOIN LOT ON stock.S_PRE = LOT.MC_LOT"
        SQLstr = SQLstr + " WHERE stock.S_SLIP<>'WE'"
        SQLstr = SQLstr + " GROUP BY stock.S_PRE, stock.S_PRDT"
        ' RunCommand(sqlstr)





        'make step1

        SQLstr = "CREATE  VIEW  Step1  AS "
        SQLstr &= "SELECT MC_LOT, MC_PRDT_THAI, Sum(IIf(stock.DB='BOI',S_QTY,0)) AS WEBOI, Sum(IIf(stock.DB='TAX',S_QTY,0)) AS WETAX, Max(stock.maxDate) AS s_date "
        SQLstr = SQLstr + " FROM (SELECT stock.DB, stock.S_PRDT, stock.S_SLIP, Sum(stock.SumOfS_QTY) AS S_QTY, stock.S_PRE,maxDate"
        SQLstr = SQLstr + " From stock GROUP BY stock.DB, stock.S_PRDT, stock.S_SLIP, stock.S_PRE,maxDate Having stock.S_SLIP = 'we') as stock RIGHT JOIN LOT ON stock.S_PRE=LOT.MC_LOT"
        ' sqlstr = sqlstr + " WHERE ((MC_DATE) Between '" & FromDate & "' and '" & toDate & "') and mc_dept like '" & DEP & "'"
        SQLstr = SQLstr + " GROUP BY MC_LOT, MC_PRDT_THAI"
        'RunCommand(sqlstr)



        'make Show G&CL


        SQLstr = "SELECT MC_LOT, step1.MC_PRDT_THAI,StockDATA.s_prdt, step1.WEBOI, step1.WETAX, step1.s_date, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX, ([MATAX]+[MABOI])-([MBBOI]+[MBTAX])-([WEBOI]+[WETAX]) AS diff"
        SQLstr = SQLstr + " into ShowG FROM StockDATA right JOIN step1 ON StockDATA.S_PRE = step1.MC_LOT WHERE (((step1.MC_LOT) Like 'G%' Or (step1.MC_LOT) Like 'CL%')) OR (((step1.MC_PRDT_THAI)=[s_prdt]))"

        dtACC.RunCommand(SQLstr, ConnectionString)


        pgb.PGB.Value += 1
        pgb.Text = "Prepare to ShowDaTA"
        'make step2
        SQLstr = "CREATE  VIEW  step2  AS "
        SQLstr &= "SELECT Step1.MC_LOT, Step1.MC_PRDT_THAI, BOMDB.B_SCODE, Step1.WEBOI, Step1.WETAX,s_date, BOMDB.BOMBOI, BOMDB.BOMTAX "
        SQLstr = SQLstr + " FROM BOMDB RIGHT JOIN Step1 ON BOMDB.B_PCODE = Step1.MC_PRDT_THAI " 'where MC_LOT not in (select MC_LOT from showG)"  
        'RunCommand(sqlstr)



        Try


            SQLstr = "drop table result1"
            dtACC.RunCommand(SQLstr, ConnectionString)

        Catch ex As Exception

        End Try


        SQLstr = "SELECT MC_DATE, MC_LOT, MC_DEPT, MC_PRDT, MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, DATA1.S_PRDT, prdt_" & DB & ".P_ENAME"
        SQLstr = SQLstr + ",prdt_" & DB & ".P_TNAME,prdt_" & DB & ".P_SPEC,prdt_boi.P_AST_FROM,prdt_tax.P_AST_FROM, DATA1.WEBOI, DATA1.WETAX, DATA1.s_date, DATA1.MABOI, DATA1.MATAX, DATA1.MBBOI, DATA1.MBTAX, DATA1.BOMBOI, DATA1.BOMTAX, (iif(isnull(maboi),0,maboi)+iif(isnull(matax),0,matax))-(iif(isnull(mbboi),0,mbboi)+iif(isnull(mbtax),0,mbtax))-(iif(isnull(weboi*bomboi),0,weboi*bomboi))-(iif(isnull(wetax*bomtax),0,wetax*bomtax)) AS diff"

        SQLstr = SQLstr + " into result1 FROM (((SELECT StockDATA.S_PRE, StockDATA.S_PRDT, step2.WEBOI, step2.WETAX, step2.s_date, step2.BOMBOI, step2.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"

        SQLstr = SQLstr + " FROM StockDATA LEFT JOIN step2 ON (StockDATA.S_PRE = step2.MC_LOT) AND (StockDATA.S_PRDT = step2.B_SCODE) " 'where StockDATA.S_PRE not in (select MC_LOT from showG) "
        SQLstr += "  union SELECT step2.MC_LOT, step2.B_SCODE, step2.WEBOI, step2.WETAX, step2.s_date, step2.BOMBOI, step2.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        SQLstr = SQLstr + " FROM StockDATA RIGHT JOIN step2 ON (StockDATA.S_PRDT = step2.B_SCODE) AND (StockDATA.S_PRE = step2.MC_LOT) ) AS DATA1 INNER JOIN LOT ON DATA1.S_PRE = LOT.MC_LOT) LEFT JOIN prdt_boi  ON DATA1.S_PRDT = prdt_boi.P_PRDT) LEFT JOIN prdt_TAX  ON DATA1.S_PRDT = prdt_TAX.P_PRDT"
        'sqlstr = sqlstr + " WHERE (((Left([S_PRE],1))<>'G') AND ((Left([S_PRE],2))<>'CL')) "
        SQLstr = SQLstr + " order by mc_lot,s_prdt"

        dtACC.RunCommand(SQLstr, ConnectionString)



        SQLstr = "select result1.*,bfile.b_note from result1  left join  bomfile_" & DB & " as bfile on result1.MC_LOT=bfile.b_lot and result1.s_prdt=bfile.b_scode"

        _ALLdt = dtACC.QryDT(SQLstr, ConnectionString)




        SQLstr = "SELECT MC_DATE, MC_DEPT, ShowG.MC_LOT, MC_PRDT, ShowG.MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, ShowG.S_PRDT, P_ENAME, P_TNAME, P_SPEC, ShowG.WEBOI, ShowG.WETAX, ShowG.s_date, ShowG.MABOI, ShowG.MATAX, ShowG.MBBOI, ShowG.MBTAX, ShowG.diff"
        SQLstr = SQLstr + " FROM PRDT_" & DB & " RIGHT JOIN (ShowG INNER JOIN LOT_" & DB & " ON ShowG.MC_LOT = LOT_" & DB & ".MC_LOT) ON PRDT_" & DB & ".P_PRDT = ShowG.S_PRDT"

        _Gdt = dtACC.QryDT(SQLstr, ConnectionString)


        pgb.Close()

    End Sub

    Sub LoadWIP(ByVal DB As String, ByVal LOTno As String)

        If dtACC.ExistsTable("stock") Then
            SQLstr = "drop table stock"
            dtACC.RunCommand(SQLstr)
        End If

        If dtACC.ExistsTable("ShowG") Then
            SQLstr = "drop table ShowG"
            dtACC.RunCommand(SQLstr)
        End If
        If dtACC.ExistsTable("LOT") Then
            SQLstr = "drop table LOT"
            dtACC.RunCommand(SQLstr)
        End If
        If dtACC.ExistsTable("step21") Then
            SQLstr = "drop table step21"
            dtACC.RunCommand(SQLstr)
        End If


        sqlstr = "SELECT MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
        sqlstr += " into LOT FROM LOT_" & DB
        sqlstr += " WHERE MC_LOT in (" & AddSingleQoute(LOTno) & ")"
        dtACC.RunCommand(SQLstr)


        sqlstr = "SELECT * INTO stock"
        sqlstr = sqlstr + " FROM (SELECT 'BOI' as DB,max(s_date) as maxDate,STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, Sum(STOCK_BOI.S_QTY) AS SumOfS_QTY, STOCK_BOI.S_PRE"
        sqlstr = sqlstr + " From STOCK_BOI inner join LOT on STOCK_BOI.S_PRE = LOT.MC_LOT"
        sqlstr = sqlstr + " where s_pre in  (" & AddSingleQoute(LOTno) & ") and (s_KK <>'KK' or s_kk is null)"
        sqlstr = sqlstr + " GROUP BY STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, STOCK_BOI.S_PRE"
        sqlstr = sqlstr + " union SELECT 'TAX' as DB,max(s_date) as maxDate,STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, Sum(STOCK_TAX.S_QTY) AS SumOfS_QTY, STOCK_TAX.S_PRE"
        sqlstr = sqlstr + " From STOCK_TAX inner join LOT  on STOCK_tax.S_PRE = LOT.MC_LOT"
        sqlstr = sqlstr + " where s_pre in  (" & AddSingleQoute(LOTno) & ") and (s_KK <>'KK' or s_kk is null)"
        sqlstr = sqlstr + " GROUP BY STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, STOCK_TAX.S_PRE) AS [stock];"

        dtACC.RunCommand(SQLstr)


        'If Left(LOTno, 1) = "G" Or Left(LOTno, 2) = "CL" Then
        '    'make Show G&CL


        '    sqlstr = "SELECT MC_LOT, step1.MC_PRDT_THAI,StockDATA.s_prdt, step1.WEBOI, step1.WETAX, step1.s_date, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX, ([MATAX]+[MABOI])-([MBBOI]+[MBTAX])-([WEBOI]+[WETAX]) AS diff"
        '    sqlstr = sqlstr + " into ShowG FROM StockDATA right JOIN step1 ON StockDATA.S_PRE = step1.MC_LOT WHERE (((step1.MC_LOT) Like 'G%' Or (step1.MC_LOT) Like 'CL%')) OR (((step1.MC_PRDT_THAI)=[s_prdt]))"
        '    RunCommand(sqlstr)

        '    sqlstr = "SELECT MC_DATE, MC_DEPT, ShowG.MC_LOT, MC_PRDT, ShowG.MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, ShowG.S_PRDT, P_ENAME, P_TNAME, P_SPEC, ShowG.WEBOI, ShowG.WETAX, ShowG.s_date, ShowG.MABOI, ShowG.MATAX, ShowG.MBBOI, ShowG.MBTAX, ShowG.diff"
        '    sqlstr = sqlstr + " FROM PRDT_" & DB & " RIGHT JOIN (ShowG INNER JOIN LOT_" & DB & " ON ShowG.MC_LOT = LOT_" & DB & ".MC_LOT) ON PRDT_" & DB & ".P_PRDT = ShowG.S_PRDT"
        '    _ALLdt = LoadDatatable(sqlstr)



        'Else



        sqlstr = "SELECT Step1.MC_LOT, Step1.MC_PRDT_THAI, BOMDB.B_SCODE, Step1.WEBOI, Step1.WETAX, Step1.s_date, BOMDB.BOMBOI, BOMDB.BOMTAX"
        sqlstr = sqlstr + " into step21 FROM BOMDB RIGHT JOIN Step1 ON BOMDB.B_PCODE = Step1.MC_PRDT_THAI"

        dtACC.RunCommand(SQLstr)



        sqlstr = "SELECT MC_DATE, MC_LOT, MC_DEPT, MC_PRDT, MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, DATA1.S_PRDT, prdt_" & DB & ".P_ENAME"
        sqlstr = sqlstr + ",P_TNAME, P_SPEC, DATA1.WEBOI, DATA1.WETAX, DATA1.s_date, DATA1.MABOI, DATA1.MATAX, DATA1.MBBOI, DATA1.MBTAX, DATA1.BOMBOI, DATA1.BOMTAX, (iif(isnull(maboi),0,maboi)+iif(isnull(matax),0,matax))-(iif(isnull(mbboi),0,mbboi)+iif(isnull(mbtax),0,mbtax))-(iif(isnull(weboi*bomboi),0,weboi*bomboi))-(iif(isnull(wetax*bomtax),0,wetax*bomtax)) AS diff"
        sqlstr = sqlstr + " FROM ((SELECT StockDATA.S_PRE, StockDATA.S_PRDT, step21.WEBOI, step21.WETAX, step21.s_date, step21.BOMBOI, step21.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        sqlstr = sqlstr + " FROM StockDATA LEFT JOIN step21 ON (StockDATA.S_PRE = step21.MC_LOT) AND (StockDATA.S_PRDT = step21.B_SCODE)  "
        sqlstr = sqlstr + " union SELECT step21.MC_LOT, step21.B_SCODE, step21.WEBOI, step21.WETAX, step21.s_date, step21.BOMBOI, step21.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        sqlstr = sqlstr + " FROM StockDATA RIGHT JOIN step21 ON (StockDATA.S_PRDT = step21.B_SCODE) AND (StockDATA.S_PRE = step21.MC_LOT) ) AS DATA1 INNER JOIN LOT ON DATA1.S_PRE = LOT.MC_LOT) LEFT JOIN prdt_" & DB & " ON DATA1.S_PRDT = prdt_" & DB & ".P_PRDT"
        'sqlstr = sqlstr + " WHERE (((Left([S_PRE],1))<>'G') AND ((Left([S_PRE],2))<>'CL')) "
        sqlstr = sqlstr + " order by mc_lot,s_prdt"

        dtACC.QryDT(SQLstr)
        _ALLdt = dtACC.dt

        'End If









    End Sub
    Sub LoadWIP(ByVal Prdt As String)

        If dtACC.ExistsTable("stock") Then
            SQLstr = "drop table stock"
            dtACC.RunCommand(SQLstr)
        End If

        If dtACC.ExistsTable("TABLE1") Then
            SQLstr = "drop table TABLE1"
            dtACC.RunCommand(SQLstr)
        End If

        If dtACC.ExistsTable("ShowG") Then
            SQLstr = "drop table ShowG"
            'RunCommand(sqlstr)
        End If
        If dtACC.ExistsTable("LOT") Then
            SQLstr = "drop table LOT"
            dtACC.RunCommand(SQLstr)
        End If
        If dtACC.ExistsTable("step21") Then
            SQLstr = "drop table step21"
            dtACC.RunCommand(SQLstr)
        End If

        Dim REFcode As String
        REFcode = getREFcode(Prdt)


        sqlstr = "select * into LOT  from ("
        sqlstr += " SELECT 'BOI' As LOTDB,MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
        sqlstr += " FROM BOMDB INNER JOIN LOT_BOI ON BOMDB.B_PCODE = LOT_BOI.MC_PRDT_THAI"
        sqlstr += " WHERE "
        If REFcode <> "" Then
            sqlstr += " (BOMDB.B_SCODE = '" & Prdt & "' or BOMDB.B_SCODE = '" & REFcode & "')"
        Else
            sqlstr += " BOMDB.B_SCODE = '" & Prdt & "'"
        End If
        SQLstr += " And mc_date > '20100101'"
        SQLstr += " union"
        sqlstr += " SELECT 'TAX' As LOTDB,MC_LOT, MC_PRDT, MC_PRDT_THAI, MC_LOTQTY, MC_QTY, MC_DATE, MC_PRED, MC_CLSD, MC_CLOSE, MC_DEPT"
        sqlstr += " FROM BOMDB INNER JOIN LOT_TAX ON BOMDB.B_PCODE = LOT_TAX.MC_PRDT_THAI"
        sqlstr += " WHERE "
        If REFcode <> "" Then
            sqlstr += " (BOMDB.B_SCODE = '" & Prdt & "' or BOMDB.B_SCODE = '" & REFcode & "')"
        Else
            sqlstr += " BOMDB.B_SCODE = '" & Prdt & "'"
        End If

        SQLstr += " and  mc_date >'20100101') as LOT"
        dtACC.RunCommand(SQLstr)



        sqlstr = "select * into stock  from ("
        sqlstr = sqlstr + " SELECT 'BOI' as DB,max(s_date) as maxDate,STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP,S_REA, Sum(STOCK_BOI.S_QTY) AS SumOfS_QTY, STOCK_BOI.S_PRE"
        sqlstr = sqlstr + " From STOCK_BOI "
        sqlstr += " where s_date >'20070101'"
        sqlstr = sqlstr + " GROUP BY STOCK_BOI.S_PRDT, STOCK_BOI.S_SLIP, STOCK_BOI.S_PRE,S_REA"
        sqlstr = sqlstr + " having   (S_PRDT like '" & Prdt & "' "
        If REFcode <> "" Then sqlstr += " or S_PRDT like '" & REFcode & "'"
        sqlstr += " or s_slip like 'WE') "
        sqlstr = sqlstr + " union SELECT 'TAX' as DB,max(s_date) as maxDate,STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP,S_REA, Sum(STOCK_TAX.S_QTY) AS SumOfS_QTY, STOCK_TAX.S_PRE"
        sqlstr = sqlstr + " From STOCK_TAX "
        sqlstr += " where s_date >'20070101'"
        sqlstr = sqlstr + " GROUP BY STOCK_TAX.S_PRDT, STOCK_TAX.S_SLIP, STOCK_TAX.S_PRE,S_REA"
        sqlstr = sqlstr + " having (S_PRDT like '" & Prdt & "'"
        If REFcode <> "" Then sqlstr += " or S_PRDT like '" & REFcode & "'"
        sqlstr += " or s_slip like 'WE')) as stock"
        dtACC.RunCommand(SQLstr)

        sqlstr = " select * into TABLE1 from (SELECT 'BOI' as LOTDB,MC_DATE,MC_LOT, MC_PRDT_THAI,MC_CLOSE,MC_LOTQTY,MC_QTY, BOMDB.B_SCODE, BOMDB.BOMBOI, BOMDB.BOMTAX"
        sqlstr = sqlstr + " FROM LOT_BOI INNER JOIN BOMDB ON LOT_BOI.MC_PRDT_THAI = BOMDB.B_PCODE"
        sqlstr = sqlstr + " WHERE BOMDB.B_SCODE='" & Prdt & "'"

        sqlstr = sqlstr + " union SELECT 'TAX' as LOTDB,MC_DATE,MC_LOT, MC_PRDT_THAI,MC_CLOSE,MC_LOTQTY,MC_QTY, BOMDB.B_SCODE, BOMDB.BOMBOI, BOMDB.BOMTAX"
        sqlstr = sqlstr + " FROM LOT_TAX INNER JOIN BOMDB ON LOT_TAX.MC_PRDT_THAI = BOMDB.B_PCODE"
        sqlstr = sqlstr + " WHERE BOMDB.B_SCODE='" & Prdt & "') as TABLE1"
        ' RunCommand(sqlstr)



        sqlstr = "SELECT TABLE1.LOTDB,TABLE1.MC_DATE, TABLE1.MC_LOT, TABLE1.MC_PRDT_THAI, TABLE1.MC_CLOSE, TABLE1.MC_LOTQTY, iif([BOMBOI]>0,[MC_QTY]*[bomboi],[mc_qty]*[BOMTAX]) as WE_QTY , TABLE1.B_SCODE, TABLE1.BOMBOI, TABLE1.BOMTAX, Sum(IIf([DB]='BOI' And [S_SLIP] Like 'MA',[QTY],0)) AS MABOI, Sum(IIf([DB]='TAX' And [S_SLIP] Like 'MA',[QTY],0)) AS MATAX, Sum(IIf([DB]='BOI' And [S_SLIP] Like 'MB' And [S_REA] Like 'B',[QTY],0)) AS MBBOI, Sum(IIf([DB]='TAX' And [S_SLIP] Like 'MB' And [s_REA] Like 'B',[QTY],0)) AS MBTAX"
        sqlstr = sqlstr + ",([MABOI]+[MATAX])-([MBBOI]+[MBTAX]) - [WE_QTY] as diff"
        sqlstr = sqlstr + " FROM stock RIGHT JOIN"
        sqlstr = sqlstr + " TABLE1  ON  (stock.S_PRE = TABLE1.MC_LOT)"
        sqlstr = sqlstr + " GROUP BY TABLE1.LOTDB,TABLE1.MC_DATE, TABLE1.MC_LOT, TABLE1.MC_PRDT_THAI, TABLE1.MC_CLOSE, TABLE1.MC_LOTQTY, iif([BOMBOI]>0,[MC_QTY]*[bomboi],[mc_qty]*[BOMTAX]) , TABLE1.B_SCODE, TABLE1.BOMBOI, TABLE1.BOMTAX"

        sqlstr = sqlstr + " union SELECT "" as LOTDB,"" as MC_DATE, S_PRE,"" as MC_PRDT_THAI, "" as MC_CLOSE,"" as MC_LOTQTY, iif([BOMBOI]>0,"", s_prdt, "" as BOMBOI, "" as BOMTAX, Sum(IIf([DB]='BOI' And [S_SLIP] Like 'MA',[QTY],0)) AS MABOI, Sum(IIf([DB]='TAX' And [S_SLIP] Like 'MA',[QTY],0)) AS MATAX, Sum(IIf([DB]='BOI' And [S_SLIP] Like 'MB' And [S_REA] Like 'B',[QTY],0)) AS MBBOI, Sum(IIf([DB]='TAX' And [S_SLIP] Like 'MB' And [s_REA] Like 'B',[QTY],0)) AS MBTAX"
        sqlstr = sqlstr + ",([MABOI]+[MATAX])-([MBBOI]+[MBTAX]) - [WE_QTY] as diff"
        sqlstr = sqlstr + " FROM stock left JOIN"
        sqlstr = sqlstr + " TABLE1  ON  (stock.S_PRE = TABLE1.MC_LOT)"
        sqlstr = sqlstr + " GROUP BY TABLE1.LOTDB,TABLE1.MC_DATE, S_PRE, TABLE1.MC_PRDT_THAI, TABLE1.MC_CLOSE, TABLE1.MC_LOTQTY, iif([BOMBOI]>0,[MC_QTY]*[bomboi],[mc_qty]*[BOMTAX]) , s_prdt, TABLE1.BOMBOI, TABLE1.BOMTAX;"




        'sqlstr = "SELECT MC_DATE, MC_LOT, MC_DEPT, MC_PRDT, MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, DATA1.S_PRDT, prdt_" & DB & ".P_ENAME"
        'sqlstr = sqlstr + ",P_TNAME, P_SPEC, DATA1.WEBOI, DATA1.WETAX, DATA1.s_date, DATA1.MABOI, DATA1.MATAX, DATA1.MBBOI, DATA1.MBTAX, DATA1.BOMBOI, DATA1.BOMTAX, (iif(isnull(maboi),0,maboi)+iif(isnull(matax),0,matax))-(iif(isnull(mbboi),0,mbboi)+iif(isnull(mbtax),0,mbtax))-(iif(isnull(weboi*bomboi),0,weboi*bomboi))-(iif(isnull(wetax*bomtax),0,wetax*bomtax)) AS diff"
        'sqlstr = sqlstr + " FROM ((SELECT StockDATA.S_PRE, StockDATA.S_PRDT, table1.WEBOI, table1.WETAX, table1.s_date, table1.BOMBOI, table1.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        'sqlstr = sqlstr + " FROM StockDATA LEFT JOIN table1 ON (StockDATA.S_PRE = table1.MC_LOT) AND (StockDATA.S_PRDT = table1.B_SCODE)  "
        'sqlstr = sqlstr + " union SELECT table1.MC_LOT, table1.B_SCODE, table1.WEBOI, table1.WETAX, table1.s_date, table1.BOMBOI, table1.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        'sqlstr = sqlstr + " FROM StockDATA RIGHT JOIN table1 ON (StockDATA.S_PRDT = table1.B_SCODE) AND (StockDATA.S_PRE = table1.MC_LOT) ) AS DATA1 INNER JOIN LOT ON DATA1.S_PRE = LOT.MC_LOT) LEFT JOIN prdt_" & DB & " ON DATA1.S_PRDT = prdt_" & DB & ".P_PRDT"

        'sqlstr = sqlstr + " order by mc_lot,s_prdt"




        sqlstr = "SELECT Step1.MC_LOT, Step1.MC_PRDT_THAI, BOMDB.B_SCODE, Step1.WEBOI, Step1.WETAX, Step1.s_date, BOMDB.BOMBOI, BOMDB.BOMTAX"
        sqlstr = sqlstr + " into step21 FROM BOMDB RIGHT JOIN Step1 ON BOMDB.B_PCODE = Step1.MC_PRDT_THAI"

        dtACC.RunCommand(SQLstr)


        sqlstr = "SELECT LOTDB,MC_DATE, S_PRE as MC_LOT, MC_DEPT, MC_PRDT, MC_PRDT_THAI, MC_CLOSE, MC_LOTQTY, MC_QTY, DATA1.S_PRDT, prdt_BOI.P_ENAME"
        sqlstr = sqlstr + ",P_TNAME, P_SPEC, DATA1.WEBOI, DATA1.WETAX, DATA1.s_date, DATA1.MABOI, DATA1.MATAX, DATA1.MBBOI, DATA1.MBTAX, DATA1.BOMBOI, DATA1.BOMTAX, (iif(isnull(maboi),0,maboi)+iif(isnull(matax),0,matax))-(iif(isnull(mbboi),0,mbboi)+iif(isnull(mbtax),0,mbtax))-(iif(isnull(weboi*bomboi),0,weboi*bomboi))-(iif(isnull(wetax*bomtax),0,wetax*bomtax)) AS diff"
        sqlstr = sqlstr + " FROM ((SELECT StockDATA.S_PRE, StockDATA.S_PRDT, step21.WEBOI, step21.WETAX, step21.s_date, step21.BOMBOI, step21.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        sqlstr = sqlstr + " FROM StockDATA LEFT JOIN step21 ON (StockDATA.S_PRE = step21.MC_LOT) AND (StockDATA.S_PRDT = step21.B_SCODE)  "
        sqlstr = sqlstr + " union SELECT step21.MC_LOT, step21.B_SCODE, step21.WEBOI, step21.WETAX, step21.s_date, step21.BOMBOI, step21.BOMTAX, StockDATA.MABOI, StockDATA.MATAX, StockDATA.MBBOI, StockDATA.MBTAX"
        sqlstr = sqlstr + " FROM StockDATA RIGHT JOIN step21 ON (StockDATA.S_PRDT = step21.B_SCODE) AND (StockDATA.S_PRE = step21.MC_LOT) ) AS DATA1 left JOIN LOTALL ON DATA1.S_PRE = LOTALL.MC_LOT) LEFT JOIN prdt_BOI ON DATA1.S_PRDT = prdt_BOI.P_PRDT"
        'sqlstr = sqlstr + " WHERE (((Left([S_PRE],1))<>'G') AND ((Left([S_PRE],2))<>'CL')) "
        sqlstr += " where s_prdt like '" & Prdt & "'"
        If REFcode <> "" Then sqlstr += " or s_prdt like '" & REFcode & "'"
        sqlstr = sqlstr + " order by LOTDB,MC_DATE"

        dtACC.QryDT(SQLstr)
        _ALLdt = dtACC.dt







    End Sub

End Class
