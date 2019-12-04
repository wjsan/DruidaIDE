<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorsList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorsList))
        Me.lvErrors = New System.Windows.Forms.ListView()
        Me.chDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilErrors = New System.Windows.Forms.ImageList(Me.components)
        Me.tsErrors = New System.Windows.Forms.ToolStrip()
        Me.tsbFilterErrors = New System.Windows.Forms.ToolStripButton()
        Me.tsbFilterNotices = New System.Windows.Forms.ToolStripButton()
        Me.tdbFilterInformations = New System.Windows.Forms.ToolStripButton()
        Me.tsbClearErrors = New System.Windows.Forms.ToolStripButton()
        Me.tsErrors.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvErrors
        '
        Me.lvErrors.AllowColumnReorder = True
        Me.lvErrors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chDescription, Me.chFile, Me.chLine})
        resources.ApplyResources(Me.lvErrors, "lvErrors")
        Me.lvErrors.FullRowSelect = True
        Me.lvErrors.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {CType(resources.GetObject("lvErrors.Groups"), System.Windows.Forms.ListViewGroup), CType(resources.GetObject("lvErrors.Groups1"), System.Windows.Forms.ListViewGroup), CType(resources.GetObject("lvErrors.Groups2"), System.Windows.Forms.ListViewGroup)})
        Me.lvErrors.LargeImageList = Me.ilErrors
        Me.lvErrors.MultiSelect = False
        Me.lvErrors.Name = "lvErrors"
        Me.lvErrors.SmallImageList = Me.ilErrors
        Me.lvErrors.UseCompatibleStateImageBehavior = False
        Me.lvErrors.View = System.Windows.Forms.View.Details
        '
        'chDescription
        '
        resources.ApplyResources(Me.chDescription, "chDescription")
        '
        'chFile
        '
        resources.ApplyResources(Me.chFile, "chFile")
        '
        'chLine
        '
        resources.ApplyResources(Me.chLine, "chLine")
        '
        'ilErrors
        '
        Me.ilErrors.ImageStream = CType(resources.GetObject("ilErrors.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilErrors.TransparentColor = System.Drawing.Color.Transparent
        Me.ilErrors.Images.SetKeyName(0, "Errors.png")
        Me.ilErrors.Images.SetKeyName(1, "Notice.png")
        Me.ilErrors.Images.SetKeyName(2, "Information.png")
        '
        'tsErrors
        '
        Me.tsErrors.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFilterErrors, Me.tsbFilterNotices, Me.tdbFilterInformations, Me.tsbClearErrors})
        resources.ApplyResources(Me.tsErrors, "tsErrors")
        Me.tsErrors.Name = "tsErrors"
        '
        'tsbFilterErrors
        '
        Me.tsbFilterErrors.Checked = True
        Me.tsbFilterErrors.CheckOnClick = True
        Me.tsbFilterErrors.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbFilterErrors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFilterErrors.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete
        resources.ApplyResources(Me.tsbFilterErrors, "tsbFilterErrors")
        Me.tsbFilterErrors.Name = "tsbFilterErrors"
        '
        'tsbFilterNotices
        '
        Me.tsbFilterNotices.Checked = True
        Me.tsbFilterNotices.CheckOnClick = True
        Me.tsbFilterNotices.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbFilterNotices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFilterNotices.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Notice
        resources.ApplyResources(Me.tsbFilterNotices, "tsbFilterNotices")
        Me.tsbFilterNotices.Name = "tsbFilterNotices"
        '
        'tdbFilterInformations
        '
        Me.tdbFilterInformations.Checked = True
        Me.tdbFilterInformations.CheckOnClick = True
        Me.tdbFilterInformations.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tdbFilterInformations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tdbFilterInformations.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Information
        resources.ApplyResources(Me.tdbFilterInformations, "tdbFilterInformations")
        Me.tdbFilterInformations.Name = "tdbFilterInformations"
        '
        'tsbClearErrors
        '
        Me.tsbClearErrors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClearErrors.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete_All
        resources.ApplyResources(Me.tsbClearErrors, "tsbClearErrors")
        Me.tsbClearErrors.Name = "tsbClearErrors"
        '
        'ErrorsList
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lvErrors)
        Me.Controls.Add(Me.tsErrors)
        Me.Name = "ErrorsList"
        Me.tsErrors.ResumeLayout(False)
        Me.tsErrors.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvErrors As ListView
    Friend WithEvents chDescription As ColumnHeader
    Friend WithEvents chFile As ColumnHeader
    Friend WithEvents chLine As ColumnHeader
    Friend WithEvents tsErrors As ToolStrip
    Friend WithEvents tsbFilterErrors As ToolStripButton
    Friend WithEvents tsbFilterNotices As ToolStripButton
    Friend WithEvents tdbFilterInformations As ToolStripButton
    Friend WithEvents tsbClearErrors As ToolStripButton
    Friend WithEvents ilErrors As ImageList
End Class
