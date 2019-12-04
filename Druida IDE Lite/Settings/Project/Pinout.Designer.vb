<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinout
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
        Me.components = New System.ComponentModel.Container()
        Me.tbPin = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.pbRemove = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.vsReorder = New System.Windows.Forms.VScrollBar()
        CType(Me.pbRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPin
        '
        Me.tbPin.Location = New System.Drawing.Point(23, 5)
        Me.tbPin.Name = "tbPin"
        Me.tbPin.Size = New System.Drawing.Size(39, 20)
        Me.tbPin.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbPin, "On-board number of pin")
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(69, 5)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(144, 20)
        Me.tbName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbName, "Name to be defined to pin")
        '
        'cbType
        '
        Me.cbType.AutoCompleteCustomSource.AddRange(New String() {"INPUT", "OUTPUT", "INPUT_PULLUP", "Dados"})
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"INPUT", "OUTPUT", "INPUT_PULLUP", "Dados"})
        Me.cbType.Location = New System.Drawing.Point(219, 4)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(124, 21)
        Me.cbType.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cbType, "Type of pin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INPUT: (Button, Switch, Sensor)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OUTPUT: (Leds, Motors, Actuators)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "INPUT_PULLUP: Enable internal pull-up resistor." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data: Reserve pin to data")
        '
        'tbDescription
        '
        Me.tbDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDescription.Location = New System.Drawing.Point(349, 5)
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.Size = New System.Drawing.Size(227, 20)
        Me.tbDescription.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbDescription, "Description of pin (optional)")
        '
        'pbRemove
        '
        Me.pbRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbRemove.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Delete
        Me.pbRemove.Location = New System.Drawing.Point(582, 2)
        Me.pbRemove.Name = "pbRemove"
        Me.pbRemove.Size = New System.Drawing.Size(28, 26)
        Me.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRemove.TabIndex = 4
        Me.pbRemove.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbRemove, "Delete pin")
        '
        'vsReorder
        '
        Me.vsReorder.Location = New System.Drawing.Point(3, 6)
        Me.vsReorder.Name = "vsReorder"
        Me.vsReorder.Size = New System.Drawing.Size(17, 18)
        Me.vsReorder.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.vsReorder, "Move this pin on list")
        Me.vsReorder.Value = 50
        '
        'Pinout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.vsReorder)
        Me.Controls.Add(Me.pbRemove)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbPin)
        Me.Name = "Pinout"
        Me.Size = New System.Drawing.Size(613, 30)
        CType(Me.pbRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPin As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pbRemove As PictureBox
    Friend WithEvents vsReorder As VScrollBar
End Class
