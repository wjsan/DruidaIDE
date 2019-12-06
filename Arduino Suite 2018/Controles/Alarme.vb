Public Class Alarme
    Public alarmIndex As UInt16 = 0
    Private valor As String = 0
    Private statusAlarme As Boolean = False
    Public Event remove(alarm As Alarme)
    Private Sub Alarme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alarmIndex = numAlarme
        numAlarme += 1
        GetTypes()
    End Sub

    Private Sub GetTypes()
        'ComboBoxTipoPorta.Items.Clear()
        If appProgrammingMethod = "Avançado" Then
            If Not ComboBoxTipoPorta.Items.Contains("Regs") Then
                ComboBoxTipoPorta.Items.Add("Regs")
            End If
            ComboBoxBit.Enabled = True
        Else
            ComboBoxTipoPorta.Items.Add("Entrada Digital")
            ComboBoxTipoPorta.Items.Add("Entrada Analógica")
        End If
    End Sub

    Private Sub ButtonApagar_Click(sender As Object, e As EventArgs) Handles ButtonApagar.Click
        RaiseEvent remove(Me)
    End Sub

    Private Sub ComboBoxTipoPorta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoPorta.SelectedIndexChanged
        updatePorts()
    End Sub

    Public Sub SaveMe()
        Dim path As String = applicationDirectory & "\Alarmes.alm"
        Dim dados As String = ComboBoxTipoPorta.Text & "_" & ComboBoxPorta.Text & "_" & ComboBoxBit.Text & "_" & ComboBoxTipoAlarme.Text & "_" & TextBoxValor.Text & "_" & TextBoxMensagem.Text
        System.IO.File.AppendAllText(path, dados & vbCrLf)
    End Sub

    Public Sub LoadMe(ByVal dados As String)
        Dim data() As String = dados.Split("_")
        GetTypes()
        ComboBoxTipoPorta.SelectedItem = data(0)
        updatePorts()
        ComboBoxPorta.SelectedItem = data(1)
        ComboBoxBit.SelectedItem = data(2)
        ComboBoxTipoAlarme.SelectedItem = data(3)
        TextBoxValor.Text = data(4)
        TextBoxMensagem.Text = data(5)
    End Sub

    Public Sub updatePorts()
        Dim lista As New List(Of String)
        For i = 0 To numMaxRegs - 1
            lista.Add(i)
        Next
        ComboBoxPorta.Items.Clear()
        For Each port In lista
            If (ComboBoxTipoPorta.SelectedIndex = 1) Then
                ComboBoxPorta.Items.Add("A" & port)
            Else
                ComboBoxPorta.Items.Add(port)
            End If
        Next
    End Sub

    Public Sub checarAlarme()
        lerValor()
        If ComboBoxBit.SelectedIndex <> -1 Then
            If valor = "True" Then valor = "1"
            If valor = "False" Then valor = "0"
        End If
        If ComboBoxTipoAlarme.SelectedItem = "Máximo" Then

            statusAlarme = CInt(valor) >= CInt(TextBoxValor.Text)
        End If
        If ComboBoxTipoAlarme.SelectedItem = "Mínimo" Then
            statusAlarme = CInt(valor) <= CInt(TextBoxValor.Text)
        End If
        If statusAlarme = True Then
            Console.WriteLine(ComboBoxTipoAlarme.SelectedItem)
            Console.WriteLine(valor)
        End If
    End Sub

    Private Sub lerValor()
        If appProgrammingMethod <> "Avançado" And estados <> "" And ComboBoxPorta.SelectedItem IsNot Nothing Then
            If ComboBoxTipoPorta.SelectedIndex = 0 Then
                valor = estados(ComboBoxPorta.SelectedItem - 2)
            End If
            If ComboBoxTipoPorta.SelectedIndex = 1 Then
                valor = analogicas(ComboBoxPorta.SelectedItem.Remove(0, 1))
            End If
        End If
        If appProgrammingMethod = "Avançado" And dados IsNot Nothing And ComboBoxPorta.SelectedItem IsNot Nothing Then
            If ComboBoxBit.SelectedIndex > -1 Then
                valor = getBit(ComboBoxPorta.SelectedItem, ComboBoxBit.SelectedItem)
            Else
                valor = dados(ComboBoxPorta.SelectedItem)
            End If
        End If
    End Sub

    Private Sub TextBoxValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValor.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Function getStatusAlarme()
        checarAlarme()
        Return statusAlarme
    End Function
End Class
