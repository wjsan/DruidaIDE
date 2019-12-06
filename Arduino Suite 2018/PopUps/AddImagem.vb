Imports System.Windows.Forms

Public Class AddImagem
    Public local As Point
    Public ref As New ControleHardware
    'Ações iniciais
    Private Sub Adicionar_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub PictureBoxSinalInativo_Click(sender As Object, e As EventArgs) Handles PictureBoxSinalInativo.Click
        Dim fileName As String
        fileName = ref.engine.setImageFile("Alterar Imagem", 0)
        PictureBoxSinalInativo.Image = Image.FromFile(fileName)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If (Text <> "Propriedades") Then
            Dim novaImagem As New ControleHardware
            novaImagem.engine.UpdateDataFromControlData(ref.engine)
            GetLocal.Controls.Add(novaImagem)
            novaImagem.engine.updateControl(novaImagem)
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
        If (Text <> "Propriedades") Then
            ref.engine.local = local
        End If
        Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
        PictureBoxSinalInativo.Image = Image.FromFile(path & ref.engine.imagens(0))
    End Sub
End Class
