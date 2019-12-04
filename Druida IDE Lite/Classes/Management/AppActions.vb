Imports Druida_IDE_Lite.IDEcfgs.Values.Workspace

Public Class AppActions
    Public myViewSettings As New ViewSettings

    Public Class ViewSettings
        Public Sub SetFullScreen(state As Boolean)
            If state Then
                Druida_IDE.WindowState = FormWindowState.Normal
                Druida_IDE.FormBorderStyle = FormBorderStyle.None
            Else
                Druida_IDE.FormBorderStyle = FormBorderStyle.Sizable
            End If
            Druida_IDE.WindowState = FormWindowState.Maximized
            FullScreen = state
            controlMainToolBar.lMinimize.Visible = state
            controlMainToolBar.lClose.Visible = state
        End Sub
    End Class
End Class
