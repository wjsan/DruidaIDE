Imports ArduinoSuite.Objects

Public Class ComboIcon
    Inherits ComboBox

    Private ListaImg1 As New ImageList

    Public Property ImageList() As ImageList
        Get
            Return ListaImg1
        End Get
        Set(ByVal ListaImagem As ImageList)
            ListaImg1 = ListaImagem
        End Set
    End Property

    Public Sub New()
        DrawMode = DrawMode.OwnerDrawFixed
    End Sub



    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        e.DrawBackground()
        e.DrawFocusRectangle()

        Dim item As New ComboBoxIconItem
        Dim imageSize As New Size
        imageSize = ListaImg1.ImageSize

        Dim bounds As New Rectangle
        bounds = e.Bounds

        If (e.Index <> -1) Then
            item = Me.Items(e.Index)
        Else
            e.Graphics.DrawString(Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
            MyBase.OnDrawItem(e)
            Exit Sub
        End If

        If Me.Items.Count - 1 >= e.Index Then
            If (item.ImageIndex <> -1) Then
                Me.ImageList.Draw(e.Graphics, bounds.Left, bounds.Top, item.ImageIndex)
                e.Graphics.DrawString(item.Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left + imageSize.Width, bounds.Top)
            Else
                e.Graphics.DrawString(item.Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
            End If
        Else
            If (e.Index <> -1) Then
                e.Graphics.DrawString(Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
            Else
                e.Graphics.DrawString(Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
            End If
        End If

        'Try
        '    item = Me.Items(e.Index)
        '    If (item.ImageIndex <> -1) Then
        '        Me.ImageList.Draw(e.Graphics, bounds.Left, bounds.Top, item.ImageIndex)
        '        e.Graphics.DrawString(item.Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left + imageSize.Width, bounds.Top)
        '    Else
        '        e.Graphics.DrawString(item.Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
        '    End If
        'Catch ex As Exception
        '    If (e.Index <> -1) Then
        '        e.Graphics.DrawString(Items(e.Index).ToString(), e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
        '    Else
        '        e.Graphics.DrawString(Text, e.Font, New SolidBrush(e.ForeColor), bounds.Left, bounds.Top)
        '    End If
        '    MessageBox.Show("Erro combo icon")
        'End Try
        MyBase.OnDrawItem(e)
    End Sub


End Class

Class ComboBoxIconItem

    Private _descr As String

    Public Property descr() As String
        Get
            Return _descr
        End Get
        Set(ByVal value As String)
            _descr = value
        End Set
    End Property

    Private _tag As String

    Public Property Tag() As String
        Get
            Return _tag
        End Get
        Set(ByVal value As String)
            _tag = value
        End Set
    End Property

    Private _text As String

    Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal Value As String)
            _text = Value
        End Set
    End Property

    Private _imageIndex As Integer

    Property ImageIndex() As Integer
        Get
            Return _imageIndex
        End Get

        Set(ByVal Value As Integer)
            _imageIndex = Value
        End Set
    End Property

    Public Sub New()
        _text = ""
    End Sub

    Public Sub New(ByVal text As String)
        _text = text
    End Sub

    Public Sub New(ByVal text As String, ByVal imageIndex As Integer)
        _text = text
        _imageIndex = imageIndex
    End Sub

    ''' <summary>
    ''' Cria um objeto do tipo comboIcon, podendo acrescentar uma informação a mais no mesmo (tag)
    ''' </summary>
    ''' <param name="text">Texto que irá aparecer no objeto</param>
    ''' <param name="imageIndex">Índice da lista de imagens, que deverá aparecer no objeto</param>
    ''' <param name="tag">Uma informação a mais que pode ser adicionada como você desejar ao objeto</param>

    Public Sub New(ByVal text As String, ByVal imageIndex As Integer, ByVal tag As String)
        _text = text
        _imageIndex = imageIndex
        _tag = tag
    End Sub

    Public Overrides Function ToString() As String
        Return _text
    End Function
End Class
