<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Druida_IDE
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Druida_IDE))
        Me.scDruidaMain = New System.Windows.Forms.SplitContainer()
        Me.scWorkArea = New System.Windows.Forms.SplitContainer()
        Me.scExplorer = New System.Windows.Forms.SplitContainer()
        Me.scCodeArea = New System.Windows.Forms.SplitContainer()
        Me.tCheckPorts = New System.Windows.Forms.Timer(Me.components)
        Me.ilCodeElements = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.scDruidaMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDruidaMain.Panel2.SuspendLayout()
        Me.scDruidaMain.SuspendLayout()
        CType(Me.scWorkArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scWorkArea.Panel1.SuspendLayout()
        Me.scWorkArea.Panel2.SuspendLayout()
        Me.scWorkArea.SuspendLayout()
        CType(Me.scExplorer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scExplorer.SuspendLayout()
        CType(Me.scCodeArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scCodeArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'scDruidaMain
        '
        Me.scDruidaMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scDruidaMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scDruidaMain.IsSplitterFixed = True
        Me.scDruidaMain.Location = New System.Drawing.Point(0, 0)
        Me.scDruidaMain.Name = "scDruidaMain"
        Me.scDruidaMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scDruidaMain.Panel2
        '
        Me.scDruidaMain.Panel2.Controls.Add(Me.scWorkArea)
        Me.scDruidaMain.Size = New System.Drawing.Size(868, 553)
        Me.scDruidaMain.SplitterDistance = 81
        Me.scDruidaMain.TabIndex = 1
        '
        'scWorkArea
        '
        Me.scWorkArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scWorkArea.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scWorkArea.Location = New System.Drawing.Point(0, 0)
        Me.scWorkArea.Name = "scWorkArea"
        '
        'scWorkArea.Panel1
        '
        Me.scWorkArea.Panel1.Controls.Add(Me.scExplorer)
        '
        'scWorkArea.Panel2
        '
        Me.scWorkArea.Panel2.Controls.Add(Me.scCodeArea)
        Me.scWorkArea.Size = New System.Drawing.Size(868, 468)
        Me.scWorkArea.SplitterDistance = 255
        Me.scWorkArea.TabIndex = 0
        '
        'scExplorer
        '
        Me.scExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scExplorer.Location = New System.Drawing.Point(0, 0)
        Me.scExplorer.Name = "scExplorer"
        Me.scExplorer.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.scExplorer.Size = New System.Drawing.Size(255, 468)
        Me.scExplorer.SplitterDistance = 140
        Me.scExplorer.TabIndex = 0
        '
        'scCodeArea
        '
        Me.scCodeArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scCodeArea.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.scCodeArea.Location = New System.Drawing.Point(0, 0)
        Me.scCodeArea.Name = "scCodeArea"
        Me.scCodeArea.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.scCodeArea.Size = New System.Drawing.Size(609, 468)
        Me.scCodeArea.SplitterDistance = 300
        Me.scCodeArea.TabIndex = 0
        '
        'tCheckPorts
        '
        '
        'ilCodeElements
        '
        Me.ilCodeElements.ImageStream = CType(resources.GetObject("ilCodeElements.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilCodeElements.TransparentColor = System.Drawing.Color.Transparent
        Me.ilCodeElements.Images.SetKeyName(0, "Keyword.png")
        Me.ilCodeElements.Images.SetKeyName(1, "Var.png")
        Me.ilCodeElements.Images.SetKeyName(2, "ConstantValue.png")
        Me.ilCodeElements.Images.SetKeyName(3, "Class.png")
        Me.ilCodeElements.Images.SetKeyName(4, "Cube.png")
        Me.ilCodeElements.Images.SetKeyName(5, "Tree.png")
        Me.ilCodeElements.Images.SetKeyName(6, "Library.png")
        Me.ilCodeElements.Images.SetKeyName(7, "Global.png")
        Me.ilCodeElements.Images.SetKeyName(8, "namspace.png")
        '
        'Druida_IDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(868, 553)
        Me.Controls.Add(Me.scDruidaMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Druida_IDE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Druida IDE Lite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.scDruidaMain.Panel2.ResumeLayout(False)
        CType(Me.scDruidaMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDruidaMain.ResumeLayout(False)
        Me.scWorkArea.Panel1.ResumeLayout(False)
        Me.scWorkArea.Panel2.ResumeLayout(False)
        CType(Me.scWorkArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scWorkArea.ResumeLayout(False)
        CType(Me.scExplorer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scExplorer.ResumeLayout(False)
        CType(Me.scCodeArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scCodeArea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents scDruidaMain As SplitContainer
    Friend WithEvents scWorkArea As SplitContainer
    Friend WithEvents scCodeArea As SplitContainer
    Friend WithEvents scExplorer As SplitContainer
    Friend WithEvents tCheckPorts As Timer
    Friend WithEvents ilCodeElements As ImageList
End Class
