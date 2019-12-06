<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adicionar_Saída
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSelecionaPorta = New System.Windows.Forms.ComboBox()
        Me.LabelRotulo = New System.Windows.Forms.Label()
        Me.TextBoxRotulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBotao2 = New System.Windows.Forms.TextBox()
        Me.TextBoxBotao1 = New System.Windows.Forms.TextBox()
        Me.CheckBoxBotao2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBotao1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBoxSinalAtivo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSinalInativo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSinalFalha = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxTeclaAtalho = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxTeclaJoy = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TimerLeituraJoy = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonRet = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPushButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton2Bt = New System.Windows.Forms.RadioButton()
        Me.CheckBoxPortaVisivel = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxSinalAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSinalInativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSinalFalha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(265, 398)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Porta:"
        '
        'ComboBoxSelecionaPorta
        '
        Me.ComboBoxSelecionaPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta.Location = New System.Drawing.Point(67, 19)
        Me.ComboBoxSelecionaPorta.Name = "ComboBoxSelecionaPorta"
        Me.ComboBoxSelecionaPorta.Size = New System.Drawing.Size(86, 21)
        Me.ComboBoxSelecionaPorta.TabIndex = 0
        '
        'LabelRotulo
        '
        Me.LabelRotulo.AutoSize = True
        Me.LabelRotulo.Location = New System.Drawing.Point(20, 54)
        Me.LabelRotulo.Name = "LabelRotulo"
        Me.LabelRotulo.Size = New System.Drawing.Size(41, 13)
        Me.LabelRotulo.TabIndex = 4
        Me.LabelRotulo.Text = "Rótulo:"
        '
        'TextBoxRotulo
        '
        Me.TextBoxRotulo.Location = New System.Drawing.Point(67, 51)
        Me.TextBoxRotulo.Name = "TextBoxRotulo"
        Me.TextBoxRotulo.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxRotulo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxBotao2)
        Me.GroupBox1.Controls.Add(Me.TextBoxBotao1)
        Me.GroupBox1.Controls.Add(Me.CheckBoxBotao2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxBotao1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 114)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botões"
        '
        'TextBoxBotao2
        '
        Me.TextBoxBotao2.Location = New System.Drawing.Point(102, 64)
        Me.TextBoxBotao2.Name = "TextBoxBotao2"
        Me.TextBoxBotao2.Size = New System.Drawing.Size(48, 20)
        Me.TextBoxBotao2.TabIndex = 1
        Me.TextBoxBotao2.Text = "Desliga"
        '
        'TextBoxBotao1
        '
        Me.TextBoxBotao1.Location = New System.Drawing.Point(102, 30)
        Me.TextBoxBotao1.Name = "TextBoxBotao1"
        Me.TextBoxBotao1.Size = New System.Drawing.Size(48, 20)
        Me.TextBoxBotao1.TabIndex = 0
        Me.TextBoxBotao1.Text = "Liga"
        '
        'CheckBoxBotao2
        '
        Me.CheckBoxBotao2.AutoSize = True
        Me.CheckBoxBotao2.Location = New System.Drawing.Point(37, 66)
        Me.CheckBoxBotao2.Name = "CheckBoxBotao2"
        Me.CheckBoxBotao2.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxBotao2.TabIndex = 7
        Me.CheckBoxBotao2.Text = "Botão 2:"
        Me.CheckBoxBotao2.UseVisualStyleBackColor = True
        '
        'CheckBoxBotao1
        '
        Me.CheckBoxBotao1.AutoSize = True
        Me.CheckBoxBotao1.Location = New System.Drawing.Point(37, 32)
        Me.CheckBoxBotao1.Name = "CheckBoxBotao1"
        Me.CheckBoxBotao1.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxBotao1.TabIndex = 8
        Me.CheckBoxBotao1.Text = "Botão 1:"
        Me.CheckBoxBotao1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(158, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sinal Ativo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(23, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sinal Inativo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(289, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sinal em Falha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxSinalAtivo
        '
        Me.PictureBoxSinalAtivo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalAtivo.Image = Global.ArduinoSuite.My.Resources.Resources.LedOn
        Me.PictureBoxSinalAtivo.Location = New System.Drawing.Point(158, 223)
        Me.PictureBoxSinalAtivo.Name = "PictureBoxSinalAtivo"
        Me.PictureBoxSinalAtivo.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalAtivo.TabIndex = 10
        Me.PictureBoxSinalAtivo.TabStop = False
        '
        'PictureBoxSinalInativo
        '
        Me.PictureBoxSinalInativo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalInativo.Image = Global.ArduinoSuite.My.Resources.Resources.GreenLedOff
        Me.PictureBoxSinalInativo.Location = New System.Drawing.Point(23, 223)
        Me.PictureBoxSinalInativo.Name = "PictureBoxSinalInativo"
        Me.PictureBoxSinalInativo.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalInativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalInativo.TabIndex = 10
        Me.PictureBoxSinalInativo.TabStop = False
        '
        'PictureBoxSinalFalha
        '
        Me.PictureBoxSinalFalha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalFalha.Image = Global.ArduinoSuite.My.Resources.Resources.LedOff
        Me.PictureBoxSinalFalha.Location = New System.Drawing.Point(289, 223)
        Me.PictureBoxSinalFalha.Name = "PictureBoxSinalFalha"
        Me.PictureBoxSinalFalha.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalFalha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalFalha.TabIndex = 10
        Me.PictureBoxSinalFalha.TabStop = False
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tecla de Atalho:"
        '
        'TextBoxTeclaAtalho
        '
        Me.TextBoxTeclaAtalho.Location = New System.Drawing.Point(115, 362)
        Me.TextBoxTeclaAtalho.Name = "TextBoxTeclaAtalho"
        Me.TextBoxTeclaAtalho.ReadOnly = True
        Me.TextBoxTeclaAtalho.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxTeclaAtalho.TabIndex = 12
        Me.TextBoxTeclaAtalho.Text = "Nenhuma"
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tecla de Atalho:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.Teclado
        Me.PictureBox1.Location = New System.Drawing.Point(122, 321)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'TextBoxTeclaJoy
        '
        Me.TextBoxTeclaJoy.Location = New System.Drawing.Point(312, 363)
        Me.TextBoxTeclaJoy.Name = "TextBoxTeclaJoy"
        Me.TextBoxTeclaJoy.ReadOnly = True
        Me.TextBoxTeclaJoy.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxTeclaJoy.TabIndex = 12
        Me.TextBoxTeclaJoy.Text = "Nenhuma"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ArduinoSuite.My.Resources.Resources.xOneController
        Me.PictureBox2.Location = New System.Drawing.Point(319, 337)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'TimerLeituraJoy
        '
        Me.TimerLeituraJoy.Interval = 250
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonRet)
        Me.GroupBox3.Controls.Add(Me.RadioButtonPushButton)
        Me.GroupBox3.Controls.Add(Me.RadioButton2Bt)
        Me.GroupBox3.Location = New System.Drawing.Point(228, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 114)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Funcionamento Botão:"
        '
        'RadioButtonRet
        '
        Me.RadioButtonRet.AutoSize = True
        Me.RadioButtonRet.Location = New System.Drawing.Point(37, 78)
        Me.RadioButtonRet.Name = "RadioButtonRet"
        Me.RadioButtonRet.Size = New System.Drawing.Size(91, 17)
        Me.RadioButtonRet.TabIndex = 2
        Me.RadioButtonRet.TabStop = True
        Me.RadioButtonRet.Text = "Com retenção"
        Me.RadioButtonRet.UseVisualStyleBackColor = True
        '
        'RadioButtonPushButton
        '
        Me.RadioButtonPushButton.AutoSize = True
        Me.RadioButtonPushButton.Location = New System.Drawing.Point(37, 54)
        Me.RadioButtonPushButton.Name = "RadioButtonPushButton"
        Me.RadioButtonPushButton.Size = New System.Drawing.Size(83, 17)
        Me.RadioButtonPushButton.TabIndex = 1
        Me.RadioButtonPushButton.TabStop = True
        Me.RadioButtonPushButton.Text = "Push-Button"
        Me.RadioButtonPushButton.UseVisualStyleBackColor = True
        '
        'RadioButton2Bt
        '
        Me.RadioButton2Bt.AutoSize = True
        Me.RadioButton2Bt.Location = New System.Drawing.Point(37, 30)
        Me.RadioButton2Bt.Name = "RadioButton2Bt"
        Me.RadioButton2Bt.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton2Bt.TabIndex = 0
        Me.RadioButton2Bt.TabStop = True
        Me.RadioButton2Bt.Text = "2  Botões"
        Me.RadioButton2Bt.UseVisualStyleBackColor = True
        '
        'CheckBoxPortaVisivel
        '
        Me.CheckBoxPortaVisivel.AutoSize = True
        Me.CheckBoxPortaVisivel.Checked = True
        Me.CheckBoxPortaVisivel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPortaVisivel.Location = New System.Drawing.Point(116, 389)
        Me.CheckBoxPortaVisivel.Name = "CheckBoxPortaVisivel"
        Me.CheckBoxPortaVisivel.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxPortaVisivel.TabIndex = 16
        Me.CheckBoxPortaVisivel.Text = "Visível"
        Me.CheckBoxPortaVisivel.UseVisualStyleBackColor = True
        '
        'Adicionar_Saída
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(423, 439)
        Me.Controls.Add(Me.CheckBoxPortaVisivel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBoxTeclaJoy)
        Me.Controls.Add(Me.TextBoxTeclaAtalho)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBoxSinalFalha)
        Me.Controls.Add(Me.PictureBoxSinalInativo)
        Me.Controls.Add(Me.PictureBoxSinalAtivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxRotulo)
        Me.Controls.Add(Me.LabelRotulo)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adicionar_Saída"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Valor:"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxSinalAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSinalInativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSinalFalha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxSelecionaPorta As ComboBox
    Friend WithEvents LabelRotulo As Label
    Friend WithEvents TextBoxRotulo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBoxSinalAtivo As PictureBox
    Friend WithEvents PictureBoxSinalInativo As PictureBox
    Friend WithEvents PictureBoxSinalFalha As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxTeclaAtalho As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxTeclaJoy As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TimerLeituraJoy As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonRet As RadioButton
    Friend WithEvents RadioButtonPushButton As RadioButton
    Friend WithEvents RadioButton2Bt As RadioButton
    Friend WithEvents TextBoxBotao2 As TextBox
    Friend WithEvents TextBoxBotao1 As TextBox
    Friend WithEvents CheckBoxBotao2 As CheckBox
    Friend WithEvents CheckBoxBotao1 As CheckBox
    Friend WithEvents CheckBoxPortaVisivel As CheckBox
End Class
