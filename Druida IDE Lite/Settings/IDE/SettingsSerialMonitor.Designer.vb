<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsSerialMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsSerialMonitor))
        Me.cbShowMessageOrigin = New System.Windows.Forms.CheckBox()
        Me.cbShowPCmessages = New System.Windows.Forms.CheckBox()
        Me.cbShowTime = New System.Windows.Forms.CheckBox()
        Me.cbShowDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbShowMessageOrigin
        '
        resources.ApplyResources(Me.cbShowMessageOrigin, "cbShowMessageOrigin")
        Me.cbShowMessageOrigin.Name = "cbShowMessageOrigin"
        Me.cbShowMessageOrigin.UseVisualStyleBackColor = True
        '
        'cbShowPCmessages
        '
        resources.ApplyResources(Me.cbShowPCmessages, "cbShowPCmessages")
        Me.cbShowPCmessages.Name = "cbShowPCmessages"
        Me.cbShowPCmessages.UseVisualStyleBackColor = True
        '
        'cbShowTime
        '
        resources.ApplyResources(Me.cbShowTime, "cbShowTime")
        Me.cbShowTime.Name = "cbShowTime"
        Me.cbShowTime.UseVisualStyleBackColor = True
        '
        'cbShowDate
        '
        resources.ApplyResources(Me.cbShowDate, "cbShowDate")
        Me.cbShowDate.Name = "cbShowDate"
        Me.cbShowDate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbShowMessageOrigin)
        Me.GroupBox1.Controls.Add(Me.cbShowDate)
        Me.GroupBox1.Controls.Add(Me.cbShowPCmessages)
        Me.GroupBox1.Controls.Add(Me.cbShowTime)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'SettingsSerialMonitor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SettingsSerialMonitor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbShowMessageOrigin As CheckBox
    Friend WithEvents cbShowPCmessages As CheckBox
    Friend WithEvents cbShowTime As CheckBox
    Friend WithEvents cbShowDate As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
