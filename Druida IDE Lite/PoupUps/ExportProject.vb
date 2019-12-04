Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression

Public Class ExportProject

    Dim applicationDirectory As String = CurrentProjectInfo.DirectoryPaths.projectDirectory
    Dim destiny As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        CreateFile()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Export_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbDirectory.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida\"
        destiny = tbDirectory.Text
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim createApp As FolderBrowserDialog = New FolderBrowserDialog With {
            .SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida\"
        }
        createApp.ShowDialog()
        tbDirectory.Text = createApp.SelectedPath
        destiny = createApp.SelectedPath
    End Sub

    Private Sub CreateFile()
        If validPath Then
            ZipFiles()
        End If
    End Sub

    Private Function validPath() As Boolean
        If tbName.Text = "" Or tbName Is Nothing Then
            MessageBox.Show("Digite o nome da nova aplicação.")
            Return False
        End If
        destiny = tbDirectory.Text
        Return True
    End Function

    Private Sub ZipFiles()
        Dim directory As New DirectoryInfo(CurrentProjectInfo.DirectoryPaths.projectDirectory)
        Compress(directory)
    End Sub

    Private Sub SearchLibs()

    End Sub

    Private Sub CopyLibsToDir()

    End Sub

    Private Sub RemoveLibs()

    End Sub

    Private Sub Compress(directorySelected As DirectoryInfo)

    End Sub

End Class
