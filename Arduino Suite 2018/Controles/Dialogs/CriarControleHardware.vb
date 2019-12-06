Imports System.Windows.Forms

Public Class CriarControleHardware
    Public local As Point
    Public fileOpened As String = ""
    Private fileName As String = ""

    Private Sub CriarControleHardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileName = ""
        fileOpened = ""
        Dim local As Point = ControleHardwarePreview.Location
        Text = "Criar controle personalizado - Novo"
        If (System.IO.File.Exists(controlPath & "\Default.ctr")) Then
            Try
                ControleHardwarePreview.engine.loadDataFromFile(controlPath & "\Default.ctr")
            Catch ex As Exception
                If (MessageBox.Show("Foram encontradas inconsistência nos dados. Deseja recuperar os valores padrão?", "Erro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    ControleHardwarePreview.engine.updateDataFromControl(ControleHardwarePreview)
                    ControleHardwarePreview.engine.saveData(controlPath & "\Default.ctr")
                End If
            End Try
        Else
            ControleHardwarePreview.engine.updateDataFromControl(ControleHardwarePreview)
            ControleHardwarePreview.engine.saveData(controlPath & "\Default.ctr")
        End If
        ControleHardwarePreview.engine.canMove = True
        ControleHardwarePreview.engine.editMode = True
        If (Text <> "Propriedades") Then
            ControleHardwarePreview.engine.updateControl(ControleHardwarePreview)
            loadControl()
        End If
        atualizaContextMenu()
        ControleHardwarePreview.Location = local
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim novoControle As New ControleHardware
        novoControle.engine.updateDataFromControl(ControleHardwarePreview)
        novoControle.engine.updateControl(novoControle)
        novoControle.Location = local
        novoControle.engine.canMove = True
        novoControle.engine.editMode = False
        GetLocal.Controls.Add(novoControle)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub loadControl()
        With ControleHardwarePreview.engine
            TextBoxTipo.Text = .tipo
            ComboBoxSelPorta.SelectedItem = .porta(0)
            CheckBoxTipVisivel.Checked = .tipVisivel
            CheckBoxRotulo.Checked = .rotulo
            TextBoxRotulo.Text = .rotuloText
            LabelRotuloCor.BackColor = .rotuloColor
            LabelRotuloCor.Text = .rotuloColor.Name
            CheckBoxTrackBarEnable.Checked = .trackBar
            RadioButtonTrackBarHorizontal.Checked = .trackBarOrientation = Orientation.Horizontal
            RadioButtonTrackBarVertical.Checked = .trackBarOrientation = Orientation.Vertical
            CheckBoxTrackBarInvert.Checked = .trackBarDirection = "Tras"
            CheckBoxBarGraphEnable.Checked = .barGraph
            RadioButtonBarGraphHorizontal.Checked = .barGraphOrientation = "Horizontal"
            RadioButtonBarGraphVertical.Checked = .barGraphOrientation = "Vertical"
            LabelBarGraphColor.BackColor = .barGraphColor
            LabelBarGraphColor.Text = .barGraphColor.Name
            TextBoxMin.Text = .scaleMin
            TextBoxMax.Text = .scaleMax
            TextBoxUnit.Text = .unit
            CheckBoxAnalogValor.Checked = .analogValor
            CheckBoxBotao1.Checked = .button1
            TextBoxBotao1.Text = .button1Text
            CheckBoxBotao2.Checked = .button2
            TextBoxBotao2.Text = .button2Text
            RadioButton2Bt.Checked = (.buttonMode = "on/off")
            RadioButtonPushButton.Checked = (.buttonMode = "pls")
            RadioButtonRet.Checked = (.buttonMode = "ret")
        End With
    End Sub

    Private Sub TextBoxTipo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTipo.TextChanged
        ControleHardwarePreview.engine.tipo = TextBoxTipo.Text
    End Sub

    Private Sub ComboBoxSelPorta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelPorta.SelectedIndexChanged
        ControleHardwarePreview.engine.porta(0) = ComboBoxSelPorta.SelectedItem
    End Sub

    Private Sub CheckBoxTipVisivel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTipVisivel.CheckedChanged
        ControleHardwarePreview.ToolTipInfoPorta.Active = CheckBoxTipVisivel.Checked
    End Sub

    Private Sub CheckBoxRotulo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRotulo.CheckedChanged
        ControleHardwarePreview.LabelRotulo.Visible = CheckBoxRotulo.Checked
    End Sub

    Private Sub TextBoxRotulo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRotulo.TextChanged
        ControleHardwarePreview.LabelRotulo.Text = TextBoxRotulo.Text
    End Sub

    Private Sub LabelRotuloCor_Click(sender As Object, e As EventArgs) Handles LabelRotuloCor.Click
        selecionaCor(LabelRotuloCor, ControleHardwarePreview.LabelRotulo)
    End Sub

    Private Sub selecionaCor(ByRef label1 As Label, ByRef label2 As Label)
        Dim corRotulo As New ColorDialog
        If (corRotulo.ShowDialog() <> DialogResult.Cancel) Then
            label1.BackColor = corRotulo.Color
            label1.Text = corRotulo.Color.Name
            label2.BackColor = corRotulo.Color
        End If
    End Sub

    Private Sub CheckBoxTrackBarEnable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTrackBarEnable.CheckedChanged
        ControleHardwarePreview.TrackBarSaidaAnalogica.Visible = CheckBoxTrackBarEnable.Checked
    End Sub

    Private Sub RadioButtonTrackBarHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTrackBarHorizontal.CheckedChanged
        ControleHardwarePreview.TrackBarSaidaAnalogica.Orientation = Orientation.Horizontal
    End Sub

    Private Sub RadioButtonTrackBarVertical_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTrackBarVertical.CheckedChanged
        ControleHardwarePreview.TrackBarSaidaAnalogica.Orientation = Orientation.Vertical
    End Sub

    Private Sub CheckBoxTrackBarInvert_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTrackBarInvert.CheckedChanged
        If (CheckBoxTrackBarInvert.Checked) Then
            ControleHardwarePreview.engine.trackBarDirection = "Frente"
        Else
            ControleHardwarePreview.engine.trackBarDirection = "Tras"
        End If
    End Sub

    Private Sub CheckBoxBarGraphEnable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBarGraphEnable.CheckedChanged
        ControleHardwarePreview.BarraGrafica.Visible = CheckBoxBarGraphEnable.Checked
    End Sub

    Private Sub RadioButtonBarGraphHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBarGraphHorizontal.CheckedChanged
        If (RadioButtonBarGraphHorizontal.Checked) Then ControleHardwarePreview.engine.barGraphOrientation = "Horizontal"
    End Sub

    Private Sub RadioButtonBarGraphVertical_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBarGraphVertical.CheckedChanged
        If (RadioButtonBarGraphVertical.Checked) Then ControleHardwarePreview.engine.barGraphOrientation = "Vertical"
    End Sub

    Private Sub RadioButtonBarGraphVertical_Click(sender As Object, e As EventArgs) Handles RadioButtonBarGraphVertical.Click
        Dim sizeAux As New Size(ControleHardwarePreview.BarraGrafica.Size)
        ControleHardwarePreview.BarraGrafica.Width = sizeAux.Height
        ControleHardwarePreview.BarraGrafica.Height = sizeAux.Width
    End Sub

    Private Sub LabelBarGraphColor_Click(sender As Object, e As EventArgs) Handles LabelBarGraphColor.Click
        selecionaCor(LabelBarGraphColor, ControleHardwarePreview.BarraGrafica)
    End Sub

    Private Sub CheckBoxAnalogValor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAnalogValor.CheckedChanged
        ControleHardwarePreview.TextBoxValor.Visible = CheckBoxAnalogValor.Checked
        ControleHardwarePreview.LabelValor.Visible = CheckBoxAnalogValor.Checked
    End Sub

    Private Sub CheckBoxBotao1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBotao1.CheckedChanged
        ControleHardwarePreview.Button1.Visible = CheckBoxBotao1.Checked
    End Sub

    Private Sub CheckBoxBotao2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBotao2.CheckedChanged
        ControleHardwarePreview.Button2.Visible = CheckBoxBotao2.Checked
    End Sub

    Private Sub TextBoxBotao1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBotao1.TextChanged
        ControleHardwarePreview.Button1.Text = TextBoxBotao1.Text
    End Sub

    Private Sub TextBoxBotao2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBotao2.TextChanged
        ControleHardwarePreview.Button2.Text = TextBoxBotao2.Text
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim opt As DialogResult = MessageBox.Show("Deseja salvar as alterações?", "Novo Arquivo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If (opt = DialogResult.Yes) Then
            If (fileOpened = "") Then
                SalvarDialog()
            Else
                System.IO.File.Delete(fileOpened)
                ControleHardwarePreview.engine.saveData(fileOpened)
            End If
        End If
        If (opt = DialogResult.No) Then
            Me.CriarControleHardware_Load(sender, e)
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim initialPath As String = applicationDirectory & "\Comando\Controles Personalizados"
        System.IO.Directory.CreateDirectory(initialPath)
        Dim openFile As New OpenFileDialog With {
            .Filter = "Controle Personalizado|*.ctr",
            .InitialDirectory = initialPath,
            .Title = "Abrir Controle Personalizado"
        }
        Dim dialogResult = openFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            abrirArquivo(openFile.FileName)
            'ControleHardwarePreview.engine.loadDataFromFile(openFile.FileName)
            'ControleHardwarePreview.engine.updateControl(ControleHardwarePreview)
            'fileOpened = openFile.FileName
            'fileName = openFile.SafeFileName
            'Text = "Controle Personalizado - " & fileName
            'loadControl()
            'ControleHardwarePreview.Location = local
        End If
    End Sub

    Public Sub abrirArquivo(ByVal path As String)
        ControleHardwarePreview.engine.loadDataFromFile(path)
        ControleHardwarePreview.engine.updateControl(ControleHardwarePreview)
        fileOpened = path
        fileName = path.Split("\")(path.Split("\").Count - 1)
        Text = "Controle Personalizado - " & fileName
        loadControl()
        ControleHardwarePreview.Location = New Point(74, 128)
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        If (fileOpened = "") Then
            SalvarDialog()
        Else
            ControleHardwarePreview.engine.updateDataFromControl(ControleHardwarePreview)
            System.IO.File.Delete(fileOpened)
            ControleHardwarePreview.engine.saveData(fileOpened)
        End If
    End Sub

    Private Sub SalvarDialog()
        Dim initialPath As String = applicationDirectory & "\Comando\Controles Personalizados"
        System.IO.Directory.CreateDirectory(initialPath)
        Dim saveFile As New SaveFileDialog With {
            .Filter = "Controle Personalizado|*.ctr",
            .InitialDirectory = initialPath,
            .Title = "Salvar Controle Personalizado"
        }
        Dim dialogResult = saveFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            System.IO.File.Delete(saveFile.FileName)
            ControleHardwarePreview.engine.updateDataFromControl(ControleHardwarePreview)
            ControleHardwarePreview.engine.saveData(saveFile.FileName)
            fileOpened = saveFile.FileName
            fileName = fileOpened.Split("\")(fileOpened.Split("\").Count - 1)
            Text = "Controle Personalizado - " & fileName
        End If
    End Sub

    Private Sub SalvarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarComoToolStripMenuItem.Click
        SalvarDialog()
    End Sub

    Private Sub Imagem0SinalInativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Imagem0SinalInativoToolStripMenuItem.Click
        Dim fileName As String
        fileName = ControleHardwarePreview.engine.setImageFile("Alterar Imagem - Entrada Inativa", 0)
        ControleHardwarePreview.PictureBoxStatus.Image = Image.FromFile(fileName)
    End Sub

    Private Sub Imagem1SinalAtivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Imagem1SinalAtivoToolStripMenuItem.Click
        Dim fileName As String
        fileName = ControleHardwarePreview.engine.setImageFile("Alterar Imagem - Entrada Inativa", 1)
        ControleHardwarePreview.PictureBoxStatus.Image = Image.FromFile(fileName)
    End Sub

    Private Sub Imagem2SinalDeFalhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Imagem2SinalDeFalhaToolStripMenuItem.Click
        Dim fileName As String
        fileName = ControleHardwarePreview.engine.setImageFile("Alterar Imagem - Entrada Inativa", 2)
        ControleHardwarePreview.PictureBoxStatus.Image = Image.FromFile(fileName)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstado.SelectedIndexChanged
        ControleHardwarePreview.PictureBoxStatus.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagens\" & ControleHardwarePreview.engine.imagens(ComboBoxEstado.SelectedIndex))
    End Sub

    Private Sub atualizaContextMenu()
        With ControleHardwarePreview
            .PropriedadesToolStripMenuItem.Enabled = False
            .DeletarToolStripMenuItem.Enabled = False
            .CopiarToolStripMenuItem.Enabled = False
            .RecortarToolStripMenuItem1.Enabled = False
            .EnviarParaTrásToolStripMenuItem.Enabled = False
            .TrazerParaFrenteToolStripMenuItem.Enabled = False
        End With
    End Sub

    Private Sub RadioButtonPushButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPushButton.CheckedChanged
        If (RadioButtonPushButton.Checked) Then ControleHardwarePreview.engine.buttonMode = "pls"
    End Sub

    Private Sub RadioButtonRet_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonRet.CheckedChanged
        If (RadioButtonRet.Checked) Then ControleHardwarePreview.engine.buttonMode = "ret"
    End Sub

    Private Sub RadioButton2Bt_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2Bt.CheckedChanged
        If (RadioButton2Bt.Checked) Then ControleHardwarePreview.engine.buttonMode = "on/off"
    End Sub

    Private Sub TextBoxMin_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMin.TextChanged
        If TextBoxMin.Text <> "" Then
            Try
                ControleHardwarePreview.engine.scaleMin = TextBoxMin.Text
            Catch ex As Exception
                ToolStripStatusLabel1.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub TextBoxMax_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMax.TextChanged
        If TextBoxMin.Text <> "" Then
            Try
                ControleHardwarePreview.engine.scaleMax = TextBoxMax.Text
            Catch ex As Exception
                ToolStripStatusLabel1.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub TextBoxTeste_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUnit.TextChanged
        ControleHardwarePreview.engine.unit = TextBoxUnit.Text
    End Sub

    Private Sub EditarControlesExistentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarControlesExistentesToolStripMenuItem.Click
        Dim initialPath As String = My.Application.Info.DirectoryPath & "\Controles"
        Dim local As Point = ControleHardwarePreview.Location
        System.IO.Directory.CreateDirectory(initialPath)
        Dim openFile As New OpenFileDialog With {
            .Filter = "Controle Personalizado|*.ctr",
            .InitialDirectory = initialPath,
            .Title = "Abrir Controle Personalizado"
        }
        Dim dialogResult = openFile.ShowDialog()
        If dialogResult <> DialogResult.Cancel Then
            ControleHardwarePreview.engine.loadDataFromFile(openFile.FileName)
            ControleHardwarePreview.engine.updateControl(ControleHardwarePreview)
            fileOpened = openFile.FileName
            fileName = openFile.SafeFileName
            Text = "Controle Personalizado - " & fileName
            loadControl()
            ControleHardwarePreview.Location = local
        End If
    End Sub
End Class
