Imports Druida_IDE_Lite.IDEcfgs

Public Class ExternalInterfaces
    'comments
    Public Class Styles
        Shared externalStyleCfgs As New FileVarSystem

        Shared Sub ShowExportDialog()
            Dim cultureResx As New CultureManager
            Dim initialPath As String = AppInfo.Directories.styles
            Dim saveFile As New SaveFileDialog With {
                .Filter = cultureResx.translateText("Arquivo") & " style|*.style",
                .InitialDirectory = initialPath,
                .Title = cultureResx.translateText("Exportar") & " Style"
                }
            Dim dialogResult = saveFile.ShowDialog()
            If dialogResult <> DialogResult.Cancel Then
                ExportStyles(saveFile.FileName)
            End If
        End Sub

        Shared Sub ShowImportDialog()
            Dim cultureResx As New CultureManager
            Dim initialPath As String = AppInfo.Directories.styles
            Dim openFile As New OpenFileDialog With {
                .Filter = cultureResx.translateText("Arquivo") & " style|*.style",
                .InitialDirectory = initialPath,
                .Title = cultureResx.translateText("Importar arquivo") & " Style"
                }
            Dim dialogResult = openFile.ShowDialog()
            If dialogResult <> DialogResult.Cancel Then
                ImportStyles(openFile.FileName)
            End If
        End Sub

        Private Shared Sub ExportStyles(ByVal path As String)
            externalStyleCfgs.SetFilePath(path)
            exportColors()
            exportFormat()
        End Sub

        Shared Sub ImportStyles(ByVal path As String)
            externalStyleCfgs.SetFilePath(path)
            importColors()
            importFormat()
        End Sub

        Private Shared Sub exportColors()
            externalStyleCfgs.WriteVar(Names.CodeColors.ArduinoKeywordsColor, Values.CodeColors.ArduinoKeywordsColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.BackColor, Values.CodeColors.BackColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.CommentsColor, Values.CodeColors.CommentsColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.CompilerKeysColor, Values.CodeColors.CompilerKeysColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.ConstantsNamesColor, Values.CodeColors.ConstantsNamesColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.ControlsColor, Values.CodeColors.ControlsColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.CppCommonColor, Values.CodeColors.CppCommonColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.DataTypesColor, Values.CodeColors.DataTypesColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.DeclaredClassTypesColor, Values.CodeColors.DeclaredClassTypesColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.DeclaredInstancesColor, Values.CodeColors.DeclaredInstancesColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.DeclaredMethodsStyleColor, Values.CodeColors.DeclaredMethodsStyleColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.ForeColor, Values.CodeColors.ForeColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.InstanceMethodsStyleColor, Values.CodeColors.InstanceMethodsStyleColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.LineNumbersBackColor, Values.CodeColors.LineNumbersBackColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.LineNumbersColor, Values.CodeColors.LineNumbersColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.NumbersColor, Values.CodeColors.NumbersColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.SameWordsColor, Values.CodeColors.SameWordsColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.StringColor, Values.CodeColors.StringColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.TabsColor, Values.CodeColors.TabsColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.TabsFontColor, Values.CodeColors.TabsFontColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.TabsHeaderColor, Values.CodeColors.TabsHeaderColor)
            externalStyleCfgs.WriteVar(Names.CodeColors.TypeNamesColor, Values.CodeColors.TypeNamesColor)

        End Sub

        Private Shared Sub exportFormat()
            externalStyleCfgs.WriteVar(Names.CodeStyles.ArduinoKeywordsStyle, Values.CodeStyles.ArduinoKeywordsStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.CommentsStyle, Values.CodeStyles.CommentsStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.CompilerKeysStyle, Values.CodeStyles.CompilerKeysStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.ConstantsNamesStyle, Values.CodeStyles.ConstantsNamesStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.CppCommonStyle, Values.CodeStyles.CppCommonStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.DataTypesStyle, Values.CodeStyles.DataTypesStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.DeclaredClassTypesStyle, Values.CodeStyles.DeclaredClassTypesStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.DeclaredInstancesStyle, Values.CodeStyles.DeclaredInstancesStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.DeclaredMethodsStyleStyle, Values.CodeStyles.DeclaredMethodsStyleStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.InstanceMethodsStyleStyle, Values.CodeStyles.InstanceMethodsStyleStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.NumbersStyle, Values.CodeStyles.NumbersStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.SameWordsStyle, Values.CodeStyles.SameWordsStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.StringStyle, Values.CodeStyles.StringStyle)
            externalStyleCfgs.WriteVar(Names.CodeStyles.TypeNamesStyle, Values.CodeStyles.TypeNamesStyle)
        End Sub

        Private Shared Sub importColors()
            Values.CodeColors.ArduinoKeywordsColor = externalStyleCfgs.ReadVar(Names.CodeColors.ArduinoKeywordsColor)
            Values.CodeColors.BackColor = externalStyleCfgs.ReadVar(Names.CodeColors.BackColor)
            Values.CodeColors.CommentsColor = externalStyleCfgs.ReadVar(Names.CodeColors.CommentsColor)
            Values.CodeColors.CompilerKeysColor = externalStyleCfgs.ReadVar(Names.CodeColors.CompilerKeysColor)
            Values.CodeColors.ConstantsNamesColor = externalStyleCfgs.ReadVar(Names.CodeColors.ConstantsNamesColor)
            Values.CodeColors.ControlsColor = externalStyleCfgs.ReadVar(Names.CodeColors.ControlsColor)
            Values.CodeColors.CppCommonColor = externalStyleCfgs.ReadVar(Names.CodeColors.CppCommonColor)
            Values.CodeColors.DataTypesColor = externalStyleCfgs.ReadVar(Names.CodeColors.DataTypesColor)
            Values.CodeColors.DeclaredClassTypesColor = externalStyleCfgs.ReadVar(Names.CodeColors.DeclaredClassTypesColor)
            Values.CodeColors.DeclaredInstancesColor = externalStyleCfgs.ReadVar(Names.CodeColors.DeclaredInstancesColor)
            Values.CodeColors.DeclaredMethodsStyleColor = externalStyleCfgs.ReadVar(Names.CodeColors.DeclaredMethodsStyleColor)
            Values.CodeColors.ForeColor = externalStyleCfgs.ReadVar(Names.CodeColors.ForeColor)
            Values.CodeColors.InstanceMethodsStyleColor = externalStyleCfgs.ReadVar(Names.CodeColors.InstanceMethodsStyleColor)
            Values.CodeColors.LineNumbersBackColor = externalStyleCfgs.ReadVar(Names.CodeColors.LineNumbersBackColor)
            Values.CodeColors.LineNumbersColor = externalStyleCfgs.ReadVar(Names.CodeColors.LineNumbersColor)
            Values.CodeColors.NumbersColor = externalStyleCfgs.ReadVar(Names.CodeColors.NumbersColor)
            Values.CodeColors.SameWordsColor = externalStyleCfgs.ReadVar(Names.CodeColors.SameWordsColor)
            Values.CodeColors.StringColor = externalStyleCfgs.ReadVar(Names.CodeColors.StringColor)
            Values.CodeColors.TabsColor = externalStyleCfgs.ReadVar(Names.CodeColors.TabsColor)
            Values.CodeColors.TabsFontColor = externalStyleCfgs.ReadVar(Names.CodeColors.TabsFontColor)
            Values.CodeColors.TabsHeaderColor = externalStyleCfgs.ReadVar(Names.CodeColors.TabsHeaderColor)
            Values.CodeColors.TypeNamesColor = externalStyleCfgs.ReadVar(Names.CodeColors.TypeNamesColor)
            'IDEcfgs.VerifyCodeColorsKeys()
        End Sub

        Private Shared Sub importFormat()
            Values.CodeStyles.ArduinoKeywordsStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.ArduinoKeywordsStyle)
            Values.CodeStyles.CommentsStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.CommentsStyle)
            Values.CodeStyles.CompilerKeysStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.CompilerKeysStyle)
            Values.CodeStyles.ConstantsNamesStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.ConstantsNamesStyle)
            Values.CodeStyles.CppCommonStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.CppCommonStyle)
            Values.CodeStyles.DataTypesStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.DataTypesStyle)
            Values.CodeStyles.DeclaredClassTypesStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.DeclaredClassTypesStyle)
            Values.CodeStyles.DeclaredInstancesStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.DeclaredInstancesStyle)
            Values.CodeStyles.DeclaredMethodsStyleStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.DeclaredMethodsStyleStyle)
            Values.CodeStyles.InstanceMethodsStyleStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.InstanceMethodsStyleStyle)
            Values.CodeStyles.NumbersStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.NumbersStyle)
            Values.CodeStyles.SameWordsStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.SameWordsStyle)
            Values.CodeStyles.StringStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.StringStyle)
            Values.CodeStyles.TypeNamesStyle = externalStyleCfgs.ReadVar(Names.CodeStyles.TypeNamesStyle)
            'IDEcfgs.VerifyCodeStylesKeys()
        End Sub
    End Class


End Class
