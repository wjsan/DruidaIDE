Imports System.Runtime.InteropServices

Public Class G27
    Dim centerVolante As Point
    Dim posAcel As Point
    Dim posEmbreagem As Point
    Dim posFreio As Point

    Private Sub TesteJoystick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerVolante = Volante.Location
    End Sub

    Public Sub OpenCfgs()
        posAcel = New Point(Acelerador.Location.X, Acelerador.Location.Y + Acelerador.Height)
        posEmbreagem = New Point(Embreagem.Location.X, Embreagem.Location.Y + Embreagem.Height)
        posFreio = New Point(Freio.Location.X, Freio.Location.Y + Freio.Height)
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF ' All information
        Timer1.Interval = 5  'Update at 5 hz
        If (System.IO.File.Exists(applicationDirectory & "\Config Files\G27.cfg")) Then
            TesteJoytick.mySeetings.fileJoy = applicationDirectory & "\Config Files\G27.cfg"
            TesteJoytick.mySeetings.OpenFileG27("load")
            loadValues()
        Else
            TesteJoytick.mySeetings.fileJoy = g27Default
            TesteJoytick.mySeetings.OpenFileG27("load")
            loadValues()
            TesteJoytick.mySeetings.fileJoy = applicationDirectory & "\Config Files\G27.cfg"
            TesteJoytick.mySeetings.OpenFileG27("save")
        End If
        Timer1.Start()
    End Sub

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

    Dim myjoyEX As JOYINFOEX

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            LabelButtonPressed.Text = readJoy()
            TesteJoytick.ToolStripStatusLabel1.Text = "Dispositivo Funcionando"
        Catch ex As Exception
            TesteJoytick.ToolStripStatusLabel1.Text = ex.Message
        End Try
    End Sub

    Function readJoy()
        ' Get the joystick information
        Dim botao As String = ""
        Call joyGetPosEx(TesteJoytick.mySeetings.port, myjoyEX)
        With myjoyEX
            Dim leftAnalogXVal As Int32 = (.dwXpos / 65535) * (TesteJoytick.mySeetings.volanteMax - TesteJoytick.mySeetings.volanteMin) + TesteJoytick.mySeetings.volanteMin
            Dim leftAnalogYVal As Int32 = (.dwZpos / 65535) * (TesteJoytick.mySeetings.aceleradorMax - TesteJoytick.mySeetings.aceleradorMin) + TesteJoytick.mySeetings.aceleradorMin
            Dim rightAnalogXVal As Int32 = (.dwUpos / 65535) * (TesteJoytick.mySeetings.embreagemMax - TesteJoytick.mySeetings.embreagemMin) + TesteJoytick.mySeetings.embreagemMin
            Dim rightAnalogYVal As Int32 = (.dwRpos / 65535) * (TesteJoytick.mySeetings.freioMax - TesteJoytick.mySeetings.freioMin) + TesteJoytick.mySeetings.freioMin
            Dim codBotoesVal As UInt32 = .dwButtons
            Dim botoesPress As Int32 = .dwButtonNumber
            Dim direcionaisVal As UInt16 = (.dwPOV / 100)
            Dim buttonsPressed As String = Convert.ToString(CUInt(codBotoesVal), 2).PadLeft(32, "0")
            LeftAnalogX.Text = leftAnalogXVal     'Up to six axis supported
            LeftAnalogY.Text = leftAnalogYVal
            RightAnalogX.Text = rightAnalogXVal
            RighAnalogY.Text = rightAnalogYVal
            CodBotoes.Text = codBotoesVal  'Print in Hex, so can see the individual bits associated with the buttons
            BotaoPressionado.Text = botoesPress  'number of buttons pressed at the same time
            Direcionais.Text = direcionaisVal    'POV hat (in 1/100ths of degrees, so divided by 100 to give degrees)
            LabelButtonsPressed.Text = buttonsPressed
            If (botoesPress = 0) Then
                If (leftAnalogXVal > 300) Then
                    botao = "leftAnalogXRight"
                ElseIf (leftAnalogXVal < 200) Then
                    botao = "leftAnalogXLeft"
                ElseIf (rightAnalogXVal > 300) Then
                    botao = "rightAnalogXRight"
                ElseIf (rightAnalogXVal < 200) Then
                    botao = "rightAnalogXLeft"
                ElseIf (rightAnalogYVal > 300) Then
                    botao = "rightAnalogYDown"
                ElseIf (rightAnalogYVal < 200) Then
                    botao = "rightAnalogYUp"
                ElseIf (direcionaisVal = 0) Then
                    botao = "dirUp"
                ElseIf (direcionaisVal = 90) Then
                    botao = "dirRight"
                ElseIf (direcionaisVal = 180) Then
                    botao = "dirDown"
                ElseIf (direcionaisVal = 270) Then
                    botao = "dirLeft"
                Else
                    botao = ""
                End If
            Else
                For i = 0 To 31
                    If (buttonsPressed(i) = "1") Then
                        botao = "Buttton" & 31 - i
                    End If
                Next
            End If
            AnimJoy(buttonsPressed, direcionaisVal)
            AnimVol(.dwXpos)
            AnimAcel(.dwZpos)
            AnimEmbreagem(.dwRpos)
            AnimFreio(.dwUpos)
        End With
        Return (botao)
    End Function

    Private Sub AnimVol(ByVal pos)
        Dim offset = 450
        Dim posX = (pos - 65535 / 2) / offset
        Dim r = 65535 / 2 / offset
        Dim PosY = 0
        If posX <= r Then
            PosY = Math.Sqrt(r ^ 2 - posX ^ 2) - r
        End If
        Volante.Location = centerVolante + New Point(posX, centerVolante.Y - PosY)
    End Sub

    Private Sub AnimAcel(ByVal pos)
        Dim offset = 1100
        Dim newSize = (65535 - pos) / 1100
        Acelerador.Size = New Size(Acelerador.Width, newSize)
        Acelerador.Location = posAcel - New Point(0, newSize)
    End Sub

    Private Sub AnimEmbreagem(ByVal pos)
        Dim offset = 1100
        Dim newSize = (65535 - pos) / 1100
        Embreagem.Size = New Size(Embreagem.Width, newSize)
        Embreagem.Location = posEmbreagem - New Point(0, newSize)
    End Sub

    Private Sub AnimFreio(ByVal pos)
        Dim offset = 1100
        Dim newSize = (65535 - pos) / 1100
        Freio.Size = New Size(Freio.Width, newSize)
        Freio.Location = posFreio - New Point(0, newSize)
    End Sub

    Private Sub AnimJoy(ByVal bt As String, ByVal dir As Int32)
        bt = StrReverse(bt)
        CambioBt0.Visible = bt(0) = "1"
        CambioBt1.Visible = bt(1) = "1"
        CambioBt2.Visible = bt(2) = "1"
        CambioBt3.Visible = bt(3) = "1"
        BorboletaDir.Visible = bt(4) = "1"
        BorboletaEsq.Visible = bt(5) = "1"
        VolBt1.Visible = bt(6) = "1"
        VolBt0.Visible = bt(7) = "1"
        Cambio1.Visible = bt(8) = "1"
        Cambio2.Visible = bt(9) = "1"
        Cambio3.Visible = bt(10) = "1"
        Cambio4.Visible = bt(11) = "1"
        Cambio5.Visible = bt(12) = "1"
        Cambio6.Visible = bt(13) = "1"
        CambioRe.Visible = bt(14) = "1"
        CambioBt4.Visible = bt(15) = "1"
        CambioBt5.Visible = bt(16) = "1"
        CambioBt6.Visible = bt(17) = "1"
        CambioBt7.Visible = bt(18) = "1"
        VolBt3.Visible = bt(19) = "1"
        VolBt2.Visible = bt(20) = "1"
        VolBt5.Visible = bt(21) = "1"
        VolBt4.Visible = bt(22) = "1"
        CambioUp.Visible = dir = 0
        CambioLeft.Visible = dir = 270
        CambioRight.Visible = dir = 90
        CambioDown.Visible = dir = 180
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub escreveValor(ByVal val As String, ByRef var As Int32)
        If (IsNumeric(val)) Then
            If (val <= 65535 And val > -65535) Then
                var = val
            End If
        End If
    End Sub

    Private Sub SaveValues()
        TesteJoytick.mySeetings.name = "G27"
        TesteJoytick.mySeetings.volanteMin = TextBoxVolanteMin.Text
        TesteJoytick.mySeetings.volanteMax = TextBoxVolanteMax.Text
        TesteJoytick.mySeetings.aceleradorMin = TextBoxAceleradorMin.Text
        TesteJoytick.mySeetings.aceleradorMax = TextBoxAceleradorMax.Text
        TesteJoytick.mySeetings.embreagemMin = EmbreagemMin.Text
        TesteJoytick.mySeetings.embreagemMax = EmbreagemMax.Text
        TesteJoytick.mySeetings.freioMin = FreioMin.Text
        TesteJoytick.mySeetings.freioMax = TextBoxFreioMax.Text
    End Sub

    Public Sub loadValues()
        TesteJoytick.TextBox1.Text = TesteJoytick.mySeetings.port
        TextBoxVolanteMin.Text = TesteJoytick.mySeetings.volanteMin
        TextBoxVolanteMax.Text = TesteJoytick.mySeetings.volanteMax
        TextBoxAceleradorMin.Text = TesteJoytick.mySeetings.aceleradorMin
        TextBoxAceleradorMax.Text = TesteJoytick.mySeetings.aceleradorMax
        EmbreagemMin.Text = TesteJoytick.mySeetings.embreagemMin
        EmbreagemMax.Text = TesteJoytick.mySeetings.embreagemMax
        FreioMin.Text = TesteJoytick.mySeetings.freioMin
        TextBoxFreioMax.Text = TesteJoytick.mySeetings.freioMax
    End Sub

    Private Sub ButtonAplicar_Click(sender As Object, e As EventArgs) Handles ButtonAplicar.Click
        SaveValues()
    End Sub
End Class