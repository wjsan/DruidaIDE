Imports System.Windows.Forms
Imports System.IO
Public Class DialogNewCode

    Public result As Boolean = False
    Private folderToImport As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        SplashScreen.LabelStatusAbertura.Text = "Carregando Interfaces..."
        result = True
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        SplashScreen.LabelStatusAbertura.Text = "Carregando Interfaces..."
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            TextBoxCode.Clear()
            folderToImport = ""
        End If
        If ListBox1.SelectedIndex = 1 Then
            TextBoxCode.Text = File.ReadAllText(My.Application.Info.DirectoryPath & "\ArduinoNewProgram\ArduinoNewProgram.ino")
            folderToImport = My.Application.Info.DirectoryPath & "\ArduinoNewProgram"
        End If
        If ListBox1.SelectedIndex = 2 Then
            TextBoxCode.Text = File.ReadAllText(My.Application.Info.DirectoryPath & "\ArduinoSuiteCustom\ArduinoSuiteCustom.ino")
            folderToImport = My.Application.Info.DirectoryPath & "\ArduinoSuiteCustom"
        End If
    End Sub

    Private Sub DialogNewCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = 2
        CheckBox1.Checked = True
    End Sub

End Class
