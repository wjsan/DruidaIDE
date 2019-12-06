Imports System.ComponentModel
Imports System.IO.Ports
Imports Tulpep.NotificationWindow
Imports Druida_IDE_Lite
Public Class DruidaSuiteMain
    Public windowsOpened As UInt16 = 0
    Public taskButtons() As TaskButton
    Public openedForm As Form
    Private alarmsToCheck As New List(Of Alarme)
    Public activatedAlarms As New List(Of Alarme)
    Private normalizedAlarms As New List(Of Alarme)
    Private dateTimeActivatesAlarms As New List(Of String)
    Public alarmTable As New List(Of String())
    Public druidaIDEinterface As New SoftwareInterface
    'Ações Iniciais

    'If ProgressBarStartUp.Value = 31 Then
    '        LabelStatusAbertura.Text = "Iniciando Druida..."
    '        timerStart = True
    '    End If

    Private Sub AtualizaProgresso(ByVal num As Integer)
        SplashScreen.ProgressBarStartUp.Value = num
        SplashScreen.LabelProgresso.Text = String.Format("{0}%", {SplashScreen.ProgressBarStartUp.Value})
    End Sub

    Private Sub ArduinoSuiteMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarRecursos()
        SplashScreen.TopMost = True
        PictureBoxAudio.Visible = appProgrammingMethod <> "Avançado"
        Dim configFile = applicationDirectory & "\Config Files\Configuracao.cfg"
        taskButtons = {TaskButton1, TaskButton2, TaskButton3}
        If (System.IO.File.Exists(applicationDirectory & "\Config Files\Configuracao.cfg")) Then
            AtualizaProgresso(50)
            SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando cfgs>..."
            Dim dados() As String
            dados = System.IO.File.ReadAllText(configFile).Split("_")
            arduinoConfig = dados(0)
            porta = dados(22)
            autoConnect = dados(24)
        End If
        If (appProgrammingMethod = "Avançado") Then
            Label1.Text = "Programação"
            PictureBoxConfig.Image = My.Resources.SourceCode
        Else
            AtualizaProgresso(55)
            SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando Tela de Cfgs>..."
            Configurações.MdiParent = Me
            Configurações.Show()
            Configurações.Hide()
        End If
        AtualizaProgresso(60)
        SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando Tela Inicial>..."
        TelaInicial.MdiParent = Me
        TelaInicial.Dock = DockStyle.Fill
        TelaInicial.Show()
        TelaInicial.Top() = 0
        TimerCheckPortAvailable.Enabled = True
        If (autoConnect) Then
            searchPort()
            If (serialPortAvailable) Then
                openPort()
            End If
        End If
        AtualizaProgresso(65)
        SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando definições de audio>..."
        If audioEnable Then
            PictureBoxSound.Image = My.Resources.audioOn
        Else
            PictureBoxSound.Image = My.Resources.audioOff
        End If
        PictureBoxAudio.Image = PictureBoxSound.Image
        AtualizaProgresso(70)
        SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando Alarmes>..."
        GetAlarmList()
        If (appProgrammingMethod = "Avançado") Then
            If My.Computer.FileSystem.DirectoryExists(applicationDirectory & "\Comando") Then
                AtualizaProgresso(80)
                SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando Editor de Interface Gráfica>..."
                'TelaInicial.OpenForm(ComandoAvancado)
            End If
            'Programação.BringToFront()
            AtualizaProgresso(90)
            SplashScreen.LabelStatusAbertura.Text = "Iniciando Druida <Carregando Editor de Códigos>..."
            'TelaInicial.OpenForm(Programação)
        End If
        AtualizaProgresso(100)
        SplashScreen.LabelStatusAbertura.Text = "Concluído!"
        AddHandler DruidaInterface.DruidaIDE.ConnectionRequested, AddressOf druidaIDEinterface.CloseSerialPorts
    End Sub

    'AÇÕES DOS BOTÕES
    'Botão Nova
    Public Sub PictureBoxNova_Click(sender As Object, e As EventArgs) Handles PictureBoxNova.Click
        PlayBackgroundSoundFile("Click.wav")
        If Mode = Completo Then
            Dim resposta As DialogResult = MessageBox.Show("Deseja salvar as modificações ao iniciar o novo projeto?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If (resposta = System.Windows.Forms.DialogResult.Yes) Then
                PlayBackgroundSoundFile("Salvar.wav")
                SalvarAplicacao()
                If System.IO.File.Exists(appIni & "\App.ini") Then
                    My.Computer.FileSystem.DeleteFile(appIni & "\App.ini")
                End If
                For Each element In GetLocal.Controls
                    If (element.GetType() = GetType(ControleHardware) And element.Visible) Then
                        If (element.engine.tipo = "Câmera IP") Then
                            element.VideoSourcePlayer.SignalToStop()
                        End If
                    End If
                Next
                Application.Restart()
            End If
            If (resposta = System.Windows.Forms.DialogResult.No) Then
                If System.IO.File.Exists(appIni & "\App.ini") Then
                    My.Computer.FileSystem.DeleteFile(appIni & "\App.ini")
                End If
                For Each element In GetLocal.Controls
                    If (element.GetType() = GetType(ControleHardware) And element.Visible) Then
                        If (element.engine.tipo = "Câmera IP") Then
                            element.VideoSourcePlayer.SignalToStop()
                        End If
                    End If
                Next
                Application.Restart()
            End If
        Else
            Dim resposta As DialogResult = MessageBox.Show("O projeto atual será totalmente perdido, deseja continuar?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If (resposta = System.Windows.Forms.DialogResult.Yes) Then
                If System.IO.File.Exists(appIni & "\App.ini") Then
                    My.Computer.FileSystem.DeleteFile(appIni & "\App.ini")
                    My.Computer.FileSystem.DeleteDirectory(applicationDirectory, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                Application.Restart()
            End If
        End If
    End Sub
    'Botão Abrir
    Public Sub PictureBoxAbrir_Click(sender As Object, e As EventArgs) Handles PictureBoxAbrir.Click
        If Mode <> Completo Then
            FuncaoIndisponivel()
            Exit Sub
        End If
        Dim fileList() As String
        If System.IO.File.Exists(appIni & "\AppList.txt") Then
            fileList = System.IO.File.ReadAllLines(appIni & "\AppList.txt")
            ProjetosRecentesToolStripMenuItem.DropDownItems.Clear()
            For Each filePath In fileList
                ProjetosRecentesToolStripMenuItem.DropDownItems.Add(filePath)
            Next
            ContextMenuStripAbrir.Show()
            ContextMenuStripAbrir.Location = MousePosition
        Else
            ContextMenuStripAbrir.Show()
            ContextMenuStripAbrir.Location = MousePosition
            Exit Sub
        End If
    End Sub

    Private Sub AbrirOutroApp()
        PlayBackgroundSoundFile("Click.wav")
        Dim resposta As DialogResult = MessageBox.Show("Deseja salvar as modificações antes de abrir outro projeto?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (resposta = System.Windows.Forms.DialogResult.Yes) Then
            PlayBackgroundSoundFile("Salvar.wav")
            SalvarAplicacao()
        End If
        If (resposta = System.Windows.Forms.DialogResult.No Or resposta = System.Windows.Forms.DialogResult.Yes) Then
            Dim openApp As OpenFileDialog = New OpenFileDialog With {
                .Filter = "Projeto de Aplicativo do Druida|*.app",
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida Projects",
                .Title = "Abrir Apicação"
            }
            If (openApp.ShowDialog() = DialogResult.OK) Then
                Dim newPath = openApp.FileName.Replace(openApp.SafeFileName, "")
                newPath = newPath.Remove(newPath.Length - 1, 1)
                System.IO.File.WriteAllText(appIni & "\App.ini", newPath)
                For Each element In GetLocal.Controls
                    If (element.GetType() = GetType(ControleHardware) And element.Visible) Then
                        If (element.engine.tipo = "Câmera IP") Then
                            element.VideoSourcePlayer.SignalToStop()
                        End If
                    End If
                Next
                Application.Restart()
            End If
        End If
    End Sub
    'Salvar
    Public Sub PictureBoxSalvar_Click(sender As Object, e As EventArgs) Handles PictureBoxSalvar.Click
        'If Mode <> Completo Then
        '    FuncaoIndisponivel()
        '    Exit Sub
        'End If
        PlayBackgroundSoundFile("Salvar.wav")
        SalvarAplicacao()
    End Sub
    Private Sub SalvarAplicacao()
        Dim Data() As String = {AppName, loginNeeded, audioEnable, joyPadOn, joyPadType, appProgrammingMethod}
        System.IO.File.WriteAllLines(applicationDirectory & "\AppConfig.ini", Data)
        If (Application.OpenForms.OfType(Of Comando).Count > 0) Or Application.OpenForms.OfType(Of ComandoAvancado).Count Then
            SalvarDados()
        End If
    End Sub
    'Botão Configurações
    Public Sub PictureBoxConfig_Click(sender As Object, e As EventArgs) Handles PictureBoxConfig.Click
        If (Application.OpenForms.OfType(Of Configurações).Count > 0) Then
            Configurações.BringToFront()
        Else
            Configurações.MdiParent = Me
            Configurações.Dock = DockStyle.Fill
            Configurações.Show()
            Configurações.Top() = 0
            TelaInicial.Close()
        End If
    End Sub
    'Botão Ferramentas
    Private Sub PictureBoxFerramentas_Click(sender As Object, e As EventArgs) Handles PictureBoxFerramentas.Click
        PlayBackgroundSoundFile("Click.wav")
        If (Application.OpenForms.OfType(Of Ferramentas).Count = 0) Then
            'If (COMPort.IsOpen And Not (StartRede())) Then
            '    StartRede()
            '    dadoLido = False
            '    dadoRecebido = False
            '    AtualizaRegs()
            'End If
            Ferramentas.Show()
            Ferramentas.Top() = 0
        End If
    End Sub
    'Botão Controle
    Public Sub PictureBoxControle_Click(sender As Object, e As EventArgs) Handles PictureBoxControle.Click
        PlayBackgroundSoundFile("Click.wav")
        If (Application.OpenForms.OfType(Of Alarmes).Count > 0) Then
            Alarmes.Hide()
        End If
        If (Application.OpenForms.OfType(Of Configurações).Count > 0) Then
            Configurações.Hide()
        End If
        If (My.Computer.FileSystem.FileExists(applicationDirectory & "\Comando\ListaTelas.list")) Then
            'If (COMPort.IsOpen And Not (StartRede()) And (arduinoType = arduinoConfig)) Then
            '    StartRede()
            '    dadoLido = False
            '    dadoRecebido = False
            '    AtualizaRegs()
            'End If
            Comando.MdiParent = Me
            Comando.Dock = DockStyle.Fill
            Comando.Show()
            Comando.Top() = 0
            TelaInicial.Close()
        Else
            Criar_Tela_de_Comando.ShowDialog()
        End If
        If (Application.OpenForms.OfType(Of Comando).Count > 0) Then
            Comando.BringToFront()
        End If
    End Sub

    'Alarmes
    Public Sub PictureBoxAlarmes_Click(sender As Object, e As EventArgs) Handles PictureBoxAlarmes.Click
        If (Application.OpenForms.OfType(Of Configurações).Count > 0) Then
            Configurações.SendToBack()
        End If
        PlayBackgroundSoundFile("Click.wav")
        Alarmes.MdiParent = Me
        Alarmes.Dock = DockStyle.Fill
        Alarmes.Show()
        Alarmes.Top() = 0
        TelaInicial.Close()
    End Sub
    'Conectar
    Public Sub PictureBoxConectar_Click(sender As Object, e As EventArgs) Handles PictureBoxConectar.Click
        openPort()
    End Sub
    Public Sub openPort()
        If DruidaInterface.SerialPort.GetPort() <> "" Then porta = DruidaInterface.SerialPort.GetPort()
        If DruidaInterface.SerialPort.GetBaud() <> "" Then velocidade = DruidaInterface.SerialPort.GetBaud()
        If velocidade = "" Then velocidade = "115200"
        If (porta = "" Or porta = Nothing Or porta = "Automático") And portasDisponiveis.Count > 1 Then porta = portasDisponiveis(1)
        'If (serialPortAvailable) Then
        'If porta = "Automático" Then Exit Sub
        If Not (COMPort.IsOpen) Then
            DruidaInterface.SerialPort.Close()
            If (porta <> "" And porta <> "Automático") Then
                COMPort.PortName = porta
                COMPort.BaudRate = velocidade
            End If
            Try
                COMPort.Open()
                portaAberta = True
                If (appProgrammingMethod <> "Avançado") Then
                    monitorSerialWrite("1_")
                    TimerTryConnect.Enabled = True
                Else
                    AtualizaRegs()
                    TimerTryConnect.Enabled = True
                    PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Porta_Aberta
                    Exit Sub
                End If
            Catch ex As System.IO.IOException
                portaAberta = False
                serialPortAvailable = False
                TimerTryConnect.Enabled = False
                autoConnect = False
                MessageBox.Show("A porta Serial Selecionada não Existe! Verifique a conexão do dispositivo.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As System.UnauthorizedAccessException
                portaAberta = False
                serialPortAvailable = False
                TimerTryConnect.Enabled = False
                autoConnect = False
                MessageBox.Show("A porta Serial Selecionada Esta em uso! Verifique se existem programas abertos a utilizar essa porta.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As System.TimeoutException
                portaAberta = False
                serialPortAvailable = False
                TimerTryConnect.Enabled = False
                autoConnect = False
                MessageBox.Show("Tempo de Resposta esgotado. Verifique se a porta selecionada é a correta.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            StopRede()
            autoConnect = False
            COMPort.Close()
            portaAberta = False
            PlayBackgroundSoundFile("Desconectar.wav")
            LabelConectar.Text = "Conectar"
            Configurações.PictureBoxDownload.Image = ArduinoSuite.My.Resources.Resources.Download2
            Configurações.PictureBoxUpload.Image = ArduinoSuite.My.Resources.Resources.Upload2
            PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.spm_icon_256
        End If
        'End If
        Configurações.ListBoxSelecaoArduino.Enabled = Not (COMPort.IsOpen)
    End Sub
    'Botão Sair
    Public Sub PictureBoxSair_Click(sender As Object, e As EventArgs) Handles PictureBoxSair.Click
        Dim portaEstavaAberta As Boolean = False
        PlayBackgroundSoundFile("Click.wav")
        PlayBackgroundSoundFile("Exit.wav")
        If Mode <> Completo Then
            AdquirirSoftware.Show()
            Exit Sub
        End If
        Dim resposta As DialogResult = MessageBox.Show("Deseja salvar as modificações?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (resposta = System.Windows.Forms.DialogResult.Yes) Then
            SalvarAplicacao()
            FecharApp()
        End If
        If (resposta = System.Windows.Forms.DialogResult.No) Then
            FecharApp()
        End If
        If (resposta = System.Windows.Forms.DialogResult.Cancel) Then

        End If
    End Sub

    Public Sub FecharApp()
        If (Application.OpenForms.OfType(Of Ferramentas).Count <> 0) Then
            Ferramentas.Close()
        End If
        For Each element In GetLocal.Controls
            If (element.GetType() = GetType(ControleHardware) And element.Visible) Then
                If (element.engine.tipo = "Câmera IP") Then
                    element.VideoSourcePlayer.SignalToStop()
                End If
            End If
        Next
        'Application.Exit()
        Environment.Exit(0)
    End Sub

    'TEMPORIZADORES:
    'Verifica disponibilidade das portas seriais
    Private Sub TimerCheckPortAvailable_Tick(sender As Object, e As EventArgs) Handles TimerCheckPortAvailable.Tick
        Static Dim cont As UInt16 = 0
        Static Dim aux As Boolean = True
        searchPort()
        If (autoConnect And Not (COMPort.IsOpen) And serialPortAvailable) Then
            openPort()
            TimerTryConnect.Enabled = True
        End If
        If aux Then
            cont += 1
            If cont > 5 Then
                SplashScreen.Close()
                aux = False
            End If
        End If
    End Sub
    Public Sub searchPort()
        Dim portaAdicionada As String = ""
        Static Dim nPortas = portasDisponiveis.Count
        portasDisponiveis.Clear()
        portasDisponiveis.Add("Automático")
        Dim cont As Integer = 0
        For Each port As String In SerialPort.GetPortNames()
            portasDisponiveis.Add(port)
            portaAdicionada = port
            If (Not (serialPortAvailable) And (porta = "Automático" Or porta = port)) Then
                If (Not (COMPort.IsOpen)) Then
                    COMPort.PortName = port
                    PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.spm_icon_256
                End If
            End If
        Next
        If (portasDisponiveis.Count > 1) Then
            serialPortAvailable = True
        Else
            serialPortAvailable = False
            PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Conectar
        End If
        If (portasDisponiveis.Count <> Configurações.ListBoxSelecionaPorta.Items.Count) Then
            Configurações.ListBoxSelecionaPorta.Items.Clear()
            For Each item In portasDisponiveis
                Configurações.ListBoxSelecionaPorta.Items.Add(item)
            Next
        End If
        If Not (COMPort.IsOpen) Then
            Configurações.GroupBoxArduinoInfo.Visible = False
            ' If (portasDisponiveis.Count > 1) Then
            LabelConectar.Text = "Conectar"
            If (portasDisponiveis.Count > 1) Then
                PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.spm_icon_256
            End If
            If nPortas < portasDisponiveis.Count Then
                nPortas = portasDisponiveis.Count
                ExibirNotificação(portaAdicionada)
            End If
            If nPortas > portasDisponiveis.Count Then
                nPortas = portasDisponiveis.Count
                Notificação("Dispositivo desconectado.", My.Resources.spm_icon_256, 1 / 3)
            End If
        End If
    End Sub
    'Exibir notifição de dispositivo detectado

    Dim notfy = New PopupNotifier()

    Private Sub ExibirNotificação(ByVal portaDetectada As String)
        Dim notificacao = notfy
        notificacao.TitleText = "Druida Tool's Suite"
        notificacao.IsRightToLeft = False
        notificacao.ShowCloseButton = True
        notificacao.ContentColor = Color.Black
        notificacao.ImageSize = New Point(100, 100)
        notificacao.Image = My.Resources.images8PCHE2EJ
        If portaDetectada <> "" Then
            notificacao.ContentText = "Dispositivo detectado na porta: " & portaDetectada
        Else
            notificacao.ContentText = "Dispositivo desconectado."
        End If
        notificacao.Popup()
    End Sub

    Private Sub Notificação(ByVal message As String, ByRef picture As Image, ByVal scale As Double)
        Dim notificacao = notfy
        notificacao.TitleText = "Druida Tool's Suite"
        notificacao.IsRightToLeft = False
        notificacao.ShowCloseButton = True
        notificacao.ContentColor = Color.Black
        notificacao.ImageSize = New Point(picture.Width * scale, picture.Height * scale)
        notificacao.Image = picture
        notificacao.ContentText = message
        notificacao.Popup()
    End Sub
    'Abre porta de comunicação com o dispositivo
    Private Sub TimerTryConnect_Tick(sender As Object, e As EventArgs) Handles TimerTryConnect.Tick
        connectPort()
    End Sub
    Private Sub connectPort()
        Static Dim cont As Int16
        Static limpar As Boolean = True
        If (COMPort.IsOpen And limpar) Then
            Dim limpaMemoria = COMPort.ReadExisting
            monitorSerialRead(limpaMemoria)
            limpar = False
        End If
        LabelConectar.Text = "Buscando..."
        If (COMPort.IsOpen) Then
            leituraRede = COMPort.ReadExisting
            monitorSerialRead(leituraRede)
            If (Not (leituraRede <> "") Or leituraRede = "?" Or leituraRede.Length < 5) Then
                If appProgrammingMethod <> "Avançado" Then
                    monitorSerialWrite("_")
                End If
                cont = cont + 1
            Else
                Dim informacoes() As String = {0, 0, 0, 0, 0, 0, 0}
                Try
                    informacoes = leituraRede.Split(".")
                Catch ex As Exception
                    cont = 0
                    TimerTryConnect.Enabled = False
                    MessageBox.Show("Erro na interpretação dos sinais: " & leituraRede & "em split(''.'')")
                    TimerTryConnect.Enabled = True
                End Try
                Try
                    arduinoType = informacoes(0)
                    versaoFirmware = informacoes(1)
                    nEntradas = informacoes(2)
                    nPullUps = informacoes(3)
                    nSaidas = informacoes(4)
                    nSaidasRt = informacoes(5)
                    nPWM = informacoes(6)
                    cont = 0
                    Configurações.GroupBoxArduinoInfo.Visible = True
                    If versaoFirmware = 1000 And appProgrammingMethod <> "Avançado" Then
                        Dim img As Image = My.Resources.Arduino_UNO
                        If arduinoType = 0 Then img = My.Resources.Arduino_NANO
                        If arduinoType = 1 Then img = My.Resources.Arduino_UNO
                        If arduinoType = 2 Then img = My.Resources.Arduino_MEGA
                        Notificação("Dispositivo conectado com sucesso", img, 1 / 30)
                    ElseIf appProgrammingMethod <> "Avançado" Then
                        cont = 4
                        TimerTryConnect.Enabled = False
                        MessageBox.Show("Erro ao verificar informações do dispositivo")
                    Else
                        Notificação("Dispositivo conectado com sucesso", My.Resources.images8PCHE2EJ, 1 / 2)
                    End If
                Catch ex As Exception
                    If appProgrammingMethod <> "Avançado" Then
                        cont = 4
                        TimerTryConnect.Enabled = False
                        MessageBox.Show("Erro ao verificar informações do dispositivo")
                    Else
                        'Notificação("Dispositivo conectado com sucesso", My.Resources.images8PCHE2EJ, 1 / 2)
                    End If
                End Try
            End If
            If (Not ((Not (leituraRede <> "") Or leituraRede = "?" Or leituraRede.Length < 5)) Or cont > 3) Then
                PlayBackgroundSoundFile("Conectar.wav")
                LabelConectar.Text = "Desconectar"
                Configurações.PictureBoxDownload.Image = ArduinoSuite.My.Resources.Resources.Download
                Configurações.PictureBoxUpload.Image = ArduinoSuite.My.Resources.Resources.Upload
                PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Porta_Aberta
                TimerTryConnect.Enabled = False
                StopRede()
                limpar = True
                If (appProgrammingMethod <> "Avançado" And cont > 3) Then
                    DialogUpdateFirmware.ShowDialog()
                    cont = 0
                    limpar = True
                End If
            End If
        End If
        If (COMPort.IsOpen) Then
            StartRede()
            dadoLido = False
            dadoRecebido = False
            AtualizaRegs()
            If appProgrammingMethod = "Avançado" Then TimerTryConnect.Stop()
        End If
    End Sub
    'Leitura dos estados do dispositivo

    Public Sub StartRede()
        ' If appProgrammingMethod <> "Avançado" Then
        TimerLeituraRede.Start()
        'Else
        'BackgroundWorkerRede.RunWorkerAsync()
        'End If
    End Sub

    Public Sub StopRede()
        'If appProgrammingMethod <> "Avançado" Then
        TimerLeituraRede.Stop()
        'Else
        'BackgroundWorkerRede.CancelAsync()
        'End If
    End Sub

    Private Sub TimerLeituraRede_Tick_1(sender As Object, e As EventArgs) Handles TimerLeituraRede.Tick
        If (dadoRecebido) Then
            cicloRede()
            cicloJoy()
            CheckAlarms()
        End If
    End Sub

    Private Sub cicloRede()
        Try
            leituraEstados = COMPort.ReadTo("_")
        Catch ex As Exception
            ErrorMessage(ex.Message)
            TimerLeituraRede.Stop()
        End Try
        monitorSerialRead(leituraEstados)
        If (leituraEstados <> "") Then
            'If leituraEstados.Split(".").Count - 1 = numMaxRegs Then
            Dim aux As Integer = 0
                If descartaDados <> -1 And Not dados Is Nothing Then
                    aux = dados(descartaDados)
                End If
                If dados IsNot Nothing Then dadosAnteriores = dados
                If Not descartaLeitura Then
                    dados = leituraEstados.Split(".")
                    numMaxRegs = dados.Count - 1
                    If dados(0) < 0 Then dados(0) = 0
                Else
                    descartaLeitura = False
                End If
                If descartaDados <> -1 Then
                    dados(descartaDados) = aux
                    descartaDados = -1
                End If
                AtualizaRegs()
            'End If
        End If
    End Sub

    Private Sub cicloJoy()
        If (joyPadOn) Then
            'Try
            If appProgrammingMethod <> "Avançado" Then
                Comando.ComandoJoy()
            Else
                ComandoAvancado.ComandoJoy()
            End If
            'Catch ex As Exception
            '    MessageBox.Show("Erro na leitura do joystick (linha 507)")
            'End Try
        End If
    End Sub

    Private Sub ErrorMessage(ByVal message As String)
        DruidaInterface.AddErrorMsg(message, ErrorsManager.Type.msgError)
    End Sub

    'Private Sub TimerLeituraRede_Tick_1(sender As Object, e As EventArgs) Handles TimerLeituraRede.Tick
    '    Static Dim timeOut As Int16 = 0
    '    timeOut = timeOut + 1
    '    If (dadoRecebido) Then
    '        If (COMPort.IsOpen) Then
    '            If Not (TimerTryConnect.Enabled) Then
    '                Try
    '                    leituraEstados = COMPort.ReadLine
    '                Catch ex As Exception
    '                    'COMPort.Close()
    '                    'StopRede
    '                    'StopRede()
    '                    'essageBox.Show("Erro na leitura de estados em: COMPort.ReadLine. Erro: " & ex.ToString)
    '                    AtualizaRegs()
    '                End Try
    '                monitorSerialRead(leituraEstados)
    '                If (leituraEstados <> "") Then
    '                    Try
    '                        If (appProgrammingMethod <> "Avançado") Then
    '                            dados = leituraEstados.Split(".")
    '                            interpretaSinais()
    '                        Else
    '                            If leituraEstados.Split(".").Count - 1 = numMaxRegs Then
    '                                Dim aux As Integer = 0
    '                                If descartaDados <> -1 And Not dados Is Nothing Then
    '                                    aux = dados(descartaDados)
    '                                End If
    '                                If dados IsNot Nothing Then dadosAnteriores = dados
    '                                If Not descartaLeitura Then
    '                                    dados = leituraEstados.Split(".")
    '                                Else
    '                                    descartaLeitura = False
    '                                End If
    '                                If descartaDados <> -1 Then
    '                                    dados(descartaDados) = aux
    '                                    descartaDados = -1
    '                                End If
    '                            End If
    '                        End If
    '                    Catch ex As Exception
    '                        COMPort.Close()
    '                        'StopRede
    '                        StopRede()
    '                        MessageBox.Show("Erro na leitura dos sinais.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        DialogUpdateFirmware.ShowDialog()
    '                    End Try
    '                End If
    '                dadoLido = True
    '            End If
    '        Else
    '            'StopRede
    '            StopRede()
    '        End If
    '    Else
    '        'If appProgrammingMethod = "Avançado" Then
    '        '    AtualizaRegs()
    '        'End If
    '    End If
    '    If (dadoLido And Not (dadoRecebido)) Then
    '        If (COMPort.IsOpen) Then
    '            AtualizaRegs()
    '        Else
    '            Try
    '                COMPort.Open()
    '            Catch ex As Exception
    '                'StopRede()
    '                StopRede()
    '                MessageBox.Show("Erro ao manter a porta de comunicação aberta: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End Try
    '            AtualizaRegs()
    '        End If
    '        dadoLido = False
    '        timeOut = 0
    '    End If
    '    dadoRecebido = False
    '    If (joyPadOn) Then
    '        'Try
    '        If appProgrammingMethod <> "Avançado" Then
    '            Comando.ComandoJoy()
    '        Else
    '            ComandoAvancado.ComandoJoy()
    '        End If
    '        'Catch ex As Exception
    '        '    MessageBox.Show("Erro na leitura do joystick (linha 507)")
    '        'End Try
    '    End If
    '    CheckAlarms()
    'End Sub

    Public Sub AtualizaRegs()
        If appProgrammingMethod <> "Avançado" Then
            monitorSerialWrite("r")
        Else
            comunica()
        End If
    End Sub

    'Ações finais
    Private Sub ArduinoSuiteMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Computer.FileSystem.WriteAllText(appIni & "App.ini", applicationDirectory, False)
    End Sub

    'ANIMAÇÕES:
    'Botão Nova Aplicação
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxNova.MouseHover
        PictureBoxNova.Image = ArduinoSuite.My.Resources.Resources.Novo1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxNova.MouseLeave
        PictureBoxNova.Image = ArduinoSuite.My.Resources.Resources.Novo
    End Sub
    'Botão Abrir
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxAbrir.MouseHover
        PictureBoxAbrir.Image = ArduinoSuite.My.Resources.Resources.Abrir1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxAbrir.MouseLeave
        PictureBoxAbrir.Image = ArduinoSuite.My.Resources.Resources.Abrir
    End Sub
    'Botão Salvar
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxSalvar.MouseHover
        PictureBoxSalvar.Image = ArduinoSuite.My.Resources.Resources.Salvar1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxSalvar.MouseLeave
        PictureBoxSalvar.Image = ArduinoSuite.My.Resources.Resources.Salvar
    End Sub
    'Botão 
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.Image = ArduinoSuite.My.Resources.Resources.Salvar_Como1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = ArduinoSuite.My.Resources.Resources.Salvar_Como
    End Sub
    'Botão Configurar
    Private Sub PictureBoxConfig_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxConfig.MouseHover
        If appProgrammingMethod = "Avançado" Then
            PictureBoxConfig.Image = ArduinoSuite.My.Resources.Resources.SourceCodeSelect
        Else
            PictureBoxConfig.Image = ArduinoSuite.My.Resources.Resources.Setting_icon1
        End If
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxConfig_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxConfig.MouseLeave
        If appProgrammingMethod = "Avançado" Then
            PictureBoxConfig.Image = ArduinoSuite.My.Resources.Resources.SourceCode
        Else
            PictureBoxConfig.Image = ArduinoSuite.My.Resources.Resources.Setting_icon
        End If
    End Sub
    'Botão Ferramentas
    Private Sub PictureBoxFerramentas_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxFerramentas.MouseHover
        PictureBoxFerramentas.Image = ArduinoSuite.My.Resources.Resources.advancedsettings1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxFerramentas_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxFerramentas.MouseLeave
        PictureBoxFerramentas.Image = ArduinoSuite.My.Resources.Resources.advancedsettings
    End Sub
    'Botão Controle
    Private Sub PictureBoxControle_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxControle.MouseHover
        PictureBoxControle.Image = ArduinoSuite.My.Resources.Resources._813df8d91
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxControle_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxControle.MouseLeave
        PictureBoxControle.Image = ArduinoSuite.My.Resources.Resources._813df8d9
    End Sub

    Private Sub PictureBox8_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxAlarmes.MouseHover
        PictureBoxAlarmes.Image = ArduinoSuite.My.Resources.Resources._392ae9cfa4b776ec2eac86fe92f7f3a6_ilustra__o_de_luz_de_alarme_de_bombeiro1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxAlarmes.MouseLeave
        PictureBoxAlarmes.Image = ArduinoSuite.My.Resources.Resources._392ae9cfa4b776ec2eac86fe92f7f3a6_ilustra__o_de_luz_de_alarme_de_bombeiro
    End Sub
    'Botão Conectar
    Private Sub PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxConectar.MouseHover
        If Not (COMPort.IsOpen) Then
            If serialPortAvailable Then
                PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.spm_icon_2561
            Else PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Conectar1
            End If
        Else
            PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Porta_Aberta1
        End If
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxConectar.MouseLeave
        If Not (COMPort.IsOpen) Then
            If serialPortAvailable Then
                PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.spm_icon_256
            Else PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Conectar
            End If
        Else
            PictureBoxConectar.Image = ArduinoSuite.My.Resources.Resources.Porta_Aberta
        End If
    End Sub

    Private Sub PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxLogon.MouseHover
        PictureBoxLogon.Image = ArduinoSuite.My.Resources.Resources.lock1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxLogon.MouseLeave
        PictureBoxLogon.Image = ArduinoSuite.My.Resources.Resources.lock
    End Sub
    'Botão Sair
    Private Sub PictureBox11_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxSair.MouseHover
        PictureBoxSair.Image = ArduinoSuite.My.Resources.Resources._2013_06_13_televizija_na_off_163771
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxSair.MouseLeave
        PictureBoxSair.Image = ArduinoSuite.My.Resources.Resources._2013_06_13_televizija_na_off_16377
    End Sub

    Private Sub COMPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles COMPort.DataReceived
        dadoRecebido = True
    End Sub

    Private Sub PictureBoxSound_Click(sender As Object, e As EventArgs) Handles PictureBoxSound.Click, PictureBoxAudio.Click
        audioEnable = Not (audioEnable)
        If audioEnable Then
            PictureBoxSound.Image = My.Resources.audioOn
        Else
            PictureBoxSound.Image = My.Resources.audioOff
        End If
        PictureBoxAudio.Image = PictureBoxSound.Image
    End Sub

    Public Sub PictureBoxLogon_Click(sender As Object, e As EventArgs) Handles PictureBoxLogon.Click
        If Mode <> Completo Then
            FuncaoIndisponivel()
            Exit Sub
        End If
        OpcoesDeUsuario.Show()
    End Sub


    Private Sub PictureBoxWindows_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxWindows.MouseEnter
        PictureBoxWindows.Image = My.Resources.windowsSelected
    End Sub

    Private Sub PictureBoxWindows_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxWindows.MouseLeave
        PictureBoxWindows.Image = My.Resources.windows
    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        LabelTimer.Text = System.DateTime.Now
    End Sub

    Private Sub PictureBoxWindows_Click(sender As Object, e As EventArgs) Handles PictureBoxWindows.Click
        If MenuInterativo.Visible Then
            MenuInterativo.Hide()
        Else
            MenuInterativo.ShowMe()
        End If
    End Sub

    Private Sub PictureBoxHideAll_Click(sender As Object, e As EventArgs) Handles PictureBoxHideAll.Click
        openedForm = Nothing
        TelaInicial.BringToFront()
        SplitContainerWindows.Hide()
        TelaInicial.WebBrowser1.Refresh()
        TelaInicial.WebBrowser2.Refresh()
    End Sub

    Private Sub PictureBoxHideAll_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxHideAll.MouseEnter
        PictureBoxHideAll.Image = My.Resources.Gradiente_Azul2
    End Sub

    Private Sub PictureBoxHideAll_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxHideAll.MouseLeave
        PictureBoxHideAll.Image = My.Resources.TaskBar
    End Sub

    Public Sub ReadjustTasks()
        If Not taskButtons(0).Visible And taskButtons(1).Visible Then
            ChangeTaskButtons(taskButtons(0), taskButtons(1))
        End If
        If Not taskButtons(1).Visible And taskButtons(2).Visible Then
            ChangeTaskButtons(taskButtons(1), taskButtons(2))
        End If
    End Sub

    Private Sub DestroyButton(ByRef bt As TaskButton)
        bt.Visible = False
    End Sub

    Private Sub ChangeTaskButtons(ByRef bt1 As TaskButton, ByRef bt2 As TaskButton)
        'taskButtons(0) = TaskButton1
        bt1.PictureBoxItem.Image = bt2.PictureBoxItem.Image
        bt1.LabelNomeItem.Text = bt2.LabelNomeItem.Text
        bt1.SetForm(bt2.GetForm)
        bt1.GetForm.taskButtonRef = bt1
        bt1.Visible = True
        bt2.Visible = False
    End Sub

    Private Sub TaskButton1_VisibleChanged(sender As Object, e As EventArgs) Handles TaskButton1.VisibleChanged, TaskButton2.VisibleChanged
        ReadjustTasks()
    End Sub

    Public Sub GetAlarmList()
        Dim path As String = applicationDirectory & "\Alarmes.alm"
        alarmsToCheck.Clear()
        numAlarme = 0
        If (System.IO.File.Exists(path)) Then
            Dim dados() As String = System.IO.File.ReadAllLines(path)
            For Each line As String In dados
                Dim newAlarm As New Alarme
                newAlarm.LoadMe(line)
                alarmsToCheck.Add(newAlarm)
            Next
        End If
        numAlarme = 0
    End Sub

    Public Sub CheckAlarms()
        For Each item As Alarme In alarmsToCheck
            If item.getStatusAlarme Then
                If Not activatedAlarms.Contains(item) Then
                    Dim portAlm As String = item.ComboBoxPorta.SelectedItem
                    If item.ComboBoxBit.SelectedIndex <> -1 Then
                        portAlm &= "." & item.ComboBoxBit.SelectedItem
                    End If
                    Dim message As String = item.ComboBoxTipoPorta.Text & " " & portAlm & ": " & item.TextBoxMensagem.Text
                    Notificação(message, My.Resources._392ae9cfa4b776ec2eac86fe92f7f3a6_ilustra__o_de_luz_de_alarme_de_bombeiro, 1 / 3)
                    PlayBackgroundSoundFile("Alarm.wav")
                    activatedAlarms.Add(item)
                    dateTimeActivatesAlarms.Add(Now)
                    TimerAnimAlarme.Start()
                    Dim newRow As New DataGridViewRow
                    Dim values() As String = {Now, item.ComboBoxTipoPorta.Text & " " & portAlm, item.TextBoxMensagem.Text}
                    alarmTable.Add(values)
                    Alarmes.updateTable()
                End If
            Else
                If activatedAlarms.Contains(item) Then
                    activatedAlarms.Remove(item)
                    normalizedAlarms.Add(item)
                    dateTimeActivatesAlarms.Add(Now)
                    TimerAnimAlarme.Start()
                End If
            End If
        Next
    End Sub

    Private Sub TimerAnimAlarme_Tick(sender As Object, e As EventArgs) Handles TimerAnimAlarme.Tick
        Static chave As Boolean = True
        If chave Then
            PictureBoxAlarmes.BackColor = Color.Red
        Else
            PictureBoxAlarmes.BackColor = Color.Transparent
        End If
        chave = Not chave
        If activatedAlarms.Count = 0 Then
            PictureBoxAlarmes.BackColor = Color.Transparent
            TimerAnimAlarme.Stop()
        End If
    End Sub

    Public Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Mode <> Completo Then
            FuncaoIndisponivel()
            Exit Sub
        End If
        SalvarComo.ShowDialog()
    End Sub

    Private Sub ExibitTelaInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExibitTelaInicialToolStripMenuItem.Click
        TelaInicial.BringToFront()
        openedForm = Nothing
    End Sub

    Private Sub AbrirProjetoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirProjetoToolStripMenuItem.Click
        AbrirOutroApp()
    End Sub

    Private Sub ProjetosRecentesToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ProjetosRecentesToolStripMenuItem.DropDownItemClicked
        If Not System.IO.Directory.Exists(e.ClickedItem.Text) Then
            ContextMenuStripAbrir.Hide()
            MessageBox.Show("O item selecionado não existe e será retirado da lista.", "Abrir novo projeto", MessageBoxButtons.OK)
            Dim itens As New List(Of String)
            For Each item As ToolStripDropDownItem In ProjetosRecentesToolStripMenuItem.DropDownItems
                If System.IO.Directory.Exists(item.Text) Then
                    itens.Add(item.Text)
                End If
            Next
            If System.IO.File.Exists(appIni & "\AppList.txt") Then
                System.IO.File.WriteAllLines(appIni & "\AppList.txt", itens)
            End If
            Exit Sub
        End If
        ContextMenuStripAbrir.Hide()
        Dim diagResult = MessageBox.Show("Deseja savar as alterações antes de abrir o projeto selecionado?", "Abrir novo projeto", MessageBoxButtons.YesNoCancel)
        If diagResult = DialogResult.Yes Then
            SalvarAplicacao()
            'If System.IO.File.Exists(appIni & "App.ini") Then
            System.IO.File.WriteAllText(appIni & "\App.ini", e.ClickedItem.Text)
            'End If
        End If
        If diagResult = DialogResult.No Then
            If System.IO.File.Exists(appIni & "App.ini") Then
                System.IO.File.WriteAllText(appIni & "App.ini", e.ClickedItem.Text)
            End If
        End If
        If diagResult <> DialogResult.Cancel Then
            Application.Restart()
        End If
    End Sub

    Private Sub PanelTaskBar_MouseEnter(sender As Object, e As EventArgs) Handles PanelTaskBar.MouseEnter
        TelaInicial.Panel1.Show()
    End Sub

    Private Sub PictureBoxGoToWindows_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBoxGoToHome_Click(sender As Object, e As EventArgs)
        TelaInicial.BringToFront()
        openedForm = TelaInicial
    End Sub

    Private Sub PanelTaskBar_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelTaskBar.MouseClick
        TelaInicial.BringToFront()
        TelaInicial.WebBrowser1.Refresh()
        TelaInicial.WebBrowser2.Refresh()
        openedForm = Nothing
    End Sub

End Class

