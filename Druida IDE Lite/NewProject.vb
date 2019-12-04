Imports System.IO

Public Class NewProject
    Dim path As String

    Private Sub Criar_Novo_Projeto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(AppInfo.Directories.projectDir)
        tbDirectory.Text = AppInfo.Directories.projectDir
        path = tbDirectory.Text
        tbDirectory.Text = AppInfo.Directories.projectDir & "\NovoProjeto"
    End Sub

    Private Sub btFind_Click(sender As Object, e As EventArgs) Handles btFind.Click
        Dim selectDir As FolderBrowserDialog = New FolderBrowserDialog With {
            .SelectedPath = AppInfo.Directories.projectDir
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
            ToolTipErro.Show("Digite o nome da nova aplicação.", tbName, 5000)
            Exit Sub
        End If
        CreateProject()
    End Sub

    Private Sub CreateProject()
        If (cbCreateFolder.Checked) Then My.Computer.FileSystem.CreateDirectory(tbDirectory.Text)
        Try
            If (path <> "") Then
                ProjectActions.NewProject.Create(path & "\" & tbName.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao criar o projeto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        tbName.SelectAll()
    End Sub
End Class