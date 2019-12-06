Public Module Variáveis
    Public listaEntradas As New List(Of String)
    Public listaSaidas As New List(Of String)
    Public listaEntradasAnalogicas As New List(Of Byte)
    Public listaPWMs As New List(Of Byte)
    'Public enderecoSaidas As UInt16 = 0
    'Public enderecoEntradas As UInt16 = 0
    'Public enderecoEntradasAnalogicas As UInt16 = 0
    'Obtém a lista das entradas que foram previamente configuradas
    Public Sub getListaEntradas()
        listaEntradas.Clear()
        For i As Int16 = 0 To 15
            If (getEntradasWord0(i) = "1" Or getPullUpsWord0(i) = "1") Then
                listaEntradas.Add(i + 2)
            End If
        Next
        For i As Int16 = 0 To 15
            If (getEntradasWord1(i) = "1" Or getPullUpsWord1(i) = "1") Then
                listaEntradas.Add(i + 2 + 16)
            End If
        Next
        For i As Int16 = 0 To 15
            If (getEntradasWord2(i) = "1" Or getPullUpsWord2(i) = "1") Then
                listaEntradas.Add(i + 2 + 16 + 16)
            End If
        Next
        For i As Int16 = 0 To 15
            If (getEntradasWord3(i) = "1" Or getPullUpsWord3(i) = "1") Then
                listaEntradas.Add(i + 2 + 16 + 16 + 16)
            End If
        Next
        For i As Int16 = 0 To 3
            If (getEntradasWord4(i) = "1" Or getPullUpsWord4(i) = "1") Then
                listaEntradas.Add(i + 2 + 16 + 16 + 16 + 16)
            End If
        Next
    End Sub
    'Obtém a lista das saídas que foram previamente configuradas
    Public Sub getListaSaidas()
        listaSaidas.Clear()
        For i As Int16 = 0 To 15
            If (getSaidasWord0(i) = "1" Or getSaidasRWord0(i) = "1") Then
                listaSaidas.Add(i + 2)
            End If
        Next
        For i As Int16 = 0 To 15
            If (getSaidasWord1(i) = "1" Or getSaidasRWord1(i) = "1") Then
                listaSaidas.Add(i + 2 + 16)
            End If
        Next
        For i As Int16 = 0 To 15
            If (getSaidasWord2(i) = "1" Or getSaidasRWord2(i) = "1") Then
                listaSaidas.Add(i + 2 + 16 + 16)
            End If
        Next
        For i As Int16 = 0 To 15
            If (getSaidasWord3(i) = "1" Or getSaidasRWord3(i) = "1") Then
                listaSaidas.Add(i + 2 + 16 + 16 + 16)
            End If
        Next
        For i As Int16 = 0 To 3
            If (getSaidasWord4(i) = "1" Or getSaidasRWord4(i) = "1") Then
                listaSaidas.Add(i + 2 + 16 + 16 + 16 + 16)
            End If
        Next
    End Sub
    'Obtém a lista das entradas analógicas que foram previamente configuradas
    Public Sub getListaEntradasAnalogicas()
        listaEntradasAnalogicas.Clear()
        If (arduinoConfig = 0 Or arduinoConfig = 1) Then
            For i = 12 To 15
                If (getEntradasWord0(i) = "1") Then
                    listaEntradasAnalogicas.Add(i - 12)
                End If
            Next
        End If
        If (arduinoConfig = 0) Then
            For i = 0 To 3
                If (getEntradasWord1(i) = "1") Then
                    listaEntradasAnalogicas.Add(i + 4)
                End If
            Next
        End If
        If (arduinoConfig = 1) Then
            For i = 0 To 1
                If (getEntradasWord1(i) = "1") Then
                    listaEntradasAnalogicas.Add(i + 4)
                End If
            Next
        End If
        If (arduinoConfig = 2) Then
            For i = 4 To 15
                If (getEntradasWord3(i) = "1") Then
                    listaEntradasAnalogicas.Add(i - 4)
                End If
            Next
            For i As Int16 = 0 To 3
                If (getEntradasWord4(i) = "1") Then
                    listaEntradasAnalogicas.Add(i + 12)
                End If
            Next
        End If
    End Sub
    'Obtém a lista de saídas analógicas que foram previamente configuradas
    Public Sub getListaPWMs()
        listaPWMs.Clear()
        For i As Int16 = 0 To 14
            If (getPWMWord0(i) = "1") Then
                listaPWMs.Add(i + 2)
            End If
        Next
    End Sub
End Module
