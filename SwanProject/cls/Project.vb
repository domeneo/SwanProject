Imports System.Configuration
Public Class Project
    Public Shared User As String
    Public Shared Group As String


    Public Shared md7_boi As String = ConfigurationManager.ConnectionStrings("md7_boi").ConnectionString
    Public Shared md7_tax As String = ConfigurationManager.ConnectionStrings("md7_tax").ConnectionString
    Public Shared md2_boi As String = ConfigurationManager.ConnectionStrings("md2_boi").ConnectionString
    Public Shared md2_tax As String = ConfigurationManager.ConnectionStrings("md2_tax").ConnectionString
    Public Shared md5_boi As String = ConfigurationManager.ConnectionStrings("md5_boi").ConnectionString
    Public Shared md5_tax As String = ConfigurationManager.ConnectionStrings("md5_tax").ConnectionString
    Public Shared md3p As String = ConfigurationManager.ConnectionStrings("md3p").ConnectionString
    Public Shared checkbal As String = ConfigurationManager.ConnectionStrings("checkbal").ConnectionString
    Public Shared swanpath As String = ConfigurationManager.ConnectionStrings("swanacc").ConnectionString
    Public Shared swanSQL As String = ConfigurationManager.ConnectionStrings("swan").ConnectionString

End Class
