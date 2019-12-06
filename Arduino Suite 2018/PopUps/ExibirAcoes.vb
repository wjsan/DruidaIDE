Public Class ExibirAcoes
    Private acoesGravadas As New List(Of String)
    Private controlActions As String = ""

    Private Sub TimerGravarAcoes_Tick(sender As Object, e As EventArgs) Handles TimerGravarAcoes.Tick
        Static Dim index As UInt16 = 0
        Static Dim lastAction As String = ""
        Static Dim image As Image = My.Resources.LedOn
        If controlActions = "stop" Then
            index = 0
            TimerGravarAcoes.Stop()
            TextBoxActions.SelectionStart = 0
            TextBoxActions.ScrollToCaret()
            Exit Sub
        End If
        If controlActions = "pause" Then
            TimerGravarAcoes.Stop()
            Exit Sub
        End If
        If controlActions = "record" Then
            If lastActions = lastAction Then
                lastActions = "r" & vbLf
            End If
            lastAction = lastActions
            acoesGravadas.Add(lastActions)
            TextBoxActions.AppendText(lastActions)
            If ToolStripButtonRec.Image IsNot image Then
                ToolStripButtonRec.Image = image
            End If
        Else
            If index < acoesGravadas.Count Then
                Dim action As String = acoesGravadas(index)
                If action <> "r" Then
                    If action.Contains("timer") Then
                        ToolStripTextBoxTimer.Text = action.Split("=")(1).TrimStart
                        If index + 1 < acoesGravadas.Count Then
                            index += 1
                            GoToLine(index)
                        End If
                    End If
                    monitorSerialWrite(acoesGravadas(index))
                    monitorSerialWrite("0.0.0.0.0.0.0.0.0.0_")
                End If
                GoToLine(index)
                AtualizaNumList()
                index += 1
                If index = acoesGravadas.Count Then
                    If controlActions = "playOnce" Then
                        TimerGravarAcoes.Stop()
                        index = 0
                    Else
                        index = 0
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GoToLine(index As UShort)
        Dim i As Int16 = TextBoxActions.GetFirstCharIndexFromLine(index)
        If i >= 0 Then
            TextBoxActions.SelectionStart = i
            TextBoxActions.ScrollToCaret()
        End If
    End Sub

    Private Sub ToolStripButtonRec_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRec.Click
        controlActions = "record"
        TimerGravarAcoes.Start()
    End Sub

    Private Sub ToolStripButtonStop_Click(sender As Object, e As EventArgs) Handles ToolStripButtonStop.Click
        controlActions = "stop"
        ToolStripButtonRec.Image = My.Resources.LedOff
    End Sub

    Private Sub ToolStripButtonPlay_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPlay.Click
        LoadActions()
        controlActions = "playOnce"
        TimerGravarAcoes.Start()
    End Sub

    Private Sub ToolStripButtonClear_Click(sender As Object, e As EventArgs) Handles ToolStripButtonClear.Click
        acoesGravadas.Clear()
        TextBoxActions.Clear()
    End Sub

    Private Sub ToolStripButtonSave_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSave.Click
        Dim initialPath As String = applicationDirectory & "\Comando\Ações Personalizadadas"
        System.IO.Directory.CreateDirectory(initialPath)
        Dim saveFile As New SaveFileDialog With {
            .Filter = "Ação personalizada|*.act",
            .InitialDirectory = initialPath,
            .Title = "Salvar Ação Personalizada"
        }
        Dim dialogResult = saveFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            acoesGravadas.Insert(0, "timer = " & ToolStripTextBoxTimer.Text & vbLf)
            System.IO.File.WriteAllLines(saveFile.FileName, acoesGravadas)
        End If
    End Sub

    Private Sub ToolStripButtonCarregar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCarregar.Click
        Dim initialPath As String = applicationDirectory & "\Comando\Ações Personalizadadas"
        System.IO.Directory.CreateDirectory(initialPath)
        Dim openFile As New OpenFileDialog With {
            .Filter = "Ação personalizada|*.act",
            .InitialDirectory = initialPath,
            .Title = "Carregar Ação Personalizada"
        }
        Dim dialogResult = openFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            TextBoxActions.Text = System.IO.File.ReadAllText(openFile.FileName)
            LoadActions()
        End If
    End Sub

    Public Sub AtualizaNumList()
        Dim cont As Int16 = 0
        Dim linhas As String = ""
        Dim cIndex As Integer = TextBoxActions.GetCharIndexFromPosition(New Point(0, 0))
        For i = TextBoxActions.GetLineFromCharIndex(cIndex) + 1 To TextBoxActions.Lines.Count
            linhas &= i & vbCrLf
        Next
        RichTextBoxLinhas.SelectionAlignment = HorizontalAlignment.Right
        RichTextBoxLinhas.Text = linhas
        Dim line As String = 0
        If TextBoxActions.SelectionStart > 0 Then
            line = TextBoxActions.GetLineFromCharIndex(TextBoxActions.SelectionStart)
        End If
        If line >= 0 And acoesGravadas.Count > 0 And line < acoesGravadas.Count Then
            ToolStripLabelLineNum.Text = "Lin:" & line + 1
            ToolStripLabelCmd.Text = "Cmd:" & acoesGravadas(line).TrimEnd
        End If
    End Sub

    Private Sub r_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxActions.Resize, TextBoxActions.TextChanged
        AtualizaNumList()
    End Sub

    Private Sub r_KeyDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxActions.KeyUp, TextBoxActions.MouseWheel
        AtualizaNumList()
    End Sub

    Private Sub ToolStripButtonPause_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPause.Click
        controlActions = "pause"
    End Sub

    Private Sub ToolStripButtonPlayLoop_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPlayLoop.Click
        LoadActions()
        controlActions = "playLoop"
        TimerGravarAcoes.Start()
    End Sub



    Private Sub ToolStripTextBoxTimer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripTextBoxTimer.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripTextBoxTimer_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBoxTimer.TextChanged
        If ToolStripTextBoxTimer.Text <> "" Then
            If ToolStripTextBoxTimer.Text >= 50 Then
                TimerGravarAcoes.Interval = ToolStripTextBoxTimer.Text
            End If
        End If
    End Sub

    Private Sub LoadActions()
        acoesGravadas.Clear()
        For Each item In TextBoxActions.Lines
            If item.Contains("timer") Then
                ToolStripTextBoxTimer.Text = item.Split("=")(1).TrimStart
            End If
            If item <> "" Then
                acoesGravadas.Add(item.TrimEnd)
            End If
        Next
    End Sub

    Private Sub ToolStripButtonRemoveTimers_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRemoveTimers.Click
        Dim newText As String = ""
        For Each line In TextBoxActions.Lines
            If line <> "r" And line <> "" Then
                newText &= line & vbCrLf
            End If
        Next
        TextBoxActions.Text = newText
    End Sub
End Class