Imports System.Windows.Forms

Public Class CriarGatilho
    Public ref As New ControleHardware

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        AtualizaRef()
        TimerMonitor.Stop()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        TimerMonitor.Stop()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CriarGatilho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerMonitor.Start()
        carregaDados()
    End Sub

    Private Sub carregaDados()
        ComboBoxReg.Items.Clear()
        For i As Byte = 0 To numMaxRegs - 1
            ComboBoxReg.Items.Add(i.ToString)
        Next
        If Not ref.engine.gatilho.Contains(",") Then
            Exit Sub
        End If
        Dim dados() As String = ref.engine.gatilho.Split(",")
        ComboBoxReg.SelectedItem = dados(0)
        ComboBoxCondiçao.SelectedItem = dados(1)
        TextBoxValor.Text = dados(2)
    End Sub

    Private Sub AtualizaRef()
        ref.engine.gatilho = ComboBoxReg.SelectedItem & "," & ComboBoxCondiçao.SelectedItem & "," & TextBoxValor.Text
        ref = New ControleHardware
    End Sub

    Private Sub TimerMonitor_Tick(sender As Object, e As EventArgs) Handles TimerMonitor.Tick
        If (DruidaSuiteMain.TimerLeituraRede.Enabled And Me.Visible And ComboBoxReg.SelectedItem <> Nothing) Then
            Try
                TextBoxReg.Text = dados(ComboBoxReg.SelectedItem)
                Dim regGatilho = ComboBoxReg.SelectedItem
                Dim condicao = ComboBoxCondiçao.SelectedItem
                Dim valor = TextBoxValor.Text
                TextBoxCondition.Text = TestaCondicao(condicao, regGatilho, valor)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Function TestaCondicao(condicao As String, reg As String, valor As String)
        If condicao = "igual a" Then
            Return (dados(reg) = valor)
        ElseIf condicao = "diferente de" Then
            Return (dados(reg) <> valor)
        ElseIf condicao = "maior que" Then
            Return (dados(reg) > valor)
        ElseIf condicao = "menor que" Then
            Return (dados(reg) < valor)
        Else
            Return True
        End If
    End Function
End Class
