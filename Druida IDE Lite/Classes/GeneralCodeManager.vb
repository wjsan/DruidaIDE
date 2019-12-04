Imports Code_Editor_For_Arduino
Imports Druida_IDE_Lite.IDEcfgs

''' <summary>
''' Responsible for assign and manage all features Of the code editor (syntax highlither, markers, intellisense, font, etc)
''' </summary>
Public Class GeneralCodeManager
    Dim myCodeEditor As CodeEditorForArduino
    Dim syntax As New ArduinoSyntax
    Dim markers As New MarkersManager
    Dim initializeValues As Boolean = True
    Dim actualFont As Font
    Dim actualZoom As Single

    ''' <summary>
    ''' Change the codeEditor control managed by this instance
    ''' </summary>
    ''' <param name="CodeEditor"></param>
    Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
        Initialize()
        myCodeEditor = CodeEditor
        syntax.AssignRef(CodeEditor)
        markers.AssignRef(CodeEditor)
        AddHandler myCodeEditor.ZoomChanged, AddressOf myCodeEditor_ZoomChanged
        myCodeEditor.Zoom = actualZoom
    End Sub

    Private Sub Initialize()
        If initializeValues Then
            UpdateFont()
            initializeValues = False
        End If
    End Sub

    Public Sub UpdateEditorCfgs()
        If myCodeEditor IsNot Nothing Then
            UpdateFont()
        End If
    End Sub

    Public Sub UpdateFont()
        Dim fontName As FontFamily = GetFontFamily(GetValue(Names.TextEditor.fontFamily))
        Dim fontSize As Single = GetValue(Names.TextEditor.fontSize)
        Dim fontStyle As New FontStyle
        Dim font As New Font(fontName, fontSize, fontStyle)
        actualFont = font
        actualZoom = GetValue(Names.TextEditor.zoomFactor)
    End Sub

    Private Sub myCodeEditor_ZoomChanged()
        'SetValue(Names.TextEditor.zoomFactor, myCodeEditor.Zoom)
        actualZoom = myCodeEditor.Zoom
    End Sub
End Class
