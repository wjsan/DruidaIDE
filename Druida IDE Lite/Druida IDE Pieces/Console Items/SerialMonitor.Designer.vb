<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SerialMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialMonitor))
        Me.btSend = New System.Windows.Forms.Button()
        Me.tbSerialInput = New System.Windows.Forms.TextBox()
        Me.tsSerialMonitor = New System.Windows.Forms.ToolStrip()
        Me.tslPort = New System.Windows.Forms.ToolStripLabel()
        Me.tscbPort = New System.Windows.Forms.ToolStripComboBox()
        Me.tslBaud = New System.Windows.Forms.ToolStripLabel()
        Me.tscbBaud = New System.Windows.Forms.ToolStripComboBox()
        Me.tslFinalizer = New System.Windows.Forms.ToolStripLabel()
        Me.tscbFinalizer = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbtAutoClear = New System.Windows.Forms.ToolStripButton()
        Me.tsbtAutoScroll = New System.Windows.Forms.ToolStripButton()
        Me.tsbtConection = New System.Windows.Forms.ToolStripButton()
        Me.tsbtSettings = New System.Windows.Forms.ToolStripButton()
        Me.tsbtSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtClearSerial = New System.Windows.Forms.ToolStripButton()
        Me.tbSerialMonitor = New System.Windows.Forms.TextBox()
        Me.tsSerialMonitor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btSend
        '
        resources.ApplyResources(Me.btSend, "btSend")
        Me.btSend.Name = "btSend"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'tbSerialInput
        '
        resources.ApplyResources(Me.tbSerialInput, "tbSerialInput")
        Me.tbSerialInput.Name = "tbSerialInput"
        '
        'tsSerialMonitor
        '
        resources.ApplyResources(Me.tsSerialMonitor, "tsSerialMonitor")
        Me.tsSerialMonitor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslPort, Me.tscbPort, Me.tslBaud, Me.tscbBaud, Me.tslFinalizer, Me.tscbFinalizer, Me.tsbtAutoClear, Me.tsbtAutoScroll, Me.tsbtConection, Me.tsbtSettings, Me.tsbtSave, Me.tsbtClearSerial})
        Me.tsSerialMonitor.Name = "tsSerialMonitor"
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
        'tslFinalizer
        '
        resources.ApplyResources(Me.tslFinalizer, "tslFinalizer")
        Me.tslFinalizer.Name = "tslFinalizer"
        '
        'tscbFinalizer
        '
        resources.ApplyResources(Me.tscbFinalizer, "tscbFinalizer")
        Me.tscbFinalizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbFinalizer.Items.AddRange(New Object() {resources.GetString("tscbFinalizer.Items"), resources.GetString("tscbFinalizer.Items1"), resources.GetString("tscbFinalizer.Items2"), resources.GetString("tscbFinalizer.Items3")})
        Me.tscbFinalizer.Name = "tscbFinalizer"
        '
        'tsbtAutoClear
        '
        resources.ApplyResources(Me.tsbtAutoClear, "tsbtAutoClear")
        Me.tsbtAutoClear.Checked = True
        Me.tsbtAutoClear.CheckOnClick = True
        Me.tsbtAutoClear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbtAutoClear.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Rename
        Me.tsbtAutoClear.Name = "tsbtAutoClear"
        '
        'tsbtAutoScroll
        '
        resources.ApplyResources(Me.tsbtAutoScroll, "tsbtAutoScroll")
        Me.tsbtAutoScroll.Checked = True
        Me.tsbtAutoScroll.CheckOnClick = True
        Me.tsbtAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbtAutoScroll.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Auto_Scroll
        Me.tsbtAutoScroll.Name = "tsbtAutoScroll"
        '
        'tsbtConection
        '
        resources.ApplyResources(Me.tsbtConection, "tsbtConection")
        Me.tsbtConection.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete
        Me.tsbtConection.Name = "tsbtConection"
        '
        'tsbtSettings
        '
        resources.ApplyResources(Me.tsbtSettings, "tsbtSettings")
        Me.tsbtSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSettings.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Options
        Me.tsbtSettings.Name = "tsbtSettings"
        '
        'tsbtSave
        '
        resources.ApplyResources(Me.tsbtSave, "tsbtSave")
        Me.tsbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSave.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_File
        Me.tsbtSave.Name = "tsbtSave"
        '
        'tsbtClearSerial
        '
        resources.ApplyResources(Me.tsbtClearSerial, "tsbtClearSerial")
        Me.tsbtClearSerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtClearSerial.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete_All
        Me.tsbtClearSerial.Name = "tsbtClearSerial"
        '
        'tbSerialMonitor
        '
        resources.ApplyResources(Me.tbSerialMonitor, "tbSerialMonitor")
        Me.tbSerialMonitor.Name = "tbSerialMonitor"
        '
        'SerialMonitor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbSerialMonitor)
        Me.Controls.Add(Me.btSend)
        Me.Controls.Add(Me.tbSerialInput)
        Me.Controls.Add(Me.tsSerialMonitor)
        Me.Name = "SerialMonitor"
        Me.tsSerialMonitor.ResumeLayout(False)
        Me.tsSerialMonitor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSend As Button
    Friend WithEvents tbSerialInput As TextBox
    Friend WithEvents tsSerialMonitor As ToolStrip
    Friend WithEvents tslPort As ToolStripLabel
    Friend WithEvents tscbPort As ToolStripComboBox
    Friend WithEvents tslBaud As ToolStripLabel
    Friend WithEvents tscbBaud As ToolStripComboBox
    Friend WithEvents tsbtClearSerial As ToolStripButton
    Friend WithEvents tscbFinalizer As ToolStripComboBox
    Friend WithEvents tbSerialMonitor As TextBox
    Friend WithEvents tsbtAutoScroll As ToolStripButton
    Friend WithEvents tsbtConection As ToolStripButton
    Friend WithEvents tslFinalizer As ToolStripLabel
    Friend WithEvents tsbtSettings As ToolStripButton
    Friend WithEvents tsbtSave As ToolStripButton
    Friend WithEvents tsbtAutoClear As ToolStripButton
End Class
