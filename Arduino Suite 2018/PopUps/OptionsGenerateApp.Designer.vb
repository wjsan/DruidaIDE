<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsGenerateApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsGenerateApp))
        Me.ToolTipErro = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipInformacoes = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonProcurar = New System.Windows.Forms.Button()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxDiretorio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        PictureBox1.Size = New System.Drawing.Size(205, 218)
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
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(521, 177)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 26
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonProcurar
        '
        Me.ButtonProcurar.Location = New System.Drawing.Point(521, 131)
        Me.ButtonProcurar.Name = "ButtonProcurar"
        Me.ButtonProcurar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProcurar.TabIndex = 25
        Me.ButtonProcurar.Text = "Procurar"
        Me.ButtonProcurar.UseVisualStyleBackColor = True
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(277, 106)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxNome.TabIndex = 18
        Me.TextBoxNome.Text = "Nova Aplicação.exe"
        '
        'TextBoxDiretorio
        '
        Me.TextBoxDiretorio.Location = New System.Drawing.Point(277, 133)
        Me.TextBoxDiretorio.Name = "TextBoxDiretorio"
        Me.TextBoxDiretorio.Size = New System.Drawing.Size(238, 20)
        Me.TextBoxDiretorio.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Pasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 109)
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
        Me.Label2.Text = "Sua nova Aplicação esta quase pronta..."
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(428, 177)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGenerate.TabIndex = 26
        Me.ButtonGenerate.Text = "Gerar App"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(231, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 74)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'OptionsGenerateApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 219)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonProcurar)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.TextBoxDiretorio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsGenerateApp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gerar Aplicação Windows"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTipErro As ToolTip
    Friend WithEvents ToolTipInformacoes As ToolTip
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonProcurar As Button
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxDiretorio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents Label4 As Label
End Class
