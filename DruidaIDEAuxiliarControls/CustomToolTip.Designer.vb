<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomToolTip
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
        Me.PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.Título = New System.Windows.Forms.Label()
        Me.LabelTexto = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.Label()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxIcon
        '
        Me.PictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxIcon.Location = New System.Drawing.Point(6, 6)
        Me.PictureBoxIcon.Name = "PictureBoxIcon"
        Me.PictureBoxIcon.Size = New System.Drawing.Size(21, 20)
        Me.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIcon.TabIndex = 0
        Me.PictureBoxIcon.TabStop = False
        '
        'Título
        '
        Me.Título.AutoSize = True
        Me.Título.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Título.Location = New System.Drawing.Point(34, 10)
        Me.Título.Name = "Título"
        Me.Título.Size = New System.Drawing.Size(41, 13)
        Me.Título.TabIndex = 1
        Me.Título.Text = "Título"
        '
        'LabelTexto
        '
        Me.LabelTexto.AutoSize = True
        Me.LabelTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTexto.Location = New System.Drawing.Point(9, 32)
        Me.LabelTexto.Name = "LabelTexto"
        Me.LabelTexto.Size = New System.Drawing.Size(55, 13)
        Me.LabelTexto.TabIndex = 2
        Me.LabelTexto.Text = "Descrição"
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type.ForeColor = System.Drawing.Color.Blue
        Me.Type.Location = New System.Drawing.Point(31, 10)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(44, 13)
        Me.Type.TabIndex = 3
        Me.Type.Text = "Object"
        Me.Type.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CustomToolTip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PictureBoxIcon)
        Me.Controls.Add(Me.LabelTexto)
        Me.Controls.Add(Me.Título)
        Me.Controls.Add(Me.Type)
        Me.Name = "CustomToolTip"
        Me.Size = New System.Drawing.Size(78, 45)
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxIcon As PictureBox
    Friend WithEvents Título As Label
    Friend WithEvents LabelTexto As Label
    Friend WithEvents Type As Label
End Class
