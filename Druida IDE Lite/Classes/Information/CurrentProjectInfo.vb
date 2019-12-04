Imports System.IO
Imports Code_Editor_For_Arduino

Public Class CurrentProjectInfo
    Structure DirectoryPaths
        Shared projectDirectory As String = ""
        Shared mainCodeFile As String = ""
        Shared mainCFGsProjectFile As String = ""
        Shared pinoutDllFile As String = ""
        Shared pinoutCodeFile As String = ""
        Shared buildDir As String = ""
    End Structure

    Structure Code
        Shared currentCodeEditor As CodeEditorForArduino
    End Structure

    Structure General
        Shared title As String = ""
        Shared name As String = ""
        Shared author As String = ""
        Shared company As String = ""
        Shared description As String = ""
        Shared notes As String = ""
    End Structure

    Structure Version
        Shared getVersion As String = major & "." & minor & "." & build & "." & revision
        Shared major As String = ""
        Shared minor As String = ""
        Shared build As String = ""
        Shared revision As String = ""
    End Structure

    ''' <summary>
    ''' Verify if exists a initial directory and set him to current project path if it exists
    ''' </summary>
    Shared Sub VerifyInitialProjectDirectory()
        If LastProjectFileExists() And IDEcfgs.Values.Initialization.openLastFile Then
            Dim path As New FileInfo(IO.File.ReadAllText(AppInfo.Files.appIni))
            SetCurrentProjectPath(path.DirectoryName)
        End If
    End Sub

    Shared Function LastProjectFileExists()
        If File.Exists(AppInfo.Files.appIni) Then
            Dim path As String = File.ReadAllText(AppInfo.Files.appIni)
            If File.Exists(path) Then
                Return True
            End If
        End If
        Return False
    End Function

    Shared Sub SetCurrentProjectPath(ByRef path As String, ByVal file As String)
        path = VerifyProjectFile(file)
        If path = Nothing Then Exit Sub
        Dim directory As New DirectoryInfo(path)
        DirectoryPaths.projectDirectory = path
        General.name = directory.Name
        CurrentProjectCfgs.SetFilePath(path & "\" & General.name & ".cfg")
        DirectoryPaths.mainCFGsProjectFile = path & "\" & General.name & ".cfg"
        DirectoryPaths.mainCodeFile = path & "\" & General.name & ".ino"
        DirectoryPaths.buildDir = path & "\build"
        DirectoryPaths.pinoutDllFile = path & "\pins.dll"
        DirectoryPaths.pinoutCodeFile = path & "\pins.h"
        UpdateIniFiles()
        controlGeneralEditor.CloseAllTabs()
    End Sub

    Shared Sub SetCurrentProjectPath(ByVal path As String)
        Dim directory As New DirectoryInfo(path)
        DirectoryPaths.projectDirectory = path
        General.name = directory.Name
        CreateDir(path)
        Try
            CurrentProjectCfgs.SetFilePath(path & "\" & General.name & ".cfg")
            DirectoryPaths.mainCFGsProjectFile = path & "\" & General.name & ".cfg"
        Catch ex As Exception
            path = AppInfo.Directories.ideData & "\"
            CurrentProjectCfgs.SetFilePath(path & "\" & General.name & ".cfg")
            DirectoryPaths.mainCFGsProjectFile = path & "\" & General.name & ".cfg"
        End Try
        DirectoryPaths.mainCodeFile = path & "\" & General.name & ".ino"
        DirectoryPaths.buildDir = path & "\build"
        DirectoryPaths.pinoutDllFile = path & "\pinout.dll"
        DirectoryPaths.pinoutCodeFile = path & "\pins.h"
        CreateProjectFile(path & "\" & General.name & ".ino")
        controlGeneralEditor.CloseAllTabs()
    End Sub

    Shared Sub CreateDir(path As String)
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

    Shared Function VerifyProjectFile(file As String) As String
        Dim fileinfo As New FileInfo(file)
        If Not verifyFolderName(file) Then
            MoveOrCopy.LoadParameters(file.Split("\").Last, getFileName(file))
            Dim diagResult = MoveOrCopy.ShowDialog()
            If diagResult <> MoveOrCopy.diagResult.cancel Then
                Return CreateNewFolder(file, diagResult)
            End If
            Return Nothing
        Else
            Return fileinfo.DirectoryName
        End If
    End Function

    Shared Function CreateNewFolder(filePath As String, action As MoveOrCopy.diagResult)
        Dim fileInfo As New FileInfo(filePath)
        Dim fileName As String = fileInfo.Name.Replace(fileInfo.Extension, "")
        Dim folderName As String = fileInfo.DirectoryName & "\" & fileName
        If Not Directory.Exists(folderName) Then
            Directory.CreateDirectory(folderName)
        End If
        If Not File.Exists(folderName & "\" & fileInfo.Name) Then
            If action = MoveOrCopy.diagResult.move Then
                File.Move(filePath, folderName & "\" & fileInfo.Name)
            Else
                File.Copy(filePath, folderName & "\" & fileInfo.Name)
            End If
            Return folderName
        Else
            Dim cultureResx As New CultureManager
            MessageBox.Show(cultureResx.translateText("O arquivo já existe."))
            Return Nothing
        End If
    End Function

    Shared Function verifyFolderName(file As String) As Boolean
        Dim fileName As String = getFileName(file)
        Dim folderName As String = getFolderName(file)
        Return folderName = fileName
    End Function

    Private Shared Function getFolderName(fileName As String) As String
        Dim fileInfo As New FileInfo(fileName)
        Return FileInfo.DirectoryName.Split("\").Last
    End Function

    Shared Function getFileName(filePath As String) As String
        Dim fileInfo As New FileInfo(filePath)
        Dim fileName As String = fileInfo.Name.Replace(fileInfo.Extension, "")
        Return fileName
    End Function

    Shared Sub CreateProjectFile(path As String)
        If Not File.Exists(path) Then
            Dim cultureResx As New CultureManager
            Dim filePath As String = CurrentProjectInfo.DirectoryPaths.mainCodeFile
            Dim descr As String = cultureResx.translateText("Configurações e loop principal")
            Dim header As String = CurrentProjectCfgs.GetHeader(filePath, descr)
            Dim content As String = IDEcfgs.GetModelContent()
            File.WriteAllText(path, header & vbCrLf)
            File.AppendAllText(path, content)
        End If
        UpdateIniFiles()
    End Sub

    Shared Sub CreateProjectFileWithModel(path As String, descr As String, model As String)
        If Not File.Exists(path) Then
            Dim cultureResx As New CultureManager
            Dim filePath As String = path
            descr = cultureResx.translateText(descr)
            Dim header As String = CurrentProjectCfgs.GetHeader(filePath, descr)
            Dim content As String = IDEcfgs.GetModelContent(cultureResx.translateFile(model))
            File.WriteAllText(path, header & vbCrLf)
            File.AppendAllText(path, content)
        End If
    End Sub

    Shared Sub UpdateIniFiles()
        File.WriteAllText(AppInfo.Files.appIni, CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        Dim recentFiles As New List(Of String)
        If File.Exists(AppInfo.Files.recentFiles) Then
            recentFiles.AddRange(File.ReadLines(AppInfo.Files.recentFiles))
        End If
        If recentFiles.Contains(CurrentProjectInfo.DirectoryPaths.mainCodeFile) Then
            recentFiles.Remove(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        End If
        recentFiles.Insert(0, CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        File.WriteAllLines(AppInfo.Files.recentFiles, recentFiles)
    End Sub
End Class
