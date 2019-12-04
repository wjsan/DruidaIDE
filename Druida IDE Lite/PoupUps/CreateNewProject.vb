Imports System.IO

Public Class CreateNewProject
    Dim path As String
    Dim culture As New CultureManager
    Dim projectType As typeOfProject = typeOfProject.arduinoProject

    Enum typeOfProject
        arduinoProject
        library
    End Enum

    Private Sub Criar_Novo_Projeto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(AppInfo.Directories.project)
    End Sub

    Public Sub setProjectParameters(Title As String, Path As String, type As typeOfProject)
        Me.path = Path
        tbDirectory.Text = Path & System.IO.Path.DirectorySeparatorChar & Text
        tbTitle.Text = Title
        tbName.Text = Title
        Text = Title
        projectType = type
    End Sub

    Private Sub btFind_Click(sender As Object, e As EventArgs) Handles btFind.Click
        Dim selectDir As FolderBrowserDialog = New FolderBrowserDialog With {
            .SelectedPath = AppInfo.Directories.project
        }
        selectDir.ShowDialog()
        If (cbCreateFolder.Checked) Then tbDirectory.Text = selectDir.SelectedPath & "\" & tbName.Text
        If (Not (cbCreateFolder.Checked)) Then tbDirectory.Text = selectDir.SelectedPath
        path = selectDir.SelectedPath
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Close()
    End Sub

    Private Sub ButtonCriarProjeto_Click(sender As Object, e As EventArgs) Handles btCreateProject.Click
        If tbName.Text = "" Or tbName Is Nothing Then
            ToolTipErro.Show(culture.translateText("Digite o nome do código fonte principal"), tbName, 5000)
            Exit Sub
        End If
        If Directory.Exists(tbDirectory.Text) Then
            MessageBox.Show(culture.translateText("O diretório selecionado já existe."),
                           culture.translateText(culture.translateText("O arquivo já existe")),
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
            Exit Sub
            Dim dirInfo As New DirectoryInfo(tbDirectory.Text)
            For Each file In dirInfo.GetFiles()
                file.Delete()
            Next
        End If
        CreateProject()
    End Sub

    Private Sub CreateProject()
        If (cbCreateFolder.Checked) Then My.Computer.FileSystem.CreateDirectory(tbDirectory.Text)
        Try
            If (path <> "") Then
                If projectType = typeOfProject.library Then
                    ProjectActions.NewLibrary.CreateLib(path & "\" & tbName.Text)
                Else
                    ProjectActions.NewProject.Create(path & "\" & tbName.Text)
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(culture.translateText("Erro ao criar o projeto. ") & ex.Message,
                            culture.translateText("Erro"),
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbTitle_TextChanged(sender As Object, e As EventArgs) Handles tbTitle.TextChanged
        CurrentProjectCfgs.DefaultValues.ProjectInfo.title = tbTitle.Text
        tbName.Text = tbTitle.Text.Replace(" ", "_")
    End Sub

    Private Sub TextBoxNome_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        Dim selection = tbName.SelectionStart
        tbName.Text = TextTreatment.Normalize(tbName.Text)
        tbName.SelectionStart = selection
        If (cbCreateFolder.Checked) Then tbDirectory.Text = path & "\" & tbName.Text
    End Sub


    Private Sub CheckBoxCriarPasta_CheckedChanged(sender As Object, e As EventArgs) Handles cbCreateFolder.CheckedChanged
        If (tbName.Text.Length > 0 And tbDirectory.Text.Length > 0) Then
            If (cbCreateFolder.Checked) Then tbDirectory.Text = tbDirectory.Text & "\" & tbName.Text
            If (Not (cbCreateFolder.Checked)) Then tbDirectory.Text = tbDirectory.Text.ToString.Remove(tbDirectory.Text.Length - (tbName.Text.Length + 1), tbName.Text.Length + 1)
        End If
    End Sub

    Private Sub btOpen_Click(sender As Object, e As EventArgs) Handles btOpen.Click
        If ProjectActions.OpenProject.ShowDialog() = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub tbName_MouseClick(sender As Object, e As MouseEventArgs) Handles tbName.MouseClick
        'tbName.SelectAll()
    End Sub

    Private Sub CreateNewProject_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tbTitle.Focus()
        tbTitle.SelectAll()
    End Sub
End Class