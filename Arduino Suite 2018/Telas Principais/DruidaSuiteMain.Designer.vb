<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DruidaSuiteMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DruidaSuiteMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelConectar = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxAudio = New System.Windows.Forms.PictureBox()
        Me.PictureBoxConfig = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSair = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFerramentas = New System.Windows.Forms.PictureBox()
        Me.PictureBoxControle = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogon = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAlarmes = New System.Windows.Forms.PictureBox()
        Me.PictureBoxConectar = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxNova = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAbrir = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSalvar = New System.Windows.Forms.PictureBox()
        Me.TimerCheckPortAvailable = New System.Windows.Forms.Timer(Me.components)
        Me.COMPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerTryConnect = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLeituraRede = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainerWindows = New System.Windows.Forms.SplitContainer()
        Me.TimerAnimAlarme = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStripTaskBar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExibitTelaInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripAbrir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirProjetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjetosRecentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorkerRede = New System.ComponentModel.BackgroundWorker()
        Me.PanelTaskBar = New System.Windows.Forms.Panel()
        Me.PictureBoxSound = New System.Windows.Forms.PictureBox()
        Me.TaskButton3 = New ArduinoSuite.TaskButton()
        Me.TaskButton2 = New ArduinoSuite.TaskButton()
        Me.TaskButton1 = New ArduinoSuite.TaskButton()
        Me.PictureBoxHideAll = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWindows = New System.Windows.Forms.PictureBox()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.MenuInterativo = New ArduinoSuite.MenuInterativo()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFerramentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxControle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAlarmes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxConectar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxNova, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAbrir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSalvar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerWindows.SuspendLayout()
        Me.ContextMenuStripTaskBar.SuspendLayout()
        Me.ContextMenuStripAbrir.SuspendLayout()
        Me.PanelTaskBar.SuspendLayout()
        CType(Me.PictureBoxSound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHideAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Configuração"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ferramentas"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(752, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "LogOn Options"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(933, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sair"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Controle"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(480, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Alarmes"
        '
        'LabelConectar
        '
        Me.LabelConectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelConectar.AutoSize = True
        Me.LabelConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConectar.Location = New System.Drawing.Point(629, 124)
        Me.LabelConectar.Name = "LabelConectar"
        Me.LabelConectar.Size = New System.Drawing.Size(69, 18)
        Me.LabelConectar.TabIndex = 1
        Me.LabelConectar.Text = "Conectar"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Abrir"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nova"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 410)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Salvar"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 549)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Salvar Como"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.PictureBoxAudio)
        Me.GroupBox1.Controls.Add(Me.PictureBoxConfig)
        Me.GroupBox1.Controls.Add(Me.PictureBoxSair)
        Me.GroupBox1.Controls.Add(Me.PictureBoxFerramentas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBoxControle)
        Me.GroupBox1.Controls.Add(Me.PictureBoxLogon)
        Me.GroupBox1.Controls.Add(Me.PictureBoxAlarmes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBoxConectar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LabelConectar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 624)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1025, 147)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistema"
        Me.GroupBox1.Visible = False
        '
        'PictureBoxAudio
        '
        Me.PictureBoxAudio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxAudio.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAudio.Image = Global.ArduinoSuite.My.Resources.Resources.audioOn
        Me.PictureBoxAudio.Location = New System.Drawing.Point(993, 3)
        Me.PictureBoxAudio.Name = "PictureBoxAudio"
        Me.PictureBoxAudio.Size = New System.Drawing.Size(32, 36)
        Me.PictureBoxAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAudio.TabIndex = 26
        Me.PictureBoxAudio.TabStop = False
        '
        'PictureBoxConfig
        '
        Me.PictureBoxConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxConfig.Image = Global.ArduinoSuite.My.Resources.Resources.Setting_icon
        Me.PictureBoxConfig.Location = New System.Drawing.Point(10, 17)
        Me.PictureBoxConfig.Name = "PictureBoxConfig"
        Me.PictureBoxConfig.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxConfig.TabIndex = 0
        Me.PictureBoxConfig.TabStop = False
        '
        'PictureBoxSair
        '
        Me.PictureBoxSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSair.Image = Global.ArduinoSuite.My.Resources.Resources._2013_06_13_televizija_na_off_16377
        Me.PictureBoxSair.Location = New System.Drawing.Point(887, 17)
        Me.PictureBoxSair.Name = "PictureBoxSair"
        Me.PictureBoxSair.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSair.TabIndex = 0
        Me.PictureBoxSair.TabStop = False
        '
        'PictureBoxFerramentas
        '
        Me.PictureBoxFerramentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxFerramentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxFerramentas.Image = Global.ArduinoSuite.My.Resources.Resources.advancedsettings
        Me.PictureBoxFerramentas.Location = New System.Drawing.Point(154, 17)
        Me.PictureBoxFerramentas.Name = "PictureBoxFerramentas"
        Me.PictureBoxFerramentas.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxFerramentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFerramentas.TabIndex = 0
        Me.PictureBoxFerramentas.TabStop = False
        '
        'PictureBoxControle
        '
        Me.PictureBoxControle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxControle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxControle.ErrorImage = Nothing
        Me.PictureBoxControle.Image = Global.ArduinoSuite.My.Resources.Resources._813df8d9
        Me.PictureBoxControle.Location = New System.Drawing.Point(301, 17)
        Me.PictureBoxControle.Name = "PictureBoxControle"
        Me.PictureBoxControle.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxControle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxControle.TabIndex = 0
        Me.PictureBoxControle.TabStop = False
        '
        'PictureBoxLogon
        '
        Me.PictureBoxLogon.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxLogon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxLogon.Image = Global.ArduinoSuite.My.Resources.Resources.lock
        Me.PictureBoxLogon.Location = New System.Drawing.Point(743, 17)
        Me.PictureBoxLogon.Name = "PictureBoxLogon"
        Me.PictureBoxLogon.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxLogon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogon.TabIndex = 0
        Me.PictureBoxLogon.TabStop = False
        '
        'PictureBoxAlarmes
        '
        Me.PictureBoxAlarmes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxAlarmes.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAlarmes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxAlarmes.ErrorImage = Nothing
        Me.PictureBoxAlarmes.Image = Global.ArduinoSuite.My.Resources.Resources._392ae9cfa4b776ec2eac86fe92f7f3a6_ilustra__o_de_luz_de_alarme_de_bombeiro
        Me.PictureBoxAlarmes.Location = New System.Drawing.Point(450, 17)
        Me.PictureBoxAlarmes.Name = "PictureBoxAlarmes"
        Me.PictureBoxAlarmes.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxAlarmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAlarmes.TabIndex = 0
        Me.PictureBoxAlarmes.TabStop = False
        '
        'PictureBoxConectar
        '
        Me.PictureBoxConectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBoxConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxConectar.ErrorImage = Nothing
        Me.PictureBoxConectar.Image = Global.ArduinoSuite.My.Resources.Resources.Conectar
        Me.PictureBoxConectar.Location = New System.Drawing.Point(599, 17)
        Me.PictureBoxConectar.Name = "PictureBoxConectar"
        Me.PictureBoxConectar.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxConectar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxConectar.TabIndex = 0
        Me.PictureBoxConectar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.PictureBoxNova)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.PictureBoxAbrir)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBoxSalvar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(894, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 571)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aplicação"
        Me.GroupBox2.Visible = False
        '
        'PictureBoxNova
        '
        Me.PictureBoxNova.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxNova.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxNova.Image = Global.ArduinoSuite.My.Resources.Resources.Novo
        Me.PictureBoxNova.Location = New System.Drawing.Point(3, 28)
        Me.PictureBoxNova.Name = "PictureBoxNova"
        Me.PictureBoxNova.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxNova.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxNova.TabIndex = 0
        Me.PictureBoxNova.TabStop = False
        '
        'PictureBoxAbrir
        '
        Me.PictureBoxAbrir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxAbrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxAbrir.Image = Global.ArduinoSuite.My.Resources.Resources.Abrir
        Me.PictureBoxAbrir.Location = New System.Drawing.Point(3, 165)
        Me.PictureBoxAbrir.Name = "PictureBoxAbrir"
        Me.PictureBoxAbrir.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAbrir.TabIndex = 0
        Me.PictureBoxAbrir.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar_Como
        Me.PictureBox4.Location = New System.Drawing.Point(3, 445)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(128, 104)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBoxSalvar
        '
        Me.PictureBoxSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSalvar.Image = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.PictureBoxSalvar.Location = New System.Drawing.Point(3, 305)
        Me.PictureBoxSalvar.Name = "PictureBoxSalvar"
        Me.PictureBoxSalvar.Size = New System.Drawing.Size(128, 104)
        Me.PictureBoxSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSalvar.TabIndex = 0
        Me.PictureBoxSalvar.TabStop = False
        '
        'TimerCheckPortAvailable
        '
        Me.TimerCheckPortAvailable.Interval = 500
        '
        'COMPort
        '
        Me.COMPort.BaudRate = 115200
        Me.COMPort.ReadTimeout = 500
        Me.COMPort.WriteTimeout = 500
        '
        'TimerTryConnect
        '
        Me.TimerTryConnect.Interval = 300
        '
        'TimerLeituraRede
        '
        Me.TimerLeituraRede.Interval = 10
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 1000
        '
        'SplitContainerWindows
        '
        Me.SplitContainerWindows.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerWindows.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerWindows.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerWindows.Name = "SplitContainerWindows"
        '
        'SplitContainerWindows.Panel2
        '
        Me.SplitContainerWindows.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerWindows.Size = New System.Drawing.Size(1022, 730)
        Me.SplitContainerWindows.SplitterDistance = 495
        Me.SplitContainerWindows.TabIndex = 23
        Me.SplitContainerWindows.Visible = False
        '
        'TimerAnimAlarme
        '
        Me.TimerAnimAlarme.Interval = 500
        '
        'ContextMenuStripTaskBar
        '
        Me.ContextMenuStripTaskBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExibitTelaInicialToolStripMenuItem})
        Me.ContextMenuStripTaskBar.Name = "ContextMenuStripTaskBar"
        Me.ContextMenuStripTaskBar.Size = New System.Drawing.Size(161, 26)
        '
        'ExibitTelaInicialToolStripMenuItem
        '
        Me.ExibitTelaInicialToolStripMenuItem.Name = "ExibitTelaInicialToolStripMenuItem"
        Me.ExibitTelaInicialToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExibitTelaInicialToolStripMenuItem.Text = "Exibir Tela Inicial"
        '
        'ContextMenuStripAbrir
        '
        Me.ContextMenuStripAbrir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirProjetoToolStripMenuItem, Me.ProjetosRecentesToolStripMenuItem})
        Me.ContextMenuStripAbrir.Name = "ContextMenuStripAbrir"
        Me.ContextMenuStripAbrir.Size = New System.Drawing.Size(165, 48)
        '
        'AbrirProjetoToolStripMenuItem
        '
        Me.AbrirProjetoToolStripMenuItem.Image = Global.ArduinoSuite.My.Resources.Resources.Abrir
        Me.AbrirProjetoToolStripMenuItem.Name = "AbrirProjetoToolStripMenuItem"
        Me.AbrirProjetoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AbrirProjetoToolStripMenuItem.Text = "Abrir Projeto"
        '
        'ProjetosRecentesToolStripMenuItem
        '
        Me.ProjetosRecentesToolStripMenuItem.Name = "ProjetosRecentesToolStripMenuItem"
        Me.ProjetosRecentesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProjetosRecentesToolStripMenuItem.Text = "Projetos recentes"
        '
        'BackgroundWorkerRede
        '
        Me.BackgroundWorkerRede.WorkerSupportsCancellation = True
        '
        'PanelTaskBar
        '
        Me.PanelTaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelTaskBar.BackgroundImage = Global.ArduinoSuite.My.Resources.Resources.TaskBar
        Me.PanelTaskBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelTaskBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTaskBar.ContextMenuStrip = Me.ContextMenuStripTaskBar
        Me.PanelTaskBar.Controls.Add(Me.PictureBoxSound)
        Me.PanelTaskBar.Controls.Add(Me.TaskButton3)
        Me.PanelTaskBar.Controls.Add(Me.TaskButton2)
        Me.PanelTaskBar.Controls.Add(Me.TaskButton1)
        Me.PanelTaskBar.Controls.Add(Me.PictureBoxHideAll)
        Me.PanelTaskBar.Controls.Add(Me.PictureBoxWindows)
        Me.PanelTaskBar.Controls.Add(Me.LabelTimer)
        Me.PanelTaskBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTaskBar.Location = New System.Drawing.Point(0, 728)
        Me.PanelTaskBar.Name = "PanelTaskBar"
        Me.PanelTaskBar.Size = New System.Drawing.Size(1024, 40)
        Me.PanelTaskBar.TabIndex = 20
        Me.PanelTaskBar.Visible = False
        '
        'PictureBoxSound
        '
        Me.PictureBoxSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxSound.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxSound.Image = Global.ArduinoSuite.My.Resources.Resources.audioOn
        Me.PictureBoxSound.Location = New System.Drawing.Point(896, 1)
        Me.PictureBoxSound.Name = "PictureBoxSound"
        Me.PictureBoxSound.Size = New System.Drawing.Size(32, 36)
        Me.PictureBoxSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSound.TabIndex = 6
        Me.PictureBoxSound.TabStop = False
        '
        'TaskButton3
        '
        Me.TaskButton3.ActivateColor = System.Drawing.Color.Empty
        Me.TaskButton3.BackgroundImage = CType(resources.GetObject("TaskButton3.BackgroundImage"), System.Drawing.Image)
        Me.TaskButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskButton3.Location = New System.Drawing.Point(385, 1)
        Me.TaskButton3.Name = "TaskButton3"
        Me.TaskButton3.NomeItem = "Nome do Item"
        Me.TaskButton3.PictureItem = Nothing
        Me.TaskButton3.Size = New System.Drawing.Size(163, 35)
        Me.TaskButton3.TabIndex = 25
        Me.TaskButton3.Visible = False
        '
        'TaskButton2
        '
        Me.TaskButton2.ActivateColor = System.Drawing.Color.Empty
        Me.TaskButton2.BackgroundImage = CType(resources.GetObject("TaskButton2.BackgroundImage"), System.Drawing.Image)
        Me.TaskButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskButton2.Location = New System.Drawing.Point(216, 1)
        Me.TaskButton2.Name = "TaskButton2"
        Me.TaskButton2.NomeItem = "Nome do Item"
        Me.TaskButton2.PictureItem = Nothing
        Me.TaskButton2.Size = New System.Drawing.Size(163, 35)
        Me.TaskButton2.TabIndex = 25
        Me.TaskButton2.Visible = False
        '
        'TaskButton1
        '
        Me.TaskButton1.ActivateColor = System.Drawing.Color.Empty
        Me.TaskButton1.BackgroundImage = CType(resources.GetObject("TaskButton1.BackgroundImage"), System.Drawing.Image)
        Me.TaskButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskButton1.Location = New System.Drawing.Point(47, 1)
        Me.TaskButton1.Name = "TaskButton1"
        Me.TaskButton1.NomeItem = "Nome do Item"
        Me.TaskButton1.PictureItem = Nothing
        Me.TaskButton1.Size = New System.Drawing.Size(163, 35)
        Me.TaskButton1.TabIndex = 25
        Me.TaskButton1.Visible = False
        '
        'PictureBoxHideAll
        '
        Me.PictureBoxHideAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxHideAll.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxHideAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxHideAll.Location = New System.Drawing.Point(1011, 0)
        Me.PictureBoxHideAll.Name = "PictureBoxHideAll"
        Me.PictureBoxHideAll.Size = New System.Drawing.Size(11, 39)
        Me.PictureBoxHideAll.TabIndex = 23
        Me.PictureBoxHideAll.TabStop = False
        '
        'PictureBoxWindows
        '
        Me.PictureBoxWindows.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxWindows.Image = Global.ArduinoSuite.My.Resources.Resources.windows
        Me.PictureBoxWindows.Location = New System.Drawing.Point(-4, -4)
        Me.PictureBoxWindows.Name = "PictureBoxWindows"
        Me.PictureBoxWindows.Size = New System.Drawing.Size(46, 45)
        Me.PictureBoxWindows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxWindows.TabIndex = 1
        Me.PictureBoxWindows.TabStop = False
        '
        'LabelTimer
        '
        Me.LabelTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTimer.BackColor = System.Drawing.Color.Transparent
        Me.LabelTimer.ForeColor = System.Drawing.Color.White
        Me.LabelTimer.Location = New System.Drawing.Point(930, 0)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(80, 36)
        Me.LabelTimer.TabIndex = 0
        Me.LabelTimer.Text = "18/12/2018 10:50:36"
        Me.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuInterativo
        '
        Me.MenuInterativo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuInterativo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuInterativo.Location = New System.Drawing.Point(-1, 356)
        Me.MenuInterativo.Name = "MenuInterativo"
        Me.MenuInterativo.Size = New System.Drawing.Size(216, 373)
        Me.MenuInterativo.TabIndex = 21
        Me.MenuInterativo.Visible = False
        '
        'ArduinoSuiteMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PanelTaskBar)
        Me.Controls.Add(Me.MenuInterativo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SplitContainerWindows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "ArduinoSuiteMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Druida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxAudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFerramentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxControle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAlarmes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxConectar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxNova, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAbrir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSalvar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerWindows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerWindows.ResumeLayout(False)
        Me.ContextMenuStripTaskBar.ResumeLayout(False)
        Me.ContextMenuStripAbrir.ResumeLayout(False)
        Me.PanelTaskBar.ResumeLayout(False)
        CType(Me.PictureBoxSound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHideAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWindows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxConfig As PictureBox
    Friend WithEvents PictureBoxFerramentas As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBoxLogon As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBoxSair As PictureBox
    Friend WithEvents PictureBoxControle As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBoxAlarmes As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBoxConectar As PictureBox
    Friend WithEvents LabelConectar As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBoxAbrir As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBoxNova As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBoxSalvar As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TimerCheckPortAvailable As Timer
    Friend WithEvents COMPort As IO.Ports.SerialPort
    Friend WithEvents TimerTryConnect As Timer
    Friend WithEvents TimerLeituraRede As Timer
    Friend WithEvents PictureBoxSound As PictureBox
    Friend WithEvents PanelTaskBar As Panel
    Friend WithEvents PictureBoxWindows As PictureBox
    Friend WithEvents LabelTimer As Label
    Friend WithEvents MenuInterativo As MenuInterativo
    Friend WithEvents TimerClock As Timer
    Friend WithEvents PictureBoxHideAll As PictureBox
    Friend WithEvents TaskButton1 As TaskButton
    Friend WithEvents TaskButton3 As TaskButton
    Friend WithEvents TaskButton2 As TaskButton
    Friend WithEvents SplitContainerWindows As SplitContainer
    Friend WithEvents PictureBoxAudio As PictureBox
    Friend WithEvents TimerAnimAlarme As Timer
    Friend WithEvents ContextMenuStripTaskBar As ContextMenuStrip
    Friend WithEvents ExibitTelaInicialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripAbrir As ContextMenuStrip
    Friend WithEvents AbrirProjetoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjetosRecentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorkerRede As System.ComponentModel.BackgroundWorker
End Class
