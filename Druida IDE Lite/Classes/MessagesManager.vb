Public Class MessagesManager
    Private ErrorMessages As List(Of String)
    Private AdviseMessages As List(Of String)
    Private InfoMessages As List(Of String)
    Private MyMsgList As ListBox
    Private Filter As UInt16

    Structure FilterStatus
        Shared None As Short = 0
        Shared Errors As Short = 1
        Shared Advises As Short = 2
        Shared Infos As Short = 4
    End Structure

    Public Sub New(MsgList As ListBox)
        MyMsgList = MsgList
    End Sub

    Public Sub AppendErrorMsg(msg As String)
        ErrorMessages.Add(msg)
        If FilterCheck(FilterStatus.Errors) Then
            MyMsgList.Items.Add(msg)
        End If
    End Sub

    Private Function FilterCheck(value As Short)
        Return Filter Xor value
    End Function
End Class
