Imports Druida_IDE_Lite.IDEcfgs.Values.Directories

Public Class SettingsDirectories
    Private Sub SettingsDirectories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCFGs()
    End Sub

    Private Sub LoadCFGs()
        tbDirArduino.Text = Arduino
        tbDirArduinoCoreLib.Text = ArduinoCoreLib
        tbDirArduinoLib.Text = ArduinoLib
        tbDirBackupDir.Text = BackupDir
        tbDirCompilerTempDir.Text = CompilerTempDir
        tbDirDruidaProjects.Text = DruidaProjects
        tbDirArduinoDefaultLib.Text = ArduinoDefaultLib
        tbDirAditionalLibs.Text = AditionalLibsDir.Replace("\n", vbCrLf)
    End Sub

    Private Sub tbDirArduino_TextChanged(sender As Object, e As EventArgs) Handles tbDirArduino.TextChanged
        Arduino = tbDirArduino.Text
    End Sub

    Private Sub tbDirArduinoLib_TextChanged(sender As Object, e As EventArgs) Handles tbDirArduinoLib.TextChanged
        ArduinoLib = tbDirArduinoLib.Text
    End Sub

    Private Sub tbDirArduinoCoreLib_TextChanged(sender As Object, e As EventArgs) Handles tbDirArduinoCoreLib.TextChanged
        ArduinoCoreLib = tbDirArduinoCoreLib.Text
    End Sub

    Private Sub tbDirArduinoDefaultLib_TextChanged(sender As Object, e As EventArgs) Handles tbDirArduinoDefaultLib.TextChanged
        ArduinoDefaultLib = tbDirArduinoDefaultLib.Text
    End Sub

    Private Sub tbDirDruidaProjects_TextChanged(sender As Object, e As EventArgs) Handles tbDirDruidaProjects.TextChanged
        DruidaProjects = tbDirDruidaProjects.Text
    End Sub

    Private Sub tbDirCompilerTempDir_TextChanged(sender As Object, e As EventArgs) Handles tbDirCompilerTempDir.TextChanged
        CompilerTempDir = tbDirCompilerTempDir.Text
    End Sub

    Private Sub tbDirBackupDir_TextChanged(sender As Object, e As EventArgs) Handles tbDirBackupDir.TextChanged
        BackupDir = tbDirBackupDir.Text
    End Sub

    Private Sub tbDirAditionalLibs_TextChanged(sender As Object, e As EventArgs) Handles tbDirAditionalLibs.TextChanged
        AditionalLibsDir = tbDirAditionalLibs.Text.Replace(vbCrLf, "\n")
    End Sub

    Public Sub ShowFolderDialog(ByVal tb As TextBox, ByVal initPath As String)
        fbdSettingsDir.SelectedPath = initPath
        fbdSettingsDir.ShowDialog()
        tb.Text = fbdSettingsDir.SelectedPath
    End Sub

    Public Sub ShowAppendFolderDialog(ByVal tb As TextBox, ByVal initPath As String)
        fbdSettingsDir.SelectedPath = initPath
        fbdSettingsDir.ShowDialog()
        If tb.Text = "" Then
            tb.Text &= fbdSettingsDir.SelectedPath
        Else
            tb.Text &= vbCrLf & fbdSettingsDir.SelectedPath
        End If
    End Sub

    Public Sub ShowFileDialog(ByVal tb As TextBox, ByVal initPath As String)
        ofdSettingsDir.InitialDirectory = initPath
        ofdSettingsDir.ShowDialog()
        tb.Text = ofdSettingsDir.FileName
    End Sub

    Private Sub btArduinoDir_Click(sender As Object, e As EventArgs) Handles btArduinoDir.Click
        ShowFileDialog(tbDirArduino, Arduino)
    End Sub

    Private Sub btArduinoLibDir_Click(sender As Object, e As EventArgs) Handles btArduinoLibDir.Click
        ShowFolderDialog(tbDirArduinoLib, ArduinoLib)
    End Sub

    Private Sub btArduinoCoreLibDir_Click(sender As Object, e As EventArgs) Handles btArduinoCoreLibDir.Click
        ShowFolderDialog(tbDirArduinoCoreLib, ArduinoCoreLib)
    End Sub

    Private Sub btArduinoDefaultLibDir_Click(sender As Object, e As EventArgs) Handles btArduinoDefaultLibDir.Click
        ShowFolderDialog(tbDirArduinoDefaultLib, ArduinoDefaultLib)
    End Sub

    Private Sub btDruidaProjectDir_Click(sender As Object, e As EventArgs) Handles btDruidaProjectDir.Click
        ShowFolderDialog(tbDirDruidaProjects, DruidaProjects)
    End Sub

    Private Sub btCompilerTempDir_Click(sender As Object, e As EventArgs) Handles btCompilerTempDir.Click
        ShowFolderDialog(tbDirCompilerTempDir, CompilerTempDir)
    End Sub

    Private Sub btBackupDir_Click(sender As Object, e As EventArgs) Handles btBackupDir.Click
        ShowFolderDialog(tbDirBackupDir, BackupDir)
    End Sub

    Private Sub BtAddLibDir_Click(sender As Object, e As EventArgs) Handles btAddLibDir.Click
        ShowAppendFolderDialog(tbDirAditionalLibs, AppInfo.Directories.arduinoAppData)
    End Sub
End Class
