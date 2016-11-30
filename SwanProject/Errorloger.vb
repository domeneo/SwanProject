Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

<CLSCompliant(True)> _
Public Class ErrorLogger

    Public Sub New()

        'default constructor

    End Sub

    '*************************************************************
    'NAME:          WriteToErrorLog
    'PURPOSE:       Open or create an error log and submit error message
    'PARAMETERS:    msg - message to be written to error file
    '               stkTrace - stack trace from error message
    '               title - title of the error file entry
    'RETURNS:       Nothing
    '*************************************************************
    Public Sub WriteToErrorLog(ByVal msg As String, _
           ByVal stkTrace As String, ByVal title As String)

        'check and make the directory if necessary; this is set to look in 

    If Not System.IO.Directory.Exists(Application.StartupPath &  "\Errors\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\Errors\")
        End If

        'check the file
        Dim fs As FileStream = New FileStream(Application.StartupPath & "\Errors\errlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'log it
        Dim fs1 As FileStream = New FileStream(Application.StartupPath & "\Errors\errlog.txt", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)
        s1.Write("Title: " & title & vbCrLf)
        s1.Write("Message: " & msg & vbCrLf)
        s1.Write("StackTrace: " & stkTrace & vbCrLf)
        s1.Write("Date/Time: " & DateTime.Now.ToString() & vbCrLf)
        s1.Write("================================================" & vbCrLf)
        s1.Close()
        fs1.Close()

    End Sub

    Public Function WriteToEventLog(ByVal entry As String, _
                    Optional ByVal appName As String = "CompanyName", _
                    Optional ByVal eventType As  _
                    EventLogEntryType = EventLogEntryType.Information, _
                    Optional ByVal logName As String = "ProductName") As Boolean

        Dim objEventLog As New EventLog

        Try

            'Register the Application as an Event Source
            If Not EventLog.SourceExists(appName) Then
                EventLog.CreateEventSource(appName, LogName)
            End If

            'log the entry
            objEventLog.Source = appName
            objEventLog.WriteEntry(entry, eventType)

            Return True

        Catch Ex As Exception

            Return False

        End Try

    End Function

End Class
