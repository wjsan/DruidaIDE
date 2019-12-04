<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectsExplorer
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObjectsExplorer))
        Me.tvObjectList = New System.Windows.Forms.TreeView()
        Me.tsObjetcExplorer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonAtualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonLibraries = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonClass = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonFunctions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonVars = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageListFiles = New System.Windows.Forms.ImageList(Me.components)
        Me.lClose = New System.Windows.Forms.Label()
        Me.tsObjetcExplorer.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvObjectList
        '
        resources.ApplyResources(Me.tvObjectList, "tvObjectList")
        Me.tvObjectList.FullRowSelect = True
        Me.tvObjectList.Name = "tvObjectList"
        Me.tvObjectList.ShowNodeToolTips = True
        '
        'tsObjetcExplorer
        '
        Me.tsObjetcExplorer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAtualizar, Me.ToolStripSeparator1, Me.ToolStripButtonLibraries, Me.ToolStripButtonClass, Me.ToolStripButtonFunctions, Me.ToolStripButtonVars})
        resources.ApplyResources(Me.tsObjetcExplorer, "tsObjetcExplorer")
        Me.tsObjetcExplorer.Name = "tsObjetcExplorer"
        '
        'ToolStripButtonAtualizar
        '
        Me.ToolStripButtonAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAtualizar.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Refresh
        resources.ApplyResources(Me.ToolStripButtonAtualizar, "ToolStripButtonAtualizar")
        Me.ToolStripButtonAtualizar.Name = "ToolStripButtonAtualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ToolStripButtonLibraries
        '
        Me.ToolStripButtonLibraries.Checked = True
        Me.ToolStripButtonLibraries.CheckOnClick = True
        Me.ToolStripButtonLibraries.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButtonLibraries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonLibraries.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Library
        resources.ApplyResources(Me.ToolStripButtonLibraries, "ToolStripButtonLibraries")
        Me.ToolStripButtonLibraries.Name = "ToolStripButtonLibraries"
        '
        'ToolStripButtonClass
        '
        Me.ToolStripButtonClass.Checked = True
        Me.ToolStripButtonClass.CheckOnClick = True
        Me.ToolStripButtonClass.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButtonClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonClass.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Tree
        resources.ApplyResources(Me.ToolStripButtonClass, "ToolStripButtonClass")
        Me.ToolStripButtonClass.Name = "ToolStripButtonClass"
        '
        'ToolStripButtonFunctions
        '
        Me.ToolStripButtonFunctions.Checked = True
        Me.ToolStripButtonFunctions.CheckOnClick = True
        Me.ToolStripButtonFunctions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButtonFunctions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFunctions.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Cube
        resources.ApplyResources(Me.ToolStripButtonFunctions, "ToolStripButtonFunctions")
        Me.ToolStripButtonFunctions.Name = "ToolStripButtonFunctions"
        '
        'ToolStripButtonVars
        '
        Me.ToolStripButtonVars.Checked = True
        Me.ToolStripButtonVars.CheckOnClick = True
        Me.ToolStripButtonVars.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButtonVars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonVars.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Var
        resources.ApplyResources(Me.ToolStripButtonVars, "ToolStripButtonVars")
        Me.ToolStripButtonVars.Name = "ToolStripButtonVars"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'ImageListFiles
        '
        Me.ImageListFiles.ImageStream = CType(resources.GetObject("ImageListFiles.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListFiles.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListFiles.Images.SetKeyName(0, "pasta.png")
        Me.ImageListFiles.Images.SetKeyName(1, "arduinoIDE.png")
        Me.ImageListFiles.Images.SetKeyName(2, "cpp.png")
        Me.ImageListFiles.Images.SetKeyName(3, "h.png")
        Me.ImageListFiles.Images.SetKeyName(4, "notepad.png")
        Me.ImageListFiles.Images.SetKeyName(5, "png.jpg")
        Me.ImageListFiles.Images.SetKeyName(6, "Seetings.ico")
        '
        'lClose
        '
        resources.ApplyResources(Me.lClose, "lClose")
        Me.lClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lClose.ForeColor = System.Drawing.Color.Transparent
        Me.lClose.Name = "lClose"
        '
        'ObjectsExplorer
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lClose)
        Me.Controls.Add(Me.tvObjectList)
        Me.Controls.Add(Me.tsObjetcExplorer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ObjectsExplorer"
        Me.tsObjetcExplorer.ResumeLayout(False)
        Me.tsObjetcExplorer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tvObjectList As TreeView
    Friend WithEvents tsObjetcExplorer As ToolStrip
    Friend WithEvents ToolStripButtonAtualizar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButtonLibraries As ToolStripButton
    Friend WithEvents ToolStripButtonClass As ToolStripButton
    Friend WithEvents ToolStripButtonFunctions As ToolStripButton
    Friend WithEvents ToolStripButtonVars As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageListFiles As ImageList
    Friend WithEvents lClose As Label
End Class
