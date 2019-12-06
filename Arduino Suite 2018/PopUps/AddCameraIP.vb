Imports System.ComponentModel
Imports System.Windows.Forms
Imports AForge.Video

Public Class AddCameraIP
    Public local As Point
    Public ref As New ControleHardware
    Public rotate As String = "0°"
    Public invert As String = "none"
    Private novaCamera As Object

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If (Text <> "Propriedades") Then
            Dim novaCamera As New ControleHardware
            novaCamera.engine.UpdateDataFromControlData(ref.engine)
            novaCamera.engine.tamanho = New Point(400, 300)
            novaCamera.engine.rotuloText = TextBoxRótulo.Text
            novaCamera.engine.imagens(0) = TextBoxURL.Text
            novaCamera.engine.imagens(1) = TextBoxUsuario.Text
            novaCamera.engine.imagens(2) = TextBoxSenha.Text
            novaCamera.engine.button1Text = rotate
            novaCamera.engine.button2Text = invert
            GetLocal.Controls.Add(novaCamera)
            novaCamera.engine.updateControl(novaCamera)
            ref = New ControleHardware
        Else
            VideoSourcePlayer1.SignalToStop()
            ref.engine.UpdateDataFromControlData(ref.engine)
            ref.engine.tamanho = New Point(400, 300)
            ref.engine.rotuloText = TextBoxRótulo.Text
            ref.engine.imagens(0) = TextBoxURL.Text
            ref.engine.imagens(1) = TextBoxUsuario.Text
            ref.engine.imagens(2) = TextBoxSenha.Text
            ref.engine.button1Text = rotate
            ref.engine.button2Text = invert
            ref.VideoSourcePlayer.Start()
        End If
        VideoSourcePlayer1.SignalToStop()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        VideoSourcePlayer1.SignalToStop()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sourceURL As String = TextBoxURL.Text
        Dim mjpeg As MJPEGStream = New MJPEGStream(sourceURL)
        mjpeg.Login = TextBoxUsuario.Text
        mjpeg.Password = TextBoxSenha.Text
        VideoSourcePlayer1.VideoSource = mjpeg
        VideoSourcePlayer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VideoSourcePlayer1.SignalToStop()
        'VideoSourcePlayer1.SignalToStop()
    End Sub

    Private Sub AddCameraIP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        VideoSourcePlayer1.SignalToStop()
    End Sub

    Private Sub AddCameraIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaDados()
    End Sub

    Private Sub carregaDados()
        If (Text = "Propriedades") Then
            TextBoxRótulo.Text = ref.engine.rotuloText
            TextBoxURL.Text = ref.engine.imagens(0)
            TextBoxUsuario.Text = ref.engine.imagens(1)
            TextBoxSenha.Text = ref.engine.imagens(2)
            rotate = ref.engine.button1Text
            invert = ref.engine.button2Text
        End If
    End Sub

    Private Sub VideoSourcePlayer1_NewFrame(sender As Object, ByRef image As Bitmap) Handles VideoSourcePlayer1.NewFrame
        If rotate = "90°" Then
            image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If rotate = "180°" Then
            image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
        If rotate = "270°" Then
            image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If
        If invert = "x" Then
            image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        End If
        If invert = "y" Then
            image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        End If
    End Sub

    Private Sub ButtonGirar_Click(sender As Object, e As EventArgs) Handles ButtonGirar.Click
        If rotate = "0°" Then
            rotate = "90°"
            Exit Sub
        End If
        If rotate = "90°" Then
            rotate = "180°"
            Exit Sub
        End If
        If rotate = "180°" Then
            rotate = "270°"
            Exit Sub
        End If
        If rotate = "270°" Then
            rotate = "0°"
        End If
    End Sub

    Private Sub ButtonInvertX_Click(sender As Object, e As EventArgs) Handles ButtonInvertX.Click
        If invert = "none" Or invert = "y" Then
            invert = "x"
            Exit Sub
        End If
        If invert = "x" Then
            invert = "none"
        End If
    End Sub

    Private Sub ButtonInvertY_Click(sender As Object, e As EventArgs) Handles ButtonInvertY.Click
        If invert = "none" Or invert = "x" Then
            invert = "y"
            Exit Sub
        End If
        If invert = "y" Then
            invert = "none"
        End If
    End Sub
End Class
