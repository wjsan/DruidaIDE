Imports Druida_IDE_Lite.IDEcfgs.Values.Workspace

Public Class SettingsWorkspace

    Private Sub Workspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCFGs()
    End Sub

    Private Sub LoadCFGs()
        cbFullScreen.Checked = FullScreen
        cbShowErrorsTab.Checked = ShowErrorsTab
        cbShowFilesList.Checked = ShowFilesList
        cbShowObjectList.Checked = ShowObjectsList
        cbShowOutputTab.Checked = ShowOutputTab
        cbShowSerialMonitorTab.Checked = ShowSerialMonitorTab
        cbShowHardwareDebugger.Checked = ShowHardwareMonitorTab
        cbShowConsole.Checked = ShowConsole
        cbShowDocumentMap.Checked = ShowDocumentMap
        cbFullPathOnTab.Checked = FullPathOnTab
    End Sub

    Private Sub cbFullScreen_CheckedChanged(sender As Object, e As EventArgs) Handles cbFullScreen.CheckedChanged
        Dim appAction As New AppActions
        appAction.myViewSettings.SetFullScreen(cbFullScreen.Checked)
    End Sub

    Private Sub cbShowFilesList_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowFilesList.CheckedChanged
        ShowFilesList = cbShowFilesList.Checked
        Druida_IDE.scWorkArea.Panel1Collapsed = Not (Convert.ToBoolean(ShowFilesList) Or Convert.ToBoolean(ShowObjectsList))
        Druida_IDE.scExplorer.Panel1Collapsed = Not cbShowFilesList.Checked
    End Sub

    Private Sub cbShowObjectList_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowObjectList.CheckedChanged
        ShowObjectsList = cbShowObjectList.Checked
        Druida_IDE.scWorkArea.Panel1Collapsed = Not (Convert.ToBoolean(ShowFilesList) Or Convert.ToBoolean(ShowObjectsList))
        Druida_IDE.scExplorer.Panel2Collapsed = Not cbShowObjectList.Checked
    End Sub

    Private Sub cbShowConsole_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowConsole.CheckedChanged
        ShowConsole = cbShowConsole.Checked
        Druida_IDE.scCodeArea.Panel2Collapsed = Not Convert.ToBoolean(ShowConsole)
    End Sub

    Private Sub cbShowOutputTab_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowOutputTab.CheckedChanged
        ShowOutputTab = cbShowOutputTab.Checked
        controlConsole.UpdateTabs()
    End Sub

    Private Sub cbShowErrorsTab_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowErrorsTab.CheckedChanged
        ShowErrorsTab = cbShowErrorsTab.Checked
        controlConsole.UpdateTabs()
    End Sub

    Private Sub cbShowSerialMonitorTab_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowSerialMonitorTab.CheckedChanged
        ShowSerialMonitorTab = cbShowSerialMonitorTab.Checked
        controlConsole.UpdateTabs()
    End Sub
    Private Sub cbShowHardwareDebugger_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowHardwareDebugger.CheckedChanged
        ShowHardwareMonitorTab = cbShowHardwareDebugger.Checked
        controlConsole.UpdateTabs()
    End Sub

    Private Sub cbShowDocumentMap_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowDocumentMap.CheckedChanged
        ShowDocumentMap = cbShowDocumentMap.Checked
    End Sub

    Private Sub cbFullPathOnTab_CheckedChanged(sender As Object, e As EventArgs) Handles cbFullPathOnTab.CheckedChanged
        FullPathOnTab = cbFullPathOnTab.Checked
    End Sub
End Class
