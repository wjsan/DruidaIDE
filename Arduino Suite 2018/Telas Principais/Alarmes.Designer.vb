<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alarmes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alarmes))
        Me.DataGridViewAlarmes = New System.Windows.Forms.DataGridView()
        Me.ButtonLimparHistórico = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonReconhecerAlarmes = New System.Windows.Forms.Button()
        Me.ButtonConfigAlarms = New System.Windows.Forms.Button()
        Me.pbConfig = New System.Windows.Forms.PictureBox()
        Me.pbSave = New System.Windows.Forms.PictureBox()
        Me.pbClearHistory = New System.Windows.Forms.PictureBox()
        Me.pbAckAlarms = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.Cabecalho = New System.Windows.Forms.Label()
        Me.LabelClose = New System.Windows.Forms.Label()
        CType(Me.DataGridViewAlarmes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClearHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAckAlarms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewAlarmes
        '
        Me.DataGridViewAlarmes.AllowUserToAddRows = False
        Me.DataGridViewAlarmes.AllowUserToDeleteRows = False
        Me.DataGridViewAlarmes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAlarmes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewAlarmes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewAlarmes.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAlarmes.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridViewAlarmes.Location = New System.Drawing.Point(189, 84)
        Me.DataGridViewAlarmes.Name = "DataGridViewAlarmes"
        Me.DataGridViewAlarmes.ReadOnly = True
        Me.DataGridViewAlarmes.Size = New System.Drawing.Size(609, 494)
        Me.DataGridViewAlarmes.TabIndex = 22
        '
        'ButtonLimparHistórico
        '
        Me.ButtonLimparHistórico.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonLimparHistórico.Location = New System.Drawing.Point(365, 617)
        Me.ButtonLimparHistórico.Name = "ButtonLimparHistórico"
        Me.ButtonLimparHistórico.Size = New System.Drawing.Size(131, 50)
        Me.ButtonLimparHistórico.TabIndex = 23
        Me.ButtonLimparHistórico.Text = "Limpar Histórico"
        Me.ButtonLimparHistórico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonLimparHistórico.UseVisualStyleBackColor = True
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonSalvar.Location = New System.Drawing.Point(502, 617)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(134, 50)
        Me.ButtonSalvar.TabIndex = 23
        Me.ButtonSalvar.Text = "Salvar Alarmes"
        Me.ButtonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'ButtonReconhecerAlarmes
        '
        Me.ButtonReconhecerAlarmes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonReconhecerAlarmes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonReconhecerAlarmes.Location = New System.Drawing.Point(200, 617)
        Me.ButtonReconhecerAlarmes.Name = "ButtonReconhecerAlarmes"
        Me.ButtonReconhecerAlarmes.Size = New System.Drawing.Size(159, 50)
        Me.ButtonReconhecerAlarmes.TabIndex = 23
        Me.ButtonReconhecerAlarmes.Text = "Reconhecer Alarmes"
        Me.ButtonReconhecerAlarmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonReconhecerAlarmes.UseVisualStyleBackColor = True
        '
        'ButtonConfigAlarms
        '
        Me.ButtonConfigAlarms.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonConfigAlarms.Location = New System.Drawing.Point(642, 617)
        Me.ButtonConfigAlarms.Name = "ButtonConfigAlarms"
        Me.ButtonConfigAlarms.Size = New System.Drawing.Size(150, 50)
        Me.ButtonConfigAlarms.TabIndex = 23
        Me.ButtonConfigAlarms.Text = "Configurar Alarmes"
        Me.ButtonConfigAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonConfigAlarms.UseVisualStyleBackColor = True
        '
        'pbConfig
        '
        Me.pbConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbConfig.Image = Global.ArduinoSuite.My.Resources.Resources.ConfigAlarm
        Me.pbConfig.Location = New System.Drawing.Point(656, 628)
        Me.pbConfig.Name = "pbConfig"
        Me.pbConfig.Size = New System.Drawing.Size(30, 28)
        Me.pbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbConfig.TabIndex = 24
        Me.pbConfig.TabStop = False
        '
        'pbSave
        '
        Me.pbSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbSave.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.pbSave.Location = New System.Drawing.Point(516, 628)
        Me.pbSave.Name = "pbSave"
        Me.pbSave.Size = New System.Drawing.Size(30, 28)
        Me.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSave.TabIndex = 24
        Me.pbSave.TabStop = False
        '
        'pbClearHistory
        '
        Me.pbClearHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbClearHistory.Image = Global.ArduinoSuite.My.Resources.Resources.deletar
        Me.pbClearHistory.Location = New System.Drawing.Point(376, 628)
        Me.pbClearHistory.Name = "pbClearHistory"
        Me.pbClearHistory.Size = New System.Drawing.Size(30, 28)
        Me.pbClearHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClearHistory.TabIndex = 24
        Me.pbClearHistory.TabStop = False
        '
        'pbAckAlarms
        '
        Me.pbAckAlarms.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbAckAlarms.Image = Global.ArduinoSuite.My.Resources.Resources.Alarm_Ok
        Me.pbAckAlarms.Location = New System.Drawing.Point(210, 628)
        Me.pbAckAlarms.Name = "pbAckAlarms"
        Me.pbAckAlarms.Size = New System.Drawing.Size(30, 28)
        Me.pbAckAlarms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAckAlarms.TabIndex = 24
        Me.pbAckAlarms.TabStop = False
        '
        'PictureBoxIcon
        '
        Me.PictureBoxIcon.ErrorImage = Nothing
        Me.PictureBoxIcon.Image = CType(resources.GetObject("PictureBoxIcon.Image"), System.Drawing.Image)
        Me.PictureBoxIcon.Location = New System.Drawing.Point(4, 4)
        Me.PictureBoxIcon.Name = "PictureBoxIcon"
        Me.PictureBoxIcon.Size = New System.Drawing.Size(39, 37)
        Me.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxIcon.TabIndex = 17
        Me.PictureBoxIcon.TabStop = False
        '
        'Cabecalho
        '
        Me.Cabecalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cabecalho.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cabecalho.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cabecalho.ForeColor = System.Drawing.SystemColors.Window
        Me.Cabecalho.Image = CType(resources.GetObject("Cabecalho.Image"), System.Drawing.Image)
        Me.Cabecalho.Location = New System.Drawing.Point(5, 4)
        Me.Cabecalho.Name = "Cabecalho"
        Me.Cabecalho.Size = New System.Drawing.Size(1016, 36)
        Me.Cabecalho.TabIndex = 16
        Me.Cabecalho.Text = "Alarmes"
        Me.Cabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelClose
        '
        Me.LabelClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClose.BackColor = System.Drawing.Color.SkyBlue
        Me.LabelClose.ForeColor = System.Drawing.Color.White
        Me.LabelClose.Image = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul2
        Me.LabelClose.Location = New System.Drawing.Point(974, 10)
        Me.LabelClose.Name = "LabelClose"
        Me.LabelClose.Size = New System.Drawing.Size(25, 23)
        Me.LabelClose.TabIndex = 25
        Me.LabelClose.Text = "X"
        Me.LabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Alarmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 729)
        Me.Controls.Add(Me.LabelClose)
        Me.Controls.Add(Me.pbConfig)
        Me.Controls.Add(Me.pbSave)
        Me.Controls.Add(Me.pbClearHistory)
        Me.Controls.Add(Me.pbAckAlarms)
        Me.Controls.Add(Me.ButtonConfigAlarms)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonLimparHistórico)
        Me.Controls.Add(Me.ButtonReconhecerAlarmes)
        Me.Controls.Add(Me.DataGridViewAlarmes)
        Me.Controls.Add(Me.PictureBoxIcon)
        Me.Controls.Add(Me.Cabecalho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alarmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarmes"
        CType(Me.DataGridViewAlarmes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClearHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAckAlarms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxIcon As PictureBox
    Friend WithEvents Cabecalho As Label
    Friend WithEvents DataGridViewAlarmes As DataGridView
    Friend WithEvents ButtonReconhecerAlarmes As Button
    Friend WithEvents ButtonLimparHistórico As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents pbAckAlarms As PictureBox
    Friend WithEvents pbClearHistory As PictureBox
    Friend WithEvents pbSave As PictureBox
    Friend WithEvents ButtonConfigAlarms As Button
    Friend WithEvents pbConfig As PictureBox
    Friend WithEvents LabelClose As Label
End Class
