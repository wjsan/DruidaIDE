Public Class TaskButton

    Private Sub TaskButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaVisualComponente(Me)
    End Sub

    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

    Protected regionHandle As IntPtr

    Public Event TaskButtonClick()

    Public Sub carregaVisualComponente(ByVal componente As Object)
        regionHandle = New IntPtr(CreateRoundRectRgn(0, 0, componente.Width, componente.Height, 20, 20))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Private myForm As Form
    Public Property PictureItem() As Image
        Get
            Return PictureBoxItem.Image
        End Get
        Set(ByVal value As Image)
            PictureBoxItem.Image = value
        End Set
    End Property
    Public Property NomeItem() As String
        Get
            Return LabelNomeItem.Text
        End Get
        Set(ByVal value As String)
            LabelNomeItem.Text = value
        End Set
    End Property
    Public Property ActivateColor() As Color

    Private Sub ItemMenuInterativo_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, LabelNomeItem.MouseEnter, PictureBoxItem.MouseEnter
        BackgroundImage = My.Resources.Gradiente_Azul2
    End Sub

    Private Sub ItemMenuInterativo_MouseLeave(sender As Object, e As EventArgs) Handles LabelNomeItem.MouseLeave, PictureBoxItem.MouseLeave, Me.MouseLeave
        BackgroundImage = My.Resources.TaskBar
    End Sub

    Private Sub LabelNomeItem_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelNomeItem.MouseClick, PictureBoxItem.MouseClick, Me.MouseClick
        If e.Button = MouseButtons.Left Then
            DruidaSuiteMain.MenuInterativo.Hide()
            If myForm.GetType Is Druida_IDE_Lite.DruidaInterface.DruidaIDE.GetType And myForm.WindowState <> FormWindowState.Maximized Then
                myForm.WindowState = FormWindowState.Maximized
            End If
            myForm.BringToFront()
            For Each item In DruidaSuiteMain.Controls
                If item.GetType = Me.GetType Then
                    If item <> Me Then
                        BackgroundImage = My.Resources.TaskBar
                    End If
                End If
            Next
            If myForm.Parent IsNot DruidaSuiteMain.SplitContainerWindows.Panel1 And myForm.Parent IsNot DruidaSuiteMain.SplitContainerWindows.Panel2 Then
                If myForm IsNot DruidaSuiteMain.openedForm Then
                    DruidaSuiteMain.openedForm = myForm
                    DruidaSuiteMain.SplitContainerWindows.SendToBack()
                    myForm.BringToFront()
                    'Else
                    '    myForm.SendToBack()
                    '    TelaInicial.BringToFront()
                    '    ArduinoSuiteMain.openedForm = Nothing
                End If
            Else
                If DruidaSuiteMain.SplitContainerWindows.Panel1.Contains(DruidaSuiteMain.openedForm) Or DruidaSuiteMain.SplitContainerWindows.Panel2.Contains(DruidaSuiteMain.openedForm) Then
                    'ArduinoSuiteMain.SplitContainerWindows.SendToBack()
                    'TelaInicial.BringToFront()
                    'ArduinoSuiteMain.openedForm = Nothing
                Else
                    DruidaSuiteMain.openedForm = myForm
                    DruidaSuiteMain.SplitContainerWindows.BringToFront()
                    TelaInicial.SendToBack()
                End If
            End If
        End If
    End Sub

    Public Sub SetForm(ByRef formToSet As Form)
        myForm = formToSet
    End Sub

    Public Function GetForm()
        Return (myForm)
    End Function
End Class
