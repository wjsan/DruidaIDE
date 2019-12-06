Imports AutocompleteMenuNS
Imports System.Text.RegularExpressions

Public Class CodeEditor
    Public directory As String = applicationDirectory & "\CustomSourceCode\" & "Main"
    Public fileName As String = directory & "\" & "Main" & ".ino"
    Dim bkp As String

    Public listaFunctionsNames As New List(Of String)
    Public listaFunctionsLines As New List(Of UInt16)
    Private escopoList As New List(Of String)
    Private escopoLines As New List(Of UInt16)
    Private varListByEscopo As New List(Of List(Of String))
    Private varLinesByEscopo As New List(Of List(Of UInt16))
    Private caretIsInEscopo As UInt16 = 0
    Private startProcessing As Boolean = True
    Private isProcessing As Boolean = False

    Private Sub CodeEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBoxCode.Settings.Keywords.Add("if")
        TextBoxCode.Settings.Keywords.Add("then")
        TextBoxCode.Settings.Keywords.Add("else")
        TextBoxCode.Settings.Keywords.Add("elseif")
        TextBoxCode.Settings.Keywords.Add("end")
        TextBoxCode.Settings.Keywords.Add("void")
        TextBoxCode.Settings.Keywords.Add("pinMode")
        TextBoxCode.Settings.Keywords.Add("HIGH")
        TextBoxCode.Settings.Keywords.Add("LOW")
        TextBoxCode.Settings.Keywords.Add("INPUT")
        TextBoxCode.Settings.Keywords.Add("OUTPUT")
        TextBoxCode.Settings.Keywords.Add("INPUT_PULLUP")
        TextBoxCode.Settings.Keywords.Add("digitalWrite")
        TextBoxCode.Settings.Keywords.Add("digitalRead")
        TextBoxCode.Settings.Keywords.Add("Serial")
        TextBoxCode.Settings.Keywords.Add("char")
        TextBoxCode.Settings.Keywords.Add("String")
        TextBoxCode.Settings.Keywords.Add("begin")
        TextBoxCode.Settings.Keywords.Add("int")
        TextBoxCode.Settings.Keywords.Add("long")
        TextBoxCode.Settings.Keywords.Add("float")
        TextBoxCode.Settings.Keywords.Add("double")
        TextBoxCode.Settings.Keywords.Add("bool")
        TextBoxCode.Settings.Keywords.Add("BqBus")
        'TextBoxCode.Settings.Keywords.Add("Comunicacao")
        TextBoxCode.Settings.Keywords.Add("for")
        TextBoxCode.Settings.Keywords.Add("while")
        TextBoxCode.Settings.Keywords.Add("and")
        TextBoxCode.Settings.Keywords.Add("or")
        TextBoxCode.Settings.Keywords.Add("delay")
        TextBoxCode.Settings.Keywords.Add("millis")
        TextBoxCode.Settings.Keywords.Add("class")
        TextBoxCode.Settings.Keywords.Add("public")
        TextBoxCode.Settings.Keywords.Add("private")
        TextBoxCode.Settings.Comment = "//"
        TextBoxCode.Settings.KeywordColor = Color.Blue
        TextBoxCode.Settings.CommentColor = Color.Green
        TextBoxCode.Settings.StringColor = Color.DarkGoldenrod
        TextBoxCode.Settings.IntegerColor = Color.Red
        TextBoxCode.Settings.EnableStrings = True
        TextBoxCode.Settings.EnableIntegers = False
        TextBoxCode.CompileKeywords()
    End Sub

    Public Sub LoadFile()
        If (System.IO.File.Exists(fileName)) Then
            TextBoxCode.Text = System.IO.File.ReadAllText(fileName)
            bkp = System.IO.File.ReadAllText(fileName)
            TextBoxCode.Enabled = True
        Else
            NewCode()
        End If
        CheckSintax()
    End Sub

    Private Sub RichTextBoxLinhas_Enter(sender As Object, e As EventArgs) Handles RichTextBoxLinhas.Enter
        TextBoxCode.SelectionTabs = {20, 40, 60, 80}
    End Sub

    Public Sub saveFile()
        System.IO.File.WriteAllText(fileName, TextBoxCode.Text)
        bkp = TextBoxCode.Text
    End Sub

    Public Sub NewCode()
        Dim path1 As String = My.Application.Info.DirectoryPath & "\ArduinoSuiteCustom"
        My.Computer.FileSystem.CreateDirectory(directory)
        My.Computer.FileSystem.CopyDirectory(path1, directory)
        My.Computer.FileSystem.RenameFile(directory & "\ArduinoSuiteCustom.ino", "Main.ino")
        LoadFile()
        CheckHeader()
    End Sub

    Private Sub CheckHeader()
        If Not (TextBoxCode.Lines(0).Contains("*")) Then
            addLine(0, getHeader())
        End If
    End Sub

    Public Function getHeader()
        Dim header As String = ""
        header &= "//*************************************************************************************************" & vbLf
        header &= "//   Projeto" & vbTab & ": " & AppName & vbLf
        header &= "//   Arquivo" & vbTab & ": " & fileName.Split("\")(fileName.Split("\").Length - 1) & vbLf
        header &= "//   Descrição" & vbTab & ": " & NovoSkecth.TextBoxDescicao.Text & vbLf
        header &= "//   Data" & vbTab & vbTab & ": " & Date.Today & vbLf
        header &= "//**************************************************************************************************" & vbLf
        Return header
    End Function

    Private Sub CompareFile()
        ' Try
        If (System.IO.File.Exists(fileName)) Then
                If (bkp <> System.IO.File.ReadAllText(fileName)) Then
                    bkp = System.IO.File.ReadAllText(fileName)
                    If (MessageBox.Show("Foram detectadas alterações externas no código fonte. Deseja carregá-las?", "Carregar Alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        LoadFile()
                    End If
                End If
            End If
        'Catch ex As Exception

        'End Try
    End Sub

    Public Function searchLine(ByVal text As String)
        Dim lines As New List(Of String)
        Dim cont As Integer = 0
        Dim encontrado As Boolean = False
        For Each line In TextBoxCode.Lines
            If (line.Contains(text)) Then
                encontrado = True
                Return (cont)
                Exit For
            End If
            cont += 1
        Next
        If (Not (encontrado)) Then
            Return (-1)
        End If
    End Function

    Public Sub addLine(ByVal pos As UInt16, ByVal text As String)
        If (pos >= 0) Then
            Dim lines As New List(Of String)
            For Each line As String In TextBoxCode.Lines
                lines.Add(line)
            Next
            lines.Insert(pos, text)
            TextBoxCode.Clear()
            For Each line In lines
                TextBoxCode.AppendText(line & vbLf)
            Next
        End If
    End Sub

    Public Function searchAfterLine(ByVal s1 As String, ByVal s2 As String)
        Dim lines As New List(Of String)
        Dim cont As Integer = 0
        Dim encontrado As Boolean = False
        For Each line In TextBoxCode.Lines
            If (encontrado) Then
                If (line = s2) Then
                    Return (cont)
                End If
            End If
            If (line.Contains(s1) And Not (encontrado)) Then
                encontrado = True
            End If
            cont += 1
        Next
        If (Not (encontrado)) Then
            Return (-1)
        End If
    End Function

    Public Sub SelectLine(ByVal line As UInt16, ByRef rText As RichTextBox)
        Dim cont As UInt16 = 0
        Dim cLine As UInt16 = 0
        For Each lin As String In rText.Lines
            If (cLine = line) Then
                Exit For
            End If
            For i = 0 To lin.Length
                cont += 1
            Next
            cLine += 1
        Next
        Dim sStart As Integer = cont
        Dim sEnd As Integer = rText.Lines(line).Length
        rText.Focus()
        rText.Select(sStart, sEnd)
    End Sub

    Private Sub TimerCheckCode_Tick(sender As Object, e As EventArgs) Handles TimerCheckCode.Tick
        Programação.numRegs.Text = "Regs:" & numMaxRegs
        Programação.GerenciaCodigo.AtualizaArvore()
        PreencheEscopoList()
        CompareFile()
        If Not BackgroundWorkerCheckLines.IsBusy Then
            CheckNewLines()
            listaFunctionsNames.Clear()
            listaFunctionsLines.Clear()
            varListByEscopo.Clear()
            varLinesByEscopo.Clear()
            escopoList.Clear()

            BackgroundWorkerCheckLines.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorkerCheckLines_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerCheckLines.DoWork
        Dim isGlobal As Boolean = True
        Dim index As UInt16 = 0
        Static Dim globallLines As New List(Of UInt16)
        Dim text() As String
        Static Dim linAnt As UInt16 = 0
        Dim lineNum As UInt16 = 0
        Dim isInLine As Boolean = False
        Dim localFunctionsNames As New List(Of String)
        Dim localFunctionsLines As New List(Of UInt16)
        Dim localListByEscopo As New List(Of List(Of String))
        Dim localLinesByEscopo As New List(Of List(Of UInt16))
        Dim localEscopoList As New List(Of String)
        Dim localEscopoLines As New List(Of UInt16)
        Dim isDropped As Boolean = False
        TextBoxCode.Invoke(Sub() text = TextBoxCode.Lines)
        localEscopoList.Add("Global")
        localEscopoLines.Add(0)
        localListByEscopo.Add(New List(Of String))
        localLinesByEscopo.Add(New List(Of UInt16))
        For i = 0 To text.Length - 1
            Dim line As String = text(i)
            VerificaNumRegs(line)
            If IsFunction(line) Then
                localFunctionsNames.Add(line)
                listaFunctionsLines.Add(i)
                If isGlobal Then
                    localEscopoList.Add(line)
                    localEscopoLines.Add(i)
                    localListByEscopo.Add(New List(Of String))
                    localLinesByEscopo.Add(New List(Of UInt16))
                End If
                index = localFunctionsNames.Count
                isGlobal = False
            End If
            If IsVar(line) Then
                localListByEscopo.Item(index).Add(line)
                localLinesByEscopo.Item(index).Add(i)
            End If
            If line = "}" Or line = "};" Then isGlobal = True
            If isGlobal Then
                If Not (globallLines.Contains(i)) Then
                    globallLines.Add(i)
                End If
                index = 0
            Else
                If (globallLines.Contains(i)) Then
                    globallLines.Remove(i)
                End If
            End If
            TextBoxCode.Invoke(Sub() lineNum = TextBoxCode.GetLineFromCharIndex(TextBoxCode.GetFirstCharIndexOfCurrentLine()))
            isInLine = lineNum = i
            If isInLine And lineNum <> linAnt Then
                If globallLines.Contains(i) Then
                    caretIsInEscopo = 0
                Else
                    caretIsInEscopo = localEscopoList.Count - 1
                End If
            End If
        Next
        listaFunctionsNames = localFunctionsNames
        varListByEscopo = localListByEscopo
        varLinesByEscopo = localLinesByEscopo
        escopoList = localEscopoList
        escopoLines = localEscopoLines
        ComboIconEscopo.Invoke(Sub() isDropped = ComboIconEscopo.DroppedDown)
        If lineNum <> linAnt And Not (isDropped) Then
            Dim t As String = ""
            TextBoxCode.Invoke(Sub() t = TextBoxCode.Lines(lineNum))
            If globallLines.Contains(lineNum) Then
                ComboIconEscopo.Invoke(Sub() SelectEscopo())
                ComboIconObjects.Invoke(Sub() SelectVar(t))
            Else
                ComboIconEscopo.Invoke(Sub() SelectEscopo())
                ComboIconObjects.Invoke(Sub() SelectVar(t))
            End If
        End If
        linAnt = lineNum
    End Sub

    Private Sub SelectEscopo()
        salto = True
        If ComboIconEscopo.SelectedIndex <> caretIsInEscopo Then
            ComboIconEscopo.SelectedIndex = caretIsInEscopo
        Else
            salto = False
        End If
    End Sub

    Private Sub SelectVar(ByVal text As String)
        salto = True
        For i = 0 To ComboIconObjects.Items.Count - 1
            Dim item = ComboIconObjects.Items(i)
            If text.Split(" ").Contains(item.text.Split(" ")(0)) And text.Split(" ").Contains(item.text.Split(" ")(1)) Then
                ComboIconObjects.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub CheckNewLines()
        Static Dim qtdLines As UInt16 = TextBoxCode.Lines.Count
        If (TextBoxCode.Lines.Count > qtdLines + 2) Then
            CheckSintax()
        End If
        qtdLines = TextBoxCode.Lines.Count
    End Sub

    Private Sub PreencheEscopoList()
        For i = 0 To escopoList.Count - 1
            If (ComboIconEscopo.Items.Count < i + 1) Then
                EscopoAddItem(escopoList(i))
            Else
                ComboIconEscopo.Items(i).Text = escopoList(i)
                If ComboIconEscopo.Items(i).Text = "Global" Then
                    ComboIconEscopo.Items(i).ImageIndex = 0
                ElseIf ComboIconEscopo.Items(i).Text.Contains("class ") Or ComboIconEscopo.Items(i).Text.Contains("struct ") Then
                    ComboIconEscopo.Items(i).ImageIndex = 1
                Else
                    ComboIconEscopo.Items(i).ImageIndex = 2
                End If
            End If
        Next
        While ComboIconEscopo.Items.Count > escopoList.Count
            ComboIconEscopo.Items.RemoveAt(ComboIconEscopo.Items.Count - 1)
        End While
    End Sub

    Private Sub EscopoAddItem(ByVal nome As String)
        If nome = "Global" Then
            ComboIconEscopo.Items.Add(New ComboBoxIconItem(nome, 0))
        ElseIf nome.Contains("class ") Or nome.Contains("struct ") Then
            ComboIconEscopo.Items.Add(New ComboBoxIconItem(nome, 1))
        Else
            ComboIconEscopo.Items.Add(New ComboBoxIconItem(nome, 2))
        End If
    End Sub

    Private Function IsFunction(ByVal text As String)
        Dim varTypes() As String = {"void", "int", "float", "double", "bool", "long", "char", "String", "byte", "word", "array", "short", "boolean"}
        Dim varInLine As Boolean = False
        Dim open As Boolean = False
        Dim close As Boolean = False
        For Each item In varTypes
            If text.Contains(item & " ") Or text.Contains("::") Then
                varInLine = True
                Exit For
            End If
        Next
        For Each letra In text
            If letra = "(" Then open = True
            If letra = ")" Then close = True
            If letra = "=" Then Exit For
            If letra = "/" Then Exit For
        Next
        If text.Contains("class ") Or text.Contains("struct ") Then Return True
        Return (varInLine And open And close)
    End Function

    Private Function IsVar(ByVal texto As String)
        Dim varTypes() As String = {"int", "float", "double", "bool", "long", "char", "String", "byte", "word", "array", "short", "boolean", "#define"}
        Dim varInLine As Boolean = False
        For Each item In varTypes
            If texto.Contains(item & " ") Then
                varInLine = True
                Exit For
            End If
        Next
        For Each letra In Text
            If letra = "(" Then Return False
            If letra = ")" Then Return False
            If letra = "/" Then Exit For
            If letra = "=" Then Exit For
        Next
        Return (varInLine)
    End Function

    Private Sub VerificaNumRegs(ByVal data As String)
        Dim lineInf() As String = data.Split(" ")
        If (lineInf.Count >= 2) Then
            If (lineInf(1) = "numRegs") Then
                If (lineInf(2) <> "") Then
                    numMaxRegs = lineInf(2)

                Else
                    numMaxRegs = 0
                End If
            End If
        End If
    End Sub

    Public Sub WhiteBack()
        TextBoxCode.HideSelection = True
        TextBoxCode.SelectAll()
        TextBoxCode.SelectionBackColor = TextBoxCode.BackColor
        TextBoxCode.DeselectAll()
        TextBoxCode.HideSelection = False
        AtualizaNumList()
    End Sub

    'Atualização dos numeros das linhas

    Private Sub RichTextBoxLinhas_GotFocus(sender As Object, e As EventArgs) Handles RichTextBoxLinhas.GotFocus
        TextBoxCode.Focus()
    End Sub

    Public Sub AtualizaNumList()
        Dim cont As Int16 = 0
        Dim linhas As String = ""
        Dim cIndex As Integer = TextBoxCode.GetCharIndexFromPosition(New Point(0, 0))
        For i = TextBoxCode.GetLineFromCharIndex(cIndex) + 1 To TextBoxCode.Lines.Count
            linhas &= i & vbCrLf
        Next
        RichTextBoxLinhas.SelectionAlignment = HorizontalAlignment.Right
        RichTextBoxLinhas.Text = linhas
    End Sub

    Private Sub r_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.Resize
        AtualizaNumList()
    End Sub

    Private Sub r_KeyDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.KeyUp
        AtualizaNumList()
    End Sub

    Private Sub r_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxCode.VScroll
        AtualizaNumList()
    End Sub

    'Ajusta o tamanho das linhas de acordo com o tamanho do texto

    Private Sub TextBoxCode_MouseMove(sender As Object, e As MouseEventArgs) Handles TextBoxCode.MouseWheel, TextBoxCode.MouseMove
        RichTextBoxLinhas.ZoomFactor = TextBoxCode.ZoomFactor
    End Sub

    Private Sub RichTextBoxLinhas_MouseWheel(sender As Object, e As MouseEventArgs) Handles RichTextBoxLinhas.MouseWheel, RichTextBoxLinhas.MouseMove
        TextBoxCode.ZoomFactor = RichTextBoxLinhas.ZoomFactor
    End Sub

    'Obtém a posição do cursor no texto

    Private Sub TextBoxCode_SelectionChanged(sender As Object, e As EventArgs) Handles TextBoxCode.SelectionChanged
        Programação.ToolStripStatusLabelLin.Text = "Lin:" & GetLine() + 1
        Programação.ToolStripStatusLabelCol.Text = "Col:" & GetCol() + 1
        'SelectEscopo()
        'SelectVar()
    End Sub

    Public Function GetLine()
        Return (TextBoxCode.GetLineFromCharIndex(TextBoxCode.GetFirstCharIndexOfCurrentLine()))
    End Function

    Public Function GetCol()
        Return (TextBoxCode.SelectionStart - TextBoxCode.GetFirstCharIndexOfCurrentLine())
    End Function

    Dim salto As Boolean = False



    'Formatção da identação

    Private Sub TextBoxCode_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCode.KeyDown
        If (TextBoxCode.Lines.Count > 2) Then
            VerificaIdentacao()
        End If
    End Sub

    Private Sub TextBoxCode_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (TextBoxCode.Lines.Count > 2) Then
                RealizaIdentacao()
            End If
        Else
            numLines = TextBoxCode.Lines.Count
        End If
    End Sub

    Dim tab As String = ""
    Dim numLines As Int16 = 0

    Public Sub VerificaIdentacao()
        tab = ""
        For Each c As Char In TextBoxCode.Lines(GetLine())
            If (c = vbTab Or c = "{" Or c = ":") Then
                tab &= vbTab
            ElseIf (c <> "}") Then
                'Exit For
            End If
        Next
    End Sub

    Public Sub VerificaIgnorandoColchete()
        tab = ""
        For Each c As Char In TextBoxCode.Lines(GetLine())
            If (c = vbTab Or c = "{") Then
                tab &= vbTab
            ElseIf (c <> "}") Then
                Exit For
            End If
        Next
        If (GetLine() < TextBoxCode.Lines.Count - 1) Then
            If (TextBoxCode.Lines(GetLine() + 1).Contains("}")) Then
                tab = tab.Remove(0, 1)
            End If
        End If
    End Sub

    Public Sub RealizaIdentacao()
        If TextBoxCode.Text(TextBoxCode.SelectionStart - 1) <> "(" Then
            TextBoxCode.SelectedText = tab
            tab = ""
        Else
            Dim savePos As Integer = TextBoxCode.SelectionStart
            Dim linesToIdent As Int16 = TextBoxCode.Lines.Count - numLines
            Dim i As Int16 = 0
            While i < linesToIdent
                Console.WriteLine(linesToIdent)
                VerificaIgnorandoColchete()
                While TextBoxCode.Text(TextBoxCode.SelectionStart - 1) <> vbLf
                    TextBoxCode.SelectionStart += 1
                End While
                TextBoxCode.SelectedText = tab
                If (tab = "") Then
                    TextBoxCode.SelectionStart += 1
                End If
                i += 1
            End While
            TextBoxCode.SelectionStart = savePos
        End If
    End Sub

    'Classes Responsáveis por gerenciar as sugestões de código

    Private keywords As String() = {"bool", "break", "byte", "case", "catch", "char", "class", "const", "continue", "delay", "default", "#define", "do", "double", "else", "enum", "explicit", "extern", "false", "float", "for", "goto", "if", "#include", "implicit", "int", "long", "namespace", "millis()", "new", "null", "operator", "override", "private", "protected", "public", "return", "short", "sizeof", "static", "String", "struct", "switch", "this", "throw", "true", "try", "unsigned", "using", "virtual", "void", "volatile", "while", "get", "remove", "yield"}
    Private methods As String() = {"available();", "begin();", "comunicacao();", "flush();", "getReg();", "getRegBit(,);", "print();", "println();", "setReg(,);", "setRegBit(,,);"}
    Private snippets As String() = {"if(^)" & vbLf & "{" & vbLf & "}", "if(^)" & vbLf & "{" & vbLf & "}" & vbLf & "else" & vbLf & "{" & vbLf & "}", "for(^;;)" & vbLf & "{" & vbLf & "}", "while(^)" & vbLf & "{" & vbLf & "}", "do${" & vbLf & "^}while();", "switch(^)" & vbLf & "{" & vbLf & vbTab & "case : break;" & vbLf & "}"}
    Private declarationSnippets As String() = {"void ^()" & vbLf & "{" & vbLf & "}", "analogRead(^);", "analogWrite(^,);", "pinMode(^,);", "digitalRead(^)", "digitalWrite(^, );", "struct ^" & vbLf & "{" & vbLf & "}", "void ^()" & vbLf & "{" & vbLf & "}", "class ^" & vbLf & "{" & vbLf & "};", "class ^" & vbLf & "{" & vbLf & vbTab & "public:" & vbLf & vbTab & "private:" & vbLf & "};"}

    Public Sub New()
        InitializeComponent()
        BuildAutocompleteMenu()
    End Sub

    Private Sub BuildAutocompleteMenu()
        Dim items = New List(Of AutocompleteItem)()

        For Each item In snippets
            items.Add(New SnippetAutocompleteItem(item) With {
                .ImageIndex = 1
            })
        Next

        For Each item In declarationSnippets
            items.Add(New DeclarationSnippet(item) With {
                .ImageIndex = 0
            })
        Next

        For Each item In methods
            items.Add(New MethodAutocompleteItem(item) With {
                .ImageIndex = 2
            })
        Next

        For Each item In keywords
            items.Add(New AutocompleteItem(item))
        Next

        items.Add(New InsertSpaceSnippet())
        items.Add(New InsertSpaceSnippet("^(\w+)([=<>!:]+)(\w+)$"))
        items.Add(New InsertEnterSnippet())
        AutocompleteMenuCodigo.SetAutocompleteItems(items)
    End Sub

    Class DeclarationSnippet
        Inherits SnippetAutocompleteItem

        Public Shared RegexSpecSymbolsPattern As String = "[\^\$\[\]\(\)\.\\\*\+\|\?\{\}]"

        Public Sub New(ByVal snippet As String)
            MyBase.New(snippet)
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim pattern = Regex.Replace(fragmentText, RegexSpecSymbolsPattern, "\$0")
            If Regex.IsMatch(Text, "\b" & pattern, RegexOptions.IgnoreCase) Then Return CompareResult.Visible
            Return CompareResult.Hidden
        End Function
    End Class

    Class InsertSpaceSnippet
        Inherits AutocompleteItem

        Private pattern As String

        Public Sub New(ByVal pattern As String)
            MyBase.New("")
            Me.pattern = pattern
        End Sub

        Public Sub New()
            Me.New("^(\d+)([a-zA-Z_]+)(\d*)$")
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            If Regex.IsMatch(fragmentText, pattern) Then
                Text = InsertSpaces(fragmentText)
                If Text <> fragmentText Then Return CompareResult.Visible
            End If

            Return CompareResult.Hidden
        End Function

        Public Function InsertSpaces(ByVal fragment As String) As String
            Dim m = Regex.Match(fragment, pattern)
            If m.Groups(1).Value = "" AndAlso m.Groups(3).Value = "" Then Return fragment
            Return (m.Groups(1).Value & " " + m.Groups(2).Value & " " + m.Groups(3).Value).Trim()
        End Function

        Public Overridable Overloads ReadOnly Property ToolTipTitle As String
            Get
                Return Text
            End Get
        End Property
    End Class

    Class InsertEnterSnippet
        Inherits AutocompleteItem

        Private enterPlace As Integer = 0

        Public Sub New()
            MyBase.New("[Line break]")
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim tb = Parent.TargetControlWrapper
            Dim text = tb.Text

            For i As Integer = Parent.Fragment.Start - 1 To 0
                If text(i) = vbLf Then Exit For

                If text(i) = "}"c Then
                    enterPlace = i
                    Return CompareResult.Visible
                End If
            Next
            Return CompareResult.Hidden
        End Function

        Public Overrides Function GetTextForReplace() As String
            Dim tb = Parent.TargetControlWrapper
            tb.SelectionStart = enterPlace + 1
            tb.SelectedText = vbLf
            Parent.Fragment.Start += 1
            Parent.Fragment.[End] += 1
            Return Parent.Fragment.Text
        End Function

        Public Overridable Overloads ReadOnly Property ToolTipTitle As String
            Get
                Return "Insert line break after '}'"
            End Get
        End Property
    End Class

    Public Sub CheckSintax()
        If (Programação.RadioButtonLigado.Checked) Then
            If Not (BackgroundWorkerLoadCode.IsBusy) Then BackgroundWorkerLoadCode.RunWorkerAsync()
            TextBoxCode.Visible = False
            RichTextBoxLinhas.Visible = False
            System.Threading.Thread.Sleep(20)
            TextBoxCode.ProcessAllLines()
            TextBoxCode.Visible = True
            RichTextBoxLinhas.Visible = True
            startProcessing = False
        End If
    End Sub

    Private Sub BackgroundWorkerLoadCode_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerLoadCode.DoWork
        Carregando.Show()
        Carregando.BringToFront()
        Dim cont As UInt16 = 0
        While (startProcessing)
            If Not Carregando.ProgressBar1.RightToLeftLayout Then
                Carregando.ProgressBar1.Increment(1)
                Threading.Thread.Sleep(10)
                Carregando.Update()
                If Carregando.ProgressBar1.Value = 100 Then
                    For i = 0 To 50
                        Carregando.ProgressBar1.Increment(1)
                        Threading.Thread.Sleep(10)
                        Carregando.Update()
                    Next
                    Carregando.ProgressBar1.RightToLeftLayout = True
                End If
            Else
                Carregando.ProgressBar1.Increment(-1)
                Threading.Thread.Sleep(10)
                Carregando.Update()
                If Carregando.ProgressBar1.Value = 0 Then
                    For i = 0 To 50
                        Carregando.ProgressBar1.Increment(-1)
                        Threading.Thread.Sleep(10)
                        Carregando.Update()
                    Next
                    Carregando.ProgressBar1.RightToLeftLayout = False
                End If
            End If
        End While
        Carregando.Close()
    End Sub

    'Habilita e desabilita botões da barra de ferramentas

    Private Sub TextBoxCode_GotFocus(sender As Object, e As EventArgs) Handles TextBoxCode.GotFocus
        Programação.ToolStripButtonInterrupt.Enabled = True
    End Sub

    Private Sub TextBoxCode_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCode.LostFocus
        Programação.ToolStripButtonInterrupt.Enabled = False
    End Sub

    Dim indexCode As UInt16
    Dim indexObjeto As UInt16

    Private Sub ComboIconEscopo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIconEscopo.SelectedIndexChanged
        If ComboIconEscopo.SelectedIndex >= 0 Then indexCode = ComboIconEscopo.SelectedIndex
        If (salto = False) Then
            SelectLine(escopoLines(indexCode), TextBoxCode)
        End If
        ComboIconObjects.Items.Clear()
        For Each item In varListByEscopo(indexCode)
            Dim name As String = item.TrimStart.Split("=")(0)
            If name.Contains("static") Then name = name.Replace("static", "").TrimStart
            If name.Contains("unsigned") Then name = name.Replace("unsigned", "").TrimStart
            name = name.Split(" ")(0) & " " & name.Split(" ")(1)
            name = name.Replace(";", "")
            ComboIconObjects.Items.Add(New ComboBoxIconItem(name, 1))
        Next
        salto = False
    End Sub

    Private Sub ComboIconObjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIconObjects.SelectedIndexChanged
        If ComboIconObjects.SelectedIndex >= 0 Then indexObjeto = ComboIconObjects.SelectedIndex
        If (salto = False) Then
            SelectLine(varLinesByEscopo(indexCode)(indexObjeto), TextBoxCode)
        End If
        salto = False
    End Sub

    Private Sub ComboIconEscopo_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboIconEscopo.MouseClick
        salto = False
    End Sub

    Private Sub ComboIconObjects_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboIconObjects.MouseClick
        salto = False
    End Sub
End Class
