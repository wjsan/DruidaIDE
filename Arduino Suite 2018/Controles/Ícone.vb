Imports System.Drawing.Imaging

Public Class Ícone

    Public Event Selected()
    Dim g As Graphics
    Dim img As Image
    Dim r As Rectangle


    Public Property Icon() As Image
        Get
            Return PictureBoxIcon.Image
        End Get
        Set(ByVal value As Image)
            PictureBoxIcon.Image = value
            PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom
        End Set
    End Property

    Public Property LabelName() As String
        Get
            Return LabelNome.Text
        End Get
        Set(ByVal value As String)
            LabelNome.Text = value
        End Set
    End Property


    Private Sub Ícone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        img = Icon
        PictureBoxIcon.Image = New Bitmap(PictureBoxIcon.Width, PictureBoxIcon.Height, PixelFormat.Format32bppArgb)
        g = Graphics.FromImage(PictureBoxIcon.Image)
        r = New Rectangle(0, 0, PictureBoxIcon.Width, PictureBoxIcon.Height)
        g.DrawImage(img, r)
    End Sub

    Private Sub Ícone_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxIcon.MouseEnter, LabelNome.MouseEnter
        PlayBackgroundSoundFile("Focus.wav")
        Call setBrightness(0.4)
    End Sub

    Private Sub Ícone_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxIcon.MouseLeave, LabelNome.MouseLeave
        Call setBrightness(0)
    End Sub

    Private Sub Ícone_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxIcon.MouseClick, LabelNome.MouseClick
        For Each item In Parent.Controls
            If item.GetType = Me.GetType Then
                item.DeselectMe()
            End If
        Next
        SelectMe()
    End Sub

    Public Sub SelectMe()
        'BackColor = Color.Blue
        'ForeColor = Color.White
        RaiseEvent Selected()
    End Sub

    Public Sub DeselectMe()
        'BackColor = Color.Transparent
        'ForeColor = Color.White
    End Sub

    Sub setBrightness(ByVal Brightness As Single)
        ' Brightness should be -1 (black) to 0 (neutral) to 1 (white)

        Dim colorMatrixVal As Single()() = {
           New Single() {1, 0, 0, 0, 0},
           New Single() {0, 1, 0, 0, 0},
           New Single() {0, 0, 1, 0, 0},
           New Single() {0, 0, 0, 1, 0},
           New Single() {Brightness, Brightness, Brightness, 0, 1}}

        Dim colorMatrix As New ColorMatrix(colorMatrixVal)
        Dim ia As New ImageAttributes

        ia.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)

        g.DrawImage(img, r, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia)
        PictureBoxIcon.Refresh()
    End Sub

    Private Sub PictureBoxIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBoxIcon.MouseClick
        PlayBackgroundSoundFile("Click.wav")
    End Sub
End Class
