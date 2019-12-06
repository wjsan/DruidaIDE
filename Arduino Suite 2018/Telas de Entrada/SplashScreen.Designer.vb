<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.LabelStatusAbertura = New System.Windows.Forms.Label()
        Me.LabelVersao = New System.Windows.Forms.Label()
        Me.TimerProgress = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarStartUp = New System.Windows.Forms.ProgressBar()
        Me.LabelProgresso = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelFree = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelStatusAbertura
        '
        Me.LabelStatusAbertura.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatusAbertura.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelStatusAbertura.Location = New System.Drawing.Point(35, 201)
        Me.LabelStatusAbertura.Name = "LabelStatusAbertura"
        Me.LabelStatusAbertura.Size = New System.Drawing.Size(213, 27)
        Me.LabelStatusAbertura.TabIndex = 2
        Me.LabelStatusAbertura.Text = "Carregando Dados..."
        Me.LabelStatusAbertura.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LabelVersao
        '
        Me.LabelVersao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVersao.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersao.ForeColor = System.Drawing.Color.White
        Me.LabelVersao.Location = New System.Drawing.Point(416, 211)
        Me.LabelVersao.Name = "LabelVersao"
        Me.LabelVersao.Size = New System.Drawing.Size(67, 13)
        Me.LabelVersao.TabIndex = 2
        Me.LabelVersao.Text = "Versão 1.3.2"
        '
        'TimerProgress
        '
        Me.TimerProgress.Interval = 50
        '
        'ProgressBarStartUp
        '
        Me.ProgressBarStartUp.Location = New System.Drawing.Point(36, 231)
        Me.ProgressBarStartUp.Name = "ProgressBarStartUp"
        Me.ProgressBarStartUp.Size = New System.Drawing.Size(188, 15)
        Me.ProgressBarStartUp.TabIndex = 3
        '
        'LabelProgresso
        '
        Me.LabelProgresso.BackColor = System.Drawing.Color.Transparent
        Me.LabelProgresso.ForeColor = System.Drawing.Color.White
        Me.LabelProgresso.Location = New System.Drawing.Point(158, 232)
        Me.LabelProgresso.Name = "LabelProgresso"
        Me.LabelProgresso.Size = New System.Drawing.Size(96, 13)
        Me.LabelProgresso.TabIndex = 2
        Me.LabelProgresso.Text = "0%"
        Me.LabelProgresso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ArduinoSuite.My.Resources.Resources.Bar
        Me.PictureBox2.Location = New System.Drawing.Point(253, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 250)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(91, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(89, 87)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.Bar
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 556)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(293, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 53)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Software projetado por um desenvolvedor independente, sem nenhuma ou qualquer lig" &
    "ação com a marca ARDUINO™"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(377, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "BINARY_QUANTUM"
        '
        'LabelFree
        '
        Me.LabelFree.BackColor = System.Drawing.Color.Transparent
        Me.LabelFree.ForeColor = System.Drawing.Color.White
        Me.LabelFree.Location = New System.Drawing.Point(91, 167)
        Me.LabelFree.Name = "LabelFree"
        Me.LabelFree.Size = New System.Drawing.Size(89, 27)
        Me.LabelFree.TabIndex = 11
        Me.LabelFree.Text = "Druida Tool's Suite"
        Me.LabelFree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.ArduinoSuite.My.Resources.Resources.Gradiente_Azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(501, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelFree)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelVersao)
        Me.Controls.Add(Me.LabelStatusAbertura)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBarStartUp)
        Me.Controls.Add(Me.LabelProgresso)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelStatusAbertura As Label
    Friend WithEvents LabelVersao As Label
    Friend WithEvents TimerProgress As Timer
    Friend WithEvents ProgressBarStartUp As ProgressBar
    Friend WithEvents LabelProgresso As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelFree As Label
End Class
