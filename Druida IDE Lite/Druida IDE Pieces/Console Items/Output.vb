Imports Druida_IDE_Lite.IDEcfgs.Values
Imports Druida_IDE_Lite.MessagesManager

Public Class Output
    Public Sub ApplyTheme()
        Dim fontName As FontFamily = IDEcfgs.GetFontFamily(TextEditor.fontFamily)
        Dim fontStyle As New FontStyle
        Dim fontSize = TextEditor.fontSize
        Dim font As New Font(fontName, fontSize, fontStyle)
        tbOutput.Font = font
        tbOutput.BackColor = Color.FromArgb(CodeColors.BackColor)
        tbOutput.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsOutput.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsOutput.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbOutputFilter.BackColor = Color.FromArgb(CodeColors.BackColor)
        tscbOutputFilter.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tscbOutputFilter.SelectedIndex = 1
    End Sub

    Private Sub tscbOutputFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbOutputFilter.SelectedIndexChanged
        Dim newFilterStatus As Filter = tscbOutputFilter.SelectedIndex
        outputMessages.SetFilter(newFilterStatus)
    End Sub

    Private Sub tsbClearOutput_Click(sender As Object, e As EventArgs) Handles tsbClearOutput.Click
        Dim cultureResx As New CultureManager
        Dim r = MessageBox.Show(cultureResx.translateText("Tem certeza que deseja limpar?"),
                                cultureResx.translateText("Clear"),
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            outputMessages.Clear()
        End If
    End Sub


End Class
