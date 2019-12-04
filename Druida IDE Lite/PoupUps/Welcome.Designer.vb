<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbThemePreview = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbThemeSelect = New System.Windows.Forms.ComboBox()
        Me.btContinue = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThemePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Druida_IDE_Lite.My.Resources.Resources.siteIcon
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'pbThemePreview
        '
        resources.ApplyResources(Me.pbThemePreview, "pbThemePreview")
        Me.pbThemePreview.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Arduino_Light_Theme
        Me.pbThemePreview.Name = "pbThemePreview"
        Me.pbThemePreview.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'cbThemeSelect
        '
        resources.ApplyResources(Me.cbThemeSelect, "cbThemeSelect")
        Me.cbThemeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThemeSelect.FormattingEnabled = True
        Me.cbThemeSelect.Items.AddRange(New Object() {resources.GetString("cbThemeSelect.Items"), resources.GetString("cbThemeSelect.Items1"), resources.GetString("cbThemeSelect.Items2"), resources.GetString("cbThemeSelect.Items3")})
        Me.cbThemeSelect.Name = "cbThemeSelect"
        '
        'btContinue
        '
        resources.ApplyResources(Me.btContinue, "btContinue")
        Me.btContinue.Name = "btContinue"
        Me.btContinue.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btContinue)
        Me.Controls.Add(Me.cbThemeSelect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbThemePreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThemePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbThemePreview As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbThemeSelect As ComboBox
    Friend WithEvents btContinue As Button
End Class
