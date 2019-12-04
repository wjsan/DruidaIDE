Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Os seguintes eventos estão disponíveis para MyApplication:
    ' Inicialização: Ocorre quando o aplicativo é iniciado, antes da criação do formulário de inicialização.
    ' Desligamento: Ocorre após todos os formulários de aplicativo serem fechados.  Esse evento não ocorrerá se o aplicativo for encerrado de forma anormal.
    ' UnhandledException: Ocorre se o aplicativo encontra uma exceção sem tratamento.
    ' StartupNextInstance: Ocorre durante a inicialização de um aplicativo de instância única quando o aplicativo já está ativo. 
    ' NetworkAvailabilityChanged: Ocorre quando a conexão de rede é conectada ou desconectada.
    Partial Friend Class MyApplication
        Dim myCulture As New CultureManager
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            'If Not IsEqualFileToByte(AppInfo.Directories.app & "\MyProtocols.dll", My.Resources.MyProtocols) Then
            '    System.IO.File.WriteAllBytes(AppInfo.Directories.app & "\MyProtocols.dll", My.Resources.MyProtocols)
            'End If
            'If Not IsEqualFileToByte(AppInfo.Directories.app & "\DruidaIDEAuxiliarControls.dll", My.Resources.DruidaIDEAuxiliarControls) Then
            '    System.IO.File.WriteAllBytes(AppInfo.Directories.app & "\DruidaIDEAuxiliarControls.dll", My.Resources.DruidaIDEAuxiliarControls)
            'End If
            myCulture.setResxCulture(AppInfo.language)
        End Sub

        Private Function IsEqualFileToByte(file As String, binFile As Byte())
            If Not System.IO.File.Exists(file) Then
                MessageBox.Show("Arquivo criado: " & file)
                Return False
            End If
            Dim fileBytes As Byte() = System.IO.File.ReadAllBytes(file)
            Try
                For i = 0 To fileBytes.Length - 1
                    Dim b1 As Byte = fileBytes(i)
                    Dim b2 As Byte = binFile(i)
                    If b1 <> b2 Then
                        MessageBox.Show("Arquivo atualizado: " & file)
                        Return False
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Arquivo atualizado: " & file)
                Return False
            End Try
            Return True
        End Function
    End Class
End Namespace
