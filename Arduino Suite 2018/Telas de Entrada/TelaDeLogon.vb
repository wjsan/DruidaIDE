Public Module Encryption
    Private Function Encrypter(ByVal Text As String, ByVal IsEncrypt As Boolean) As String
        Const _pass As String = "AA.BB.CC.123" 'Aleatório, sem motivo para ser esse valor
        Const _salt As String = "AB13.657"     'Aleatório, sem motivo para ser esse valor
        Dim cipherBytes As Byte() = {}
        If IsEncrypt Then
            cipherBytes = System.Text.Encoding.Unicode.GetBytes(Text)
        Else
            cipherBytes = System.Convert.FromBase64String(Text)
        End If
        Dim pdb As System.Security.Cryptography.Rfc2898DeriveBytes = New System.Security.Cryptography.Rfc2898DeriveBytes(_pass, System.Text.Encoding.Unicode.GetBytes(_salt))
        Try
            Dim alg As System.Security.Cryptography.Rijndael = System.Security.Cryptography.Rijndael.Create()
            alg.Key = pdb.GetBytes(32)
            alg.IV = pdb.GetBytes(16)
            Dim cs As System.Security.Cryptography.CryptoStream
            Dim ms As New System.IO.MemoryStream()
            If IsEncrypt Then
                cs = New System.Security.Cryptography.CryptoStream(ms, alg.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
            Else
                cs = New System.Security.Cryptography.CryptoStream(ms, alg.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
            End If
            cs.Write(cipherBytes, 0, cipherBytes.Length)
            cs.FlushFinalBlock()
            cs.Close()
            Dim decryptedData As Byte() = ms.ToArray()
            If IsEncrypt Then
                Return System.Convert.ToBase64String(decryptedData)
            Else
                Return System.Text.Encoding.Unicode.GetString(decryptedData)
            End If
        Catch
            MessageBox.Show("Erro de Logon")
            Return ""
        End Try
    End Function

    Private Function GetFile() As String
        Return applicationDirectory + "\LogInData.ini"
    End Function

    Public Function Gravar(ByVal Usuario As String, ByVal Senha As String) As Boolean
        Dim File As String = Encryption.GetFile()
        'Try
        System.IO.File.AppendAllLines(File, {Encryption.Encrypter(Usuario, True) & " " & Encryption.Encrypter(Senha, True)})
        Return System.IO.File.Exists(File)
        'Catch
        'Return False
        'End Try
    End Function

    Public Function Ler(ByRef Usuario As String, ByRef Senha As String, num As Int16) As Boolean
        Dim File As String = Encryption.GetFile()
        If Not System.IO.File.Exists(File) Then Return False
        Dim Lines() As String = System.IO.File.ReadAllLines(File)
        Dim dados() As String
        dados = Lines(num).Split(" ")
        Usuario = Encryption.Encrypter(dados(0), False)
        Senha = Encryption.Encrypter(dados(1), False)
        Return (True)
    End Function

    Public Function Verificar(Usuario As String, Senha As String) As Boolean
        Dim File As String = Encryption.GetFile()
        Dim senhaCorreta As Boolean = False
        If Not System.IO.File.Exists(File) Then Return False
        Dim Lines() As String = System.IO.File.ReadAllLines(File)
        Dim dados() As String
        For i As Int16 = 0 To Lines.Length - 1
            dados = Lines(i).Split(" ")
            If Usuario = Encryption.Encrypter(dados(0), False) And Senha = Encryption.Encrypter(dados(1), False) Then
                senhaCorreta = True
            End If
        Next
        If senhaCorreta Then Return (True) Else Return (False)
    End Function

End Module


Public Class TelaDeLogon
    Dim file As String = applicationDirectory & "\LogInData.ini"
    Dim usuario As String = ""
    Dim senha As String = ""

    Private Sub LogOn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Encryption.Ler(usuario, senha, 0) Then Exit Sub
        If System.IO.File.Exists(file) Then
            ButtonLogOn.Text = "Log On"
            LabelCabecalho.Text = "Digite o nome de usuário e a senha:"
            LabelConfirmaSenha.Visible = False
            TextBoxCSenha.Visible = False
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        SplashScreen.Close()
        Close()
    End Sub

    Private Sub ButtonLogOn_Click(sender As Object, e As EventArgs) Handles ButtonLogOn.Click
        If System.IO.File.Exists(file) Then
            realizaLogon()
        Else
            criaUsuario()
        End If
    End Sub

    Private Sub realizaLogon()
        If (System.IO.File.Exists(applicationDirectory & "\LogInData.ini")) Then
            If (TextBoxSenha.Text = "" Or TextBoxNome.Text = "") Then
                MessageBox.Show("Os campos não podem estar vazios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Encryption.Verificar(TextBoxNome.Text, TextBoxSenha.Text) Then
                    userName = TextBoxNome.Text
                    PlayBackgroundSoundFile("LogOn.wav")
                    userIsAdmin = True
                    DruidaSuiteMain.Show()
                    Me.Close()
                    Me.Dispose()
                Else
                    MessageBox.Show("Usuário ou Senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub criaUsuario()
        If (Not (My.Computer.FileSystem.FileExists(applicationDirectory & "\LogInData.ini"))) Then
            If (TextBoxSenha.Text <> TextBoxCSenha.Text) Then
                MessageBox.Show("A confirmação da senha não esta igual a senha digitada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (TextBoxSenha.Text = "" Or TextBoxNome.Text = "") Then
                MessageBox.Show("Os campos não podem estar vazios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not Encryption.Gravar(TextBoxNome.Text, TextBoxSenha.Text) Then Exit Sub
                TextBoxNome.AutoCompleteCustomSource.Add(TextBoxNome.Text)
                PlayBackgroundSoundFile("LogOn.wav")
                loginNeeded = True
                MessageBox.Show("Usuario criado com sucesso!", "LogOn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                userName = TextBoxNome.Text
                DruidaSuiteMain.Show()
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    Sub PlayBackgroundSoundFile(sound As String)
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Media\" & sound, AudioPlayMode.Background)
    End Sub

    Private Sub TextBoxSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSenha.KeyPress
        If AscW(e.KeyChar) = 13 Then
            If System.IO.File.Exists(file) Then
                realizaLogon()
            End If
        End If
    End Sub

    Private Sub TextBoxCSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCSenha.KeyPress
        If AscW(e.KeyChar) = 13 Then
            criaUsuario()
        End If
    End Sub
End Class