Imports Druida_IDE_Lite.CodeObjects
Imports Druida_IDE_Lite.CodeInfo

Public Class CodeElementIndetfier

    Public Class CodeSnippet
        Private typesToFind As List(Of ItemType)

        Public Sub New(codeScope As CodeScope)
            typesToFind = codeScope.Types
        End Sub

        Public Function GetObjectName(item As String) As String
            Dim nome As String = item
            nome = TextTreatment.removeDoubleSpaces(nome)
            For Each type In typesToFind
                nome = nome.Replace(type.getName, "")
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

        Public Function GetInstanceName(item As String) As String
            Dim nome As String = item
            nome = TextTreatment.removeDoubleSpaces(nome)
            nome = nome.Split("(")(0)
            nome = nome.Split(" ")(1).Replace(";", "")
            Return nome
        End Function

        Public Function IsComment(text As String) As Boolean
            Return text.Contains("//") And text.Split("//")(0).Trim = ""
        End Function

        Public Function IsBlockComment(text As String) As Boolean
            Return text.Contains("/*") And text.Split("/*")(0).Trim = ""
        End Function

        Public Function IsPublic(line As String)
            Static Dim auxIsPublic As Boolean = True
            If line.Contains("public:") Then auxIsPublic = True
            If line.Contains("private:") Then auxIsPublic = False
            Return auxIsPublic
        End Function

        Public Function GetConstantValue(text As String) As String
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

        Public Function GetTypeName(text As String)
            Dim name = TextTreatment.removeDoubleSpaces(text)
            name = name.TrimStart
            name = name.TrimEnd
            If qualifiers.Contains(name.Split(" ")(0)) Then
                name = name.Replace(name.Split(" ")(0), "").TrimStart()
            End If
            name = name.Split(" ")(0)
            Return name
        End Function

        Public Function GetObjectType(text As String) As objectType
            If IsClass(text) Then Return objectType.classType
            If IsStruct(text) Then Return objectType.structType
            If IsInstance(text) Then Return objectType.instanceType
            If IsMethod(text) Then Return objectType.methodType
            If isVar(text) Then Return objectType.varType
            If isLibrary(text) Then Return objectType.libraryType
            Return Nothing
        End Function

        Shared foundedClasses As New List(Of String)

        Public Function IsClass(text As String) As Boolean
            If GetTypeName(text) = "class" Then
                foundedClasses.Add(GetObjectName(text))
                Return True
            End If
            Return False
        End Function

        Public Function IsStruct(text As String) As Boolean
            Return GetTypeName(text) = "struct"
        End Function

        Public Function IsInstance(text As String) As Boolean
            Dim typeName As String = GetTypeName(text)
            Return foundedClasses.Contains(typeName)
        End Function

        Public Function IsMethod(text As String) As Boolean
            Dim typeName As String = GetTypeName(text)
            Return knownTypes.Contains(typeName) And GetObjectName(text).Contains("(") And text.Contains(")")
        End Function

        Public Function isVar(text As String) As Boolean
            Dim typeName As String = GetTypeName(text)
            Return knownTypes.Contains(typeName)
        End Function

        Public Function isLibrary(text As String) As Boolean
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

        Public Function GetItemCallName(text As String)
            Dim callName As String = text.TrimStart.TrimEnd
            callName = TextTreatment.removeDoubleSpaces(callName)
            callName = clearComment(callName)
            callName = callName.Replace(";", "")
            callName = callName.Replace("{", "")
            Return callName
        End Function

        Public Function clearComment(line As String)
            If line.Contains("//") Then
                Return (line.Split("//")(0))
            End If
            Return (line)
        End Function

    End Class
End Class
