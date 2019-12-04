<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFGsProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CFGsProject))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAuthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCompany = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbVersionMajor = New System.Windows.Forms.TextBox()
        Me.tbVersionMinor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNotes = New System.Windows.Forms.TextBox()
        Me.tbBuildVersion = New System.Windows.Forms.TextBox()
        Me.tbRevisionVersion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'tbName
        '
        resources.ApplyResources(Me.tbName, "tbName")
        Me.tbName.Name = "tbName"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'tbAuthor
        '
        resources.ApplyResources(Me.tbAuthor, "tbAuthor")
        Me.tbAuthor.Name = "tbAuthor"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
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
        'tbCompany
        '
        resources.ApplyResources(Me.tbCompany, "tbCompany")
        Me.tbCompany.Name = "tbCompany"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'tbDescription
        '
        resources.ApplyResources(Me.tbDescription, "tbDescription")
        Me.tbDescription.Name = "tbDescription"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'tbVersionMajor
        '
        resources.ApplyResources(Me.tbVersionMajor, "tbVersionMajor")
        Me.tbVersionMajor.Name = "tbVersionMajor"
        '
        'tbVersionMinor
        '
        resources.ApplyResources(Me.tbVersionMinor, "tbVersionMinor")
        Me.tbVersionMinor.Name = "tbVersionMinor"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'tbNotes
        '
        resources.ApplyResources(Me.tbNotes, "tbNotes")
        Me.tbNotes.Name = "tbNotes"
        '
        'tbBuildVersion
        '
        resources.ApplyResources(Me.tbBuildVersion, "tbBuildVersion")
        Me.tbBuildVersion.Name = "tbBuildVersion"
        '
        'tbRevisionVersion
        '
        resources.ApplyResources(Me.tbRevisionVersion, "tbRevisionVersion")
        Me.tbRevisionVersion.Name = "tbRevisionVersion"
        '
        'CFGsProject
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbRevisionVersion)
        Me.Controls.Add(Me.tbBuildVersion)
        Me.Controls.Add(Me.tbNotes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbVersionMinor)
        Me.Controls.Add(Me.tbVersionMajor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbCompany)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CFGsProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAuthor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCompany As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbVersionMajor As TextBox
    Friend WithEvents tbVersionMinor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbNotes As TextBox
    Friend WithEvents tbBuildVersion As TextBox
    Friend WithEvents tbRevisionVersion As TextBox
End Class
