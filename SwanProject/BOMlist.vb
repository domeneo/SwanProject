Imports System.IO
Imports OfficeOpenXml

Public Class BOMlist
    Dim dal As New dataACCcls
    Dim dalSQL As New dataSQLcls

    Private Sub BOMlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


        ' Dim ds As New DataSet

        ' Dim dt1,dt2 As New DataTable

        'dt1= dal.QryDT("select * from bom where b_pcode like 'CHVP2030000'",Project.md7_boi)
        ' dt2 = dal.QryDT("select * from bom", Project.md7_boi)

        ' Dim rel1 As New DataRelation("rel1", dt1.Columns("b_scode"), dt2.Columns("b_pcode"))
        ' ds.Relations.Add(rel1)


        ' Dim displayColumns As New List(Of String)
        ' displayColumns.Add("B_PCODE")
        ' displayColumns.Add("B_scode")
        ' displayColumns.Add("B_qty")

        '//////////////////////////////////
        'Dim sqlstr As String
        'Dim lv As Integer = 4
        'sqlstr = "SELECT BOM_BOI.B_PCODE, BOM_BOI.B_SCODE as PRDTLV1, BOM_BOI.B_QTY*" & txtqty.Text & " as QTYLV1"

        'For i = 2 To lv
        '    sqlstr = sqlstr + ", BOM_BOI_" & i - 1 & ".B_SCODE as PRDTLV" & i & ", [BOM_BOI_" & i - 1 & ".B_QTY]*QTYLV" & i - 1 & " AS QTYLV" & i
        'Next i

        'sqlstr = sqlstr + " into BOMqry FROM"

        'For i = 2 To lv
        '    sqlstr = sqlstr + "("
        'Next i

        'sqlstr = sqlstr + " BOM_BOI"

        'For i = 2 To lv
        '    sqlstr = sqlstr + " LEFT JOIN BOM_BOI AS BOM_BOI_" & i - 1 & " ON BOM_BOI" & IIf(i - 2 = 0, "", "_" & i - 2) & ".B_SCODE = BOM_BOI_" & i - 1 & ".B_PCODE)"
        'Next i

        'sqlstr = sqlstr + " WHERE (((BOM_BOI.B_PCODE)='" & txtprdt.Text & "'));"

        'OpenRS sqlstr, rs, conn

        'Dim prdtstr, Qtystr As String
        'i = lv
        'Do While i > 1
        '    prdtstr = prdtstr & "IIf([prdtlv" & Trim(Str(i)) & "] Is Not Null,[prdtlv" & Trim(Str(i)) & "],"
        '    Qtystr = Qtystr & "IIf([qtylv" & Trim(Str(i)) & "] Is Not Null,[qtylv" & Trim(Str(i)) & "],"
        '    i = i - 1
        'Loop
        'prdtstr = prdtstr & "[prdt]"
        'Qtystr = Qtystr & "[qty]"
        'For i = 1 To lv - 1
        '    prdtstr = prdtstr & ")"
        '    Qtystr = Qtystr & ")"
        'Next i
        'prdtstr = prdtstr & "as p_prdt"
        'Qtystr = Qtystr & "as p_qty"

        'sqlstr = "select " & prdtstr & "," & Qtystr & " into prdtDB2 from BOMqry"
        'conn.Execute sqlstr


    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        dalSQL.openConn(Project.swanSQL)

        If IsNumeric(txtQTY.Text) = False Then
            txtQTY.Text = 1
        End If
        Dim sqlstr As String
        sqlstr = "With BMStudy as (" +
  " select cast(bm.B_PCODE +'\' + bm.B_SCODE +'' as varchar(max)) as Broot,bm.B_PCODE, bm.B_SCODE, bm.B_QTY * " + txtQTY.Text + " as b_qty, 1 as BOMLevel " +
  " From BOM_BOI bm " +
  " where bm.B_PCODE in ('" + txtPRDT.Text.Replace(vbCrLf, "','") + "')" +
 "  UNION all" +
 "  select cast(Broot + '\' + bb.B_SCODE + '' as varchar(max)) as Broot, ba.B_PCODE, bb.B_SCODE, bb.B_QTY * ba.B_QTY , " +
  " (BOMLevel + 1) as BOMLevel " +
 "  from BMStudy ba join " +
   "     BOM_BOI bb " +
    "    on ba.B_SCODE = bb.B_PCODE " +
 " )" +
 " Select  Broot,B_SCODE,p.p_ename,sum(b_qty) as QTY,max(BOMLevel) as LEVEL from BMStudy left join prdt_boi as p on BMStudy.B_SCODE=p.p_prdt " +
  " group by b_scode,broot,p_ename  " +
  " order by max(BOMLevel) " +
 "  OPTION (MAXRECURSION 0)"

        Dim dt As New DataTable
        dalSQL.QryDT(sqlstr)
        dt = dalSQL.dt


        TV1.Nodes.Clear()

        For Each str As String In txtPRDT.Text.Split(vbCrLf)
            str = str.Replace(vbLf, "")
            TV1.Nodes.Add(str, str)
        Next

        For Each dr As DataRow In dt.Rows
            'Dim tn As New TreeNode
            'tn = TV1.Nodes.Add(dr("broot").ToString, dr("b_scode") & "=" & dr("QTY").ToString)
            If dr("level").ToString = "2" Then
                '  MsgBox("asd")
            End If
            Dim root As String = dr("broot").ToString.Substring(0, dr("broot").ToString.Length - 12)
            Dim MyNode() As TreeNode
            MyNode = TV1.Nodes.Find(root, True)
            Dim tn As New TreeNode
            tn = MyNode(0).Nodes.Add(dr("broot").ToString, dr("b_scode").ToString & " - " & dr("p_ename").ToString & " = " & dr("QTY").ToString)
            If dr("level").ToString = "1" Then
                tn.ForeColor = Color.Blue
            ElseIf dr("level").ToString = "2" Then
                tn.ForeColor = Color.Red
            ElseIf dr("level").ToString = "3" Then
                tn.ForeColor = Color.Orange
            ElseIf dr("level").ToString = "4" Then
                tn.ForeColor = Color.Green
            ElseIf dr("level").ToString = "5" Then
                tn.ForeColor = Color.Black
            ElseIf dr("level").ToString = "6" Then
                tn.ForeColor = Color.Magenta

            End If

        Next
        TV1.ExpandAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim SaveFileDialog1 As New SaveFileDialog

        SaveFileDialog1.Filter = "Excel File|*.xlsx"
        SaveFileDialog1.Title = "Save an Excel File"
        SaveFileDialog1.FileName = "BOM"
        ' SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.ShowDialog(Me)


        Dim newFile As New FileInfo(SaveFileDialog1.filename)
        Using pck As New ExcelPackage()


            'pck.File.Create()
            Dim ws As ExcelWorksheet = pck.Workbook.Worksheets.Add("Content")


            Dim str As String
            ' ws.View.ShowGridLines = False

            ' ws.Cells("A3:" & RunChar(DT.Columns.Count - 1) & DT.Rows.Count + 2).Value = StrAR
            ' ws.Cells("A3").Value = StrAR

            Excelrows = 1

            For Each n As TreeNode In TV1.Nodes

                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(1) & Excelrows).Value = n.Text
                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(1) & Excelrows).Style.Font.Color.SetColor(Color.Blue)
                Excelrows += 1
                If n.Nodes.Count > 0 Then
                    printnode(n, 1 + 1, ws)

                End If

            Next

            pck.SaveAs(newFile)

        End Using
    End Sub
    Dim Excelrows As Integer
    Sub printnode(Pnode As TreeNode, col As Integer, ws As ExcelWorksheet)
        For Each n As TreeNode In Pnode.Nodes


            If col = 2 Then

                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(col) & Excelrows).Style.Font.Color.SetColor(Color.Red)
            ElseIf col = 3 Then

                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(col) & Excelrows).Style.Font.Color.SetColor(Color.Orange)
            ElseIf col = 4 Then

                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(col) & Excelrows).Style.Font.Color.SetColor(Color.Green)
            ElseIf col = 5 Then

                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(col) & Excelrows).Style.Font.Color.SetColor(Color.Black)
            ElseIf col = 6 Then

                ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(col) & Excelrows).Style.Font.Color.SetColor(Color.Magenta)
            End If


            ws.Cells(ExporttoExcel_EP.ExcelColumnFromNumber(col) & Excelrows).Value = n.Text
            Excelrows += 1
            If n.Nodes.Count > 0 Then
                printnode(n, col + 1, ws)

            End If

        Next
    End Sub
End Class