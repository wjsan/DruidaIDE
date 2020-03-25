Imports System.ComponentModel
Imports System.IO
Imports Druida_IDE_Lite.BoardsData
Imports Druida_IDE_Lite.MessagesManager
Imports Druida_IDE_Lite.ErrorsManager

Public Class ArduinoCompiler
    Private debugDir As String = AppInfo.Directories.arduinoCompiler & "\"
    Private debuggerCmdRequest As String = ""
    Private modeDebug = True
    Private compilerMessage As String = ""

    Private mainFileInfo As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
    Private tempDir = "C:\Temp\"
    Private tempFileDir = tempDir & CurrentProjectInfo.General.name & "\"
    Private fileDebugDir = tempDir & CurrentProjectInfo.General.name & "\" & mainFileInfo.Name
    Private fileDir = """" & mainFileInfo.FullName & """"

    Private RequestToCompile
    Private RequestToUpload

    Private BackgroundWorkerDebugger As New BackgroundWorker
    Private DebuggerErrors As String = ""
    Private DebuggerStatus As Status

    Public None As UShort = 0
    Public Compile As UShort = 1
    Public Upload As UShort = 2
    Public ShowError As UShort = 3

    Private cultureResx As New CultureManager

    Public Property SendDebugger As Boolean = False

    Enum Status
        Ok
        Erro
        Advise
    End Enum

    Public Sub New()
        AddHandler BackgroundWorkerDebugger.DoWork, AddressOf BackgroundWorkerDebugger_DoWork
        AddHandler BackgroundWorkerDebugger.RunWorkerCompleted, AddressOf BackgroundWorkerDebugger_RunWorkerCompleted
    End Sub

    Public Sub startCompiler(actionToDo As UShort)
        Dim cultureResx As New CultureManager()
        ProjectActions.SaveProject()
        CodeManager.Actions.marker.ClearMarkers()
        consoleErrors.clear()
        VerifyDebugDir()
        ReadyDebuggerDir()
        UpdateIDEContent(actionToDo, cultureResx.translateText(" <CLI> executando processo... Aguarde."))
        Select Case actionToDo
            Case Compile
                UpdateDebbugerOptions()
                debuggerCmdRequest = RequestToCompile
            Case Upload
                UpdateDebbugerOptions()
                debuggerCmdRequest = RequestToUpload
            Case Else

        End Select
        Try
            BackgroundWorkerDebugger.RunWorkerAsync()
        Catch ex As Exception
            UpdateIDEContent(ShowError, ex.Message)
        End Try
    End Sub

    Private Sub UpdateDebbugerOptions()
        Dim cmd As String = "arduino_debug"
        Dim BoardName As String = " --board " & GetCurrentBoard.GetDirective
        Dim BuildPath As String = " --pref build.path=" & tempDir & CurrentProjectInfo.General.name & "\build"
        Dim ComPort As String = " --port " & CurrentProjectCfgs.values.hardware.COMport

        RequestToCompile = cmd & BoardName & BuildPath & " --verify " & fileDir
        RequestToUpload = cmd & BoardName & BuildPath & ComPort & " --upload " & fileDir
    End Sub

    Private Sub UpdateIDEContent(act As UShort, message As String)
        Dim compileText As String = cultureResx.translateText("Compilar")
        Dim compilingText As String = cultureResx.translateText("Compilando...")
        Dim waitingText As String = cultureResx.translateText("Aguardando...")
        Select Case act
            Case None
                UpdateIDEContent(My.Resources.Verify, My.Resources.Upload, compileText, "Upload", waitingText)
            Case Compile
                UpdateIDEContent(My.Resources.Verify, My.Resources.Upload, compilingText, "Upload", compilingText)
            Case Upload
                UpdateIDEContent(My.Resources.Verify, My.Resources.Upload, compileText, "Uploading...", "Uploading...")
            Case ShowError
                UpdateIDEContent(My.Resources.Verify, My.Resources.Upload, compileText, "Upload", "Error!")
                Try
                    RefreshErrorsList()
                Catch ex As Exception
                    consoleErrors.AddItem(Type.msgAdvise, ex.Message, "ArduinoCompiler.vb", 90)
                End Try
            Case Else
                UpdateIDEContent(My.Resources.Verify, My.Resources.Upload, compileText, "Upload", waitingText)
        End Select
        outputMessages.AppendMessage("<UpdateDebbugerOptions> " & message, Filter.Compiler)
    End Sub

    Private Sub RefreshErrorsList()
        Dim erros As String = ""
        Dim fileName As String = ""
        Dim l As String = ""
        If DebuggerErrors.Contains("_getsync() attempt") Then
            erros &= vbCrLf & cultureResx.translateText("Erro de comunicação. Verique a porta, a placa, e o processador selecionados.")
        End If
        If DebuggerErrors.Contains("ser_open(): can't open device") Then
            erros &= vbCrLf & cultureResx.translateText("Erro ao tentar acessar porta de comunicação.")
        End If
        For Each line As String In DebuggerErrors.Split(vbCrLf)
            If (line.Contains(":")) Then
                If line.Contains("warning:") Then
                    Dim path = tempDir & CurrentProjectInfo.General.name & System.IO.Path.DirectorySeparatorChar
                    line = line.Replace(path, "")
                    line = line.Replace("sketch\", "")
                End If
                Dim lineError As String = ""
                If line.Contains("undefined reference") Then
                    lineError = line.Split(":")(1)
                    Dim fragment As String = line.Split(":")(2)
                    line = line.Replace(fragment, "0: error: " & fragment)
                    line = line.Replace("sketch/", "")
                End If
                If line.Contains("C:") Then
                    lineError = line.Split(":")(2)
                Else
                    lineError = line.Split(":")(1)
                End If
                If IsNumeric(lineError) Then
                    l = lineError
                    If (lineError >= 0 And (line.Contains("erro") Or line.Contains("warning"))) Then
                        If line.Contains("C:") Then
                            fileName = line.Split(":")(0) & line.Split(":")(1)
                            fileName = fileName.TrimStart
                        Else
                            fileName = line.Split(":")(0).TrimStart
                        End If
                        If Not (fileName.Contains(".h") Or fileName.Contains(".cpp") Or fileName.Contains(".ino") Or fileName.Contains(".pde") Or fileName.Contains("C:")) Then fileName = fileName & ".ino"
                        outputMessages.AppendMessage("<RefreshErrorsList>  <<Abrindo arquivo>> " & fileName, Filter.Compiler)
                        Dim filePath As String = CurrentProjectInfo.DirectoryPaths.projectDirectory
                        controlExplorer.OpenFile(filePath & "\" & fileName)
                        If line.Contains("error") Then
                            CodeManager.Actions.marker.MarkLineWithBrush(lineError - 1, Brushes.IndianRed)
                        End If
                    End If
                End If
                If (line.Contains("erro") Or line.Contains("Erro")) Then
                    erros &= vbCrLf & errorsTranslate.Translate(line)
                    Dim translatedError As String = errorsTranslate.Translate(line)
                    consoleErrors.AddItem(Type.msgError, translatedError, fileName, l)
                ElseIf (line.Contains("warning")) Then
                    Dim translatedError As String = errorsTranslate.Translate(line)
                    consoleErrors.AddItem(Type.msgAdvise, errorsTranslate.Translate(line), fileName, l)
                ElseIf (line.Contains("info") Or line.Contains("AVISO")) Then
                    Dim translatedError As String = errorsTranslate.Translate(line)
                    consoleErrors.AddItem(Type.msgInfo, errorsTranslate.Translate(line), fileName, l)
                End If
            End If
        Next
        If DebuggerStatus = Status.Erro Then
            If debuggerCmdRequest = RequestToCompile Then
                MessageBox.Show(cultureResx.translateText("Erro ao compilar o código! ") & erros)
            ElseIf debuggerCmdRequest = RequestToUpload Then
                MessageBox.Show(cultureResx.translateText("Erro ao enviar o código! ") & erros)
            End If
        ElseIf DebuggerStatus = Status.Advise Then
            If debuggerCmdRequest = RequestToCompile Then
                MessageBox.Show(cultureResx.translateText("O código foi compilado com sucesso, mas existem advertências."))
            ElseIf debuggerCmdRequest = RequestToUpload Then
                MessageBox.Show(cultureResx.translateText("O código foi enviado com sucesso, mas existem advertências."))
            End If
        End If
        controlConsole.tcConsole.SelectedIndex = 1
    End Sub

    Private Shared Sub UpdateIDEContent(VerifyImage As Image, UploadImage As Image, VerifyText As String, UploadText As String, Message As String)
        controlMainToolBar.tsbCompile.Image = VerifyImage
        controlMainToolBar.tsbUpload.Image = UploadImage
        controlMainToolBar.tsbCompile.Text = VerifyText
        controlMainToolBar.tsbUpload.Text = UploadText
        outputMessages.AppendMessage("<UpdateIDEContent> " & Message, Filter.Compiler)
    End Sub

    Private Sub VerifyDebugDir()
        If Not File.Exists(debugDir & "\arduino_debug.exe") Then
            MessageBox.Show(cultureResx.translateText("O diretório do compilador está incorreto"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewElement.Text = cultureResx.translateText("Alterar diretório do compilador")
            NewElement.lDescription.Text = cultureResx.translateText("Diretório")
            NewElement.tbLocal.Text = debugDir
            NewElement.ShowDialog()
            If Not Directory.Exists(NewElement.tbLocal.Text) Then
                MessageBox.Show(cultureResx.translateText("O diretório selecionado não existe."), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ReadyDebuggerDir()
        If SendDebugger Then
            Try
                If (System.IO.Directory.Exists(tempDir)) Then
                    My.Computer.FileSystem.DeleteDirectory(tempDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                My.Computer.FileSystem.CopyDirectory(CurrentProjectInfo.DirectoryPaths.projectDirectory, tempDir & "\" & CurrentProjectInfo.General.name, True)
            Catch ex As Exception
                outputMessages.AppendMessage("<ReadyDebuggerDir> Error on creating temporary dir: " & ex.Message, Filter.Compiler)
            End Try
            fileDir = fileDebugDir
            CreateDebugger()
        End If
    End Sub

    Private Sub CreateDebugger()
        Dim content As List(Of String) = File.ReadAllLines(fileDir).ToList
        content.Insert(0, "#define delay Debugger.delay")
        content.Insert(0, "#define delay Debugger.delay")
        content.Insert(0, "#include ""HardwareDebugger.h""")
        For i1 = 0 To content.Count - 1
            Dim lin = content(i1)
            If lin.Contains("void setup()") Then
                Dim i = content.IndexOf(lin)
                If lin.Contains("{") Then
                    i += 1
                Else
                    i += 2
                End If
                content.Insert(i + 1, "Debugger.begin(" & CurrentProjectCfgs.values.hardware.baudRate & ");")
            End If
            If lin.Contains("void loop()") Then
                Dim i = content.IndexOf(lin)
                If lin.Contains("{") Then
                    i += 1
                Else
                    i += 2
                End If
                content.Insert(i + 1, "Debugger.main();")
            End If
        Next
        File.WriteAllLines(fileDir, content)
        CrateFile(tempFileDir & "HardwareDebugger.cpp", My.Resources.HardwareDebugger_cpp)
        CrateFile(tempFileDir & "HardwareDebugger.h", My.Resources.HardwareDebugger_h)
        File.WriteAllText(tempFileDir & "BqBusCmd.cpp", My.Resources.BqBusCmd_cpp)
        File.WriteAllText(tempFileDir & "BqBusCmd.h", My.Resources.BqBusCmd_h)
    End Sub

    Private Sub CrateFile(dir As String, content As String)
        If Not File.Exists(dir) Then
            File.WriteAllText(dir, content)
        End If
    End Sub

    Private Function setupDebuggerProcess()
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo With {
                .FileName = Environment.GetEnvironmentVariable("comspec"),
                .Verb = "runas",
                .RedirectStandardInput = True,
                .RedirectStandardOutput = True,
                .RedirectStandardError = True
            }
        StartInfo.UseShellExecute = False
        StartInfo.CreateNoWindow = True
        Return (StartInfo)
    End Function

    Private Sub BackgroundWorkerDebugger_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim msg As String = ""
        Dim tempDir = "C:\Temp\"
        Dim debuggerProcess As New Process
        If (System.IO.Directory.Exists(tempDir & "Main\Colors")) Then
            My.Computer.FileSystem.DeleteDirectory(tempDir & "Main\Colors", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        debuggerProcess.StartInfo = setupDebuggerProcess()
        debuggerProcess.Start()
        Dim SW As StreamWriter = debuggerProcess.StandardInput
        Dim SR As StreamReader = debuggerProcess.StandardOutput
        Dim SRE As StreamReader = debuggerProcess.StandardError()
        SW.WriteLine("cd " & debugDir)
        SW.WriteLine(debuggerCmdRequest)
        SW.Close()
        While Not debuggerProcess.HasExited
            Dim line As String = debuggerProcess.StandardError.ReadLine()
            outputMessages.myTextBox.Invoke(Sub()
                                                DebuggerErrors &= line & vbCrLf
                                                outputMessages.AppendMessage(line, Filter.Compiler)
                                            End Sub)
        End While
        compilerMessage = vbCrLf & vbCrLf & "Compiler Messages" & vbCrLf & DebuggerErrors
        If DebuggerErrors.Contains("comando interno") Or DebuggerErrors.Contains("internal comand") Then
            DebuggerStatus = Status.Erro
            Exit Sub
        End If
        If (DebuggerErrors.Contains("erro") Or DebuggerErrors.Contains("Erro")) Then
            Dim erros As String = ""
            DebuggerStatus = Status.Erro
        ElseIf (DebuggerErrors.Contains("can't open device")) Then
            Dim erros As String = ""
            DebuggerStatus = Status.Erro
        ElseIf (DebuggerErrors.Contains("warning:")) Then
            Dim erros As String = ""
            DebuggerStatus = Status.Advise
        Else
            DebuggerStatus = Status.Ok
            If debuggerCmdRequest = RequestToCompile Then
                MessageBox.Show(cultureResx.forcedTranslationText("Código compilado com sucesso!", AppInfo.language))
            ElseIf debuggerCmdRequest = RequestToUpload Then
                MessageBox.Show(cultureResx.forcedTranslationText("Código enviado com sucesso!", AppInfo.language))
            End If
        End If
    End Sub

    Private Sub BackgroundWorkerDebugger_RunWorkerCompleted()
        Select Case DebuggerStatus
            Case Status.Ok
                UpdateIDEContent(None, "Compiler works fine.")
                Exit Select
            Case Else
                If Not SendDebugger Then
                    UpdateIDEContent(ShowError, DebuggerErrors)
                ElseIf DebuggerStatus = Status.Erro Then
                    MessageBox.Show("Debugger problem. Compile your source code first.",
                                    "Debugger Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                Else
                    UpdateIDEContent(None, "Debugger downloaded to board with sucess.")
                    MessageBox.Show("Debugger downloaded to board with sucess.")
                End If
                Exit Select
        End Select
        If modeDebug Then showSpecialInfo()
        DeleteTempFiles()
    End Sub

    Private Sub showSpecialInfo()
        outputMessages.AppendMessage("<INFO:Dir> " & tempDir, Filter.Compiler)
        outputMessages.AppendMessage("<INFO:Dir> " & fileDir, Filter.Compiler)
        outputMessages.AppendMessage("<INFO:Name> " & GetCurrentBoard.GetName, Filter.Compiler)
        outputMessages.AppendMessage("<INFO:Directive> " & debuggerCmdRequest, Filter.Compiler)
    End Sub

    '    
    'End Sub

    Private Sub DeleteTempFiles()
        Dim tempDir = "C:\Temp\"
        UpdateBuildFolder()
        If Directory.Exists(tempDir) Then
            Try
                Directory.Delete(tempDir, True)
            Catch ex As Exception
                outputMessages.AppendMessage("<DeleteTempFiles> " & ex.Message, Filter.Compiler)
            End Try
        End If
    End Sub

    Private Sub UpdateBuildFolder()
        Dim mainFile As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        Dim hexFile = tempDir & CurrentProjectInfo.General.name & "\" & "build\" & mainFile.Name & ".hex"
        Dim myHexFile = CurrentProjectInfo.DirectoryPaths.buildDir & "\"
        myHexFile &= mainFile.Name & ".hex"
        If Not Directory.Exists(CurrentProjectInfo.DirectoryPaths.buildDir) Then
            Directory.CreateDirectory(CurrentProjectInfo.DirectoryPaths.buildDir)
        End If
        Try
            File.Copy(hexFile, myHexFile, True)
            controlExplorer.UpdateExplorer()
        Catch ex As Exception
            outputMessages.AppendMessage("<BuildGenerate> " & ex.Message, Filter.Compiler)
        End Try
    End Sub

    Public Function getDebugDir()
        Return (debugDir)
    End Function
End Class
