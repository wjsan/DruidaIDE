Module GerenciamentoFirmware
    Public Sub EnviaFirmware(nome As String, velocidade As String)
        Dim myprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .RedirectStandardInput = True,
            .RedirectStandardOutput = True
        }
        Dim dirAVR As String = Application.StartupPath & "\bin"
        Dim dirFirm As String = Application.StartupPath & "\Firmwares\" & nome
        Dim dirConfig As String = Application.StartupPath & "\bin\avrdude.conf"
        Dim port As String = DruidaSuiteMain.COMPort.PortName
        autoConnect = False
        DruidaSuiteMain.COMPort.Close()
        StartInfo.UseShellExecute = False
        StartInfo.CreateNoWindow = False
        myprocess.StartInfo = StartInfo
        myprocess.Start()
        Dim SR As System.IO.StreamReader = myprocess.StandardOutput
        Dim SW As System.IO.StreamWriter = myprocess.StandardInput
        SW.WriteLine("cd " & dirAVR)
        If arduinoConfig <> 2 Then
            SW.WriteLine("avrdude -F -v -pm328p -carduino -P""" & port & """ -b""" & velocidade & """ -D -Uflash:w:""" & dirFirm & """:i -C""" & dirConfig & """")
        Else
            SW.WriteLine("avrdude -F -v -pm2560 -cwiring -P""" & port & """ -b""" & velocidade & """ -D -Uflash:w:""" & dirFirm & """:i -C""" & dirConfig & """")
        End If
        SW.Close()
        SR.Close()
    End Sub
End Module
