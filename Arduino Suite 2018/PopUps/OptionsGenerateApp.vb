Imports System.Windows.Forms

Public Class OptionsGenerateApp

    Dim path As String

    Private Sub OptionsGenerateApp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim startPath As String = applicationDirectory & "\Application"
        If Not System.IO.Directory.Exists(startPath) Then
            System.IO.Directory.CreateDirectory(startPath)
        End If
        TextBoxDiretorio.Text = startPath
        path = TextBoxDiretorio.Text
    End Sub

    Private Sub ButtonProcurar_Click(sender As Object, e As EventArgs) Handles ButtonProcurar.Click
        Dim saveFile As New SaveFileDialog With {
            .Filter = "Aplicação do Windows|*.exe",
            .InitialDirectory = TextBoxDiretorio.Text,
            .Title = "Gerar Aplicação StandAlone"
        }
        Dim dialogResult = saveFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            path = saveFile.FileName.Replace(saveFile.FileName.Split("\")(saveFile.FileName.Split("\").Length - 1), "")
        End If
    End Sub

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        If appProgrammingMethod <> "Avançado" Then
            Comando.generateControlsList()
        Else

        End If
        GenerateApp.SetDestinyPath(path)
        GenerateApp.SetAppName(TextBoxNome.Text)
        Close()
        GenerateApp.Show()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Close()
    End Sub
End Class
