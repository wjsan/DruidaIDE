Imports Druida_IDE_Lite.IDEcfgs.Values
Imports Druida_IDE_Lite.IDEcfgs
Imports System.Drawing.Text

Public Class SettingsFontColor
    Dim fontName As FontFamily
    Dim fontSize As Single
    Dim fontStyle As New FontStyle
    Dim profileFile As New FileVarSystem

    Dim colorKeyValues() As String = {Values.CodeColors.TypeNamesColor,
                                        Values.CodeColors.CppCommonColor,
                                        Values.CodeColors.ArduinoKeywordsColor,
                                        Values.CodeColors.DataTypesColor,
                                        Values.CodeColors.CompilerKeysColor,
                                        Values.CodeColors.NumbersColor,
                                        Values.CodeColors.CommentsColor,
                                        Values.CodeColors.ConstantsNamesColor,
                                        Values.CodeColors.StringColor,
                                        Values.CodeColors.SameWordsColor,
                                        Values.CodeColors.DeclaredInstancesColor,
                                        Values.CodeColors.DeclaredClassTypesColor,
                                        Values.CodeColors.InstanceMethodsStyleColor,
                                        Values.CodeColors.DeclaredMethodsStyleColor,
                                        Values.CodeColors.ForeColor,
                                        Values.CodeColors.BackColor,
                                        Values.CodeColors.ControlsColor,
                                        Values.CodeColors.LineNumbersColor,
                                        Values.CodeColors.LineNumbersBackColor,
                                        Values.CodeColors.TabsColor,
                                        Values.CodeColors.TabsHeaderColor,
                                        Values.CodeColors.TabsFontColor}


    Dim styleKeyValues() As String = {IDEcfgs.Values.CodeStyles.TypeNamesStyle,
                                        IDEcfgs.Values.CodeStyles.CppCommonStyle,
                                        IDEcfgs.Values.CodeStyles.ArduinoKeywordsStyle,
                                        IDEcfgs.Values.CodeStyles.DataTypesStyle,
                                        IDEcfgs.Values.CodeStyles.CompilerKeysStyle,
                                        IDEcfgs.Values.CodeStyles.NumbersStyle,
                                        IDEcfgs.Values.CodeStyles.CommentsStyle,
                                        IDEcfgs.Values.CodeStyles.ConstantsNamesStyle,
                                        IDEcfgs.Values.CodeStyles.StringStyle,
                                        IDEcfgs.Values.CodeStyles.SameWordsStyle,
                                        IDEcfgs.Values.CodeStyles.DeclaredInstancesStyle,
                                        IDEcfgs.Values.CodeStyles.DeclaredClassTypesStyle,
                                        IDEcfgs.Values.CodeStyles.InstanceMethodsStyleStyle,
                                        IDEcfgs.Values.CodeStyles.DeclaredMethodsStyleStyle}

    Private Sub LoadKeyValues()
        colorKeyValues = {Values.CodeColors.TypeNamesColor,
                            Values.CodeColors.CppCommonColor,
                            Values.CodeColors.ArduinoKeywordsColor,
                            Values.CodeColors.DataTypesColor,
                            Values.CodeColors.CompilerKeysColor,
                            Values.CodeColors.NumbersColor,
                            Values.CodeColors.CommentsColor,
                            Values.CodeColors.ConstantsNamesColor,
                            Values.CodeColors.StringColor,
                            Values.CodeColors.SameWordsColor,
                            Values.CodeColors.DeclaredInstancesColor,
                            Values.CodeColors.DeclaredClassTypesColor,
                            Values.CodeColors.InstanceMethodsStyleColor,
                            Values.CodeColors.DeclaredMethodsStyleColor,
                            Values.CodeColors.ForeColor,
                            Values.CodeColors.BackColor,
                            Values.CodeColors.ControlsColor,
                            Values.CodeColors.LineNumbersColor,
                            Values.CodeColors.LineNumbersBackColor,
                            Values.CodeColors.TabsColor,
                            Values.CodeColors.TabsHeaderColor,
                            Values.CodeColors.TabsFontColor}
        styleKeyValues = {IDEcfgs.Values.CodeStyles.TypeNamesStyle,
                            IDEcfgs.Values.CodeStyles.CppCommonStyle,
                            IDEcfgs.Values.CodeStyles.ArduinoKeywordsStyle,
                            IDEcfgs.Values.CodeStyles.DataTypesStyle,
                            IDEcfgs.Values.CodeStyles.CompilerKeysStyle,
                            IDEcfgs.Values.CodeStyles.NumbersStyle,
                            IDEcfgs.Values.CodeStyles.CommentsStyle,
                            IDEcfgs.Values.CodeStyles.ConstantsNamesStyle,
                            IDEcfgs.Values.CodeStyles.StringStyle,
                            IDEcfgs.Values.CodeStyles.SameWordsStyle,
                            IDEcfgs.Values.CodeStyles.DeclaredInstancesStyle,
                            IDEcfgs.Values.CodeStyles.DeclaredClassTypesStyle,
                            IDEcfgs.Values.CodeStyles.InstanceMethodsStyleStyle,
                            IDEcfgs.Values.CodeStyles.DeclaredMethodsStyleStyle}
    End Sub

    Private Sub SettingsFont_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFonts()
        LoadColors()
        cbFontSize.SelectedItem = IDEcfgs.Values.TextEditor.fontSize
        cbFontFamily.SelectedItem = IDEcfgs.Values.TextEditor.fontFamily
    End Sub

    Private Sub LoadFonts()
        cbFontFamily.Items.Clear()
        Dim installFonts As New InstallFonts
        installFonts.Install()
        Dim fontFamilies() As FontFamily = New InstalledFontCollection().Families
        For Each fontFamilie As FontFamily In fontFamilies
            If FontAnalyser.IsFixedWidth(fontFamilie) Then
                cbFontFamily.Items.Add(fontFamilie.Name)
            End If
        Next
    End Sub

    Private Sub LoadColors()
        cbColor.Items.Clear()
        cbColor.Items.Add("Custom")
        For Each c As KnownColor In [Enum].GetValues(GetType(KnownColor))
            cbColor.Items.Add([Enum].GetName(GetType(KnownColor), c))
        Next
    End Sub

    Private Sub cbFontName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFontFamily.SelectedIndexChanged
        fontName = IDEcfgs.GetFontFamily(cbFontFamily.SelectedItem)
        UpdateFont()
        UpdateCodeEditorFont()
    End Sub

    Private Sub cbFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFontSize.SelectedIndexChanged
        fontSize = Convert.ToSingle(cbFontSize.SelectedItem)
        UpdateFont()
        UpdateCodeEditorFont()
    End Sub

    Private Sub UpdateFont()
        If cbFontFamily.SelectedIndex <> -1 Then
            Try
                UpdatePreviewFont()
                IDEcfgs.Values.TextEditor.fontFamily = fontName.Name
                IDEcfgs.Values.TextEditor.fontSize = fontSize
            Catch ex As Exception
                MessageBox.Show("Erro ao configurar a fonte: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UpdatePreviewFont()
        Dim font As New Font(fontName, fontSize, fontStyle)
        If cbColor.SelectedIndex <> -1 Then
            tbPreview.ForeColor = Color.FromName(cbColor.SelectedItem)
        End If
        tbPreview.Font = font
    End Sub

    Private Sub UpdateCodeEditorFont()
        With controlGeneralEditor
            .UpdateCodeEditor(GeneralEditor.UpdateItems.Font)
        End With
    End Sub

    Private Sub cbBold_CheckedChanged(sender As Object, e As EventArgs) Handles cbBold.CheckedChanged
        UpdateFontStyle(cbBold.Checked, FontStyle.Bold)
        UpdateSelectedStyle()
    End Sub

    Private Sub cbItalic_CheckedChanged(sender As Object, e As EventArgs) Handles cbItalic.CheckedChanged
        UpdateFontStyle(cbItalic.Checked, FontStyle.Italic)
        UpdateSelectedStyle()
    End Sub

    Private Sub cbUnderlined_CheckedChanged(sender As Object, e As EventArgs) Handles cbUnderlined.CheckedChanged
        UpdateFontStyle(cbUnderlined.Checked, FontStyle.Underline)
        UpdateSelectedStyle()
    End Sub

    Private Sub UpdateFontStyle(status As Boolean, style As FontStyle)
        If status Then
            fontStyle = fontStyle Or style
        Else
            fontStyle = fontStyle Xor style
        End If
        UpdatePreviewFont()
    End Sub

    Private Sub lbSyntax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSyntax.SelectedIndexChanged
        LoadColorSettings(colorKeyValues(lbSyntax.SelectedIndex))
        If styleKeyValues.Count > lbSyntax.SelectedIndex Then
            LoadStyleSettings(styleKeyValues(lbSyntax.SelectedIndex))
        End If
        UpdateFont()
    End Sub

    Private Sub LoadColorSettings(ByVal colorARGB As String)
        If colorARGB = "Erro" Then Exit Sub
        cbColor.SelectedItem = "Personalizado"
        pbColor.BackColor = Color.FromArgb(colorARGB)
        tbPreview.ForeColor = Color.FromArgb(colorARGB)
    End Sub

    Private Sub LoadStyleSettings(ByVal style As FontStyle)
        cbBold.Checked = (style And FontStyle.Bold)
        cbItalic.Checked = (style And FontStyle.Italic)
        cbUnderlined.Checked = (style And FontStyle.Underline)
    End Sub

    Private Sub cbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbColor.SelectedIndexChanged
        If cbColor.SelectedItem <> "Personalizado" Then
            pbColor.BackColor = Color.FromName(cbColor.SelectedItem)
            UpdateSelectedColor()
        End If
    End Sub

    Private Sub UpdateSelectedColor()
        Select Case lbSyntax.SelectedIndex
            Case 0
                CodeColors.TypeNamesColor = pbColor.BackColor.ToArgb
            Case 1
                CodeColors.CppCommonColor = pbColor.BackColor.ToArgb
            Case 2
                CodeColors.ArduinoKeywordsColor = pbColor.BackColor.ToArgb
            Case 3
                CodeColors.DataTypesColor = pbColor.BackColor.ToArgb
            Case 4
                CodeColors.CompilerKeysColor = pbColor.BackColor.ToArgb
            Case 5
                CodeColors.NumbersColor = pbColor.BackColor.ToArgb
            Case 6
                CodeColors.CommentsColor = pbColor.BackColor.ToArgb
            Case 7
                CodeColors.ConstantsNamesColor = pbColor.BackColor.ToArgb
            Case 8
                CodeColors.StringColor = pbColor.BackColor.ToArgb
            Case 9
                CodeColors.SameWordsColor = pbColor.BackColor.ToArgb
            Case 10
                CodeColors.DeclaredInstancesColor = pbColor.BackColor.ToArgb
            Case 11
                CodeColors.DeclaredClassTypesColor = pbColor.BackColor.ToArgb
            Case 12
                CodeColors.InstanceMethodsStyleColor = pbColor.BackColor.ToArgb
            Case 13
                CodeColors.DeclaredMethodsStyleColor = pbColor.BackColor.ToArgb
            Case 14
                CodeColors.ForeColor = pbColor.BackColor.ToArgb
            Case 15
                CodeColors.BackColor = pbColor.BackColor.ToArgb
            Case 16
                CodeColors.ControlsColor = pbColor.BackColor.ToArgb
            Case 17
                CodeColors.LineNumbersColor = pbColor.BackColor.ToArgb
            Case 18
                CodeColors.LineNumbersBackColor = pbColor.BackColor.ToArgb
            Case 19
                CodeColors.TabsColor = pbColor.BackColor.ToArgb
            Case 20
                CodeColors.TabsHeaderColor = pbColor.BackColor.ToArgb
            Case 21
                CodeColors.TabsFontColor = pbColor.BackColor.ToArgb
        End Select
        tbPreview.ForeColor = pbColor.BackColor
    End Sub

    Private Sub UpdateSelectedStyle()
        Select Case lbSyntax.SelectedIndex
            Case 0
                CodeStyles.TypeNamesStyle = fontStyle
            Case 1
                CodeStyles.CppCommonStyle = fontStyle
            Case 2
                CodeStyles.ArduinoKeywordsStyle = fontStyle
            Case 3
                CodeStyles.DataTypesStyle = fontStyle
            Case 4
                CodeStyles.CompilerKeysStyle = fontStyle
            Case 5
                CodeStyles.NumbersStyle = fontStyle
            Case 6
                CodeStyles.CommentsStyle = fontStyle
            Case 7
                CodeStyles.ConstantsNamesStyle = fontStyle
            Case 8
                CodeStyles.StringStyle = fontStyle
            Case 9
                CodeStyles.SameWordsStyle = fontStyle
            Case 10
                CodeStyles.DeclaredInstancesStyle = fontStyle
            Case 11
                CodeStyles.DeclaredClassTypesStyle = fontStyle
            Case 12
                CodeStyles.InstanceMethodsStyleStyle = fontStyle
            Case 13
                CodeStyles.DeclaredMethodsStyleStyle = fontStyle
        End Select
    End Sub

    Private Sub btApply_Click(sender As Object, e As EventArgs) Handles btApply.Click
        CodeManager.UpdateTextStyle()
        IDEcfgs.SaveCodeColorsCFGs()
        LoadKeyValues()
        Try
            controlHomePage.ApplyTheme()
            Druida_IDE.ApplyTheme()
        Catch ex As Exception
            consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "ColorsManager", "")
        End Try
    End Sub

    Private Sub btSaveAs_Click(sender As Object, e As EventArgs) Handles btSaveAs.Click
        ExternalInterfaces.Styles.ShowExportDialog()
        LoadKeyValues()
    End Sub

    Private Sub btOpen_Click(sender As Object, e As EventArgs) Handles btOpen.Click
        ExternalInterfaces.Styles.ShowImportDialog()
        LoadKeyValues()
    End Sub

    Private Sub btColor_Click(sender As Object, e As EventArgs) Handles btColor.Click
        chooseColor.Color = pbColor.BackColor
        chooseColor.ShowDialog()
        pbColor.BackColor = chooseColor.Color
        cbColor.SelectedItem = "Personalizado"
        UpdateSelectedColor()
    End Sub
End Class
