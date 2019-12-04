Imports System.IO

Public Class CodeObjects

    Public Class CodeScope
        Dim myName As String
        Public Escopes As List(Of CodeScope)
        Public Types As List(Of ItemType)
        Public Variables As List(Of Variable)
        Public Methods As List(Of Method)
        Public TreeNode As TreeNode
        Dim myCodeFile As FileInfo
        Dim myLine As UInt16
        Public Sub New(name As String, file As FileInfo, line As UInt16)
            myName = name
            myCodeFile = file
            myLine = line
        End Sub
    End Class

    Public Class ItemType
        Dim myName As String
        Dim myEscope As CodeScope
        Public TreeNode As TreeNode
        Public Sub New(name As String, escope As CodeScope)
            myName = name
            myEscope = escope
        End Sub
        Public Function getName()
            Return myName
        End Function
    End Class

    Public Class Variable
        Dim myName As String
        Dim myType As ItemType
        Dim myEscope As CodeScope
        Dim myCodeFile As FileInfo
        Public TreeNode As TreeNode
        Public Sub New(name As String, type As ItemType, escope As CodeScope, filePath As String)
            myName = name
            myType = type
            myEscope = escope
            myCodeFile = New FileInfo(filePath)
        End Sub
    End Class

    Public Class Method
        Dim myName As String
        Dim myType As ItemType
        Dim myEscope As CodeScope
        Dim myCodeFile As FileInfo
        Public TreeNode As TreeNode
        Public Sub New(name As String, type As ItemType, escope As CodeScope, filePath As String)
            myName = name
            myType = type
            myEscope = escope
            myCodeFile = New FileInfo(filePath)
        End Sub
    End Class

End Class