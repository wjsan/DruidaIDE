Imports Druida_IDE_Lite.IDEcfgs.Values
Imports System.IO

Public Class SerialMonitor
    Private finalizer As String = ""

    Private Sub SerialMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        tscbBaud.Items.AddRange(AppSystem.serialPort.baudRates)
        tscbBaud.SelectedItem = CurrentProjectCfgs.values.hardware.baudRate
        tscbFinalizer.SelectedItem = CurrentProjectCfgs.values.hardware.finalizer
        tsbtAutoClear.Checked = IDEcfgs.Values.SerialMonitor.ClearOnEnter
    End Sub

    Public Sub ApplyTheme()
        Dim fontName As FontFamily = IDEcfgs.GetFontFamily(TextEditor.fontFamily)
        Dim fontStyle As New FontStyle
        Dim fontSize = TextEditor.fontSize
        Dim font As New Font(fontName, fontSize, FontStyle)
        tbSerialInput.BackColor = Color.FromArgb(CodeColors.BackColor)
        tbSerialInput.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tbSerialMonitor.BackColor = Color.FromArgb(CodeColors.BackColor)
        tbSerialMonitor.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tbSerialMonitor.Font = font
        btSend.BackColor = Color.FromArgb(CodeColors.BackColor)
        btSend.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsSerialMonitor.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsSerialMonitor.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbBaud.BackColor = Color.FromArgb(CodeColors.BackColor)
        tscbFinalizer.BackColor = Color.FromArgb(CodeColors.BackColor)
        tscbPort.BackColor = Color.FromArgb(CodeColors.BackColor)
        tscbBaud.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbFinalizer.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbPort.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub

    Public Sub UpdateCOMports()
        AppSystem.serialPort.UpdateComboBox(tscbPort)
    End Sub

    Private Sub tscbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbPort.SelectedIndexChanged
        AppSystem.serialPort.SetCOMport(tscbPort.SelectedItem)
    End Sub

    Private Sub tscbBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbBaud.SelectedIndexChanged
        AppSystem.serialPort.SetBaudRate(tscbBaud.SelectedItem)
        CurrentProjectCfgs.values.hardware.baudRate = tscbBaud.SelectedItem
    End Sub

    Public Sub AppendText(text As String)
        If tsbtAutoScroll.Checked Then
            tbSerialMonitor.AppendText(text)
        Else
            Dim cursor = tbSerialMonitor.SelectionStart
            tbSerialMonitor.Text &= text
            tbSerialMonitor.SelectionStart = cursor
            tbSerialMonitor.ScrollToCaret()
        End If
    End Sub

    Public Sub UpdateConectionStatus()
        Dim cultureResx As New CultureManager
        Static Dim connected As String = cultureResx.translateText("Conectado")
        Static Dim disconnected As String = cultureResx.translateText("Desconectado")
        tsbtConection.Checked = AppSystem.serialPort.IsOpen
        If AppSystem.serialPort.IsOpen Then
            tsbtConection.Image = My.Resources.Check_Marks
            tsbtConection.Text = connected
        Else
            tsbtConection.Image = My.Resources.Delete
            tsbtConection.Text = disconnected
        End If
    End Sub

    Private Sub tsbtConection_Click(sender As Object, e As EventArgs) Handles tsbtConection.Click
        If tsbtConection.Checked Then
            AppSystem.serialPort.Close()
        Else
            AppSystem.serialPort.Open()
        End If
    End Sub

    Private Sub tscbFinalizer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFinalizer.SelectedIndexChanged
        CurrentProjectCfgs.values.hardware.finalizer = tscbFinalizer.SelectedItem
        Select Case tscbFinalizer.SelectedIndex
            Case 0
                finalizer = ""
            Case 1
                finalizer = vbLf
            Case 2
                finalizer = vbCr
            Case 3
                finalizer = vbCrLf
            Case Else
                finalizer = ""
        End Select
    End Sub

    Private Sub btSend_Click(sender As Object, e As EventArgs) Handles btSend.Click
        AppSystem.serialPort.Write(tbSerialInput.Text & finalizer)
        If tsbtAutoClear.Checked Then
            tbSerialInput.Clear()
        End If
    End Sub

    Private Sub tsbtClearSerial_Click(sender As Object, e As EventArgs) Handles tsbtClearSerial.Click
        Dim cultureResx As New CultureManager
        Dim r = MessageBox.Show(cultureResx.translateText("Tem certeza que deseja limpar?"),
                                cultureResx.translateText("Clear"),
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            tbSerialMonitor.Clear()
        End If
    End Sub

    Private Sub tsbtSettings_Click(sender As Object, e As EventArgs) Handles tsbtSettings.Click
        Dim newForm As New Form()
        newForm.Text = "Serial Monitor"
        newForm.AutoSize = True
        newForm.MaximizeBox = False
        newForm.FormBorderStyle = FormBorderStyle.FixedSingle
        newForm.Icon = SettingsMainForm.Icon
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Controls.Add(New SettingsSerialMonitor)
        newForm.Show()
    End Sub

    Private Sub tsbtSave_Click(sender As Object, e As EventArgs) Handles tsbtSave.Click
        Dim sfdSerialData As New SaveFileDialog
        sfdSerialData.Filter = "Arquivo de text|*.txt"
        sfdSerialData.InitialDirectory = CurrentProjectInfo.DirectoryPaths.projectDirectory
        Dim currentDate As String = Now.Date
        sfdSerialData.FileName = CurrentProjectInfo.General.name & " - Data Logger " & currentDate.Replace("/", "_")
        If sfdSerialData.ShowDialog = DialogResult.OK Then
            File.WriteAllText(sfdSerialData.FileName, tbSerialMonitor.Text)
        End If
        controlExplorer.UpdateExplorer()
    End Sub

    Private Sub TbSerialInput_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSerialInput.KeyDown
        If e.KeyValue = Keys.Enter Then
            AppSystem.serialPort.Write(tbSerialInput.Text & finalizer)
            If tsbtAutoClear.Checked Then
                tbSerialInput.Clear()
            End If
        End If
    End Sub

    Private Sub tsbtAutoClear_CheckedChanged(sender As Object, e As EventArgs) Handles tsbtAutoClear.CheckedChanged
        IDEcfgs.Values.SerialMonitor.ClearOnEnter = tsbtAutoClear.Checked
    End Sub

    Private Sub adjustFontColors_CheckedChanged(sender As Object, e As EventArgs) Handles tsbtAutoClear.CheckedChanged, tsbtAutoScroll.CheckedChanged, tsbtConection.CheckedChanged
        If sender.Checked Then
            Try
                sender.ForeColor = Color.FromArgb(CodeColors.BackColor)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub adjustFontColors_MouseEnter(sender As Object, e As EventArgs) Handles tsbtAutoClear.MouseEnter, tsbtAutoScroll.MouseEnter, tsbtConection.MouseEnter
        sender.ForeColor = Color.Black
    End Sub

    Private Sub adjustFontColors_MouseLeave(sender As Object, e As EventArgs) Handles tsbtAutoClear.MouseLeave, tsbtAutoScroll.MouseLeave, tsbtConection.MouseLeave
        AdjustForeColor(sender)
    End Sub

    Private Shared Sub AdjustForeColor(sender As Object)
        If sender.Checked Then
            sender.ForeColor = Color.Black
        Else
            Try
                sender.ForeColor = Color.FromArgb(CodeColors.ForeColor)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
