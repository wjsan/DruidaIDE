<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogUpload
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
        Me.TimerUpload = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarUpload = New System.Windows.Forms.ProgressBar()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TimerUpload
        '
        Me.TimerUpload.Interval = 500
        '
        'ProgressBarUpload
        '
        Me.ProgressBarUpload.Location = New System.Drawing.Point(25, 37)
        Me.ProgressBarUpload.Name = "ProgressBarUpload"
        Me.ProgressBarUpload.Size = New System.Drawing.Size(249, 23)
        Me.ProgressBarUpload.TabIndex = 0
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(22, 9)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(216, 13)
        Me.LabelInfo.TabIndex = 1
        Me.LabelInfo.Text = "Verificando compatibilidade da configuração"
        '
        'DialogUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 81)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.ProgressBarUpload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogUpload"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Upload"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerUpload As Timer
    Friend WithEvents ProgressBarUpload As ProgressBar
    Friend WithEvents LabelInfo As Label
End Class
