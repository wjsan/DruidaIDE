<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GeneralEditor
    Inherits System.Windows.Forms.UserControl

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
        Me.myDocMap = New FastColoredTextBoxNS.DocumentMap()
        Me.lToggleConsole = New System.Windows.Forms.Label()
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
        Me.tcGeneralEditor.Size = New System.Drawing.Size(338, 327)
        Me.tcGeneralEditor.TabIndex = 1
        Me.tcGeneralEditor.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'myDocMap
        '
        Me.myDocMap.Dock = System.Windows.Forms.DockStyle.Right
        Me.myDocMap.ForeColor = System.Drawing.Color.Maroon
        Me.myDocMap.Location = New System.Drawing.Point(338, 0)
        Me.myDocMap.Name = "myDocMap"
        Me.myDocMap.Size = New System.Drawing.Size(134, 327)
        Me.myDocMap.TabIndex = 2
        Me.myDocMap.Target = Nothing
        Me.myDocMap.Text = "DocumentMap1"
        Me.myDocMap.Visible = False
        '
        'lToggleConsole
        '
        Me.lToggleConsole.AutoSize = True
        Me.lToggleConsole.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lToggleConsole.Dock = System.Windows.Forms.DockStyle.Right
        Me.lToggleConsole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lToggleConsole.ForeColor = System.Drawing.Color.Transparent
        Me.lToggleConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lToggleConsole.Location = New System.Drawing.Point(316, 0)
        Me.lToggleConsole.Name = "lToggleConsole"
        Me.lToggleConsole.Size = New System.Drawing.Size(22, 16)
        Me.lToggleConsole.TabIndex = 13
        Me.lToggleConsole.Text = ">_"
        '
        'GeneralEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.lToggleConsole)
        Me.Controls.Add(Me.tcGeneralEditor)
        Me.Controls.Add(Me.myDocMap)
        Me.Name = "GeneralEditor"
        Me.Size = New System.Drawing.Size(472, 327)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcGeneralEditor As VisualStudioTabControl.VisualStudioTabControl
    Friend WithEvents myDocMap As FastColoredTextBoxNS.DocumentMap
    Friend WithEvents lToggleConsole As Label
End Class
