Imports System.ComponentModel

Public Class ConfigAlarmes
    'Dim myAlarms As New List(Of Alarme)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = applicationDirectory & "\Alarmes.alm"
        If (System.IO.File.Exists(path)) Then
            System.IO.File.Delete(path)
        End If
        listaAlarmes.Clear()
        For Each control In panelAlarms.Controls
            If control IsNot Alarme1 Then
                listaAlarmes.Add(control)
                control.SaveMe()
            End If
        Next
        DruidaSuiteMain.GetAlarmList()
        Me.Close()
    End Sub

    Private Sub ButtonCriar_Click(sender As Object, e As EventArgs) Handles ButtonCriar.Click
        Dim newAlarm As New Alarme
        numAlarme = 0
        CriarAlarme(newAlarm)
        Me.AutoScrollPosition = New Point(Me.Width, Me.Height)
    End Sub

    Private Sub ConfigAlarmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = applicationDirectory & "\Alarmes.alm"
        DruidaSuiteMain.openedForm = Me
        numAlarme = 0
        If (System.IO.File.Exists(path)) Then
            Dim dados() As String = System.IO.File.ReadAllLines(path)
            For Each line As String In dados
                Dim newAlarm As New Alarme
                newAlarm.LoadMe(line)
                CriarAlarme(newAlarm)
            Next
        End If
        If (Me.Height + numAlarme * 35) < 500 Then
            Me.Height = Me.Height + numAlarme * 35
        Else
            Me.Height = 500
        End If
        numAlarme = 0
    End Sub

    Private Sub CriarAlarme(ByRef newAlarm As Alarme)
        Dim i As UInt16 = panelAlarms.Controls.Count - 1
        Dim offset = If(i = 0, 0, Alarme1.Height)
        newAlarm.Location = New Point(panelAlarms.Controls(i).Location.X, panelAlarms.Controls(i).Location.Y + offset)
        AutoScroll = True
        panelAlarms.Controls.Add(newAlarm)
    End Sub

    Private Sub ConfigAlarmes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Button1_Click(sender, e)
    End Sub

    Private Sub RemoveAlarm(alarm As Alarme)
        panelAlarms.Controls.Remove(alarm)
        Reorganize()
    End Sub

    Private Sub Reorganize()
        panelAlarms.Controls(0).Location = Alarme1.Location
        Dim lastLocation As Point = Alarme1.Location
        Dim list = DirectCast(panelAlarms.Controls, IList)

        For i = 0 To list.Count - 1
            Dim control As Control = list(i)
            If control IsNot Alarme1 Then
                Dim offset = If(i = 1, 0, control.Height)
                control.Location = New Point(lastLocation.X, lastLocation.Y + offset)
                lastLocation = control.Location
            End If
        Next
    End Sub

    Private Sub PanelAlarms_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelAlarms.ControlAdded
        Dim alrm As Alarme = e.Control
        AddHandler alrm.remove, AddressOf RemoveAlarm
    End Sub

    Private Sub PanelAlarms_ControlRemoved(sender As Object, e As ControlEventArgs) Handles panelAlarms.ControlRemoved
        Dim alrm As Alarme = e.Control
        RemoveHandler alrm.remove, AddressOf RemoveAlarm
    End Sub

    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class