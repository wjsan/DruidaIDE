Public Class ItemMenuInterativo
    Delegate Sub action()
    Private DeactivateColor As Color
    Public Property PictureItem() As Image
        Get
            Return PictureBoxItem.Image
        End Get
        Set(ByVal value As Image)
            PictureBoxItem.Image = value
        End Set
    End Property
    Public Property NomeItem() As String
        Get
            Return LabelNomeItem.Text
        End Get
        Set(ByVal value As String)
            LabelNomeItem.Text = value
        End Set
    End Property
    Public Property BarColor() As Color
        Get
            Return BackColor
        End Get
        Set(ByVal value As Color)
            BackColor = value
            DeactivateColor = value
        End Set
    End Property
    Public Property ActivateColor() As Color

    Private Sub ItemMenuInterativo_Load(sender As Object, e As EventArgs) Handles Me.Load
        BackColor = BarColor
    End Sub

    Private Sub ItemMenuInterativo_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, LabelNomeItem.MouseEnter, PictureBoxItem.MouseEnter
        BackColor = ActivateColor
        ForeColor = Color.White
    End Sub

    Private Sub ItemMenuInterativo_MouseLeave(sender As Object, e As EventArgs) Handles LabelNomeItem.MouseLeave, PictureBoxItem.MouseLeave, Me.MouseLeave
        BackColor = DeactivateColor
        ForeColor = Color.Black
    End Sub

    Private Sub LabelNomeItem_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelNomeItem.MouseClick, PictureBoxItem.MouseClick
        DruidaSuiteMain.MenuInterativo.Hide()
    End Sub
End Class
