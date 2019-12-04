<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMenuItem
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
        Me.lbText = New System.Windows.Forms.Label()
        Me.pbTrash = New System.Windows.Forms.PictureBox()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        CType(Me.pbTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbText
        '
        Me.lbText.AutoSize = True
        Me.lbText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbText.Location = New System.Drawing.Point(51, 16)
        Me.lbText.Name = "lbText"
        Me.lbText.Size = New System.Drawing.Size(45, 18)
        Me.lbText.TabIndex = 6
        Me.lbText.Text = "Texto"
        '
        'pbTrash
        '
        Me.pbTrash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbTrash.Image = Global.DruidaIDEAuxiliarControls.My.Resources.Resources.Delete
        Me.pbTrash.Location = New System.Drawing.Point(114, 3)
        Me.pbTrash.Name = "pbTrash"
        Me.pbTrash.Size = New System.Drawing.Size(31, 29)
        Me.pbTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTrash.TabIndex = 7
        Me.pbTrash.TabStop = False
        '
        'pbIcon
        '
        Me.pbIcon.Location = New System.Drawing.Point(3, 3)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(36, 42)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 5
        Me.pbIcon.TabStop = False
        '
        'CustomMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbTrash)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.lbText)
        Me.Name = "CustomMenuItem"
        Me.Size = New System.Drawing.Size(149, 48)
        CType(Me.pbTrash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents lbText As Label
    Friend WithEvents pbTrash As PictureBox
End Class
