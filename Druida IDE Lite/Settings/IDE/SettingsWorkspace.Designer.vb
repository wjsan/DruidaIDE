<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWorkspace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsWorkspace))
        Me.cbFullScreen = New System.Windows.Forms.CheckBox()
        Me.cbShowFilesList = New System.Windows.Forms.CheckBox()
        Me.cbShowObjectList = New System.Windows.Forms.CheckBox()
        Me.cbShowOutputTab = New System.Windows.Forms.CheckBox()
        Me.cbShowErrorsTab = New System.Windows.Forms.CheckBox()
        Me.cbShowSerialMonitorTab = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFullPathOnTab = New System.Windows.Forms.CheckBox()
        Me.cbShowHardwareDebugger = New System.Windows.Forms.CheckBox()
        Me.cbShowConsole = New System.Windows.Forms.CheckBox()
        Me.cbShowDocumentMap = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbFullScreen
        '
        resources.ApplyResources(Me.cbFullScreen, "cbFullScreen")
        Me.cbFullScreen.Name = "cbFullScreen"
        Me.cbFullScreen.UseVisualStyleBackColor = True
        '
        'cbShowFilesList
        '
        resources.ApplyResources(Me.cbShowFilesList, "cbShowFilesList")
        Me.cbShowFilesList.Name = "cbShowFilesList"
        Me.cbShowFilesList.UseVisualStyleBackColor = True
        '
        'cbShowObjectList
        '
        resources.ApplyResources(Me.cbShowObjectList, "cbShowObjectList")
        Me.cbShowObjectList.Name = "cbShowObjectList"
        Me.cbShowObjectList.UseVisualStyleBackColor = True
        '
        'cbShowOutputTab
        '
        resources.ApplyResources(Me.cbShowOutputTab, "cbShowOutputTab")
        Me.cbShowOutputTab.Name = "cbShowOutputTab"
        Me.cbShowOutputTab.UseVisualStyleBackColor = True
        '
        'cbShowErrorsTab
        '
        resources.ApplyResources(Me.cbShowErrorsTab, "cbShowErrorsTab")
        Me.cbShowErrorsTab.Name = "cbShowErrorsTab"
        Me.cbShowErrorsTab.UseVisualStyleBackColor = True
        '
        'cbShowSerialMonitorTab
        '
        resources.ApplyResources(Me.cbShowSerialMonitorTab, "cbShowSerialMonitorTab")
        Me.cbShowSerialMonitorTab.Name = "cbShowSerialMonitorTab"
        Me.cbShowSerialMonitorTab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFullPathOnTab)
        Me.GroupBox1.Controls.Add(Me.cbShowHardwareDebugger)
        Me.GroupBox1.Controls.Add(Me.cbShowConsole)
        Me.GroupBox1.Controls.Add(Me.cbShowDocumentMap)
        Me.GroupBox1.Controls.Add(Me.cbFullScreen)
        Me.GroupBox1.Controls.Add(Me.cbShowSerialMonitorTab)
        Me.GroupBox1.Controls.Add(Me.cbShowFilesList)
        Me.GroupBox1.Controls.Add(Me.cbShowErrorsTab)
        Me.GroupBox1.Controls.Add(Me.cbShowObjectList)
        Me.GroupBox1.Controls.Add(Me.cbShowOutputTab)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cbFullPathOnTab
        '
        resources.ApplyResources(Me.cbFullPathOnTab, "cbFullPathOnTab")
        Me.cbFullPathOnTab.Name = "cbFullPathOnTab"
        Me.cbFullPathOnTab.UseVisualStyleBackColor = True
        '
        'cbShowHardwareDebugger
        '
        resources.ApplyResources(Me.cbShowHardwareDebugger, "cbShowHardwareDebugger")
        Me.cbShowHardwareDebugger.Name = "cbShowHardwareDebugger"
        Me.cbShowHardwareDebugger.UseVisualStyleBackColor = True
        '
        'cbShowConsole
        '
        resources.ApplyResources(Me.cbShowConsole, "cbShowConsole")
        Me.cbShowConsole.Name = "cbShowConsole"
        Me.cbShowConsole.UseVisualStyleBackColor = True
        '
        'cbShowDocumentMap
        '
        resources.ApplyResources(Me.cbShowDocumentMap, "cbShowDocumentMap")
        Me.cbShowDocumentMap.Name = "cbShowDocumentMap"
        Me.cbShowDocumentMap.UseVisualStyleBackColor = True
        '
        'SettingsWorkspace
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SettingsWorkspace"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbFullScreen As CheckBox
    Friend WithEvents cbShowFilesList As CheckBox
    Friend WithEvents cbShowObjectList As CheckBox
    Friend WithEvents cbShowOutputTab As CheckBox
    Friend WithEvents cbShowErrorsTab As CheckBox
    Friend WithEvents cbShowSerialMonitorTab As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbShowDocumentMap As CheckBox
    Friend WithEvents cbShowConsole As CheckBox
    Friend WithEvents cbShowHardwareDebugger As CheckBox
    Friend WithEvents cbFullPathOnTab As CheckBox
End Class
