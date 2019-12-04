<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilesExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilesExplorer))
        Me.lHeader = New System.Windows.Forms.Label()
        Me.tsExplorer = New System.Windows.Forms.ToolStrip()
        Me.tsbtRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tsbtNewFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtImportFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbtOpenAllCodes = New System.Windows.Forms.ToolStripButton()
        Me.tvExplorer = New DruidaIDEAuxiliarControls.Explorer()
        Me.cmsFiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdicionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiImportFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpenAllCodes = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirPastaRecipienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenomearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbtCopyPath = New System.Windows.Forms.ToolStripMenuItem()
        Me.ilExtenxions = New System.Windows.Forms.ImageList(Me.components)
        Me.lClose = New System.Windows.Forms.Label()
        Me.tsExplorer.SuspendLayout()
        Me.cmsFiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'lHeader
        '
        Me.lHeader.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.lHeader, "lHeader")
        Me.lHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lHeader.Name = "lHeader"
        '
        'tsExplorer
        '
        resources.ApplyResources(Me.tsExplorer, "tsExplorer")
        Me.tsExplorer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtRefresh, Me.tsbtNewFile, Me.tsbtImportFile, Me.tsbtOpenAllCodes})
        Me.tsExplorer.Name = "tsExplorer"
        '
        'tsbtRefresh
        '
        Me.tsbtRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtRefresh.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Refresh
        resources.ApplyResources(Me.tsbtRefresh, "tsbtRefresh")
        Me.tsbtRefresh.Name = "tsbtRefresh"
        '
        'tsbtNewFile
        '
        Me.tsbtNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtNewFile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.New_File
        resources.ApplyResources(Me.tsbtNewFile, "tsbtNewFile")
        Me.tsbtNewFile.Name = "tsbtNewFile"
        '
        'tsbtImportFile
        '
        Me.tsbtImportFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtImportFile.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Import_File
        resources.ApplyResources(Me.tsbtImportFile, "tsbtImportFile")
        Me.tsbtImportFile.Name = "tsbtImportFile"
        '
        'tsbtOpenAllCodes
        '
        Me.tsbtOpenAllCodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtOpenAllCodes.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Folder
        resources.ApplyResources(Me.tsbtOpenAllCodes, "tsbtOpenAllCodes")
        Me.tsbtOpenAllCodes.Name = "tsbtOpenAllCodes"
        '
        'tvExplorer
        '
        Me.tvExplorer.ContextMenuStrip = Me.cmsFiles
        resources.ApplyResources(Me.tvExplorer, "tvExplorer")
        Me.tvExplorer.Extensions = New String() {Nothing, ".ino", ".pde", ".h", ".c", ".cpp", ".txt", ".png", ".cfg", ".hex", ".pdsprj"}
        Me.tvExplorer.HideEmptyFolders = False
        Me.tvExplorer.ImageList = Me.ilExtenxions
        Me.tvExplorer.Name = "tvExplorer"
        Me.tvExplorer.Paths = CType(resources.GetObject("tvExplorer.Paths"), System.Collections.Generic.List(Of String))
        Me.tvExplorer.PathsNames = CType(resources.GetObject("tvExplorer.PathsNames"), System.Collections.Generic.List(Of String))
        '
        'cmsFiles
        '
        Me.cmsFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripMenuItem, Me.tsmiOpenAllCodes, Me.AbrirPastaRecipienteToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.RenomearToolStripMenuItem, Me.tsbtCopyPath})
        Me.cmsFiles.Name = "cmsFiles"
        resources.ApplyResources(Me.cmsFiles, "cmsFiles")
        '
        'AdicionarToolStripMenuItem
        '
        Me.AdicionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNewFile, Me.tsmiImportFile})
        resources.ApplyResources(Me.AdicionarToolStripMenuItem, "AdicionarToolStripMenuItem")
        Me.AdicionarToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.New_File
        Me.AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        '
        'tsmiNewFile
        '
        Me.tsmiNewFile.Name = "tsmiNewFile"
        resources.ApplyResources(Me.tsmiNewFile, "tsmiNewFile")
        '
        'tsmiImportFile
        '
        Me.tsmiImportFile.Name = "tsmiImportFile"
        resources.ApplyResources(Me.tsmiImportFile, "tsmiImportFile")
        '
        'tsmiOpenAllCodes
        '
        resources.ApplyResources(Me.tsmiOpenAllCodes, "tsmiOpenAllCodes")
        Me.tsmiOpenAllCodes.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Folder
        Me.tsmiOpenAllCodes.Name = "tsmiOpenAllCodes"
        '
        'AbrirPastaRecipienteToolStripMenuItem
        '
        resources.ApplyResources(Me.AbrirPastaRecipienteToolStripMenuItem, "AbrirPastaRecipienteToolStripMenuItem")
        Me.AbrirPastaRecipienteToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Open
        Me.AbrirPastaRecipienteToolStripMenuItem.Name = "AbrirPastaRecipienteToolStripMenuItem"
        '
        'ExcluirToolStripMenuItem
        '
        resources.ApplyResources(Me.ExcluirToolStripMenuItem, "ExcluirToolStripMenuItem")
        Me.ExcluirToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        '
        'RenomearToolStripMenuItem
        '
        resources.ApplyResources(Me.RenomearToolStripMenuItem, "RenomearToolStripMenuItem")
        Me.RenomearToolStripMenuItem.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Rename
        Me.RenomearToolStripMenuItem.Name = "RenomearToolStripMenuItem"
        '
        'tsbtCopyPath
        '
        resources.ApplyResources(Me.tsbtCopyPath, "tsbtCopyPath")
        Me.tsbtCopyPath.Image = Global.Druida_IDE_Lite.My.Resources.Resources.copyDirectory
        Me.tsbtCopyPath.Name = "tsbtCopyPath"
        '
        'ilExtenxions
        '
        Me.ilExtenxions.ImageStream = CType(resources.GetObject("ilExtenxions.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilExtenxions.TransparentColor = System.Drawing.Color.Transparent
        Me.ilExtenxions.Images.SetKeyName(0, "Folder.png")
        Me.ilExtenxions.Images.SetKeyName(1, "Arduino.jpg")
        Me.ilExtenxions.Images.SetKeyName(2, "Arduino.png")
        Me.ilExtenxions.Images.SetKeyName(3, "h.png")
        Me.ilExtenxions.Images.SetKeyName(4, "c.png")
        Me.ilExtenxions.Images.SetKeyName(5, "cpp.png")
        Me.ilExtenxions.Images.SetKeyName(6, "txt.png")
        Me.ilExtenxions.Images.SetKeyName(7, "png.png")
        Me.ilExtenxions.Images.SetKeyName(8, "Settings.png")
        Me.ilExtenxions.Images.SetKeyName(9, "firmware.png")
        Me.ilExtenxions.Images.SetKeyName(10, "proteus.png")
        '
        'lClose
        '
        resources.ApplyResources(Me.lClose, "lClose")
        Me.lClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lClose.ForeColor = System.Drawing.Color.Transparent
        Me.lClose.Name = "lClose"
        '
        'FilesExplorer
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lClose)
        Me.Controls.Add(Me.tvExplorer)
        Me.Controls.Add(Me.tsExplorer)
        Me.Controls.Add(Me.lHeader)
        Me.Name = "FilesExplorer"
        Me.tsExplorer.ResumeLayout(False)
        Me.tsExplorer.PerformLayout()
        Me.cmsFiles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lHeader As Label
    Friend WithEvents tsExplorer As ToolStrip
    Friend WithEvents tvExplorer As DruidaIDEAuxiliarControls.Explorer
    Friend WithEvents tsbtRefresh As ToolStripButton
    Friend WithEvents tsbtNewFile As ToolStripButton
    Friend WithEvents tsbtOpenAllCodes As ToolStripButton
    Friend WithEvents tsbtImportFile As ToolStripButton
    Friend WithEvents cmsFiles As ContextMenuStrip
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiNewFile As ToolStripMenuItem
    Friend WithEvents tsmiImportFile As ToolStripMenuItem
    Friend WithEvents AbrirPastaRecipienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenomearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiOpenAllCodes As ToolStripMenuItem
    Friend WithEvents lClose As Label
    Friend WithEvents ilExtenxions As ImageList
    Friend WithEvents tsbtCopyPath As ToolStripMenuItem
End Class
