Imports System.IO
Imports DruidaIDEAuxiliarControls
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class CodeSnippets
    Dim fileManager As New FileVarSystem
    Dim infoNames() As String = {"Sintaxe", "Imagem", "Texto", "Título", "Descricão", "Parâmetros", "Retorna", "Notas", "Arquivo"}
    Dim filePreset() As String = {
        "Sintaxe =  ",
        "Imagem = 0",
        "Texto =  ",
        "Título =  ",
        "Descrição =  ",
        "Parâmetros = Nenhum",
        "Retorna = Nada",
        "Notas =  ",
        "Arquivo = "}

    Private Sub CodeSnippets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exSnippets.Paths.Clear()
        exSnippets.Paths.Add(AppInfo.Directories.snippets)
        tbPath.Text = exSnippets.Paths(0)
        exSnippets.LoadExplorer()
        ciImage.ImageList = Druida_IDE.ilCodeElements
        scNavigate.Panel2.Visible = False
        LoadciImage()
    End Sub

    Private Sub LoadciImage()
        Dim cultureResx As New CultureManager
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Palavra-chave"), 0))
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Variável"), 1))
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Constante"), 2))
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Objeto, instância de classe ou estrutura."), 3))
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Método, atributo, função ou procedimento"), 4))
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Tipo, ou construtor de um tipo"), 5))
        ciImage.Items.Add(New ComboBoxIconItem(cultureResx.translateText("Biblioteca"), 6))
    End Sub

    Private Sub exSnippets_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles exSnippets.AfterSelect
        Dim cultureResx As New CultureManager
        scNavigate.Panel2.Visible = e.Node.Text.Contains(".sni")
        If Not VerifyData() Then
            'If MessageBox.Show(cultureResx.translateText("Deseja salvar as alterações?"),
            'cultureResx.translateText("Salvar"),
            'MessageBoxButtons.YesNo,
            'MessageBoxIcon.Question) = DialogResult.Yes Then
            SaveData()
            '    End If
        End If
        If scNavigate.Panel2.Visible Then
            fileManager.SetFilePath(Application.StartupPath & "\CodeSnippets\" & e.Node.FullPath)
            tbFileName.Text = GetNodeFileName()
            tbTag.Text = tbFileName.Text.Split(".")(tbFileName.Text.Split(".").Count - 2)
            Dim infoData() As TextBox = {tbSyntax, tbImagemIndex, tbMenuText, tbTitle, tbDescription, tbParameters, tbReturn, tbNotes, tbFile}
            For i = 0 To infoNames.Count - 1
                Dim item = infoNames(i)
                infoData(i).Text = fileManager.ReadVar(item)
                infoData(i).Text = infoData(i).Text.Replace("\n", vbCrLf)
            Next
        End If
        If tbFile.Text = "Erro" Then
            tbFile.Text = ""
        End If
    End Sub

    Private Function GetNodeFileName()
        Dim fileName As String = ""
        Dim filePath As String = ""
        If exSnippets.SelectedNode IsNot Nothing Then
            filePath = Application.StartupPath & "\" & exSnippets.SelectedNode.FullPath
            fileName = filePath.Split("\")(filePath.Split("\").Count - 1)
        End If
        Return (fileName)
    End Function

    Private Function getNodeDirectory()
        Dim filePath = Application.StartupPath & "\CodeSnippets\" & exSnippets.SelectedNode.FullPath
        Dim directory = ""
        If filePath.Contains(".sni") Then
            directory = filePath.Replace(GetNodeFileName(), "")
        Else
            directory = filePath
        End If
        Return (directory)
    End Function

    Private Sub SaveData()
        If scNavigate.Panel2.Visible Then
            Dim infoData() As TextBox = {tbSyntax, tbImagemIndex, tbMenuText, tbTitle, tbDescription, tbParameters, tbReturn, tbNotes, tbFile}
            For i = 0 To infoNames.Count - 1
                Dim item = infoNames(i)
                Try
                    fileManager.WriteVar(item, infoData(i).Text.Replace(vbCrLf, "\n"))
                Catch ex As Exception
                    Dim cultureResx As New CultureManager
                    If MessageBox.Show(ex.Message & cultureResx.translateText(" Deseja limpar o arquivo para tentar salvá-lo novamente?"),
                                       cultureResx.translateText("Erro"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                        fileManager.ClearFile()
                        MessageBox.Show(cultureResx.translateText("O arquivo está limpo. Tente salvá-lo agora."),
                                        cultureResx.translateText("Arquivo limpo"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Try
            Next
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles tsbtSave.Click, tsmiSave.Click
        SaveData()
    End Sub

    Private Function VerifyData()
        If Not fileManager.Exists Then Return True
        Dim infoData() As String = {tbSyntax.Text.Replace(vbCrLf, "\n"),
                                    tbImagemIndex.Text.Replace(vbCrLf, "\n"),
                                    tbMenuText.Text.Replace(vbCrLf, "\n"),
                                    tbTitle.Text.Replace(vbCrLf, "\n"),
                                    tbDescription.Text.Replace(vbCrLf, "\n"),
                                    tbParameters.Text.Replace(vbCrLf, "\n"),
                                    tbReturn.Text.Replace(vbCrLf, "\n"),
                                    tbNotes.Text.Replace(vbCrLf, "\n"),
                                    tbFile.Text.Replace(vbCrLf, "\n")}
        Return fileManager.VerifyFile(infoNames, infoData)
    End Function

    Private Sub AddFolder_Click(sender As Object, e As EventArgs) Handles tsmiNewFolder.Click, tsbtNewFolder.Click
        Dim cultureResx As New CultureManager
        If exSnippets.SelectedNode Is Nothing Then
            MessageBox.Show(cultureResx.translateText("Selecione um diretório válido para realizar essa ação."))
            Exit Sub
        End If
        NewElement.Text = cultureResx.translateText("Nova Pasta")
        NewElement.tbLocal.Text = getNodeDirectory()
        If (NewElement.ShowDialog = DialogResult.OK) Then
            Dim path As String = getNodeDirectory() & "\" & NewElement.tbName.Text
            Dim nodePath As String = exSnippets.SelectedNode.FullPath & "\" & NewElement.tbName.Text
            Directory.CreateDirectory(path)
            exSnippets.LoadExplorer()
            exSnippets.SelectedNode = exSnippets.GetNode(nodePath, exSnippets.Nodes)
        End If
    End Sub

    Private Sub AddSnippet_Click(sender As Object, e As EventArgs) Handles tsmiAddSnippet.Click, tsbtNewSnippet.Click
        Dim cultureResx As New CultureManager
        If exSnippets.SelectedNode Is Nothing Then
            MessageBox.Show(cultureResx.translateText("Selecione um diretório válido para realizar essa ação."))
            Exit Sub
        End If
        NewElement.Text = cultureResx.translateText("Novo trecho de código")
        NewElement.tbLocal.Text = getNodeDirectory()
        If (NewElement.ShowDialog = DialogResult.OK) Then
            filePreset(0) = "Sintaxe = " & NewElement.tbName.Text & "^"
            filePreset(2) = "Texto = " & NewElement.tbName.Text
            filePreset(3) = "Título = " & NewElement.tbName.Text & " <>"
            File.WriteAllLines(getNodeDirectory() & "\" & NewElement.tbName.Text & ".sni", filePreset)
            exSnippets.LoadExplorer()
            Dim nodePath As String = exSnippets.SelectedNode.FullPath
            Dim last = nodePath.Split("\").Last
            If last.Contains(".sni") Then
                nodePath = nodePath.Replace(last, "")
            End If
            nodePath = nodePath & NewElement.tbName.Text
            exSnippets.SelectedNode = exSnippets.GetNode(nodePath & ".sni", exSnippets.Nodes)
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles tsmiRefresh.Click, tsbtRefresh.Click
        mainAutoCompleteMenu = New AutocompleteMenuData
        exSnippets.LoadExplorer()
    End Sub

    Private Sub tbImagemIndex_TextChanged(sender As Object, e As EventArgs) Handles tbImagemIndex.TextChanged
        Try
            ciImage.SelectedIndex = tbImagemIndex.Text
        Catch ex As Exception
            ciImage.SelectedIndex = -1
        End Try
    End Sub

    Private Sub ciImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ciImage.SelectedIndexChanged
        tbImagemIndex.Text = ciImage.SelectedIndex
    End Sub

    Private Sub TsbClone_Click(sender As Object, e As EventArgs) Handles tsbClone.Click
        If exSnippets.SelectedNode IsNot Nothing Then
            Dim filePath As New FileInfo(exSnippets.SelectedNode.Tag)
            If File.Exists(filePath.FullName) Then
                Dim cultureResx As New CultureManager
                NewElement.Text = cultureResx.translateText("Novo trecho de código")
                NewElement.tbLocal.Text = getNodeDirectory()
                If (NewElement.ShowDialog = DialogResult.OK) Then
                    Try
                        Dim destiny As String = getNodeDirectory() & "\" & NewElement.tbName.Text & ".sni"
                        filePath.CopyTo(destiny)
                        exSnippets.LoadExplorer()
                    Catch ex As Exception
                        MessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub TbSyntax_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbSyntax.MouseDoubleClick
        tbMenuText.Text = tbSyntax.Text
        tbTitle.Text = tbSyntax.Text
        tbSyntax.Text = setPopMenuText(tbSyntax.Text)
        If tbFileName.Text.Replace(".sni", "").Contains(".") And Not tbSyntax.Text.Contains(".") Then
            tbSyntax.Text = tbFileName.Text.Split(".")(0) & "." & tbSyntax.Text
        End If
    End Sub

    Private Function setPopMenuText(text As String)
        Dim aux As String = text
        Dim n As UInt16 = 0
        If aux.Contains("(") And aux.Contains(")") Then
            ciImage.SelectedIndex = CodeInfo.codeImages.method
            Try
                Dim param = aux.Remove(aux.IndexOf(")")).Substring(aux.IndexOf("(") + 1)
                Dim params = param.Split(",")
                n = params.Count
                tbParameters.Text = ""
                For Each p In params
                    tbParameters.Text &= p.Trim & ":" & vbCrLf
                Next
                If param = "" Then
                    n = 0
                    tbParameters.Text = "Nenhum"
                End If
            Catch ex As Exception
                Return text
            End Try
        End If
        If n >= 1 Then
            aux = aux.Split("(")(0) & "(^"
            For i = 0 To n - 1
                If i = n - 1 Then Exit For
                aux &= ", "
            Next
            aux &= ")"
        Else
            aux &= "^"
        End If
        Return aux
    End Function

    Private Sub TbMenuText_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbMenuText.MouseDoubleClick

    End Sub

    Private Sub TbTitle_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbTitle.MouseDoubleClick

    End Sub

    Private Sub TbDescription_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbDescription.MouseDoubleClick

    End Sub

    Private Sub TbParameters_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbParameters.MouseDoubleClick
        Dim text As String = tbParameters.Text.Replace(vbCrLf & vbCrLf, vbCrLf)
        tbParameters.Text = text
    End Sub

    Private Sub TbReturn_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbReturn.MouseDoubleClick

    End Sub
End Class