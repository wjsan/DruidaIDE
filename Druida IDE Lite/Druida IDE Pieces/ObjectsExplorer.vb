Imports System.Threading
Imports FastColoredTextBoxNS
Imports Druida_IDE_Lite.Objects
Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.CodeInfo
Imports Druida_IDE_Lite.MessagesManager
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class ObjectsExplorer

    Public myFTCBobjectList As Object
    Private myFCTB As CodeEditorForArduino
    Private codefileslist As New List(Of String)    'Deletar
    Private ObjectList As New List(Of objectList)
    Private objectReference As Object
    Private bkpObject As New List(Of Object)
    Public objectExplorerBrush = Brushes.LightGray
    Private currentLine As UInt32 = 0
    Private isBusy As Boolean
    Private firstLoop As Boolean

    Private libList As New List(Of String)
    Private detectedLibs As New List(Of objLibrary)

    Public Sub ApplyTheme()
        Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tvObjectList.BackColor = Color.FromArgb(CodeColors.BackColor)
        tvObjectList.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsObjetcExplorer.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsObjetcExplorer.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Label1.BackColor = Color.FromArgb(CodeColors.TabsColor)
        Label1.ForeColor = Color.FromArgb(CodeColors.TabsFontColor)
        lClose.BackColor = Label1.BackColor
        lClose.ForeColor = Label1.ForeColor
    End Sub

    Private Sub ObjectManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        tvObjectList.ImageList = Druida_IDE.ilCodeElements
        ApplyTheme()
    End Sub

    Public Sub AssignRef(fctb As FastColoredTextBox)
        firstLoop = True
        RemoveHandlers()
        bkpsNodes.Clear()
        myFCTB = fctb
        AddHandlers()
        ClearEscopoList()
        myFTCBobjectList = New objectList("Global")
        objectReference = myFTCBobjectList
        Try
            If Not isBusy Then
                UpdateExplorer()
            End If
        Catch ex As Exception
            outputMessages.AppendMessage("<AssignRef> " & ex.Message, Filter.ObjectExplorer)
        End Try
    End Sub

    Private Sub AddHandlers()
        AddHandler myFCTB.SelectionChanged, AddressOf myFCTB_SelectionChanged
        AddHandler myFCTB.SelectionChangedDelayed, AddressOf myFCTB_SelectionChangedDelayed
    End Sub

    Private Sub RemoveHandlers()
        If myFCTB IsNot Nothing Then
            RemoveHandler myFCTB.SelectionChanged, AddressOf myFCTB_SelectionChanged
            RemoveHandler myFCTB.SelectionChangedDelayed, AddressOf myFCTB_SelectionChangedDelayed
        End If
    End Sub

    Private Sub UpdateExplorer()
        If Not isBusy Then
            ClearEscopoList()
            bkpObject.Clear()
            ThreadPool.QueueUserWorkItem(Sub(o As Object)
                                             Try
                                                 Me.ReBuildObjectExplorer(myFCTB.Text)
                                             Catch ex As Exception

                                             End Try
                                         End Sub)
        Else
            WaitLoadLibsMessage()
        End If
    End Sub

    Private Sub WaitLoadLibsMessage()
        If tvObjectList.Nodes.Count = 1 Then
            tvObjectList.Nodes.Clear()
            tvObjectList.Nodes.Add("Aguarde... Carregando Bibliotecas.")
        End If
    End Sub

    Private Sub ClearEscopoList()
        ScopeInfo.scope.Clear()
        ScopeInfo.scope.Add(myFTCBobjectList)
        For i = 1 To myFCTB.LinesCount - 1
            ScopeInfo.scope.Add(Nothing)
        Next
    End Sub

    Private Function containsLib(libName As String) As objLibrary
        For Each detectedLib In detectedLibs
            If detectedLib.getName = libName Then
                Return detectedLib
            End If
        Next
        Return Nothing
    End Function

    Private Sub ReBuildObjectExplorer(text As String)
        isBusy = True
        objectReference.clear
        objectReference.classes.AddRange(mainAutoCompleteMenu.GetInitialClasses())
        Try
