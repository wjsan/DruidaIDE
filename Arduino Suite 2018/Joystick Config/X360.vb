Imports System.Runtime.InteropServices

Public Class X360
    Dim centerLeftAxis As Point
    Dim centerRightAxis As Point

    Private Sub TesteJoystick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerLeftAxis = leftAxis.Location
        centerRightAxis = rightAxis.Location
    End Sub

    Public Sub OpenCfgs()
        myjoyEX.dwSize = Len(myjoyEX)
        myjoyEX.dwFlags = 128 ' All information
        Timer1.Interval = 10  'Update at 5 hz
        If (System.IO.File.Exists(applicationDirectory & "\Config Files\X360.cfg")) Then
            TesteJoytick.mySeetings.fileJoy = applicationDirectory & "\Config Files\X360.cfg"
            TesteJoytick.mySeetings.OpenFileJoy("load")
            loadValues()
        Else
            TesteJoytick.mySeetings.fileJoy = x360Default
            TesteJoytick.mySeetings.OpenFileJoy("load")
            loadValues()
            TesteJoytick.mySeetings.fileJoy = applicationDirectory & "\Config Files\X360.cfg"
            TesteJoytick.mySeetings.OpenFileJoy("save")
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
        Call joyGetPosEx(joySeetings.port, myjoyEX)
        With myjoyEX
            Dim auxGatDir As Int16 = 0
            Dim auxGatEsq As Int16 = 0
            If .dwZpos < 32768 Then
                auxGatDir = 32768 - .dwZpos
                'auxGatEsq = 0
            Else
                'auxGatDir = 0
                auxGatEsq = .dwZpos - 32768
            End If
            Dim leftAnalogXVal As Int16 = (.dwXpos / 65535) * (TesteJoytick.mySeetings.anEsqXMax - TesteJoytick.mySeetings.anEsqXMin) + TesteJoytick.mySeetings.anEsqXMin
            Dim leftAnalogYVal As Int16 = (.dwYpos / 65535) * (TesteJoytick.mySeetings.anEsqYMax - TesteJoytick.mySeetings.anEsqYMin) + TesteJoytick.mySeetings.anEsqYMin
            Dim rightAnalogXVal As Int16 = (.dwUpos / 65535) * (TesteJoytick.mySeetings.anDirXMax - TesteJoytick.mySeetings.anDirXMin) + TesteJoytick.mySeetings.anDirXMin
            Dim rightAnalogYVal As Int16 = (.dwRpos / 65535) * (TesteJoytick.mySeetings.anDirYMax - TesteJoytick.mySeetings.anDirYMin) + TesteJoytick.mySeetings.anDirYMin
            Dim gatilhoDireitoVal As Int16 = (auxGatDir / 32640) * (TesteJoytick.mySeetings.gatEsqMax - TesteJoytick.mySeetings.gatEsqMin) + TesteJoytick.mySeetings.gatEsqMin
            Dim gatilhoEsquerdoVal As Int32 = (auxGatEsq / 32640) * (TesteJoytick.mySeetings.gatDirMax - TesteJoytick.mySeetings.gatDirMin) + TesteJoytick.mySeetings.gatDirMin
            Dim codBotoesVal As UInt16 = .dwButtons
            Dim botoesPress As Int16 = .dwButtonNumber
            Dim direcionaisVal As UInt16 = (.dwPOV / 100)
            Dim buttonsPressed As String = Convert.ToString(CUInt(codBotoesVal), 2).PadLeft(14, "0")
            LeftAnalogX.Text = leftAnalogXVal     'Up to six axis supported
            LeftAnalogY.Text = leftAnalogYVal
            RightAnalogX.Text = rightAnalogXVal
            RighAnalogY.Text = rightAnalogYVal
            GatilhoDireito.Text = gatilhoDireitoVal
            GatilhoEsq.Text = gatilhoEsquerdoVal
            CodBotoes.Text = codBotoesVal  'Print in Hex, so can see the individual bits associated with the buttons
            BotaoPressionado.Text = botoesPress  'number of buttons pressed at the same time
            Direcionais.Text = direcionaisVal    'POV hat (in 1/100ths of degrees, so divided by 100 to give degrees)
            LabelButtonsPressed.Text = buttonsPressed
            If (botoesPress = 0) Then
                If (leftAnalogXVal > 300) Then
                    botao = "leftAnalogXRight"
                ElseIf (leftAnalogXVal < 200) Then
                    botao = "leftAnalogXLeft"
                ElseIf (leftAnalogYVal > 300) Then
                    botao = "leftAnalogYDown"
                ElseIf (leftAnalogYVal < 200) Then
                    botao = "leftAnalogYUp"
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
                For i = 0 To 13
                    If (buttonsPressed(i) = "1") Then
                        Dim siz = buttonsPressed.Count - 1
                        botao = "Buttton" & siz - i
                    End If
                Next
            End If
            AnimJoy(buttonsPressed, direcionaisVal)
            AnimJoy(buttonsPressed, direcionaisVal)
            AnimLeftAxis(.dwXpos, .dwYpos)
            AnimRightAxis(.dwZpos, .dwRpos)
        End With
        Return (botao)
    End Function

    Private Sub AnimJoy(ByVal bt As String, ByVal dir As Int32)
        bt = StrReverse(bt)
        A.Visible = bt(0) = "1"
        B.Visible = bt(1) = "1"
        X.Visible = bt(2) = "1"
        Y.Visible = bt(3) = "1"
        LB.Visible = bt(4) = "1"
        RB.Visible = bt(5) = "1"
        Options.Visible = bt(6) = "1"
        Start.Visible = bt(7) = "1"
        RT.Visible = bt(8) = "1"
        LT.Visible = bt(9) = "1"
        L3.Visible = bt(10) = "1"
        R3.Visible = bt(11) = "1"
        'PS.Visible = bt(12) = "1"
        'TrackPad.Visible = bt(13) = "1"
        dPadLeft.Visible = dir = 270
        dPadUp.Visible = dir = 0
        dPadRight.Visible = dir = 90
        DpadDown.Visible = dir = 180
    End Sub

    Private Sub AnimLeftAxis(ByVal x, ByVal y)
        leftAxis.Location = centerLeftAxis + New Point(x / 15, y / 15)
    End Sub

    Private Sub AnimRightAxis(ByVal x, ByVal y)
        rightAxis.Location = centerRightAxis + New Point(x / 15, y / 15)
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
        TesteJoytick.mySeetings.name = "DS4"
        TesteJoytick.mySeetings.anEsqXMin = TextBoxAnEsqMinX.Text
        TesteJoytick.mySeetings.anEsqXMax = TextBoxAnEsqMaxX.Text
        TesteJoytick.mySeetings.anEsqYMin = TextBoxAnEsqMinY.Text
        TesteJoytick.mySeetings.anEsqYMax = TextBoxAnEsqMaxY.Text
        TesteJoytick.mySeetings.anDirXMin = TextBoxAnDirMinX.Text
        TesteJoytick.mySeetings.anDirXMax = TextBoxAnDirMaxX.Text
        TesteJoytick.mySeetings.anDirYMin = TextBoxAnDirMinY.Text
        TesteJoytick.mySeetings.anDirYMax = TextBoxAnDirMaxY.Text
        TesteJoytick.mySeetings.gatEsqMin = TextBoxGatilhoEsqMin.Text
        TesteJoytick.mySeetings.gatEsqMax = TextBoxGatilhoEsqMax.Text
        TesteJoytick.mySeetings.gatDirMin = TextBoxGatilhoDirMin.Text
        TesteJoytick.mySeetings.gatDirMax = TextBoxGatilhoDirMax.Text
    End Sub

    Public Sub loadValues()
        TesteJoytick.TextBox1.Text = TesteJoytick.mySeetings.port
        TextBoxAnEsqMinX.Text = TesteJoytick.mySeetings.anEsqXMin
        TextBoxAnEsqMaxX.Text = TesteJoytick.mySeetings.anEsqXMax
        TextBoxAnEsqMinY.Text = TesteJoytick.mySeetings.anEsqYMin
        TextBoxAnEsqMaxY.Text = TesteJoytick.mySeetings.anEsqYMax
        TextBoxAnDirMinX.Text = TesteJoytick.mySeetings.anDirXMin
        TextBoxAnDirMaxX.Text = TesteJoytick.mySeetings.anDirXMax
        TextBoxAnDirMinY.Text = TesteJoytick.mySeetings.anDirYMin
        TextBoxAnDirMaxY.Text = TesteJoytick.mySeetings.anDirYMax
        TextBoxGatilhoEsqMin.Text = TesteJoytick.mySeetings.gatEsqMin
        TextBoxGatilhoEsqMax.Text = TesteJoytick.mySeetings.gatEsqMax
        TextBoxGatilhoDirMin.Text = TesteJoytick.mySeetings.gatDirMin
        TextBoxGatilhoDirMax.Text = TesteJoytick.mySeetings.gatDirMax
    End Sub

    Private Sub ButtonAplicar_Click(sender As Object, e As EventArgs) Handles ButtonAplicar.Click
        SaveValues()
    End Sub
End Class
