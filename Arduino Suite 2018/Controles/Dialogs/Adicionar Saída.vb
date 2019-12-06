Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Adicionar_Saída
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
    Public local As Point
    Public ref As New ControleHardware
    'Ações iniciais
    Private Sub Adicionar_Saída_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerLeituraJoy.Enabled = joyPadOn
        carregaDados()
        InitJoy()
    End Sub

    Private Sub PictureBoxSaidaInativa_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalInativo.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Saida Inativa", 0)
        PictureBoxSinalInativo.Image = Image.FromFile(fileName)
    End Sub

    Private Sub PictureBoxSaidaAtiva_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalAtivo.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Saida Ativa", 1)
        PictureBoxSinalAtivo.Image = Image.FromFile(fileName)
    End Sub

    Private Sub PictureBoxSaidaAlarme_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalFalha.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Saida Alarme", 2)
        PictureBoxSinalFalha.Image = Image.FromFile(fileName)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        loadControl()
        If (Text <> "Propriedades") Then
            Dim novaSaida As New ControleHardware
            novaSaida.engine.UpdateDataFromControlData(ref.engine)
            GetLocal.Controls.Add(novaSaida)
            novaSaida.engine.updateControl(novaSaida)
            ref = New ControleHardware
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        TimerLeituraJoy.Enabled = False
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        TimerLeituraJoy.Enabled = False
        Me.Close()
    End Sub

    Function ReadJoy()
        'Get the joystick information
        If (ref.engine.joyKey = "") Then
            ref.engine.joyKey = "Nenhuma"
        End If
        Dim botao As String = ref.engine.joyKey
        Call joyGetPosEx(joySeetings.port, myjoyEX)
        With myjoyEX
            Dim codBotoesVal As UInt16 = .dwButtons
            Dim buttonsPressed As String = Convert.ToString(CUInt(codBotoesVal), 2).PadLeft(32, "0")
            For i = 0 To 31
                If (buttonsPressed(i) = "1") Then
                    botao = 31 - i
                End If
            Next
        End With
        Return (botao)
    End Function

    Sub InitJoy()
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF ' All information
        TimerLeituraJoy.Interval = 200  'Update at 5 hz
        TimerLeituraJoy.Start()
    End Sub

    Public Sub carregaDados()
        'getListaSaidas()
        ComboBoxSelecionaPorta.Items.Clear()
        With ref.engine
            For Each element In listaSaidas
                ComboBoxSelecionaPorta.Items.Add(element)
            Next
            If (Text <> "Propriedades") Then
                ComboBoxSelecionaPorta.SelectedIndex = 0
                .local = local
            Else
                ComboBoxSelecionaPorta.SelectedItem = .porta(0)
                TextBoxTeclaAtalho.Text = .hotKey
                TextBoxTeclaJoy.Text = .joyKey
            End If
            CheckBoxPortaVisivel.Checked = .tipVisivel
            TextBoxRotulo.Text = .rotuloText
            CheckBoxBotao1.Checked = .button1
            TextBoxBotao1.Text = .button1Text
            CheckBoxBotao2.Checked = .button2
            TextBoxBotao2.Text = .button2Text
            RadioButton2Bt.Checked = (.buttonMode = "on/off")
            RadioButtonPushButton.Checked = (.buttonMode = "pls")
            RadioButtonRet.Checked = (.buttonMode = "ret")
            Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
            PictureBoxSinalInativo.Image = Image.FromFile(path & .imagens(0))
            PictureBoxSinalAtivo.Image = Image.FromFile(path & .imagens(1))
            PictureBoxSinalFalha.Image = Image.FromFile(path & .imagens(2))
        End With
    End Sub

    Private Sub loadControl()
        With ref.engine
            .porta(0) = ComboBoxSelecionaPorta.SelectedItem
            .tipVisivel = CheckBoxPortaVisivel.Checked
            .rotuloText = TextBoxRotulo.Text
            .button1Text = TextBoxBotao1.Text
            .button2Text = TextBoxBotao2.Text
            .button1 = CheckBoxBotao1.Checked
            .button2 = CheckBoxBotao2.Checked
            .hotKey = TextBoxTeclaAtalho.Text
            .joyKey = TextBoxTeclaJoy.Text
            If (RadioButtonPushButton.Checked) Then .buttonMode = "pls"
            If (RadioButtonRet.Checked) Then .buttonMode = "ret"
            If (RadioButton2Bt.Checked) Then .buttonMode = "on/off"
        End With
    End Sub

    Private Sub SaidaDefault()
        With ref.engine
            .tipo = "Saida Digital"
            .rotuloText = "Saida Digital "
            .tipVisivel = True
            .canMove = True
            .imagens(0) = greenLedOff
            .imagens(1) = greenLedOn
            .imagens(2) = redLedOn
        End With
    End Sub

    Private Sub Adicionar_Saída_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        TextBoxTeclaAtalho.Text = e.KeyCode.ToString
        ref.engine.hotKey = e.KeyCode
    End Sub

    Private Sub TimerLeituraJoy_Tick(sender As Object, e As EventArgs) Handles TimerLeituraJoy.Tick
        TextBoxTeclaJoy.Text = ReadJoy()
        ref.engine.joyKey = TextBoxTeclaJoy.Text
    End Sub
End Class
