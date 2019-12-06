Imports System.Windows.Forms

Public Class Adicionar_Entrada
    Public local As Point
    Public ref As New ControleHardware
    'Ações iniciais
    Private Sub Adicionar_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub PictureBoxSinalInativo_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalInativo.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Saida Inativa", 0)
        PictureBoxSinalInativo.Image = Image.FromFile(fileName)
    End Sub

    Private Sub PictureBoxSinalAtivo_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalAtivo.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Saida Ativa", 1)
        PictureBoxSinalAtivo.Image = Image.FromFile(fileName)
    End Sub

    Private Sub PictureBoxSinalFalha_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalFalha.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem - Saida Alarme", 2)
        PictureBoxSinalFalha.Image = Image.FromFile(fileName)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ref.engine.porta(0) = ComboBoxSelecionaPorta.SelectedItem
        ref.engine.tipVisivel = CheckBoxPortaVisivel.Checked
        ref.engine.rotuloText = TextBoxRotulo.Text
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
        'getListaEntradas()
        ComboBoxSelecionaPorta.Items.Clear()
        With ref.engine
            For Each element In listaEntradas
                ComboBoxSelecionaPorta.Items.Add(element)
            Next
            If (Text <> "Propriedades") Then
                ComboBoxSelecionaPorta.SelectedIndex = 0
                .local = local
            Else
                ComboBoxSelecionaPorta.SelectedItem = .porta(0)
            End If
            CheckBoxPortaVisivel.Checked = .tipVisivel
            TextBoxRotulo.Text = .rotuloText
            Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
            PictureBoxSinalInativo.Image = Image.FromFile(path & .imagens(0))
            PictureBoxSinalAtivo.Image = Image.FromFile(path & .imagens(1))
            PictureBoxSinalFalha.Image = Image.FromFile(path & .imagens(2))
        End With
    End Sub
End Class
