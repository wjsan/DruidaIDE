Public Class CodeFileManager

    Private directory As String = ""
    Private filePath As String = ""
    Private fileName As String = ""
    Private myCodeEditor As CodeEditorForArduino

    Public Sub New(ByRef CodeEditor As CodeEditorForArduino)
        myCodeEditor = CodeEditor
    End Sub

    ''' <summary>
    ''' Load source code file
    ''' </summary>
    Public Sub LoadFile()
        If (System.IO.File.Exists(filePath)) Then
            myCodeEditor.OpenFile(filePath, System.Text.Encoding.UTF8)
        Else
            MessageBox.Show("The source code file does not exist: " & filePath)
        End If
    End Sub

    ''' <summary>
    ''' Save source code file modifications
    ''' </summary>
    Public Sub saveFile()
        myCodeEditor.SaveToFile(filePath, System.Text.Encoding.UTF8)
    End Sub

    ''' <summary>
    ''' Save source code copy file with modifications
    ''' </summary>
    Public Sub saveFileAs(path As String)
        myCodeEditor.SaveToFile(path, System.Text.Encoding.UTF8)
    End Sub

    ''' <summary>
    ''' Returns only the name of source code file
    ''' </summary>
    ''' <returns></returns>
    Public Function getFileName() As String
        fileName = filePath.Split("\")(filePath.Split("\").Length - 1) ' & vbLf
        Return fileName
    End Function

    ''' <summary>
    ''' Get current path of source code file
    ''' </summary>
    ''' <returns></returns>
    Public Function getFilePath()
        Return (filePath)
    End Function

    ''' <summary>
    ''' Set path of source code file
    ''' </summary>
    ''' <param name="newFilePath">Complete path of source code file</param>
    Public Sub setFilePath(newFilePath As String)
        If System.IO.File.Exists(newFilePath) Then
            filePath = newFilePath
            LoadFile()
        End If
    End Sub
End Class
