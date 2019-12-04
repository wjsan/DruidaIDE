Imports System.Net
Imports System.IO

Public Class CheckForUpdates
    Dim stringVersionToDownload As String = "https://onedrive.live.com/download?cid=01BE2F1A57D5C2BE&resid=1BE2F1A57D5C2BE%2110463&authkey=AGBcuk9ui-Rttz8"
    Dim linkEn As String = "https://binquantum.wordpress.com/#download"
    Dim linkPt As String = "https://binary-quantum.com/druida-ide-lite/#download"

    Public Sub CheckVersionFile()
        Dim client As New WebClient
        Try
            Dim version As String = client.DownloadString(stringVersionToDownload)
            If Not IsUpdated(version) Then
                Dim cultureResx As New CultureManager
                Dim r = cultureResx.ShowQuestion("Existe uma atualização disponível. Deseja realizar o download?")
                If r = DialogResult.Yes Then
                    If AppInfo.language = "en" Then
                        Process.Start(linkEn)
                    Else
                        Process.Start(linkPt)
                    End If
                    Application.Exit()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function IsUpdated(version As String) As Boolean
        Dim lastVersion() As String = version.Split(".")
        Dim majorIsUpdated As Boolean = My.Application.Info.Version.Major >= lastVersion(0)
        Dim minorIsUpdated As Boolean = My.Application.Info.Version.Minor >= lastVersion(1)
        Dim revisionIsUpdated As Boolean = My.Application.Info.Version.Build >= lastVersion(2)
        Dim buildIsUpdated As Boolean = My.Application.Info.Version.Revision >= lastVersion(3)
        If majorIsUpdated And minorIsUpdated And revisionIsUpdated And buildIsUpdated Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
