Imports System.ComponentModel

Public Class SerialMonitorTool

    Private Sub SerialMonitorTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialMonitor.ApplyTheme()
        AppSystem.serialPort.SetSerialMonitor(SerialMonitor)
    End Sub

    Private Sub SerialMonitorTool_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'AppSystem.serialPort.Close()
        AppSystem.serialPort.SetSerialMonitor(controlConsole.SerialMonitor)
    End Sub
End Class