<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.scStart = New System.Windows.Forms.SplitContainer()
        Me.itOpenLib = New DruidaIDEAuxiliarControls.CustomMenuItem()
        Me.itOpenFile = New DruidaIDEAuxiliarControls.CustomMenuItem()
        Me.itNewLib = New DruidaIDEAuxiliarControls.CustomMenuItem()
        Me.itOpenProject = New DruidaIDEAuxiliarControls.CustomMenuItem()
        Me.itNewProject = New DruidaIDEAuxiliarControls.CustomMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scRecent = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.itRecent1 = New DruidaIDEAuxiliarControls.CustomMenuItem()
        CType(Me.scStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scStart.Panel1.SuspendLayout()
        Me.scStart.Panel2.SuspendLayout()
        Me.scStart.SuspendLayout()
        CType(Me.scRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scRecent.Panel1.SuspendLayout()
        Me.scRecent.Panel2.SuspendLayout()
        Me.scRecent.SuspendLayout()
        Me.SuspendLayout()
        '
        'scStart
        '
        resources.ApplyResources(Me.scStart, "scStart")
        Me.scStart.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scStart.Name = "scStart"
        '
        'scStart.Panel1
        '
        Me.scStart.Panel1.Controls.Add(Me.itOpenLib)
        Me.scStart.Panel1.Controls.Add(Me.itOpenFile)
        Me.scStart.Panel1.Controls.Add(Me.itNewLib)
        Me.scStart.Panel1.Controls.Add(Me.itOpenProject)
        Me.scStart.Panel1.Controls.Add(Me.itNewProject)
        Me.scStart.Panel1.Controls.Add(Me.Label2)
        Me.scStart.Panel1.Controls.Add(Me.Label1)
        '
        'scStart.Panel2
        '
        resources.ApplyResources(Me.scStart.Panel2, "scStart.Panel2")
        Me.scStart.Panel2.Controls.Add(Me.scRecent)
        '
        'itOpenLib
        '
        resources.ApplyResources(Me.itOpenLib, "itOpenLib")
        Me.itOpenLib.BtText = "Abrir Biblioteca"
        Me.itOpenLib.DeleteConfirmMessage = Nothing
        Me.itOpenLib.HighlightColor = System.Drawing.SystemColors.HotTrack
        Me.itOpenLib.Icon = Global.Druida_IDE_Lite.My.Resources.Resources.OpenLibrary
        Me.itOpenLib.Name = "itOpenLib"
        Me.itOpenLib.ShowDeleteButton = False
        '
        'itOpenFile
        '
        resources.ApplyResources(Me.itOpenFile, "itOpenFile")
        Me.itOpenFile.BtText = "Abrir Arquivo"
        Me.itOpenFile.DeleteConfirmMessage = Nothing
        Me.itOpenFile.HighlightColor = System.Drawing.SystemColors.HotTrack
        Me.itOpenFile.Icon = Global.Druida_IDE_Lite.My.Resources.Resources.Open
        Me.itOpenFile.Name = "itOpenFile"
        Me.itOpenFile.ShowDeleteButton = False
        '
        'itNewLib
        '
        resources.ApplyResources(Me.itNewLib, "itNewLib")
        Me.itNewLib.BtText = "Nova Biblioteca"
        Me.itNewLib.DeleteConfirmMessage = Nothing
        Me.itNewLib.HighlightColor = System.Drawing.SystemColors.HotTrack
        Me.itNewLib.Icon = Global.Druida_IDE_Lite.My.Resources.Resources.AddLibrary
        Me.itNewLib.Name = "itNewLib"
        Me.itNewLib.ShowDeleteButton = False
        '
        'itOpenProject
        '
        resources.ApplyResources(Me.itOpenProject, "itOpenProject")
        Me.itOpenProject.BtText = "Abrir Projeto"
        Me.itOpenProject.DeleteConfirmMessage = Nothing
        Me.itOpenProject.HighlightColor = System.Drawing.SystemColors.HotTrack
        Me.itOpenProject.Icon = Global.Druida_IDE_Lite.My.Resources.Resources.Folder
        Me.itOpenProject.Name = "itOpenProject"
        Me.itOpenProject.ShowDeleteButton = False
        '
        'itNewProject
        '
        resources.ApplyResources(Me.itNewProject, "itNewProject")
        Me.itNewProject.BtText = "Novo Projeto"
        Me.itNewProject.DeleteConfirmMessage = Nothing
        Me.itNewProject.HighlightColor = System.Drawing.SystemColors.HotTrack
        Me.itNewProject.Icon = Global.Druida_IDE_Lite.My.Resources.Resources.New_File
        Me.itNewProject.Name = "itNewProject"
        Me.itNewProject.ShowDeleteButton = False
        Me.itNewProject.Tag = ""
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'scRecent
        '
        resources.ApplyResources(Me.scRecent, "scRecent")
        Me.scRecent.Name = "scRecent"
        '
        'scRecent.Panel1
        '
        Me.scRecent.Panel1.Controls.Add(Me.Label6)
        '
        'scRecent.Panel2
        '
        resources.ApplyResources(Me.scRecent.Panel2, "scRecent.Panel2")
        Me.scRecent.Panel2.Controls.Add(Me.itRecent1)
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'itRecent1
        '
        Me.itRecent1.BtText = "Arquivo Recente"
        Me.itRecent1.DeleteConfirmMessage = ""
        Me.itRecent1.HighlightColor = System.Drawing.SystemColors.HotTrack
        Me.itRecent1.Icon = Global.Druida_IDE_Lite.My.Resources.Resources.Arduino
        resources.ApplyResources(Me.itRecent1, "itRecent1")
        Me.itRecent1.Name = "itRecent1"
        Me.itRecent1.ShowDeleteButton = True
        '
        'HomePage
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.scStart)
        Me.Name = "HomePage"
        Me.scStart.Panel1.ResumeLayout(False)
        Me.scStart.Panel1.PerformLayout()
        Me.scStart.Panel2.ResumeLayout(False)
        CType(Me.scStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scStart.ResumeLayout(False)
        Me.scRecent.Panel1.ResumeLayout(False)
        Me.scRecent.Panel1.PerformLayout()
        Me.scRecent.Panel2.ResumeLayout(False)
        CType(Me.scRecent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scRecent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scStart As SplitContainer
    Friend WithEvents itNewLib As DruidaIDEAuxiliarControls.CustomMenuItem
    Friend WithEvents itOpenProject As DruidaIDEAuxiliarControls.CustomMenuItem
    Friend WithEvents itNewProject As DruidaIDEAuxiliarControls.CustomMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents scRecent As SplitContainer
    Friend WithEvents itOpenFile As DruidaIDEAuxiliarControls.CustomMenuItem
    Friend WithEvents itRecent1 As DruidaIDEAuxiliarControls.CustomMenuItem
    Friend WithEvents itOpenLib As DruidaIDEAuxiliarControls.CustomMenuItem
End Class
