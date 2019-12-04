<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeSnippets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeSnippets))
        Me.scNavigate = New System.Windows.Forms.SplitContainer()
        Me.exSnippets = New DruidaIDEAuxiliarControls.Explorer()
        Me.ilExplorer = New System.Windows.Forms.ImageList(Me.components)
        Me.tsSnippets = New System.Windows.Forms.ToolStrip()
        Me.tsbtSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtNewFolder = New System.Windows.Forms.ToolStripButton()
        Me.tsbtNewSnippet = New System.Windows.Forms.ToolStripButton()
        Me.tsbClone = New System.Windows.Forms.ToolStripButton()
        Me.tsbtRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbNotes = New System.Windows.Forms.TextBox()
        Me.tbReturn = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ciImage = New DruidaIDEAuxiliarControls.ComboIcon()
        Me.tbTag = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbParameters = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbImagemIndex = New System.Windows.Forms.TextBox()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.tbMenuText = New System.Windows.Forms.TextBox()
        Me.tbSyntax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.msCodeSnippets = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAddSnippet = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpManager = New System.Windows.Forms.TabPage()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcManager = New VisualStudioTabControl.VisualStudioTabControl()
        CType(Me.scNavigate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scNavigate.Panel1.SuspendLayout()
        Me.scNavigate.Panel2.SuspendLayout()
        Me.scNavigate.SuspendLayout()
        Me.tsSnippets.SuspendLayout()
        Me.msCodeSnippets.SuspendLayout()
        Me.tpManager.SuspendLayout()
        Me.tcManager.SuspendLayout()
        Me.SuspendLayout()
        '
        'scNavigate
        '
        resources.ApplyResources(Me.scNavigate, "scNavigate")
        Me.scNavigate.Name = "scNavigate"
        '
        'scNavigate.Panel1
        '
        Me.scNavigate.Panel1.Controls.Add(Me.exSnippets)
        Me.scNavigate.Panel1.Controls.Add(Me.tsSnippets)
        '
        'scNavigate.Panel2
        '
        Me.scNavigate.Panel2.Controls.Add(Me.tbFile)
        Me.scNavigate.Panel2.Controls.Add(Me.Label12)
        Me.scNavigate.Panel2.Controls.Add(Me.tbNotes)
        Me.scNavigate.Panel2.Controls.Add(Me.tbReturn)
        Me.scNavigate.Panel2.Controls.Add(Me.Label9)
        Me.scNavigate.Panel2.Controls.Add(Me.Label8)
        Me.scNavigate.Panel2.Controls.Add(Me.ciImage)
        Me.scNavigate.Panel2.Controls.Add(Me.tbTag)
        Me.scNavigate.Panel2.Controls.Add(Me.Label11)
        Me.scNavigate.Panel2.Controls.Add(Me.tbFileName)
        Me.scNavigate.Panel2.Controls.Add(Me.Label10)
        Me.scNavigate.Panel2.Controls.Add(Me.tbParameters)
        Me.scNavigate.Panel2.Controls.Add(Me.Label7)
        Me.scNavigate.Panel2.Controls.Add(Me.tbImagemIndex)
        Me.scNavigate.Panel2.Controls.Add(Me.tbDescription)
        Me.scNavigate.Panel2.Controls.Add(Me.tbTitle)
        Me.scNavigate.Panel2.Controls.Add(Me.tbMenuText)
        Me.scNavigate.Panel2.Controls.Add(Me.tbSyntax)
        Me.scNavigate.Panel2.Controls.Add(Me.Label6)
        Me.scNavigate.Panel2.Controls.Add(Me.Label5)
        Me.scNavigate.Panel2.Controls.Add(Me.Label4)
        Me.scNavigate.Panel2.Controls.Add(Me.Label3)
        Me.scNavigate.Panel2.Controls.Add(Me.Label2)
        '
        'exSnippets
        '
        resources.ApplyResources(Me.exSnippets, "exSnippets")
        Me.exSnippets.Extensions = New String() {Nothing, ".sni"}
        Me.exSnippets.HideEmptyFolders = False
        Me.exSnippets.HideSelection = False
        Me.exSnippets.ImageList = Me.ilExplorer
        Me.exSnippets.Name = "exSnippets"
        Me.exSnippets.Paths = CType(resources.GetObject("exSnippets.Paths"), System.Collections.Generic.List(Of String))
        Me.exSnippets.PathsNames = CType(resources.GetObject("exSnippets.PathsNames"), System.Collections.Generic.List(Of String))
        '
        'ilExplorer
        '
        Me.ilExplorer.ImageStream = CType(resources.GetObject("ilExplorer.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilExplorer.TransparentColor = System.Drawing.Color.Transparent
        Me.ilExplorer.Images.SetKeyName(0, "Folder.png")
        Me.ilExplorer.Images.SetKeyName(1, "Examples.png")
        '
        'tsSnippets
        '
        Me.tsSnippets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtSave, Me.tsbtNewFolder, Me.tsbtNewSnippet, Me.tsbClone, Me.tsbtRefresh})
        resources.ApplyResources(Me.tsSnippets, "tsSnippets")
        Me.tsSnippets.Name = "tsSnippets"
        '
        'tsbtSave
        '
        Me.tsbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtSave.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_File
        resources.ApplyResources(Me.tsbtSave, "tsbtSave")
        Me.tsbtSave.Name = "tsbtSave"
        '
        'tsbtNewFolder
        '
        Me.tsbtNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtNewFolder.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Folder
        resources.ApplyResources(Me.tsbtNewFolder, "tsbtNewFolder")
        Me.tsbtNewFolder.Name = "tsbtNewFolder"
        '
        'tsbtNewSnippet
        '
        Me.tsbtNewSnippet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtNewSnippet.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Examples
        resources.ApplyResources(Me.tsbtNewSnippet, "tsbtNewSnippet")
        Me.tsbtNewSnippet.Name = "tsbtNewSnippet"
        '
        'tsbClone
        '
        Me.tsbClone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClone.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Copy
        resources.ApplyResources(Me.tsbClone, "tsbClone")
        Me.tsbClone.Name = "tsbClone"
        '
        'tsbtRefresh
        '
        Me.tsbtRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtRefresh.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Refresh
        resources.ApplyResources(Me.tsbtRefresh, "tsbtRefresh")
        Me.tsbtRefresh.Name = "tsbtRefresh"
        '
        'tbFile
        '
        resources.ApplyResources(Me.tbFile, "tbFile")
        Me.tbFile.Name = "tbFile"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'tbNotes
        '
        resources.ApplyResources(Me.tbNotes, "tbNotes")
        Me.tbNotes.Name = "tbNotes"
        '
        'tbReturn
        '
        resources.ApplyResources(Me.tbReturn, "tbReturn")
        Me.tbReturn.Name = "tbReturn"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'ciImage
        '
        resources.ApplyResources(Me.ciImage, "ciImage")
        Me.ciImage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ciImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ciImage.FormattingEnabled = True
        Me.ciImage.Name = "ciImage"
        '
        'tbTag
        '
        resources.ApplyResources(Me.tbTag, "tbTag")
        Me.tbTag.Name = "tbTag"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'tbFileName
        '
        resources.ApplyResources(Me.tbFileName, "tbFileName")
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.ReadOnly = True
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'tbParameters
        '
        resources.ApplyResources(Me.tbParameters, "tbParameters")
        Me.tbParameters.Name = "tbParameters"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'tbImagemIndex
        '
        resources.ApplyResources(Me.tbImagemIndex, "tbImagemIndex")
        Me.tbImagemIndex.Name = "tbImagemIndex"
        Me.tbImagemIndex.ReadOnly = True
        '
        'tbDescription
        '
        resources.ApplyResources(Me.tbDescription, "tbDescription")
        Me.tbDescription.Name = "tbDescription"
        '
        'tbTitle
        '
        resources.ApplyResources(Me.tbTitle, "tbTitle")
        Me.tbTitle.Name = "tbTitle"
        '
        'tbMenuText
        '
        resources.ApplyResources(Me.tbMenuText, "tbMenuText")
        Me.tbMenuText.Name = "tbMenuText"
        '
        'tbSyntax
        '
        resources.ApplyResources(Me.tbSyntax, "tbSyntax")
        Me.tbSyntax.Name = "tbSyntax"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'msCodeSnippets
        '
        Me.msCodeSnippets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        resources.ApplyResources(Me.msCodeSnippets, "msCodeSnippets")
        Me.msCodeSnippets.Name = "msCodeSnippets"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSave, Me.tsmiNewFolder, Me.tsmiAddSnippet, Me.tsmiRefresh})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        resources.ApplyResources(Me.ArquivoToolStripMenuItem, "ArquivoToolStripMenuItem")
        '
        'tsmiSave
        '
        Me.tsmiSave.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_File
        Me.tsmiSave.Name = "tsmiSave"
        resources.ApplyResources(Me.tsmiSave, "tsmiSave")
        '
        'tsmiNewFolder
        '
        Me.tsmiNewFolder.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Folder
        Me.tsmiNewFolder.Name = "tsmiNewFolder"
        resources.ApplyResources(Me.tsmiNewFolder, "tsmiNewFolder")
        '
        'tsmiAddSnippet
        '
        Me.tsmiAddSnippet.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Examples
        Me.tsmiAddSnippet.Name = "tsmiAddSnippet"
        resources.ApplyResources(Me.tsmiAddSnippet, "tsmiAddSnippet")
        '
        'tsmiRefresh
        '
        Me.tsmiRefresh.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Refresh
        Me.tsmiRefresh.Name = "tsmiRefresh"
        resources.ApplyResources(Me.tsmiRefresh, "tsmiRefresh")
        '
        'tpManager
        '
        Me.tpManager.BackColor = System.Drawing.SystemColors.Control
        Me.tpManager.Controls.Add(Me.scNavigate)
        Me.tpManager.Controls.Add(Me.tbPath)
        Me.tpManager.Controls.Add(Me.Label1)
        Me.tpManager.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.tpManager, "tpManager")
        Me.tpManager.Name = "tpManager"
        '
        'tbPath
        '
        resources.ApplyResources(Me.tbPath, "tbPath")
        Me.tbPath.Name = "tbPath"
        Me.tbPath.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'tcManager
        '
        Me.tcManager.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tcManager.AllowDrop = True
        resources.ApplyResources(Me.tcManager, "tcManager")
        Me.tcManager.BackTabColor = System.Drawing.SystemColors.Control
        Me.tcManager.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tcManager.ClosingButtonColor = System.Drawing.Color.WhiteSmoke
        Me.tcManager.ClosingMessage = Nothing
        Me.tcManager.Controls.Add(Me.tpManager)
        Me.tcManager.HeaderColor = System.Drawing.SystemColors.ControlDark
        Me.tcManager.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tcManager.Name = "tcManager"
        Me.tcManager.SelectedIndex = 0
        Me.tcManager.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tcManager.ShowClosingButton = False
        Me.tcManager.ShowClosingMessage = False
        Me.tcManager.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'CodeSnippets
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcManager)
        Me.Controls.Add(Me.msCodeSnippets)
        Me.MainMenuStrip = Me.msCodeSnippets
        Me.Name = "CodeSnippets"
        Me.scNavigate.Panel1.ResumeLayout(False)
        Me.scNavigate.Panel1.PerformLayout()
        Me.scNavigate.Panel2.ResumeLayout(False)
        Me.scNavigate.Panel2.PerformLayout()
        CType(Me.scNavigate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scNavigate.ResumeLayout(False)
        Me.tsSnippets.ResumeLayout(False)
        Me.tsSnippets.PerformLayout()
        Me.msCodeSnippets.ResumeLayout(False)
        Me.msCodeSnippets.PerformLayout()
        Me.tpManager.ResumeLayout(False)
        Me.tpManager.PerformLayout()
        Me.tcManager.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msCodeSnippets As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ilExplorer As ImageList
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiNewFolder As ToolStripMenuItem
    Friend WithEvents tsmiAddSnippet As ToolStripMenuItem
    Friend WithEvents tsmiRefresh As ToolStripMenuItem
    Friend WithEvents tpManager As TabPage
    Friend WithEvents scNavigate As SplitContainer
    Friend WithEvents exSnippets As DruidaIDEAuxiliarControls.Explorer
    Friend WithEvents tsSnippets As ToolStrip
    Friend WithEvents tsbtSave As ToolStripButton
    Friend WithEvents tsbtNewFolder As ToolStripButton
    Friend WithEvents tsbtNewSnippet As ToolStripButton
    Friend WithEvents tsbtRefresh As ToolStripButton
    Friend WithEvents tbNotes As TextBox
    Friend WithEvents tbReturn As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ciImage As DruidaIDEAuxiliarControls.ComboIcon
    Friend WithEvents tbTag As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbFileName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbParameters As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbImagemIndex As TextBox
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents tbMenuText As TextBox
    Friend WithEvents tbSyntax As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tcManager As VisualStudioTabControl.VisualStudioTabControl
    Friend WithEvents tbFile As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tsbClone As ToolStripButton
End Class
