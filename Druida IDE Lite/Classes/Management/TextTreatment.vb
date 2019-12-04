Imports System.Text.RegularExpressions
Imports System.Drawing.Text
Imports Druida_IDE_Lite.Objects
Imports System.Web
Imports System.Text

'' <summary>
'' Collection of Text Manipulation common methods
'' </summary>
Public Class TextTreatment
    Shared Function LettersAndSpace(text As String) As String
        Dim name As String = HttpUtility.UrlEncode(text, Encoding.GetEncoding(28597)).Replace("+", " ")
        Return name
    End Function
    Shared Function OnlyLetters(text As String) As String
        Dim name As String = HttpUtility.UrlEncode(text, Encoding.GetEncoding(28597)).Replace("+", " ")
        Return name.Replace(" ", "_")
    End Function
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

Public Class InstallFonts
    Public Sub Install()
        Try
            Dim dir As New System.IO.DirectoryInfo(AppInfo.Directories.app & "\Custom Fonts")
            Dim files() As System.IO.FileInfo = dir.GetFiles
            For Each file As System.IO.FileInfo In files
                If file.Extension = ".ttf" Or file.Extension = ".otf" Then
                    FontUtil.InstallFont(file.FullName)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class

Public Class FontAnalyser
    Shared Function IsFixedWidth(fontFamilie As FontFamily) As Boolean
        If fontFamilie.IsStyleAvailable(FontStyle.Regular) Then
            Dim diff As Double
            Using font As Font = New Font(fontFamilie, 16)
                diff = TextRenderer.MeasureText("WWW", font).Width - TextRenderer.MeasureText("...", font).Width
            End Using
            If Math.Abs(diff) < Double.Epsilon * 2.5 Then
                Return True
            End If
        End If
        Return False
    End Function
End Class

Public Class FontUtil

    Private Declare Function AddFontResource Lib "gdi32" Alias "AddFontResourceA" (ByVal lpFileName As String) As Long
    Private Declare Function RemoveFontResource Lib "gdi32" Alias "RemoveFontResourceA" (ByVal lpFileName As String) As Long

    '' <summary>
    '' Instala a fonte no sistema
    '' </summary>
    '' <param name="FileName">Nome do Ficheiro</param>
    Public Shared Function InstallFont(ByVal FileName As String) As Boolean
        InstallFont = AddFontResource(FileName) <> 0
    End Function

    '' <summary>
    '' Desinstala a fonte no sistema
    '' </summary>
    '' <param name="FileName">Nome do Ficheiro</param>
    Public Shared Function UninstallFont(ByVal FileName As String) As Boolean
        UninstallFont = RemoveFontResource(FileName) <> 0
    End Function

End Class