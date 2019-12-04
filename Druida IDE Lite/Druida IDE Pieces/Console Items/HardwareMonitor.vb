Imports Druida_IDE_Lite.IDEcfgs.Values
Imports DruidaIDEAuxiliarControls
Imports System.IO

Public Class HardwareMonitor
    Private Serial As New Ports.SerialPort
    WithEvents HardwareDb As New MyProtocols.BqBus(Serial)
    Private labelList() As Label
    Private labelAnList() As Label
    Private labelSelected As Label
    Private GraphsToUpdate As New List(Of Graph)

    Private Sub HardwareMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        tscbBaud.Items.AddRange(AppSystem.serialPort.baudRates)
        tscbBaud.SelectedItem = CurrentProjectCfgs.values.hardware.baudRate
        'HardwareDb.SetSerialMonitor(controlConsole.SerialMonitor.tbSerialMonitor)
        GetLabelList()
        TimerUpdateCOM.Start()
    End Sub

    Private Sub GetLabelList()
        labelList = {Port0, Port1, Port2, Port3, Port4, Port5, Port6, Port7, Port8, Port9, Port10, Port11, Port12, Port13, Port14, Port15, Port16, Port17, Port18, Port19, Port20,
                     Port21, Port22, Port23, Port24, Port25, Port26, Port27, Port28, Port29, Port30, Port31, Port32, Port33, Port34, Port35, Port36, Port37, Port38, Port39, Port40,
                     Port41, Port42, Port43, Port44, Port45, Port46, Port47, Port48, Port49, Port50, Port51, Port52, Port53, Port54, Port55, Port56, Port57, Port58, Port59, Port60,
                     Port61, Port62, Port63, Port64, Port65, Porta66, Porta67, Porta68, Porta69, Porta70, Porta71}
        labelAnList = {PortA0, PortA1, PortA2, PortA3, PortA4, PortA5, PortA6, PortA7, PortA8, PortA9, PortA10, PortA11, PortA12, PortA13, PortA14, PortA15, PortA16, PortA17,
                       PortA18, PortA19, PortA20, PortA21}
        For Each item As Label In labelList
            AddHandler item.MouseDown, AddressOf Port_MouseDown
            AddHandler item.MouseUp, AddressOf Port_MouseUp
            item.ContextMenuStrip = cmsHardware
        Next
        For Each item As Label In labelAnList
            AddHandler item.MouseDown, AddressOf Port_MouseDown
            item.ContextMenuStrip = cmsAnalogs
        Next
    End Sub

    Public Sub AppyTheme()
        tsHardwareMonitor.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsHardwareMonitor.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbBaud.BackColor = Color.FromArgb(CodeColors.BackColor)
        tscbPort.BackColor = Color.FromArgb(CodeColors.BackColor)
        tscbBaud.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbPort.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        gbHardwareMonitor.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Me.BackColor = Color.FromArgb(CodeColors.ControlsColor)
    End Sub

    Public Sub UpdateCOMports()
        Dim availabelPorts As List(Of String) = Ports.SerialPort.GetPortNames.ToList
        If availabelPorts.Count <> tscbPort.Items.Count Then
            tscbPort.Items.Clear()
            tscbPort.Items.AddRange(availabelPorts.ToArray)
        End If
        If Not tscbPort.DroppedDown Then
            tscbPort.SelectedItem = CurrentProjectCfgs.values.hardware.COMport
        End If
    End Sub

    Private Sub tscbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbPort.SelectedIndexChanged
        If Not Serial.IsOpen Then
            Serial.PortName = tscbPort.SelectedItem
        Else
            tscbPort.SelectedItem = Serial.PortName
            MessageBox.Show("O dispositivo está em uso!")
        End If
    End Sub

    Private Sub tscbBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbBaud.SelectedIndexChanged
        Serial.BaudRate = tscbBaud.SelectedItem
        CurrentProjectCfgs.values.hardware.baudRate = tscbBaud.SelectedItem
    End Sub

    Public Sub UpdateConectionStatus()
        Dim cultureResx As New CultureManager
        Static Dim connected As String = cultureResx.translateText("Conectado")
        Static Dim disconnected As String = cultureResx.translateText("Desconectado")
        tsbtConection.Checked = Serial.IsOpen
        If Serial.IsOpen Then
            tsbtConection.Image = My.Resources.Check_Marks
            tsbtConection.Text = connected
        Else
            tsbtConection.Image = My.Resources.Delete
            tsbtConection.Text = disconnected
        End If
    End Sub

    Private Sub tsbtConection_Click(sender As Object, e As EventArgs) Handles tsbtConection.Click
        If tsbtConection.Checked Then
            Application.DoEvents()
            HardwareDb.Interrupt()
            ClearLabels()
        Else
            If AppSystem.serialPort.IsOpen Then
                AppSystem.serialPort.Close()
            End If
            HardwareDb.Begin()
        End If
    End Sub

    Private Sub ClearLabels()
        For Each label As Label In labelList
            label.BackColor = Color.Gray
        Next
    End Sub

    Private Sub HardwareDb_DataReceived() Handles HardwareDb.DataReceived
        Dim nDat As UInt16 = HardwareDb.GetRegByte(1, 1)
        readDigitalPorts(nDat)
        readAnalogPorts(nDat)
        updateGraphs()
    End Sub

    Private Sub readDigitalPorts(nDat As UInt16)
        Dim regN As UInt16 = 0
        Dim bitN As UInt16 = 0
        Dim anPorts As Int16 = HardwareDb.GetRegsCount - (HardwareDb.GetRegAddres(nDat) + 3)
        For i = 0 To nDat
            If i < labelList.Count Then
                If Not tsbtReadDigitalAnalog.Checked Then
                    If i > nDat - anPorts Then
                        Exit Sub
                    End If
                End If
                HardwareDb.GetAddres(i, regN, bitN)
                regN += 2
                Dim status As Boolean = HardwareDb.GetRegBit(regN, bitN)
                UpdateLabel(labelList(i), status)
            End If
        Next
    End Sub

    Private Sub readAnalogPorts(start As UInt16)
        Dim lastReg As UInt16 = HardwareDb.GetRegsCount
        Dim startAddr As UInt16 = HardwareDb.GetRegAddres(start) + 2
        Dim cont As UInt16 = 0
        If lastReg > 1 Then
            For i = startAddr To lastReg - 2
                Dim value As String = HardwareDb.GetReg(i)
                UpdateAnalogLabel(labelAnList(cont), value)
                cont += 1
            Next
        End If
    End Sub

    Private Sub UpdateGraphs()
        For Each graph As Graph In GraphsToUpdate
            Try
                graph.Invoke(Sub()
                                 '                     'Try
                                 graph.UpdatePens()
                                 '                     'Catch ex As Exception

                                 '                     'End Try
                             End Sub)
            Catch ex As Exception
                GraphsToUpdate.Remove(graph)
                Exit For
            End Try
        Next
    End Sub

    Private Sub UpdateLabel(label As Label, status As Boolean)
        If status Then
            label.BackColor = Color.Green
        Else
            label.BackColor = Color.Red
        End If
    End Sub

    Private Sub UpdateAnalogLabel(label As Label, value As String)
        Try
            label.Invoke(Sub()
                             Try
                                 label.Text = value
                             Catch ex As Exception

                             End Try
                         End Sub)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimerUpdateCOM_Tick(sender As Object, e As EventArgs) Handles TimerUpdateCOM.Tick
        UpdateConectionStatus()
        UpdateCOMports()
    End Sub

    Private Sub SetPinStatus(pin As Byte, status As pinStatus)
        HardwareDb.SetRegByte(0, 0, pin)
        HardwareDb.SetRegByte(0, 1, status)
        HardwareDb.SetRegByte(1, 0, cmd.pinStatus)
    End Sub

    Private Sub SetPinMode(pin As Byte, mode As pinMode)
        HardwareDb.SetRegByte(0, 0, pin)
        HardwareDb.SetRegByte(0, 1, mode)
        HardwareDb.SetRegByte(1, 0, cmd.cfgPin)
    End Sub

    Enum pinStatus
        LOW
        HIGH
    End Enum

    Enum pinMode
        INPUT
        OUTPUT
        INPUT_PULLUP
    End Enum

    Enum cmd
        readPorts
        cfgPin
        pinStatus
        pinValue
    End Enum

    Private Sub Port_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            SetLabelPinStatus(sender, pinStatus.HIGH)
        End If
        If e.Button = MouseButtons.Right Then
            labelSelected = sender
        End If
    End Sub

    Private Sub Port_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            SetLabelPinStatus(sender, pinStatus.LOW)
        End If
    End Sub

    Private Sub SetLabelPinStatus(label As Label, status As pinStatus)
        Dim index = labelList.ToList.IndexOf(label)
        If index > -1 Then
            SetPinStatus(index, status)
        End If
    End Sub

    Private Sub SetLabelPinMode(label As Label, status As pinStatus)
        Dim index = labelList.ToList.IndexOf(label)
        If index > -1 Then
            SetPinMode(index, status)
        End If
    End Sub

    Private Sub TsmiForceOn_Click(sender As Object, e As EventArgs) Handles TsmiForceOn.Click
        SetLabelPinStatus(labelSelected, pinStatus.HIGH)
    End Sub

    Private Sub TsmiForceOff_Click(sender As Object, e As EventArgs) Handles TsmiForceOff.Click
        SetLabelPinStatus(labelSelected, pinStatus.LOW)
    End Sub

    Private Sub TsmiConfigAsInput_Click(sender As Object, e As EventArgs) Handles TsmiConfigAsInput.Click
        SetLabelPinMode(labelSelected, pinMode.INPUT)
    End Sub

    Private Sub TsmiConfigAsOutput_Click(sender As Object, e As EventArgs) Handles TsmiConfigAsOutput.Click
        SetLabelPinMode(labelSelected, pinMode.OUTPUT)
    End Sub

    Public Sub CloseSerialPort()
        HardwareDb.Interrupt()
    End Sub

    Private Sub tsbtReadDigitalAnalog_Click(sender As Object, e As EventArgs) Handles tsbtReadDigitalAnalog.Click
        If Not tsbtReadDigitalAnalog.Checked Then
            ClearLabels()
        End If
    End Sub

    Private Sub PlotarGráficoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlotarGráficoToolStripMenuItem.Click
        Dim newGraph As New Graph(HardwareDb)
        Dim name As String = "Porta " & labelSelected.Text
        Dim color As Color = Color.Blue
        Dim index = labelList.ToList.IndexOf(labelSelected)
        Dim reg As String = ""
        Dim bit As String = ""
        HardwareDb.GetAddres(index, reg, bit)
        newGraph.addPen(New Pen(name, color, reg + 2, bit))
        GraphsToUpdate.Add(newGraph)
        newGraph.CreateWindow()
    End Sub

    Private Sub tsmiPlotAnalog_Click(sender As Object, e As EventArgs) Handles tsmiPlotAnalog.Click
        Dim start As UInt16 = HardwareDb.GetRegByte(1, 1)
        Dim lastReg As UInt16 = HardwareDb.GetRegsCount
        Dim startAddr As UInt16 = HardwareDb.GetRegAddres(start) + 2
        Dim reg As UInt16 = startAddr + labelAnList.ToList.IndexOf(labelSelected)
        Dim bit As String = ""
        Dim newGraph As New Graph(HardwareDb)
        Dim name As String = "Port A" & labelAnList.ToList.IndexOf(labelSelected)
        Dim color As Color = Color.Blue
        Dim index = labelList.ToList.IndexOf(labelSelected)
        newGraph.addPen(New Pen(name, color, reg, bit))
        GraphsToUpdate.Add(newGraph)
        newGraph.CreateWindow()
    End Sub

    Private Sub adjustFontColors_CheckedChanged(sender As Object, e As EventArgs) Handles tsbtReadDigitalAnalog.CheckedChanged, tsbtConection.CheckedChanged
        If sender.Checked Then
            sender.ForeColor = Color.FromArgb(CodeColors.BackColor)
        End If
    End Sub

    Private Sub adjustFontColors_MouseEnter(sender As Object, e As EventArgs) Handles tsbtReadDigitalAnalog.MouseEnter, tsbtConection.MouseEnter
        sender.ForeColor = Color.FromArgb(CodeColors.BackColor)
    End Sub

    Private Sub adjustFontColors_MouseLeave(sender As Object, e As EventArgs) Handles tsbtReadDigitalAnalog.MouseLeave, tsbtConection.MouseLeave
        AdjustForeColor(sender)
    End Sub

    Private Shared Sub AdjustForeColor(sender As Object)
        If sender.Checked Then
            sender.ForeColor = Color.FromArgb(CodeColors.BackColor)
        Else
            sender.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        End If
    End Sub

End Class
