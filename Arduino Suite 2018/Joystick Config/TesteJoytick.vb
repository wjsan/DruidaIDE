Imports System.ComponentModel

Public Class TesteJoytick
    Public mySeetings As New Joy
    Private Sub showJoy(ByRef joy As Form)
        While OwnedForms.Count > 0
            OwnedForms(0).Close()
        End While
        joy.MdiParent = Me
        joy.Parent = SplitContainer1.Panel2
        joy.Show()
        joy.Dock = DockStyle.Fill
        joy.BringToFront()
    End Sub

    Private Sub X360ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X360ToolStripMenuItem.Click
        showJoy(X360)
        joyPadType = 0
    End Sub

    Private Sub DS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DS4ToolStripMenuItem.Click
        showJoy(DS4)
        joyPadType = 1
    End Sub

    Private Sub G27ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles G27ToolStripMenuItem.Click
        showJoy(G27)
        joyPadType = 2
    End Sub

    Private Sub TesteJoytick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.SelectedNode = TreeView1.Nodes(joyPadType)
        Select Case joyPadType
            Case 0
                showJoy(X360)
            Case 1
                showJoy(DS4)
            Case 2
                showJoy(G27)
        End Select
        joySeetings = mySeetings
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        If (MessageBox.Show("Tem certeza que deseja iniciar um novo perfil?", "Novo Perfil",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Asterisk) = DialogResult.Yes) Then
            Select Case joyPadType
                Case 0
                    mySeetings.fileJoy = x360Default
                    mySeetings.OpenFileJoy("open")
                    mySeetings.fileJoy = applicationDirectory & "\Config Files\Joy.cfg"
                    'X360.loadValues()
                Case 1
                    mySeetings.fileJoy = ds4Default
                    mySeetings.OpenFileJoy("open")
                    mySeetings.fileJoy = applicationDirectory & "\Config Files\Joy.cfg"
                    DS4.loadValues()
                Case 2
                    mySeetings.fileJoy = g27Default
                    mySeetings.OpenFileJoy("open")
                    mySeetings.fileJoy = applicationDirectory & "\Config Files\G27.cfg"
                    'G27.loadValues()
            End Select
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim initialPath As String = applicationDirectory & "\Config Files\"
        Dim openFile As New OpenFileDialog With {
            .Filter = "Configurações|*.cfg",
            .InitialDirectory = initialPath,
            .Title = "Abrir Arquivo de Configurações do Controle"
        }
        If openFile.ShowDialog() = DialogResult.OK Then
            If (joyPadType <> 2) Then
                mySeetings.fileJoy = openFile.FileName
                mySeetings.OpenFileJoy("load")
            Else
                mySeetings.fileG27 = openFile.FileName
                mySeetings.OpenFileG27("load")
            End If
        End If
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        SalvarJoySeetings()
    End Sub

    Private Sub SalvarJoySeetings()
        If (joyPadType <> 2) Then
            mySeetings.OpenFileJoy("save")
        Else
            mySeetings.OpenFileG27("save")
        End If
    End Sub

    Private Sub SalvarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarComoToolStripMenuItem.Click
        Dim initialPath As String = applicationDirectory & "\Config Files\"
        System.IO.Directory.CreateDirectory(initialPath)
        Dim saveFile As New SaveFileDialog With {
            .Filter = "Configurações|*.cfg",
            .InitialDirectory = initialPath,
            .Title = "Salvar Arquivo de Configurações do Controle"
        }
        If saveFile.ShowDialog() = DialogResult.OK Then
            If (joyPadType <> 2) Then
                mySeetings.fileJoy = saveFile.FileName
                mySeetings.OpenFileJoy("save")
            Else
                mySeetings.fileG27 = saveFile.FileName
                mySeetings.OpenFileG27("save")
            End If
        End If
    End Sub

    Private Sub Porta0ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mySeetings.port = TextBox1.Text
    End Sub

    Private Sub Porta1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mySeetings.port = TextBox1.Text
    End Sub

    Private Sub Porta2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mySeetings.port = TextBox1.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            mySeetings.port = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode Is TreeView1.Nodes(0) Then
            showJoy(X360)
            X360.OpenCfgs()
        End If
        If TreeView1.SelectedNode Is TreeView1.Nodes(1) Then
            showJoy(DS4)
            DS4.OpenCfgs()
        End If
        If TreeView1.SelectedNode Is TreeView1.Nodes(2) Then
            showJoy(G27)
            G27.OpenCfgs()
        End If
        joyPadType = TreeView1.SelectedNode.Index
    End Sub

    Private Sub TesteJoytick_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Deseja salvar as alteraççoes?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SalvarJoySeetings()
        End If
    End Sub
End Class