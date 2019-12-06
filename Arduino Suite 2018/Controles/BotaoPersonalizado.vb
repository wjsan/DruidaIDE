Imports System.Drawing.Drawing2D

Public Class BotaoPersonalizado

    Dim imagemSel As Image
    Dim imagemDef As Image

    Public Property Imagem() As Image
        Get
            Return PictureBox1.Image
        End Get
        Set(ByVal pic As Image)
            PictureBox1.Image = pic
        End Set
    End Property

    Public Property ImagemSelecao() As Image
        Get
            Return imagemSel
        End Get
        Set(ByVal pic As Image)
            imagemSel = pic
        End Set
    End Property

    Public Property ImagemDefault() As Image
        Get
            Return imagemDef
        End Get
        Set(ByVal pic As Image)
            imagemDef = pic
        End Set
    End Property

    Public Event ButtonClick()

    Private Sub BotaoPersonalizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArredondaCantos()
    End Sub

    Sub ArredondaCantos()

        Dim PastaGrafica As New GraphicsPath
        Dim rect As New Rectangle(1, 1, Me.Size.Width, Me.Size.Height)
        PastaGrafica.AddRectangle(rect)

        'Arredondar canto superior esquerdo
        Dim rES As New Rectangle(1, 1, 10, 10)
        PastaGrafica.AddRectangle(rES)
        PastaGrafica.AddPie(1, 1, 20, 20, 180, 90)

        'Arredondar canto superior direito
        'Dim rDS As New Rectangle(Me.Width - 12, 1, 12, 13)
        'PastaGrafica.AddRectangle(rDS)
        'PastaGrafica.AddPie(Me.Width - 24, 1, 24, 26, 270, 90)

        'Arredondar canto inferior esquerdo
        Dim rIE As New Rectangle(1, Me.Height - 10, 10, 10)
        PastaGrafica.AddRectangle(rIE)
        PastaGrafica.AddPie(1, Me.Height - 20, 20, 20, 90, 90)

        'Arredondar canto inferior direito
        'Dim rID As New Rectangle(Me.Width - 12, Me.Height - 13, 13, 13)
        'PastaGrafica.AddRectangle(rID)
        'PastaGrafica.AddPie(Me.Width - 24, Me.Height - 26, 24, 26, 0, 90)

        PastaGrafica.SetMarkers()
        Me.Region = New Region(PastaGrafica)
    End Sub
End Class
