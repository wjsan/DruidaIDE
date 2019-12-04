Imports System.IO.Ports
Imports Druida_IDE_Lite.IDEcfgs

Module MySystemInfo
    ''' <summary>
    ''' Management of systems operations
    ''' </summary>
    Public AppSystem As New SystemOperations
End Module

Public Class SystemOperations
    Public serialPort As MySerialPort

    Public Sub New()
        serialPort = New MySerialPort(New SerialPort, controlConsole)
    End Sub

    Class MySerialPort
        Private serialPort As SerialPort
        Private availablePorts As New List(Of String)
        Private mySerialMonitor As SerialMonitor
        Private myErrorsList As ErrorsList

        Public ReadOnly baudRates() As String =
        {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"
        }

        Public Sub New(port As SerialPort, console As myConsole)
            serialPort = port
            serialPort.ReadTimeout = 500
            serialPort.WriteTimeout = 500
            availablePorts.Clear()
            availablePorts.AddRange(SerialPort.GetPortNames)
            mySerialMonitor = console.SerialMonitor
            myErrorsList = console.ErrorsList
            'AddHandler serialPort.DataReceived, AddressOf serialPort_DataReceived
        End Sub

        Public Sub SetSerialMonitor(serialMonitor As SerialMonitor)
            mySerialMonitor = serialMonitor
        End Sub

        Public Sub CheckForDeviceChanges()
            CheckAvailableDevices()
            Static Dim previous As Short = availablePorts.Count
            If availablePorts.Count > previous Then
                Notify.Show("Dispositivo detectado na porta " & availablePorts.Last,
                            My.Resources.USB_On, 1.5)
                previous = availablePorts.Count
                UpdateCurrentPort()
            End If
            If availablePorts.Count < previous Then
                Notify.Show("Dispositivo desconectado", My.Resources.USB_Off, 1.5)
                previous = availablePorts.Count
                UpdateCurrentPort()
            End If
            mySerialMonitor.UpdateConectionStatus()
        End Sub

        Private Sub UpdateCurrentPort()
            Dim currentPort = CurrentProjectCfgs.values.hardware.COMport
            If (currentPort = "" Or Not availablePorts.Contains(currentPort)) And availablePorts.Count > 0 Then
                CurrentProjectCfgs.values.hardware.COMport = availablePorts.Last
            End If
        End Sub

        Public Sub UpdateComboBox(ByRef cb As Object)
            Dim availabelPorts As List(Of String) = AppSystem.serialPort.GetAvailablePorts
            If availabelPorts.Count <> cb.Items.Count Then
                cb.Items.Clear()
                cb.Items.AddRange(availabelPorts.ToArray)
            End If
            If Not cb.DroppedDown Then
                cb.SelectedItem = CurrentProjectCfgs.values.hardware.COMport
            End If
        End Sub

        Public Sub CheckAvailableDevices()
            availablePorts.Clear()
            availablePorts.AddRange(SerialPort.GetPortNames)
        End Sub

        Public Function GetAvailablePorts() As List(Of String)
            Return availablePorts
        End Function

        Public Sub SetCOMport(ByVal portName As String)
            Dim needReOpen As Boolean = False
            If serialPort.IsOpen Then
                serialPort.Close()
                needReOpen = True
            End If
            Try
                serialPort.PortName = portName
                CurrentProjectCfgs.values.hardware.COMport = portName
                If needReOpen Then
                    serialPort.Open()
                End If
            Catch ex As Exception
                controlConsole.tcConsole.SelectedIndex = 1
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "AppSystem", "")
            End Try
        End Sub

        Public Sub SetBaudRate(ByVal baudRate As String)
            Try
                serialPort.BaudRate = baudRate
            Catch ex As Exception
                controlConsole.tcConsole.SelectedIndex = 1
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "AppSystem", "")
            End Try
        End Sub

        Public Sub Open()
            If Not serialPort.IsOpen Then
                Try
                    AddHandler serialPort.DataReceived, AddressOf serialPort_DataReceived
                    serialPort.Open()
                Catch ex As Exception
                    For Each tab As TabPage In controlConsole.tcConsole.TabPages
                        If tab.Name = "tpErrors" Then controlConsole.tcConsole.SelectedTab = tab
                    Next
                    consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "AppSystem", "")
                End Try
            End If
        End Sub

        Public Sub Close()
            If serialPort.IsOpen Then
                Try
                    RemoveHandler serialPort.DataReceived, AddressOf serialPort_DataReceived
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1000)
                    serialPort.Close()
                Catch ex As Exception
                    controlConsole.tcConsole.SelectedIndex = 1
                    consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "AppSystem", "")
                End Try
            End If
            Dim i As UInt16
            i = 10
        End Sub

        Public Function IsOpen()
            Return serialPort.IsOpen
        End Function

        Private Sub serialPort_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
            Dim leitura As String = ""
            If serialPort.IsOpen Then
                If NeedToShowOrigin() Then
                    Try
                        leitura = GetMessageOrigin("PLACA") & serialPort.ReadLine & vbCrLf
                    Catch ex As Exception
                        myErrorsList.Invoke(Sub()
                                                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, " Erro na leitura da porta Serial:" & ex.Message, "SerialMonitor", "")
                                                consoleErrors.AddItem(ErrorsManager.Type.msgInfo, " Verifique as configurações de leitura do Serial Monitor, desabilite todas as opções. ", "SerialMonitor", "")
                                                consoleErrors.AddItem(ErrorsManager.Type.msgInfo, " Caso voce queira utilizar o data logger, certifique-se de utilizar o método Serial.println() no código do Arduino. ", "SerialMonitor", "")
                                            End Sub)
                        leitura = serialPort.ReadExisting
                        AppendMessage(leitura)
                    End Try
                Else
                    Try
                        leitura = serialPort.ReadExisting
                    Catch ex As Exception
                        myErrorsList.Invoke(Sub()
                                                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, " Erro na leitura da porta Serial:" & ex.Message, "SerialMonitor", "")
                                            End Sub)
                        leitura = serialPort.ReadExisting
                        AppendMessage(leitura)
                    End Try
                End If
                AppendMessage(leitura)
            End If
        End Sub

        Public Sub Write(text As String)
            If serialPort.IsOpen Then
                serialPort.Write(text)
                If NeedToShowOrigin() Then
                    text = GetMessageOrigin("PC") & text
                End If
                AppendMessage(text)
            End If
        End Sub

        Private Sub AppendMessage(text As String)
            Try
                mySerialMonitor.tbSerialMonitor.Invoke(Sub()
                                                           Try
                                                               mySerialMonitor.AppendText(text)
                                                           Catch ex As Exception

                                                           End Try
                                                       End Sub)
            Catch ex As Exception

            End Try
            'SerialMonitorTool.SerialMonitor.Invoke(Sub()
            '                                           SerialMonitorTool.SerialMonitor.AppendText(text)
            '                                       End Sub)
        End Sub

        Public Function NeedToShowOrigin() As Boolean
            If Values.SerialMonitor.ShowMessageOrigin Then Return True
            If Values.SerialMonitor.ShowDate Then Return True
            If Values.SerialMonitor.ShowTime Then Return True
            Return False
        End Function

        Public Function GetMessageOrigin(origin As String) As String
            GetMessageOrigin = ""
            If Values.SerialMonitor.ShowMessageOrigin Then
                GetMessageOrigin &= "<" & origin & "> - "
            End If
            If Values.SerialMonitor.ShowDate Then
                GetMessageOrigin &= Date.Now.Date.Date & " - "
            End If
            If Values.SerialMonitor.ShowTime Then
                GetMessageOrigin &= TimeOfDay.ToString("h:mm:ss tt") & " - "
            End If
            Return GetMessageOrigin
        End Function
    End Class
End Class
