Imports Code_Editor_For_Arduino
Imports System.IO
Imports Druida_IDE_Lite.IDEcfgs.Values
Imports VisualStudioTabControl

Public Class GeneralEditor

    Structure UpdateItems
        Const CFGs = 0
        Const Font = 1
    End Structure

    Public Sub ApplyTheme()
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tcGeneralEditor.ActiveColor = Color.FromArgb(CodeColors.TabsColor)
        tcGeneralEditor.HorizontalLineColor = Color.FromArgb(CodeColors.TabsColor)
        tcGeneralEditor.BackTabColor = Color.FromArgb(CodeColors.ControlsColor)
        tcGeneralEditor.HeaderColor = Color.FromArgb(CodeColors.TabsHeaderColor)
        tcGeneralEditor.TextColor = Color.FromArgb(CodeColors.TabsFontColor)
        lToggleConsole.BackColor = Color.FromArgb(CodeColors.TabsColor)
        lToggleConsole.ForeColor = Color.FromArgb(CodeColors.TabsFontColor)
        tcGeneralEditor.Refresh()
        DocMapApplyTheme()
    End Sub

    Private Sub DocMapApplyTheme()
        myDocMap.Visible = Workspace.ShowDocumentMap
        myDocMap.BackColor = Color.FromArgb(CodeColors.BackColor)
    End Sub

    Public Sub UpdateCodeEditor(ByVal item As Integer)
        Select Case item
            Case UpdateItems.CFGs
                CodeManager.UpdateEditorCfgs()
            Case UpdateItems.Font
                CodeManager.UpdateFont()
            Case Else

        End Select
    End Sub

    ''' <summary>
    ''' Creates a tab and adds a content to it or opens it, if it already exists
    ''' </summary>
    ''' <param name="name">Name of new tab</param>
    ''' <param name="content">Content of new tab</param>
    Public Sub CreateTab(name As String, content As Object, fullPath As String)
        Dim existingTab = GetTab(name)
        If existingTab Is Nothing Then
            Dim newTab As New TabPage(name)
            newTab.ToolTipText = fullPath
            content.Dock = DockStyle.Fill
            newTab.Controls.Add(content)
            tcGeneralEditor.TabPages.Add(newTab)
            tcGeneralEditor.SelectedTab = newTab
        Else
            tcGeneralEditor.SelectedTab = existingTab
        End If
    End Sub

    Public Sub ShowDocumentMap()
        myDocMap.Visible = Not myDocMap.Visible
        Workspace.ShowDocumentMap = myDocMap.Visible
    End Sub

    Public Sub CloseTab(name As String)
        Dim tabPage As TabPage = GetTab(name)
        If tabPage IsNot Nothing Then
            Try
                tcGeneralEditor.TabPages.Remove(tabPage)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Function GetTab(name As String) As TabPage
        For Each tabPage As TabPage In tcGeneralEditor.TabPages
            If tabPage.Text = name Then
                Return tabPage
            End If
        Next
        Return Nothing
    End Function

    Private Sub UpdateRef()
        myDocMap.Visible = False
        If tcGeneralEditor.TabCount > 0 Then
            For Each control In tcGeneralEditor.SelectedTab.Controls
                If control.GetType = GetType(CodeEditorForArduino) Then
                    CodeManager.AssignRef(control)
                    myDocMap.Target = control
                    myDocMap.Visible = Workspace.ShowDocumentMap
                    myDocMap.Scale = 0.3
                End If
            Next
        End If
    End Sub

    Private Sub tcGeneralEditor_ControlAdded(sender As Object, e As ControlEventArgs) Handles tcGeneralEditor.ControlAdded
        If tcGeneralEditor.TabCount = 1 Then
            UpdateRef()
        End If
    End Sub

    Private Sub tcGeneralEditor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcGeneralEditor.SelectedIndexChanged
        CodeManager.ClearStyles()
        CodeManager.Actions.Save()
        UpdateRef()
    End Sub

    Private Sub SaveDialog()
        Try
            Dim selectedFile As New FileInfo(tcGeneralEditor.SelectedTab.Text)
            If selectedFile.Extension <> ".cfg" Then
                If CodeManager.IsChanged Then
                    ProjectActions.Save.CurrentCode.ShowDialog()
                End If
            Else
                CurrentProjectCfgs.Save()
            End If
        Catch ex As Exception

        End Try
        tcGeneralEditor.SelectedTab.Dispose()
    End Sub

    Public Sub SaveAll()
        For Each tab As TabPage In tcGeneralEditor.TabPages
            For Each control In tab.Controls
                If control.GetType = GetType(CodeEditorForArduino) Then
                    Try
                        control.myCodeFileManager.saveFile()
                    Catch ex As Exception

                    End Try
                End If
            Next
        Next
        CodeManager.SaveSettings()
    End Sub

    'Public Sub SaveCurrentCode()
    '    ProjectActions.Save.CurrentCode.Save()
    'End Sub

    'Private Sub GeneralEditor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    e.Cancel = True
    'End Sub

    Private Sub tcGeneralEditor_ControlRemoved(sender As Object, e As ControlEventArgs) Handles tcGeneralEditor.ControlRemoved
        SaveDialog()
        If tcGeneralEditor.TabCount = 1 Then
            controlObjectsExplorer.clearAll()
        End If
    End Sub

    Public Sub CloseAllTabs()
        For Each tab As TabPage In tcGeneralEditor.TabPages
            tab.Dispose()
        Next
    End Sub

    Private Sub lToggleConsole_Click(sender As Object, e As EventArgs) Handles lToggleConsole.Click
        controlMainToolBar.toggleConsole()
    End Sub

    Private Sub tcGeneralEditor_CloseButtonClicked(sender As Object, e As CloseButtonClickedEventArgs) Handles tcGeneralEditor.CloseButtonClicked
        tcGeneralEditor.TabPages.Remove(e.tabPage)
    End Sub

    Public Sub CloseCurrentTab()
        tcGeneralEditor.TabPages.Remove(tcGeneralEditor.SelectedTab)
    End Sub
End Class