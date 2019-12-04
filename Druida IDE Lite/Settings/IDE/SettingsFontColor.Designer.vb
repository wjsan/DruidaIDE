<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsFontColor
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsFontColor))
        Me.btSaveAs = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbUnderlined = New System.Windows.Forms.CheckBox()
        Me.cbItalic = New System.Windows.Forms.CheckBox()
        Me.cbBold = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbColor = New System.Windows.Forms.ComboBox()
        Me.lbSyntax = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPreview = New System.Windows.Forms.RichTextBox()
        Me.btColor = New System.Windows.Forms.Button()
        Me.btOpen = New System.Windows.Forms.Button()
        Me.btApply = New System.Windows.Forms.Button()
        Me.pbColor = New System.Windows.Forms.PictureBox()
        Me.cbFontSize = New System.Windows.Forms.ComboBox()
        Me.cbFontFamily = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chooseColor = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btSaveAs
        '
        resources.ApplyResources(Me.btSaveAs, "btSaveAs")
        Me.btSaveAs.Name = "btSaveAs"
        Me.btSaveAs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'cbUnderlined
        '
        resources.ApplyResources(Me.cbUnderlined, "cbUnderlined")
        Me.cbUnderlined.Name = "cbUnderlined"
        Me.cbUnderlined.UseVisualStyleBackColor = True
        '
        'cbItalic
        '
        resources.ApplyResources(Me.cbItalic, "cbItalic")
        Me.cbItalic.Name = "cbItalic"
        Me.cbItalic.UseVisualStyleBackColor = True
        '
        'cbBold
        '
        resources.ApplyResources(Me.cbBold, "cbBold")
        Me.cbBold.Name = "cbBold"
        Me.cbBold.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'cbColor
        '
        resources.ApplyResources(Me.cbColor, "cbColor")
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Name = "cbColor"
        '
        'lbSyntax
        '
        resources.ApplyResources(Me.lbSyntax, "lbSyntax")
        Me.lbSyntax.FormattingEnabled = True
        Me.lbSyntax.Items.AddRange(New Object() {resources.GetString("lbSyntax.Items"), resources.GetString("lbSyntax.Items1"), resources.GetString("lbSyntax.Items2"), resources.GetString("lbSyntax.Items3"), resources.GetString("lbSyntax.Items4"), resources.GetString("lbSyntax.Items5"), resources.GetString("lbSyntax.Items6"), resources.GetString("lbSyntax.Items7"), resources.GetString("lbSyntax.Items8"), resources.GetString("lbSyntax.Items9"), resources.GetString("lbSyntax.Items10"), resources.GetString("lbSyntax.Items11"), resources.GetString("lbSyntax.Items12"), resources.GetString("lbSyntax.Items13"), resources.GetString("lbSyntax.Items14"), resources.GetString("lbSyntax.Items15"), resources.GetString("lbSyntax.Items16"), resources.GetString("lbSyntax.Items17"), resources.GetString("lbSyntax.Items18"), resources.GetString("lbSyntax.Items19"), resources.GetString("lbSyntax.Items20"), resources.GetString("lbSyntax.Items21")})
        Me.lbSyntax.Name = "lbSyntax"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.tbPreview)
        Me.GroupBox1.Controls.Add(Me.btColor)
        Me.GroupBox1.Controls.Add(Me.btOpen)
        Me.GroupBox1.Controls.Add(Me.btApply)
        Me.GroupBox1.Controls.Add(Me.btSaveAs)
        Me.GroupBox1.Controls.Add(Me.pbColor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbUnderlined)
        Me.GroupBox1.Controls.Add(Me.cbItalic)
        Me.GroupBox1.Controls.Add(Me.cbBold)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbColor)
        Me.GroupBox1.Controls.Add(Me.lbSyntax)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'tbPreview
        '
        resources.ApplyResources(Me.tbPreview, "tbPreview")
        Me.tbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPreview.Name = "tbPreview"
        '
        'btColor
        '
        resources.ApplyResources(Me.btColor, "btColor")
        Me.btColor.Name = "btColor"
        Me.btColor.UseVisualStyleBackColor = True
        '
        'btOpen
        '
        resources.ApplyResources(Me.btOpen, "btOpen")
        Me.btOpen.Name = "btOpen"
        Me.btOpen.UseVisualStyleBackColor = True
        '
        'btApply
        '
        resources.ApplyResources(Me.btApply, "btApply")
        Me.btApply.Name = "btApply"
        Me.btApply.UseVisualStyleBackColor = True
        '
        'pbColor
        '
        resources.ApplyResources(Me.pbColor, "pbColor")
        Me.pbColor.Name = "pbColor"
        Me.pbColor.TabStop = False
        '
        'cbFontSize
        '
        resources.ApplyResources(Me.cbFontSize, "cbFontSize")
        Me.cbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFontSize.FormattingEnabled = True
        Me.cbFontSize.Items.AddRange(New Object() {resources.GetString("cbFontSize.Items"), resources.GetString("cbFontSize.Items1"), resources.GetString("cbFontSize.Items2"), resources.GetString("cbFontSize.Items3"), resources.GetString("cbFontSize.Items4"), resources.GetString("cbFontSize.Items5"), resources.GetString("cbFontSize.Items6"), resources.GetString("cbFontSize.Items7"), resources.GetString("cbFontSize.Items8"), resources.GetString("cbFontSize.Items9"), resources.GetString("cbFontSize.Items10"), resources.GetString("cbFontSize.Items11"), resources.GetString("cbFontSize.Items12"), resources.GetString("cbFontSize.Items13"), resources.GetString("cbFontSize.Items14"), resources.GetString("cbFontSize.Items15"), resources.GetString("cbFontSize.Items16"), resources.GetString("cbFontSize.Items17"), resources.GetString("cbFontSize.Items18"), resources.GetString("cbFontSize.Items19")})
        Me.cbFontSize.Name = "cbFontSize"
        '
        'cbFontFamily
        '
        resources.ApplyResources(Me.cbFontFamily, "cbFontFamily")
        Me.cbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFontFamily.FormattingEnabled = True
        Me.cbFontFamily.Items.AddRange(New Object() {resources.GetString("cbFontFamily.Items"), resources.GetString("cbFontFamily.Items1"), resources.GetString("cbFontFamily.Items2"), resources.GetString("cbFontFamily.Items3")})
        Me.cbFontFamily.Name = "cbFontFamily"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'SettingsFontColor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbFontSize)
        Me.Controls.Add(Me.cbFontFamily)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SettingsFontColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSaveAs As Button
    Friend WithEvents pbColor As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbUnderlined As CheckBox
    Friend WithEvents cbItalic As CheckBox
    Friend WithEvents cbBold As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbColor As ComboBox
    Friend WithEvents lbSyntax As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbFontSize As ComboBox
    Friend WithEvents cbFontFamily As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btApply As Button
    Friend WithEvents btOpen As Button
    Friend WithEvents btColor As Button
    Friend WithEvents chooseColor As ColorDialog
    Friend WithEvents tbPreview As RichTextBox
End Class
