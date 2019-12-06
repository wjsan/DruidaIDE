Imports AForge.Video

Public Class ControleInterface
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
    End Sub

    Private Sub TimerAtualizaStatus_Tick(sender As Object, e As EventArgs) Handles TimerAtualizaStatus.Tick
        If DruidaSuiteMain.TimerLeituraRede.Enabled Then
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
        MessageBox.Show(texto, "Erro")
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
        If engine.tipo = "Botão de Comando" Then
            If engine.imagens(0) = "Sair da Aplicação" Then
                If DruidaSuiteMain.COMPort.IsOpen Then
                    DruidaSuiteMain.PictureBoxConectar_Click(sender, e)
                End If
                TestarApp.Close()
            Else
                TestarApp.AbrirTela(engine.imagens(0))
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

End Class
