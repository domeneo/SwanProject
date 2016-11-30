Public Class NullCLS


    Function NulltoDBL(ByVal obj As Object) As Double
        If TypeOf (obj) Is DBNull Then
            NulltoDBL = 0
        Else
            NulltoDBL = CDbl(obj)
        End If
    End Function
    Function NulltoString(ByVal obj As Object) As String
        If TypeOf (obj) Is DBNull Then
            NulltoString = ""
        Else
            NulltoString = CStr(obj)
        End If
    End Function
End Class
