Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions

Public Class ArduinoAutocomplete
    Public Function AddItemWithInfo(ByVal text As String, ByVal imageIndex As Int16, ByVal menuText As String, ByVal toolTipTitle As String, ByVal toolTipText As String, ByVal tag As String)
        If imageIndex < 0 Then
            imageIndex = 0
        End If
        Dim item As New SnippetAutocompleteItem(text) With {
            .ImageIndex = imageIndex,
            .MenuText = menuText,
            .ToolTipTitle = toolTipTitle,
            .ToolTipText = toolTipText,
            .Tag = tag
            }
        Return item
    End Function

    Public Function AddMethodWithInfo(ByVal text As String, ByVal imageIndex As Int16, ByVal menuText As String, ByVal toolTipTitle As String, ByVal toolTipText As String, ByVal tag As String)
        If imageIndex < 0 Then
            imageIndex = 0
        End If
        Dim item As New MethodAutocompleteItem2(text) With {
            .ImageIndex = imageIndex,
            .MenuText = menuText,
            .ToolTipTitle = toolTipTitle,
            .ToolTipText = toolTipText,
            .Tag = tag
            }
        Return item
    End Function

    Private Class DeclarationSnippet
        Inherits SnippetAutocompleteItem

        Public Sub New(snippet As String)
            MyBase.New(snippet)
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim pattern As String = Regex.Escape(fragmentText)
            Dim result As CompareResult
            If Regex.IsMatch(Me.Text, "\b" + pattern, RegexOptions.IgnoreCase) Then
                result = CompareResult.Visible
            Else
                result = CompareResult.Hidden
            End If
            Return result
        End Function
    End Class

    Public Class MethodAutocompleteItem2
        Inherits MethodAutocompleteItem

        Private firstPart As String
        Private lastPart As String

        Public Sub New(ByVal text As String)
            MyBase.New(text)
            Dim i = text.LastIndexOf("."c)

            If i < 0 Then
                firstPart = text
            Else
                firstPart = text.Substring(0, i)
                lastPart = text.Substring(i + 1)
            End If
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim i As Integer = fragmentText.LastIndexOf("."c)

            If i < 0 Then
                If firstPart.StartsWith(fragmentText) AndAlso String.IsNullOrEmpty(lastPart) Then Return CompareResult.VisibleAndSelected
            Else
                Dim fragmentFirstPart = fragmentText.Substring(0, i)
                Dim fragmentLastPart = fragmentText.Substring(i + 1)
                If firstPart <> fragmentFirstPart Then Return CompareResult.Hidden
                If lastPart IsNot Nothing AndAlso lastPart.StartsWith(fragmentLastPart) Then Return CompareResult.VisibleAndSelected
                If lastPart IsNot Nothing AndAlso lastPart.ToLower().Contains(fragmentLastPart.ToLower()) Then Return CompareResult.Visible
            End If

            Return CompareResult.Hidden
        End Function

        Public Overrides Function GetTextForReplace() As String
            If lastPart Is Nothing Then Return firstPart
            Return firstPart & "." & lastPart
        End Function

        Public Overrides Sub OnSelected(ByVal popupMenu As AutocompleteMenu, ByVal e As SelectedEventArgs)
            e.Tb.BeginUpdate()
            e.Tb.Selection.BeginUpdate()
            Dim p1 = popupMenu.Fragment.Start
            Dim p2 = e.Tb.Selection.Start

            If e.Tb.AutoIndent Then

                For iLine As Integer = p1.iLine + 1 To p2.iLine
                    e.Tb.Selection.Start = New Place(0, iLine)
                    e.Tb.DoAutoIndent(iLine)
                Next
            End If

            e.Tb.Selection.Start = p1

            While e.Tb.Selection.CharBeforeStart <> "^"c
                If Not e.Tb.Selection.GoRightThroughFolded() Then Exit While
            End While

            e.Tb.Selection.GoLeft(True)
            e.Tb.InsertText("")
            e.Tb.Selection.EndUpdate()
            e.Tb.EndUpdate()
        End Sub
    End Class

    Private Class InsertSpaceSnippet
        Inherits AutocompleteItem

        Private pattern As String

        Public Overrides Property ToolTipTitle() As String
            Get
                Return Me.Text
            End Get
            Set(value As String)

            End Set
        End Property

        Public Sub New(pattern As String)
            MyBase.New("")
            Me.pattern = pattern
        End Sub

        Public Sub New()
            Me.New("^(\d+)([a-zA-Z_]+)(\d*)$")
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim result As CompareResult
            If Regex.IsMatch(fragmentText, Me.pattern) Then
                Me.Text = Me.InsertSpaces(fragmentText)
                If Me.Text <> fragmentText Then
                    result = CompareResult.Visible
                    Return result
                End If
            End If
            result = CompareResult.Hidden
            Return result
        End Function

        Public Function InsertSpaces(fragment As String) As String
            Dim i As Match = Regex.Match(fragment, Me.pattern)
            Dim result As String
            If i Is Nothing Then
                result = fragment
            Else
                If i.Groups(1).Value = "" AndAlso i.Groups(3).Value = "" Then
                    result = fragment
                Else
                    result = String.Concat(New String() {i.Groups(1).Value, " ", i.Groups(2).Value, " ", i.Groups(3).Value}).Trim()
                End If
            End If
            Return result
        End Function
    End Class

    Private Class InsertEnterSnippet
        Inherits AutocompleteItem

        Private enterPlace As Place = Place.Empty

        Public Overrides Property ToolTipTitle() As String
            Get
                Return "Insert line break after '}'"
            End Get
            Set(value As String)

            End Set
        End Property

        Public Sub New()
            MyBase.New("[Line break]")
        End Sub

        Public Overrides Function Compare(fragmentText As String) As CompareResult
            Dim r As Range = MyBase.Parent.Fragment.Clone()
            Dim result As CompareResult
            While r.Start.iChar > 0
                If r.CharBeforeStart = "}" Then
                    Me.enterPlace = r.Start
                    result = CompareResult.Visible
                    Return result
                End If
                r.GoLeftThroughFolded()
            End While
            result = CompareResult.Hidden
            Return result
        End Function

        Public Overrides Function GetTextForReplace() As String
            Dim r As Range = MyBase.Parent.Fragment
            Dim [end] As Place = r.[End]
            r.Start = Me.enterPlace
            r.[End] = r.[End]
            Return Environment.NewLine + r.Text
        End Function

        Public Overrides Sub OnSelected(popupMenu As AutocompleteMenu, e As SelectedEventArgs)
            MyBase.OnSelected(popupMenu, e)
            If MyBase.Parent.Fragment.tb.AutoIndent Then
                MyBase.Parent.Fragment.tb.DoAutoIndent()
            End If
        End Sub
    End Class
End Class
