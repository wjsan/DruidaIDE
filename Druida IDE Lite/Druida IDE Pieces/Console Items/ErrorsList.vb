Imports Druida_IDE_Lite.IDEcfgs.Values
Imports System.IO

Public Class ErrorsList
    Private errorsExplorerBrush = Brushes.Red
    Private warnignsExplorerBrush = Brushes.Yellow

    Public Sub ApplyTheme()
        lvErrors.BackColor = Color.FromArgb(CodeColors.BackColor)
        lvErrors.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsErrors.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsErrors.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub

    Private Sub lvErrors_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvErrors.MouseDoubleClick
        If lvErrors.SelectedItems IsNot Nothing Then
            If Not IsNumeric(lvErrors.SelectedItems.Item(0).SubItems(2).Text) Then
                Exit Sub
            End If
            Dim linToSelect = lvErrors.SelectedItems.Item(0).SubItems(2).Text - 1
            Dim fileName = lvErrors.SelectedItems.Item(0).SubItems(1).Text
            If File.Exists(fileName) Then
                controlExplorer.OpenCodeFile(fileName)
            Else
                fileName = CurrentProjectInfo.DirectoryPaths.projectDirectory & "\" & fileName
                If File.Exists(fileName) Then
                    controlExplorer.OpenCodeFile(fileName)
                Else
                    outputMessages.AppendMessage("Arquivo " & fileName & " não foi encontrado.", MessagesManager.Filter.ObjectExplorer)
                    Exit Sub
                End If
            End If
            CodeManager.Actions.Navigate(linToSelect)
            CodeManager.Actions.marker.ClearMarker(errorsExplorerBrush)
            CodeManager.Actions.marker.ClearMarker(warnignsExplorerBrush)
            If lvErrors.SelectedItems.Item(0).ImageIndex = ErrorsManager.Type.msgError Then
                CodeManager.Actions.marker.MarkLineWithBrush(linToSelect, errorsExplorerBrush)
            ElseIf lvErrors.SelectedItems.Item(0).ImageIndex = ErrorsManager.Type.msgAdvise Then
                CodeManager.Actions.marker.MarkLineWithBrush(linToSelect, warnignsExplorerBrush)
            End If
        End If
    End Sub

    Private Sub tsbClearErrors_Click(sender As Object, e As EventArgs) Handles tsbClearErrors.Click
        Dim cultureResx As New CultureManager
        Dim r = MessageBox.Show(cultureResx.translateText("Tem certeza que deseja limpar?"),
                                cultureResx.translateText("Clear"),
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            For Each item In lvErrors.Items
                lvErrors.Items.Remove(item)
            Next
        End If
    End Sub

    Private Sub tsbFilterErrors_CheckedChanged(sender As Object, e As EventArgs) Handles tsbFilterErrors.CheckedChanged
        Static Dim bkpItmems As New List(Of ListViewItem)
        Dim errorType As ErrorsManager.Type = ErrorsManager.Type.msgError
        Dim status As Boolean = tsbFilterErrors.Checked
        UpdateFilter(bkpItmems, errorType, status)
    End Sub

    Private Sub tsbFilterNotices_CheckedChanged(sender As Object, e As EventArgs) Handles tsbFilterNotices.CheckedChanged
        Static Dim bkpItmems As New List(Of ListViewItem)
        Dim errorType As ErrorsManager.Type = ErrorsManager.Type.msgAdvise
        Dim status As Boolean = tsbFilterNotices.Checked
        UpdateFilter(bkpItmems, errorType, status)
    End Sub

    Private Sub tdbFilterInformations_CheckedChanged(sender As Object, e As EventArgs) Handles tdbFilterInformations.CheckedChanged
        Static Dim bkpItmems As New List(Of ListViewItem)
        Dim errorType As ErrorsManager.Type = ErrorsManager.Type.msgInfo
        Dim status As Boolean = tdbFilterInformations.Checked
        UpdateFilter(bkpItmems, errorType, status)
    End Sub

    Private Sub UpdateFilter(bkpItmems As List(Of ListViewItem), errorType As ErrorsManager.Type, status As Boolean)
        If Not status Then
            For Each item As ListViewItem In lvErrors.Items
                If item.ImageIndex = errorType Then
                    bkpItmems.Add(item)
                    item.Remove()
                End If
            Next
        Else
            Dim i = 0
            While i <= bkpItmems.Count - 1
                Dim item As ListViewItem = bkpItmems(i)
                If item.ImageIndex = errorType Then
                    lvErrors.Items.Add(item)
                    bkpItmems.Remove(item)
                    i -= 1
                End If
                i += 1
            End While
        End If
    End Sub

End Class
