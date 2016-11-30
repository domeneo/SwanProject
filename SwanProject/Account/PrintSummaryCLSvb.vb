Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Public Class PrintSummaryCLSvb

    Dim Printer As New Printer
    Private Sub HEAD_RTN()

        Printer.FontSize = 10
        Printer.FontBold = False
        Printer.Print()

        'Printer.Print("SWAN SIAM CORPORATION CO.,LTD.(BOI)")
        'Printer.Print TAB(140); "TAX ID:3011876497"
        ' Printer.Print TAB(2); "5/1 Moo 7 Tambon Bangpra Amphur Muang Chachoengsao 24000";
        ' Printer.Print TAB(140); "PRINT DATE:" & Format(Date, "YYYYMMDD")
        ' Printer.Print TAB(2); "Tel. (038) 516670-2   Fax. (038) 516669";
        ' c_page = c_page + 1
        'Printer.Print TAB(140); "PAGE:" & c_page
        ' Printer.Print()
        'Printer.FontSize = 11
        'Printer.FontBold = True
        'Printer.Print TAB(63); "SUMMARY  REPORT "
        ' Printer.Print()
        ''  Printer.FontName = "Times New Roman"
        'Printer.FontSize = 11
        'Printer.FontBold = False
        'Printer.Print TAB(2); "GROUP";
        ' Printer.Print TAB(21); C_SOURCE
        ' Printer.Print TAB(2); "PART CODE ";
        ' Printer.Print TAB(21); TXT_PRDT1;
        ' Printer.Print TAB(41); "TO";
        ' Printer.Print TAB(50); TXT_PRDT2
        ' Printer.Print TAB(2); "DATE ";
        ' Printer.Print TAB(21); TXT_TO
        ' Printer.Print TAB(2); "PART CODE";
        ' Printer.Print TAB(30); "PART NAME";
        ' Printer.Print TAB(60); "SPEC";
        ' Printer.Print TAB(104); "QTY";
        ' Printer.Print TAB(118); "U-PRICE";
        ' Printer.Print TAB(136); "AMOUNT"
        ' l_c = 0
    End Sub


End Class
