Module ProcedimentosGlobais
    Public Function GetLocal()
        If appProgrammingMethod = "Avançado" Then
            Return ComandoAvancado.PanelComando
        Else
            Return Comando.PanelComando
        End If
    End Function

    Public Function GetNumbers(Text As String) As String
        Dim i As Integer, j As String = ""
        For i = 1 To Len(Text)
            If Asc(Mid(Text, i, 1)) < 48 Or
               Asc(Mid(Text, i, 1)) > 57 Then
            Else
                j = j & Mid(Text, i, 1)
            End If
            GetNumbers = j
        Next
        Return 0
    End Function
End Module
