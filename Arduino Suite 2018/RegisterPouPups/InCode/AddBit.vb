Imports System.ComponentModel
Imports System.Windows.Forms

Public Class AddBit

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddBit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If numMaxRegs = 0 Then
        '    Configurar_Registradores.ShowDialog()
        'End If
        GroupBoxAcionamento.Visible = Text = "Adicionar saída digital" Or Text = "Adicionar Bit de Memória"
        'GroupBoxMemory.Visible = Text = "Adicionar Bit de Memória"
        Dim reg As UInt16 = ComboBoxRegister.SelectedItem
        ComboBoxRegister.Items.Clear()
        For i As UInt16 = 0 To numMaxRegs - 1
            ComboBoxRegister.Items.Add(i)
        Next
        'ComboBoxSelecionaMemória.Items.Clear
        For i = 0 To RotulosMemorias.Count - 1
            If Not (EnderecosMemorias(i).Contains(",")) Then
                'ComboBoxSelecionaMemória.Items.Add(RotulosMemorias(i))
            End If
        Next
        ComboBoxRegister.SelectedItem = reg
    End Sub

    Private Sub AddBit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GroupBoxAcionamento.Visible = False
    End Sub

    Private Sub CheckBoxCriar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCriar.CheckedChanged
        ComboBoxRegister.Enabled = CheckBoxCriar.Checked
        ComboBoxSelecionaBit.Enabled = CheckBoxCriar.Checked
        GroupBoxAcionamento.Enabled = CheckBoxCriar.Checked
    End Sub

    Private Sub RadioButtonNenhum_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
