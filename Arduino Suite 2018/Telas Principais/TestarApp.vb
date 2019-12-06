Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class TestarApp
    Dim tamInicial As Size
    Dim fileControl As New FileVarSystem
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
        telas.AddRange(System.IO.File.ReadAllLines(pathLista))
        WindowState = FormWindowState.Maximized
        AbrirTela(telas(0))
        InitJoy()
    End Sub

    'AÇÕES CONTROLES

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
                        End If
                    End If
                Next
            End If
        End If
        leituraAnterior = leituraJoy
    End Sub

    Function ReadJoy()
        ' Get the joystick information
        Dim botao As String = "NONE"
        Call joyGetPosEx(joySeetings.port, myjoyEX)
        With myjoyEX
            If (joyPadType = 1) Then
                leftAnalogXVal = (.dwXpos / 65535) * (TesteJoytick.mySeetings.anEsqXMax - TesteJoytick.mySeetings.anEsqXMin) + TesteJoytick.mySeetings.anEsqXMin
                leftAnalogYVal = (.dwYpos / 65535) * (TesteJoytick.mySeetings.anEsqYMax - TesteJoytick.mySeetings.anEsqYMin) + TesteJoytick.mySeetings.anEsqYMin
                rightAnalogXVal = (.dwZpos / 65535) * (TesteJoytick.mySeetings.anDirXMax - TesteJoytick.mySeetings.anDirXMin) + TesteJoytick.mySeetings.anDirXMin
                rightAnalogYVal = (.dwRpos / 65535) * (TesteJoytick.mySeetings.anDirYMax - TesteJoytick.mySeetings.anDirYMin) + TesteJoytick.mySeetings.anDirYMin
                gatilhoDireitoVal = (.dwUpos / 65535) * (TesteJoytick.mySeetings.gatEsqMax - TesteJoytick.mySeetings.gatEsqMin) + TesteJoytick.mySeetings.gatEsqMin
                gatilhoEsquerdoVal = (.dwVpos / 65535) * (TesteJoytick.mySeetings.gatDirMax - TesteJoytick.mySeetings.gatDirMin) + TesteJoytick.mySeetings.gatDirMin
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
                gatilhoDireitoVal = (auxGatDir / 32740) * (joySeetings.gatEsqMax - joySeetings.gatEsqMin) + joySeetings.gatEsqMin
                gatilhoEsquerdoVal = (auxGatEsq / 32740) * (joySeetings.gatDirMax - joySeetings.gatDirMin) + joySeetings.gatDirMin
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
    Private Sub Comando_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keyPressed = e.KeyCode
        For Each element In PanelComando.Controls
            If (element.GetType() = GetType(ControleInterface)) Then
                If (element.engine.HotKey = e.KeyCode.ToString) Then
                    element.BtPressed()
                End If
            End If
        Next
    End Sub

    Private Sub Comando_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        For Each element In PanelComando.Controls
            If (element.GetType() = GetType(ControleInterface)) Then
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
            End If
        Next
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
    End Sub

    Private Sub Comando_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For Each control In Me.PanelComando.Controls
            If (control.GetType() = GetType(ControleInterface) And control.Visible) Then
                If (control.engine.tipo = "Câmera IP") Then
                    control.VideoSourcePlayer.SignalToStop()
                End If
            End If
            PanelComando.Controls.Remove(control)
            control.dispose()
        Next
        If appProgrammingMethod = "Avançado" Then
            startAvancado()
        Else
            startNormal()
        End If

    End Sub

    Private Sub startAvancado()
        For Each control In ComandoAvancado.PanelComando.Controls
            If (control.GetType() = GetType(ControleHardware) And control.Visible) Then
                If (control.engine.tipo = "Câmera IP") Then
                    control.VideoSourcePlayer.Start()
                End If
            End If
        Next
    End Sub

    Private Sub startNormal()
        For Each control In Comando.PanelComando.Controls
            If (control.GetType() = GetType(ControleHardware) And control.Visible) Then
                If (control.engine.tipo = "Câmera IP") Then
                    control.VideoSourcePlayer.Start()
                End If
            End If
        Next
    End Sub

    'TELA:
    Public telas As New List(Of String)
    Public telaAberta As Int16
    Public pathTela As String = ""
    Public pathEntradas As String = ""
    Public pathSaidas As String = ""
    Public pathEntradasAnalogicas As String = ""

    Public Sub SalvarDados()
        SalvarComponentes()
    End Sub

    Public Sub AbrirTela(nome As String)
        Dim sizeString As String = ""
        pathTela = applicationDirectory & "\Comando\" & nome
        fileControl.SetFilePath(pathTela & "\" & nome & ".tela")
        fileControl.LoadVar("Size", sizeString)
        Dim tamInicial = PanelComando.Size
        If sizeString <> "" Then
            PanelComando.Size = ConvertStringToSize(sizeString)
        End If
        telaAberta = telas.IndexOf(nome)
        Text = "TesteApp <" & AppName & "> " & nome
        While PanelComando.Controls.Count > 0
            For Each control In PanelComando.Controls
                If (control.GetType() = GetType(ControleInterface) And control.Visible) Then
                    If (control.engine.tipo = "Câmera IP") Then
                        control.VideoSourcePlayer.SignalToStop()
                    End If
                End If
                PanelComando.Controls.Remove(control)
                control.dispose()
            Next
        End While
        PosicionaComponentes(nome)
        PanelComando.Size = tamInicial
    End Sub

    Private Function ConvertStringToSize(stringPoint As String)
        Dim valorPonto As String = stringPoint.Replace("{Width=", "")
        valorPonto = valorPonto.Replace("Height=", "")
        valorPonto = valorPonto.Replace("}", "")
        Try
            Dim size As New Size(valorPonto.Split(",")(0), valorPonto.Split(",")(1))
            Return (size)
        Catch ex As Exception
            MessageBox.Show("Erro ao configurar o tamanho do componente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return (New Size(100, 100))
        End Try
    End Function

    Sub PosicionaComponentes(nome As String)
        Dim fileName As String = pathTela & "\Componentes.inf"
        If (My.Computer.FileSystem.FileExists(fileName)) Then
            Dim dados() As String = System.IO.File.ReadAllLines(fileName)
            For Each line In dados
                Dim novoComponente As New ControleInterface
                novoComponente.engine.loadFromString(line)
                novoComponente.engine.updateInterface(novoComponente)
                PanelComando.Controls.Add(novoComponente)
            Next
        End If
    End Sub

    Private Sub ContextMenuStripOptions_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStripOptions.Opening
        If (joyPadOn = True) Then
            AtivadoToolStripMenuItem1.Image = My.Resources.Enabled
            DesativadoToolStripMenuItem1.Image = Nothing
        End If
        If (joyPadOn = False) Then
            DesativadoToolStripMenuItem1.Image = My.Resources.Disabled
            AtivadoToolStripMenuItem1.Image = Nothing
        End If
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

    Private Sub FecharAplicaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharAplicaçãoToolStripMenuItem.Click
        If DruidaSuiteMain.COMPort.IsOpen Then
            DruidaSuiteMain.PictureBoxConectar_Click(sender, e)
        End If
        Close()
    End Sub

    Private Sub SelecionarPortaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarPortaToolStripMenuItem.Click
        'Conectar.Show()
    End Sub

    Private Sub ConectarDesconectarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarDesconectarToolStripMenuItem.Click
        DruidaSuiteMain.PictureBoxConectar_Click(sender, e)
    End Sub

    Private Sub AlarmesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlarmesToolStripMenuItem.Click
        Alarmes.Show()
    End Sub
End Class