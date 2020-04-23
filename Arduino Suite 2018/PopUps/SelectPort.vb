Imports System.IO.Ports

Public Class SelectPort
    Private Sub SelectPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPort.Items.AddRange(SerialPort.GetPortNames())
        cbPort.SelectedItem = porta
        cbBaud.SelectedItem = velocidade
        If (porta = Nothing And cbPort.Items.Count > 0) Then
            cbPort.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPort.SelectedIndexChanged
        porta = cbPort.SelectedItem
    End Sub

    Private Sub cbBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBaud.SelectedIndexChanged
        velocidade = cbBaud.SelectedItem
    End Sub
End Class