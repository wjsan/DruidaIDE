Imports System.IO
Imports System.Text

Module ErrorsTranslation
    Public errorsTranslate As New ErrorsTranslateEngine
End Module

Public Class ErrorsTranslateEngine
    Private GeneralErrors As New List(Of String)
    Private TranslatedErrors As New List(Of String)

    Public Sub New()
        Dim errorsText = My.Resources.Errors.Replace(vbLf, "")
        Dim errorsPT = My.Resources.Errors_PT.Replace(vbLf, "")
        GeneralErrors.AddRange(errorsText.Split(vbCr))
        TranslatedErrors.AddRange(errorsPT.Split(vbCr))
    End Sub

    Public Function Translate(errorText As String) As String
        Translate = errorText
        If errorText.Contains("error:") Then
            Translate = errorText.Remove(0, errorText.IndexOf("error:")).Replace("error: ", "")
            errorText = errorText.Remove(0, errorText.IndexOf("error:")).Replace("error: ", "")
        End If
        If errorText.Contains("warning:") Then
            Translate = errorText.Remove(0, errorText.IndexOf("warning:")).Replace("warning: ", "")
            errorText = errorText.Remove(0, errorText.IndexOf("warning:")).Replace("warning: ", "")
            If errorText.Contains("[") Then
                errorText = errorText.Remove(errorText.IndexOf("["), errorText.Count - errorText.IndexOf("["))
            End If
            Translate = errorText
        End If
        If CultureManager.currentCulture <> "en" Then
            For Each item In GeneralErrors
                If errorText.Contains(item) Then
                    Translate = Translate.Replace(item, TranslatedErrors(GeneralErrors.IndexOf(item)))
                End If
            Next
        End If
        Return Translate
    End Function
End Class
