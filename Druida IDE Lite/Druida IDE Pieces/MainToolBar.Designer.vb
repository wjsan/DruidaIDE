<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainToolBar
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainToolBar))
        Me.tcMainToolBar = New VisualStudioTabControl.VisualStudioTabControl()
        Me.tpProject = New System.Windows.Forms.TabPage()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbBoard = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBoard = New System.Windows.Forms.ComboBox()
        Me.tsProject = New System.Windows.Forms.ToolStrip()
        Me.tsbNewProject = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbSaveAs = New System.Windows.Forms.ToolStripButton()
        Me.tsbtExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHardware = New System.Windows.Forms.ToolStripButton()
        Me.tsbCompile = New System.Windows.Forms.ToolStripButton()
        Me.tsbUpload = New System.Windows.Forms.ToolStripButton()
        Me.tsbtScada = New System.Windows.Forms.ToolStripButton()
        Me.tsbSerialMonitor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tpFile = New System.Windows.Forms.TabPage()
        Me.tsFile = New System.Windows.Forms.ToolStrip()
        Me.tsbNewFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtSaveFileAs = New System.Windows.Forms.ToolStripButton()
        Me.tsbImportFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbDirectories = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportAsHtml = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpenIDE = New System.Windows.Forms.ToolStripButton()
        Me.tsbExamples = New System.Windows.Forms.ToolStripButton()
        Me.tsbLibraries = New System.Windows.Forms.ToolStripButton()
        Me.tpEdit = New System.Windows.Forms.TabPage()
        Me.tsEdit = New System.Windows.Forms.ToolStrip()
        Me.tsbGoTo = New System.Windows.Forms.ToolStripButton()
        Me.tsbFind = New System.Windows.Forms.ToolStripButton()
        Me.tsbFindAndReplace = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbUndo = New System.Windows.Forms.ToolStripButton()
        Me.tsbRedo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCut = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tsbPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbIdent = New System.Windows.Forms.ToolStripButton()
        Me.tsbCommentSelected = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtFold = New System.Windows.Forms.ToolStripButton()
        Me.tsbtUnfold = New System.Windows.Forms.ToolStripButton()
        Me.tpView = New System.Windows.Forms.TabPage()
        Me.tsView = New System.Windows.Forms.ToolStrip()
        Me.tsbtFullScreen = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFileList = New System.Windows.Forms.ToolStripButton()
        Me.tsbtObjects = New System.Windows.Forms.ToolStripButton()
        Me.tsbtConsole = New System.Windows.Forms.ToolStripButton()
        Me.tsbtDocumentMap = New System.Windows.Forms.ToolStripButton()
        Me.tsbtShowOutput = New System.Windows.Forms.ToolStripButton()
        Me.tsbtShowErrors = New System.Windows.Forms.ToolStripButton()
        Me.tsbtShowSerialMonitor = New System.Windows.Forms.ToolStripButton()
        Me.tsbtShowHardwareMonitor = New System.Windows.Forms.ToolStripButton()
        Me.tpTools = New System.Windows.Forms.TabPage()
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.tsbVarMonitor = New System.Windows.Forms.ToolStripButton()
        Me.tsbClear = New System.Windows.Forms.ToolStripButton()
        Me.tsbInterrupt = New System.Windows.Forms.ToolStripButton()
        Me.tsbtHardwareDebugger = New System.Windows.Forms.ToolStripButton()
        Me.tsbVerifySyntax = New System.Windows.Forms.ToolStripButton()
        Me.tsbCodeSnnipetsManager = New System.Windows.Forms.ToolStripButton()
        Me.tsbOptions = New System.Windows.Forms.ToolStripButton()
        Me.tpHelp = New System.Windows.Forms.TabPage()
        Me.tsHelp = New System.Windows.Forms.ToolStrip()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.tsbOnlineDocuments = New System.Windows.Forms.ToolStripButton()
        Me.tsbTutorial = New System.Windows.Forms.ToolStripButton()
        Me.tsbOnlineSupport = New System.Windows.Forms.ToolStripButton()
        Me.tsbtBugReport = New System.Windows.Forms.ToolStripButton()
        Me.tsbSuggestion = New System.Windows.Forms.ToolStripButton()
        Me.cmsCodeEditor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiGoTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPast = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiIdent = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.DobramentoDeCódigoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiFold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUnfold = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lClose = New System.Windows.Forms.Label()
        Me.lMinimize = New System.Windows.Forms.Label()
        Me.tcMainToolBar.SuspendLayout()
        Me.tpProject.SuspendLayout()
        CType(Me.pbBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsProject.SuspendLayout()
        Me.tpFile.SuspendLayout()
        Me.tsFile.SuspendLayout()
        Me.tpEdit.SuspendLayout()
        Me.tsEdit.SuspendLayout()
        Me.tpView.SuspendLayout()
        Me.tsView.SuspendLayout()
        Me.tpTools.SuspendLayout()
        Me.tsTools.SuspendLayout()
        Me.tpHelp.SuspendLayout()
        Me.tsHelp.SuspendLayout()
        Me.cmsCodeEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMainToolBar
        '
        Me.tcMainToolBar.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tcMainToolBar.AllowDrop = True
        Me.tcMainToolBar.BackTabColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tcMainToolBar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tcMainToolBar.ClosingButtonColor = System.Drawing.Color.WhiteSmoke
        Me.tcMainToolBar.ClosingMessage = Nothing
        Me.tcMainToolBar.Controls.Add(Me.tpProject)
        Me.tcMainToolBar.Controls.Add(Me.tpFile)
        Me.tcMainToolBar.Controls.Add(Me.tpEdit)
        Me.tcMainToolBar.Controls.Add(Me.tpView)
        Me.tcMainToolBar.Controls.Add(Me.tpTools)
        Me.tcMainToolBar.Controls.Add(Me.tpHelp)
        resources.ApplyResources(Me.tcMainToolBar, "tcMainToolBar")
        Me.tcMainToolBar.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tcMainToolBar.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tcMainToolBar.Name = "tcMainToolBar"
        Me.tcMainToolBar.SelectedIndex = 0
        Me.tcMainToolBar.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tcMainToolBar.ShowClosingButton = False
        Me.tcMainToolBar.ShowClosingMessage = False
        Me.tcMainToolBar.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'tpProject
        '
        Me.tpProject.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpProject.Controls.Add(Me.cbPort)
        Me.tpProject.Controls.Add(Me.Label2)
        Me.tpProject.Controls.Add(Me.pbBoard)
        Me.tpProject.Controls.Add(Me.Label1)
        Me.tpProject.Controls.Add(Me.cbBoard)
        Me.tpProject.Controls.Add(Me.tsProject)
        resources.ApplyResources(Me.tpProject, "tpProject")
        Me.tpProject.Name = "tpProject"
        '
        'cbPort
        '
        Me.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbPort, "cbPort")
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Name = "cbPort"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Name = "Label2"
        '
        'pbBoard
        '
        resources.ApplyResources(Me.pbBoard, "pbBoard")
        Me.pbBoard.Name = "pbBoard"
        Me.pbBoard.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Name = "Label1"
        '
        'cbBoard
        '
        Me.cbBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbBoard, "cbBoard")
        Me.cbBoard.FormattingEnabled = True
        Me.cbBoard.Name = "cbBoard"
        '
        'tsProject
        '
        Me.tsProject.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsProject.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNewProject, Me.tsbOpen, Me.tsbSave, Me.tsbSaveAs, Me.tsbtExit, Me.ToolStripSeparator1, Me.tsbHardware, Me.tsbCompile, Me.tsbUpload, Me.tsbtScada, Me.tsbSerialMonitor, Me.ToolStripSeparator6})
        resources.ApplyResources(Me.tsProject, "tsProject")
        Me.tsProject.Name = "tsProject"
        Me.tsProject.ShowItemToolTips = False
        '
        'tsbNewProject
        '
        Me.tsbNewProject.Image = Global.Druida_IDE_Lite.My.Resources.Resources.New_File
        resources.ApplyResources(Me.tsbNewProject, "tsbNewProject")
        Me.tsbNewProject.Name = "tsbNewProject"
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Open
        resources.ApplyResources(Me.tsbOpen, "tsbOpen")
        Me.tsbOpen.Name = "tsbOpen"
        '
        'tsbSave
        '
        resources.ApplyResources(Me.tsbSave, "tsbSave")
        Me.tsbSave.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save
        Me.tsbSave.Name = "tsbSave"
        '
        'tsbSaveAs
        '
        resources.ApplyResources(Me.tsbSaveAs, "tsbSaveAs")
        Me.tsbSaveAs.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_As
        Me.tsbSaveAs.Name = "tsbSaveAs"
        '
        'tsbtExit
        '
        resources.ApplyResources(Me.tsbtExit, "tsbtExit")
        Me.tsbtExit.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Quit
        Me.tsbtExit.Name = "tsbtExit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'tsbHardware
        '
        resources.ApplyResources(Me.tsbHardware, "tsbHardware")
        Me.tsbHardware.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Hardware
        Me.tsbHardware.Name = "tsbHardware"
        '
        'tsbCompile
        '
        resources.ApplyResources(Me.tsbCompile, "tsbCompile")
        Me.tsbCompile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Verify
        Me.tsbCompile.Name = "tsbCompile"
        '
        'tsbUpload
        '
        resources.ApplyResources(Me.tsbUpload, "tsbUpload")
        Me.tsbUpload.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Upload
        Me.tsbUpload.Name = "tsbUpload"
        '
        'tsbtScada
        '
        resources.ApplyResources(Me.tsbtScada, "tsbtScada")
        Me.tsbtScada.Image = Global.Druida_IDE_Lite.My.Resources.Resources._813df8d9
        Me.tsbtScada.Name = "tsbtScada"
        '
        'tsbSerialMonitor
        '
        resources.ApplyResources(Me.tsbSerialMonitor, "tsbSerialMonitor")
        Me.tsbSerialMonitor.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Serial_Monitor
        Me.tsbSerialMonitor.Name = "tsbSerialMonitor"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'tpFile
        '
        Me.tpFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpFile.Controls.Add(Me.tsFile)
        resources.ApplyResources(Me.tpFile, "tpFile")
        Me.tpFile.Name = "tpFile"
        '
        'tsFile
        '
        Me.tsFile.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNewFile, Me.tsbOpenFile, Me.tsbtSaveFile, Me.tsbtSaveFileAs, Me.tsbImportFile, Me.tsbDirectories, Me.tsbExportAsHtml, Me.tsbOpenIDE, Me.tsbExamples, Me.tsbLibraries})
        resources.ApplyResources(Me.tsFile, "tsFile")
        Me.tsFile.Name = "tsFile"
        '
        'tsbNewFile
        '
        resources.ApplyResources(Me.tsbNewFile, "tsbNewFile")
        Me.tsbNewFile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Add_File
        Me.tsbNewFile.Name = "tsbNewFile"
        '
        'tsbOpenFile
        '
        Me.tsbOpenFile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Open
        resources.ApplyResources(Me.tsbOpenFile, "tsbOpenFile")
        Me.tsbOpenFile.Name = "tsbOpenFile"
        '
        'tsbtSaveFile
        '
        resources.ApplyResources(Me.tsbtSaveFile, "tsbtSaveFile")
        Me.tsbtSaveFile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_File
        Me.tsbtSaveFile.Name = "tsbtSaveFile"
        '
        'tsbtSaveFileAs
        '
        resources.ApplyResources(Me.tsbtSaveFileAs, "tsbtSaveFileAs")
        Me.tsbtSaveFileAs.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_File_As
        Me.tsbtSaveFileAs.Name = "tsbtSaveFileAs"
        '
        'tsbImportFile
        '
        resources.ApplyResources(Me.tsbImportFile, "tsbImportFile")
        Me.tsbImportFile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Import_File
        Me.tsbImportFile.Name = "tsbImportFile"
        '
        'tsbDirectories
        '
        resources.ApplyResources(Me.tsbDirectories, "tsbDirectories")
        Me.tsbDirectories.Image = Global.Druida_IDE_Lite.My.Resources.Resources.File_Config
        Me.tsbDirectories.Name = "tsbDirectories"
        '
        'tsbExportAsHtml
        '
        resources.ApplyResources(Me.tsbExportAsHtml, "tsbExportAsHtml")
        Me.tsbExportAsHtml.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Export_Html
        Me.tsbExportAsHtml.Name = "tsbExportAsHtml"
        '
        'tsbOpenIDE
        '
        resources.ApplyResources(Me.tsbOpenIDE, "tsbOpenIDE")
        Me.tsbOpenIDE.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Open_IDE
        Me.tsbOpenIDE.Name = "tsbOpenIDE"
        '
        'tsbExamples
        '
        resources.ApplyResources(Me.tsbExamples, "tsbExamples")
        Me.tsbExamples.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Examples
        Me.tsbExamples.Name = "tsbExamples"
        '
        'tsbLibraries
        '
        resources.ApplyResources(Me.tsbLibraries, "tsbLibraries")
        Me.tsbLibraries.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Library
        Me.tsbLibraries.Name = "tsbLibraries"
        '
        'tpEdit
        '
        Me.tpEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpEdit.Controls.Add(Me.tsEdit)
        resources.ApplyResources(Me.tpEdit, "tpEdit")
        Me.tpEdit.Name = "tpEdit"
        '
        'tsEdit
        '
        Me.tsEdit.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGoTo, Me.tsbFind, Me.tsbFindAndReplace, Me.ToolStripSeparator2, Me.tsbUndo, Me.tsbRedo, Me.ToolStripSeparator3, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.ToolStripSeparator4, Me.tsbIdent, Me.tsbCommentSelected, Me.ToolStripSeparator5, Me.tsbtFold, Me.tsbtUnfold})
        resources.ApplyResources(Me.tsEdit, "tsEdit")
        Me.tsEdit.Name = "tsEdit"
        '
        'tsbGoTo
        '
        resources.ApplyResources(Me.tsbGoTo, "tsbGoTo")
        Me.tsbGoTo.Image = Global.Druida_IDE_Lite.My.Resources.Resources._GoTo
        Me.tsbGoTo.Name = "tsbGoTo"
        '
        'tsbFind
        '
        resources.ApplyResources(Me.tsbFind, "tsbFind")
        Me.tsbFind.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Find
        Me.tsbFind.Name = "tsbFind"
        '
        'tsbFindAndReplace
        '
        resources.ApplyResources(Me.tsbFindAndReplace, "tsbFindAndReplace")
        Me.tsbFindAndReplace.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Find_and_Replace
        Me.tsbFindAndReplace.Name = "tsbFindAndReplace"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'tsbUndo
        '
        resources.ApplyResources(Me.tsbUndo, "tsbUndo")
        Me.tsbUndo.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Undo
        Me.tsbUndo.Name = "tsbUndo"
        '
        'tsbRedo
        '
        resources.ApplyResources(Me.tsbRedo, "tsbRedo")
        Me.tsbRedo.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Redo
        Me.tsbRedo.Name = "tsbRedo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'tsbCut
        '
        resources.ApplyResources(Me.tsbCut, "tsbCut")
        Me.tsbCut.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Cut
        Me.tsbCut.Name = "tsbCut"
        '
        'tsbCopy
        '
        resources.ApplyResources(Me.tsbCopy, "tsbCopy")
        Me.tsbCopy.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Copy
        Me.tsbCopy.Name = "tsbCopy"
        '
        'tsbPaste
        '
        resources.ApplyResources(Me.tsbPaste, "tsbPaste")
        Me.tsbPaste.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Paste
        Me.tsbPaste.Name = "tsbPaste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'tsbIdent
        '
        resources.ApplyResources(Me.tsbIdent, "tsbIdent")
        Me.tsbIdent.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Ident
        Me.tsbIdent.Name = "tsbIdent"
        '
        'tsbCommentSelected
        '
        resources.ApplyResources(Me.tsbCommentSelected, "tsbCommentSelected")
        Me.tsbCommentSelected.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Comment_Selected
        Me.tsbCommentSelected.Name = "tsbCommentSelected"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'tsbtFold
        '
        resources.ApplyResources(Me.tsbtFold, "tsbtFold")
        Me.tsbtFold.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Fold
        Me.tsbtFold.Name = "tsbtFold"
        '
        'tsbtUnfold
        '
        resources.ApplyResources(Me.tsbtUnfold, "tsbtUnfold")
        Me.tsbtUnfold.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Unfold
        Me.tsbtUnfold.Name = "tsbtUnfold"
        '
        'tpView
        '
        Me.tpView.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpView.Controls.Add(Me.tsView)
        resources.ApplyResources(Me.tpView, "tpView")
        Me.tpView.Name = "tpView"
        '
        'tsView
        '
        Me.tsView.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtFullScreen, Me.tsbtFileList, Me.tsbtObjects, Me.tsbtConsole, Me.tsbtDocumentMap, Me.tsbtShowOutput, Me.tsbtShowErrors, Me.tsbtShowSerialMonitor, Me.tsbtShowHardwareMonitor})
        resources.ApplyResources(Me.tsView, "tsView")
        Me.tsView.Name = "tsView"
        '
        'tsbtFullScreen
        '
        Me.tsbtFullScreen.CheckOnClick = True
        Me.tsbtFullScreen.Image = Global.Druida_IDE_Lite.My.Resources.Resources.FullScreen
        resources.ApplyResources(Me.tsbtFullScreen, "tsbtFullScreen")
        Me.tsbtFullScreen.Name = "tsbtFullScreen"
        '
        'tsbtFileList
        '
        Me.tsbtFileList.Image = Global.Druida_IDE_Lite.My.Resources.Resources.FilesList
        resources.ApplyResources(Me.tsbtFileList, "tsbtFileList")
        Me.tsbtFileList.Name = "tsbtFileList"
        '
        'tsbtObjects
        '
        Me.tsbtObjects.Image = Global.Druida_IDE_Lite.My.Resources.Resources.ObjectsList
        resources.ApplyResources(Me.tsbtObjects, "tsbtObjects")
        Me.tsbtObjects.Name = "tsbtObjects"
        '
        'tsbtConsole
        '
        Me.tsbtConsole.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Console
        resources.ApplyResources(Me.tsbtConsole, "tsbtConsole")
        Me.tsbtConsole.Name = "tsbtConsole"
        '
        'tsbtDocumentMap
        '
        Me.tsbtDocumentMap.Image = Global.Druida_IDE_Lite.My.Resources.Resources.DocumentMap
        resources.ApplyResources(Me.tsbtDocumentMap, "tsbtDocumentMap")
        Me.tsbtDocumentMap.Name = "tsbtDocumentMap"
        '
        'tsbtShowOutput
        '
        Me.tsbtShowOutput.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Var_Monitor
        resources.ApplyResources(Me.tsbtShowOutput, "tsbtShowOutput")
        Me.tsbtShowOutput.Name = "tsbtShowOutput"
        '
        'tsbtShowErrors
        '
        Me.tsbtShowErrors.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete_All
        resources.ApplyResources(Me.tsbtShowErrors, "tsbtShowErrors")
        Me.tsbtShowErrors.Name = "tsbtShowErrors"
        '
        'tsbtShowSerialMonitor
        '
        Me.tsbtShowSerialMonitor.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Serial_Monitor
        resources.ApplyResources(Me.tsbtShowSerialMonitor, "tsbtShowSerialMonitor")
        Me.tsbtShowSerialMonitor.Name = "tsbtShowSerialMonitor"
        '
        'tsbtShowHardwareMonitor
        '
        Me.tsbtShowHardwareMonitor.Image = Global.Druida_IDE_Lite.My.Resources.Resources.HardwareDebugger
        resources.ApplyResources(Me.tsbtShowHardwareMonitor, "tsbtShowHardwareMonitor")
        Me.tsbtShowHardwareMonitor.Name = "tsbtShowHardwareMonitor"
        '
        'tpTools
        '
        Me.tpTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpTools.Controls.Add(Me.tsTools)
        resources.ApplyResources(Me.tpTools, "tpTools")
        Me.tpTools.Name = "tpTools"
        '
        'tsTools
        '
        Me.tsTools.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbVarMonitor, Me.tsbClear, Me.tsbInterrupt, Me.tsbtHardwareDebugger, Me.tsbVerifySyntax, Me.tsbCodeSnnipetsManager, Me.tsbOptions})
        resources.ApplyResources(Me.tsTools, "tsTools")
        Me.tsTools.Name = "tsTools"
        '
        'tsbVarMonitor
        '
        resources.ApplyResources(Me.tsbVarMonitor, "tsbVarMonitor")
        Me.tsbVarMonitor.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Var_Monitor
        Me.tsbVarMonitor.Name = "tsbVarMonitor"
        '
        'tsbClear
        '
        resources.ApplyResources(Me.tsbClear, "tsbClear")
        Me.tsbClear.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Check_Marks
        Me.tsbClear.Name = "tsbClear"
        '
        'tsbInterrupt
        '
        resources.ApplyResources(Me.tsbInterrupt, "tsbInterrupt")
        Me.tsbInterrupt.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Interrupt
        Me.tsbInterrupt.Name = "tsbInterrupt"
        '
        'tsbtHardwareDebugger
        '
        resources.ApplyResources(Me.tsbtHardwareDebugger, "tsbtHardwareDebugger")
        Me.tsbtHardwareDebugger.Image = Global.Druida_IDE_Lite.My.Resources.Resources.HardwareDebugger
        Me.tsbtHardwareDebugger.Name = "tsbtHardwareDebugger"
        '
        'tsbVerifySyntax
        '
        resources.ApplyResources(Me.tsbVerifySyntax, "tsbVerifySyntax")
        Me.tsbVerifySyntax.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Compile
        Me.tsbVerifySyntax.Name = "tsbVerifySyntax"
        '
        'tsbCodeSnnipetsManager
        '
        Me.tsbCodeSnnipetsManager.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Variables
        resources.ApplyResources(Me.tsbCodeSnnipetsManager, "tsbCodeSnnipetsManager")
        Me.tsbCodeSnnipetsManager.Name = "tsbCodeSnnipetsManager"
        '
        'tsbOptions
        '
        Me.tsbOptions.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Options
        resources.ApplyResources(Me.tsbOptions, "tsbOptions")
        Me.tsbOptions.Name = "tsbOptions"
        '
        'tpHelp
        '
        Me.tpHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpHelp.Controls.Add(Me.tsHelp)
        resources.ApplyResources(Me.tpHelp, "tpHelp")
        Me.tpHelp.Name = "tpHelp"
        '
        'tsHelp
        '
        Me.tsHelp.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbHelp, Me.tsbOnlineDocuments, Me.tsbTutorial, Me.tsbOnlineSupport, Me.tsbtBugReport, Me.tsbSuggestion})
        resources.ApplyResources(Me.tsHelp, "tsHelp")
        Me.tsHelp.Name = "tsHelp"
        '
        'tsbHelp
        '
        Me.tsbHelp.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Help
        resources.ApplyResources(Me.tsbHelp, "tsbHelp")
        Me.tsbHelp.Name = "tsbHelp"
        '
        'tsbOnlineDocuments
        '
        Me.tsbOnlineDocuments.Image = Global.Druida_IDE_Lite.My.Resources.Resources.On_line_Documents
        resources.ApplyResources(Me.tsbOnlineDocuments, "tsbOnlineDocuments")
        Me.tsbOnlineDocuments.Name = "tsbOnlineDocuments"
        '
        'tsbTutorial
        '
        Me.tsbTutorial.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Tutorial
        resources.ApplyResources(Me.tsbTutorial, "tsbTutorial")
        Me.tsbTutorial.Name = "tsbTutorial"
        '
        'tsbOnlineSupport
        '
        Me.tsbOnlineSupport.Image = Global.Druida_IDE_Lite.My.Resources.Resources.On_Line_Support
        resources.ApplyResources(Me.tsbOnlineSupport, "tsbOnlineSupport")
        Me.tsbOnlineSupport.Name = "tsbOnlineSupport"
        '
        'tsbtBugReport
        '
        Me.tsbtBugReport.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Bug_Report
        resources.ApplyResources(Me.tsbtBugReport, "tsbtBugReport")
        Me.tsbtBugReport.Name = "tsbtBugReport"
        '
        'tsbSuggestion
        '
        Me.tsbSuggestion.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Suggestion
        resources.ApplyResources(Me.tsbSuggestion, "tsbSuggestion")
        Me.tsbSuggestion.Name = "tsbSuggestion"
        '
        'cmsCodeEditor
        '
        Me.cmsCodeEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGoTo, Me.tsmiFind, Me.tsmiReplace, Me.ToolStripSeparator7, Me.tsmiUndo, Me.tsmiRedo, Me.ToolStripSeparator8, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPast, Me.ToolStripSeparator9, Me.tsmiIdent, Me.tsmiComment, Me.ToolStripSeparator10, Me.DobramentoDeCódigoToolStripMenuItem, Me.CloseTabToolStripMenuItem})
        Me.cmsCodeEditor.Name = "cmsCodeEditor"
        resources.ApplyResources(Me.cmsCodeEditor, "cmsCodeEditor")
        '
        'tsmiGoTo
        '
        Me.tsmiGoTo.Image = Global.Druida_IDE_Lite.My.Resources.Resources._GoTo
        Me.tsmiGoTo.Name = "tsmiGoTo"
        resources.ApplyResources(Me.tsmiGoTo, "tsmiGoTo")
        '
        'tsmiFind
        '
        Me.tsmiFind.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Find
        Me.tsmiFind.Name = "tsmiFind"
        resources.ApplyResources(Me.tsmiFind, "tsmiFind")
        '
        'tsmiReplace
        '
        Me.tsmiReplace.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Find_and_Replace
        Me.tsmiReplace.Name = "tsmiReplace"
        resources.ApplyResources(Me.tsmiReplace, "tsmiReplace")
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'tsmiUndo
        '
        Me.tsmiUndo.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Undo
        Me.tsmiUndo.Name = "tsmiUndo"
        resources.ApplyResources(Me.tsmiUndo, "tsmiUndo")
        '
        'tsmiRedo
        '
        Me.tsmiRedo.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Redo
        Me.tsmiRedo.Name = "tsmiRedo"
        resources.ApplyResources(Me.tsmiRedo, "tsmiRedo")
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        '
        'tsmiCut
        '
        Me.tsmiCut.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Cut
        Me.tsmiCut.Name = "tsmiCut"
        resources.ApplyResources(Me.tsmiCut, "tsmiCut")
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Copy
        Me.tsmiCopy.Name = "tsmiCopy"
        resources.ApplyResources(Me.tsmiCopy, "tsmiCopy")
        '
        'tsmiPast
        '
        Me.tsmiPast.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Paste
        Me.tsmiPast.Name = "tsmiPast"
        resources.ApplyResources(Me.tsmiPast, "tsmiPast")
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'tsmiIdent
        '
        Me.tsmiIdent.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Ident
        Me.tsmiIdent.Name = "tsmiIdent"
        resources.ApplyResources(Me.tsmiIdent, "tsmiIdent")
        '
        'tsmiComment
        '
        Me.tsmiComment.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Comment_Selected
        Me.tsmiComment.Name = "tsmiComment"
        resources.ApplyResources(Me.tsmiComment, "tsmiComment")
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'DobramentoDeCódigoToolStripMenuItem
        '
        Me.DobramentoDeCódigoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFold, Me.tsmiUnfold})
        Me.DobramentoDeCódigoToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.CodeFolding
        Me.DobramentoDeCódigoToolStripMenuItem.Name = "DobramentoDeCódigoToolStripMenuItem"
        resources.ApplyResources(Me.DobramentoDeCódigoToolStripMenuItem, "DobramentoDeCódigoToolStripMenuItem")
        '
        'tsmiFold
        '
        Me.tsmiFold.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Fold
        Me.tsmiFold.Name = "tsmiFold"
        resources.ApplyResources(Me.tsmiFold, "tsmiFold")
        '
        'tsmiUnfold
        '
        Me.tsmiUnfold.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Unfold
        Me.tsmiUnfold.Name = "tsmiUnfold"
        resources.ApplyResources(Me.tsmiUnfold, "tsmiUnfold")
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Quit
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        resources.ApplyResources(Me.CloseTabToolStripMenuItem, "CloseTabToolStripMenuItem")
        '
        'lClose
        '
        resources.ApplyResources(Me.lClose, "lClose")
        Me.lClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lClose.ForeColor = System.Drawing.Color.Transparent
        Me.lClose.Name = "lClose"
        '
        'lMinimize
        '
        resources.ApplyResources(Me.lMinimize, "lMinimize")
        Me.lMinimize.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.lMinimize.Name = "lMinimize"
        '
        'MainToolBar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lMinimize)
        Me.Controls.Add(Me.lClose)
        Me.Controls.Add(Me.tcMainToolBar)
        Me.Name = "MainToolBar"
        Me.tcMainToolBar.ResumeLayout(False)
        Me.tpProject.ResumeLayout(False)
        Me.tpProject.PerformLayout()
        CType(Me.pbBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsProject.ResumeLayout(False)
        Me.tsProject.PerformLayout()
        Me.tpFile.ResumeLayout(False)
        Me.tpFile.PerformLayout()
        Me.tsFile.ResumeLayout(False)
        Me.tsFile.PerformLayout()
        Me.tpEdit.ResumeLayout(False)
        Me.tpEdit.PerformLayout()
        Me.tsEdit.ResumeLayout(False)
        Me.tsEdit.PerformLayout()
        Me.tpView.ResumeLayout(False)
        Me.tpView.PerformLayout()
        Me.tsView.ResumeLayout(False)
        Me.tsView.PerformLayout()
        Me.tpTools.ResumeLayout(False)
        Me.tpTools.PerformLayout()
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.tpHelp.ResumeLayout(False)
        Me.tpHelp.PerformLayout()
        Me.tsHelp.ResumeLayout(False)
        Me.tsHelp.PerformLayout()
        Me.cmsCodeEditor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tpProject As TabPage
    Friend WithEvents tpFile As TabPage
    Friend WithEvents tpEdit As TabPage
    Friend WithEvents tpTools As TabPage
    Friend WithEvents tpHelp As TabPage
    Friend WithEvents tsProject As ToolStrip
    Friend WithEvents cbBoard As ComboBox
    Friend WithEvents tsbNewProject As ToolStripButton
    Friend WithEvents tsbOpen As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbSaveAs As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbHardware As ToolStripButton
    Friend WithEvents tsbCompile As ToolStripButton
    Friend WithEvents tsbUpload As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents pbBoard As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsFile As ToolStrip
    Friend WithEvents tsbNewFile As ToolStripButton
    Friend WithEvents tsbOpenFile As ToolStripButton
    Friend WithEvents tsbtSaveFile As ToolStripButton
    Friend WithEvents tsbImportFile As ToolStripButton
    Friend WithEvents tsbDirectories As ToolStripButton
    Friend WithEvents tsbExportAsHtml As ToolStripButton
    Friend WithEvents tsbOpenIDE As ToolStripButton
    Friend WithEvents tsbExamples As ToolStripButton
    Friend WithEvents tsbLibraries As ToolStripButton
    Friend WithEvents tsEdit As ToolStrip
    Friend WithEvents tsbUndo As ToolStripButton
    Friend WithEvents tsbRedo As ToolStripButton
    Friend WithEvents tsbPaste As ToolStripButton
    Friend WithEvents tsbIdent As ToolStripButton
    Friend WithEvents tsbFind As ToolStripButton
    Friend WithEvents tsbFindAndReplace As ToolStripButton
    Friend WithEvents tsbCut As ToolStripButton
    Friend WithEvents tsbCopy As ToolStripButton
    Friend WithEvents tsbCommentSelected As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbGoTo As ToolStripButton
    Friend WithEvents tsTools As ToolStrip
    Friend WithEvents tsbCodeSnnipetsManager As ToolStripButton
    Friend WithEvents tsbVarMonitor As ToolStripButton
    Friend WithEvents tsbOptions As ToolStripButton
    Friend WithEvents tsbInterrupt As ToolStripButton
    Friend WithEvents tsbVerifySyntax As ToolStripButton
    Friend WithEvents tsbClear As ToolStripButton
    Friend WithEvents tsHelp As ToolStrip
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents tsbOnlineDocuments As ToolStripButton
    Friend WithEvents tsbOnlineSupport As ToolStripButton
    Friend WithEvents tsbSuggestion As ToolStripButton
    Friend WithEvents tsbtBugReport As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents cmsCodeEditor As ContextMenuStrip
    Friend WithEvents tsmiGoTo As ToolStripMenuItem
    Friend WithEvents tsmiFind As ToolStripMenuItem
    Friend WithEvents tsmiReplace As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsmiUndo As ToolStripMenuItem
    Friend WithEvents tsmiRedo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsmiCut As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiPast As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsmiIdent As ToolStripMenuItem
    Friend WithEvents tsmiComment As ToolStripMenuItem
    Friend WithEvents tcMainToolBar As VisualStudioTabControl.VisualStudioTabControl
    Friend WithEvents tpView As TabPage
    Friend WithEvents tsView As ToolStrip
    Friend WithEvents tsbtFullScreen As ToolStripButton
    Friend WithEvents tsbtFileList As ToolStripButton
    Friend WithEvents tsbtObjects As ToolStripButton
    Friend WithEvents tsbtConsole As ToolStripButton
    Friend WithEvents cbPort As ComboBox
    Friend WithEvents lClose As Label
    Friend WithEvents tsbTutorial As ToolStripButton
    Friend WithEvents tsbtDocumentMap As ToolStripButton
    Friend WithEvents tsbtScada As ToolStripButton
    Friend WithEvents lMinimize As Label
    Friend WithEvents tsbtHardwareDebugger As ToolStripButton
    Friend WithEvents tsbtFold As ToolStripButton
    Friend WithEvents tsbtUnfold As ToolStripButton
    Friend WithEvents DobramentoDeCódigoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsmiFold As ToolStripMenuItem
    Friend WithEvents tsmiUnfold As ToolStripMenuItem
    Friend WithEvents tsbtExit As ToolStripButton
    Friend WithEvents tsbtSaveFileAs As ToolStripButton
    Friend WithEvents tsbtShowHardwareMonitor As ToolStripButton
    Friend WithEvents tsbtShowOutput As ToolStripButton
    Friend WithEvents tsbtShowErrors As ToolStripButton
    Friend WithEvents tsbtShowSerialMonitor As ToolStripButton
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbSerialMonitor As ToolStripButton
End Class
