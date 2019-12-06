Public Class NomePortas

    Dim file As New FileVarSystem
    Dim names(19) As String
    Dim types(19) As String

    Private Sub ComboBoxPorta_MouseDown(sender As Object, e As MouseEventArgs) Handles ComboBoxPorta2.MouseDown,
        ComboBoxPorta3.MouseDown,
        ComboBoxPorta4.MouseDown,
        ComboBoxPorta5.MouseDown,
        ComboBoxPorta6.MouseDown,
        ComboBoxPorta7.MouseDown,
        ComboBoxPorta8.MouseDown,
        ComboBoxPorta9.MouseDown,
        ComboBoxPorta10.MouseDown,
        ComboBoxPorta11.MouseDown,
        ComboBoxPorta12.MouseDown,
        ComboBoxPorta13.MouseDown,
        ComboBoxPortaA0.MouseDown,
        ComboBoxPortaA1.MouseDown,
        ComboBoxPortaA2.MouseDown,
        ComboBoxPortaA3.MouseDown,
        ComboBoxPortaA4.MouseDown,
        ComboBoxPortaA5.MouseDown,
        ComboBoxPortaA6.MouseDown,
        ComboBoxPortaA7.MouseDown
        If e.Button = MouseButtons.Right Then
            sender.SelectedIndex = -1
        End If
    End Sub

    Public Sub SavePortSeetings()
        Dim varNames(19) As String
        GetVarNames(varNames, " Nome")
        GetPortNames()
        file.SaveData(varNames, names)
        GetVarNames(varNames, " Tipo")
        GetTypeNames()
        file.AppendData(varNames, types)
    End Sub

    Public Sub LoadPortSeetings()
        If file.Empty Then
            Exit Sub
        End If
        Dim varNames(19) As String
        GetVarNames(varNames, " Nome")
        file.LoadData(varNames, names)
        SetPortNames()
        GetVarNames(varNames, " Tipo")
        file.LoadDataInInterval(varNames, types, 20, 39)
        SetTypeNames()
    End Sub

    Private Sub GetTypeNames()
        For Each control In SplitContainer2.Panel2.Controls
            If control.GetType() = GetType(ComboBox) Then
                If control.SelectedIndex > -1 Then
                    types(control.TabIndex) = control.SelectedItem.ToString
                End If
            End If
        Next
    End Sub

    Private Sub GetPortNames()
        For Each control In SplitContainer2.Panel1.Controls
            If control.GetType() = GetType(TextBox) Then
                names(control.TabIndex) = control.Text
            End If
        Next
    End Sub

    Private Sub SetTypeNames()
        For Each control In SplitContainer2.Panel2.Controls
            If control.GetType() = GetType(ComboBox) Then
                control.SelectedItem = types(control.TabIndex)
            End If
        Next
    End Sub

    Private Sub SetPortNames()
        For Each control In SplitContainer2.Panel1.Controls
            If control.GetType() = GetType(TextBox) Then
                control.Text = names(control.TabIndex)
            End If
        Next
    End Sub

    Private Sub GetVarNames(ByRef varNames() As String, ByVal str As String)
        For Each control In SplitContainer1.Panel1.Controls
            If control.TabIndex > 0 Then
                varNames(control.TabIndex - 1) = control.Text & str
            End If
        Next
    End Sub

    Public Sub LimparTudo()
        For Each control In SplitContainer2.Panel1.Controls
            If control.GetType = GetType(TextBox) Then
                control.Text = ""
            End If
        Next
        For Each control In SplitContainer1.Panel1.Controls
            If control.GetType = GetType(ComboBox) Then
                control.SelectedItem = Nothing
            End If
        Next
    End Sub

    Private Sub NomePortas_Load(sender As Object, e As EventArgs) Handles Me.Load
        file.SetFilePath(applicationDirectory & "\Config Files\Ports.cfg")
    End Sub
End Class
