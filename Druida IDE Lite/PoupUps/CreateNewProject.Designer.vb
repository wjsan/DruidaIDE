<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateNewProject))
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
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTipErro = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCreateFolder)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cbCreateFolder
        '
        resources.ApplyResources(Me.cbCreateFolder, "cbCreateFolder")
        Me.cbCreateFolder.Checked = True
        Me.cbCreateFolder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCreateFolder.Name = "cbCreateFolder"
        Me.cbCreateFolder.UseVisualStyleBackColor = True
        '
        'tbDirectory
        '
        resources.ApplyResources(Me.tbDirectory, "tbDirectory")
        Me.tbDirectory.Name = "tbDirectory"
        '
        'btFind
        '
        resources.ApplyResources(Me.btFind, "btFind")
        Me.btFind.Name = "btFind"
        Me.btFind.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'tbName
        '
        resources.ApplyResources(Me.tbName, "tbName")
        Me.tbName.Name = "tbName"
        '
        'btCreateProject
        '
        resources.ApplyResources(Me.btCreateProject, "btCreateProject")
        Me.btCreateProject.Name = "btCreateProject"
        Me.btCreateProject.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        resources.ApplyResources(Me.btCancel, "btCancel")
        Me.btCancel.Name = "btCancel"
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
        resources.ApplyResources(Me.btOpen, "btOpen")
        Me.btOpen.Name = "btOpen"
        Me.btOpen.UseVisualStyleBackColor = True
        '
        'tbTitle
        '
        resources.ApplyResources(Me.tbTitle, "tbTitle")
        Me.tbTitle.Name = "tbTitle"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'CreateNewProject
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.Label4)
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
        Me.MaximizeBox = False
        Me.Name = "CreateNewProject"
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
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents Label4 As Label
End Class
