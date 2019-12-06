<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Criar_Novo_Projeto
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
        Me.components = New System.ComponentModel.Container()
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Criar_Novo_Projeto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCriarPasta = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLog = New System.Windows.Forms.CheckBox()
        Me.TextBoxDiretorio = New System.Windows.Forms.TextBox()
        Me.ButtonProcurar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.ButtonCriarProjeto = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.GroupBoxSelect = New System.Windows.Forms.GroupBox()
        Me.RadioButtonAvançado = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSimples = New System.Windows.Forms.RadioButton()
        Me.ToolTipInformacoes = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonAbrir = New System.Windows.Forms.Button()
        Me.ToolTipErro = New System.Windows.Forms.ToolTip(Me.components)
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul
        PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        PictureBox1.Location = New System.Drawing.Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(205, 233)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxCriarPasta)
        Me.GroupBox1.Controls.Add(Me.CheckBoxLog)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 82)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opções:"
        '
        'CheckBoxCriarPasta
        '
        Me.CheckBoxCriarPasta.AutoSize = True
        Me.CheckBoxCriarPasta.Checked = True
        Me.CheckBoxCriarPasta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCriarPasta.Location = New System.Drawing.Point(30, 23)
        Me.CheckBoxCriarPasta.Name = "CheckBoxCriarPasta"
        Me.CheckBoxCriarPasta.Size = New System.Drawing.Size(232, 17)
        Me.CheckBoxCriarPasta.TabIndex = 0
        Me.CheckBoxCriarPasta.Text = "Criar Nova Pasta com o nome da Aplicação"
        Me.CheckBoxCriarPasta.UseVisualStyleBackColor = True
        '
        'CheckBoxLog
        '
        Me.CheckBoxLog.AutoSize = True
        Me.CheckBoxLog.Location = New System.Drawing.Point(30, 52)
        Me.CheckBoxLog.Name = "CheckBoxLog"
        Me.CheckBoxLog.Size = New System.Drawing.Size(284, 17)
        Me.CheckBoxLog.TabIndex = 1
        Me.CheckBoxLog.Text = "Sistema de Usuário e Senha necessário para o acesso"
        Me.CheckBoxLog.UseVisualStyleBackColor = True
        '
        'TextBoxDiretorio
        '
        Me.TextBoxDiretorio.Location = New System.Drawing.Point(282, 50)
        Me.TextBoxDiretorio.Name = "TextBoxDiretorio"
        Me.TextBoxDiretorio.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxDiretorio.TabIndex = 6
        '
        'ButtonProcurar
        '
        Me.ButtonProcurar.Location = New System.Drawing.Point(526, 48)
        Me.ButtonProcurar.Name = "ButtonProcurar"
        Me.ButtonProcurar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProcurar.TabIndex = 14
        Me.ButtonProcurar.Text = "Procurar"
        Me.ButtonProcurar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 52)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bem vindo ao Druida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pasta:"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(282, 23)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxNome.TabIndex = 5
        Me.TextBoxNome.Text = "Nova Aplicacao"
        '
        'ButtonCriarProjeto
        '
        Me.ButtonCriarProjeto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonCriarProjeto.Location = New System.Drawing.Point(255, 188)
        Me.ButtonCriarProjeto.Name = "ButtonCriarProjeto"
        Me.ButtonCriarProjeto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCriarProjeto.TabIndex = 15
        Me.ButtonCriarProjeto.Text = "Criar Projeto"
        Me.ButtonCriarProjeto.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonCancelar.Location = New System.Drawing.Point(507, 188)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 15
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'GroupBoxSelect
        '
        Me.GroupBoxSelect.Controls.Add(Me.RadioButtonAvançado)
        Me.GroupBoxSelect.Controls.Add(Me.RadioButtonSimples)
        Me.GroupBoxSelect.Location = New System.Drawing.Point(11, 88)
        Me.GroupBoxSelect.Name = "GroupBoxSelect"
        Me.GroupBoxSelect.Size = New System.Drawing.Size(186, 135)
        Me.GroupBoxSelect.TabIndex = 16
        Me.GroupBoxSelect.TabStop = False
        Me.GroupBoxSelect.Text = "Método de Programação:"
        Me.GroupBoxSelect.Visible = False
        '
        'RadioButtonAvançado
        '
        Me.RadioButtonAvançado.AutoSize = True
        Me.RadioButtonAvançado.Checked = True
        Me.RadioButtonAvançado.Location = New System.Drawing.Point(30, 78)
        Me.RadioButtonAvançado.Name = "RadioButtonAvançado"
        Me.RadioButtonAvançado.Size = New System.Drawing.Size(74, 17)
        Me.RadioButtonAvançado.TabIndex = 1
        Me.RadioButtonAvançado.TabStop = True
        Me.RadioButtonAvançado.Tag = ""
        Me.RadioButtonAvançado.Text = "Avançado"
        Me.ToolTipInformacoes.SetToolTip(Me.RadioButtonAvançado, "A programação é realizada por você! Através de uma IDE intuitiva, desenvolva o có" &
        "digo livremente para a sua placa.")
        Me.RadioButtonAvançado.UseVisualStyleBackColor = True
        '
        'RadioButtonSimples
        '
        Me.RadioButtonSimples.AutoSize = True
        Me.RadioButtonSimples.Location = New System.Drawing.Point(30, 32)
        Me.RadioButtonSimples.Name = "RadioButtonSimples"
        Me.RadioButtonSimples.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonSimples.TabIndex = 0
        Me.RadioButtonSimples.Text = "Simples"
        Me.ToolTipInformacoes.SetToolTip(Me.RadioButtonSimples, "A programação é realizada de forma automática através do firmware. Não posibilita" &
        " opções avançadas de programação.")
        Me.RadioButtonSimples.UseVisualStyleBackColor = True
        '
        'ToolTipInformacoes
        '
        Me.ToolTipInformacoes.AutomaticDelay = 100
        Me.ToolTipInformacoes.AutoPopDelay = 10000
        Me.ToolTipInformacoes.InitialDelay = 100
        Me.ToolTipInformacoes.ReshowDelay = 20
        Me.ToolTipInformacoes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipInformacoes.ToolTipTitle = "Informações"
        '
        'ButtonAbrir
        '
        Me.ButtonAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonAbrir.Location = New System.Drawing.Point(379, 188)
        Me.ButtonAbrir.Name = "ButtonAbrir"
        Me.ButtonAbrir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAbrir.TabIndex = 17
        Me.ButtonAbrir.Text = "Abrir Projeto"
        Me.ButtonAbrir.UseVisualStyleBackColor = True
        '
        'Criar_Novo_Projeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 231)
        Me.Controls.Add(Me.ButtonAbrir)
        Me.Controls.Add(Me.GroupBoxSelect)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonCriarProjeto)
        Me.Controls.Add(Me.ButtonProcurar)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.TextBoxDiretorio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Criar_Novo_Projeto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Aplicação"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxSelect.ResumeLayout(False)
        Me.GroupBoxSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxLog As CheckBox
    Friend WithEvents TextBoxDiretorio As TextBox
    Friend WithEvents ButtonProcurar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents CheckBoxCriarPasta As CheckBox
    Friend WithEvents ButtonCriarProjeto As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents GroupBoxSelect As GroupBox
    Friend WithEvents RadioButtonAvançado As RadioButton
    Friend WithEvents RadioButtonSimples As RadioButton
    Friend WithEvents ToolTipInformacoes As ToolTip
    Friend WithEvents ButtonAbrir As Button
    Friend WithEvents ToolTipErro As ToolTip
End Class
