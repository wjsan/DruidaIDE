<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaInicial
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlterarLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreDruidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.LabelMaximize = New System.Windows.Forms.Label()
        Me.LabelClose = New System.Windows.Forms.Label()
        Me.CabecalhoTelaInicial = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ÍconeHome = New ArduinoSuite.Ícone()
        Me.ÍconeSair = New ArduinoSuite.Ícone()
        Me.ÍconeAbrirPasta = New ArduinoSuite.Ícone()
        Me.ÍconeAlarmes = New ArduinoSuite.Ícone()
        Me.ÍconeProgramação = New ArduinoSuite.Ícone()
        Me.ÍconeComando = New ArduinoSuite.Ícone()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ÍconeNovo = New ArduinoSuite.Ícone()
        Me.ÍconeAbrir = New ArduinoSuite.Ícone()
        Me.ÍconeSalvar = New ArduinoSuite.Ícone()
        Me.ÍconeSalvarComo = New ArduinoSuite.Ícone()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarLogoToolStripMenuItem, Me.SobreToolStripMenuItem, Me.SobreDruidaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(214, 70)
        '
        'AlterarLogoToolStripMenuItem
        '
        Me.AlterarLogoToolStripMenuItem.Name = "AlterarLogoToolStripMenuItem"
        Me.AlterarLogoToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AlterarLogoToolStripMenuItem.Text = "Alterar Logo"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SobreToolStripMenuItem.Text = "Sobre BINARY_QUANTUM"
        '
        'SobreDruidaToolStripMenuItem
        '
        Me.SobreDruidaToolStripMenuItem.Name = "SobreDruidaToolStripMenuItem"
        Me.SobreDruidaToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SobreDruidaToolStripMenuItem.Text = "Sobre Druida"
        '
        'LabelMin
        '
        Me.LabelMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMin.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMin.ForeColor = System.Drawing.Color.White
        Me.LabelMin.Image = CType(resources.GetObject("LabelMin.Image"), System.Drawing.Image)
        Me.LabelMin.Location = New System.Drawing.Point(909, 7)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(25, 23)
        Me.LabelMin.TabIndex = 37
        Me.LabelMin.Text = "_"
        Me.LabelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMaximize
        '
        Me.LabelMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMaximize.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelMaximize.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelMaximize.ForeColor = System.Drawing.Color.White
        Me.LabelMaximize.Image = CType(resources.GetObject("LabelMaximize.Image"), System.Drawing.Image)
        Me.LabelMaximize.Location = New System.Drawing.Point(940, 7)
        Me.LabelMaximize.Name = "LabelMaximize"
        Me.LabelMaximize.Size = New System.Drawing.Size(25, 23)
        Me.LabelMaximize.TabIndex = 37
        Me.LabelMaximize.Text = "o"
        Me.LabelMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClose
        '
        Me.LabelClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClose.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelClose.ForeColor = System.Drawing.Color.White
        Me.LabelClose.Image = CType(resources.GetObject("LabelClose.Image"), System.Drawing.Image)
        Me.LabelClose.Location = New System.Drawing.Point(971, 7)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(25, 23)
        Me.LabelClose.TabIndex = 36
        Me.LabelClose.Text = "X"
        Me.LabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CabecalhoTelaInicial
        '
        Me.CabecalhoTelaInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CabecalhoTelaInicial.BackColor = System.Drawing.Color.Transparent
        Me.CabecalhoTelaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CabecalhoTelaInicial.ForeColor = System.Drawing.SystemColors.Window
        Me.CabecalhoTelaInicial.Location = New System.Drawing.Point(0, 0)
        Me.CabecalhoTelaInicial.Name = "CabecalhoTelaInicial"
        Me.CabecalhoTelaInicial.Size = New System.Drawing.Size(1002, 36)
        Me.CabecalhoTelaInicial.TabIndex = 3
        Me.CabecalhoTelaInicial.Text = "Druida"
        Me.CabecalhoTelaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.ArduinoSuite.My.Resources.Resources.TaskBar
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ÍconeHome)
        Me.Panel1.Controls.Add(Me.ÍconeSair)
        Me.Panel1.Controls.Add(Me.ÍconeAbrirPasta)
        Me.Panel1.Controls.Add(Me.ÍconeAlarmes)
        Me.Panel1.Controls.Add(Me.ÍconeProgramação)
        Me.Panel1.Controls.Add(Me.ÍconeComando)
        Me.Panel1.Location = New System.Drawing.Point(218, 628)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 111)
        Me.Panel1.TabIndex = 46
        '
        'ÍconeHome
        '
        Me.ÍconeHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeHome.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeHome.ForeColor = System.Drawing.Color.White
        Me.ÍconeHome.Icon = CType(resources.GetObject("ÍconeHome.Icon"), System.Drawing.Image)
        Me.ÍconeHome.LabelName = "binary-quantum"
        Me.ÍconeHome.Location = New System.Drawing.Point(17, 6)
        Me.ÍconeHome.Name = "ÍconeHome"
        Me.ÍconeHome.Size = New System.Drawing.Size(83, 86)
        Me.ÍconeHome.TabIndex = 6
        '
        'ÍconeSair
        '
        Me.ÍconeSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeSair.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeSair.ForeColor = System.Drawing.Color.White
        Me.ÍconeSair.Icon = CType(resources.GetObject("ÍconeSair.Icon"), System.Drawing.Image)
        Me.ÍconeSair.LabelName = "Sair"
        Me.ÍconeSair.Location = New System.Drawing.Point(458, 7)
        Me.ÍconeSair.Name = "ÍconeSair"
        Me.ÍconeSair.Size = New System.Drawing.Size(71, 84)
        Me.ÍconeSair.TabIndex = 5
        '
        'ÍconeAbrirPasta
        '
        Me.ÍconeAbrirPasta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeAbrirPasta.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeAbrirPasta.ForeColor = System.Drawing.Color.White
        Me.ÍconeAbrirPasta.Icon = CType(resources.GetObject("ÍconeAbrirPasta.Icon"), System.Drawing.Image)
        Me.ÍconeAbrirPasta.LabelName = "Arquivos da Aplicação"
        Me.ÍconeAbrirPasta.Location = New System.Drawing.Point(115, 6)
        Me.ÍconeAbrirPasta.Name = "ÍconeAbrirPasta"
        Me.ÍconeAbrirPasta.Size = New System.Drawing.Size(71, 86)
        Me.ÍconeAbrirPasta.TabIndex = 4
        '
        'ÍconeAlarmes
        '
        Me.ÍconeAlarmes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeAlarmes.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeAlarmes.ForeColor = System.Drawing.Color.White
        Me.ÍconeAlarmes.Icon = CType(resources.GetObject("ÍconeAlarmes.Icon"), System.Drawing.Image)
        Me.ÍconeAlarmes.LabelName = "Alarmes"
        Me.ÍconeAlarmes.Location = New System.Drawing.Point(372, 6)
        Me.ÍconeAlarmes.Name = "ÍconeAlarmes"
        Me.ÍconeAlarmes.Size = New System.Drawing.Size(71, 88)
        Me.ÍconeAlarmes.TabIndex = 4
        '
        'ÍconeProgramação
        '
        Me.ÍconeProgramação.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeProgramação.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeProgramação.ForeColor = System.Drawing.Color.White
        Me.ÍconeProgramação.Icon = CType(resources.GetObject("ÍconeProgramação.Icon"), System.Drawing.Image)
        Me.ÍconeProgramação.LabelName = "Programação"
        Me.ÍconeProgramação.Location = New System.Drawing.Point(197, 6)
        Me.ÍconeProgramação.Name = "ÍconeProgramação"
        Me.ÍconeProgramação.Size = New System.Drawing.Size(74, 86)
        Me.ÍconeProgramação.TabIndex = 4
        '
        'ÍconeComando
        '
        Me.ÍconeComando.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeComando.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeComando.ForeColor = System.Drawing.Color.White
        Me.ÍconeComando.Icon = CType(resources.GetObject("ÍconeComando.Icon"), System.Drawing.Image)
        Me.ÍconeComando.LabelName = "Interface Gráfica"
        Me.ÍconeComando.Location = New System.Drawing.Point(286, 5)
        Me.ÍconeComando.Name = "ÍconeComando"
        Me.ÍconeComando.Size = New System.Drawing.Size(71, 88)
        Me.ÍconeComando.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.ArduinoSuite.My.Resources.Resources.TaskBar
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ÍconeNovo)
        Me.Panel2.Controls.Add(Me.ÍconeAbrir)
        Me.Panel2.Controls.Add(Me.ÍconeSalvar)
        Me.Panel2.Controls.Add(Me.ÍconeSalvarComo)
        Me.Panel2.Location = New System.Drawing.Point(301, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 110)
        Me.Panel2.TabIndex = 47
        '
        'ÍconeNovo
        '
        Me.ÍconeNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeNovo.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeNovo.ForeColor = System.Drawing.Color.White
        Me.ÍconeNovo.Icon = CType(resources.GetObject("ÍconeNovo.Icon"), System.Drawing.Image)
        Me.ÍconeNovo.LabelName = "Novo Projeto"
        Me.ÍconeNovo.Location = New System.Drawing.Point(42, 29)
        Me.ÍconeNovo.Name = "ÍconeNovo"
        Me.ÍconeNovo.Size = New System.Drawing.Size(79, 78)
        Me.ÍconeNovo.TabIndex = 6
        '
        'ÍconeAbrir
        '
        Me.ÍconeAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeAbrir.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeAbrir.ForeColor = System.Drawing.Color.White
        Me.ÍconeAbrir.Icon = CType(resources.GetObject("ÍconeAbrir.Icon"), System.Drawing.Image)
        Me.ÍconeAbrir.LabelName = "Abrir Projeto"
        Me.ÍconeAbrir.Location = New System.Drawing.Point(126, 27)
        Me.ÍconeAbrir.Name = "ÍconeAbrir"
        Me.ÍconeAbrir.Size = New System.Drawing.Size(71, 78)
        Me.ÍconeAbrir.TabIndex = 4
        '
        'ÍconeSalvar
        '
        Me.ÍconeSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeSalvar.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeSalvar.ForeColor = System.Drawing.Color.White
        Me.ÍconeSalvar.Icon = CType(resources.GetObject("ÍconeSalvar.Icon"), System.Drawing.Image)
        Me.ÍconeSalvar.LabelName = "Salvar"
        Me.ÍconeSalvar.Location = New System.Drawing.Point(203, 27)
        Me.ÍconeSalvar.Name = "ÍconeSalvar"
        Me.ÍconeSalvar.Size = New System.Drawing.Size(70, 78)
        Me.ÍconeSalvar.TabIndex = 4
        '
        'ÍconeSalvarComo
        '
        Me.ÍconeSalvarComo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ÍconeSalvarComo.BackColor = System.Drawing.Color.Transparent
        Me.ÍconeSalvarComo.ForeColor = System.Drawing.Color.White
        Me.ÍconeSalvarComo.Icon = CType(resources.GetObject("ÍconeSalvarComo.Icon"), System.Drawing.Image)
        Me.ÍconeSalvarComo.LabelName = "Salvar Como"
        Me.ÍconeSalvarComo.Location = New System.Drawing.Point(283, 27)
        Me.ÍconeSalvarComo.Name = "ÍconeSalvarComo"
        Me.ÍconeSalvarComo.Size = New System.Drawing.Size(71, 80)
        Me.ÍconeSalvarComo.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackgroundImage = Global.ArduinoSuite.My.Resources.Resources.TaskBar
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.LabelMaximize)
        Me.Panel3.Controls.Add(Me.LabelClose)
        Me.Panel3.Controls.Add(Me.LabelMin)
        Me.Panel3.Controls.Add(Me.CabecalhoTelaInicial)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1002, 36)
        Me.Panel3.TabIndex = 48
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 42)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(402, 681)
        Me.WebBrowser1.TabIndex = 49
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser2.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser2.Location = New System.Drawing.Point(411, 107)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(594, 617)
        Me.WebBrowser2.TabIndex = 50
        Me.WebBrowser2.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.WebBrowser2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Druida"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CabecalhoTelaInicial As Label
    Friend WithEvents ÍconeProgramação As Ícone
    Friend WithEvents ÍconeComando As Ícone
    Friend WithEvents ÍconeAlarmes As Ícone
    Friend WithEvents ÍconeAbrirPasta As Ícone
    Friend WithEvents LabelClose As Label
    Friend WithEvents LabelMaximize As Label
    Friend WithEvents LabelMin As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AlterarLogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreDruidaToolStripMenuItem As ToolStripMenuItem
    'Friend WithEvents WebViewTelaPrincipal As DruidaIDEAuxiliarControls.WebBrowserFix
    'Friend WithEvents WebViewAprendizado As DruidaIDEAuxiliarControls.WebBrowserFix
    'Friend WithEvents WebViewReportBug As DruidaIDEAuxiliarControls.WebBrowserFix
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ÍconeSair As Ícone
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ÍconeNovo As Ícone
    Friend WithEvents ÍconeAbrir As Ícone
    Friend WithEvents ÍconeSalvar As Ícone
    Friend WithEvents ÍconeSalvarComo As Ícone
    Friend WithEvents Panel3 As Panel
    Private WithEvents ÍconeHome As Ícone
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents WebBrowser2 As WebBrowser
End Class
