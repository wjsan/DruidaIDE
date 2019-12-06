Public Class EstruturaControleHardware
    Public id As UInt16 ' = 0
    Public tipo As String ' = "Indefinido"
    Public rotulo As Boolean '= True
    Public rotuloColor As Color '= Color.Blue
    Public rotuloText As String ' = "Controle"
    Public porta(3) As String ' =
    Public tipVisivel As Boolean ' = True
    Public canMove As Boolean = True
    Public local As New Point ' '(0, 0)
    Public tamanho As New Size '(133, 206)
    Public backgroundColor As Color ' = Color.WhiteSmoke
    Public borda As String ' = "Fixed"
    Public trackBar As Boolean ' ' = True
    Public trackBarOrientation As Orientation ' = Orientation.Horizontal
    Public trackBarDirection As String ' = "Left"
    Public trackBarLocation As New Point
    Public trackBarSize As New Size
    Public pictureLocation As New Point '(42, 59)
    Public pictureSize As New Size '(88, 89)
    Public imagens() As String = {greenLedOff, greenLedOn, redLedOn}
    Public barGraph As Boolean ' = True
    Public barGraphOrientation As String ' = "Horizontal"
    Public barGraphLocation As New Point
    Public barGraphMaxSize As New Size
    Public barGraphColor As Color ' = Color.LimeGreen
    Public analogValor As Boolean ' = True
    Public analogValorLocation As New Point
    Public textValorLocation As New Point
    Public textValorValue As String = ""
    Public scaleMax As Int32
    Public scaleMin As Int32
    Public unit As String
    Public button1 As Boolean = True
    Public button1Location As New Point
    Public button1Size As New Size
    Public button1Text As String ' = "Liga"
    Public button2 As Boolean ' = True
    Public button2Location As New Point
    Public button2Size As New Size
    Public button2Text As String ' = "Desliga"
    Public buttonMode As String ' = "on/off,ret,pls"
    Public hotKey As String ' = ""
    Public joyKey As String ' = ""
    Public editMode As Boolean ' = False
    Public startPath As Boolean = False
    Public gatilho As String = "nenhum,nenhum,nenhum"

    Private Sub getReg()
        If porta(0) Is Nothing Or porta(0) = "" Then
            If tipo = "Registrador <Bit>" Then
                getRegBitAddres()
            ElseIf tipo = "Entrada Registrador-32Bits" Or tipo = "Saída Registrador-32Bits" Or tipo = "TextBox" Then
                getRegIntAddress()
            ElseIf tipo = "Gráfico" Then
                getRegsGrafico()
            End If
        Else
            If tipo = "Registrador <Bit>" Then
                BitAddRegInt(porta(0) & "." & porta(1))
                BitAddRegInt(porta(0))
            Else
                AddRegInt(porta(0))
            End If
        End If
    End Sub

    Private Sub getRegIntAddress()
        For i = 0 To 256
            If Not RegsInUse.Contains(i.ToString) And Not BitRegsInUse.Contains(i.ToString) Then
                porta(0) = i.ToString
                AddRegInt(i.ToString)
                Exit Sub
            End If
        Next
        MessageBox.Show("Todos os registradores estão em uso")
    End Sub

    Private Sub getRegsGrafico()
        For i = 0 To 256
            If Not RegsInUse.Contains(i.ToString) And Not BitRegsInUse.Contains(i.ToString) Then
                porta(0) = i.ToString
                AddRegInt(i.ToString)
                Exit For
            End If
        Next
        For i = 0 To 256
            If Not RegsInUse.Contains(i.ToString) And Not BitRegsInUse.Contains(i.ToString) Then
                porta(1) = i.ToString
                AddRegInt(i.ToString)
                Exit For
            End If
        Next
        For i = 0 To 256
            If Not RegsInUse.Contains(i.ToString) And Not BitRegsInUse.Contains(i.ToString) Then
                porta(2) = i.ToString
                AddRegInt(i.ToString)
                Exit Sub
            End If
        Next
        MessageBox.Show("Todos os registradores estão em uso")
    End Sub

    Public Sub AddRegInt(valor As String)
        If Not RegsInUse.Contains(valor) Then
            RegsInUse.Add(valor)
        End If
    End Sub

    Public Sub BitAddRegInt(valor As String)
        If Not BitRegsInUse.Contains(valor) Then
            BitRegsInUse.Add(valor)
        End If
    End Sub

    Private Sub verificaNome()
        If tipo = "Rótulo" Then Exit Sub
        If tipo = "Câmera IP" Then Exit Sub
        If porta(0) Is Nothing Or porta(0) = "" Then
            If ControlNames.Contains(rotuloText) Then
                Dim cont As UInt16 = 1
                While ControlNames.Contains(rotuloText & " " & cont)
                    Try
                        cont += 1
                    Catch ex As Exception
                        MessageBox.Show("O nome do controle já esta em uso.")
                    End Try
                End While
                rotuloText = rotuloText & " " & cont
                AddControlName(rotuloText)
            Else
                AddControlName(rotuloText)
            End If
        End If
    End Sub

    Public Sub AddControlName(valor As String)
        If Not ControlNames.Contains(valor) Then
            ControlNames.Add(valor)
        End If
    End Sub

    Private Sub getRegBitAddres()
        For i = 0 To 256
            If Not RegsInUse.Contains(i.ToString) Then
                For j = 0 To 15
                    If Not BitRegsInUse.Contains(i.ToString & "." & j) Then
                        porta(0) = i.ToString
                        porta(1) = j.ToString
                        BitAddRegInt(i.ToString)
                        BitAddRegInt(i.ToString & "." & j)
                        Exit Sub
                    End If
                Next
            End If
        Next
        MessageBox.Show("Todos os registradores estão em uso")
    End Sub

    'Desenha a estrutura do controle na tela
    Public Sub updateControl(ByRef inf As ControleHardware)
        If appProgrammingMethod = "Avançado" And Not editMode Then
            verificaNome()
            getReg()
        End If
        drawWindow(inf)
        formatControl(inf)
        drawItensControl(inf)
    End Sub

    Public Sub updateInterface(ByRef inf As ControleInterface)
        drawWindow(inf)
        formatInterface(inf)
        drawItensInterface(inf)
    End Sub

    Public Sub drawWindow(ByRef inf As Object)
        With inf
            .Location = local
            .Size = tamanho
            .BackColor = backgroundColor
            If IsNumeric(borda) Then
                .Anchor = borda
            End If
        End With
    End Sub

    Public Sub formatControl(ByRef inf As ControleHardware)
        With inf
            .LabelRotulo.Visible = rotulo
            .TrackBarSaidaAnalogica.Visible = trackBar
            .BarraGrafica.Visible = barGraph
            .LabelValor.Visible = analogValor
            .TextBoxValor.Visible = analogValor
            .Button1.Visible = button1
            .Button2.Visible = button2
            .TextBoxValor.Visible = analogValor
        End With
    End Sub

    Public Sub formatInterface(ByRef inf As ControleInterface)
        With inf
            .LabelRotulo.Visible = rotulo
            .TrackBarSaidaAnalogica.Visible = trackBar
            .BarraGrafica.Visible = barGraph
            .LabelValor.Visible = analogValor
            .TextBoxValor.Visible = analogValor
            .Button1.Visible = button1
            .Button2.Visible = button2
            .TextBoxValor.Visible = analogValor
        End With
    End Sub

    Public Sub drawItensControl(ByRef inf As ControleHardware)
        With inf
            If (rotulo) Then
                .LabelRotulo.BackColor = rotuloColor
                .LabelRotulo.Text = rotuloText
            End If
            If (trackBar) Then
                .TrackBarSaidaAnalogica.Orientation = trackBarOrientation
                .TrackBarSaidaAnalogica.Size = trackBarSize
                .TrackBarSaidaAnalogica.Location = trackBarLocation
                .TrackBarSaidaAnalogica.Maximum = scaleMax
                .TrackBarSaidaAnalogica.Minimum = scaleMin
            End If
            If (tipo <> "Câmera IP" And tipo <> "Botão de Comando") Then
                Try
                    .PictureBoxStatus.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagens\" & imagens(0))
                Catch ex As Exception
                    MessageBox.Show("Falha ao carregar imagem do componente: " & .LabelRotulo.Text & " Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                .PictureBoxStatus.Location = pictureLocation
                .PictureBoxStatus.Size = pictureSize
            End If
            If (barGraph) Then
                .BarraGrafica.BackColor = barGraphColor
                .BarraGrafica.Location = barGraphLocation
                .BarraGrafica.Size = barGraphMaxSize
            End If
            If (analogValor) Then
                .LabelValor.Location = analogValorLocation
                .TextBoxValor.Location = textValorLocation
                .TextBoxValor.Text = textValorValue
            End If
            If (button1) Then
                .Button1.Location = button1Location
                .Button1.Size = button1Size
                .Button1.Text = button1Text
            End If
            If (button2) Then
                .Button2.Location = button2Location
                .Button2.Size = button2Size
                .Button2.Text = button2Text
            End If
        End With
    End Sub

    Public Sub drawItensInterface(ByRef inf As ControleInterface)
        With inf
            If (rotulo) Then
                .LabelRotulo.BackColor = rotuloColor
                .LabelRotulo.Text = rotuloText
            End If
            If (trackBar) Then
                .TrackBarSaidaAnalogica.Orientation = trackBarOrientation
                .TrackBarSaidaAnalogica.Size = trackBarSize
                .TrackBarSaidaAnalogica.Location = trackBarLocation
                .TrackBarSaidaAnalogica.Maximum = scaleMax
                .TrackBarSaidaAnalogica.Minimum = scaleMin
            End If
            If (tipo <> "Câmera IP" And tipo <> "Botão de Comando") Then
                .PictureBoxStatus.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagens\" & imagens(0))
                .PictureBoxStatus.Location = pictureLocation
                .PictureBoxStatus.Size = pictureSize
            End If
            If (barGraph) Then
                .BarraGrafica.BackColor = barGraphColor
                .BarraGrafica.Location = barGraphLocation
                .BarraGrafica.Size = barGraphMaxSize
            End If
            If (analogValor) Then
                .LabelValor.Location = analogValorLocation
                .TextBoxValor.Location = textValorLocation
                .TextBoxValor.Text = textValorValue
            End If
            If (button1) Then
                .Button1.Location = button1Location
                .Button1.Size = button1Size
                .Button1.Text = button1Text
            End If
            If (button2) Then
                .Button2.Location = button2Location
                .Button2.Size = button2Size
                .Button2.Text = button2Text
            End If
        End With
    End Sub

    Public Function getInfo()
        Dim info As String = ""
        Dim dados() As String = {
        id,
        tipo,
        rotulo,
        rotuloColor.Name,
        rotuloText,
        porta(0),
        porta(1),
        porta(2),
        tipVisivel,
        canMove,
        local.ToString,
        tamanho.ToString,
        backgroundColor.Name,
        borda,
        trackBar,
        trackBarOrientation,
        trackBarDirection,
        trackBarLocation.ToString,
        trackBarSize.ToString,
        pictureLocation.ToString,
        pictureSize.ToString,
        imagens(0),
        imagens(1),
        imagens(2),
        barGraph,
        barGraphOrientation,
        barGraphLocation.ToString,
        barGraphMaxSize.ToString,
        barGraphColor.Name,
        analogValor,
        analogValorLocation.ToString,
        textValorLocation.ToString,
        scaleMin,
        scaleMax,
        unit,
        button1,
        button1Location.ToString,
        button1Size.ToString,
        button1Text,
        button2,
        button2Location.ToString,
        button2Size.ToString,
        button2Text,
        buttonMode,
        hotKey,
        joyKey,
        textValorValue,
        gatilho}
        For Each line In dados
            If line = vbCrLf Then line = ""
            info = info & line & "_"
        Next
        info = info & vbCrLf
        Return (info)
    End Function

    Public Sub saveData(ByVal path As String)
        System.IO.File.AppendAllText(path, getInfo)
    End Sub

    Public Sub loadDataFromFile(ByVal path As String)
        Try
            Dim dados As String = System.IO.File.ReadAllText(path)
            loadFromString(dados)
        Catch ex As Exception
            Druida_IDE_Lite.DruidaInterface.AddErrorMsg(ex.Message, Druida_IDE_Lite.ErrorsManager.Type.msgError)
        End Try
    End Sub

    Public Sub loadFromString(ByVal dados As String)
        Dim data() As String = dados.Split("_")
        For Each item As String In data
            If item = vbCrLf Then item = ""
        Next
        id = data(0)
        tipo = data(1)
        rotulo = data(2)
        rotuloColor = Color.FromName(data(3))
        rotuloText = data(4)
        porta(0) = data(5)
        porta(1) = data(6)
        porta(2) = data(7)
        tipVisivel = data(8)
        canMove = data(9)
        local = ConvertStringToPoint(data(10))
        tamanho = ConvertStringToSize(data(11))
        backgroundColor = Color.FromName(data(12))
        borda = data(13)
        trackBar = data(14)
        trackBarOrientation = data(15)
        trackBarDirection = data(16)
        trackBarLocation = ConvertStringToPoint(data(17))
        trackBarSize = ConvertStringToSize(data(18))
        pictureLocation = ConvertStringToPoint(data(19))
        pictureSize = ConvertStringToSize(data(20))
        imagens(0) = data(21)
        imagens(1) = data(22)
        imagens(2) = data(23)
        barGraph = data(24)
        barGraphOrientation = data(25)
        barGraphLocation = ConvertStringToPoint(data(26))
        barGraphMaxSize = ConvertStringToSize(data(27))
        barGraphColor = Color.FromName(data(28))
        analogValor = data(29)
        analogValorLocation = ConvertStringToPoint(data(30))
        textValorLocation = ConvertStringToPoint(data(31))
        scaleMin = data(32)
        scaleMax = data(33)
        unit = data(34)
        button1 = data(35)
        button1Location = ConvertStringToPoint(data(36))
        button1Size = ConvertStringToSize(data(37))
        button1Text = (data(38))
        button2 = data(39)
        button2Location = ConvertStringToPoint(data(40))
        button2Size = ConvertStringToSize(data(41))
        button2Text = data(42)
        buttonMode = data(43)
        hotKey = data(44)
        joyKey = data(45)
        textValorValue = data(46)
        gatilho = data(47)
    End Sub

    Public Sub UpdateDataFromControlData(ByRef data As EstruturaControleHardware)
        startPath = data.startPath
        id = data.id
        tipo = data.tipo
        rotulo = data.rotulo
        rotuloColor = data.rotuloColor
        rotuloText = data.rotuloText
        porta(0) = data.porta(0)
        porta(1) = data.porta(1)
        porta(2) = data.porta(2)
        tipVisivel = data.tipVisivel
        canMove = data.canMove
        local = data.local
        tamanho = data.tamanho
        backgroundColor = data.backgroundColor
        borda = data.borda
        trackBar = data.trackBar
        trackBarOrientation = data.trackBarOrientation
        trackBarDirection = data.trackBarDirection
        trackBarSize = data.trackBarSize
        trackBarLocation = data.trackBarLocation
        pictureLocation = data.pictureLocation
        pictureSize = data.pictureSize
        imagens(0) = data.imagens(0)
        imagens(1) = data.imagens(1)
        imagens(2) = data.imagens(2)
        barGraph = data.barGraph
        barGraphOrientation = data.barGraphOrientation
        barGraphLocation = data.barGraphLocation
        barGraphMaxSize = data.barGraphMaxSize
        barGraphColor = data.barGraphColor
        analogValor = data.analogValor
        analogValorLocation = data.analogValorLocation
        textValorLocation = data.textValorLocation
        scaleMin = data.scaleMin
        scaleMax = data.scaleMax
        unit = data.unit
        button1 = data.button1
        button1Location = data.button1Location
        button1Size = data.button1Size
        button1Text = data.button1Text
        button2 = data.button2
        button2Location = data.button2Location
        button2Size = data.button2Size
        button2Text = data.button2Text
        buttonMode = data.buttonMode
        hotKey = data.hotKey
        joyKey = data.joyKey
        textValorValue = data.textValorValue
        gatilho = data.gatilho
    End Sub

    Sub updateDataFromControl(ByRef controle As ControleHardware)
        tipo = controle.engine.tipo
        borda = controle.Anchor
        rotulo = controle.LabelRotulo.Visible
        rotuloColor = controle.LabelRotulo.BackColor
        rotuloText = controle.LabelRotulo.Text
        porta(0) = controle.engine.porta(0)
        porta(1) = controle.engine.porta(1)
        porta(2) = controle.engine.porta(2)
        tipVisivel = controle.ToolTipInfoPorta.Active
        local = controle.Location
        tamanho = controle.Size
        backgroundColor = controle.BackColor
        trackBar = controle.TrackBarSaidaAnalogica.Visible
        trackBarOrientation = controle.TrackBarSaidaAnalogica.Orientation
        trackBarSize = controle.engine.trackBarSize
        trackBarLocation = controle.TrackBarSaidaAnalogica.Location
        pictureLocation = controle.PictureBoxStatus.Location
        pictureSize = controle.PictureBoxStatus.Size
        imagens(0) = controle.engine.imagens(0)
        imagens(1) = controle.engine.imagens(1)
        imagens(2) = controle.engine.imagens(2)
        barGraph = controle.BarraGrafica.Visible
        barGraphLocation = controle.BarraGrafica.Location
        barGraphColor = controle.BarraGrafica.BackColor
        barGraphMaxSize = controle.engine.barGraphMaxSize
        barGraphOrientation = controle.engine.barGraphOrientation
        analogValor = controle.LabelValor.Visible
        analogValorLocation = controle.LabelValor.Location
        textValorLocation = controle.TextBoxValor.Location
        scaleMin = controle.engine.scaleMin
        scaleMax = controle.engine.scaleMax
        unit = controle.engine.unit
        button1 = controle.Button1.Visible
        button1Location = controle.Button1.Location
        button1Size = controle.Button1.Size
        button1Text = controle.Button1.Text
        button2 = controle.Button2.Visible
        button2Location = controle.Button2.Location
        button2Size = controle.Button2.Size
        button2Text = controle.Button2.Text
        buttonMode = controle.engine.buttonMode
        textValorValue = controle.TextBoxValor.Text
        gatilho = controle.engine.gatilho
    End Sub

    Public Function ConvertStringToPoint(stringPoint As String)
        Dim valorPonto = Replace(stringPoint, "{X=", "", vbTextCompare)
        valorPonto = Replace(valorPonto, "Y=", "", vbTextCompare)
        valorPonto = Replace(valorPonto, "}", "", vbTextCompare)
        Dim ponto As New Point(valorPonto.Split(",")(0), valorPonto.Split(",")(1))
        Return (ponto)
    End Function

    Public Function ConvertStringToSize(stringPoint As String)
        Dim valorPonto = Replace(stringPoint, "{Width=", "", vbTextCompare)
        valorPonto = Replace(valorPonto, "Height=", "", vbTextCompare)
        valorPonto = Replace(valorPonto, "}", "", vbTextCompare)
        Dim size As New Size(valorPonto.Split(",")(0), valorPonto.Split(",")(1))
        Return (size)
    End Function

    Public Sub AjustaTamX(ByRef controle As Control, ByRef newSize As String)
        If (newSize <> "") Then
            Try
                If (newSize >= 1) Then
                    controle.Width = newSize
                    salvaPosicao(controle)
                End If
            Catch ex As Exception
                MessageBox.Show("O formato digitado é invalido", "Erro", MessageBoxButtons.OK)
                newSize = controle.Width
            End Try
        End If
    End Sub

    Public Sub AjustaTamY(ByRef controle As Control, ByRef newSize As String)
        If (newSize <> "") Then
            Try
                If (newSize >= 1) Then
                    controle.Height = newSize
                    salvaPosicao(controle)
                End If
            Catch ex As Exception
                MessageBox.Show("O formato digitado é invalido", "Erro", MessageBoxButtons.OK)
                newSize = controle.Height
            End Try
        End If
    End Sub

    Public Sub AjustaPosX(ByRef controle As Control, ByRef newPos As String)
        If (newPos <> "") Then
            Try
                If (newPos >= 0) Then
                    Dim novoX As Integer = newPos
                    Dim ponto As New Point(novoX, controle.Location.Y)
                    controle.Location = ponto
                    salvaPosicao(controle)
                End If
            Catch ex As Exception
                MessageBox.Show("O formato digitado é invalido", "Erro", MessageBoxButtons.OK)
                newPos = controle.Location.X
            End Try
        End If
    End Sub

    Public Sub AjustaPosY(ByRef controle As Control, ByRef newPos As String)
        If (newPos <> "") Then
            Try
                If (newPos >= 0) Then
                    Dim novoY As Integer = newPos
                    Dim ponto As New Point(controle.Location.X, novoY)
                    controle.Location = ponto
                    salvaPosicao(controle)
                End If
            Catch ex As Exception
                MessageBox.Show("O formato digitado é invalido", "Erro", MessageBoxButtons.OK)
                newPos = controle.Location.Y
            End Try
        End If
    End Sub

    Public Sub Move(ByRef controle As Control, e As EventArgs, menu As ContextMenuStrip)
        menu.Enabled = userIsAdmin
        If (userIsAdmin) Then
            If (canMove) Then
                OBJ_Resize.ResizeOBJ(controle, e, controle.FindForm.Parent)
                salvaPosicao(controle)
            End If
        End If
    End Sub

    Public Sub salvaPosicao(ByVal controle As Control)
        tamanho = controle.Size
        local = controle.Location
    End Sub

    Public Sub salvaGraficos(ByVal controle As ControleHardware)
        With controle
            pictureLocation = .PictureBoxStatus.Location
            pictureSize = .PictureBoxStatus.Size
            trackBarLocation = .TrackBarSaidaAnalogica.Location
            trackBarOrientation = .TrackBarSaidaAnalogica.Orientation
            trackBarSize = .TrackBarSaidaAnalogica.Size
            barGraphLocation = .BarraGrafica.Location
            barGraphMaxSize = .BarraGrafica.Size
            textValorLocation = .TextBoxValor.Location
            analogValorLocation = .LabelValor.Location
        End With
    End Sub

    Public Sub bloquearControle(ByRef menuItem As ToolStripMenuItem)
        If (canMove) Then
            menuItem.Text = "Desbloquear Controle"
            menuItem.Image = ArduinoSuite.My.Resources.Resources.lock_flat
            canMove = False
        Else
            menuItem.Text = "Bloquear Controle"
            menuItem.Image = ArduinoSuite.My.Resources.Resources.unlock_553_847794
            canMove = True
        End If
    End Sub

    Public Function setImageFile(titulo As String, index As UInt16)
        Dim openImage As New OpenFileDialog With {
            .Filter = "Imagens|*.png;*.jpg;*.bmp;*.gif",
            .InitialDirectory = My.Application.Info.DirectoryPath & "\Imagens\",
            .Title = titulo
        }
        openImage.Title = titulo
        If (openImage.ShowDialog() = DialogResult.OK) Then
            Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
            If Not openImage.FileName.Contains(path) Then
                Dim diag = MessageBox.Show("Os arquivos de imagem devem estar dentro da pasta: " & path & ". Deseja importar o arquivo selecionado para essa pasta?", "Importar nova imagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If diag = DialogResult.Yes Then
                    FileCopy(openImage.FileName, path & openImage.SafeFileName)
                    imagens(index) = openImage.SafeFileName
                    Return (path & openImage.SafeFileName)
                    Exit Function
                End If
            End If
            Dim newFileName As String = openImage.FileName.Replace(path, "")
            imagens(index) = newFileName
            Return (openImage.FileName)
        Else
            Dim path As String = My.Application.Info.DirectoryPath & "\Imagens\"
            Return (path & imagens(index))
        End If
    End Function
End Class
