Imports System.Data.SqlClient
Imports System.Configuration
Public Class StockCLS
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim connACC As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)
    Dim dtSQL As New dataSQLcls
    Dim dtACC As New dataACCcls
    Dim SQLstr As String
    Sub New()
        dtSQL.conn = conn
        dtACC.conn = connACC
    End Sub
    Function getLockDate(ByVal DB As String)
        SQLstr = "select C_DATE from LOCKDATE_" & DB
        Return dtACC.ExScalar(SQLstr)
    End Function
    Function getWENO(ByVal DB As String)
        Return dtACC.ExScalar("select we_no from weno_" & DB)
    End Function

    Function getLastPrice(ByVal DB As String, PRDT As String)
        ' Return dtACC.ExScalar("select top 1 s_BPRICE from STOCK_" & DB & " where s_Bprice>0 and s_prdt like '" & PRDT & "' order by s_date desc,s_slip,s_code desc")
        Dim connstr As String
        If DB = "BOI" Then
            connstr = Project.md2_boi
        Else
            connstr = Project.md2_tax
        End If
        Return dtACC.ExScalar("select top 1 s_BPRICE from STOCK where s_Bprice>0 and s_prdt like '" & PRDT & "' order by s_date desc,s_slip,s_code desc", connstr)

    End Function
    Sub incWENO(ByVal DB As String)
        SQLstr = "update  weno_" & DB & " set we_no=we_no + 1"
        dtSQL.RunCommand(SQLstr)
        SQLstr = "update  weno_" & DB & " set we_no=we_no + 1"
        dtACC.RunCommand(SQLstr)

    End Sub

    Function getMANO(ByVal DB As String)
        Return dtACC.ExScalar("select ma_no from mano_" & DB)
    End Function
    Sub incMANO(ByVal DB As String)
        SQLstr = "update  mano_" & DB & " set ma_no=ma_no + 1"
        dtSQL.RunCommand(SQLstr)

        SQLstr = "update  mano_" & DB & " set ma_no=ma_no + 1"
        dtACC.RunCommand(SQLstr)
    End Sub
    Function getMBNO(ByVal DB As String)
        Return dtACC.ExScalar("select mb_no from mbno_" & DB)
    End Function
    Sub incMBNO(ByVal DB As String)
        SQLstr = "update  mbno_" & DB & " set mb_no=mb_no + 1"
        dtSQL.RunCommand(SQLstr)

        SQLstr = "update  mbno_" & DB & " set mb_no=mb_no + 1"
        dtACC.RunCommand(SQLstr)

    End Sub
    Function getBAL(ByVal DB As String, ByVal Prdt As String)
        Return dtACC.ExScalar("select P_bal from prdt_" & DB & " where P_prdt like '" & Prdt & "'")
    End Function
End Class
