Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.CodeObjects
Imports System.IO

Public Class CodeDataBase
    Private CodeEditor As CodeEditorForArduino
    Private CodeMap As CodeScope
    Private treeNode As TreeNode

    Public Sub New(file As FileInfo)
        Dim newCode As New CodeEditorForArduino
        Dim codeMap As New CodeScope(file.Name, file, 0)
        newCode.OpenFile(file.FullName)
    End Sub
End Class
