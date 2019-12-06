Imports System.ComponentModel

Public Class Ferramentas
    Private Sub Ferramentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisibilidadePaineis(arduinoType)
        VisibilidadeAnalogicas(arduinoType)
        VisibilidadePWM(arduinoType)
        visibilidadeEstados(arduinoType)
        AjustaTam(arduinoType)
        If (DruidaSuiteMain.COMPort.IsOpen And arduinoConfig <> 3) Then
            TimerAtualizaDados.Enabled = True
        Else

        End If
        TabControl.TabPages(0).Enabled = appProgrammingMethod <> "Avançado"
    End Sub

    Private Sub AjustaTam(tipo As Byte)
        If (tipo = 1) Then
            Me.Size = New Size(660, 400)
        End If
    End Sub

    Private Sub Ferramentas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TimerAtualizaDados.Enabled = False
    End Sub

    Private Sub TimerAtualizaDados_Tick(sender As Object, e As EventArgs) Handles TimerAtualizaDados.Tick
        If ((arduinoType = 0 Or arduinoType = 1) And appProgrammingMethod <> "Avançado") Then
            escreveTextBoxWord0(estadosWord0)
            escreveTextBoxWord1(estadosWord1)
            escreveTextBoxAnalogicasUNO(analogicas)
            escreveTextBoxPWMsUNO(pwm)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxMonitorSerialWrite.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxMonitorSerialRead.Text = ""
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        If Not (DruidaSuiteMain.COMPort.IsOpen) Then
            DruidaSuiteMain.COMPort.Open()
            portaAberta = True
        End If
        monitorSerialWrite(TextBoxEnviar.Text)
        If (TextBoxEnviar.Text = "r") Then
            Try
                TextBoxMonitorSerialRead.Text += DruidaSuiteMain.COMPort.ReadLine()
            Catch ex As Exception
                TextBoxMonitorSerialRead.Text += "Timeout Error" & vbCrLf
            End Try
        End If
        If Not (DruidaSuiteMain.TimerLeituraRede.Enabled) Then
            DruidaSuiteMain.COMPort.Close()
            portaAberta = False
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedIndex = 1 And Not DruidaSuiteMain.COMPort.IsOpen Then
            Try
                DruidaSuiteMain.COMPort.Open()
            Catch ex As Exception
                MessageBox.Show("Erro ao abrir a porta de comnicação.")
            End Try
        End If
    End Sub

End Class