<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddGráfico
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Escala = New System.Windows.Forms.GroupBox()
        Me.TextBoxMax = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit = New System.Windows.Forms.TextBox()
        Me.TextBoxMin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxSelecionaPorta = New System.Windows.Forms.ComboBox()
        Me.TextBoxRotulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.CheckBoxPortaVisivel = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRotulo1 = New System.Windows.Forms.TextBox()
        Me.ComboBoxSelecionaPorta1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRotulo2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxSelecionaPorta2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Escala.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(148, 220)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Escala
        '
        Me.Escala.Controls.Add(Me.TextBoxMax)
        Me.Escala.Controls.Add(Me.CheckBoxPortaVisivel)
        Me.Escala.Controls.Add(Me.TextBoxUnit)
        Me.Escala.Controls.Add(Me.TextBoxMin)
        Me.Escala.Controls.Add(Me.Label7)
        Me.Escala.Controls.Add(Me.Label3)
        Me.Escala.Controls.Add(Me.Label6)
        Me.Escala.Location = New System.Drawing.Point(11, 118)
        Me.Escala.Name = "Escala"
        Me.Escala.Size = New System.Drawing.Size(283, 84)
        Me.Escala.TabIndex = 26
        Me.Escala.TabStop = False
        Me.Escala.Text = "Escala"
        '
        'TextBoxMax
        '
        Me.TextBoxMax.Location = New System.Drawing.Point(188, 19)
        Me.TextBoxMax.Name = "TextBoxMax"
        Me.TextBoxMax.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxMax.TabIndex = 16
        '
        'TextBoxUnit
        '
        Me.TextBoxUnit.Location = New System.Drawing.Point(143, 51)
        Me.TextBoxUnit.Name = "TextBoxUnit"
        Me.TextBoxUnit.Size = New System.Drawing.Size(51, 20)
        Me.TextBoxUnit.TabIndex = 16
        '
        'TextBoxMin
        '
        Me.TextBoxMin.Location = New System.Drawing.Point(103, 19)
        Me.TextBoxMin.Name = "TextBoxMin"
        Me.TextBoxMin.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxMin.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(156, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Máx:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Min:"
        '
        'ComboBoxSelecionaPorta
        '
        Me.ComboBoxSelecionaPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta.Location = New System.Drawing.Point(231, 33)
        Me.ComboBoxSelecionaPorta.Name = "ComboBoxSelecionaPorta"
        Me.ComboBoxSelecionaPorta.Size = New System.Drawing.Size(63, 21)
        Me.ComboBoxSelecionaPorta.TabIndex = 24
        '
        'TextBoxRotulo
        '
        Me.TextBoxRotulo.Location = New System.Drawing.Point(54, 34)
        Me.TextBoxRotulo.Name = "TextBoxRotulo"
        Me.TextBoxRotulo.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxRotulo.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Porta:"
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(51, 18)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(41, 13)
        Me.LabelNome.TabIndex = 22
        Me.LabelNome.Text = "Rótulo:"
        '
        'CheckBoxPortaVisivel
        '
        Me.CheckBoxPortaVisivel.AutoSize = True
        Me.CheckBoxPortaVisivel.Location = New System.Drawing.Point(6, 61)
        Me.CheckBoxPortaVisivel.Name = "CheckBoxPortaVisivel"
        Me.CheckBoxPortaVisivel.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxPortaVisivel.TabIndex = 25
        Me.CheckBoxPortaVisivel.Text = "Visível"
        Me.CheckBoxPortaVisivel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Pena 1"
        '
        'TextBoxRotulo1
        '
        Me.TextBoxRotulo1.Location = New System.Drawing.Point(54, 60)
        Me.TextBoxRotulo1.Name = "TextBoxRotulo1"
        Me.TextBoxRotulo1.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxRotulo1.TabIndex = 23
        '
        'ComboBoxSelecionaPorta1
        '
        Me.ComboBoxSelecionaPorta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta1.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta1.Location = New System.Drawing.Point(231, 59)
        Me.ComboBoxSelecionaPorta1.Name = "ComboBoxSelecionaPorta1"
        Me.ComboBoxSelecionaPorta1.Size = New System.Drawing.Size(63, 21)
        Me.ComboBoxSelecionaPorta1.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Pena 2"
        '
        'TextBoxRotulo2
        '
        Me.TextBoxRotulo2.Location = New System.Drawing.Point(54, 86)
        Me.TextBoxRotulo2.Name = "TextBoxRotulo2"
        Me.TextBoxRotulo2.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxRotulo2.TabIndex = 23
        '
        'ComboBoxSelecionaPorta2
        '
        Me.ComboBoxSelecionaPorta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta2.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta2.Location = New System.Drawing.Point(231, 85)
        Me.ComboBoxSelecionaPorta2.Name = "ComboBoxSelecionaPorta2"
        Me.ComboBoxSelecionaPorta2.Size = New System.Drawing.Size(63, 21)
        Me.ComboBoxSelecionaPorta2.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Pena 3"
        '
        'AddGráfico
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(306, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Escala)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta2)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta1)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta)
        Me.Controls.Add(Me.TextBoxRotulo2)
        Me.Controls.Add(Me.TextBoxRotulo1)
        Me.Controls.Add(Me.TextBoxRotulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddGráfico"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Gráfico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Escala.ResumeLayout(False)
        Me.Escala.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Escala As GroupBox
    Friend WithEvents TextBoxMax As TextBox
    Friend WithEvents TextBoxUnit As TextBox
    Friend WithEvents TextBoxMin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxSelecionaPorta As ComboBox
    Friend WithEvents TextBoxRotulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelNome As Label
    Friend WithEvents CheckBoxPortaVisivel As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRotulo1 As TextBox
    Friend WithEvents ComboBoxSelecionaPorta1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRotulo2 As TextBox
    Friend WithEvents ComboBoxSelecionaPorta2 As ComboBox
    Friend WithEvents Label5 As Label
End Class
