Public Class CustomMenuItem
    Private bkpBackgroundColor As Color = BackColor

    Shadows Event Click(fileName As String)
    Public Event DeleteClick(sender As CustomMenuItem)

    Public Property DeleteConfirmMessage() As String

    Public Property ShowDeleteButton() As Boolean
        Get
            Return pbTrash.Visible
        End Get
        Set(value As Boolean)
            pbTrash.Visible = value
        End Set
    End Property

    Public Property Icon() As Image
        Get
            Return pbIcon.Image
        End Get
        Set(ByVal value As Image)
            pbIcon.Image = value
        End Set
    End Property

    Public Property BtText() As String
        Get
            Return lbText.Text
        End Get
        Set(ByVal value As String)
            lbText.Text = value
        End Set
    End Property

    Public Property HighlightColor As Color

    Private Sub MenuItem_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, pbIcon.MouseEnter, lbText.MouseEnter
        Me.BackColor = HighlightColor
    End Sub

    Private Sub MenuItem_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, pbIcon.MouseLeave, lbText.MouseLeave
        Me.BackColor = Me.Parent.BackColor
    End Sub

    Private Sub pbTrash_MouseEnter(sender As Object, e As EventArgs) Handles pbTrash.MouseEnter
        pbTrash.BackColor = HighlightColor
    End Sub

    Private Sub pbTrash_MouseLeave(sender As Object, e As EventArgs) Handles pbTrash.MouseLeave
        pbTrash.BackColor = Color.Transparent
    End Sub

    Private Sub MenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick, pbIcon.MouseClick, lbText.MouseClick
        Dim Text = BtText
        If Text.Contains(vbCrLf) Then
            If Text.Split(vbCrLf).Count > 0 Then
                Text = BtText.Split(vbCrLf)(1).Trim
            End If
        End If
        RaiseEvent Click(Text)
    End Sub

    Private Sub pbTrash_Click(sender As Object, e As EventArgs) Handles pbTrash.Click
        If MessageBox.Show(DeleteConfirmMessage, "Druida IDE Lite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RaiseEvent DeleteClick(Me)
        End If
    End Sub

End Class
