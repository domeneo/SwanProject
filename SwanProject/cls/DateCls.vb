
Public Class DateCls
    Function Checkdate(strIn As String) As Boolean
        Dim StrDate As String
        StrDate = Right(strIn, 2) & "/" & Mid$(strIn, 5, 2) & "/" & Left$(strIn, 4)
        Dim d As Date
        If Date.TryParseExact(StrDate, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, d) Then
            Checkdate = True
            Exit Function
        End If
        MsgBox("Please Check Date")
        Checkdate = False

    End Function
    Public Function ConvertDate(ByVal strtmp As String) As String
        Dim testdate As DateTime
        If strtmp <> "" Then
            testdate = Convert.ToDateTime(strtmp)
            strtmp = Convert.ToString(testdate.ToString("MM/dd/yyyy"))
        Else
            strtmp = ""
        End If
        Return strtmp
    End Function


    Public Function TimeTOstring(ByVal itime As DateTime) As String
        Dim H As Integer
        H = itime.Hour
        'If itime.Hour < 5 Then
        '    H = H + 24
        'End If
        TimeTOstring = H & Add0(itime.Minute) & Add0(itime.Second)
    End Function
    Public Function DateTOstring(ByVal itime As DateTime) As String
        'If itime.Hour < 5 Then
        '    itime = itime.AddDays(-1)
        'End If
        DateTOstring = itime.Year & Add0(itime.Month) & Add0(itime.Day)
    End Function
    Public Function Date120TOstring(ByVal itime As String) As String
        'If itime.Hour < 5 Then
        '    itime = itime.AddDays(-1)
        'End If
        ' Date120TOstring = itime.Year & Add0(itime.Month) & Add0(itime.Day)

        Date120TOstring = itime.Substring(0, 4) & itime.Substring(5, 2) & itime.Substring(8, 2)
    End Function

    Public Function StrtoDatetime(ByVal iDate As String, ByVal iTime As String) As DateTime
        'Format คือ Date="20130701" time="122123"
        Dim iYear, iMonth, iDay, iHour, iMinute, iSec As String
        Dim strDATE As String
        While iTime.Length < 6
            iTime = "0" & iTime
        End While
        iYear = iDate.Substring(0, 4)
        iMonth = iDate.Substring(4, 2)
        iDay = iDate.Substring(6, 2)
        iHour = iTime.Substring(0, 2)
        iMinute = iTime.Substring(2, 2)
        iSec = iTime.Substring(4, 2)
        If iHour >= 24 Then
            iHour = iHour - 24
            strDATE = "" & iYear & "/" & iMonth & "/" & iDay & " " & iHour & ":" & iMinute & ":" & iSec & ""
            Date.TryParseExact(strDATE, "yyyy/MM/dd HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, StrtoDatetime)
            StrtoDatetime = StrtoDatetime.AddDays(1)
        Else
            strDATE = "" & iYear & "/" & iMonth & "/" & iDay & " " & iHour & ":" & iMinute & ":" & iSec & ""
            Date.TryParseExact(strDATE, "yyyy/MM/dd HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, StrtoDatetime)
        End If


    End Function

    Public Function DbLtimeTOstring(ByVal val As Double) As DateTime
        Dim str As String
        str = val
        While str.Length < 6
            str = "0" & str
        End While
        DbLtimeTOstring = "#" & str.Substring(0, 2) & ":" & str.Substring(2, 2) & ":" & str.Substring(4, 2) & "#"


    End Function




    Public Function MonthDiff(ByVal fromDate As String, ByVal toDate As String) As Integer
        Dim fdate, tdate As Date
        fdate = StrtoDatetime(fromDate, "000000")
        tdate = StrtoDatetime(toDate, "000000")
        MonthDiff = DateDiff(DateInterval.Month, fdate, tdate)


    End Function
    Public Function dbDatetoString(ByVal obj As Object) As String
        If obj.ToString = "" Then
            Return ""
        Else
            Dim iDate As DateTime
            iDate = CDate(obj)
            Return DateTOstring(iDate)

        End If

    End Function
End Class
