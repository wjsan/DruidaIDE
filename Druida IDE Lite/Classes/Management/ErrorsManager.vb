
Module myErrorsManager
    Public consoleErrors As New ErrorsManager(controlConsole.ErrorsList.lvErrors)
End Module

Public Class ErrorsManager
    Private myListView As ListView

    Public Sub New(ListView As ListView)
        myListView = ListView
    End Sub

    Enum Type
        msgError
        msgAdvise
        msgInfo
    End Enum

    Public Sub AddItem(type As Type, descr As String, file As String, line As String)
        Dim newItem As New ListViewItem
        newItem.ImageIndex = type
        newItem.Text = descr
        newItem.SubItems.Add(file)
        newItem.SubItems.Add(line)
        newItem.Group = myListView.Groups(type)
        For Each item As ListViewItem In myListView.Items
            If item.Text = newItem.Text And item.ImageIndex = newItem.ImageIndex Then Exit Sub
        Next
        myListView.Items.Add(newItem)
        For Each item In controlConsole.tcConsole.TabPages
            If item.Name = "tpErrors" Then controlConsole.tcConsole.SelectedTab = item
        Next
    End Sub

    Public Sub clear()
        myListView.Items.Clear()
    End Sub
End Class
