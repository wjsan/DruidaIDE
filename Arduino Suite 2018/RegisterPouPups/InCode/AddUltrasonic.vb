Imports System.Windows.Forms

Public Class AddUltrasonic

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddUltrasonic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxRegister.Items.Clear()
        For i As UInt16 = 0 To numMaxRegs - 1
            ComboBoxRegister.Items.Add(i)
        Next
    End Sub

    Private Sub CheckBoxCriar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCriar.CheckedChanged
        ComboBoxRegister.Enabled = CheckBoxCriar.Checked
    End Sub
End Class
