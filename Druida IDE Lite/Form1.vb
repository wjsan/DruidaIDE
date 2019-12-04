Imports Druida_IDE_Lite.IDEcfgs
Imports Code_Editor_For_Arduino

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDEcfgs.VerifyCFGs()
        Dim CodeEditorForArduino1 As New CodeEditorForArduino
        CodeEditorForArduino1.OpenFile("C:\Users\BINAR\OneDrive\Documentos\Druida\Novo_Projeto\Novo_Projeto.ino")
        CodeEditorForArduino1.Dock = DockStyle.Fill
        CodeManager.AssignRef(CodeEditorForArduino1)
        CreateTab("teste", CodeEditorForArduino1)
        'UpdateSyntaxHighlighter()
    End Sub

    Public Sub CreateTab(name As String, content As CodeEditorForArduino)
        'If existingTab Is Nothing Then
        Dim newTab As New TabPage(name)
        content.Dock = DockStyle.Fill
        newTab.Controls.Add(content)
        tcGeneralEditor.TabPages.Add(newTab)
        tcGeneralEditor.SelectedTab = newTab
        'Else
        'tcGeneralEditor.SelectedTab = existingTab
        'End If
    End Sub

End Class
