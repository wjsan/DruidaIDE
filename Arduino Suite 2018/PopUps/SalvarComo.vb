Public Class SalvarComo

    Dim path As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim dadosIni() As String = {TextBoxNome.Text, loginNeeded, audioEnable, joyPadOn, joyPadType, appProgrammingMethod}
        If TextBoxNome.Text = "" Or TextBoxNome Is Nothing Then
            MessageBox.Show("Digite o nome da nova aplicação.")
            Exit Sub
        End If
        path = TextBoxDiretorio.Text
        If (CheckBoxCriarPasta.Checked) Then My.Computer.FileSystem.CreateDirectory(TextBoxDiretorio.Text)
        Try
            If (path <> "") Then
                My.Computer.FileSystem.CopyDirectory(applicationDirectory, path)
                My.Computer.FileSystem.WriteAllText(TextBoxDiretorio.Text & "\" & TextBoxNome.Text & ".app", TextBoxDiretorio.Text, False)
                System.IO.File.WriteAllLines(TextBoxDiretorio.Text & "\AppConfig.ini", dadosIni)
                My.Computer.FileSystem.WriteAllText(appIni & "App.ini", path, False)
                Application.Restart()
            End If
        Catch ex As Exception
            MessageBox.Show("O caminho informado é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SalvarComo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDiretorio.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects\"
        path = TextBoxDiretorio.Text
    End Sub

    Private Sub TextBoxNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNome.TextChanged
        If (CheckBoxCriarPasta.Checked) Then TextBoxDiretorio.Text = path & "\" & TextBoxNome.Text
    End Sub

    Private Sub ButtonProcurar_Click(sender As Object, e As EventArgs) Handles ButtonProcurar.Click
        Dim criarAplicacao As FolderBrowserDialog = New FolderBrowserDialog With {
            .SelectedPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects\"
        }
        criarAplicacao.ShowDialog()
        If (CheckBoxCriarPasta.Checked) Then TextBoxDiretorio.Text = criarAplicacao.SelectedPath & "\" & TextBoxNome.Text
        If (Not (CheckBoxCriarPasta.Checked)) Then TextBoxDiretorio.Text = criarAplicacao.SelectedPath
        path = criarAplicacao.SelectedPath
    End Sub
End Class
