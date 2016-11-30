Public Class LoginFrm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Login As New LoginCls
        Login.authenticate(UsernameTextBox.Text, PasswordTextBox.Text)
        Dim MDIfrm As New MDIParent1
        MDIfrm.lblUser.Text = Login.Uname
        MDIfrm.lblGroup.Text = Login.Group

        Project.User = Login.Uname
        Project.Group = Login.Group

        MDIfrm.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SwanProject Version " + Application.ProductVersion + " - 20160905"



    End Sub


    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim oskID = System.Diagnostics.Process.Start("c:\windows\SysWOW64\osk.exe")
        '  Process.Start("c:\Temp\osk.exe")

        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start(osk)
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start(osk)
        End If
    End Sub
End Class
