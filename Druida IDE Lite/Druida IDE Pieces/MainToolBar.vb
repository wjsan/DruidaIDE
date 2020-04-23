Imports System.IO
Imports Druida_IDE_Lite.BoardsData
Imports Druida_IDE_Lite.IDEcfgs.Values
Imports Druida_IDE_Lite.ErrorsManager
Imports Druida_IDE_Lite.ImagesManipulation

Public Class MainToolBar

    Private Sub MainToolBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadProjectCFGs()
        ApplyTheme()
        AssignEvents()
        UpdateCulture()
        lMinimize.Visible = IDEcfgs.Values.Workspace.FullScreen
        lClose.Visible = IDEcfgs.Values.Workspace.FullScreen
    End Sub

    Private Sub LoadProjectCFGs()
        LoadFavoriteBoards()
        LoadSettings()
    End Sub

    Public Sub ApplyTheme()
        Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        ApplyThemeToolStrips()
        ApplyThemeTabs()
        ApplyThemeAuxiliaryControls()
    End Sub

    Private Sub ApplyThemeAuxiliaryControls()
        cbBoard.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        cbBoard.BackColor = Color.FromArgb(CodeColors.BackColor)
        cbPort.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        cbPort.BackColor = Color.FromArgb(CodeColors.BackColor)
        cmsCodeEditor.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        cmsCodeEditor.BackColor = Color.FromArgb(CodeColors.BackColor)
    End Sub

    Private Sub ApplyThemeTabs()
        tcMainToolBar.BackTabColor = Color.FromArgb(CodeColors.ControlsColor)
        tcMainToolBar.HeaderColor = Color.FromArgb(CodeColors.TabsHeaderColor)
        tcMainToolBar.TextColor = Color.FromArgb(CodeColors.TabsFontColor)
        tcMainToolBar.ActiveColor = Color.FromArgb(CodeColors.TabsColor)
        tcMainToolBar.HorizontalLineColor = Color.FromArgb(CodeColors.TabsColor)
        lClose.ForeColor = Color.FromArgb(CodeColors.TabsFontColor)
        lClose.BackColor = Color.FromArgb(CodeColors.TabsColor)
        lMinimize.ForeColor = lClose.ForeColor
        lMinimize.BackColor = lClose.BackColor
        For Each tabPage As TabPage In tcMainToolBar.TabPages
            tabPage.BackColor = Color.FromArgb(CodeColors.ControlsColor)
            tabPage.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Next
        tcMainToolBar.Refresh()
    End Sub

    Private Sub ApplyThemeToolStrips()
        tsProject.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsEdit.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsView.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsFile.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsTools.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsHelp.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        Label1.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        Label2.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        pbBoard.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        ApplyBtTextColors()
    End Sub

    Public Sub ApplyBtTextColors()
        For Each tabPage As TabPage In tcMainToolBar.TabPages
            For Each control In tabPage.Controls
                If control.GetType = GetType(ToolStrip) Then
                    For Each button In control.Items
                        If button.GetType = GetType(ToolStripButton) Then
                            Dim bt As ToolStripButton = button
                            bt.ForeColor = Color.FromArgb(CodeColors.ForeColor)
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Public Sub AssignEvents()
        For Each tabPage As TabPage In tcMainToolBar.TabPages
            For Each control In tabPage.Controls
                If control.GetType = GetType(ToolStrip) Then
                    For Each button In control.Items
                        If button.GetType = GetType(ToolStripButton) Then
                            Dim bt As ToolStripButton = button
                            AddHandler bt.MouseEnter, AddressOf IDEcfgs.adjustFontColors_MouseEnter
                            AddHandler bt.MouseLeave, AddressOf IDEcfgs.adjustFontColors_MouseLeave
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Public Sub UpdateCulture()
        tsbHelp.Visible = AppInfo.language <> "en"
        tsbTutorial.Visible = AppInfo.language <> "en"
    End Sub

    Public Sub ActivateTools()
        For Each tabPage As TabPage In tcMainToolBar.TabPages
            For Each control In tabPage.Controls
                control.Enabled = True
                If control.GetType = GetType(ToolStrip) Then
                    For Each button In control.Items
                        button.Enabled = True
                    Next
                End If
            Next
        Next
        LoadProjectCFGs()
    End Sub

    Public Sub LoadFavoriteBoards()
        cbBoard.Items.Clear()
        For Each board As Board In favoriteBoards
            cbBoard.Items.Add(board.GetName)
        Next
    End Sub

    Public Sub UpdateCOMports()
        AppSystem.serialPort.UpdateComboBox(cbPort)
    End Sub

    Private Sub LoadSettings()
        LoadSelectedBoard()
        LoadSelectedPort()
    End Sub

    Public Sub LoadSelectedBoard()
        Dim selBoard As String = CurrentProjectCfgs.values.hardware.selectedBoardName
        If cbBoard.Items.Contains(selBoard) Then
            cbBoard.SelectedItem = selBoard
        ElseIf selBoard <> "Erro" Then
            LoadFavoriteBoards()
            cbBoard.Items.Add(selBoard)
            cbBoard.SelectedItem = selBoard
        End If
    End Sub

    Private Sub LoadSelectedPort()
        cbPort.SelectedItem = CurrentProjectCfgs.values.hardware.COMport
    End Sub

    Private Sub tsbNewProject_Click(sender As Object, e As EventArgs) Handles tsbNewProject.Click
        ProjectActions.NewProject.ShowDialog()
    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        ProjectActions.OpenProject.ShowDialog()
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        ProjectActions.SaveProject()
    End Sub

    Private Sub tsbSaveAs_Click(sender As Object, e As EventArgs) Handles tsbSaveAs.Click
        ProjectActions.SaveAs.ShowDialog()
    End Sub

    Private Sub tsbtExport_Click(sender As Object, e As EventArgs)
        ProjectActions.Export.ShowDialog()
    End Sub

    Private Sub tsbCompile_Click(sender As Object, e As EventArgs) Handles tsbCompile.Click
        If BoardsData.GetCurrentBoard Is Nothing Then
            consoleErrors.AddItem(Type.msgAdvise, "A placa selecionada é inválida. Tente selecionar outro modelo.", "Druida.exe", "")
            Exit Sub
        End If
        Try
            Dim arduino As New ArduinoCompiler
            arduino.startCompiler(arduino.Compile)
        Catch ex As Exception
            consoleErrors.AddItem(Type.msgError, ex.Message, "MainToolBar.vb", 117)
        End Try
    End Sub

    Private Sub tsbUpload_Click(sender As Object, e As EventArgs) Handles tsbUpload.Click
        Druida_IDE.RequestConnection()
        Dim currentPort As String = CurrentProjectCfgs.values.hardware.COMport
        If Not AppSystem.serialPort.GetAvailablePorts.Contains(currentPort) And currentPort <> cbPort.SelectedItem Then
            currentPort = cbPort.SelectedItem
        End If
        If BoardsData.GetCurrentBoard Is Nothing Then
            consoleErrors.AddItem(Type.msgAdvise, "Selected board is invalid. Try to select another.", "Druida.exe", "")
            Exit Sub
        End If
        If AppSystem.serialPort.GetAvailablePorts.Count <= 0 Then
            consoleErrors.AddItem(Type.msgAdvise, "No devices on usb ports. Check your connections.", "Druida.exe", "")
            Exit Sub
        End If
        If Not AppSystem.serialPort.GetAvailablePorts.Contains(currentPort) Then
            consoleErrors.AddItem(Type.msgAdvise, "Selected port doesn't exists. Please, select another port.", "Druida.exe", "")
            Exit Sub
        End If
        Try
            Dim arduino As New ArduinoCompiler
            AppSystem.serialPort.Close()
            'controlConsole.HardwareMonitorControl.CloseSerialPort()
            arduino.startCompiler(arduino.Upload)
        Catch ex As Exception
            consoleErrors.AddItem(Type.msgError, ex.Message, "", "")
        End Try
    End Sub

    Private Sub tsbtScada_Click(sender As Object, e As EventArgs) Handles tsbtScada.Click
        'Dim currentPort As String = CurrentProjectCfgs.values.hardware.COMport
        'If Not AppSystem.serialPort.GetAvailablePorts.Contains(currentPort) And currentPort <> cbPort.SelectedItem Then
        '    currentPort = cbPort.SelectedItem
        'End If
        'If BoardsData.GetCurrentBoard Is Nothing Then
        '    consoleErrors.AddItem(Type.msgAdvise, "Selected board is invalid. Try to select another.", "Druida.exe", "")
        '    Exit Sub
        'End If
        'If AppSystem.serialPort.GetAvailablePorts.Count <= 0 Then
        '    consoleErrors.AddItem(Type.msgAdvise, "No devices on usb ports. Check your connections.", "Druida.exe", "")
        '    Exit Sub
        'End If
        'If Not AppSystem.serialPort.GetAvailablePorts.Contains(currentPort) Then
        '    consoleErrors.AddItem(Type.msgAdvise, "Selected port doesn't exists. Please, select another port.", "Druida.exe", "")
        '    Exit Sub
        'End If
        'Try
        '    Dim arduino As New ArduinoCompiler
        '    arduino.SendDebugger = True
        '    AppSystem.serialPort.Close()
        '    'controlConsole.HardwareMonitorControl.CloseSerialPort()
        '    arduino.startCompiler(arduino.Upload)
        'Catch ex As Exception
        '    consoleErrors.AddItem(Type.msgError, ex.Message, "", "")
        'End Try
        DruidaInterface.CallScada()
    End Sub

    Private Sub tsbHardware_Click(sender As Object, e As EventArgs) Handles tsbHardware.Click
        Dim CFGsExplorer As New ProjectCFGsExplorer
        Dim CFGsFile As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCFGsProjectFile)
        controlGeneralEditor.CreateTab(CFGsFile.Name, CFGsExplorer, CFGsFile.FullName)
        CFGsExplorer.ShowControl(New CFGsHardware)
    End Sub

    Private Sub cbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPort.SelectedIndexChanged
        AppSystem.serialPort.SetCOMport(cbPort.SelectedItem)
    End Sub

    Private Sub cbBoard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBoard.SelectedIndexChanged
        SelectBoard(cbBoard.SelectedItem)
        Try
            If GetCurrentBoard() IsNot Nothing Then
                'image.Dispose()
                pbBoard.Image = SafeImageFromFile(GetCurrentBoard.GetImage)
            End If
        Catch ex As Exception
            MessageBox.Show("Board data is invalid. Please, check your hardware settings.",
                            "Erro",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error)
            outputMessages.AppendMessage(ex.Message, MessagesManager.Filter.Compiler)
            outputMessages.AppendMessage(ex.ToString, MessagesManager.Filter.Compiler)
        End Try
    End Sub

    Private Sub pbBoard_Click(sender As Object, e As EventArgs) Handles pbBoard.Click

    End Sub

    Private Sub tsbNewFile_Click(sender As Object, e As EventArgs) Handles tsbNewFile.Click
        ProjectActions.CreateFile.ShowDialog()
    End Sub

    Private Sub tsbOpenFile_Click(sender As Object, e As EventArgs) Handles tsbOpenFile.Click
        ProjectActions.OpenFile.ShowDialog()
    End Sub

    Private Sub tsbSaveFile_Click(sender As Object, e As EventArgs) Handles tsbtSaveFile.Click
        ProjectActions.Save.CurrentCode.Save()
    End Sub

    Private Sub tsbtSaveFileAs_Click(sender As Object, e As EventArgs) Handles tsbtSaveFileAs.Click
        ProjectActions.Save.CurrentCode.SaveAs()
    End Sub

    Private Sub tsbImportFile_Click(sender As Object, e As EventArgs) Handles tsbImportFile.Click
        ProjectActions.ImportFile.ShowDialog()
    End Sub

    Private Sub tsbDirectories_Click(sender As Object, e As EventArgs) Handles tsbDirectories.Click
        Dim cultureResx As New CultureManager
        Dim newForm As New Form()
        newForm.Text = cultureResx.translateText("Diretórios")
        newForm.AutoSize = True
        newForm.MaximizeBox = False
        newForm.FormBorderStyle = FormBorderStyle.FixedSingle
        newForm.Icon = SettingsMainForm.Icon
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Controls.Add(New SettingsDirectories)
        newForm.Show()
    End Sub

    Private Sub tsbExportAsHtml_Click(sender As Object, e As EventArgs) Handles tsbExportAsHtml.Click
        CodeManager.Actions.exportHtml.ShowDialog()
    End Sub

    Private Sub tsbOpenIDE_Click(sender As Object, e As EventArgs) Handles tsbOpenIDE.Click
        Try
            Process.Start(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsbExamples_Click(sender As Object, e As EventArgs) Handles tsbExamples.Click
        ExamplesManager.Show()
    End Sub

    Private Sub tsbLibraries_Click(sender As Object, e As EventArgs) Handles tsbLibraries.Click
        LibrariesManager.Show()
    End Sub

    Private Sub tsbGoTo_Click(sender As Object, e As EventArgs) Handles tsbGoTo.Click, tsmiGoTo.Click
        CodeManager.Actions.goToLine.ShowDialog()
    End Sub

    Private Sub tsbFind_Click(sender As Object, e As EventArgs) Handles tsbFind.Click, tsmiFind.Click
        CodeManager.Actions.find.ShowDialog()
    End Sub

    Private Sub tsbFindAndReplace_Click(sender As Object, e As EventArgs) Handles tsbFindAndReplace.Click, tsmiReplace.Click
        CodeManager.Actions.replace.ShowDialog()
    End Sub

    Private Sub tsbUndo_Click(sender As Object, e As EventArgs) Handles tsbUndo.Click, tsmiUndo.Click
        CodeManager.Actions.Undo()
    End Sub

    Private Sub tsbRedo_Click(sender As Object, e As EventArgs) Handles tsbRedo.Click, tsmiRedo.Click
        CodeManager.Actions.Redo()
    End Sub

    Private Sub tsbCut_Click(sender As Object, e As EventArgs) Handles tsbCut.Click, tsmiCut.Click
        CodeManager.Actions.Cut()
    End Sub

    Private Sub TsbCopy_Click(sender As Object, e As EventArgs) Handles tsbCopy.Click
        CodeManager.Actions.Copy()
    End Sub

    Private Sub TsbPaste_Click(sender As Object, e As EventArgs) Handles tsbPaste.Click
        CodeManager.Actions.Paste()
    End Sub

    Private Sub tsbIdent_Click(sender As Object, e As EventArgs) Handles tsbIdent.Click, tsmiIdent.Click
        CodeManager.Actions.Ident()
    End Sub

    Private Sub tsbCommentSelected_Click(sender As Object, e As EventArgs) Handles tsbCommentSelected.Click, tsmiComment.Click
        CodeManager.Actions.Comment()
    End Sub

    Private Sub tsbtFold_Click(sender As Object, e As EventArgs) Handles tsbtFold.Click, tsmiFold.Click
        CodeManager.Actions.CollapseAllFoldingBlocks()
    End Sub

    Private Sub tsbtUnfold_Click(sender As Object, e As EventArgs) Handles tsbtUnfold.Click, tsmiUnfold.Click
        CodeManager.Actions.ExpandAllFoldingBlocks()
    End Sub

    Private Sub tsbVarMonitor_Click(sender As Object, e As EventArgs) Handles tsbVarMonitor.Click

    End Sub

    Private Sub tsbClear_Click(sender As Object, e As EventArgs) Handles tsbClear.Click
        CodeManager.Actions.marker.ClearMarkers()
    End Sub

    Private Sub tsbInterrupt_Click(sender As Object, e As EventArgs) Handles tsbInterrupt.Click

    End Sub

    Private Sub tsbSerialMonitor_Click(sender As Object, e As EventArgs) Handles tsbSerialMonitor.Click
        SerialMonitorTool.Show()
        SerialMonitorTool.BringToFront()
    End Sub

    Private Sub tsbVerifySyntax_Click(sender As Object, e As EventArgs) Handles tsbVerifySyntax.Click
        Druida_IDE_Lite.mainAutoCompleteMenu.UpdateScope(CodeInfo.ScopeInfo.scope(0))
        CodeManager.SyntaxHighlighter()
    End Sub

    Private Sub tsbCodeSnnipetsManager_Click(sender As Object, e As EventArgs) Handles tsbCodeSnnipetsManager.Click
        CodeSnippets.ShowDialog()
    End Sub

    Private Sub tsbOptions_Click(sender As Object, e As EventArgs) Handles tsbOptions.Click
        SettingsMainForm.ShowDialog()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        Process.Start("https://binary-quantum.com/2019/03/24/visao-geral-druida-ide-lite/")
    End Sub

    Private Sub tsbTutorial_Click(sender As Object, e As EventArgs) Handles tsbTutorial.Click
        Process.Start("https://binary-quantum.com/category/videos/druida-ide-lite-videos/tutoriais/")
    End Sub

    Private Sub tsbOnlineDocuments_Click(sender As Object, e As EventArgs) Handles tsbOnlineDocuments.Click

    End Sub

    Private Sub tsbOnlineSupport_Click(sender As Object, e As EventArgs) Handles tsbOnlineSupport.Click
        If AppInfo.language = "en" Then
            Process.Start("https://api.whatsapp.com/send?phone=5537999039766&text=Welcome%20to%20online%20support#")
        Else
            Process.Start("https://api.whatsapp.com/send?phone=5537999039766&text=Seja%20bem%20vindo%20ao%20suporte%20t%C3%A9cnico#")
        End If
    End Sub

    Private Sub tsbtBugReport_Click(sender As Object, e As EventArgs) Handles tsbtBugReport.Click
        If AppInfo.language = "en" Then
            Process.Start("https://binquantum.wordpress.com/bug-report/")
        Else
            Process.Start("https://binary-quantum.com/reportar-bug/")
        End If
    End Sub

    Private Sub tsbSuggestion_Click(sender As Object, e As EventArgs) Handles tsbSuggestion.Click
        If AppInfo.language = "en" Then
            Process.Start("https://binquantum.wordpress.com./contact-us/")
        Else
            Process.Start("https://binary-quantum.com/contato/")
        End If
    End Sub

    Private Sub tsbtFileList_Click(sender As Object, e As EventArgs) Handles tsbtFileList.Click
        Druida_IDE.scWorkArea.Panel1Collapsed = False
        Druida_IDE.scExplorer.Panel1Collapsed = False
        Workspace.ShowFilesList = True
    End Sub

    Private Sub tsbtFullScreen_Click(sender As Object, e As EventArgs) Handles tsbtFullScreen.Click
        Dim appAction As New AppActions
        appAction.myViewSettings.SetFullScreen(tsbtFullScreen.Checked)
    End Sub

    Private Sub tsbtObjects_Click(sender As Object, e As EventArgs) Handles tsbtObjects.Click
        Druida_IDE.scWorkArea.Panel1Collapsed = False
        Druida_IDE.scExplorer.Panel2Collapsed = False
        Workspace.ShowObjectsList = True
    End Sub

    Private Sub tsbtConsole_Click(sender As Object, e As EventArgs) Handles tsbtConsole.Click
        toggleConsole()
    End Sub

    Public Sub toggleConsole()
        Druida_IDE.scCodeArea.Panel2Collapsed = Not Druida_IDE.scCodeArea.Panel2Collapsed
        Workspace.ShowConsole = Not Druida_IDE.scCodeArea.Panel2Collapsed
    End Sub

    Private Sub tsbtDocumentMap_Click(sender As Object, e As EventArgs) Handles tsbtDocumentMap.Click
        controlGeneralEditor.ShowDocumentMap()
    End Sub

    Private Sub lClose_Click(sender As Object, e As EventArgs) Handles lClose.Click
        Druida_IDE.Close()
    End Sub

    Private Sub lMinimize_Click(sender As Object, e As EventArgs) Handles lMinimize.Click
        Druida_IDE.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub tsbtAnnounce_Click(sender As Object, e As EventArgs)
        Process.Start("https://binary-quantum.com/anuncie-sua-loja-no-nosso-aplicativo/")
    End Sub

    'Private Sub tcMainToolBar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMainToolBar.SelectedIndexChanged
    '    newBrowser.Dock = DockStyle.Fill
    '    If tcMainToolBar.SelectedTab.Text = "Shopping" Then
    '        If Not Druida_IDE.Contains(newBrowser) Then
    '            Druida_IDE.scCodeArea.Panel1.Controls.Add(newBrowser)
    '            newBrowser.Navigate("https://binary-quantum.com/partners/")
    '        End If
    '        newBrowser.BringToFront()
    '    Else
    '        Druida_IDE.scCodeArea.Panel1.Controls.Remove(newBrowser)
    '    End If
    'End Sub

    Private Sub tsbtExit_Click(sender As Object, e As EventArgs) Handles tsbtExit.Click
        ProjectActions.Close()
    End Sub

    Private Sub tsbtShowOutput_Click(sender As Object, e As EventArgs) Handles tsbtShowOutput.Click
        Workspace.ShowOutputTab = True
        Workspace.ShowConsole = True
        controlConsole.UpdateTabs()
    End Sub

    Private Sub tsbtShowErrors_Click(sender As Object, e As EventArgs) Handles tsbtShowErrors.Click
        Workspace.ShowErrorsTab = True
        Workspace.ShowConsole = True
        controlConsole.UpdateTabs()
    End Sub

    Private Sub tsbtShowSerialMonitor_Click(sender As Object, e As EventArgs) Handles tsbtShowSerialMonitor.Click
        Workspace.ShowSerialMonitorTab = True
        Workspace.ShowConsole = True
        controlConsole.UpdateTabs()
    End Sub

    Private Sub tsbtShowHardwareMonitor_Click(sender As Object, e As EventArgs) Handles tsbtShowHardwareMonitor.Click
        Workspace.ShowHardwareMonitorTab = True
        Workspace.ShowConsole = True
        controlConsole.UpdateTabs()
    End Sub

    Private Sub FecharAbaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        controlGeneralEditor.CloseCurrentTab()
    End Sub



End Class