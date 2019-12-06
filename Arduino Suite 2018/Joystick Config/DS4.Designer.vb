<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DS4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelButtonPressed = New System.Windows.Forms.Label()
        Me.LabelButtonsPressed = New System.Windows.Forms.Label()
        Me.Direcionais = New System.Windows.Forms.Label()
        Me.BotaoPressionado = New System.Windows.Forms.Label()
        Me.CodBotoes = New System.Windows.Forms.Label()
        Me.GatilhoEsq = New System.Windows.Forms.Label()
        Me.GatilhoDireito = New System.Windows.Forms.Label()
        Me.RighAnalogY = New System.Windows.Forms.Label()
        Me.RightAnalogX = New System.Windows.Forms.Label()
        Me.LeftAnalogY = New System.Windows.Forms.Label()
        Me.LeftAnalogX = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.X = New System.Windows.Forms.Label()
        Me.O = New System.Windows.Forms.Label()
        Me.Quadrado = New System.Windows.Forms.Label()
        Me.Triângulo = New System.Windows.Forms.Label()
        Me.DpadDown = New System.Windows.Forms.Label()
        Me.dPadLeft = New System.Windows.Forms.Label()
        Me.dPadUp = New System.Windows.Forms.Label()
        Me.dPadRight = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Label()
        Me.Options = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.R3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxAnEsqMinX = New System.Windows.Forms.TextBox()
        Me.TextBoxAnEsqMaxX = New System.Windows.Forms.TextBox()
        Me.TextBoxAnEsqMinY = New System.Windows.Forms.TextBox()
        Me.TextBoxAnEsqMaxY = New System.Windows.Forms.TextBox()
        Me.TextBoxAnDirMinX = New System.Windows.Forms.TextBox()
        Me.TextBoxAnDirMaxX = New System.Windows.Forms.TextBox()
        Me.TextBoxAnDirMinY = New System.Windows.Forms.TextBox()
        Me.TextBoxAnDirMaxY = New System.Windows.Forms.TextBox()
        Me.TextBoxGatilhoEsqMin = New System.Windows.Forms.TextBox()
        Me.TextBoxGatilhoDirMax = New System.Windows.Forms.TextBox()
        Me.TextBoxGatilhoDirMin = New System.Windows.Forms.TextBox()
        Me.TextBoxGatilhoEsqMax = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.R2 = New System.Windows.Forms.Label()
        Me.PS = New System.Windows.Forms.Label()
        Me.TrackPad = New System.Windows.Forms.Label()
        Me.ButtonAplicar = New System.Windows.Forms.Button()
        Me.leftAxis = New System.Windows.Forms.Label()
        Me.rightAxis = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LabelButtonPressed
        '
        Me.LabelButtonPressed.AutoSize = True
        Me.LabelButtonPressed.Location = New System.Drawing.Point(248, 442)
        Me.LabelButtonPressed.Name = "LabelButtonPressed"
        Me.LabelButtonPressed.Size = New System.Drawing.Size(76, 13)
        Me.LabelButtonPressed.TabIndex = 16
        Me.LabelButtonPressed.Text = "ButtonPressed"
        '
        'LabelButtonsPressed
        '
        Me.LabelButtonsPressed.AutoSize = True
        Me.LabelButtonsPressed.Location = New System.Drawing.Point(248, 463)
        Me.LabelButtonsPressed.Name = "LabelButtonsPressed"
        Me.LabelButtonsPressed.Size = New System.Drawing.Size(81, 13)
        Me.LabelButtonsPressed.TabIndex = 17
        Me.LabelButtonsPressed.Text = "ButtonsPressed"
        '
        'Direcionais
        '
        Me.Direcionais.BackColor = System.Drawing.Color.Transparent
        Me.Direcionais.Location = New System.Drawing.Point(248, 422)
        Me.Direcionais.Name = "Direcionais"
        Me.Direcionais.Size = New System.Drawing.Size(31, 17)
        Me.Direcionais.TabIndex = 6
        Me.Direcionais.Text = "000"
        Me.Direcionais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BotaoPressionado
        '
        Me.BotaoPressionado.AutoSize = True
        Me.BotaoPressionado.Location = New System.Drawing.Point(248, 505)
        Me.BotaoPressionado.Name = "BotaoPressionado"
        Me.BotaoPressionado.Size = New System.Drawing.Size(75, 13)
        Me.BotaoPressionado.TabIndex = 7
        Me.BotaoPressionado.Text = "BtPressionado"
        '
        'CodBotoes
        '
        Me.CodBotoes.AutoSize = True
        Me.CodBotoes.Location = New System.Drawing.Point(250, 484)
        Me.CodBotoes.Name = "CodBotoes"
        Me.CodBotoes.Size = New System.Drawing.Size(36, 13)
        Me.CodBotoes.TabIndex = 8
        Me.CodBotoes.Text = "CodBt"
        '
        'GatilhoEsq
        '
        Me.GatilhoEsq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GatilhoEsq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GatilhoEsq.Location = New System.Drawing.Point(329, 341)
        Me.GatilhoEsq.Name = "GatilhoEsq"
        Me.GatilhoEsq.Size = New System.Drawing.Size(56, 20)
        Me.GatilhoEsq.TabIndex = 9
        Me.GatilhoEsq.Text = "000"
        Me.GatilhoEsq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GatilhoDireito
        '
        Me.GatilhoDireito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GatilhoDireito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GatilhoDireito.Location = New System.Drawing.Point(329, 362)
        Me.GatilhoDireito.Name = "GatilhoDireito"
        Me.GatilhoDireito.Size = New System.Drawing.Size(56, 20)
        Me.GatilhoDireito.TabIndex = 10
        Me.GatilhoDireito.Text = "000"
        Me.GatilhoDireito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RighAnalogY
        '
        Me.RighAnalogY.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RighAnalogY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RighAnalogY.Location = New System.Drawing.Point(329, 320)
        Me.RighAnalogY.Name = "RighAnalogY"
        Me.RighAnalogY.Size = New System.Drawing.Size(56, 20)
        Me.RighAnalogY.TabIndex = 11
        Me.RighAnalogY.Text = "000"
        Me.RighAnalogY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightAnalogX
        '
        Me.RightAnalogX.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RightAnalogX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RightAnalogX.Location = New System.Drawing.Point(329, 299)
        Me.RightAnalogX.Name = "RightAnalogX"
        Me.RightAnalogX.Size = New System.Drawing.Size(56, 20)
        Me.RightAnalogX.TabIndex = 12
        Me.RightAnalogX.Text = "000"
        Me.RightAnalogX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftAnalogY
        '
        Me.LeftAnalogY.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LeftAnalogY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LeftAnalogY.Location = New System.Drawing.Point(329, 278)
        Me.LeftAnalogY.Name = "LeftAnalogY"
        Me.LeftAnalogY.Size = New System.Drawing.Size(56, 20)
        Me.LeftAnalogY.TabIndex = 13
        Me.LeftAnalogY.Text = "000"
        Me.LeftAnalogY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftAnalogX
        '
        Me.LeftAnalogX.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LeftAnalogX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LeftAnalogX.Location = New System.Drawing.Point(329, 257)
        Me.LeftAnalogX.Name = "LeftAnalogX"
        Me.LeftAnalogX.Size = New System.Drawing.Size(56, 20)
        Me.LeftAnalogX.TabIndex = 14
        Me.LeftAnalogX.Text = "000"
        Me.LeftAnalogX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.controle_ps4_jpg
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.Lime
        Me.X.Location = New System.Drawing.Point(320, 96)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(15, 14)
        Me.X.TabIndex = 18
        Me.X.Text = "   "
        Me.X.Visible = False
        '
        'O
        '
        Me.O.BackColor = System.Drawing.Color.Lime
        Me.O.Location = New System.Drawing.Point(342, 74)
        Me.O.Name = "O"
        Me.O.Size = New System.Drawing.Size(15, 14)
        Me.O.TabIndex = 19
        Me.O.Text = "   "
        Me.O.Visible = False
        '
        'Quadrado
        '
        Me.Quadrado.BackColor = System.Drawing.Color.Lime
        Me.Quadrado.Location = New System.Drawing.Point(297, 74)
        Me.Quadrado.Name = "Quadrado"
        Me.Quadrado.Size = New System.Drawing.Size(15, 14)
        Me.Quadrado.TabIndex = 19
        Me.Quadrado.Text = "   "
        Me.Quadrado.Visible = False
        '
        'Triângulo
        '
        Me.Triângulo.BackColor = System.Drawing.Color.Lime
        Me.Triângulo.Location = New System.Drawing.Point(319, 52)
        Me.Triângulo.Name = "Triângulo"
        Me.Triângulo.Size = New System.Drawing.Size(15, 14)
        Me.Triângulo.TabIndex = 19
        Me.Triângulo.Text = "   "
        Me.Triângulo.Visible = False
        '
        'DpadDown
        '
        Me.DpadDown.BackColor = System.Drawing.Color.Lime
        Me.DpadDown.Location = New System.Drawing.Point(130, 93)
        Me.DpadDown.Name = "DpadDown"
        Me.DpadDown.Size = New System.Drawing.Size(15, 14)
        Me.DpadDown.TabIndex = 20
        Me.DpadDown.Text = "   "
        Me.DpadDown.Visible = False
        '
        'dPadLeft
        '
        Me.dPadLeft.BackColor = System.Drawing.Color.Lime
        Me.dPadLeft.Location = New System.Drawing.Point(113, 74)
        Me.dPadLeft.Name = "dPadLeft"
        Me.dPadLeft.Size = New System.Drawing.Size(15, 14)
        Me.dPadLeft.TabIndex = 21
        Me.dPadLeft.Text = "   "
        Me.dPadLeft.Visible = False
        '
        'dPadUp
        '
        Me.dPadUp.BackColor = System.Drawing.Color.Lime
        Me.dPadUp.Location = New System.Drawing.Point(130, 57)
        Me.dPadUp.Name = "dPadUp"
        Me.dPadUp.Size = New System.Drawing.Size(15, 14)
        Me.dPadUp.TabIndex = 21
        Me.dPadUp.Text = "   "
        Me.dPadUp.Visible = False
        '
        'dPadRight
        '
        Me.dPadRight.BackColor = System.Drawing.Color.Lime
        Me.dPadRight.Location = New System.Drawing.Point(150, 74)
        Me.dPadRight.Name = "dPadRight"
        Me.dPadRight.Size = New System.Drawing.Size(15, 14)
        Me.dPadRight.TabIndex = 21
        Me.dPadRight.Text = "   "
        Me.dPadRight.Visible = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Lime
        Me.Start.Location = New System.Drawing.Point(167, 45)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(10, 14)
        Me.Start.TabIndex = 22
        Me.Start.Text = "   "
        Me.Start.Visible = False
        '
        'Options
        '
        Me.Options.BackColor = System.Drawing.Color.Lime
        Me.Options.Location = New System.Drawing.Point(288, 44)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(10, 14)
        Me.Options.TabIndex = 23
        Me.Options.Text = "   "
        Me.Options.Visible = False
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.Lime
        Me.L1.Location = New System.Drawing.Point(116, 30)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(47, 10)
        Me.L1.TabIndex = 24
        Me.L1.Text = "   "
        Me.L1.Visible = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.Lime
        Me.R1.Location = New System.Drawing.Point(301, 29)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(47, 10)
        Me.R1.TabIndex = 25
        Me.R1.Text = "   "
        Me.R1.Visible = False
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.Color.Lime
        Me.L3.Location = New System.Drawing.Point(177, 115)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(15, 14)
        Me.L3.TabIndex = 26
        Me.L3.Text = "   "
        Me.L3.Visible = False
        '
        'R3
        '
        Me.R3.BackColor = System.Drawing.Color.Lime
        Me.R3.Location = New System.Drawing.Point(273, 114)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(15, 14)
        Me.R3.TabIndex = 27
        Me.R3.Text = "   "
        Me.R3.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(71, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Analógico Esquerdo Eixo X:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(71, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Analógico Esquerdo Eixo Y:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(71, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Analógico Direito Eixo X:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(71, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Analógico Direito Eixo Y:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(71, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Gatilho Esquerdo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(71, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Gatilho Direito:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(105, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Direcionais:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(125, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Palavra de Dados (BIN):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(122, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Palavra de Dados (DEC):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(146, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Botão Pressionado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(112, 505)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Qtde Botões Pressionados:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(213, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Mín:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(271, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Máx:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxAnEsqMinX
        '
        Me.TextBoxAnEsqMinX.Location = New System.Drawing.Point(213, 257)
        Me.TextBoxAnEsqMinX.Name = "TextBoxAnEsqMinX"
        Me.TextBoxAnEsqMinX.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnEsqMinX.TabIndex = 30
        Me.TextBoxAnEsqMinX.Text = "0"
        Me.TextBoxAnEsqMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnEsqMaxX
        '
        Me.TextBoxAnEsqMaxX.Location = New System.Drawing.Point(271, 257)
        Me.TextBoxAnEsqMaxX.Name = "TextBoxAnEsqMaxX"
        Me.TextBoxAnEsqMaxX.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnEsqMaxX.TabIndex = 30
        Me.TextBoxAnEsqMaxX.Text = "255"
        Me.TextBoxAnEsqMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnEsqMinY
        '
        Me.TextBoxAnEsqMinY.Location = New System.Drawing.Point(213, 278)
        Me.TextBoxAnEsqMinY.Name = "TextBoxAnEsqMinY"
        Me.TextBoxAnEsqMinY.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnEsqMinY.TabIndex = 30
        Me.TextBoxAnEsqMinY.Text = "0"
        Me.TextBoxAnEsqMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnEsqMaxY
        '
        Me.TextBoxAnEsqMaxY.Location = New System.Drawing.Point(271, 278)
        Me.TextBoxAnEsqMaxY.Name = "TextBoxAnEsqMaxY"
        Me.TextBoxAnEsqMaxY.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnEsqMaxY.TabIndex = 30
        Me.TextBoxAnEsqMaxY.Text = "255"
        Me.TextBoxAnEsqMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnDirMinX
        '
        Me.TextBoxAnDirMinX.Location = New System.Drawing.Point(213, 299)
        Me.TextBoxAnDirMinX.Name = "TextBoxAnDirMinX"
        Me.TextBoxAnDirMinX.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnDirMinX.TabIndex = 30
        Me.TextBoxAnDirMinX.Text = "0"
        Me.TextBoxAnDirMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnDirMaxX
        '
        Me.TextBoxAnDirMaxX.Location = New System.Drawing.Point(271, 299)
        Me.TextBoxAnDirMaxX.Name = "TextBoxAnDirMaxX"
        Me.TextBoxAnDirMaxX.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnDirMaxX.TabIndex = 30
        Me.TextBoxAnDirMaxX.Text = "255"
        Me.TextBoxAnDirMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnDirMinY
        '
        Me.TextBoxAnDirMinY.Location = New System.Drawing.Point(213, 320)
        Me.TextBoxAnDirMinY.Name = "TextBoxAnDirMinY"
        Me.TextBoxAnDirMinY.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnDirMinY.TabIndex = 30
        Me.TextBoxAnDirMinY.Text = "0"
        Me.TextBoxAnDirMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxAnDirMaxY
        '
        Me.TextBoxAnDirMaxY.Location = New System.Drawing.Point(271, 320)
        Me.TextBoxAnDirMaxY.Name = "TextBoxAnDirMaxY"
        Me.TextBoxAnDirMaxY.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxAnDirMaxY.TabIndex = 30
        Me.TextBoxAnDirMaxY.Text = "255"
        Me.TextBoxAnDirMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxGatilhoEsqMin
        '
        Me.TextBoxGatilhoEsqMin.Location = New System.Drawing.Point(213, 362)
        Me.TextBoxGatilhoEsqMin.Name = "TextBoxGatilhoEsqMin"
        Me.TextBoxGatilhoEsqMin.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxGatilhoEsqMin.TabIndex = 30
        Me.TextBoxGatilhoEsqMin.Text = "0"
        Me.TextBoxGatilhoEsqMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxGatilhoDirMax
        '
        Me.TextBoxGatilhoDirMax.Location = New System.Drawing.Point(271, 362)
        Me.TextBoxGatilhoDirMax.Name = "TextBoxGatilhoDirMax"
        Me.TextBoxGatilhoDirMax.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxGatilhoDirMax.TabIndex = 30
        Me.TextBoxGatilhoDirMax.Text = "255"
        Me.TextBoxGatilhoDirMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxGatilhoDirMin
        '
        Me.TextBoxGatilhoDirMin.Location = New System.Drawing.Point(213, 341)
        Me.TextBoxGatilhoDirMin.Name = "TextBoxGatilhoDirMin"
        Me.TextBoxGatilhoDirMin.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxGatilhoDirMin.TabIndex = 30
        Me.TextBoxGatilhoDirMin.Text = "0"
        Me.TextBoxGatilhoDirMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxGatilhoEsqMax
        '
        Me.TextBoxGatilhoEsqMax.Location = New System.Drawing.Point(271, 341)
        Me.TextBoxGatilhoEsqMax.Name = "TextBoxGatilhoEsqMax"
        Me.TextBoxGatilhoEsqMax.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxGatilhoEsqMax.TabIndex = 30
        Me.TextBoxGatilhoEsqMax.Text = "255"
        Me.TextBoxGatilhoEsqMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(329, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Leitura:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(71, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Mecanismo:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.Lime
        Me.L2.Location = New System.Drawing.Point(118, 20)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(47, 10)
        Me.L2.TabIndex = 24
        Me.L2.Text = "   "
        Me.L2.Visible = False
        '
        'R2
        '
        Me.R2.BackColor = System.Drawing.Color.Lime
        Me.R2.Location = New System.Drawing.Point(297, 19)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(47, 10)
        Me.R2.TabIndex = 25
        Me.R2.Text = "   "
        Me.R2.Visible = False
        '
        'PS
        '
        Me.PS.BackColor = System.Drawing.Color.Lime
        Me.PS.Location = New System.Drawing.Point(229, 119)
        Me.PS.Name = "PS"
        Me.PS.Size = New System.Drawing.Size(10, 10)
        Me.PS.TabIndex = 27
        Me.PS.Text = "   "
        Me.PS.Visible = False
        '
        'TrackPad
        '
        Me.TrackPad.BackColor = System.Drawing.Color.Lime
        Me.TrackPad.Location = New System.Drawing.Point(186, 45)
        Me.TrackPad.Name = "TrackPad"
        Me.TrackPad.Size = New System.Drawing.Size(93, 43)
        Me.TrackPad.TabIndex = 19
        Me.TrackPad.Text = "   "
        Me.TrackPad.Visible = False
        '
        'ButtonAplicar
        '
        Me.ButtonAplicar.Location = New System.Drawing.Point(271, 391)
        Me.ButtonAplicar.Name = "ButtonAplicar"
        Me.ButtonAplicar.Size = New System.Drawing.Size(114, 23)
        Me.ButtonAplicar.TabIndex = 31
        Me.ButtonAplicar.Text = "Aplicar Modificações"
        Me.ButtonAplicar.UseVisualStyleBackColor = True
        '
        'leftAxis
        '
        Me.leftAxis.BackColor = System.Drawing.Color.Lime
        Me.leftAxis.Location = New System.Drawing.Point(180, 118)
        Me.leftAxis.Name = "leftAxis"
        Me.leftAxis.Size = New System.Drawing.Size(9, 9)
        Me.leftAxis.TabIndex = 32
        Me.leftAxis.Text = "   "
        '
        'rightAxis
        '
        Me.rightAxis.BackColor = System.Drawing.Color.Lime
        Me.rightAxis.Location = New System.Drawing.Point(276, 117)
        Me.rightAxis.Name = "rightAxis"
        Me.rightAxis.Size = New System.Drawing.Size(9, 9)
        Me.rightAxis.TabIndex = 33
        Me.rightAxis.Text = "   "
        '
        'DS4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 543)
        Me.Controls.Add(Me.rightAxis)
        Me.Controls.Add(Me.leftAxis)
        Me.Controls.Add(Me.ButtonAplicar)
        Me.Controls.Add(Me.TextBoxGatilhoEsqMax)
        Me.Controls.Add(Me.TextBoxGatilhoDirMax)
        Me.Controls.Add(Me.TextBoxAnDirMaxY)
        Me.Controls.Add(Me.TextBoxGatilhoDirMin)
        Me.Controls.Add(Me.TextBoxAnDirMaxX)
        Me.Controls.Add(Me.TextBoxGatilhoEsqMin)
        Me.Controls.Add(Me.TextBoxAnEsqMaxY)
        Me.Controls.Add(Me.TextBoxAnDirMinY)
        Me.Controls.Add(Me.TextBoxAnDirMinX)
        Me.Controls.Add(Me.TextBoxAnEsqMinY)
        Me.Controls.Add(Me.TextBoxAnEsqMaxX)
        Me.Controls.Add(Me.TextBoxAnEsqMinX)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PS)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.dPadUp)
        Me.Controls.Add(Me.dPadRight)
        Me.Controls.Add(Me.dPadLeft)
        Me.Controls.Add(Me.DpadDown)
        Me.Controls.Add(Me.Triângulo)
        Me.Controls.Add(Me.TrackPad)
        Me.Controls.Add(Me.Quadrado)
        Me.Controls.Add(Me.O)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.LabelButtonPressed)
        Me.Controls.Add(Me.LabelButtonsPressed)
        Me.Controls.Add(Me.Direcionais)
        Me.Controls.Add(Me.BotaoPressionado)
        Me.Controls.Add(Me.CodBotoes)
        Me.Controls.Add(Me.GatilhoEsq)
        Me.Controls.Add(Me.GatilhoDireito)
        Me.Controls.Add(Me.RighAnalogY)
        Me.Controls.Add(Me.RightAnalogX)
        Me.Controls.Add(Me.LeftAnalogY)
        Me.Controls.Add(Me.LeftAnalogX)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DS4"
        Me.Text = "DS4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelButtonPressed As Label
    Friend WithEvents LabelButtonsPressed As Label
    Friend WithEvents Direcionais As Label
    Friend WithEvents BotaoPressionado As Label
    Friend WithEvents CodBotoes As Label
    Friend WithEvents GatilhoEsq As Label
    Friend WithEvents GatilhoDireito As Label
    Friend WithEvents RighAnalogY As Label
    Friend WithEvents RightAnalogX As Label
    Friend WithEvents LeftAnalogY As Label
    Friend WithEvents LeftAnalogX As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents X As Label
    Friend WithEvents O As Label
    Friend WithEvents Quadrado As Label
    Friend WithEvents Triângulo As Label
    Friend WithEvents DpadDown As Label
    Friend WithEvents dPadLeft As Label
    Friend WithEvents dPadUp As Label
    Friend WithEvents dPadRight As Label
    Friend WithEvents Start As Label
    Friend WithEvents Options As Label
    Friend WithEvents L1 As Label
    Friend WithEvents R1 As Label
    Friend WithEvents L3 As Label
    Friend WithEvents R3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxAnEsqMinX As TextBox
    Friend WithEvents TextBoxAnEsqMaxX As TextBox
    Friend WithEvents TextBoxAnEsqMinY As TextBox
    Friend WithEvents TextBoxAnEsqMaxY As TextBox
    Friend WithEvents TextBoxAnDirMinX As TextBox
    Friend WithEvents TextBoxAnDirMaxX As TextBox
    Friend WithEvents TextBoxAnDirMinY As TextBox
    Friend WithEvents TextBoxAnDirMaxY As TextBox
    Friend WithEvents TextBoxGatilhoEsqMin As TextBox
    Friend WithEvents TextBoxGatilhoDirMax As TextBox
    Friend WithEvents TextBoxGatilhoDirMin As TextBox
    Friend WithEvents TextBoxGatilhoEsqMax As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents R2 As Label
    Friend WithEvents PS As Label
    Friend WithEvents TrackPad As Label
    Friend WithEvents ButtonAplicar As Button
    Friend WithEvents leftAxis As Label
    Friend WithEvents rightAxis As Label
End Class
