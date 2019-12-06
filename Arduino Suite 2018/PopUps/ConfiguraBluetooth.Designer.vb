<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguraBluetooth
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerComBlue = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxResponse = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBoxStatus = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.TextBoxPIN = New System.Windows.Forms.TextBox()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.PictureBoxName = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPIN = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimerEnviar = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxBluetooth = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(372, 314)
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
        Me.PictureBox1.Image = Global.ArduinoSuite.My.Resources.Resources.bluetooth
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Status:"
        '
        'TimerComBlue
        '
        Me.TimerComBlue.Interval = 850
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(372, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Procurar Módulo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxResponse
        '
        Me.TextBoxResponse.Location = New System.Drawing.Point(184, 53)
        Me.TextBoxResponse.Name = "TextBoxResponse"
        Me.TextBoxResponse.ReadOnly = True
        Me.TextBoxResponse.Size = New System.Drawing.Size(182, 20)
        Me.TextBoxResponse.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(184, 33)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(182, 20)
        Me.ProgressBar1.TabIndex = 0
        '
        'PictureBoxStatus
        '
        Me.PictureBoxStatus.Image = Global.ArduinoSuite.My.Resources.Resources.Disabled
        Me.PictureBoxStatus.Location = New System.Drawing.Point(75, 85)
        Me.PictureBoxStatus.Name = "PictureBoxStatus"
        Me.PictureBoxStatus.Size = New System.Drawing.Size(30, 30)
        Me.PictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxStatus.TabIndex = 6
        Me.PictureBoxStatus.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Novo Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Novo PIN:"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(95, 42)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(193, 20)
        Me.TextBoxNome.TabIndex = 2
        '
        'TextBoxPIN
        '
        Me.TextBoxPIN.Location = New System.Drawing.Point(95, 79)
        Me.TextBoxPIN.Name = "TextBoxPIN"
        Me.TextBoxPIN.Size = New System.Drawing.Size(193, 20)
        Me.TextBoxPIN.TabIndex = 3
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Location = New System.Drawing.Point(216, 116)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(71, 23)
        Me.ButtonEnviar.TabIndex = 4
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'PictureBoxName
        '
        Me.PictureBoxName.Image = Global.ArduinoSuite.My.Resources.Resources.Disabled
        Me.PictureBoxName.Location = New System.Drawing.Point(294, 42)
        Me.PictureBoxName.Name = "PictureBoxName"
        Me.PictureBoxName.Size = New System.Drawing.Size(16, 21)
        Me.PictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxName.TabIndex = 6
        Me.PictureBoxName.TabStop = False
        '
        'PictureBoxPIN
        '
        Me.PictureBoxPIN.Image = Global.ArduinoSuite.My.Resources.Resources.Disabled
        Me.PictureBoxPIN.Location = New System.Drawing.Point(294, 78)
        Me.PictureBoxPIN.Name = "PictureBoxPIN"
        Me.PictureBoxPIN.Size = New System.Drawing.Size(16, 21)
        Me.PictureBoxPIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPIN.TabIndex = 6
        Me.PictureBoxPIN.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Status:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonEnviar)
        Me.GroupBox1.Controls.Add(Me.TextBoxPIN)
        Me.GroupBox1.Controls.Add(Me.TextBoxNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBoxPIN)
        Me.GroupBox1.Controls.Add(Me.PictureBoxName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(39, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 158)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novas Configurações:"
        '
        'TimerEnviar
        '
        Me.TimerEnviar.Interval = 200
        '
        'TextBoxBluetooth
        '
        Me.TextBoxBluetooth.Location = New System.Drawing.Point(402, 132)
        Me.TextBoxBluetooth.Multiline = True
        Me.TextBoxBluetooth.Name = "TextBoxBluetooth"
        Me.TextBoxBluetooth.Size = New System.Drawing.Size(106, 158)
        Me.TextBoxBluetooth.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Resposta do Bluetooth:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(36, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(292, 35)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "OBS.: O código PIN deve ser um número de 4 dígitos, caso contrário a configuração" &
    " não será realizada."
        '
        'ConfiguraBluetooth
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(530, 355)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxBluetooth)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBoxStatus)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxResponse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfiguraBluetooth"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Bluetooth"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerComBlue As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxResponse As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBoxStatus As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents TextBoxPIN As TextBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents PictureBoxName As PictureBox
    Friend WithEvents PictureBoxPIN As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TimerEnviar As Timer
    Friend WithEvents TextBoxBluetooth As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
