Imports Druida_IDE_Lite.IDEcfgs.Values
Imports Druida_IDE_Lite.IDEcfgs.Values.Workspace
Imports VisualStudioTabControl

Public Class myConsole


    Public Sub ApplyTheme()
        Output.ApplyTheme()
        ErrorsList.ApplyTheme()
        SerialMonitor.ApplyTheme()
        'HardwareMonitorControl.AppyTheme()
        tcConsole.BackTabColor = Color.FromArgb(CodeColors.ControlsColor)
        tcConsole.HeaderColor = Color.FromArgb(CodeColors.TabsHeaderColor)
        tcConsole.TextColor = Color.FromArgb(CodeColors.TabsFontColor)
        tcConsole.ActiveColor = Color.FromArgb(CodeColors.TabsColor)
        tcConsole.HorizontalLineColor = Color.FromArgb(CodeColors.TabsColor)
        lClose.BackColor = Color.FromArgb(CodeColors.TabsColor)
        lClose.ForeColor = Color.FromArgb(CodeColors.TabsFontColor)
        For Each tabPage As TabPage In tcConsole.TabPages
            tabPage.BackColor = Color.FromArgb(CodeColors.ControlsColor)
            tabPage.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Next
        tcConsole.Refresh()
        UpdateTabs()
    End Sub

    Public Sub UpdateTabs()
        Dim tabs() As TabPage = {tpOutput, tpErrors, tpSerialMonitor} ', tpHardwareDebugger}
        Dim conditions() As Boolean = {ShowOutputTab, ShowErrorsTab, ShowSerialMonitorTab} ', ShowHardwareMonitorTab}
        tcConsole.TabPages.Clear()
        For i = 0 To conditions.Length - 1
            Dim condition As Boolean = conditions(i)
            If condition Then
                tcConsole.TabPages.Add(tabs(i))
            Else
                tcConsole.TabPages.Remove(tabs(i))
            End If
        Next
        Druida_IDE.scCodeArea.Panel2Collapsed = tcConsole.TabCount = 0
    End Sub

    Private Sub Console_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeItems()
        ApplyTheme()
    End Sub

    Private Sub InitializeItems()
        Output.tscbOutputFilter.SelectedIndex = 0
    End Sub

    Private Sub lClose_Click(sender As Object, e As EventArgs) Handles lClose.Click
        Druida_IDE.scCodeArea.Panel2Collapsed = True
        Workspace.ShowConsole = Not Druida_IDE.scCodeArea.Panel2Collapsed
    End Sub

    Private Sub tcConsole_CloseButtonClicked(sender As Object, e As CloseButtonClickedEventArgs) Handles tcConsole.CloseButtonClicked
        If e.tabPage Is tpOutput Then ShowOutputTab = False
        If e.tabPage Is tpErrors Then ShowErrorsTab = False
        If e.tabPage Is tpSerialMonitor Then ShowSerialMonitorTab = False
        'If e.tabPage Is tpHardwareDebugger Then ShowHardwareMonitorTab = False
        If tcConsole.TabCount = 1 Then Druida_IDE.scCodeArea.Panel2Collapsed = True
        tcConsole.TabPages.Remove(e.tabPage)
    End Sub

End Class