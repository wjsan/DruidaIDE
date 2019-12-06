<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCameraIP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxURL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxSenha = New System.Windows.Forms.TextBox()
        Me.VideoSourcePlayer1 = New AForge.Controls.VideoSourcePlayer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRótulo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonGirar = New System.Windows.Forms.Button()
        Me.ButtonInvertX = New System.Windows.Forms.Button()
        Me.ButtonInvertY = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(338, 393)
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
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Url:"
        '
        'TextBoxURL
        '
        Me.TextBoxURL.Location = New System.Drawing.Point(59, 36)
        Me.TextBoxURL.Name = "TextBoxURL"
        Me.TextBoxURL.Size = New System.Drawing.Size(314, 20)
        Me.TextBoxURL.TabIndex = 2
        Me.TextBoxURL.Text = "http://"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Senha:"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(59, 59)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(314, 20)
        Me.TextBoxUsuario.TabIndex = 2
        Me.TextBoxUsuario.Text = "admin"
        '
        'TextBoxSenha
        '
        Me.TextBoxSenha.Location = New System.Drawing.Point(59, 82)
        Me.TextBoxSenha.Name = "TextBoxSenha"
        Me.TextBoxSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxSenha.Size = New System.Drawing.Size(314, 20)
        Me.TextBoxSenha.TabIndex = 2
        Me.TextBoxSenha.Text = "admin"
        '
        'VideoSourcePlayer1
        '
        Me.VideoSourcePlayer1.Location = New System.Drawing.Point(59, 117)
        Me.VideoSourcePlayer1.Name = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.Size = New System.Drawing.Size(377, 254)
        Me.VideoSourcePlayer1.TabIndex = 3
        Me.VideoSourcePlayer1.Text = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.VideoSource = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Testar Streaming"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Rótulo:"
        '
        'TextBoxRótulo
        '
        Me.TextBoxRótulo.Location = New System.Drawing.Point(59, 12)
        Me.TextBoxRótulo.Name = "TextBoxRótulo"
        Me.TextBoxRótulo.Size = New System.Drawing.Size(314, 20)
        Me.TextBoxRótulo.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(394, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Parar Streaming"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonGirar
        '
        Me.ButtonGirar.Location = New System.Drawing.Point(59, 393)
        Me.ButtonGirar.Name = "ButtonGirar"
        Me.ButtonGirar.Size = New System.Drawing.Size(74, 23)
        Me.ButtonGirar.TabIndex = 6
        Me.ButtonGirar.Text = "Girar"
        Me.ButtonGirar.UseVisualStyleBackColor = True
        '
        'ButtonInvertX
        '
        Me.ButtonInvertX.Location = New System.Drawing.Point(139, 393)
        Me.ButtonInvertX.Name = "ButtonInvertX"
        Me.ButtonInvertX.Size = New System.Drawing.Size(74, 23)
        Me.ButtonInvertX.TabIndex = 6
        Me.ButtonInvertX.Text = "Inverter (X)"
        Me.ButtonInvertX.UseVisualStyleBackColor = True
        '
        'ButtonInvertY
        '
        Me.ButtonInvertY.Location = New System.Drawing.Point(219, 393)
        Me.ButtonInvertY.Name = "ButtonInvertY"
        Me.ButtonInvertY.Size = New System.Drawing.Size(74, 23)
        Me.ButtonInvertY.TabIndex = 6
        Me.ButtonInvertY.Text = "Inverter (Y)"
        Me.ButtonInvertY.UseVisualStyleBackColor = True
        '
        'AddCameraIP
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(496, 434)
        Me.Controls.Add(Me.ButtonInvertY)
        Me.Controls.Add(Me.ButtonInvertX)
        Me.Controls.Add(Me.ButtonGirar)
        Me.Controls.Add(Me.TextBoxRótulo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VideoSourcePlayer1)
        Me.Controls.Add(Me.TextBoxSenha)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.TextBoxURL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddCameraIP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Câmera"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxURL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxSenha As TextBox
    Friend WithEvents VideoSourcePlayer1 As AForge.Controls.VideoSourcePlayer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRótulo As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonGirar As Button
    Friend WithEvents ButtonInvertX As Button
    Friend WithEvents ButtonInvertY As Button
End Class
