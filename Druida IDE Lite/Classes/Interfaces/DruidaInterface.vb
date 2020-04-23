Imports System.IO

Public Class DruidaInterface
    Public Shared DruidaIDE As Druida_IDE = Druida_IDE

    Public Shared callScadaAction As Action

    Public Shared Sub CallScada()
        If Not callScadaAction Is Nothing Then
            callScadaAction()
        End If
    End Sub

    Public Shared Sub InitializeDruidaOnPath(path As String)
        Dim myCulture As New CultureManager
        HideButtons()
        LoadCFGs()
        myCulture.setResxCulture(AppInfo.language)
        CurrentProjectInfo.CreateDir(path)
        Try
            CurrentProjectCfgs.SetFilePath(path & "\" & CurrentProjectInfo.General.name & ".cfg")
            CurrentProjectInfo.DirectoryPaths.mainCFGsProjectFile = path & "\" & CurrentProjectInfo.General.name & ".cfg"
        Catch ex As Exception
            path = AppInfo.Directories.ideData & "\"
            CurrentProjectCfgs.SetFilePath(path & "\" & CurrentProjectInfo.General.name & ".cfg")
            CurrentProjectInfo.DirectoryPaths.mainCFGsProjectFile = path & "\" & CurrentProjectInfo.General.name & ".cfg"
        End Try
        CurrentProjectInfo.CreateProjectFileWithModel(path & "\" & CurrentProjectInfo.General.name & ".ino", "Configurações e loop principal", CodeInfo.ModelFiles.DruidaDefault)
        CurrentProjectInfo.CreateProjectFileWithModel(path & "\Druida.ino", "Druida Structures", CodeInfo.ModelFiles.DruidaInoDefault)
        CurrentProjectInfo.SetCurrentProjectPath(path)
        DruidaIDE.LoadProject()
        CurrentProjectCfgs.values.hardware.baudRate = 115200
        IDEcfgs.Values.Workspace.IsChild = True
    End Sub
    Public Shared Sub LoadCFGs()
        If File.Exists(AppInfo.Files.ideCfgs) Then
            IDEcfgs.VerifyCFGs()
        Else
            Welcome.ShowDialog()
            IDEcfgs.VerifyCFGs()
        End If
        BoardsData.LoadDataBase()
    End Sub

    Public Shared Sub HideButtons()
        controlMainToolBar.tsbNewProject.Visible = False
        controlMainToolBar.tsbOpen.Visible = False
        controlMainToolBar.tsbSaveAs.Visible = False
        controlMainToolBar.tsbtExit.Visible = False
        controlMainToolBar.tsbtScada.Visible = True
    End Sub

    'Public Shared Sub AddErrorMsg(errorMsg As String)
    '    consoleErrors.AddItem(ErrorsManager.Type.msgInfo, errorMsg, "Druida Tool's Suite", "")
    'End Sub

    Public Shared Sub AddErrorMsg(errorMsg As String, errorType As ErrorsManager.Type)
        consoleErrors.AddItem(ErrorsManager.Type.msgInfo, errorMsg, "Druida Tool's Suite", "")
    End Sub

    Public Class Project
        Public Shared Sub SetProjectName(name As String)
            CurrentProjectCfgs.DefaultValues.ProjectInfo.title = name
            CurrentProjectInfo.General.title = name
            CurrentProjectInfo.General.name = TextTreatment.OnlyLetters(name)
        End Sub
        Public Shared Sub ChangeModelFile(path As String)

        End Sub
    End Class
    Public Class Files
        Public Shared Sub OpenFile(filePath As String)
            controlExplorer.OpenCodeFile(filePath)
        End Sub

        Public Shared Sub OpenLocalFile(fileName As String)
            Dim path As String = CurrentProjectInfo.DirectoryPaths.projectDirectory & "\" & fileName
            controlExplorer.OpenCodeFile(path)
        End Sub

        Public Shared Sub UpdateFileList()
            controlExplorer.UpdateExplorer()
        End Sub
    End Class

    Public Class Code
        Public Shared Function SearchLine(text As String)
            Return CodeManager.Actions.SearchLine(text)
        End Function

        Public Shared Function SearchAfterLine(s1 As String, s2 As String)
            Return CodeManager.Actions.SearchAfterLine(s1, s2)
        End Function

        Public Shared Sub MarkLine(line As UInt16)
            CodeManager.Actions.marker.MarkLine(line)
        End Sub

        Public Shared Sub AddLine(lin As UInt16, text As String)
            CodeManager.Actions.AddText(lin, text)
        End Sub

        Public Shared Sub AppendText(text As String)
            CodeManager.Actions.AppendText(text)
        End Sub
    End Class

    Public Class SerialPort
        Public Shared Sub Close()
            AppSystem.serialPort.Close()
            'controlConsole.HardwareMonitorControl.CloseSerialPort()
        End Sub

        Public Shared Function GetPort() As String
            If CurrentProjectCfgs.values.hardware.COMport = "" Then

            End If
            Return CurrentProjectCfgs.values.hardware.COMport
        End Function

        Public Shared Function GetBaud() As String
            Return CurrentProjectCfgs.values.hardware.baudRate
        End Function

    End Class
End Class
