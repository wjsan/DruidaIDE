'Imports AutocompleteMenuNS
Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions
Imports System.IO
Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.Objects
Imports Druida_IDE_Lite.CodeInfo

Module myMainAutoCompleteMenu
    Public mainAutoCompleteMenu As New AutocompleteMenuData
End Module

Public Class AutocompleteMenuData
    Private aMenuItens As New List(Of AutocompleteItem)
    Private predefinedItens As New List(Of AutocompleteItem)
    Private predefinedLibItens As New List(Of AutoCompleteMenuData)
    Private menuData As New AutoCompleteMenuData
    Private aMenu As AutocompleteMenu
    Private myCode As CodeEditorForArduino
    Private initialClasses As New Dictionary(Of String, objClass)
    Private buildedClasses As New Dictionary(Of String, objClass)

    Public Sub New()
        BringDataFromSnippetsFile()
    End Sub

    Public Sub AssignRef(ByRef code As CodeEditorForArduino)
        If myCode IsNot Nothing Then
            RemoveHandler myCode.SelectionChanged, AddressOf myCode_SelectionChanged
        End If
        myCode = code
        myCode.myPredefinedPopMenuItens = predefinedItens
        LoadSettings(myCode.myPopMenu)
        AddHandler myCode.SelectionChanged, AddressOf myCode_SelectionChanged
    End Sub

    Public Sub LoadSettings(ByRef autoCompleteMenu As AutocompleteMenu)
        With autoCompleteMenu
            .AllowTabKey = IDEcfgs.Values.AutoCompleteMenu.AllowTabKey
            '.AlwaysShowTooltip = IDEcfgs.Values.AutoCompleteMenu.AlwaysShowTooltip
            .AppearInterval = IDEcfgs.Values.AutoCompleteMenu.AppearInterval
            .Enabled = IDEcfgs.Values.AutoCompleteMenu.Enabled
            .MinFragmentLength = IDEcfgs.Values.AutoCompleteMenu.MinFragmentLength
            .ToolTipDuration = IDEcfgs.Values.AutoCompleteMenu.ToolTipDuration
        End With
        autoCompleteMenu.ImageList = Druida_IDE.ilCodeElements
    End Sub

    Public Sub UpdateScope(objScope As Object)
        myCode.myPopMenuItens.Clear()
        buildedClasses.Clear()
        Dim globalScope As objectList = CodeInfo.ScopeInfo.scope(0)
        addedLibs.Clear()
        getObjectsFromScope(globalScope)
        If globalScope IsNot objScope Then
            If objScope.GetType = GetType(objFunction) Or CodeSnippet.IsFather(objScope) Then
                AddInstancesFromScope(objScope.ClassInstances, objScope.getName)
            End If
            AddVarsFromScope(objScope.variables, objScope.getName)
            If CodeSnippet.IsFather(objScope) And objScope.GetType IsNot GetType(objStructure) Then
                AddFunctionsFromScope(objScope.functions, objScope.getName)
            End If
        End If
        If IncludeInLine() Then
            AddLibraries()
        End If
    End Sub


    Dim addedLibs As New List(Of String)
    Private Sub getObjectsFromScope(globalScope As objectList)
        AddLibrarieObjects(globalScope)
        AddVarsFromScope(globalScope.variables, globalScope.getName)
        AddFunctionsFromScope(globalScope.functions, globalScope.getName)
        AddClassTypesFromScope(globalScope.classes, globalScope.getName)
        AddStructTypesFromScope(globalScope.Structures, globalScope.getName)
        AddInstancesFromScope(globalScope.ClassInstances, globalScope.getName)
    End Sub

    Private Sub AddLibrarieObjects(globalScope As objectList)
        If globalScope.libraries.Count > 0 Then
            For Each librarie In globalScope.libraries
                For Each preLib In predefinedLibItens
                    If preLib.file = librarie.getName Then
                        With preLib
                            Dim it As Object
                            If Not .syntax.Contains(".") Then
                                it = AddItemWithInfo(.syntax.Replace("\n", vbCrLf).Replace("\t", vbTab), .image, .menuText, .title, .description, .tag)
                                myCode.myPopMenuItemsAdd(it)
                            ElseIf .image = CodeInfo.codeImages.method Then
                                it = AddMethodWithInfo(.syntax.Replace("\n", vbCrLf).Replace("\t", vbTab), .image, .menuText, .title, .description, .tag)
                                myCode.myPopMenuItemsAdd(it)
                            Else
                                buildClass(preLib)
                            End If
                        End With
                    End If
                Next
                If Not addedLibs.Contains(librarie.getName) Then
                    addedLibs.Add(librarie.getName)
                    getObjectsFromScope(librarie)
                End If
            Next
        End If
    End Sub

    Private Sub AddVarsFromScope(objVars As List(Of objVariable), escopoName As String)
        For Each variable As objVariable In objVars
            Dim newItem = BuildItem(variable, escopoName, "Variáveis")
            'If Not myCode.myPopMenuItens.Contains(newItem) Then
            myCode.myPopMenuItemsAdd(newItem)
            'End If
        Next
    End Sub

    Private Sub AddFunctionsFromScope(objFunctions As List(Of objFunction), escopoName As String)
        For Each functions As objFunction In objFunctions
            Dim newItem = BuildItem(functions, escopoName, "Funções")
            'If Not myCode.myPopMenuItens.Contains(newItem) Then
            myCode.myPopMenuItemsAdd(newItem)
            'End If
        Next
    End Sub

    Private Sub AddClassTypesFromScope(objClasses As List(Of objClass), escopoName As String)
        For Each classTyppe As objClass In objClasses
            Dim newItem = BuildItem(classTyppe, escopoName, "Classe")
            'If Not myCode.myPopMenuItens.Contains(newItem) Then
            myCode.myPopMenuItemsAdd(newItem)
            AddInstanceMethods(classTyppe)
            AddInstancesFromScope(classTyppe.ClassInstances, classTyppe.getName)
            'End If
        Next
    End Sub

    Private Sub AddStructTypesFromScope(objStructures As List(Of objStructure), escopoName As String)
        For Each structType As objStructure In objStructures
            Dim newItem = BuildItem(structType, escopoName, "Estrutura")
            'If Not myCode.myPopMenuItens.Contains(newItem) Then
            myCode.myPopMenuItemsAdd(newItem)
            'End If
        Next
    End Sub

    Private Sub AddInstancesFromScope(objInstances As List(Of objClassInstance), escopoName As String)
        For Each instance As objClassInstance In objInstances
            Dim newItem = BuildInstanceItem(instance, escopoName, "Classe")
            If instance.getName().contains("*") Then
                AddPointerMethods(instance)
                AddPointerVars(instance)
            Else
                AddInstanceMethods(instance)
                AddInstanceVars(instance)
            End If
            'If Not myCode.myPopMenuItens.Contains(newItem) Then
            myCode.myPopMenuItemsAdd(newItem)
            'End If
        Next
    End Sub

    Private Sub AddLibraries()
        Static Dim libItens As New List(Of AutocompleteItem)
        If libItens.Count > 0 Then
            myCode.myPopMenuItens.AddRange(libItens)
            Exit Sub
        End If
        Dim getLibs As New FileOperations
        Dim libFiles As List(Of FileInfo) = getLibs.GetLibraryFiles
        For Each libFile In libFiles
            Dim objLib As New objLibrary(libFile.Name, 0)
            Dim newItem = BuildItem(objLib, libFile.DirectoryName, "Biblioteca")
            libItens.Add(newItem)
        Next
        myCode.myPopMenuItens.AddRange(libItens)
    End Sub

    Private Function BuildItem(obj As Object, escopoName As String, type As String) As SnippetAutocompleteItem
        Dim name = CodeSnippet.GetObjectName(obj.getName)
        Dim fileName As New FileInfo(CodeManager.Actions.GetCodeFilePath)
        Dim text = name & "^"
        Dim img = obj.getImage
        Dim toolTipTitle = name & " - " & fileName.Name & ">" & escopoName & ">" & type
        If type = "Biblioteca" Then
            toolTipTitle = name & " - " & escopoName
        End If
        Dim toolTipText = ""
        If obj.getDescr <> "" Then
            Dim descr = obj.getDescr
            toolTipText &= descr
        End If
        If obj.GetType = GetType(objFunction) Then
            text = obj.getPopMenuText
        End If
        Dim newItem = AddItemWithInfo(text, img, name, toolTipTitle, toolTipText, name.Split("(")(0))
        Return newItem
    End Function

    Private Function BuildInstanceItem(obj As Object, escopoName As String, type As String)
        Dim name = CodeSnippet.GetInstanceName(obj.getName).Replace("*", "")
        Dim fileName As New FileInfo(CodeManager.Actions.GetCodeFilePath)
        Dim text = name & "^"
        Dim img = obj.getImage
        Dim toolTipTitle = name & " - " & fileName.Name & ">" & escopoName & ">" & type
        Dim toolTipText = ""
        If obj.getDescr <> "" Then
            Dim descr = obj.getDescr
            toolTipText &= descr
        End If
        If obj.GetType = GetType(objFunction) Then
            text = obj.getPopMenuText
        End If
        Dim newItem = AddItemWithInfo(text, img, name, toolTipTitle, toolTipText, name.Split("(")(0))
        Return newItem
    End Function

    Private Sub AddInstanceMethods(obj As objClassInstance)
        Dim fatherName As String = CodeSnippet.GetInstanceName(obj.getName)
        Dim constructor As String = CodeSnippet.GetObjectName(obj.getClassName)
        Dim name As String = fatherName & "."
        For Each item In obj.getMethods
            Dim title As String = obj.getClassName & " - " & item.getName
            Dim itName As String = item.getName
            itName = CodeSnippet.GetObjectName(itName)
            If itName.Contains(")") Then
                If itName.LastIndexOf(")") < itName.Count - 1 Then
                    itName = itName.Remove(itName.IndexOf(")") + 1)
                End If
            ElseIf itName.Contains("(") Then
                itName = itName.Remove(itName.IndexOf("(")) & "()"
            End If
            Dim newItem As Object
            If itName.Contains(constructor & "(") Then
                newItem = AddItemWithInfo(item.getPopMenuText, CodeInfo.codeImages.classType, itName, title, item.getDescr, itName.Split("(")(0))
            Else
                newItem = AddMethodWithInfo(name & item.getPopMenuText, CodeInfo.codeImages.method, itName, title, item.getDescr, itName.Split("(")(0))
            End If
            myCode.myPopMenuItemsAdd(newItem)
        Next
    End Sub

    Private Sub AddPointerMethods(obj As objClassInstance)
        Dim fatherName As String = CodeSnippet.GetInstanceName(obj.getName)
        Dim constructor As String = CodeSnippet.GetObjectName(obj.getClassName)
        Dim name As String = fatherName.Replace("*", "") & "->"
        For Each item In obj.getMethods
            Dim title As String = obj.getClassName & " - " & item.getName
            Dim itName As String = item.getName
            itName = CodeSnippet.GetObjectName(itName)
            If itName.Contains(")") Then
                If itName.LastIndexOf(")") < itName.Count - 1 Then
                    itName = itName.Remove(itName.IndexOf(")") + 1)
                End If
            ElseIf itName.Contains("(") Then
                itName = itName.Remove(itName.IndexOf("(")) & "()"
            End If
            Dim newItem As Object
            If itName.Contains(constructor & "(") Then
                newItem = AddItemWithInfo(item.getPopMenuText, CodeInfo.codeImages.classType, itName, title, item.getDescr, itName.Split("(")(0))
            Else
                newItem = AddPointerMethodWithInfo(name & item.getPopMenuText, CodeInfo.codeImages.method, itName, title, item.getDescr, itName.Split("(")(0))
            End If
            myCode.myPopMenuItemsAdd(newItem)
        Next
    End Sub

    Private Sub AddInstanceMethods(obj As objClass)
        Dim constructor As String = CodeSnippet.GetObjectName(obj.getName)
        Dim name As String = constructor & "::"
        If myCode.myCodeFileManager.getFileName.Contains(".cpp") Then
            Dim functions As New List(Of objFunction)
            'functions.AddRange(obj.publicFunctions)
            functions.AddRange(obj.functions)
            For Each item In functions
                Dim title As String = obj.getName & " - " & item.getName
                Dim itName As String = item.getName
                itName = CodeSnippet.GetObjectDeclaration(itName)
                Dim newItem As Object
                newItem = AddMethodWithInfo(name & itName, CodeInfo.codeImages.method, itName, title, item.getDescr, itName.Split("(")(0))
                Dim classRef = AddClassMethodWithInfo(name & itName & "^", CodeInfo.codeImages.method, itName, title, item.getDescr, itName.Split("(")(0))
                myCode.myPopMenuItens.Add(classRef)
                Dim libFunction = BuildItem(item, obj.getName, "Funções")
                myCode.myPopMenuItens.Add(libFunction)
            Next
            For Each variable In obj.publicVariables
                Dim newItem = BuildItem(variable, constructor, "Variáveis")
                myCode.myPopMenuItemsAdd(newItem)
            Next
            For Each variable In obj.variables
                Dim newItem = BuildItem(variable, constructor, "Variáveis")
                myCode.myPopMenuItemsAdd(newItem)
            Next
        End If
    End Sub

    Private Sub AddInstanceVars(obj As objClassInstance)
        Dim fatherName As String = CodeSnippet.GetInstanceName(obj.getName)
        Dim constructor As String = CodeSnippet.GetObjectName(obj.getClassName)
        Dim name As String = fatherName & "."
        Dim newItem As Object
        For Each item In obj.getVars
            Dim title As String = obj.getClassName & " - " & item.getName
            Dim itName As String = item.getName.Replace("*", "")
            itName = CodeSnippet.GetObjectName(itName)
            newItem = AddItemWithInfo(name & itName, CodeInfo.codeImages.variable, itName, title, item.getDescr, itName)
            myCode.myPopMenuItemsAdd(newItem)
        Next
    End Sub

    Private Sub AddPointerVars(obj As objClassInstance)
        Dim fatherName As String = CodeSnippet.GetInstanceName(obj.getName)
        Dim constructor As String = CodeSnippet.GetObjectName(obj.getClassName)
        Dim name As String = fatherName & "->"
        Dim newItem As Object
        For Each item In obj.getVars
            Dim title As String = obj.getClassName & " - " & item.getName
            Dim itName As String = item.getName.Replace("*", "")
            itName = CodeSnippet.GetObjectName(itName)
            newItem = AddItemWithInfo(name & itName, CodeInfo.codeImages.variable, itName, title, item.getDescr, itName)
            myCode.myPopMenuItemsAdd(newItem)
        Next
    End Sub

    Private Sub BringDataFromSnippetsFile()
        Dim filesList As String() = Directory.GetFiles(AppInfo.Directories.snippets, "*.*", SearchOption.AllDirectories)
        For Each file In filesList
            GetFileDataToAutoCompleteMenu(file)
        Next
    End Sub

    Private Function getItens() As List(Of AutocompleteItem)
        Return aMenuItens
    End Function

    Class AutoCompleteMenuData
        Public infoNames() As String = {"Sintaxe", "Imagem", "Texto", "Título", "Descricão", "Parâmetros", "Retorna", "Notas", "Arquivo"}
        Public syntax As String = ""
        Public image As UInt16 = 0
        Public menuText As String = ""
        Public title As String = ""
        Public description As String = ""
        Public parameters As String = ""
        Public functionReturn As String = ""
        Public notes As String = ""
        Public tag As String = ""
        Public file As String = ""

        Public Sub New()

        End Sub

        Public Sub New(data As AutoCompleteMenuData)
            Me.syntax = data.syntax
            Me.image = data.image
            Me.menuText = data.menuText
            Me.title = data.title
            Me.description = data.description
            Me.parameters = data.parameters
            Me.functionReturn = data.functionReturn
            Me.notes = data.notes
            Me.tag = data.tag
            Me.file = data.file
        End Sub

        Public Sub ReadSnippetFile(ByVal filePath As String)
            Dim fileManager As New FileVarSystem
            fileManager.SetFilePath(filePath)
            syntax = fileManager.ReadVar(infoNames(0))
            image = fileManager.ReadVar(infoNames(1))
            menuText = fileManager.ReadVar(infoNames(2))
            title = fileManager.ReadVar(infoNames(3))
            description = fileManager.ReadVar(infoNames(4))
            parameters = fileManager.ReadVar(infoNames(5))
            functionReturn = fileManager.ReadVar(infoNames(6))
            notes = fileManager.ReadVar(infoNames(7))
            file = fileManager.ReadVar(infoNames(8))
            If file = "Error" Then file = ""
        End Sub
    End Class

    Private Sub GetFileDataToAutoCompleteMenu(ByVal filePath As String)
        Dim cultureResx As New CultureManager
        menuData.ReadSnippetFile(filePath)
        Dim fileinfo As New FileInfo(filePath)
        With menuData
            Dim descr As String = menuData.description.Replace("\n", vbCrLf) & vbCrLf & vbCrLf
            If .parameters <> "Nenhum" And .parameters <> "" Then
                descr &= cultureResx.translateText("PARÂMETROS: ") & vbCrLf & .parameters.Replace("\n", vbCrLf) & vbCrLf & vbCrLf
            End If
            If .functionReturn <> "Nada" And .functionReturn <> "" Then
                descr &= cultureResx.translateText("RETORNO: ") & vbCrLf & .functionReturn & vbCrLf & vbCrLf
            End If
            'descr &= "NOTAS: " & vbCrLf & .notes.Replace("\n", vbCrLf)
            Dim tag = fileinfo.Name.Replace(fileinfo.Extension, "")
            If .file.Contains(".h") Then
                menuData.description = descr
                menuData.tag = tag
                predefinedLibItens.Add(New AutoCompleteMenuData(menuData))
                Exit Sub
            End If
            If Not .syntax.Contains(".") Then
                predefinedItens.Add(AddItemWithInfo(.syntax.Replace("\n", vbCrLf).Replace("\t", vbTab), .image, .menuText, .title, descr, tag))
            ElseIf .image = CodeInfo.codeImages.method Then
                predefinedItens.Add(AddMethodWithInfo(.syntax.Replace("\n", vbCrLf).Replace("\t", vbTab), .image, .menuText, .title, descr, tag))
            Else
                buildInitialClass(menuData)
            End If
        End With
        'listTags.Add(fileName.Split(".")(fileName.Split(".").Count - 2))
    End Sub

    Private Sub buildInitialClass(data As AutoCompleteMenuData)
        Dim className = data.syntax.Split(".")(0)
        If Not initialClasses.Keys.Contains(className) Then
            initialClasses.Add(className, New objClass(className, 0))
        End If
        Dim classObj As objClass = initialClasses.Item(className)
        classObj.addPublicFunction(Method(data.menuText,
                                              data.description,
                                              data.parameters,
                                              data.functionReturn))
    End Sub

    Private Sub buildClass(data As AutoCompleteMenuData)
        Dim className = data.syntax.Split(".")(0)
        If Not buildedClasses.Keys.Contains(className) Then
            buildedClasses.Add(className, New objClass(className, 0))
        End If
        Dim classObj As objClass = buildedClasses.Item(className)
        classObj.addPublicFunction(MethodWithToolTip(data.menuText,
                                              data.description))
    End Sub

    Public Function GetInitialClasses()
        Dim list As Generic.List(Of objClass) = initialClasses.Values.ToList
        list.AddRange(buildedClasses.Values.ToList)
        Return list
    End Function

    Private Function Method(name As String, description As String, parameters As String, ret As String)
        Dim cultureResx As New CultureManager
        Return New objFunction(name & " //" & description & "\n\n" & cultureResx.translateText("PARÂMETROS: ") &
                               ":\n" & parameters & "\n\n" & cultureResx.translateText("RETORNO: ") & ":\n" & ret, 0)
    End Function

    Private Function MethodWithToolTip(name As String, tooltip As String)
        Return New objFunction(name & " //" & tooltip, 0)
    End Function

    Private Function AddItemWithInfo(ByVal text As String, ByVal imageIndex As Int16, ByVal menuText As String, ByVal toolTipTitle As String, ByVal toolTipText As String, ByVal tag As String)
        If imageIndex < 0 Then
            imageIndex = 0
        End If
        Dim item As New SnippetAutocompleteItem(text) With {
            .ImageIndex = imageIndex,
            .MenuText = menuText,
            .ToolTipTitle = toolTipTitle,
            .ToolTipText = toolTipText,
            .Tag = tag.Replace("()", "")
            }
        Return item
    End Function

    Private Function AddMethodWithInfo(ByVal text As String, ByVal imageIndex As Int16, ByVal menuText As String, ByVal toolTipTitle As String, ByVal toolTipText As String, ByVal tag As String)
        If imageIndex < 0 Then
            imageIndex = 0
        End If
        Dim item As New MethodAutocompleteItem2(text) With {
            .ImageIndex = imageIndex,
            .MenuText = menuText,
            .ToolTipTitle = toolTipTitle,
            .ToolTipText = toolTipText,
            .Tag = tag
            }
        Return item
    End Function

    Private Function AddClassMethodWithInfo(ByVal text As String, ByVal imageIndex As Int16, ByVal menuText As String, ByVal toolTipTitle As String, ByVal toolTipText As String, ByVal tag As String)
        If imageIndex < 0 Then
            imageIndex = 0
        End If
        Dim item As New MethodAutocompleteItem3(text) With {
            .ImageIndex = imageIndex,
            .MenuText = menuText,
            .ToolTipTitle = toolTipTitle,
            .ToolTipText = toolTipText,
            .Tag = tag
            }
        Return item
    End Function

    Private Function AddPointerMethodWithInfo(ByVal text As String, ByVal imageIndex As Int16, ByVal menuText As String, ByVal toolTipTitle As String, ByVal toolTipText As String, ByVal tag As String)
        If imageIndex < 0 Then
            imageIndex = 0
        End If
        Dim item As New MethodAutocompleteItem4(text) With {
            .ImageIndex = imageIndex,
            .MenuText = menuText,
            .ToolTipTitle = toolTipTitle,
            .ToolTipText = toolTipText,
            .Tag = tag
            }
        Return item
    End Function

    Private Sub myCode_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        myCode.myPopMenu.Enabled = Not CursorInComment()
    End Sub

    Private Function CursorInComment()
        Dim line As String = myCode.Lines(myCode.Selection.Start.iLine)
        If line.Contains("//") Then
            If line.IndexOf("//") < myCode.Selection.Start.iChar Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function IncludeInLine()
        Dim line As String = myCode.Lines(myCode.Selection.Start.iLine)
        
        Return line.Contains("#include")
    End Function

    Private Class DeclarationSnippet
        Inherits SnippetAutocompleteItem

        Public Sub New(snippet As String)
            MyBase.New(snippet)
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim pattern As String = Regex.Escape(fragmentText)
            Dim result As CompareResult
            If Regex.IsMatch(Me.Text, "\b" + pattern, RegexOptions.IgnoreCase) Then
                result = CompareResult.Visible
            Else
                result = CompareResult.Hidden
            End If
            Return result
        End Function
    End Class

    Public Class MethodAutocompleteItem2
        Inherits MethodAutocompleteItem

        Private firstPart As String
        Private lastPart As String

        Public Sub New(ByVal text As String)
            MyBase.New(text)
            Dim i = text.LastIndexOf("."c)

            If i < 0 Then
                firstPart = text
            Else
                firstPart = text.Substring(0, i)
                lastPart = text.Substring(i + 1)
            End If
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim i As Integer = fragmentText.LastIndexOf("."c)

            If i < 0 Then
                If firstPart.StartsWith(fragmentText) AndAlso String.IsNullOrEmpty(lastPart) Then Return CompareResult.VisibleAndSelected
            Else
                Dim fragmentFirstPart = fragmentText.Substring(0, i)
                Dim fragmentLastPart = fragmentText.Substring(i + 1)
                If firstPart <> fragmentFirstPart Then Return CompareResult.Hidden
                If lastPart IsNot Nothing AndAlso lastPart.StartsWith(fragmentLastPart) Then Return CompareResult.VisibleAndSelected
                If lastPart IsNot Nothing AndAlso lastPart.ToLower().Contains(fragmentLastPart.ToLower()) Then Return CompareResult.Visible
            End If

            Return CompareResult.Hidden
        End Function

        Public Overrides Function GetTextForReplace() As String
            If lastPart Is Nothing Then Return firstPart
            Return firstPart & "." & lastPart
        End Function

        Public Overrides Sub OnSelected(ByVal popupMenu As AutocompleteMenu, ByVal e As SelectedEventArgs)
            e.Tb.BeginUpdate()
            e.Tb.Selection.BeginUpdate()
            Dim p1 = popupMenu.Fragment.Start
            Dim p2 = e.Tb.Selection.Start

            Dim i = e.Tb.Selection.ToLine
            Dim text As String = e.Tb.Lines(i)
            If text.Contains(")^()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")^()", ")^")
            End If
            If text.Contains(")()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")()", ")")
            End If

            If e.Tb.AutoIndent Then

                For iLine As Integer = p1.iLine + 1 To p2.iLine
                    e.Tb.Selection.Start = New Place(0, iLine)
                    e.Tb.DoAutoIndent(iLine)
                Next
            End If

            e.Tb.Selection.Start = p1

            While e.Tb.Selection.CharBeforeStart <> "^"c
                If Not e.Tb.Selection.GoRightThroughFolded() Then Exit While
            End While

            e.Tb.Selection.GoLeft(True)
            e.Tb.InsertText("")
            e.Tb.Selection.EndUpdate()
            e.Tb.EndUpdate()
        End Sub
    End Class

    Public Class MethodAutocompleteItem3
        Inherits MethodAutocompleteItem

        Private firstPart As String
        Private lastPart As String

        Public Sub New(ByVal text As String)
            MyBase.New(text)
            Dim i = text.LastIndexOf(":"c)

            If i < 0 Then
                firstPart = text
            Else
                firstPart = text.Substring(0, i)
                lastPart = text.Substring(i + 1)
            End If
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim i As Integer = fragmentText.LastIndexOf(":"c)

            If i < 0 Then
                If firstPart.StartsWith(fragmentText) AndAlso String.IsNullOrEmpty(lastPart) Then Return CompareResult.VisibleAndSelected
            Else
                Dim fragmentFirstPart = fragmentText.Substring(0, i)
                Dim fragmentLastPart = fragmentText.Substring(i + 1)
                If firstPart <> fragmentFirstPart Then Return CompareResult.Hidden
                If lastPart IsNot Nothing AndAlso lastPart.StartsWith(fragmentLastPart) Then Return CompareResult.VisibleAndSelected
                If lastPart IsNot Nothing AndAlso lastPart.ToLower().Contains(fragmentLastPart.ToLower()) Then Return CompareResult.Visible
            End If

            Return CompareResult.Hidden
        End Function

        Public Overrides Function GetTextForReplace() As String
            If lastPart Is Nothing Then Return firstPart
            Return firstPart & ":" & lastPart
        End Function

        Public Overrides Sub OnSelected(ByVal popupMenu As AutocompleteMenu, ByVal e As SelectedEventArgs)
            e.Tb.BeginUpdate()
            e.Tb.Selection.BeginUpdate()
            Dim p1 = popupMenu.Fragment.Start
            Dim p2 = e.Tb.Selection.Start

            Dim i = e.Tb.Selection.ToLine
            Dim text As String = e.Tb.Lines(i)
            If text.Contains(")^()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")^()", ")^")
            End If

            If e.Tb.AutoIndent Then

                For iLine As Integer = p1.iLine + 1 To p2.iLine
                    e.Tb.Selection.Start = New Place(0, iLine)
                    e.Tb.DoAutoIndent(iLine)
                Next
            End If

            e.Tb.Selection.Start = p1

            While e.Tb.Selection.CharBeforeStart <> "^"c
                If Not e.Tb.Selection.GoRightThroughFolded() Then Exit While
            End While

            e.Tb.Selection.GoLeft(True)
            e.Tb.InsertText("")
            e.Tb.Selection.EndUpdate()
            e.Tb.EndUpdate()
        End Sub
    End Class

    Public Class MethodAutocompleteItem4
        Inherits MethodAutocompleteItem

        Private firstPart As String
        Private lastPart As String

        Public Sub New(ByVal text As String)
            MyBase.New(text)
            Dim i = text.LastIndexOf(">"c)

            If i < 0 Then
                firstPart = text
            Else
                firstPart = text.Substring(0, i)
                lastPart = text.Substring(i + 1)
            End If
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim i As Integer = fragmentText.LastIndexOf(">"c)

            If i < 0 Then
                If firstPart.StartsWith(fragmentText) AndAlso String.IsNullOrEmpty(lastPart) Then Return CompareResult.VisibleAndSelected
            Else
                Dim fragmentFirstPart = fragmentText.Substring(0, i)
                Dim fragmentLastPart = fragmentText.Substring(i + 1)
                If firstPart <> fragmentFirstPart Then Return CompareResult.Hidden
                If lastPart IsNot Nothing AndAlso lastPart.StartsWith(fragmentLastPart) Then Return CompareResult.VisibleAndSelected
                If lastPart IsNot Nothing AndAlso lastPart.ToLower().Contains(fragmentLastPart.ToLower()) Then Return CompareResult.Visible
            End If

            Return CompareResult.Hidden
        End Function

        Public Overrides Function GetTextForReplace() As String
            If lastPart Is Nothing Then Return firstPart
            Return firstPart & ">" & lastPart
        End Function

        Public Overrides Sub OnSelected(ByVal popupMenu As AutocompleteMenu, ByVal e As SelectedEventArgs)
            e.Tb.BeginUpdate()
            e.Tb.Selection.BeginUpdate()
            Dim p1 = popupMenu.Fragment.Start
            Dim p2 = e.Tb.Selection.Start

            Dim i = e.Tb.Selection.ToLine
            Dim text As String = e.Tb.Lines(i)
            If text.Contains(")^()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")^()", ")^")
            End If
            If text.Contains(")()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")()", ")")
            End If

            If e.Tb.AutoIndent Then

                For iLine As Integer = p1.iLine + 1 To p2.iLine
                    e.Tb.Selection.Start = New Place(0, iLine)
                    e.Tb.DoAutoIndent(iLine)
                Next
            End If

            e.Tb.Selection.Start = p1

            While e.Tb.Selection.CharBeforeStart <> "^"c
                If Not e.Tb.Selection.GoRightThroughFolded() Then Exit While
            End While

            e.Tb.Selection.GoLeft(True)
            e.Tb.InsertText("")
            e.Tb.Selection.EndUpdate()
            e.Tb.EndUpdate()
        End Sub
    End Class


    Private Class InsertSpaceSnippet
        Inherits AutocompleteItem

        Private pattern As String

        Public Overrides Property ToolTipTitle() As String
            Get
                Return Me.Text
            End Get
            Set(value As String)

            End Set
        End Property

        Public Sub New(pattern As String)
            MyBase.New("")
            Me.pattern = pattern
        End Sub

        Public Sub New()
            Me.New("^(\d+)([a-zA-Z_]+)(\d*)$")
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim result As CompareResult
            If Regex.IsMatch(fragmentText, Me.pattern) Then
                Me.Text = Me.InsertSpaces(fragmentText)
                If Me.Text <> fragmentText Then
                    result = CompareResult.Visible
                    Return result
                End If
            End If
            result = CompareResult.Hidden
            Return result
        End Function

        Public Function InsertSpaces(fragment As String) As String
            Dim i As Match = Regex.Match(fragment, Me.pattern)
            Dim result As String
            If i Is Nothing Then
                result = fragment
            Else
                If i.Groups(1).Value = "" AndAlso i.Groups(3).Value = "" Then
                    result = fragment
                Else
                    result = String.Concat(New String() {i.Groups(1).Value, " ", i.Groups(2).Value, " ", i.Groups(3).Value}).Trim()
                End If
            End If
            Return result
        End Function
    End Class

    Private Class InsertEnterSnippet
        Inherits AutocompleteItem

        Private enterPlace As Place = Place.Empty

        Public Overrides Property ToolTipTitle() As String
            Get
                Return "Insert line break after '}'"
            End Get
            Set(value As String)

            End Set
        End Property

        Public Sub New()
            MyBase.New("[Line break]")
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim r As Range = MyBase.Parent.Fragment.Clone()
            Dim result As CompareResult
            While r.Start.iChar > 0
                If r.CharBeforeStart = "}" Then
                    Me.enterPlace = r.Start
                    result = CompareResult.Visible
                    Return result
                End If
                r.GoLeftThroughFolded()
            End While
            result = CompareResult.Hidden
            Return result
        End Function

        Public Overrides Function GetTextForReplace() As String
            Dim r As Range = MyBase.Parent.Fragment
            Dim [end] As Place = r.[End]
            r.Start = Me.enterPlace
            r.[End] = r.[End]
            Return Environment.NewLine + r.Text
        End Function

        Public Overrides Sub OnSelected(popupMenu As AutocompleteMenu, e As SelectedEventArgs)
            MyBase.OnSelected(popupMenu, e)

            Dim i = e.Tb.Selection.ToLine
            Dim text As String = e.Tb.Lines(i)
            If text.Contains(")^()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")^()", ")^")
            End If
            If text.Contains(")()") Then
                e.Tb.Selection = e.Tb.GetLine(i)
                e.Tb.SelectedText = text.Replace(")()", ")")
            End If

            If MyBase.Parent.Fragment.tb.AutoIndent Then
                MyBase.Parent.Fragment.tb.DoAutoIndent()
            End If
        End Sub
    End Class
End Class
