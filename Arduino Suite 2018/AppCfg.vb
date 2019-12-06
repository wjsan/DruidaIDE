Imports System.Configuration

Public Class AppCfg
    Public Function Ler(ByVal key As String) As String
        Try
            Dim appSettings = ConfigurationManager.AppSettings
            Dim result As String = If(appSettings(key), "Não Encontrado")
            Return (result)
        Catch __unusedConfigurationErrorsException1__ As ConfigurationErrorsException
            MessageBox.Show("Erro ao ler configurações do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return ("Erro")
        End Try
    End Function

    Public Sub Escrever(ByVal key As String, ByVal value As String)
        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings

            If settings(key) Is Nothing Then
                settings.Add(key, value)
            Else
                settings(key).Value = value
            End If

            configFile.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        Catch __unusedConfigurationErrorsException1__ As ConfigurationErrorsException
            'MessageBox.Show("Erro ao escrever as alterações nas configurações do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            'ComandoAvancado.TextBoxConsole.AppendText("Erro ao ler configurações do programa:" & __unusedConfigurationErrorsException1__.Message & vbCrLf)
            Druida_IDE_Lite.DruidaInterface.AddErrorMsg(__unusedConfigurationErrorsException1__.Message, Druida_IDE_Lite.ErrorsManager.Type.msgError)
        End Try
    End Sub

End Class
