'Imports System.Windows.Forms

'Public Class DialogDownload
'    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ProgressBarDownload.Increment(15)
'        TimerDownload.Enabled = True
'    End Sub

'    Private Sub TimerDownload_Tick(sender As Object, e As EventArgs) Handles TimerDownload.Tick
'        Static Dim progress As Int16 = 0
'        Static Dim erro As Int16 = 0
'        Static Dim dados() As String
'        Static Dim iDados() As UInt16 = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
'        If (progress = 0) Then
'            If (DruidaSuiteMain.COMPort.IsOpen) Then
'                labelInfo.Text = "Interrompendo rede de informações"
'                DruidaSuiteMain.StopRede()
'                DruidaSuiteMain.TimerTryConnect.Enabled = False
'                monitorSerialRead(DruidaSuiteMain.COMPort.ReadExisting())
'            End If
'        End If
'        If (progress = 1) Then
'            If (DruidaSuiteMain.COMPort.IsOpen) Then
'                labelInfo.Text = "Abrindo nova linha de comunicação"
'                monitorSerialWrite("_")
'                'ArduinoSuiteMain.COMPort.Write("_")
'            End If
'            TimerDownload.Interval = 100
'        End If
'        If (progress = 1) Then
'            If (DruidaSuiteMain.COMPort.IsOpen) Then
'                leituraRede = ""
'                monitorSerialWrite("2.0.0.0.0.0.0.0.0.0_")
'                'ArduinoSuiteMain.COMPort.Write("2.0.0.0.0.0.0.0.0.0_")
'            End If
'        End If
'        If (progress = 3) Then
'            labelInfo.Text = "Recebendo Informações"
'            leituraRede = DruidaSuiteMain.COMPort.ReadLine
'            monitorSerialRead(leituraRede)
'        End If
'        If (progress = 4) Then
'            labelInfo.Text = "Verificando Informações"
'            dados = leituraRede.Split(".")
'            If (leituraRede = "" Or dados(9) <> "1") Then
'                labelInfo.Text = "Erro de leitura. Tentando Novamente..."
'                TimerDownload.Interval = 500
'                progress = -1
'                erro = erro + 1
'            End If
'        End If
'        If (progress = 5) Then
'            erro = 0
'            labelInfo.Text = "Processando Dados:"
'            For i As Int16 = 0 To 9
'                iDados(i) = CUInt(dados(i))
'            Next
'        End If
'        If (progress = 6) Then
'            labelInfo.Text = "Preenchendo tabela de configuração<ENTRADAS>:"
'            Configurações.ListBoxSelecaoArduino.SelectedIndex = arduinoType
'            configuraEntradasWord0(Convert.ToString(iDados(0), 2).PadLeft(16, "0"))
'            configuraEntradasWord1(Convert.ToString(iDados(1), 2).PadLeft(16, "0"))
'            configuraEntradasWord2(Convert.ToString(iDados(1), 2).PadLeft(16, "0"))
'            configuraEntradasWord3(Convert.ToString(iDados(1), 2).PadLeft(16, "0"))
'            configuraEntradasWord4(Convert.ToString(iDados(1), 2).PadLeft(16, "0"))
'        End If
'        If (progress = 7) Then
'            labelInfo.Text = "Preenchendo tabela de configuração<PULLUPs>:"
'            configuraEPullUpsWord0(Convert.ToString(iDados(2), 2).PadLeft(16, "0"))
'            configuraEPullUpsWord1(Convert.ToString(iDados(3), 2).PadLeft(16, "0"))
'            configuraEPullUpsWord2(Convert.ToString(iDados(2), 2).PadLeft(16, "0"))
'            configuraEPullUpsWord3(Convert.ToString(iDados(3), 2).PadLeft(16, "0"))
'            configuraEPullUpsWord4(Convert.ToString(iDados(3), 2).PadLeft(16, "0"))
'        End If
'        If (progress = 8) Then
'            labelInfo.Text = "Preenchendo tabela de configuração<Saidas>:"
'            configuraSaidasWord0(Convert.ToString(iDados(4), 2).PadLeft(16, "0"))
'            configuraSaidasWord1(Convert.ToString(iDados(5), 2).PadLeft(16, "0"))
'            configuraSaidasWord2(Convert.ToString(iDados(5), 2).PadLeft(16, "0"))
'            configuraSaidasWord3(Convert.ToString(iDados(5), 2).PadLeft(16, "0"))
'            configuraSaidasWord4(Convert.ToString(iDados(5), 2).PadLeft(16, "0"))
'        End If
'        If (progress = 9) Then
'            labelInfo.Text = "Preenchendo tabela de configuração<SaidasR>:"
'            configuraSaidasRWord0(Convert.ToString(iDados(6), 2).PadLeft(16, "0"))
'            configuraSaidasRWord1(Convert.ToString(iDados(7), 2).PadLeft(16, "0"))
'            configuraSaidasRWord2(Convert.ToString(iDados(7), 2).PadLeft(16, "0"))
'            configuraSaidasRWord3(Convert.ToString(iDados(7), 2).PadLeft(16, "0"))
'            configuraSaidasRWord4(Convert.ToString(iDados(7), 2).PadLeft(16, "0"))
'        End If
'        If (progress = 10) Then
'            DruidaSuiteMain.TimerTryConnect.Enabled = True
'            labelInfo.Text = "Preenchendo tabela de configuração<PWMs>:"
'            configuraPWMWord0(Convert.ToString(iDados(8), 2).PadLeft(16, "0"))
'            TimerDownload.Interval = 500
'        End If
'        If (progress = 11) Then
'            TimerDownload.Interval = 500
'            labelInfo.Text = "Download concluído!"
'            TimerDownload.Enabled = False
'            MessageBox.Show("Download concluído com sucesso!!", "Donload Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Me.Close()
'        End If
'        progress = progress + 1
'        If (erro = 0) Then ProgressBarDownload.Increment(10)
'        If (erro > 3) Then
'            TimerDownload.Enabled = False
'            MessageBox.Show("Falha na comunicação com a placa. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Me.Close()
'        End If
'    End Sub
'End Class


