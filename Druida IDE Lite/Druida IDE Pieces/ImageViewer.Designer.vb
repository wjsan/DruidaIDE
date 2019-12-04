<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageViewer
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
        Me.tsImageViewer = New System.Windows.Forms.ToolStrip()
        Me.tsbtZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.tsbtZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.tsbtUndoZoom = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFitToScreen = New System.Windows.Forms.ToolStripButton()
        Me.pnImgViewer = New System.Windows.Forms.Panel()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.tsImageViewer.SuspendLayout()
        Me.pnImgViewer.SuspendLayout()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsImageViewer
        '
        Me.tsImageViewer.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsImageViewer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtZoomIn, Me.tsbtZoomOut, Me.tsbtUndoZoom, Me.tsbtFitToScreen})
        Me.tsImageViewer.Location = New System.Drawing.Point(0, 0)
        Me.tsImageViewer.Name = "tsImageViewer"
        Me.tsImageViewer.Size = New System.Drawing.Size(372, 54)
        Me.tsImageViewer.TabIndex = 0
        Me.tsImageViewer.Text = "ToolStrip1"
        '
        'tsbtZoomIn
        '
        Me.tsbtZoomIn.Image = Global.Druida_IDE_Lite.My.Resources.Resources.ZoomIn
        Me.tsbtZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtZoomIn.Name = "tsbtZoomIn"
        Me.tsbtZoomIn.Size = New System.Drawing.Size(56, 51)
        Me.tsbtZoomIn.Text = "Zoom In"
        Me.tsbtZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbtZoomOut
        '
        Me.tsbtZoomOut.Image = Global.Druida_IDE_Lite.My.Resources.Resources.ZoomOut
        Me.tsbtZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtZoomOut.Name = "tsbtZoomOut"
        Me.tsbtZoomOut.Size = New System.Drawing.Size(66, 51)
        Me.tsbtZoomOut.Text = "Zoom Out"
        Me.tsbtZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbtUndoZoom
        '
        Me.tsbtUndoZoom.Image = Global.Druida_IDE_Lite.My.Resources.Resources.ZoomToNormal
        Me.tsbtUndoZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtUndoZoom.Name = "tsbtUndoZoom"
        Me.tsbtUndoZoom.Size = New System.Drawing.Size(55, 51)
        Me.tsbtUndoZoom.Text = "Desfazer"
        Me.tsbtUndoZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbtFitToScreen
        '
        Me.tsbtFitToScreen.Image = Global.Druida_IDE_Lite.My.Resources.Resources.FitToScreen
        Me.tsbtFitToScreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtFitToScreen.Name = "tsbtFitToScreen"
        Me.tsbtFitToScreen.Size = New System.Drawing.Size(48, 51)
        Me.tsbtFitToScreen.Text = "Ajustar"
        Me.tsbtFitToScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pnImgViewer
        '
        Me.pnImgViewer.BackColor = System.Drawing.Color.White
        Me.pnImgViewer.Controls.Add(Me.img)
        Me.pnImgViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnImgViewer.Location = New System.Drawing.Point(0, 54)
        Me.pnImgViewer.Name = "pnImgViewer"
        Me.pnImgViewer.Size = New System.Drawing.Size(372, 235)
        Me.pnImgViewer.TabIndex = 1
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(3, 3)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(100, 50)
        Me.img.TabIndex = 0
        Me.img.TabStop = False
        '
        'ImageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnImgViewer)
        Me.Controls.Add(Me.tsImageViewer)
        Me.Name = "ImageViewer"
        Me.Size = New System.Drawing.Size(372, 289)
        Me.tsImageViewer.ResumeLayout(False)
        Me.tsImageViewer.PerformLayout()
        Me.pnImgViewer.ResumeLayout(False)
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsImageViewer As ToolStrip
    Friend WithEvents tsbtZoomIn As ToolStripButton
    Friend WithEvents pnImgViewer As Panel
    Friend WithEvents tsbtFitToScreen As ToolStripButton
    Friend WithEvents tsbtUndoZoom As ToolStripButton
    Friend WithEvents tsbtZoomOut As ToolStripButton
    Friend WithEvents img As PictureBox
End Class
