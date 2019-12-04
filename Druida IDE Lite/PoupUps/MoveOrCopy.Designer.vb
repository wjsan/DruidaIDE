<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoveOrCopy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoveOrCopy))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFile = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbFolder = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btMove = New System.Windows.Forms.Button()
        Me.btCopy = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lbFile
        '
        resources.ApplyResources(Me.lbFile, "lbFile")
        Me.lbFile.Name = "lbFile"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lbFolder
        '
        resources.ApplyResources(Me.lbFolder, "lbFolder")
        Me.lbFolder.Name = "lbFolder"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btMove
        '
        resources.ApplyResources(Me.btMove, "btMove")
        Me.btMove.Name = "btMove"
        Me.btMove.UseVisualStyleBackColor = True
        '
        'btCopy
        '
        resources.ApplyResources(Me.btCopy, "btCopy")
        Me.btCopy.Name = "btCopy"
        Me.btCopy.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        resources.ApplyResources(Me.btCancel, "btCancel")
        Me.btCancel.Name = "btCancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'MoveOrCopy
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btCopy)
        Me.Controls.Add(Me.btMove)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbFolder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbFile)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MoveOrCopy"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbFile As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbFolder As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btMove As Button
    Friend WithEvents btCopy As Button
    Friend WithEvents btCancel As Button
End Class
