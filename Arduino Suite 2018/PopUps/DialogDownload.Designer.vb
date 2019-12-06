<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogDownload
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
        Me.labelInfo = New System.Windows.Forms.Label()
        Me.TimerDownload = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarDownload = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'labelInfo
        '
        Me.labelInfo.AutoSize = True
        Me.labelInfo.Location = New System.Drawing.Point(13, 9)
        Me.labelInfo.Name = "labelInfo"
        Me.labelInfo.Size = New System.Drawing.Size(154, 13)
        Me.labelInfo.TabIndex = 1
        Me.labelInfo.Text = "Abrindo canal de comunicação"
        '
        'TimerDownload
        '
        Me.TimerDownload.Interval = 500
        '
        'ProgressBarDownload
        '
        Me.ProgressBarDownload.Location = New System.Drawing.Point(16, 34)
        Me.ProgressBarDownload.Name = "ProgressBarDownload"
        Me.ProgressBarDownload.Size = New System.Drawing.Size(262, 23)
        Me.ProgressBarDownload.TabIndex = 2
        '
        'DialogDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 73)
        Me.Controls.Add(Me.ProgressBarDownload)
        Me.Controls.Add(Me.labelInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogDownload"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Download"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelInfo As Label
    Friend WithEvents TimerDownload As Timer
    Friend WithEvents ProgressBarDownload As ProgressBar
End Class
