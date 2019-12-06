
Imports System.ComponentModel

Public Class Alarmes
    Public alarme As Boolean = False
    Public portasEmAlarme As New List(Of String)
    Private tabelaAlarmes As New DataTable
    Public taskButtonRef As TaskButton

    Private Sub Alarmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (DruidaSuiteMain.COMPort.IsOpen) Then
            DruidaSuiteMain.StartRede()
        End If
        tabelaAlarmes.Columns.Clear()
        tabelaAlarmes.Columns.Add("Data")
        tabelaAlarmes.Columns.Add("Porta")
        tabelaAlarmes.Columns.Add("Descrição")
        updateTable()
        DataGridViewAlarmes.DataSource = tabelaAlarmes
        taskButtonRef = DruidaSuiteMain.taskButtons(DruidaSuiteMain.windowsOpened)
        DruidaSuiteMain.windowsOpened += 1
        taskButtonRef.Show()
        taskButtonRef.PictureBoxItem.Image = My.Resources._392ae9cfa4b776ec2eac86fe92f7f3a6_ilustra__o_de_luz_de_alarme_de_bombeiro
        taskButtonRef.LabelNomeItem.Text = "Alarmes"
        taskButtonRef.SetForm(Me)
    End Sub

    Private Sub ButtonReconhecerAlarmes_Click(sender As Object, e As EventArgs) Handles ButtonReconhecerAlarmes.Click, pbAckAlarms.Click
        For Each row In DataGridViewAlarmes.Rows
            If (row.DefaultCellStyle.ForeColor <> Color.Lime) Then
                row.DefaultCellStyle.ForeColor = Color.Green
            End If
        Next
        For Each item As Alarme In DruidaSuiteMain.activatedAlarms
            Dim portAlm As String = item.ComboBoxPorta.SelectedItem
            If item.ComboBoxBit.SelectedIndex <> -1 Then
                portAlm &= "." & item.ComboBoxBit.SelectedItem
            End If
            Dim values() As String = {Now, item.ComboBoxTipoPorta.Text & " " & portAlm, item.TextBoxMensagem.Text}
            tabelaAlarmes.Rows.Add(values)
        Next
    End Sub

    Private Sub ButtonLimparHistórico_Click(sender As Object, e As EventArgs) Handles ButtonLimparHistórico.Click, pbClearHistory.Click
        DruidaSuiteMain.alarmTable.Clear()
        ClearTable()
    End Sub

    Private Sub ButtonConfigAlarms_Click(sender As Object, e As EventArgs) Handles ButtonConfigAlarms.Click, pbConfig.Click
        If (My.Application.OpenForms.OfType(Of ConfigAlarmes).Count = 0) Then
            ConfigAlarmes.Show()
        End If
    End Sub

    Private Sub LabelClose_Click(sender As Object, e As EventArgs) Handles LabelClose.Click
        Close()
    End Sub

    Private Sub LabelClose_MouseEnter(sender As Object, e As EventArgs) Handles LabelClose.MouseEnter
        LabelClose.Image = Nothing
    End Sub

    Private Sub LabelClose_MouseLeave(sender As Object, e As EventArgs) Handles LabelClose.MouseLeave
        LabelClose.Image = My.Resources.Gradiente_Azul2
    End Sub

    Private Sub Alarmes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DruidaSuiteMain.windowsOpened -= 1
        taskButtonRef.Hide()
    End Sub

    Public Sub updateTable()
        If My.Application.OpenForms.OfType(Of Alarmes).Count > 0 Then
            ClearTable()
            For Each item In DruidaSuiteMain.alarmTable
                tabelaAlarmes.Rows.Add(item)
            Next
        End If
    End Sub

    Public Sub ClearTable()
        tabelaAlarmes.Clear()
        tabelaAlarmes.Columns.Clear()
        tabelaAlarmes.Rows.Clear()
        tabelaAlarmes.Columns.Add("Data")
        tabelaAlarmes.Columns.Add("Porta")
        tabelaAlarmes.Columns.Add("Descrição")
        DataGridViewAlarmes.DataSource = tabelaAlarmes
    End Sub

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click, pbSave.Click
        Dim saveAlarms As New SaveFileDialog With {
            .InitialDirectory = applicationDirectory,
            .Title = "Salvar Alarmes",
            .Filter = "Arquivo de Texto|*.txt"}
        If saveAlarms.ShowDialog <> DialogResult.OK Then
            Exit Sub
        End If
        System.IO.File.WriteAllText(saveAlarms.FileName, "")
        System.IO.File.AppendAllText(saveAlarms.FileName, "Data" & vbTab & "Porta" & vbTab & "Descricao" & vbCrLf)
        For Each lin As DataGridViewRow In DataGridViewAlarmes.Rows
            System.IO.File.AppendAllText(saveAlarms.FileName, lin.Cells(0).Value & vbTab & lin.Cells(1).Value & vbTab & lin.Cells(2).Value & vbCrLf)
        Next
    End Sub

End Class