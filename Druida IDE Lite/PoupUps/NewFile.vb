Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Code_Editor_For_Arduino

Public Class NewFile

    'Dim extension As String = ""
    Dim projectPath As String = CurrentProjectInfo.DirectoryPaths.projectDirectory

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim cultureResx As New CultureManager
        Dim expecialCharExist As Boolean = Regex.IsMatch(tbName.Text, ("@[^a-zA-Z0-9]"))
        If cbType.SelectedIndex < 0 Then
            MessageBox.Show(cultureResx.translateText("Selecione um tipo de arquivo válido."),
                            cultureResx.translateText("Erro"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If
        If expecialCharExist Or tbName.Text = "" Then
            MessageBox.Show(cultureResx.translateText("Não é permitido caracteres especiais ou nome em branco. Favor alterar o nome."),
                            cultureResx.translateText("Erro"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            If (cbType.SelectedIndex = 0) Then
                CreateLib()
            End If
            If (cbType.SelectedIndex = 1) Then
                CreateInoFile()
            End If
            If (cbType.SelectedIndex = 2) Then
                CreateNotes()
            End If
            If (cbType.SelectedIndex = 3) Then
                ImportImage()
            End If
            If (cbType.SelectedIndex = 4) Then
                CreateInterfaceFile()
            End If
            If (cbType.SelectedIndex = 5) Then
                CreateCFile()
            End If
            If (cbType.SelectedIndex = 6) Then
                CreateCppFile()
            End If
            If (cbType.SelectedIndex = 7) Then
                CreateProteusFile()
            End If
            If (cbType.SelectedIndex = 8) Then
                CreateCLib()
            End If
            controlExplorer.UpdateExplorer()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub CreateLib()
        Dim content As String = ""
        content = GetLib_h_Content(tbName.Text)
        ProjectActions.CreateFile.Create(content, projectPath & "\" & tbName.Text & ".h", tbDescription.Text)
        content = GetLib_cpp_Content(tbName.Text)
        ProjectActions.CreateFile.Create(content, projectPath & "\" & tbName.Text & ".cpp", tbDescription.Text)
    End Sub

    Private Sub CreateCLib()
        ProjectActions.CreateFile.Create("", projectPath & "\" & tbName.Text & ".h", tbDescription.Text)
        ProjectActions.CreateFile.Create("", projectPath & "\" & tbName.Text & ".c", tbDescription.Text)
    End Sub

    Private Sub CreateInoFile()
        ProjectActions.CreateFile.Create("", projectPath & "\" & tbName.Text & ".ino", tbDescription.Text)
    End Sub

    Private Sub CreateNotes()
        ProjectActions.CreateFile.Create("", projectPath & "\" & tbName.Text & ".txt", tbDescription.Text)
    End Sub

    Private Sub ImportImage()
        Dim cultureResx As New CultureManager
        Dim openImage As New OpenFileDialog With {
            .Filter = cultureResx.translateText("Imagens") & "|*.png",
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
            .Title = cultureResx.translateText("Importar Imagem")
        }
        If (openImage.ShowDialog() = DialogResult.OK) Then
            System.IO.File.Copy(openImage.FileName, projectPath & "\" & tbName.Text & ".png", True)
        End If
    End Sub

    Private Sub CreateInterfaceFile()
        Dim content As String = ""
        content &= vbLf
        content &= "#ifndef " & tbName.Text & "_h" & vbLf
        content &= "#define " & tbName.Text & "_h" & vbLf
        content &= vbLf
        content &= vbLf
        content &= "#endif"
        ProjectActions.CreateFile.Create(content, projectPath & "\" & tbName.Text & ".h", tbDescription.Text)
    End Sub

    Private Sub CreateCFile()
        ProjectActions.CreateFile.Create("", projectPath & "\" & tbName.Text & ".c", tbDescription.Text)
    End Sub

    Private Sub CreateCppFile()
        ProjectActions.CreateFile.Create("", projectPath & "\" & tbName.Text & ".cpp", tbDescription.Text)
    End Sub

    Private Sub CreateProteusFile()
        Dim content = My.Resources.Novo_Projeto
        ProjectActions.CreateFile.Create(content, projectPath & "\" & tbName.Text & ".pdsprj", tbDescription.Text)
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txBoxName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        Dim selection = tbName.SelectionStart
        tbName.Text = TextTreatment.Normalize(tbName.Text)
        tbName.SelectionStart = selection
    End Sub

    Public Function GetLib_h_Content(name As String)
        Dim content As String = ""
        content &= vbLf
        content &= "#ifndef " & name & "_h" & vbLf
        content &= "#define " & name & "_h" & vbLf
        content &= vbLf
        content &= "class " & name & vbLf
        content &= "{" & vbLf
        content &= "public:" & vbLf
        content &= vbTab & name & "();" & vbLf
        content &= "private:" & vbLf
        content &= "};" & vbLf & vbLf
        content &= "#endif"
        Return content
    End Function

    Public Function GetLib_cpp_Content(name As String)
        Dim content = ""
        content = vbLf
        content &= "#include """ & name & ".h""" & vbLf
        content &= vbLf
        content &= name & "::" & name & "()" & vbLf
        content &= "{" & vbLf
        content &= "}" & vbLf
        Return content
    End Function
End Class
