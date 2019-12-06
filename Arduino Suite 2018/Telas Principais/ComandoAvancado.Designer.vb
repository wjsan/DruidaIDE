<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComandoAvancado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComandoAvancado))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saída", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sinais Binários", 32, 32, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saída", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sinais de 32-Bits", 33, 33, New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registradores", 31, 31, New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Led Verde", 35, 35)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Led Vermelho", 36, 36)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Led Amarelo", 48, 48)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sinalização", 34, 34, New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Botão", 13, 13)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chave", 14, 14)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comando", 12, 12, New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Potenciômetro", 3, 3)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Slider", 47, 47)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analógicos", 46, 46, New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Motor 1", 15, 15)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Motor 2", 16, 16)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Motor CC", 7, 7)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servo", 8, 8)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Motores", 6, 6, New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temperatura C°", 24, 24)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temperatura F°", 25, 25)
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HC-SR04", 37, 37)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sensores", 26, 26, New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Câmera", 27, 27)
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Componentes", 11, 11, New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode14, TreeNode17, TreeNode22, TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chart", 29, 29)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Imagem", 30, 30)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gráficos", 28, 28, New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Botão", 41, 41)
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada de Dados", 44, 44)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entrada de Dados Simples", 44, 44)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rótulo", 42, 42)
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Check Box", 45, 45)
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Componentes para Tela", 43, 43, New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Novo", 10, 10)
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Controles Personalizados", 9, 9, New System.Windows.Forms.TreeNode() {TreeNode38})
        Me.PanelTela = New System.Windows.Forms.Panel()
        Me.ToolStripTela = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNovaTela = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripComboBoxSelecionaTela = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBoxRegistrador = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButtonSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRenomear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonLimpaTela = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDeletar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonReverterTudo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonReverter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRefazer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonAlinharHorizontal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonAlinharVertical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonTrazerParaFrente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEnviarParaTrás = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonTamHorizontal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonTamVertical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBoxModo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButtonExecutar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiConnect = New System.Windows.Forms.ToolStripButton()
        Me.ParaEsquerdaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanelComponentes = New System.Windows.Forms.TableLayoutPanel()
        Me.Componentes = New System.Windows.Forms.TreeView()
        Me.Imagens = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStripComando = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusMousePos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusItemSelecionado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelComando = New System.Windows.Forms.Panel()
        Me.ContextMenuStripComando = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimparTelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriedadesTelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripWindowMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AncorarÀEsquerdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AncorarÀDireitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerAnimação = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.AcionamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcionamentoViaTecladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesativadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcionamentoViaJoystickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesativadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParaDireitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClonarTelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenomearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparTelaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripComando = New System.Windows.Forms.MenuStrip()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesfazerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefazerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropriedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CódigoDeProgramaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçãoAoClicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarCódigoParaLeituraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarCódigoParaEscritaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxOffSet = New System.Windows.Forms.ToolStripTextBox()
        Me.ParaCimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParaBaixoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComunicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecionarPortaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoTelaCheiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonAdmin = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOperador = New System.Windows.Forms.RadioButton()
        Me.LabelHome = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.LabelClose = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CabecalhoComando = New System.Windows.Forms.Label()
        Me.PanelTela.SuspendLayout()
        Me.ToolStripTela.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanelComponentes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStripComando.SuspendLayout()
        Me.ContextMenuStripComando.SuspendLayout()
        Me.ContextMenuStripWindowMenuStrip.SuspendLayout()
        Me.MenuStripComando.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTela
        '
        Me.PanelTela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTela.Controls.Add(Me.ToolStripTela)
        Me.PanelTela.Location = New System.Drawing.Point(9, 74)
        Me.PanelTela.Name = "PanelTela"
        Me.PanelTela.Size = New System.Drawing.Size(900, 27)
        Me.PanelTela.TabIndex = 34
        '
        'ToolStripTela
        '
        Me.ToolStripTela.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripTela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripTela.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNovaTela, Me.ToolStripComboBoxSelecionaTela, Me.ToolStripComboBoxRegistrador, Me.ToolStripButtonSalvar, Me.ToolStripButtonRenomear, Me.ToolStripButtonLimpaTela, Me.ToolStripButtonDeletar, Me.ToolStripSeparator3, Me.ToolStripButtonReverterTudo, Me.ToolStripButtonReverter, Me.ToolStripButtonRefazer, Me.ToolStripSeparator2, Me.ToolStripButtonAlinharHorizontal, Me.ToolStripButtonAlinharVertical, Me.ToolStripButtonTrazerParaFrente, Me.ToolStripButtonEnviarParaTrás, Me.ToolStripButtonTamHorizontal, Me.ToolStripButtonTamVertical, Me.ToolStripSeparator1, Me.ToolStripComboBoxModo, Me.ToolStripButtonExecutar, Me.ToolStripSeparator6, Me.tsmiConnect})
        Me.ToolStripTela.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTela.Name = "ToolStripTela"
        Me.ToolStripTela.Size = New System.Drawing.Size(900, 27)
        Me.ToolStripTela.TabIndex = 0
        Me.ToolStripTela.Text = "ToolStrip1"
        '
        'ToolStripButtonNovaTela
        '
        Me.ToolStripButtonNovaTela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNovaTela.Image = Global.ArduinoSuite.My.Resources.Resources.Novo
        Me.ToolStripButtonNovaTela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNovaTela.Name = "ToolStripButtonNovaTela"
        Me.ToolStripButtonNovaTela.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonNovaTela.Text = "ToolStripButtonNovaTela"
        Me.ToolStripButtonNovaTela.ToolTipText = "Criar Nova Tela (Ctrl + N)"
        '
        'ToolStripComboBoxSelecionaTela
        '
        Me.ToolStripComboBoxSelecionaTela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxSelecionaTela.Name = "ToolStripComboBoxSelecionaTela"
        Me.ToolStripComboBoxSelecionaTela.Size = New System.Drawing.Size(121, 27)
        Me.ToolStripComboBoxSelecionaTela.ToolTipText = "Abrir Tela"
        '
        'ToolStripComboBoxRegistrador
        '
        Me.ToolStripComboBoxRegistrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxRegistrador.Name = "ToolStripComboBoxRegistrador"
        Me.ToolStripComboBoxRegistrador.Size = New System.Drawing.Size(121, 27)
        Me.ToolStripComboBoxRegistrador.ToolTipText = "Registrador responsável por informar ao Arduino qual tela está aberta"
        '
        'ToolStripButtonSalvar
        '
        Me.ToolStripButtonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSalvar.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.ToolStripButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSalvar.Name = "ToolStripButtonSalvar"
        Me.ToolStripButtonSalvar.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonSalvar.Text = "ToolStripButtonSalvar"
        Me.ToolStripButtonSalvar.ToolTipText = "Salvar Tela (Ctrl + S)"
        '
        'ToolStripButtonRenomear
        '
        Me.ToolStripButtonRenomear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRenomear.Image = Global.ArduinoSuite.My.Resources.Resources.Rename
        Me.ToolStripButtonRenomear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRenomear.Name = "ToolStripButtonRenomear"
        Me.ToolStripButtonRenomear.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonRenomear.Text = "ToolStripButtonRenomear"
        Me.ToolStripButtonRenomear.ToolTipText = "Renomear Tela (Ctrl + R)"
        '
        'ToolStripButtonLimpaTela
        '
        Me.ToolStripButtonLimpaTela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonLimpaTela.Image = Global.ArduinoSuite.My.Resources.Resources.clearScreen
        Me.ToolStripButtonLimpaTela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonLimpaTela.Name = "ToolStripButtonLimpaTela"
        Me.ToolStripButtonLimpaTela.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonLimpaTela.Text = "Limpar Tela (Ctrl + L)"
        '
        'ToolStripButtonDeletar
        '
        Me.ToolStripButtonDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDeletar.Image = CType(resources.GetObject("ToolStripButtonDeletar.Image"), System.Drawing.Image)
        Me.ToolStripButtonDeletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDeletar.Name = "ToolStripButtonDeletar"
        Me.ToolStripButtonDeletar.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonDeletar.Text = "ToolStripButtonDeletar"
        Me.ToolStripButtonDeletar.ToolTipText = "Deletar Tela (Ctrl + Del)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButtonReverterTudo
        '
        Me.ToolStripButtonReverterTudo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonReverterTudo.Image = Global.ArduinoSuite.My.Resources.Resources.Undo_Rollback
        Me.ToolStripButtonReverterTudo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonReverterTudo.Name = "ToolStripButtonReverterTudo"
        Me.ToolStripButtonReverterTudo.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonReverterTudo.Text = "Reverter Tudo"
        '
        'ToolStripButtonReverter
        '
        Me.ToolStripButtonReverter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonReverter.Image = Global.ArduinoSuite.My.Resources.Resources.Undo
        Me.ToolStripButtonReverter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonReverter.Name = "ToolStripButtonReverter"
        Me.ToolStripButtonReverter.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonReverter.Text = "Desfazer"
        '
        'ToolStripButtonRefazer
        '
        Me.ToolStripButtonRefazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRefazer.Image = Global.ArduinoSuite.My.Resources.Resources.Redo
        Me.ToolStripButtonRefazer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRefazer.Name = "ToolStripButtonRefazer"
        Me.ToolStripButtonRefazer.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonRefazer.Text = "Refazer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButtonAlinharHorizontal
        '
        Me.ToolStripButtonAlinharHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAlinharHorizontal.Enabled = False
        Me.ToolStripButtonAlinharHorizontal.Image = Global.ArduinoSuite.My.Resources.Resources.Alinhar_Horizontal
        Me.ToolStripButtonAlinharHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAlinharHorizontal.Name = "ToolStripButtonAlinharHorizontal"
        Me.ToolStripButtonAlinharHorizontal.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonAlinharHorizontal.Text = "Alinhar Horizontalmente"
        '
        'ToolStripButtonAlinharVertical
        '
        Me.ToolStripButtonAlinharVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAlinharVertical.Enabled = False
        Me.ToolStripButtonAlinharVertical.Image = Global.ArduinoSuite.My.Resources.Resources.Alinhar_Vertical
        Me.ToolStripButtonAlinharVertical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAlinharVertical.Name = "ToolStripButtonAlinharVertical"
        Me.ToolStripButtonAlinharVertical.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonAlinharVertical.Text = "Alinhar Verticalmente"
        '
        'ToolStripButtonTrazerParaFrente
        '
        Me.ToolStripButtonTrazerParaFrente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonTrazerParaFrente.Enabled = False
        Me.ToolStripButtonTrazerParaFrente.Image = Global.ArduinoSuite.My.Resources.Resources.Front1
        Me.ToolStripButtonTrazerParaFrente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonTrazerParaFrente.Name = "ToolStripButtonTrazerParaFrente"
        Me.ToolStripButtonTrazerParaFrente.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonTrazerParaFrente.Text = "Trazer Para Frente"
        '
        'ToolStripButtonEnviarParaTrás
        '
        Me.ToolStripButtonEnviarParaTrás.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonEnviarParaTrás.Enabled = False
        Me.ToolStripButtonEnviarParaTrás.Image = Global.ArduinoSuite.My.Resources.Resources.Back1
        Me.ToolStripButtonEnviarParaTrás.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEnviarParaTrás.Name = "ToolStripButtonEnviarParaTrás"
        Me.ToolStripButtonEnviarParaTrás.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonEnviarParaTrás.Text = "Enviar Para Trás"
        '
        'ToolStripButtonTamHorizontal
        '
        Me.ToolStripButtonTamHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonTamHorizontal.Enabled = False
        Me.ToolStripButtonTamHorizontal.Image = Global.ArduinoSuite.My.Resources.Resources.equal_horizontal
        Me.ToolStripButtonTamHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonTamHorizontal.Name = "ToolStripButtonTamHorizontal"
        Me.ToolStripButtonTamHorizontal.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonTamHorizontal.Text = "Igualar Distância Horizontal"
        '
        'ToolStripButtonTamVertical
        '
        Me.ToolStripButtonTamVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonTamVertical.Enabled = False
        Me.ToolStripButtonTamVertical.Image = Global.ArduinoSuite.My.Resources.Resources.equal_vertical
        Me.ToolStripButtonTamVertical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonTamVertical.Name = "ToolStripButtonTamVertical"
        Me.ToolStripButtonTamVertical.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonTamVertical.Text = "Igualar Distância Vertical"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripComboBoxModo
        '
        Me.ToolStripComboBoxModo.AutoCompleteCustomSource.AddRange(New String() {"Janela", "Tela-Cheia"})
        Me.ToolStripComboBoxModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxModo.Items.AddRange(New Object() {"Janela", "Tela-Cheia"})
        Me.ToolStripComboBoxModo.Name = "ToolStripComboBoxModo"
        Me.ToolStripComboBoxModo.Size = New System.Drawing.Size(121, 27)
        Me.ToolStripComboBoxModo.ToolTipText = "Selecionar o modo de execução"
        '
        'ToolStripButtonExecutar
        '
        Me.ToolStripButtonExecutar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonExecutar.Image = Global.ArduinoSuite.My.Resources.Resources.Play
        Me.ToolStripButtonExecutar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExecutar.Name = "ToolStripButtonExecutar"
        Me.ToolStripButtonExecutar.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButtonExecutar.Text = "Executar Aplicação"
        Me.ToolStripButtonExecutar.ToolTipText = "Roda a aplicação no modo selecionado ao lado"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'tsmiConnect
        '
        Me.tsmiConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmiConnect.Image = Global.ArduinoSuite.My.Resources.Resources.spm_icon_256
        Me.tsmiConnect.Name = "tsmiConnect"
        Me.tsmiConnect.Size = New System.Drawing.Size(23, 24)
        Me.tsmiConnect.Text = "Conectar/Desconectar"
        '
        'ParaEsquerdaToolStripMenuItem1
        '
        Me.ParaEsquerdaToolStripMenuItem1.Name = "ParaEsquerdaToolStripMenuItem1"
        Me.ParaEsquerdaToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.ParaEsquerdaToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.ParaEsquerdaToolStripMenuItem1.Text = "Para Esquerda"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 107)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanelComponentes)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelComando)
        Me.SplitContainer1.Size = New System.Drawing.Size(1004, 649)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 32
        '
        'TableLayoutPanelComponentes
        '
        Me.TableLayoutPanelComponentes.ColumnCount = 1
        Me.TableLayoutPanelComponentes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelComponentes.Controls.Add(Me.Componentes, 0, 1)
        Me.TableLayoutPanelComponentes.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanelComponentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelComponentes.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelComponentes.Name = "TableLayoutPanelComponentes"
        Me.TableLayoutPanelComponentes.RowCount = 2
        Me.TableLayoutPanelComponentes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelComponentes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanelComponentes.Size = New System.Drawing.Size(250, 649)
        Me.TableLayoutPanelComponentes.TabIndex = 29
        '
        'Componentes
        '
        Me.Componentes.AllowDrop = True
        Me.Componentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Componentes.ImageIndex = 0
        Me.Componentes.ImageList = Me.Imagens
        Me.Componentes.Location = New System.Drawing.Point(3, 33)
        Me.Componentes.Name = "Componentes"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Entrada"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Entrada"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "Saída"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "Saída"
        TreeNode3.ImageIndex = 32
        TreeNode3.Name = "Sinais Binários"
        TreeNode3.SelectedImageIndex = 32
        TreeNode3.Text = "Sinais Binários"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Entrada"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Entrada"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Saída"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Saída"
        TreeNode6.ImageIndex = 33
        TreeNode6.Name = "Sinais de 32-Bits"
        TreeNode6.SelectedImageIndex = 33
        TreeNode6.Text = "Sinais de 32-Bits"
        TreeNode7.ImageIndex = 31
        TreeNode7.Name = "Registradores"
        TreeNode7.SelectedImageIndex = 31
        TreeNode7.Text = "Registradores"
        TreeNode8.ImageIndex = 35
        TreeNode8.Name = "Led Verde"
        TreeNode8.SelectedImageIndex = 35
        TreeNode8.Text = "Led Verde"
        TreeNode9.ImageIndex = 36
        TreeNode9.Name = "Led Vermelho"
        TreeNode9.SelectedImageIndex = 36
        TreeNode9.Text = "Led Vermelho"
        TreeNode10.ImageIndex = 48
        TreeNode10.Name = "Led Amarelo"
        TreeNode10.SelectedImageIndex = 48
        TreeNode10.Text = "Led Amarelo"
        TreeNode11.ImageIndex = 34
        TreeNode11.Name = "Sinalização"
        TreeNode11.SelectedImageIndex = 34
        TreeNode11.Text = "Sinalização"
        TreeNode12.ImageIndex = 13
        TreeNode12.Name = "Botão"
        TreeNode12.SelectedImageIndex = 13
        TreeNode12.Text = "Botão"
        TreeNode13.ImageIndex = 14
        TreeNode13.Name = "Chave"
        TreeNode13.SelectedImageIndex = 14
        TreeNode13.Text = "Chave"
        TreeNode14.ImageIndex = 12
        TreeNode14.Name = "Comando"
        TreeNode14.SelectedImageIndex = 12
        TreeNode14.Text = "Comando"
        TreeNode15.ImageIndex = 3
        TreeNode15.Name = "Potenciômetro"
        TreeNode15.SelectedImageIndex = 3
        TreeNode15.Text = "Potenciômetro"
        TreeNode16.ImageIndex = 47
        TreeNode16.Name = "Slider"
        TreeNode16.SelectedImageIndex = 47
        TreeNode16.Text = "Slider"
        TreeNode17.ImageIndex = 46
        TreeNode17.Name = "Analógicos"
        TreeNode17.SelectedImageIndex = 46
        TreeNode17.Text = "Analógicos"
        TreeNode18.ImageIndex = 15
        TreeNode18.Name = "Motor 1"
        TreeNode18.SelectedImageIndex = 15
        TreeNode18.Text = "Motor 1"
        TreeNode19.ImageIndex = 16
        TreeNode19.Name = "Motor 2"
        TreeNode19.SelectedImageIndex = 16
        TreeNode19.Text = "Motor 2"
        TreeNode20.ImageIndex = 7
        TreeNode20.Name = "Motor CC"
        TreeNode20.SelectedImageIndex = 7
        TreeNode20.Text = "Motor CC"
        TreeNode21.ImageIndex = 8
        TreeNode21.Name = "Servo"
        TreeNode21.SelectedImageIndex = 8
        TreeNode21.Text = "Servo"
        TreeNode22.ImageIndex = 6
        TreeNode22.Name = "Motores"
        TreeNode22.SelectedImageIndex = 6
        TreeNode22.Text = "Motores"
        TreeNode23.ImageIndex = 24
        TreeNode23.Name = "Temperatura C°"
        TreeNode23.SelectedImageIndex = 24
        TreeNode23.Text = "Temperatura C°"
        TreeNode24.ImageIndex = 25
        TreeNode24.Name = "Temperatura F"
        TreeNode24.SelectedImageIndex = 25
        TreeNode24.Text = "Temperatura F°"
        TreeNode25.ImageIndex = 37
        TreeNode25.Name = "HC-SR04"
        TreeNode25.SelectedImageIndex = 37
        TreeNode25.Text = "HC-SR04"
        TreeNode26.ImageIndex = 26
        TreeNode26.Name = "Sensores"
        TreeNode26.SelectedImageIndex = 26
        TreeNode26.Text = "Sensores"
        TreeNode27.ImageIndex = 27
        TreeNode27.Name = "Câmera"
        TreeNode27.SelectedImageIndex = 27
        TreeNode27.Text = "Câmera"
        TreeNode28.ImageIndex = 11
        TreeNode28.Name = "Componentes"
        TreeNode28.SelectedImageIndex = 11
        TreeNode28.Text = "Componentes"
        TreeNode29.ImageIndex = 29
        TreeNode29.Name = "Chart"
        TreeNode29.SelectedImageIndex = 29
        TreeNode29.Text = "Chart"
        TreeNode30.ImageIndex = 30
        TreeNode30.Name = "Imagem"
        TreeNode30.SelectedImageIndex = 30
        TreeNode30.Text = "Imagem"
        TreeNode31.ImageIndex = 28
        TreeNode31.Name = "Gráficos"
        TreeNode31.SelectedImageIndex = 28
        TreeNode31.Text = "Gráficos"
        TreeNode32.ImageIndex = 41
        TreeNode32.Name = "Botão"
        TreeNode32.SelectedImageIndex = 41
        TreeNode32.Text = "Botão"
        TreeNode33.ImageIndex = 44
        TreeNode33.Name = "Entrada de Dados"
        TreeNode33.SelectedImageIndex = 44
        TreeNode33.Text = "Entrada de Dados"
        TreeNode34.ImageIndex = 44
        TreeNode34.Name = "Entrada de Dados Simples"
        TreeNode34.SelectedImageIndex = 44
        TreeNode34.Text = "Entrada de Dados Simples"
        TreeNode35.ImageIndex = 42
        TreeNode35.Name = "Rótulo"
        TreeNode35.SelectedImageIndex = 42
        TreeNode35.Text = "Rótulo"
        TreeNode36.ImageIndex = 45
        TreeNode36.Name = "Check Box"
        TreeNode36.SelectedImageIndex = 45
        TreeNode36.Text = "Check Box"
        TreeNode37.ImageIndex = 43
        TreeNode37.Name = "Componetenes para Tela"
        TreeNode37.SelectedImageIndex = 43
        TreeNode37.Text = "Componentes para Tela"
        TreeNode38.ImageIndex = 10
        TreeNode38.Name = "Novo"
        TreeNode38.SelectedImageIndex = 10
        TreeNode38.Text = "Novo"
        TreeNode39.ImageIndex = 9
        TreeNode39.Name = "Controles Personalizados"
        TreeNode39.SelectedImageIndex = 9
        TreeNode39.Text = "Controles Personalizados"
        Me.Componentes.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode28, TreeNode31, TreeNode37, TreeNode39})
        Me.Componentes.SelectedImageIndex = 0
        Me.Componentes.Size = New System.Drawing.Size(244, 613)
        Me.Componentes.TabIndex = 0
        '
        'Imagens
        '
        Me.Imagens.ImageStream = CType(resources.GetObject("Imagens.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagens.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagens.Images.SetKeyName(0, "ArduinoUNO.png")
        Me.Imagens.Images.SetKeyName(1, "Switch.png")
        Me.Imagens.Images.SetKeyName(2, "Lampada.png")
        Me.Imagens.Images.SetKeyName(3, "AnalogInput.png")
        Me.Imagens.Images.SetKeyName(4, "analogActuator.png")
        Me.Imagens.Images.SetKeyName(5, "Intertravamentos.png")
        Me.Imagens.Images.SetKeyName(6, "motorCC.png")
        Me.Imagens.Images.SetKeyName(7, "stepperMotor.png")
        Me.Imagens.Images.SetKeyName(8, "servoMotor.png")
        Me.Imagens.Images.SetKeyName(9, "Edit.png")
        Me.Imagens.Images.SetKeyName(10, "Novo.png")
        Me.Imagens.Images.SetKeyName(11, "componentes.png")
        Me.Imagens.Images.SetKeyName(12, "Comando.png")
        Me.Imagens.Images.SetKeyName(13, "buttonOn.png")
        Me.Imagens.Images.SetKeyName(14, "on.png")
        Me.Imagens.Images.SetKeyName(15, "Motor2Cinza.png")
        Me.Imagens.Images.SetKeyName(16, "MotorCinza.png")
        Me.Imagens.Images.SetKeyName(17, "ServoMotorCinza.png")
        Me.Imagens.Images.SetKeyName(18, "Flow Sensor 2.png")
        Me.Imagens.Images.SetKeyName(19, "Flow Sensor 3.png")
        Me.Imagens.Images.SetKeyName(20, "Flow Sensor.png")
        Me.Imagens.Images.SetKeyName(21, "Level Sensor 2.png")
        Me.Imagens.Images.SetKeyName(22, "Level Sensor 3.png")
        Me.Imagens.Images.SetKeyName(23, "Level Sensor1.png")
        Me.Imagens.Images.SetKeyName(24, "temperaturaC.png")
        Me.Imagens.Images.SetKeyName(25, "temperaturaF.png")
        Me.Imagens.Images.SetKeyName(26, "Sensor.png")
        Me.Imagens.Images.SetKeyName(27, "CameraIP.jpg")
        Me.Imagens.Images.SetKeyName(28, "Componentes.png")
        Me.Imagens.Images.SetKeyName(29, "chart.png")
        Me.Imagens.Images.SetKeyName(30, "AddPicture.png")
        Me.Imagens.Images.SetKeyName(31, "COMPort.png")
        Me.Imagens.Images.SetKeyName(32, "Bits.png")
        Me.Imagens.Images.SetKeyName(33, "32bit.png")
        Me.Imagens.Images.SetKeyName(34, "Sinalização.jpg")
        Me.Imagens.Images.SetKeyName(35, "GreenLedOn.png")
        Me.Imagens.Images.SetKeyName(36, "RedLedOn.png")
        Me.Imagens.Images.SetKeyName(37, "hc-sr04.png")
        Me.Imagens.Images.SetKeyName(38, "CriarAutomação.png")
        Me.Imagens.Images.SetKeyName(39, "TarefasSecundárias.png")
        Me.Imagens.Images.SetKeyName(40, "Acionamento.png")
        Me.Imagens.Images.SetKeyName(41, "buttonImg.png")
        Me.Imagens.Images.SetKeyName(42, "rotulo.jpg")
        Me.Imagens.Images.SetKeyName(43, "Tela.png")
        Me.Imagens.Images.SetKeyName(44, "TextBox.png")
        Me.Imagens.Images.SetKeyName(45, "Enabled.png")
        Me.Imagens.Images.SetKeyName(46, "icons8-seno-480.png")
        Me.Imagens.Images.SetKeyName(47, "icons8-timeline-slider-480.png")
        Me.Imagens.Images.SetKeyName(48, "YellowLedOn.png")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul1
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Caixa de Componentes:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.StatusStripComando)
        Me.Panel1.Location = New System.Drawing.Point(5, 622)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 23)
        Me.Panel1.TabIndex = 26
        '
        'StatusStripComando
        '
        Me.StatusStripComando.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusMousePos, Me.ToolStripStatusItemSelecionado, Me.ToolStripStatusLabel4, Me.ToolStripStatusSize})
        Me.StatusStripComando.Location = New System.Drawing.Point(0, 1)
        Me.StatusStripComando.Name = "StatusStripComando"
        Me.StatusStripComando.Size = New System.Drawing.Size(740, 22)
        Me.StatusStripComando.TabIndex = 26
        Me.StatusStripComando.Text = "StatusStrip1"
        '
        'ToolStripStatusMousePos
        '
        Me.ToolStripStatusMousePos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusMousePos.Name = "ToolStripStatusMousePos"
        Me.ToolStripStatusMousePos.Size = New System.Drawing.Size(241, 17)
        Me.ToolStripStatusMousePos.Spring = True
        Me.ToolStripStatusMousePos.Text = "0"
        '
        'ToolStripStatusItemSelecionado
        '
        Me.ToolStripStatusItemSelecionado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusItemSelecionado.Name = "ToolStripStatusItemSelecionado"
        Me.ToolStripStatusItemSelecionado.Size = New System.Drawing.Size(241, 17)
        Me.ToolStripStatusItemSelecionado.Spring = True
        Me.ToolStripStatusItemSelecionado.Text = "Nenhum"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusSize
        '
        Me.ToolStripStatusSize.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusSize.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusSize.Name = "ToolStripStatusSize"
        Me.ToolStripStatusSize.Size = New System.Drawing.Size(241, 17)
        Me.ToolStripStatusSize.Spring = True
        Me.ToolStripStatusSize.Text = "Size"
        '
        'PanelComando
        '
        Me.PanelComando.AllowDrop = True
        Me.PanelComando.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelComando.AutoScroll = True
        Me.PanelComando.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelComando.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelComando.ContextMenuStrip = Me.ContextMenuStripComando
        Me.PanelComando.Location = New System.Drawing.Point(0, 0)
        Me.PanelComando.Name = "PanelComando"
        Me.PanelComando.Size = New System.Drawing.Size(750, 620)
        Me.PanelComando.TabIndex = 22
        '
        'ContextMenuStripComando
        '
        Me.ContextMenuStripComando.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimparTelaToolStripMenuItem, Me.ColarToolStripMenuItem, Me.PropriedadesTelaToolStripMenuItem})
        Me.ContextMenuStripComando.Name = "ContextMenuStripComando"
        Me.ContextMenuStripComando.Size = New System.Drawing.Size(176, 70)
        '
        'LimparTelaToolStripMenuItem
        '
        Me.LimparTelaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.clearScreen
        Me.LimparTelaToolStripMenuItem.Name = "LimparTelaToolStripMenuItem"
        Me.LimparTelaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LimparTelaToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LimparTelaToolStripMenuItem.Text = "Limpar Tela"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Paste
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ColarToolStripMenuItem.Text = "Colar"
        '
        'PropriedadesTelaToolStripMenuItem
        '
        Me.PropriedadesTelaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Propriedades
        Me.PropriedadesTelaToolStripMenuItem.Name = "PropriedadesTelaToolStripMenuItem"
        Me.PropriedadesTelaToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PropriedadesTelaToolStripMenuItem.Text = "Propriedades"
        '
        'ContextMenuStripWindowMenuStrip
        '
        Me.ContextMenuStripWindowMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AncorarÀEsquerdaToolStripMenuItem, Me.AncorarÀDireitaToolStripMenuItem, Me.MaximizarToolStripMenuItem, Me.MinimizarToolStripMenuItem})
        Me.ContextMenuStripWindowMenuStrip.Name = "ContextMenuStripWindowMenuStrip"
        Me.ContextMenuStripWindowMenuStrip.Size = New System.Drawing.Size(177, 92)
        '
        'AncorarÀEsquerdaToolStripMenuItem
        '
        Me.AncorarÀEsquerdaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.leftdocking
        Me.AncorarÀEsquerdaToolStripMenuItem.Name = "AncorarÀEsquerdaToolStripMenuItem"
        Me.AncorarÀEsquerdaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AncorarÀEsquerdaToolStripMenuItem.Text = "Ancorar à esquerda"
        '
        'AncorarÀDireitaToolStripMenuItem
        '
        Me.AncorarÀDireitaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.rightDocking
        Me.AncorarÀDireitaToolStripMenuItem.Name = "AncorarÀDireitaToolStripMenuItem"
        Me.AncorarÀDireitaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AncorarÀDireitaToolStripMenuItem.Text = "Ancorar à direita"
        '
        'MaximizarToolStripMenuItem
        '
        Me.MaximizarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Maximize
        Me.MaximizarToolStripMenuItem.Name = "MaximizarToolStripMenuItem"
        Me.MaximizarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MaximizarToolStripMenuItem.Text = "Maximizar"
        '
        'MinimizarToolStripMenuItem
        '
        Me.MinimizarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Minimize
        Me.MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        Me.MinimizarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MinimizarToolStripMenuItem.Text = "Minimizar"
        '
        'TimerAnimação
        '
        Me.TimerAnimação.Interval = 1
        '
        'AcionamentoToolStripMenuItem
        '
        Me.AcionamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcionamentoViaTecladoToolStripMenuItem, Me.AcionamentoViaJoystickToolStripMenuItem})
        Me.AcionamentoToolStripMenuItem.Name = "AcionamentoToolStripMenuItem"
        Me.AcionamentoToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.AcionamentoToolStripMenuItem.Text = "Acionamento"
        '
        'AcionamentoViaTecladoToolStripMenuItem
        '
        Me.AcionamentoViaTecladoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivadoToolStripMenuItem, Me.DesativadoToolStripMenuItem})
        Me.AcionamentoViaTecladoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Keyboard
        Me.AcionamentoViaTecladoToolStripMenuItem.Name = "AcionamentoViaTecladoToolStripMenuItem"
        Me.AcionamentoViaTecladoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AcionamentoViaTecladoToolStripMenuItem.Text = "Acionamento Via Teclado"
        '
        'AtivadoToolStripMenuItem
        '
        Me.AtivadoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Enabled
        Me.AtivadoToolStripMenuItem.Name = "AtivadoToolStripMenuItem"
        Me.AtivadoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AtivadoToolStripMenuItem.Text = "Ativado"
        '
        'DesativadoToolStripMenuItem
        '
        Me.DesativadoToolStripMenuItem.Name = "DesativadoToolStripMenuItem"
        Me.DesativadoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DesativadoToolStripMenuItem.Text = "Desativado"
        '
        'AcionamentoViaJoystickToolStripMenuItem
        '
        Me.AcionamentoViaJoystickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivadoToolStripMenuItem1, Me.DesativadoToolStripMenuItem1, Me.TestarToolStripMenuItem})
        Me.AcionamentoViaJoystickToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.xOneController
        Me.AcionamentoViaJoystickToolStripMenuItem.Name = "AcionamentoViaJoystickToolStripMenuItem"
        Me.AcionamentoViaJoystickToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AcionamentoViaJoystickToolStripMenuItem.Text = "Acionamento Via Joystick"
        '
        'AtivadoToolStripMenuItem1
        '
        Me.AtivadoToolStripMenuItem1.Name = "AtivadoToolStripMenuItem1"
        Me.AtivadoToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.AtivadoToolStripMenuItem1.Text = "Ativado"
        '
        'DesativadoToolStripMenuItem1
        '
        Me.DesativadoToolStripMenuItem1.Image = Global.ArduinoSuite.My.Resources.Resources.Disabled
        Me.DesativadoToolStripMenuItem1.Name = "DesativadoToolStripMenuItem1"
        Me.DesativadoToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.DesativadoToolStripMenuItem1.Text = "Desativado"
        '
        'TestarToolStripMenuItem
        '
        Me.TestarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Setting_icon
        Me.TestarToolStripMenuItem.Name = "TestarToolStripMenuItem"
        Me.TestarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.TestarToolStripMenuItem.Text = "Configurar"
        '
        'ParaDireitaToolStripMenuItem
        '
        Me.ParaDireitaToolStripMenuItem.Name = "ParaDireitaToolStripMenuItem"
        Me.ParaDireitaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.ParaDireitaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ParaDireitaToolStripMenuItem.Text = "Para Direita"
        '
        'TelaToolStripMenuItem
        '
        Me.TelaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaToolStripMenuItem, Me.ClonarTelaToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.RenomearToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.LimparTelaToolStripMenuItem1})
        Me.TelaToolStripMenuItem.Name = "TelaToolStripMenuItem"
        Me.TelaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.TelaToolStripMenuItem.Text = "Tela"
        '
        'NovaToolStripMenuItem
        '
        Me.NovaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Novo
        Me.NovaToolStripMenuItem.Name = "NovaToolStripMenuItem"
        Me.NovaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NovaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.NovaToolStripMenuItem.Text = "Nova"
        '
        'ClonarTelaToolStripMenuItem
        '
        Me.ClonarTelaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.copy
        Me.ClonarTelaToolStripMenuItem.Name = "ClonarTelaToolStripMenuItem"
        Me.ClonarTelaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ClonarTelaToolStripMenuItem.Text = "Clonar Tela"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'RenomearToolStripMenuItem
        '
        Me.RenomearToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Rename
        Me.RenomearToolStripMenuItem.Name = "RenomearToolStripMenuItem"
        Me.RenomearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RenomearToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RenomearToolStripMenuItem.Text = "Renomear"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = CType(resources.GetObject("ExcluirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'LimparTelaToolStripMenuItem1
        '
        Me.LimparTelaToolStripMenuItem1.Image = Global.ArduinoSuite.My.Resources.Resources.clearScreen
        Me.LimparTelaToolStripMenuItem1.Name = "LimparTelaToolStripMenuItem1"
        Me.LimparTelaToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LimparTelaToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.LimparTelaToolStripMenuItem1.Text = "Limpar Tela"
        '
        'MenuStripComando
        '
        Me.MenuStripComando.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripComando.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TelaToolStripMenuItem, Me.EditarToolStripMenuItem, Me.AcionamentoToolStripMenuItem, Me.ComunicaçãoToolStripMenuItem, Me.AplicaçãoToolStripMenuItem})
        Me.MenuStripComando.Location = New System.Drawing.Point(-1, 1)
        Me.MenuStripComando.Name = "MenuStripComando"
        Me.MenuStripComando.Size = New System.Drawing.Size(352, 24)
        Me.MenuStripComando.TabIndex = 27
        Me.MenuStripComando.Text = "MenuStrip1"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesfazerToolStripMenuItem, Me.RefazerToolStripMenuItem, Me.ToolStripSeparator4, Me.RecortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ColarToolStripMenuItem1, Me.ExcluirToolStripMenuItem1, Me.PropriedadesToolStripMenuItem, Me.ToolStripSeparator5, Me.CódigoDeProgramaçãoToolStripMenuItem, Me.MoverControleToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'DesfazerToolStripMenuItem
        '
        Me.DesfazerToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Undo
        Me.DesfazerToolStripMenuItem.Name = "DesfazerToolStripMenuItem"
        Me.DesfazerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DesfazerToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.DesfazerToolStripMenuItem.Text = "Desfazer"
        '
        'RefazerToolStripMenuItem
        '
        Me.RefazerToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Redo
        Me.RefazerToolStripMenuItem.Name = "RefazerToolStripMenuItem"
        Me.RefazerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RefazerToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RefazerToolStripMenuItem.Text = "Refazer"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        '
        'RecortarToolStripMenuItem
        '
        Me.RecortarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.scissor_png_image_9297
        Me.RecortarToolStripMenuItem.Name = "RecortarToolStripMenuItem"
        Me.RecortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RecortarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RecortarToolStripMenuItem.Text = "Recortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.copy
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'ColarToolStripMenuItem1
        '
        Me.ColarToolStripMenuItem1.Image = Global.ArduinoSuite.My.Resources.Resources.Paste
        Me.ColarToolStripMenuItem1.Name = "ColarToolStripMenuItem1"
        Me.ColarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ColarToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ColarToolStripMenuItem1.Text = "Colar"
        '
        'ExcluirToolStripMenuItem1
        '
        Me.ExcluirToolStripMenuItem1.Image = Global.ArduinoSuite.My.Resources.Resources.deletar
        Me.ExcluirToolStripMenuItem1.Name = "ExcluirToolStripMenuItem1"
        Me.ExcluirToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.ExcluirToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ExcluirToolStripMenuItem1.Text = "Excluir"
        '
        'PropriedadesToolStripMenuItem
        '
        Me.PropriedadesToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Propriedades
        Me.PropriedadesToolStripMenuItem.Name = "PropriedadesToolStripMenuItem"
        Me.PropriedadesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PropriedadesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PropriedadesToolStripMenuItem.Text = "Propriedades"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(200, 6)
        '
        'CódigoDeProgramaçãoToolStripMenuItem
        '
        Me.CódigoDeProgramaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem, Me.AçãoAoClicarToolStripMenuItem, Me.CopiarCódigoParaLeituraToolStripMenuItem, Me.CopiarCódigoParaEscritaToolStripMenuItem})
        Me.CódigoDeProgramaçãoToolStripMenuItem.Name = "CódigoDeProgramaçãoToolStripMenuItem"
        Me.CódigoDeProgramaçãoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CódigoDeProgramaçãoToolStripMenuItem.Text = "Código de Programação"
        '
        'AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem
        '
        Me.AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem.Name = "AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem"
        Me.AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem.Text = "Ação ao Ativar o Componente (chamada do procedimento)"
        '
        'AçãoAoClicarToolStripMenuItem
        '
        Me.AçãoAoClicarToolStripMenuItem.Name = "AçãoAoClicarToolStripMenuItem"
        Me.AçãoAoClicarToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AçãoAoClicarToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.AçãoAoClicarToolStripMenuItem.Text = "Ação ao Ativar o Componente (procedimento completo)"
        '
        'CopiarCódigoParaLeituraToolStripMenuItem
        '
        Me.CopiarCódigoParaLeituraToolStripMenuItem.Name = "CopiarCódigoParaLeituraToolStripMenuItem"
        Me.CopiarCódigoParaLeituraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.CopiarCódigoParaLeituraToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.CopiarCódigoParaLeituraToolStripMenuItem.Text = "Leitura"
        '
        'CopiarCódigoParaEscritaToolStripMenuItem
        '
        Me.CopiarCódigoParaEscritaToolStripMenuItem.Name = "CopiarCódigoParaEscritaToolStripMenuItem"
        Me.CopiarCódigoParaEscritaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CopiarCódigoParaEscritaToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.CopiarCódigoParaEscritaToolStripMenuItem.Text = "Escrita"
        '
        'MoverControleToolStripMenuItem
        '
        Me.MoverControleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValorToolStripMenuItem, Me.ParaCimaToolStripMenuItem, Me.ParaBaixoToolStripMenuItem, Me.ParaDireitaToolStripMenuItem, Me.ParaEsquerdaToolStripMenuItem1})
        Me.MoverControleToolStripMenuItem.Name = "MoverControleToolStripMenuItem"
        Me.MoverControleToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MoverControleToolStripMenuItem.Text = "Mover Controle"
        '
        'ValorToolStripMenuItem
        '
        Me.ValorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxOffSet})
        Me.ValorToolStripMenuItem.Name = "ValorToolStripMenuItem"
        Me.ValorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ValorToolStripMenuItem.Text = "Valor"
        '
        'ToolStripTextBoxOffSet
        '
        Me.ToolStripTextBoxOffSet.Name = "ToolStripTextBoxOffSet"
        Me.ToolStripTextBoxOffSet.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBoxOffSet.Text = "1"
        '
        'ParaCimaToolStripMenuItem
        '
        Me.ParaCimaToolStripMenuItem.Name = "ParaCimaToolStripMenuItem"
        Me.ParaCimaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.ParaCimaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ParaCimaToolStripMenuItem.Text = "Para Cima"
        '
        'ParaBaixoToolStripMenuItem
        '
        Me.ParaBaixoToolStripMenuItem.Name = "ParaBaixoToolStripMenuItem"
        Me.ParaBaixoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.ParaBaixoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ParaBaixoToolStripMenuItem.Text = "Para Baixo"
        '
        'ComunicaçãoToolStripMenuItem
        '
        Me.ComunicaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelecionarPortaToolStripMenuItem, Me.ConectarToolStripMenuItem})
        Me.ComunicaçãoToolStripMenuItem.Name = "ComunicaçãoToolStripMenuItem"
        Me.ComunicaçãoToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ComunicaçãoToolStripMenuItem.Text = "Comunicação"
        '
        'SelecionarPortaToolStripMenuItem
        '
        Me.SelecionarPortaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Porta_Aberta
        Me.SelecionarPortaToolStripMenuItem.Name = "SelecionarPortaToolStripMenuItem"
        Me.SelecionarPortaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SelecionarPortaToolStripMenuItem.Text = "Selecionar Porta"
        '
        'ConectarToolStripMenuItem
        '
        Me.ConectarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.spm_icon_256
        Me.ConectarToolStripMenuItem.Name = "ConectarToolStripMenuItem"
        Me.ConectarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConectarToolStripMenuItem.Text = "Conectar/Desconectar"
        '
        'AplicaçãoToolStripMenuItem
        '
        Me.AplicaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestarToolStripMenuItem1})
        Me.AplicaçãoToolStripMenuItem.Name = "AplicaçãoToolStripMenuItem"
        Me.AplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AplicaçãoToolStripMenuItem.Text = "Aplicação"
        '
        'TestarToolStripMenuItem1
        '
        Me.TestarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModoJanelaToolStripMenuItem, Me.ModoTelaCheiaToolStripMenuItem})
        Me.TestarToolStripMenuItem1.Name = "TestarToolStripMenuItem1"
        Me.TestarToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.TestarToolStripMenuItem1.Text = "Executar"
        '
        'ModoJanelaToolStripMenuItem
        '
        Me.ModoJanelaToolStripMenuItem.Name = "ModoJanelaToolStripMenuItem"
        Me.ModoJanelaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModoJanelaToolStripMenuItem.Text = "Modo Janela"
        '
        'ModoTelaCheiaToolStripMenuItem
        '
        Me.ModoTelaCheiaToolStripMenuItem.Name = "ModoTelaCheiaToolStripMenuItem"
        Me.ModoTelaCheiaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModoTelaCheiaToolStripMenuItem.Text = "Modo Tela-Cheia"
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.Controls.Add(Me.MenuStripComando)
        Me.PanelMenu.Location = New System.Drawing.Point(8, 47)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(901, 25)
        Me.PanelMenu.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButtonAdmin)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOperador)
        Me.GroupBox1.Location = New System.Drawing.Point(915, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 59)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Privilégios"
        Me.GroupBox1.Visible = False
        '
        'RadioButtonAdmin
        '
        Me.RadioButtonAdmin.AutoSize = True
        Me.RadioButtonAdmin.Checked = True
        Me.RadioButtonAdmin.Location = New System.Drawing.Point(5, 18)
        Me.RadioButtonAdmin.Name = "RadioButtonAdmin"
        Me.RadioButtonAdmin.Size = New System.Drawing.Size(88, 17)
        Me.RadioButtonAdmin.TabIndex = 9
        Me.RadioButtonAdmin.TabStop = True
        Me.RadioButtonAdmin.Text = "Administrador"
        Me.RadioButtonAdmin.UseVisualStyleBackColor = True
        '
        'RadioButtonOperador
        '
        Me.RadioButtonOperador.AutoSize = True
        Me.RadioButtonOperador.Location = New System.Drawing.Point(5, 40)
        Me.RadioButtonOperador.Name = "RadioButtonOperador"
        Me.RadioButtonOperador.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonOperador.TabIndex = 10
        Me.RadioButtonOperador.Text = "Operador"
        Me.RadioButtonOperador.UseVisualStyleBackColor = True
        '
        'LabelHome
        '
        Me.LabelHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelHome.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelHome.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.LabelHome.ForeColor = System.Drawing.Color.White
        Me.LabelHome.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul2
        Me.LabelHome.Location = New System.Drawing.Point(958, 9)
        Me.LabelHome.Name = "LabelHome"
        Me.LabelHome.Size = New System.Drawing.Size(25, 23)
        Me.LabelHome.TabIndex = 40
        Me.LabelHome.Text = "H"
        Me.LabelHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMin
        '
        Me.LabelMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMin.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMin.ForeColor = System.Drawing.Color.White
        Me.LabelMin.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul2
        Me.LabelMin.Location = New System.Drawing.Point(927, 9)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(25, 23)
        Me.LabelMin.TabIndex = 39
        Me.LabelMin.Text = "_"
        Me.LabelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClose
        '
        Me.LabelClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClose.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelClose.ForeColor = System.Drawing.Color.White
        Me.LabelClose.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul2
        Me.LabelClose.Location = New System.Drawing.Point(989, 10)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(25, 23)
        Me.LabelClose.TabIndex = 35
        Me.LabelClose.Text = "X"
        Me.LabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources._813df8d9
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'CabecalhoComando
        '
        Me.CabecalhoComando.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CabecalhoComando.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CabecalhoComando.ContextMenuStrip = Me.ContextMenuStripWindowMenuStrip
        Me.CabecalhoComando.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CabecalhoComando.ForeColor = System.Drawing.SystemColors.Window
        Me.CabecalhoComando.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul2
        Me.CabecalhoComando.Location = New System.Drawing.Point(5, 4)
        Me.CabecalhoComando.Name = "CabecalhoComando"
        Me.CabecalhoComando.Size = New System.Drawing.Size(1016, 36)
        Me.CabecalhoComando.TabIndex = 29
        Me.CabecalhoComando.Text = "Comando"
        Me.CabecalhoComando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComandoAvancado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LabelHome)
        Me.Controls.Add(Me.LabelMin)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.PanelTela)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.CabecalhoComando)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ComandoAvancado"
        Me.Text = "ComandoAvancado"
        Me.PanelTela.ResumeLayout(False)
        Me.PanelTela.PerformLayout()
        Me.ToolStripTela.ResumeLayout(False)
        Me.ToolStripTela.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanelComponentes.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStripComando.ResumeLayout(False)
        Me.StatusStripComando.PerformLayout()
        Me.ContextMenuStripComando.ResumeLayout(False)
        Me.ContextMenuStripWindowMenuStrip.ResumeLayout(False)
        Me.MenuStripComando.ResumeLayout(False)
        Me.MenuStripComando.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesativadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AtivadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcionamentoViaJoystickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesativadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtivadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcionamentoViaTecladoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelTela As Panel
    Friend WithEvents ParaEsquerdaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanelComponentes As TableLayoutPanel
    Friend WithEvents Componentes As TreeView
    Friend WithEvents Imagens As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStripComando As ContextMenuStrip
    Friend WithEvents LimparTelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CabecalhoComando As Label
    Friend WithEvents TimerAnimação As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents AcionamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParaDireitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenomearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparTelaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStripComando As MenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesfazerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefazerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RecortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PropriedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents MoverControleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxOffSet As ToolStripTextBox
    Friend WithEvents ParaCimaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParaBaixoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonAdmin As RadioButton
    Friend WithEvents RadioButtonOperador As RadioButton
    Friend WithEvents LabelClose As Label
    Friend WithEvents ContextMenuStripWindowMenuStrip As ContextMenuStrip
    Friend WithEvents AncorarÀEsquerdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AncorarÀDireitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTela As ToolStrip
    Friend WithEvents ToolStripButtonNovaTela As ToolStripButton
    Friend WithEvents ToolStripComboBoxSelecionaTela As ToolStripComboBox
    Friend WithEvents ToolStripButtonSalvar As ToolStripButton
    Friend WithEvents ToolStripButtonRenomear As ToolStripButton
    Friend WithEvents ToolStripButtonLimpaTela As ToolStripButton
    Friend WithEvents ToolStripButtonDeletar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButtonReverterTudo As ToolStripButton
    Friend WithEvents ToolStripButtonReverter As ToolStripButton
    Friend WithEvents ToolStripButtonRefazer As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButtonAlinharHorizontal As ToolStripButton
    Friend WithEvents ToolStripButtonAlinharVertical As ToolStripButton
    Friend WithEvents ToolStripButtonTrazerParaFrente As ToolStripButton
    Friend WithEvents ToolStripButtonEnviarParaTrás As ToolStripButton
    Friend WithEvents ToolStripButtonTamHorizontal As ToolStripButton
    Friend WithEvents ToolStripButtonTamVertical As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ComunicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarPortaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConectarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PropriedadesTelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModoJanelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModoTelaCheiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelMin As Label
    Friend WithEvents ToolStripButtonExecutar As ToolStripButton
    Friend WithEvents ToolStripComboBoxModo As ToolStripComboBox
    Friend WithEvents ClonarTelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelComando As Panel
    Friend WithEvents StatusStripComando As StatusStrip
    Friend WithEvents ToolStripStatusMousePos As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusItemSelecionado As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusSize As ToolStripStatusLabel
    Friend WithEvents CódigoDeProgramaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCódigoParaLeituraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCódigoParaEscritaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçãoAoClicarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçãoAoAtivarOComponentechamadaDoProcedimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBoxRegistrador As ToolStripComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelHome As Label
    Friend WithEvents tsmiConnect As ToolStripButton
End Class
