Imports FastColoredTextBoxNS
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class MarkersManager
    Private myFCTB As CodeEditorForArduino

    Public Sub AssignRef(ByRef ftcb As CodeEditorForArduino)
        myFCTB = ftcb
    End Sub

    Public Sub markBackgroundLine(ByVal line As UInt16)
        TrimSelection()
        myFCTB.Parent.Focus()
        myFCTB(line).BackgroundBrush = Brushes.Pink
        myFCTB.Focus()
    End Sub

    Public Sub markBackgroundLineWithBrush(ByVal line As UInt16, brushToMark As Brush)
        TrimSelection()
        myFCTB.Parent.Focus()
        myFCTB(line).BackgroundBrush = brushToMark
        myFCTB.Focus()
    End Sub

    Private Sub TrimSelection()
        Dim sel = myFCTB.Selection
        sel.Normalize()

        While Char.IsWhiteSpace(sel.CharAfterStart) AndAlso sel.Start < sel.[End]
            sel.GoRight(True)
        End While

        sel.Inverse()

        While Char.IsWhiteSpace(sel.CharBeforeStart) AndAlso sel.Start > sel.[End]
            sel.GoLeft(True)
        End While
    End Sub

    Public Sub clearBrush(brushToclear As Brush)
        For i = 0 To myFCTB.Lines.Count - 1
            If myFCTB(i).BackgroundBrush Is brushToclear Then
                myFCTB(i).BackgroundBrush = Nothing
            End If
        Next
    End Sub

    Public Sub clearAll()
        'myFCTB.Selection.ClearStyle(YellowStyle, RedStyle, GreenStyle)
        myFCTB.Parent.Focus()
        For i = 0 To myFCTB.Lines.Count - 1
            myFCTB(i).BackgroundBrush = Nothing
        Next
        myFCTB.Focus()
    End Sub

    Public Function lastLineNumber()
        Return myFCTB.Lines.Count - 1
    End Function

    Private Sub fctb_PaintLine(ByVal sender As Object, ByVal e As PaintLineEventArgs)
        If e.LineIndex = myFCTB.Selection.Start.iLine Then
            Using brush = New LinearGradientBrush(New Rectangle(0, e.LineRect.Top, 15, 15), Color.LightPink, Color.Red, 45)
                e.Graphics.FillEllipse(brush, 0, e.LineRect.Top, 15, 15)
            End Using
        End If
    End Sub
End Class
