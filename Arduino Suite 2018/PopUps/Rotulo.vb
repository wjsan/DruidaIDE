Imports System.Windows.Forms

Public Class Rotulo
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

    Private Sub Rotulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxTexto.Text = ref.engine.rotuloText
        LabelColor.Text = ref.engine.rotuloColor.Name
        LabelColor.BackColor = ref.engine.rotuloColor
    End Sub

    Private Sub TextBoxTexto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTexto.TextChanged
        ref.engine.rotuloText = TextBoxTexto.Text
    End Sub

    Private Sub LabelColor_Click(sender As Object, e As EventArgs) Handles LabelColor.Click
        ColorDialogRotulo.ShowDialog()
        ref.engine.rotuloColor = ColorDialogRotulo.Color
        LabelColor.Text = ref.engine.rotuloColor.Name
        LabelColor.BackColor = ref.engine.rotuloColor
    End Sub
End Class
