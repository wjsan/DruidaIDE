Public Class MenuInterativo

    Private InitialLocation As UInt16 = 0

    Private Sub MenuInterativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Deleg(ItemMenuInterativoConect, AddressOf DruidaSuiteMain.PictureBoxConectar_Click)
        Deleg(ItemMenuInterativoSelecionaPorta, AddressOf SelecionarPorta)
        Deleg(ItemMenuInterativoSair, AddressOf DruidaSuiteMain.PictureBoxSair_Click)
        Deleg(ItemMenuInterativoLogon, AddressOf DruidaSuiteMain.PictureBoxLogon_Click)
        Deleg(ItemMenuInterativoNovo, AddressOf DruidaSuiteMain.PictureBoxNova_Click)
        Deleg(ItemMenuInterativoAbrir, AddressOf DruidaSuiteMain.PictureBoxAbrir_Click)
        Deleg(ItemMenuInterativoSalvar, AddressOf DruidaSuiteMain.PictureBoxSalvar_Click)
        Deleg(ItemMenuInterativoComando, AddressOf TelaInicial.OpenComando)
        'Deleg(ItemMenuInterativoLogon, AddressOf OpenLogon)
        Deleg(ItemMenuInterativoIrParaWindows, AddressOf Minimize)
        Deleg(ItemMenuInterativoPair, AddressOf Pair)
    End Sub

    Delegate Sub buttonAction(sender As Object, e As EventArgs)

    Private Sub Deleg(ByVal act As ItemMenuInterativo, ByVal metodo As buttonAction)
        AddHandler act.LabelNomeItem.Click, AddressOf metodo.Invoke
        AddHandler act.PictureBoxItem.Click, AddressOf metodo.Invoke
    End Sub

    Private Sub Pair()
        Dim pair As String = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) & "\DevicePairingWizard.exe"
        If System.IO.File.Exists(pair) Then
            Process.Start(pair)
        End If
    End Sub

    Private Sub SelecionarPorta(sender As Object, e As EventArgs)
        SelectPort.Show()
    End Sub

    Private Sub Minimize(sender As Object, e As EventArgs)
        Hide()
        DruidaSuiteMain.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OpenComandoAvacado(sender As Object, e As EventArgs)
        ComandoAvancado.MdiParent = DruidaSuiteMain
        ComandoAvancado.Dock = DockStyle.Fill
        ComandoAvancado.Show()
        ComandoAvancado.Top() = 0
    End Sub

    Public Sub ShowMe()
        Me.Location = New Point(Location.X, Me.ParentForm.Height)
        TimerShowAnimation.Start()
        Me.Show()
        Me.BringToFront()
    End Sub

    Private Sub TimerShowAnimation_Tick(sender As Object, e As EventArgs) Handles TimerShowAnimation.Tick
        Dim dist1 As Int16 = Me.Location.Y + Me.Height
        Dim dist2 As Int16 = Me.ParentForm.Height
        Dim stepAnim As Int16 = (dist1 - dist2) \ 2
        If stepAnim < 5 Then stepAnim = 5
        Me.Location = New Point(Location.X, Location.Y - stepAnim)
        If dist1 <= dist2 Then
            TimerShowAnimation.Stop()
            Me.Location = New Point(Location.X, Me.ParentForm.Height - Me.Height - DruidaSuiteMain.PanelTaskBar.Height)
            stepAnim = 40
        End If
    End Sub
End Class
