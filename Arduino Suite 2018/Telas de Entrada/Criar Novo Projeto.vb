Public Class Criar_Novo_Projeto

    Dim path As String

    Private Sub Criar_Novo_Projeto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreen.LabelStatusAbertura.Text = "Informe os dados do novo projeto..."
        SplashScreen.TopMost = False
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects\")
        TextBoxDiretorio.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects"
        path = TextBoxDiretorio.Text
        TextBoxDiretorio.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects\NovaAplicacao"
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

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        SplashScreen.Close()
        Close()
    End Sub

    Private Sub ButtonCriarProjeto_Click(sender As Object, e As EventArgs) Handles ButtonCriarProjeto.Click
        Dim dadosIni() As String = {TextBoxNome.Text, CheckBoxLog.Checked, True, False, 0, appProgrammingMethod}
        If TextBoxNome.Text = "" Or TextBoxNome Is Nothing Then
            ToolTipErro.Show("Digite o nome da nova aplicação.", TextBoxNome, 5000)
            Exit Sub
        End If
        If Not RadioButtonAvançado.Checked And Not RadioButtonSimples.Checked Then
            ToolTipErro.Show("Favor selecionar o método de programação antes de criar a aplicação.", GroupBoxSelect, 2000)
            Exit Sub
        End If
        If (CheckBoxCriarPasta.Checked) Then My.Computer.FileSystem.CreateDirectory(TextBoxDiretorio.Text)
        Try
            If (path <> "") Then
                My.Computer.FileSystem.WriteAllText(TextBoxDiretorio.Text & "\" & TextBoxNome.Text & ".app", TextBoxDiretorio.Text, False)
                System.IO.File.WriteAllLines(TextBoxDiretorio.Text & "\AppConfig.ini", dadosIni)
                AppName = TextBoxNome.Text
                IniciarAplicacao()
            End If
        Catch ex As Exception
            MessageBox.Show("O caminho informado é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBoxNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNome.TextChanged
        TextBoxNome.Text = Druida_IDE_Lite.TextTreatment.OnlyLetters(TextBoxNome.Text)
        If (CheckBoxCriarPasta.Checked) Then TextBoxDiretorio.Text = path & "\" & TextBoxNome.Text
    End Sub

    Private Sub IniciarAplicacao()
        Dim erroDeInicializacao As Boolean = True
        applicationDirectory = TextBoxDiretorio.Text
        If (My.Computer.FileSystem.FileExists(applicationDirectory & "\AppConfig.ini")) Then
            Dim opcoesDeInicializacao() As String = System.IO.File.ReadAllLines(applicationDirectory & "\AppConfig.ini")
            AppName = opcoesDeInicializacao(0)
            My.Computer.FileSystem.WriteAllText(appIni & "App.ini", applicationDirectory, False)
            'IO.File.AppendAllText(My.Application.Info.DirectoryPath & "\AppList.txt", AppName & " - " & TextBoxDiretorio.Text & vbLf)
            If (CBool(opcoesDeInicializacao(1) = True)) Then
                loginNeeded = True
                TelaDeLogon.Show()
                If appProgrammingMethod = "Avançado" Then
                    DruidaSuiteMain.PanelTaskBar.Visible = True
                    DruidaSuiteMain.GroupBox1.Visible = False
                    DruidaSuiteMain.GroupBox2.Visible = False
                    DruidaSuiteMain.TimerClock.Start()
                End If
                Me.Close()
            Else
                DruidaSuiteMain.Show()
                loginNeeded = False
                If appProgrammingMethod = "Avançado" Then
                    DruidaSuiteMain.PanelTaskBar.Visible = True
                    DruidaSuiteMain.GroupBox1.Visible = False
                    DruidaSuiteMain.GroupBox2.Visible = False
                    DruidaSuiteMain.TimerClock.Start()
                End If
                Me.Close()
            End If
            appProgrammingMethod = opcoesDeInicializacao(5)
            erroDeInicializacao = False
        End If
        If (erroDeInicializacao) Then
        End If
    End Sub

    Private Sub CheckBoxCriarPasta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCriarPasta.CheckedChanged
        If (TextBoxNome.Text.Length > 0 And TextBoxDiretorio.Text.Length > 0) Then
            If (CheckBoxCriarPasta.Checked) Then TextBoxDiretorio.Text = TextBoxDiretorio.Text & "\" & TextBoxNome.Text
            If (Not (CheckBoxCriarPasta.Checked)) Then TextBoxDiretorio.Text = TextBoxDiretorio.Text.ToString.Remove(TextBoxDiretorio.Text.Length - (TextBoxNome.Text.Length + 1), TextBoxNome.Text.Length + 1)
        End If
    End Sub

    Private Sub RadioButtonSimples_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSimples.CheckedChanged
        If RadioButtonSimples.Checked Then appProgrammingMethod = "Simples"
    End Sub

    Private Sub RadioButtonAvançado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAvançado.CheckedChanged
        If RadioButtonAvançado.Checked Then appProgrammingMethod = "Avançado"
    End Sub

    Private Sub ButtonAbrir_Click(sender As Object, e As EventArgs) Handles ButtonAbrir.Click
        Dim openApp As OpenFileDialog = New OpenFileDialog With {
                .Filter = "Arduino Suite 2018 App|*.app",
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects",
                .Title = "Abrir Apicação"
            }
        If (openApp.ShowDialog() = DialogResult.OK) Then
            Dim newPath = openApp.FileName.Replace(openApp.SafeFileName, "")
            System.IO.File.WriteAllText(appIni & "App.ini", newPath)
            Application.Restart()
        End If
    End Sub

End Class