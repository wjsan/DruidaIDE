Public Class ConfiguraçõesHardware

    Private Sub ConfiguraçõesHardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomePortas1.LoadPortSeetings()
    End Sub

    Private Sub PictureBoxSalvar_Click(sender As Object, e As EventArgs) Handles PictureBoxSalvar.Click
        NomePortas1.SavePortSeetings()
    End Sub

    Private Sub PictureBoxLimpar_Click(sender As Object, e As EventArgs) Handles PictureBoxLimpar.Click
        If MessageBox.Show("Tem certeza que deseja limpar as configurações atuais?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            NomePortas1.LimparTudo()
        End If
    End Sub
End Class