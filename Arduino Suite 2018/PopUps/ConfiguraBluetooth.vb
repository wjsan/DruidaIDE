Imports System.ComponentModel
Imports System.Windows.Forms

Public Class ConfiguraBluetooth

    Dim velocidades() As String = {"9600", "115200", "2400", "4800", "19200", "38400", "57600", "1200"}
    Dim resposta As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If (TextBoxNome.Text <> "" Or TextBoxPIN.Text <> "") Then
            Dim path As String = applicationDirectory & "\Bluetooth.cfg"
            Dim dados() As String = {TextBoxNome.Text, TextBoxPIN.Text}
            System.IO.File.WriteAllLines(path, dados)
        End If
        If appProgrammingMethod <> "Avançado" Then
            If arduinoConfig = 0 Then
                EnviaFirmware("Arduino_UNO.ino.hex", "115200")
            Else
                EnviaFirmware("Arduino_NANO.ino.hex", "115200")
            End If
        End If
        MessageBox.Show("Desligue e conecte o Módulo Bluetooth nas portas  TX->0, RX->1. Depois realize o pareamento com o mesmo.", "Parear Bluetooth", MessageBoxButtons.OK)
        Dim pair As String = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) & "\DevicePairingWizard.exe"
        If System.IO.File.Exists(pair) Then
            Process.Start(pair)
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ConfiguraBluetooth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DruidaSuiteMain.COMPort.Close()
        DruidaSuiteMain.COMPort.BaudRate = 9600
        If appProgrammingMethod <> "Avançado" Then
            If arduinoConfig = 0 Then
                EnviaFirmware("configuraBluetooth_NANO.ino.hex", "115200")
            Else
                EnviaFirmware("configuraBluetooth_UNO.ino.hex", "115200")
            End If
        Else
            Dim msg As String = ""
            msg &= "Conecte o módulo Bluetooth nos pinos: TX->2 e RX->3 (não se esqueça dos resistores!!)"
            msg &= "Deseja abrir o sketch com o código de configuração para enviá-lo ao arduino?"
            If MessageBox.Show(msg, "Enviar método para arduino", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Process.Start(My.Application.Info.DirectoryPath & "\configuraBluetooth\configuraBluetooth.ino")
            End If
        End If
        Dim path As String = applicationDirectory & "\Bluetooth.cfg"
        If (System.IO.File.Exists(path)) Then
            Dim dados() As String = System.IO.File.ReadAllLines(path)
            TextBoxNome.Text = dados(0)
            TextBoxPIN.Text = dados(1)
        End If
    End Sub

    Private Sub TimerComBlue_Tick(sender As Object, e As EventArgs) Handles TimerComBlue.Tick
        Static Dim cont As UInt16 = 0
        Static Dim i = 0
        Static Dim progressStep = 100 / 16
        If (dadoRecebido) Then
            leitura()
            TextBoxResponse.Text = "Encontrado Baud Rate = " & velocidades(i)
            ProgressBar1.Value = 100
            TimerComBlue.Enabled = False
            dadoRecebido = False
            cont = 0
            PictureBoxStatus.Image = My.Resources.Enabled
            GroupBox1.Enabled = True
        Else
            cont += 1
            ProgressBar1.Increment(progressStep)
            If (cont Mod 2 = 0) Then
                i = cont / 2
            End If
            If (i = 8) Then
                i = 0
                cont = 0
            End If
            If (cont Mod 2 = 0) Then
                DruidaSuiteMain.COMPort.Write(i)
            Else
                DruidaSuiteMain.COMPort.Write("AT")
            End If
            TextBoxResponse.Text = "Procurando baud rate = " & velocidades(i)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DruidaSuiteMain.COMPort.BaudRate = velocidades(0)
        GroupBox1.Enabled = False
        PictureBoxStatus.Image = My.Resources.Disabled
        If Not (DruidaSuiteMain.COMPort.IsOpen) Then
            Try
                DruidaSuiteMain.COMPort.Open()
            Catch ex As Exception
                MessageBox.Show("Erro ao abrir a porta: " & DruidaSuiteMain.COMPort.PortName & ". Verifique as configurações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        TimerComBlue.Enabled = True
        DruidaSuiteMain.COMPort.Write("AT")
        TextBoxResponse.Text = "Procurando baud rate = " & velocidades(0)
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        dadoRecebido = False
        TimerEnviar.Enabled = True
        ProgressBar1.Value = 0
    End Sub

    Private Sub TimerEnviar_Tick(sender As Object, e As EventArgs) Handles TimerEnviar.Tick
        Static Dim etapa As UInt16 = 0
        Static Dim progressStep = 100 / 16
        If (etapa = 0) Then
            TextBoxResponse.Text = "Enviando Novo Nome..."
            DruidaSuiteMain.COMPort.Write("AT+NAME" & TextBoxNome.Text)
            ProgressBar1.Value = 10
        End If
        If (etapa = 2) Then
            etapa = 1
            TextBoxResponse.Text = "Aguardando Resposta..."
            ProgressBar1.Value = 15
            If (dadoRecebido) Then
                leitura()
                If (resposta = "OKsetname" & vbCrLf) Then
                    ProgressBar1.Value = 25
                    TextBoxResponse.Text = "Nome Alterado com Sucesso..."
                    PictureBoxName.Image = My.Resources.Enabled
                    etapa = 3
                    dadoRecebido = False
                Else
                    ProgressBar1.Value = 20
                    dadoRecebido = False
                    TextBoxResponse.Text = "Tentando Novamente..."
                    DruidaSuiteMain.COMPort.Write("AT+NAME" & TextBoxNome.Text)
                    etapa = 1
                End If
            End If
        End If
        If (etapa = 5) Then
            ProgressBar1.Value = 30
            TextBoxResponse.Text = "Enviando Novo PIN..."
            DruidaSuiteMain.COMPort.Write("AT+PIN" & TextBoxPIN.Text)
        End If
        If (etapa = 7) Then
            etapa = 6
            TextBoxResponse.Text = "Aguardando Resposta..."
            ProgressBar1.Value = 35
            If (dadoRecebido) Then
                leitura()
                ProgressBar1.Value = 40
                If (resposta = "OKsetPIN" & vbCrLf) Then
                    ProgressBar1.Value = 50
                    TextBoxResponse.Text = "PIN Alterado com Sucesso..."
                    PictureBoxPIN.Image = My.Resources.Enabled
                    etapa = 8
                    dadoRecebido = False
                Else
                    dadoRecebido = False
                    TextBoxResponse.Text = "Tentando Novamente..."
                    DruidaSuiteMain.COMPort.Write("AT+PIN" & TextBoxPIN.Text)
                    etapa = 6
                End If
            End If
        End If
        If (etapa = 9) Then
            ProgressBar1.Value = 65
            TextBoxResponse.Text = "Configurando BaudRate..."
            DruidaSuiteMain.COMPort.Write(GetBaud())
        End If
        If (etapa = 11) Then
            ProgressBar1.Value = 70
            etapa = 10
            TextBoxResponse.Text = "Aguardando Resposta..."
            If (dadoRecebido) Then
                ProgressBar1.Value = 80
                leitura()
                If (resposta.Contains("OK")) Then
                    ProgressBar1.Value = 90
                    TextBoxResponse.Text = "BaudRate Alterado com Sucesso..."
                    PictureBoxPIN.Image = My.Resources.Enabled
                    etapa = 11
                    dadoRecebido = False
                Else
                    dadoRecebido = False
                    TextBoxResponse.Text = "Tentando Novamente..."
                    DruidaSuiteMain.COMPort.Write(GetBaud)
                    etapa = 10
                End If
            End If
        End If
        If (etapa = 12) Then
            ProgressBar1.Value = 100
            TimerEnviar.Enabled = False
            TextBoxResponse.Text = "Configuração Concluída."
            MessageBox.Show("Dados Enviados Com Sucesso!", "Configuração do Bluetooth", MessageBoxButtons.OK)
        End If
        etapa += 1
    End Sub

    Private Sub leitura()
        resposta = DruidaSuiteMain.COMPort.ReadExisting
        TextBoxBluetooth.Text += resposta
    End Sub

    Private Sub ConfiguraBluetooth_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DruidaSuiteMain.COMPort.BaudRate = velocidade
    End Sub

    Private Function GetBaud()
        If velocidade = 1200 Then
            Return "AT+BAUD2"
        ElseIf velocidade = 4800 Then
            Return "AT+BAUD3"
        ElseIf velocidade = 9600 Then
            Return "AT+BAUD4"
        ElseIf velocidade = 19200 Then
            Return "AT+BAUD5"
        ElseIf velocidade = 38400 Then
            Return "AT+BAUD6"
        ElseIf velocidade = 57600 Then
            Return "AT+BAUD7"
        ElseIf velocidade = 115200 Then
            Return "AT+BAUD8"
        ElseIf velocidade = 230400 Then
            Return "AT+BAUD9"
        ElseIf velocidade = 460800 Then
            Return "AT+BAUDA"
        ElseIf velocidade = 921600 Then
            Return "AT+BAUDB"
        ElseIf velocidade = 12382400 Then
            Return "AT+BAUDC"
        Else
            MessageBox.Show("A velocidade configurada no druida não é compatível com módulo bluetooth.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
            Return "ERRO"
        End If
        '        AT+BAUD1	OK1200	Seta o baud rate em 1200
        'AT+BAUD2	OK2400	Seta o baud rate em 2400
        'AT+BAUD3	OK4800	Seta o baud rate em 4800
        'AT+BAUD4	OK9600	Seta o baud rate em 9600
        'AT+BAUD5	OK19200	Seta o baud rate em 19200
        'AT+BAUD6	OK38400	Seta o baud rate em 38400
        'AT+BAUD7	OK57600	Seta o baud rate em 57600
        'AT+BAUD8	OK115200	Seta o baud rate em 115200
        'AT+BAUD9	OK230400	Seta o baud rate em 230400
        'AT+BAUDA	OK460800	Seta o baud rate em 460800
        'AT+BAUDB	OK921600	Seta o baud rate em 921600
        'AT+BAUDC	OK1382400	Seta o baud rate em 1382400
    End Function
End Class
