Imports System.IO
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class LibrariesManager
    Dim arduinoLibs = IDEcfgs.Values.Directories.ArduinoDefaultLib
    Dim myLibs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Arduino\libraries"
    Dim arduinoCoreLibs = IDEcfgs.Values.Directories.ArduinoCoreLib
    Dim myCodeManager As New GeneralCodeManager

    Private Sub Bibliotecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCodeManager.AssignLocalRef(Code)
        libsExplorer.Paths.Add(myLibs)
        libsExplorer.Paths.Add(arduinoLibs)
        libsExplorer.Paths.Add(arduinoCoreLibs)
        AddCustomPaths()
        libsExplorer.PathsNames.Add("My Libraries")
        libsExplorer.PathsNames.Add("Arduino Libraries")
        libsExplorer.PathsNames.Add("Core Libraries")
        AddCustomNames()
        libsExplorer.LoadExplorer()
        VerifyDirs()
        ApplyTheme()
    End Sub

    Private Sub AddCustomPaths()
        For Each libr In Directories.AditionalLibsDir.Replace("\n", vbCrLf).Split(vbCrLf)
            libsExplorer.Paths.Add(libr.Replace(vbLf, ""))
        Next
        For Each libr In BoardsData.GetCurrentBoard.GetAditionalLibs
            libsExplorer.Paths.Add(libr)
        Next
    End Sub

    Private Sub AddCustomNames()
        Dim arduinoAppData As String = AppInfo.Directories.arduinoAppData
        For Each libr In Directories.AditionalLibsDir.Replace("\n", vbCrLf).Split(vbCrLf)
            Dim name As String = libr.Replace(arduinoAppData, "")
            name = name.Split("\").First & " Libraries"
            libsExplorer.PathsNames.Add(name)
        Next
        For Each libr In BoardsData.GetCurrentBoard.GetAditionalLibs
            libsExplorer.PathsNames.Add(BoardsData.GetCurrentBoard.GetName & " Libraries")
        Next
    End Sub


    Public Sub VerifyDirs()
        Dim cultureResx As New CultureManager
        Dim dirList As List(Of String) = libsExplorer.VerifyDirs
        If dirList IsNot Nothing Then
            For Each dirName In dirList
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise,
                                      cultureResx.translateText("Diretório de bibliotecas não encontrado."),
                                      dirName, "")
            Next
        End If
    End Sub

    Private Sub ApplyTheme()
        Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsLibsManager.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsLibsManager.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        libsExplorer.BackColor = Color.FromArgb(CodeColors.BackColor)
        libsExplorer.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsSearch.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsSearch.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tstbSearch.BackColor = Color.FromArgb(CodeColors.BackColor)
        tstbSearch.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        'Code.BackColor = Color.FromArgb(CodeColors.BackColor)
    End Sub

    Private Sub libsExplorer_AfterSelect() Handles libsExplorer.AfterSelect
        If System.IO.File.Exists(libsExplorer.SelectedNode.Tag) Then
            Code.myCodeFileManager.setFilePath(libsExplorer.SelectedNode.Tag)
            myCodeManager.SyntaxHighlighter()
            'Code.myCodeFileManager.LoadFile()
        End If
    End Sub

    Private Sub ToolStripButtonAbrirSketch_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAbrirSketch.Click
        Dim cultureResx As New CultureManager
        Try
            ProjectActions.OpenFile.Open(Code.myCodeFileManager.getFilePath)
            MessageBox.Show(cultureResx.translateText("O arquivo foi aberto com sucesso."),
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButtonImport_Click(sender As Object, e As EventArgs) Handles ToolStripButtonImport.Click
        Dim cultureResx As New CultureManager
        Dim fileInfo As New FileInfo(Code.myCodeFileManager.getFilePath)
        If fileInfo.Name.Contains(".h") Then
            CodeManager.Actions.IncludeLibrary(fileInfo.Name)
            MessageBox.Show(cultureResx.translateText("O arquivo foi importado com sucesso."),
                            "Info", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
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
        libsExplorer.SearchNode(tstbSearch.Text, continueMessage, endMessage)
    End Sub

    Private Sub ToolStripButtonAbrirSketch_MouseEnter(sender As Object, e As EventArgs) Handles ToolStripButtonImport.MouseEnter, ToolStripButtonExit.MouseEnter, ToolStripButtonCopy.MouseEnter, ToolStripButtonAbrirSketch.MouseEnter
        sender.ForeColor = Color.Black
    End Sub

    Private Sub ToolStripButtonAbrirSketch_MouseLeave(sender As Object, e As EventArgs) Handles ToolStripButtonImport.MouseLeave, ToolStripButtonExit.MouseLeave, ToolStripButtonCopy.MouseLeave, ToolStripButtonAbrirSketch.MouseLeave
        sender.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub
End Class