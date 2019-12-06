Imports System.Windows.Forms

Public Class AddL298N

    Dim p() As String
    Public pins As String
    Public declaration As String = "L298N PonteH(ponteHpins);"

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        p = {tx1.Text,
             tx2.Text,
             tx3.Text,
             tx4.Text,
             tx5.Text,
             tx6.Text}
        pins = "byte ponteHpins[] = {" & p(0) & "," & p(1) & "," & p(2) & "," & p(3) & "," & p(4) & "," & p(5) & "};"
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
