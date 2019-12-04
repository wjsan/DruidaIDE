Imports System.IO

Public Class SaveFileAs

    Dim applicationDirectory As String = CurrentProjectInfo.DirectoryPaths.projectDirectory
    Dim path As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cultureResx As New CultureManager
        If tbName.Text = "" Or tbName Is Nothing Then
            MessageBox.Show(cultureResx.translateText("Digite o nome do novo projeto."))
            Exit Sub
        End If
        path = tbDirectory.Text
        If (cbCreateFolder.Checked) Then My.Computer.FileSystem.CreateDirectory(tbDirectory.Text)
        Try
            If (path <> "") Then
                Dim currentFile As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
                Dim currentCfgFile As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCFGsProjectFile)
                My.Computer.FileSystem.CopyDirectory(applicationDirectory, path)
                If tbName.Text <> CurrentProjectInfo.General.name Then
                    My.Computer.FileSystem.RenameFile(path & "\" & currentFile.Name, tbName.Text & ".ino")
                    My.Computer.FileSystem.RenameFile(path & "\" & currentCfgFile.Name, tbName.Text & ".cfg")
                End If
                ProjectActions.OpenProject.Open(path)
            End If
        Catch ex As Exception
            MessageBox.Show(cultureResx.translateText(ex.Message),
                            cultureResx.translateText("Erro"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbDirectory.Text = IDEcfgs.Values.Directories.DruidaProjects
        path = tbDirectory.Text
        tbName.Text = CurrentProjectInfo.General.name
    End Sub

    Private Sub tbNAme_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        Dim selection = tbName.SelectionStart
        tbName.Text = TextTreatment.Normalize(tbName.Text)
        tbName.SelectionStart = selection
        If (cbCreateFolder.Checked) Then tbDirectory.Text = path & "\" & tbName.Text
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim createApp As FolderBrowserDialog = New FolderBrowserDialog With {
            .SelectedPath = IDEcfgs.Values.Directories.DruidaProjects
        }
        createApp.ShowDialog()
        If (cbCreateFolder.Checked) Then tbDirectory.Text = createApp.SelectedPath & "\" & tbName.Text
        If (Not (cbCreateFolder.Checked)) Then tbDirectory.Text = createApp.SelectedPath
        path = createApp.SelectedPath
    End Sub
End Class
