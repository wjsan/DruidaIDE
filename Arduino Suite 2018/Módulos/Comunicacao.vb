Module Comunicacao
    Public dadoRecebido = False
    Public serialPortAvailable = False
    Public portaAberta = False
    Public leituraRede As String = ""
    Public comandoRede As String = ""
    Public erroRede As Boolean = True
    Public descartaDados As Integer = -1
    Public descartaLeitura As Boolean

    Public iniciaLeituraEstados As Boolean = False
    Public leituraEstados As String = ""
    Public dadoLido As Boolean = False
    Public dados() As String
    Public dadosAnteriores() As String
    Public valorAnterior() As String
    Public estadosWord0 As String = ""
    Public estadosWord1 As String = ""
    Public estadosWord2 As String = ""
    Public estadosWord3 As String = ""
    Public estadosWord4 As String = ""
    Public estados As String = ""
    Public analogicas(8) As String
    Public pwm(20) As String

    Public Sub interpretaSinais()
        If (arduinoType = 0 Or arduinoType = 1) Then
            estadosWord0 = Convert.ToString(CUInt(dados(10)), 2).PadLeft(16, "0")
            estadosWord1 = Convert.ToString(CUInt(dados(11)), 2).PadLeft(16, "0")
            analogicas(0) = dados(12)
            analogicas(1) = dados(13)
            analogicas(2) = dados(14)
            analogicas(3) = dados(15)
            analogicas(4) = dados(16)
            analogicas(5) = dados(17)
            analogicas(6) = dados(18)
            analogicas(7) = dados(19)
            pwm(0) = dados(20)
            pwm(1) = dados(21)
            pwm(2) = dados(22)
            pwm(3) = dados(23)
            pwm(4) = dados(24)
            pwm(5) = dados(25)
        End If
        If (arduinoType = 2) Then
            estadosWord0 = Convert.ToString(CUInt(dados(10)), 2).PadLeft(16, "0")
            estadosWord1 = Convert.ToString(CUInt(dados(11)), 2).PadLeft(16, "0")
            analogicas(0) = dados(12)
            analogicas(1) = dados(13)
            analogicas(2) = dados(14)
            analogicas(3) = dados(15)
            analogicas(4) = dados(16)
            analogicas(5) = dados(17)
            analogicas(6) = dados(18)
            analogicas(7) = dados(19)
            pwm(0) = dados(20)
            pwm(1) = dados(21)
            pwm(2) = dados(22)
            pwm(3) = dados(23)
            pwm(4) = dados(24)
            pwm(5) = dados(25)
        End If
        estados = StrReverse(estadosWord0) + StrReverse(estadosWord1) + StrReverse(estadosWord2) + StrReverse(estadosWord3) + StrReverse(estadosWord4)
    End Sub

    Public Function getComando()
        Dim comando As String = ""
        If dados IsNot Nothing Then
            If dados.Count < 10 Then
                Return ("0")
                Exit Function
            End If
            For i = 0 To 10
                Dim c = dados(i)
                comando &= c
                If i < 10 Then
                    comando &= "."
                Else
                    comando &= "_"
                End If
            Next
        End If
        Return (comando)
    End Function

    Public Sub comunica()
        Dim str As String = ""
        If dados Is Nothing Then
            monitorSerialWrite("_")
            Exit Sub
        End If
        For i = 0 To dados.Length - 1
            Dim item = dados(i)
            If i < dados.Length - 1 Then
                str &= item
                str &= "."
            End If
        Next
        str &= "_"
        monitorSerialWrite(str)
    End Sub
End Module