l1:
            For Each item In libList
                If containsLib(item) IsNot Nothing Then
                    libList.Remove(item)
                    objectReference.removeLib(item)
                    GoTo l1
                End If
            Next
            detectedLibs.Clear()
            mapText(text, myFCTB.myCodeFileManager.getFileName)
        Catch ex As Exception
            Me.Invoke(Sub()
                          outputMessages.AppendMessage("<ReBuildObjectExplorer> " & ex.Message, Filter.ObjectExplorer)
                      End Sub)
        End Try
        isBusy = False
        tvObjectList.Invoke(Sub()
                                Try
                                    UpdateTree()
                                Catch ex As Exception
                                End Try
                            End Sub)
        myFCTB.Invoke(Sub()
                          If firstLoop Then
                              UpdateSelectedScope()
                          End If
                          myFCTB.UpdateSyntaxData()
                          If firstLoop Then
                              CodeManager.SyntaxHighlighter()
                          End If
                          firstLoop = False
                      End Sub)
    End Sub

    Private Sub mapText(text As String, codeFile As String)
        Objects.SetCurrentText(text)
        Dim lastObjectFinded = objectReference
        Dim lines() As String = text.Split(vbLf)
        Dim ignoreLine As Boolean = False
        For i = 0 To lines.Length - 1
            currentLine = i
            Dim line = lines(i)
            Dim lineIsPublic = CodeSnippet.IsPublic(line)
            If Not CodeSnippet.IsComment(line) Then
                If CodeSnippet.IsBlockComment(line) Then
                    ignoreLine = True
                End If
                If line.Contains("*/") Then
                    ignoreLine = False
                End If
                If Not ignoreLine Then
                    Dim objectFinded = Nothing
                    If CodeSnippet.IsFather(objectReference) Or CodeSnippet.IsFunction(objectReference) Or CodeSnippet.IsLibrary(objectReference) Then
                        objectFinded = objectReference.searchObjectInLine(line, i)
                    End If
                    If objectFinded IsNot Nothing Then
                        putObjectInDataBase(lastObjectFinded, lineIsPublic, objectFinded)
                    End If
                End If
                    If lastObjectFinded IsNot Nothing Then
                    testBrackets(lastObjectFinded, i, line)
                    mapEscopoToLines(codeFile, lastObjectFinded, i)
                End If
            Else
                mapEscopoToLines(codeFile, lastObjectFinded, i)
            End If
        Next
    End Sub

    Private Sub mapEscopoToLines(codeFile As String, lastObjectFinded As Object, i As Integer)
        If codeFile = myFCTB.myCodeFileManager.getFileName Then
            If CodeSnippet.IsFather(lastObjectFinded) Or lastObjectFinded.GetType = GetType(objFunction) Then
                ScopeInfo.scope(i) = lastObjectFinded
            ElseIf i > 0 Then
                ScopeInfo.scope(i) = ScopeInfo.scope(i - 1)
            End If
        End If
    End Sub

    Private Sub testBrackets(ByRef lastObjectFinded As Object, ByRef i As Integer, line As String)
        If line.Contains("#define ") Or line.Contains("{") And line.Contains("}") Then Exit Sub
        If line.Contains("{") Then
            bkpObject.Add(objectReference)
            If lastObjectFinded.GetType <> GetType(objVariable) Then
                objectReference = lastObjectFinded
            End If
        End If
        If line.Contains("}") Then
            If CodeSnippet.IsFather(objectReference) Or CodeSnippet.IsFunction(objectReference) Or CodeSnippet.IsStructure(objectReference) Then
                Try
                    objectReference.setEndIndex(i)
                Catch ex As Exception
                    outputMessages.AppendMessage("<ReBuildObjectExplorer> " & ex.Message, Filter.ObjectExplorer)
                    outputMessages.AppendMessage("<ReBuildObjectExplorer> " & "Verifique os colchetes do seu código", Filter.ObjectExplorer)
                End Try
            End If
            objectReference = bkpObject.Last
            lastObjectFinded = bkpObject.Last
            bkpObject.Remove(bkpObject.Last)
        End If
    End Sub

    Private Sub putObjectInDataBase(ByRef lastObjectFinded As Object, lineIsPublic As Object, ByRef objectFinded As Object)
        lastObjectFinded = objectFinded
        If CodeSnippet.IsLibrary(objectFinded) Then
            If Not libList.Contains(objectFinded.getName) Then
                CodeSnippet.IsPublic("public:")
                objectReference.addLibrary(objectFinded)
                bkpObject.Add(objectReference)
                objectReference = lastObjectFinded
                Dim bkpText As String = Objects.GetCurrentText()
                mapText(objectFinded.getTextCode, objectFinded.getName)
                Objects.SetCurrentText(bkpText)
                If bkpObject.Last.GetType = GetType(objectList) Then
                    libList.Add(objectFinded.getName)
                    detectedLibs.Add(objectFinded)
                End If
                objectReference = bkpObject.Last
                lastObjectFinded = bkpObject.Last
                bkpObject.Remove(bkpObject.Last)
            Else
                detectedLibs.Add(objectFinded)
            End If
        End If
        If CodeSnippet.IsClass(objectFinded) Then
            objectReference.addClass(objectFinded)
        End If
        If CodeSnippet.IsClassInstance(objectFinded) Then
            objectReference.addClassInstance(objectFinded)
        End If
        If CodeSnippet.IsStructure(objectFinded) Then
            objectReference.addStructure(objectFinded)
        End If
        If CodeSnippet.IsFunction(objectFinded) Then
            objectReference.addFunction(objectFinded)
            If CodeSnippet.IsClass(objectReference) And lineIsPublic Then
                objectReference.addPublicFunction(objectFinded)
            End If
        End If
        If CodeSnippet.IsVar(objectFinded) Then
            objectReference.addVar(objectFinded)
            If CodeSnippet.IsClass(objectReference) And lineIsPublic Then
                objectReference.addPublicVar(objectFinded)
            End If
        End If
        If CodeSnippet.IsVars(objectFinded) Then
            For Each item In objectFinded
                objectReference.addVar(item)
                If CodeSnippet.IsClass(objectFinded) And lineIsPublic Then
                    objectReference.addPublicVar(item)
                End If
            Next
        End If
        If CodeSnippet.IsNamespace(objectFinded) Then
            objectReference.addNamespace(objectFinded)
        End If
    End Sub

    Dim bkpsNodes As New List(Of TreeNode)
    Private Sub ClearTreeNode()
        bkpsNodes.Clear()
        If tvObjectList.Nodes.Count > 0 Then
            For Each node As TreeNode In tvObjectList.Nodes(0).Nodes
                Dim containLib = containsLib(node.Text)
                If containLib IsNot Nothing Then
                    bkpsNodes.Add(node)
                    AddBkpLibrary(containLib)
                End If
            Next
        End If
    End Sub

    Private Sub AddBkpLibrary(library As objLibrary)
        For Each ownedLib In objectReference.libraries
            If ownedLib.getName = library.getName Then
                Exit Sub
            End If
        Next
        objectReference.addLibrary(library)
    End Sub

    Private Function NodeContains(name As String) As Boolean
        If tvObjectList.Nodes.Count > 0 Then
            If tvObjectList.Nodes(0).Nodes.Find(name, False).Count > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Sub clearAll()
        Try
            objectReference.clearAll()
            libList.Clear()
            detectedLibs.Clear()
            tvObjectList.Nodes.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateTree()
        If Not isBusy Then
            If myFCTB Is Nothing Then Exit Sub
            objectReference = myFTCBobjectList
            ClearTreeNode()
            Dim node As New TreeNode(objectReference.getName, 7, 7)
            node.Tag = 0
            Try
                If ToolStripButtonFunctions.Checked Or ToolStripButtonClass.Checked Then
                    UpdateTreeNode(node, objectReference)
                Else
                    UpdateTreeOnlyVars(node, objectReference)
                End If
            Catch ex As Exception
                outputMessages.AppendMessage("<UpdateTree> " & ex.Message, Filter.ObjectExplorer)
            End Try
            tvObjectList.Nodes.Clear()
            If ToolStripButtonLibraries.Checked Then
                node.Nodes.AddRange(bkpsNodes.ToArray)
            End If
            tvObjectList.Nodes.Add(node)
            tvObjectList.Nodes(0).Expand()
        Else
            WaitLoadLibsMessage()
        End If
    End Sub

    Private Sub UpdateTreeNode(node As TreeNode, objectRef As Object)
        If objectRef.GetType = GetType(objVariable) Then
            Exit Sub
        End If
        If ToolStripButtonVars.Checked Then
            For Each item As objVariable In objectRef.variables
                If Not item.getName.Contains("#define") Then
                    Dim newNode = GetNode(node, item)
                End If
            Next
            For Each item As objClassInstance In objectRef.ClassInstances
                Dim newNode = GetNode(node, item)
            Next
        End If
        If objectRef.GetType = GetType(objFunction) Or objectRef.GetType = GetType(objStructure) Then
            Exit Sub
        End If
        If objectRef.GetType = GetType(objectList) Then
            For Each item In objectRef.nameSpaces
                UpdateTreeNode(GetNode(node, item), item)
            Next
        End If
        If ToolStripButtonFunctions.Checked Then
            For Each item As objStructure In objectRef.Structures
                Dim newNode = GetNode(node, item)
                UpdateTreeNode(newNode, item)
            Next
            For Each item As objFunction In objectRef.functions
                Dim newNode = GetNode(node, item)
                UpdateTreeNode(newNode, item)
            Next
        End If
        If ToolStripButtonClass.Checked Then
            For Each item As objClass In objectRef.classes
                If item.getName <> "String" Then
                    Dim newNode As Object = GetNode(node, item)
                    UpdateTreeNode(newNode, item)
                End If
            Next
        End If
        If objectRef.GetType = GetType(objClass) Then
            Exit Sub
        End If
        If ToolStripButtonLibraries.Checked Then
            For Each item As objLibrary In objectRef.libraries
                If Not NodeContains(item.getName) Then
                    Dim newNode = node.Nodes.Add(item.getName, item.getName, item.getImage, item.getImage)
                    newNode.Tag = item.getIndex
                    newNode.ToolTipText = item.getPath
                    UpdateTreeNode(newNode, item)
                End If
            Next
        End If
    End Sub

    Private Shared Function GetNode(node As TreeNode, item As Object) As Object
        Dim newNode = node.Nodes.Add(item.getName, item.getName, item.getImage, item.getImage)
        newNode.Tag = item.getIndex
        newNode.ToolTipText = item.getDescr
        Return newNode
    End Function

    Private Sub UpdateTreeOnlyVars(node As TreeNode, objectRef As Object)
        If Not ToolStripButtonVars.Checked Then Exit Sub
        If objectRef.GetType = GetType(objVariable) Then
            Exit Sub
        End If
        For Each item As objVariable In objectRef.variables
            Dim newNode = node.Nodes.Add(item.getName, item.getName, item.getImage, item.getImage)
            newNode.Tag = item.getIndex
        Next
        If objectRef.GetType = GetType(objFunction) Or objectRef.GetType = GetType(objStructure) Then
            Exit Sub
        End If
        For Each item As objStructure In objectRef.Structures
            UpdateTreeOnlyVars(node, item)
        Next
        For Each item As objFunction In objectRef.functions
            UpdateTreeOnlyVars(node, item)
        Next
        For Each item As objClass In objectRef.classes
            UpdateTreeOnlyVars(node, item)
        Next
    End Sub

    Private Sub UpdateSelectedScope()
        Try
            ScopeInfo.UpdateEscopo()
        Catch ex As Exception
            outputMessages.AppendMessage("<UpdateSelectedScope> " & ex.Message, Filter.ObjectExplorer)
        End Try
    End Sub

    Private Sub tvObjectList_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvObjectList.NodeMouseClick
        tvObjectList.SelectedNode = e.Node
    End Sub

    Private Sub tvObjectList_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvObjectList.NodeMouseDoubleClick
        If tvObjectList.SelectedNode IsNot Nothing Then
            Dim linToSelect = tvObjectList.SelectedNode.Tag
            If tvObjectList.SelectedNode.ImageIndex = CodeInfo.codeImages.library Then
                Dim fileToOpen As String = tvObjectList.SelectedNode.ToolTipText
                controlExplorer.OpenCodeFile(fileToOpen)
                Exit Sub
            End If
            Try
                myFCTB.Navigate(linToSelect)
                CodeManager.Actions.marker.ClearMarker(objectExplorerBrush)
                CodeManager.Actions.marker.MarkLineWithBrush(linToSelect, objectExplorerBrush)
                myFCTB.Focus()
            Catch ex As Exception
                outputMessages.AppendMessage("<ReBuildObjectExplorer> " & ex.Message, Filter.ObjectExplorer)
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message & ". Este objeto tem origem em outro arquivo.", myFCTB.myCodeFileManager.getFileName, "")
            End Try
        End If
    End Sub

    Private Sub ToolStripButtonLibraries_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripButtonLibraries.MouseUp
        UpdateTree()
    End Sub

    Private Sub ToolStripButtonClass_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripButtonClass.MouseUp
        UpdateTree()
    End Sub

    Private Sub ToolStripButtonFunctions_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripButtonFunctions.MouseUp
        UpdateTree()
    End Sub

    Private Sub ToolStripButtonVars_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStripButtonVars.MouseUp
        UpdateTree()
    End Sub

    Private Sub ToolStripButtonAtualizar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAtualizar.Click
        clearAll()
        UpdateTree()
    End Sub

    Private Sub myFCTB_SelectionChangedDelayed(ByVal sender As Object, ByVal e As EventArgs)
        ScopeInfo.selectedLine = myFCTB.Selection.Start.iLine
        UpdateSelectedScope()
        If ScopeInfo.selectedLine <> 0 Then
            UpdateExplorer()
        End If
    End Sub

    Private Sub myFCTB_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        CodeManager.Actions.marker.ClearMarker(objectExplorerBrush)
    End Sub

    Private Sub lClose_Click(sender As Object, e As EventArgs) Handles lClose.Click
        Druida_IDE.scWorkArea.Panel1Collapsed = Druida_IDE.scExplorer.Panel1Collapsed
        Druida_IDE.scExplorer.Panel2Collapsed = True
        Workspace.ShowObjectsList = Not Druida_IDE.scExplorer.Panel2Collapsed
    End Sub

End Class