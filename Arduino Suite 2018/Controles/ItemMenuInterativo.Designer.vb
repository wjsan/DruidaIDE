<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemMenuInterativo
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
        Me.PictureBoxItem = New System.Windows.Forms.PictureBox()
        Me.LabelNomeItem = New System.Windows.Forms.Label()
        CType(Me.PictureBoxItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxItem
        '
        Me.PictureBoxItem.Location = New System.Drawing.Point(1, 1)
        Me.PictureBoxItem.Name = "PictureBoxItem"
        Me.PictureBoxItem.Size = New System.Drawing.Size(35, 35)
        Me.PictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxItem.TabIndex = 0
        Me.PictureBoxItem.TabStop = False
        '
        'LabelNomeItem
        '
        Me.LabelNomeItem.Location = New System.Drawing.Point(40, 1)
        Me.LabelNomeItem.Name = "LabelNomeItem"
        Me.LabelNomeItem.Size = New System.Drawing.Size(187, 37)
        Me.LabelNomeItem.TabIndex = 1
        Me.LabelNomeItem.Text = "Nome do Item"
        Me.LabelNomeItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ItemMenuInterativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBoxItem)
        Me.Controls.Add(Me.LabelNomeItem)
        Me.Name = "ItemMenuInterativo"
        Me.Size = New System.Drawing.Size(228, 38)
        CType(Me.PictureBoxItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxItem As PictureBox
    Friend WithEvents LabelNomeItem As Label
End Class
