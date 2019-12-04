Imports System.Text.RegularExpressions
Imports System.Drawing.Text
Imports Druida_IDE_Lite.Objects

''' <summary>
''' Collection of Text Manipulation common methods
''' </summary>
Public Class TextTreatment
    Shared Function Normalize(text As String) As String
        Return Regex.Replace(text, "[^0-9a-zA-Z_]+", "")
    End Function
    Shared Function NumbersOnly(text As String) As String
        Dim digitsOnly As Regex = New Regex("[^\d]")
        Return digitsOnly.Replace(text, "")
    End Function
    Shared Function removeDoubleSpaces(text As String) As String
        For i = 0 To text.Length
            text = Regex.Replace(text, "  ", " ")
        Next
        Return text
    End Function
    Shared Function removeDoubleComments(text As String) As String
        For i = 0 To text.Length
            text = Regex.Replace(text, "///", "//")
        Next
        Return text
    End Function
End Class

Public Class FontAnalyser
    Shared Function IsFixedWidth(fontFamilie As FontFamily) As Boolean
        If fontFamilie.IsStyleAvailable(FontStyle.Regular) Then
            Dim diff As Double
            Using font As Font = New Font(fontFamilie, 16)
                diff = TextRenderer.MeasureText("WWW", font).Width - TextRenderer.MeasureText("...", font).Width
            End Using
            If Math.Abs(diff) < Double.Epsilon * 2 Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
