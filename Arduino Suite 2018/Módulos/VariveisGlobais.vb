Module VariveisGlobais

    Public Mode As String = Completo
    Public Const Completo As String = "Completo"
    Public Const Gratuito As String = "Gratuito"
    Public Const OpenAlpha As String = "OpenAlpha"

    'AppConfig.ini
    Public AppName As String = ""
    Public MainCodeName As String = ""
    Public loginNeeded As Boolean
    Public audioEnable As Boolean = True
    Public appProgrammingMethod = "Simples"
    Public userIsAdmin As Boolean = True
    Public filePinoutCfg = applicationCode & "Main\Pinout.cfg"

    'Application.app
    Public applicationDirectory As String
    Public applicationCode As String = "\Firmware\"
    Public userName As String
    Public joySeetings As New Joy
    Public portasDisponiveis As New List(Of String)

    'Congiguração.cfg
    Public porta As String
    Public velocidade As String = "115200"
    Public autoConnect As Boolean
    Public arduinoConfig As Byte
    Public joyPadOn As Boolean
    Public keyboard As Boolean = True
    Public joyPadType As UInt16 = 0
    Public arduinoPath As String = Application.StartupPath & "\Arduino"
    'Comando
    Public applicationRunning As Boolean = False
    Public apontaControle As UInt16 = Nothing
    Public selectedControls As New List(Of ControleHardware)
    Public keyPressed As Keys
    Public refBuffer As New List(Of ControleHardware)
    Public Structure controlInf
        Public size As Size
        Public location As Point
        Public topLevel As Int16
        Public action As String
        Public visible As Boolean
    End Structure
    Public removedControls As New List(Of ControleHardware)
    Public infBuffer As New List(Of controlInf)
    Public bufferPointer As UInt16 = 0
    Public clipBoardControl As New Control
    Public clipBoardControlList As New List(Of Control)
    Public numAlarme As UInt16 = 0
    Public listaAlarmes As New List(Of Alarme)

    'Informações arduino
    Public arduinoType, versaoFirmware, nEntradas, nPullUps, nSaidas, nSaidasRt, nPWM, numMaxRegs As Int16

    'paths
    Public appIni As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida Projects\"
    Public controlPath As String = My.Application.Info.DirectoryPath & "\Controles\"
    Public entradaDigitalFile As String = My.Application.Info.DirectoryPath & "\Controles\Entrada Digital.ctr"
    Public entradaDigitalRegFile As String = My.Application.Info.DirectoryPath & "\Controles\Entrada Digital-Reg.ctr"
    Public saidaDigitalFile As String = My.Application.Info.DirectoryPath & "\Controles\Saída Digital.ctr"
    Public saidaDigitalRegFile As String = My.Application.Info.DirectoryPath & "\Controles\Saída Digital-Reg.ctr"
    Public entradaAnalogicaFile As String = My.Application.Info.DirectoryPath & "\Controles\Entrada Analógica.ctr"
    Public saidaAnalogicaFile As String = My.Application.Info.DirectoryPath & "\Controles\Saída Analógica.ctr"
    Public botaoFile As String = My.Application.Info.DirectoryPath & "\Controles\Botão.ctr"
    Public chaveFile As String = My.Application.Info.DirectoryPath & " \Controles\Chave.ctr"
    Public motor1File As String = My.Application.Info.DirectoryPath & " \Controles\Motor1.ctr"
    Public motor1RegFile As String = My.Application.Info.DirectoryPath & "\Controles\Motor1-Reg.ctr"
    Public motor2File As String = My.Application.Info.DirectoryPath & "\Controles\Motor2.ctr"
    Public motor2RegFile As String = My.Application.Info.DirectoryPath & " \Controles\Motor2-Reg.ctr"
    Public motorCCFile As String = My.Application.Info.DirectoryPath & "\Controles\MotorCC.ctr"
    Public motorCCRegFile As String = My.Application.Info.DirectoryPath & "\Controles\MotorCC-Reg.ctr"
    Public servoFile As String = My.Application.Info.DirectoryPath & "\Controles\Saída Servo Motor.ctr"
    Public sensorTempC As String = My.Application.Info.DirectoryPath & " \Controles\Sensor de Temperatura C.ctr"
    Public sensorRegTempC As String = My.Application.Info.DirectoryPath & "\Controles\Sensor de Temperatura C-Reg.ctr"
    Public sensorTempF As String = My.Application.Info.DirectoryPath & " \Controles\Sensor de Temperatura F.ctr"
    Public sensorRegTempF As String = My.Application.Info.DirectoryPath & "\Controles\Sensor de Temperatura F-Reg.ctr"
    Public sensorUltra As String = My.Application.Info.DirectoryPath & "\Controles\HC-SR04.ctr"
    Public cameraIp As String = My.Application.Info.DirectoryPath & "\Controles\Câmera IP.ctr"
    Public chart As String = My.Application.Info.DirectoryPath & "\Controles\Gráfico.ctr"
    Public imagem As String = My.Application.Info.DirectoryPath & "\Controles\Imagem.ctr"
    Public btReg As String = My.Application.Info.DirectoryPath & "\Controles\Botão-Reg.ctr"
    Public chaveReg As String = My.Application.Info.DirectoryPath & "\Controles\Chave-Reg.ctr"
    Public entradaReg32 As String = My.Application.Info.DirectoryPath & "\Controles\Entrada Registrador-32bits.ctr"
    Public saidaReg32 As String = My.Application.Info.DirectoryPath & "\Controles\Saída Registrador-32Bits.ctr"
    Public redLed As String = My.Application.Info.DirectoryPath & "\Controles\Led Vermelho.ctr"
    Public greenLed As String = My.Application.Info.DirectoryPath & "\Controles\Led Verde.ctr"
    Public filePotenciometro As String = My.Application.Info.DirectoryPath & "\Controles\Potenciometro.ctr"
    Public saidaServo As String = My.Application.Info.DirectoryPath & "\Controles\Saída Servo Motor.ctr"
    Public leituraServo As String = My.Application.Info.DirectoryPath & "\Controles\Entrada Servo Motor.ctr"
    Public textBox As String = My.Application.Info.DirectoryPath & "\Controles\TextBox.ctr"
    Public textBoxSimples As String = My.Application.Info.DirectoryPath & "\Controles\TextBoxSimples.ctr"
    Public btComando As String = My.Application.Info.DirectoryPath & "\Controles\Botão de Comando.ctr"
    Public rotuloFile As String = My.Application.Info.DirectoryPath & "\Controles\Rótulo.ctr"
    Public checkBoxFile As String = My.Application.Info.DirectoryPath & "\Controles\Check.ctr"
    Public cmdUP As String = My.Application.Info.DirectoryPath & "\Controles\Para Cima.ctr"
    Public cmdDown As String = My.Application.Info.DirectoryPath & "\Controles\Para Baixo.ctr"
    Public cmdLeft As String = My.Application.Info.DirectoryPath & "\Controles\Para Esquerda.ctr"
    Public cmdRight As String = My.Application.Info.DirectoryPath & "\Controles\Para Direita.ctr"
    Public cmdUPReg As String = My.Application.Info.DirectoryPath & "\Controles\Para Cima Reg.ctr"
    Public cmdDownReg As String = My.Application.Info.DirectoryPath & "\Controles\Para Baixo Reg.ctr"
    Public cmdLeftReg As String = My.Application.Info.DirectoryPath & "\Controles\Para Esquerda Reg.ctr"
    Public cmdRightReg As String = My.Application.Info.DirectoryPath & "\Controles\Para Direita Reg.ctr"
    Public greenLedOff As String = My.Application.Info.DirectoryPath & "\Imagens\Comando\GreenLedOff.png"
    Public greenLedOn As String = My.Application.Info.DirectoryPath & "\Imagens\Comando\GreenLedOn.png"
    Public redLedOn As String = My.Application.Info.DirectoryPath & "\Imagens\Comando\RedLedOn.png"
    Public fileGrafico As String = My.Application.Info.DirectoryPath & "\Controles\Gráfico.ctr"
    Public x360Default As String = My.Application.Info.DirectoryPath & "\DefaultFiles\X360.cfg"
    Public ds4Default As String = My.Application.Info.DirectoryPath & "\DefaultFiles\DS4.cfg"
    Public g27Default As String = My.Application.Info.DirectoryPath & "\DefaultFiles\G27.cfg"

    'Ferramentas

    Public lastActions As String = ""

    Public Sub monitorSerialWrite(ByVal valor As String)
        Console.WriteLine(DruidaSuiteMain.COMPort.IsOpen)
        If (DruidaSuiteMain.COMPort.IsOpen) Then
            Try
                DruidaSuiteMain.COMPort.Write(valor)
            Catch ex As Exception
                DruidaSuiteMain.COMPort.Close()
                MessageBox.Show("Erro ao enviar informações para a placa. (Timeout Write)")
            End Try
            If valor <> "0.0.0.0.0.0.0.0.0.0_" And valor <> "r" Then
                lastActions = valor & vbLf
            End If
        End If
        If (Application.OpenForms.OfType(Of Ferramentas).Count > 0) Then
            Ferramentas.TextBoxMonitorSerialWrite.Text += valor
        End If
    End Sub

    Public Sub monitorSerialRead(ByVal valor As String)
        If (Application.OpenForms.OfType(Of Ferramentas).Count > 0) Then
            Ferramentas.TextBoxMonitorSerialRead.Text += valor
        End If
    End Sub

    'Programação

    Public rascunhoCodigo As String = ""

    Sub PlayBackgroundSoundFile(sound As String)
        If (audioEnable) Then My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Media\" & sound, AudioPlayMode.Background)
    End Sub

    Public Function toInt(dado() As Boolean)
        Dim aux As Int32 = 1
        Dim sum As UInt16 = 0
        For i As Byte = 0 To (dado.Length - 1)
            sum = sum + (aux * CInt(-dado(i)))
            aux = aux * 2
        Next
        Return (sum)
    End Function

    Public Function toInt32(dado() As Boolean)
        Dim aux As Int64 = 1
        Dim sum As UInt32 = 0
        For i As Byte = 0 To (dado.Length - 1)
            sum = sum + (aux * CInt(-dado(i)))
            aux = aux * 2
        Next
        Return (sum)
    End Function

    Public Function getBit(ByVal regPos As Byte, ByVal bit As Byte)
        Dim val As Int32 = dados(regPos)
        Dim newVal As String = Convert.ToString(val, 2).PadLeft(32, "0"c) '32 bits
        newVal = StrReverse(newVal)
        Dim bitR As Boolean
        bitR = newVal(bit) = "1"
        Return bitR
    End Function

    Public Sub FuncaoIndisponivel()
        If MessageBox.Show("Essa função está disponível apenas na versão completa. Deseja adquiri-la agora?", "Adquirir Software Completo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            System.Diagnostics.Process.Start("https://binary-quantum.com/pre-venda/")
        End If
    End Sub
End Module
