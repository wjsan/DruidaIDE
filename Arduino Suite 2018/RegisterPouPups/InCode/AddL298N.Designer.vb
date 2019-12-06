<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddL298N
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx1 = New System.Windows.Forms.TextBox()
        Me.tx2 = New System.Windows.Forms.TextBox()
        Me.tx3 = New System.Windows.Forms.TextBox()
        Me.tx4 = New System.Windows.Forms.TextBox()
        Me.tx5 = New System.Windows.Forms.TextBox()
        Me.tx6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDescricao = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(356, 505)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.l298n
        Me.PictureBox1.Location = New System.Drawing.Point(84, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 348)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "pwOutA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "pwOutB"
        '
        'tx1
        '
        Me.tx1.Location = New System.Drawing.Point(256, 471)
        Me.tx1.Name = "tx1"
        Me.tx1.Size = New System.Drawing.Size(21, 20)
        Me.tx1.TabIndex = 2
        '
        'tx2
        '
        Me.tx2.Location = New System.Drawing.Point(276, 471)
        Me.tx2.Name = "tx2"
        Me.tx2.Size = New System.Drawing.Size(21, 20)
        Me.tx2.TabIndex = 3
        '
        'tx3
        '
        Me.tx3.Location = New System.Drawing.Point(296, 471)
        Me.tx3.Name = "tx3"
        Me.tx3.Size = New System.Drawing.Size(21, 20)
        Me.tx3.TabIndex = 4
        '
        'tx4
        '
        Me.tx4.Location = New System.Drawing.Point(316, 471)
        Me.tx4.Name = "tx4"
        Me.tx4.Size = New System.Drawing.Size(21, 20)
        Me.tx4.TabIndex = 5
        '
        'tx5
        '
        Me.tx5.Location = New System.Drawing.Point(336, 471)
        Me.tx5.Name = "tx5"
        Me.tx5.Size = New System.Drawing.Size(21, 20)
        Me.tx5.TabIndex = 6
        '
        'tx6
        '
        Me.tx6.Location = New System.Drawing.Point(356, 471)
        Me.tx6.Name = "tx6"
        Me.tx6.Size = New System.Drawing.Size(21, 20)
        Me.tx6.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome:"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(180, 16)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxNome.TabIndex = 0
        Me.TextBoxNome.Text = "PonteH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pinos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descrição:"
        '
        'TextBoxDescricao
        '
        Me.TextBoxDescricao.Location = New System.Drawing.Point(180, 46)
        Me.TextBoxDescricao.Multiline = True
        Me.TextBoxDescricao.Name = "TextBoxDescricao"
        Me.TextBoxDescricao.Size = New System.Drawing.Size(177, 53)
        Me.TextBoxDescricao.TabIndex = 1
        '
        'AddL298N
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(514, 546)
        Me.Controls.Add(Me.TextBoxDescricao)
        Me.Controls.Add(Me.TextBoxNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tx6)
        Me.Controls.Add(Me.tx5)
        Me.Controls.Add(Me.tx4)
        Me.Controls.Add(Me.tx3)
        Me.Controls.Add(Me.tx2)
        Me.Controls.Add(Me.tx1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddL298N"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Drive"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tx1 As TextBox
    Friend WithEvents tx2 As TextBox
    Friend WithEvents tx3 As TextBox
    Friend WithEvents tx4 As TextBox
    Friend WithEvents tx5 As TextBox
    Friend WithEvents tx6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDescricao As TextBox
End Class
