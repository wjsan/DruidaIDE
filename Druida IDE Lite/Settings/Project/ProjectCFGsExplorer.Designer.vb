<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectCFGsExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectCFGsExplorer))
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.tvCFGitem = New System.Windows.Forms.TreeView()
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
        resources.ApplyResources(Me.scMain.Panel1, "scMain.Panel1")
        Me.scMain.Panel1.Controls.Add(Me.tvCFGitem)
        '
        'scMain.Panel2
        '
        resources.ApplyResources(Me.scMain.Panel2, "scMain.Panel2")
        '
        'tvCFGitem
        '
        resources.ApplyResources(Me.tvCFGitem, "tvCFGitem")
        Me.tvCFGitem.Name = "tvCFGitem"
        Me.tvCFGitem.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("tvCFGitem.Nodes"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvCFGitem.Nodes1"), System.Windows.Forms.TreeNode), CType(resources.GetObject("tvCFGitem.Nodes2"), System.Windows.Forms.TreeNode)})
        '
        'ProjectCFGsExplorer
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.scMain)
        Me.Name = "ProjectCFGsExplorer"
        Me.scMain.Panel1.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scMain As SplitContainer
    Friend WithEvents tvCFGitem As TreeView
End Class
