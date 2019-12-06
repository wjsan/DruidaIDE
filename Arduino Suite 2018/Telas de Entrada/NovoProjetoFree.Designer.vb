<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovoProjetoFree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoProjetoFree))
        Me.ToolTipErro = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipInformacoes = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButtonAvançado = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSimples = New System.Windows.Forms.RadioButton()
        Me.GroupBoxSelect = New System.Windows.Forms.GroupBox()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonCriarProjeto = New System.Windows.Forms.Button()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        PictureBox1.Size = New System.Drawing.Size(205, 132)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
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
        'RadioButtonAvançado
        '
        Me.RadioButtonAvançado.AutoSize = True
        Me.RadioButtonAvançado.Checked = True
        Me.RadioButtonAvançado.Location = New System.Drawing.Point(193, 32)
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
        'GroupBoxSelect
        '
        Me.GroupBoxSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxSelect.Controls.Add(Me.RadioButtonAvançado)
        Me.GroupBoxSelect.Controls.Add(Me.RadioButtonSimples)
        Me.GroupBoxSelect.Location = New System.Drawing.Point(239, 76)
        Me.GroupBoxSelect.Name = "GroupBoxSelect"
        Me.GroupBoxSelect.Size = New System.Drawing.Size(288, 72)
        Me.GroupBoxSelect.TabIndex = 28
        Me.GroupBoxSelect.TabStop = False
        Me.GroupBoxSelect.Text = "Método de Programação:"
        Me.GroupBoxSelect.Visible = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonCancelar.Location = New System.Drawing.Point(452, 90)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 26
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonCriarProjeto
        '
        Me.ButtonCriarProjeto.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonCriarProjeto.Location = New System.Drawing.Point(239, 90)
        Me.ButtonCriarProjeto.Name = "ButtonCriarProjeto"
        Me.ButtonCriarProjeto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCriarProjeto.TabIndex = 27
        Me.ButtonCriarProjeto.Text = "Criar Projeto"
        Me.ButtonCriarProjeto.UseVisualStyleBackColor = True
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(289, 28)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxNome.TabIndex = 18
        Me.TextBoxNome.Text = "Nova Aplicacao"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nome:"
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
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Bem vindo ao Druida"
        '
        'NovoProjetoFree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 130)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonCriarProjeto)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(PictureBox1)
        Me.Controls.Add(Me.GroupBoxSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NovoProjetoFree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Projeto"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSelect.ResumeLayout(False)
        Me.GroupBoxSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTipErro As ToolTip
    Friend WithEvents ToolTipInformacoes As ToolTip
    Friend WithEvents RadioButtonAvançado As RadioButton
    Friend WithEvents RadioButtonSimples As RadioButton
    Friend WithEvents GroupBoxSelect As GroupBox
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonCriarProjeto As Button
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
