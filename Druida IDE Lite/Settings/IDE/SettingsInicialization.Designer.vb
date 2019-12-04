<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsInicialization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsInicialization))
        Me.cbOpenLastFile = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFileModel = New System.Windows.Forms.ComboBox()
        Me.cbOpenAllFiles = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbShowSplashScreen = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbOpenLastFile
        '
        resources.ApplyResources(Me.cbOpenLastFile, "cbOpenLastFile")
        Me.cbOpenLastFile.Name = "cbOpenLastFile"
        Me.cbOpenLastFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cbFileModel
        '
        Me.cbFileModel.FormattingEnabled = True
        resources.ApplyResources(Me.cbFileModel, "cbFileModel")
        Me.cbFileModel.Name = "cbFileModel"
        '
        'cbOpenAllFiles
        '
        resources.ApplyResources(Me.cbOpenAllFiles, "cbOpenAllFiles")
        Me.cbOpenAllFiles.Name = "cbOpenAllFiles"
        Me.cbOpenAllFiles.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbShowSplashScreen)
        Me.GroupBox1.Controls.Add(Me.cbOpenLastFile)
        Me.GroupBox1.Controls.Add(Me.cbOpenAllFiles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbFileModel)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cbShowSplashScreen
        '
        resources.ApplyResources(Me.cbShowSplashScreen, "cbShowSplashScreen")
        Me.cbShowSplashScreen.Name = "cbShowSplashScreen"
        Me.cbShowSplashScreen.UseVisualStyleBackColor = True
        '
        'SettingsInicialization
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SettingsInicialization"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbOpenLastFile As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFileModel As ComboBox
    Friend WithEvents cbOpenAllFiles As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbShowSplashScreen As CheckBox
End Class
