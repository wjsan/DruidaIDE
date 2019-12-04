Imports Druida_IDE_Lite.IDEcfgs.Values.Initialization

Public Class SettingsInicialization

    Private Sub SettingsInicialization_Enter(sender As Object, e As EventArgs) Handles Me.Load
        LoadCFGs()
    End Sub

    Private Sub LoadCFGs()
        cbOpenLastFile.Checked = openLastFile
        cbOpenAllFiles.Checked = openAllFiles
        cbShowSplashScreen.Checked = showSplashScreen
    End Sub

    Private Sub cbOpenLastFile_CheckedChanged(sender As Object, e As EventArgs) Handles cbOpenLastFile.CheckedChanged
        If AppInfo.license = AppInfo.LicenseTypes.lite And cbOpenLastFile.Checked Then
            If MessageBox.Show("Este recurso não está disponível na Versão gratuita do Druida. Deseja adquirir a versão paga?",
                           "Recurso Exclisivo da Versão Paga",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Process.Start("https://binary-quantum.com/loja-druida-ide-lite/")
            End If
            cbOpenLastFile.Checked = False
        Else
            openLastFile = cbOpenLastFile.Checked
        End If
    End Sub

    Private Sub cbOpenAllFiles_CheckedChanged(sender As Object, e As EventArgs) Handles cbOpenAllFiles.CheckedChanged
        openAllFiles = cbOpenAllFiles.Checked
    End Sub

    Private Sub cbShowSplashScreen_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowSplashScreen.CheckedChanged
        If AppInfo.license = AppInfo.LicenseTypes.lite And Not cbShowSplashScreen.Checked Then
            If MessageBox.Show("Este recurso não está disponível na Versão gratuita do Druida. Deseja adquirir a versão paga?",
                               "Recurso Exclisivo da Versão Paga",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Process.Start("https://binary-quantum.com/loja-druida-ide-lite/")
            End If
            cbShowSplashScreen.Checked = True
        Else
            showSplashScreen = cbShowSplashScreen.Checked
        End If
    End Sub
End Class
