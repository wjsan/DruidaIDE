Imports Druida_IDE_Lite.IDEcfgs.Values.SerialMonitor

Public Class SettingsSerialMonitor
    Private Sub SettingsSerialMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCFGs()
    End Sub

    Private Sub LoadCFGs()
        cbShowMessageOrigin.Checked = ShowMessageOrigin
        cbShowPCmessages.Checked = ShowPCmessages
        cbShowTime.Checked = ShowTime
        cbShowDate.Checked = ShowDate
    End Sub

    Private Sub cbShowMessageOrigin_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowMessageOrigin.CheckedChanged
        ShowMessageOrigin = cbShowMessageOrigin.Checked
    End Sub

    Private Sub cbShowPCmessages_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPCmessages.CheckedChanged
        ShowPCmessages = cbShowPCmessages.Checked
    End Sub

    Private Sub cbShowTime_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowTime.CheckedChanged
        ShowTime = cbShowTime.Checked
    End Sub

    Private Sub cbShowDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowDate.CheckedChanged
        ShowDate = cbShowDate.Checked
    End Sub
End Class
