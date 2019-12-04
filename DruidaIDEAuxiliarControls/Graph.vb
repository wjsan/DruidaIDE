Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graph
    Inherits Chart

    Private Pens As New List(Of Pen)
    Private mySource As MyProtocols.BqBus

    Public Property GraphSize As UInt16 = 1000
    Public Property limMax As Int16 = 1023
    Public Property limMin As Int16 = 0

    Public Sub New()
        Me.ChartAreas.Add(New ChartArea)
    End Sub

    Public Sub New(source As MyProtocols.BqBus)
        mySource = source
        Me.ChartAreas.Add(New ChartArea)
    End Sub

    Public Sub CreateWindow()
        Dim newForm As New Form()
        newForm.Show()
        newForm.Text = "GrphViewer - " & Pens(0).Name
        newForm.Controls.Add(Me)
        newForm.TopMost = True
        newForm.Icon = My.Resources.plot
        Me.Dock = DockStyle.Fill
        Me.Show
    End Sub

    Public Sub addPen(pen As Pen)
        Pens.Add(pen)
        Series.Add(pen)
        pen.ChartArea = Me.ChartAreas(0).Name
    End Sub

    Public Sub UpdatePens()
        Static Dim cont = 0
        For Each pen In Pens
            pen.Points.AddXY(cont, readPen(pen))
            cont += 1
            If cont > GraphSize Then
                pen.Points.RemoveAt(0)
                Me.ChartAreas(0).AxisX.Minimum = cont - GraphSize
                Me.ChartAreas(0).AxisX.Maximum = cont
            End If
            Dim max = Me.ChartAreas(0).AxisY.Maximum
            Dim min = Me.ChartAreas(0).AxisY.Minimum
            If maxPenValue() > max And maxPenValue() <= limMax Then
                Me.ChartAreas(0).AxisY.Maximum = maxPenValue()
            End If
            If minPenValue() < min And minPenValue() >= limMin Then
                Me.ChartAreas(0).AxisY.Minimum = minPenValue()
            End If
            If min > limMin Then
                Me.ChartAreas(0).AxisY.Minimum = limMin
            End If
            If max > limMax Then
                Me.ChartAreas(0).AxisY.Maximum = limMax
            End If

        Next
    End Sub

    Private Function maxPenValue() As Int16
        Dim max As Int16 = readPen(Pens(0))
        Dim val As Int16
        For Each pen In Pens
            val = readPen(pen)
            If val > max Then max = val
        Next
        Return val
    End Function

    Private Function minPenValue() As Int16
        Dim min As Int16 = readPen(Pens(0))
        Dim val As Int16
        For Each pen In Pens
            val = readPen(pen)
            If val < min Then min = val
        Next
        Return val
    End Function

    Private Function readPen(pen As Pen)
        If pen.Bit = "" Then
            Dim val = mySource.GetReg(pen.Reg)
            Return val
        Else
            If mySource.GetRegBit(pen.Reg, pen.Bit) Then
                Return limMax * (2 / 3)
            Else
                Return limMin * (1 / 3)
            End If
        End If
    End Function

End Class

'Public maximumPoint As Int32
'Public minimumPoint As Int32
'Private pontosAmostrados = 100
'Dim cont = 0
'Public Sub AddPoints(ByVal points() As Double)
'    ChartControl.Series(0).Points.AddXY(cont, points(0))
'    ChartControl.Series(1).Points.AddXY(cont, points(1))
'    ChartControl.Series(2).Points.AddXY(cont, points(2))
'    cont += 1
'    If (cont > pontosAmostrados) Then
'        ChartControl.Series(0).Points.RemoveAt(0)
'        ChartControl.Series(1).Points.RemoveAt(0)
'        ChartControl.Series(2).Points.RemoveAt(0)
'        ChartControl.ChartAreas(0).AxisX.Minimum = cont - pontosAmostrados
'        ChartControl.ChartAreas(0).AxisX.Maximum = cont
'        If (variávelMaior(points) > ChartControl.ChartAreas(0).AxisY.Maximum And variávelMaior(points) <= maximumPoint) Then
'            ChartControl.ChartAreas(0).AxisY.Maximum = variávelMaior(points)
'        End If
'        If (variávelMenor(points) < ChartControl.ChartAreas(0).AxisY.Minimum And variávelMenor(points) >= minimumPoint) Then
'            ChartControl.ChartAreas(0).AxisY.Minimum = variávelMenor(points)
'        End If
'        If ChartControl.ChartAreas(0).AxisY.Minimum > minimumPoint Then
'            ChartControl.ChartAreas(0).AxisY.Minimum = minimumPoint
'        End If
'        If ChartControl.ChartAreas(0).AxisY.Maximum > maximumPoint Then
'            ChartControl.ChartAreas(0).AxisY.Maximum = maximumPoint
'        End If
'    End If
'End Sub

'Private Function variávelMaior(ByVal variaveis() As Double)
'    Dim comp = variaveis(0)
'    For Each var In variaveis
'        If var > comp Then comp = var
'    Next
'    Return (comp)
'End Function

'Private Function variávelMenor(ByVal variaveis() As Double)
'    Dim comp = variaveis(0)
'    For Each var In variaveis
'        If var < comp Then comp = var
'    Next
'    Return (comp)
'End Function

Public Class Pen
    Inherits Series

    'Private myGraph As Graph

    Public Property Reg As String
    Public Property Bit As String

    Public Sub New(name As String, color As Color, reg As String, bit As String)
        Me.Name = name
        Me.Color = color
        Me.Reg = reg
        Me.Bit = bit
        Me.ChartType = SeriesChartType.Line
        'myGraph = Graph
        'myGraph.addPen(Me)
    End Sub
End Class
