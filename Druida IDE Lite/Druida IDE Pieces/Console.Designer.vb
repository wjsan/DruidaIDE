<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myConsole
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myConsole))
        Me.tcConsole = New VisualStudioTabControl.VisualStudioTabControl()
        Me.tpOutput = New System.Windows.Forms.TabPage()
        Me.tpErrors = New System.Windows.Forms.TabPage()
        Me.tpSerialMonitor = New System.Windows.Forms.TabPage()
        Me.ilErrorsTypes = New System.Windows.Forms.ImageList(Me.components)
        Me.lClose = New System.Windows.Forms.Label()
        Me.Output = New Druida_IDE_Lite.Output()
        Me.ErrorsList = New Druida_IDE_Lite.ErrorsList()
        Me.SerialMonitor = New Druida_IDE_Lite.SerialMonitor()
        Me.tcConsole.SuspendLayout()
        Me.tpOutput.SuspendLayout()
        Me.tpErrors.SuspendLayout()
        Me.tpSerialMonitor.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcConsole
        '
        resources.ApplyResources(Me.tcConsole, "tcConsole")
        Me.tcConsole.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tcConsole.AllowDrop = True
        Me.tcConsole.BackTabColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tcConsole.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tcConsole.ClosingButtonColor = System.Drawing.Color.WhiteSmoke
        Me.tcConsole.ClosingMessage = Nothing
        Me.tcConsole.Controls.Add(Me.tpOutput)
        Me.tcConsole.Controls.Add(Me.tpErrors)
        Me.tcConsole.Controls.Add(Me.tpSerialMonitor)
        Me.tcConsole.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tcConsole.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tcConsole.Name = "tcConsole"
        Me.tcConsole.SelectedIndex = 0
        Me.tcConsole.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tcConsole.ShowClosingButton = True
        Me.tcConsole.ShowClosingMessage = False
        Me.tcConsole.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'tpOutput
        '
        resources.ApplyResources(Me.tpOutput, "tpOutput")
        Me.tpOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpOutput.Controls.Add(Me.Output)
        Me.tpOutput.Name = "tpOutput"
        '
        'tpErrors
        '
        resources.ApplyResources(Me.tpErrors, "tpErrors")
        Me.tpErrors.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpErrors.Controls.Add(Me.ErrorsList)
        Me.tpErrors.Name = "tpErrors"
        '
        'tpSerialMonitor
        '
        resources.ApplyResources(Me.tpSerialMonitor, "tpSerialMonitor")
        Me.tpSerialMonitor.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.tpSerialMonitor.Controls.Add(Me.SerialMonitor)
        Me.tpSerialMonitor.Name = "tpSerialMonitor"
        '
        'ilErrorsTypes
        '
        Me.ilErrorsTypes.ImageStream = CType(resources.GetObject("ilErrorsTypes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilErrorsTypes.TransparentColor = System.Drawing.Color.Transparent
        Me.ilErrorsTypes.Images.SetKeyName(0, "Delete.png")
        Me.ilErrorsTypes.Images.SetKeyName(1, "Notice.png")
        Me.ilErrorsTypes.Images.SetKeyName(2, "Information.png")
        '
        'lClose
        '
        resources.ApplyResources(Me.lClose, "lClose")
        Me.lClose.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lClose.ForeColor = System.Drawing.Color.Transparent
        Me.lClose.Name = "lClose"
        '
        'Output
        '
        resources.ApplyResources(Me.Output, "Output")
        Me.Output.Name = "Output"
        '
        'ErrorsList
        '
        resources.ApplyResources(Me.ErrorsList, "ErrorsList")
        Me.ErrorsList.Name = "ErrorsList"
        '
        'SerialMonitor
        '
        resources.ApplyResources(Me.SerialMonitor, "SerialMonitor")
        Me.SerialMonitor.Name = "SerialMonitor"
        '
        'myConsole
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lClose)
        Me.Controls.Add(Me.tcConsole)
        Me.Name = "myConsole"
        Me.tcConsole.ResumeLayout(False)
        Me.tpOutput.ResumeLayout(False)
        Me.tpErrors.ResumeLayout(False)
        Me.tpSerialMonitor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tpOutput As TabPage
    Friend WithEvents tpErrors As TabPage
    Friend WithEvents tpSerialMonitor As TabPage
    Friend WithEvents ilErrorsTypes As ImageList
    Friend WithEvents Output As Output
    Friend WithEvents ErrorsList As ErrorsList
    Friend WithEvents SerialMonitor As SerialMonitor
    Friend WithEvents tcConsole As VisualStudioTabControl.VisualStudioTabControl
    Friend WithEvents lClose As Label
End Class
