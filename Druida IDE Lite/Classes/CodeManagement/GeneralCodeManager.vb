Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.IDEcfgs
Imports System.IO

Module MyGeneralCodeManager
    Public CodeManager As New GeneralCodeManager
End Module

''' <summary>
''' Responsible for assign and manage all features Of the code editor (syntax highlither, markers, intellisense, font, etc)
''' </summary>
Public Class GeneralCodeManager
    Public Actions As New MyCodeActions
    Private myCodeEditor As CodeEditorForArduino
    Private syntax As New ArduinoSyntax
    Private Shared markers As New MarkersManager
    Private initializeValues As Boolean = True
    Private actualFont As Font
    Private actualZoom As Single

    Public Function getCodeName() As String
        Return myCodeEditor.myCodeFileManager.getFileName()
    End Function

    ''' <summary>
    ''' Change the codeEditor control managed by this instance
    ''' </summary>
    ''' <param name="CodeEditor"></param>
    Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
        Initialize()
        myCodeEditor = CodeEditor
        markers.AssignRef(CodeEditor)
        syntax.AssignRef(myCodeEditor)
        mainAutoCompleteMenu.AssignRef(CodeEditor)
        controlObjectsExplorer.AssignRef(CodeEditor)
        Actions.AssignRef(CodeEditor)
        AddHandler myCodeEditor.ZoomChanged, AddressOf myCodeEditor_ZoomChanged
        UpdateTextStyle()
        UpdateFont()
        CodeEditor.ContextMenuStrip = controlMainToolBar.cmsCodeEditor
    End Sub

    Public Sub ClearStyles()
        syntax.ClearStyles()
    End Sub

    Public Function IsChanged() As Boolean
        Return myCodeEditor.IsChanged
    End Function

    Public Sub AssignLocalRef(CodeEditor As CodeEditorForArduino)
        Initialize()
        myCodeEditor = CodeEditor
        'markers.AssignRef(CodeEditor)
        syntax.AssignRef(myCodeEditor)
        'mainAutoCompleteMenu.AssignRef(CodeEditor)
        UpdateTextStyle()
        UpdateFont()
        'CodeEditor.ContextMenuStrip = MainToolBar.cmsCodeEditor
    End Sub

    Public Sub UpdateEditorCfgs()
        If myCodeEditor IsNot Nothing Then
            UpdateFont()
        End If
    End Sub

    Public Sub UpdateFont()
        Dim fontName As FontFamily = GetFontFamily(Values.TextEditor.fontFamily)
        Dim fontSize As Single = Values.TextEditor.fontSize
        Dim fontStyle As New FontStyle
        Dim font As New Font(fontName, fontSize, fontStyle)
        actualFont = font
        If myCodeEditor IsNot Nothing Then
            myCodeEditor.Font = font
            myCodeEditor.Zoom = Values.TextEditor.zoomFactor
            myCodeEditor.Update()
        End If
    End Sub

    Public Sub UpdateTextStyle()
        If myCodeEditor IsNot Nothing Then
            UpdateSyntaxHighlighter()
            syntax.AssignRef(myCodeEditor)
            PopMenuApplyTheme()
            ToolTipApplyTheme()
        End If
    End Sub

    Private Sub UpdateSyntaxHighlighter()
        Dim colors As String() = Nothing
        Dim styles As FontStyle() = Nothing
        GetCurrentStyle(colors, styles)
        syntax.UpdateStyles(colors, styles)
    End Sub

    Private Shared Sub GetCurrentStyle(ByRef colors() As String, ByRef styles() As FontStyle)
        colors = {Values.CodeColors.TypeNamesColor,
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
        styles = {IDEcfgs.Values.CodeStyles.TypeNamesStyle,
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

    Private Sub ToolTipApplyTheme()
        myCodeEditor.ToolTip.BackColor = Color.FromArgb(IDEcfgs.Values.CodeColors.BackColor)
        myCodeEditor.ToolTip.ForeColor = Color.FromArgb(IDEcfgs.Values.CodeColors.ForeColor)
    End Sub

    Private Sub PopMenuApplyTheme()
        myCodeEditor.myPopMenu.ToolTip.BackColor = Color.FromArgb(IDEcfgs.Values.CodeColors.BackColor)
        myCodeEditor.myPopMenu.ToolTip.ForeColor = Color.FromArgb(IDEcfgs.Values.CodeColors.ForeColor)
        myCodeEditor.myPopMenu.BackColor = Color.FromArgb(IDEcfgs.Values.CodeColors.BackColor)
        myCodeEditor.myPopMenu.ForeColor = Color.FromArgb(IDEcfgs.Values.CodeColors.ForeColor)
    End Sub

    Public Sub SaveSettings()
        If myCodeEditor IsNot Nothing Then
            Values.TextEditor.zoomFactor = myCodeEditor.Zoom
        End If
    End Sub

    'Public Sub SaveCurrentCode()
    '    myCodeEditor.myCodeFileManager.saveFile()
    'End Sub

    Public Function IsCode(file As FileInfo) As Boolean
        Return file.Extension = ".ino" Or file.Extension = ".pde" Or file.Extension = ".cpp" Or file.Extension = ".h"
    End Function

    Public Class MyCodeActions
        Public exportHtml As New ActionExportHtml
        Public goToLine As New GoToLineTool
        Public find As New FindTool
        Public replace As New ReplaceTool
        Public marker As New MarkerTool
        Private myCodeEditor As CodeEditorForArduino

        Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
            myCodeEditor = CodeEditor
            exportHtml.AssignRef(myCodeEditor)
            goToLine.AssignRef(myCodeEditor)
            find.AssignRef(myCodeEditor)
            replace.AssignRef(myCodeEditor)
            marker.AssignRef(myCodeEditor)
        End Sub

        Public Class ActionExportHtml
            Private myCodeEditor As CodeEditorForArduino
            Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
                myCodeEditor = CodeEditor
            End Sub
            Public Sub ShowDialog()
                Dim cultureResx As New CultureManager
                Dim initialPath As String = CurrentProjectInfo.DirectoryPaths.projectDirectory
                Dim saveFile As New SaveFileDialog With {
                    .Filter = cultureResx.translateText("Arquivo") & " HTML|*.html",
                    .InitialDirectory = initialPath,
                    .Title = cultureResx.translateText("Exportar") & " HTML"
                    }
                Dim dialogResult = saveFile.ShowDialog()
                If dialogResult <> DialogResult.Cancel Then
                    ExportToFile(saveFile.FileName)
                End If
            End Sub

            Public Sub ExportToFile(ByVal filePath As String)
                File.WriteAllText(filePath, myCodeEditor.Html)
            End Sub
        End Class

        Public Class GoToLineTool
            Private myCodeEditor As CodeEditorForArduino
            Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
                myCodeEditor = CodeEditor
            End Sub
            Public Sub ShowDialog()
                myCodeEditor.ShowGoToDialog()
            End Sub

            Public Sub Line(line As UInt16)
                Dim l As UInt16 = Math.Min(myCodeEditor.LinesCount - 1, Math.Max(0, line - 1))
                myCodeEditor.Selection = New FastColoredTextBoxNS.Range(myCodeEditor, 0, l, 0, l)
            End Sub

        End Class

        Public Class FindTool
            Private myCodeEditor As CodeEditorForArduino
            Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
                myCodeEditor = CodeEditor
            End Sub
            Public Sub ShowDialog()
                myCodeEditor.ShowFindDialog()
            End Sub
        End Class

        Public Class ReplaceTool
            Private myCodeEditor As CodeEditorForArduino
            Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
                myCodeEditor = CodeEditor
            End Sub
            Public Sub ShowDialog()
                myCodeEditor.ShowReplaceDialog()
            End Sub
        End Class

        Public Class MarkerTool
            Private myCodeEditor As CodeEditorForArduino
            Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
                myCodeEditor = CodeEditor
            End Sub
            Public Sub ClearMarkers()
                markers.clearAll()
            End Sub

            Public Sub ClearMarker(brush As Brush)
                markers.clearBrush(brush)
            End Sub

            Public Sub MarkLine(lin As UInt16)
                If lin <= markers.lastLineNumber Then
                    myCodeEditor.Navigate(lin)
                    CodeManager.Actions.marker.ClearMarker(controlObjectsExplorer.objectExplorerBrush)
                    CodeManager.Actions.marker.MarkLineWithBrush(lin, controlObjectsExplorer.objectExplorerBrush)
                    myCodeEditor.Focus()
                End If
            End Sub

            Public Sub MarkLineWithBrush(lin As UInt16, brush As Brush)
                If lin <= markers.lastLineNumber Then
                    markers.markBackgroundLineWithBrush(lin, brush)
                End If
            End Sub
        End Class

        Public Sub Undo()
            myCodeEditor.Undo()
        End Sub

        Public Sub Redo()
            myCodeEditor.Redo()
        End Sub

        Public Sub Cut()
            myCodeEditor.Cut()
        End Sub

        Public Sub Copy()
            myCodeEditor.Copy()
        End Sub

        Public Sub Paste()
            myCodeEditor.Paste()
        End Sub

        Public Sub Ident()
            myCodeEditor.DoAutoIndent()
        End Sub

        Public Sub Comment()
            myCodeEditor.CommentSelected()
        End Sub

        Public Function GetCodeFilePath() As String
            If myCodeEditor IsNot Nothing Then
                Return myCodeEditor.myCodeFileManager.getFilePath
            Else
                Return "Arduino"
            End If
        End Function

        Public Function GetCodeText() As String
            Return myCodeEditor.Text
        End Function

        Public Sub Navigate(line As UInt16)
            myCodeEditor.Navigate(line)
        End Sub

        Public Sub Save()
            Try
                myCodeEditor.myCodeFileManager.saveFile()
            Catch ex As Exception
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "CodeFileManager", "")
            End Try
        End Sub

        Public Sub SaveAs(path As String)
            Try
                myCodeEditor.myCodeFileManager.saveFileAs(path)
            Catch ex As Exception
                consoleErrors.AddItem(ErrorsManager.Type.msgAdvise, ex.Message, "CodeFileManager", "")
            End Try
        End Sub

        Public Sub IncludeLibrary(libName As String)
            Dim l As UInt16 = myCodeEditor.firstValidLine
            myCodeEditor.addLine(l, vbCrLf & "#include """ & libName & """")
        End Sub

        Public Sub AddSetup(text As String)
            Dim l As UInt16 = myCodeEditor.searchAfterString("void setup()", "}")
            myCodeEditor.addLine(l, text)
        End Sub

        Public Sub AddText(lin As UInt16, text As String)
            myCodeEditor.addLine(lin, text)
        End Sub

        Public Sub AppendText(text As String)
            myCodeEditor.AppendText(text)
        End Sub

        Public Sub CollapseAllFoldingBlocks()
            myCodeEditor.CollapseAllFoldingBlocks()
        End Sub

        Public Sub ExpandAllFoldingBlocks()
            myCodeEditor.ExpandAllFoldingBlocks()
        End Sub

        Public Function SearchLine(text As String)
            Return myCodeEditor.searchLine(text)
        End Function

        Public Function SearchAfterLine(s1 As String, s2 As String)
            Return myCodeEditor.searchAfterString(s1, s2)
        End Function

    End Class

    Private Sub Initialize()
        If initializeValues Then
            UpdateFont()
            initializeValues = False
        End If
    End Sub

    Private Sub myCodeEditor_ZoomChanged()
        Values.TextEditor.zoomFactor = myCodeEditor.Zoom
    End Sub

    Public Sub SyntaxHighlighter()
        myCodeEditor.UpdateSyntaxData()
        syntax.ArduinoSyntaxHighlight(myCodeEditor.Range)
        'syntax.ArduinoSyntaxHighlight(myCodeEditor.VisibleRange)
    End Sub

End Class
