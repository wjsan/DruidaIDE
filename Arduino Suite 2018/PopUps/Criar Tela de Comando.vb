Imports System.ComponentModel
Imports System.Windows.Forms

Public Class Criar_Tela_de_Comando

    Dim fileControl As New FileVarSystem

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim pathCreated As String = applicationDirectory & "\Comando\" & TextBoxNomeTela.Text
        My.Computer.FileSystem.CreateDirectory(pathCreated)
        If Not (telas.Contains(TextBoxNomeTela.Text)) Then
            System.IO.File.AppendAllText(applicationDirectory & "\Comando\ListaTelas.list", TextBoxNomeTela.Text & vbCrLf)
            System.IO.File.AppendAllText(pathCreated & "\" & TextBoxNomeTela.Text & ".tela", "")
            fileControl.SetFilePath(pathCreated & "\" & TextBoxNomeTela.Text & ".tela")
            'fileControl.SetVar("Size", "{Width=" & TextBoxWidth.Text & ", Height=" & Height & "}")
            If (My.Application.OpenForms.OfType(Of Comando).Count = 0) Then
                'If (ArduinoSuiteMain.COMPort.IsOpen And Not (ArduinoSuiteMain.StartRede) And (arduinoType = arduinoConfig)) Then
                '    ArduinoSuiteMain.StartRede()
                '    dadoLido = False
                '    dadoRecebido = False
                '    ArduinoSuiteMain.AtualizaRegs()
                '    'ArduinoSuiteMain.COMPort.Write("r")
                'End If
                If appProgrammingMethod = "Avançado" Then
                    ComandoAvancado.MdiParent = DruidaSuiteMain
                    ComandoAvancado.Dock = DockStyle.Fill
                    ComandoAvancado.Show()
                    ComandoAvancado.Top() = 0
                Else
                    Comando.MdiParent = DruidaSuiteMain
                    Comando.Dock = DockStyle.Fill
                    Comando.Show()
                    Comando.Top() = 0
                    TelaInicial.Close()
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ConvertStringToSize(stringPoint As String)
        Dim valorPonto = Replace(stringPoint, "{Width=", "", vbTextCompare)
        valorPonto = Replace(valorPonto, "Height=", "", vbTextCompare)
        valorPonto = Replace(valorPonto, "}", "", vbTextCompare)
        Dim size As New Size(valorPonto.Split(",")(0), valorPonto.Split(",")(1))
        Return (size)
    End Function

    Private Sub Criar_Tela_de_Comando_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
