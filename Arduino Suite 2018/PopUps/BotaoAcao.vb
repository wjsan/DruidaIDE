Imports System.Windows.Forms

Public Class BotaoAcao
    Public local As Point
    Public ref As New ControleHardware

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BotaoAcao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxSelecionaTela.Items.Clear
        For Each item In telas
            ComboBoxSelecionaTela.Items.Add(item)
        Next
        ComboBoxSelecionaTela.Items.Add("Sair da Aplicação")
        carregaDados()
    End Sub

    Private Sub carregaDados()
        If (Text <> "Propriedades") Then
            ref.engine.local = local
        End If
        TextBoxTexto.Text = ref.engine.button1Text
        If ref.engine.imagens(0) IsNot Nothing Then
            ComboBoxSelecionaTela.SelectedItem = ref.engine.imagens(0)
        End If
    End Sub

    Private Sub TextBoxTexto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTexto.TextChanged
        ref.engine.button1Text = TextBoxTexto.Text
    End Sub

    Private Sub ComboBoxSelecionaTela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelecionaTela.SelectedIndexChanged
        ref.engine.imagens(0) = ComboBoxSelecionaTela.SelectedItem
    End Sub
End Class
