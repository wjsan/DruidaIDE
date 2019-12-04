Imports Tulpep.NotificationWindow

Public Class Notify
    Shared notify = New PopupNotifier()

    Shared Sub Show(ByVal message As String, ByRef picture As Image, ByVal scale As Double)
        Dim newNotify = notify
        newNotify.TitleText = "Druida IDE Lite"
        newNotify.IsRightToLeft = False
        newNotify.ShowCloseButton = True
        newNotify.ContentColor = Color.Black
        newNotify.ImageSize = New Point(picture.Width * scale, picture.Height * scale)
        newNotify.Image = picture
        newNotify.ContentText = message
        newNotify.Popup()
    End Sub
End Class
