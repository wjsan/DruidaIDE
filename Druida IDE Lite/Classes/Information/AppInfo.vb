Public Class AppInfo
    Public Structure Files
        Shared appIni As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida\App.ini"
        Shared recentFiles As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida\RecentFiles.ini"
        Shared boardDirectives As String = Application.StartupPath & "\Boards\BoardDirectives.cfg"
        Shared boardPaths As String = Application.StartupPath & "\Boards\BoardPaths.cfg"
        Shared favoriteBoards As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\FavoriteBoards.cfg"
        Shared errorsTranslatePT As String = Application.StartupPath & "\pt\Errors_PT.txt"
        Shared errorsGeneralRef As String = Application.StartupPath & "\GeneralReferences\Errors.txt"
        Shared ideCfgs As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida\AppV2.cfg"
    End Structure

    Public Structure Directories
        Shared ideData As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida"
        Shared project As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida"
        Shared app As String = Application.StartupPath
        Shared boards As String = Application.StartupPath & "\Boards"
        Shared snippets As String = Application.StartupPath & "\CodeSnippets" & "\" & language
        Shared styles As String = Application.StartupPath & "\StylesProfiles"
        Shared arduinoAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Arduino15\packages\"
        Shared arduinoCompiler As String = Application.StartupPath & "\Compiler\Arduino"
        Shared arduinoLibs As String = arduinoCompiler & "\libraries"
        Shared arduinoCoreLibs As String = arduinoCompiler & "\hardware\arduino\avr\libraries"
        Shared arduinoCustomLibs As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Arduino\libraries"
    End Structure

    Structure LicenseTypes
        Const lite = "lite"
        Const premium = "premium"
    End Structure

    Public Const language = "en"

    Public Const license As String = LicenseTypes.premium

End Class
