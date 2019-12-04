Imports System.IO
Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class ExamplesManager
    Dim myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim examples = IDEcfgs.Values.Directories.Arduino & "\Examples"
    Dim pathLib = IDEcfgs.Values.Directories.ArduinoLib
    Dim pathDefaltLib = IDEcfgs.Values.Directories.ArduinoDefaultLib
    Dim myCodeManager As New GeneralCodeManager

    Private Sub Exemplos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCodeManager.AssignLocalRef(Code)
        ExampleManager.Paths.Add(examples)
        ExampleManager.Paths.Add(pathLib)
        ExampleManager.Paths.Add(pathDefaltLib)
        AddCustomPaths()
        ExampleManager.PathsNames.Add("Arduino Examples")
        ExampleManager.PathsNames.Add("My Libraries Examples")
        ExampleManager.PathsNames.Add("Core Libraries Examples")
        AddCustomNames()
        ExampleManager.LoadExplorer()
        VerifyDirs()
        ApplyTheme()
    End Sub

    Private Sub AddCustomPaths()
        For Each libr In Directories.AditionalLibsDir.Replace("\n", vbCrLf).Split(vbCrLf)
            Console.WriteLine(libr)
            ExampleManager.Paths.Add(libr.Replace(vbLf, ""))
        Next
        For Each libr In BoardsData.GetCurrentBoard.GetAditionalLibs
            ExampleManager.Paths.Add(libr)
        Next
    End Sub

    Private Sub AddCustomNames()
        Dim arduinoAppData As String = AppInfo.Directories.arduinoAppData
        For Each libr In Directories.AditionalLibsDir.Replace("\n", vbCrLf).Split(vbCrLf)
            Dim name As String = libr.Replace(arduinoAppData, "")
            name = name.Split("\").First & " Examples"
            ExampleManager.PathsNames.Add(name)
        Next
        For Each libr In BoardsData.GetCurrentBoard.GetAditionalLibs
            ExampleManager.PathsNames.Add(BoardsData.GetCurrentBoard.GetName & " Examples")
        Next
    End Sub

    Public Sub VerifyDirs()
        Dim dirList As List(Of String) = ExampleManager.VerifyDirs
        Dim cultureResx As New CultureManager
        If dirList IsNot Nothing Then
            For Each dirName In dirList
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise,
                                      cultureResx.translateText("Diretório de exemplos não encontrado."), dirName, "")
            Next
        End If
    End Sub

    Private Sub ApplyTheme()
        Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsExamplesManager.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsExamplesManager.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        'Code.BackColor = Color.FromArgb(CodeColors.BackColor)
        tbDescription.BackColor = Color.FromArgb(CodeColors.BackColor)
        tbDescription.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        ExampleManager.BackColor = Color.FromArgb(CodeColors.BackColor)
        ExampleManager.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsSearch.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsSearch.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tstbSearch.BackColor = Color.FromArgb(CodeColors.BackColor)
        tstbSearch.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub

    Private Sub GerenciadorArquivos1_SelectedFileChanged() Handles ExampleManager.AfterSelect
        Dim cultureResx As New CultureManager
        Dim filePath As String = ExampleManager.SelectedNode.Tag
        If filePath Is Nothing Or filePath = "" Then Exit Sub
        Dim fileInfo As New FileInfo(filePath)
        Dim fileName As String = fileInfo.Name
        Dim name As String = fileName.Replace(".ino", "")
        Dim path As String = filePath.Replace(fileName, "")
        Dim doc As String = path & "\" & name & ".txt"
        Dim layout As String = path & "\layout.png"
        Dim schematic As String = path & "\schematic.png"
        If File.Exists(filePath) Then
            Code.myCodeFileManager.setFilePath(filePath)
            myCodeManager.SyntaxHighlighter()
        Else
            Code.Text = filePath & ": " & cultureResx.translateText("Arquivo não encontrado.")
        End If
        If File.Exists(doc) Then
            tbDescription.Text = File.ReadAllText(doc)
        Else
            cultureResx.translateText("Arquivo não encontrado.")
        End If
        If File.Exists(layout) Then
            pbLayout.Image = Image.FromFile(layout)
        Else
            pbLayout.Image = Nothing
        End If
        If File.Exists(schematic) Then
            pbSchematix.Image = Image.FromFile(schematic)
        Else
            pbSchematix.Image = Nothing
        End If
    End Sub

    Private Sub ToolStripButtonAbrirSketch_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAbrirSketch.Click
        Dim cultureResx As New CultureManager
        Try
            ProjectActions.OpenFile.Open(Code.myCodeFileManager.getFilePath)
            MessageBox.Show(cultureResx.translateText("O arquivo foi aberto com sucesso."),
                            "Info", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, cultureResx.translateText("Erro"),
            'MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButtonImport_Click(sender As Object, e As EventArgs) Handles ToolStripButtonImport.Click
        Dim cultureResx As New CultureManager
        Try
            Dim newArray As String() = {Code.myCodeFileManager.getFilePath}
            ProjectActions.ImportFile.Import(newArray)
            MessageBox.Show(cultureResx.translateText("O arquivo foi importado com sucesso."),
                            "Info", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Catch ex As Exception
            'MessageBox.Show(ex.Message,
            'cultureResx.translateText("Erro"),
            'MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButtonCopy_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCopy.Click
        Code.SelectAll()
        Code.Copy()
    End Sub

    Private Sub ToolStripButtonExit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonExit.Click
        Close()
    End Sub

    Private Sub TsbtSearch_Click(sender As Object, e As EventArgs) Handles tsbtSearch.Click
        Dim cultureResx As New CultureManager
        Dim continueMessage As String = cultureResx.translateText("Deseja continuar a pesquisa?")
        Dim endMessage As String = cultureResx.translateText("A pesquisa chegou ao fim do documento.")
        ExampleManager.SearchNode(tstbSearch.Text, continueMessage, endMessage)
    End Sub

    Private Sub tsbtOpenInNewWindow_Click(sender As Object, e As EventArgs) Handles tsbtOpenInNewWindow.Click
        Dim mePath As String = Application.ExecutablePath
        Dim fileToOpenInf As New FileInfo(Code.myCodeFileManager.getFilePath)
        Dim tempProjectDir As String = AppInfo.Directories.project & "\Examples"
        Dim folderName As String = fileToOpenInf.DirectoryName.Split("\").Last
        Dim filePath As String = tempProjectDir & "\" & folderName & "\" & fileToOpenInf.Name
        Dim fileToOpen As String = """" & filePath & """"
        Dim p As New ProcessStartInfo
        Directory.CreateDirectory(tempProjectDir)
        My.Computer.FileSystem.CopyDirectory(fileToOpenInf.DirectoryName, tempProjectDir & "\" & folderName, True)
        If File.Exists(filePath) Then
            p.FileName = mePath
            p.Arguments = fileToOpen
            Process.Start(p)
        End If
        Me.Close()
    End Sub

    Private Sub TsbtOpenInNewWindow_MouseEnter(sender As Object, e As EventArgs) Handles tsbtOpenInNewWindow.MouseEnter, ToolStripButtonImport.MouseEnter, ToolStripButtonExit.MouseEnter, ToolStripButtonCopy.MouseEnter, ToolStripButtonAbrirSketch.MouseEnter
        sender.ForeColor = Color.Black
    End Sub

    Private Sub TsbtOpenInNewWindow_MouseLeave(sender As Object, e As EventArgs) Handles tsbtOpenInNewWindow.MouseLeave, ToolStripButtonImport.MouseLeave, ToolStripButtonExit.MouseLeave, ToolStripButtonCopy.MouseLeave, ToolStripButtonAbrirSketch.MouseLeave
        sender.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub
End Class