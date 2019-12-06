Public Class NovoProjetoFree
    Private Sub NovoProjetoFree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreen.LabelStatusAbertura.Text = "Informe os dados do novo projeto..."
        SplashScreen.TopMost = False
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects\")
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Application.Exit()
    End Sub

    Private Sub ButtonCriarProjeto_Click(sender As Object, e As EventArgs) Handles ButtonCriarProjeto.Click
        If TextBoxNome.Text = "" Or TextBoxNome Is Nothing Then
            ToolTipErro.Show("Digite o nome da nova aplicação.", TextBoxNome, 5000)
            Exit Sub
        End If
        If Not RadioButtonAvançado.Checked And Not RadioButtonSimples.Checked Then
            ToolTipErro.Show("Favor selecionar o método de programação antes de criar a aplicação.", GroupBoxSelect, 2000)
            Exit Sub
        End If
        AppName = TextBoxNome.Text
        IniciarAplicacao()
        Close()
    End Sub

    Private Sub IniciarAplicacao()
        Dim erroDeInicializacao As Boolean = True
        applicationDirectory = appIni & "FreeApplicationFiles"
        AppName = TextBoxNome.Text
        loginNeeded = False
        DruidaSuiteMain.Show()
        'If (My.Computer.FileSystem.FileExists(applicationDirectory & "\AppConfig.ini")) Then
        '    Dim opcoesDeInicializacao() As String = System.IO.File.ReadAllLines(applicationDirectory & "\AppConfig.ini")
        '    AppName = opcoesDeInicializacao(0)
        My.Computer.FileSystem.WriteAllText(appIni & "App.ini", applicationDirectory, False)
        '    'IO.File.AppendAllText(My.Application.Info.DirectoryPath & "\AppList.txt", AppName & " - " & TextBoxDiretorio.Text & vbLf)
        '    If (CBool(opcoesDeInicializacao(1) = True)) Then
        '        loginNeeded = True
        '        TelaDeLogon.Show()
        '        If appProgrammingMethod = "Avançado" Then
        '            ArduinoSuiteMain.PanelTaskBar.Visible = True
        '            ArduinoSuiteMain.GroupBox1.Visible = False
        '            ArduinoSuiteMain.GroupBox2.Visible = False
        '            ArduinoSuiteMain.TimerClock.Start()
        '        End If
        '        Me.Close()
        '    Else
        '        ArduinoSuiteMain.Show()
        '        loginNeeded = False
        '        If appProgrammingMethod = "Avançado" Then
        '            ArduinoSuiteMain.PanelTaskBar.Visible = True
        '            ArduinoSuiteMain.GroupBox1.Visible = False
        '            ArduinoSuiteMain.GroupBox2.Visible = False
        '            ArduinoSuiteMain.TimerClock.Start()
        '        End If
        '        Me.Close()
        '    End If
        '    appProgrammingMethod = opcoesDeInicializacao(5)
        '    erroDeInicializacao = False
        'End If
        'If (erroDeInicializacao) Then
        'End If
    End Sub

    Private Sub RadioButtonSimples_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSimples.CheckedChanged
        If RadioButtonSimples.Checked Then appProgrammingMethod = "Simples"
    End Sub

    Private Sub RadioButtonAvançado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAvançado.CheckedChanged
        If RadioButtonAvançado.Checked Then appProgrammingMethod = "Avançado"
    End Sub

    Private Sub TextBoxNome_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNome.TextChanged
        TextBoxNome.Text = Druida_IDE_Lite.TextTreatment.Normalize(TextBoxNome.Text)
    End Sub
End Class