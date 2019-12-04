Public Class Welcome
    Dim images() As Image = {My.Resources.Arduino_Light_Theme,
                             My.Resources.Arduino_Dark_Theme,
                             My.Resources.Druida_Light_Theme,
                             My.Resources.Druida_Dark_Theme}

    Dim themePaths As String = AppInfo.Directories.styles

    Dim themeFiles() As String = {themePaths & "\Arduino Default Light.style",
                                  themePaths & "\Arduino Default Dark.style",
                                  themePaths & "\Druida Defalt Light Theme.style",
                                  themePaths & "\Druida Default Dark Theme.style"}

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim myGradient As New FormBackgroundGradient(Me, Color.LightGray, Color.White)
        cbThemeSelect.SelectedIndex = 0
        System.IO.Directory.CreateDirectory(AppInfo.Directories.ideData)
        IDEcfgs.VerifyCFGs()
    End Sub

    Private Sub CbThemeSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThemeSelect.SelectedIndexChanged
        Dim index = cbThemeSelect.SelectedIndex
        pbThemePreview.Image = images(index)
        ExternalInterfaces.Styles.ImportStyles(themeFiles(index))
        IDEcfgs.Save()
    End Sub

    Private Sub BtContinue_Click(sender As Object, e As EventArgs) Handles btContinue.Click
        Me.Close()
    End Sub
End Class