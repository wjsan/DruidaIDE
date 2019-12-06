<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRegBit
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PictureBoxSinalFalha = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSinalInativo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSinalAtivo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxPortaVisivel = New System.Windows.Forms.CheckBox()
        Me.TextBoxRotulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTeclaJoy = New System.Windows.Forms.TextBox()
        Me.TextBoxTeclaAtalho = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TimerLeituraJoy = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBoxSelecionaPorta = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSelecionaBit = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBoxSinalFalha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSinalInativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSinalAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(245, 279)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 5
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
        'PictureBoxSinalFalha
        '
        Me.PictureBoxSinalFalha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalFalha.Image = Global.ArduinoSuite.My.Resources.Resources.LedOff
        Me.PictureBoxSinalFalha.Location = New System.Drawing.Point(279, 88)
        Me.PictureBoxSinalFalha.Name = "PictureBoxSinalFalha"
        Me.PictureBoxSinalFalha.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalFalha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalFalha.TabIndex = 25
        Me.PictureBoxSinalFalha.TabStop = False
        '
        'PictureBoxSinalInativo
        '
        Me.PictureBoxSinalInativo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalInativo.Image = Global.ArduinoSuite.My.Resources.Resources.GreenLedOff
        Me.PictureBoxSinalInativo.Location = New System.Drawing.Point(13, 88)
        Me.PictureBoxSinalInativo.Name = "PictureBoxSinalInativo"
        Me.PictureBoxSinalInativo.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalInativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalInativo.TabIndex = 26
        Me.PictureBoxSinalInativo.TabStop = False
        '
        'PictureBoxSinalAtivo
        '
        Me.PictureBoxSinalAtivo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalAtivo.Image = Global.ArduinoSuite.My.Resources.Resources.LedOn
        Me.PictureBoxSinalAtivo.Location = New System.Drawing.Point(148, 88)
        Me.PictureBoxSinalAtivo.Name = "PictureBoxSinalAtivo"
        Me.PictureBoxSinalAtivo.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalAtivo.TabIndex = 27
        Me.PictureBoxSinalAtivo.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(279, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Sinal em Falha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(13, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Sinal Inativo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(148, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Sinal Ativo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxPortaVisivel
        '
        Me.CheckBoxPortaVisivel.AutoSize = True
        Me.CheckBoxPortaVisivel.Location = New System.Drawing.Point(330, 12)
        Me.CheckBoxPortaVisivel.Name = "CheckBoxPortaVisivel"
        Me.CheckBoxPortaVisivel.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxPortaVisivel.TabIndex = 21
        Me.CheckBoxPortaVisivel.Text = "Visível"
        Me.CheckBoxPortaVisivel.UseVisualStyleBackColor = True
        '
        'TextBoxRotulo
        '
        Me.TextBoxRotulo.Location = New System.Drawing.Point(100, 38)
        Me.TextBoxRotulo.Name = "TextBoxRotulo"
        Me.TextBoxRotulo.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxRotulo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Registrador:"
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(33, 41)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(41, 13)
        Me.LabelNome.TabIndex = 18
        Me.LabelNome.Text = "Rótulo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bit:"
        '
        'TextBoxTeclaJoy
        '
        Me.TextBoxTeclaJoy.Location = New System.Drawing.Point(308, 239)
        Me.TextBoxTeclaJoy.Name = "TextBoxTeclaJoy"
        Me.TextBoxTeclaJoy.ReadOnly = True
        Me.TextBoxTeclaJoy.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxTeclaJoy.TabIndex = 4
        Me.TextBoxTeclaJoy.Text = "Nenhuma"
        '
        'TextBoxTeclaAtalho
        '
        Me.TextBoxTeclaAtalho.Location = New System.Drawing.Point(111, 238)
        Me.TextBoxTeclaAtalho.Name = "TextBoxTeclaAtalho"
        Me.TextBoxTeclaAtalho.ReadOnly = True
        Me.TextBoxTeclaAtalho.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxTeclaAtalho.TabIndex = 3
        Me.TextBoxTeclaAtalho.Text = "Nenhuma"
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(221, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Tecla de Atalho:"
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Tecla de Atalho:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.Teclado
        Me.PictureBox1.Location = New System.Drawing.Point(118, 197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ArduinoSuite.My.Resources.Resources.xOneController
        Me.PictureBox2.Location = New System.Drawing.Point(315, 213)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'TimerLeituraJoy
        '
        Me.TimerLeituraJoy.Interval = 250
        '
        'ComboBoxSelecionaPorta
        '
        Me.ComboBoxSelecionaPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta.Location = New System.Drawing.Point(100, 10)
        Me.ComboBoxSelecionaPorta.Name = "ComboBoxSelecionaPorta"
        Me.ComboBoxSelecionaPorta.Size = New System.Drawing.Size(96, 21)
        Me.ComboBoxSelecionaPorta.TabIndex = 0
        '
        'ComboBoxSelecionaBit
        '
        Me.ComboBoxSelecionaBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaBit.FormattingEnabled = True
        Me.ComboBoxSelecionaBit.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.ComboBoxSelecionaBit.Location = New System.Drawing.Point(219, 10)
        Me.ComboBoxSelecionaBit.Name = "ComboBoxSelecionaBit"
        Me.ComboBoxSelecionaBit.Size = New System.Drawing.Size(96, 21)
        Me.ComboBoxSelecionaBit.TabIndex = 1
        '
        'AddRegBit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(403, 320)
        Me.Controls.Add(Me.ComboBoxSelecionaBit)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta)
        Me.Controls.Add(Me.TextBoxTeclaJoy)
        Me.Controls.Add(Me.TextBoxTeclaAtalho)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBoxSinalFalha)
        Me.Controls.Add(Me.PictureBoxSinalInativo)
        Me.Controls.Add(Me.PictureBoxSinalAtivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBoxPortaVisivel)
        Me.Controls.Add(Me.TextBoxRotulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddRegBit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Acionamento Registrador - 1 Bit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBoxSinalFalha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSinalInativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSinalAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBoxSinalFalha As PictureBox
    Friend WithEvents PictureBoxSinalInativo As PictureBox
    Friend WithEvents PictureBoxSinalAtivo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxPortaVisivel As CheckBox
    Friend WithEvents TextBoxRotulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelNome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTeclaJoy As TextBox
    Friend WithEvents TextBoxTeclaAtalho As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TimerLeituraJoy As Timer
    Friend WithEvents ComboBoxSelecionaPorta As ComboBox
    Friend WithEvents ComboBoxSelecionaBit As ComboBox
End Class
