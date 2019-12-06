<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestarApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestarApp))
        Me.PanelComando = New System.Windows.Forms.Panel()
        Me.ContextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComunicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecionarPortaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarDesconectarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcionamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivarJoystickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesativadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarJoystickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesativadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlarmesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharAplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelComando
        '
        Me.PanelComando.AllowDrop = True
        Me.PanelComando.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelComando.AutoScroll = True
        Me.PanelComando.BackColor = System.Drawing.Color.White
        Me.PanelComando.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelComando.ContextMenuStrip = Me.ContextMenuStripOptions
        Me.PanelComando.Location = New System.Drawing.Point(0, 0)
        Me.PanelComando.Name = "PanelComando"
        Me.PanelComando.Size = New System.Drawing.Size(762, 649)
        Me.PanelComando.TabIndex = 22
        '
        'ContextMenuStripOptions
        '
        Me.ContextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComunicaçãoToolStripMenuItem, Me.AcionamentosToolStripMenuItem, Me.AlarmesToolStripMenuItem, Me.FecharAplicaçãoToolStripMenuItem})
        Me.ContextMenuStripOptions.Name = "ContextMenuStripOptions"
        Me.ContextMenuStripOptions.Size = New System.Drawing.Size(152, 92)
        '
        'ComunicaçãoToolStripMenuItem
        '
        Me.ComunicaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelecionarPortaToolStripMenuItem, Me.ConectarDesconectarToolStripMenuItem})
        Me.ComunicaçãoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.images8PCHE2EJ
        Me.ComunicaçãoToolStripMenuItem.Name = "ComunicaçãoToolStripMenuItem"
        Me.ComunicaçãoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ComunicaçãoToolStripMenuItem.Text = "Comunicação"
        '
        'SelecionarPortaToolStripMenuItem
        '
        Me.SelecionarPortaToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Porta_Aberta
        Me.SelecionarPortaToolStripMenuItem.Name = "SelecionarPortaToolStripMenuItem"
        Me.SelecionarPortaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SelecionarPortaToolStripMenuItem.Text = "Selecionar Porta"
        '
        'ConectarDesconectarToolStripMenuItem
        '
        Me.ConectarDesconectarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.spm_icon_256
        Me.ConectarDesconectarToolStripMenuItem.Name = "ConectarDesconectarToolStripMenuItem"
        Me.ConectarDesconectarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConectarDesconectarToolStripMenuItem.Text = "Conectar/Desconectar"
        '
        'AcionamentosToolStripMenuItem
        '
        Me.AcionamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivarJoystickToolStripMenuItem, Me.ConfigurarJoystickToolStripMenuItem})
        Me.AcionamentosToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources._813df8d91
        Me.AcionamentosToolStripMenuItem.Name = "AcionamentosToolStripMenuItem"
        Me.AcionamentosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AcionamentosToolStripMenuItem.Text = "Acionamentos"
        '
        'AtivarJoystickToolStripMenuItem
        '
        Me.AtivarJoystickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivadoToolStripMenuItem, Me.DesativadoToolStripMenuItem})
        Me.AtivarJoystickToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Teclado
        Me.AtivarJoystickToolStripMenuItem.Name = "AtivarJoystickToolStripMenuItem"
        Me.AtivarJoystickToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AtivarJoystickToolStripMenuItem.Text = "Teclado"
        '
        'AtivadoToolStripMenuItem
        '
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
        'ConfigurarJoystickToolStripMenuItem
        '
        Me.ConfigurarJoystickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivadoToolStripMenuItem1, Me.DesativadoToolStripMenuItem1, Me.ConfigurarToolStripMenuItem})
        Me.ConfigurarJoystickToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.xOneController
        Me.ConfigurarJoystickToolStripMenuItem.Name = "ConfigurarJoystickToolStripMenuItem"
        Me.ConfigurarJoystickToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ConfigurarJoystickToolStripMenuItem.Text = "Joystick"
        '
        'AtivadoToolStripMenuItem1
        '
        Me.AtivadoToolStripMenuItem1.Name = "AtivadoToolStripMenuItem1"
        Me.AtivadoToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.AtivadoToolStripMenuItem1.Text = "Ativado"
        '
        'DesativadoToolStripMenuItem1
        '
        Me.DesativadoToolStripMenuItem1.Name = "DesativadoToolStripMenuItem1"
        Me.DesativadoToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.DesativadoToolStripMenuItem1.Text = "Desativado"
        '
        'ConfigurarToolStripMenuItem
        '
        Me.ConfigurarToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Setting_icon
        Me.ConfigurarToolStripMenuItem.Name = "ConfigurarToolStripMenuItem"
        Me.ConfigurarToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ConfigurarToolStripMenuItem.Text = "Configurar"
        '
        'AlarmesToolStripMenuItem
        '
        Me.AlarmesToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources._392ae9cfa4b776ec2eac86fe92f7f3a6_ilustra__o_de_luz_de_alarme_de_bombeiro
        Me.AlarmesToolStripMenuItem.Name = "AlarmesToolStripMenuItem"
        Me.AlarmesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AlarmesToolStripMenuItem.Text = "Alarmes"
        '
        'FecharAplicaçãoToolStripMenuItem
        '
        Me.FecharAplicaçãoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources._2013_06_13_televizija_na_off_16377
        Me.FecharAplicaçãoToolStripMenuItem.Name = "FecharAplicaçãoToolStripMenuItem"
        Me.FecharAplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FecharAplicaçãoToolStripMenuItem.Text = "Fechar"
        '
        'TestarApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(761, 649)
        Me.Controls.Add(Me.PanelComando)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "TestarApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestarApp"
        Me.ContextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelComando As Panel
    Friend WithEvents ContextMenuStripOptions As ContextMenuStrip
    Friend WithEvents ComunicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarPortaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConectarDesconectarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcionamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtivarJoystickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurarJoystickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlarmesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharAplicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtivadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesativadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtivadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DesativadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConfigurarToolStripMenuItem As ToolStripMenuItem
End Class
