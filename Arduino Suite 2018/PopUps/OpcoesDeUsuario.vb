Imports System.Windows.Forms

Public Class OpcoesDeUsuario

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_Button.Click
        If loginNeeded Then
            userIsAdmin = False
            TelaDeLogon.Text = "LogOn - Remover Sistema"
            TelaDeLogon.ShowDialog()
            If userIsAdmin Then
                loginNeeded = False
                If (System.IO.File.Exists(applicationDirectory & "\LogInData.ini")) Then
                    System.IO.File.Delete(applicationDirectory & "\LogInData.ini")
                End If
            End If
        Else
            TelaDeLogon.Text = "LogOn - Criar Usuário"
            TelaDeLogon.ShowDialog()
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OpcoesDeUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If loginNeeded Then
            User_Button.Text = "Remover"
        Else
            User_Button.Text = "Criar"
        End If
    End Sub
End Class
