<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrariesManager
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibrariesManager))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tsLibsManager = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonAbrirSketch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonImport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonExit = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.libsExplorer = New DruidaIDEAuxiliarControls.Explorer()
        Me.ilLibsManager = New System.Windows.Forms.ImageList(Me.components)
        Me.tsSearch = New System.Windows.Forms.ToolStrip()
        Me.tstbSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtSearch = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Code = New Code_Editor_For_Arduino.CodeEditorForArduino()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tsLibsManager.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.tsSearch.SuspendLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        resources.ApplyResources(Me.SplitContainer1.Panel1, "SplitContainer1.Panel1")
        Me.SplitContainer1.Panel1.Controls.Add(Me.tsLibsManager)
        '
        'SplitContainer1.Panel2
        '
        resources.ApplyResources(Me.SplitContainer1.Panel2, "SplitContainer1.Panel2")
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        '
        'tsLibsManager
        '
        resources.ApplyResources(Me.tsLibsManager, "tsLibsManager")
        Me.tsLibsManager.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsLibsManager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAbrirSketch, Me.ToolStripButtonImport, Me.ToolStripButtonCopy, Me.ToolStripButtonExit})
        Me.tsLibsManager.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsLibsManager.Name = "tsLibsManager"
        '
        'ToolStripButtonAbrirSketch
        '
        resources.ApplyResources(Me.ToolStripButtonAbrirSketch, "ToolStripButtonAbrirSketch")
        Me.ToolStripButtonAbrirSketch.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Open
        Me.ToolStripButtonAbrirSketch.Name = "ToolStripButtonAbrirSketch"
        '
        'ToolStripButtonImport
        '
        resources.ApplyResources(Me.ToolStripButtonImport, "ToolStripButtonImport")
        Me.ToolStripButtonImport.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Import_File
        Me.ToolStripButtonImport.Name = "ToolStripButtonImport"
        '
        'ToolStripButtonCopy
        '
        resources.ApplyResources(Me.ToolStripButtonCopy, "ToolStripButtonCopy")
        Me.ToolStripButtonCopy.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Copy
        Me.ToolStripButtonCopy.Name = "ToolStripButtonCopy"
        '
        'ToolStripButtonExit
        '
        resources.ApplyResources(Me.ToolStripButtonExit, "ToolStripButtonExit")
        Me.ToolStripButtonExit.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Quit
        Me.ToolStripButtonExit.Name = "ToolStripButtonExit"
        '
        'SplitContainer2
        '
        resources.ApplyResources(Me.SplitContainer2, "SplitContainer2")
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        resources.ApplyResources(Me.SplitContainer2.Panel1, "SplitContainer2.Panel1")
        Me.SplitContainer2.Panel1.Controls.Add(Me.libsExplorer)
        Me.SplitContainer2.Panel1.Controls.Add(Me.tsSearch)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        resources.ApplyResources(Me.SplitContainer2.Panel2, "SplitContainer2.Panel2")
        Me.SplitContainer2.Panel2.Controls.Add(Me.Code)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        '
        'libsExplorer
        '
        resources.ApplyResources(Me.libsExplorer, "libsExplorer")
        Me.libsExplorer.Extensions = New String() {Nothing, ".h"}
        Me.libsExplorer.FullRowSelect = True
        Me.libsExplorer.HideEmptyFolders = True
        Me.libsExplorer.HideSelection = False
        Me.libsExplorer.ImageList = Me.ilLibsManager
        Me.libsExplorer.Name = "libsExplorer"
        Me.libsExplorer.Paths = CType(resources.GetObject("libsExplorer.Paths"), System.Collections.Generic.List(Of String))
        Me.libsExplorer.PathsNames = CType(resources.GetObject("libsExplorer.PathsNames"), System.Collections.Generic.List(Of String))
        '
        'ilLibsManager
        '
        Me.ilLibsManager.ImageStream = CType(resources.GetObject("ilLibsManager.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLibsManager.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLibsManager.Images.SetKeyName(0, "Folder.png")
        Me.ilLibsManager.Images.SetKeyName(1, "h.png")
        '
        'tsSearch
        '
        resources.ApplyResources(Me.tsSearch, "tsSearch")
        Me.tsSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstbSearch, Me.tsbtSearch})
        Me.tsSearch.Name = "tsSearch"
        '
        'tstbSearch
        '
        resources.ApplyResources(Me.tstbSearch, "tstbSearch")
        Me.tstbSearch.Name = "tstbSearch"
        '
        'tsbtSearch
        '
        resources.ApplyResources(Me.tsbtSearch, "tsbtSearch")
        Me.tsbtSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSearch.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Find
        Me.tsbtSearch.Name = "tsbtSearch"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'Code
        '
        resources.ApplyResources(Me.Code, "Code")
        Me.Code.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Code.BackBrush = Nothing
        Me.Code.CharHeight = 14
        Me.Code.CharWidth = 8
        Me.Code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Code.IsReplaceMode = False
        Me.Code.Name = "Code"
        Me.Code.Paddings = New System.Windows.Forms.Padding(0)
        Me.Code.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Code.ServiceColors = CType(resources.GetObject("Code.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Code.Zoom = 100
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Name = "Label4"
        '
        'LibrariesManager
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LibrariesManager"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tsLibsManager.ResumeLayout(False)
        Me.tsLibsManager.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.tsSearch.ResumeLayout(False)
        Me.tsSearch.PerformLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tsLibsManager As ToolStrip
    Friend WithEvents ToolStripButtonAbrirSketch As ToolStripButton
    Friend WithEvents ToolStripButtonImport As ToolStripButton
    Friend WithEvents ToolStripButtonCopy As ToolStripButton
    Friend WithEvents ToolStripButtonExit As ToolStripButton
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents libsExplorer As DruidaIDEAuxiliarControls.Explorer
    Friend WithEvents Code As Code_Editor_For_Arduino.CodeEditorForArduino
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ilLibsManager As ImageList
    Friend WithEvents tsSearch As ToolStrip
    Friend WithEvents tstbSearch As ToolStripTextBox
    Friend WithEvents tsbtSearch As ToolStripButton
End Class
