Imports System.IO
Imports Druida_IDE_Lite.IDEcfgs.Values

Public NotInheritable Class SplashScreen

    Dim isShowCase As Boolean = False

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If File.Exists(AppInfo.Files.ideCfgs) Then
            IDEcfgs.VerifyCFGs()
        Else
            Welcome.ShowDialog()
            IDEcfgs.VerifyCFGs()
        End If
        ApplyTheme()
        If Initialization.showSplashScreen = True Then
            Dim myGradient As New FormBackgroundGradient(Me, Color.FromArgb(CodeColors.ControlsColor), Color.FromArgb(CodeColors.BackColor))
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
        ShowCase()
    End Sub

    Private Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'myCulture.setResxCulture("en")
        lVersion.Text = System.String.Format(lVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        BoardsData.LoadDataBase()
        CurrentProjectInfo.VerifyInitialProjectDirectory()
        If Not isShowCase Then
            VerifySoftwareVersion()
            If Initialization.showSplashScreen Then
                timerSplash.Start()
            Else
                InitializeWorkSpace()
                StartDruidaIDE()
                Me.Close()
            End If
            SplitContainer1.Visible = True
        End If
        InitializeWorkSpace()
    End Sub

    Private Sub VerifySoftwareVersion()
        Dim updateCheck As New CheckForUpdates
        updateCheck.CheckVersionFile()
    End Sub

    Public Sub InitializeWorkSpace()
        controlMainToolBar.tsbtFullScreen.Checked = Workspace.FullScreen
        If Workspace.FullScreen Then
            Druida_IDE.FormBorderStyle = FormBorderStyle.None
        Else
            Druida_IDE.FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub timSplashShow_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick
        StartDruidaIDE()
        Me.Close()
    End Sub

    Private Sub StartDruidaIDE()
        If Not OpenArgFile() Then
            StartApp()
        End If
    End Sub

    Private Function OpenArgFile()
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim file As New FileInfo(My.Application.CommandLineArgs(0))
            If file.Exists Then
                CurrentProjectInfo.SetCurrentProjectPath(file.DirectoryName)
                Druida_IDE.LoadProject()
                Druida_IDE.Show()
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub StartApp()
        If IDEcfgs.GetValue(IDEcfgs.Names.Initialization.openLastFile) And File.Exists(CurrentProjectInfo.DirectoryPaths.mainCodeFile) Then
            Dim file As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
            CurrentProjectInfo.SetCurrentProjectPath(file.DirectoryName)
            Druida_IDE.LoadProject()
        Else
            Druida_IDE.LoadHomePage()
        End If
        Druida_IDE.Show()
    End Sub

    Private Sub LoadCulture()
        Dim cultureManager As New CultureManager
        cultureManager.setResxCulture(IDEcfgs.Values.Initialization.culture)
    End Sub

    Private Sub ApplyTheme()
        Label1.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Label2.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        Label3.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        lVersion.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub

    Private Sub ShowCase()
        If isShowCase Then
            'Dim myGradient As New FormBackgroundGradient(Me, Color.Black, Color.White)
            Me.Size = New Point(1366, 768)
            Me.Location = New Point(0, 0)
            PictureBox2.Visible = True
            Panel1.Visible = True
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            lVersion.Visible = False
        End If
    End Sub
End Class