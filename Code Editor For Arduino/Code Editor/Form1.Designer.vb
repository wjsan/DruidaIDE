<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CodeEditorForArduino1 = New Code_Editor_For_Arduino.CodeEditorForArduino()
        CType(Me.CodeEditorForArduino1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodeEditorForArduino1
        '
        Me.CodeEditorForArduino1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.CodeEditorForArduino1.AutoScrollMinSize = New System.Drawing.Size(195, 14)
        Me.CodeEditorForArduino1.BackBrush = Nothing
        Me.CodeEditorForArduino1.CharHeight = 14
        Me.CodeEditorForArduino1.CharWidth = 8
        Me.CodeEditorForArduino1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodeEditorForArduino1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CodeEditorForArduino1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorForArduino1.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.CodeEditorForArduino1.IsReplaceMode = False
        Me.CodeEditorForArduino1.Location = New System.Drawing.Point(0, 0)
        Me.CodeEditorForArduino1.Name = "CodeEditorForArduino1"
        Me.CodeEditorForArduino1.Paddings = New System.Windows.Forms.Padding(0)
        Me.CodeEditorForArduino1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CodeEditorForArduino1.ServiceColors = CType(resources.GetObject("CodeEditorForArduino1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.CodeEditorForArduino1.Size = New System.Drawing.Size(800, 450)
        Me.CodeEditorForArduino1.TabIndex = 0
        Me.CodeEditorForArduino1.Text = "CodeEditorForArduino1"
        Me.CodeEditorForArduino1.Zoom = 100
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CodeEditorForArduino1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CodeEditorForArduino1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CodeEditorForArduino1 As CodeEditorForArduino
End Class
