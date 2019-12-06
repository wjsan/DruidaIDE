<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alarme
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
        Me.ButtonApagar = New System.Windows.Forms.Button()
        Me.TextBoxMensagem = New System.Windows.Forms.TextBox()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoAlarme = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPorta = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTipoPorta = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBit = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtonApagar
        '
        Me.ButtonApagar.Location = New System.Drawing.Point(747, 2)
        Me.ButtonApagar.Name = "ButtonApagar"
        Me.ButtonApagar.Size = New System.Drawing.Size(86, 23)
        Me.ButtonApagar.TabIndex = 14
        Me.ButtonApagar.Text = "Apagar Alarme"
        Me.ButtonApagar.UseVisualStyleBackColor = True
        '
        'TextBoxMensagem
        '
        Me.TextBoxMensagem.Location = New System.Drawing.Point(354, 4)
        Me.TextBoxMensagem.Name = "TextBoxMensagem"
        Me.TextBoxMensagem.Size = New System.Drawing.Size(386, 20)
        Me.TextBoxMensagem.TabIndex = 12
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Location = New System.Drawing.Point(285, 4)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(61, 20)
        Me.TextBoxValor.TabIndex = 13
        '
        'ComboBoxTipoAlarme
        '
        Me.ComboBoxTipoAlarme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoAlarme.FormattingEnabled = True
        Me.ComboBoxTipoAlarme.Items.AddRange(New Object() {"Máximo", "Mínimo"})
        Me.ComboBoxTipoAlarme.Location = New System.Drawing.Point(212, 3)
        Me.ComboBoxTipoAlarme.Name = "ComboBoxTipoAlarme"
        Me.ComboBoxTipoAlarme.Size = New System.Drawing.Size(64, 21)
        Me.ComboBoxTipoAlarme.TabIndex = 4
        '
        'ComboBoxPorta
        '
        Me.ComboBoxPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPorta.FormattingEnabled = True
        Me.ComboBoxPorta.Location = New System.Drawing.Point(120, 3)
        Me.ComboBoxPorta.Name = "ComboBoxPorta"
        Me.ComboBoxPorta.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxPorta.TabIndex = 5
        '
        'ComboBoxTipoPorta
        '
        Me.ComboBoxTipoPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoPorta.FormattingEnabled = True
        Me.ComboBoxTipoPorta.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxTipoPorta.Name = "ComboBoxTipoPorta"
        Me.ComboBoxTipoPorta.Size = New System.Drawing.Size(109, 21)
        Me.ComboBoxTipoPorta.TabIndex = 6
        '
        'ComboBoxBit
        '
        Me.ComboBoxBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBit.Enabled = False
        Me.ComboBoxBit.FormattingEnabled = True
        Me.ComboBoxBit.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.ComboBoxBit.Location = New System.Drawing.Point(166, 3)
        Me.ComboBoxBit.Name = "ComboBoxBit"
        Me.ComboBoxBit.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxBit.TabIndex = 5
        '
        'Alarme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonApagar)
        Me.Controls.Add(Me.TextBoxMensagem)
        Me.Controls.Add(Me.TextBoxValor)
        Me.Controls.Add(Me.ComboBoxTipoAlarme)
        Me.Controls.Add(Me.ComboBoxBit)
        Me.Controls.Add(Me.ComboBoxPorta)
        Me.Controls.Add(Me.ComboBoxTipoPorta)
        Me.Name = "Alarme"
        Me.Size = New System.Drawing.Size(835, 27)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonApagar As Button
    Friend WithEvents TextBoxMensagem As TextBox
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents ComboBoxTipoAlarme As ComboBox
    Friend WithEvents ComboBoxPorta As ComboBox
    Friend WithEvents ComboBoxTipoPorta As ComboBox
    Friend WithEvents ComboBoxBit As ComboBox
End Class
