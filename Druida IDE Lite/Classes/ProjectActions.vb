Imports System.IO
Imports Code_Editor_For_Arduino

Public Class ProjectActions

    Public Class NewProject
        Shared Sub ShowDialog()
            NewProject.ShowDialog()
        End Sub
        Shared Sub Create(ByVal path As String)
            CurrentProjectInfo.SetCurrentProjectPath(path)
            Druida_IDE.LoadProject()
        End Sub
    End Class

    Public Class OpenProject
        Shared Function ShowDialog()
            Dim openApp As OpenFileDialog = New OpenFileDialog With {
                .Filter = "Arduino File|*.ino",
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Druida",
                .Title = "Abrir Projeto"
            }
            If (openApp.ShowDialog() = DialogResult.OK) Then
                Dim newPath As New FileInfo(openApp.FileName)
                ProjectActions.OpenProject.Open(newPath.DirectoryName)
            End If
            Return openApp
        End Function

        Shared Sub Open(ByVal path As String)
            CurrentProjectInfo.SetCurrentProjectPath(path)
            Druida_IDE.LoadProject()
        End Sub
    End Class

    Public Class CreateFile
        Shared Sub ShowDialog()
            NewFile.ShowDialog()
        End Sub
        Shared Sub Create(ByVal content As String, ByVal filePath As String, ByVal descr As String)
            Dim header As String = CurrentProjectCfgs.GetHeader(filePath, descr)
            File.WriteAllText(filePath, header)
            File.AppendAllText(filePath, content)
            FilesExplorer.UpdateExplorer()
        End Sub
    End Class

    Shared Sub SaveProject()

    End Sub

    Shared Sub SaveProjectAs()

    End Sub

End Class
