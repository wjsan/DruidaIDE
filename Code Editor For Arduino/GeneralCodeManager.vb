
''' <summary>
''' Responsible for managing all the features of the code editor (syntax highlither, markers, intellisense, etc)
''' </summary>
Public Class GeneralCodeManager
    Dim syntax As New ArduinoSyntax
    Dim markers As New MarkersManager

    Public Sub AssignRef(CodeEditor As CodeEditorForArduino)
        syntax.AssignRef(CodeEditor)
        markers.AssignRef(CodeEditor)
    End Sub
End Class
