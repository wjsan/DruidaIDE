<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.tcGeneralEditor = New VisualStudioTabControl.VisualStudioTabControl()
        Me.SuspendLayout()
        '
        'tcGeneralEditor
        '
        Me.tcGeneralEditor.ActiveColor = System.Drawing.SystemColors.HotTrack
        Me.tcGeneralEditor.AllowDrop = True
        Me.tcGeneralEditor.BackTabColor = System.Drawing.SystemColors.Control
        Me.tcGeneralEditor.BorderColor = System.Drawing.Color.Transparent
        Me.tcGeneralEditor.ClosingButtonColor = System.Drawing.Color.White
        Me.tcGeneralEditor.ClosingMessage = Nothing
        Me.tcGeneralEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcGeneralEditor.HeaderColor = System.Drawing.Color.DarkGray
        Me.tcGeneralEditor.HorizontalLineColor = System.Drawing.SystemColors.ButtonFace
        Me.tcGeneralEditor.ItemSize = New System.Drawing.Size(240, 16)
        Me.tcGeneralEditor.Location = New System.Drawing.Point(0, 0)
        Me.tcGeneralEditor.Name = "tcGeneralEditor"
        Me.tcGeneralEditor.SelectedIndex = 0
        Me.tcGeneralEditor.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tcGeneralEditor.ShowClosingButton = True
        Me.tcGeneralEditor.ShowClosingMessage = False
        Me.tcGeneralEditor.Size = New System.Drawing.Size(943, 450)
        Me.tcGeneralEditor.TabIndex = 2
        Me.tcGeneralEditor.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 450)
        Me.Controls.Add(Me.tcGeneralEditor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcGeneralEditor As VisualStudioTabControl.VisualStudioTabControl
End Class
