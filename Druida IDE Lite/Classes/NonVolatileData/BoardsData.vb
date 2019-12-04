Imports System.IO

Public Class BoardsData
    Public Shared installedBoards As New Boards
    Public Shared favoriteBoards As New List(Of Board)
    Shared currentBoard As Board
    Shared favoriteBoardNames As New List(Of String)

    ''' <summary>
    ''' Initialize boards data base, with information of Druida installed boards
    ''' </summary>
    Shared Sub LoadDataBase()
        installedBoards.Clear()
        favoriteBoards.Clear()
        favoriteBoardNames.Clear()
        Dim boardDirectives As New List(Of String)
        Dim boardPaths As New List(Of String)
        boardDirectives.AddRange(File.ReadAllLines(AppInfo.Files.boardDirectives))
        boardPaths.AddRange(File.ReadAllLines(AppInfo.Files.boardPaths))
        If Not File.Exists(AppInfo.Files.favoriteBoards) Then
            File.WriteAllBytes(AppInfo.Files.favoriteBoards, My.Resources.FavoriteBoards)
        End If
        favoriteBoardNames.AddRange(File.ReadAllLines(AppInfo.Files.favoriteBoards))
        BuildDataBase(boardDirectives, boardPaths)
    End Sub

    Shared Sub SelectBoard(name As String)
        FileOperations.ClearLibs()
        currentBoard = installedBoards.GetBoard(name)
        If currentBoard IsNot Nothing Then
            CurrentProjectCfgs.values.hardware.selectedBoardName = name
        End If
    End Sub

    Private Shared Sub BuildDataBase(boardDirectives As List(Of String), boardPaths As List(Of String))
        For i = 0 To boardPaths.Count - 1
            Dim fileInf As New FileInfo(boardPaths(i))
            Dim name = fileInf.Name
            Dim directive = boardDirectives(i)
            Dim path = Application.StartupPath & "\" & boardPaths(i)
            Dim newBoard As New Board(name, directive, path)
            Dim groupName = newBoard.GetBoardGroupName
            installedBoards.AddBoard(newBoard, groupName)
            If favoriteBoardNames.Contains(newBoard.GetName) Then
                newBoard.SetFavorite(True)
                favoriteBoards.Add(newBoard)
            End If
        Next
    End Sub

    Public Shared Sub AddFavorite(ByVal name As String)
        If Not favoriteBoardNames.Contains(name) Then
            favoriteBoardNames.Add(name)
        End If
        File.WriteAllLines(AppInfo.Files.favoriteBoards, favoriteBoardNames)
        LoadDataBase()
    End Sub

    Public Shared Sub RemoveFavorite(ByVal name As String)
        While favoriteBoardNames.Contains(name)
            favoriteBoardNames.Remove(name)
        End While
        File.WriteAllLines(AppInfo.Files.favoriteBoards, favoriteBoardNames)
        LoadDataBase()
    End Sub

    Public Shared Function GetCurrentBoard() As Board
        Return currentBoard
    End Function

    Class Boards
        Private Shared groupNames As New List(Of String)
        Private Shared boardGroups As New List(Of BoardsType)
        Public Sub AddBoard(ByRef board As Board, ByVal groupName As String)
            If groupNames.Contains(groupName) Then
                boardGroups(groupNames.IndexOf(groupName)).AddBoard(board)
            Else
                Dim description As String = File.ReadAllText(AppInfo.Directories.boards & "\" & groupName & "\Description.txt")
                Dim newBoardType As New BoardsType(board.GetBoardGroupName, description)
                groupNames.Add(groupName)
                boardGroups.Add(newBoardType)
                newBoardType.AddBoard(board)
            End If
        End Sub

        Public Function GetBoard(name As String) As Board
            For Each group As BoardsType In boardGroups
                For Each board As Board In group.BoardList
                    If board.GetName = name Then
                        Return board
                    End If
                Next
            Next
            Return Nothing
        End Function

        Public Function GetGroups() As List(Of BoardsType)
            Return boardGroups
        End Function

        Public Function GetGroupNames() As List(Of String)
            Return groupNames
        End Function

        Public Sub Clear()
            groupNames.Clear()
            boardGroups.Clear()
        End Sub
    End Class

    Class BoardsType
        Private name As String
        Private description As String
        Private boards As New List(Of Board)

        Public Sub New(name As String, description As String)
            Me.name = name
            Me.description = description
        End Sub

        Public Sub AddBoard(board As Board)
            Me.boards.Add(board)
        End Sub

        Public Function BoardList() As List(Of Board)
            Return boards
        End Function

        Public Function GetName() As String
            Return Me.name
        End Function

        Public Function GetDescription() As String
            Return description
        End Function
    End Class

    Class Board
        Private name As String
        Private directive As String
        Private picture As String
        Private description As String
        Private groupName As String
        Private aditionalLibs As New List(Of String)
        Private favorite As Boolean = False

        Public Sub New(boardName As String, boardDirective As String, boardPath As String)
            Me.name = boardName
            Me.directive = boardDirective
            Me.picture = boardPath & "\" & Me.name & ".jpg"
            Me.description = boardPath & "\Description.rtf"
            If File.Exists(boardPath & "\AditionalLibs.txt") Then
                Dim libs() As String = File.ReadAllLines(boardPath & "\AditionalLibs.txt")
                For Each libr In libs
                    Me.aditionalLibs.Add(AppInfo.Directories.arduinoAppData & libr)
                Next
            End If
            Me.groupName = boardPath.Split("\")(boardPath.Split("\").Count - 2)
        End Sub

        Public Function GetName() As String
            Return name
        End Function

        Public Function GetDirective() As String
            Return directive
        End Function

        Public Function GetDescrFile() As String
            Return description
        End Function

        Public Function GetBoardGroupName() As String
            Return groupName
        End Function

        Public Function GetAditionalLibs() As List(Of String)
            Return aditionalLibs
        End Function

        Public Function GetImage() As String
            Return picture
        End Function

        Public Sub SetFavorite(ByVal state)
            favorite = state
        End Sub

        Public Function IsFavorite()
            Return favorite
        End Function
    End Class
End Class

Public Class BoardSpecifications
    Private micro As String
    Private voltage As String
    Private supply As String
    Private dig As String
    Private pwm As String
    Private analog As String
    Private flash As String
    Private sram As String
    Private eeprom As String
    Private clock As String
    Private height As String
    Private width As String
    Private file As New FileVarSystem

    Public Sub New(filePath As String)
        file.SetFilePath(filePath)
    End Sub
End Class
