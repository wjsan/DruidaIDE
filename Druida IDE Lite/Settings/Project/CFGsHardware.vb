Imports Druida_IDE_Lite.BoardsData
Imports Druida_IDE_Lite.ImagesManipulation
Imports Druida_IDE_Lite.IDEcfgs.Values

Public Class CFGsHardware

    Private favNode As TreeNode

    Private Sub CFGsHardware_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateBoardsList()
        GetSelectedBoard()
        ApplyTheme()
    End Sub

    Public Sub UpdateBoardsList()
        tvBoardsList.Nodes.Clear()
        Dim node As TreeNode = tvBoardsList.Nodes.Add("Boards")
        node.SelectedImageIndex = 0
        node.ImageIndex = 0
        LoadBoardGroup(installedBoards, node)
        UpdateFavorites()
    End Sub

    Public Sub GetSelectedBoard()
        Dim name As String = CurrentProjectCfgs.values.hardware.selectedBoardName
        Dim selectedBoard As Board = installedBoards.GetBoard(name)
        If selectedBoard IsNot Nothing Then
            tbSelectededBoardName.Text = name
            pbBoard.Image = SafeImageFromFile(selectedBoard.GetImage)
            rtbDescription.LoadFile(selectedBoard.GetDescrFile())
            tbAditionalLibs.Lines = selectedBoard.GetAditionalLibs.ToArray
        End If
    End Sub

    Public Sub ApplyTheme()
        IDEcfgs.ApplyThemeInControlGroup(GroupBoxSelecaoArduino)
        IDEcfgs.ApplyThemeInControlGroup(Me)
        tvBoardsList.BackColor = Color.FromArgb(CodeColors.BackColor)
        tvBoardsList.ForeColor = Color.FromArgb(CodeColors.ForeColor)
        tsBoards.BackColor = Color.FromArgb(CodeColors.ControlsColor)
        tsBoards.ForeColor = Color.FromArgb(CodeColors.ForeColor)
    End Sub



    Private Sub UpdateFavorites()
        If favNode IsNot Nothing Then
            tvBoardsList.Nodes.Remove(favNode)
        End If
        Dim fav As TreeNode = tvBoardsList.Nodes.Add("Favorites")
        fav.SelectedImageIndex = 2
        fav.ImageIndex = 2
        LoadBoards(favoriteBoards, fav)
        favNode = fav
    End Sub

    Private Sub LoadBoards(ByRef Boards As List(Of Board), node As TreeNode)
        For Each board As Board In Boards
            Dim newNode As TreeNode = node.Nodes.Add(board.GetName)
            newNode.Tag = "Board"
            If board.IsFavorite Then
                newNode.SelectedImageIndex = 2
                newNode.ImageIndex = 2
            Else
                newNode.SelectedImageIndex = 1
                newNode.ImageIndex = 1
            End If
        Next
    End Sub

    Private Sub LoadBoardGroup(ByRef boardGroups As Boards, node As TreeNode)
        For Each boardGroup As BoardsType In boardGroups.GetGroups
            Dim newNode As TreeNode = node.Nodes.Add(boardGroup.GetName)
            newNode.Tag = "Group"
            newNode.SelectedImageIndex = 0
            newNode.ImageIndex = 0
            newNode.ToolTipText = boardGroup.GetDescription
            LoadBoards(boardGroup.BoardList, newNode)
        Next
    End Sub

    Private Sub tvBoardsList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvBoardsList.AfterSelect
        If e.Node.Tag = "Board" Then
            Dim selectedBoard As Board = installedBoards.GetBoard(e.Node.Text)
            Try
                pbBoard.Image = SafeImageFromFile(selectedBoard.GetImage)
                rtbDescription.LoadFile(selectedBoard.GetDescrFile)
                IDEcfgs.ApplyThemeInControl(rtbDescription)
                tbSelectededBoardName.Text = selectedBoard.GetName()
                tbAditionalLibs.Lines = selectedBoard.GetAditionalLibs.ToArray
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                outputMessages.AppendMessage(ex.ToString, MessagesManager.Filter.Compiler)
            End Try
            tsbtFavorite.Checked = selectedBoard.IsFavorite
            SelectBoard(selectedBoard.GetName)
            controlMainToolBar.LoadSelectedBoard()
        End If
    End Sub

    Private Sub tsbtFavorite_Click(sender As Object, e As EventArgs) Handles tsbtFavorite.Click
        If tvBoardsList.SelectedNode.Tag = "Board" Then
            Dim selectedBoard As Board = installedBoards.GetBoard(tvBoardsList.SelectedNode.Text)
            selectedBoard.SetFavorite(tsbtFavorite.Checked)
            If tsbtFavorite.Checked Then
                BoardsData.AddFavorite(selectedBoard.GetName)
            Else
                BoardsData.RemoveFavorite(selectedBoard.GetName)
            End If
            UpdateImageStatus(selectedBoard)
            controlMainToolBar.LoadFavoriteBoards()
            controlMainToolBar.LoadSelectedBoard()
        End If
    End Sub

    Private Sub UpdateImageStatus(selectedBoard As Board)
        Dim image As Short = 0
        If selectedBoard.IsFavorite Then
            image = 2
        Else
            image = 1
        End If
        tvBoardsList.SelectedNode.ImageIndex = image
        tvBoardsList.SelectedNode.SelectedImageIndex = image
    End Sub

    Private Sub tsbtUpdateTree_Click(sender As Object, e As EventArgs) Handles tsbtUpdateTree.Click
        UpdateBoardsList()
    End Sub

End Class
