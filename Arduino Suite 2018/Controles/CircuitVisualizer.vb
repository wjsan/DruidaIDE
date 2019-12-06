Public Class CircuitVisualizer
    Private img As PictureBox

    Public Sub setImage(_img As PictureBox)
        img = _img
    End Sub


    Private Sub ToolStripButtonZoomIn_Click(sender As Object, e As EventArgs) Handles ToolStripButtonZoomIn.Click
        verificaZoom()
        img.Size = New Point(img.Size.Width * 1.1, img.Size.Height * 1.1)
        img.Location = New Point(0, 0)
    End Sub

    Private Sub ToolStripButtonZoomOut_Click(sender As Object, e As EventArgs) Handles ToolStripButtonZoomOut.Click
        verificaZoom()
        img.Size = New Point(img.Size.Width * 0.9, img.Size.Height * 0.9)
        img.Location = New Point(0, 0)
    End Sub

    Private Sub verificaZoom()
        If img.SizeMode <> PictureBoxSizeMode.Zoom Then
            Dim aux As Size = img.Size
            img.SizeMode = PictureBoxSizeMode.Zoom
            img.Size = aux
        End If
    End Sub
End Class
