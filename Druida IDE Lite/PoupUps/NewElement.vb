Public Class NewElement
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewElement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbName_MouseDown(sender As Object, e As MouseEventArgs) Handles tbName.MouseDown
        tbName.SelectAll()
    End Sub
End Class