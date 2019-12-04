Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class CFGsProject
    Public nameChanged As Boolean = False

    Private Sub CFGsProject_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()
        ApplyTheme()
    End Sub

    Private Sub LoadSettings()
        tbTitle.Text = CurrentProjectInfo.General.title
        tbName.Text = CurrentProjectInfo.General.name
        tbAuthor.Text = CurrentProjectInfo.General.author
        tbCompany.Text = CurrentProjectInfo.General.company
        tbDescription.Text = CurrentProjectInfo.General.description
        tbVersionMajor.Text = CurrentProjectInfo.Version.major
        tbVersionMinor.Text = CurrentProjectInfo.Version.minor
        tbBuildVersion.Text = CurrentProjectInfo.Version.build
        tbRevisionVersion.Text = CurrentProjectInfo.Version.revision
        tbNotes.Text = CurrentProjectInfo.General.notes
    End Sub

    Private Sub ApplyTheme()
        For Each control In Me.Controls
            If control.GetType = GetType(TextBox) Then
                control.BackColor = Color.FromArgb(CodeColors.BackColor)
                control.ForeColor = Color.FromArgb(CodeColors.ForeColor)
            End If
            If control.GetType = GetType(Label) Then
                control.BackColor = Color.FromArgb(CodeColors.ControlsColor)
                control.ForeColor = Color.FromArgb(CodeColors.ForeColor)
            End If
        Next
    End Sub

    Private Sub ConfirmChangeName()
        If nameChanged Then
            Dim diag = MessageBox.Show("Deseja alterar o nome do projeto? Com isso serão alterados os nomes da pasta e do arquivo de código principal do mesmo.",
                                       "Confirmação",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)
            If diag = DialogResult.Yes Then

            End If
        End If
    End Sub

    Private Sub ChangeName()

    End Sub

    Private Sub tbTitle_TextChanged(sender As Object, e As EventArgs) Handles tbTitle.TextChanged
        CurrentProjectInfo.General.title = tbTitle.Text
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        nameChanged = True
        Dim selection = tbName.SelectionStart
        tbName.Text = TextTreatment.Normalize(tbName.Text)
        tbName.SelectionStart = selection
        CurrentProjectInfo.General.name = tbName.Text
    End Sub

    Private Sub tbAuthor_TextChanged(sender As Object, e As EventArgs) Handles tbAuthor.TextChanged
        CurrentProjectInfo.General.author = tbAuthor.Text
    End Sub

    Private Sub tbCompany_TextChanged(sender As Object, e As EventArgs) Handles tbCompany.TextChanged
        CurrentProjectInfo.General.company = tbCompany.Text
    End Sub

    Private Sub tbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        CurrentProjectInfo.General.description = tbDescription.Text
    End Sub

    Private Sub tbVersionMajor_TextChanged(sender As Object, e As EventArgs) Handles tbVersionMajor.TextChanged
        CurrentProjectInfo.Version.major = TextTreatment.NumbersOnly(tbVersionMajor.Text)
    End Sub

    Private Sub tbVersionMinor_TextChanged(sender As Object, e As EventArgs) Handles tbVersionMinor.TextChanged
        CurrentProjectInfo.Version.minor = TextTreatment.NumbersOnly(tbVersionMinor.Text)
    End Sub

    Private Sub tbBuildVersion_TextChanged(sender As Object, e As EventArgs) Handles tbBuildVersion.TextChanged
        CurrentProjectInfo.Version.build = TextTreatment.NumbersOnly(tbBuildVersion.Text)
    End Sub

    Private Sub tbRevisionVersion_TextChanged(sender As Object, e As EventArgs) Handles tbRevisionVersion.TextChanged
        CurrentProjectInfo.Version.revision = TextTreatment.NumbersOnly(tbRevisionVersion.Text)
    End Sub

    Private Sub tbNotes_TextChanged(sender As Object, e As EventArgs) Handles tbNotes.TextChanged
        CurrentProjectInfo.General.notes = tbNotes.Text.Replace(vbCrLf, "\n")
    End Sub
End Class
