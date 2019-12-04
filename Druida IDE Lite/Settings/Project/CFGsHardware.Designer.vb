<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CFGsHardware
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CFGsHardware))
        Me.GroupBoxSelecaoArduino = New System.Windows.Forms.GroupBox()
        Me.pBoards = New System.Windows.Forms.Panel()
        Me.tvBoardsList = New System.Windows.Forms.TreeView()
        Me.ilBoards = New System.Windows.Forms.ImageList(Me.components)
        Me.tsBoards = New System.Windows.Forms.ToolStrip()
        Me.tsbNewBoard = New System.Windows.Forms.ToolStripButton()
        Me.tsbtUpdateTree = New System.Windows.Forms.ToolStripButton()
        Me.tsbtFavorite = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSelectededBoardName = New System.Windows.Forms.TextBox()
        Me.pbBoard = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.gbSpecs = New System.Windows.Forms.GroupBox()
        Me.tbWidth = New System.Windows.Forms.TextBox()
        Me.tbHeight = New System.Windows.Forms.TextBox()
        Me.tbClk = New System.Windows.Forms.TextBox()
        Me.tbEEPROM = New System.Windows.Forms.TextBox()
        Me.tbSRAM = New System.Windows.Forms.TextBox()
        Me.tbFlash = New System.Windows.Forms.TextBox()
        Me.tbAnalog = New System.Windows.Forms.TextBox()
        Me.tbPWM = New System.Windows.Forms.TextBox()
        Me.tbDigital = New System.Windows.Forms.TextBox()
        Me.tbPwr = New System.Windows.Forms.TextBox()
        Me.tbVoltz = New System.Windows.Forms.TextBox()
        Me.tbMicro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbAditionalLibs = New System.Windows.Forms.TextBox()
        Me.GroupBoxSelecaoArduino.SuspendLayout()
        Me.pBoards.SuspendLayout()
        Me.tsBoards.SuspendLayout()
        CType(Me.pbBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSpecs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxSelecaoArduino
        '
        resources.ApplyResources(Me.GroupBoxSelecaoArduino, "GroupBoxSelecaoArduino")
        Me.GroupBoxSelecaoArduino.Controls.Add(Me.pBoards)
        Me.GroupBoxSelecaoArduino.Controls.Add(Me.Label2)
        Me.GroupBoxSelecaoArduino.Controls.Add(Me.tbSelectededBoardName)
        Me.GroupBoxSelecaoArduino.Controls.Add(Me.pbBoard)
        Me.GroupBoxSelecaoArduino.Name = "GroupBoxSelecaoArduino"
        Me.GroupBoxSelecaoArduino.TabStop = False
        '
        'pBoards
        '
        resources.ApplyResources(Me.pBoards, "pBoards")
        Me.pBoards.Controls.Add(Me.tvBoardsList)
        Me.pBoards.Controls.Add(Me.tsBoards)
        Me.pBoards.Controls.Add(Me.Label3)
        Me.pBoards.Name = "pBoards"
        '
        'tvBoardsList
        '
        resources.ApplyResources(Me.tvBoardsList, "tvBoardsList")
        Me.tvBoardsList.ImageList = Me.ilBoards
        Me.tvBoardsList.Name = "tvBoardsList"
        Me.tvBoardsList.ShowNodeToolTips = True
        '
        'ilBoards
        '
        Me.ilBoards.ImageStream = CType(resources.GetObject("ilBoards.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilBoards.TransparentColor = System.Drawing.Color.Transparent
        Me.ilBoards.Images.SetKeyName(0, "Folder.png")
        Me.ilBoards.Images.SetKeyName(1, "Board.png")
        Me.ilBoards.Images.SetKeyName(2, "IsFavorite.png")
        '
        'tsBoards
        '
        resources.ApplyResources(Me.tsBoards, "tsBoards")
        Me.tsBoards.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNewBoard, Me.tsbtUpdateTree, Me.tsbtFavorite})
        Me.tsBoards.Name = "tsBoards"
        '
        'tsbNewBoard
        '
        resources.ApplyResources(Me.tsbNewBoard, "tsbNewBoard")
        Me.tsbNewBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNewBoard.Image = Global.Druida_IDE_Lite.My.Resources.Resources.New_File
        Me.tsbNewBoard.Name = "tsbNewBoard"
        '
        'tsbtUpdateTree
        '
        resources.ApplyResources(Me.tsbtUpdateTree, "tsbtUpdateTree")
        Me.tsbtUpdateTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtUpdateTree.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Refresh
        Me.tsbtUpdateTree.Name = "tsbtUpdateTree"
        '
        'tsbtFavorite
        '
        resources.ApplyResources(Me.tsbtFavorite, "tsbtFavorite")
        Me.tsbtFavorite.CheckOnClick = True
        Me.tsbtFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtFavorite.Image = Global.Druida_IDE_Lite.My.Resources.Resources.Favorite
        Me.tsbtFavorite.Name = "tsbtFavorite"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'tbSelectededBoardName
        '
        resources.ApplyResources(Me.tbSelectededBoardName, "tbSelectededBoardName")
        Me.tbSelectededBoardName.Name = "tbSelectededBoardName"
        '
        'pbBoard
        '
        resources.ApplyResources(Me.pbBoard, "pbBoard")
        Me.pbBoard.Name = "pbBoard"
        Me.pbBoard.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'rtbDescription
        '
        resources.ApplyResources(Me.rtbDescription, "rtbDescription")
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.ReadOnly = True
        '
        'gbSpecs
        '
        resources.ApplyResources(Me.gbSpecs, "gbSpecs")
        Me.gbSpecs.Controls.Add(Me.tbWidth)
        Me.gbSpecs.Controls.Add(Me.tbHeight)
        Me.gbSpecs.Controls.Add(Me.tbClk)
        Me.gbSpecs.Controls.Add(Me.tbEEPROM)
        Me.gbSpecs.Controls.Add(Me.tbSRAM)
        Me.gbSpecs.Controls.Add(Me.tbFlash)
        Me.gbSpecs.Controls.Add(Me.tbAnalog)
        Me.gbSpecs.Controls.Add(Me.tbPWM)
        Me.gbSpecs.Controls.Add(Me.tbDigital)
        Me.gbSpecs.Controls.Add(Me.tbPwr)
        Me.gbSpecs.Controls.Add(Me.tbVoltz)
        Me.gbSpecs.Controls.Add(Me.tbMicro)
        Me.gbSpecs.Controls.Add(Me.Label15)
        Me.gbSpecs.Controls.Add(Me.Label14)
        Me.gbSpecs.Controls.Add(Me.Label13)
        Me.gbSpecs.Controls.Add(Me.Label12)
        Me.gbSpecs.Controls.Add(Me.Label11)
        Me.gbSpecs.Controls.Add(Me.Label10)
        Me.gbSpecs.Controls.Add(Me.Label9)
        Me.gbSpecs.Controls.Add(Me.Label8)
        Me.gbSpecs.Controls.Add(Me.Label7)
        Me.gbSpecs.Controls.Add(Me.Label6)
        Me.gbSpecs.Controls.Add(Me.Label5)
        Me.gbSpecs.Controls.Add(Me.Label4)
        Me.gbSpecs.Name = "gbSpecs"
        Me.gbSpecs.TabStop = False
        '
        'tbWidth
        '
        resources.ApplyResources(Me.tbWidth, "tbWidth")
        Me.tbWidth.Name = "tbWidth"
        Me.tbWidth.ReadOnly = True
        '
        'tbHeight
        '
        resources.ApplyResources(Me.tbHeight, "tbHeight")
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.ReadOnly = True
        '
        'tbClk
        '
        resources.ApplyResources(Me.tbClk, "tbClk")
        Me.tbClk.Name = "tbClk"
        Me.tbClk.ReadOnly = True
        '
        'tbEEPROM
        '
        resources.ApplyResources(Me.tbEEPROM, "tbEEPROM")
        Me.tbEEPROM.Name = "tbEEPROM"
        Me.tbEEPROM.ReadOnly = True
        '
        'tbSRAM
        '
        resources.ApplyResources(Me.tbSRAM, "tbSRAM")
        Me.tbSRAM.Name = "tbSRAM"
        Me.tbSRAM.ReadOnly = True
        '
        'tbFlash
        '
        resources.ApplyResources(Me.tbFlash, "tbFlash")
        Me.tbFlash.Name = "tbFlash"
        Me.tbFlash.ReadOnly = True
        '
        'tbAnalog
        '
        resources.ApplyResources(Me.tbAnalog, "tbAnalog")
        Me.tbAnalog.Name = "tbAnalog"
        Me.tbAnalog.ReadOnly = True
        '
        'tbPWM
        '
        resources.ApplyResources(Me.tbPWM, "tbPWM")
        Me.tbPWM.Name = "tbPWM"
        Me.tbPWM.ReadOnly = True
        '
        'tbDigital
        '
        resources.ApplyResources(Me.tbDigital, "tbDigital")
        Me.tbDigital.Name = "tbDigital"
        Me.tbDigital.ReadOnly = True
        '
        'tbPwr
        '
        resources.ApplyResources(Me.tbPwr, "tbPwr")
        Me.tbPwr.Name = "tbPwr"
        Me.tbPwr.ReadOnly = True
        '
        'tbVoltz
        '
        resources.ApplyResources(Me.tbVoltz, "tbVoltz")
        Me.tbVoltz.Name = "tbVoltz"
        Me.tbVoltz.ReadOnly = True
        '
        'tbMicro
        '
        resources.ApplyResources(Me.tbMicro, "tbMicro")
        Me.tbMicro.Name = "tbMicro"
        Me.tbMicro.ReadOnly = True
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.tbAditionalLibs)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'tbAditionalLibs
        '
        resources.ApplyResources(Me.tbAditionalLibs, "tbAditionalLibs")
        Me.tbAditionalLibs.Name = "tbAditionalLibs"
        Me.tbAditionalLibs.ReadOnly = True
        '
        'CFGsHardware
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSpecs)
        Me.Controls.Add(Me.rtbDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxSelecaoArduino)
        Me.Name = "CFGsHardware"
        Me.GroupBoxSelecaoArduino.ResumeLayout(False)
        Me.GroupBoxSelecaoArduino.PerformLayout()
        Me.pBoards.ResumeLayout(False)
        Me.pBoards.PerformLayout()
        Me.tsBoards.ResumeLayout(False)
        Me.tsBoards.PerformLayout()
        CType(Me.pbBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSpecs.ResumeLayout(False)
        Me.gbSpecs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxSelecaoArduino As GroupBox
    Friend WithEvents pbBoard As PictureBox
    Friend WithEvents tvBoardsList As TreeView
    Friend WithEvents ilBoards As ImageList
    Friend WithEvents tbSelectededBoardName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents pBoards As Panel
    Friend WithEvents tsBoards As ToolStrip
    Friend WithEvents tsbNewBoard As ToolStripButton
    Friend WithEvents tsbtUpdateTree As ToolStripButton
    Friend WithEvents tsbtFavorite As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents gbSpecs As GroupBox
    Friend WithEvents tbWidth As TextBox
    Friend WithEvents tbHeight As TextBox
    Friend WithEvents tbClk As TextBox
    Friend WithEvents tbEEPROM As TextBox
    Friend WithEvents tbSRAM As TextBox
    Friend WithEvents tbFlash As TextBox
    Friend WithEvents tbAnalog As TextBox
    Friend WithEvents tbPWM As TextBox
    Friend WithEvents tbDigital As TextBox
    Friend WithEvents tbPwr As TextBox
    Friend WithEvents tbVoltz As TextBox
    Friend WithEvents tbMicro As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbAditionalLibs As TextBox
End Class
