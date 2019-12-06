Public Class Configurações
    'Configurações Iniciais
    Private Sub Configurações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DruidaSuiteMain.searchPort()
        CabecalhoConfig.Text = CabecalhoConfig.Text & " <" & AppName & ">"
        ListBoxSelecaoArduino.SelectedIndex = 0
        ListBoxSelecionaPorta.SelectedItem = porta
        ListBoxSelecionaVelocidade.SelectedIndex = 0
        'If (My.Computer.FileSystem.FileExists(applicationDirectory & "\Config Files\Configuracao.cfg")) Then
        '    importConfig(applicationDirectory & "\Config Files\Configuracao.cfg")
        'End If
        If (My.Computer.FileSystem.FileExists(applicationDirectory & "\Config Files\Notes.txt")) Then
            TextBoxNotes.Text = System.IO.File.ReadAllText(applicationDirectory & "\Config Files\Notes.txt")
        End If
        If (My.Computer.FileSystem.FileExists(applicationDirectory & "\Config Files\Esquematico.png")) Then
            PictureBoxEsquematico.Image = SafeImageFromFile(applicationDirectory & "\Config Files\Esquematico.png")
        End If
        If (DruidaSuiteMain.COMPort.IsOpen) Then
            GroupBoxArduinoInfo.Visible = True
        Else
            GroupBoxArduinoInfo.Visible = False
        End If
    End Sub

    Private Sub ListBoxSelecaoArduino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSelecaoArduino.SelectedIndexChanged
        Dim path As String = applicationDirectory & "\Config Files"
        Static Dim bkpNodes() As TreeNode = {Comando.Componentes.Nodes.Item(0).Clone,
                                             Comando.Componentes.Nodes.Item(1).Clone,
                                             Comando.Componentes.Nodes.Item(2).Clone,
                                             Comando.Componentes.Nodes.Item(3).Clone,
                                             Comando.Componentes.Nodes.Item(4).Clone}
        Comando.Componentes.Nodes.Clear()
        GroupBoxConfiguraHardware.Visible = ListBoxSelecaoArduino.SelectedIndex < 3
        'VisualisadorCodigoArduino.Visible = ListBoxSelecaoArduino.SelectedIndex = 3
        'If (ListBoxSelecaoArduino.SelectedIndex = 0) Then
        '    PictureBoxArduino.Image = ArduinoSuite.My.Resources.Resources.Arduino_NANO
        '    PreencheEspecificacoes(13, 8, 6, "32KB", "2KB", "1KB", "16MHz")
        '    PanelConfiguraHardwareGrupo1.Visible = True
        '    PanelConfiguraHardwareGrupo2.Visible = False
        '    PanelConfiguraHardwareGrupo3.Visible = False
        '    visibilidadePaineisConfig(1, 1, 0, 0, 0, 0)
        '    setPortNames("A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7")
        '    habilitaPWM()
        'End If
        'If (ListBoxSelecaoArduino.SelectedIndex = 1) Then
        '    PictureBoxArduino.Image = ArduinoSuite.My.Resources.Resources.Arduino_UNO
        '    PreencheEspecificacoes(13, 6, 6, "32KB", "2KB", "1KB", "16MHz")
        '    PanelConfiguraHardwareGrupo1.Visible = True
        '    PanelConfiguraHardwareGrupo2.Visible = False
        '    PanelConfiguraHardwareGrupo3.Visible = False
        '    visibilidadePaineisConfig(0, 0, 0, 0, 0, 0)
        '    setPortNames("A0", "A1", "A2", "A3", "A4", "A5", "20", "21")
        '    habilitaPWM()
        'End If
        'If (ListBoxSelecaoArduino.SelectedIndex = 2) Then
        '    PictureBoxArduino.Image = ArduinoSuite.My.Resources.Resources.Arduino_MEGA
        '    PreencheEspecificacoes(54, 16, 15, "256KB", "8KB", "4KB", "16MHz")
        '    PanelConfiguraHardwareGrupo1.Visible = True
        '    PanelConfiguraHardwareGrupo2.Visible = True
        '    PanelConfiguraHardwareGrupo3.Visible = False
        '    visibilidadePaineisConfig(1, 1, 1, 1, 1, 0)
        '    setPortNames("14", "15", "16", "17", "18", "19", "20", "21")
        '    habilitaPWM()
        'End If
        If (appProgrammingMethod = "Avançado") Then
            PictureBoxArduino.Image = My.Resources.SourceCode
            Comando.Componentes.Nodes.AddRange(bkpNodes)
            Comando.Componentes.Nodes.Item(0).Remove()
        Else
            Comando.Componentes.Nodes.AddRange(bkpNodes)
            Comando.Componentes.Nodes.Item(1).Remove()
        End If
        GroupBoxConfiguralcoesMenu.Visible = ListBoxSelecaoArduino.SelectedIndex <> 3
        arduinoConfig = ListBoxSelecaoArduino.SelectedIndex
    End Sub

    Private Sub PictureBoxExportar_Click(sender As Object, e As EventArgs) Handles PictureBoxExportar.Click
        If Mode <> Completo Then
            FuncaoIndisponivel()
            Exit Sub
        End If
        PlayBackgroundSoundFile("Click.wav")
        System.IO.Directory.CreateDirectory(applicationDirectory & "\Config Files")
        Dim exportConfigDialog As SaveFileDialog = New SaveFileDialog With {
            .Filter = "Arquivo de configuração|*.cfg",
            .InitialDirectory = applicationDirectory & "\Config Files",
            .Title = "Exportar Arquivo de Configuração"
        }
        exportConfigDialog.ShowDialog()
        If (exportConfigDialog.FileName <> "") Then
            'exportConfig(exportConfigDialog.FileName)
        End If
    End Sub

    Private Sub PictureBoxImportar_Click(sender As Object, e As EventArgs) Handles PictureBoxImportar.Click
        If Mode <> Completo Then
            FuncaoIndisponivel()
            Exit Sub
        End If
        PlayBackgroundSoundFile("Click.wav")
        Dim importConfigDialog As OpenFileDialog = New OpenFileDialog With {
            .Filter = "Arquivo de configuração|*.cfg",
            .InitialDirectory = applicationDirectory & "\Config Files",
            .Title = "Importar Arquivo de Configuração"
        }
        importConfigDialog.ShowDialog()
        'If (importConfigDialog.FileName <> "") Then
        '    importConfig(importConfigDialog.FileName)
        'End If
    End Sub

    Private Sub ListBoxSelecionaPorta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSelecionaPorta.SelectedIndexChanged
        porta = ListBoxSelecionaPorta.SelectedItem
        If (arduinoConfig = 3) Then
            configPorta()
        End If
    End Sub

    Private Sub configPorta()
        Dim debugDir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\Arduino\"
        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = Environment.GetEnvironmentVariable("comspec"),
            .RedirectStandardInput = True,
            .RedirectStandardOutput = True
        }
        myprocess.StartInfo = StartInfo
        StartInfo.UseShellExecute = False
        StartInfo.CreateNoWindow = True
        myprocess.Start()
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        SW.WriteLine("cd " & debugDir)
        SW.WriteLine("arduino_debug  --port " & porta)
        'SW.Close()
    End Sub

    'ANIMAÇÕES
    Private Sub PictureBoxImportar_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxImportar.MouseHover
        PictureBoxImportar.Image = ArduinoSuite.My.Resources.Resources.importar1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxImportar_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxImportar.MouseLeave
        PictureBoxImportar.Image = ArduinoSuite.My.Resources.Resources.importar
    End Sub

    Private Sub PictureBoxExportar_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxExportar.MouseHover
        PictureBoxExportar.Image = ArduinoSuite.My.Resources.Resources.exportar1
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxExportar_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxExportar.MouseLeave
        PictureBoxExportar.Image = ArduinoSuite.My.Resources.Resources.exportar
    End Sub

    Private Sub PictureBoxDownload_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxDownload.MouseHover
        If (portaAberta) Then
            PictureBoxDownload.Image = ArduinoSuite.My.Resources.Resources.Download1
        Else
            PictureBoxDownload.Image = ArduinoSuite.My.Resources.Resources.Download3
        End If
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxDownload_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxDownload.MouseLeave
        If (portaAberta) Then
            PictureBoxDownload.Image = ArduinoSuite.My.Resources.Resources.Download
        Else
            PictureBoxDownload.Image = ArduinoSuite.My.Resources.Resources.Download2
        End If

    End Sub

    Private Sub PictureBoxUpload_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxUpload.MouseHover
        If (portaAberta) Then
            PictureBoxUpload.Image = ArduinoSuite.My.Resources.Resources.Upload1
        Else
            PictureBoxUpload.Image = ArduinoSuite.My.Resources.Resources.Upload3
        End If
        PlayBackgroundSoundFile("Focus.wav")
    End Sub
    Private Sub PictureBoxUpload_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxUpload.MouseLeave
        If (portaAberta) Then
            PictureBoxUpload.Image = ArduinoSuite.My.Resources.Resources.Upload
        Else
            PictureBoxUpload.Image = ArduinoSuite.My.Resources.Resources.Upload2
        End If
        PlayBackgroundSoundFile("Focus.wav")
    End Sub

    Private Sub PictureBoxUpload_Click(sender As Object, e As EventArgs) Handles PictureBoxUpload.Click
        If Not DruidaSuiteMain.COMPort.IsOpen Then
            Try
                DruidaSuiteMain.COMPort.Open()
            Catch ex As Exception
                MessageBox.Show("Houve um erro ao abrir a porta de comunicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        DruidaSuiteMain.StopRede()
        If (Application.OpenForms.OfType(Of Ferramentas).Count > 0) Then Ferramentas.Close()
        If (portaAberta) Then
            DialogUpload.Show()
        End If
    End Sub

    Private Sub PictureBoxDownload_Click(sender As Object, e As EventArgs) Handles PictureBoxDownload.Click
        If Not DruidaSuiteMain.COMPort.IsOpen Then
            Try
                DruidaSuiteMain.COMPort.Open()
            Catch ex As Exception
                MessageBox.Show("Houve um erro ao abrir a porta de comunicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        DruidaSuiteMain.StopRede()
        If (Application.OpenForms.OfType(Of Ferramentas).Count > 0) Then Ferramentas.Close()
        If (portaAberta And arduinoConfig <> 3) Then
            DialogDownload.Show()
        End If
    End Sub

    Private Sub GroupBoxArduinoInfo_VisibleChanged(sender As Object, e As EventArgs) Handles GroupBoxArduinoInfo.VisibleChanged
        Dim arduinoName As String = ""
        If (arduinoType = 0 And arduinoConfig <> 3) Then
            PictureBoxArduinoInfo.Image = ArduinoSuite.My.Resources.Resources.Arduino_NANO
            arduinoName = "NANO"
        End If
        If (arduinoType = 1) Then
            PictureBoxArduinoInfo.Image = ArduinoSuite.My.Resources.Resources.Arduino_UNO
            arduinoName = "UNO"
        End If
        If (arduinoType = 2) Then
            PictureBoxArduinoInfo.Image = ArduinoSuite.My.Resources.Resources.Arduino_MEGA
            arduinoName = "MEGA"
        End If
        If (versaoFirmware > 999) Then
            arduinoNameInfo.Text = arduinoName & " - " & CStr(versaoFirmware)(0) & "." & CStr(versaoFirmware)(1) & "." & CStr(versaoFirmware)(2) & "." & CStr(versaoFirmware)(3)
        End If
        nEntradasInfo.Text = nEntradas
        nPullUpInfo.Text = nPullUps
        nSaidasInfo.Text = nSaidas
        nSaidasRInfo.Text = nSaidasRt
        nPWMInfo.Text = nPWM
    End Sub

    'PUSH BACK Radio Buttons
    Private Sub RadioButtonEntrada2_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada2.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada2.Checked = False
    End Sub
    Private Sub RadioButtonEntrada3_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada3.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada3.Checked = False
    End Sub
    Private Sub RadioButtonEntrada4_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada4.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada4.Checked = False
    End Sub
    Private Sub RadioButtonEntrada5_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada5.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada5.Checked = False
    End Sub
    Private Sub RadioButtonEntrada6_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada6.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada6.Checked = False
    End Sub
    Private Sub RadioButtonEntrada7_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada7.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada7.Checked = False
    End Sub
    Private Sub RadioButtonEntrada8_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada8.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada8.Checked = False
    End Sub
    Private Sub RadioButtonEntrada9_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada9.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada9.Checked = False
    End Sub
    Private Sub RadioButtonEntrada10_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada10.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada10.Checked = False
    End Sub
    Private Sub RadioButtonEntrada11_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada11.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada11.Checked = False
    End Sub
    Private Sub RadioButtonEntrada12_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada12.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada12.Checked = False
    End Sub
    Private Sub RadioButtonEntrada13_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada13.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada13.Checked = False
    End Sub
    Private Sub RadioButtonEntrada14_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada14.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada14.Checked = False
    End Sub
    Private Sub RadioButtonEntrada15_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada15.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada15.Checked = False
    End Sub
    Private Sub RadioButtonEntrada16_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada16.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada16.Checked = False
    End Sub
    Private Sub RadioButtonEntrada17_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada17.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada17.Checked = False
    End Sub
    Private Sub RadioButtonEntrada18_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada18.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada18.Checked = False
    End Sub
    Private Sub RadioButtonEntrada19_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada19.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada19.Checked = False
    End Sub
    Private Sub RadioButtonEntrada20_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada20.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada20.Checked = False
    End Sub
    Private Sub RadioButtonEntrada21_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada21.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada21.Checked = False
    End Sub
    Private Sub RadioButtonEntrada22_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada22.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada22.Checked = False
    End Sub
    Private Sub RadioButtonEntrada23_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada23.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada23.Checked = False
    End Sub
    Private Sub RadioButtonEntrada24_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada24.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada24.Checked = False
    End Sub
    Private Sub RadioButtonEntrada25_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada25.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada25.Checked = False
    End Sub
    Private Sub RadioButtonEntrada26_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada26.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada26.Checked = False
    End Sub
    Private Sub RadioButtonEntrada27_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada27.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada27.Checked = False
    End Sub
    Private Sub RadioButtonEntrada28_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada28.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada28.Checked = False
    End Sub
    Private Sub RadioButtonEntrada29_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada29.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada29.Checked = False
    End Sub
    Private Sub RadioButtonEntrada30_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada30.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada30.Checked = False
    End Sub
    Private Sub RadioButtonEntrada31_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada31.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada31.Checked = False
    End Sub
    Private Sub RadioButtonEntrada32_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada32.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada32.Checked = False
    End Sub
    Private Sub RadioButtonEntrada33_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada33.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada33.Checked = False
    End Sub
    Private Sub RadioButtonEntrada34_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada34.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada34.Checked = False
    End Sub
    Private Sub RadioButtonEntrada35_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada35.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada35.Checked = False
    End Sub
    Private Sub RadioButtonEntrada36_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada36.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada36.Checked = False
    End Sub
    Private Sub RadioButtonEntrada37_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada37.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada37.Checked = False
    End Sub
    Private Sub RadioButtonEntrada38_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada38.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada38.Checked = False
    End Sub
    Private Sub RadioButtonEntrada39_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada39.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada39.Checked = False
    End Sub
    Private Sub RadioButtonEntrada40_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada40.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada40.Checked = False
    End Sub
    Private Sub RadioButtonEntrada41_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada41.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada41.Checked = False
    End Sub
    Private Sub RadioButtonEntrada42_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada42.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada42.Checked = False
    End Sub
    Private Sub RadioButtonEntrada43_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada43.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada43.Checked = False
    End Sub
    Private Sub RadioButtonEntrada44_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada44.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada44.Checked = False
    End Sub
    Private Sub RadioButtonEntrada45_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada45.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada45.Checked = False
    End Sub
    Private Sub RadioButtonEntrada46_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada46.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada46.Checked = False
    End Sub
    Private Sub RadioButtonEntrada47_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada47.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada47.Checked = False
    End Sub
    Private Sub RadioButtonEntrada48_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada48.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada48.Checked = False
    End Sub
    Private Sub RadioButtonEntrada49_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada49.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada49.Checked = False
    End Sub
    Private Sub RadioButtonEntrada50_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada50.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada50.Checked = False
    End Sub
    Private Sub RadioButtonEntrada51_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada51.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada51.Checked = False
    End Sub
    Private Sub RadioButtonEntrada52_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada52.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada52.Checked = False
    End Sub
    Private Sub RadioButtonEntrada53_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada53.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada53.Checked = False
    End Sub
    Private Sub RadioButtonEntrada54_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada54.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada54.Checked = False
    End Sub
    Private Sub RadioButtonEntrada55_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada55.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada55.Checked = False
    End Sub
    Private Sub RadioButtonEntrada56_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada56.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada56.Checked = False
    End Sub
    Private Sub RadioButtonEntrada57_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada57.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada57.Checked = False
    End Sub
    Private Sub RadioButtonEntrada58_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada58.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada58.Checked = False
    End Sub
    Private Sub RadioButtonEntrada59_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada59.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada59.Checked = False
    End Sub
    Private Sub RadioButtonEntrada60_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada60.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada60.Checked = False
    End Sub
    Private Sub RadioButtonEntrada61_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada61.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada61.Checked = False
    End Sub
    Private Sub RadioButtonEntrada62_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada62.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada62.Checked = False
    End Sub
    Private Sub RadioButtonEntrada63_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada63.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada63.Checked = False
    End Sub
    Private Sub RadioButtonEntrada64_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada64.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada64.Checked = False
    End Sub
    Private Sub RadioButtonEntrada65_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada65.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada65.Checked = False
    End Sub
    Private Sub RadioButtonEntrada66_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada66.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada66.Checked = False
    End Sub
    Private Sub RadioButtonEntrada67_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada67.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada67.Checked = False
    End Sub
    Private Sub RadioButtonEntrada68_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada68.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada68.Checked = False
    End Sub
    Private Sub RadioButtonEntrada69_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEntrada69.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEntrada69.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp2_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp2.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp2.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp3_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp3.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp3.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp4_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp4.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp4.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp5_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp5.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp5.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp6_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp6.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp6.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp7_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp7.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp7.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp8_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp8.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp8.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp9_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp9.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp9.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp10_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp10.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp10.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp11_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp11.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp11.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp12_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp12.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp12.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp13_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp13.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp13.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp14_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp14.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp14.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp15_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp15.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp15.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp16_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp16.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp16.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp17_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp17.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp17.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp18_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp18.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp18.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp19_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp19.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp19.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp20_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp20.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp20.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp21_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp21.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp21.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp22_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp22.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp22.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp23_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp23.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp23.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp24_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp24.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp24.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp25_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp25.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp25.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp26_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp26.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp26.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp27_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp27.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp27.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp28_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp28.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp28.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp29_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp29.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp29.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp30_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp30.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp30.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp31_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp31.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp31.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp32_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp32.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp32.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp33_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp33.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp33.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp34_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp34.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp34.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp35_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp35.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp35.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp36_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp36.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp36.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp37_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp37.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp37.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp38_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp38.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp38.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp39_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp39.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp39.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp40_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp40.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp40.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp41_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp41.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp41.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp42_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp42.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp42.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp43_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp43.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp43.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp44_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp44.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp44.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp45_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp45.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp45.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp46_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp46.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp46.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp47_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp47.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp47.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp48_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp48.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp48.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp49_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp49.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp49.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp50_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp50.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp50.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp51_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp51.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp51.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp52_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp52.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp52.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp53_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp53.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp53.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp54_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp54.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp54.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp55_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp55.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp55.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp56_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp56.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp56.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp57_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp57.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp57.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp58_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp58.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp58.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp59_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp59.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp59.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp60_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp60.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp60.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp61_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp61.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp61.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp62_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp62.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp62.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp63_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp63.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp63.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp64_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp64.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp64.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp65_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp65.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp65.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp66_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp66.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp66.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp67_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp67.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp67.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp68_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp68.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp68.Checked = False
    End Sub
    Private Sub RadioButtonEPullUp69_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonEPullUp69.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonEPullUp69.Checked = False
    End Sub
    Private Sub RadioButtonSaidas2_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas2.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas2.Checked = False
    End Sub
    Private Sub RadioButtonSaidas3_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas3.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas3.Checked = False
    End Sub
    Private Sub RadioButtonSaidas4_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas4.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas4.Checked = False
    End Sub
    Private Sub RadioButtonSaidas5_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas5.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas5.Checked = False
    End Sub
    Private Sub RadioButtonSaidas6_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas6.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas6.Checked = False
    End Sub
    Private Sub RadioButtonSaidas7_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas7.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas7.Checked = False
    End Sub
    Private Sub RadioButtonSaidas8_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas8.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas8.Checked = False
    End Sub
    Private Sub RadioButtonSaidas9_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas9.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas9.Checked = False
    End Sub
    Private Sub RadioButtonSaidas10_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas10.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas10.Checked = False
    End Sub
    Private Sub RadioButtonSaidas11_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas11.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas11.Checked = False
    End Sub
    Private Sub RadioButtonSaidas12_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas12.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas12.Checked = False
    End Sub
    Private Sub RadioButtonSaidas13_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas13.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas13.Checked = False
    End Sub
    Private Sub RadioButtonSaidas14_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas14.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas14.Checked = False
    End Sub
    Private Sub RadioButtonSaidas15_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas15.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas15.Checked = False
    End Sub
    Private Sub RadioButtonSaidas16_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas16.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas16.Checked = False
    End Sub
    Private Sub RadioButtonSaidas17_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas17.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas17.Checked = False
    End Sub
    Private Sub RadioButtonSaidas18_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas18.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas18.Checked = False
    End Sub
    Private Sub RadioButtonSaidas19_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas19.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas19.Checked = False
    End Sub
    Private Sub RadioButtonSaidas20_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas20.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas20.Checked = False
    End Sub
    Private Sub RadioButtonSaidas21_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas21.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas21.Checked = False
    End Sub
    Private Sub RadioButtonSaidas22_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas22.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas22.Checked = False
    End Sub
    Private Sub RadioButtonSaidas23_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas23.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas23.Checked = False
    End Sub
    Private Sub RadioButtonSaidas24_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas24.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas24.Checked = False
    End Sub
    Private Sub RadioButtonSaidas25_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas25.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas25.Checked = False
    End Sub
    Private Sub RadioButtonSaidas26_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas26.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas26.Checked = False
    End Sub
    Private Sub RadioButtonSaidas27_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas27.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas27.Checked = False
    End Sub
    Private Sub RadioButtonSaidas28_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas28.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas28.Checked = False
    End Sub
    Private Sub RadioButtonSaidas29_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas29.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas29.Checked = False
    End Sub
    Private Sub RadioButtonSaidas30_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas30.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas30.Checked = False
    End Sub
    Private Sub RadioButtonSaidas31_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas31.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas31.Checked = False
    End Sub
    Private Sub RadioButtonSaidas32_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas32.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas32.Checked = False
    End Sub
    Private Sub RadioButtonSaidas33_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas33.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas33.Checked = False
    End Sub
    Private Sub RadioButtonSaidas34_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas34.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas34.Checked = False
    End Sub
    Private Sub RadioButtonSaidas35_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas35.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas35.Checked = False
    End Sub
    Private Sub RadioButtonSaidas36_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas36.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas36.Checked = False
    End Sub
    Private Sub RadioButtonSaidas37_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas37.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas37.Checked = False
    End Sub
    Private Sub RadioButtonSaidas38_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas38.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas38.Checked = False
    End Sub
    Private Sub RadioButtonSaidas39_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas39.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas39.Checked = False
    End Sub
    Private Sub RadioButtonSaidas40_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas40.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas40.Checked = False
    End Sub
    Private Sub RadioButtonSaidas41_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas41.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas41.Checked = False
    End Sub
    Private Sub RadioButtonSaidas42_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas42.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas42.Checked = False
    End Sub
    Private Sub RadioButtonSaidas43_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas43.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas43.Checked = False
    End Sub
    Private Sub RadioButtonSaidas44_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas44.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas44.Checked = False
    End Sub
    Private Sub RadioButtonSaidas45_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas45.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas45.Checked = False
    End Sub
    Private Sub RadioButtonSaidas46_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas46.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas46.Checked = False
    End Sub
    Private Sub RadioButtonSaidas47_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas47.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas47.Checked = False
    End Sub
    Private Sub RadioButtonSaidas48_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas48.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas48.Checked = False
    End Sub
    Private Sub RadioButtonSaidas49_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas49.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas49.Checked = False
    End Sub
    Private Sub RadioButtonSaidas50_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas50.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas50.Checked = False
    End Sub
    Private Sub RadioButtonSaidas51_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas51.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas51.Checked = False
    End Sub
    Private Sub RadioButtonSaidas52_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas52.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas52.Checked = False
    End Sub
    Private Sub RadioButtonSaidas53_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas53.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas53.Checked = False
    End Sub
    Private Sub RadioButtonSaidas54_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas54.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas54.Checked = False
    End Sub
    Private Sub RadioButtonSaidas55_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas55.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas55.Checked = False
    End Sub
    Private Sub RadioButtonSaidas56_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas56.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas56.Checked = False
    End Sub
    Private Sub RadioButtonSaidas57_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas57.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas57.Checked = False
    End Sub
    Private Sub RadioButtonSaidas58_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas58.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas58.Checked = False
    End Sub
    Private Sub RadioButtonSaidas59_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas59.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas59.Checked = False
    End Sub
    Private Sub RadioButtonSaidas60_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas60.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas60.Checked = False
    End Sub
    Private Sub RadioButtonSaidas61_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas61.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas61.Checked = False
    End Sub
    Private Sub RadioButtonSaidas62_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas62.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas62.Checked = False
    End Sub
    Private Sub RadioButtonSaidas63_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas63.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas63.Checked = False
    End Sub
    Private Sub RadioButtonSaidas64_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas64.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas64.Checked = False
    End Sub
    Private Sub RadioButtonSaidas65_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas65.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas65.Checked = False
    End Sub
    Private Sub RadioButtonSaidas66_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas66.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas66.Checked = False
    End Sub
    Private Sub RadioButtonSaidas67_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas67.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas67.Checked = False
    End Sub
    Private Sub RadioButtonSaidas68_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas68.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas68.Checked = False
    End Sub
    Private Sub RadioButtonSaidas69_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidas69.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidas69.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR2_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR2.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR2.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR3_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR3.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR3.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR4_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR4.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR4.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR5_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR5.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR5.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR6_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR6.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR6.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR7_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR7.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR7.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR8_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR8.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR8.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR9_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR9.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR9.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR10_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR10.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR10.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR11_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR11.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR11.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR12_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR12.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR12.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR13_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR13.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR13.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR14_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR14.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR14.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR15_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR15.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR15.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR16_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR16.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR16.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR17_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR17.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR17.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR18_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR18.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR18.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR19_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR19.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR19.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR20_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR20.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR20.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR21_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR21.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR21.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR22_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR22.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR22.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR23_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR23.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR23.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR24_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR24.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR24.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR25_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR25.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR25.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR26_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR26.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR26.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR27_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR27.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR27.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR28_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR28.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR28.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR29_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR29.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR29.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR30_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR30.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR30.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR31_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR31.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR31.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR32_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR32.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR32.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR33_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR33.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR33.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR34_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR34.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR34.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR35_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR35.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR35.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR36_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR36.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR36.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR37_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR37.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR37.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR38_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR38.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR38.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR39_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR39.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR39.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR40_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR40.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR40.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR41_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR41.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR41.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR42_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR42.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR42.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR43_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR43.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR43.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR44_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR44.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR44.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR45_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR45.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR45.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR46_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR46.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR46.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR47_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR47.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR47.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR48_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR48.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR48.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR49_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR49.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR49.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR50_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR50.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR50.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR51_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR51.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR51.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR52_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR52.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR52.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR53_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR53.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR53.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR54_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR54.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR54.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR55_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR55.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR55.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR56_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR56.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR56.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR57_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR57.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR57.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR58_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR58.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR58.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR59_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR59.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR59.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR60_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR60.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR60.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR61_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR61.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR61.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR62_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR62.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR62.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR63_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR63.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR63.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR64_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR64.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR64.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR65_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR65.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR65.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR66_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR66.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR66.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR67_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR67.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR67.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR68_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR68.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR68.Checked = False
    End Sub
    Private Sub RadioButtonSaidasR69_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonSaidasR69.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonSaidasR69.Checked = False
    End Sub
    Private Sub RadioButtonPWM2_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM2.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM2.Checked = False
    End Sub
    Private Sub RadioButtonPWM3_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM3.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM3.Checked = False
    End Sub
    Private Sub RadioButtonPWM4_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM4.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM4.Checked = False
    End Sub
    Private Sub RadioButtonPWM5_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM5.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM5.Checked = False
    End Sub
    Private Sub RadioButtonPWM6_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM6.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM6.Checked = False
    End Sub
    Private Sub RadioButtonPWM7_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM7.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM7.Checked = False
    End Sub
    Private Sub RadioButtonPWM8_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM8.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM8.Checked = False
    End Sub
    Private Sub RadioButtonPWM9_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM9.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM9.Checked = False
    End Sub
    Private Sub RadioButtonPWM10_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM10.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM10.Checked = False
    End Sub
    Private Sub RadioButtonPWM11_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM11.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM11.Checked = False
    End Sub
    Private Sub RadioButtonPWM12_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM12.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM12.Checked = False
    End Sub
    Private Sub RadioButtonPWM13_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM13.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM13.Checked = False
    End Sub
    Private Sub RadioButtonPWM43_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM43.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM43.Checked = False
    End Sub
    Private Sub RadioButtonPWM44_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM44.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM44.Checked = False
    End Sub
    Private Sub RadioButtonPWM45_MouseRight(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles RadioButtonPWM45.MouseDown
        If (e.Button = MouseButtons.Right) Then RadioButtonPWM45.Checked = False
    End Sub

    Private Sub TextBoxTempoRede_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTempoRede.TextChanged
        If (TextBoxTempoRede.Text <> "") Then
            If (TextBoxTempoRede.Text >= 50) Then
                DruidaSuiteMain.TimerLeituraRede.Interval = TextBoxTempoRede.Text
            End If
        End If
    End Sub

    Private Sub TextBoxTempoRede_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTempoRede.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ListBoxSelecionaVelocidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSelecionaVelocidade.SelectedIndexChanged
        DruidaSuiteMain.COMPort.BaudRate = ListBoxSelecionaVelocidade.SelectedItem
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ContextMenuStripBlueTooth.Show()
        ContextMenuStripBlueTooth.Location = MousePosition
    End Sub

    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarToolStripMenuItem.Click
        'If (portaAberta) Then
        Dim dialog As DialogResult = MessageBox.Show("Conecte o módulo Bluetooth no Arduino: TX->2 e RX->3", "Configurar Bluetooth", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (dialog = DialogResult.OK) Then
            ConfiguraBluetooth.Show()
        End If
        'Else
        'Dim dialog As DialogResult = MessageBox.Show("O arduino deve estar online para inicar a configuração do bluetooth", "Configurar Bluetooth", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End If
    End Sub

    Private Sub ParearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParearToolStripMenuItem.Click
        Dim pair As String = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) & "\DevicePairingWizard.exe"
        If System.IO.File.Exists(pair) Then
            Process.Start(pair)
        End If
    End Sub

    Private Sub TextBoxTempoRede_Leave(sender As Object, e As EventArgs) Handles TextBoxTempoRede.Leave
        If (TextBoxTempoRede.Text < 50) Then
            If (MessageBox.Show("Requisições de rede abaixo de 50ms podem causar instabilidades nos comandos. Tem certeza que deseja continuar?", "Risco de Instabilidade", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                DruidaSuiteMain.TimerLeituraRede.Interval = TextBoxTempoRede.Text
            End If
        End If
    End Sub

    Private Sub ListBoxSelecaoArduino_MouseEnter(sender As Object, e As EventArgs) Handles ListBoxSelecaoArduino.MouseEnter
        ListBoxSelecaoArduino.Enabled = Not (DruidaSuiteMain.COMPort.IsOpen)
    End Sub

    Private Sub PictureBoxEsquematico_Click(sender As Object, e As EventArgs) Handles PictureBoxEsquematico.Click
        Dim openImage As New OpenFileDialog With {
            .Filter = "Imagens|*.png",
            .InitialDirectory = My.Application.Info.DirectoryPath & "\Imagens\",
            .Title = "Importar Imagem"
        }
        If (openImage.ShowDialog() = DialogResult.OK) Then
            My.Computer.FileSystem.CreateDirectory(applicationDirectory & "\Config Files")
            System.IO.File.Copy(openImage.FileName, applicationDirectory & "\Config Files\Esquematico.png", True)
            PictureBoxEsquematico.Image = SafeImageFromFile(applicationDirectory & "\Config Files\Esquematico.png")
        End If
    End Sub

    Public Shared Function SafeImageFromFile(path As String) As Image
        Using fs As New System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function
End Class


