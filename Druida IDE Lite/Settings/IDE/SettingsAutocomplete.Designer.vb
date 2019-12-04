<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsAutocomplete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsAutocomplete))
        Me.cbEnable = New System.Windows.Forms.CheckBox()
        Me.cbAllowTabKey = New System.Windows.Forms.CheckBox()
        Me.cbAlwaysShowToolTip = New System.Windows.Forms.CheckBox()
        Me.mtbAppearInterval = New System.Windows.Forms.MaskedTextBox()
        Me.mtbMinFragmentLenght = New System.Windows.Forms.MaskedTextBox()
        Me.mtbToolTipDuration = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbEnable
        '
        resources.ApplyResources(Me.cbEnable, "cbEnable")
        Me.cbEnable.Name = "cbEnable"
        Me.cbEnable.UseVisualStyleBackColor = True
        '
        'cbAllowTabKey
        '
        resources.ApplyResources(Me.cbAllowTabKey, "cbAllowTabKey")
        Me.cbAllowTabKey.Name = "cbAllowTabKey"
        Me.cbAllowTabKey.UseVisualStyleBackColor = True
        '
        'cbAlwaysShowToolTip
        '
        resources.ApplyResources(Me.cbAlwaysShowToolTip, "cbAlwaysShowToolTip")
        Me.cbAlwaysShowToolTip.Name = "cbAlwaysShowToolTip"
        Me.cbAlwaysShowToolTip.UseVisualStyleBackColor = True
        '
        'mtbAppearInterval
        '
        resources.ApplyResources(Me.mtbAppearInterval, "mtbAppearInterval")
        Me.mtbAppearInterval.Name = "mtbAppearInterval"
        Me.mtbAppearInterval.ValidatingType = GetType(Integer)
        '
        'mtbMinFragmentLenght
        '
        resources.ApplyResources(Me.mtbMinFragmentLenght, "mtbMinFragmentLenght")
        Me.mtbMinFragmentLenght.Name = "mtbMinFragmentLenght"
        Me.mtbMinFragmentLenght.ValidatingType = GetType(Integer)
        '
        'mtbToolTipDuration
        '
        resources.ApplyResources(Me.mtbToolTipDuration, "mtbToolTipDuration")
        Me.mtbToolTipDuration.Name = "mtbToolTipDuration"
        Me.mtbToolTipDuration.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbEnable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbAlwaysShowToolTip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbAllowTabKey)
        Me.GroupBox1.Controls.Add(Me.mtbToolTipDuration)
        Me.GroupBox1.Controls.Add(Me.mtbAppearInterval)
        Me.GroupBox1.Controls.Add(Me.mtbMinFragmentLenght)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'SettingsAutocomplete
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SettingsAutocomplete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbEnable As CheckBox
    Friend WithEvents cbAllowTabKey As CheckBox
    Friend WithEvents cbAlwaysShowToolTip As CheckBox
    Friend WithEvents mtbAppearInterval As MaskedTextBox
    Friend WithEvents mtbMinFragmentLenght As MaskedTextBox
    Friend WithEvents mtbToolTipDuration As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
