Imports System.Windows.Forms

Public Class MoveOrCopy

    Sub LoadParameters(fileName As String, folderName As String)
        lbFile.Text = fileName
        lbFolder.Text = folderName
    End Sub

    Enum diagResult
        none
        cancel
        move
        copy
    End Enum

    Private Sub BtMove_Click(sender As Object, e As EventArgs) Handles btMove.Click
        Me.DialogResult = diagResult.move
        Me.Close()
    End Sub

    Private Sub BtCopy_Click(sender As Object, e As EventArgs) Handles btCopy.Click
        Me.DialogResult = diagResult.copy
        Me.Close()
    End Sub

    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.DialogResult = diagResult.cancel
        Me.Close()
    End Sub
End Class
