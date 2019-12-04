<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProject))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCreateFolder = New System.Windows.Forms.CheckBox()
        Me.tbDirectory = New System.Windows.Forms.TextBox()
        Me.btFind = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btCreateProject = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.ToolTipInformacoes = New System.Windows.Forms.ToolTip(Me.components)
        Me.btOpen = New System.Windows.Forms.Button()
        Me.ToolTipErro = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCreateFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 57)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opções:"
        '
        'cbCreateFolder
        '
        Me.cbCreateFolder.AutoSize = True
        Me.cbCreateFolder.Checked = True
        Me.cbCreateFolder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateFolder.Location = New System.Drawing.Point(30, 23)
        Me.cbCreateFolder.Name = "cbCreateFolder"
        Me.cbCreateFolder.Size = New System.Drawing.Size(232, 17)
        Me.cbCreateFolder.TabIndex = 0
        Me.cbCreateFolder.Text = "Criar Nova Pasta com o nome da Aplicação"
        Me.cbCreateFolder.UseVisualStyleBackColor = True
        '
        'tbDirectory
        '
        Me.tbDirectory.Location = New System.Drawing.Point(282, 50)
        Me.tbDirectory.Name = "tbDirectory"
        Me.tbDirectory.Size = New System.Drawing.Size(238, 20)
        Me.tbDirectory.TabIndex = 6
        '
        'btFind
        '
        Me.btFind.Location = New System.Drawing.Point(526, 48)
        Me.btFind.Name = "btFind"
        Me.btFind.Size = New System.Drawing.Size(75, 23)
        Me.btFind.TabIndex = 14
        Me.btFind.Text = "Procurar"
        Me.btFind.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 211)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bem vindo ao Druida"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pasta:"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(282, 23)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(238, 20)
        Me.tbName.TabIndex = 5
        Me.tbName.Text = "NovoProjeto"
        '
        'btCreateProject
        '
        Me.btCreateProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btCreateProject.Location = New System.Drawing.Point(255, 162)
        Me.btCreateProject.Name = "btCreateProject"
        Me.btCreateProject.Size = New System.Drawing.Size(75, 23)
        Me.btCreateProject.TabIndex = 15
        Me.btCreateProject.Text = "Criar Projeto"
        Me.btCreateProject.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btCancel.Location = New System.Drawing.Point(507, 162)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 15
        Me.btCancel.Text = "Cancelar"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'ToolTipInformacoes
        '
        Me.ToolTipInformacoes.AutomaticDelay = 100
        Me.ToolTipInformacoes.AutoPopDelay = 10000
        Me.ToolTipInformacoes.InitialDelay = 100
        Me.ToolTipInformacoes.ReshowDelay = 20
        Me.ToolTipInformacoes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipInformacoes.ToolTipTitle = "Informações"
        '
        'btOpen
        '
        Me.btOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btOpen.Location = New System.Drawing.Point(379, 162)
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(75, 23)
        Me.btOpen.TabIndex = 17
        Me.btOpen.Text = "Abrir Projeto"
        Me.btOpen.UseVisualStyleBackColor = True
        '
        'NewProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 205)
        Me.Controls.Add(Me.btOpen)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btCreateProject)
        Me.Controls.Add(Me.btFind)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbDirectory)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Projeto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbDirectory As TextBox
    Friend WithEvents btFind As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents cbCreateFolder As CheckBox
    Friend WithEvents btCreateProject As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents ToolTipInformacoes As ToolTip
    Friend WithEvents btOpen As Button
    Friend WithEvents ToolTipErro As ToolTip
End Class
