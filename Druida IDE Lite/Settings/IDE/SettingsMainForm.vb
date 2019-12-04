Public Class SettingsMainForm

    Dim settingsControls() As Control = {New SettingsFontColor,
                                         New SettingsDirectories,
                                         New SettingsInicialization,
                                         New SettingsAutocomplete,
                                         New SettingsWorkspace,
                                         New SettingsSerialMonitor}

    Private Sub tvSettingsItem_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvSettingsItem.AfterSelect
        ShowControl(e.Node.Index)
    End Sub

    Public Sub ShowControl(ByVal index As Short)
        scMain.Panel2.Controls.Clear()
        settingsControls(index).Dock = DockStyle.Fill
        scMain.Panel2.Controls.Add(settingsControls(index))
        Me.Show()
    End Sub

    Private Sub SettingsMainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        tvSettingsItem.SelectedNode = Nothing
    End Sub
End Class