<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HardwareMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HardwareMonitor))
        Me.Port0 = New System.Windows.Forms.Label()
        Me.tsHardwareMonitor = New System.Windows.Forms.ToolStrip()
        Me.tslPort = New System.Windows.Forms.ToolStripLabel()
        Me.tscbPort = New System.Windows.Forms.ToolStripComboBox()
        Me.tslBaud = New System.Windows.Forms.ToolStripLabel()
        Me.tscbBaud = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtConection = New System.Windows.Forms.ToolStripButton()
        Me.tsbtReadDigitalAnalog = New System.Windows.Forms.ToolStripButton()
        Me.tsbtSettings = New System.Windows.Forms.ToolStripButton()
        Me.gbHardwareMonitor = New System.Windows.Forms.GroupBox()
        Me.Porta71 = New System.Windows.Forms.Label()
        Me.Porta69 = New System.Windows.Forms.Label()
        Me.Port65 = New System.Windows.Forms.Label()
        Me.Port43 = New System.Windows.Forms.Label()
        Me.Porta70 = New System.Windows.Forms.Label()
        Me.Porta68 = New System.Windows.Forms.Label()
        Me.Port64 = New System.Windows.Forms.Label()
        Me.Port42 = New System.Windows.Forms.Label()
        Me.Porta67 = New System.Windows.Forms.Label()
        Me.Port63 = New System.Windows.Forms.Label()
        Me.Port41 = New System.Windows.Forms.Label()
        Me.Porta66 = New System.Windows.Forms.Label()
        Me.Port62 = New System.Windows.Forms.Label()
        Me.Port40 = New System.Windows.Forms.Label()
        Me.Port61 = New System.Windows.Forms.Label()
        Me.Port39 = New System.Windows.Forms.Label()
        Me.Port60 = New System.Windows.Forms.Label()
        Me.Port38 = New System.Windows.Forms.Label()
        Me.Port59 = New System.Windows.Forms.Label()
        Me.Port37 = New System.Windows.Forms.Label()
        Me.Port58 = New System.Windows.Forms.Label()
        Me.Port36 = New System.Windows.Forms.Label()
        Me.Port57 = New System.Windows.Forms.Label()
        Me.Port35 = New System.Windows.Forms.Label()
        Me.Port56 = New System.Windows.Forms.Label()
        Me.Port34 = New System.Windows.Forms.Label()
        Me.Port55 = New System.Windows.Forms.Label()
        Me.Port33 = New System.Windows.Forms.Label()
        Me.Port54 = New System.Windows.Forms.Label()
        Me.Port32 = New System.Windows.Forms.Label()
        Me.Port53 = New System.Windows.Forms.Label()
        Me.Port31 = New System.Windows.Forms.Label()
        Me.Port52 = New System.Windows.Forms.Label()
        Me.Port30 = New System.Windows.Forms.Label()
        Me.Port51 = New System.Windows.Forms.Label()
        Me.Port29 = New System.Windows.Forms.Label()
        Me.Port50 = New System.Windows.Forms.Label()
        Me.Port28 = New System.Windows.Forms.Label()
        Me.Port49 = New System.Windows.Forms.Label()
        Me.Port27 = New System.Windows.Forms.Label()
        Me.Port48 = New System.Windows.Forms.Label()
        Me.Port26 = New System.Windows.Forms.Label()
        Me.Port47 = New System.Windows.Forms.Label()
        Me.Port25 = New System.Windows.Forms.Label()
        Me.Port46 = New System.Windows.Forms.Label()
        Me.Port24 = New System.Windows.Forms.Label()
        Me.Port45 = New System.Windows.Forms.Label()
        Me.Port23 = New System.Windows.Forms.Label()
        Me.Port44 = New System.Windows.Forms.Label()
        Me.Port22 = New System.Windows.Forms.Label()
        Me.Port21 = New System.Windows.Forms.Label()
        Me.Port20 = New System.Windows.Forms.Label()
        Me.Port19 = New System.Windows.Forms.Label()
        Me.Port18 = New System.Windows.Forms.Label()
        Me.Port17 = New System.Windows.Forms.Label()
        Me.Port16 = New System.Windows.Forms.Label()
        Me.Port15 = New System.Windows.Forms.Label()
        Me.Port14 = New System.Windows.Forms.Label()
        Me.Port13 = New System.Windows.Forms.Label()
        Me.Port12 = New System.Windows.Forms.Label()
        Me.Port11 = New System.Windows.Forms.Label()
        Me.Port10 = New System.Windows.Forms.Label()
        Me.Port9 = New System.Windows.Forms.Label()
        Me.Port8 = New System.Windows.Forms.Label()
        Me.Port7 = New System.Windows.Forms.Label()
        Me.Port6 = New System.Windows.Forms.Label()
        Me.Port5 = New System.Windows.Forms.Label()
        Me.Port4 = New System.Windows.Forms.Label()
        Me.Port3 = New System.Windows.Forms.Label()
        Me.Port2 = New System.Windows.Forms.Label()
        Me.Port1 = New System.Windows.Forms.Label()
        Me.TimerUpdateCOM = New System.Windows.Forms.Timer(Me.components)
        Me.cmsHardware = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsmiForceOn = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiForceOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiConfigAsInput = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiConfigAsOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlotarGráficoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbAnalogs = New System.Windows.Forms.GroupBox()
        Me.PortA21 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.PortA20 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.PortA19 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PortA18 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PortA17 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PortA16 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PortA15 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PortA14 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PortA13 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PortA12 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PortA11 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PortA10 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PortA9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PortA8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PortA7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PortA6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PortA5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PortA4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PortA3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PortA2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PortA1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PortA0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmsAnalogs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiPlotAnalog = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHardwareMonitor.SuspendLayout()
        Me.gbHardwareMonitor.SuspendLayout()
        Me.cmsHardware.SuspendLayout()
        Me.gbAnalogs.SuspendLayout()
        Me.cmsAnalogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Port0
        '
        resources.ApplyResources(Me.Port0, "Port0")
        Me.Port0.BackColor = System.Drawing.Color.Gray
        Me.Port0.ForeColor = System.Drawing.Color.Black
        Me.Port0.Name = "Port0"
        '
        'tsHardwareMonitor
        '
        resources.ApplyResources(Me.tsHardwareMonitor, "tsHardwareMonitor")
        Me.tsHardwareMonitor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslPort, Me.tscbPort, Me.tslBaud, Me.tscbBaud, Me.tsbtConection, Me.tsbtReadDigitalAnalog, Me.tsbtSettings})
        Me.tsHardwareMonitor.Name = "tsHardwareMonitor"
        '
        'tslPort
        '
        resources.ApplyResources(Me.tslPort, "tslPort")
        Me.tslPort.Name = "tslPort"
        '
        'tscbPort
        '
        resources.ApplyResources(Me.tscbPort, "tscbPort")
        Me.tscbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbPort.Name = "tscbPort"
        '
        'tslBaud
        '
        resources.ApplyResources(Me.tslBaud, "tslBaud")
        Me.tslBaud.Name = "tslBaud"
        '
        'tscbBaud
        '
        resources.ApplyResources(Me.tscbBaud, "tscbBaud")
        Me.tscbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbBaud.Name = "tscbBaud"
        '
        'tsbtConection
        '
        resources.ApplyResources(Me.tsbtConection, "tsbtConection")
        Me.tsbtConection.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete
        Me.tsbtConection.Name = "tsbtConection"
        '
        'tsbtReadDigitalAnalog
        '
        resources.ApplyResources(Me.tsbtReadDigitalAnalog, "tsbtReadDigitalAnalog")
        Me.tsbtReadDigitalAnalog.CheckOnClick = True
        Me.tsbtReadDigitalAnalog.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Tree
        Me.tsbtReadDigitalAnalog.Name = "tsbtReadDigitalAnalog"
        '
        'tsbtSettings
        '
        resources.ApplyResources(Me.tsbtSettings, "tsbtSettings")
        Me.tsbtSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSettings.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Options
        Me.tsbtSettings.Name = "tsbtSettings"
        '
        'gbHardwareMonitor
        '
        resources.ApplyResources(Me.gbHardwareMonitor, "gbHardwareMonitor")
        Me.gbHardwareMonitor.Controls.Add(Me.Porta71)
        Me.gbHardwareMonitor.Controls.Add(Me.Porta69)
        Me.gbHardwareMonitor.Controls.Add(Me.Port65)
        Me.gbHardwareMonitor.Controls.Add(Me.Port43)
        Me.gbHardwareMonitor.Controls.Add(Me.Porta70)
        Me.gbHardwareMonitor.Controls.Add(Me.Porta68)
        Me.gbHardwareMonitor.Controls.Add(Me.Port64)
        Me.gbHardwareMonitor.Controls.Add(Me.Port42)
        Me.gbHardwareMonitor.Controls.Add(Me.Porta67)
        Me.gbHardwareMonitor.Controls.Add(Me.Port63)
        Me.gbHardwareMonitor.Controls.Add(Me.Port41)
        Me.gbHardwareMonitor.Controls.Add(Me.Porta66)
        Me.gbHardwareMonitor.Controls.Add(Me.Port62)
        Me.gbHardwareMonitor.Controls.Add(Me.Port40)
        Me.gbHardwareMonitor.Controls.Add(Me.Port61)
        Me.gbHardwareMonitor.Controls.Add(Me.Port39)
        Me.gbHardwareMonitor.Controls.Add(Me.Port60)
        Me.gbHardwareMonitor.Controls.Add(Me.Port38)
        Me.gbHardwareMonitor.Controls.Add(Me.Port59)
        Me.gbHardwareMonitor.Controls.Add(Me.Port37)
        Me.gbHardwareMonitor.Controls.Add(Me.Port58)
        Me.gbHardwareMonitor.Controls.Add(Me.Port36)
        Me.gbHardwareMonitor.Controls.Add(Me.Port57)
        Me.gbHardwareMonitor.Controls.Add(Me.Port35)
        Me.gbHardwareMonitor.Controls.Add(Me.Port56)
        Me.gbHardwareMonitor.Controls.Add(Me.Port34)
        Me.gbHardwareMonitor.Controls.Add(Me.Port55)
        Me.gbHardwareMonitor.Controls.Add(Me.Port33)
        Me.gbHardwareMonitor.Controls.Add(Me.Port54)
        Me.gbHardwareMonitor.Controls.Add(Me.Port32)
        Me.gbHardwareMonitor.Controls.Add(Me.Port53)
        Me.gbHardwareMonitor.Controls.Add(Me.Port31)
        Me.gbHardwareMonitor.Controls.Add(Me.Port52)
        Me.gbHardwareMonitor.Controls.Add(Me.Port30)
        Me.gbHardwareMonitor.Controls.Add(Me.Port51)
        Me.gbHardwareMonitor.Controls.Add(Me.Port29)
        Me.gbHardwareMonitor.Controls.Add(Me.Port50)
        Me.gbHardwareMonitor.Controls.Add(Me.Port28)
        Me.gbHardwareMonitor.Controls.Add(Me.Port49)
        Me.gbHardwareMonitor.Controls.Add(Me.Port27)
        Me.gbHardwareMonitor.Controls.Add(Me.Port48)
        Me.gbHardwareMonitor.Controls.Add(Me.Port26)
        Me.gbHardwareMonitor.Controls.Add(Me.Port47)
        Me.gbHardwareMonitor.Controls.Add(Me.Port25)
        Me.gbHardwareMonitor.Controls.Add(Me.Port46)
        Me.gbHardwareMonitor.Controls.Add(Me.Port24)
        Me.gbHardwareMonitor.Controls.Add(Me.Port45)
        Me.gbHardwareMonitor.Controls.Add(Me.Port23)
        Me.gbHardwareMonitor.Controls.Add(Me.Port44)
        Me.gbHardwareMonitor.Controls.Add(Me.Port22)
        Me.gbHardwareMonitor.Controls.Add(Me.Port21)
        Me.gbHardwareMonitor.Controls.Add(Me.Port20)
        Me.gbHardwareMonitor.Controls.Add(Me.Port19)
        Me.gbHardwareMonitor.Controls.Add(Me.Port18)
        Me.gbHardwareMonitor.Controls.Add(Me.Port17)
        Me.gbHardwareMonitor.Controls.Add(Me.Port16)
        Me.gbHardwareMonitor.Controls.Add(Me.Port15)
        Me.gbHardwareMonitor.Controls.Add(Me.Port14)
        Me.gbHardwareMonitor.Controls.Add(Me.Port13)
        Me.gbHardwareMonitor.Controls.Add(Me.Port12)
        Me.gbHardwareMonitor.Controls.Add(Me.Port11)
        Me.gbHardwareMonitor.Controls.Add(Me.Port10)
        Me.gbHardwareMonitor.Controls.Add(Me.Port9)
        Me.gbHardwareMonitor.Controls.Add(Me.Port8)
        Me.gbHardwareMonitor.Controls.Add(Me.Port7)
        Me.gbHardwareMonitor.Controls.Add(Me.Port6)
        Me.gbHardwareMonitor.Controls.Add(Me.Port5)
        Me.gbHardwareMonitor.Controls.Add(Me.Port4)
        Me.gbHardwareMonitor.Controls.Add(Me.Port3)
        Me.gbHardwareMonitor.Controls.Add(Me.Port2)
        Me.gbHardwareMonitor.Controls.Add(Me.Port1)
        Me.gbHardwareMonitor.Controls.Add(Me.Port0)
        Me.gbHardwareMonitor.Name = "gbHardwareMonitor"
        Me.gbHardwareMonitor.TabStop = False
        '
        'Porta71
        '
        resources.ApplyResources(Me.Porta71, "Porta71")
        Me.Porta71.BackColor = System.Drawing.Color.Gray
        Me.Porta71.ForeColor = System.Drawing.Color.Black
        Me.Porta71.Name = "Porta71"
        '
        'Porta69
        '
        resources.ApplyResources(Me.Porta69, "Porta69")
        Me.Porta69.BackColor = System.Drawing.Color.Gray
        Me.Porta69.ForeColor = System.Drawing.Color.Black
        Me.Porta69.Name = "Porta69"
        '
        'Port65
        '
        resources.ApplyResources(Me.Port65, "Port65")
        Me.Port65.BackColor = System.Drawing.Color.Gray
        Me.Port65.ForeColor = System.Drawing.Color.Black
        Me.Port65.Name = "Port65"
        '
        'Port43
        '
        resources.ApplyResources(Me.Port43, "Port43")
        Me.Port43.BackColor = System.Drawing.Color.Gray
        Me.Port43.ForeColor = System.Drawing.Color.Black
        Me.Port43.Name = "Port43"
        '
        'Porta70
        '
        resources.ApplyResources(Me.Porta70, "Porta70")
        Me.Porta70.BackColor = System.Drawing.Color.Gray
        Me.Porta70.ForeColor = System.Drawing.Color.Black
        Me.Porta70.Name = "Porta70"
        '
        'Porta68
        '
        resources.ApplyResources(Me.Porta68, "Porta68")
        Me.Porta68.BackColor = System.Drawing.Color.Gray
        Me.Porta68.ForeColor = System.Drawing.Color.Black
        Me.Porta68.Name = "Porta68"
        '
        'Port64
        '
        resources.ApplyResources(Me.Port64, "Port64")
        Me.Port64.BackColor = System.Drawing.Color.Gray
        Me.Port64.ForeColor = System.Drawing.Color.Black
        Me.Port64.Name = "Port64"
        '
        'Port42
        '
        resources.ApplyResources(Me.Port42, "Port42")
        Me.Port42.BackColor = System.Drawing.Color.Gray
        Me.Port42.ForeColor = System.Drawing.Color.Black
        Me.Port42.Name = "Port42"
        '
        'Porta67
        '
        resources.ApplyResources(Me.Porta67, "Porta67")
        Me.Porta67.BackColor = System.Drawing.Color.Gray
        Me.Porta67.ForeColor = System.Drawing.Color.Black
        Me.Porta67.Name = "Porta67"
        '
        'Port63
        '
        resources.ApplyResources(Me.Port63, "Port63")
        Me.Port63.BackColor = System.Drawing.Color.Gray
        Me.Port63.ForeColor = System.Drawing.Color.Black
        Me.Port63.Name = "Port63"
        '
        'Port41
        '
        resources.ApplyResources(Me.Port41, "Port41")
        Me.Port41.BackColor = System.Drawing.Color.Gray
        Me.Port41.ForeColor = System.Drawing.Color.Black
        Me.Port41.Name = "Port41"
        '
        'Porta66
        '
        resources.ApplyResources(Me.Porta66, "Porta66")
        Me.Porta66.BackColor = System.Drawing.Color.Gray
        Me.Porta66.ForeColor = System.Drawing.Color.Black
        Me.Porta66.Name = "Porta66"
        '
        'Port62
        '
        resources.ApplyResources(Me.Port62, "Port62")
        Me.Port62.BackColor = System.Drawing.Color.Gray
        Me.Port62.ForeColor = System.Drawing.Color.Black
        Me.Port62.Name = "Port62"
        '
        'Port40
        '
        resources.ApplyResources(Me.Port40, "Port40")
        Me.Port40.BackColor = System.Drawing.Color.Gray
        Me.Port40.ForeColor = System.Drawing.Color.Black
        Me.Port40.Name = "Port40"
        '
        'Port61
        '
        resources.ApplyResources(Me.Port61, "Port61")
        Me.Port61.BackColor = System.Drawing.Color.Gray
        Me.Port61.ForeColor = System.Drawing.Color.Black
        Me.Port61.Name = "Port61"
        '
        'Port39
        '
        resources.ApplyResources(Me.Port39, "Port39")
        Me.Port39.BackColor = System.Drawing.Color.Gray
        Me.Port39.ForeColor = System.Drawing.Color.Black
        Me.Port39.Name = "Port39"
        '
        'Port60
        '
        resources.ApplyResources(Me.Port60, "Port60")
        Me.Port60.BackColor = System.Drawing.Color.Gray
        Me.Port60.ForeColor = System.Drawing.Color.Black
        Me.Port60.Name = "Port60"
        '
        'Port38
        '
        resources.ApplyResources(Me.Port38, "Port38")
        Me.Port38.BackColor = System.Drawing.Color.Gray
        Me.Port38.ForeColor = System.Drawing.Color.Black
        Me.Port38.Name = "Port38"
        '
        'Port59
        '
        resources.ApplyResources(Me.Port59, "Port59")
        Me.Port59.BackColor = System.Drawing.Color.Gray
        Me.Port59.ForeColor = System.Drawing.Color.Black
        Me.Port59.Name = "Port59"
        '
        'Port37
        '
        resources.ApplyResources(Me.Port37, "Port37")
        Me.Port37.BackColor = System.Drawing.Color.Gray
        Me.Port37.ForeColor = System.Drawing.Color.Black
        Me.Port37.Name = "Port37"
        '
        'Port58
        '
        resources.ApplyResources(Me.Port58, "Port58")
        Me.Port58.BackColor = System.Drawing.Color.Gray
        Me.Port58.ForeColor = System.Drawing.Color.Black
        Me.Port58.Name = "Port58"
        '
        'Port36
        '
        resources.ApplyResources(Me.Port36, "Port36")
        Me.Port36.BackColor = System.Drawing.Color.Gray
        Me.Port36.ForeColor = System.Drawing.Color.Black
        Me.Port36.Name = "Port36"
        '
        'Port57
        '
        resources.ApplyResources(Me.Port57, "Port57")
        Me.Port57.BackColor = System.Drawing.Color.Gray
        Me.Port57.ForeColor = System.Drawing.Color.Black
        Me.Port57.Name = "Port57"
        '
        'Port35
        '
        resources.ApplyResources(Me.Port35, "Port35")
        Me.Port35.BackColor = System.Drawing.Color.Gray
        Me.Port35.ForeColor = System.Drawing.Color.Black
        Me.Port35.Name = "Port35"
        '
        'Port56
        '
        resources.ApplyResources(Me.Port56, "Port56")
        Me.Port56.BackColor = System.Drawing.Color.Gray
        Me.Port56.ForeColor = System.Drawing.Color.Black
        Me.Port56.Name = "Port56"
        '
        'Port34
        '
        resources.ApplyResources(Me.Port34, "Port34")
        Me.Port34.BackColor = System.Drawing.Color.Gray
        Me.Port34.ForeColor = System.Drawing.Color.Black
        Me.Port34.Name = "Port34"
        '
        'Port55
        '
        resources.ApplyResources(Me.Port55, "Port55")
        Me.Port55.BackColor = System.Drawing.Color.Gray
        Me.Port55.ForeColor = System.Drawing.Color.Black
        Me.Port55.Name = "Port55"
        '
        'Port33
        '
        resources.ApplyResources(Me.Port33, "Port33")
        Me.Port33.BackColor = System.Drawing.Color.Gray
        Me.Port33.ForeColor = System.Drawing.Color.Black
        Me.Port33.Name = "Port33"
        '
        'Port54
        '
        resources.ApplyResources(Me.Port54, "Port54")
        Me.Port54.BackColor = System.Drawing.Color.Gray
        Me.Port54.ForeColor = System.Drawing.Color.Black
        Me.Port54.Name = "Port54"
        '
        'Port32
        '
        resources.ApplyResources(Me.Port32, "Port32")
        Me.Port32.BackColor = System.Drawing.Color.Gray
        Me.Port32.ForeColor = System.Drawing.Color.Black
        Me.Port32.Name = "Port32"
        '
        'Port53
        '
        resources.ApplyResources(Me.Port53, "Port53")
        Me.Port53.BackColor = System.Drawing.Color.Gray
        Me.Port53.ForeColor = System.Drawing.Color.Black
        Me.Port53.Name = "Port53"
        '
        'Port31
        '
        resources.ApplyResources(Me.Port31, "Port31")
        Me.Port31.BackColor = System.Drawing.Color.Gray
        Me.Port31.ForeColor = System.Drawing.Color.Black
        Me.Port31.Name = "Port31"
        '
        'Port52
        '
        resources.ApplyResources(Me.Port52, "Port52")
        Me.Port52.BackColor = System.Drawing.Color.Gray
        Me.Port52.ForeColor = System.Drawing.Color.Black
        Me.Port52.Name = "Port52"
        '
        'Port30
        '
        resources.ApplyResources(Me.Port30, "Port30")
        Me.Port30.BackColor = System.Drawing.Color.Gray
        Me.Port30.ForeColor = System.Drawing.Color.Black
        Me.Port30.Name = "Port30"
        '
        'Port51
        '
        resources.ApplyResources(Me.Port51, "Port51")
        Me.Port51.BackColor = System.Drawing.Color.Gray
        Me.Port51.ForeColor = System.Drawing.Color.Black
        Me.Port51.Name = "Port51"
        '
        'Port29
        '
        resources.ApplyResources(Me.Port29, "Port29")
        Me.Port29.BackColor = System.Drawing.Color.Gray
        Me.Port29.ForeColor = System.Drawing.Color.Black
        Me.Port29.Name = "Port29"
        '
        'Port50
        '
        resources.ApplyResources(Me.Port50, "Port50")
        Me.Port50.BackColor = System.Drawing.Color.Gray
        Me.Port50.ForeColor = System.Drawing.Color.Black
        Me.Port50.Name = "Port50"
        '
        'Port28
        '
        resources.ApplyResources(Me.Port28, "Port28")
        Me.Port28.BackColor = System.Drawing.Color.Gray
        Me.Port28.ForeColor = System.Drawing.Color.Black
        Me.Port28.Name = "Port28"
        '
        'Port49
        '
        resources.ApplyResources(Me.Port49, "Port49")
        Me.Port49.BackColor = System.Drawing.Color.Gray
        Me.Port49.ForeColor = System.Drawing.Color.Black
        Me.Port49.Name = "Port49"
        '
        'Port27
        '
        resources.ApplyResources(Me.Port27, "Port27")
        Me.Port27.BackColor = System.Drawing.Color.Gray
        Me.Port27.ForeColor = System.Drawing.Color.Black
        Me.Port27.Name = "Port27"
        '
        'Port48
        '
        resources.ApplyResources(Me.Port48, "Port48")
        Me.Port48.BackColor = System.Drawing.Color.Gray
        Me.Port48.ForeColor = System.Drawing.Color.Black
        Me.Port48.Name = "Port48"
        '
        'Port26
        '
        resources.ApplyResources(Me.Port26, "Port26")
        Me.Port26.BackColor = System.Drawing.Color.Gray
        Me.Port26.ForeColor = System.Drawing.Color.Black
        Me.Port26.Name = "Port26"
        '
        'Port47
        '
        resources.ApplyResources(Me.Port47, "Port47")
        Me.Port47.BackColor = System.Drawing.Color.Gray
        Me.Port47.ForeColor = System.Drawing.Color.Black
        Me.Port47.Name = "Port47"
        '
        'Port25
        '
        resources.ApplyResources(Me.Port25, "Port25")
        Me.Port25.BackColor = System.Drawing.Color.Gray
        Me.Port25.ForeColor = System.Drawing.Color.Black
        Me.Port25.Name = "Port25"
        '
        'Port46
        '
        resources.ApplyResources(Me.Port46, "Port46")
        Me.Port46.BackColor = System.Drawing.Color.Gray
        Me.Port46.ForeColor = System.Drawing.Color.Black
        Me.Port46.Name = "Port46"
        '
        'Port24
        '
        resources.ApplyResources(Me.Port24, "Port24")
        Me.Port24.BackColor = System.Drawing.Color.Gray
        Me.Port24.ForeColor = System.Drawing.Color.Black
        Me.Port24.Name = "Port24"
        '
        'Port45
        '
        resources.ApplyResources(Me.Port45, "Port45")
        Me.Port45.BackColor = System.Drawing.Color.Gray
        Me.Port45.ForeColor = System.Drawing.Color.Black
        Me.Port45.Name = "Port45"
        '
        'Port23
        '
        resources.ApplyResources(Me.Port23, "Port23")
        Me.Port23.BackColor = System.Drawing.Color.Gray
        Me.Port23.ForeColor = System.Drawing.Color.Black
        Me.Port23.Name = "Port23"
        '
        'Port44
        '
        resources.ApplyResources(Me.Port44, "Port44")
        Me.Port44.BackColor = System.Drawing.Color.Gray
        Me.Port44.ForeColor = System.Drawing.Color.Black
        Me.Port44.Name = "Port44"
        '
        'Port22
        '
        resources.ApplyResources(Me.Port22, "Port22")
        Me.Port22.BackColor = System.Drawing.Color.Gray
        Me.Port22.ForeColor = System.Drawing.Color.Black
        Me.Port22.Name = "Port22"
        '
        'Port21
        '
        resources.ApplyResources(Me.Port21, "Port21")
        Me.Port21.BackColor = System.Drawing.Color.Gray
        Me.Port21.ForeColor = System.Drawing.Color.Black
        Me.Port21.Name = "Port21"
        '
        'Port20
        '
        resources.ApplyResources(Me.Port20, "Port20")
        Me.Port20.BackColor = System.Drawing.Color.Gray
        Me.Port20.ForeColor = System.Drawing.Color.Black
        Me.Port20.Name = "Port20"
        '
        'Port19
        '
        resources.ApplyResources(Me.Port19, "Port19")
        Me.Port19.BackColor = System.Drawing.Color.Gray
        Me.Port19.ForeColor = System.Drawing.Color.Black
        Me.Port19.Name = "Port19"
        '
        'Port18
        '
        resources.ApplyResources(Me.Port18, "Port18")
        Me.Port18.BackColor = System.Drawing.Color.Gray
        Me.Port18.ForeColor = System.Drawing.Color.Black
        Me.Port18.Name = "Port18"
        '
        'Port17
        '
        resources.ApplyResources(Me.Port17, "Port17")
        Me.Port17.BackColor = System.Drawing.Color.Gray
        Me.Port17.ForeColor = System.Drawing.Color.Black
        Me.Port17.Name = "Port17"
        '
        'Port16
        '
        resources.ApplyResources(Me.Port16, "Port16")
        Me.Port16.BackColor = System.Drawing.Color.Gray
        Me.Port16.ForeColor = System.Drawing.Color.Black
        Me.Port16.Name = "Port16"
        '
        'Port15
        '
        resources.ApplyResources(Me.Port15, "Port15")
        Me.Port15.BackColor = System.Drawing.Color.Gray
        Me.Port15.ForeColor = System.Drawing.Color.Black
        Me.Port15.Name = "Port15"
        '
        'Port14
        '
        resources.ApplyResources(Me.Port14, "Port14")
        Me.Port14.BackColor = System.Drawing.Color.Gray
        Me.Port14.ForeColor = System.Drawing.Color.Black
        Me.Port14.Name = "Port14"
        '
        'Port13
        '
        resources.ApplyResources(Me.Port13, "Port13")
        Me.Port13.BackColor = System.Drawing.Color.Gray
        Me.Port13.ForeColor = System.Drawing.Color.Black
        Me.Port13.Name = "Port13"
        '
        'Port12
        '
        resources.ApplyResources(Me.Port12, "Port12")
        Me.Port12.BackColor = System.Drawing.Color.Gray
        Me.Port12.ForeColor = System.Drawing.Color.Black
        Me.Port12.Name = "Port12"
        '
        'Port11
        '
        resources.ApplyResources(Me.Port11, "Port11")
        Me.Port11.BackColor = System.Drawing.Color.Gray
        Me.Port11.ForeColor = System.Drawing.Color.Black
        Me.Port11.Name = "Port11"
        '
        'Port10
        '
        resources.ApplyResources(Me.Port10, "Port10")
        Me.Port10.BackColor = System.Drawing.Color.Gray
        Me.Port10.ForeColor = System.Drawing.Color.Black
        Me.Port10.Name = "Port10"
        '
        'Port9
        '
        resources.ApplyResources(Me.Port9, "Port9")
        Me.Port9.BackColor = System.Drawing.Color.Gray
        Me.Port9.ForeColor = System.Drawing.Color.Black
        Me.Port9.Name = "Port9"
        '
        'Port8
        '
        resources.ApplyResources(Me.Port8, "Port8")
        Me.Port8.BackColor = System.Drawing.Color.Gray
        Me.Port8.ForeColor = System.Drawing.Color.Black
        Me.Port8.Name = "Port8"
        '
        'Port7
        '
        resources.ApplyResources(Me.Port7, "Port7")
        Me.Port7.BackColor = System.Drawing.Color.Gray
        Me.Port7.ForeColor = System.Drawing.Color.Black
        Me.Port7.Name = "Port7"
        '
        'Port6
        '
        resources.ApplyResources(Me.Port6, "Port6")
        Me.Port6.BackColor = System.Drawing.Color.Gray
        Me.Port6.ForeColor = System.Drawing.Color.Black
        Me.Port6.Name = "Port6"
        '
        'Port5
        '
        resources.ApplyResources(Me.Port5, "Port5")
        Me.Port5.BackColor = System.Drawing.Color.Gray
        Me.Port5.ForeColor = System.Drawing.Color.Black
        Me.Port5.Name = "Port5"
        '
        'Port4
        '
        resources.ApplyResources(Me.Port4, "Port4")
        Me.Port4.BackColor = System.Drawing.Color.Gray
        Me.Port4.ForeColor = System.Drawing.Color.Black
        Me.Port4.Name = "Port4"
        '
        'Port3
        '
        resources.ApplyResources(Me.Port3, "Port3")
        Me.Port3.BackColor = System.Drawing.Color.Gray
        Me.Port3.ForeColor = System.Drawing.Color.Black
        Me.Port3.Name = "Port3"
        '
        'Port2
        '
        resources.ApplyResources(Me.Port2, "Port2")
        Me.Port2.BackColor = System.Drawing.Color.Gray
        Me.Port2.ForeColor = System.Drawing.Color.Black
        Me.Port2.Name = "Port2"
        '
        'Port1
        '
        resources.ApplyResources(Me.Port1, "Port1")
        Me.Port1.BackColor = System.Drawing.Color.Gray
        Me.Port1.ForeColor = System.Drawing.Color.Black
        Me.Port1.Name = "Port1"
        '
        'TimerUpdateCOM
        '
        '
        'cmsHardware
        '
        resources.ApplyResources(Me.cmsHardware, "cmsHardware")
        Me.cmsHardware.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmiForceOn, Me.TsmiForceOff, Me.TsmiConfigAsInput, Me.TsmiConfigAsOutput, Me.PlotarGráficoToolStripMenuItem})
        Me.cmsHardware.Name = "cmsHardware"
        '
        'TsmiForceOn
        '
        resources.ApplyResources(Me.TsmiForceOn, "TsmiForceOn")
        Me.TsmiForceOn.Image = Global.Druida_IDE_Lite.My.Resources.Resources.forceOn
        Me.TsmiForceOn.Name = "TsmiForceOn"
        '
        'TsmiForceOff
        '
        resources.ApplyResources(Me.TsmiForceOff, "TsmiForceOff")
        Me.TsmiForceOff.Image = Global.Druida_IDE_Lite.My.Resources.Resources.forceOff
        Me.TsmiForceOff.Name = "TsmiForceOff"
        '
        'TsmiConfigAsInput
        '
        resources.ApplyResources(Me.TsmiConfigAsInput, "TsmiConfigAsInput")
        Me.TsmiConfigAsInput.Image = Global.Druida_IDE_Lite.My.Resources.Resources.cfgInput
        Me.TsmiConfigAsInput.Name = "TsmiConfigAsInput"
        '
        'TsmiConfigAsOutput
        '
        resources.ApplyResources(Me.TsmiConfigAsOutput, "TsmiConfigAsOutput")
        Me.TsmiConfigAsOutput.Image = Global.Druida_IDE_Lite.My.Resources.Resources.cfgOutput
        Me.TsmiConfigAsOutput.Name = "TsmiConfigAsOutput"
        '
        'PlotarGráficoToolStripMenuItem
        '
        resources.ApplyResources(Me.PlotarGráficoToolStripMenuItem, "PlotarGráficoToolStripMenuItem")
        Me.PlotarGráficoToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.plot
        Me.PlotarGráficoToolStripMenuItem.Name = "PlotarGráficoToolStripMenuItem"
        '
        'gbAnalogs
        '
        resources.ApplyResources(Me.gbAnalogs, "gbAnalogs")
        Me.gbAnalogs.Controls.Add(Me.PortA21)
        Me.gbAnalogs.Controls.Add(Me.Label44)
        Me.gbAnalogs.Controls.Add(Me.PortA20)
        Me.gbAnalogs.Controls.Add(Me.Label42)
        Me.gbAnalogs.Controls.Add(Me.PortA19)
        Me.gbAnalogs.Controls.Add(Me.Label40)
        Me.gbAnalogs.Controls.Add(Me.PortA18)
        Me.gbAnalogs.Controls.Add(Me.Label38)
        Me.gbAnalogs.Controls.Add(Me.PortA17)
        Me.gbAnalogs.Controls.Add(Me.Label36)
        Me.gbAnalogs.Controls.Add(Me.PortA16)
        Me.gbAnalogs.Controls.Add(Me.Label34)
        Me.gbAnalogs.Controls.Add(Me.PortA15)
        Me.gbAnalogs.Controls.Add(Me.Label32)
        Me.gbAnalogs.Controls.Add(Me.PortA14)
        Me.gbAnalogs.Controls.Add(Me.Label30)
        Me.gbAnalogs.Controls.Add(Me.PortA13)
        Me.gbAnalogs.Controls.Add(Me.Label28)
        Me.gbAnalogs.Controls.Add(Me.PortA12)
        Me.gbAnalogs.Controls.Add(Me.Label26)
        Me.gbAnalogs.Controls.Add(Me.PortA11)
        Me.gbAnalogs.Controls.Add(Me.Label24)
        Me.gbAnalogs.Controls.Add(Me.PortA10)
        Me.gbAnalogs.Controls.Add(Me.Label22)
        Me.gbAnalogs.Controls.Add(Me.PortA9)
        Me.gbAnalogs.Controls.Add(Me.Label20)
        Me.gbAnalogs.Controls.Add(Me.PortA8)
        Me.gbAnalogs.Controls.Add(Me.Label18)
        Me.gbAnalogs.Controls.Add(Me.PortA7)
        Me.gbAnalogs.Controls.Add(Me.Label16)
        Me.gbAnalogs.Controls.Add(Me.PortA6)
        Me.gbAnalogs.Controls.Add(Me.Label14)
        Me.gbAnalogs.Controls.Add(Me.PortA5)
        Me.gbAnalogs.Controls.Add(Me.Label12)
        Me.gbAnalogs.Controls.Add(Me.PortA4)
        Me.gbAnalogs.Controls.Add(Me.Label10)
        Me.gbAnalogs.Controls.Add(Me.PortA3)
        Me.gbAnalogs.Controls.Add(Me.Label8)
        Me.gbAnalogs.Controls.Add(Me.PortA2)
        Me.gbAnalogs.Controls.Add(Me.Label6)
        Me.gbAnalogs.Controls.Add(Me.PortA1)
        Me.gbAnalogs.Controls.Add(Me.Label4)
        Me.gbAnalogs.Controls.Add(Me.PortA0)
        Me.gbAnalogs.Controls.Add(Me.Label1)
        Me.gbAnalogs.Name = "gbAnalogs"
        Me.gbAnalogs.TabStop = False
        '
        'PortA21
        '
        resources.ApplyResources(Me.PortA21, "PortA21")
        Me.PortA21.BackColor = System.Drawing.Color.Black
        Me.PortA21.ForeColor = System.Drawing.Color.White
        Me.PortA21.Name = "PortA21"
        '
        'Label44
        '
        resources.ApplyResources(Me.Label44, "Label44")
        Me.Label44.BackColor = System.Drawing.Color.Blue
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Name = "Label44"
        '
        'PortA20
        '
        resources.ApplyResources(Me.PortA20, "PortA20")
        Me.PortA20.BackColor = System.Drawing.Color.Black
        Me.PortA20.ForeColor = System.Drawing.Color.White
        Me.PortA20.Name = "PortA20"
        '
        'Label42
        '
        resources.ApplyResources(Me.Label42, "Label42")
        Me.Label42.BackColor = System.Drawing.Color.Blue
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Name = "Label42"
        '
        'PortA19
        '
        resources.ApplyResources(Me.PortA19, "PortA19")
        Me.PortA19.BackColor = System.Drawing.Color.Black
        Me.PortA19.ForeColor = System.Drawing.Color.White
        Me.PortA19.Name = "PortA19"
        '
        'Label40
        '
        resources.ApplyResources(Me.Label40, "Label40")
        Me.Label40.BackColor = System.Drawing.Color.Blue
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Name = "Label40"
        '
        'PortA18
        '
        resources.ApplyResources(Me.PortA18, "PortA18")
        Me.PortA18.BackColor = System.Drawing.Color.Black
        Me.PortA18.ForeColor = System.Drawing.Color.White
        Me.PortA18.Name = "PortA18"
        '
        'Label38
        '
        resources.ApplyResources(Me.Label38, "Label38")
        Me.Label38.BackColor = System.Drawing.Color.Blue
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Name = "Label38"
        '
        'PortA17
        '
        resources.ApplyResources(Me.PortA17, "PortA17")
        Me.PortA17.BackColor = System.Drawing.Color.Black
        Me.PortA17.ForeColor = System.Drawing.Color.White
        Me.PortA17.Name = "PortA17"
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.BackColor = System.Drawing.Color.Blue
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Name = "Label36"
        '
        'PortA16
        '
        resources.ApplyResources(Me.PortA16, "PortA16")
        Me.PortA16.BackColor = System.Drawing.Color.Black
        Me.PortA16.ForeColor = System.Drawing.Color.White
        Me.PortA16.Name = "PortA16"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.BackColor = System.Drawing.Color.Blue
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Name = "Label34"
        '
        'PortA15
        '
        resources.ApplyResources(Me.PortA15, "PortA15")
        Me.PortA15.BackColor = System.Drawing.Color.Black
        Me.PortA15.ForeColor = System.Drawing.Color.White
        Me.PortA15.Name = "PortA15"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.BackColor = System.Drawing.Color.Blue
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Name = "Label32"
        '
        'PortA14
        '
        resources.ApplyResources(Me.PortA14, "PortA14")
        Me.PortA14.BackColor = System.Drawing.Color.Black
        Me.PortA14.ForeColor = System.Drawing.Color.White
        Me.PortA14.Name = "PortA14"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.BackColor = System.Drawing.Color.Blue
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Name = "Label30"
        '
        'PortA13
        '
        resources.ApplyResources(Me.PortA13, "PortA13")
        Me.PortA13.BackColor = System.Drawing.Color.Black
        Me.PortA13.ForeColor = System.Drawing.Color.White
        Me.PortA13.Name = "PortA13"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.BackColor = System.Drawing.Color.Blue
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Name = "Label28"
        '
        'PortA12
        '
        resources.ApplyResources(Me.PortA12, "PortA12")
        Me.PortA12.BackColor = System.Drawing.Color.Black
        Me.PortA12.ForeColor = System.Drawing.Color.White
        Me.PortA12.Name = "PortA12"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.BackColor = System.Drawing.Color.Blue
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Name = "Label26"
        '
        'PortA11
        '
        resources.ApplyResources(Me.PortA11, "PortA11")
        Me.PortA11.BackColor = System.Drawing.Color.Black
        Me.PortA11.ForeColor = System.Drawing.Color.White
        Me.PortA11.Name = "PortA11"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.BackColor = System.Drawing.Color.Blue
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Name = "Label24"
        '
        'PortA10
        '
        resources.ApplyResources(Me.PortA10, "PortA10")
        Me.PortA10.BackColor = System.Drawing.Color.Black
        Me.PortA10.ForeColor = System.Drawing.Color.White
        Me.PortA10.Name = "PortA10"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.BackColor = System.Drawing.Color.Blue
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Name = "Label22"
        '
        'PortA9
        '
        resources.ApplyResources(Me.PortA9, "PortA9")
        Me.PortA9.BackColor = System.Drawing.Color.Black
        Me.PortA9.ForeColor = System.Drawing.Color.White
        Me.PortA9.Name = "PortA9"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.BackColor = System.Drawing.Color.Blue
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Name = "Label20"
        '
        'PortA8
        '
        resources.ApplyResources(Me.PortA8, "PortA8")
        Me.PortA8.BackColor = System.Drawing.Color.Black
        Me.PortA8.ForeColor = System.Drawing.Color.White
        Me.PortA8.Name = "PortA8"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.BackColor = System.Drawing.Color.Blue
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Name = "Label18"
        '
        'PortA7
        '
        resources.ApplyResources(Me.PortA7, "PortA7")
        Me.PortA7.BackColor = System.Drawing.Color.Black
        Me.PortA7.ForeColor = System.Drawing.Color.White
        Me.PortA7.Name = "PortA7"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.BackColor = System.Drawing.Color.Blue
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Name = "Label16"
        '
        'PortA6
        '
        resources.ApplyResources(Me.PortA6, "PortA6")
        Me.PortA6.BackColor = System.Drawing.Color.Black
        Me.PortA6.ForeColor = System.Drawing.Color.White
        Me.PortA6.Name = "PortA6"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.BackColor = System.Drawing.Color.Blue
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Name = "Label14"
        '
        'PortA5
        '
        resources.ApplyResources(Me.PortA5, "PortA5")
        Me.PortA5.BackColor = System.Drawing.Color.Black
        Me.PortA5.ForeColor = System.Drawing.Color.White
        Me.PortA5.Name = "PortA5"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.BackColor = System.Drawing.Color.Blue
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Name = "Label12"
        '
        'PortA4
        '
        resources.ApplyResources(Me.PortA4, "PortA4")
        Me.PortA4.BackColor = System.Drawing.Color.Black
        Me.PortA4.ForeColor = System.Drawing.Color.White
        Me.PortA4.Name = "PortA4"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Blue
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'PortA3
        '
        resources.ApplyResources(Me.PortA3, "PortA3")
        Me.PortA3.BackColor = System.Drawing.Color.Black
        Me.PortA3.ForeColor = System.Drawing.Color.White
        Me.PortA3.Name = "PortA3"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Name = "Label8"
        '
        'PortA2
        '
        resources.ApplyResources(Me.PortA2, "PortA2")
        Me.PortA2.BackColor = System.Drawing.Color.Black
        Me.PortA2.ForeColor = System.Drawing.Color.White
        Me.PortA2.Name = "PortA2"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Name = "Label6"
        '
        'PortA1
        '
        resources.ApplyResources(Me.PortA1, "PortA1")
        Me.PortA1.BackColor = System.Drawing.Color.Black
        Me.PortA1.ForeColor = System.Drawing.Color.White
        Me.PortA1.Name = "PortA1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'PortA0
        '
        resources.ApplyResources(Me.PortA0, "PortA0")
        Me.PortA0.BackColor = System.Drawing.Color.Black
        Me.PortA0.ForeColor = System.Drawing.Color.White
        Me.PortA0.Name = "PortA0"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'cmsAnalogs
        '
        resources.ApplyResources(Me.cmsAnalogs, "cmsAnalogs")
        Me.cmsAnalogs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPlotAnalog})
        Me.cmsAnalogs.Name = "cmsAnalogs"
        '
        'tsmiPlotAnalog
        '
        resources.ApplyResources(Me.tsmiPlotAnalog, "tsmiPlotAnalog")
        Me.tsmiPlotAnalog.Image = Global.Druida_IDE_Lite.My.Resources.Resources.plot
        Me.tsmiPlotAnalog.Name = "tsmiPlotAnalog"
        '
        'HardwareMonitor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbAnalogs)
        Me.Controls.Add(Me.gbHardwareMonitor)
        Me.Controls.Add(Me.tsHardwareMonitor)
        Me.Name = "HardwareMonitor"
        Me.tsHardwareMonitor.ResumeLayout(False)
        Me.tsHardwareMonitor.PerformLayout()
        Me.gbHardwareMonitor.ResumeLayout(False)
        Me.gbHardwareMonitor.PerformLayout()
        Me.cmsHardware.ResumeLayout(False)
        Me.gbAnalogs.ResumeLayout(False)
        Me.gbAnalogs.PerformLayout()
        Me.cmsAnalogs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Port0 As Label
    Friend WithEvents tsHardwareMonitor As ToolStrip
    Friend WithEvents tslPort As ToolStripLabel
    Friend WithEvents tscbPort As ToolStripComboBox
    Friend WithEvents tslBaud As ToolStripLabel
    Friend WithEvents tscbBaud As ToolStripComboBox
    Friend WithEvents tsbtConection As ToolStripButton
    Friend WithEvents tsbtSettings As ToolStripButton
    Friend WithEvents gbHardwareMonitor As GroupBox
    Friend WithEvents TimerUpdateCOM As Timer
    Friend WithEvents Port2 As Label
    Friend WithEvents Port1 As Label
    Friend WithEvents Port21 As Label
    Friend WithEvents Port20 As Label
    Friend WithEvents Port19 As Label
    Friend WithEvents Port18 As Label
    Friend WithEvents Port17 As Label
    Friend WithEvents Port16 As Label
    Friend WithEvents Port15 As Label
    Friend WithEvents Port14 As Label
    Friend WithEvents Port13 As Label
    Friend WithEvents Port12 As Label
    Friend WithEvents Port11 As Label
    Friend WithEvents Port10 As Label
    Friend WithEvents Port9 As Label
    Friend WithEvents Port8 As Label
    Friend WithEvents Port7 As Label
    Friend WithEvents Port6 As Label
    Friend WithEvents Port5 As Label
    Friend WithEvents Port4 As Label
    Friend WithEvents Port3 As Label
    Friend WithEvents Port43 As Label
    Friend WithEvents Port42 As Label
    Friend WithEvents Port41 As Label
    Friend WithEvents Port40 As Label
    Friend WithEvents Port39 As Label
    Friend WithEvents Port38 As Label
    Friend WithEvents Port37 As Label
    Friend WithEvents Port36 As Label
    Friend WithEvents Port35 As Label
    Friend WithEvents Port34 As Label
    Friend WithEvents Port33 As Label
    Friend WithEvents Port32 As Label
    Friend WithEvents Port31 As Label
    Friend WithEvents Port30 As Label
    Friend WithEvents Port29 As Label
    Friend WithEvents Port28 As Label
    Friend WithEvents Port27 As Label
    Friend WithEvents Port26 As Label
    Friend WithEvents Port25 As Label
    Friend WithEvents Port24 As Label
    Friend WithEvents Port23 As Label
    Friend WithEvents Port22 As Label
    Friend WithEvents cmsHardware As ContextMenuStrip
    Friend WithEvents TsmiForceOn As ToolStripMenuItem
    Friend WithEvents TsmiForceOff As ToolStripMenuItem
    Friend WithEvents TsmiConfigAsInput As ToolStripMenuItem
    Friend WithEvents TsmiConfigAsOutput As ToolStripMenuItem
    Friend WithEvents Port65 As Label
    Friend WithEvents Port64 As Label
    Friend WithEvents Port63 As Label
    Friend WithEvents Port62 As Label
    Friend WithEvents Port61 As Label
    Friend WithEvents Port60 As Label
    Friend WithEvents Port59 As Label
    Friend WithEvents Port58 As Label
    Friend WithEvents Port57 As Label
    Friend WithEvents Port56 As Label
    Friend WithEvents Port55 As Label
    Friend WithEvents Port54 As Label
    Friend WithEvents Port53 As Label
    Friend WithEvents Port52 As Label
    Friend WithEvents Port51 As Label
    Friend WithEvents Port50 As Label
    Friend WithEvents Port49 As Label
    Friend WithEvents Port48 As Label
    Friend WithEvents Port47 As Label
    Friend WithEvents Port46 As Label
    Friend WithEvents Port45 As Label
    Friend WithEvents Port44 As Label
    Friend WithEvents Porta71 As Label
    Friend WithEvents Porta69 As Label
    Friend WithEvents Porta70 As Label
    Friend WithEvents Porta68 As Label
    Friend WithEvents Porta67 As Label
    Friend WithEvents Porta66 As Label
    Friend WithEvents gbAnalogs As GroupBox
    Friend WithEvents PortA21 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents PortA20 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents PortA19 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents PortA18 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents PortA17 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents PortA16 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents PortA15 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PortA14 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents PortA13 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents PortA12 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PortA11 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PortA10 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PortA9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PortA8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PortA7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PortA6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PortA5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PortA4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PortA3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PortA2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PortA1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PortA0 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tsbtReadDigitalAnalog As ToolStripButton
    Friend WithEvents PlotarGráficoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsAnalogs As ContextMenuStrip
    Friend WithEvents tsmiPlotAnalog As ToolStripMenuItem
End Class
