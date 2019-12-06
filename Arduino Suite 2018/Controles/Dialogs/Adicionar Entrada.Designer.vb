<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adicionar_Entrada
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
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.TextBoxRotulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSelecionaPorta = New System.Windows.Forms.ComboBox()
        Me.CheckBoxPortaVisivel = New System.Windows.Forms.CheckBox()
        Me.ToolTipInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBoxSinalFalha = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSinalInativo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSinalAtivo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBoxSinalFalha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSinalInativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSinalAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(248, 200)
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
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(30, 45)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(41, 13)
        Me.LabelNome.TabIndex = 1
        Me.LabelNome.Text = "Rótulo:"
        '
        'TextBoxRotulo
        '
        Me.TextBoxRotulo.Location = New System.Drawing.Point(76, 42)
        Me.TextBoxRotulo.Name = "TextBoxRotulo"
        Me.TextBoxRotulo.Size = New System.Drawing.Size(171, 20)
        Me.TextBoxRotulo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Porta:"
        '
        'ComboBoxSelecionaPorta
        '
        Me.ComboBoxSelecionaPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSelecionaPorta.FormattingEnabled = True
        Me.ComboBoxSelecionaPorta.Location = New System.Drawing.Point(76, 15)
        Me.ComboBoxSelecionaPorta.Name = "ComboBoxSelecionaPorta"
        Me.ComboBoxSelecionaPorta.Size = New System.Drawing.Size(81, 21)
        Me.ComboBoxSelecionaPorta.TabIndex = 0
        '
        'CheckBoxPortaVisivel
        '
        Me.CheckBoxPortaVisivel.AutoSize = True
        Me.CheckBoxPortaVisivel.Location = New System.Drawing.Point(182, 15)
        Me.CheckBoxPortaVisivel.Name = "CheckBoxPortaVisivel"
        Me.CheckBoxPortaVisivel.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxPortaVisivel.TabIndex = 7
        Me.CheckBoxPortaVisivel.Text = "Visível"
        Me.ToolTipInfo.SetToolTip(Me.CheckBoxPortaVisivel, "Define se a informação da porta será visível ao apontar controle com o mouse")
        Me.CheckBoxPortaVisivel.UseVisualStyleBackColor = True
        '
        'PictureBoxSinalFalha
        '
        Me.PictureBoxSinalFalha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalFalha.Image = Global.ArduinoSuite.My.Resources.Resources.LedOff
        Me.PictureBoxSinalFalha.Location = New System.Drawing.Point(276, 96)
        Me.PictureBoxSinalFalha.Name = "PictureBoxSinalFalha"
        Me.PictureBoxSinalFalha.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalFalha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalFalha.TabIndex = 14
        Me.PictureBoxSinalFalha.TabStop = False
        '
        'PictureBoxSinalInativo
        '
        Me.PictureBoxSinalInativo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalInativo.Image = Global.ArduinoSuite.My.Resources.Resources.GreenLedOff
        Me.PictureBoxSinalInativo.Location = New System.Drawing.Point(10, 96)
        Me.PictureBoxSinalInativo.Name = "PictureBoxSinalInativo"
        Me.PictureBoxSinalInativo.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalInativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalInativo.TabIndex = 15
        Me.PictureBoxSinalInativo.TabStop = False
        '
        'PictureBoxSinalAtivo
        '
        Me.PictureBoxSinalAtivo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxSinalAtivo.Image = Global.ArduinoSuite.My.Resources.Resources.LedOn
        Me.PictureBoxSinalAtivo.Location = New System.Drawing.Point(145, 96)
        Me.PictureBoxSinalAtivo.Name = "PictureBoxSinalAtivo"
        Me.PictureBoxSinalAtivo.Size = New System.Drawing.Size(111, 94)
        Me.PictureBoxSinalAtivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSinalAtivo.TabIndex = 16
        Me.PictureBoxSinalAtivo.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(276, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sinal em Falha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(10, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sinal Inativo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(145, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Sinal Ativo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Adicionar_Entrada
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(406, 241)
        Me.Controls.Add(Me.PictureBoxSinalFalha)
        Me.Controls.Add(Me.PictureBoxSinalInativo)
        Me.Controls.Add(Me.PictureBoxSinalAtivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBoxPortaVisivel)
        Me.Controls.Add(Me.ComboBoxSelecionaPorta)
        Me.Controls.Add(Me.TextBoxRotulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelNome)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adicionar_Entrada"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Entrada"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBoxSinalFalha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSinalInativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSinalAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LabelNome As Label
    Friend WithEvents TextBoxRotulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSelecionaPorta As ComboBox
    Friend WithEvents CheckBoxPortaVisivel As CheckBox
    Friend WithEvents ToolTipInfo As ToolTip
    Friend WithEvents PictureBoxSinalFalha As PictureBox
    Friend WithEvents PictureBoxSinalInativo As PictureBox
    Friend WithEvents PictureBoxSinalAtivo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
