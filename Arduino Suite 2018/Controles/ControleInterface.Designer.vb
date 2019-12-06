<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControleInterface
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.BarraGrafica = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.TrackBarSaidaAnalogica = New System.Windows.Forms.TrackBar()
        Me.ToolTipInfoPorta = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerAtualizaStatus = New System.Windows.Forms.Timer(Me.components)
        Me.Grafico = New ArduinoSuite.Grafico()
        Me.LabelRotulo = New System.Windows.Forms.Label()
        Me.VideoSourcePlayer = New AForge.Controls.VideoSourcePlayer()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarSaidaAnalogica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraGrafica
        '
        Me.BarraGrafica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarraGrafica.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BarraGrafica.Location = New System.Drawing.Point(42, 130)
        Me.BarraGrafica.Name = "BarraGrafica"
        Me.BarraGrafica.Size = New System.Drawing.Size(83, 15)
        Me.BarraGrafica.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(65, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Desliga"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Liga"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBoxStatus
        '
        Me.PictureBoxStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxStatus.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBoxStatus.Image = Global.ArduinoSuite.My.Resources.Resources.GreenLedOff
        Me.PictureBoxStatus.Location = New System.Drawing.Point(41, 61)
        Me.PictureBoxStatus.Name = "PictureBoxStatus"
        Me.PictureBoxStatus.Size = New System.Drawing.Size(84, 85)
        Me.PictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatus.TabIndex = 30
        Me.PictureBoxStatus.TabStop = False
        '
        'LabelValor
        '
        Me.LabelValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelValor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelValor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelValor.Location = New System.Drawing.Point(1, 152)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(50, 19)
        Me.LabelValor.TabIndex = 33
        Me.LabelValor.Text = "Valor:"
        Me.LabelValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxValor.Location = New System.Drawing.Point(54, 152)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxValor.TabIndex = 32
        '
        'TrackBarSaidaAnalogica
        '
        Me.TrackBarSaidaAnalogica.Location = New System.Drawing.Point(2, 27)
        Me.TrackBarSaidaAnalogica.Maximum = 255
        Me.TrackBarSaidaAnalogica.Name = "TrackBarSaidaAnalogica"
        Me.TrackBarSaidaAnalogica.Size = New System.Drawing.Size(129, 45)
        Me.TrackBarSaidaAnalogica.TabIndex = 31
        '
        'ToolTipInfoPorta
        '
        Me.ToolTipInfoPorta.AutoPopDelay = 15000
        Me.ToolTipInfoPorta.InitialDelay = 500
        Me.ToolTipInfoPorta.ReshowDelay = 100
        '
        'TimerAtualizaStatus
        '
        Me.TimerAtualizaStatus.Interval = 50
        '
        'Grafico
        '
        Me.Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grafico.Location = New System.Drawing.Point(3, 25)
        Me.Grafico.Name = "Grafico"
        Me.Grafico.Size = New System.Drawing.Size(120, 174)
        Me.Grafico.TabIndex = 38
        '
        'LabelRotulo
        '
        Me.LabelRotulo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRotulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelRotulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelRotulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelRotulo.Name = "LabelRotulo"
        Me.LabelRotulo.Size = New System.Drawing.Size(129, 19)
        Me.LabelRotulo.TabIndex = 29
        Me.LabelRotulo.Text = "Novo Controle"
        Me.LabelRotulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VideoSourcePlayer
        '
        Me.VideoSourcePlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoSourcePlayer.Location = New System.Drawing.Point(3, 26)
        Me.VideoSourcePlayer.Name = "VideoSourcePlayer"
        Me.VideoSourcePlayer.Size = New System.Drawing.Size(120, 174)
        Me.VideoSourcePlayer.TabIndex = 37
        Me.VideoSourcePlayer.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer.VideoSource = Nothing
        '
        'ControleInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.BarraGrafica)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBoxStatus)
        Me.Controls.Add(Me.LabelValor)
        Me.Controls.Add(Me.TextBoxValor)
        Me.Controls.Add(Me.TrackBarSaidaAnalogica)
        Me.Controls.Add(Me.Grafico)
        Me.Controls.Add(Me.LabelRotulo)
        Me.Controls.Add(Me.VideoSourcePlayer)
        Me.Name = "ControleInterface"
        Me.Size = New System.Drawing.Size(129, 202)
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarSaidaAnalogica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraGrafica As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxStatus As PictureBox
    Friend WithEvents LabelValor As Label
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents TrackBarSaidaAnalogica As TrackBar
    Friend WithEvents ToolTipInfoPorta As ToolTip
    Friend WithEvents TimerAtualizaStatus As Timer
    Friend WithEvents Grafico As Grafico
    Friend WithEvents LabelRotulo As Label
    Public WithEvents VideoSourcePlayer As AForge.Controls.VideoSourcePlayer
End Class
