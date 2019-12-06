Module SaidaDigitalArduino
    'Arduino UNO'
    Public UNOportasSaida As New List(Of Byte)
    Public UNOintertravPorts(21, 5) As Byte
    Public UNOintertravValores(21, 5) As Int16
    Public UNOcomparacao(21, 5) As String
    Public UNOintertravHabilitado(21, 5) As Boolean
End Module
