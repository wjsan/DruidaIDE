Public Class Grafico
    Public maximumPoint As Int32
    Public minimumPoint As Int32
    Private pontosAmostrados = 100
    Dim cont = 0
    Public Sub AddPoint(ByVal variáveis() As Double)
        ChartGrafico.Series(0).Points.AddXY(cont, variáveis(0))
        ChartGrafico.Series(1).Points.AddXY(cont, variáveis(1))
        ChartGrafico.Series(2).Points.AddXY(cont, variáveis(2))
        cont += 1
        If (cont > pontosAmostrados) Then
            ChartGrafico.Series(0).Points.RemoveAt(0)
            ChartGrafico.Series(1).Points.RemoveAt(0)
            ChartGrafico.Series(2).Points.RemoveAt(0)
            ChartGrafico.ChartAreas(0).AxisX.Minimum = cont - pontosAmostrados
            ChartGrafico.ChartAreas(0).AxisX.Maximum = cont
            If (variávelMaior(variáveis) > ChartGrafico.ChartAreas(0).AxisY.Maximum And variávelMaior(variáveis) <= maximumPoint) Then
                ChartGrafico.ChartAreas(0).AxisY.Maximum = variávelMaior(variáveis)
            End If
            If (variávelMenor(variáveis) < ChartGrafico.ChartAreas(0).AxisY.Minimum And variávelMenor(variáveis) >= minimumPoint) Then
                ChartGrafico.ChartAreas(0).AxisY.Minimum = variávelMenor(variáveis)
            End If
            If ChartGrafico.ChartAreas(0).AxisY.Minimum > minimumPoint Then
                ChartGrafico.ChartAreas(0).AxisY.Minimum = minimumPoint
            End If
            If ChartGrafico.ChartAreas(0).AxisY.Maximum > maximumPoint Then
                ChartGrafico.ChartAreas(0).AxisY.Maximum = maximumPoint
            End If
        End If
    End Sub

    Private Function variávelMaior(ByVal variaveis() As Double)
        Dim comp = variaveis(0)
        For Each var In variaveis
            If var > comp Then comp = var
        Next
        Return (comp)
    End Function

    Private Function variávelMenor(ByVal variaveis() As Double)
        Dim comp = variaveis(0)
        For Each var In variaveis
            If var < comp Then comp = var
        Next
        Return (comp)
    End Function

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        pontosAmostrados = 50
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        pontosAmostrados = 100
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        cont = 0
        pontosAmostrados = 150
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        cont = 0
        pontosAmostrados = 200
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        cont = 0
        pontosAmostrados = 250
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        cont = 0
        pontosAmostrados = 300
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        cont = 0
        pontosAmostrados = 400
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        cont = 0
        pontosAmostrados = 500
    End Sub
End Class
