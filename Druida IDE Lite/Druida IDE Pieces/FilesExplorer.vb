Imports System.IO
Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class FilesExplorer

    Public Sub ApplyTheme()
        Me.BackColor = Color.FromArgb(CodeColors.BackColor)
        Me.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tvExplorer.BackColor = Color.FromArgb(CodeColors.BackColor)
        tvExplorer.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsExplorer.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsExplorer.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        cmsFiles.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        cmsFiles.BackColor = Color.FromArgb(CodeColors.BackColor)
        lHeader.BackColor = Color.FromArgb(CodeColors.TabsColor)
        lHeader.ForeColor = Color.FromArgb(CodeColors.TabsFontColor)
        lClose.BackColor = lHeader.BackColor
        lClose.ForeColor = lHeader.ForeColor
    End Sub

    Private Sub FilesExplorer_Load(sender As Object, e As EventArgs) Handles Me.Load
        ApplyTheme()
    End Sub

    Public Sub UpdateExplorer()
        tvExplorer.Paths.Clear()
        tvExplorer.Paths.Add(CurrentProjectInfo.DirectoryPaths.projectDirectory)
        tvExplorer.LoadExplorer()
        tvExplorer.ExpandAll()
        tsExplorer.Enabled = True
        For Each item In cmsFiles.Items
            item.enabled = True
        Next
    End Sub

    Private Sub tvExplorer_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvExplorer.NodeMouseDoubleClick
        If e.Node.Text <> CurrentProjectInfo.General.name Then
            OpenFile(e.Node.Tag)
        End If
    End Sub

    Public Sub OpenFile(file As String)
        Dim fileInfo As New FileInfo(file)
        If fileInfo IsNot Nothing Then
            If fileInfo.Exists Then
                Select Case fileInfo.Extension
                    Case ".cfg"
                        OpenCfgFile(file)
                    Case ".ino"
                        OpenCodeFile(fileInfo.FullName)
                    Case ".h"
                        OpenCodeFile(fileInfo.FullName)
                    Case ".cpp"
                        OpenCodeFile(fileInfo.FullName)
                    Case ".c"
                        OpenCodeFile(fileInfo.FullName)
                    Case ".txt"
                        OpenCodeFile(fileInfo.FullName)
                    Case ".hex"
                        OpenCodeFile(fileInfo.FullName)
                    Case ".png"
                        OpenImageFile(fileInfo.FullName)
                    Case ".pdsprj"
                        Try
                            Process.Start(fileInfo.FullName)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Case Else
                        Dim cultureResx As New CultureManager
                        cultureResx.ShowError("O formato de arquivo não pode ser aberto.")
                End Select
            End If
        End If
    End Sub

    Private Sub OpenCfgFile(file As String)
        Dim CFGsExplorer As New ProjectCFGsExplorer
        Dim CFGsFile As New FileInfo(file)
        controlGeneralEditor.CreateTab(CFGsFile.Name, CFGsExplorer, file)
    End Sub

    Public Sub OpenCodeFile(file As String)
        Dim newCode As New CodeEditorForArduino
        Dim codeInfo As New FileInfo(file)
        newCode.myCodeFileManager.setFilePath(file)
        If codeInfo.Exists Then
            If IsLocalFile(codeInfo) Then
                If Workspace.FullPathOnTab Then
                    controlGeneralEditor.CreateTab(codeInfo.FullName, newCode, codeInfo.FullName)
                    Druida_IDE.Text = CurrentProjectInfo.General.name & " - " & codeInfo.FullName
                Else
                    controlGeneralEditor.CreateTab(codeInfo.Name, newCode, codeInfo.FullName)
                End If
            Else
                VerifyEditor(codeInfo)
                If Workspace.FullPathOnTab Then
                    controlGeneralEditor.CreateTab(codeInfo.FullName, newCode, codeInfo.FullName)
                Else
                    controlGeneralEditor.CreateTab("...\" & codeInfo.Name, newCode, codeInfo.FullName)
                End If
            End If
        End If
    End Sub

    Private Sub VerifyEditor(file As FileInfo)
        If Druida_IDE.scCodeArea.Panel1.Controls.Contains(controlHomePage) Then
            Druida_IDE.scCodeArea.Panel1.Controls.Clear()
            Druida_IDE.OpenControlInPanel(controlGeneralEditor, Druida_IDE.scCodeArea.Panel1)
            controlMainToolBar.tsbtSaveFileAs.Enabled = True
            controlMainToolBar.tsbtSaveFile.Enabled = True
            CurrentProjectInfo.DirectoryPaths.projectDirectory = file.DirectoryName
        End If
    End Sub

    Public Sub OpenImageFile(file As String)
        Dim newImgViewer As New ImageViewer
        Dim imgInfo As New FileInfo(file)
        newImgViewer.SetImageSource(file)
        controlGeneralEditor.CreateTab(imgInfo.Name, newImgViewer, imgInfo.FullName)
    End Sub

    Private Shared Function IsLocalFile(codeInfo As FileInfo) As Boolean
        Return codeInfo.Directory.FullName = CurrentProjectInfo.DirectoryPaths.projectDirectory
    End Function

    Private Sub tsbtNewFile_Click(sender As Object, e As EventArgs) Handles tsbtNewFile.Click, tsmiNewFile.Click
        ProjectActions.CreateFile.ShowDialog()
    End Sub

    Private Sub tsbtImportFile_Click(sender As Object, e As EventArgs) Handles tsbtImportFile.Click, tsmiImportFile.Click
        ProjectActions.ImportFile.ShowDialog()
    End Sub

    Private Sub tsbtOpenAllCodes_Click(sender As Object, e As EventArgs) Handles tsbtOpenAllCodes.Click, tsmiOpenAllCodes.Click
        For Each item As TreeNode In tvExplorer.Nodes.Item(0).Nodes
            If item.Tag IsNot Nothing Then
                If IsCode(item.Tag) Then
                    OpenCodeFile(item.Tag)
                End If
            End If
        Next
    End Sub

    Private Sub tsbtRefresh_Click(sender As Object, e As EventArgs) Handles tsbtRefresh.Click
        UpdateExplorer()
    End Sub

    Private Function IsCode(filePath As String)
        Dim FileInfo As New FileInfo(filePath)
        Dim ext As String = FileInfo.Extension
        If ext = ".ino" Or ext = ".cpp" Or ext = "*.h" Then
            Return True
        End If
        Return False
    End Function

    Private Sub AbrirPastaRecipienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirPastaRecipienteToolStripMenuItem.Click
        Process.Start("Explorer", CurrentProjectInfo.DirectoryPaths.projectDirectory)
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        If tvExplorer.SelectedNode IsNot Nothing Then
            If IsEssentialFile() Then
                Dim cultureResx As New CultureManager
                cultureResx.ShowInfo("Este arquivo é essencial para o seu projeto, e não pode ser deletado!")
            Else
                Dim cultureResx As New CultureManager
                Dim dialog = cultureResx.ShowQuestion("Tem certeza que deseja remover o arquivo ", tvExplorer.SelectedNode.Text & "?")
                If dialog = DialogResult.Yes Then
                    Try
                        If File.Exists(tvExplorer.SelectedNode.Tag) Then
                            Dim fileinf As New FileInfo(tvExplorer.SelectedNode.Tag)
                            If IDEcfgs.Values.Workspace.FullPathOnTab Then
                                controlGeneralEditor.CloseTab(fileinf.FullName)
                            Else
                                controlGeneralEditor.CloseTab(fileinf.Name)
                            End If
                            My.Computer.FileSystem.DeleteFile(fileinf.FullName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                        End If
                        If Directory.Exists(tvExplorer.SelectedNode.Tag) Then
                            Directory.Delete(tvExplorer.SelectedNode.Tag, True)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    UpdateExplorer()
                End If
            End If
        End If
    End Sub

    Private Function IsEssentialFile() As Boolean
        Return tvExplorer.SelectedNode.Text = CurrentProjectInfo.General.name & ".cfg" Or
                       tvExplorer.SelectedNode.Text = CurrentProjectInfo.General.name & ".ino" Or
                       tvExplorer.SelectedNode.Text = CurrentProjectInfo.General.name
    End Function

    Private Sub RenomearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenomearToolStripMenuItem.Click
        If IsEssentialFile() Then
            Dim cultureResx As New CultureManager
            Dim diag = cultureResx.ShowQuestion("Ao renomear esse arquivo, serão alteradas as referências e os nomes dos arquivos essenciais do projeto. Deseja continuar?")
            If diag = DialogResult.Yes Then
                ProjectActions.RenameEssentialFiles()
            End If
        Else
            If tvExplorer.SelectedNode IsNot Nothing Then
                ProjectActions.RenameFile(tvExplorer.SelectedNode.Tag)
            End If
        End If
    End Sub

    Private Sub lClose_Click(sender As Object, e As EventArgs) Handles lClose.Click
        Druida_IDE.scWorkArea.Panel1Collapsed = Druida_IDE.scExplorer.Panel2Collapsed
        Druida_IDE.scExplorer.Panel1Collapsed = True
        Workspace.ShowFilesList = Not Druida_IDE.scExplorer.Panel1Collapsed
    End Sub

    Private Sub CopiarCaminhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsbtCopyPath.Click
        Dim path As String = tvExplorer.SelectedNode.Tag
        Clipboard.SetText(path)
    End Sub
End Class