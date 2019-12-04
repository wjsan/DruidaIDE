Imports System.IO
Imports DruidaIDEAuxiliarControls
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class HomePage
    Public Sub ApplyTheme()
        Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckRecentFiles()
        ApplyTheme()
        TranslateInterface()
    End Sub

    Public Sub TranslateInterface()
        Dim cultureResx As New CultureManager
        itNewProject.BtText = cultureResx.translateText("Novo Projeto")
        itOpenProject.BtText = cultureResx.translateText("Abrir Projeto")
        itOpenFile.BtText = cultureResx.translateText("Abrir Arquivo")
        itNewLib.BtText = cultureResx.translateText("Nova Biblioteca")
        itOpenLib.BtText = cultureResx.translateText("Abrir Biblioteca")
        itRecent1.DeleteConfirmMessage = cultureResx.translateText("Tem certeza que deseja remover este item do acesso rápido?")
    End Sub

    Private Sub CheckRecentFiles()
        If Not File.Exists(AppInfo.Files.recentFiles) Then
            NoRecentFile()
        Else
            Dim fileList() As String = File.ReadAllLines(AppInfo.Files.recentFiles)
            ShowRecentFiles(fileList)
        End If
    End Sub

    Private Sub NoRecentFile()
        Dim cultureResx As New CultureManager
        itRecent1.BtText = cultureResx.translateText("Sem Arquivos Recentes")
        itRecent1.Icon = My.Resources.Delete
        itRecent1.BackColor = Color.FromArgb(CodeColors.BackColor)
    End Sub

    Private Sub ShowRecentFiles(files() As String)
        Try
            Dim cont As Short = 0
            Dim fileInfo As New FileInfo(files(0))
            AssignButtonProprieties(itRecent1, fileInfo)
            Dim previousButton As CustomMenuItem = itRecent1
            For i = 1 To files.Length - 1
                previousButton = CreateRecentFileButton(previousButton, files(i))
            Next
        Catch ex As Exception
            NoRecentFile()
        End Try
    End Sub

    Private Function CreateRecentFileButton(previousButton As CustomMenuItem, file As String)
        Dim newButton As New CustomMenuItem
        newButton.Location = New Point(previousButton.Location.X, previousButton.Location.Y + previousButton.Height + 5)
        Dim fileInfo As New FileInfo(file)
        AddHandler newButton.DeleteClick, AddressOf RemoveItRecent
        If fileInfo.Exists Then
            AssignButtonProprieties(newButton, fileInfo)
            scRecent.Panel2.Controls.Add(newButton)
            Return newButton
        Else
            RemoveFileFromList(file)
            Return previousButton
        End If
    End Function

    Private Sub AssignButtonProprieties(button As CustomMenuItem, file As FileInfo)
        button.BtText = file.Name & vbCrLf & file.FullName
        button.Icon = My.Resources.Arduino
        button.HighlightColor = SystemColors.HotTrack
        button.Size = itRecent1.Size
        button.DeleteConfirmMessage = itRecent1.DeleteConfirmMessage
        AddHandler button.Click, AddressOf OpenRecentFile
    End Sub

    Private Sub OpenRecentFile(fileName As String)
        Dim fileInfo As New FileInfo(fileName)
        Dim cultureResx As New CultureManager
        If fileName = cultureResx.translateText("Sem Arquivos Recentes") Then
            Exit Sub
        End If
        If Not fileInfo.Exists Then
            Dim r = cultureResx.ShowQuestion("O arquivo não existe mais. Deseja criar um novo projeto com esse nome?")
            If r = DialogResult.No Then
                DeleteRecentFile(fileInfo.FullName)
                Exit Sub
            End If
        End If
        ProjectActions.OpenProject.Open(fileInfo.DirectoryName)
    End Sub

    Private Sub DeleteRecentFile(fileName As String)
        Dim fileList As List(Of String) = RemoveFileFromList(fileName)
        Dim bkpButton = itRecent1
        scRecent.Panel2.Controls.Clear()
        scRecent.Panel2.Controls.Add(bkpButton)
        ShowRecentFiles(fileList.ToArray)
    End Sub

    Private Shared Function RemoveFileFromList(fileName As String) As List(Of String)
        Dim fileList As New List(Of String)
        If File.Exists(AppInfo.Files.recentFiles) Then
            fileList.AddRange(File.ReadAllLines(AppInfo.Files.recentFiles))
            fileList.Remove(fileName)
            File.WriteAllLines(AppInfo.Files.recentFiles, fileList)
        End If
        Return fileList
    End Function

    Private Sub itNewProject_Click() Handles itNewProject.Click
        ProjectActions.NewProject.ShowDialog()
    End Sub

    Private Sub itOpenProject_Click() Handles itOpenProject.Click
        ProjectActions.OpenProject.ShowDialog()
    End Sub

    Private Sub itOpenFile_Click(fileName As String) Handles itOpenFile.Click
        ProjectActions.OpenFile.ShowDialog()
    End Sub

    Private Sub RemoveItRecent(sender As CustomMenuItem) Handles itRecent1.DeleteClick
        Try
            Dim cultureResx As New CultureManager
            If sender.BtText = cultureResx.translateText("Sem Arquivos Recentes") Then
                Exit Sub
            End If
            Dim filePath As String = sender.BtText.Split(vbCrLf)(1)
            DeleteRecentFile(filePath.TrimStart)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ItNewLib_Click(fileName As String) Handles itNewLib.Click
        ProjectActions.NewLibrary.ShowDialog()
    End Sub

    Private Sub ItOpenLib_Click(fileName As String) Handles itOpenLib.Click
        ProjectActions.OpenLibrary.ShowDialog()
    End Sub

    Private Sub itOpenProject_Click(fileName As String) Handles itOpenProject.Click

    End Sub

    Private Sub itNewProject_Click(fileName As String) Handles itNewProject.Click

    End Sub
End Class