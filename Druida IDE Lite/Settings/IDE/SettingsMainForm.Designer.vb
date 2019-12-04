<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsMainForm))
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tvSettingsItem = New System.Windows.Forms.TreeView()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'scMain
        '
        resources.ApplyResources(Me.scMain, "scMain")
        Me.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.Label1)
        Me.scMain.Panel1.Controls.Add(Me.tvSettingsItem)
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'tvSettingsItem
        '
        resources.ApplyResources(Me.tvSettingsItem, "tvSettingsItem")
        Me.tvSettingsItem.Name = "tvSettingsItem"
        Me.tvSettingsItem.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("tvSettingsItem.Nodes"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvSettingsItem.Nodes1"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvSettingsItem.Nodes2"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvSettingsItem.Nodes3"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvSettingsItem.Nodes4"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvSettingsItem.Nodes5"), System.Windows.Forms.TreeNode)})
        '
        'SettingsMainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.scMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "SettingsMainForm"
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel1.PerformLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvSettingsItem As TreeView
    Friend WithEvents scMain As SplitContainer
    Friend WithEvents Label1 As Label
End Class
