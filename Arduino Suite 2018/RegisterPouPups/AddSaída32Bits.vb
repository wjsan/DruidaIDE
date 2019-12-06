Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class AddSaída32Bits
    Private eqPos As Byte = 0
    Public local As Point
    Public ref As New ControleHardware
    Dim joy As String = ""
    Dim joyAnt As String = ""
    Dim textoAnterior As New List(Of String)
    Dim leftAnalogXVal As Int16
    Dim leftAnalogYVal As Int16
    Dim rightAnalogXVal As Int16
    Dim rightAnalogYVal As Int16
    Dim gatilhoDireitoVal As Int16
    Dim gatilhoEsquerdoVal As Int16
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

    Private Sub Adicionar_Saída_Analógica_Load(sender As Object, e As EventArgs) Handles Me.Load
        carregaDados()
        If joyPadOn Then
            myjoyEX.dwSize = 64
            myjoyEX.dwFlags = &HFF ' All information
            TimerLeituraJoy.Start()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Entrada Inativa", 0)
        PictureBox1.Image = Image.FromFile(fileName)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Entrada Ativa", 2)
        PictureBox2.Image = Image.FromFile(fileName)
    End Sub

    Public Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ref.engine.porta(0) = ComboBoxRegistrador.SelectedItem
        ref.engine.tipVisivel = CheckBoxPortaVisivel.Checked
        ref.engine.rotuloText = TextBoxRotulo.Text
        ref.engine.joyKey = ""
        ref.engine.scaleMax = TextBoxMax.Text
        ref.engine.scaleMin = TextBoxMin.Text
        Dim cont As Byte = 1
        For Each item In ListBoxComandos.Items
            ref.engine.joyKey += item
            If (item <> ListBoxComandos.Items(ListBoxComandos.Items.Count - 1)) Then
                ref.engine.joyKey += "|"
            End If
        Next
        If (Text <> "Propriedades") Then
            Dim novaEntrada As New ControleHardware
            novaEntrada.engine.UpdateDataFromControlData(ref.engine)
            GetLocal.Controls.Add(novaEntrada)
            novaEntrada.BringToFront()
            novaEntrada.engine.updateControl(novaEntrada)
            ref = New ControleHardware
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Text = "Adicionar Elemento"
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub carregaDados()
        ComboBoxRegistrador.Items.Clear()
        If numMaxRegs = 0 Then numMaxRegs = 10
        For i As Byte = 0 To numMaxRegs - 1
            ComboBoxRegistrador.Items.Add(i.ToString)
        Next
        If (Text <> "Propriedades") Then
            ref.engine.local = local
        End If
        If ref.engine.porta(0) <> "" Then
            ComboBoxRegistrador.SelectedItem = ref.engine.porta(0)
        End If
        CheckBoxPortaVisivel.Checked = ref.engine.tipVisivel
        TextBoxRotulo.Text = ref.engine.rotuloText
        Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
        PictureBox1.Image = Image.FromFile(path & ref.engine.imagens(0))
        PictureBox2.Image = Image.FromFile(path & ref.engine.imagens(1))
        TextBoxMax.Text = ref.engine.scaleMax
        TextBoxMin.Text = ref.engine.scaleMin
        If (ref.engine.joyKey <> "") Then
            Dim dados() As String = ref.engine.joyKey.Split("|")
            ListBoxComandos.Items.Clear()

            For Each element In dados
                ListBoxComandos.Items.Add(element)
            Next
        End If
    End Sub

    Private Sub ListBoxComandos_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBoxComandos.KeyDown
        Dim k As String = e.KeyCode.ToString
        If (k = "Add" Or k = "Subtract" Or k = "/" Or k = "*" And ListBoxComandos.SelectedIndex >= 0) Then
            If (k = "Add") Then
                Dim newItem As String = ListBoxComandos.SelectedItem.ToString.Replace("-", "+")
                ListBoxComandos.Items.Add(newItem)
                ListBoxComandos.Items.Remove(ListBoxComandos.SelectedItem)
                ListBoxComandos.SelectedItem = newItem
            End If
            If (k = "Subtract") Then
                Dim newItem As String = ListBoxComandos.SelectedItem.ToString.Replace("+", "-")
                ListBoxComandos.Items.Add(newItem)
                ListBoxComandos.Items.Remove(ListBoxComandos.SelectedItem)
                ListBoxComandos.SelectedItem = newItem
            End If
            If (k = "Multiply") Then
                'TextBoxExpressão.Text += "/"
            End If
            If (k = "Divide") Then
                'TextBoxExpressão.Text += "*"
            End If
            eqPos += 1
        End If
        If (k.ToString = "Delete") Then
            ListBoxComandos.Items.Remove(ListBoxComandos.SelectedItem)
        End If
    End Sub

    Private Sub TimerLeituraJoy_Tick(sender As Object, e As EventArgs) Handles TimerLeituraJoy.Tick
        Try
            joy = ReadJoy()
        Catch ex As Exception
            TimerLeituraJoy.Stop()
            MessageBox.Show("Erro de leitura no joystick. Verifique as configurações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If (joy <> "none" And joy <> joyAnt) And CheckBoxEdit.Checked Then
            ListBoxComandos.Items.Add(joy)
        End If
        Try
            leituraInstrucoes()
        Catch ex As Exception
            TimerLeituraJoy.Stop()
            MessageBox.Show("Erro de leitura no joystick: " & ex.ToString)
        End Try
        joyAnt = joy
    End Sub

    Private Sub leituraInstrucoes()
        Dim cont As Byte = 0
        TextBoxResultado.Text = 0
        ListBoxValores.Items.Clear()
        For Each line In ListBoxComandos.Items
            If (line <> "") Then
                Dim valor As Int16 = 0
                If (line.Remove(0, 1) = "leftAnalogXRight") Then
                    ListBoxValores.Items.Add(leftAnalogXVal)
                    valor = leftAnalogXVal
                End If
                If (line.Remove(0, 1) = "leftAnalogXLeft") Then
                    ListBoxValores.Items.Add(-leftAnalogXVal)
                    valor = -leftAnalogXVal
                End If
                If (line.Remove(0, 1) = "leftAnalogYUp") Then
                    ListBoxValores.Items.Add(line(leftAnalogYVal))
                    valor = leftAnalogYVal
                End If
                If (line.Remove(0, 1) = "leftAnalogYDown") Then
                    ListBoxValores.Items.Add(-leftAnalogYVal)
                    valor = -leftAnalogYVal
                End If
                If (line.Remove(0, 1) = "rightAnalogXLeft") Then
                    ListBoxValores.Items.Add(rightAnalogXVal)
                    valor = rightAnalogXVal
                End If
                If (line.Remove(0, 1) = "rightAnalogXRight") Then
                    ListBoxValores.Items.Add(rightAnalogXVal)
                    valor = rightAnalogXVal
                End If
                If (line.Remove(0, 1) = "rightAnalogYUp") Then
                    ListBoxValores.Items.Add(rightAnalogYVal)
                    valor = rightAnalogYVal
                End If
                If (line.Remove(0, 1) = "rightAnalogYDown") Then
                    ListBoxValores.Items.Add(-rightAnalogYVal)
                    valor = -rightAnalogYVal
                End If
                If (line.Remove(0, 1) = "gatilhoEsq") Then
                    ListBoxValores.Items.Add(gatilhoEsquerdoVal)
                    valor = gatilhoEsquerdoVal
                End If
                If (line.Remove(0, 1) = "gatilhoDir") Then
                    ListBoxValores.Items.Add(gatilhoDireitoVal)
                    valor = gatilhoDireitoVal
                End If
                If (line(0) = "+") Then TextBoxResultado.Text += valor
                If (line(0) = "-") Then TextBoxResultado.Text -= valor
                'TextBoxResultado.Text += valor
                If (TextBoxResultado.Text > 255) Then TextBoxResultado.Text = 255
                If (TextBoxResultado.Text < 0) Then TextBoxResultado.Text = 0
            End If
        Next
    End Sub

    Function ReadJoy()
        ' Get the joystick information
        Dim botao As String = ""
        Call joyGetPosEx(joySeetings.port, myjoyEX)
        With myjoyEX
            If (joyPadType = 1) Then
                leftAnalogXVal = (.dwXpos / 65535) * (joySeetings.anEsqXMax - joySeetings.anEsqXMin) + joySeetings.anEsqXMin
                leftAnalogYVal = (.dwYpos / 65535) * (joySeetings.anEsqYMax - joySeetings.anEsqYMin) + joySeetings.anEsqYMin
                rightAnalogXVal = (.dwZpos / 65535) * (joySeetings.anDirXMax - joySeetings.anDirXMin) + joySeetings.anDirXMin
                rightAnalogYVal = (.dwRpos / 65535) * (joySeetings.anDirYMax - joySeetings.anDirYMin) + joySeetings.anDirYMin
                gatilhoDireitoVal = (.dwUpos / 65535) * (joySeetings.gatDirMax - joySeetings.gatDirMin) + joySeetings.gatDirMin
                gatilhoEsquerdoVal = (.dwVpos / 65535) * (joySeetings.gatEsqMax - joySeetings.gatEsqMin) + joySeetings.gatEsqMin
            End If
            If (joyPadType = 0) Then
                Dim auxGatDir As Int16 = 0
                Dim auxGatEsq As Int16 = 0
                If .dwZpos < 32768 Then
                    auxGatDir = 32768 - .dwZpos
                    'auxGatEsq = 0
                Else
                    'auxGatDir = 0
                    auxGatEsq = .dwZpos - 32768
                End If
                leftAnalogXVal = (.dwXpos / 65535) * (joySeetings.anEsqXMax - joySeetings.anEsqXMin) + joySeetings.anEsqXMin
                leftAnalogYVal = (.dwYpos / 65535) * (joySeetings.anEsqYMax - joySeetings.anEsqYMin) + joySeetings.anEsqYMin
                rightAnalogXVal = (.dwUpos / 65535) * (joySeetings.anDirXMax - joySeetings.anDirXMin) + joySeetings.anDirXMin
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
            Dim codBotoesVal As UInt32 = .dwButtons
            Dim botoesPress As Int32 = .dwButtonNumber
            Dim direcionaisVal As UInt32 = (.dwPOV / 100)
            Dim buttonsPressed As String = Convert.ToString(CUInt(codBotoesVal), 2).PadLeft(14, "0")
            If joyPadType <> 2 Then
                botao = CheckJoyPress()
            Else
                botao = Checkg27()
            End If
            TextBoxBtPress.Text = botao
        End With
        Return (botao)
    End Function

    Private Function CheckJoyPress()
        Dim botao As String
        If (leftAnalogXVal = joySeetings.anEsqXMax) Then
            botao = "+leftAnalogXRight"
        ElseIf (leftAnalogXVal = joySeetings.anEsqXMin) Then
            botao = "+leftAnalogXLeft"
        ElseIf (leftAnalogYVal = joySeetings.anEsqYMin) Then
            botao = "+leftAnalogYUp"
        ElseIf (leftAnalogYVal = joySeetings.anEsqYMax) Then
            botao = "+leftAnalogYDown"
        ElseIf (rightAnalogXVal = joySeetings.anDirXMax) Then
            botao = "+rightAnalogXRight"
        ElseIf (rightAnalogXVal = joySeetings.anDirXMin) Then
            botao = "+rightAnalogXLeft"
        ElseIf (rightAnalogYVal = joySeetings.anDirYMin) Then
            botao = "+rightAnalogYUp"
        ElseIf (rightAnalogYVal = joySeetings.anDirYMax) Then
            botao = "+rightAnalogYDown"
        ElseIf (gatilhoDireitoVal = joySeetings.gatDirMax) Then
            botao = "+gatilhoDir"
        ElseIf (gatilhoEsquerdoVal = joySeetings.gatEsqMax) Then
            botao = "+gatilhoEsq"
        Else
            botao = "none"
        End If
        Return botao
    End Function

    Private Function Checkg27()
        Dim botao As String
        If (leftAnalogXVal = joySeetings.volanteMin) Then
            botao = "+leftAnalogXRight"
        ElseIf (leftAnalogXVal = joySeetings.volanteMax) Then
            botao = "+leftAnalogXLeft"
        ElseIf (leftAnalogYVal = joySeetings.aceleradorMin) Then
            botao = "+leftAnalogYUp"
        ElseIf (leftAnalogYVal = joySeetings.aceleradorMax) Then
            botao = "none"
        ElseIf (rightAnalogXVal = joySeetings.embreagemMin) Then
            botao = "+rightAnalogXRight"
        ElseIf (rightAnalogXVal = joySeetings.embreagemMax) Then
            botao = "none"
        ElseIf (rightAnalogYVal = joySeetings.freioMin) Then
            botao = "+rightAnalogYUp"
        ElseIf (rightAnalogYVal = joySeetings.freioMax) Then
            botao = "none"
        Else
            botao = "none"
        End If
        Return botao
    End Function

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        ListBoxComandos.Items.Clear()
        ListBoxValores.Items.Clear()
        textoAnterior.Clear()
        eqPos = 0
        joyAnt = ""
    End Sub
End Class
