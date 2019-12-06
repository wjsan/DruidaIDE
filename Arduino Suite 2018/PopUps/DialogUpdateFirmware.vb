Imports System.Windows.Forms

Public Class DialogUpdateFirmware

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If (ListBoxSelecaoArduino.SelectedIndex = 0) Then GerenciamentoFirmware.EnviaFirmware("Arduino_NANO.ino.hex", "57600")
        If (ListBoxSelecaoArduino.SelectedIndex = 1) Then GerenciamentoFirmware.EnviaFirmware("Arduino_UNO.ino.hex", "115200")
        If (ListBoxSelecaoArduino.SelectedIndex = 2) Then GerenciamentoFirmware.EnviaFirmware("Arduino_MEGA.ino.hex", "115200")
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListBoxSelecaoArduino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSelecaoArduino.SelectedIndexChanged
        Dim path As String = applicationDirectory & "\Config Files"
        If (ListBoxSelecaoArduino.SelectedIndex = 0) Then
            PictureBoxArduino.Image = ArduinoSuite.My.Resources.Resources.Arduino_NANO

        End If
        If (ListBoxSelecaoArduino.SelectedIndex = 1) Then
            PictureBoxArduino.Image = ArduinoSuite.My.Resources.Resources.Arduino_UNO

        End If
        If (ListBoxSelecaoArduino.SelectedIndex = 2) Then
            PictureBoxArduino.Image = ArduinoSuite.My.Resources.Resources.Arduino_MEGA
        End If
    End Sub
End Class
