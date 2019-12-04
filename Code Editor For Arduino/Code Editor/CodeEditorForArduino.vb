Imports FastColoredTextBoxNS

Public Class CodeEditorForArduino
    Inherits FastColoredTextBox

    Enum codeImages
        keyword
        variable
        constant
        classObject
        method
        classType
        library
        globalEscope
    End Enum

    Public myCodeFileManager As New CodeFileManager(Me)
    Public myPopMenuItens As New List(Of AutocompleteItem)
    Public myPredefinedPopMenuItens As New List(Of AutocompleteItem)
    Public myPopMenu As New AutocompleteMenu(Me)
    Private AllPopMenuItens As New List(Of AutocompleteItem)

    ''' <summary>
    ''' Procura uma linha baseado no texto informado
    ''' </summary>
    ''' <param name="text">Texto a ser buscado nas linhas</param>
    ''' <returns>Retorna o número da primeira linha onde foi encontrado o texto em questão</returns>
    Public Function searchLine(ByVal text As String)
        Dim cont As Integer = 0
        Dim encontrado As Boolean = False
        For i = 0 To Me.Lines.Count - 1
            Dim line = Me.Lines(i)
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
        Return (0)
    End Function

    ''' <summary>
    ''' Adiciona uma linha no editor de código
    ''' </summary>
    ''' <param name="pos">Qual o número da linha onde será adicionado o texto</param>
    ''' <param name="text">Texto da nova linha a ser adicionada</param>

    Public Sub addLine(ByVal pos As Int16, ByVal text As String)
        If (pos < 0) Then
            pos = Me.Lines.Count - 1
        End If
        Navigate(pos)
        Me.SelectionLength = 0
        Me.SelectedText = text
        Me.SelectedText = vbLf
    End Sub

    ''' <summary>
    ''' Procura uma linha que contenha a string 's2', e esteje depois da string 's1'
    ''' </summary>
    ''' <param name="s1">String inicial</param>
    ''' <param name="s2">String a ser localizada após a string inicial</param>
    ''' <returns></returns>

    Public Function searchAfterString(ByVal s1 As String, ByVal s2 As String)
        Static Dim lines As New List(Of String)
        lines.Clear()
        Dim cont As Integer = 0
        Dim encontrado As Boolean = False
        For Each line In Me.Lines
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
        Return (0)
    End Function

    ''' <summary>
    ''' Procura qual a primeira linha válida do editor de códigos, ou seja, a primeira linha após o cabeçalho.
    ''' </summary>
    ''' <returns>O número da primeira linha que esteje após o cabeçalho</returns>

    Public Function firstValidLine()
        Static Dim lines As New List(Of String)
        lines.Clear()
        Dim cont As Integer = 0
        Dim encontrado As Boolean = False
        For Each line In Me.Lines
            If Not (line.Contains("/*") Or line.Contains("//")) Then
                encontrado = True
                Return (cont)
                Exit For
            End If
            cont += 1
        Next
        If (Not (encontrado)) Then
            Return (-1)
        End If
        Return (0)
    End Function

    Private Sub CodeEditorForArduino_ToolTipNeeded(sender As Object, e As ToolTipNeededEventArgs) Handles Me.ToolTipNeeded
        If Not String.IsNullOrEmpty(e.HoveredWord) Then
            For Each it In AllPopMenuItens
                If it.Tag = e.HoveredWord Then
                    e.ToolTipIcon = ToolTipIcon.Info
                    e.ToolTipTitle = it.ToolTipTitle
                    e.ToolTipText = it.ToolTipText
                    If e.ToolTipText = "" Then
                        e.ToolTipIcon = ToolTipIcon.None
                        e.ToolTipText = it.ToolTipTitle
                        e.ToolTipTitle = ""
                    End If
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub CodeEditorForArduino_TextChangedDelayed(sender As Object, e As TextChangedEventArgs) Handles Me.TextChangedDelayed
        'If AllPopMenuItens.Count <> (myPredefinedPopMenuItens.Count + myPopMenuItens.Count) Then
        AllPopMenuItens.Clear()
        AllPopMenuItens.AddRange(myPredefinedPopMenuItens)
        AllPopMenuItens.AddRange(myPopMenuItens)
        myPopMenu.Items.SetAutocompleteItems(AllPopMenuItens)
        UpdateSyntaxData()
        'End If
    End Sub

    Public Sub UpdateSyntaxData()
        ArduinoSyntax.declaredClassTypes = ""
        ArduinoSyntax.declaredConstants = ""
        ArduinoSyntax.instanceMethods = ""
        ArduinoSyntax.declaredInstances = ""
        ArduinoSyntax.declaredMethods = ""
        ArduinoSyntax.declaredVariables = ""
        For Each it In myPopMenuItens
            AddConstant(it)
            AddClassTypes(it)
            AddMethod(it)
            AddInstance(it)
            AddVariable(it)
        Next
    End Sub

    Private Sub AddClassTypes(it As AutocompleteItem)
        If it.ImageIndex = codeImages.classType And Not ArduinoSyntax.declaredClassTypes.Contains(it.Tag) Then
            If Not it.Tag.contains("(") Then
                ArduinoSyntax.declaredClassTypes &= TextTreatment.Normalize(it.Tag) & "|"
            End If
        End If
    End Sub

    Private Sub AddConstant(it As AutocompleteItem)
        If it.ImageIndex = codeImages.constant And Not ArduinoSyntax.declaredConstants.Contains(it.Tag) Then
            ArduinoSyntax.declaredConstants &= TextTreatment.Normalize(it.Tag) & "|"
        End If
    End Sub

    Private Sub AddMethod(it As AutocompleteItem)
        If it.ImageIndex = codeImages.method Then
            If Not it.Text.Contains(".") And Not ArduinoSyntax.declaredMethods.Contains(it.Tag) Then
                ArduinoSyntax.declaredMethods &= TextTreatment.Normalize(it.Tag) & "|"
            ElseIf Not ArduinoSyntax.instanceMethods.Contains(it.Tag) Then
                ArduinoSyntax.instanceMethods &= TextTreatment.Normalize(it.Tag) & "|"
            End If
        End If
    End Sub

    Private Sub AddInstance(it As AutocompleteItem)
        If it.ImageIndex = codeImages.classObject And Not ArduinoSyntax.declaredInstances.Contains(it.Tag) Then
            ArduinoSyntax.declaredInstances &= TextTreatment.Normalize(it.Tag) & "|"
        End If
    End Sub

    Private Sub AddVariable(it As AutocompleteItem)
        If it.ImageIndex = codeImages.variable And Not ArduinoSyntax.declaredVariables.Contains(it.Tag) Then
            ArduinoSyntax.declaredVariables &= TextTreatment.Normalize(it.Tag) & "|"
        End If
    End Sub

    Public Sub myPopMenuItemsAdd(item)
        Dim name As String = ClearName(item.Text)
        For Each it In myPredefinedPopMenuItens
            If name = ClearName(it.Text) Then
                Exit Sub
            End If
        Next
        For Each it In myPopMenuItens
            If name = ClearName(it.Text) Then
                Exit Sub
            End If
        Next
        myPopMenuItens.Add(item)
    End Sub

    Private Function ClearName(name As String) As String
        Return name.Replace("^", "").Replace(";", "")
    End Function

    Private Sub InitializeComponent()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodeEditorForArduino
        '
        Me.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Name = "CodeEditorForArduino"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
