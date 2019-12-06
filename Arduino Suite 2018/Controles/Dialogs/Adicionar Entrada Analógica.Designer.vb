<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adicionar_Entrada_Analógica
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxPortaVisivel = New System.Windows.Forms.CheckBox()
        Me.ComboBoxSelecionaPorta = New System.Windows.Forms.ComboBox()
        Me.TextBoxRotulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Escala = New System.Windows.Forms.GroupBox()
        Me.TextBoxMax = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit = New System.Windows.Forms.TextBox()
        Me.TextBoxMin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(97, 279)
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Imagem"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxPortaVisivel
        '
        Me.CheckBoxPortaVisivel.AutoSize = True
        Me.CheckBoxPortaVisivel.Location = New System.Drawing.Point(161, 12)
        Me.CheckBoxPortaVisivel.Name = "CheckBoxPortaVisivel"
        Me.CheckBoxPortaVisivel.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxPortaVisivel.TabIndex = 13
        Me.CheckBoxPortaVisivel.Text = "Visível"
        Me.CheckBoxPortaVisivel.UseVisualStyleBackColor = True
        '
        'ComboBoxSelecionaPorta
        '
        Me.ComboBoxSelecionaPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta.Location = New System.Drawing.Point(55, 12)
        Me.ComboBoxSelecionaPorta.Name = "ComboBoxSelecionaPorta"
        Me.ComboBoxSelecionaPorta.Size = New System.Drawing.Size(81, 21)
        Me.ComboBoxSelecionaPorta.TabIndex = 0
        '
        'TextBoxRotulo
        '
        Me.TextBoxRotulo.Location = New System.Drawing.Point(55, 39)
        Me.TextBoxRotulo.Name = "TextBoxRotulo"
        Me.TextBoxRotulo.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxRotulo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Porta:"
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(9, 42)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(41, 13)
        Me.LabelNome.TabIndex = 10
        Me.LabelNome.Text = "Rótulo:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(129, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Imagem (falha)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Image = Global.ArduinoSuite.My.Resources.Resources.SinalAnalógico_Falha
        Me.PictureBox2.Location = New System.Drawing.Point(129, 89)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.SinalAnalógico
        Me.PictureBox1.Location = New System.Drawing.Point(12, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Escala
        '
        Me.Escala.Controls.Add(Me.TextBoxMax)
        Me.Escala.Controls.Add(Me.TextBoxUnit)
        Me.Escala.Controls.Add(Me.TextBoxMin)
        Me.Escala.Controls.Add(Me.Label7)
        Me.Escala.Controls.Add(Me.Label3)
        Me.Escala.Controls.Add(Me.Label6)
        Me.Escala.Location = New System.Drawing.Point(12, 189)
        Me.Escala.Name = "Escala"
        Me.Escala.Size = New System.Drawing.Size(228, 84)
        Me.Escala.TabIndex = 16
        Me.Escala.TabStop = False
        Me.Escala.Text = "Escala"
        '
        'TextBoxMax
        '
        Me.TextBoxMax.Location = New System.Drawing.Point(149, 19)
        Me.TextBoxMax.Name = "TextBoxMax"
        Me.TextBoxMax.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxMax.TabIndex = 1
        '
        'TextBoxUnit
        '
        Me.TextBoxUnit.Location = New System.Drawing.Point(104, 51)
        Me.TextBoxUnit.Name = "TextBoxUnit"
        Me.TextBoxUnit.Size = New System.Drawing.Size(51, 20)
        Me.TextBoxUnit.TabIndex = 2
        '
        'TextBoxMin
        '
        Me.TextBoxMin.Location = New System.Drawing.Point(64, 19)
        Me.TextBoxMin.Name = "TextBoxMin"
        Me.TextBoxMin.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxMin.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Máx:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Min:"
        '
        'Adicionar_Entrada_Analógica
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(255, 320)
        Me.Controls.Add(Me.Escala)
        Me.Controls.Add(Me.CheckBoxPortaVisivel)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta)
        Me.Controls.Add(Me.TextBoxRotulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adicionar_Entrada_Analógica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Entrada Analógica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Escala.ResumeLayout(False)
        Me.Escala.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxPortaVisivel As CheckBox
    Friend WithEvents ComboBoxSelecionaPorta As ComboBox
    Friend WithEvents TextBoxRotulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelNome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Escala As GroupBox
    Friend WithEvents TextBoxMax As TextBox
    Friend WithEvents TextBoxMin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxUnit As TextBox
    Friend WithEvents Label3 As Label
End Class
