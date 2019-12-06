<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaDeLogon
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaDeLogon))
        Me.ButtonLogOn = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelConfirmaSenha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCSenha = New System.Windows.Forms.TextBox()
        Me.TextBoxSenha = New System.Windows.Forms.TextBox()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelCabecalho = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul
        PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        PictureBox1.Location = New System.Drawing.Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(205, 262)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        '
        'ButtonLogOn
        '
        Me.ButtonLogOn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLogOn.Location = New System.Drawing.Point(260, 209)
        Me.ButtonLogOn.Name = "ButtonLogOn"
        Me.ButtonLogOn.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogOn.TabIndex = 3
        Me.ButtonLogOn.Text = "Criar Usuário"
        Me.ButtonLogOn.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCancelar.Location = New System.Drawing.Point(375, 209)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 4
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.ArduinoSuite.My.Resources.Resources.Key
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(251, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.ArduinoSuite.My.Resources.Resources._1370401673665602820business_user_lock_1
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(251, 85)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'LabelConfirmaSenha
        '
        Me.LabelConfirmaSenha.AutoSize = True
        Me.LabelConfirmaSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelConfirmaSenha.Location = New System.Drawing.Point(249, 176)
        Me.LabelConfirmaSenha.Name = "LabelConfirmaSenha"
        Me.LabelConfirmaSenha.Size = New System.Drawing.Size(85, 13)
        Me.LabelConfirmaSenha.TabIndex = 25
        Me.LabelConfirmaSenha.Text = "Confirma Senha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(292, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(289, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Usuário:"
        '
        'TextBoxCSenha
        '
        Me.TextBoxCSenha.Location = New System.Drawing.Point(338, 173)
        Me.TextBoxCSenha.Name = "TextBoxCSenha"
        Me.TextBoxCSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxCSenha.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxCSenha.TabIndex = 2
        '
        'TextBoxSenha
        '
        Me.TextBoxSenha.Location = New System.Drawing.Point(338, 134)
        Me.TextBoxSenha.Name = "TextBoxSenha"
        Me.TextBoxSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSenha.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxSenha.TabIndex = 1
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(338, 95)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxNome.TabIndex = 0
        '
        'LabelCabecalho
        '
        Me.LabelCabecalho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCabecalho.Location = New System.Drawing.Point(251, 18)
        Me.LabelCabecalho.Name = "LabelCabecalho"
        Me.LabelCabecalho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelCabecalho.Size = New System.Drawing.Size(238, 51)
        Me.LabelCabecalho.TabIndex = 22
        Me.LabelCabecalho.Text = "Digite um nome de usuário e uma senha. Esses dados serão utilizados no futuro, pa" &
    "ra acessar o programa como administrador do sistema."
        Me.LabelCabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(14, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 52)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Bem vindo ao Druida Tool's Suite"
        '
        'TelaDeLogon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 257)
        Me.Controls.Add(Me.ButtonLogOn)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelConfirmaSenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCSenha)
        Me.Controls.Add(Me.TextBoxSenha)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.LabelCabecalho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TelaDeLogon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogOn"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLogOn As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelConfirmaSenha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCSenha As TextBox
    Friend WithEvents TextBoxSenha As TextBox
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents LabelCabecalho As Label
    Friend WithEvents Label2 As Label
End Class
