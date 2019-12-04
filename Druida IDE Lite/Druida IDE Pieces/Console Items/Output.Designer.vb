<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Output))
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.tsOutput = New System.Windows.Forms.ToolStrip()
        Me.tslMessageFilter = New System.Windows.Forms.ToolStripLabel()
        Me.tscbOutputFilter = New System.Windows.Forms.ToolStripComboBox()
        Me.tsbClearOutput = New System.Windows.Forms.ToolStripButton()
        Me.tsOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbOutput
        '
        resources.ApplyResources(Me.tbOutput, "tbOutput")
        Me.tbOutput.BackColor = System.Drawing.Color.White
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ReadOnly = True
        '
        'tsOutput
        '
        resources.ApplyResources(Me.tsOutput, "tsOutput")
        Me.tsOutput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslMessageFilter, Me.tscbOutputFilter, Me.tsbClearOutput})
        Me.tsOutput.Name = "tsOutput"
        '
        'tslMessageFilter
        '
        resources.ApplyResources(Me.tslMessageFilter, "tslMessageFilter")
        Me.tslMessageFilter.Name = "tslMessageFilter"
        '
        'tscbOutputFilter
        '
        resources.ApplyResources(Me.tscbOutputFilter, "tscbOutputFilter")
        Me.tscbOutputFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbOutputFilter.Items.AddRange(New Object() {resources.GetString("tscbOutputFilter.Items"), resources.GetString("tscbOutputFilter.Items1"), resources.GetString("tscbOutputFilter.Items2")})
        Me.tscbOutputFilter.MergeIndex = 0
        Me.tscbOutputFilter.Name = "tscbOutputFilter"
        '
        'tsbClearOutput
        '
        resources.ApplyResources(Me.tsbClearOutput, "tsbClearOutput")
        Me.tsbClearOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClearOutput.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete_All
        Me.tsbClearOutput.Name = "tsbClearOutput"
        '
        'Output
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.tsOutput)
        Me.Name = "Output"
        Me.tsOutput.ResumeLayout(False)
        Me.tsOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbOutput As TextBox
    Friend WithEvents tsOutput As ToolStrip
    Friend WithEvents tslMessageFilter As ToolStripLabel
    Friend WithEvents tscbOutputFilter As ToolStripComboBox
    Friend WithEvents tsbClearOutput As ToolStripButton
End Class
