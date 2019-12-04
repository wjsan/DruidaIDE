Imports System.Drawing

Public Class FormBackgroundGradient

    Private myForm As Form
    Private _primaryColor As Color
    Private _secundaryColor As Color

    ''' <summary>
    ''' Initialize the background color instance
    ''' </summary>
    ''' <param name="form">Form to assing the background gradient</param>
    ''' <param name="primaryColor">Color 1 for gradient</param>
    ''' <param name="secundaryColor">Color 2 for gradient</param>
    Public Sub New(form As Form, primaryColor As Color, secundaryColor As Color)
        myForm = form
        _primaryColor = primaryColor
        _secundaryColor = secundaryColor
        AddHandler myForm.Paint, AddressOf form_Paint
        AddHandler myForm.ResizeEnd, AddressOf frmBG_ResizeEnd
    End Sub

    Private Sub form_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim p1 As Point = myForm.ClientRectangle.Location
        Dim p2 As Point = New Point(myForm.ClientRectangle.Right, myForm.ClientRectangle.Bottom)
        Using brsGradient As New System.Drawing.Drawing2D.LinearGradientBrush(p1, p2, _primaryColor, _secundaryColor)
            g.FillRectangle(brsGradient, e.ClipRectangle)
        End Using
    End Sub

    Private Sub frmBG_ResizeEnd(sender As Object, e As System.EventArgs)
        myForm.Invalidate()
    End Sub
End Class