<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControleHardware
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.LabelRotulo = New System.Windows.Forms.Label()
        Me.ContextMenuStripControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramaçãoArduinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLeitura = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImplementarCódigoescritaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarCódigoParaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçãoAoClicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeituraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscritaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarEndereçoDoComponenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparRascunhoDeCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GatilhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditarTamanhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamanhoNoEixoXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxTamX = New System.Windows.Forms.ToolStripTextBox()
        Me.TamanhoNoEixoYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxTamY = New System.Windows.Forms.ToolStripTextBox()
        Me.CopiarTamanhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarTamanhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPosiçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosiçãoNoEixoXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxPosX = New System.Windows.Forms.ToolStripTextBox()
        Me.PosiçãoNoEixoYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxPosY = New System.Windows.Forms.ToolStripTextBox()
        Me.AlinhamentoDoControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlinharAoCentroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AncorarADireitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AncorarAEsquerdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AncorarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AncorarAoTopoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BloquearControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrazerParaFrenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarParaTrásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarDatabaseParaATelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarDatabaseParaATelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropriedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.TrackBarSaidaAnalogica = New System.Windows.Forms.TrackBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTipInfoPorta = New System.Windows.Forms.ToolTip(Me.components)
        Me.BarraGrafica = New System.Windows.Forms.Label()
        Me.TimerAtualizaStatus = New System.Windows.Forms.Timer(Me.components)
        Me.VideoSourcePlayer = New AForge.Controls.VideoSourcePlayer()
        Me.Grafico = New ArduinoSuite.Grafico()
        Me.ContextMenuStripControl.SuspendLayout()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarSaidaAnalogica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelRotulo
        '
        Me.LabelRotulo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRotulo.ContextMenuStrip = Me.ContextMenuStripControl
        Me.LabelRotulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelRotulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelRotulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelRotulo.Name = "LabelRotulo"
        Me.LabelRotulo.Size = New System.Drawing.Size(131, 19)
        Me.LabelRotulo.TabIndex = 3
        Me.LabelRotulo.Text = "Novo Controle"
        Me.LabelRotulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStripControl
        '
        Me.ContextMenuStripControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaçãoArduinoToolStripMenuItem, Me.GatilhoToolStripMenuItem, Me.ToolStripSeparator5, Me.EditarTamanhoToolStripMenuItem, Me.EditarPosiçãoToolStripMenuItem, Me.AlinhamentoDoControleToolStripMenuItem, Me.ToolStripSeparator4, Me.BloquearControleToolStripMenuItem, Me.ToolStripSeparator3, Me.TrazerParaFrenteToolStripMenuItem, Me.EnviarParaTrásToolStripMenuItem, Me.ToolStripSeparator2, Me.RecortarToolStripMenuItem1, Me.CopiarToolStripMenuItem, Me.DeletarToolStripMenuItem, Me.ToolStripSeparator1, Me.DatabaseToolStripMenuItem, Me.ToolStripSeparator6, Me.PropriedadesToolStripMenuItem})
        Me.ContextMenuStripControl.Name = "ContextMenuStrip"
        Me.ContextMenuStripControl.Size = New System.Drawing.Size(210, 348)
        '
        'ProgramaçãoArduinoToolStripMenuItem
        '
        Me.ProgramaçãoArduinoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemLeitura, Me.ImplementarCódigoescritaToolStripMenuItem, Me.CopiarCódigoParaToolStripMenuItem})
        Me.ProgramaçãoArduinoToolStripMenuItem.Name = "ProgramaçãoArduinoToolStripMenuItem"
        Me.ProgramaçãoArduinoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ProgramaçãoArduinoToolStripMenuItem.Text = "Código de Programação"
        '
        'ToolStripMenuItemLeitura
        '
        Me.ToolStripMenuItemLeitura.Name = "ToolStripMenuItemLeitura"
        Me.ToolStripMenuItemLeitura.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItemLeitura.Text = "Ir para o código (leitura)"
        Me.ToolStripMenuItemLeitura.ToolTipText = "Ir para, ou implementar um código para ler o componente"
        '
        'ImplementarCódigoescritaToolStripMenuItem
        '
        Me.ImplementarCódigoescritaToolStripMenuItem.Name = "ImplementarCódigoescritaToolStripMenuItem"
        Me.ImplementarCódigoescritaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ImplementarCódigoescritaToolStripMenuItem.Text = "Ir para o código (escrita)"
        Me.ImplementarCódigoescritaToolStripMenuItem.ToolTipText = "Ir para, ou implementar um código para escrever no componente"
        '
        'CopiarCódigoParaToolStripMenuItem
        '
        Me.CopiarCódigoParaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem, Me.AçãoAoClicarToolStripMenuItem, Me.LeituraToolStripMenuItem, Me.EscritaToolStripMenuItem, Me.CopiarEndereçoDoComponenteToolStripMenuItem, Me.LimparRascunhoDeCódigoToolStripMenuItem})
        Me.CopiarCódigoParaToolStripMenuItem.Name = "CopiarCódigoParaToolStripMenuItem"
        Me.CopiarCódigoParaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CopiarCódigoParaToolStripMenuItem.Text = "Copiar código para"
        Me.CopiarCódigoParaToolStripMenuItem.Visible = False
        '
        'AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem
        '
        Me.AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem.Name = "AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem"
        Me.AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem.Text = "Ação ao Ativar o Componente (chamada do procedimento)"
        '
        'AçãoAoClicarToolStripMenuItem
        '
        Me.AçãoAoClicarToolStripMenuItem.Name = "AçãoAoClicarToolStripMenuItem"
        Me.AçãoAoClicarToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AçãoAoClicarToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.AçãoAoClicarToolStripMenuItem.Text = "Ação ao Ativar o Componente (procedimento completo)"
        '
        'LeituraToolStripMenuItem
        '
        Me.LeituraToolStripMenuItem.Name = "LeituraToolStripMenuItem"
        Me.LeituraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.LeituraToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.LeituraToolStripMenuItem.Text = "Leitura"
        '
        'EscritaToolStripMenuItem
        '
        Me.EscritaToolStripMenuItem.Name = "EscritaToolStripMenuItem"
        Me.EscritaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.EscritaToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.EscritaToolStripMenuItem.Text = "Escrita"
        '
        'CopiarEndereçoDoComponenteToolStripMenuItem
        '
        Me.CopiarEndereçoDoComponenteToolStripMenuItem.Name = "CopiarEndereçoDoComponenteToolStripMenuItem"
        Me.CopiarEndereçoDoComponenteToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.CopiarEndereçoDoComponenteToolStripMenuItem.Text = "Endereço do componente"
        '
        'LimparRascunhoDeCódigoToolStripMenuItem
        '
        Me.LimparRascunhoDeCódigoToolStripMenuItem.Name = "LimparRascunhoDeCódigoToolStripMenuItem"
        Me.LimparRascunhoDeCódigoToolStripMenuItem.Size = New System.Drawing.Size(448, 22)
        Me.LimparRascunhoDeCódigoToolStripMenuItem.Text = "Limpar rascunho de código"
        '
        'GatilhoToolStripMenuItem
        '
        Me.GatilhoToolStripMenuItem.Name = "GatilhoToolStripMenuItem"
        Me.GatilhoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GatilhoToolStripMenuItem.Text = "Editar Gatilho"
        Me.GatilhoToolStripMenuItem.ToolTipText = "Cria um gatilho condicional para permitir/bloquear o funcionamento deste controle" &
    ""
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(206, 6)
        '
        'EditarTamanhoToolStripMenuItem
        '
        Me.EditarTamanhoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TamanhoNoEixoXToolStripMenuItem, Me.TamanhoNoEixoYToolStripMenuItem, Me.CopiarTamanhoToolStripMenuItem, Me.ColarTamanhoToolStripMenuItem})
        Me.EditarTamanhoToolStripMenuItem.Name = "EditarTamanhoToolStripMenuItem"
        Me.EditarTamanhoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EditarTamanhoToolStripMenuItem.Text = "Editar Tamanho"
        '
        'TamanhoNoEixoXToolStripMenuItem
        '
        Me.TamanhoNoEixoXToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxTamX})
        Me.TamanhoNoEixoXToolStripMenuItem.Name = "TamanhoNoEixoXToolStripMenuItem"
        Me.TamanhoNoEixoXToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TamanhoNoEixoXToolStripMenuItem.Text = "Tamanho no Eixo X"
        '
        'ToolStripTextBoxTamX
        '
        Me.ToolStripTextBoxTamX.Name = "ToolStripTextBoxTamX"
        Me.ToolStripTextBoxTamX.Size = New System.Drawing.Size(100, 23)
        '
        'TamanhoNoEixoYToolStripMenuItem
        '
        Me.TamanhoNoEixoYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxTamY})
        Me.TamanhoNoEixoYToolStripMenuItem.Name = "TamanhoNoEixoYToolStripMenuItem"
        Me.TamanhoNoEixoYToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TamanhoNoEixoYToolStripMenuItem.Text = "Tamanho no Eixo Y"
        '
        'ToolStripTextBoxTamY
        '
        Me.ToolStripTextBoxTamY.Name = "ToolStripTextBoxTamY"
        Me.ToolStripTextBoxTamY.Size = New System.Drawing.Size(100, 23)
        '
        'CopiarTamanhoToolStripMenuItem
        '
        Me.CopiarTamanhoToolStripMenuItem.Name = "CopiarTamanhoToolStripMenuItem"
        Me.CopiarTamanhoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CopiarTamanhoToolStripMenuItem.Text = "Copiar Tamanho"
        '
        'ColarTamanhoToolStripMenuItem
        '
        Me.ColarTamanhoToolStripMenuItem.Name = "ColarTamanhoToolStripMenuItem"
        Me.ColarTamanhoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ColarTamanhoToolStripMenuItem.Text = "Colar Tamanho"
        '
        'EditarPosiçãoToolStripMenuItem
        '
        Me.EditarPosiçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PosiçãoNoEixoXToolStripMenuItem, Me.PosiçãoNoEixoYToolStripMenuItem})
        Me.EditarPosiçãoToolStripMenuItem.Name = "EditarPosiçãoToolStripMenuItem"
        Me.EditarPosiçãoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EditarPosiçãoToolStripMenuItem.Text = "Editar Posição"
        '
        'PosiçãoNoEixoXToolStripMenuItem
        '
        Me.PosiçãoNoEixoXToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxPosX})
        Me.PosiçãoNoEixoXToolStripMenuItem.Name = "PosiçãoNoEixoXToolStripMenuItem"
        Me.PosiçãoNoEixoXToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PosiçãoNoEixoXToolStripMenuItem.Text = "Posição no Eixo X"
        '
        'ToolStripTextBoxPosX
        '
        Me.ToolStripTextBoxPosX.Name = "ToolStripTextBoxPosX"
        Me.ToolStripTextBoxPosX.Size = New System.Drawing.Size(100, 23)
        '
        'PosiçãoNoEixoYToolStripMenuItem
        '
        Me.PosiçãoNoEixoYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxPosY})
        Me.PosiçãoNoEixoYToolStripMenuItem.Name = "PosiçãoNoEixoYToolStripMenuItem"
        Me.PosiçãoNoEixoYToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PosiçãoNoEixoYToolStripMenuItem.Text = "Posição no Eixo Y"
        '
        'ToolStripTextBoxPosY
        '
        Me.ToolStripTextBoxPosY.Name = "ToolStripTextBoxPosY"
        Me.ToolStripTextBoxPosY.Size = New System.Drawing.Size(100, 23)
        '
        'AlinhamentoDoControleToolStripMenuItem
        '
        Me.AlinhamentoDoControleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlinharAoCentroToolStripMenuItem, Me.AncorarADireitaToolStripMenuItem, Me.AncorarAEsquerdaToolStripMenuItem, Me.AncorarToolStripMenuItem, Me.AncorarAoTopoToolStripMenuItem})
        Me.AlinhamentoDoControleToolStripMenuItem.Name = "AlinhamentoDoControleToolStripMenuItem"
        Me.AlinhamentoDoControleToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AlinhamentoDoControleToolStripMenuItem.Text = "Alinhamento do Controle"
        '
        'AlinharAoCentroToolStripMenuItem
        '
        Me.AlinharAoCentroToolStripMenuItem.Name = "AlinharAoCentroToolStripMenuItem"
        Me.AlinharAoCentroToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AlinharAoCentroToolStripMenuItem.Text = "Alinhar ao Centro"
        '
        'AncorarADireitaToolStripMenuItem
        '
        Me.AncorarADireitaToolStripMenuItem.Name = "AncorarADireitaToolStripMenuItem"
        Me.AncorarADireitaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AncorarADireitaToolStripMenuItem.Text = "Ancorar a Direita"
        '
        'AncorarAEsquerdaToolStripMenuItem
        '
        Me.AncorarAEsquerdaToolStripMenuItem.Name = "AncorarAEsquerdaToolStripMenuItem"
        Me.AncorarAEsquerdaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AncorarAEsquerdaToolStripMenuItem.Text = "Ancorar a Esquerda"
        '
        'AncorarToolStripMenuItem
        '
        Me.AncorarToolStripMenuItem.Name = "AncorarToolStripMenuItem"
        Me.AncorarToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AncorarToolStripMenuItem.Text = "Ancorar ao canto Inferior"
        '
        'AncorarAoTopoToolStripMenuItem
        '
        Me.AncorarAoTopoToolStripMenuItem.Name = "AncorarAoTopoToolStripMenuItem"
        Me.AncorarAoTopoToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AncorarAoTopoToolStripMenuItem.Text = "Ancorar ao Topo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(206, 6)
        '
        'BloquearControleToolStripMenuItem
        '
        Me.BloquearControleToolStripMenuItem.Name = "BloquearControleToolStripMenuItem"
        Me.BloquearControleToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.BloquearControleToolStripMenuItem.Text = "Bloquear Controle"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(206, 6)
        '
        'TrazerParaFrenteToolStripMenuItem
        '
        Me.TrazerParaFrenteToolStripMenuItem.Name = "TrazerParaFrenteToolStripMenuItem"
        Me.TrazerParaFrenteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.TrazerParaFrenteToolStripMenuItem.Text = "Trazer Para Frente"
        '
        'EnviarParaTrásToolStripMenuItem
        '
        Me.EnviarParaTrásToolStripMenuItem.Name = "EnviarParaTrásToolStripMenuItem"
        Me.EnviarParaTrásToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EnviarParaTrásToolStripMenuItem.Text = "Enviar Para Trás"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(206, 6)
        '
        'RecortarToolStripMenuItem1
        '
        Me.RecortarToolStripMenuItem1.Name = "RecortarToolStripMenuItem1"
        Me.RecortarToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RecortarToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.RecortarToolStripMenuItem1.Text = "Recortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'DeletarToolStripMenuItem
        '
        Me.DeletarToolStripMenuItem.Name = "DeletarToolStripMenuItem"
        Me.DeletarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeletarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DeletarToolStripMenuItem.Text = "Deletar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem, Me.CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem, Me.CriarDatabaseParaATelaToolStripMenuItem, Me.CarregarDatabaseParaATelaToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        Me.DatabaseToolStripMenuItem.ToolTipText = "Salva os valores dos controles em um arquivo, que pode ser carregado posteriormen" &
    "te"
        '
        'CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem
        '
        Me.CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Name = "CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem"
        Me.CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Size = New System.Drawing.Size(333, 22)
        Me.CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Text = "Salvar database para os controles selecionados"
        '
        'CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem
        '
        Me.CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Name = "CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem"
        Me.CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Size = New System.Drawing.Size(333, 22)
        Me.CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem.Text = "Carregar database para os controles selecionados"
        '
        'CriarDatabaseParaATelaToolStripMenuItem
        '
        Me.CriarDatabaseParaATelaToolStripMenuItem.Name = "CriarDatabaseParaATelaToolStripMenuItem"
        Me.CriarDatabaseParaATelaToolStripMenuItem.Size = New System.Drawing.Size(333, 22)
        Me.CriarDatabaseParaATelaToolStripMenuItem.Text = "Salvar database para a tela"
        '
        'CarregarDatabaseParaATelaToolStripMenuItem
        '
        Me.CarregarDatabaseParaATelaToolStripMenuItem.Name = "CarregarDatabaseParaATelaToolStripMenuItem"
        Me.CarregarDatabaseParaATelaToolStripMenuItem.Size = New System.Drawing.Size(333, 22)
        Me.CarregarDatabaseParaATelaToolStripMenuItem.Text = "Carregar database para a tela"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(206, 6)
        '
        'PropriedadesToolStripMenuItem
        '
        Me.PropriedadesToolStripMenuItem.Name = "PropriedadesToolStripMenuItem"
        Me.PropriedadesToolStripMenuItem.ShortcutKeyDisplayString = "P"
        Me.PropriedadesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.PropriedadesToolStripMenuItem.Text = "Propriedades"
        '
        'PictureBoxStatus
        '
        Me.PictureBoxStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxStatus.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBoxStatus.ContextMenuStrip = Me.ContextMenuStripControl
        Me.PictureBoxStatus.Image = Global.ArduinoSuite.My.Resources.Resources.GreenLedOff
        Me.PictureBoxStatus.Location = New System.Drawing.Point(42, 59)
        Me.PictureBoxStatus.Name = "PictureBoxStatus"
        Me.PictureBoxStatus.Size = New System.Drawing.Size(86, 87)
        Me.PictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatus.TabIndex = 19
        Me.PictureBoxStatus.TabStop = False
        '
        'LabelValor
        '
        Me.LabelValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelValor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelValor.ContextMenuStrip = Me.ContextMenuStripControl
        Me.LabelValor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelValor.Location = New System.Drawing.Point(2, 152)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(50, 19)
        Me.LabelValor.TabIndex = 22
        Me.LabelValor.Text = "Valor:"
        Me.LabelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxValor.Location = New System.Drawing.Point(55, 152)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxValor.TabIndex = 21
        '
        'TrackBarSaidaAnalogica
        '
        Me.TrackBarSaidaAnalogica.Location = New System.Drawing.Point(3, 25)
        Me.TrackBarSaidaAnalogica.Maximum = 255
        Me.TrackBarSaidaAnalogica.Name = "TrackBarSaidaAnalogica"
        Me.TrackBarSaidaAnalogica.Size = New System.Drawing.Size(129, 45)
        Me.TrackBarSaidaAnalogica.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(67, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Desliga"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.ContextMenuStrip = Me.ContextMenuStripControl
        Me.Button1.Location = New System.Drawing.Point(2, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Liga"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTipInfoPorta
        '
        Me.ToolTipInfoPorta.AutoPopDelay = 15000
        Me.ToolTipInfoPorta.InitialDelay = 500
        Me.ToolTipInfoPorta.ReshowDelay = 100
        '
        'BarraGrafica
        '
        Me.BarraGrafica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarraGrafica.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BarraGrafica.Location = New System.Drawing.Point(43, 130)
        Me.BarraGrafica.Name = "BarraGrafica"
        Me.BarraGrafica.Size = New System.Drawing.Size(85, 15)
        Me.BarraGrafica.TabIndex = 26
        '
        'TimerAtualizaStatus
        '
        Me.TimerAtualizaStatus.Interval = 50
        '
        'VideoSourcePlayer
        '
        Me.VideoSourcePlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoSourcePlayer.ContextMenuStrip = Me.ContextMenuStripControl
        Me.VideoSourcePlayer.Location = New System.Drawing.Point(4, 24)
        Me.VideoSourcePlayer.Name = "VideoSourcePlayer"
        Me.VideoSourcePlayer.Size = New System.Drawing.Size(122, 176)
        Me.VideoSourcePlayer.TabIndex = 27
        Me.VideoSourcePlayer.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer.VideoSource = Nothing
        '
        'Grafico
        '
        Me.Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grafico.ContextMenuStrip = Me.ContextMenuStripControl
        Me.Grafico.Location = New System.Drawing.Point(4, 23)
        Me.Grafico.Name = "Grafico"
        Me.Grafico.Size = New System.Drawing.Size(122, 176)
        Me.Grafico.TabIndex = 28
        '
        'ControleHardware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.BarraGrafica)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxStatus)
        Me.Controls.Add(Me.LabelValor)
        Me.Controls.Add(Me.TextBoxValor)
        Me.Controls.Add(Me.TrackBarSaidaAnalogica)
        Me.Controls.Add(Me.LabelRotulo)
        Me.Controls.Add(Me.VideoSourcePlayer)
        Me.Controls.Add(Me.Grafico)
        Me.Name = "ControleHardware"
        Me.Size = New System.Drawing.Size(131, 204)
        Me.ContextMenuStripControl.ResumeLayout(False)
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarSaidaAnalogica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelRotulo As Label
    Friend WithEvents PictureBoxStatus As PictureBox
    Friend WithEvents LabelValor As Label
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents TrackBarSaidaAnalogica As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStripControl As ContextMenuStrip
    Friend WithEvents EditarTamanhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamanhoNoEixoXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxTamX As ToolStripTextBox
    Friend WithEvents TamanhoNoEixoYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxTamY As ToolStripTextBox
    Friend WithEvents CopiarTamanhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarTamanhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPosiçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PosiçãoNoEixoXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxPosX As ToolStripTextBox
    Friend WithEvents PosiçãoNoEixoYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxPosY As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BloquearControleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TrazerParaFrenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarParaTrásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DeletarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PropriedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTipInfoPorta As ToolTip
    Friend WithEvents BarraGrafica As Label
    Friend WithEvents TimerAtualizaStatus As Timer
    Public WithEvents VideoSourcePlayer As AForge.Controls.VideoSourcePlayer
    Friend WithEvents Grafico As Grafico
    Friend WithEvents ProgramaçãoArduinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AlinhamentoDoControleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlinharAoCentroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AncorarAEsquerdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AncorarADireitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AncorarAoTopoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AncorarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecortarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCódigoParaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçãoAoAtivarOComponenteapenasONomeDaRotinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeituraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscritaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarEndereçoDoComponenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparRascunhoDeCódigoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçãoAoClicarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriarDatabaseParaOsControlesSelecionadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents CarregarDatabaseParaOsControlesSelecionadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriarDatabaseParaATelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarregarDatabaseParaATelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImplementarCódigoescritaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GatilhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLeitura As ToolStripMenuItem
End Class
