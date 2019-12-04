Imports System.IO
Imports System.Drawing.Text
''' <summary>
''' Management of IDE Settings
''' </summary>
Public Class IDEcfgs
    Shared myCfgs As New FileVarSystem

    ''' <summary>
    ''' Key names of cfg file
    ''' </summary>
    Structure Names
        Structure Initialization
            Const culture = "culture"
            Const openLastFile = "openLastFile"
            Const modelFile = "modelFile"
            Const openAllFiles = "openAllFiles"
            Const showSplashScreen = "showSlpashScreen"
        End Structure
        Structure TextEditor
            Const fontFamily = "fontFamily"
            Const fontSize = "fontSize"
            Const zoomFactor = "zoomFactor"
        End Structure
        Structure CodeColors
            Const TypeNamesColor = "TypeNamesColor"
            Const CppCommonColor = "CppCommonColor"
            Const ArduinoKeywordsColor = "ArduinoKeywordsColor"
            Const DataTypesColor = "DataTypesColor"
            Const CompilerKeysColor = "CompilerKeysColor"
            Const NumbersColor = "NumbersColor"
            Const CommentsColor = "CommentsColor"
            Const ConstantsNamesColor = "ConstantsNamesColor"
            Const StringColor = "StringColor"
            Const SameWordsColor = "SameWordsColor"
            Const DeclaredInstancesColor = "DeclaredInstancesColor"
            Const DeclaredClassTypesColor = "DeclaredClassTypesColor"
            Const InstanceMethodsStyleColor = "InstanceMethodsStyleColor"
            Const DeclaredMethodsStyleColor = "DeclaredMethodsStyleColor"
            Const ForeColor = "ForeColor"
            Const BackColor = "BackColor"
            Const ControlsColor = "ControlsColor"
            Const LineNumbersColor = "LineNumbersColor"
            Const LineNumbersBackColor = "LineNumbersBackColor"
            Const TabsColor = "TabsColor"
            Const TabsHeaderColor = "TabsHeaderColor"
            Const TabsFontColor = "TabsFontColor"
        End Structure
        Structure CodeStyles
            Const TypeNamesStyle = "TypeNamesStyle"
            Const CppCommonStyle = "CppCommonStyle"
            Const ArduinoKeywordsStyle = "ArduinoKeywordsStyle"
            Const DataTypesStyle = "DataTypesStyle"
            Const CompilerKeysStyle = "CompilerKeysStyle"
            Const NumbersStyle = "NumbersStyle"
            Const CommentsStyle = "CommentsStyle"
            Const ConstantsNamesStyle = "ConstantsNamesStyle"
            Const StringStyle = "StringStyle"
            Const SameWordsStyle = "SameWordsStyle"
            Const DeclaredInstancesStyle = "DeclaredInstancesStyle"
            Const DeclaredClassTypesStyle = "DeclaredClassTypesStyle"
            Const InstanceMethodsStyleStyle = "InstanceMethodsStyleStyle"
            Const DeclaredMethodsStyleStyle = "DeclaredMethodsStyleStyle"
        End Structure
        Structure AutoCompleteMenu
            Const AllowTabKey = "AllowTabKey"
            Const AlwaysShowTooltip = "AlwaysShowTooltip"
            Const AppearInterval = "AppearInterval"
            Const Enabled = "Enabled"
            Const MinFragmentLength = "MinFragmentLength"
            Const ToolTipDuration = "ToolTipDuration"
        End Structure
        Structure Workspace
            Const FullScreen = "Fullscreen"
            Const ShowConsole = "ShowConsole"
            Const ShowFilesList = "ShowFilesList"
            Const ShowObjectsList = "ShowObjectsList"
            Const ShowOutputTab = "ShowOutputTab"
            Const ShowErrorsTab = "ShowErrorsTab"
            Const ShowSerialMonitorTab = "ShowSerialMonitorTab"
            Const ShowHardwareMonitorTab = "ShowHardwareMonitorTab"
            Const ShowDocumentMap = "ShowDocumentMap"
            Const FullPathOnTab = "FullPathOnTab"
            Const CodeAreaSplittedDistance = "CodeAreaSplittedDistance"
            Const WorkAreaSplittedDistance = "WorkAreaSplittedDistance"
        End Structure
        Structure SerialMonitor
            Const ShowMessageOrigin = "ShowMessageOrigin"
            Const ShowPCmessages = "ShowPCmessages"
            Const ShowTime = "ShowTime"
            Const ShowDate = "ShowDate"
            Const ClearOnEnter = "ClearOnEnter"
        End Structure
        Structure Directories
            Const Arduino = "Arduino"
            Const ArduinoLib = "ArduinoLib"
            Const ArduinoCoreLib = "ArduinoCoreLib"
            Const ArduinoDefaultLib = "ArduinoDefaultLib"
            Const DruidaProjects = "DruidaProjects"
            Const CompilerTempDir = "CompilerTempDir"
            Const BackupDir = "BackupDir"
            Const AditionalLibsDir = "AditionalLibsDir"
        End Structure
    End Structure

    ''' <summary>
    ''' Default values of keys
    ''' </summary>
    Structure DefaultValues
        Structure Initialization
            Const culture = "pt"
            Const openLastFile = "False"
            Shared Function modelFile() As String
                Dim cultureResx As New CultureManager
                Dim file As String = cultureResx.translateFile(CodeInfo.ModelFiles.ArduinoDefault)
                Return file
            End Function
            Const openAllFiles = "False"
            Const showSplashScreen = "True"
        End Structure
        Structure TextEditor
            Const fontFamily = "Consolas"
            Const fontSize = "12"
            Const zoomFactor = "105"
        End Structure
        Structure CodeColors
            Shared ArduinoKeywordsColor = -2002688
            Shared BackColor = -1
            Shared CommentsColor = -9868951
            Shared CompilerKeysColor = -8355840
            Shared ConstantsNamesColor = -14634326
            Shared ControlsColor = -986896
            Shared CppCommonColor = -8355840
            Shared DataTypesColor = -12550016
            Shared DeclaredClassTypesColor = -2002688
            Shared DeclaredInstancesColor = -2002688
            Shared DeclaredMethodsStyleColor = -2002688
            Shared ForeColor = -16777216
            Shared InstanceMethodsStyleColor = -2002688
            Shared LineNumbersBackColor = -1
            Shared LineNumbersColor = -8487298
            Shared NumbersColor = -16777216
            Shared SameWordsColor = -9605779
            Shared StringColor = -16744320
            Shared TabsColor = -16750900
            Shared TabsFontColor = -1
            Shared TabsHeaderColor = -12961222
            Shared TypeNamesColor = -14634326
        End Structure
        Structure CodeStyles
            Const ArduinoKeywordsStyle = 0
            Const CommentsStyle = 0
            Const CompilerKeysStyle = 0
            Const ConstantsNamesStyle = 0
            Const CppCommonStyle = 0
            Const DataTypesStyle = 0
            Const DeclaredClassTypesStyle = 1
            Const DeclaredInstancesStyle = 1
            Const DeclaredMethodsStyleStyle = 0
            Const InstanceMethodsStyleStyle = 0
            Const NumbersStyle = 0
            Const SameWordsStyle = 0
            Const StringStyle = 0
            Const TypeNamesStyle = 0
        End Structure
        Structure AutoCompleteMenu
            Const AllowTabKey = "True"
            Const AlwaysShowTooltip = "True"
            Const AppearInterval = "100"
            Const Enabled = "True"
            Const MinFragmentLength = "1"
            Const ToolTipDuration = "32766"
        End Structure
        Structure Workspace
            Const FullScreen = "false"
            Const ShowFilesList = "true"
            Const ShowConsole = "true"
            Const ShowObjectsList = "true"
            Const ShowOutputTab = "true"
            Const ShowErrorsTab = "true"
            Const ShowSerialMonitorTab = "true"
            Const ShowHardwareMonitorTab = "true"
            Const ShowDocumentMap = "true"
            Const FullPathOnTab = "False"
            Const CodeAreaSplittedDistance = 0
            Const WorkAreaSplittedDistance = 0
        End Structure
        Structure SerialMonitor
            Const ShowMessageOrigin = "false"
            Const ShowPCmessages = "false"
            Const ShowTime = "false"
            Const ShowDate = "false"
            Const ClearOnEnter = "true"
        End Structure
        Structure Directories
            Shared Arduino = AppInfo.Directories.arduinoCompiler
            Shared ArduinoCoreLib = AppInfo.Directories.arduinoCoreLibs
            Shared ArduinoDefaultLib = AppInfo.Directories.arduinoLibs
            Shared ArduinoLib = AppInfo.Directories.arduinoCustomLibs
            Shared DruidaProjects = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Druida"
            Const CompilerTempDir = "C:\Temp"
            Shared BackupDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Backup"
            Shared esp8266lib = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Arduino15\packages\esp8266\hardware\esp8266\2.5.1\libraries"
            Shared AditionalLibsDir = esp8266lib
        End Structure
    End Structure

    ''' <summary>
    ''' Actual values of keys
    ''' </summary>
    Structure Values
        Structure Initialization
            Shared culture = ""
            Shared openLastFile = ""
            Shared Function modelFile() As String
                Dim cultureResx As New CultureManager
                Dim file As String = cultureResx.translateFile(CodeInfo.ModelFiles.ArduinoDefault)
                Return file
            End Function
            Shared openAllFiles = ""
            Shared showSplashScreen = ""
        End Structure
        Structure TextEditor
            Shared fontFamily = ""
            Shared fontSize = ""
            Shared zoomFactor = ""
        End Structure
        Structure CodeColors
            Shared TypeNamesColor = ""
            Shared CppCommonColor = ""
            Shared ArduinoKeywordsColor = ""
            Shared DataTypesColor = ""
            Shared CompilerKeysColor = ""
            Shared NumbersColor = ""
            Shared CommentsColor = ""
            Shared ConstantsNamesColor = ""
            Shared StringColor = ""
            Shared SameWordsColor = ""
            Shared DeclaredInstancesColor = ""
            Shared DeclaredClassTypesColor = ""
            Shared InstanceMethodsStyleColor = ""
            Shared DeclaredMethodsStyleColor = ""
            Shared ForeColor = ""
            Shared BackColor = ""
            Shared ControlsColor = ""
            Shared LineNumbersColor = ""
            Shared LineNumbersBackColor = ""
            Shared TabsColor = ""
            Shared TabsHeaderColor = ""
            Shared TabsFontColor = ""
        End Structure
        Structure CodeStyles
            Shared TypeNamesStyle = ""
            Shared CppCommonStyle = ""
            Shared ArduinoKeywordsStyle = ""
            Shared DataTypesStyle = ""
            Shared CompilerKeysStyle = ""
            Shared NumbersStyle = ""
            Shared CommentsStyle = ""
            Shared ConstantsNamesStyle = ""
            Shared StringStyle = ""
            Shared SameWordsStyle = ""
            Shared DeclaredInstancesStyle = ""
            Shared DeclaredClassTypesStyle = ""
            Shared InstanceMethodsStyleStyle = ""
            Shared DeclaredMethodsStyleStyle = ""
        End Structure
        Structure AutoCompleteMenu
            Shared AllowTabKey = ""
            Shared AlwaysShowTooltip = ""
            Shared AppearInterval = ""
            Shared Enabled = ""
            Shared MinFragmentLength = ""
            Shared ToolTipDuration = ""
        End Structure
        Structure Workspace
            Shared FullScreen As String = ""
            Shared ShowFilesList As String = ""
            Shared ShowObjectsList As String = ""
            Shared ShowConsole As String = ""
            Shared ShowOutputTab As String = ""
            Shared ShowErrorsTab As String = ""
            Shared ShowSerialMonitorTab As String = ""
            Shared ShowHardwareMonitorTab As String = ""
            Shared ShowDocumentMap As String = ""
            Shared FullPathOnTab As String = ""
            Shared CodeAreaSplittedDistance As String = ""
            Shared WorkAreaSplittedDistance As String = ""
            Shared IsChild As Boolean = False
        End Structure
        Structure SerialMonitor
            Shared ShowMessageOrigin = ""
            Shared ShowPCmessages = ""
            Shared ShowTime = ""
            Shared ShowDate = ""
            Shared ClearOnEnter = ""
        End Structure
        Structure Directories
            Shared Arduino As String = ""
            Shared ArduinoLib As String = ""
            Shared ArduinoCoreLib As String = ""
            Shared ArduinoDefaultLib As String = ""
            Shared DruidaProjects As String = ""
            Shared CompilerTempDir As String = ""
            Shared BackupDir As String = ""
            Shared AditionalLibsDir As String = ""
        End Structure
    End Structure

    ''' <summary>
    ''' Get a key value
    ''' </summary>
    ''' <param name="name">Name of key</param>
    ''' <returns>Value of key</returns>
    Public Shared Function GetValue(name As String)
        Return (myCfgs.ReadVar(name))
    End Function


    ''' <summary>
    ''' Set a key value
    ''' </summary>
    ''' <param name="name">Name of Key</param>
    ''' <param name="value">Value of Key</param>
    Public Shared Sub SetValue(name As String, value As String)
        myCfgs.WriteVar(name, value)
    End Sub

    ''' <summary>
    ''' Checks integrity of cfg file
    ''' </summary>
    Shared Sub VerifyCFGs()
        myCfgs.SetFilePath(AppInfo.Files.ideCfgs)
        VerifyInitializationKeys()
        VerifyTextEditorKeys()
        VerifyCodeColorsKeys()
        VerifyCodeStylesKeys()
        VerifyAutocompleteKeys()
        VerifyWorkspaceKeys()
        VerifySerialMonitorKeys()
        VerifyDirectoriesKeys()
    End Sub

    Shared Sub VerifyInitializationKeys()
        VerifyKey(Names.Initialization.culture, DefaultValues.Initialization.culture, Values.Initialization.culture)
        VerifyKey(Names.Initialization.openLastFile, DefaultValues.Initialization.openLastFile, Values.Initialization.openLastFile)
        VerifyKey(Names.Initialization.openAllFiles, DefaultValues.Initialization.openAllFiles, Values.Initialization.openAllFiles)
        If File.Exists(GetValue(Names.Initialization.modelFile)) Then
            VerifyKey(Names.Initialization.modelFile, DefaultValues.Initialization.modelFile, Values.Initialization.modelFile)
        Else
            SetValue(Names.Initialization.modelFile, DefaultValues.Initialization.modelFile)
        End If
        VerifyKey(Names.Initialization.showSplashScreen, DefaultValues.Initialization.showSplashScreen, Values.Initialization.showSplashScreen)
    End Sub

    Shared Sub VerifyTextEditorKeys()
        VerifyKey(Names.TextEditor.fontFamily, DefaultValues.TextEditor.fontFamily, Values.TextEditor.fontFamily)
        VerifyKey(Names.TextEditor.fontSize, DefaultValues.TextEditor.fontSize, Values.TextEditor.fontSize)
        VerifyKey(Names.TextEditor.zoomFactor, DefaultValues.TextEditor.zoomFactor, Values.TextEditor.zoomFactor)
    End Sub

    Shared Sub VerifyCodeColorsKeys()
        VerifyKey(Names.CodeColors.ArduinoKeywordsColor, DefaultValues.CodeColors.ArduinoKeywordsColor, Values.CodeColors.ArduinoKeywordsColor)
        VerifyKey(Names.CodeColors.BackColor, DefaultValues.CodeColors.BackColor, Values.CodeColors.BackColor)
        VerifyKey(Names.CodeColors.CommentsColor, DefaultValues.CodeColors.CommentsColor, Values.CodeColors.CommentsColor)
        VerifyKey(Names.CodeColors.CompilerKeysColor, DefaultValues.CodeColors.CompilerKeysColor, Values.CodeColors.CompilerKeysColor)
        VerifyKey(Names.CodeColors.ConstantsNamesColor, DefaultValues.CodeColors.ConstantsNamesColor, Values.CodeColors.ConstantsNamesColor)
        VerifyKey(Names.CodeColors.ControlsColor, DefaultValues.CodeColors.ControlsColor, Values.CodeColors.ControlsColor)
        VerifyKey(Names.CodeColors.CppCommonColor, DefaultValues.CodeColors.CppCommonColor, Values.CodeColors.CppCommonColor)
        VerifyKey(Names.CodeColors.DataTypesColor, DefaultValues.CodeColors.DataTypesColor, Values.CodeColors.DataTypesColor)
        VerifyKey(Names.CodeColors.DeclaredClassTypesColor, DefaultValues.CodeColors.DeclaredClassTypesColor, Values.CodeColors.DeclaredClassTypesColor)
        VerifyKey(Names.CodeColors.DeclaredInstancesColor, DefaultValues.CodeColors.DeclaredInstancesColor, Values.CodeColors.DeclaredInstancesColor)
        VerifyKey(Names.CodeColors.DeclaredMethodsStyleColor, DefaultValues.CodeColors.DeclaredMethodsStyleColor, Values.CodeColors.DeclaredMethodsStyleColor)
        VerifyKey(Names.CodeColors.ForeColor, DefaultValues.CodeColors.ForeColor, Values.CodeColors.ForeColor)
        VerifyKey(Names.CodeColors.InstanceMethodsStyleColor, DefaultValues.CodeColors.InstanceMethodsStyleColor, Values.CodeColors.InstanceMethodsStyleColor)
        VerifyKey(Names.CodeColors.LineNumbersBackColor, DefaultValues.CodeColors.LineNumbersBackColor, Values.CodeColors.LineNumbersBackColor)
        VerifyKey(Names.CodeColors.LineNumbersColor, DefaultValues.CodeColors.LineNumbersColor, Values.CodeColors.LineNumbersColor)
        VerifyKey(Names.CodeColors.NumbersColor, DefaultValues.CodeColors.NumbersColor, Values.CodeColors.NumbersColor)
        VerifyKey(Names.CodeColors.SameWordsColor, DefaultValues.CodeColors.SameWordsColor, Values.CodeColors.SameWordsColor)
        VerifyKey(Names.CodeColors.StringColor, DefaultValues.CodeColors.StringColor, Values.CodeColors.StringColor)
        VerifyKey(Names.CodeColors.TabsColor, DefaultValues.CodeColors.TabsColor, Values.CodeColors.TabsColor)
        VerifyKey(Names.CodeColors.TabsFontColor, DefaultValues.CodeColors.TabsFontColor, Values.CodeColors.TabsFontColor)
        VerifyKey(Names.CodeColors.TabsHeaderColor, DefaultValues.CodeColors.TabsHeaderColor, Values.CodeColors.TabsHeaderColor)
        VerifyKey(Names.CodeColors.TypeNamesColor, DefaultValues.CodeColors.TypeNamesColor, Values.CodeColors.TypeNamesColor)
    End Sub

    Shared Sub VerifyCodeStylesKeys()
        VerifyKey(Names.CodeStyles.ArduinoKeywordsStyle, DefaultValues.CodeStyles.ArduinoKeywordsStyle, Values.CodeStyles.ArduinoKeywordsStyle)
        VerifyKey(Names.CodeStyles.CommentsStyle, DefaultValues.CodeStyles.CommentsStyle, Values.CodeStyles.CommentsStyle)
        VerifyKey(Names.CodeStyles.CompilerKeysStyle, DefaultValues.CodeStyles.CompilerKeysStyle, Values.CodeStyles.CompilerKeysStyle)
        VerifyKey(Names.CodeStyles.ConstantsNamesStyle, DefaultValues.CodeStyles.ConstantsNamesStyle, Values.CodeStyles.ConstantsNamesStyle)
        VerifyKey(Names.CodeStyles.CppCommonStyle, DefaultValues.CodeStyles.CppCommonStyle, Values.CodeStyles.CppCommonStyle)
        VerifyKey(Names.CodeStyles.DataTypesStyle, DefaultValues.CodeStyles.DataTypesStyle, Values.CodeStyles.DataTypesStyle)
        VerifyKey(Names.CodeStyles.DeclaredClassTypesStyle, DefaultValues.CodeStyles.DeclaredClassTypesStyle, Values.CodeStyles.DeclaredClassTypesStyle)
        VerifyKey(Names.CodeStyles.DeclaredInstancesStyle, DefaultValues.CodeStyles.DeclaredInstancesStyle, Values.CodeStyles.DeclaredInstancesStyle)
        VerifyKey(Names.CodeStyles.DeclaredMethodsStyleStyle, DefaultValues.CodeStyles.DeclaredMethodsStyleStyle, Values.CodeStyles.DeclaredMethodsStyleStyle)
        VerifyKey(Names.CodeStyles.InstanceMethodsStyleStyle, DefaultValues.CodeStyles.InstanceMethodsStyleStyle, Values.CodeStyles.InstanceMethodsStyleStyle)
        VerifyKey(Names.CodeStyles.NumbersStyle, DefaultValues.CodeStyles.NumbersStyle, Values.CodeStyles.NumbersStyle)
        VerifyKey(Names.CodeStyles.SameWordsStyle, DefaultValues.CodeStyles.SameWordsStyle, Values.CodeStyles.SameWordsStyle)
        VerifyKey(Names.CodeStyles.StringStyle, DefaultValues.CodeStyles.StringStyle, Values.CodeStyles.StringStyle)
        VerifyKey(Names.CodeStyles.TypeNamesStyle, DefaultValues.CodeStyles.TypeNamesStyle, Values.CodeStyles.TypeNamesStyle)
    End Sub

    Shared Sub VerifyAutocompleteKeys()
        VerifyKey(Names.AutoCompleteMenu.AllowTabKey, DefaultValues.AutoCompleteMenu.AllowTabKey, Values.AutoCompleteMenu.AllowTabKey)
        VerifyKey(Names.AutoCompleteMenu.AlwaysShowTooltip, DefaultValues.AutoCompleteMenu.AlwaysShowTooltip, Values.AutoCompleteMenu.AlwaysShowTooltip)
        VerifyKey(Names.AutoCompleteMenu.AppearInterval, DefaultValues.AutoCompleteMenu.AppearInterval, Values.AutoCompleteMenu.AppearInterval)
        VerifyKey(Names.AutoCompleteMenu.Enabled, DefaultValues.AutoCompleteMenu.Enabled, Values.AutoCompleteMenu.Enabled)
        VerifyKey(Names.AutoCompleteMenu.MinFragmentLength, DefaultValues.AutoCompleteMenu.MinFragmentLength, Values.AutoCompleteMenu.MinFragmentLength)
        VerifyKey(Names.AutoCompleteMenu.ToolTipDuration, DefaultValues.AutoCompleteMenu.ToolTipDuration, Values.AutoCompleteMenu.ToolTipDuration)
    End Sub

    Shared Sub VerifyWorkspaceKeys()
        VerifyKey(Names.Workspace.FullScreen, DefaultValues.Workspace.FullScreen, Values.Workspace.FullScreen)
        VerifyKey(Names.Workspace.ShowConsole, DefaultValues.Workspace.ShowConsole, Values.Workspace.ShowConsole)
        VerifyKey(Names.Workspace.ShowErrorsTab, DefaultValues.Workspace.ShowErrorsTab, Values.Workspace.ShowErrorsTab)
        VerifyKey(Names.Workspace.ShowFilesList, DefaultValues.Workspace.ShowFilesList, Values.Workspace.ShowFilesList)
        VerifyKey(Names.Workspace.ShowObjectsList, DefaultValues.Workspace.ShowObjectsList, Values.Workspace.ShowObjectsList)
        VerifyKey(Names.Workspace.ShowOutputTab, DefaultValues.Workspace.ShowOutputTab, Values.Workspace.ShowOutputTab)
        VerifyKey(Names.Workspace.ShowSerialMonitorTab, DefaultValues.Workspace.ShowSerialMonitorTab, Values.Workspace.ShowSerialMonitorTab)
        VerifyKey(Names.Workspace.ShowHardwareMonitorTab, DefaultValues.Workspace.ShowHardwareMonitorTab, Values.Workspace.ShowHardwareMonitorTab)
        VerifyKey(Names.Workspace.ShowOutputTab, DefaultValues.Workspace.ShowOutputTab, Values.Workspace.ShowOutputTab)
        VerifyKey(Names.Workspace.ShowDocumentMap, DefaultValues.Workspace.ShowDocumentMap, Values.Workspace.ShowDocumentMap)
        VerifyKey(Names.Workspace.fullPathOnTab, DefaultValues.Workspace.fullPathOnTab, Values.Workspace.fullPathOnTab)
        VerifyKey(Names.Workspace.CodeAreaSplittedDistance, DefaultValues.Workspace.CodeAreaSplittedDistance, Values.Workspace.CodeAreaSplittedDistance)
        VerifyKey(Names.Workspace.WorkAreaSplittedDistance, DefaultValues.Workspace.WorkAreaSplittedDistance, Values.Workspace.WorkAreaSplittedDistance)
    End Sub

    Shared Sub VerifySerialMonitorKeys()
        VerifyKey(Names.SerialMonitor.ShowDate, DefaultValues.SerialMonitor.ShowDate, Values.SerialMonitor.ShowDate)
        VerifyKey(Names.SerialMonitor.ShowMessageOrigin, DefaultValues.SerialMonitor.ShowMessageOrigin, Values.SerialMonitor.ShowMessageOrigin)
        VerifyKey(Names.SerialMonitor.ShowPCmessages, DefaultValues.SerialMonitor.ShowPCmessages, Values.SerialMonitor.ShowPCmessages)
        VerifyKey(Names.SerialMonitor.ShowTime, DefaultValues.SerialMonitor.ShowTime, Values.SerialMonitor.ShowTime)
        VerifyKey(Names.SerialMonitor.ClearOnEnter, DefaultValues.SerialMonitor.ClearOnEnter, Values.SerialMonitor.ClearOnEnter)
    End Sub

    Shared Sub VerifyDirectoriesKeys()
        VerifyKey(Names.Directories.Arduino, DefaultValues.Directories.Arduino, Values.Directories.Arduino)
        VerifyKey(Names.Directories.ArduinoDefaultLib, DefaultValues.Directories.ArduinoDefaultLib, Values.Directories.ArduinoDefaultLib)
        VerifyKey(Names.Directories.ArduinoLib, DefaultValues.Directories.ArduinoLib, Values.Directories.ArduinoLib)
        VerifyKey(Names.Directories.DruidaProjects, DefaultValues.Directories.DruidaProjects, Values.Directories.DruidaProjects)
        VerifyKey(Names.Directories.AditionalLibsDir, DefaultValues.Directories.AditionalLibsDir, Values.Directories.AditionalLibsDir)
        If Not Directory.Exists(Values.Directories.Arduino) Then
            Values.Directories.Arduino = DefaultValues.Directories.Arduino
        End If
        If Not Directory.Exists(Values.Directories.ArduinoCoreLib) Then
            Values.Directories.ArduinoCoreLib = DefaultValues.Directories.ArduinoCoreLib
        End If
        If Not Directory.Exists(Values.Directories.ArduinoDefaultLib) Then
            Values.Directories.ArduinoDefaultLib = DefaultValues.Directories.ArduinoDefaultLib
        End If
        If Not Directory.Exists(Values.Directories.ArduinoLib) Then
            Values.Directories.ArduinoLib = DefaultValues.Directories.ArduinoLib
        End If
        If Not Directory.Exists(Values.Directories.DruidaProjects) Then
            Values.Directories.DruidaProjects = DefaultValues.Directories.DruidaProjects
        End If
    End Sub

    Shared Sub Save()
        SaveAutoCompleteCFGs()
        SaveCodeColorsCFGs()
        SaveCodeStylesCFGs()
        SaveInitializationCFGs()
        SaveTextEditorCFGs()
        SaveWorkspaceCFGs()
        SaveSerialMonitorCFGs()
        SaveDirectoriesCFGs()
    End Sub

    Private Shared Sub SaveTextEditorCFGs()
        SetValue(Names.TextEditor.fontFamily, Values.TextEditor.fontFamily)
        SetValue(Names.TextEditor.fontSize, Values.TextEditor.fontSize)
        SetValue(Names.TextEditor.zoomFactor, Values.TextEditor.zoomFactor)
    End Sub

    Private Shared Sub SaveInitializationCFGs()
        SetValue(Names.Initialization.culture, Values.Initialization.culture)
        SetValue(Names.Initialization.modelFile, Values.Initialization.modelFile)
        SetValue(Names.Initialization.openLastFile, Values.Initialization.openLastFile)
        SetValue(Names.Initialization.openAllFiles, Values.Initialization.openAllFiles)
        SetValue(Names.Initialization.showSplashScreen, Values.Initialization.showSplashScreen)
    End Sub

    Private Shared Sub SaveAutoCompleteCFGs()
        SetValue(Names.AutoCompleteMenu.AllowTabKey, Values.AutoCompleteMenu.AllowTabKey)
        SetValue(Names.AutoCompleteMenu.AlwaysShowTooltip, Values.AutoCompleteMenu.AlwaysShowTooltip)
        SetValue(Names.AutoCompleteMenu.AppearInterval, Values.AutoCompleteMenu.AppearInterval)
        SetValue(Names.AutoCompleteMenu.Enabled, Values.AutoCompleteMenu.Enabled)
        SetValue(Names.AutoCompleteMenu.MinFragmentLength, Values.AutoCompleteMenu.MinFragmentLength)
        SetValue(Names.AutoCompleteMenu.ToolTipDuration, Values.AutoCompleteMenu.ToolTipDuration)
    End Sub

    Shared Sub SaveCodeColorsCFGs()
        SetValue(Names.CodeColors.ArduinoKeywordsColor, Values.CodeColors.ArduinoKeywordsColor)
        SetValue(Names.CodeColors.BackColor, Values.CodeColors.BackColor)
        SetValue(Names.CodeColors.CommentsColor, Values.CodeColors.CommentsColor)
        SetValue(Names.CodeColors.CompilerKeysColor, Values.CodeColors.CompilerKeysColor)
        SetValue(Names.CodeColors.ConstantsNamesColor, Values.CodeColors.ConstantsNamesColor)
        SetValue(Names.CodeColors.ControlsColor, Values.CodeColors.ControlsColor)
        SetValue(Names.CodeColors.CppCommonColor, Values.CodeColors.CppCommonColor)
        SetValue(Names.CodeColors.DataTypesColor, Values.CodeColors.DataTypesColor)
        SetValue(Names.CodeColors.DeclaredClassTypesColor, Values.CodeColors.DeclaredClassTypesColor)
        SetValue(Names.CodeColors.DeclaredInstancesColor, Values.CodeColors.DeclaredInstancesColor)
        SetValue(Names.CodeColors.DeclaredMethodsStyleColor, Values.CodeColors.DeclaredMethodsStyleColor)
        SetValue(Names.CodeColors.ForeColor, Values.CodeColors.ForeColor)
        SetValue(Names.CodeColors.InstanceMethodsStyleColor, Values.CodeColors.InstanceMethodsStyleColor)
        SetValue(Names.CodeColors.LineNumbersBackColor, Values.CodeColors.LineNumbersBackColor)
        SetValue(Names.CodeColors.LineNumbersColor, Values.CodeColors.LineNumbersColor)
        SetValue(Names.CodeColors.NumbersColor, Values.CodeColors.NumbersColor)
        SetValue(Names.CodeColors.SameWordsColor, Values.CodeColors.SameWordsColor)
        SetValue(Names.CodeColors.StringColor, Values.CodeColors.StringColor)
        SetValue(Names.CodeColors.TabsColor, Values.CodeColors.TabsColor)
        SetValue(Names.CodeColors.TabsFontColor, Values.CodeColors.TabsFontColor)
        SetValue(Names.CodeColors.TabsHeaderColor, Values.CodeColors.TabsHeaderColor)
        SetValue(Names.CodeColors.TypeNamesColor, Values.CodeColors.TypeNamesColor)

    End Sub

    Private Shared Sub SaveCodeStylesCFGs()
        SetValue(Names.CodeStyles.ArduinoKeywordsStyle, Values.CodeStyles.ArduinoKeywordsStyle)
        SetValue(Names.CodeStyles.CommentsStyle, Values.CodeStyles.CommentsStyle)
        SetValue(Names.CodeStyles.CompilerKeysStyle, Values.CodeStyles.CompilerKeysStyle)
        SetValue(Names.CodeStyles.ConstantsNamesStyle, Values.CodeStyles.ConstantsNamesStyle)
        SetValue(Names.CodeStyles.CppCommonStyle, Values.CodeStyles.CppCommonStyle)
        SetValue(Names.CodeStyles.DataTypesStyle, Values.CodeStyles.DataTypesStyle)
        SetValue(Names.CodeStyles.DeclaredClassTypesStyle, Values.CodeStyles.DeclaredClassTypesStyle)
        SetValue(Names.CodeStyles.DeclaredInstancesStyle, Values.CodeStyles.DeclaredInstancesStyle)
        SetValue(Names.CodeStyles.DeclaredMethodsStyleStyle, Values.CodeStyles.DeclaredMethodsStyleStyle)
        SetValue(Names.CodeStyles.InstanceMethodsStyleStyle, Values.CodeStyles.InstanceMethodsStyleStyle)
        SetValue(Names.CodeStyles.NumbersStyle, Values.CodeStyles.NumbersStyle)
        SetValue(Names.CodeStyles.SameWordsStyle, Values.CodeStyles.SameWordsStyle)
        SetValue(Names.CodeStyles.StringStyle, Values.CodeStyles.StringStyle)
        SetValue(Names.CodeStyles.TypeNamesStyle, Values.CodeStyles.TypeNamesStyle)
    End Sub

    Private Shared Sub SaveWorkspaceCFGs()
        SetValue(Names.Workspace.FullScreen, Values.Workspace.FullScreen)
        SetValue(Names.Workspace.ShowErrorsTab, Values.Workspace.ShowErrorsTab)
        SetValue(Names.Workspace.ShowFilesList, Values.Workspace.ShowFilesList)
        SetValue(Names.Workspace.ShowObjectsList, Values.Workspace.ShowObjectsList)
        SetValue(Names.Workspace.ShowOutputTab, Values.Workspace.ShowOutputTab)
        SetValue(Names.Workspace.ShowSerialMonitorTab, Values.Workspace.ShowSerialMonitorTab)
        SetValue(Names.Workspace.ShowHardwareMonitorTab, Values.Workspace.ShowHardwareMonitorTab)
        SetValue(Names.Workspace.ShowDocumentMap, Values.Workspace.ShowDocumentMap)
        SetValue(Names.Workspace.ShowConsole, Values.Workspace.ShowConsole)
        SetValue(Names.Workspace.FullPathOnTab, Values.Workspace.FullPathOnTab)
        SetValue(Names.Workspace.CodeAreaSplittedDistance, Values.Workspace.CodeAreaSplittedDistance)
        SetValue(Names.Workspace.WorkAreaSplittedDistance, Values.Workspace.WorkAreaSplittedDistance)
    End Sub

    Private Shared Sub SaveSerialMonitorCFGs()
        SetValue(Names.SerialMonitor.ShowDate, Values.SerialMonitor.ShowDate)
        SetValue(Names.SerialMonitor.ShowMessageOrigin, Values.SerialMonitor.ShowMessageOrigin)
        SetValue(Names.SerialMonitor.ShowPCmessages, Values.SerialMonitor.ShowPCmessages)
        SetValue(Names.SerialMonitor.ShowTime, Values.SerialMonitor.ShowTime)
        SetValue(Names.SerialMonitor.ClearOnEnter, Values.SerialMonitor.ClearOnEnter)
    End Sub

    Private Shared Sub SaveDirectoriesCFGs()
        SetValue(Names.Directories.Arduino, Values.Directories.Arduino)
        SetValue(Names.Directories.ArduinoCoreLib, Values.Directories.ArduinoCoreLib)
        SetValue(Names.Directories.ArduinoDefaultLib, Values.Directories.ArduinoDefaultLib)
        SetValue(Names.Directories.ArduinoLib, Values.Directories.ArduinoLib)
        SetValue(Names.Directories.BackupDir, Values.Directories.BackupDir)
        SetValue(Names.Directories.CompilerTempDir, Values.Directories.CompilerTempDir)
        SetValue(Names.Directories.DruidaProjects, Values.Directories.DruidaProjects)
        SetValue(Names.Directories.AditionalLibsDir, Values.Directories.AditionalLibsDir)
    End Sub

    ''' <summary>
    ''' Checks integrity of a key value, and sets it to default if is empty or ocourred an error
    ''' </summary>
    Shared Sub VerifyKey(ByVal name As String, ByVal defaultValue As String, ByRef var As String)
        If GetValue(name) = "Erro" Or GetValue(name) = "Nothing" Or GetValue(name) = "" Then
            SetValue(name, defaultValue)
            var = defaultValue
        Else
            var = GetValue(name)
        End If
    End Sub

    ''' <summary>
    ''' Get the content of selected model file
    ''' </summary>
    ''' <returns>Content of selected model file</returns>
    Shared Function GetModelContent() As String
        Return File.ReadAllText(GetValue(Names.Initialization.modelFile))
    End Function

    Shared Function GetModelContent(model As String)
        Return File.ReadAllText(model)
    End Function

    ''' <summary>
    ''' Search in installed fonts for a fontFamily
    ''' </summary>
    ''' <param name="name">Name of fontFamily</param>
    ''' <returns>fontFamily</returns>
    Shared Function GetFontFamily(ByVal name As String) As FontFamily
        Dim fontFamilies() As FontFamily = New InstalledFontCollection().Families
        Dim fontNames As New List(Of String)
        For Each fontFamilie As FontFamily In fontFamilies
            fontNames.Add(fontFamilie.Name)
        Next
        If fontNames.IndexOf(name) = -1 Then
            Return GetFontFamily("Consolas")
        End If
        Dim family = fontFamilies(fontNames.IndexOf(name))
        Return family
    End Function

    Shared Sub ApplyThemeInControlGroup(controlGroup)
        Try
            controlGroup.BackColor = Color.FromArgb(Values.CodeColors.BackColor)
            For Each control In controlGroup.Controls
                ApplyThemeInControl(control)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Shared Sub ApplyThemeInControl(control As Object)
        If control.GetType = GetType(TextBox) Then
            control.BackColor = Color.FromArgb(Values.CodeColors.BackColor)
        End If
        If control.GetType = GetType(RichTextBox) Then
            control.BackColor = Color.FromArgb(Values.CodeColors.BackColor)
            control.SelectAll()
            control.SelectionColor = Color.FromArgb(Values.CodeColors.ForeColor)
            control.SelectionLength = 0
        End If
        If control.GetType = GetType(Label) Then
            control.BackColor = Color.FromArgb(Values.CodeColors.BackColor)
        End If
        If control.GetType = GetType(ToolStrip) Then
            control.BackColor = Color.FromArgb(Values.CodeColors.ControlsColor)
            For Each button In control.Items
                If button.GetType = GetType(ToolStripButton) Then
                    Dim bt As ToolStripButton = button
                    AddHandler bt.MouseEnter, AddressOf IDEcfgs.adjustFontColors_MouseEnter
                    AddHandler bt.MouseLeave, AddressOf IDEcfgs.adjustFontColors_MouseLeave
                End If
            Next
        End If
        If control.GetType = GetType(ComboBox) Then
            control.BackColor = Color.FromArgb(Values.CodeColors.BackColor)
            control.ForeColor = Color.FromArgb(Values.CodeColors.ForeColor)
        End If
        control.ForeColor = Color.FromArgb(Values.CodeColors.ForeColor)
    End Sub

    Shared Sub adjustFontColors_MouseEnter(sender As Object, e As EventArgs)
        sender.ForeColor = Color.Black
    End Sub

    Shared Sub adjustFontColors_MouseLeave(sender As Object, e As EventArgs)
        AdjustForeColor(sender)
    End Sub

    Shared Sub AdjustForeColor(sender As Object)
        If sender.Checked Then
            sender.ForeColor = Color.Black
        Else
            sender.ForeColor = Color.FromArgb(Values.CodeColors.ForeColor)
        End If
    End Sub
End Class
