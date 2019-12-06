<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuInterativo
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.TimerShowAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.ItemMenuInterativoComando = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoLogon = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoNovo = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoConect = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoPair = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoIrParaWindows = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoSalvar = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoAbrir = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoSair = New ArduinoSuite.ItemMenuInterativo()
        Me.ItemMenuInterativoSelecionaPorta = New ArduinoSuite.ItemMenuInterativo()
        Me.SuspendLayout()
        '
        'TimerShowAnimation
        '
        Me.TimerShowAnimation.Interval = 1
        '
        'ItemMenuInterativoComando
        '
        Me.ItemMenuInterativoComando.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoComando.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoComando.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoComando.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoComando.Location = New System.Drawing.Point(3, 167)
        Me.ItemMenuInterativoComando.Name = "ItemMenuInterativoComando"
        Me.ItemMenuInterativoComando.NomeItem = "Telas de Comando"
        Me.ItemMenuInterativoComando.PictureItem = Global.ArduinoSuite.My.Resources.Resources.Screen
        Me.ItemMenuInterativoComando.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoComando.TabIndex = 3
        '
        'ItemMenuInterativoLogon
        '
        Me.ItemMenuInterativoLogon.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoLogon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoLogon.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoLogon.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoLogon.Location = New System.Drawing.Point(3, 331)
        Me.ItemMenuInterativoLogon.Name = "ItemMenuInterativoLogon"
        Me.ItemMenuInterativoLogon.NomeItem = "Opções de Usuário"
        Me.ItemMenuInterativoLogon.PictureItem = Global.ArduinoSuite.My.Resources.Resources.lock
        Me.ItemMenuInterativoLogon.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoLogon.TabIndex = 2
        '
        'ItemMenuInterativoNovo
        '
        Me.ItemMenuInterativoNovo.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoNovo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoNovo.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoNovo.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoNovo.Location = New System.Drawing.Point(3, 44)
        Me.ItemMenuInterativoNovo.Name = "ItemMenuInterativoNovo"
        Me.ItemMenuInterativoNovo.NomeItem = "Nova Aplicação"
        Me.ItemMenuInterativoNovo.PictureItem = Global.ArduinoSuite.My.Resources.Resources.Novo
        Me.ItemMenuInterativoNovo.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoNovo.TabIndex = 1
        '
        'ItemMenuInterativoConect
        '
        Me.ItemMenuInterativoConect.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoConect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoConect.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoConect.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoConect.Location = New System.Drawing.Point(3, 249)
        Me.ItemMenuInterativoConect.Name = "ItemMenuInterativoConect"
        Me.ItemMenuInterativoConect.NomeItem = "Conectar/Desconectar"
        Me.ItemMenuInterativoConect.PictureItem = Global.ArduinoSuite.My.Resources.Resources.spm_icon_256
        Me.ItemMenuInterativoConect.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoConect.TabIndex = 1
        '
        'ItemMenuInterativoPair
        '
        Me.ItemMenuInterativoPair.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoPair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoPair.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoPair.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoPair.Location = New System.Drawing.Point(3, 290)
        Me.ItemMenuInterativoPair.Name = "ItemMenuInterativoPair"
        Me.ItemMenuInterativoPair.NomeItem = "Parear com Bluetooth"
        Me.ItemMenuInterativoPair.PictureItem = Global.ArduinoSuite.My.Resources.Resources.bluetooth
        Me.ItemMenuInterativoPair.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoPair.TabIndex = 1
        '
        'ItemMenuInterativoIrParaWindows
        '
        Me.ItemMenuInterativoIrParaWindows.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoIrParaWindows.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoIrParaWindows.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoIrParaWindows.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoIrParaWindows.Location = New System.Drawing.Point(3, 3)
        Me.ItemMenuInterativoIrParaWindows.Name = "ItemMenuInterativoIrParaWindows"
        Me.ItemMenuInterativoIrParaWindows.NomeItem = "Voltar para o Windows"
        Me.ItemMenuInterativoIrParaWindows.PictureItem = Global.ArduinoSuite.My.Resources.Resources.WindowsLogo
        Me.ItemMenuInterativoIrParaWindows.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoIrParaWindows.TabIndex = 1
        '
        'ItemMenuInterativoSalvar
        '
        Me.ItemMenuInterativoSalvar.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoSalvar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoSalvar.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoSalvar.Location = New System.Drawing.Point(3, 126)
        Me.ItemMenuInterativoSalvar.Name = "ItemMenuInterativoSalvar"
        Me.ItemMenuInterativoSalvar.NomeItem = "Salvar Aplicação"
        Me.ItemMenuInterativoSalvar.PictureItem = Global.ArduinoSuite.My.Resources.Resources.Salvar
        Me.ItemMenuInterativoSalvar.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoSalvar.TabIndex = 1
        '
        'ItemMenuInterativoAbrir
        '
        Me.ItemMenuInterativoAbrir.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoAbrir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoAbrir.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoAbrir.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoAbrir.Location = New System.Drawing.Point(3, 85)
        Me.ItemMenuInterativoAbrir.Name = "ItemMenuInterativoAbrir"
        Me.ItemMenuInterativoAbrir.NomeItem = "Abrir Aplicação"
        Me.ItemMenuInterativoAbrir.PictureItem = Global.ArduinoSuite.My.Resources.Resources.Abrir
        Me.ItemMenuInterativoAbrir.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoAbrir.TabIndex = 1
        '
        'ItemMenuInterativoSair
        '
        Me.ItemMenuInterativoSair.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoSair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoSair.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoSair.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoSair.Location = New System.Drawing.Point(3, 372)
        Me.ItemMenuInterativoSair.Name = "ItemMenuInterativoSair"
        Me.ItemMenuInterativoSair.NomeItem = "Sair da Aplicação"
        Me.ItemMenuInterativoSair.PictureItem = Global.ArduinoSuite.My.Resources.Resources._2013_06_13_televizija_na_off_16377
        Me.ItemMenuInterativoSair.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoSair.TabIndex = 0
        '
        'ItemMenuInterativoSelecionaPorta
        '
        Me.ItemMenuInterativoSelecionaPorta.ActivateColor = System.Drawing.Color.Blue
        Me.ItemMenuInterativoSelecionaPorta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemMenuInterativoSelecionaPorta.BackColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoSelecionaPorta.BarColor = System.Drawing.SystemColors.Control
        Me.ItemMenuInterativoSelecionaPorta.Location = New System.Drawing.Point(3, 208)
        Me.ItemMenuInterativoSelecionaPorta.Name = "ItemMenuInterativoSelecionaPorta"
        Me.ItemMenuInterativoSelecionaPorta.NomeItem = "Selecionar Porta"
        Me.ItemMenuInterativoSelecionaPorta.PictureItem = Global.ArduinoSuite.My.Resources.Resources.Porta_Aberta
        Me.ItemMenuInterativoSelecionaPorta.Size = New System.Drawing.Size(204, 38)
        Me.ItemMenuInterativoSelecionaPorta.TabIndex = 1
        '
        'MenuInterativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.ItemMenuInterativoComando)
        Me.Controls.Add(Me.ItemMenuInterativoLogon)
        Me.Controls.Add(Me.ItemMenuInterativoNovo)
        Me.Controls.Add(Me.ItemMenuInterativoConect)
        Me.Controls.Add(Me.ItemMenuInterativoPair)
        Me.Controls.Add(Me.ItemMenuInterativoIrParaWindows)
        Me.Controls.Add(Me.ItemMenuInterativoSalvar)
        Me.Controls.Add(Me.ItemMenuInterativoAbrir)
        Me.Controls.Add(Me.ItemMenuInterativoSair)
        Me.Controls.Add(Me.ItemMenuInterativoSelecionaPorta)
        Me.Name = "MenuInterativo"
        Me.Size = New System.Drawing.Size(211, 413)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ItemMenuInterativoSair As ItemMenuInterativo
    Friend WithEvents TimerShowAnimation As Timer
    Friend WithEvents ItemMenuInterativoLogon As ItemMenuInterativo
    Friend WithEvents ItemMenuInterativoAbrir As ItemMenuInterativo
    Friend WithEvents ItemMenuInterativoSalvar As ItemMenuInterativo
    Friend WithEvents ItemMenuInterativoIrParaWindows As ItemMenuInterativo
    Protected Friend WithEvents ItemMenuInterativoConect As ItemMenuInterativo
    Protected Friend WithEvents ItemMenuInterativoSelecionaPorta As ItemMenuInterativo
    Protected Friend WithEvents ItemMenuInterativoNovo As ItemMenuInterativo
    Friend WithEvents ItemMenuInterativoPair As ItemMenuInterativo
    Friend WithEvents ItemMenuInterativoComando As ItemMenuInterativo
End Class
