Imports System.IO
Imports Druida_IDE_Lite.Objects

Public Class CodeInfo
    Public Shared knownTypes() As String = {"bool", "boolean", "byte", "char", "double", "float", "int", "long", "short", "word", "#define", "uint8_t", "uint16_t", "uint32_t", "int8_t", "int16_t", "int32_t", "void", "string"}
    Public Shared qualifiers() As String = {"const", "scope", "static", "internal", "extern", "virtual", "inline", "unsigned"}

    Structure ScopeInfo
        Shared scope As New List(Of Object)
        Shared selectedLine As UInt32
        Shared selectedEscopoObject As Object
        Shared selectedEscopoName As String
        Shared Sub UpdateEscopo()
            If scope.Count - 1 >= selectedLine Then
                selectedEscopoObject = scope(selectedLine)
                selectedEscopoName = selectedEscopoObject.getName
                mainAutoCompleteMenu.UpdateScope(selectedEscopoObject)
            End If
        End Sub
    End Structure

    Enum codeImages
        keyword
        variable
        constant
        classObject
        method
        classType
        library
        globalEscope
        objNamespace
    End Enum

    Structure HeaderFiles
        Shared DefaultHeader As String = Application.StartupPath & "\Headers\Default.ino"
        Shared DefaultHeaderEN As String = Application.StartupPath & "\Headers\DefaultEN.ino"
    End Structure

    Structure ModelFiles
        Shared ArduinoDefault As String = Application.StartupPath & "\ProjectModels\ArduinoDefault\ArduinoDefault.ino"
        Shared ArduinoDefaultEN As String = Application.StartupPath & "\ProjectModels\ArduinoDefaultEN\ArduinoDefaultEN.ino"
        Shared DruidaDefault As String = Application.StartupPath & "\ProjectModels\DruidaDefault\DruidaDefault.ino"
        Shared DruidaDefaultEn As String = Application.StartupPath & "\ProjectModels\DruidaDefaultEN\DruidaDefaultEN.ino"
        Shared DruidaInoDefault As String = Application.StartupPath & "\ProjectModels\DruidaDefault\Druida.ino"
        Shared DruidaInoDefaultEn As String = Application.StartupPath & "\ProjectModels\DruidaDefaultEn\Druida.ino"
    End Structure

    Public Class CodeSnippet
        Shared qualifiers() As String = {"unsigned", "static", "virtual", "extern", "const"}
        Shared dataTypes() As String = {"bool", "boolean", "byte", "char", "double", "float", "int", "long", "short", "word", "#define", "uint8_t", "uint16_t", "uint32_t", "int8_t", "int16_t", "int32_t", "void", "string"}
        Shared preDefinedVarTypes() As String = {"String ", "unsigned char ", "unsigned int ", "unsigned long ", "bool ", "boolean ", "byte ", "char ", "double", "float", "int ", "long ", "short ", "word ", "#define ", "const ", "uint8_t ", "uint16_t ", "uint32_t ", "int8_t ", "int16_t ", "int32_t ", "class ", "enum ", "void ", "struct ", "friend ", "extern ", "static ", "string ", "virtual "}
        Shared Function GetObjectName(item As String) As String
            Dim nome As String = item
            nome = TextTreatment.removeDoubleSpaces(nome)
            For Each type In preDefinedVarTypes
                nome = nome.Replace(type, "")
                nome = nome.Trim()
            Next
            If nome.Contains("//") Then
                nome = nome.Split("//")(0)
            End If
            If nome.Split("::").Count > 2 Then
                nome = nome.Split("::")(2)
            End If
            nome = nome.Replace(";", "")
            nome = nome.Replace("{", "")
            nome = nome.Replace("}", "")
            If nome.Contains(" ") And (Not nome.Contains("(") Or nome.Contains("=")) Then
                If nome.Contains("=") And nome.Contains("(") Then
                    If Not nome.IndexOf("=") > nome.IndexOf("(") Then
                        nome = nome.Split(" ")(0)
                    End If
                Else
                    nome = nome.Split(" ")(0)
                End If
            End If
            Return nome
        End Function

        Shared Function GetObjectDeclaration(item As String)
            Dim nome As String = item
            nome = TextTreatment.removeDoubleSpaces(nome)
            For Each type In preDefinedVarTypes
                If nome.Split(" ")(0) & " " = type And nome.Split(" ").Count > 1 Then
                    nome = nome.Remove(0, nome.IndexOf(" ")).Trim
                End If
            Next
            If nome.Contains("//") Then
                nome = nome.Split("//")(0)
            End If
            If nome.Split("::").Count > 2 Then
                nome = nome.Split("::")(2)
            End If
            nome = nome.Replace(";", "")
            nome = nome.Replace("{", "")
            nome = nome.Replace("}", "")
            Return nome
        End Function

        Shared Function GetInstanceName(item As String) As String
            Dim nome As String = item
            nome = TextTreatment.removeDoubleSpaces(nome)
            nome = nome.Split("(")(0)
            nome = nome.Split(" ")(1).Replace(";", "")
            Return nome
        End Function

        Shared Function IsComment(text As String) As Boolean
            Return text.Contains("//") And text.Split("//")(0).Trim = ""
        End Function

        Shared Function IsBlockComment(text As String) As Boolean
            Return text.Contains("/*") And text.Split("/*")(0).Trim = ""
        End Function

        Shared Function IsPublic(line As String)
            Static Dim auxIsPublic As Boolean = True
            If line.Contains("public:") Then auxIsPublic = True
            If line.Contains("private:") Then auxIsPublic = False
            Return auxIsPublic
        End Function

        Shared Function IsFather(obj As Object) As Boolean
            Return obj.GetType = GetType(objectList) Or obj.GetType = GetType(objClass) Or obj.GetType = GetType(objStructure)
        End Function

        Shared Function IsStructure(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objStructure)
        End Function

        Shared Function IsFunction(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objFunction)
        End Function

        Shared Function IsVars(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(List(Of objVariable))
        End Function

        Shared Function IsVar(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objVariable)
        End Function

        Shared Function IsClass(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objClass)
        End Function

        Shared Function IsClassInstance(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objClassInstance)
        End Function

        Shared Function IsLibrary(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objLibrary)
        End Function

        Shared Function IsNamespace(objectFinded As Object) As Boolean
            Return objectFinded.GetType = GetType(objectList)
        End Function

        Shared Function GetConstantValue(text As String) As String
            Dim name As String = GetObjectName(text)
            Dim value As String = ""
            Dim clearComment As String = text.Split("//")(0).Trim
            name = TextTreatment.removeDoubleSpaces(name)
            clearComment = TextTreatment.removeDoubleSpaces(clearComment)
            If text.Contains("#define") Then
                value = clearComment.Split(" ").Last
            ElseIf text.Contains("const") Then
                value = clearComment.Split("=").Last.Replace(";", "")
            Else
                Return ""
            End If
            If text.Contains("//") Then name = vbCrLf & name
            Return name & " = " & value.Trim
        End Function

        Shared Function GetTypeName(text As String)
            Dim name = TextTreatment.removeDoubleSpaces(text)
            name = name.TrimStart
            name = name.TrimEnd
            If qualifiers.Contains(name.Split(" ")(0)) Then
                name = name.Replace(name.Split(" ")(0), "").TrimStart()
            End If
            name = name.Split(" ")(0)
            Return name
        End Function

        Shared Function GetObjectType(text As String) As objectType
            If IsClass(text) Then Return objectType.classType
            If IsStruct(text) Then Return objectType.structType
            If IsInstance(text) Then Return objectType.instanceType
            If IsMethod(text) Then Return objectType.methodType
            If isVar(text) Then Return objectType.varType
            If isLibrary(text) Then Return objectType.libraryType
            Return Nothing
        End Function

        Shared foundedClasses As New List(Of String)

        Shared Function IsClass(text As String) As Boolean
            If GetTypeName(text) = "class" Then
                foundedClasses.Add(GetObjectName(text))
                Return True
            End If
            Return False
        End Function

        Shared Function IsStruct(text As String) As Boolean
            Return GetTypeName(text) = "struct"
        End Function

        Shared Function IsInstance(text As String) As Boolean
            Dim typeName As String = GetTypeName(text)
            Return foundedClasses.Contains(typeName)
        End Function

        Shared Function IsMethod(text As String) As Boolean
            Dim typeName As String = GetTypeName(text)
            Return dataTypes.Contains(typeName) And GetObjectName(text).Contains("(") And text.Contains(")")
        End Function

        Shared Function isVar(text As String) As Boolean
            Dim typeName As String = GetTypeName(text)
            Return dataTypes.Contains(typeName)
        End Function

        Shared Function isLibrary(text As String) As Boolean
            Return GetTypeName(text) = "#include"
        End Function

        Enum objectType
            classType
            structType
            instanceType
            methodType
            varType
            libraryType
        End Enum

        Shared Function GetItemCallName(text As String)
            Dim callName As String = text.TrimStart.TrimEnd
            callName = TextTreatment.removeDoubleSpaces(callName)
            callName = clearComment(callName)
            callName = callName.Replace(";", "")
            callName = callName.Replace("{", "")
            Return callName
        End Function

        Shared Function clearComment(line As String)
            If line.Contains("//") Then
                Return (line.Split("//")(0))
            End If
            Return (line)
        End Function

    End Class
End Class
