Imports System.Windows.Forms

Public Class DialogUpload
    Dim comparacao As String
    Private Sub TimerUpload_Tick(sender As Object, e As EventArgs) Handles TimerUpload.Tick
        Static Dim progress As Int16 = 0
        Static Dim erro As Int16 = 0
        If (progress = -4) Then
            LabelInfo.Text = "Fechando Porta de Comunicação"
        End If
        If (progress = -2) Then
            LabelInfo.Text = "Reabrindo Porta de Comunicação"
            If (Not (DruidaSuiteMain.COMPort.IsOpen)) Then
                DruidaSuiteMain.openPort()
            End If
        End If
        If (progress = 0) Then
            leituraRede = ""
            Dim lixo = DruidaSuiteMain.COMPort.ReadExisting()
            monitorSerialRead(lixo)
            DruidaSuiteMain.StopRede()
            DruidaSuiteMain.TimerTryConnect.Enabled = False
            LabelInfo.Text = "Verificando compatibilidade da configuração"
            If (arduinoType <> Configurações.ListBoxSelecaoArduino.SelectedIndex) Then
                TimerUpload.Enabled = False
                MessageBox.Show("O modelo selecionado é incompatível com o conectado. Verifique sua configuração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            TimerUpload.Interval = 100
        End If
        If (progress = 1) Then
            monitorSerialWrite("_")
            'ArduinoSuiteMain.COMPort.Write("_")
            LabelInfo.Text = "Formatando dados da tabela de configuração"
            'If (arduinoType = 0) Then
            '    formatNANO()
            'End If
            'If (arduinoType = 1) Then
            '    FormatUNO()
            'End If
        End If
        If (progress = 2) Then
            If (portaAberta) Then
                LabelInfo.Text = "Abrindo canal de comunicação"
                leituraRede = ""
                monitorSerialWrite("3.0.0.0.0.0.0.0.0.0_")
                'ArduinoSuiteMain.COMPort.Write("3.0.0.0.0.0.0.0.0.0_")
            End If
        End If
        If (progress = 3) Then
            LabelInfo.Text = "Aguardando resposta..."
            leituraRede = DruidaSuiteMain.COMPort.ReadExisting
            monitorSerialRead(leituraRede)
        End If
        If (progress = 4) Then
            LabelInfo.Text = "Verificando Informações"
            If (leituraRede <> "0.0.0.0.0.0.0.0.0.1._" & vbCrLf) Then
                LabelInfo.Text = "Erro de leitura. Tentando Novamente..."
                If (portaAberta) Then
                    DruidaSuiteMain.openPort()
                End If
                progress = -5
                erro = erro + 1
            End If
        End If
        If (progress = 5) Then
            LabelInfo.Text = "Enviando Informações"
            'If (Configurações.ListBoxSelecaoArduino.SelectedIndex < 2) Then
            'enviaConfigVer1()
            'End If
        End If
        If (progress = 6) Then
            LabelInfo.Text = "Verificando dados enviados"
            If (DruidaSuiteMain.COMPort.ReadExisting = comparacao) Then
                monitorSerialRead(comparacao)
                TimerUpload.Enabled = False
                MessageBox.Show("Dados enviados não foram recebidos adequadamente. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        End If
        If (progress = 7) Then
            Configurações.GroupBoxArduinoInfo.Visible = False
            DruidaSuiteMain.openPort()
            TimerUpload.Interval = 500
        End If
        If (progress = 8) Then
            LabelInfo.Text = "Upload concluído!"
            TimerUpload.Enabled = False
            DruidaSuiteMain.openPort()
            MessageBox.Show("Upload concluído com sucesso!!", "Upoad Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
            erro = 0
            TimerUpload.Interval = 100
            Me.Close()
        End If
        If (erro = 0) Then ProgressBarUpload.Increment(15)
        If (erro > 5) Then
            TimerUpload.Enabled = False
            MessageBox.Show("Falha na comunicação com a placa. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        progress = progress + 1
    End Sub

    'Private Sub enviaConfigVer1()
    '    Dim boolEntradasWord0() As Boolean = getEntradasWord0()
    '    Dim boolEntradasWord1() As Boolean = getEntradasWord1()
    '    Dim boolEntradasPullUpWord0() As Boolean = getPullUpsWord0()
    '    Dim boolEntradasPullUpWord1() As Boolean = getPullUpsWord1()
    '    Dim boolSaidasWord0() As Boolean = getSaidasWord0()
    '    Dim boolSaidasWord1() As Boolean = getSaidasWord1()
    '    Dim boolSaidasRWord0() As Boolean = getSaidasRWord0()
    '    Dim boolSaidasRWord1() As Boolean = getSaidasRWord1()
    '    Dim boolPWMWord0() As Boolean = getPWMWord0()
    '    Dim dados = toInt(boolEntradasWord0) & "." &
    '                toInt(boolEntradasWord1) & "." &
    '                toInt(boolEntradasPullUpWord0) & "." &
    '                toInt(boolEntradasPullUpWord1) & "." &
    '                toInt(boolSaidasWord0) & "." &
    '                toInt(boolSaidasWord1) & "." &
    '                toInt(boolSaidasRWord0) & "." &
    '                toInt(boolSaidasRWord1) & "." &
    '                toInt(boolPWMWord0) & "." & "1_"
    '    comparacao = dados
    '    monitorSerialWrite(dados)
    '    'ArduinoSuiteMain.COMPort.Write(dados)
    'End Sub
    'Private Sub formatNANO()
    '    Configurações.RadioButtonEntrada22.Checked = False
    '    Configurações.RadioButtonEntrada23.Checked = False
    '    Configurações.RadioButtonEntrada24.Checked = False
    '    Configurações.RadioButtonEntrada25.Checked = False
    '    Configurações.RadioButtonEntrada26.Checked = False
    '    Configurações.RadioButtonEntrada27.Checked = False
    '    Configurações.RadioButtonEntrada28.Checked = False
    '    Configurações.RadioButtonEntrada29.Checked = False
    '    Configurações.RadioButtonEntrada30.Checked = False
    '    Configurações.RadioButtonEntrada31.Checked = False
    '    Configurações.RadioButtonEntrada32.Checked = False
    '    Configurações.RadioButtonEntrada33.Checked = False
    '    configuraEntradasWord2("0000000000000000")
    '    configuraEntradasWord3("0000000000000000")
    '    configuraEntradasWord4("0000000000000000")
    '    Configurações.RadioButtonEPullUp22.Checked = False
    '    Configurações.RadioButtonEPullUp23.Checked = False
    '    Configurações.RadioButtonEPullUp24.Checked = False
    '    Configurações.RadioButtonEPullUp25.Checked = False
    '    Configurações.RadioButtonEPullUp26.Checked = False
    '    Configurações.RadioButtonEPullUp27.Checked = False
    '    Configurações.RadioButtonEPullUp28.Checked = False
    '    Configurações.RadioButtonEPullUp29.Checked = False
    '    Configurações.RadioButtonEPullUp30.Checked = False
    '    Configurações.RadioButtonEPullUp31.Checked = False
    '    Configurações.RadioButtonEPullUp32.Checked = False
    '    Configurações.RadioButtonEPullUp33.Checked = False
    '    configuraEPullUpsWord2("0000000000000000")
    '    configuraEPullUpsWord3("0000000000000000")
    '    configuraEPullUpsWord4("0000000000000000")
    '    Configurações.RadioButtonSaidas22.Checked = False
    '    Configurações.RadioButtonSaidas23.Checked = False
    '    Configurações.RadioButtonSaidas24.Checked = False
    '    Configurações.RadioButtonSaidas25.Checked = False
    '    Configurações.RadioButtonSaidas26.Checked = False
    '    Configurações.RadioButtonSaidas27.Checked = False
    '    Configurações.RadioButtonSaidas28.Checked = False
    '    Configurações.RadioButtonSaidas29.Checked = False
    '    Configurações.RadioButtonSaidas30.Checked = False
    '    Configurações.RadioButtonSaidas31.Checked = False
    '    Configurações.RadioButtonSaidas32.Checked = False
    '    Configurações.RadioButtonSaidas33.Checked = False
    '    configuraSaidasWord2("0000000000000000")
    '    configuraSaidasWord3("0000000000000000")
    '    configuraSaidasWord4("0000000000000000")
    '    Configurações.RadioButtonSaidasR22.Checked = False
    '    Configurações.RadioButtonSaidasR23.Checked = False
    '    Configurações.RadioButtonSaidasR24.Checked = False
    '    Configurações.RadioButtonSaidasR25.Checked = False
    '    Configurações.RadioButtonSaidasR26.Checked = False
    '    Configurações.RadioButtonSaidasR27.Checked = False
    '    Configurações.RadioButtonSaidasR28.Checked = False
    '    Configurações.RadioButtonSaidasR29.Checked = False
    '    Configurações.RadioButtonSaidasR30.Checked = False
    '    Configurações.RadioButtonSaidasR31.Checked = False
    '    Configurações.RadioButtonSaidasR32.Checked = False
    '    Configurações.RadioButtonSaidasR33.Checked = False
    '    configuraSaidasRWord2("0000000000000000")
    '    configuraSaidasRWord3("0000000000000000")
    '    configuraSaidasRWord4("0000000000000000")
    'End Sub
    'Private Sub FormatUNO()
    '    formatPWM()
    '    Dim aux(1) As String
    '    formatPWM()
    '    If (Configurações.RadioButtonEntrada18.Checked) Then
    '        aux(0) = "1"
    '    Else
    '        aux(0) = "0"
    '    End If
    '    If (Configurações.RadioButtonEntrada19.Checked) Then
    '        aux(1) = "1"
    '    Else
    '        aux(1) = "0"
    '    End If
    '    configuraEntradasWord1("00000000000000" & aux(1) & aux(0))
    '    configuraEntradasWord2("0000000000000000")
    '    configuraEntradasWord3("0000000000000000")
    '    configuraEntradasWord4("0000000000000000")
    '    If (Configurações.RadioButtonEPullUp18.Checked) Then
    '        aux(0) = "1"
    '    Else
    '        aux(0) = "0"
    '    End If
    '    If (Configurações.RadioButtonEPullUp19.Checked) Then
    '        aux(1) = "1"
    '    Else
    '        aux(1) = "0"
    '    End If
    '    configuraEPullUpsWord1("00000000000000" & aux(1) & aux(0))
    '    configuraEPullUpsWord2("0000000000000000")
    '    configuraEPullUpsWord3("0000000000000000")
    '    configuraEPullUpsWord4("0000000000000000")
    '    If (Configurações.RadioButtonSaidas18.Checked) Then
    '        aux(0) = "1"
    '    Else
    '        aux(0) = "0"
    '    End If
    '    If (Configurações.RadioButtonSaidas19.Checked) Then
    '        aux(1) = "1"
    '    Else
    '        aux(1) = "0"
    '    End If
    '    configuraSaidasWord1("00000000000000" & aux(1) & aux(0))
    '    configuraSaidasWord2("0000000000000000")
    '    configuraSaidasWord3("0000000000000000")
    '    configuraSaidasWord4("0000000000000000")
    '    If (Configurações.RadioButtonSaidasR18.Checked) Then
    '        aux(0) = "1"
    '    Else
    '        aux(0) = "0"
    '    End If
    '    If (Configurações.RadioButtonSaidasR19.Checked) Then
    '        aux(1) = "1"
    '    Else
    '        aux(1) = "0"
    '    End If
    '    configuraSaidasRWord1("00000000000000" & aux(1) & aux(0))
    '    configuraSaidasRWord2("0000000000000000")
    '    configuraSaidasRWord3("0000000000000000")
    '    configuraSaidasRWord4("0000000000000000")
    'End Sub
    Private Sub formatPWM()
        Configurações.RadioButtonPWM2.Checked = False
        Configurações.RadioButtonPWM4.Checked = False
        Configurações.RadioButtonPWM7.Checked = False
        Configurações.RadioButtonPWM8.Checked = False
        Configurações.RadioButtonPWM12.Checked = False
        Configurações.RadioButtonPWM13.Checked = False
        Configurações.RadioButtonPWM43.Checked = False
        Configurações.RadioButtonPWM44.Checked = False
        Configurações.RadioButtonPWM45.Checked = False
    End Sub
    Private Sub DialogUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBarUpload.Increment(15)
        TimerUpload.Enabled = True
    End Sub
End Class
