Imports System.Text.RegularExpressions
Imports System.Drawing.Text

Public Class TextTreatment

    Shared Function Normalize(text As String) As String
        Return Regex.Replace(text, "[^0-9a-zA-Z]+", "")
    End Function
End Class
