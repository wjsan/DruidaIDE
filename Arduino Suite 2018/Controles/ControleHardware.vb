Imports AForge.Video
Imports System.Web
Imports System.Text
Imports Druida_IDE_Lite

Public Class ControleHardware
    Public engine As New EstruturaControleHardware
    Dim getOffSet As Boolean = True
    Dim offSets As New List(Of Point)
    Dim dwg As Graphics = GetLocal.CreateGraphics
    Dim rectDraw As Rectangle
    Dim alarme As Boolean = False
    Dim posY As Integer
    Dim estadoAnterior As Integer = 0
    Dim testeVar As Integer = 0
    Dim mjpeg As MJPEGStream
    Dim textLeitura As String = ""
    Dim textEscrita As String = ""
    Public textAction As String = ""
    Dim alinhamento As String

    Private Function Avancado()
        Return appProgrammingMethod = "Avançado"
    End Function

    Private Sub ControleHardware_Load(sender As Object, e As EventArgs) Handles Me.Load
        'getListaPWMs()
        Me.Anchor = AnchorStyles.None
        If engine.borda <> "" Then
            If IsNumeric(engine.borda) Then
                Me.Anchor = engine.borda
            End If
        End If
        If engine.tipo = "Botão de Comando" Then
            Button1.Dock = DockStyle.Fill
            Me.Controls.Remove(PictureBoxStatus)
            Me.Controls.Remove(Grafico)
            Me.Controls.Remove(VideoSourcePlayer)
        End If
        If engine.tipo = "Rótulo" Then
            LabelRotulo.Dock = DockStyle.Fill
            Me.Controls.Remove(PictureBoxStatus)
            Me.Controls.Remove(Grafico)
            Me.Controls.Remove(VideoSourcePlayer)
        End If
        If engine.tipo = "TextBox" Then
            engine.tipo = "Saída Registrador-32Bits"
            LabelValor.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom
            TextBoxValor.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
            Me.Controls.Remove(PictureBoxStatus)
            Me.Controls.Remove(Grafico)
            Me.Controls.Remove(VideoSourcePlayer)
        End If
        If (engine.tipo = "Câmera IP") Then
            Me.Controls.Remove(PictureBoxStatus)
            Me.Controls.Remove(Grafico)
            mjpeg = New MJPEGStream(engine.imagens(0))
            mjpeg.Login = engine.imagens(1)
            mjpeg.Password = engine.imagens(2)
            VideoSourcePlayer.VideoSource = mjpeg
            VideoSourcePlayer.Start()
        End If
        If (engine.tipo = "Gráfico") Then
            Me.Controls.Remove(PictureBoxStatus)
            Me.Controls.Remove(VideoSourcePlayer)
            Grafico.ChartGrafico.Series(0).Name = " 1- " & engine.rotuloText
            Grafico.ChartGrafico.Series(1).Name = " 2- " & engine.hotKey
            Grafico.ChartGrafico.Series(2).Name = " 3- " & engine.joyKey
            Grafico.maximumPoint = engine.scaleMax
            Grafico.minimumPoint = engine.scaleMin
        End If
        If (engine.tipo <> "Gráfico" And engine.tipo <> "Câmera IP") Then
            Me.Controls.Remove(VideoSourcePlayer)
            Me.Controls.Remove(Grafico)
        End If
        If (engine.tipo = "Imagem") Then
            'PictureBoxStatus.Visible = False
            BorderStyle = BorderStyle.None
            'BackColor = Color.White
            BackColor = Color.Transparent
            PictureBoxStatus.BackColor = Color.Transparent
            PictureBoxStatus.Dock = DockStyle.Fill
            'Static Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
            'Me.BackgroundImage = Image.FromFile(path & engine.imagens(0))
        End If
        posY = BarraGrafica.Location.Y + engine.barGraphMaxSize.Height
        ToolStripTextBoxTamX.Text = Width
        ToolStripTextBoxTamY.Text = Height
        ToolStripTextBoxPosX.Text = Location.X
        ToolStripTextBoxPosY.Text = Location.Y
        TimerAtualizaStatus.Enabled = True
        Dim offSetMouse As Point
        If Avancado() Then
            offSetMouse = New Point(ComandoAvancado.SplitContainer1.Panel2.Location.X + ComandoAvancado.Parent.Location.X, ComandoAvancado.SplitContainer1.Location.Y + ComandoAvancado.Parent.Location.Y)
        Else
            offSetMouse = New Point(Comando.SplitContainer1.Panel2.Location.X, Comando.SplitContainer1.Location.Y)
        End If
        If (engine.startPath) Then
            Me.engine.local = MousePosition - offSetMouse - New Point(Height / 2, Width / 2)
        End If
        GetToolTip()
    End Sub

    Public Sub GetToolTip()
        If engine.porta(0) <> "" And appProgrammingMethod = "Avançado" Then
            Dim name As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            name = HttpUtility.UrlEncode(name, Encoding.GetEncoding(28597)).Replace("+", " ")
            Dim Reg As Int16 = engine.porta(0)
            Dim bit As Int16 = 0

            If engine.porta(1) <> "" Then bit = engine.porta(1)

            If engine.tipVisivel Then
                If engine.tipo = "Registrador <Bit>" Then
                    ToolTipInfoPorta.ToolTipIcon = ToolTipIcon.Info
                    ToolTipInfoPorta.ToolTipTitle = "Para acessar esse controle na programação no Druida IDE:"
                    textLeitura = "bool " & name & " = Druida.getRegBit(" & Reg & "," & bit & ");" & vbLf
                    textEscrita &= "Druida.setRegBit(" & Reg & "," & bit & "," & "valor);"
                    ToolTipInfoPorta.SetToolTip(LabelRotulo, "Leitura: " & textLeitura & "Escrita " & textEscrita)
                    ToolTipInfoPorta.SetToolTip(PictureBoxStatus, "Leitura: " & textLeitura & "Escrita: " & textEscrita)
                    ToolTipInfoPorta.SetToolTip(Me, "Leitura: " & textLeitura & "Escrita " & textEscrita)
                End If
            End If

            If engine.tipVisivel Then
                If engine.tipo = "Entrada Registrador-32Bits" Or engine.tipo = "Gráfico" Then
                    ToolTipInfoPorta.ToolTipIcon = ToolTipIcon.Info
                    ToolTipInfoPorta.ToolTipTitle = "Para acessar esse controle na programação no Druida IDE:"
                    textEscrita = "Druida.setReg(" & Reg & ", valor " & ");" & vbLf
                    ToolTipInfoPorta.SetToolTip(LabelRotulo, "Escrita: " & textEscrita)
                    ToolTipInfoPorta.SetToolTip(PictureBoxStatus, "Escrita: " & textEscrita)
                    ToolTipInfoPorta.SetToolTip(Me, "Escrita: " & textEscrita)
                End If
            End If
            If engine.tipVisivel Then
                If engine.tipo = "Saída Registrador-32Bits" Then
                    ToolTipInfoPorta.ToolTipIcon = ToolTipIcon.Info
                    ToolTipInfoPorta.ToolTipTitle = "Para acessar esse controle na programação no Druida IDE:"
                    textLeitura = "long " & name & " = Druida.getReg(" & Reg & ");" & vbLf
                    textEscrita = "Druida.setReg(" & Reg & ", valor);" & vbTab
                    ToolTipInfoPorta.SetToolTip(LabelRotulo, "Leitura: " & textLeitura & "Escrita " & textEscrita)
                    ToolTipInfoPorta.SetToolTip(PictureBoxStatus, "Leitura: " & textLeitura & "Escrita: " & textEscrita)
                    ToolTipInfoPorta.SetToolTip(Me, "Leitura: " & textLeitura & "Escrita " & textEscrita)
                End If
            End If
        End If

    End Sub

    Private Sub LabelRotulo_MouseMove(sender As Object, e As EventArgs) Handles Me.MouseMove, LabelRotulo.MouseMove, Button1.MouseMove, PictureBoxStatus.MouseMove, LabelValor.MouseMove
        'posY = BarraGrafica.Location.Y
        Dim offSetMouse As Point
        If Avancado() Then
            offSetMouse = New Point(ComandoAvancado.SplitContainer1.Panel2.Location.X + ComandoAvancado.Parent.Location.X, ComandoAvancado.SplitContainer1.Location.Y + ComandoAvancado.Parent.Location.Y)
        Else
            offSetMouse = New Point(Comando.SplitContainer1.Panel2.Location.X, Comando.SplitContainer1.Location.Y)
        End If
        If (selectedControls.Count <= 1) Then
            engine.Move(Me, e, ContextMenuStripControl)
            engine.pictureSize = PictureBoxStatus.Size
        ElseIf (userIsAdmin) Then
            Try
                Dim mouse As MouseEventArgs = e
                If (mouse.Button = MouseButtons.Left) Then
                    dwg.Clear(GetLocal.BackColor)
                    If (getOffSet) Then
                        For Each control In selectedControls
                            control.AtualizaBufferDesfazer("move/resize")
                            control.AtualizaBufferDesfazer("move/resize")
                        Next
                    End If
                    If getOffSet Then
                        getOffSet = False
                        For Each control In selectedControls
                            offSets.Add(control.Location - MousePosition + offSetMouse)
                        Next
                    End If
                    For Each element As ControleHardware In selectedControls
                        If element.engine.canMove Then
                            element.Location = offSets(selectedControls.IndexOf(element)) + MousePosition - offSetMouse
                            element.engine.salvaPosicao(element)
                        End If
                    Next
                Else
                    If Not (getOffSet) Then
                        bufferPointer = bufferPointer - (selectedControls.Count) * 2
                        For Each control In selectedControls
                            bufferPointer += 1
                            Dim infMe As New controlInf
                            infMe.location = control.Location
                            infMe.size = control.Size
                            infBuffer(bufferPointer) = infMe
                            refBuffer(bufferPointer) = control
                            bufferPointer += 1
                        Next
                    End If
                    offSets.Clear()
                    getOffSet = True
                End If
            Catch ex As Exception
                showError("Erro ao mover objetos: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TrackBarSaidaAnalogica_MouseMove(sender As Object, e As EventArgs) Handles TrackBarSaidaAnalogica.MouseMove
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(TrackBarSaidaAnalogica, e, CriarControleHardware)
            engine.trackBarLocation = TrackBarSaidaAnalogica.Location
        End If
    End Sub

    Private Sub PictureBoxStatus_MouseMove(sender As Object, e As EventArgs) Handles PictureBoxStatus.MouseMove
        Dim offSetMouse As Point
        If Avancado() Then
            offSetMouse = New Point(ComandoAvancado.SplitContainer1.Panel2.Location.X + ComandoAvancado.Parent.Location.X, ComandoAvancado.SplitContainer1.Location.Y + ComandoAvancado.Parent.Location.Y)
        Else
            offSetMouse = New Point(Comando.SplitContainer1.Panel2.Location.X, Comando.SplitContainer1.Location.Y)
        End If
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(PictureBoxStatus, e, CriarControleHardware)
            engine.pictureLocation = PictureBoxStatus.Location
            engine.pictureSize = PictureBoxStatus.Size
        End If
        If (engine.startPath) Then
            Me.Location = MousePosition - offSetMouse - New Point(Height / 2, Width / 2)
        End If
    End Sub

    Private Sub BarraGrafica_MouseMove(sender As Object, e As EventArgs) Handles BarraGrafica.MouseMove
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(BarraGrafica, e, CriarControleHardware)
            engine.barGraphLocation = BarraGrafica.Location
            engine.barGraphMaxSize = BarraGrafica.Size
        End If
    End Sub

    Private Sub LabelValor_MouseMove(sender As Object, e As EventArgs) Handles LabelValor.MouseMove
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(LabelValor, e, CriarControleHardware)
            engine.analogValorLocation = LabelValor.Location
        End If
    End Sub

    Private Sub TextBoxValor_MouseMove(sender As Object, e As EventArgs) Handles TextBoxValor.MouseMove
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(TextBoxValor, e, CriarControleHardware)
            engine.textValorLocation = TextBoxValor.Location
        End If
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As EventArgs) Handles Button1.MouseMove
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(Button1, e, CriarControleHardware)
            engine.button1Location = Button1.Location
            engine.button1Size = Button1.Size
        End If
    End Sub

    Private Sub Button2_MouseMove(sender As Object, e As EventArgs) Handles Button2.MouseMove
        If (engine.editMode) Then
            OBJ_Resize.ResizeOBJ(Button2, e, CriarControleHardware)
            engine.button2Location = Button2.Location
            engine.button2Size = Button2.Size
        End If
    End Sub

    'Botão deletar toolStripMenu
    Private Sub DeletarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletarToolStripMenuItem.Click
        'Me.BorderStyle = BorderStyle.None
        Me.AtualizaBufferDesfazer("move/resize")
        Me.Visible = False
        Me.AtualizaBufferDesfazer("move/resize")
        For Each control As ControleHardware In selectedControls
            control.AtualizaBufferDesfazer("move/resize")
            control.Visible = False
            control.AtualizaBufferDesfazer("move/resize")
        Next
    End Sub
    'Botão propriedades
    Public Sub PropriedadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriedadesToolStripMenuItem.Click
        BarraGrafica.Size = engine.barGraphMaxSize
        engine.salvaPosicao(Me)
        engine.salvaGraficos(Me)
        If (engine.tipo = "Entrada Digital") Then
            Adicionar_Entrada.Text = "Propriedades"
            Adicionar_Entrada.ref = Me
            Adicionar_Entrada.ShowDialog()
        End If
        If (engine.tipo = "Saída Digital") Then
            Adicionar_Saída.Text = "Propriedades"
            Adicionar_Saída.ref = Me
            Adicionar_Saída.ShowDialog()
        End If
        If (engine.tipo = "Entrada Analógica") Then
            'getListaEntradasAnalogicas()
            Adicionar_Entrada_Analógica.Text = "Propriedades"
            Adicionar_Entrada_Analógica.ref = Me
            Adicionar_Entrada_Analógica.ShowDialog()
        End If
        If (engine.tipo = "Saída Analógica") Then
            Adicionar_Saída_Analógica.Text = "Propriedades"
            Adicionar_Saída_Analógica.ref = Me
            Adicionar_Saída_Analógica.ShowDialog()
        End If
        If (engine.tipo = "Câmera IP") Then
            VideoSourcePlayer.Stop()
            AddCameraIP.Text = "Propriedades"
            AddCameraIP.ref = Me
            AddCameraIP.ShowDialog()
            AddCameraIP.VideoSourcePlayer1.Start()
        End If
        If (engine.tipo = "Gráfico") Then
            AddGráfico.Text = "Propriedades"
            AddGráfico.ref = Me
            AddGráfico.ShowDialog()
        End If
        If (engine.tipo = "Imagem") Then
            AddImagem.Text = "Propriedades"
            AddImagem.ref = Me
            AddImagem.ShowDialog()
        End If
        If (engine.tipo = "Registrador <Bit>") Then
            AddRegBit.Text = "Propriedades"
            AddRegBit.ref = Me
            AddRegBit.ShowDialog()
        End If
        If (engine.tipo = "Entrada Registrador-32Bits") Then
            AddEntrada32Bits.Text = "Propriedades"
            AddEntrada32Bits.ref = Me
            AddEntrada32Bits.ShowDialog()
        End If
        If (engine.tipo = "Saída Registrador-32Bits") Then
            AddSaída32Bits.Text = "Propriedades"
            AddSaída32Bits.ref = Me
            AddSaída32Bits.ShowDialog()
        End If
        If engine.tipo = "Botão de Comando" Then
            BotaoAcao.Text = "Propriedades"
            BotaoAcao.ref = Me
            BotaoAcao.ShowDialog()
        End If
        If engine.tipo = "Rótulo" Then
            Rotulo.Text = "Propriedades"
            Rotulo.ref = Me
            Rotulo.ShowDialog()
        End If
        engine.updateControl(Me)
        GetToolTip()
    End Sub
    'Ajuste de tamanho Pos x
    Private Sub ToolStripTextBoxTamX_KeyUp(sender As Object, e As EventArgs) Handles ToolStripTextBoxTamX.KeyUp
        engine.AjustaTamX(Me, ToolStripTextBoxTamX.Text)
    End Sub
    'Ajuste de Tam Posicao y
    Private Sub ToolStripTextBoxTamY_KeyUp(sender As Object, e As EventArgs) Handles ToolStripTextBoxTamY.KeyUp
        engine.AjustaTamY(Me, ToolStripTextBoxTamY.Text)
    End Sub
    'Ajuste de posição pos x
    Private Sub ToolStripTextBoxPosX_KeyUp(sender As Object, e As EventArgs) Handles ToolStripTextBoxPosX.KeyUp
        engine.AjustaPosX(Me, ToolStripTextBoxPosX.Text)
    End Sub
    'Ajuste de posição pos y
    Private Sub ToolStripTextBoxPosY_KeyUp(sender As Object, e As EventArgs) Handles ToolStripTextBoxPosY.KeyUp
        engine.AjustaPosY(Me, ToolStripTextBoxPosY.Text)
    End Sub
    'Botão Copiar Tamanho
    Private Sub CopiarTamanhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarTamanhoToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(Size.ToString)
    End Sub
    'Botão Colar Tamanho
    Private Sub ColarTamanhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarTamanhoToolStripMenuItem.Click
        Try
            Size = engine.ConvertStringToSize(My.Computer.Clipboard.GetText)
        Catch ex As Exception
            MessageBox.Show("A informação não está no formato correto", "Erro", MessageBoxButtons.OK)
        End Try
        engine.salvaPosicao(Me)
    End Sub
    'Habilita/Desabilita Colar posição
    Private Sub EditarPosiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarPosiçãoToolStripMenuItem.MouseEnter
        ColarTamanhoToolStripMenuItem.Enabled = My.Computer.Clipboard.ContainsText
    End Sub
    'Botão copiar
    Public Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        'Dim copyHardware As New ControleHardware
        'copyHardware.engine.updateDataFromControl(Me)
        'copyHardware.engine.updateControl(copyHardware)
        'clipBoardControl = copyHardware
        clipBoardControlList.Clear()
        If selectedControls.Count = 0 Then
            clipBoardControlList.Add(Me)
            Exit Sub
        End If
        For Each item As ControleHardware In selectedControls
            Dim newcopyHardware As New ControleHardware
            newcopyHardware.engine.UpdateDataFromControlData(item.engine)
            newcopyHardware.engine.updateControl(newcopyHardware)
            clipBoardControlList.Add(newcopyHardware)
        Next
    End Sub
    'Botão Recortar
    Public Sub ToolStripRecortar_Click(sender As Object, e As EventArgs) Handles RecortarToolStripMenuItem1.Click
        AtualizaBufferDesfazer("move/resize")
        Dim cutHardware As New ControleHardware
        cutHardware.engine.updateDataFromControl(Me)
        cutHardware.engine.updateControl(cutHardware)
        clipBoardControl = cutHardware
        Me.Visible = False
        AtualizaBufferDesfazer("move/resize")
    End Sub
    'Botão Trazer para Frente
    Private Sub TrazerParaFrenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrazerParaFrenteToolStripMenuItem.Click
        Me.BringToFront()
    End Sub
    'Botão Enviar para Tras
    Private Sub EnviarParaTrásToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarParaTrásToolStripMenuItem.Click
        Me.SendToBack()
    End Sub
    'Botão Bloquear/Desloquear controle
    Private Sub BloquearControleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloquearControleToolStripMenuItem.Click
        engine.bloquearControle(BloquearControleToolStripMenuItem)
        For Each controle As ControleHardware In selectedControls
            controle.engine.bloquearControle(controle.BloquearControleToolStripMenuItem)
        Next
    End Sub
    'Atualiza Itens do Menu
    Private Sub ContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripControl.Opening
        Dim img As Image = My.Resources.Enabled
        alinhamento = Convert.ToString(Me.Anchor, 2).PadLeft(4, "0")
        If alinhamento = "0000" Then
            AlinharAoCentroToolStripMenuItem.Image = img
        Else
            AlinharAoCentroToolStripMenuItem.Image = Nothing
        End If
        checarAlinhamento()
        If (Not (engine.canMove)) Then
            BloquearControleToolStripMenuItem.Text = "Desbloquear Controle"
            BloquearControleToolStripMenuItem.Image = ArduinoSuite.My.Resources.Resources.lock_flat
        Else
            BloquearControleToolStripMenuItem.Text = "Bloquear Controle"
            BloquearControleToolStripMenuItem.Image = ArduinoSuite.My.Resources.Resources.unlock_553_847794
        End If
        DatabaseToolStripMenuItem.Visible = appProgrammingMethod = "Avançado"
        GatilhoToolStripMenuItem.Visible = appProgrammingMethod = "Avançado"
        ProgramaçãoArduinoToolStripMenuItem.Visible = appProgrammingMethod = "Avançado"
    End Sub
    'Atualiza ponteiro do mouse
    Private Sub Entrada_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, PictureBoxStatus.MouseEnter, LabelRotulo.MouseEnter, Button1.MouseEnter
        If Not (engine.editMode) Then
            For Each control In GetLocal.Controls
                If (control.GetType = GetType(ControleHardware) And (Not (keyPressed = Keys.ControlKey)) And selectedControls.Count = 1) Then
                    selectedControls.Clear()
                    ClearRect()
                    'control.BorderStyle = BorderStyle.None
                    If Avancado() Then
                        ComandoAvancado.ToolStripStatusItemSelecionado.Text = "Nenhum"
                    Else
                        Comando.ToolStripStatusItemSelecionado.Text = "Nenhum"
                    End If
                End If
            Next
            If (Not (engine.canMove)) Then
                Me.Cursor = Cursors.No
            Else
                If (Not (selectedControls.Contains(Me)) And Not (keyPressed = Keys.ControlKey) And selectedControls.Count <= 1) Then
                    selectedControls.Add(Me)
                    If Avancado() Then
                        ComandoAvancado.drawRects()
                    Else
                        Comando.drawRects()
                    End If
                    If Avancado() Then
                        ComandoAvancado.ToolStripStatusItemSelecionado.Text = selectedControls.Count
                    Else
                        Comando.ToolStripStatusItemSelecionado.Text = selectedControls.Count
                    End If
                    'Me.BorderStyle = BorderStyle.Fixed3D
                    Me.Cursor = Cursors.Default
                End If
            End If
            apontaControle = GetLocal.Controls.IndexOf(Me)
        End If
    End Sub

    Private Sub Entrada_MouseClick(sender As Object, e As EventArgs) Handles Me.MouseClick, PictureBoxStatus.MouseClick, LabelRotulo.MouseClick
        If (Not (engine.canMove)) Then
            Me.Cursor = Cursors.No
        Else
            If (Not (selectedControls.Contains(Me)) And (keyPressed = Keys.ControlKey) And Not (engine.editMode)) Then
                selectedControls.Add(Me)
                If Avancado() Then
                    ComandoAvancado.ToolStripStatusItemSelecionado.Text = selectedControls.Count
                Else
                    Comando.ToolStripStatusItemSelecionado.Text = selectedControls.Count
                End If
                'Me.BorderStyle = BorderStyle.Fixed3D
                Me.Cursor = Cursors.Default
            End If
        End If
        If (Not (engine.editMode)) Then
            apontaControle = GetLocal.Controls.IndexOf(Me)
        End If
        If (engine.startPath) Then
            engine.startPath = False
        End If
    End Sub

    Private Sub Entrada_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, PictureBoxStatus.MouseLeave, LabelRotulo.MouseLeave, Button1.MouseLeave
        If (selectedControls.Count = 1 And Not (keyPressed = Keys.ControlKey) And Not (engine.editMode)) Then
            selectedControls.Clear()
            'ClearRect()
            'BorderStyle = BorderStyle.None
            If Avancado() Then
                ComandoAvancado.ToolStripStatusItemSelecionado.Text = "Nenhum"
            Else
                Comando.ToolStripStatusItemSelecionado.Text = "Nenhum"
            End If
        End If
        engine.salvaPosicao(Me)
    End Sub

    Public Sub SaveMe()
        engine.saveData(pathTela & "\Componentes.inf")
    End Sub

    Private Sub Me_MouseInteract(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, LabelRotulo.MouseDown, Me.MouseUp, LabelRotulo.MouseUp, PictureBoxStatus.MouseDown, PictureBoxStatus.MouseUp, Button1.MouseDown, Button2.MouseUp, LabelValor.MouseDown, LabelValor.MouseUp
        If (selectedControls.Count <= 1) Then
            AtualizaBufferDesfazer("move/resize")
        End If
        dwg.Clear(GetLocal.BackColor)
        For Each element In selectedControls
            element.DrawRect()
        Next
    End Sub


    Public Sub AtualizaBufferDesfazer(action As String)
        Dim infMe As New controlInf
        Dim refazer As Boolean = False
        If Avancado() Then
            refazer = ComandoAvancado.ToolStripButtonRefazer.Enabled
        Else
            refazer = Comando.ToolStripButtonRefazer.Enabled
        End If
        If (refazer) Then
            If Avancado() Then
                ComandoAvancado.ToolStripButtonRefazer.Enabled = False
            Else
                Comando.ToolStripButtonRefazer.Enabled = False
            End If
            infBuffer.Clear()
            refBuffer.Clear()
            bufferPointer = 0
        End If
        infMe.location = Me.Location
        infMe.size = Me.Size
        infMe.visible = Me.Visible
        infMe.action = action
        For Each control In GetLocal.Controls
            If (control.Equals(Me)) Then
                refBuffer.Add(Me)
            End If
        Next
        infBuffer.Add(infMe)
        bufferPointer += 1
        If Avancado() Then
            ComandoAvancado.ToolStripButtonReverter.Enabled = bufferPointer > 0
            ComandoAvancado.DesfazerToolStripMenuItem.Enabled = ComandoAvancado.ToolStripButtonReverter.Enabled
            ComandoAvancado.RefazerToolStripMenuItem.Enabled = ComandoAvancado.ToolStripButtonRefazer.Enabled
            ComandoAvancado.ToolStripStatusLabel4.Text = refBuffer.Count
        Else
            Comando.ToolStripButtonReverter.Enabled = bufferPointer > 0
            Comando.DesfazerToolStripMenuItem.Enabled = Comando.ToolStripButtonReverter.Enabled
            Comando.RefazerToolStripMenuItem.Enabled = Comando.ToolStripButtonRefazer.Enabled
            Comando.ToolStripStatusLabel4.Text = refBuffer.Count
        End If
    End Sub

    Public Sub DrawRect()
        Dim pen As New Pen(Brushes.Black)
        rectDraw = New Rectangle(Me.Location - New Point(3, 3), Me.Size + New Size(3, 3))
        pen.DashStyle = Drawing2D.DashStyle.Dot
        dwg.DrawRectangle(pen, rectDraw)
    End Sub

    Public Sub ClearRect()
        dwg.Clear(Color.Transparent)
    End Sub

    Private Sub TimerAtualizaStatus_Tick(sender As Object, e As EventArgs) Handles TimerAtualizaStatus.Tick
        If DruidaSuiteMain.TimerLeituraRede.Enabled And Application.OpenForms.OfType(Of TestarApp).Count = 0 Then
            TimerAtualizaStatus.Interval = DruidaSuiteMain.TimerLeituraRede.Interval
            controlScan()
        End If
    End Sub

    Private Sub controlScan()
        'ArduinoSuiteMain.TimerLeituraRede.Enabled And 
        If (Me.Visible And engine.porta(0) <> Nothing And Not (alarme)) Then
            If engine.gatilho.Contains(",") Then
                If engine.gatilho.Split(",").Count >= 3 Then
                    Try
                        Dim dadosGatilho() As String = engine.gatilho.Split(",")
                        Dim regGatilho = dadosGatilho(0)
                        Dim condicao = dadosGatilho(1)
                        Dim valor = dadosGatilho(2)
                        If Not TestaCondicao(condicao, regGatilho, valor) Then
                            Exit Sub
                        End If
                    Catch ex As Exception

                    End Try
                End If
            End If
            If (engine.tipo = "Entrada Digital" Or engine.tipo = "Saída Digital") Then
                leituraEntrada()
            End If
            If (engine.tipo = "Entrada Analógica" Or engine.tipo = "Gráfico" Or engine.tipo = "Entrada Registrador-32Bits" And engine.porta(0) <> Nothing) Then
                leituraAnalogica()
            End If
            If (engine.tipo = "Saída Analógica" Or engine.tipo = "Saída Registrador-32Bits" And engine.porta(0) <> Nothing) Then
                If (engine.tipo = "Saída Analógica") Then
                    Dim pos = listaPWMs.IndexOf(CInt(engine.porta(0)))
                    TextBoxValor.Text = pwm(pos)
                Else
                    If TrackBarSaidaAnalogica.Visible Then
                        AcionaSaidaAnalogica(engine.porta(0), TrackBarSaidaAnalogica.Value)
                        'TextBoxValor.Text = TrackBarSaidaAnalogica.Value
                    Else
                        If dados IsNot Nothing And dadosAnteriores IsNot Nothing Then
                            If TextBoxValor.Text <> dadosAnteriores(engine.porta(0)) Then
                                AcionaSaidaAnalogica(engine.porta(0), TextBoxValor.Text)
                            Else
                                If dadosAnteriores(engine.porta(0)) <> dados(engine.porta(0)) Then
                                    TextBoxValor.Text = dados(engine.porta(0))
                                End If
                            End If
                        End If
                    End If
                End If
                If (engine.joyKey <> "" And joyPadOn) Then
                    leituraInstrucoes()
                End If
            End If
            If (engine.tipo = "Registrador <Bit>") Then
                leituraRegBit()
            End If
        End If
    End Sub

    Private Function TestaCondicao(condicao As String, reg As String, valor As String)
        If condicao = "igual a" Then
            Return (dados(reg) = valor)
        ElseIf condicao = "diferente de" Then
            Return (dados(reg) <> valor)
        ElseIf condicao = "maior que" Then
            Return (dados(reg) > valor)
        ElseIf condicao = "menor que" Then
            Return (dados(reg) < valor)
        Else
            Return True
        End If
    End Function

    Private Sub leituraEntrada()
        Static Dim erro
        Static Dim imageFile As String = engine.imagens(0)
        Static Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
        If (estados <> "") Then
            Try
                If (estados(engine.porta(0) - 2) = "1" And imageFile <> engine.imagens(1)) Then
                    imageFile = engine.imagens(1)
                    PictureBoxStatus.Image = Image.FromFile(path & engine.imagens(1))
                End If
                If (estados(engine.porta(0) - 2) = "0" And imageFile <> engine.imagens(0)) Then
                    imageFile = engine.imagens(0)
                    PictureBoxStatus.Image = Image.FromFile(path & engine.imagens(0))
                End If
            Catch ex As Exception
                erro = erro + 1
            End Try
            If (erro > 5) Then
                DruidaSuiteMain.StopRede()
                showError("Erro de leitura elemento de rotulo = " & LabelRotulo.Text)
            End If
        End If
    End Sub

    Private Sub showError(texto)
        If appProgrammingMethod = "Avançado" Then
            DruidaInterface.AddErrorMsg(texto, Druida_IDE_Lite.ErrorsManager.Type.msgError)
        Else
            MessageBox.Show(texto, "Erro")
        End If
    End Sub

    Private Sub leituraRegBit()
        Static Dim erro
        Static Dim imageFile As String = engine.imagens(0)
        Static Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
        If (dados IsNot Nothing) Then
            If dados.Count < engine.porta(0) + 1 Then Exit Sub
            If Not IsNumeric(dados(engine.porta(0))) Then
                Exit Sub
            End If
            If (getBit(engine.porta(0), engine.porta(1)) And imageFile <> engine.imagens(1)) Then
                imageFile = engine.imagens(1)
                'PictureBoxStatus.Image.Dispose()
                PictureBoxStatus.Image = Image.FromFile(path & engine.imagens(1))
            End If
            If (Not (getBit(engine.porta(0), engine.porta(1))) And imageFile <> engine.imagens(0)) Then
                imageFile = engine.imagens(0)
                'PictureBoxStatus.Image.Dispose()
                PictureBoxStatus.Image = Image.FromFile(path & engine.imagens(0))
            End If
            'Catch ex As Exception
            erro = erro + 1
            'End Try
            'If (erro > 5) Then
            'ArduinoSuiteMain.StopRede
            'MessageBox.Show("Erro de leitura elemento de rotulo = " & LabelRotulo.Text, "Erro")
            'End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (DruidaSuiteMain.COMPort.IsOpen And engine.porta(0) <> Nothing) Then
            If appProgrammingMethod <> "Avançado" Then
                AcionaSaida(engine.porta(0), 1)
            Else
                acionaReg(engine.porta(0), engine.porta(1), 1)
            End If
        End If
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        If (DruidaSuiteMain.COMPort.IsOpen And engine.porta(0) <> Nothing) Then
            If appProgrammingMethod <> "Avançado" Then
                If estados(engine.porta(0) - 2) = "0" Then
                    'AcionaSaida(engine.porta(0), 1)
                Else
                    AcionaSaida(engine.porta(0), 0)
                End If
            Else
                acionaReg(engine.porta(0), engine.porta(1), 0)
            End If
        End If
    End Sub

    Private Sub PictureBoxStatus_MouseDown(sender As Object, e As EventArgs) Handles PictureBoxStatus.MouseDown
        BtPressed()
    End Sub

    Public Sub KeyIsPressed()
        If dados Is Nothing Then Exit Sub
        If (engine.buttonMode <> "pls") Then
            reverseReg(engine.porta(0), engine.porta(1))
        Else
            acionaReg(engine.porta(0), engine.porta(1), 1)
        End If
    End Sub

    Public Sub KeyIsReleased()
        If dados Is Nothing Then Exit Sub
        If (engine.buttonMode = "pls") Then
            acionaReg(engine.porta(0), engine.porta(1), 0)
        End If
    End Sub

    Public Sub BtPressed()
        If (DruidaSuiteMain.COMPort.IsOpen And engine.porta(0) <> Nothing) Then
            If (engine.tipo = "Saída Digital") Then
                If (engine.buttonMode <> "pls") Then
                    If estados(engine.porta(0) - 2) = "0" Then
                        AcionaSaida(engine.porta(0), 1)
                    Else
                        AcionaSaida(engine.porta(0), 0)
                    End If
                Else
                    If estados(engine.porta(0) - 2) = "0" Then
                        AcionaSaida(engine.porta(0), 1)
                    End If
                End If
            End If
            If (engine.tipo = "Registrador <Bit>") Then
                If (engine.buttonMode <> "pls") Then
                    reverseReg(engine.porta(0), engine.porta(1))
                Else
                    If (getBit(engine.porta(0), engine.porta(1))) Then
                        acionaReg(engine.porta(0), engine.porta(1), 0)
                    Else
                        acionaReg(engine.porta(0), engine.porta(1), 1)
                    End If
                End If
                '    If (getBit(engine.porta(0), engine.porta(1))) Then
                '        AcionaReg(engine.porta(0), engine.porta(1), 0)
                '    Else
                '        AcionaReg(engine.porta(0), engine.porta(1), 1)
                '    End If
                'Else
                '    AcionaReg(engine.porta(0), engine.porta(1), 1)
                'End If
            End If
        End If
    End Sub

    Private Sub PictureBoxStatus_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxStatus.MouseUp
        BtReleased()
    End Sub

    Public Sub BtReleased()
        If (DruidaSuiteMain.COMPort.IsOpen And engine.porta(0) <> Nothing) Then
            If (engine.tipo = "Saída Digital") Then
                If (engine.buttonMode = "pls") Then
                    'If estados(engine.porta(0) - 2) <> "0" Then
                    AcionaSaida(engine.porta(0), 0)
                    'End If
                End If
            End If
            If (engine.tipo = "Registrador <Bit>") Then
                If (engine.buttonMode = "pls") Then
                    acionaReg(engine.porta(0), engine.porta(1), 0)
                End If
            End If
        End If
    End Sub

    'Public Sub srBit(ByVal regPos As Byte, ByVal bit As Byte, ByVal estado As Boolean)
    '    Dim val As Int32 = dados(regPos)
    '    Dim newVal As String = Convert.ToString(val, 2).PadLeft(32, "0"c) '32 bits
    '    newVal = StrReverse(newVal)
    '    Dim bits(31) As Boolean
    '    For i As Byte = 0 To 31
    '        bits(i) = newVal(i) = "1"
    '    Next
    '    'If (bits(bit) <> estado) Then
    '    bits(bit) = estado
    '    dados(regPos) = toInt32(bits)
    '    escreveRegs()
    '    'End If
    'End Sub

    Public Sub escreveRegs()
        Dim palavra As String = ""
        For Each reg In dados
            If (reg <> "_" & vbCr) Then
                palavra += reg & "."
            End If
        Next
        palavra += "_"
        If (dadoRecebido = True) Then
            dadoRecebido = False
            Dim lixo As String = DruidaSuiteMain.COMPort.ReadLine
            monitorSerialWrite(palavra & "r")
        Else
            monitorSerialWrite(palavra)
        End If
    End Sub

    Public Sub AcionaSaida(porta As Byte, estado As Byte)
        monitorSerialWrite("4.0.0.0.0.0.0." & porta & "." & estado & ".1_")
        'ArduinoSuiteMain.COMPort.Write("4.0.0.0.0.0.0." & porta & "." & estado & ".1_")
    End Sub

    Public Sub acionaReg(reg As Byte, bit As Byte, estado As Byte)
        'monitorSerialWrite("4.0.0.0.0.0." & engine.porta(0) & "." & engine.porta(1) & "." & estado & ".1_")
        'monitorSerialWrite("0.0.0.0.0.0.0.0.0.0_")
        If estado = 1 Then
            dados(reg) = dados(reg) Or 2 ^ (bit)
        Else
            dados(reg) = dados(reg) Or 2 ^ (bit)
            dados(reg) = dados(reg) Xor 2 ^ (bit)
        End If
        'comunica()
        descartaDados = reg
    End Sub

    Public Sub reverseReg(reg As Byte, bit As Byte)
        If dados Is Nothing Then Exit Sub
        dados(reg) = dados(reg) Xor 2 ^ (bit)
        'comunica()
        descartaDados = reg
    End Sub

    Public Sub ScaleBargraph(input As UInt16)
        Dim valor As Double
        If (appProgrammingMethod <> "Avançado") Then
            If (engine.barGraphOrientation = "Horizontal") Then
                valor = input * (engine.barGraphMaxSize.Width / 1023)
                BarraGrafica.Width = valor
            End If
            If (engine.barGraphOrientation = "Vertical") Then
                valor = input * (engine.barGraphMaxSize.Height / 1023)
                BarraGrafica.Height = valor
                Dim ponto As New Point(BarraGrafica.Location.X, (posY) - valor)
                BarraGrafica.Location = ponto
            End If
            valor = GetScaleValue(input)
            TextBoxValor.Text = valor & engine.unit
            If (engine.tipo = "Gráfico") Then
                atualizaGrafico()
            End If
        Else
            If (engine.barGraphOrientation = "Horizontal") Then
                valor = input * (engine.barGraphMaxSize.Width / engine.scaleMax)
                BarraGrafica.Width = valor
            End If
            If (engine.barGraphOrientation = "Vertical") Then
                valor = input * (engine.barGraphMaxSize.Height / engine.scaleMax)
                BarraGrafica.Height = valor
                Dim ponto As New Point(BarraGrafica.Location.X, (posY) - valor)
                BarraGrafica.Location = ponto
            End If
            valor = input
            TextBoxValor.Text = valor & engine.unit
            If (engine.tipo = "Gráfico") Then
                atualizaGrafico()
            End If
        End If
    End Sub

    Private Sub atualizaGrafico()
        Dim valores() As Double = {0, 0, 0}
        If dados Is Nothing Then Exit Sub
        If engine.porta(0) <> "" Then
            valores(0) = dados(engine.porta(0))
        End If
        If engine.porta(1) <> "" Then
            valores(1) = dados(engine.porta(1))
        End If
        If engine.porta(2) <> "" Then
            valores(2) = dados(engine.porta(2))
        End If
        Grafico.AddPoint(valores)
    End Sub

    Private Function GetScaleValue(input As UInt16) As Double
        Return (FormatNumber((input / 1024) * (engine.scaleMax - engine.scaleMin), 2))
    End Function

    Private Sub leituraAnalogica()
        Static Dim cont As UInt16 = 0
        Static Dim erro As UInt16 = 0
        Dim valor As String = "0"
        If dados IsNot Nothing Then
            If dados.Count <= engine.porta(0) Then Exit Sub
            If (appProgrammingMethod <> "Avançado") Then
                valor = analogicas(engine.porta(0).Remove(0, 1))
            Else
                valor = dados(engine.porta(0))
            End If
        End If
        Try
            'If (arduinoType = 1) Then
            ScaleBargraph(valor)
            'End If
        Catch ex As Exception
            'MessageBox.Show("Exeção gerada: " & ex.ToString)
            showError(ex.Message)
        End Try
        If (erro > 5) Then
            'MessageBox.Show("Erro de leitura elemento " & meusDados.endereco & " de rotulo = " & LabelRotulo.Text, "Erro")
            'ArduinoSuiteMain.StopRede
        End If
        If (Not (DruidaSuiteMain.COMPort.IsOpen)) Then
            ScaleBargraph(1023)
            TimerAtualizaStatus.Enabled = False
        End If
        'Dim valor As Double = GetScaleValue(analogicas(engine.porta(0)))
    End Sub

    Public Sub AcionaSaidaAnalogica(porta As Byte, estado As String)
        'If dados Is Nothing Then Exit Sub
        'If dados.Count < porta + 1 Then Exit Sub
        If estado = Nothing Or estado = "" Then estado = 0
        If (engine.tipo <> "Saída Registrador-32Bits") Then
            testeVar = estado
            'getListaPWMs()
            Dim pos = listaPWMs.IndexOf(CInt(engine.porta(0)))
            If (portaAberta And estado <> pwm(pos)) Then
                monitorSerialWrite("4.0.0.0.0.0.0." & engine.porta(0) & "." & estado & ".1_")
                'ArduinoSuiteMain.COMPort.Write("4.0.0.0.0.0.0." & engine.porta(0) & "." & estado & ".1_")
                If TrackBarSaidaAnalogica.Visible Then
                    TrackBarSaidaAnalogica.Value = estado
                End If
            End If
        Else
            'testeVar = estado
            If dados IsNot Nothing Then
                If (portaAberta And estado <> dados(engine.porta(0))) Then
                    'monitorSerialWrite("2.0.0.0.0.0.0." & engine.porta(0) & "." & estado & ".1_")
                    'ArduinoSuiteMain.COMPort.Write("4.0.0.0.0.0.0." & engine.porta(0) & "." & estado & ".1_")
                    dados(engine.porta(0)) = estado
                    If TrackBarSaidaAnalogica.Visible Then
                        TrackBarSaidaAnalogica.Value = estado
                    End If
                    descartaDados = engine.porta(0)
                End If
            End If
        End If
    End Sub

    Private Sub TrackBarSaidaAnalogica_Scroll(sender As Object, e As EventArgs) Handles TrackBarSaidaAnalogica.Scroll, TrackBarSaidaAnalogica.ValueChanged
        If TrackBarSaidaAnalogica.Visible And engine.porta(0) <> "" Then
            AcionaSaidaAnalogica(engine.porta(0), TrackBarSaidaAnalogica.Value)
        End If
        'If (engine.scrollDir) Then TextBoxValor.Text = 255 - TrackBarSaidaAnalogica.Value
        'If Not (engine.scrollDir) Then TextBoxValor.Text = TrackBarSaidaAnalogica.Value
        'TextBoxValor.Text = TrackBarSaidaAnalogica.Value
    End Sub

    Private Function GetForm()
        Return Me.ParentForm
    End Function

    Private Sub leituraInstrucoes()
        Dim cont As Byte = 0
        Dim resultado As Int16 = 0
        Dim comandos() = engine.joyKey.Split("|")
        Static Dim valorAnterior = 0
        If dados Is Nothing Then
            Exit Sub
        End If
        For Each line In comandos
            If (line <> "") Then
                Dim valor As Int16 = 0
                If (line.Remove(0, 1) = "leftAnalogXRight") Then
                    valor = GetForm.leftAnalogXVal
                End If
                If (line.Remove(0, 1) = "leftAnalogXLeft") Then
                    valor = GetForm.leftAnalogXVal
                End If
                If (line.Remove(0, 1) = "leftAnalogYUp") Then
                    valor = GetForm.leftAnalogYVal
                End If
                If (line.Remove(0, 1) = "leftAnalogYDown") Then
                    valor = GetForm.leftAnalogYVal
                End If
                If (line.Remove(0, 1) = "rightAnalogXLeft") Then
                    valor = GetForm.rightAnalogXVal
                End If
                If (line.Remove(0, 1) = "rightAnalogXRight") Then
                    valor = GetForm.rightAnalogXVal
                End If
                If (line.Remove(0, 1) = "rightAnalogYUp") Then
                    valor = GetForm.rightAnalogYVal
                End If
                If (line.Remove(0, 1) = "rightAnalogYDown") Then
                    valor = GetForm.rightAnalogYVal
                End If
                If (line.Remove(0, 1) = "gatilhoEsq") Then
                    valor = GetForm.gatilhoEsquerdoVal
                End If
                If (line.Remove(0, 1) = "gatilhoDir") Then
                    valor = GetForm.gatilhoDireitoVal
                End If
                If (line(0) = "+") Then valor = valor
                If (line(0) = "-") Then valor = valor * (-1)
                resultado += valor
                If (resultado > engine.scaleMax) Then resultado = engine.scaleMax
                If (resultado < engine.scaleMin) Then resultado = engine.scaleMin
            End If
        Next
        If (engine.tipo <> "Saída Registrador-32Bits") Then
            Dim pos = listaPWMs.IndexOf(CInt(engine.porta(0)))
            If (resultado <> pwm(pos)) Then
                AcionaSaidaAnalogica(engine.porta(0), resultado)
                valorAnterior = resultado
            End If
        Else
            'If (resultado <> dados(engine.porta(0))) Then
            AcionaSaidaAnalogica(engine.porta(0), resultado)
            'valorAnterior = resultado
            'End If
        End If
    End Sub

    Private Sub TextBoxValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValor.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Me_ContextMenu(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If (e.Button = MouseButtons.Right) Then
            ContextMenuStripControl.Show()
            ContextMenuStripControl.Location = MousePosition
        End If
    End Sub

    Private Sub TrackBarSaidaAnalogica_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBarSaidaAnalogica.MouseUp
        'If (ArduinoSuiteMain.COMPort.IsOpen) Then
        '    monitorSerialWrite("0.0.0.0.0.0.0.0.0.0_r")
        'End If
    End Sub


    Private Sub TextBoxValor_TextChanged(sender As Object, e As EventArgs) Handles TextBoxValor.TextChanged
        Dim valor As Int32 = "0"
        valor = GetNumbers(TextBoxValor.Text)
        If valor > TrackBarSaidaAnalogica.Maximum Then
            TrackBarSaidaAnalogica.Maximum = valor
        End If
        'If engine.porta(0) <> "" And engine.tipo = "Saída Registrador-32Bits" Then
        '    AcionaSaidaAnalogica(engine.porta(0), TextBoxValor.Text)
        'End If
        If TextBoxValor.Text = vbCrLf Then TextBoxValor.Text = ""
        engine.textValorValue = TextBoxValor.Text
    End Sub

    Private Sub AlinharAoCentroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlinharAoCentroToolStripMenuItem.Click
        Me.Anchor = AnchorStyles.None
        engine.borda = Me.Anchor
        For Each control As ControleHardware In selectedControls
            control.Anchor = AnchorStyles.None
            control.engine.borda = control.Anchor
        Next
    End Sub

    Private Sub AncorarADireitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AncorarADireitaToolStripMenuItem.Click
        If alinhamento(0) = "1" Then
            Me.Anchor = Me.Anchor Xor AnchorStyles.Right
        Else
            Me.Anchor = Me.Anchor Or AnchorStyles.Right
        End If
        engine.borda = Me.Anchor
        For Each control As ControleHardware In selectedControls
            If alinhamento(0) = "1" Then
                control.Anchor = control.Anchor Xor AnchorStyles.Right
            Else
                control.Anchor = control.Anchor Or AnchorStyles.Right
            End If
            control.engine.borda = control.Anchor
        Next
    End Sub

    Private Sub AncorarAEsquerdaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AncorarAEsquerdaToolStripMenuItem.Click
        If alinhamento(1) = "1" Then
            Me.Anchor = Me.Anchor Xor AnchorStyles.Left
        Else
            Me.Anchor = Me.Anchor Or AnchorStyles.Left
        End If
        For Each control As ControleHardware In selectedControls
            If alinhamento(0) = "1" Then
                control.Anchor = control.Anchor Xor AnchorStyles.Left
            Else
                control.Anchor = control.Anchor Or AnchorStyles.Left
            End If
            control.engine.borda = control.Anchor
        Next
        engine.borda = Me.Anchor
    End Sub

    Private Sub AncorarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AncorarToolStripMenuItem.Click
        If alinhamento(2) = "1" Then
            Me.Anchor = Me.Anchor Xor AnchorStyles.Bottom
        Else
            Me.Anchor = Me.Anchor Or AnchorStyles.Bottom
        End If
        engine.borda = Me.Anchor
        For Each control As ControleHardware In selectedControls
            If alinhamento(0) = "1" Then
                control.Anchor = control.Anchor Xor AnchorStyles.Bottom
            Else
                control.Anchor = control.Anchor Or AnchorStyles.Bottom
            End If
            control.engine.borda = control.Anchor
        Next
    End Sub

    Private Sub AncorarAoTopoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AncorarAoTopoToolStripMenuItem.Click
        If alinhamento(3) = "1" Then
            Me.Anchor = Me.Anchor Xor AnchorStyles.Top
        Else
            Me.Anchor = Me.Anchor Or AnchorStyles.Top
        End If
        engine.borda = Me.Anchor
        For Each control As ControleHardware In selectedControls
            If alinhamento(0) = "1" Then
                control.Anchor = control.Anchor Xor AnchorStyles.Top
            Else
                control.Anchor = control.Anchor Or AnchorStyles.Top
            End If
            control.engine.borda = control.Anchor
        Next
    End Sub

    Private Sub checarAlinhamento()
        Dim img As Image = My.Resources.Enabled
        If alinhamento(0) = "1" Then
            AncorarADireitaToolStripMenuItem.Image = img
        Else
            AncorarADireitaToolStripMenuItem.Image = Nothing
        End If
        If alinhamento(1) = "1" Then
            AncorarAEsquerdaToolStripMenuItem.Image = img
        Else
            AncorarAEsquerdaToolStripMenuItem.Image = Nothing
        End If
        If alinhamento(2) = "1" Then
            AncorarToolStripMenuItem.Image = img
        Else
            AncorarToolStripMenuItem.Image = Nothing
        End If
        If alinhamento(3) = "1" Then
            AncorarAoTopoToolStripMenuItem.Image = img
        Else
            AncorarAoTopoToolStripMenuItem.Image = Nothing
        End If
    End Sub

    Private Sub VideoSourcePlayer_NewFrame(sender As Object, ByRef image As Bitmap) Handles VideoSourcePlayer.NewFrame
        If engine.button1Text = "90°" Then
            image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If engine.button1Text = "180°" Then
            image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
        If engine.button1Text = "270°" Then
            image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If
        If engine.button2Text = "x" Then
            image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        End If
        If engine.button2Text = "y" Then
            image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        End If
    End Sub

    Private Sub GetTextActionRoutine(nome As String, tipo As String, gatilho As String)
        If engine.tipo = "Registrador <Bit>" Then
            textAction = ""
            textAction &= "void " & nome & "_" & gatilho & "()" & vbCrLf
            textAction &= "{" & vbCrLf
            textAction &= vbTab & tipo & ";" & vbCrLf
            textAction &= vbTab & "//coloque seu código aqui" & vbCrLf
            textAction &= "}" & vbCrLf
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            textAction = ""
            textAction &= "void " & nome & "_LerValor()" & vbCrLf
            textAction &= "{" & vbCrLf
            textAction &= vbTab & textLeitura & vbCrLf
            textAction &= vbTab & "//coloque seu código aqui" & vbCrLf
            textAction &= "}" & vbCrLf
        End If
    End Sub

    Private Sub GetTextActionWriteRoutine(nome As String, tipo As String)
        If engine.tipo = "Registrador <Bit>" Then
            textAction = ""
            textAction &= "void " & nome & "_Escrita()" & vbCrLf
            textAction &= "{" & vbCrLf
            textAction &= vbTab & "bool " & nome & " = //digite o valor ou o nome da váriavel a ser enviada para o controle aqui" & vbCrLf
            textAction &= vbTab & "Druida.setRegBit(" & engine.porta(0) & ", " & engine.porta(1) & ", " & nome & ");" & vbCrLf
            textAction &= vbTab & "//coloque seu código aqui" & vbCrLf
            textAction &= "}" & vbCrLf
        End If
        If engine.tipo = "Entrada Registrador-32Bits" Then
            textAction = ""
            textAction &= "void " & nome & "_EscreveValor()" & vbCrLf
            textAction &= "{" & vbCrLf
            textAction &= vbTab & "int " & nome & " = //digite o valor ou o nome da váriavel a ser enviada para o controle aqui" & vbCrLf
            textAction &= vbTab & "Druida.setReg(" & tipo & ", " & nome & ");" & vbCrLf
            textAction &= vbTab & "//coloque seu código aqui" & vbCrLf
            textAction &= "}" & vbCrLf
        End If
        If engine.tipo = "Gráfico" Then
            textAction = ""
            textAction &= "void " & nome & "_EscreveValor()" & vbCrLf
            textAction &= "{" & vbCrLf
            If engine.porta(0) <> "" Then
                textAction &= vbTab & "int pena1 = //digite o valor ou o nome da váriavel a ser enviada para o controle aqui" & vbCrLf
                textAction &= vbTab & "Druida.setReg(" & engine.porta(0) & ", pena1);" & vbCrLf
            End If
            If engine.porta(1) <> "" Then
                textAction &= vbTab & "int pena2 = //digite o valor ou o nome da váriavel a ser enviada para o controle aqui" & vbCrLf
                textAction &= vbTab & "Druida.setReg(" & engine.porta(1) & ", pena2);" & vbCrLf
            End If
            If engine.porta(2) <> "" Then
                textAction &= vbTab & "int pena3 = //digite o valor ou o nome da váriavel a ser enviada para o controle aqui" & vbCrLf
                textAction &= vbTab & "Druida.setReg(" & engine.porta(2) & ", pena1);" & vbCrLf
            End If
            textAction &= vbTab & "//coloque seu código aqui" & vbCrLf
            textAction &= "}" & vbCrLf
        End If
    End Sub

    Public Sub AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem.Click
        GetTextActionCall()
        Clipboard.SetText(textAction)
        rascunhoCodigo &= textAction & vbCrLf
    End Sub

    Private Sub GetTextActionCall()
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            textAction = vbTab & nome & "_Ativo();" & vbTab & vbTab & "//Leitura de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            textAction = vbTab & nome & "_LerValor();" & vbTab & vbTab & "//Leitura de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
    End Sub

    Private Sub GetTextActionLeituraBitCall()
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            textAction = vbTab & nome & "_Leitura();" & vbTab & vbTab & "//Leitura de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            textAction = vbTab & nome & "_LerValor();" & vbTab & vbTab & "//Leitura de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
    End Sub

    Private Sub GetTextActionCallInativo()
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            textAction = vbTab & nome & "_Inativo();" & vbTab & vbTab & "//Leitura de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            textAction = vbTab & nome & "_LerValor();" & vbTab & vbTab & "//Leitura de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
    End Sub

    Private Sub GetTextActionCallEscrita()
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            textAction = vbTab & nome & "_Escrita();" & vbTab & vbTab & "//Escrita de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
        If engine.tipo = "Entrada Registrador-32Bits" Or engine.tipo = "Gráfico" Then
            textAction = vbTab & nome & "_EscreveValor();" & vbTab & vbTab & "//Escrita de componente: " & telas(telaAberta) & "\" & engine.rotuloText
        End If
    End Sub

    Public Sub AçãoAoClicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçãoAoClicarToolStripMenuItem.Click
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        Dim Reg As Int16 = engine.porta(0)
        Dim bit As Int16 = 0
        If engine.porta(1) <> "" Then bit = engine.porta(1)
        If engine.tipo = "Registrador <Bit>" Or engine.tipo = "Saída Registrador-32Bits" Then
            GetTextActionRoutine(nome, "bool " & Name & " = Druida.getRegBit(" & Reg & "," & bit & ")", "Ativo")
            Clipboard.SetText(textAction)
            rascunhoCodigo &= textAction & vbCrLf
        Else
            MessageBox.Show("Não compatível com este tipo de componente.", "Tipo de componente inconpatível")
        End If
    End Sub

    Public Sub LeituraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeituraToolStripMenuItem.Click
        If textLeitura <> "" Then
            Clipboard.SetText(textLeitura)
            rascunhoCodigo &= textLeitura & vbCrLf
        Else
            MessageBox.Show("Clique com o botão direito do mouse e vá em propriedades para selecionar o endereço deste componente.")
        End If
    End Sub

    Public Sub EscritaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscritaToolStripMenuItem.Click
        If textEscrita <> "" Then
            Clipboard.SetText(textEscrita)
            rascunhoCodigo &= textEscrita & vbCrLf
        Else
            MessageBox.Show("Clique com o botão direito do mouse e vá em propriedades para selecionar o endereço deste componente.")
        End If
    End Sub

    Private Sub CopiarEndereçoDoComponenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarEndereçoDoComponenteToolStripMenuItem.Click
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        Dim reg As String = engine.porta(0)
        Dim bit As String = engine.porta(1)
        If engine.tipo = "Registrador <Bit>" Then
            Clipboard.SetText("#define " & nome & " " & reg & "," & bit)
            rascunhoCodigo &= "#define " & nome & " " & reg & "," & bit & vbCrLf
        Else
            Clipboard.SetText("#define " & nome & " " & reg)
            rascunhoCodigo = "#define " & nome & " " & reg & "," & bit & vbCrLf
        End If
    End Sub

    Private Sub LimparRascunhoDeCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparRascunhoDeCódigoToolStripMenuItem.Click
        rascunhoCodigo = ""
    End Sub

    Private Sub ExibirCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If selectedControls.Count > 1 Then
            selectedControls.Sort(Function(x, y) x.LabelRotulo.Text.CompareTo(y.LabelRotulo.Text))
            For Each control In selectedControls
                control.Ativo()
            Next
        Else
            Ativo()
        End If
    End Sub

    Private Sub ExibirCódigoLeitura_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLeitura.Click
        If selectedControls.Count > 1 Then
            selectedControls.Sort(Function(x, y) x.LabelRotulo.Text.CompareTo(y.LabelRotulo.Text))
            For Each control In selectedControls
                control.LeituraBit()
            Next
        Else
            LeituraBit()
        End If
    End Sub

    Public Sub Ativo()
        Dim nomeTela As String = telas(telaAberta).Replace(" ", "").Replace("-", "")
        nomeTela = HttpUtility.UrlEncode(nomeTela, Encoding.GetEncoding(28597)).Replace("+", " ")
        If Not (engine.tipo = "Registrador <Bit>" Or engine.tipo = "Saída Registrador-32Bits") Then
            MessageBox.Show("Não compatível com este tipo de componente.", "Tipo de componente inconpatível")
            Exit Sub
        End If
        Dim filePath As String = applicationDirectory & applicationCode & MainCodeName & "\Tela_" & nomeTela & ".ino"
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenFile(filePath)
        Else
            System.IO.Directory.CreateDirectory(applicationDirectory & applicationCode & MainCodeName & "\")
            Dim header As String = ""
            Dim descr As String = "Rotinas relacionadas aos comandos da Tela: " & telas(telaAberta)
            header &= "//*************************************************************************************************/" & vbLf
            header &= "//   Projeto" & vbTab & ": " & AppName & vbLf
            header &= "//   Arquivo" & vbTab & ": " & "Tela_" & nomeTela & ".ino" & vbLf
            header &= "//   Descrição" & vbTab & ": " & descr & vbLf
            header &= "//   Data" & vbTab & vbTab & ": " & Date.Today & vbLf
            header &= "//*************************************************************************************************/" & vbLf
            System.IO.File.WriteAllText(filePath, header)
            DruidaInterface.Files.UpdateFileList()
        End If
        OpenProgrammingScreen()
        Dim index = DruidaInterface.Code.SearchLine(GetMyCode())

        If index <> -1 Then
            DruidaInterface.Code.MarkLine(DruidaInterface.Code.SearchLine(GetMyCode()))
            Exit Sub
        Else
            If Not selectedControls.Count > 1 Then
                If MessageBox.Show("Não foi encontrado esse código para o componente selecionado. Deseja criá-lo?", "Criar código de programação", MessageBoxButtons.YesNo) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            Dim druidaPath As String = applicationDirectory & applicationCode & MainCodeName & "\Druida.ino"
            If System.IO.File.Exists(druidaPath) Then
                DruidaInterface.Files.OpenLocalFile("Druida.ino")
            End If
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            GetTextActionCall()
            Dim linToAdd = DruidaInterface.Code.SearchAfterLine("Druida.comunicacao();", "}")
            DruidaInterface.Code.AddLine(linToAdd, textAction)
        End If
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            Dim reg As String = engine.porta(0)
            Dim bit As String = engine.porta(1)
            GetTextActionRoutine(nome, "bool " & nome & " = Druida.getRegBit(" & reg & "," & bit & ")", "Ativo")
            DruidaInterface.Code.AppendText(vbCrLf & textAction)
            Dim linToSel As UInt16 = DruidaInterface.Code.SearchLine(GetMyCode())
            Druida_IDE_Lite.DruidaInterface.Code.MarkLine(linToSel)
        End If
    End Sub

    Public Sub LeituraBit()
        Dim nomeTela As String = telas(telaAberta).Replace(" ", "").Replace("-", "")
        nomeTela = HttpUtility.UrlEncode(nomeTela, Encoding.GetEncoding(28597)).Replace("+", " ")
        If Not (engine.tipo = "Registrador <Bit>" Or engine.tipo = "Saída Registrador-32Bits") Then
            MessageBox.Show("Não compatível com este tipo de componente.", "Tipo de componente inconpatível")
            Exit Sub
        End If
        Dim filePath As String = applicationDirectory & applicationCode & MainCodeName & "\Tela_" & nomeTela & ".ino"
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
        Else
            System.IO.Directory.CreateDirectory(applicationDirectory & applicationCode & MainCodeName & "\")
            Dim header As String = ""
            Dim descr As String = "Rotinas relacionadas aos comandos da Tela: " & telas(telaAberta)
            header &= "//*************************************************************************************************/" & vbLf
            header &= "//   Projeto" & vbTab & ": " & AppName & vbLf
            header &= "//   Arquivo" & vbTab & ": " & "Tela_" & nomeTela & ".ino" & vbLf
            header &= "//   Descrição" & vbTab & ": " & descr & vbLf
            header &= "//   Data" & vbTab & vbTab & ": " & Date.Today & vbLf
            header &= "//*************************************************************************************************/" & vbLf
            If System.IO.File.Exists(applicationDirectory & applicationCode & MainCodeName & "\pins.h") Then
                header &= vbCrLf & "#include ""pins.h""" & vbCrLf
            End If
            System.IO.File.WriteAllText(filePath, header)
            DruidaInterface.Files.UpdateFileList()
        End If
        OpenProgrammingScreen()
        Dim index = DruidaInterface.Code.SearchLine(GetMyCodeLeitura())
        If index <> -1 Then
            DruidaInterface.Code.MarkLine(index)
            Exit Sub
        Else
            If Not selectedControls.Count > 1 Then
                If MessageBox.Show("Não foi encontrado esse código para o componente selecionado. Deseja criá-lo?", "Criar código de programação", MessageBoxButtons.YesNo) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            Dim druidaPath As String = applicationDirectory & applicationCode & MainCodeName & "\Druida.ino"
            If System.IO.File.Exists(druidaPath) Then
                DruidaInterface.Files.OpenLocalFile("Druida.ino")
            End If
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            GetTextActionLeituraBitCall()
            Dim lineToAdd As UInt16 = DruidaInterface.Code.SearchAfterLine("Druida.comunicacao();", "}")
            DruidaInterface.Code.AddLine(lineToAdd, textAction)
        End If
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            Dim reg As String = engine.porta(0)
            Dim bit As String = engine.porta(1)
            GetTextActionRoutine(nome, "bool " & nome & " = Druida.getRegBit(" & reg & "," & bit & ")", "Leitura")
            DruidaInterface.Code.AppendText(vbCrLf & textAction)
            Dim lin As UInt16 = DruidaInterface.Code.SearchLine("//coloque seu código aqui")
            DruidaInterface.Code.MarkLine(lin)
        End If
    End Sub

    Public Sub ImplementarCódigoinativoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If selectedControls.Count > 1 Then
            selectedControls.Sort(Function(x, y) x.LabelRotulo.Text.CompareTo(y.LabelRotulo.Text))
            For Each control In selectedControls
                control.Inativo()
            Next
        Else
            Inativo()
        End If
    End Sub

    Public Sub Inativo()
        Dim nomeTela As String = telas(telaAberta).Replace(" ", "").Replace("-", "")
        nomeTela = HttpUtility.UrlEncode(nomeTela, Encoding.GetEncoding(28597)).Replace("+", " ")
        If Not (engine.tipo = "Registrador <Bit>" Or engine.tipo = "Saída Registrador-32Bits") Then
            MessageBox.Show("Não compatível com este tipo de componente.", "Tipo de componente inconpatível")
            Exit Sub
        End If
        Dim filePath As String = applicationDirectory & applicationCode & MainCodeName & "\Tela_" & nomeTela & ".ino"
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
        Else
            System.IO.Directory.CreateDirectory(applicationDirectory & applicationCode & MainCodeName & "\")
            Dim header As String = ""
            Dim descr As String = "Rotinas relacionadas aos comandos da Tela: " & telas(telaAberta)
            header &= "//*************************************************************************************************/" & vbLf
            header &= "//   Projeto" & vbTab & ": " & AppName & vbLf
            header &= "//   Arquivo" & vbTab & ": " & "Tela_" & nomeTela & ".ino" & vbLf
            header &= "//   Descrição" & vbTab & ": " & descr & vbLf
            header &= "//   Data" & vbTab & vbTab & ": " & Date.Today & vbLf
            header &= "//*************************************************************************************************/" & vbLf
            System.IO.File.WriteAllText(filePath, header)
            DruidaInterface.Files.UpdateFileList()
        End If
        OpenProgrammingScreen()
        Dim index = DruidaInterface.Code.SearchLine(GetMyCodeLeitura())
        If index <> -1 Then
            DruidaInterface.Code.MarkLine(DruidaInterface.Code.SearchLine(GetMyCode()))
            Exit Sub
        Else
            If Not selectedControls.Count > 1 Then
                If MessageBox.Show("Não foi encontrado esse código para o componente selecionado. Deseja criá-lo?", "Criar código de programação", MessageBoxButtons.YesNo) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            Dim druidaPath As String = applicationDirectory & applicationCode & MainCodeName & "\Druida.ino"
            If System.IO.File.Exists(druidaPath) Then
                DruidaInterface.Files.OpenLocalFile("Druida.ino")
            End If
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            GetTextActionCallInativo()
            Dim lineToAdd As UInt16 = DruidaInterface.Code.SearchAfterLine("Druida.comunicacao();", "}")
            DruidaInterface.Code.AddLine(lineToAdd, textAction)
        End If
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            Dim reg As String = engine.porta(0)
            Dim bit As String = engine.porta(1)
            GetTextActionRoutine(nome, "bool " & nome & " = !Druida.getRegBit(" & reg & "," & bit & ")", "Inativo")
            DruidaInterface.Code.AppendText(vbCrLf & textAction)
            Dim linToSel = DruidaInterface.Code.SearchLine(GetMyCodeLeitura)
            DruidaInterface.Code.MarkLine(linToSel)
        End If
    End Sub


    Private Function GetMyCode()
        Dim myCode As String = ""
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            myCode = "void " & nome & "_Ativo()"
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            myCode = "void " & nome & "_LerValor()"
        End If
        Return (myCode)
    End Function

    Private Function GetMyCodeLeitura()
        Dim myCode As String = ""
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            myCode = "void " & nome & "_Leitura()"
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            myCode = "void " & nome & "_LerValor()"
        End If
        Return (myCode)
    End Function

    Private Function GetMyCodeInativo()
        Dim myCode As String = ""
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            myCode = "void " & nome & "_Inativo()"
        End If
        If engine.tipo = "Saída Registrador-32Bits" Then
            myCode = "void " & nome & "_LerValor()"
        End If
        Return (myCode)
    End Function

    Private Function GetMyCodeEscrita()
        Dim myCode As String = ""
        Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
        nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
        If engine.tipo = "Registrador <Bit>" Then
            myCode = "void " & nome & "_Escrita()"
        End If
        If engine.tipo = "Entrada Registrador-32Bits" Or engine.tipo = "Gráfico" Then
            myCode = "void " & nome & "_EscreveValor()"
        End If
        Return (myCode)
    End Function

    Private Sub OpenProgrammingScreen()
        TelaInicial.OpenDruida()
        'DruidaInterface.DruidaIDE.BringToFront()
        'DruidaInterface.Code.MarkLine(0)
        'If ArduinoSuiteMain.SplitContainerWindows.Panel1.Contains(Programação) Or
        '        ArduinoSuiteMain.SplitContainerWindows.Panel2.Contains(Programação) Then
        '    ArduinoSuiteMain.SplitContainerWindows.BringToFront()
        '    Dim newPosition As New Point
        '    With Programação
        '        newPosition = .Parent.Location + .SplitContainer1.Location + .SplitContainer1.Panel2.Location + New Point(.SplitContainer1.Panel2.Height / 2, .SplitContainer1.Panel2.Width / 2)
        '        Cursor.Position = newPosition
        '        .Show()
        '        .BringToFront()
        '        .CodeEditorRef.TextBoxCode.Focus()
        '    End With
        'Else
        '    Programação.MdiParent = ArduinoSuiteMain
        '    Programação.Dock = DockStyle.Fill
        '    Programação.Show()
        '    Programação.BringToFront()
        'End If
    End Sub

    Private Sub LabelRotulo_DoubleClick(sender As Object, e As EventArgs) Handles LabelRotulo.DoubleClick, LabelValor.DoubleClick, PictureBoxStatus.DoubleClick
        'ExibirCódigoToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Click
        Dim initialPath As String = pathTela
        Dim saveFile As New SaveFileDialog With {
            .Filter = "Base de dados|*.dbf",
            .InitialDirectory = initialPath,
            .Title = "Salvar Base de Dados"
        }
        Dim dialogResult = saveFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            ComandoAvancado.recipesFile.SetFilePath(saveFile.FileName)
            For Each item As ControleHardware In selectedControls
                ComandoAvancado.recipesFile.SetVar(item.engine.rotuloText, item.engine.textValorValue)
            Next
        End If
    End Sub

    Private Sub CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Click
        Dim initialPath As String = pathTela
        Dim loadFile As New OpenFileDialog With {
        .Filter = "Base de dados|*.dbf",
        .InitialDirectory = initialPath,
        .Title = "Carregar Base de Dados"
        }
        Dim dialogResult = loadFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            ComandoAvancado.recipesFile.SetFilePath(loadFile.FileName)
            For Each item As ControleHardware In selectedControls
                If ComandoAvancado.recipesFile.VarExists(item.engine.rotuloText) Then
                    ComandoAvancado.recipesFile.LoadVar(item.engine.rotuloText, item.engine.textValorValue)
                    item.engine.updateControl(item)
                    descartaLeitura = True
                Else
                    MessageBox.Show("Não foram encontradas ocorrêcias de '" & item.engine.rotuloText & "' no database selecionado")
                End If
            Next
        End If
    End Sub

    Private Sub CriarDatabaseParaATelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriarDatabaseParaATelaToolStripMenuItem.Click
        Dim initialPath As String = pathTela
        Dim saveFile As New SaveFileDialog With {
            .Filter = "Base de dados|*.dbf",
            .InitialDirectory = initialPath,
            .Title = "Salvar Base de Dados"
        }
        Dim dialogResult = saveFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            ComandoAvancado.recipesFile.SetFilePath(saveFile.FileName)
            For Each item As ControleHardware In ComandoAvancado.PanelComando.Controls
                If item.engine.textValorValue <> "" Then
                    ComandoAvancado.recipesFile.SetVar(item.engine.rotuloText, item.engine.textValorValue)
                End If
            Next
        End If
    End Sub

    Private Sub CarregarDatabaseParaATelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarregarDatabaseParaATelaToolStripMenuItem.Click
        Dim initialPath As String = pathTela
        Dim loadFile As New OpenFileDialog With {
        .Filter = "Base de dados|*.dbf",
        .InitialDirectory = initialPath,
        .Title = "Carregar Base de Dados"
        }
        Dim dialogResult = loadFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            ComandoAvancado.recipesFile.SetFilePath(loadFile.FileName)
            For Each item As ControleHardware In ComandoAvancado.PanelComando.Controls
                If ComandoAvancado.recipesFile.VarExists(item.engine.rotuloText) Then
                    ComandoAvancado.recipesFile.LoadVar(item.engine.rotuloText, item.engine.textValorValue)
                    item.engine.updateControl(item)
                    descartaLeitura = True
                Else
                    'MessageBox.Show("Não foram encontradas ocorrêcias de '" & item.engine.rotuloText & "' no database selecionado")
                End If
            Next
        End If
    End Sub

    Private Sub ImplementarCódigoescritaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImplementarCódigoescritaToolStripMenuItem.Click
        If selectedControls.Count > 1 Then
            selectedControls.Sort(Function(x, y) x.LabelRotulo.Text.CompareTo(y.LabelRotulo.Text))
            For Each control In selectedControls
                control.Escrita()
            Next
        Else
            Escrita()
        End If
    End Sub

    Public Sub Escrita()
        Dim nomeTela As String = telas(telaAberta).Replace(" ", "").Replace("-", "")
        nomeTela = HttpUtility.UrlEncode(nomeTela, Encoding.GetEncoding(28597)).Replace("+", " ")
        If Not (engine.tipo = "Registrador <Bit>" Or engine.tipo = "Entrada Registrador-32Bits" Or engine.tipo = "Gráfico") Then
            MessageBox.Show("Não compatível com este tipo de componente.", "Tipo de componente inconpatível")
            Exit Sub
        End If
        Dim filePath As String = applicationDirectory & applicationCode & MainCodeName & "\Tela_" & nomeTela & ".ino"
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
        Else
            System.IO.Directory.CreateDirectory(applicationDirectory & applicationCode & MainCodeName & "\")
            Dim header As String = ""
            Dim descr As String = "Rotinas relacionadas aos comandos da Tela: " & telas(telaAberta)
            header &= "//*************************************************************************************************/" & vbLf
            header &= "//   Projeto" & vbTab & ": " & AppName & vbLf
            header &= "//   Arquivo" & vbTab & ": " & "Tela_" & nomeTela & ".ino" & vbLf
            header &= "//   Descrição" & vbTab & ": " & descr & vbLf
            header &= "//   Data" & vbTab & vbTab & ": " & Date.Today & vbLf
            header &= "//*************************************************************************************************/" & vbLf
            If System.IO.File.Exists(applicationDirectory & applicationCode & MainCodeName & "\pins.h") Then
                header &= vbCrLf & "#include ""pins.h""" & vbCrLf
            End If
            System.IO.File.WriteAllText(filePath, header)
            DruidaInterface.Files.UpdateFileList()
        End If
        OpenProgrammingScreen()
        Dim index = DruidaInterface.Code.SearchLine(GetMyCodeEscrita())
        If index <> -1 Then
            DruidaInterface.Code.MarkLine(DruidaInterface.Code.SearchLine(GetMyCodeEscrita()))
            Exit Sub
        Else
            If Not selectedControls.Count > 1 Then
                If MessageBox.Show("Não foi encontrado esse código para o componente selecionado. Deseja criá-lo?", "Criar código de programação", MessageBoxButtons.YesNo) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            Dim druidaPath As String = applicationDirectory & applicationCode & MainCodeName & "\Druida.ino"
            If System.IO.File.Exists(druidaPath) Then
                DruidaInterface.Files.OpenLocalFile("Druida.ino")
            End If
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            GetTextActionCallEscrita()
            Dim lineToSel = DruidaInterface.Code.SearchAfterLine("Druida.comunicacao();", "}")
            DruidaInterface.Code.AddLine(lineToSel, textAction)
        End If
        If System.IO.File.Exists(filePath) Then
            DruidaInterface.Files.OpenLocalFile("Tela_" & nomeTela & ".ino")
            Dim nome As String = engine.rotuloText.Replace(" ", "_").Replace("-", "_")
            nome = HttpUtility.UrlEncode(nome, Encoding.GetEncoding(28597)).Replace("+", " ")
            Dim reg As String = engine.porta(0)
            Dim bit As String = engine.porta(1)
            GetTextActionWriteRoutine(nome, reg)
            DruidaInterface.Code.AppendText(vbCrLf & textAction)
        End If
    End Sub

    Private Sub GatilhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GatilhoToolStripMenuItem.Click
        CriarGatilho.ref = Me
        If CriarGatilho.ShowDialog() = DialogResult.OK Then
            If selectedControls.Count > 1 Then
                For Each control As ControleHardware In selectedControls
                    control.engine.gatilho = Me.engine.gatilho
                Next
            End If
        End If
    End Sub

    Private Sub ControleHardware_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            engine.AddControlName(engine.rotuloText)
            If engine.tipo = "Registrador <Bit>" Then
                engine.BitAddRegInt(engine.porta(0))
                engine.BitAddRegInt(engine.porta(0) & "." & engine.porta(1))
            ElseIf engine.tipo = "Entrada Registrador-32Bits" Or engine.tipo = "Saída Registrador-32Bits" Then
                engine.AddRegInt(engine.porta(0))
            ElseIf engine.tipo = "Gráfico" Then
                engine.AddRegInt(engine.porta(0))
                engine.AddRegInt(engine.porta(1))
                engine.AddRegInt(engine.porta(2))
            End If
        End If
    End Sub
End Class
