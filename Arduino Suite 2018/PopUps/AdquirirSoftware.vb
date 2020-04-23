Imports System.Windows.Forms

Public Class AdquirirSoftware

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://binary-quantum.com/loja-druida-tools-suite/")
        DruidaSuiteMain.FecharApp()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DruidaSuiteMain.FecharApp()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub AdquirirSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DruidaSuiteMain.PictureBoxSalvar_Click(sender, e)
    End Sub
End Class
