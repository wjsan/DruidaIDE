<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CFGsPinout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CFGsPinout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbtImport = New System.Windows.Forms.ToolStripButton()
        Me.Pinout1 = New Druida_IDE_Lite.Pinout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtSave, Me.tsbtAdd, Me.tsbtImport})
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'tsbtSave
        '
        resources.ApplyResources(Me.tsbtSave, "tsbtSave")
        Me.tsbtSave.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Save_File
        Me.tsbtSave.Name = "tsbtSave"
        '
        'tsbtAdd
        '
        resources.ApplyResources(Me.tsbtAdd, "tsbtAdd")
        Me.tsbtAdd.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Add_File
        Me.tsbtAdd.Name = "tsbtAdd"
        '
        'tsbtImport
        '
        resources.ApplyResources(Me.tsbtImport, "tsbtImport")
        Me.tsbtImport.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Import_File
        Me.tsbtImport.Name = "tsbtImport"
        '
        'Pinout1
        '
        resources.ApplyResources(Me.Pinout1, "Pinout1")
        Me.Pinout1.Name = "Pinout1"
        '
        'CFGsPinout
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Pinout1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CFGsPinout"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Pinout1 As Pinout
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtSave As ToolStripButton
    Friend WithEvents tsbtAdd As ToolStripButton
    Friend WithEvents tsbtImport As ToolStripButton
End Class
