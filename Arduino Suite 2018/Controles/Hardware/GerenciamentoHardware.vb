Public Class GerenciamentoHardware
    Dim file As New FileVarSystem
    Dim txBox As New List(Of TextBox)
    Dim cbBox As New List(Of ComboBox)
    Dim txBoxNames As New List(Of String)
    Dim cbBoxNames As New List(Of String)
    Dim txBoxValues As New List(Of String)
    Dim cbBoxValues As New List(Of String)

    Public Sub New(filePath As String)
        file.SetFilePath(filePath)
    End Sub

    Public Sub SetFilePath(filePath As String)
        file.SetFilePath(filePath)
    End Sub

    Public Function GetFilePath()
        Return (file.GetFilePath())
    End Function

    Private Sub SaveTextBox()
        For i = 0 To txBoxNames.Count - 1
            Dim item = txBoxNames(i)
            file.SetVar(item, txBoxValues(i))
        Next
    End Sub

    Private Sub SaveComboBox()
        For i = 0 To cbBoxNames.Count - 1
            Dim item = cbBoxNames(i)
            file.SetVar(item, cbBoxValues(i))
        Next
    End Sub

    Private Sub LoadTextBox()
        For i = 0 To txBoxNames.Count - 1
            Dim item = txBoxNames(i)
            file.LoadVar(item, txBoxValues(i))
        Next
    End Sub

    Private Sub LoadComboBox()
        For i = 0 To cbBoxNames.Count - 1
            Dim item = cbBoxNames(i)
            file.LoadVar(item, cbBoxValues(i))
        Next
    End Sub

    Public Sub Save()
        updateTextBoxValues()
        updateComboBoxValues()
        SaveTextBox()
        SaveComboBox()
    End Sub

    Public Sub Load()
        If Not file.Empty Then
            LoadTextBox()
            LoadComboBox()
            AssignPinNames()
            AssignPinTypes()
        End If
    End Sub

    Public Sub SetTextBoxList(ByRef controlsList As Control.ControlCollection)
        txBox.Clear()
        txBoxNames.Clear()
        For Each item In controlsList
            If item.GetType = GetType(TextBox) Then
                txBox.Add(item)
                txBoxNames.Add(item.Name)
            End If
        Next
        txBox.Sort(Function(x, y) x.Name.CompareTo(y.Name))
        txBoxNames.Sort()
        updateTextBoxValues()
    End Sub

    Private Sub updateTextBoxValues()
        txBoxValues.Clear()
        For Each item In txBox
            txBoxValues.Add(item.Text)
        Next
    End Sub

    Public Sub SetComboBoxList(ByRef controlsList As Control.ControlCollection)
        cbBox.Clear()
        cbBoxNames.Clear()
        For Each item In controlsList
            If item.GetType = GetType(ComboBox) Then
                cbBox.Add(item)
                cbBoxNames.Add(item.Name)
            End If
        Next
        cbBox.Sort(Function(x, y) x.Name.CompareTo(y.Name))
        cbBoxNames.Sort()
        updateComboBoxValues()
    End Sub

    Private Sub updateComboBoxValues()
        cbBoxValues.Clear()
        For Each item In cbBox
            cbBoxValues.Add(item.SelectedItem)
        Next
    End Sub

    Private Sub AssignPinNames()
        For i = 0 To txBox.Count - 1
            txBox(i).Text = txBoxValues(i)
        Next
    End Sub

    Private Sub AssignPinTypes()
        For i = 0 To cbBox.Count - 1
            cbBox(i).SelectedItem = cbBoxValues(i)
        Next
    End Sub

    Public Function GetPinOut()
        Dim pinout As String = getHeader()
        updateTextBoxValues()
        updateComboBoxValues()
        For Each item As TextBox In txBox
            If item.Text <> "" Then
                pinout &= "#define " & item.Text & " " & txBoxNames.Item(txBox.IndexOf(item)).Remove(0, 12) & vbCrLf
            End If
        Next
        Return pinout
    End Function

    Public Function GetSetup()
        Dim setup As String = "void setupPins()" & vbCrLf
        setup &= "{" & vbCrLf
        For Each item As ComboBox In cbBox
            If item.SelectedIndex <> 0 Then
                Dim mode As String = ""
                Select Case item.SelectedIndex
                    Case 1
                        mode = "INPUT"
                    Case 2
                        mode = "INPUT_PULLUP"
                    Case 3
                        mode = "OUTPUT"
                End Select
                setup &= vbTab & "pinMode(" & txBoxValues.Item(cbBox.IndexOf(item)) & ", " & mode & ");" & vbCrLf
                'txBoxValues.Item(cbBox.IndexOf(item)) & " " & txBoxNames.Item(cbBox.IndexOf(item)).Remove(11) & vbCrLf
            End If
        Next
        setup &= "}" & vbCrLf
        Return setup
    End Function

    Public Function getHeader()
        Dim header As String = ""
        Dim descr As String = ""
        header &= "//*************************************************************************************************" & vbLf
        header &= "//   Projeto" & vbTab & ": " & AppName & vbLf
        header &= "//   Arquivo" & vbTab & ": " & "Pinout.h" & vbLf
        header &= "//   Descrição" & vbTab & ": " & "Descrição dos pinos do Arduino" & vbLf
        header &= "//   Data" & vbTab & vbTab & ": " & Date.Today & vbLf
        header &= "//**************************************************************************************************" & vbLf & vbLf
        Return header
    End Function
End Class
