Imports System.Windows.Forms

Public Class Adicionar_Entrada_Analógica
    Public local As Point
    Public ref As New ControleHardware

    Private Sub Adicionar_Entrada_Analógica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
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

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ref.ScaleBargraph(1024)
        ref.engine.porta(0) = ComboBoxSelecionaPorta.SelectedItem
        ref.engine.tipVisivel = CheckBoxPortaVisivel.Checked
        ref.engine.rotuloText = TextBoxRotulo.Text
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
        'getListaEntradasAnalogicas()
        ComboBoxSelecionaPorta.Items.Clear()
        For Each element In listaEntradasAnalogicas
            ComboBoxSelecionaPorta.Items.Add("A" & element)
        Next
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
        CheckBoxPortaVisivel.Checked = ref.engine.tipVisivel
        TextBoxRotulo.Text = ref.engine.rotuloText
        Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
        PictureBox1.Image = Image.FromFile(path & ref.engine.imagens(0))
        PictureBox2.Image = Image.FromFile(path & ref.engine.imagens(2))
    End Sub
End Class
