Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS

Public Class ArduinoSyntax

    'Dim knownMethodsList As List(Of String)
    Public Shared declaredInstances As String = ""
    Public Shared declaredConstants As String = ""
    Public Shared declaredClassTypes As String = ""
    Public Shared instanceMethods As String = ""
    Public Shared declaredMethods As String = ""
    Public Shared declaredVariables As String = ""

    Dim TypeNamesStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim CppCommonStyle As TextStyle = New TextStyle(Brushes.DarkCyan, Nothing, FontStyle.Regular)
    Dim ArduinoKeywordsStyle As TextStyle = New TextStyle(Brushes.DarkCyan, Nothing, FontStyle.Regular)
    Dim DataTypes As TextStyle = New TextStyle(Brushes.CadetBlue, Nothing, FontStyle.Regular)
    Dim CompilerKeys As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
    Dim NumbersStyle As TextStyle = New TextStyle(Brushes.Black, Nothing, FontStyle.Regular)
    Dim CommentsStyle As TextStyle = New TextStyle(Brushes.LightGray, Nothing, FontStyle.Italic)
    Dim ConstantsNamesStyle As TextStyle = New TextStyle(Brushes.Purple, Nothing, FontStyle.Regular)
    Dim StringStyle As TextStyle = New TextStyle(Brushes.Brown, Nothing, FontStyle.Italic)
    Dim declaredInstancesStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim declaredClassTypesStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim instanceMethodsStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim declaredMethodsStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim SameWordsStyle As MarkerStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))
    Dim myFCTB As CodeEditorForArduino

    Dim checkAll As Boolean = False

    Public Sub AssignRef(ByRef fctb As CodeEditorForArduino)
        If myFCTB IsNot Nothing Then
            RemoveHandler myFCTB.AutoIndentNeeded, AddressOf myFCTB_AutoIndentNeeded
            RemoveHandler myFCTB.SelectionChangedDelayed, AddressOf myFCTB_SelectionChangedDelayed
            RemoveHandler myFCTB.TextChanged, AddressOf myFCTB_TextChanged
            If myFCTB.HighlightingRangeType = HighlightingRangeType.VisibleRange Then
                RemoveHandler myFCTB.Pasting, AddressOf myFCTB_Pasting
            End If
        End If
        myFCTB = fctb
        AddHandler myFCTB.AutoIndentNeeded, AddressOf myFCTB_AutoIndentNeeded
        AddHandler myFCTB.SelectionChangedDelayed, AddressOf myFCTB_SelectionChangedDelayed
        AddHandler myFCTB.TextChanged, AddressOf myFCTB_TextChanged
        AddHandler myFCTB.Pasting, AddressOf myFCTB_Pasting
        myFCTB.DelayedEventsInterval = 500
        myFCTB.DelayedTextChangedInterval = 400
        myFCTB.ShowFoldingLines = True
        myFCTB.AutoCompleteBrackets = True
        myFCTB.LeftPadding = 20
        myFCTB.LeftBracket = "("
        myFCTB.RightBracket = ")"
        myFCTB.LeftBracket2 = "{"
        myFCTB.RightBracket2 = "}"
        myFCTB.BracketsStyle2 = myFCTB.BracketsStyle
        myFCTB.HighlightingRangeType = HighlightingRangeType.VisibleRange
        ArduinoSyntaxHighlight(myFCTB.Range)
    End Sub

    Public Sub UpdateStyles(brushes() As String, styles() As FontStyle)
        'If IsNumeric(brushes(0)) Then
        UpdateColorsFromARGB(brushes)
            'Else
            '    UpdateColorsFromNames(brushes)
            'End If
            TypeNamesStyle.FontStyle = styles(0)
        CppCommonStyle.FontStyle = styles(1)
        ArduinoKeywordsStyle.FontStyle = styles(2)
        DataTypes.FontStyle = styles(3)
        CompilerKeys.FontStyle = styles(4)
        NumbersStyle.FontStyle = styles(5)
        CommentsStyle.FontStyle = styles(6)
        ConstantsNamesStyle.FontStyle = styles(7)
        StringStyle.FontStyle = styles(8)
        'SameWordsStyle.FontStyle = stykes(9)
        declaredInstancesStyle.FontStyle = styles(10)
        declaredClassTypesStyle.FontStyle = styles(11)
        instanceMethodsStyle.FontStyle = styles(12)
        declaredMethodsStyle.FontStyle = styles(13)
    End Sub

    Private Sub UpdateColorsFromARGB(ByRef brushes() As String)
        For i = 0 To brushes.Count - 1
            If brushes(i) = "Erro" Then
                brushes(i) = "0"
            End If
        Next
        TypeNamesStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(0)))
        CppCommonStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(1)))
        ArduinoKeywordsStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(2)))
        DataTypes.ForeBrush = New SolidBrush(Color.FromArgb(brushes(3)))
        CompilerKeys.ForeBrush = New SolidBrush(Color.FromArgb(brushes(4)))
        NumbersStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(5)))
        CommentsStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(6)))
        ConstantsNamesStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(7)))
        StringStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(8)))
        SameWordsStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.FromArgb(brushes(9)))))
        declaredInstancesStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(10)))
        declaredClassTypesStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(11)))
        instanceMethodsStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(12)))
        declaredMethodsStyle.ForeBrush = New SolidBrush(Color.FromArgb(brushes(13)))
        If myFCTB IsNot Nothing Then
            myFCTB.ForeColor = Color.FromArgb(brushes(14))
            myFCTB.BackColor = Color.FromArgb(brushes(15))
            myFCTB.CaretColor = myFCTB.ForeColor
        End If
        myFCTB.LineNumberColor = Color.FromArgb(brushes(17))
        myFCTB.IndentBackColor = Color.FromArgb(brushes(18))
    End Sub

    Private Sub myFCTB_TextChanged(sender As Object, ByVal e As TextChangedEventArgs)
        'clear style of changed range
        Dim Range As Range
        Select Case myFCTB.HighlightingRangeType
            Case HighlightingRangeType.ChangedRange
                Range = e.ChangedRange
            Case HighlightingRangeType.VisibleRange
                Range = myFCTB.VisibleRange
            Case Else
                Range = myFCTB.Range
        End Select
        If checkAll Then
            ArduinoSyntaxHighlight(myFCTB.Range)
            Static Dim cont = 0
            cont += 1
            If cont = 2 Then
                checkAll = False
                cont = 0
            End If
        Else
            ArduinoSyntaxHighlight(Range)

        End If
    End Sub

    Private Sub myFCTB_Pasting(sender As Object, ByVal e As TextChangingEventArgs)
        checkAll = True
    End Sub

    ''' <summary>
    ''' Realiza a edição das cores do texto, de acordo com a síntaxe da linguagem
    ''' </summary>
    ''' <param name="Range">Intervalo do texto onde será feita a verificação</param>
    Public Sub ArduinoSyntaxHighlight(Range As Range)
        Try
            UpdateStyles(Range)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateStyles(Range As Range)
        myFCTB.VisibleRange.ClearStyle(TypeNamesStyle, CppCommonStyle, ArduinoKeywordsStyle, DataTypes, CompilerKeys, NumbersStyle, CommentsStyle, ConstantsNamesStyle, StringStyle,
                                       declaredInstancesStyle, declaredClassTypesStyle, instanceMethodsStyle, declaredMethodsStyle)
        myFCTB.Range.ClearStyle(CommentsStyle)
        myFCTB.Range.SetStyle(CommentsStyle, "//.*$", RegexOptions.Multiline)
        myFCTB.Range.SetStyle(CommentsStyle, "(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline)
        myFCTB.Range.SetStyle(CommentsStyle, "(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
        Range.SetStyle(StringStyle, """""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'")
        Range.SetStyle(StringStyle, """""|@""""|<>|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|<.*?[^\\]>")
        Range.SetStyle(NumbersStyle, "\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b")
        Range.SetStyle(CompilerKeys, "^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline)
        Range.SetStyle(ConstantsNamesStyle, "\b(HIGH|LOW|INPUT|OUTPUT|INPUT_PULLUP|LED_BUILTIN|NUM_ANALOG_INPUTS|NUM_DIGITAL_PINS|true|false|)\b")
        Range.SetStyle(ArduinoKeywordsStyle, "\b(loop|setup|digitalRead|digitalWrite|pinMode|analogRead|analogReference|analogWrite|analogReadResolution|analogWriteResolution|noTone|pulseIn|pulseInLong|shiftIn|shiftOut|tone|delay|delayMicroseconds|micros|millis|abs|constrain|map|max|min|pow|sq|sqrt|cos|sin|tan|isAlpha|isAlphaNumeric|isAscii|isControl|isDigit|isGraph|isHexadecimalDigit|isLowerCase|isPrintable|isPunct|isSpace|isUpperCase|isWhitespace|random|randomSeed|bit|bitClear|bitRead|bitSet|bitWrite|highByte|lowByte|attachInterrupt|detachInterrupt|Interruptsinterrupts|noInterrupts)\b")
        Range.SetStyle(TypeNamesStyle, "\b(void|unsigned|array|bool|boolean|typedef|byte|char|double|float|int|long|short|size_t|int8_t|int16_t|int32_t|uint8_t|uint16_t|uint32_t|long|word|const|scope|static|volatile|extern)\b")
        Range.SetStyle(TypeNamesStyle, "\b(namespace|class|struct|enum|public|private|PROGMEM|sizeof|String|void)\b")
        Range.SetStyle(CppCommonStyle, "\b(break|continue|do|while|else|for|goto|if|else|return|switch|case|while|default)\b")
        Range.SetStyle(CompilerKeys, "\b(defined)\b|#ifndef\b|#endif\b|#define\b|#if\b|#elif\b|#include\b|#ifdef\b|#else|#ifdef\b")
        Range.SetStyle(declaredInstancesStyle, "\b(CommunicationStream|USB|Keyboard|Mouse|Serial|Serial1|Serial2|Serial3)\b")
        Range.SetStyle(instanceMethodsStyle, "\b(available|availableForWrite|begin|end|find|findUntil|flush|parseFloat|parseInt|peek|print|println|read|readBytes|readBytesUntil|readString|readStringUntil|setTimeout|write|serialEvent|)\b")
        'clear foldings
        Range.ClearFoldingMarkers()
        'set foldings
        Range.SetFoldingMarkers("{", "}")
        Range.SetFoldingMarkers("//#region\b", "//#endregion\b")
        Range.SetFoldingMarkers("#ifndef\b", "#endif\b")
        Range.SetFoldingMarkers("#ifdef\b", "#endif\b")
        Range.SetFoldingMarkers("#if\b", "#elif\b")
        Range.SetFoldingMarkers("#if\b", "#endif\b")
        Range.SetFoldingMarkers("/\*", "\*/")
        UpdateDinamicStyles(Range)
    End Sub

    Public Sub UpdateDinamicStyles(Range As Range)
        If New Pen(DataTypes.ForeBrush).Color <> myFCTB.ForeColor Then
            Range.SetStyle(DataTypes, "\b(" & declaredVariables & ")\b")
        End If
        If New Pen(declaredClassTypesStyle.ForeBrush).Color <> myFCTB.ForeColor Then
            Range.SetStyle(declaredClassTypesStyle, "\b(" & declaredClassTypes & ")\b")
        End If
        If New Pen(ConstantsNamesStyle.ForeBrush).Color <> myFCTB.ForeColor Then
            Range.SetStyle(ConstantsNamesStyle, "\b(" & declaredConstants & ")\b")
        End If
        If New Pen(declaredMethodsStyle.ForeBrush).Color <> myFCTB.ForeColor Then
            Range.SetStyle(declaredMethodsStyle, "\b(" & declaredMethods & ")\b")
        End If
        If New Pen(instanceMethodsStyle.ForeBrush).Color <> myFCTB.ForeColor Then
            Range.SetStyle(instanceMethodsStyle, "\b(" & instanceMethods & ")\b")
        End If
        If New Pen(declaredInstancesStyle.ForeBrush).Color <> myFCTB.ForeColor Then
            Range.SetStyle(declaredInstancesStyle, "\b(" & declaredInstances & ")\b")
        End If
    End Sub

    Public Sub ClearStyles()
        myFCTB.VisibleRange.ClearStyle(TypeNamesStyle, CppCommonStyle, ArduinoKeywordsStyle, DataTypes, CompilerKeys, NumbersStyle, CommentsStyle, ConstantsNamesStyle, StringStyle,
                                       declaredInstancesStyle, declaredClassTypesStyle, instanceMethodsStyle, declaredMethodsStyle, SameWordsStyle)
    End Sub

    Private Sub myFCTB_SelectionChangedDelayed(ByVal sender As Object, ByVal e As EventArgs) '(ByVal sender As Object, ByVal e As EventArgs) Handles myFTCB.SelectionChangedDelayed
        myFCTB.VisibleRange.ClearStyle(SameWordsStyle)
        If Not myFCTB.Selection.IsEmpty Then Return
        Dim fragment = myFCTB.Selection.GetFragment("\w")
        Dim text As String = fragment.Text
        If text.Length = 0 Then Return
        Dim ranges = myFCTB.VisibleRange.GetRanges("\b" & text & "\b").ToArray()
        If ranges.Length > 1 Then
            For Each r In ranges
                Try
                    r.SetStyle(SameWordsStyle)
                Catch ex As Exception
                    myFCTB.VisibleRange.ClearStyle(SameWordsStyle)
                    'MessageBox.Show(ex.Message)
                End Try
            Next
        End If
    End Sub

    Private Sub myFCTB_AutoIndentNeeded(ByVal sendar As Object, ByVal args As AutoIndentEventArgs) ' Handles fctb.AutoIndentNeeded
        If Regex.IsMatch(args.LineText, "^[^""']*\{.*\}[^""']*$") Then Return

        If Regex.IsMatch(args.LineText, "^[^""']*\{") Then
            args.ShiftNextLines = args.TabLength
            Return
        End If

        If Regex.IsMatch(args.LineText, "}[^""']*$") Then
            args.Shift = -args.TabLength
            args.ShiftNextLines = -args.TabLength
            Return
        End If

        If Regex.IsMatch(args.LineText, "^\s*\w+\s*:\s*($|//)") AndAlso Not Regex.IsMatch(args.LineText, "^\s*default\s*:") Then
            args.Shift = -args.TabLength
            Return
        End If

        If Regex.IsMatch(args.LineText, "^\s*(case|default)\b.*:\s*($|//)") Then
            args.Shift = -args.TabLength / 2
            Return
        End If

        If Regex.IsMatch(args.PrevLineText, "^\s*(if|for|while|[\}\s]*else)\b[^{]*$") Then

            If Not Regex.IsMatch(args.PrevLineText, "(;\s*$)|(;\s*//)") Then
                args.Shift = args.TabLength
                Return
            End If
        End If
    End Sub

    'Dim keywordsstyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    'Dim arduinokeywords As TextStyle = New TextStyle(Brushes.DarkCyan, Nothing, FontStyle.Regular)
    'Dim classnames As TextStyle = New TextStyle(Brushes.CadetBlue, Nothing, FontStyle.Regular)
    'Dim compilerkeys As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
    'Dim numbersstyle As TextStyle = New TextStyle(Brushes.Black, Nothing, FontStyle.Regular)
    'Dim commentsstyle As TextStyle = New TextStyle(Brushes.LightGray, Nothing, FontStyle.Italic)
    'Dim constantsnamesstyle As TextStyle = New TextStyle(Brushes.Purple, Nothing, FontStyle.Regular)
    'Dim stringstyle As TextStyle = New TextStyle(Brushes.Brown, Nothing, FontStyle.Italic)
    'Dim samewordsstyle As MarkerStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))
End Class
