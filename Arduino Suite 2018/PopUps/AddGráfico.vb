Imports System.Windows.Forms

Public Class AddGráfico
    Public local As Point
    Public ref As New ControleHardware

    Private Sub Adicionar_Entrada_Analógica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ref.engine.porta(0) = ComboBoxSelecionaPorta.SelectedItem
        ref.engine.porta(1) = ComboBoxSelecionaPorta1.SelectedItem
        ref.engine.porta(2) = ComboBoxSelecionaPorta2.SelectedItem
        ref.engine.tipVisivel = CheckBoxPortaVisivel.Checked
        ref.engine.rotuloText = TextBoxRotulo.Text
        ref.engine.hotKey = TextBoxRotulo1.Text
        ref.engine.joyKey = TextBoxRotulo2.Text
        ref.engine.scaleMin = TextBoxMin.Text
        ref.engine.scaleMax = TextBoxMax.Text
        ref.engine.unit = TextBoxUnit.Text
        If (Text <> "Propriedades") Then
            Dim novaEntrada As New ControleHardware
            novaEntrada.engine.UpdateDataFromControlData(ref.engine)
            GetLocal.Controls.Add(novaEntrada)
            novaEntrada.engine.updateControl(novaEntrada)
            ref = New ControleHardware
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub carregaDados()
        ComboBoxSelecionaPorta.Items.Clear()
        ComboBoxSelecionaPorta1.Items.Clear()
        ComboBoxSelecionaPorta2.Items.Clear()
        If appProgrammingMethod <> "Avançado" Then
            'getListaEntradasAnalogicas()
            For Each element In listaEntradasAnalogicas
                ComboBoxSelecionaPorta.Items.Add("A" & element)
                ComboBoxSelecionaPorta1.Items.Add("A" & element)
                ComboBoxSelecionaPorta2.Items.Add("A" & element)
            Next
        Else
            Label2.Text = "Reg:"
            For i = 0 To numMaxRegs - 1
                ComboBoxSelecionaPorta.Items.Add(i.ToString)
                ComboBoxSelecionaPorta1.Items.Add(i.ToString)
                ComboBoxSelecionaPorta2.Items.Add(i.ToString)
            Next
        End If
        If (Text <> "Propriedades") Then
            ComboBoxSelecionaPorta.SelectedIndex = 0
            ref.engine.local = local
            TextBoxMin.Text = 0
            TextBoxMax.Text = 1023
        Else
            ComboBoxSelecionaPorta.SelectedItem = ref.engine.porta(0)
            TextBoxMin.Text = ref.engine.scaleMin
            TextBoxMax.Text = ref.engine.scaleMax
            TextBoxUnit.Text = ref.engine.unit
        End If
        ComboBoxSelecionaPorta.SelectedItem = ref.engine.porta(0)
        ComboBoxSelecionaPorta1.SelectedItem = ref.engine.porta(1)
        ComboBoxSelecionaPorta2.SelectedItem = ref.engine.porta(2)
        CheckBoxPortaVisivel.Checked = ref.engine.tipVisivel
        TextBoxRotulo.Text = ref.engine.rotuloText
        TextBoxRotulo1.Text = ref.engine.hotKey
        TextBoxRotulo2.Text = ref.engine.joyKey
    End Sub

End Class
