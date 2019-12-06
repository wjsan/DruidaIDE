Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Comando
    Dim posCursorClick As Point
    Dim vazio() As String = {"carregando..."}
    Dim pathLista As String = applicationDirectory & "\Comando\ListaTelas.list"
    Dim abreComando = False
    Dim leituraJoy = False
    Dim itemArrastado As UInt16 = 0
    Public referenciaHorizontal As UInt16 = Nothing
    Public ReferenciaVertical As UInt16 = Nothing
    Public leftAnalogXVal As Int16
    Public leftAnalogYVal As Int16
    Public rightAnalogXVal As Int16
    Public rightAnalogYVal As Int16
    Public gatilhoDireitoVal As Int16
    Public gatilhoEsquerdoVal As Int16
    Public taskButtonRef As TaskButton
    Private cfgManager As New AppCfg

    Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer

    <StructLayout(LayoutKind.Sequential)>
    Public Structure JOYINFOEX
        Public dwSize As Integer
        Public dwFlags As Integer
        Public dwXpos As Integer
        Public dwYpos As Integer
        Public dwZpos As Integer
        Public dwRpos As Integer
        Public dwUpos As Integer
        Public dwVpos As Integer
        Public dwButtons As Integer
        Public dwButtonNumber As Integer
        Public dwPOV As Integer
        Public dwReserved1 As Integer
        Public dwReserved2 As Integer
    End Structure

    Public myjoyEX As JOYINFOEX
    'Ações Iniciais
    Private Sub Comando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ToolStripComboBoxModo.Items.Contains(cfgManager.Ler("Modo")) Then
            ToolStripComboBoxModo.SelectedItem = cfgManager.Ler("Modo")
        End If
        ToolStripStatusSize.Text = PanelComando.Size.ToString
        If (DruidaSuiteMain.COMPort.IsOpen) Then
            If Not (arduinoType = arduinoConfig) Then
                MessageBox.Show("Para ficar online, realize o download da confiugração da placa conectada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        telas.AddRange(System.IO.File.ReadAllLines(pathLista))
        For Each element In telas
            ComboBoxSelecionaTela.Items.Add(element)
            ToolStripComboBoxSelecionaTela.Items.Add(element)
        Next
        If (ComboBoxSelecionaTela.Items.Count = 1) Then
            ExcluirToolStripMenuItem.Enabled = False
            ToolStripButtonDeletar.Enabled = False
        Else
            ExcluirToolStripMenuItem.Enabled = True
            ToolStripButtonDeletar.Enabled = True
        End If
        ToolStripComboBoxSelecionaTela.SelectedIndex = 0
        If (joyPadOn = True) Then
            AtivadoToolStripMenuItem1.Image = My.Resources.Enabled
            DesativadoToolStripMenuItem1.Image = Nothing
        End If
        If (joyPadOn = False) Then
            DesativadoToolStripMenuItem1.Image = My.Resources.Disabled
            AtivadoToolStripMenuItem1.Image = Nothing
        End If
        ToolStripButtonReverter.Enabled = bufferPointer > 0
        ToolStripButtonRefazer.Enabled = (bufferPointer >= 0) And (bufferPointer < infBuffer.Count - 1)
        DesfazerToolStripMenuItem.Enabled = ToolStripButtonReverter.Enabled
        RefazerToolStripMenuItem.Enabled = ToolStripButtonRefazer.Enabled
        InitJoy()
        taskButtonRef = DruidaSuiteMain.taskButtons(DruidaSuiteMain.windowsOpened)
        DruidaSuiteMain.windowsOpened += 1
        taskButtonRef.Show()
        taskButtonRef.PictureBoxItem.Image = My.Resources._813df8d9
        taskButtonRef.LabelNomeItem.Text = "Comando"
        taskButtonRef.SetForm(Me)
    End Sub

    'Alterna entre Admin e Operador
    Private Sub RadioButtonAdmin_CheckedChanged(sender As Object, e As EventArgs)
        userIsAdmin = True
        MenuStripComando.Visible = True
        TableLayoutPanelComponentes.Visible = True
        PanelMenu.Visible = True
        PanelTela.Visible = True
    End Sub
    'AÇÕES CONTROLES
    'Troca de Tela
    Private Sub ToolStripComboBoxSelecionaTela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxSelecionaTela.SelectedIndexChanged
        ComboBoxSelecionaTela.SelectedItem = ToolStripComboBoxSelecionaTela.SelectedItem
        If (ToolStripComboBoxSelecionaTela.SelectedItem <> "carregando...") Then
            If (abreComando) Then
                SalvarDados()
            End If
            AbrirTela(ToolStripComboBoxSelecionaTela.SelectedItem)
            abreComando = True
        End If
    End Sub

    Private Sub ComboBoxSelecionaTela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelecionaTela.SelectedIndexChanged
        ToolStripComboBoxSelecionaTela.SelectedItem = ComboBoxSelecionaTela.SelectedItem
        If (ComboBoxSelecionaTela.SelectedItem <> "carregando...") Then
            If (abreComando) Then
                SalvarDados()
            End If
            AbrirTela(ComboBoxSelecionaTela.SelectedItem)
            abreComando = True
        End If
    End Sub

    Private Sub ToolStripMenuItemTeste_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTestar.Click
        Configurações.Show()
    End Sub

    Public Sub ComandoJoy()
        Static Dim leituraAnterior As String = ReadJoy()
        Dim leituraJoy As String = ReadJoy()
        If (DruidaSuiteMain.COMPort.IsOpen And joyPadOn) Then
            If (leituraJoy <> leituraAnterior) Then
                For Each element In PanelComando.Controls
                    If (element.GetType = GetType(ControleHardware) And element.Visible) Then
                        If (element.engine.joyKey <> "" And element.engine.joyKey <> "Nenhuma" And element.engine.Tipo = "Saída Digital") Then
                            'If (leituraJoy(13 - element.engine.joyKey) <> leituraAnterior(13 - element.engine.joyKey)) Then
                            Dim siz = leituraJoy.Count - 1
                            If (leituraJoy(siz - element.engine.joyKey) = "1") Then
                                element.btPressed()
                            Else
                                element.btReleased()
                            End If
                            'End If
                        End If
                    End If
                Next
            End If
        End If
        leituraAnterior = leituraJoy
    End Sub

    Function ReadJoy()
        ' Get the joystick information
        InitJoy()
        Dim botao As String = "NONE"
        Call joyGetPosEx(joySeetings.port, myjoyEX)
        With myjoyEX
            If (joyPadType = 1) Then
                leftAnalogXVal = (.dwXpos / 65535) * (joySeetings.anEsqXMax - joySeetings.anEsqXMin) + joySeetings.anEsqXMin
                leftAnalogYVal = (.dwYpos / 65535) * (joySeetings.anEsqYMax - joySeetings.anEsqYMin) + joySeetings.anEsqYMin
                rightAnalogXVal = (.dwZpos / 65535) * (joySeetings.anDirXMax - joySeetings.anDirXMin) + joySeetings.anDirXMin
                rightAnalogYVal = (.dwRpos / 65535) * (joySeetings.anDirYMax - joySeetings.anDirYMin) + joySeetings.anDirYMin
                gatilhoDireitoVal = (.dwUpos / 65535) * (joySeetings.gatEsqMax - joySeetings.gatEsqMin) + joySeetings.gatEsqMin
                gatilhoEsquerdoVal = (.dwVpos / 65535) * (joySeetings.gatDirMax - joySeetings.gatDirMin) + joySeetings.gatDirMin
            End If
            If (joyPadType = 0) Then
                Dim auxGatDir As Int16 = 0
                Dim auxGatEsq As Int16 = 0
                If .dwZpos < 32768 Then
                    auxGatDir = 32768 - .dwZpos
                Else
                    auxGatEsq = .dwZpos - 32768
                End If
                leftAnalogXVal = (.dwXpos / 65535) * (joySeetings.anEsqXMax - joySeetings.anEsqXMin) + joySeetings.anEsqXMin
                leftAnalogYVal = (.dwYpos / 65535) * (joySeetings.anEsqYMax - joySeetings.anEsqYMin) + joySeetings.anEsqYMin
                rightAnalogXVal = (.dwZpos / 65535) * (joySeetings.anDirXMax - joySeetings.anDirXMin) + joySeetings.anDirXMin
                rightAnalogYVal = (.dwRpos / 65535) * (joySeetings.anDirYMax - joySeetings.anDirYMin) + joySeetings.anDirYMin
                gatilhoDireitoVal = (auxGatDir / 32640) * (joySeetings.gatEsqMax - joySeetings.gatEsqMin) + joySeetings.gatEsqMin
                gatilhoEsquerdoVal = (auxGatEsq / 32640) * (joySeetings.gatDirMax - joySeetings.gatDirMin) + joySeetings.gatDirMin
            End If
            If joyPadType = 2 Then
                leftAnalogXVal = (.dwXpos / 65535) * (joySeetings.volanteMax - joySeetings.volanteMin) + joySeetings.volanteMin
                leftAnalogYVal = (.dwZpos / 65535) * (joySeetings.aceleradorMax - joySeetings.aceleradorMin) + joySeetings.aceleradorMin
                rightAnalogXVal = (.dwUpos / 65535) * (joySeetings.embreagemMax - joySeetings.embreagemMin) + joySeetings.embreagemMin
                rightAnalogYVal = (.dwRpos / 65535) * (joySeetings.freioMax - joySeetings.freioMin) + joySeetings.freioMin
            End If
            Dim codBotoesVal As UInt16 = .dwButtons
            Dim botoesPress As Int16 = .dwButtonNumber
            Dim direcionaisVal As UInt16 = (.dwPOV / 100)
            Dim buttonsPressed As String = Convert.ToString(CUInt(codBotoesVal), 2).PadLeft(14, "0")
            Return (buttonsPressed)
        End With
        Return (botao)
    End Function

    Sub InitJoy()
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF ' All information
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim novaEntradaAnalogica As New EntradaAnalogica
        'novaEntradaAnalogica.Location = New Point(300, 300)
        'PanelComando.Controls.Add(novaEntradaAnalogica)
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click, ToolStripButtonNovaTela.Click
        'ComboBoxSelecionaTela.DataSource = vazio
        If telas.Count >= 3 And Mode <> Completo Then
            AdquirirSoftware.ShowDialog()
            Exit Sub
        End If
        ComboBoxSelecionaTela.Items.Clear()
        ToolStripComboBoxSelecionaTela.Items.Clear()
        Criar_Tela_de_Comando.ShowDialog()
        If (Criar_Tela_de_Comando.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            If (telas.Contains(Criar_Tela_de_Comando.TextBoxNomeTela.Text)) Then
                MessageBox.Show("A tela já existe", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ComboBoxSelecionaTela.DataSource = telas
                For Each element In telas
                    ComboBoxSelecionaTela.Items.Add(element)
                    ToolStripComboBoxSelecionaTela.Items.Add(element)
                Next
            Else
                MessageBox.Show("Tela Criada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AtualizaListaTelas()
            End If
        End If
        If (ComboBoxSelecionaTela.Items.Count = 1) Then
            ExcluirToolStripMenuItem.Enabled = False
            ToolStripButtonDeletar.Enabled = False
        Else
            ExcluirToolStripMenuItem.Enabled = True
            ToolStripButtonDeletar.Enabled = True
        End If
        If (Criar_Tela_de_Comando.DialogResult = System.Windows.Forms.DialogResult.Cancel) Then
            'ComboBoxSelecionaTela.DataSource = telas
            For Each element In telas
                ComboBoxSelecionaTela.Items.Add(element)
                ToolStripComboBoxSelecionaTela.Items.Add(element)
            Next
        End If
    End Sub

    Private Sub AtualizaListaTelas()
        telas.Clear()
        telas.AddRange(System.IO.File.ReadAllLines(pathLista))
        'ComboBoxSelecionaTela.DataSource = telas
        For Each element In telas
            ComboBoxSelecionaTela.Items.Add(element)
            ToolStripComboBoxSelecionaTela.Items.Add(element)
        Next
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click, ToolStripButtonSalvar.Click
        If Mode <> Completo Then
            FuncaoIndisponivel()
            Exit Sub
        End If
        SalvarDados()
    End Sub
    'Renomear Tela
    Private Sub RenomearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenomearToolStripMenuItem.Click, ToolStripButtonRenomear.Click
        'ComboBoxSelecionaTela.DataSource = vazio
        ComboBoxSelecionaTela.Items.Clear()
        ToolStripComboBoxSelecionaTela.Items.Clear()
        Renomear.ShowDialog()
        If (Renomear.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            MessageBox.Show("Tela Renomeada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Computer.FileSystem.RenameDirectory(pathTela, Renomear.TextBoxNovoNome.Text)
            pathTela = applicationDirectory & "\Comando\" & Renomear.TextBoxNovoNome.Text
            My.Computer.FileSystem.RenameFile(pathTela & "\" & telas(telaAberta) & ".tela", Renomear.TextBoxNovoNome.Text & ".tela")
            telas(telaAberta) = Renomear.TextBoxNovoNome.Text
            System.IO.File.WriteAllLines(pathLista, telas)
            telas.Clear()
            telas.AddRange(System.IO.File.ReadAllLines(pathLista))
            ComboBoxSelecionaTela.Items.Clear()
            ToolStripComboBoxSelecionaTela.Items.Clear()
            For Each element In telas
                ComboBoxSelecionaTela.Items.Add(element)
                ToolStripComboBoxSelecionaTela.Items.Add(element)
            Next
            'ComboBoxSelecionaTela.DataSource = telas
        Else
            'ComboBoxSelecionaTela.DataSource = telas
            ComboBoxSelecionaTela.Items.Clear()
            ToolStripComboBoxSelecionaTela.Items.Clear()
            For Each element In telas
                ComboBoxSelecionaTela.Items.Add(element)
                ToolStripComboBoxSelecionaTela.Items.Add(element)
            Next
        End If
    End Sub
    'Excluir Tela
    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click, ToolStripButtonDeletar.Click
        abreComando = False
        Dim itemSelecionado As String = ComboBoxSelecionaTela.SelectedItem
        'ComboBoxSelecionaTela.DataSource = vazio
        ComboBoxSelecionaTela.Items.Clear()
        ToolStripComboBoxSelecionaTela.Items.Clear()
        If (MessageBox.Show("Confima Exclusão da tela?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            MessageBox.Show("Tela Removida", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Computer.FileSystem.DeleteDirectory(pathTela, FileIO.DeleteDirectoryOption.DeleteAllContents)
            telas.Remove(itemSelecionado)
            System.IO.File.WriteAllLines(pathLista, telas)
            'ComboBoxSelecionaTela.DataSource = telas
            For Each element In telas
                ComboBoxSelecionaTela.Items.Add(element)
                ToolStripComboBoxSelecionaTela.Items.Add(element)
            Next
            Try
                AbrirTela(telas(telaAberta))
            Catch ex As Exception
                AbrirTela(telas(telaAberta - 1))
                MessageBox.Show("Erro ao abrir a tela")
            End Try
        Else
            'ComboBoxSelecionaTela.DataSource = telas
            For Each element In telas
                ComboBoxSelecionaTela.Items.Add(element)
                ToolStripComboBoxSelecionaTela.Items.Add(element)
            Next
        End If

        If (ComboBoxSelecionaTela.Items.Count = 1) Then
            ExcluirToolStripMenuItem.Enabled = False
            ToolStripButtonDeletar.Enabled = False
        Else
            ExcluirToolStripMenuItem.Enabled = True
            ToolStripButtonDeletar.Enabled = True
        End If
    End Sub
    ''Adicionar Entrada Digital
    'Private Sub AdicionarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    '    AddEntrada(New Point(300, 250))
    'End Sub
    ''Adicionar Saida Digital
    'Private Sub AdicionarToolStripMenuItem2_Click(sender As Object, e As EventArgs)
    '    AddSaida(New Point(300, 250))
    'End Sub

    Private Sub AdicionarToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        'AddEntradaAnalogica(New Point(300, 250))
    End Sub

    Private Sub AtivadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtivadoToolStripMenuItem.Click
        AtivadoToolStripMenuItem.Image = My.Resources.Enabled
        DesativadoToolStripMenuItem.Image = Nothing
    End Sub

    Private Sub DesativadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesativadoToolStripMenuItem.Click
        DesativadoToolStripMenuItem.Image = My.Resources.Disabled
        AtivadoToolStripMenuItem.Image = Nothing
    End Sub

    Private Sub AtivadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtivadoToolStripMenuItem1.Click
        joyPadOn = True
        AtivadoToolStripMenuItem1.Image = My.Resources.Enabled
        DesativadoToolStripMenuItem1.Image = Nothing
    End Sub

    Private Sub DesativadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DesativadoToolStripMenuItem1.Click
        joyPadOn = False
        DesativadoToolStripMenuItem1.Image = My.Resources.Disabled
        AtivadoToolStripMenuItem1.Image = Nothing
    End Sub

    Private Sub Componentes_DragDrop(sender As Object, e As DragEventArgs) Handles PanelComando.DragDrop
        Dim offSetMouse As Point = New Point(SplitContainer1.Panel2.Location.X, SplitContainer1.Location.Y)
        Dim local As Point = MousePosition - offSetMouse
        'If (Componentes.SelectedNode.FullPath = "Hardware\Entrada Digital") Then
        '    AddEntrada(local)
        'End If
        'If (Componentes.SelectedNode.FullPath = "Hardware\Saída Digital") Then
        '    AddSaida(local)
        'End If
        'If (Componentes.SelectedNode.FullPath = "Hardware\Entrada Analógica") Then
        '    AddEntradaAnalogica(local)
        '    'AddComponent(entradaAnalogicaFile, local)
        'End If
        'If (Componentes.SelectedNode.FullPath = "Hardware\Saída Analógica") Then
        '    AddSaidaAnalogica(local)
        'End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Comando\Botão") Then
            AddComponent(botaoFile, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Comando\Chave") Then
            AddComponent(chaveFile, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Comando\Acima") Then
            AddComponent(cmdUP, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Comando\Abaixo") Then
            AddComponent(cmdDown, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Comando\Esquerda") Then
            AddComponent(cmdLeft, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Comando\Direita") Then
            AddComponent(cmdRight, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Motores\Motor 1") Then
            AddComponent(motor1File, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Motores\Motor 2") Then
            AddComponent(motor2File, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Sensores\Temperatura C°") Then
            AddComponent(sensorTempC, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Sensores\Temperatura F°") Then
            AddComponent(sensorTempF, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes\Câmera") Then
            addCamera(local)
        End If
        If (Componentes.SelectedNode.FullPath = "Gráficos\Chart") Then
            'AddGrafico(local)
        End If
        If (Componentes.SelectedNode.FullPath = "Gráficos\Imagem") Then
            AddImage(local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes Para Tela\Botão") Then
            AddComponent(btComando, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes Para Tela\Entrada de Dados") Then
            AddComponent(textBox, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Componentes Para Tela\Rótulo") Then
            AddComponent(rotuloFile, local)
        End If
        If (Componentes.SelectedNode.FullPath = "Controles Personalizados\Novo") Then
            CriarControleHardware.local = local
            CriarControleHardware.ShowDialog()
        End If
    End Sub

    Private Sub addCamera(ByVal local As Point)
        AddCameraIP.ref.engine.loadDataFromFile(cameraIp)
        AddCameraIP.local = local
        AddCameraIP.ShowDialog()
    End Sub

    Private Sub Componentes_DragEnter(sender As Object, e As DragEventArgs) Handles Componentes.DragEnter, PanelComando.DragEnter
        Componentes.SelectedNode = e.Data.GetData("System.Windows.Forms.TreeNode")
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Componentes_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles Componentes.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    'Private Sub AddEntrada(local As Point)
    '    getListaEntradas()
    '    If (listaEntradas.Count > 0) Then
    '        Adicionar_Entrada.Text = "Adicionar Entrada"
    '        Adicionar_Entrada.ref.engine.loadDataFromFile(entradaDigitalFile)
    '        Adicionar_Entrada.local = local
    '        Adicionar_Entrada.ShowDialog()
    '    Else
    '        MessageBox.Show("Não existem portas de entrada no projeto atual", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub AddSaida(local As Point)
    '    getListaSaidas()
    '    If (listaSaidas.Count > 0) Then
    '        Adicionar_Saída.Text = "Adicionar Saída"
    '        Adicionar_Saída.ref.engine.loadDataFromFile(saidaDigitalFile)
    '        Adicionar_Saída.local = local
    '        Adicionar_Saída.ShowDialog()
    '    Else
    '        MessageBox.Show("Não existem portas de saida no projeto atual", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub AddEntradaAnalogica(local As Point)
    '    getListaEntradasAnalogicas()
    '    If (listaEntradasAnalogicas.Count > 0) Then
    '        Adicionar_Entrada_Analógica.Text = "Adicionar Entrada Analógica"
    '        Adicionar_Entrada_Analógica.ref.engine.loadDataFromFile(entradaAnalogicaFile)
    '        Adicionar_Entrada_Analógica.local = local
    '        Adicionar_Entrada_Analógica.ShowDialog()
    '    Else
    '        MessageBox.Show("Não existem portas de entrada analógica no projeto atual", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub AddSaidaAnalogica(local As Point)
    '    getListaPWMs()
    '    If (listaPWMs.Count > 0) Then
    '        Adicionar_Saída_Analógica.Text = "Adicionar Saída Analógica"
    '        Adicionar_Saída_Analógica.ref.engine.loadDataFromFile(saidaAnalogicaFile)
    '        Adicionar_Saída_Analógica.local = local
    '        Adicionar_Saída_Analógica.ShowDialog()
    '    Else
    '        MessageBox.Show("Não existem portas de Saída analógica no projeto atual", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub AddGrafico(local As Point)
    '    getListaEntradasAnalogicas()
    '    If (listaEntradasAnalogicas.Count > 0) Then
    '        AddGráfico.Text = "Adicionar Gráfico"
    '        AddGráfico.ref.engine.loadDataFromFile(chart)
    '        AddGráfico.local = local
    '        AddGráfico.ShowDialog()
    '    Else
    '        MessageBox.Show("Não existem portas de entrada analógica no projeto atual", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub AddImage(local As Point)
        AddImagem.Text = "Adicionar Gráfico"
        AddImagem.ref.engine.loadDataFromFile(imagem)
        AddImagem.local = local
        AddImagem.ShowDialog()
    End Sub

    Private Sub AddComponent(fileName As String, local As Point)
        Dim novo As New ControleHardware
        novo.engine.loadDataFromFile(fileName)
        novo.engine.updateControl(novo)
        novo.Location = local
        PanelComando.Controls.Add(novo)
        novo.BringToFront()
    End Sub

    'Interrupção
    Private Sub ToolStripButtonInterromperPrograma_Click(sender As Object, e As EventArgs)
        'infBuffer.Clear()
        'refBuffer.Clear()
        'bufferPointer = 0
    End Sub
    'Atualiza a aplicação
    Private Sub ToolStripButtonStartScreen_Click(sender As Object, e As EventArgs)
        If (MessageBox.Show("Deseja salvar as alterações e rodar a aplicação?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            SalvarDados()
            AbrirTela(telas(telaAberta))
        End If
    End Sub
    'Abre a janela de teste de joystick
    Private Sub TestarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestarToolStripMenuItem.Click
        TesteJoytick.Show()
    End Sub
    'Para a leitura da Rede
    Private Sub ToolStripStop_Click(sender As Object, e As EventArgs)
        DruidaSuiteMain.StopRede()
    End Sub
    'Desfazer ultima alteração
    Private Sub ToolStripButtonReverter_Click(sender As Object, e As EventArgs) Handles ToolStripButtonReverter.Click, DesfazerToolStripMenuItem.Click
        bufferPointer -= 2
        If (infBuffer(bufferPointer).action = "move/resize") Then
            If (bufferPointer < 0) Then bufferPointer = 0
            refBuffer(bufferPointer).Location = infBuffer(bufferPointer).location
            refBuffer(bufferPointer).Size = infBuffer(bufferPointer).size
            refBuffer(bufferPointer).Visible = infBuffer(bufferPointer).visible
            refBuffer(bufferPointer).engine.salvaPosicao(refBuffer(bufferPointer))
            ToolStripButtonRefazer.Enabled = (bufferPointer >= 0) And (bufferPointer < infBuffer.Count - 1)
            ToolStripButtonReverter.Enabled = bufferPointer > 0
            DesfazerToolStripMenuItem.Enabled = ToolStripButtonReverter.Enabled
            RefazerToolStripMenuItem.Enabled = ToolStripButtonRefazer.Enabled
        End If
        If (infBuffer(bufferPointer).action = "delete") Then
            If (bufferPointer < 0) Then bufferPointer = 0
            Dim newControl As New ControleHardware
            newControl.engine.UpdateDataFromControlData(removedControls(removedControls.Count - 1).engine)
            removedControls.RemoveAt(removedControls.Count - 1)
            newControl.engine.updateControl(newControl)
            PanelComando.Controls.Add(newControl)
            newControl.BringToFront()
        End If
    End Sub
    'Refazer ultima alteração
    Private Sub RefazerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefazerToolStripMenuItem.Click, ToolStripButtonRefazer.Click
        bufferPointer += 2
        If (infBuffer(bufferPointer - 1).action = "move/resize") Then
            If (bufferPointer > infBuffer.Count) Then bufferPointer = infBuffer.Count
            refBuffer(bufferPointer - 1).Location = infBuffer(bufferPointer - 1).location
            refBuffer(bufferPointer - 1).Size = infBuffer(bufferPointer - 1).size
            refBuffer(bufferPointer - 1).Visible = infBuffer(bufferPointer - 1).visible
            refBuffer(bufferPointer - 1).engine.salvaPosicao(refBuffer(bufferPointer - 1))
            ToolStripButtonRefazer.Enabled = (bufferPointer >= 0) And (bufferPointer < infBuffer.Count - 1)
            ToolStripButtonReverter.Enabled = bufferPointer > 0
            DesfazerToolStripMenuItem.Enabled = ToolStripButtonReverter.Enabled
            RefazerToolStripMenuItem.Enabled = ToolStripButtonRefazer.Enabled
        End If
    End Sub

    'Apaga retangulos quando realiza desfazer ou refazer
    Private Sub RefazerDesfazerApagaRect(sender As Object, e As EventArgs) Handles ToolStripButtonReverter.Click, DesfazerToolStripMenuItem.Click, RefazerToolStripMenuItem.Click, ToolStripButtonRefazer.Click
        Dim dwg As Graphics = PanelComando.CreateGraphics
        dwg.Clear(PanelComando.BackColor)
        drawRects()
    End Sub
    'Colar elemento
    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        'Dim novoControle As New ControleHardware
        'novoControle.engine.updateDataFromControl(clipBoardControl)
        'novoControle.engine.local = posCursorClick
        'novoControle.Location = posCursorClick
        'novoControle.engine.canMove = True
        'PanelComando.Controls.Add(novoControle)
        'novoControle.engine.updateControl(novoControle)
        ToPaste()
    End Sub

    Private Sub ToPaste()
        For Each item As ControleHardware In clipBoardControlList
            Dim novoControle As New ControleHardware
            Dim offSetMouse As Point = New Point(SplitContainer1.Panel2.Location.X + Me.Parent.Location.X, SplitContainer1.Location.Y + Me.Parent.Location.Y)
            novoControle.engine.updateDataFromControl(item)
            novoControle.engine.local = MousePosition - offSetMouse + item.Location - clipBoardControlList.Item(0).Location
            novoControle.Location = posCursorClick
            novoControle.engine.canMove = True
            PanelComando.Controls.Add(novoControle)
            novoControle.engine.updateControl(novoControle)
            novoControle.Visible = False
            MeAtualizaBufferDesfazer(novoControle)
            novoControle.Visible = True
            MeAtualizaBufferDesfazer(novoControle)
            novoControle.BringToFront()
            bufferPointer = bufferPointer - (selectedControls.Count) * 2
        Next
    End Sub

    Private Sub ContextMenuStripComando_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripComando.Opening
        Dim offSetMouse As Point = New Point(SplitContainer1.Panel2.Location.X, SplitContainer1.Location.Y)
        posCursorClick = MousePosition - offSetMouse
        ColarToolStripMenuItem.Enabled = clipBoardControlList.Count > 0
    End Sub

    Private Sub LimparTelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparTelaToolStripMenuItem.Click, ToolStripButtonLimpaTela.Click
        If (MessageBox.Show("Tem certeza que deseja limpar a tela?", "Limpar a tela", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            While PanelComando.Controls.Count > 0
                For Each control In PanelComando.Controls
                    If (control.GetType = GetType(ControleHardware)) Then
                        'control.AtualizaBufferDesfazer()
                        control.Visible = False
                        'control.AtualizaBufferDesfazer()
                    End If
                Next
            End While
        End If
    End Sub

    Private Sub ToolStripButtonReverterTudo_Click(sender As Object, e As EventArgs) Handles ToolStripButtonReverterTudo.Click
        If (MessageBox.Show("Essa ação não podera ser desfeita.", "Reverter Tudo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            AbrirTela(telas(telaAberta))
        End If
    End Sub

    Private Sub RecortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecortarToolStripMenuItem.Click
        'MeAtualizaBufferDesfazer(PanelComando.Controls(apontaControle))
        'Dim cutHardware As New ControleHardware
        'cutHardware.engine.updateDataFromControl(PanelComando.Controls(apontaControle))
        'cutHardware.engine.updateControl(cutHardware)
        'clipBoardControl = cutHardware
        'PanelComando.Controls(apontaControle).Visible = False
        'MeAtualizaBufferDesfazer(PanelComando.Controls(apontaControle))
        For Each item As ControleHardware In selectedControls
            MeAtualizaBufferDesfazer(item)
            Dim newCutHardware As New ControleHardware
            newCutHardware.engine.updateDataFromControl(item)
            newCutHardware.engine.updateControl(newCutHardware)
            clipBoardControlList.Add(newCutHardware)
            item.Visible = False
            MeAtualizaBufferDesfazer(item)
        Next
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        ToCopy()
    End Sub

    Private Sub ToCopy()
        'Dim copyHardware As New ControleHardware
        'copyHardware.engine.updateDataFromControl(PanelComando.Controls(apontaControle))
        'copyHardware.engine.updateControl(copyHardware)
        'clipBoardControl = copyHardware
        'clipBoardControlList.Clear()
        clipBoardControlList.Clear()
        For Each item As ControleHardware In selectedControls
            Dim newcopyHardware As New ControleHardware
            newcopyHardware.engine.updateDataFromControl(item)
            newcopyHardware.engine.updateControl(newcopyHardware)
            clipBoardControlList.Add(newcopyHardware)
        Next
    End Sub

    Private Sub ColarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem1.Click
        'Dim novoControle As New ControleHardware
        'Dim offSetMouse As Point = New Point(SplitContainer1.Panel2.Location.X, SplitContainer1.Location.Y)
        'novoControle.engine.updateDataFromControl(clipBoardControl)
        'novoControle.engine.local = MousePosition - offSetMouse
        'novoControle.Location = posCursorClick
        'novoControle.engine.canMove = True
        'PanelComando.Controls.Add(novoControle)
        'novoControle.engine.updateControl(novoControle)
        ToPaste()
    End Sub

    Private Sub ExcluirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem1.Click
        If (selectedControls.Count > 0) Then
            For Each control In selectedControls
                control.BorderStyle = BorderStyle.FixedSingle
                control.AtualizaBufferDesfazer("move/resize")
                control.Visible = False
                control.AtualizaBufferDesfazer("move/resize")
            Next
        End If
    End Sub

    Private Sub ParaCimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParaCimaToolStripMenuItem.Click
        MoveObjeto(PanelComando.Controls(apontaControle), 0, -ToolStripTextBoxOffSet.Text)
    End Sub

    Private Sub ParaBaixoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParaBaixoToolStripMenuItem.Click
        MoveObjeto(PanelComando.Controls(apontaControle), 0, ToolStripTextBoxOffSet.Text)
    End Sub

    Private Sub ParaDireitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParaDireitaToolStripMenuItem.Click
        MoveObjeto(PanelComando.Controls(apontaControle), ToolStripTextBoxOffSet.Text, 0)
    End Sub

    Private Sub ParaEsquerdaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParaEsquerdaToolStripMenuItem1.Click
        MoveObjeto(PanelComando.Controls(apontaControle), -ToolStripTextBoxOffSet.Text, 0)
    End Sub

    Private Sub MoveObjeto(objeto As ControleHardware, xOffSet As Integer, yOffSet As Integer)
        If selectedControls.Count = 0 Then
            If Not objeto.engine.canMove Then Exit Sub
            MeAtualizaBufferDesfazer(objeto)
            Dim newLocation As New Point(objeto.Location.X + xOffSet, objeto.Location.Y + yOffSet)
            objeto.Location = newLocation
            MeAtualizaBufferDesfazer(objeto)
            Exit Sub
        End If
        For Each control As ControleHardware In selectedControls
            If control.engine.canMove Then
                MeAtualizaBufferDesfazer(control)
                Dim newControlLocation As New Point(control.Location.X + xOffSet, control.Location.Y + yOffSet)
                control.Location = newControlLocation
                MeAtualizaBufferDesfazer(control)
            End If
        Next
    End Sub

    Private Sub ToolStripTextBoxOffSet_Click(sender As Object, e As EventArgs) Handles ToolStripTextBoxOffSet.Click
        If (ToolStripTextBoxOffSet.Text < 0) Then
            ToolStripTextBoxOffSet.Text = 0
        End If
    End Sub

    Private Sub MeAtualizaBufferDesfazer(control As ControleHardware)
        control.AtualizaBufferDesfazer("move/resize")
    End Sub

    Private Sub PanelComando_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelComando.MouseMove
        Static Dim mousePos1 As New Point
        Static Dim mousePos2 As New Point
        Static Dim recPoint() As Int16 = {0, 0, 0, 0}
        Static Dim rectSel As Rectangle
        Dim offSetMouse As Point = New Point(SplitContainer1.Panel2.Location.X, SplitContainer1.Location.Y)
        ToolStripStatusMousePos.Text = (MousePosition - offSetMouse).ToString
        Dim dwg As Graphics = PanelComando.CreateGraphics()
        Static Dim startDrawing As Boolean = False
        If (e.Button = MouseButtons.Left And Not (startDrawing)) Then
            mousePos1 = MousePosition - offSetMouse
            startDrawing = True
        End If
        If (e.Button = MouseButtons.None) Then
            startDrawing = False
        End If
        If (startDrawing) Then
            mousePos2 = MousePosition - offSetMouse
            recPoint(0) = mousePos1.X
            recPoint(1) = mousePos1.Y
            recPoint(2) = mousePos2.X - mousePos1.X
            recPoint(3) = mousePos2.Y - mousePos1.Y
            If (recPoint(3) < 0) Then
                recPoint(1) = mousePos1.Y - (mousePos1.Y - mousePos2.Y)
                recPoint(3) = mousePos1.Y - recPoint(1)
            End If
            If (recPoint(2) < 0) Then
                recPoint(0) = mousePos1.X - (mousePos1.X - mousePos2.X)
                recPoint(2) = mousePos1.X - recPoint(0)
            End If
            dwg.Clear(Color.White)
            Dim blackPen = New Pen(Color.Black, 1)
            blackPen.DashStyle = Drawing2D.DashStyle.Dash
            rectSel = New Rectangle(recPoint(0), recPoint(1), recPoint(2), recPoint(3))
            dwg.DrawRectangle(blackPen, rectSel)
            For Each element In PanelComando.Controls
                If (rectSel.Contains(New Rectangle(element.Location.X, element.Location.Y, element.Width, element.Height)) And element.Visible) Then
                    If (Not (selectedControls.Contains(element))) Then
                        selectedControls.Add(element)
                        ToolStripStatusItemSelecionado.Text = selectedControls.Count
                        'element.BorderStyle = BorderStyle.Fixed3D
                        element.Cursor = Cursors.Default
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Comando_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keyPressed = e.KeyCode
        If (e.KeyCode = Keys.Escape) Then
            For Each element In PanelComando.Controls
                If (element.GetType = GetType(ControleHardware)) Then
                    selectedControls.Clear()
                    'element.BorderStyle = BorderStyle.None
                    ToolStripStatusItemSelecionado.Text = "Nenhum"
                End If
            Next
        End If
        For Each element In PanelComando.Controls
            If (element.GetType() = GetType(ControleHardware)) Then
                If (element.engine.HotKey = e.KeyCode.ToString) Then
                    element.BtPressed()
                End If
            End If
        Next
    End Sub

    Private Sub Comando_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        For Each element In PanelComando.Controls
            If (element.GetType() = GetType(ControleHardware)) Then
                If (element.engine.HotKey = e.KeyCode.ToString) Then
                    element.BtReleased()
                End If
            End If
        Next
        keyPressed = Keys.None
    End Sub

    Private Sub PanelComando_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelComando.MouseDown
        For Each control In PanelComando.Controls
            If (control.GetType = GetType(ControleHardware) And keyPressed <> Keys.ControlKey) Then
                selectedControls.Clear()
                'control.BorderStyle = BorderStyle.None
                ToolStripStatusItemSelecionado.Text = "Nenhum"
            End If
        Next
    End Sub

    Public Sub clearUndoBuffer()
        bufferPointer = 0
        infBuffer.Clear()
        refBuffer.Clear()
        checkUndoBuffer()
    End Sub

    Public Sub checkUndoBuffer()
        ToolStripButtonReverter.Enabled = bufferPointer > 0
        ToolStripButtonRefazer.Enabled = (bufferPointer >= 0) And (bufferPointer < infBuffer.Count - 1)
        DesfazerToolStripMenuItem.Enabled = ToolStripButtonReverter.Enabled
        RefazerToolStripMenuItem.Enabled = ToolStripButtonRefazer.Enabled
    End Sub

    Private Sub PanelComando_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelComando.MouseUp
        drawRects()
    End Sub

    Public Sub drawRects()
        Dim dwg As Graphics = PanelComando.CreateGraphics
        dwg.Clear(Color.White)
        If (selectedControls.Count > 0) Then
            Dim pen As New Pen(Color.Black)
            Dim rectDraw As New List(Of Rectangle)
            For Each element In selectedControls
                element.DrawRect()
            Next
        End If
        HabilitaFerramentasOrganizacao()
    End Sub

    Private Sub PropriedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriedadesToolStripMenuItem.Click
        If (selectedControls.Count > 0) Then
            selectedControls(0).PropriedadeToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripButtonAlinharHorizontal_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAlinharHorizontal.Click
        ReferenciaVertical = selectedControls(0).Location.Y
        referenciaHorizontal = Nothing
        alinharComReferencia()
    End Sub

    Private Sub ToolStripVertical_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAlinharVertical.Click
        referenciaHorizontal = selectedControls(0).Location.X
        ReferenciaVertical = Nothing
        alinharComReferencia()
    End Sub

    Private Sub ToolStripButtonTrazerParaFrente_Click(sender As Object, e As EventArgs) Handles ToolStripButtonTrazerParaFrente.Click
        For Each control In selectedControls
            control.BringToFront()
        Next
    End Sub

    Private Sub ToolStripButtonEnviarParaTrás_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEnviarParaTrás.Click
        For Each control In selectedControls
            control.SendToBack()
        Next
    End Sub

    Private Sub ToolStripButtonHorizontal_Click(sender As Object, e As EventArgs) Handles ToolStripButtonTamHorizontal.Click
        Dim ordenedList As New List(Of ControleHardware)
        While selectedControls.Count > 0
            Dim minControl As ControleHardware = selectedControls(0)
            For Each item In selectedControls
                If item.Location.X < minControl.Location.X Then
                    minControl = item
                End If
            Next
            selectedControls.Remove(minControl)
            ordenedList.Add(minControl)
        End While
        selectedControls.AddRange(ordenedList)
        Dim distance As Integer = Math.Abs(selectedControls(0).Location.X + selectedControls(0).Width - selectedControls(1).Location.X)
        Dim newLocation As New Point
        For i = 1 To selectedControls.Count - 1
            MeAtualizaBufferDesfazer(selectedControls(i))
            newLocation = New Point(selectedControls(i - 1).Location.X + selectedControls(i - 1).Width + distance, selectedControls(i).Location.Y)
            selectedControls(i).Location = newLocation
            MeAtualizaBufferDesfazer(selectedControls(i))
        Next
    End Sub

    Private Sub ToolStripButtonVertical_Click(sender As Object, e As EventArgs) Handles ToolStripButtonTamVertical.Click
        Dim ordenedList As New List(Of ControleHardware)
        While selectedControls.Count > 0
            Dim minControl As ControleHardware = selectedControls(0)
            For Each item In selectedControls
                If item.Location.Y < minControl.Location.Y Then
                    minControl = item
                End If
            Next
            selectedControls.Remove(minControl)
            ordenedList.Add(minControl)
        End While
        selectedControls.AddRange(ordenedList)
        Dim distance As Integer = Math.Abs(selectedControls(0).Location.Y + selectedControls(0).Height - selectedControls(1).Location.Y)
        Dim newLocation As New Point
        For i = 1 To selectedControls.Count - 1
            MeAtualizaBufferDesfazer(selectedControls(i))
            newLocation = New Point(selectedControls(i).Location.X, selectedControls(i - 1).Location.Y + selectedControls(i - 1).Height + distance)
            selectedControls(i).Location = newLocation
            MeAtualizaBufferDesfazer(selectedControls(i))
        Next
    End Sub

    Private Sub alinharComReferencia()
        Dim newLocation As New Point
        For Each control In selectedControls
            MeAtualizaBufferDesfazer(control)
            If ((referenciaHorizontal <> Nothing) And (ReferenciaVertical <> Nothing)) Then
                newLocation = New Point(referenciaHorizontal, ReferenciaVertical)
            Else
                If (referenciaHorizontal <> Nothing) Then
                    newLocation = New Point(referenciaHorizontal, control.Location.Y)
                End If
                If (ReferenciaVertical <> Nothing) Then
                    newLocation = New Point(control.Location.X, ReferenciaVertical)
                End If
            End If
            control.Location = newLocation
            MeAtualizaBufferDesfazer(control)
        Next
    End Sub

    Private Sub HabilitaFerramentasOrganizacao()
        ToolStripButtonAlinharHorizontal.Enabled = selectedControls.Count > 1
        ToolStripButtonAlinharVertical.Enabled = selectedControls.Count > 1
        ToolStripButtonTrazerParaFrente.Enabled = selectedControls.Count > 1
        ToolStripButtonEnviarParaTrás.Enabled = selectedControls.Count > 1
        ToolStripButtonTamHorizontal.Enabled = selectedControls.Count > 1
        ToolStripButtonTamVertical.Enabled = selectedControls.Count > 1
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        RecortarToolStripMenuItem.Enabled = apontaControle <> Nothing
        CopiarToolStripMenuItem.Enabled = apontaControle <> Nothing
        ColarToolStripMenuItem1.Enabled = clipBoardControlList.Count > 0
        ExcluirToolStripMenuItem1.Enabled = apontaControle <> Nothing
        PropriedadesToolStripMenuItem.Enabled = apontaControle <> Nothing
    End Sub

    Private Sub PictureBoxShowTools_Click(sender As Object, e As EventArgs)
        TimerAnimação.Enabled = True
    End Sub

    Private Sub Comando_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DruidaSuiteMain.windowsOpened -= 1
        taskButtonRef.Hide()
        taskButtonRef.PictureBoxItem.Image = Nothing
        taskButtonRef.LabelNomeItem.Text = Nothing
        taskButtonRef.SetForm(Nothing)
        taskButtonRef = Nothing
    End Sub

    Private Sub SelecionarPortaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarPortaToolStripMenuItem.Click
        'Conectar.Show()
    End Sub

    Private Sub ConectarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarToolStripMenuItem.Click
        DruidaSuiteMain.PictureBoxConectar_Click(sender, e)
    End Sub

    Private Sub ModoJanelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoJanelaToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Deseja salvar as alterações e iniciar a aplicação no modo teste?", "Iniciar Modo Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SalvarDados()
            TestarApp.Show()
        End If
    End Sub

    Private Sub ModoTelaCheiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoTelaCheiaToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Deseja salvar as alterações e iniciar a aplicação no modo teste?", "Iniciar Modo Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SalvarDados()
            TestarApp.FormBorderStyle = FormBorderStyle.None
            TestarApp.Dock = DockStyle.Fill
            TestarApp.Show()
        End If
    End Sub

    Private Sub GerarAplicaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim dialog As DialogResult = MessageBox.Show("Para conseguir gerar aplicações comerciais, adiquira a versão comercial do programa.", "Adiquirir versão comercial", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dialog = DialogResult.Yes Then
            MessageBox.Show("Versão comercial ainda em desenvolvimento!")
        End If
        ''Dim startPath As String = applicationDirectory & "\Application"
        ''If Not System.IO.Directory.Exists(startPath) Then
        ''    System.IO.Directory.CreateDirectory(startPath)
        ''End If
        ''Dim saveFile As New SaveFileDialog With {
        ''    .Filter = "Aplicação do Windows|*.exe",
        ''    .InitialDirectory = startPath,
        ''    .Title = "Salvar Controle Personalizado"
        ''}
        ''Dim dialogResult = saveFile.ShowDialog()
        ''If dialogResult <> DialogResult.Cancel Then
        ''    Dim path As String = saveFile.FileName.Replace(saveFile.FileName.Split("\")(saveFile.FileName.Split("\").Length - 1), "")
        ''    generateControlsList()
        ''    GenerateApp.SetDestinyPath(path)
        ''    GenerateApp.Show()
        ''End If
        'OptionsGenerateApp.Show()
    End Sub

    Public Sub generateControlsList()
        Dim localControlsList As New List(Of ControleHardware)
        For Each tela In telas
            AbrirTela(tela)
            For Each ctr In PanelComando.Controls
                If ctr.GetType = GetType(ControleHardware) Then
                    localControlsList.Add(ctr)
                End If
            Next
        Next
        GenerateApp.SetControlList(localControlsList)
    End Sub

    Private Sub ToolStripButtonExecutar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonExecutar.Click
        If ToolStripComboBoxModo.SelectedItem = "Janela" Then
            Dim result As DialogResult
            result = MessageBox.Show("Deseja salvar as alterações e iniciar a aplicação no modo teste?", "Iniciar Modo Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SalvarDados()
                TestarApp.Show()
            End If
        End If
        If ToolStripComboBoxModo.SelectedItem = "Tela-Cheia" Then
            Dim result As DialogResult
            result = MessageBox.Show("Deseja salvar as alterações e iniciar a aplicação no modo teste?", "Iniciar Modo Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SalvarDados()
                TestarApp.FormBorderStyle = FormBorderStyle.None
                TestarApp.Dock = DockStyle.Fill
                TestarApp.Show()
            End If
        End If
        If Not DruidaSuiteMain.COMPort.IsOpen Then
            DruidaSuiteMain.PictureBoxConectar_Click(sender, e)
        End If
    End Sub

    Private Sub ToolStripComboBoxModo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxModo.SelectedIndexChanged
        cfgManager.Escrever("Modo", ToolStripComboBoxModo.SelectedItem)
    End Sub

    Private Sub ClonarTelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClonarTelaToolStripMenuItem.Click
        Renomear.Text = "Clonar Tela - Novo Nome"
        If Renomear.ShowDialog() = DialogResult.OK Then
            If (telas.Contains(Renomear.TextBoxNovoNome.Text)) Then
                MessageBox.Show("Essa tela já existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Renomear.Text = "Clonar Tela - Novo Nome"
                Exit Sub
            End If
            System.IO.File.AppendAllText(applicationDirectory & "\Comando\ListaTelas.list", Renomear.TextBoxNovoNome.Text & vbCrLf)
            My.Computer.FileSystem.CopyDirectory(applicationDirectory & "\Comando\" & telas(telaAberta), applicationDirectory & "\Comando\" & Renomear.TextBoxNovoNome.Text)
        End If
        Renomear.Text = "Clonar Tela - Novo Nome"
    End Sub
End Class