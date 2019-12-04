Imports System.ComponentModel
Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.MySystemInfo
Imports FastColoredTextBoxNS
Imports Druida_IDE_Lite.IDEcfgs.Values.Workspace

Public Class Druida_IDE
    Dim loadedInterface As Boolean = False
    Public Event ConnectionRequested()

    Public Sub ApplyTheme()
        'Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        'Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        'MainToolBar.ApplyTheme
        controlMainToolBar.ApplyTheme()
        controlConsole.ApplyTheme()
        controlExplorer.ApplyTheme()
        controlObjectsExplorer.ApplyTheme()
        controlGeneralEditor.ApplyTheme()

        scWorkArea.Panel1Collapsed = Not (Convert.ToBoolean(ShowFilesList) And Convert.ToBoolean(ShowObjectsList))
        scExplorer.Panel1Collapsed = Not Convert.ToBoolean(ShowFilesList)
        scExplorer.Panel2Collapsed = Not Convert.ToBoolean(ShowObjectsList)
        scCodeArea.Panel2Collapsed = Not Convert.ToBoolean(ShowConsole)

        If CodeAreaSplittedDistance <> 0 Then
            scCodeArea.SplitterDistance = CodeAreaSplittedDistance
        End If

        If WorkAreaSplittedDistance <> 0 Then
            scWorkArea.SplitterDistance = WorkAreaSplittedDistance
        End If

        loadedInterface = True
    End Sub

    Private Sub Druida_IDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        StartTimers()
        ApplyTheme()
    End Sub

    Public Sub Druida_IDE_Clear()
        scDruidaMain.Panel1.Controls.Clear()
        scCodeArea.Panel2.Controls.Clear()
        scExplorer.Panel1.Controls.Clear()
        scExplorer.Panel2.Controls.Clear()
    End Sub

    Public Sub InitializeForm()
        OpenControlInPanel(controlMainToolBar, scDruidaMain.Panel1)
        OpenControlInPanel(controlConsole, scCodeArea.Panel2)
        OpenControlInPanel(controlExplorer, scExplorer.Panel1)
        OpenControlInPanel(controlObjectsExplorer, scExplorer.Panel2)
    End Sub

    Public Sub LoadProject()
        scCodeArea.Panel1.Controls.Clear()
        OpenControlInPanel(controlGeneralEditor, scCodeArea.Panel1)
        controlExplorer.UpdateExplorer()
        Me.Text = CurrentProjectInfo.General.name & " - Druida IDE Lite"
        controlExplorer.OpenCodeFile(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        controlMainToolBar.ActivateTools()
    End Sub

    Public Sub LoadHomePage()
        OpenControlInPanel(controlHomePage, scCodeArea.Panel1)
    End Sub

    ''' <summary>
    ''' Opens a children form, in a specified panel
    ''' </summary>
    ''' <param name="form">Form to open</param>
    ''' <param name="panel">Panel to be the parent of form</param>
    Public Sub OpenControlInPanel(form As Object, panel As SplitterPanel)
        'If form.GetType IsNot GetType(myConsole) Then
        '    form.MdiParent = Me
        'End If
        form.Parent = panel
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub Druida_IDE_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IDEcfgs.Save()
        If CurrentProjectInfo.DirectoryPaths.projectDirectory = "" Then
            If ProjectActions.CloseApplication.ShowDialog = DialogResult.No Then
                e.Cancel = True
            End If
        Else
            If ProjectActions.Save.ShowDialog() = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
        If IDEcfgs.Values.Workspace.IsChild Then
            Me.Hide()
            e.Cancel = True
        End If
    End Sub

    Public Sub StartTimers()
        tCheckPorts.Start()
    End Sub

    Private Sub tCheckPorts_Tick(sender As Object, e As EventArgs) Handles tCheckPorts.Tick
        AppSystem.serialPort.CheckForDeviceChanges()
        controlMainToolBar.UpdateCOMports()
        controlConsole.SerialMonitor.UpdateCOMports()
        SerialMonitorTool.SerialMonitor.UpdateCOMports()
    End Sub

    Private Sub scCodeArea_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles scCodeArea.SplitterMoved
        If loadedInterface Then
            CodeAreaSplittedDistance = scCodeArea.SplitterDistance
        End If
    End Sub

    Private Sub scWorkArea_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles scWorkArea.SplitterMoved
        If loadedInterface Then
            WorkAreaSplittedDistance = scWorkArea.SplitterDistance
        End If
    End Sub

    Public Sub RequestConnection()
        RaiseEvent ConnectionRequested()
    End Sub
End Class