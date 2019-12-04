Imports System.IO

Module myProjectCfgs
    ''' <summary>
    ''' Management of Project Cfgs
    ''' </summary>
    '''
    Public CurrentProjectCfgs As New ProjectCfgs
End Module

Public Class ProjectCfgs
    Private myCfgs As New FileVarSystem
    Public values As New MyValues

    Public Sub SetFilePath(path As String)
        myCfgs.SetFilePath(path)
        VerifyCFGs()
    End Sub

    ''' <summary>
    ''' Variable names of cfg file
    ''' </summary>
    Structure Names
        Structure Hardware
            Const COMport = "COMport"
            Const baudRate = "baudRate"
            Const selectedBoardName = "boardName"
            Const finalizer = "finalizer"
        End Structure
        Structure FileNames
            Const headerFile = "headerFile"
        End Structure
        Structure ProjectInfo
            Const title = "title"
            Const author = "author"
            Const company = "company"
            Const description = "description"
            Const version = "version"
            Const notes = "notes"
        End Structure
    End Structure

    Structure DefaultValues
        Structure Hardware
            Const COMport = "COM0"
            Const baudRate = "9600"
            Const selectedBoarName = "Arduino UNO"
            Const finalizer = "Nenhum"
        End Structure
        Structure FileNames
            Shared Function headerFile() As String
                Dim cultureResx As New CultureManager
                Dim file = cultureResx.translateFile(CodeInfo.HeaderFiles.DefaultHeader)
                Return file
            End Function
        End Structure
        Structure ProjectInfo
            Shared title = CurrentProjectInfo.General.title
            Shared author = CurrentProjectInfo.General.author
            Shared company = CurrentProjectInfo.General.company
            Shared description = CurrentProjectInfo.General.description
            Shared version = CurrentProjectInfo.Version.getVersion
            Shared notes = CurrentProjectInfo.General.notes
        End Structure
    End Structure

    Class MyValues
        Public hardware As New MyHardware
        Public fileNames As New MyFileNames
        Class MyHardware
            Public COMport As String = ""
            Public baudRate As String = ""
            Public selectedBoardName As String = ""
            Public finalizer As String = ""
        End Class
        Class MyFileNames
            Public headerFile As String = ""
        End Class
    End Class

    Private Function GetValue(name As String)
        Return (myCfgs.ReadVar(name))
    End Function

    Private Sub SetValue(name As String, value As String)
        myCfgs.WriteVar(name, value)
    End Sub

    Private Sub VerifyCFGs()
        VerifyCFGsHardware()
        VerifyCFGsFileNames()
        VerifyCFGsProjectInfo()
    End Sub

    Private Sub VerifyCFGsHardware()
        VerifyVar(Names.Hardware.baudRate, DefaultValues.Hardware.baudRate, values.hardware.baudRate)
        VerifyVar(Names.Hardware.selectedBoardName, DefaultValues.Hardware.selectedBoarName, values.hardware.selectedBoardName)
        VerifyVar(Names.Hardware.COMport, DefaultValues.Hardware.COMport, values.hardware.COMport)
        VerifyVar(Names.Hardware.finalizer, DefaultValues.Hardware.finalizer, values.hardware.finalizer)
    End Sub

    Private Sub VerifyCFGsFileNames()
        If Not File.Exists(GetValue(Names.FileNames.headerFile)) Then
            SetValue(Names.FileNames.headerFile, "Erro")
        End If
        VerifyVar(Names.FileNames.headerFile, DefaultValues.FileNames.headerFile, values.fileNames.headerFile)
    End Sub

    Private Sub VerifyCFGsProjectInfo()
        VerifyVar(Names.ProjectInfo.author, DefaultValues.ProjectInfo.author, CurrentProjectInfo.General.author)
        VerifyVar(Names.ProjectInfo.company, DefaultValues.ProjectInfo.company, CurrentProjectInfo.General.company)
        VerifyVar(Names.ProjectInfo.description, DefaultValues.ProjectInfo.description, CurrentProjectInfo.General.description)
        VerifyVar(Names.ProjectInfo.notes, DefaultValues.ProjectInfo.notes, CurrentProjectInfo.General.notes)
        VerifyVar(Names.ProjectInfo.title, DefaultValues.ProjectInfo.title, CurrentProjectInfo.General.title)
        VerifyVar(Names.ProjectInfo.version, DefaultValues.ProjectInfo.version, CurrentProjectInfo.Version.getVersion)
        Dim version() As String = CurrentProjectInfo.Version.getVersion.Split(".")
        CurrentProjectInfo.Version.major = version(0)
        CurrentProjectInfo.Version.minor = version(0)
        CurrentProjectInfo.Version.build = version(0)
        CurrentProjectInfo.Version.revision = version(0)
    End Sub

    Private Sub VerifyVar(ByVal name As String, ByVal defaultValue As String, ByRef variable As String)
        Dim currentValue As String = GetValue(name)
        If currentValue = "Erro" Then
            SetValue(name, defaultValue)
            variable = defaultValue
        Else
            variable = currentValue
        End If
    End Sub

    Public Sub Save()
        SaveHardware()
        SaveFileNames()
        SaveProjectInfo()
    End Sub

    Private Sub SaveHardware()
        SetValue(Names.Hardware.baudRate, values.hardware.baudRate)
        SetValue(Names.Hardware.COMport, values.hardware.COMport)
        SetValue(Names.Hardware.selectedBoardName, values.hardware.selectedBoardName)
        SetValue(Names.Hardware.finalizer, values.hardware.finalizer)
    End Sub

    Private Sub SaveFileNames()
        SetValue(Names.FileNames.headerFile, values.fileNames.headerFile)
    End Sub

    Private Sub SaveProjectInfo()
        SetValue(Names.ProjectInfo.author, CurrentProjectInfo.General.author)
        SetValue(Names.ProjectInfo.company, CurrentProjectInfo.General.company)
        SetValue(Names.ProjectInfo.description, CurrentProjectInfo.General.description)
        SetValue(Names.ProjectInfo.notes, CurrentProjectInfo.General.notes)
        SetValue(Names.ProjectInfo.title, CurrentProjectInfo.General.title)
        SetValue(Names.ProjectInfo.version, CurrentProjectInfo.Version.getVersion)
    End Sub

    Public Function GetHeader(ByVal filePath As String, ByVal descr As String) As String
        Dim fileInfo As New FileInfo(filePath)
        Dim content As String = File.ReadAllText(GetValue(Names.FileNames.headerFile))
        content = content.Replace("%PROJECT%", CurrentProjectInfo.General.title)
        content = content.Replace("%FILE%", fileInfo.Name)
        content = content.Replace("%DESCR%", descr)
        content = content.Replace("%DATA%", Now.Date)
        Return content
    End Function

End Class
