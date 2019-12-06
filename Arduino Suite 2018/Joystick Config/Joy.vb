Public Class Joy
    Private FileControl As New FileVarSystem
    Public name As String
    Public port As UInt16 = 0
    Public anEsqXMin, anEsqXMax As Int32
    Public anEsqYMin, anEsqYMax As Int32
    Public anDirXMin, anDirXMax As Int32
    Public anDirYMin, anDirYMax As Int32
    Public gatEsqMin, gatEsqMax As Int32
    Public gatDirMin, gatDirMax As Int32
    Public aceleradorMin, aceleradorMax As Int32
    Public embreagemMin, embreagemMax As Int32
    Public freioMin, freioMax As Int32
    Public volanteMin, volanteMax As Int32
    Public fileJoy As String = applicationDirectory & "\Config Files\Joy.cfg"
    Public fileG27 As String = applicationDirectory & "\Config Files\G27.cfg"

    Public Sub OpenFileJoy(ByVal operation As String)
        Dim nameList() As String = {"port", "name",
                                    "anEsqXMin", "anEsqXMax",
                                    "anEsqYMin", "anEsqYMax",
                                    "anDirXMin", "anDirXMax",
                                    "anDirYMin", "anDirYMax",
                                    "gatEsqMin", "gatEsqMax",
                                    "gatDirMin", "gatDirMax"}
        Dim dataList() As String = {port, name,
                                    anEsqXMin, anEsqXMax,
                                    anEsqYMin, anEsqYMax,
                                    anDirXMin, anDirXMax,
                                    anDirYMin, anDirYMax,
                                    gatEsqMin, gatEsqMax,
                                    gatDirMin, gatDirMax}
        FileControl.SetFilePath(fileJoy)
        FileControl.SetSeparator("=")
        If (operation = "save") Then
            FileControl.SaveData(nameList, dataList)
        End If
        If (operation = "load") Then
            FileControl.LoadData(nameList, dataList)
            joyMergeList(dataList)
        End If
    End Sub

    Public Sub OpenFileG27(ByVal operation As String)
        Dim nameList() As String = {"port", "name",
                                    "aceleradorMin", "aceleradorMax",
                                    "embreagemMin", "embreagemMax",
                                    "freioMin", "freioMax",
                                    "volanteMin", "volanteMax"}
        Dim dataList() As String = {port, name,
                                    aceleradorMin, aceleradorMax,
                                    embreagemMin, embreagemMax,
                                    freioMin, freioMax,
                                    volanteMin, volanteMax}
        FileControl.SetFilePath(fileJoy)
        FileControl.SetSeparator("=")
        If (operation = "save") Then
            FileControl.SaveData(nameList, dataList)
        End If
        If (operation = "load") Then
            FileControl.LoadData(nameList, dataList)
            g27MergeList(dataList)
        End If
    End Sub

    Private Sub joyMergeList(ByVal dataList() As String)
        port = dataList(0)
        name = dataList(1)
        anEsqXMin = dataList(2)
        anEsqXMax = dataList(3)
        anEsqYMin = dataList(4)
        anEsqYMax = dataList(5)
        anDirXMin = dataList(6)
        anDirXMax = dataList(7)
        anDirYMin = dataList(8)
        anDirYMax = dataList(9)
        gatEsqMin = dataList(10)
        gatEsqMax = dataList(11)
        gatDirMin = dataList(12)
        gatDirMax = dataList(13)
    End Sub

    Private Sub g27MergeList(ByVal dataList() As String)
        port = dataList(0)
        name = dataList(1)
        aceleradorMin = dataList(2)
        aceleradorMax = dataList(3)
        embreagemMin = dataList(4)
        embreagemMax = dataList(5)
        freioMin = dataList(6)
        freioMax = dataList(7)
        volanteMin = dataList(8)
        volanteMax = dataList(9)
    End Sub
End Class
