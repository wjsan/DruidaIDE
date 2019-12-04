Public Class CustomToolTip

    Public Property ToolTipTitle() As String
        Get
            Return Título.Text
        End Get
        Set(ByVal value As String)
            Título.Text = value
        End Set
    End Property

    Public Property ToolTipIcon() As Image
        Get
            Return PictureBoxIcon.Image
        End Get
        Set(ByVal value As Image)
            PictureBoxIcon.Image = value
        End Set
    End Property

    Dim textoDescr As String = ""

    Public Sub setText(ByVal texto As String)
        LabelTexto.Text = texto
    End Sub

    Public Sub setType(ByVal index As Int16)
        Type.Text = getStrucType()
    End Sub

    Private Function getStrucType() As String
        If LabelTexto.Text.Contains("::") Then
            Dim tipo As String = LabelTexto.Text.Replace("@", "")
            tipo = tipo.Replace("::", "@")
            tipo = tipo.Split("@")(1)
            Return (tipo)
        End If
        Return ("void")
    End Function

    Private Sub CustomToolTip_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    End Sub

    Private Sub CustomToolTip_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Type_TextChanged(sender As Object, e As EventArgs) Handles Type.TextChanged
        Título.Location = New Point(34 + (Type.Text.Length * 6.3), 10)
    End Sub
End Class
