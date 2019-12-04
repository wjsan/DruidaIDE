Imports System.IO

Public Class Explorer
    Inherits TreeView

    Dim extensionsList As New List(Of String)
    Dim filesList As New List(Of String)

    ''' <summary>
    ''' A filter, to hide all empty folders after build explorer
    ''' </summary>
    ''' <returns>Status of filter</returns>
    <System.ComponentModel.Description("A filter, to hide all empty folders after build explorer")>
    Public Property HideEmptyFolders As Boolean

    ''' <summary>
    ''' List of Paths to be explored
    ''' </summary>
    ''' <returns>List of Paths to be explored</returns>
    <System.ComponentModel.Description("Full Path to be explored")>
    Public Property Paths As New List(Of String)

    ''' <summary>
    ''' Alternative names to directory folder in Paths List
    ''' </summary>
    ''' <returns>Path of explorer</returns>
    <System.ComponentModel.Description("Alternative names to directory folder in Paths List")>
    Public Property PathsNames As New List(Of String)

    ''' <summary>
    ''' Extensions of files to be listed
    ''' </summary>
    ''' <returns>Extensions recognized by this explorer</returns>
    <System.ComponentModel.Description("Extensions of files to be listed. Put in the same order of the images of image list to auto-defined images by extensions. Let the first extension empty, and first image of list will be used to folders.")>
    Property Extensions As String()

    ''' <summary>
    ''' Load Explorer elements in defined path
    ''' </summary>
    Public Sub LoadExplorer()
        Dim bkp As String = ""
        If Me.SelectedNode IsNot Nothing Then
            bkp = Me.SelectedNode.FullPath
        End If
        Me.Nodes.Clear()
        filesList.Clear()
        For Each path As String In Paths
            If Directory.Exists(path) Then
                Dim dirInfo As DirectoryInfo = New DirectoryInfo(path)
                Dim node As TreeNode = Me.Nodes.Add(dirInfo.Name)
                If PathsNames.Count > Paths.IndexOf(path) Then
                    node.Text = PathsNames(Paths.IndexOf(path))
                End If
                LoadFiles(path, node)
                LoadSubDirectories(path, node)
                If bkp <> "" And bkp IsNot Nothing Then
                    Me.SelectedNode = GetNode(bkp, Me.Nodes)
                End If
            End If
        Next
        If HideEmptyFolders Then
            FilterEmptyNodes(Nodes)
        End If
    End Sub

    Private Sub FilterEmptyNodes(nodes As TreeNodeCollection)
        Dim list = DirectCast(nodes, IList)
        Dim i As Int32 = 0
        While i <= list.Count - 1
            Dim node As TreeNode = DirectCast(list(i), TreeNode)
            If Not File.Exists(node.Tag) Then
                FilterEmptyNodes(node.Nodes)
                If node.Nodes.Count = 0 Then
                    nodes.Remove(node)
                    i -= 1
                    'Else
                End If
            End If
            i += 1
        End While
    End Sub

    ''' <summary>
    ''' Verify all directories in directory lists
    ''' </summary>
    ''' <returns>The list of directories not found</returns>
    Public Function VerifyDirs() As List(Of String)
        Dim directories As New List(Of String)
        For Each path In Paths
            If Not Directory.Exists(path) Then
                directories.Add(path)
            End If
        Next
        If directories.Count > 0 Then
            Return directories
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Search a node in explorer using fullPath key
    ''' </summary>
    ''' <param name="path">Path to be seek</param>
    ''' <param name="parentCollection">Collection of nodes</param>
    ''' <returns></returns>
    Public Function GetNode(ByVal path As String, ByVal parentCollection As TreeNodeCollection) As TreeNode
        Dim ret As TreeNode
        For Each child As TreeNode In parentCollection 'step through the parentcollection
            If child.FullPath = path.Replace("/", "\") Then
                ret = child
            ElseIf child.GetNodeCount(True) > 0 Then ' if there is child items then call this function recursively
                ret = GetNode(path.Replace("/", "\"), child.Nodes)
            End If
#Disable Warning BC42104 ' A variável é usada antes de receber um valor
            If Not ret Is Nothing Then Exit For 'if something was found, exit out of the for loop
#Enable Warning BC42104 ' A variável é usada antes de receber um valor
        Next
        Return ret
    End Function

    Public Sub SearchNode(name As String, continueMessage As String, endMessage As String)
        SearchByName(name, Me.Nodes, continueMessage)
        If exitSearch = False Then
            MessageBox.Show(endMessage)
        End If
    End Sub

    Dim exitSearch = False
    Private Function SearchByName(name As String, nodes As TreeNodeCollection, continueMessage As String)
        Dim ret As TreeNode = Nothing
        exitSearch = False
        For Each child As TreeNode In nodes
            Dim childNodes = child.Nodes
            If child.Text.ToLower.Contains(name.ToLower) Then
                Return child
            ElseIf child.GetNodeCount(True) > 0 Then
continueSearch:
                ret = SearchByName(name, childNodes, continueMessage)
                If exitSearch Then Exit For
            End If
            If ret IsNot Nothing And Me.SelectedNode IsNot ret Then
                Me.SelectedNode = ret
                Dim d = MessageBox.Show(continueMessage, "Explorer", MessageBoxButtons.YesNo)
                If d = DialogResult.No Then
                    exitSearch = True
                    Exit For
                Else
                    childNodes = ret.Nodes
                    GoTo continueSearch
                End If
            End If
        Next
        Return ret
    End Function

    Private Sub LoadFiles(ByVal path As String, node As TreeNode)
        Dim arquivos() As String = Directory.GetFiles(path, "*.*")
        For Each file In arquivos
            extensionsList.Clear()
            extensionsList.AddRange(Extensions)
            Dim filInf As New FileInfo(file)
            Dim newNode As New TreeNode(filInf.Name)
            Dim imgIndex As Int16 = extensionsList.IndexOf(filInf.Extension)
            If Extensions.Contains(filInf.Extension) Then
                newNode.Tag = filInf.FullName
                newNode.SelectedImageIndex = extensionsList.IndexOf(filInf.Extension)
                newNode.ImageIndex = extensionsList.IndexOf(filInf.Extension)
                node.Nodes.Add(newNode)
                filesList.Add(filInf.FullName)
            End If
        Next
    End Sub

    Private Sub LoadSubDirectories(ByVal path As String, node As TreeNode)
        Dim subDir() As String = Directory.GetDirectories(path)
        For Each directory In subDir
            Dim dirInfo As New DirectoryInfo(directory)
            Dim newNode As TreeNode = node.Nodes.Add(dirInfo.Name)
            newNode.Tag = dirInfo.Name
            newNode.StateImageIndex = 0
            newNode.Tag = dirInfo.FullName
            LoadFiles(directory, newNode)
            LoadSubDirectories(directory, newNode)
        Next
    End Sub

    ''' <summary>
    ''' Get a list of full name files loaded in explorer
    ''' </summary>
    ''' <returns></returns>
    Public Function GetFilesList() As List(Of String)
        Return filesList
    End Function

    Private Sub Explorer_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Me.NodeMouseClick
        Me.SelectedNode = e.Node
    End Sub
End Class
