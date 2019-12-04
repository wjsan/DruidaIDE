<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamplesManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamplesManager))
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.pbLayout = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbSchematix = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Code = New Code_Editor_For_Arduino.CodeEditorForArduino()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.tsExamplesManager = New System.Windows.Forms.ToolStrip()
        Me.tsbtOpenInNewWindow = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonAbrirSketch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonImport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonExit = New System.Windows.Forms.ToolStripButton()
        Me.ExampleManager = New DruidaIDEAuxiliarControls.Explorer()
        Me.ilExamples = New System.Windows.Forms.ImageList(Me.components)
        Me.tsSearch = New System.Windows.Forms.ToolStrip()
        Me.tstbSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtSearch = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.pbLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSchematix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.tsExamplesManager.SuspendLayout()
        Me.tsSearch.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer4
        '
        resources.ApplyResources(Me.SplitContainer4, "SplitContainer4")
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        resources.ApplyResources(Me.SplitContainer4.Panel1, "SplitContainer4.Panel1")
        Me.SplitContainer4.Panel1.Controls.Add(Me.pbLayout)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer4.Panel2
        '
        resources.ApplyResources(Me.SplitContainer4.Panel2, "SplitContainer4.Panel2")
        Me.SplitContainer4.Panel2.Controls.Add(Me.pbSchematix)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label2)
        '
        'pbLayout
        '
        resources.ApplyResources(Me.pbLayout, "pbLayout")
        Me.pbLayout.BackColor = System.Drawing.Color.White
        Me.pbLayout.Name = "pbLayout"
        Me.pbLayout.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'pbSchematix
        '
        resources.ApplyResources(Me.pbSchematix, "pbSchematix")
        Me.pbSchematix.BackColor = System.Drawing.Color.White
        Me.pbSchematix.Name = "pbSchematix"
        Me.pbSchematix.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Name = "Label2"
        '
        'SplitContainer3
        '
        resources.ApplyResources(Me.SplitContainer3, "SplitContainer3")
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        resources.ApplyResources(Me.SplitContainer3.Panel1, "SplitContainer3.Panel1")
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        resources.ApplyResources(Me.SplitContainer3.Panel2, "SplitContainer3.Panel2")
        Me.SplitContainer3.Panel2.Controls.Add(Me.Code)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label4)
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
        'SplitContainer5
        '
        resources.ApplyResources(Me.SplitContainer5, "SplitContainer5")
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        resources.ApplyResources(Me.SplitContainer5.Panel1, "SplitContainer5.Panel1")
        Me.SplitContainer5.Panel1.Controls.Add(Me.tsExamplesManager)
        '
        'SplitContainer5.Panel2
        '
        resources.ApplyResources(Me.SplitContainer5.Panel2, "SplitContainer5.Panel2")
        Me.SplitContainer5.Panel2.Controls.Add(Me.ExampleManager)
        Me.SplitContainer5.Panel2.Controls.Add(Me.tsSearch)
        Me.SplitContainer5.Panel2.Controls.Add(Me.Label3)
        '
        'tsExamplesManager
        '
        resources.ApplyResources(Me.tsExamplesManager, "tsExamplesManager")
        Me.tsExamplesManager.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsExamplesManager.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtOpenInNewWindow, Me.ToolStripButtonAbrirSketch, Me.ToolStripButtonImport, Me.ToolStripButtonCopy, Me.ToolStripButtonExit})
        Me.tsExamplesManager.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsExamplesManager.Name = "tsExamplesManager"
        '
        'tsbtOpenInNewWindow
        '
        resources.ApplyResources(Me.tsbtOpenInNewWindow, "tsbtOpenInNewWindow")
        Me.tsbtOpenInNewWindow.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Open
        Me.tsbtOpenInNewWindow.Name = "tsbtOpenInNewWindow"
        '
        'ToolStripButtonAbrirSketch
        '
        resources.ApplyResources(Me.ToolStripButtonAbrirSketch, "ToolStripButtonAbrirSketch")
        Me.ToolStripButtonAbrirSketch.Image = Global.Druida_IDE_Lite.My.Resources.Resources.FilesList
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
        'ExampleManager
        '
        resources.ApplyResources(Me.ExampleManager, "ExampleManager")
        Me.ExampleManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExampleManager.Extensions = New String() {Nothing, ".ino", ".pde", Nothing}
        Me.ExampleManager.HideEmptyFolders = True
        Me.ExampleManager.ImageList = Me.ilExamples
        Me.ExampleManager.Name = "ExampleManager"
        Me.ExampleManager.Paths = CType(resources.GetObject("ExampleManager.Paths"), System.Collections.Generic.List(Of String))
        Me.ExampleManager.PathsNames = CType(resources.GetObject("ExampleManager.PathsNames"), System.Collections.Generic.List(Of String))
        '
        'ilExamples
        '
        Me.ilExamples.ImageStream = CType(resources.GetObject("ilExamples.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilExamples.TransparentColor = System.Drawing.Color.Transparent
        Me.ilExamples.Images.SetKeyName(0, "Folder.png")
        Me.ilExamples.Images.SetKeyName(1, "Arduino.png")
        Me.ilExamples.Images.SetKeyName(2, "Arduino.png")
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
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Name = "Label3"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer2.Panel2
        '
        resources.ApplyResources(Me.SplitContainer2.Panel2, "SplitContainer2.Panel2")
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        resources.ApplyResources(Me.SplitContainer1.Panel1, "SplitContainer1.Panel1")
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        resources.ApplyResources(Me.SplitContainer1.Panel2, "SplitContainer1.Panel2")
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbDescription)
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Name = "Label5"
        '
        'tbDescription
        '
        resources.ApplyResources(Me.tbDescription, "tbDescription")
        Me.tbDescription.Name = "tbDescription"
        '
        'ExamplesManager
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ExamplesManager"
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.pbLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSchematix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.tsExamplesManager.ResumeLayout(False)
        Me.tsExamplesManager.PerformLayout()
        Me.tsSearch.ResumeLayout(False)
        Me.tsSearch.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbDescription As TextBox
    Friend WithEvents Code As Code_Editor_For_Arduino.CodeEditorForArduino
    Friend WithEvents Label4 As Label
    Friend WithEvents pbSchematix As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents pbLayout As PictureBox
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents ExampleManager As DruidaIDEAuxiliarControls.Explorer
    Friend WithEvents ToolStripButtonCopy As ToolStripButton
    Friend WithEvents ToolStripButtonImport As ToolStripButton
    Friend WithEvents ToolStripButtonAbrirSketch As ToolStripButton
    Friend WithEvents tsExamplesManager As ToolStrip
    Friend WithEvents ToolStripButtonExit As ToolStripButton
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ilExamples As ImageList
    Friend WithEvents Label3 As Label
    Friend WithEvents tsSearch As ToolStrip
    Friend WithEvents tstbSearch As ToolStripTextBox
    Friend WithEvents tsbtSearch As ToolStripButton
    Friend WithEvents tsbtOpenInNewWindow As ToolStripButton
End Class
