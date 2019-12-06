<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ícone
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
        Me.PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.PanelIcon = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxIcon
        '
        Me.PictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxIcon.Location = New System.Drawing.Point(13, 3)
        Me.PictureBoxIcon.Name = "PictureBoxIcon"
        Me.PictureBoxIcon.Size = New System.Drawing.Size(51, 50)
        Me.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxIcon.TabIndex = 0
        Me.PictureBoxIcon.TabStop = False
        '
        'LabelNome
        '
        Me.LabelNome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelNome.Location = New System.Drawing.Point(2, 55)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(73, 32)
        Me.LabelNome.TabIndex = 1
        Me.LabelNome.Text = "Nome"
        Me.LabelNome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelIcon
        '
        Me.PanelIcon.Controls.Add(Me.LabelNome)
        Me.PanelIcon.Controls.Add(Me.PictureBoxIcon)
        Me.PanelIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelIcon.Location = New System.Drawing.Point(0, 0)
        Me.PanelIcon.Name = "PanelIcon"
        Me.PanelIcon.Size = New System.Drawing.Size(77, 88)
        Me.PanelIcon.TabIndex = 2
        '
        'Ícone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PanelIcon)
        Me.Name = "Ícone"
        Me.Size = New System.Drawing.Size(77, 88)
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIcon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelIcon As Panel
    Friend WithEvents PictureBoxIcon As PictureBox
    Friend WithEvents LabelNome As Label
End Class
