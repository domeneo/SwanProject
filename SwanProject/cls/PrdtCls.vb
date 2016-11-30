Imports System.Configuration
Imports System.Data.SqlClient
Public Class PrdtCls
    Dim _PRDT, _NAME, _SPEC, _USEDB, _PLACE As String
    Dim _Backlog, _Bal, _Price As Double
    'Dim dtc As New dataSQLcls
    'Private conn As New SqlConnection(ConfigurationManager.ConnectionStrings("swan").ConnectionString)
    Dim dtc As New dataACCcls
    Private conn As New OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings("swanacc").ConnectionString)

    Public Property PRDT As String
        Get
            Return _PRDT
        End Get
        Set(ByVal value As String)
            _PRDT = value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _NAME
        End Get
        Set(ByVal value As String)
            _NAME = value
        End Set
    End Property
    Public Property SPEC As String
        Get
            Return _SPEC
        End Get
        Set(ByVal value As String)
            _SPEC = value
        End Set
    End Property
    Public Property USEDB As String
        Get
            Return _USEDB
        End Get
        Set(ByVal value As String)
            _USEDB = value
        End Set
    End Property
    Public Property Backlog As Double
        Get
            Return _Backlog
        End Get
        Set(ByVal value As Double)
            _Backlog = value
        End Set
    End Property
    Public Property Bal As Double
        Get
            Return _Bal
        End Get
        Set(ByVal value As Double)
            _Bal = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return _Price
        End Get
        Set(ByVal value As Double)
            _Price = value
        End Set
    End Property
    Public Property PLACE As String
        Get
            Return _PLACE
        End Get
        Set(ByVal value As String)
            _PLACE = value
        End Set
    End Property
    Function GETBAL(PRDT As String, DB As String)



        dtc.conn = conn
        Dim bal As String = dtc.ExScalar("select P_BAL from Prdt_" & DB & " where P_Prdt like '" & PRDT & "'").ToString
        If bal = "" Then

            Return 0
        Else
            Return CDbl(bal)
        End If
    End Function

    Function GETPrice(PRDT As String, DB As String)



        dtc.conn = conn
        Dim bal As String = dtc.ExScalar("select P_Last from Prdt_" & DB & " where P_Prdt like '" & PRDT & "'").ToString
        If bal = "" Then

            Return 0
        Else
            Return CDbl(bal).ToString("0.00")
        End If
    End Function


    Sub GetDATA(Prdt As String, DB As String)
        dtc.conn = conn
        dtc.QryDT("select P_PRDT,P_Ename,P_SPEC," & IIf(DB = "BOI", "P_USEDB,", "") & "P_BACKLOG,P_BAL,P_LAST,P_PLACE from Prdt_" & DB & " where P_Prdt like '" & Prdt & "'")
        If dtc.dt.Rows.Count = 0 Then
            _PRDT = ""
            _NAME = ""
            _SPEC = ""
            _USEDB = ""
            _PLACE = ""

            _Backlog = 0
            _Bal = 0
            _Price = 0
        Else
            _PRDT = dtc.dt.Rows(0)("P_PRDT").ToString
            _NAME = dtc.dt.Rows(0)("P_Ename").ToString
            _SPEC = dtc.dt.Rows(0)("P_SPEC").ToString
            If DB = "BOI" Then _USEDB = dtc.dt.Rows(0)("P_USEDB").ToString

            If dtc.dt.Rows(0)("P_BACKLOG").ToString = "" Then dtc.dt.Rows(0)("P_BACKLOG") = 0
            If dtc.dt.Rows(0)("P_BAL").ToString = "" Then dtc.dt.Rows(0)("P_BAL") = 0
            If dtc.dt.Rows(0)("P_LAST").ToString = "" Then dtc.dt.Rows(0)("P_LAST") = 0
            _Backlog = dtc.dt.Rows(0)("P_BACKLOG").ToString
            _Bal = dtc.dt.Rows(0)("P_BAL").ToString
            _Price = dtc.dt.Rows(0)("P_LAST").ToString
                _PLACE = dtc.dt.Rows(0)("P_PLACE").ToString
            End If
    End Sub
End Class
