Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net



Public Class matchControl

    Private Ctrlconn As New SqlConnection(ConfigurationManager.ConnectionStrings("ctrl").ConnectionString)
    Public OutConnSQL As New SqlConnection
    Public OutConnAcc As New OleDbConnection
    Public OutDB As String
    Dim nullC As New NullCLS
    Private sqlstr As String
    Private dc As New dataSQLcls()

    Protected Function MatchSQL(ByVal showon As String) As String

        Dim str As String
        str = "select * from match_control where m_table like '" & showon & "'  order by m_order"

        Return str

    End Function
    Protected Function MatchSQLGV(ByVal showon As String) As String

        Dim str As String
        str = "select * from match_control where  m_table like '" & showon & "' and m_onGV is not null  order by m_onGV"

        Return str

    End Function
    Sub New()

        dc.conn = Ctrlconn

    End Sub
    Public Sub InitGV(ByVal showon As String, ByVal GV As DataGridView, TABLE As String)

        'dc.QryDT(MatchSQLGV(showon))

        'If dc.dt.Rows.Count > 0 Then
        '    For Each dr As DataRow In dc.dt.Rows
        '        Dim bf As New DataGridViewTextBoxColumn

        '        bf.DataPropertyName = dr("m_fields").ToString()
        '        bf.HeaderText = dr("m_fields").ToString()

        '        If dr("m_ftype").ToString() = "date" Then
        '            bf.DefaultCellStyle.Format = "{0:MM/dd/yyyy}"
        '        End If


        '        'GV.Columns.Insert(dr("C_ongv").ToString(), bf)
        '        GV.Columns.Add(bf)
        '    Next
        'End If




    End Sub


    Public Function CreateDT(showon As String) As DataTable
        Dim dt As New DataTable(showon)

        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count > 0 Then
            For Each dr As DataRow In dc.dt.Rows

                Dim dtc As New DataColumn(dr("m_fields").ToString)



                dt.Columns.Add(dtc)
            Next
        End If


        Return dt



    End Function

    Public Function SelectbyOrder(showon As String, onGV As Boolean) As String
        Dim str As String = ""
        If onGV Then
            dc.QryDT(MatchSQLGV(showon))
        Else
            dc.QryDT(MatchSQL(showon))
        End If

        If dc.dt.Rows.Count > 0 Then
            For Each dr As DataRow In dc.dt.Rows
                str += "," & dr("m_fields").ToString()

            Next
        End If
        If str.Length > 1 Then
            str = str.Substring(1)
        End If

        Return str
    End Function



    Public Function addContoGV(ByVal showon As String, ByVal dt As DataTable, ByVal [me] As Control, ByVal key As String) As DataRow


        Dim dr As DataRow = dt.NewRow()
        dc.QryDT(MatchSQLGV(showon))
        If dc.dt.Rows.Count > 0 Then
            For Each dr1 As DataRow In dc.dt.Rows
                ' If Not key.Contains(dr1("m_fields").ToString()) And dr1("m_con").ToString <> "" Then
                If dr1("m_con").ToString <> "" Then
                    Dim ct As Control() = [me].Controls.Find(dr1("m_con").ToString, True)
                    Dim str As String = ""
                    If Not ct Is Nothing And ct.Length > 0 Then
                        str = getString(ct(0))
                    End If
                    If dr1("m_ftype").ToString() = "date" AndAlso str = "" Then
                        dr(dr1("m_fields").ToString()) = DBNull.Value
                    Else
                        dr(dr1("m_fields").ToString()) = str
                    End If
                End If

            Next
        End If

        Return dr

    End Function

    Protected Function getString(ctrl As Control) As String
        If ctrl Is Nothing Then
            MsgBox("CANNOT FIND CONTROL")
            Exit Function
        End If
        Try
            Dim result As String


            If ctrl.[GetType]() Is GetType(TextBox) Then
                result = DirectCast(ctrl, TextBox).Text
            ElseIf ctrl.[GetType]() Is GetType(ComboBox) Then
                result = DirectCast(ctrl, ComboBox).SelectedValue

            ElseIf ctrl.[GetType]() Is GetType(Label) Then
                result = DirectCast(ctrl, Label).Text
            Else
                result = ""
            End If
            Return result
        Catch ex As Exception
            Return ""


        End Try

    End Function

    Public Sub GVrowtocon(ByVal showon As String, ByVal row As DataGridViewRow, ByVal [me] As Control)


        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count > 0 Then
            For i As Integer = 0 To dc.dt.Rows.Count - 3
                Dim ct As Control() = [me].Controls.Find(DirectCast(dc.dt.Rows(i)("m_con"), String), True)
                Dim str As String = ""
                If Not ct Is Nothing And ct.Length > 0 Then
                    str = getString(ct(0))

             
                    setCtrl(ct(0), nullC.NulltoString(row.Cells(DirectCast(dc.dt.Rows(i)("m_fields"), String)).Value))


                End If


                ' setCtrl([me].FindControl(DirectCast(dc.dt.Rows(i)("m_con"), String)), Modcls.Nullnbsp(row.Cells(i + 1).Text))
            Next
        End If
    End Sub

    Protected Sub setCtrl(ctrl As Object, value As String)
        If ctrl Is Nothing Then Exit Sub
        If ctrl.[GetType]() Is GetType(TextBox) Then
            DirectCast(ctrl, TextBox).Text = value
        ElseIf ctrl.[GetType]() Is GetType(ComboBox) Then
            Dim CB As ComboBox = DirectCast(ctrl, ComboBox)
            CB.SelectedValue = value
            If CB.SelectedValue Is Nothing Then CB.SelectedItem = value

        ElseIf ctrl.[GetType]() Is GetType(Label) Then
            DirectCast(ctrl, Label).Text = value

        ElseIf ctrl.[GetType]() Is GetType(ToolStripStatusLabel) Then
            DirectCast(ctrl, ToolStripStatusLabel).Text = value

        End If
    End Sub
    Public Sub DTtoGV(ByVal showon As String, GV As DataGridView, ParentCtrl As Control, inputDT As DataTable)
        If inputDT.Rows.Count = 0 Then
            Return
        End If
        dc.QryDT(MatchSQLGV(showon))
        If dc.dt.Rows.Count = 0 Then
            Return
        End If

        For Each idr As DataRow In inputDT.Rows



            Dim str As String = ""


            For Each dr As DataRow In dc.dt.Rows
                If dr("m_ongv").ToString <> "" Then



                    If dr("m_ongv").ToString <> 0 Then
                        str += "," & idr(dr("m_fields").ToString).ToString
                    End If
                End If
            Next
            str = str.Substring(1)
            ' GV.Rows.Add(str)

        Next


    End Sub


    Public Sub DTrowtocon(ByVal showon As String, ByVal iDT As DataTable, ByVal [me] As Control)


        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count = 0 Then
            Return
        End If

        If iDT.Rows.Count = 0 Then
            Return
        End If
        For Each dr As DataRow In dc.dt.Rows
            If dr("m_ongv").ToString = "" Then
                'If dr("m_key").ToString <> "" Then



                ' setCtrl([me].Controls(DirectCast(dr("m_key"), String)), iDT.Rows(0)(dr("m_fields").ToString()).ToString())
                setCtrl(FindControlRecursive([me], dr("m_key").ToString), iDT.Rows(0)(dr("m_fields").ToString()).ToString())

                'End If
                'If dr("m_fields").ToString = "s_rea" Then

                '    MsgBox("asdasd")
                'End If
                If dr("m_ftype").ToString() = "date" Then
                    setCtrl([me].Controls(DirectCast(dr("m_con"), String)), Modcls.ConvertDate(iDT.Rows(0)(dr("m_fields").ToString()).ToString()))
                Else
                    setCtrl([me].Controls(DirectCast(dr("m_con"), String)), iDT.Rows(0)(dr("m_fields").ToString()).ToString())
                End If
            End If
        Next
    End Sub



    Public Sub updateSQL(ByVal Table As String, ByVal showon As String, ByVal [me] As Control, ByVal Key As String, conn As Object, Optional ByVal ExStr As String = "")
        Dim wheresql As String = "", rowsql As String = ""
        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count > 0 Then



            sqlstr = "update " & Table & " set "


            For Each dr As DataRow In dc.dt.Rows

                ' If Not Key.Contains(dr("m_fields").ToString()) Then
                If dr("M_ONGV").ToString <> "" Then Continue For
                If dr("m_ftype").ToString() = "number" Then
                    rowsql += ",[" & Convert.ToString(dr("m_fields")) & "]=" & Modcls.NullDate(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""
                Else
                    rowsql += ",[" & Convert.ToString(dr("m_fields")) & "]='" & getString([me].Controls(DirectCast(dr("m_con"), String))) & "'"
                End If
                ' Else

                If dr("m_key").ToString <> "" Then

                    wheresql += "and " & dr("m_fields").ToString & " like '" & FindControlRecursive([me], dr("m_key").ToString).Text & "'"


                End If
                'wheresql += "and " & Convert.ToString(dr("m_fields")) & " like '" & getString([me].Controls(DirectCast(dr("m_con"), String))) & "'"
                'End If
            Next

            wheresql = wheresql.Substring(3)
            wheresql = " where " & wheresql
            rowsql = rowsql.Substring(1)
            sqlstr += rowsql & ExStr & wheresql




            sqlstr += ""


            If conn.[GetType]() Is GetType(SqlConnection) Then
                conn = DirectCast(conn, SqlConnection)
                Dim aDc As New dataSQLcls
                aDc.conn = conn
                aDc.RunCommand(sqlstr)
            ElseIf conn.[GetType]() Is GetType(OleDbConnection) Then
                conn = DirectCast(conn, OleDbConnection)
                Dim aDc As New dataACCcls
                aDc.conn = conn
                aDc.RunCommand(sqlstr)
            End If



            'If OutDB = "ACC" Then
            '    Dim odc As New dataACCcls
            '    odc.conn = OutConnAcc
            '    odc.RunCommand(sqlstr)
            'ElseIf OutDB = "SQL" Then
            '    Dim odc As New dataSQLcls
            '    odc.conn = OutConnSQL
            '    odc.RunCommand(sqlstr)
            'End If
        End If
    End Sub





    Public Sub insertSQLGV(ByVal Table As String, ByVal showon As String, ByVal [me] As Control, ByVal gv1 As DataGridView, ByVal key As String, ByVal connw As Object)


        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count = 0 Then
            Return
        End If
        If gv1.Rows.Count = 0 Then
            Return
        End If

        For i As Integer = 0 To gv1.Rows.Count - 1
            If gv1.Rows(i).Cells(0).Value Is Nothing Then Continue For
            sqlstr = "  "
            sqlstr += "insert into " & Table & "("
            Dim fsql As String = "", vsql As String = ""
            For Each dr As DataRow In dc.dt.Rows
                If Not key.Contains(dr("m_fields").ToString()) Then
                    fsql += ",[" & Convert.ToString(dr("m_fields")) & "]"
                    If dr("m_ongv").ToString() <> "" Then


                        If dr("m_ftype").ToString() = "date" Then

                            vsql += "," & Modcls.NullDate(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & ""

                        ElseIf dr("m_ftype").ToString() = "number" Then
                            ' vsql += "," & Modcls.NullstringToZero(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & ""

                            vsql += "," & Modcls.NullstringtoNull(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & ""

                        Else
                                vsql += ",'" & Modcls.Nullnbsp(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & "'"
                        End If
                    Else

                        If dr("m_ftype").ToString() = "date" Then

                            vsql += "," & Modcls.NullDate(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""
                        ElseIf dr("m_ftype").ToString() = "number" Then
                            'vsql += "," & Modcls.NullstringToZero(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""
                            vsql += "," & Modcls.NullstringtoNull(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""

                        Else
                            vsql += ",'" & Modcls.Nullnbsp(getString([me].Controls(DirectCast(dr("m_con"), String)))) & "'"
                        End If
                    End If
                End If
            Next
            vsql = vsql.Substring(1)
            fsql = fsql.Substring(1)

            sqlstr += fsql & ") values(" & vsql & ") "



            If connw.[GetType]() Is GetType(SqlConnection) Then
                connw = DirectCast(connw, SqlConnection)
                Dim aDc As New dataSQLcls
                aDc.conn = connw
                aDc.RunCommand(sqlstr)
            ElseIf connw.[GetType]() Is GetType(OleDbConnection) Then
                connw = DirectCast(connw, OleDbConnection)
                Dim aDc As New dataACCcls
                aDc.conn = connw
                aDc.RunCommand(sqlstr)
            End If

            dc.conn = Ctrlconn
        Next

    End Sub
    Public Sub insertSQLGV_CONNstr(ByVal Table As String, ByVal showon As String, ByVal [me] As Control, ByVal gv1 As DataGridView, ByVal key As String, ByVal CONNSTR As String, Optional NOTINSERTWHENZERO As String = "", Optional timestampCol As String = "")


        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count = 0 Then
            Return
        End If
        If gv1.Rows.Count = 0 Then
            Return
        End If
        Using conn As New OleDb.OleDbConnection


            conn.ConnectionString = CONNSTR
            conn.Open()

            Using comm As New OleDb.OleDbCommand

                comm.Connection = conn


                dc.conn = Ctrlconn


                For i As Integer = 0 To gv1.Rows.Count - 1
                    If gv1.Rows(i).Cells(0).Value Is Nothing Then Continue For


                    If NOTINSERTWHENZERO <> "" Then
                        If gv1.Rows(i).Cells(NOTINSERTWHENZERO).Value.ToString = "0" Or gv1.Rows(i).Cells(NOTINSERTWHENZERO).Value.ToString = "" Then
                            Continue For
                        End If

                    End If
                    sqlstr = "  "
                    sqlstr += "insert into " & Table & "("
                    Dim fsql As String = "", vsql As String = ""
                    For Each dr As DataRow In dc.dt.Rows
                        If Not key.Contains(dr("m_fields").ToString()) Then
                            fsql += ",[" & Convert.ToString(dr("m_fields")) & "]"
                            If dr("m_ongv").ToString() <> "" Then
                                If dr("m_ftype").ToString() = "date" Then

                                    vsql += "," & Modcls.NullDate(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & ""
                                Else
                                    vsql += ",'" & Modcls.Nullnbsp(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & "'"
                                End If
                            Else

                                If dr("m_ftype").ToString() = "date" Then

                                    vsql += "," & Modcls.NullDate(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""
                                Else
                                    vsql += ",'" & Modcls.Nullnbsp(getString([me].Controls(DirectCast(dr("m_con"), String)))) & "'"
                                End If
                            End If
                        End If
                    Next


                    If timestampCol <> "" Then
                        fsql += "," & timestampCol
                        vsql += ",now()"

                    End If


                    vsql = vsql.Substring(1)
                    fsql = fsql.Substring(1)

                    sqlstr += fsql & ") values(" & vsql & ") "


                    comm.CommandText = sqlstr
                    comm.ExecuteNonQuery()

                Next



            End Using

        End Using
    End Sub
    Public Sub insertSQLGV_CONNstrSQL(ByVal Table As String, ByVal showon As String, ByVal [me] As Control, ByVal gv1 As DataGridView, ByVal key As String, ByVal CONNSTR As String, Optional NOTINSERTWHENZERO As String = "", Optional timestampCol As String = "")


        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count = 0 Then
            Return
        End If
        If gv1.Rows.Count = 0 Then
            Return
        End If


        dc.conn = Ctrlconn
        sqlstr = ""
        For i As Integer = 0 To gv1.Rows.Count - 1
            If gv1.Rows(i).Cells(0).Value Is Nothing Then Continue For


            If NOTINSERTWHENZERO <> "" Then
                If gv1.Rows(i).Cells(NOTINSERTWHENZERO).Value.ToString = "0" Or gv1.Rows(i).Cells(NOTINSERTWHENZERO).Value.ToString = "" Then
                    Continue For
                End If

            End If

            sqlstr += "insert into " & Table & "("
            Dim fsql As String = "", vsql As String = ""
            For Each dr As DataRow In dc.dt.Rows
                If Not key.Contains(dr("m_fields").ToString()) Then
                    fsql += ",[" & Convert.ToString(dr("m_fields")) & "]"
                    If dr("m_ongv").ToString() <> "" Then
                        If dr("m_ftype").ToString() = "date" Then

                            vsql += "," & Modcls.NullDate(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & ""
                        Else
                            vsql += ",'" & Modcls.Nullnbsp(gv1.Rows(i).Cells(CStr(dr("m_con"))).Value) & "'"
                        End If
                    Else

                        If dr("m_ftype").ToString() = "date" Then

                            vsql += "," & Modcls.NullDate(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""
                        Else
                            vsql += ",'" & Modcls.Nullnbsp(getString([me].Controls(DirectCast(dr("m_con"), String)))) & "'"
                        End If
                    End If
                End If
            Next



            If timestampCol <> "" Then
                fsql += "," & timestampCol
                vsql += ",getdate()"

            End If
            vsql = vsql.Substring(1)
            fsql = fsql.Substring(1)



            sqlstr += fsql & ") values(" & vsql & "); "

        Next

        Using conn As New SqlConnection


                conn.ConnectionString = CONNSTR
                conn.Open()

                Using comm As New SqlCommand

                    comm.Connection = conn

                comm.CommandText = sqlstr
                comm.ExecuteNonQuery()


            End Using

        End Using
    End Sub

    Public Sub insertSQL(ByVal Table As String, ByVal showon As String, ByVal [me] As Control, ByVal key As String, conn As Object, InsertKey As Boolean)


        dc.QryDT(MatchSQL(showon))
        If dc.dt.Rows.Count = 0 Then
            Return
        End If


        sqlstr = ""
        sqlstr += "insert into " & Table & "("
        Dim fsql As String = "", vsql As String = ""
        For Each dr As DataRow In dc.dt.Rows
            If Not key.Contains(dr("m_fields").ToString()) Or InsertKey Then
                fsql += ",[" & Convert.ToString(dr("m_fields")) & "]"

                If dr("m_ftype").ToString() = "number" Then

                    vsql += "," & Modcls.NullDate(getString([me].Controls(DirectCast(dr("m_con"), String)))) & ""
                Else
                    vsql += ",'" & Modcls.Nullnbsp(getString([me].Controls(DirectCast(dr("m_con"), String)))) & "'"

                End If
            End If
        Next
        vsql = vsql.Substring(1)
        fsql = fsql.Substring(1)

        sqlstr += fsql & ") values(" & vsql & ")"


        If conn.[GetType]() Is GetType(SqlConnection) Then
            conn = DirectCast(conn, SqlConnection)
            Dim aDc As New dataSQLcls
            aDc.conn = conn
            aDc.RunCommand(sqlstr)
        ElseIf conn.[GetType]() Is GetType(OleDbConnection) Then
            conn = DirectCast(conn, OleDbConnection)
            Dim aDc As New dataACCcls
            aDc.conn = conn
            aDc.RunCommand(sqlstr)
        End If



        'If OutDB = "ACC" Then
        '    Dim odc As New dataACCcls
        '    odc.conn = OutConnAcc
        '    odc.RunCommand(sqlstr)
        'ElseIf OutDB = "SQL" Then
        '    Dim odc As New dataSQLcls
        '    odc.conn = OutConnSQL
        '    odc.RunCommand(sqlstr)
        'End If



    End Sub
End Class

