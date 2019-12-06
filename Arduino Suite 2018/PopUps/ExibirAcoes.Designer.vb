<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExibirAcoes
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
        Me.TextBoxActions = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonRec = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPlayLoop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPlay = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonPause = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCarregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBoxTimer = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabelLineNum = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelCmd = New System.Windows.Forms.ToolStripLabel()
        Me.TimerGravarAcoes = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBoxLinhas = New System.Windows.Forms.RichTextBox()
        Me.ToolStripButtonRemoveTimers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxActions
        '
        Me.TextBoxActions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxActions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TextBoxActions.Location = New System.Drawing.Point(59, 28)
        Me.TextBoxActions.Multiline = True
        Me.TextBoxActions.Name = "TextBoxActions"
        Me.TextBoxActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxActions.Size = New System.Drawing.Size(479, 283)
        Me.TextBoxActions.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonRec, Me.ToolStripButtonPlayLoop, Me.ToolStripButtonPlay, Me.ToolStripButtonPause, Me.ToolStripButtonStop, Me.ToolStripButtonClear, Me.ToolStripButtonRemoveTimers, Me.ToolStripButtonCarregar, Me.ToolStripButtonSave, Me.ToolStripTextBoxTimer, Me.ToolStripLabelLineNum, Me.ToolStripLabelCmd})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(538, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonRec
        '
        Me.ToolStripButtonRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRec.Image = Global.ArduinoSuite.My.Resources.Resources.LedOff
        Me.ToolStripButtonRec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRec.Name = "ToolStripButtonRec"
        Me.ToolStripButtonRec.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRec.Text = "Gravar Ações"
        '
        'ToolStripButtonPlayLoop
        '
        Me.ToolStripButtonPlayLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPlayLoop.Image = Global.ArduinoSuite.My.Resources.Resources.playLoop
        Me.ToolStripButtonPlayLoop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPlayLoop.Name = "ToolStripButtonPlayLoop"
        Me.ToolStripButtonPlayLoop.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPlayLoop.Text = "Reproduzir em loop as ações gravadas"
        '
        'ToolStripButtonPlay
        '
        Me.ToolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPlay.Image = Global.ArduinoSuite.My.Resources.Resources.Play1
        Me.ToolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPlay.Name = "ToolStripButtonPlay"
        Me.ToolStripButtonPlay.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPlay.Text = "Reproduzir uma unica vez as ações gravadas"
        '
        'ToolStripButtonPause
        '
        Me.ToolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPause.Image = Global.ArduinoSuite.My.Resources.Resources.pause
        Me.ToolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPause.Name = "ToolStripButtonPause"
        Me.ToolStripButtonPause.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonPause.Text = "Pausar a gravação/reprodução de ações"
        '
        'ToolStripButtonStop
        '
        Me.ToolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonStop.Image = Global.ArduinoSuite.My.Resources.Resources.stopButton
        Me.ToolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonStop.Name = "ToolStripButtonStop"
        Me.ToolStripButtonStop.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonStop.Text = "Interromper a gravação/reprodução de ações"
        '
        'ToolStripButtonClear
        '
        Me.ToolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonClear.Image = Global.ArduinoSuite.My.Resources.Resources.deletar
        Me.ToolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonClear.Name = "ToolStripButtonClear"
        Me.ToolStripButtonClear.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonClear.Text = "'"
        Me.ToolStripButtonClear.ToolTipText = "Limpar programação"
        '
        'ToolStripButtonCarregar
        '
        Me.ToolStripButtonCarregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCarregar.Image = Global.ArduinoSuite.My.Resources.Resources.Abrir
        Me.ToolStripButtonCarregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCarregar.Name = "ToolStripButtonCarregar"
        Me.ToolStripButtonCarregar.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonCarregar.Text = "Carregar uma ação personalizada"
        '
        'ToolStripButtonSave
        '
        Me.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSave.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSave.Name = "ToolStripButtonSave"
        Me.ToolStripButtonSave.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonSave.Text = "Salvar Ações Gravadas"
        '
        'ToolStripTextBoxTimer
        '
        Me.ToolStripTextBoxTimer.Name = "ToolStripTextBoxTimer"
        Me.ToolStripTextBoxTimer.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBoxTimer.Text = "100"
        Me.ToolStripTextBoxTimer.ToolTipText = "Intervalo de tempo entre a gravação/reprodução de ações (em ms)"
        '
        'ToolStripLabelLineNum
        '
        Me.ToolStripLabelLineNum.Name = "ToolStripLabelLineNum"
        Me.ToolStripLabelLineNum.Size = New System.Drawing.Size(26, 22)
        Me.ToolStripLabelLineNum.Text = "Lin:"
        '
        'ToolStripLabelCmd
        '
        Me.ToolStripLabelCmd.Name = "ToolStripLabelCmd"
        Me.ToolStripLabelCmd.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabelCmd.Text = "cmd"
        '
        'TimerGravarAcoes
        '
        '
        'RichTextBoxLinhas
        '
        Me.RichTextBoxLinhas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxLinhas.AutoWordSelection = True
        Me.RichTextBoxLinhas.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBoxLinhas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.RichTextBoxLinhas.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RichTextBoxLinhas.Location = New System.Drawing.Point(0, 28)
        Me.RichTextBoxLinhas.Name = "RichTextBoxLinhas"
        Me.RichTextBoxLinhas.ReadOnly = True
        Me.RichTextBoxLinhas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBoxLinhas.Size = New System.Drawing.Size(53, 283)
        Me.RichTextBoxLinhas.TabIndex = 12
        Me.RichTextBoxLinhas.Text = ""
        '
        'ToolStripButtonRemoveTimers
        '
        Me.ToolStripButtonRemoveTimers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRemoveTimers.Image = Global.ArduinoSuite.My.Resources.Resources.clearScreen
        Me.ToolStripButtonRemoveTimers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRemoveTimers.Name = "ToolStripButtonRemoveTimers"
        Me.ToolStripButtonRemoveTimers.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonRemoveTimers.Text = "Remover pausas"
        Me.ToolStripButtonRemoveTimers.ToolTipText = "Remover pausas (caracteres 'r') da programação"
        '
        'ExibirAcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 311)
        Me.Controls.Add(Me.RichTextBoxLinhas)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBoxActions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExibirAcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programar Acoes"
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxActions As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabelCmd As ToolStripLabel
    Friend WithEvents ToolStripLabelLineNum As ToolStripLabel
    Friend WithEvents ToolStripButtonClear As ToolStripButton
    Friend WithEvents ToolStripButtonCarregar As ToolStripButton
    Friend WithEvents ToolStripButtonSave As ToolStripButton
    Friend WithEvents ToolStripButtonPlay As ToolStripButton
    Friend WithEvents ToolStripButtonStop As ToolStripButton
    Friend WithEvents ToolStripButtonRec As ToolStripButton
    Friend WithEvents TimerGravarAcoes As Timer
    Friend WithEvents ToolStripButtonPause As ToolStripButton
    Friend WithEvents ToolStripButtonPlayLoop As ToolStripButton
    Friend WithEvents ToolStripTextBoxTimer As ToolStripTextBox
    Friend WithEvents RichTextBoxLinhas As RichTextBox
    Friend WithEvents ToolStripButtonRemoveTimers As ToolStripButton
End Class
