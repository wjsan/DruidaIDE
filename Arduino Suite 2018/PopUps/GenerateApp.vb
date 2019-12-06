Imports System.IO

Public Class GenerateApp

    Private destinyPath As String
    Private newAppName As String
    Private myControls As List(Of ControleHardware)

    Private Sub GenerateApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateImgList()
    End Sub

    Public Sub SetDestinyPath(_destinyPath As String)
        destinyPath = _destinyPath
    End Sub

    Public Sub SetAppName(_newAppName As String)
        newAppName = _newAppName
    End Sub

    Public Sub SetControlList(_myConytols As List(Of ControleHardware))
        myControls = _myConytols
    End Sub

    Private Sub GenerateImgList()
        If Directory.Exists(destinyPath) Then
            My.Computer.FileSystem.DeleteDirectory(destinyPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Directory.CreateDirectory(destinyPath)
        End If
        Dim imgPath As String = destinyPath & "\Imagens\"
        Directory.CreateDirectory(imgPath)
        Dim fixedPath As String = My.Application.Info.DirectoryPath & "\Imagens\"
        Dim imgList As New List(Of String)
        For Each control As ControleHardware In myControls
            imgList.Add(control.engine.imagens(0))
            imgList.Add(control.engine.imagens(1))
            imgList.Add(control.engine.imagens(2))
        Next
        For Each img As String In imgList
            If Not File.Exists(imgPath & img) And File.Exists(fixedPath & img) Then
                Dim dir As String = imgPath & img
                dir = dir.Replace(dir.Split("\")(dir.Split("\").Length - 1), "")
                If Not Directory.Exists(dir) Then
                    Directory.CreateDirectory(dir)
                End If
                System.IO.File.Copy(fixedPath & img, imgPath & img)
            End If
        Next
        Directory.CreateDirectory(destinyPath & "\Comando")
        Directory.CreateDirectory(destinyPath & "\Config Files")
        My.Computer.FileSystem.CopyDirectory(applicationDirectory & "\Comando", destinyPath & "\Comando")
        My.Computer.FileSystem.CopyDirectory(applicationDirectory & "\Config Files", destinyPath & "\Config Files")
        File.Copy(My.Application.Info.DirectoryPath & "\AForge.Controls.dll", destinyPath & "\AForge.Controls.dll")
        File.Copy(My.Application.Info.DirectoryPath & "\AForge.Video.dll", destinyPath & "\AForge.Video.dll")
        File.Copy(My.Application.Info.DirectoryPath & "\Druida Application Runner.exe", destinyPath & "\" & newAppName)
        If MessageBox.Show("O aplicativo foi gerado com sucesso. Deseja abri-lo?", "Abrir nova aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Process.Start(destinyPath & "\" & newAppName)
        End If
        Close()
    End Sub
End Class
