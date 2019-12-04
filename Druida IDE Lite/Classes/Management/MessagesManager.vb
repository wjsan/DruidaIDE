Module myMessagesManager
    Public outputMessages As New MessagesManager(controlConsole.Output.tbOutput)
End Module

Public Class MessagesManager
    Public myTextBox As TextBox
    Dim compilerMessages As New List(Of String)
    Dim objExplorerMessages As New List(Of String)
    Dim allMessages As New List(Of String)
    Dim filterStatus As Filter = Filter.None

    Structure TitleMsg
        Shared None As String = ""
        Shared Compiler As String = "Druida Ard Compiler 1.0: "
        Shared ObjectExplorer As String = "Druida Obj Explorer 1.0: "
    End Structure

    Enum Filter
        None
        Compiler
        ObjectExplorer
    End Enum

    Public Sub New(textBox As TextBox)
        myTextBox = textBox
    End Sub

    Public Sub AppendMessage(text As String, type As Filter)
        Select Case type
            Case Filter.None
                allMessages.Add(text)
                UpdateTextBox()
            Case Filter.Compiler
                AppendCompilerMessage(text)
            Case Filter.ObjectExplorer
                AppendObjExplorerMessage(text)
            Case Else

        End Select
    End Sub

    Private Sub AppendCompilerMessage(message As String)
        message = TitleMsg.Compiler & message
        compilerMessages.Add(message)
        allMessages.Add(message)
        UpdateTextBox()
    End Sub

    Private Sub AppendObjExplorerMessage(message As String)
        message = TitleMsg.ObjectExplorer & message
        objExplorerMessages.Add(message)
        allMessages.Add(message)
        UpdateTextBox()
    End Sub

    Public Function GetAllMessages() As List(Of String)
        Return allMessages
    End Function

    Public Function GetCompilerMessages() As List(Of String)
        Return compilerMessages
    End Function

    Public Function GetObjectExplorer() As List(Of String)
        Return objExplorerMessages
    End Function

    Public Sub UpdateTextBox()
        Select Case filterStatus
            Case Filter.None
                myTextBox.Lines = allMessages.ToArray
            Case Filter.Compiler
                myTextBox.Lines = compilerMessages.ToArray
            Case Filter.ObjectExplorer
                myTextBox.Lines = objExplorerMessages.ToArray
            Case Else

        End Select

        myTextBox.SelectionStart = myTextBox.TextLength
        myTextBox.ScrollToCaret()
    End Sub

    Public Sub SetFilter(filter As Filter)
        filterStatus = filter
        UpdateTextBox()
    End Sub

    Public Sub Clear()
        compilerMessages.Clear()
        objExplorerMessages.Clear()
        allMessages.Clear()
        UpdateTextBox()
    End Sub

End Class
