Imports Druida_IDE_Lite.CodeInfo

Class Objects
    Shared currentText As String()
    Shared textBkp As String
    Shared constructors As New List(Of String)
    'Shared preDefinedObjectTypes() As String = {"String"}
    Shared preDefinedVarTypes() As String = {"bool ", "boolean ", "byte ", "char ", "double", "float", "int ", "long ", "short ", "unsigned char ", "unsigned int ", "unsigned long ", "word ", "#define ", "const ", "uint8_t ", "uint16_t ", "uint32_t ", "int8_t ", "int16_t ", "int32_t "}
    Shared preDefinedFuncTypes() As String = {"String", "bool ", "boolean ", "byte ", "char ", "double", "float", "int ", "long ", "short ", "unsigned char ", "unsigned int ", "unsigned long ", "word ", "#define ", "const ", "uint8_t ", "uint16_t ", "uint32_t ", "int8_t ", "int16_t ", "int32_t "}
    Shared detectedClasses As New List(Of objClass)
    Shared namespaces As New List(Of objectList)

    Shared Function searchFatherInLine(line As String, index As String)
        line = TextTreatment.removeDoubleSpaces(line)
        line = line.Replace("virtual ", "").TrimStart
        line = line.Replace("friend ", "").TrimStart
        line = line.Replace("inline ", "").TrimStart
        Dim text As String = CodeSnippet.clearComment(line)
        text = TextTreatment.removeDoubleSpaces(text)
        If line.Contains("#define") Then Return Nothing
        If text.Contains("namespace ") Then
            Dim name As String = text.Replace("namespace ", "")
            name = TextTreatment.removeDoubleSpaces(name).Replace("{", "").Trim
            Dim objNameSpace As New objectList(name)
            objNameSpace.setIndex(index)
            Return objNameSpace
        End If
        If text.Contains("class ") Or text.Contains("struct ") Then
            Dim construct As String = CodeSnippet.GetObjectName(text)
            Dim newClass As New objClass(line.Trim, index)
            getInheritsMethods(newClass, text)
            constructors.Add(construct)
            detectedClasses.Add(newClass)
            Return newClass
        End If
        'If text.Contains("extern ") Then
        '    Return New objStructure(line.Trim, index)
        'End If
        If line.Contains("enum ") Then
            Dim enumStruct As objStructure = New objStructure(line.Trim.Replace("{", ""), index)
            If line.Contains("{") And line.Contains("}") Then
                Dim vars As List(Of String) = line.Split("{")(1).Split("}")(0).Split(",").ToList
                For Each item In vars
                    enumStruct.addVar(New objVariable("const " & item & "\\" & item & " = " & vars.IndexOf(item), index))
                Next
                Return enumStruct
            End If
            Dim enumText As String = line
            Dim i As UInt16 = index
            Dim cont As UInt16 = 0
            Dim varList As New List(Of objVariable)
            i += 1
            While Not currentText(i).Contains("}")
                If currentText(i).Trim.Replace("{", "").Count > 0 Then
                    enumText = currentText(i).Trim.Replace(",", "")
                    enumText = enumText & " //" & enumText & " = " & cont
                    varList.Add(New objVariable("const " & enumText, i))
                    cont += 1
                End If
                i += 1
            End While
            enumStruct.variables.AddRange(varList)
            Return enumStruct
        End If
        If text.Contains("void ") Then
            Return New objFunction(TextTreatment.removeDoubleSpaces(line.Trim), index)
        End If
        For Each construct In constructors
            Dim textVal As String = text.TrimStart
            textVal = TextTreatment.removeDoubleSpaces(textVal)
            textVal = textVal.Split(" ")(0)
            If textVal.Contains(construct & "(") Then
                If text.Contains(";") Then
                    Return New objFunction(TextTreatment.removeDoubleSpaces(line), index)
                Else
                    Dim constructText As String = text
                    Dim i As UInt16 = index
                    While Not constructText.Contains(";")
                        i += 1
                        constructText &= currentText(i).TrimStart
                        If i = currentText.Count - 1 Then Exit While
                    End While
                    Return New objFunction(constructText, index)
                End If
            End If
        Next
        For Each var In preDefinedFuncTypes
            Dim textVal As String = text.TrimStart
            textVal = TextTreatment.removeDoubleSpaces(textVal)
            If textVal.Split(" ").Count < 2 Then Exit For
            textVal = textVal.Split(" ")(0) & " " & textVal.Split(" ")(1)
            If textVal.Contains(var) And text.Contains("(") And text.Contains(")") Then
                If text.Contains("=") And (text.IndexOf("=") < text.IndexOf("(")) Then
                    Exit For
                End If
                Return New objFunction(TextTreatment.removeDoubleSpaces(line.Trim), index)
            End If
        Next
        Return Nothing
    End Function

    Shared Function getInheritsMethods(ByRef classObj As objClass, ByVal declaration As String)
        Dim text As String = TextTreatment.removeDoubleSpaces(declaration)
        If text.Contains(": public") And text.Split(":").Count > 0 Then
            Dim className As String = text.Split(":")(1).Replace("public", "").Replace("{", "")
            If className.Contains(",") Then
                Dim classNames() As String = className.Trim.Split(",")
                For Each className In classNames
                    MergeInheritsClasse(classObj, className.Trim)
                Next
            Else
                className = className.TrimStart.TrimEnd
                MergeInheritsClasse(classObj, className)
            End If
        End If
    End Function

    Private Shared Sub MergeInheritsClasse(classObj As objClass, className As String)
        For Each classIncluded As objClass In detectedClasses
            If className = classIncluded.getName().Replace("class ", "").Replace(";", "") Then
                classObj.addMethods(classIncluded.publicFunctions)
            End If
        Next
    End Sub

    Shared Function searchVarInLine(line As String, index As String)
        line = TextTreatment.removeDoubleSpaces(line)
        'If line.Contains("#define") Then
        '    Dim text = line.Split(" ")(1)
        '    Return New objVariable(text.Trim, index)
        'End If
        Try
            If line.IndexOf("[") < line.IndexOf("]") Then
                line = line.Remove(line.IndexOf("["), line.IndexOf("]") - line.IndexOf("[") + 1)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
        If index > 0 Then
            If currentText(index - 1).Contains("enum ") Then
                'Return New objStructure(line.Trim, index)
                Dim enumText As String = line
                Dim i As UInt16 = index
                Dim cont As UInt16 = 0
                Dim varList As New List(Of objVariable)
                While Not enumText.Contains("};")
                    i += 1
                    enumText = currentText(i).Trim.Replace(",", "")
                    enumText = enumText & " //" & enumText & " = " & cont
                    varList.Add(New objVariable("#define" & " " & enumText, i))
                    cont += 1
                End While
                Return varList
            End If
        End If
        For Each var In preDefinedVarTypes
            Dim text As String = line.Replace("*", "")
            'If line.Contains("=") Then text = line.Split("=")(0)
            If text.Contains(var) And VerifyParenthesis(text) Then
                If text.Contains(",") And Not text.Contains("#define") And Not text.Contains("{") Then
                    Dim varList As New List(Of objVariable)
                    If text.IndexOf(",") > text.IndexOf("//") And text.IndexOf("//") <> -1 Then
                        Return New objVariable(text.Trim, index)
                    End If
                    For Each uVar In text.Split(",")
                        Dim tipo = text.TrimStart.Split(" ")(0)
                        uVar = uVar.Replace(tipo, "")
                        varList.Add(New objVariable(tipo & " " & uVar.Trim, index))
                    Next
                    Return varList
                Else
                    Return New objVariable(text.Trim, index)
                End If
            End If
        Next
        Return Nothing
    End Function

    Shared Function VerifyParenthesis(text As String) As Boolean
        text = CodeInfo.CodeSnippet.clearComment(text)
        If text.Contains("(") Or text.Contains(")") Then
            If text.Contains("=") Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Shared Function searchClassInstanceInLine(line As String, index As String, origem As Object)
        Dim text As String = line.Replace("extern ", "")
        Dim libs As List(Of objLibrary)
        Dim classes As New List(Of objClass)
        classes.AddRange(origem.classes)
        classes.AddRange(mainAutoCompleteMenu.GetInitialClasses())
        If origem.GetType Is GetType(objectList) Then
            libs = origem.getLibs()
            For Each librarie In libs
                classes.addRange(librarie.classes)
            Next
        End If

        For Each item In classes
            If item.GetType = GetType(objClass) Then
                Dim className As String = item.getName.Replace("class ", "").trim.Replace("struct ", "").Trim
                className = className.Split(":")(0).TrimEnd
                Dim removeComment = CodeInfo.CodeSnippet.clearComment(text)
                If removeComment.Trim.Contains(className & " ") And Not removeComment.Trim.Contains("class ") And Not removeComment.Trim.Contains("struct ") Then
                    If line.Contains("extern ") Then
                        CodeInfo.ScopeInfo.scope(0).addClassInstance(New objClassInstance(text.Trim.Replace("static ", ""), index, item))
                    End If
                    Return New objClassInstance(text.Trim.Replace("static ", ""), index, item)
                End If
            End If
        Next
        'If origem.GetType Is GetType(objectList) Then
        '    Dim obj As objectList = origem
        '    For Each library As objLibrary In obj.libraries
        '        For Each item In library.classes
        '            If item.GetType = GetType(objClass) Then
        '                Dim className As String = item.getName.Replace("class ", "").trim.Replace("struct ", "").trim
        '                className = className.Split(":")(0).TrimEnd
        '                If text.Trim.Split("//")(0).Contains(className & " ") And Not text.Trim.Contains("class ") And Not text.Trim.Contains("struct ") Then
        '                    Return New objClassInstance(text.Trim.Replace("static ", ""), index, item)
        '                End If
        '            End If
        '        Next
        '    Next
        'End If
        Return Nothing
    End Function

    'Shared Function searchStructInstanceInLine(line As String, index As String, origem As Object)
    '    Dim text As String = line
    '    For Each item In origem.Structures
    '        If item.GetType = GetType(objClass) Then
    '            Dim structName As String = item.getName.Replace("struct ", "").trim
    '            If text.Trim.Contains(structName & " ") And Not text.Trim.Contains("struct ") Then
    '                Return New objClassInstance(text.Trim, index, item)
    '            End If
    '        End If
    '    Next
    '    If origem.GetType Is GetType(objStructure) Then
    '        Dim obj As objectList = origem
    '        For Each library As objLibrary In obj.libraries
    '            For Each item In library.classes
    '                If item.GetType = GetType(objStructure) Then
    '                    Dim structName As String = item.getName.Replace("struct ", "").trim
    '                    If text.Trim.Contains(structName & " ") And Not text.Trim.Contains("struct ") Then
    '                        Return New objClassInstance(text.Trim, index, item)
    '                    End If
    '                End If
    '            Next
    '        Next
    '    End If
    '    Return Nothing
    'End Function


    Shared Function searchLibraryInLine(line As String, index As String)
        If line.Contains("#include ") Then
            Dim nome As String = line.Replace("#include ", "")
            nome = nome.Replace("""", "")
            nome = nome.Replace("<", "")
            nome = nome.Replace(">", "")
            Dim newlib As New objLibrary(nome, index)
            If System.IO.File.Exists(newlib.getPath) Then
                Return New objLibrary(nome, index)
            End If
        End If
        Return Nothing
    End Function

    Shared Sub SetCurrentText(text As String)
        currentText = text.Split(vbLf)
        textBkp = text
    End Sub

    Shared Function GetCurrentText() As String
        Return textBkp
    End Function

    Class objectList
        Private name As String
        Public index As UInt16
        Public nameSpaces As New List(Of objectList)
        Public types As New List(Of objType)
        Public varTypes As New List(Of objVarType)
        Public classes As New List(Of objClass)
        Public ClassInstances As New List(Of objClassInstance)
        Public functions As New List(Of objFunction)
        Public Structures As New List(Of objStructure)
        Public variables As New List(Of objVariable)
        Public libraries As New List(Of objLibrary)
        Private imgIndex As UInt16 = 0
        Private endIndex As UInt16 = 0
        Private descr As String

        Public Sub setEndIndex(ByVal _index As UInt16)
            endIndex = _index
        End Sub

        Public Sub setIndex(ByVal _index As UInt16)
            index = _index
        End Sub

        Public Function getIndex() As UInt16
            Return index
        End Function

        Public Function getDescr()
            Return descr
        End Function

        Public Sub New(_name As String)
            name = _name
            If name <> "Global" Then
                imgIndex = CodeInfo.codeImages.objNamespace
                If _name.Contains("//") Then
                    descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                    _name = _name.Split("//")(0)
                End If
                name = _name
                Exit Sub
            End If
            For Each item In preDefinedVarTypes
                varTypes.Add(New objVarType(item))
            Next
            'For Each item In preDefinedObjectTypes
            '    types.Add(New objType(item))
            'Next
        End Sub

        Public Function getName()
            Return (name)
        End Function

        Public Sub addClass(objClass As objClass)
            classes.Add(objClass)
        End Sub

        Public Sub addClassInstance(objClassInstance As objClassInstance)
            ClassInstances.Add(objClassInstance)
        End Sub

        Public Sub addVar(objVar As objVariable)
            variables.Add(objVar)
        End Sub

        Public Sub addFunction(objFunction As objFunction)
            functions.Add(objFunction)
        End Sub

        Public Sub addStructure(objStructure As objStructure)
            Structures.Add(objStructure)
        End Sub

        Public Sub addLibrary(objLibrary As objLibrary)
            If objLibrary.getPath IsNot Nothing Then
                libraries.Add(objLibrary)
                'classes.AddRange(objLibrary.classes)
                'ClassInstances.AddRange(objLibrary.ClassInstances)
                'functions.AddRange(objLibrary.functions)
                'Structures.AddRange(objLibrary.Structures)
                'variables.AddRange(objLibrary.variables)
            End If
        End Sub

        Public Sub addNamespace(objNamespace As objectList)
            nameSpaces.Add(objNamespace)
        End Sub

        Public Sub removeLib(name As String)
            For Each item In Me.libraries
                If item.getName = name Then
                    Me.libraries.Remove(item)
                    Exit For
                End If
            Next
        End Sub

        Public Function searchObjectInLine(line As String, index As UInt16)
            Dim father = searchFatherInLine(line, index)
            If father IsNot Nothing Then Return (father)
            Dim var = searchVarInLine(line, index)
            If var IsNot Nothing Then Return (var)
            Dim instance = searchClassInstanceInLine(line, index, Me)
            If instance IsNot Nothing Then Return instance
            Dim library = searchLibraryInLine(line, index)
            If library IsNot Nothing Then Return library
            Return Nothing
        End Function

        Public Sub clear()
            detectedClasses.Clear()
            classes.Clear()
            functions.Clear()
            Structures.Clear()
            variables.Clear()
            ClassInstances.Clear()
            nameSpaces.Clear()
            'libraries.Clear()
            constructors.Clear()
        End Sub

        Public Sub clearAll()
            detectedClasses.Clear()
            classes.Clear()
            functions.Clear()
            Structures.Clear()
            variables.Clear()
            ClassInstances.Clear()
            libraries.Clear()
            constructors.Clear()
        End Sub

        Public Function getLibs() As List(Of objLibrary)
            Dim libs As New List(Of objLibrary)
            For Each item In Me.libraries
                libs.Add(item)
                libs.AddRange(item.getLibs)
            Next
            Return libs
        End Function

        Public Function getImage()
            Return imgIndex
        End Function

    End Class

    Class objVarType

        Private name As String

        Public Sub New(_name As String)
            name = _name
        End Sub

    End Class

    Class objType

        Private name As String

        Public Sub New(_name As String)
            name = _name
        End Sub
    End Class

    Class objClass
        Private name As String
        Private index As UInt16
        Private descr As String
        Private endIndex As UInt16
        Private imgIndex As UInt16 = codeImages.classType
        Public functions As New List(Of objFunction)
        Public variables As New List(Of objVariable)
        Public publicFunctions As New List(Of objFunction)
        Public publicVariables As New List(Of objVariable)
        Private ReadOnly preDefinedVarTypes() As String = {"bool", "boolean", "byte", "char", "double", "float", "int", "long", "short", "unsigned char", "unsigned int", "unsigned long", "vetor", "word"}
        Public classes As New List(Of objClass)
        Public ClassInstances As New List(Of objClassInstance)
        Public Structures As New List(Of objStructure)

        Public Sub New(_name As String, _index As UInt16)
            If _name.Contains("//") Then
                descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                _name = _name.Split("//")(0)
            End If
            If _name.Contains(":") Then
                _name = _name.Split(":")(0)
            End If
            name = _name.Split("{")(0).Trim
            index = _index
        End Sub

        Public Sub addVar(objVar As objVariable)
            variables.Add(objVar)
        End Sub

        Public Sub addPublicVar(objVar As objVariable)
            publicVariables.Add(objVar)
        End Sub

        Public Sub addClass(objClass As objClass)
            classes.Add(objClass)
        End Sub

        Public Sub addClassInstance(objClassInstance As objClassInstance)
            ClassInstances.Add(objClassInstance)
        End Sub

        Public Sub addFunction(objFunction As objFunction)
            functions.Add(objFunction)
        End Sub

        Public Sub addMethods(methods As List(Of objFunction))
            publicFunctions.AddRange(methods)
        End Sub

        Public Sub addPublicFunction(objFunction As objFunction)
            publicFunctions.Add(objFunction)
        End Sub

        Public Sub setEndIndex(ByVal _index As UInt16)
            endIndex = _index
        End Sub

        Public Function getEndIndex()
            Return (endIndex)
        End Function

        Public Function getName() As String
            Return (name)
        End Function

        Public Function getDescr()
            Return descr
        End Function

        Public Function getImage()
            Return imgIndex
        End Function

        Public Sub addStructure(objStructure As objStructure)
            Structures.Add(objStructure)
        End Sub

        Public Function getIndex()
            Return (index)
        End Function

        Public Function searchObjectInLine(line As String, index As UInt16)
            Dim father = searchFatherInLine(line, index)
            If father IsNot Nothing Then Return (father)
            Dim var = searchVarInLine(line, index)
            If var IsNot Nothing Then Return (var)
            Dim instance = searchClassInstanceInLine(line, index, CodeInfo.ScopeInfo.scope(0))
            If instance IsNot Nothing Then Return instance
            Return Nothing
            Return Nothing
        End Function

        Public Sub clear()
            classes.Clear()
            functions.Clear()
            variables.Clear()
        End Sub
    End Class

    Class objClassInstance
        Private name As String
        Private index As UInt16
        Private descr As String
        Private imgIndex = codeImages.classObject
        Private classFather As objClass
        Public variables As New List(Of objVariable)

        Public Sub New(_name As String, _index As UInt16, _classFather As objClass)
            If _name.Contains("//") Then
                descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                _name = _name.Split("//")(0)
            End If
            If _name.Contains("[") Then _name = _name.Split("[")(0)
            _name = _name.Split("=")(0)
            name = _name.Trim
            index = _index
            classFather = _classFather
        End Sub

        Public Function getName() As String
            Return (name)
        End Function

        Public Function getDescr() As String
            Return descr
        End Function

        Public Function getIndex() As UInt16
            Return index
        End Function

        Public Function getImage() As UInt16
            Return imgIndex
        End Function

        Public Function getVars() As List(Of objVariable)
            Dim vars As New List(Of objVariable)
            For Each item In classFather.publicVariables
                vars.Add(item)
            Next
            Return vars
        End Function

        Public Function getMethods() As List(Of objFunction)
            Dim method As New List(Of objFunction)
            For Each item In classFather.publicFunctions
                method.Add(item)
            Next
            Return method
        End Function

        Public Function getClassName()
            Return classFather.getName()
        End Function

    End Class

    Class objStructInstance
        Private name As String
        Private index As UInt16
        Private descr As String
        Private imgIndex = codeImages.classObject
        Private classFather As objClass
        Public variables As New List(Of objVariable)

        Public Sub New(_name As String, _index As UInt16, _classFather As objClass)
            If _name.Contains("//") Then
                descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                _name = _name.Split("//")(0)
            End If
            _name = _name.Split("=")(0)
            name = _name.Trim
            index = _index
            classFather = _classFather
        End Sub

        Public Function getName()
            Return (name)
        End Function

        Public Function getDescr()
            Return descr
        End Function

        Public Function getIndex()
            Return index
        End Function

        Public Function getImage()
            Return imgIndex
        End Function

        Public Function getVars() As List(Of objVariable)
            Dim vars As New List(Of objVariable)
            For Each item In classFather.publicVariables
                vars.Add(item)
            Next
            Return vars
        End Function

        Public Function getMethods() As List(Of objFunction)
            Dim method As New List(Of objFunction)
            For Each item In classFather.publicFunctions
                method.Add(item)
            Next
            Return method
        End Function

        Public Function getClassName()
            Return classFather.getName()
        End Function

    End Class

    Class objStructure

        Private name As String
        Private index As UInt16
        Private endIndex As UInt16
        Private descr As String
        Private imgIndex As UInt16 = codeImages.classType
        Public variables As New List(Of objVariable)
        Public ClassInstances As New List(Of objClassInstance)

        Public Sub New(_name As String, _index As UInt16)
            If _name.Contains("//") Then
                descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                _name = _name.Split("//")(0)
            End If
            name = _name.Trim
            index = _index
        End Sub

        Public Sub addVar(objVar As objVariable)
            variables.Add(objVar)
        End Sub

        Public Function getName()
            Return (name)
        End Function

        Public Function getIndex()
            Return (index)
        End Function

        Public Sub setEndIndex(ByVal index As UInt16)
            endIndex = index
        End Sub

        Public Function getEndIndex()
            Return (endIndex)
        End Function

        Public Function getImage()
            Return imgIndex
        End Function

        Public Function getDescr()
            Return descr
        End Function

        Public Function searchObjectInLine(line As String, index As UInt16)
            Dim var = searchVarInLine(line, index)
            If var IsNot Nothing Then Return (var)
            Return Nothing
        End Function

        Public Sub clear()
            variables.Clear()
        End Sub

    End Class

    Class objFunction

        Private name As String
        Private popMenuText As String
        Private index As UInt16
        Private descr As String
        Private endIndex As UInt16
        Private imgIndex As UInt16 = codeImages.method
        Public variables As New List(Of objVariable)
        Public ClassInstances As New List(Of objClassInstance)
        Public parameters As New List(Of objVariable)

        Public Sub New(_name As String, _index As UInt16)
            If _name.Contains("//") Then
                descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                _name = _name.Split("//")(0)
            End If
            If _name.Contains("{") Then
                _name = _name.Remove(_name.IndexOf("{"))
            End If
            name = _name.Trim
            index = _index
            If (_name.Contains("(") And _name.Contains(")")) Then
                setParameters(_name)
            End If
            setPopMenuText()
        End Sub

        Private Sub setParameters(ByVal declr As String)
            If declr.Contains("(") And declr.Contains(")") Then
                Dim param As String
                Try
                    param = declr.Remove(declr.IndexOf(")")).Substring(declr.IndexOf("(") + 1)
                Catch ex As Exception
                    Exit Sub
                End Try
                If param.Contains(",") Then
                    Dim varList As New List(Of objVariable)
                    For Each uVar In param.Split(",")
                        varList.Add(New objVariable(uVar.Trim, index))
                    Next
                    variables.AddRange(varList)
                    parameters.AddRange(varList)
                ElseIf param <> "" Then
                    Dim myVar = New objVariable(param, index)
                    If myVar IsNot Nothing Then
                        variables.Add(myVar)
                        parameters.Add(myVar)
                    End If
                End If
            End If
        End Sub

        Private Sub setPopMenuText()
            Dim myName = CodeSnippet.GetObjectName(name)
            If parameters.Count > 0 Then
                popMenuText = myName.Split("(")(0) & "(^"
                For i = 0 To parameters.Count - 1
                    If i = parameters.Count - 1 Then Exit For
                    popMenuText &= ", "
                Next
                popMenuText &= ")"
            Else
                popMenuText = myName & "^"
            End If
        End Sub

        Public Sub addClassInstance(objClassInstance As objClassInstance)
            ClassInstances.Add(objClassInstance)
        End Sub

        Public Sub addVar(objVar As objVariable)
            variables.Add(objVar)
        End Sub

        Public Function getName() As String
            Return (name)
        End Function

        Public Function getIndex()
            Return (index)
        End Function

        Public Sub setEndIndex(ByVal index As UInt16)
            endIndex = index
        End Sub

        Public Function getEndIndex()
            Return (endIndex)
        End Function

        Public Function getImage()
            Return imgIndex
        End Function

        Public Function getDescr() As String
            Return descr
        End Function

        Public Function getPopMenuText()
            'If popMenuText.Contains(".") Then popMenuText = popMenuText.Split(".")(1)
            Return popMenuText
        End Function

        Public Function searchObjectInLine(line As String, index As UInt16)
            Dim var = searchVarInLine(line, index)
            If var IsNot Nothing Then Return (var)
            Dim instance = searchClassInstanceInLine(line, index, CodeInfo.ScopeInfo.scope(0))
            If instance IsNot Nothing Then Return instance
            Return Nothing
        End Function

        Public Sub clear()
            variables.Clear()
        End Sub
    End Class

    Class objVariable

        Private name As String
        Private index As UInt16
        Private descr As String
        Private imgIndex As UInt16 = 0

        Public Sub New(_name As String, _index As UInt16)
            _name = TextTreatment.removeDoubleComments(_name)
            If _name.Contains("//") Then
                descr = _name.Split("//")(2).Replace("\n", vbCrLf)
                _name = _name.Split("//")(0)
            End If
            _name = _name.Replace(" +", "")
            _name = _name.Split("=")(0)
            name = _name.Trim
            index = _index
            If name.Contains("const ") Or name.Contains("#define ") Then
                imgIndex = codeImages.constant
                descr &= CodeSnippet.GetConstantValue(currentText(_index))
            Else
                imgIndex = codeImages.variable
            End If
        End Sub

        Public Function getName() As String
            Return (name)
        End Function

        Public Function getIndex()
            Return (index)
        End Function

        Public Function getImage()
            Return imgIndex
        End Function

        Public Function getDescr() As String
            Return descr
        End Function

        Public Function searchObjectInLine(line As String, index As UInt16)
            Dim var = searchVarInLine(line, index)
            If var IsNot Nothing Then Return (var)
            Return Nothing
        End Function
    End Class

    Class objLibrary
        Inherits objectList
        Private path As String
        Private imgIndex As UInt16 = codeImages.library
        Private index As UInt16
        Private descr As String = ""

        Public Sub New(_name As String, _index As UInt16)
            MyBase.New(_name.Split("//")(0).TrimEnd)
            path = getPath()
            index = _index
        End Sub

        Public Function getPath() As String
            Dim fileName As String = getName.trim.split(" ")(0)
            Dim newFileOperation As New FileOperations
            ''Dim folderName As String = getName.split(".")(0)
            'Dim localPath As String = CurrentProjectInfo.DirectoryPaths.projectDirectory
            'Dim coreLib As String = IDEcfgs.Values.Directories.ArduinoCoreLib
            'Dim defaultLibs As String = IDEcfgs.Values.Directories.ArduinoDefaultLib
            'Dim libs As String = IDEcfgs.Values.Directories.ArduinoLib
            'Dim filePath As String = ""
            'filePath = newFileOperation.SearchFileInDir(fileName, localPath)
            'If filePath IsNot Nothing Then Return filePath
            'filePath = newFileOperation.SearchFileInDir(fileName, coreLib)
            'If filePath IsNot Nothing Then Return filePath
            'filePath = newFileOperation.SearchFileInDir(fileName, defaultLibs)
            'If filePath IsNot Nothing Then Return filePath
            'filePath = newFileOperation.SearchFileInDir(fileName, libs)
            'If filePath IsNot Nothing Then Return filePath
            Return newFileOperation.GetLibDir(fileName)
        End Function

        Public Function getIndex() As UInt16
            Return index
        End Function

        Public Function getImage() As UInt16
            Return imgIndex
        End Function

        Public Function getTextCode() As String
            Return System.IO.File.ReadAllText(path, System.Text.Encoding.Default)
        End Function

        Public Function getDescr() As String
            Return descr
        End Function
    End Class
End Class