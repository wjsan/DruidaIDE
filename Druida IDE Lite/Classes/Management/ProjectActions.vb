Imports System.IO
Imports Code_Editor_For_Arduino

''' <summary>
''' Management of globall project actions
''' </summary>
Public Class ProjectActions

    Public Class NewProject
        Shared Sub ShowDialog()
            Dim cultureResx As New CultureManager
            Dim title As String = cultureResx.translateText("Novo Projeto")
            Dim path As String = IDEcfgs.Values.Directories.DruidaProjects
            Dim projectType As CreateNewProject.typeOfProject = CreateNewProject.typeOfProject.arduinoProject
            CreateNewProject.setProjectParameters(title, path, projectType)
            CreateNewProject.ShowDialog()
        End Sub
        Shared Sub Create(ByVal path As String)
            CurrentProjectInfo.SetCurrentProjectPath(path)
            Druida_IDE.LoadProject()
        End Sub
    End Class

    Public Class OpenProject
        Shared Function ShowDialog() As DialogResult
            Dim cultureResx As New CultureManager
            Dim openApp As OpenFileDialog = New OpenFileDialog With {
                .Filter = cultureResx.translateText("Arquivo de código do Arduino") & "|*.ino;*.cpp",
                .InitialDirectory = IDEcfgs.Values.Directories.DruidaProjects,
                .Title = cultureResx.translateText("Abrir Pojeto")
            }
            If (openApp.ShowDialog() = DialogResult.OK) Then
                Dim newPath As New FileInfo(openApp.FileName)
                ProjectActions.OpenProject.Open(newPath.DirectoryName, newPath.FullName)
                Return DialogResult.OK
            Else
                Return DialogResult.Cancel
            End If
        End Function

        Shared Sub Open(ByVal path As String, ByVal file As String)
            CurrentProjectInfo.SetCurrentProjectPath(path, file)
            If path IsNot Nothing Then
                Druida_IDE.LoadProject()
            End If
        End Sub

        Shared Sub Open(ByVal path As String)
            CurrentProjectInfo.SetCurrentProjectPath(path)
            Druida_IDE.LoadProject()
        End Sub
    End Class

    Shared Sub Close()
        controlExplorer.tvExplorer.Nodes.Clear()
        controlObjectsExplorer.tvObjectList.Nodes.Clear()
        controlGeneralEditor.CloseAllTabs()
        Druida_IDE.scCodeArea.Panel1.Controls.Clear()
        Druida_IDE.scDruidaMain.Panel1.Controls.Clear()
        controlMainToolBar = New MainToolBar
        controlHomePage = New HomePage
        Druida_IDE.OpenControlInPanel(controlMainToolBar, Druida_IDE.scDruidaMain.Panel1)
        Druida_IDE.OpenControlInPanel(controlHomePage, Druida_IDE.scCodeArea.Panel1)
    End Sub

    Public Class NewLibrary
        Shared Sub ShowDialog()
            Dim cultureResx As New CultureManager
            Dim title As String = cultureResx.translateText("Nova Biblioteca")
            Dim path As String = IDEcfgs.Values.Directories.ArduinoLib
            Dim projectType As CreateNewProject.typeOfProject = CreateNewProject.typeOfProject.library
            CreateNewProject.setProjectParameters(title, path, projectType)
            CreateNewProject.ShowDialog()
        End Sub

        Shared Sub CreateLib(ByVal path As String)
            Dim cultureResx As New CultureManager
            Dim name As String = path.Split("\").Last
            Dim descr As String = cultureResx.translateText("Arquivo a ser compilado para testar a biblioteca")
            CurrentProjectInfo.SetCurrentProjectPath(path)
            Dim content = vbCrLf & "#include """ & name & ".h""" & vbCrLf & vbCrLf
            content &= IDEcfgs.GetModelContent()
            CreateFile.Create(content, path & "\" & name & ".ino", descr)
            content = NewFile.GetLib_h_Content(name)
            descr = cultureResx.translateText("Desrcição das estruturas da biblioteca")
            CreateFile.Create(content, path & "\" & name & ".h", descr)
            content = NewFile.GetLib_cpp_Content(name)
            descr = cultureResx.translateText("Implementação das estruturas da biblioteca")
            CreateFile.Create(content, path & "\" & name & ".cpp", descr)
            Druida_IDE.LoadProject()
        End Sub
    End Class

    Public Class OpenLibrary
        Shared Function ShowDialog()
            Dim cultureResx As New CultureManager
            Dim openApp As OpenFileDialog = New OpenFileDialog With {
                .Filter = cultureResx.translateText("Arquivo de código do Arduino") & "|*.ino;*.cpp",
                .InitialDirectory = IDEcfgs.Values.Directories.ArduinoLib,
                .Title = cultureResx.translateText("Abrir Biblioteca")
            }
            If (openApp.ShowDialog() = DialogResult.OK) Then
                Dim newPath As New FileInfo(openApp.FileName)
                ProjectActions.OpenProject.Open(newPath.DirectoryName, newPath.FullName)
            Else
                Return Nothing
            End If
            Return openApp
        End Function
        Shared Sub Open(path As String)
            ProjectActions.OpenProject.Open(path)
        End Sub
    End Class

    Public Class CloseApplication
            Shared Function ShowDialog()
                Dim cultureResx As New CultureManager
                Dim title As String = cultureResx.translateText("Sair")
                Dim message As String = cultureResx.translateText("Tem certeza que deseja sair do programa?")
                Dim dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes And Not IDEcfgs.Values.Workspace.IsChild Then
                Application.Exit()
            End If
            Return dialogResult
            End Function
        End Class

        Public Class Save

            Public Class CurrentCode
                Shared Function ShowDialog()
                    Dim cultureResx As New CultureManager
                    Dim title As String = cultureResx.translateText("Salvar")
                    Dim message As String = cultureResx.translateText("Deseja salvar as alterações?")
                    Dim dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dialogResult = DialogResult.Yes Then Save()
                    Return dialogResult
                End Function

                Shared Sub Save()
                    CodeManager.Actions.Save()
                End Sub

                Shared Sub SaveAs()
                    Dim cultureResx As New CultureManager
                    Dim title As String = cultureResx.translateText("Salvar")
                    Dim saveFile As New SaveFileDialog
                    saveFile.Title = title
                    saveFile.InitialDirectory = IDEcfgs.Values.Directories.DruidaProjects
                    saveFile.FileName = CodeManager.getCodeName
                    If saveFile.ShowDialog = DialogResult.OK Then
                        CodeManager.Actions.SaveAs(saveFile.FileName)
                    End If
                End Sub
            End Class

            Shared Function ShowDialog()
                Dim cultureResx As New CultureManager
                Dim title As String = cultureResx.translateText("Salvar")
                Dim message As String = cultureResx.translateText("Deseja salvar as alterações?")
                Dim dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If dialogResult = DialogResult.Yes Then SaveProject()
            If dialogResult <> DialogResult.Cancel And Not IDEcfgs.Values.Workspace.IsChild Then Application.Exit()
            Return dialogResult
            End Function
        End Class

        Shared Sub SaveProject()
            controlGeneralEditor.SaveAll()
            CurrentProjectCfgs.Save()
        End Sub


        Public Class SaveAs
            Shared Sub ShowDialog()
                SaveFileAs.ShowDialog()
            End Sub
        End Class

        Public Class Export
            Shared Sub ShowDialog()
                ExportProject.ShowDialog()
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
                controlExplorer.UpdateExplorer()
            End Sub

            Shared Sub Create(ByVal content As Byte(), ByVal filePath As String, ByVal descr As String)
                Dim header As String = CurrentProjectCfgs.GetHeader(filePath, descr)
                File.WriteAllBytes(filePath, content)
                controlExplorer.UpdateExplorer()
            End Sub
        End Class

        Public Class OpenFile
            Shared Sub ShowDialog()
                Dim cultureResx As New CultureManager
                Dim openFile As OpenFileDialog = New OpenFileDialog With {
                    .Filter = cultureResx.translateText("Arquivos de código") & "|*.ino;*.h;*.cpp",
                    .InitialDirectory = IDEcfgs.Values.Directories.DruidaProjects,
                    .Title = cultureResx.translateText("Abrir Arquivo")
                }
                If (openFile.ShowDialog() = DialogResult.OK) Then
                    Open(openFile.FileNames)
                End If
            End Sub

            Shared Sub Open(files() As String)
                For Each fileName In files
                    controlExplorer.OpenCodeFile(fileName)
                Next
            End Sub

            Shared Sub Open(file As String)
                controlExplorer.OpenCodeFile(file)
            End Sub
        End Class

        Public Class ImportFile
            Public Shared Sub ShowDialog()
                Dim cultureResx As New CultureManager
                Dim importFile As OpenFileDialog = New OpenFileDialog With {
                    .Filter = cultureResx.translateText("Arquivos de código") & "|*.ino;*.h;*.cpp",
                    .InitialDirectory = IDEcfgs.Values.Directories.DruidaProjects,
                    .Title = cultureResx.translateText("Importar arquivo")
                }
                If (importFile.ShowDialog() = DialogResult.OK) Then
                    Import(importFile.FileNames)
                End If
            End Sub

            Public Shared Sub Import(files() As String)
                Dim cultureResx As New CultureManager
                For Each fileName In files
                    Dim fileinfo As New FileInfo(fileName)
                    Dim destiny As String = CurrentProjectInfo.DirectoryPaths.projectDirectory & "\" & fileinfo.Name
                    If File.Exists(destiny) Then
                        If MessageBox.Show(cultureResx.translateText("Já existe um arquivo com o mesmo nome, nesse projeto. Deseja sobrescrevê-lo?"),
                                        cultureResx.translateText("Importar arquivo"),
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                            File.Copy(fileName, destiny, True)
                        End If
                    Else
                        File.Copy(fileName, destiny)
                    End If
                    controlExplorer.UpdateExplorer()
                Next
            End Sub
        End Class

        Shared Sub RenameFile(ByVal filePath As String)
            Dim cultureResx As New CultureManager
            Dim file As New FileInfo(filePath)
            NewElement.Text = cultureResx.translateText("Novo nome")
            NewElement.lDescription.Text = cultureResx.translateText("Digite o novo nome do componente selecionado: (Com a extensão!)")
            NewElement.tbLocal.Text = filePath
            NewElement.tbName.Text = file.Name
            If NewElement.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.RenameFile(filePath, NewElement.tbName.Text)
                controlExplorer.UpdateExplorer()
            End If
        End Sub

        Shared Sub RenameEssentialFiles()
            Dim cultureResx As New CultureManager
            Dim file As New FileInfo(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
            NewElement.Text = cultureResx.translateText("Novo nome")
            NewElement.lDescription.Text = cultureResx.translateText("Digite o novo nome do componente selecionado: (Sem a extensão!)")
            NewElement.tbLocal.Text = cultureResx.translateText("Serão renomeados todos os arquivos essenciais do projeto.")
            NewElement.tbName.Text = file.Name.Replace(file.Extension, "")
            If NewElement.ShowDialog = DialogResult.OK Then
                NewElement.tbName.Text = TextTreatment.Normalize(NewElement.tbName.Text)
                Dim mainCodeFile = CurrentProjectInfo.DirectoryPaths.mainCodeFile
                Dim projectFileInfo As New FileInfo(mainCodeFile)
                Dim cfgsFile = CurrentProjectInfo.DirectoryPaths.mainCFGsProjectFile
                Dim folder = CurrentProjectInfo.DirectoryPaths.projectDirectory
                My.Computer.FileSystem.RenameFile(mainCodeFile, NewElement.tbName.Text & ".ino")
                My.Computer.FileSystem.RenameFile(cfgsFile, NewElement.tbName.Text & ".cfg")
                My.Computer.FileSystem.RenameDirectory(folder, NewElement.tbName.Text)
                CurrentProjectInfo.General.name = NewElement.tbName.Text
                Dim newProjectDir As String = projectFileInfo.Directory.FullName
                newProjectDir = newProjectDir.Replace(newProjectDir.Split("\").ToArray.Last, "")
                newProjectDir = newProjectDir & NewElement.tbName.Text
                ProjectActions.OpenProject.Open(newProjectDir)
            End If
        End Sub

    End Class
