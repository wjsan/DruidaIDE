Imports Druida_IDE_Lite
Public Class SoftwareInterface

    Public Sub CloseSerialPorts()
        If DruidaSuiteMain.COMPort.IsOpen Then
            DruidaSuiteMain.StopRede()
            DruidaSuiteMain.COMPort.Close()
        End If
    End Sub
End Class
