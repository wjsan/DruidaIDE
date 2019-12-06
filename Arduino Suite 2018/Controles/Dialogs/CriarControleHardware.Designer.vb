<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CriarControleHardware
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxTipVisivel = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxTrackBarEnable = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTrackBarVertical = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTrackBarHorizontal = New System.Windows.Forms.RadioButton()
        Me.CheckBoxTrackBarInvert = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBarGraphEnable = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelBarGraphColor = New System.Windows.Forms.Label()
        Me.RadioButtonBarGraphVertical = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBarGraphHorizontal = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxAnalogValor = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBotao1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBotao2 = New System.Windows.Forms.CheckBox()
        Me.TextBoxRotulo = New System.Windows.Forms.TextBox()
        Me.TextBoxBotao1 = New System.Windows.Forms.TextBox()
        Me.TextBoxBotao2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxSelPorta = New System.Windows.Forms.ComboBox()
        Me.LabelRotuloCor = New System.Windows.Forms.Label()
        Me.CheckBoxRotulo = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTipo = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarControlesExistentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarImagensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Imagem0SinalInativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Imagem1SinalAtivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Imagem2SinalDeFalhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonRet = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPushButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton2Bt = New System.Windows.Forms.RadioButton()
        Me.Escala = New System.Windows.Forms.GroupBox()
        Me.TextBoxUnit = New System.Windows.Forms.TextBox()
        Me.TextBoxMax = New System.Windows.Forms.TextBox()
        Me.TextBoxMin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ControleHardwarePreview = New ArduinoSuite.ControleHardware()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Escala.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57983!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.42017!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(473, 423)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(137, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(61, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(70, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(63, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Porta:"
        '
        'CheckBoxTipVisivel
        '
        Me.CheckBoxTipVisivel.AutoSize = True
        Me.CheckBoxTipVisivel.Location = New System.Drawing.Point(152, 39)
        Me.CheckBoxTipVisivel.Name = "CheckBoxTipVisivel"
        Me.CheckBoxTipVisivel.Size = New System.Drawing.Size(104, 17)
        Me.CheckBoxTipVisivel.TabIndex = 3
        Me.CheckBoxTipVisivel.Text = "Tip Porta Visível"
        Me.CheckBoxTipVisivel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cor do Rótulo:"
        '
        'CheckBoxTrackBarEnable
        '
        Me.CheckBoxTrackBarEnable.AutoSize = True
        Me.CheckBoxTrackBarEnable.Location = New System.Drawing.Point(44, 130)
        Me.CheckBoxTrackBarEnable.Name = "CheckBoxTrackBarEnable"
        Me.CheckBoxTrackBarEnable.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxTrackBarEnable.TabIndex = 3
        Me.CheckBoxTrackBarEnable.Text = "Track Bar"
        Me.CheckBoxTrackBarEnable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonTrackBarVertical)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTrackBarHorizontal)
        Me.GroupBox1.Controls.Add(Me.CheckBoxTrackBarInvert)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 88)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "2"
        Me.GroupBox1.Text = "Orientação Track Bar"
        '
        'RadioButtonTrackBarVertical
        '
        Me.RadioButtonTrackBarVertical.AutoSize = True
        Me.RadioButtonTrackBarVertical.Location = New System.Drawing.Point(6, 43)
        Me.RadioButtonTrackBarVertical.Name = "RadioButtonTrackBarVertical"
        Me.RadioButtonTrackBarVertical.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonTrackBarVertical.TabIndex = 0
        Me.RadioButtonTrackBarVertical.Text = "Vertical"
        Me.RadioButtonTrackBarVertical.UseVisualStyleBackColor = True
        '
        'RadioButtonTrackBarHorizontal
        '
        Me.RadioButtonTrackBarHorizontal.AutoSize = True
        Me.RadioButtonTrackBarHorizontal.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonTrackBarHorizontal.Name = "RadioButtonTrackBarHorizontal"
        Me.RadioButtonTrackBarHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.RadioButtonTrackBarHorizontal.TabIndex = 0
        Me.RadioButtonTrackBarHorizontal.Text = "Horizontal"
        Me.RadioButtonTrackBarHorizontal.UseVisualStyleBackColor = True
        '
        'CheckBoxTrackBarInvert
        '
        Me.CheckBoxTrackBarInvert.AutoSize = True
        Me.CheckBoxTrackBarInvert.Location = New System.Drawing.Point(6, 67)
        Me.CheckBoxTrackBarInvert.Name = "CheckBoxTrackBarInvert"
        Me.CheckBoxTrackBarInvert.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxTrackBarInvert.TabIndex = 3
        Me.CheckBoxTrackBarInvert.Text = "Inverter Sentido"
        Me.CheckBoxTrackBarInvert.UseVisualStyleBackColor = True
        '
        'CheckBoxBarGraphEnable
        '
        Me.CheckBoxBarGraphEnable.AutoSize = True
        Me.CheckBoxBarGraphEnable.Location = New System.Drawing.Point(178, 130)
        Me.CheckBoxBarGraphEnable.Name = "CheckBoxBarGraphEnable"
        Me.CheckBoxBarGraphEnable.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxBarGraphEnable.TabIndex = 3
        Me.CheckBoxBarGraphEnable.Text = "Bar Graph"
        Me.CheckBoxBarGraphEnable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelBarGraphColor)
        Me.GroupBox2.Controls.Add(Me.RadioButtonBarGraphVertical)
        Me.GroupBox2.Controls.Add(Me.RadioButtonBarGraphHorizontal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 88)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "2"
        Me.GroupBox2.Text = "Orientação Bar Graph"
        '
        'LabelBarGraphColor
        '
        Me.LabelBarGraphColor.AutoSize = True
        Me.LabelBarGraphColor.BackColor = System.Drawing.Color.LimeGreen
        Me.LabelBarGraphColor.Location = New System.Drawing.Point(31, 68)
        Me.LabelBarGraphColor.Name = "LabelBarGraphColor"
        Me.LabelBarGraphColor.Size = New System.Drawing.Size(35, 13)
        Me.LabelBarGraphColor.TabIndex = 8
        Me.LabelBarGraphColor.Text = "Verde"
        '
        'RadioButtonBarGraphVertical
        '
        Me.RadioButtonBarGraphVertical.AutoSize = True
        Me.RadioButtonBarGraphVertical.Location = New System.Drawing.Point(8, 43)
        Me.RadioButtonBarGraphVertical.Name = "RadioButtonBarGraphVertical"
        Me.RadioButtonBarGraphVertical.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonBarGraphVertical.TabIndex = 0
        Me.RadioButtonBarGraphVertical.Text = "Vertical"
        Me.RadioButtonBarGraphVertical.UseVisualStyleBackColor = True
        '
        'RadioButtonBarGraphHorizontal
        '
        Me.RadioButtonBarGraphHorizontal.AutoSize = True
        Me.RadioButtonBarGraphHorizontal.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonBarGraphHorizontal.Name = "RadioButtonBarGraphHorizontal"
        Me.RadioButtonBarGraphHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.RadioButtonBarGraphHorizontal.TabIndex = 0
        Me.RadioButtonBarGraphHorizontal.Text = "Horizontal"
        Me.RadioButtonBarGraphHorizontal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cor:"
        '
        'CheckBoxAnalogValor
        '
        Me.CheckBoxAnalogValor.AutoSize = True
        Me.CheckBoxAnalogValor.Location = New System.Drawing.Point(42, 304)
        Me.CheckBoxAnalogValor.Name = "CheckBoxAnalogValor"
        Me.CheckBoxAnalogValor.Size = New System.Drawing.Size(100, 17)
        Me.CheckBoxAnalogValor.TabIndex = 3
        Me.CheckBoxAnalogValor.Text = "Valor Analógico"
        Me.CheckBoxAnalogValor.UseVisualStyleBackColor = True
        '
        'CheckBoxBotao1
        '
        Me.CheckBoxBotao1.AutoSize = True
        Me.CheckBoxBotao1.Location = New System.Drawing.Point(42, 328)
        Me.CheckBoxBotao1.Name = "CheckBoxBotao1"
        Me.CheckBoxBotao1.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxBotao1.TabIndex = 3
        Me.CheckBoxBotao1.Text = "Botão 1:"
        Me.CheckBoxBotao1.UseVisualStyleBackColor = True
        '
        'CheckBoxBotao2
        '
        Me.CheckBoxBotao2.AutoSize = True
        Me.CheckBoxBotao2.Location = New System.Drawing.Point(42, 351)
        Me.CheckBoxBotao2.Name = "CheckBoxBotao2"
        Me.CheckBoxBotao2.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxBotao2.TabIndex = 3
        Me.CheckBoxBotao2.Text = "Botão 2:"
        Me.CheckBoxBotao2.UseVisualStyleBackColor = True
        '
        'TextBoxRotulo
        '
        Me.TextBoxRotulo.Location = New System.Drawing.Point(110, 77)
        Me.TextBoxRotulo.Name = "TextBoxRotulo"
        Me.TextBoxRotulo.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxRotulo.TabIndex = 6
        Me.TextBoxRotulo.Text = "Novo Controle 1"
        '
        'TextBoxBotao1
        '
        Me.TextBoxBotao1.Location = New System.Drawing.Point(107, 326)
        Me.TextBoxBotao1.Name = "TextBoxBotao1"
        Me.TextBoxBotao1.Size = New System.Drawing.Size(48, 20)
        Me.TextBoxBotao1.TabIndex = 6
        Me.TextBoxBotao1.Text = "Liga"
        '
        'TextBoxBotao2
        '
        Me.TextBoxBotao2.Location = New System.Drawing.Point(107, 349)
        Me.TextBoxBotao2.Name = "TextBoxBotao2"
        Me.TextBoxBotao2.Size = New System.Drawing.Size(48, 20)
        Me.TextBoxBotao2.TabIndex = 6
        Me.TextBoxBotao2.Text = "Desliga"
        '
        'ComboBoxSelPorta
        '
        Me.ComboBoxSelPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelPorta.FormattingEnabled = True
        Me.ComboBoxSelPorta.Location = New System.Drawing.Point(70, 36)
        Me.ComboBoxSelPorta.Name = "ComboBoxSelPorta"
        Me.ComboBoxSelPorta.Size = New System.Drawing.Size(66, 21)
        Me.ComboBoxSelPorta.TabIndex = 7
        '
        'LabelRotuloCor
        '
        Me.LabelRotuloCor.AutoSize = True
        Me.LabelRotuloCor.BackColor = System.Drawing.Color.RoyalBlue
        Me.LabelRotuloCor.Location = New System.Drawing.Point(115, 104)
        Me.LabelRotuloCor.Name = "LabelRotuloCor"
        Me.LabelRotuloCor.Size = New System.Drawing.Size(27, 13)
        Me.LabelRotuloCor.TabIndex = 8
        Me.LabelRotuloCor.Text = "Azul"
        '
        'CheckBoxRotulo
        '
        Me.CheckBoxRotulo.AutoSize = True
        Me.CheckBoxRotulo.Location = New System.Drawing.Point(44, 79)
        Me.CheckBoxRotulo.Name = "CheckBoxRotulo"
        Me.CheckBoxRotulo.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxRotulo.TabIndex = 9
        Me.CheckBoxRotulo.Text = "Rotulo:"
        Me.CheckBoxRotulo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipo:"
        '
        'TextBoxTipo
        '
        Me.TextBoxTipo.Location = New System.Drawing.Point(70, 3)
        Me.TextBoxTipo.Name = "TextBoxTipo"
        Me.TextBoxTipo.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxTipo.TabIndex = 6
        Me.TextBoxTipo.Text = "Novo Controle"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(616, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.EditarControlesExistentesToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.SalvarComoToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Novo
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Abrir
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'EditarControlesExistentesToolStripMenuItem
        '
        Me.EditarControlesExistentesToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Componentes
        Me.EditarControlesExistentesToolStripMenuItem.Name = "EditarControlesExistentesToolStripMenuItem"
        Me.EditarControlesExistentesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EditarControlesExistentesToolStripMenuItem.Text = "Editar Controles Existentes"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'SalvarComoToolStripMenuItem
        '
        Me.SalvarComoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar_Como
        Me.SalvarComoToolStripMenuItem.Name = "SalvarComoToolStripMenuItem"
        Me.SalvarComoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SalvarComoToolStripMenuItem.Text = "Salvar Como"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.logout_icon_icons_com_51025
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarImagensToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'AlterarImagensToolStripMenuItem
        '
        Me.AlterarImagensToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Imagem0SinalInativoToolStripMenuItem, Me.Imagem1SinalAtivoToolStripMenuItem, Me.Imagem2SinalDeFalhaToolStripMenuItem})
        Me.AlterarImagensToolStripMenuItem.Name = "AlterarImagensToolStripMenuItem"
        Me.AlterarImagensToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AlterarImagensToolStripMenuItem.Text = "Alterar Imagens"
        '
        'Imagem0SinalInativoToolStripMenuItem
        '
        Me.Imagem0SinalInativoToolStripMenuItem.Name = "Imagem0SinalInativoToolStripMenuItem"
        Me.Imagem0SinalInativoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.Imagem0SinalInativoToolStripMenuItem.Text = "Imagem 0 - (Sinal Inativo)"
        '
        'Imagem1SinalAtivoToolStripMenuItem
        '
        Me.Imagem1SinalAtivoToolStripMenuItem.Name = "Imagem1SinalAtivoToolStripMenuItem"
        Me.Imagem1SinalAtivoToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.Imagem1SinalAtivoToolStripMenuItem.Text = "Imagem 1 - (Sinal Ativo)"
        '
        'Imagem2SinalDeFalhaToolStripMenuItem
        '
        Me.Imagem2SinalDeFalhaToolStripMenuItem.Name = "Imagem2SinalDeFalhaToolStripMenuItem"
        Me.Imagem2SinalDeFalhaToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.Imagem2SinalDeFalhaToolStripMenuItem.Text = "Imagem 2 - (Sinal de Falha)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Estado:"
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"Inativo", "Ativo", "Falha"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(123, 61)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(73, 21)
        Me.ComboBoxEstado.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonRet)
        Me.GroupBox3.Controls.Add(Me.RadioButtonPushButton)
        Me.GroupBox3.Controls.Add(Me.RadioButton2Bt)
        Me.GroupBox3.Location = New System.Drawing.Point(175, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 96)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Funcionamento Botão:"
        '
        'RadioButtonRet
        '
        Me.RadioButtonRet.AutoSize = True
        Me.RadioButtonRet.Location = New System.Drawing.Point(13, 69)
        Me.RadioButtonRet.Name = "RadioButtonRet"
        Me.RadioButtonRet.Size = New System.Drawing.Size(91, 17)
        Me.RadioButtonRet.TabIndex = 0
        Me.RadioButtonRet.TabStop = True
        Me.RadioButtonRet.Text = "Com retenção"
        Me.RadioButtonRet.UseVisualStyleBackColor = True
        '
        'RadioButtonPushButton
        '
        Me.RadioButtonPushButton.AutoSize = True
        Me.RadioButtonPushButton.Location = New System.Drawing.Point(13, 45)
        Me.RadioButtonPushButton.Name = "RadioButtonPushButton"
        Me.RadioButtonPushButton.Size = New System.Drawing.Size(83, 17)
        Me.RadioButtonPushButton.TabIndex = 0
        Me.RadioButtonPushButton.TabStop = True
        Me.RadioButtonPushButton.Text = "Push-Button"
        Me.RadioButtonPushButton.UseVisualStyleBackColor = True
        '
        'RadioButton2Bt
        '
        Me.RadioButton2Bt.AutoSize = True
        Me.RadioButton2Bt.Location = New System.Drawing.Point(13, 21)
        Me.RadioButton2Bt.Name = "RadioButton2Bt"
        Me.RadioButton2Bt.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton2Bt.TabIndex = 0
        Me.RadioButton2Bt.TabStop = True
        Me.RadioButton2Bt.Text = "2  Botões"
        Me.RadioButton2Bt.UseVisualStyleBackColor = True
        '
        'Escala
        '
        Me.Escala.Controls.Add(Me.TextBoxUnit)
        Me.Escala.Controls.Add(Me.TextBoxMax)
        Me.Escala.Controls.Add(Me.TextBoxMin)
        Me.Escala.Controls.Add(Me.Label8)
        Me.Escala.Controls.Add(Me.Label7)
        Me.Escala.Controls.Add(Me.Label6)
        Me.Escala.Location = New System.Drawing.Point(41, 251)
        Me.Escala.Name = "Escala"
        Me.Escala.Size = New System.Drawing.Size(271, 47)
        Me.Escala.TabIndex = 15
        Me.Escala.TabStop = False
        Me.Escala.Text = "Escala"
        '
        'TextBoxUnit
        '
        Me.TextBoxUnit.Location = New System.Drawing.Point(226, 18)
        Me.TextBoxUnit.Name = "TextBoxUnit"
        Me.TextBoxUnit.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxUnit.TabIndex = 16
        '
        'TextBoxMax
        '
        Me.TextBoxMax.Location = New System.Drawing.Point(119, 18)
        Me.TextBoxMax.Name = "TextBoxMax"
        Me.TextBoxMax.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxMax.TabIndex = 16
        '
        'TextBoxMin
        '
        Me.TextBoxMin.Location = New System.Drawing.Point(34, 18)
        Me.TextBoxMin.Name = "TextBoxMin"
        Me.TextBoxMin.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxMin.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Unidade:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Máx:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Min:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Escala)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTipo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxRotulo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxTipVisivel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelRotuloCor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxTrackBarEnable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxSelPorta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxBarGraphEnable)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxBotao2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxAnalogValor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxBotao1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxBotao1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxBotao2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxRotulo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ControleHardwarePreview)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBoxEstado)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Size = New System.Drawing.Size(616, 390)
        Me.SplitContainer1.SplitterDistance = 344
        Me.SplitContainer1.TabIndex = 16
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(616, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(23, 17)
        Me.ToolStripStatusLabel1.Text = "OK"
        '
        'ControleHardwarePreview
        '
        Me.ControleHardwarePreview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ControleHardwarePreview.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ControleHardwarePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ControleHardwarePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ControleHardwarePreview.Location = New System.Drawing.Point(74, 128)
        Me.ControleHardwarePreview.Name = "ControleHardwarePreview"
        Me.ControleHardwarePreview.Size = New System.Drawing.Size(131, 204)
        Me.ControleHardwarePreview.TabIndex = 1
        '
        'CriarControleHardware
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(616, 482)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CriarControleHardware"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criar Controle Personalizado - Novo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Escala.ResumeLayout(False)
        Me.Escala.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxTipVisivel As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBoxTrackBarEnable As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonTrackBarVertical As RadioButton
    Friend WithEvents RadioButtonTrackBarHorizontal As RadioButton
    Friend WithEvents CheckBoxTrackBarInvert As CheckBox
    Friend WithEvents CheckBoxBarGraphEnable As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonBarGraphVertical As RadioButton
    Friend WithEvents RadioButtonBarGraphHorizontal As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxAnalogValor As CheckBox
    Friend WithEvents CheckBoxBotao1 As CheckBox
    Friend WithEvents CheckBoxBotao2 As CheckBox
    Friend WithEvents TextBoxRotulo As TextBox
    Friend WithEvents TextBoxBotao1 As TextBox
    Friend WithEvents TextBoxBotao2 As TextBox
    Friend WithEvents ComboBoxSelPorta As ComboBox
    Friend WithEvents LabelRotuloCor As Label
    Friend WithEvents LabelBarGraphColor As Label
    Friend WithEvents CheckBoxRotulo As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTipo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarImagensToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Imagem0SinalInativoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Imagem1SinalAtivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Imagem2SinalDeFalhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Public WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonRet As RadioButton
    Friend WithEvents RadioButtonPushButton As RadioButton
    Friend WithEvents RadioButton2Bt As RadioButton
    Friend WithEvents Escala As GroupBox
    Friend WithEvents TextBoxMax As TextBox
    Friend WithEvents TextBoxMin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxUnit As TextBox
    Friend WithEvents EditarControlesExistentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleHardwarePreview As ControleHardware
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
