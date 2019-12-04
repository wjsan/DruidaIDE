Imports System.IO
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class ImageViewer
    Private ImageSource As String

    Public Sub SetImageSource(newImgSource As String)
        If File.Exists(newImgSource) Then
            ImageSource = newImgSource
            img.SizeMode = PictureBoxSizeMode.AutoSize
            img.Image = ImagesManipulation.SafeImageFromFile(ImageSource)
            pnImgViewer.Controls.Add(img)
        End If
    End Sub

    Private Sub tsbtZoomIn_Click(sender As Object, e As EventArgs) Handles tsbtZoomIn.Click
        ZoomIn()
    End Sub

    Private Sub ZoomIn()
        Dim locBkp = img.Location
        verifyZoom()
        img.Size = New Point(img.Size.Width * 1.1, img.Size.Height * 1.1)
        img.Location = locBkp
    End Sub

    Private Sub tsbtZoomOut_Click(sender As Object, e As EventArgs) Handles tsbtZoomOut.Click
        ZoomOut()
    End Sub

    Private Sub ZoomOut()
        Dim locBkp = img.Location
        verifyZoom()
        img.Size = New Point(img.Size.Width * 0.9, img.Size.Height * 0.9)
        img.Location = locBkp
    End Sub

    Private Sub verifyZoom()
        If img.SizeMode <> PictureBoxSizeMode.Zoom Then
            Dim aux As Size = img.Size
            img.SizeMode = PictureBoxSizeMode.Zoom
            img.Size = aux
        End If
    End Sub

    Private Sub tsbtUndoZoom_Click(sender As Object, e As EventArgs) Handles tsbtUndoZoom.Click
        img.Size = img.Image.Size
        img.Location = New Point(0, 0)
    End Sub

    Private Sub tsbtFitToScreen_Click(sender As Object, e As EventArgs) Handles tsbtFitToScreen.Click
        'verifyZoom()
        img.Location = New Point(0, 0)
        If img.Width > pnImgViewer.Width Or img.Height > pnImgViewer.Height Then
            While img.Width > pnImgViewer.Width Or img.Height > pnImgViewer.Height
                ZoomOut()
            End While
        Else
            While img.Width < pnImgViewer.Width And img.Height < pnImgViewer.Height
                ZoomIn()
            End While
        End If
    End Sub

    Private Sub ImageViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        ApplyTheme()
    End Sub

    Private Sub ApplyTheme()
        tsImageViewer.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsImageViewer.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        pnImgViewer.BackColor = Color.FromArgb(CodeColors.BackColor)
    End Sub

    Private Sub img_MouseMove(sender As Object, e As MouseEventArgs) Handles img.MouseMove
        img.Cursor = Cursors.Hand
        If e.Button = MouseButtons.Left Then
            img.Location = pnImgViewer.PointToClient(Form.MousePosition) - offSet
        End If
    End Sub

    Dim offSet As Point
    Private Sub img_MouseDown(sender As Object, e As MouseEventArgs) Handles img.MouseDown
        offSet = pnImgViewer.PointToClient(Form.MousePosition) - img.Location
    End Sub

    Private Sub img_MouseWheel(sender As Object, e As MouseEventArgs) Handles img.MouseWheel
        Dim locBkp = img.Location
        If e.Delta > 0 Then
            ZoomIn()
        Else
            ZoomOut()
        End If
        img.Location = locBkp
    End Sub

End Class
