Module GerenciamentoComando
    'TELA:
    Public telas As New List(Of String)
    Public telaAberta As Int16
    Public pathTela As String = ""
    Public pathEntradas As String = ""
    Public pathSaidas As String = ""
    Public pathEntradasAnalogicas As String = ""
    Dim fileControl As New FileVarSystem
    Dim fileTelas As New FileVarSystem

    Public Sub SalvarDados()
        SalvarComponentes()
        SalvarRecursos()
    End Sub

    Private Sub SalvarRecursos()
        Dim listaRegsInt As String = getItensAgregados(RegsInUse)
        Dim listaRegsBit As String = getItensAgregados(BitRegsInUse)
        Dim listaNomes As String = getItensAgregados(ControlNames)
        System.IO.Directory.CreateDirectory(applicationDirectory)
        fileResourcesList.SetFilePath(applicationDirectory & "\Resources.dat")
        fileResourcesList.SetVar("listaRegsInt", listaRegsInt)
        fileResourcesList.SetVar("listaRegsBit", listaRegsBit)
        fileResourcesList.SetVar("listaNomes", listaNomes)
    End Sub

    Public Sub CarregarRecursos()
        System.IO.Directory.CreateDirectory(applicationDirectory)
        fileResourcesList.SetFilePath(applicationDirectory & "\Resources.dat")
        Dim listaRegsInt As String = getItensAgregados(RegsInUse)
        Dim listaRegsBit As String = getItensAgregados(BitRegsInUse)
        Dim listaNomes As String = getItensAgregados(ControlNames)
        fileResourcesList.LoadVar("listaRegsInt", listaRegsInt)
        fileResourcesList.LoadVar("listaRegsBit", listaRegsBit)
        fileResourcesList.LoadVar("listaNomes", listaNomes)
        RegsInUse.AddRange(listaRegsInt.Split("_"))
        BitRegsInUse.AddRange(listaRegsBit.Split("_"))
        ControlNames.AddRange(listaNomes.Split("_"))
        RegsInUse.Remove("")
        BitRegsInUse.Remove("")
        ControlNames.Remove("")
    End Sub

    Private Function getItensAgregados(ByVal itens As List(Of String))
        Dim aux As String = ""
        For Each item In itens
            aux &= item & "_"
        Next
        Return aux
    End Function

    Public Sub SalvarConfigTela()
        fileTelas.SetFilePath(applicationDirectory & "\Comando\Telas.cfg")
        fileTelas.SetVar("Registrador", ComandoAvancado.ToolStripComboBoxRegistrador.SelectedItem)
    End Sub

    Public Sub CarregarConfigTela()
        ComandoAvancado.GetRegsToScreen()
        fileTelas.SetFilePath(applicationDirectory & "\Comando\Telas.cfg")
        Try
            Dim regToScreen As String = ""
            fileTelas.LoadVar("Registrador", regToScreen)
            ComandoAvancado.ToolStripComboBoxRegistrador.SelectedItem = regToScreen
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar configurações das telas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SalvarComponentes()
        fileControl.SetFilePath(pathTela & "\" & telas(telaAberta) & ".tela")
        SalvarConfigTela()
        If appProgrammingMethod = "Avançado" Then
            fileControl.SetVar("Size", ComandoAvancado.PanelComando.Size.ToString)
        Else
            fileControl.SetVar("Size", Comando.PanelComando.Size.ToString)
        End If
        Dim fileName As String = "\Componentes.inf"
        If (System.IO.File.Exists(pathTela & fileName)) Then
            System.IO.File.Delete(pathTela & fileName)
        End If
        For Each element In GetLocal.Controls
            If (element.GetType() = GetType(ControleHardware) And element.Visible) Then
                element.engine.salvaPosicao(element)
                'element.engine.salvaGraficos(element)
                element.SaveMe()
            End If
        Next
    End Sub

    Public Function ConvertStringToSize(stringPoint As String)
        Dim valorPonto As String = stringPoint.Replace("{Width=", "")
        valorPonto = valorPonto.Replace("Height=", "")
        valorPonto = valorPonto.Replace("}", "")
        Dim size As New Size(valorPonto.Split(",")(0), valorPonto.Split(",")(1))
        Return (size)
    End Function

    Public Sub AbrirTela(nome As String)
        CarregarConfigTela()
        If appProgrammingMethod = "Avançado" Then
            ComandoAvancado.clearUndoBuffer()
        Else
            Comando.clearUndoBuffer()
        End If
        pathTela = applicationDirectory & "\Comando\" & nome
        fileControl.SetFilePath(pathTela & "\" & nome & ".tela")
        Dim tam As String = ""
        fileControl.LoadVar("Size", tam)
        If tam <> "" And appProgrammingMethod = "Avançado" Then
        End If
        telaAberta = telas.IndexOf(nome)
        If appProgrammingMethod = "Avançado" Then
            ComandoAvancado.CabecalhoComando.Text = "Comando <" & AppName & "> " & nome
        Else
            Comando.CabecalhoComando.Text = "Comando <" & AppName & "> " & nome
        End If
        Dim statusBkp As StatusStrip = Comando.StatusStripComando
        While GetLocal.Controls.Count > 0
            For Each control In GetLocal.Controls
                If (control.GetType() = GetType(ControleHardware) And control.Visible) Then
                    If (control.engine.tipo = "Câmera IP") Then
                        control.VideoSourcePlayer.SignalToStop()
                    End If
                End If
                GetLocal.Controls.Remove(control)
                control.dispose()
            Next
        End While
        GetLocal.Controls.Add(statusBkp)
        PosicionaComponentes(nome)
    End Sub

    Sub PosicionaComponentes(nome As String)
        Dim fileName As String = pathTela & "\Componentes.inf"
        If (My.Computer.FileSystem.FileExists(fileName)) Then
            Dim dados() As String = System.IO.File.ReadAllLines(fileName)
            For Each line In dados
                Dim novoComponente As New ControleHardware
                Try
                    novoComponente.engine.loadFromString(line)
                Catch ex As Exception

                End Try
                novoComponente.engine.updateControl(novoComponente)
                GetLocal.Controls.Add(novoComponente)
            Next
        End If
    End Sub
End Module