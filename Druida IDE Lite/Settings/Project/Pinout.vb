Public Class Pinout
    Public myData As New PinoutClass

    Public Event remove(item As Pinout)
    Public Event moveUp(item As Pinout)
    Public Event moveDown(item As Pinout)

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Public Sub New(locationX As String, locationY As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Location = New Point(locationX, locationY)
    End Sub

    Private Sub TbPin_TextChanged(sender As Object, e As EventArgs) Handles tbPin.TextChanged
        myData.pinNumber = tbPin.Text
    End Sub

    Private Sub TbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        myData.pinName = TextTreatment.OnlyLetters(tbName.Text)
        tbName.Text = TextTreatment.OnlyLetters(tbName.Text)
    End Sub

    Private Sub CbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        myData.pinType = cbType.SelectedItem
    End Sub

    Private Sub TbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        myData.pinDescriprion = tbDescription.Text
    End Sub

    Private Sub PbRemove_Click(sender As Object, e As EventArgs) Handles pbRemove.Click
        RaiseEvent remove(Me)
    End Sub

    Private Sub VsReorder_Scroll(sender As Object, e As ScrollEventArgs) Handles vsReorder.Scroll
        If e.NewValue < e.OldValue Then
            RaiseEvent moveUp(Me)
        End If
        If e.NewValue > e.OldValue Then
            RaiseEvent moveDown(Me)
        End If
        e.NewValue = e.OldValue
    End Sub

    Public Sub LoadPin()
        tbPin.Text = myData.pinNumber
        tbName.Text = myData.pinName
        cbType.SelectedItem = myData.pinType
        tbDescription.Text = myData.pinDescriprion
    End Sub

    Private Sub Pinout_Load(sender As Object, e As EventArgs) Handles Me.Load
        IDEcfgs.ApplyThemeInControlGroup(Me)
    End Sub
End Class

Public Class PinoutClass

    Public Property pinNumber As String
    Public Property pinName As String
    Public Property pinType As String
    Public Property pinDescriprion As String

    Public Function getPinDefinition() As String
        Dim text As String = ""
        text += "#define " & pinName & " " & pinNumber & vbTab & "//" & pinDescriprion
        Return text
    End Function

    Public Function getPinSetup() As String
        Dim text As String = ""
        If pinType <> "Dados" And pinType <> "Data" Then
            text = "    pinMode(" & pinName & ", " & pinType & ");" & vbCrLf
        End If
        Return text
    End Function
End Class
