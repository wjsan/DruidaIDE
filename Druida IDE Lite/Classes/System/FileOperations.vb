Imports System.IO

Public Class FileOperations
    Shared libFiles As New List(Of FileInfo)
    Shared localLibs As New List(Of FileInfo)
    'Shared aditionalLibs As New List(Of FileInfo)
    Public Function SearchFileInDir(fileName As String, dirName As String)
        Dim filesList As New List(Of FileInfo)
        Dim newDir As New DirectoryInfo(dirName)
        If filesList.Count = 0 Then
            filesList.AddRange(newDir.GetFiles(fileName, SearchOption.AllDirectories))
        End If
        For Each file As FileInfo In filesList
            If file.Name = fileName Then
                Return file.FullName
            End If
        Next
        Return Nothing
    End Function

    Public Function GetLibraryFiles()
        Dim coreLib As New DirectoryInfo(IDEcfgs.Values.Directories.ArduinoCoreLib)
        Dim defaultLibs As New DirectoryInfo(IDEcfgs.Values.Directories.ArduinoDefaultLib)
        Dim libs As New DirectoryInfo(IDEcfgs.Values.Directories.ArduinoLib)
        Dim localLibs As New DirectoryInfo(CurrentProjectInfo.DirectoryPaths.projectDirectory)
        Dim aditionalLibs As New List(Of DirectoryInfo)
        If libFiles.Count = 0 Then
            Dim libPaths As String = IDEcfgs.Values.Directories.AditionalLibsDir.Replace("\n", vbCr)
            If BoardsData.GetCurrentBoard IsNot Nothing Then
                For Each libPath In BoardsData.GetCurrentBoard.GetAditionalLibs
                    If Directory.Exists(libPath) Then
                        aditionalLibs.Add(New DirectoryInfo(libPath))
                    End If
                Next
            End If
            For Each libPath In libPaths.Split(vbCr)
                If Directory.Exists(libPath) Then
                    aditionalLibs.Add(New DirectoryInfo(libPath))
                End If
            Next
            For Each libInfo As DirectoryInfo In aditionalLibs
                libFiles.AddRange(libInfo.GetFiles("*.h", SearchOption.AllDirectories))
            Next
            libFiles.AddRange(defaultLibs.GetFiles("*.h", SearchOption.AllDirectories))
            libFiles.AddRange(libs.GetFiles("*.h", SearchOption.AllDirectories))
            libFiles.AddRange(coreLib.GetFiles("*.h", SearchOption.AllDirectories))
        End If
        For Each localLib As FileInfo In localLibs.GetFiles
            Dim exists = False
            For Each libfile In libFiles
                If localLib.FullName = libfile.FullName Or Not localLib.FullName.Contains(".h") Then
                    exists = True
                End If
            Next
            If Not exists Then
                libFiles.Add(localLib)
            End If
        Next
        Return libFiles
    End Function

    Public Function GetLibDir(fileName As String)
        Dim localPath As New DirectoryInfo(CurrentProjectInfo.DirectoryPaths.projectDirectory)
        localLibs.AddRange(localPath.GetFiles("*.h", SearchOption.AllDirectories))
        'For Each file In BoardsData.GetCurrentBoard.GetAditionalLibs
        '    aditionalLibs.Add(New FileInfo(file))
        'Next
        If libFiles.Count = 0 Then
            GetLibraryFiles()
        End If
        For Each file In localLibs
            If file.Name = fileName Then
                Return (file.FullName)
            End If
        Next
        'For Each file In aditionalLibs
        '    If file.Name = fileName Then
        '        Return (file.FullName)
        '    End If
        'Next
        For Each file In libFiles
            If file.Name = fileName Then
                Return (file.FullName)
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub ClearLibs()
        libFiles.Clear()
    End Sub
End Class
