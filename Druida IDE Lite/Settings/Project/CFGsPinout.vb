Imports Common
Imports Druida_IDE_Lite.CurrentProjectInfo
Imports System.IO
Public Class CFGsPinout
    Dim myPins As New Pins

    Public Sub ApplyTheme()
        IDEcfgs.ApplyThemeInControlGroup(Me)
    End Sub

    Private Sub CreateNewPin()
        Dim locationX As UInt16 = myPins.data.Last.Location.X
        Dim locationY As UInt16 = myPins.data.Last.Location.Y + (-myPins.data.Last.Size.Height * (myPins.data.Count <> 1))
        Dim newPin As Pinout = New Pinout(locationX, locationY)
        newPin.Size = myPins.data.Last.Size
        newPin.Anchor = AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Left
        newPin.tbPin.Text = myPins.data.Count - 1
        newPin.tbName.Text = "pin" & myPins.data.Count - 1
        newPin.cbType.SelectedIndex = 0
        myPins.data.Add(newPin)
        Me.Controls.Add(newPin)
    End Sub

    Private Sub PutPinsOnScreen()
        For i = 0 To myPins.data.Count - 1
            Dim pin = myPins.data(i)
            If i > 0 Then
                Dim locationX As UInt16 = myPins.data(i - 1).Location.X
                Dim locationY As UInt16 = myPins.data(i - 1).Location.Y + (-myPins.data.Last.Size.Height * (i <> 1))
                pin.Location = New Point(locationX, locationY)
                'pin.Size = Pinout1.Size
            End If
            Me.Controls.Add(pin)
        Next
    End Sub

    Private Sub ClearPins(clearData As Boolean)
        For Each pin In myPins.data
            Controls.Remove(pin)
        Next
        For Each pin In myPins.data
            If pin IsNot Pinout1 Then
                Controls.Remove(pin)
            End If
        Next
    End Sub

    Private Sub CFGsPinout_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearPins(True)
        If File.Exists(DirectoryPaths.pinoutDllFile) Then
            myPins.Load(Pinout1)
            myPins.data(0).Location = Pinout1.Location
            myPins.data(0).Size = Pinout1.Size
            Pinout1.tbPin.Text = myPins.data(0).tbPin.Text
            Pinout1.tbName.Text = myPins.data(0).tbName.Text
            Pinout1.cbType.SelectedItem = myPins.data(0).cbType.SelectedItem
            Pinout1.tbDescription.Text = myPins.data(0).tbDescription.Text
            PutPinsOnScreen()
        Else
            InitializePins()
        End If
        ApplyTheme()
    End Sub

    Private Sub InitializePins()
        myPins.data.Add(Pinout1)
        'CreateNewPin()
        'Pinout1.tbPin.Text = "0"
        'Pinout1.tbName.Text = "pinoRX"
        'Pinout1.cbType.SelectedIndex = 3
        'Pinout1.tbDescription.Text = "Pino reservado para troca de informações."
        'myPins.data(1).tbPin.Text = "1"
        'myPins.data(1).tbName.Text = "pinoTX"
        'myPins.data(1).cbType.SelectedIndex = 3
        'myPins.data(1).tbDescription.Text = "Pino reservado para troca de informações."
    End Sub

    Private Sub BtAddPin_Click(sender As Object, e As EventArgs) Handles tsbtAdd.Click
        CreateNewPin()
    End Sub

    Private Sub removePin(pin As Pinout)
        If pin IsNot Pinout1 Then
            ClearPins(False)
            myPins.data.Remove(pin)
            PutPinsOnScreen()
        End If
    End Sub

    Private Sub moveUp(pin As Pinout)
        If pin IsNot Pinout1 Then
            ClearPins(False)
            Dim index = myPins.data.IndexOf(pin) - 1
            myPins.data.Remove(pin)
            myPins.data.Insert(index, pin)
            PutPinsOnScreen()
        End If
    End Sub

    Private Sub moveDown(pin As Pinout)
        If pin IsNot Pinout1 And pin IsNot myPins.data.Last Then
            ClearPins(False)
            Dim index = myPins.data.IndexOf(pin) + 1
            myPins.data.Remove(pin)
            myPins.data.Insert(index, pin)
            PutPinsOnScreen()
        End If
    End Sub

    Private Sub CFGsPinout_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        If e.Control.GetType = GetType(Pinout) Then
            Dim pin As Pinout = e.Control
            AddHandler pin.remove, AddressOf removePin
            AddHandler pin.moveUp, AddressOf moveUp
            AddHandler pin.moveDown, AddressOf moveDown
        End If
    End Sub

    Private Sub CFGsPinout_ControlRemoved(sender As Object, e As ControlEventArgs) Handles Me.ControlRemoved
        If e.Control.GetType = GetType(Pinout) Then
            Dim pin As Pinout = e.Control
            RemoveHandler pin.remove, AddressOf removePin
            RemoveHandler pin.moveUp, AddressOf moveUp
            RemoveHandler pin.moveDown, AddressOf moveDown
        End If
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles tsbtSave.Click
        controlGeneralEditor.CloseTab("pins.h")
        myPins.Save()
        ImportFile()
        CratePinsCodeFile()
        controlExplorer.OpenCodeFile("pins.h")
    End Sub

    'Private Sub TsbtImport_Click(sender As Object, e As EventArgs) Handles tsbtImport.Click
    '    ImportFile()
    '    CratePinsCodeFile()
    'End Sub

    Private Sub CratePinsCodeFile()
        Dim cultureResx As New CultureManager
        Dim content As String = ""
        Dim descr As String = cultureResx.translateText("Descrição e configuração dos pinos")
        content &= vbLf
        content &= "#ifndef pins_h" & vbLf
        content &= "#define pins_h" & vbLf
        content &= GetPinsDefinitions()
        content &= GetPinsConfiguratons()
        content &= vbLf
        content &= "#endif"
        ProjectActions.CreateFile.Create(content, DirectoryPaths.pinoutCodeFile, descr)
    End Sub

    Private Function GetPinsDefinitions()
        Dim text As String = vbCrLf
        For Each pin As Pinout In myPins.data
            If pin.myData.pinName <> "" And pin.myData.pinNumber <> "" Then
                text &= pin.myData.getPinDefinition & vbCrLf
            End If
        Next
        text &= vbCrLf
        Return text
    End Function

    Private Function GetPinsConfiguratons()
        Dim text As String = vbCrLf
        text &= "void pins_setup()" & vbCrLf & "{" & vbCrLf
        For Each pin As Pinout In myPins.data
            If pin.myData.pinName <> "" And pin.myData.pinNumber <> "" Then
                text &= pin.myData.getPinSetup
            End If
        Next
        text &= "}" & vbCrLf
        Return text
    End Function

    Private Sub ImportFile()
        ProjectActions.OpenFile.Open(CurrentProjectInfo.DirectoryPaths.mainCodeFile)
        If Not File.Exists(CurrentProjectInfo.DirectoryPaths.pinoutCodeFile) Then
            CodeManager.Actions.AddSetup("    pins_setup();")
            CodeManager.Actions.IncludeLibrary("pins.h")
        End If
    End Sub
End Class

Class Pins
    Public data As New List(Of Pinout)
    Public dataStr As New PinsData

    Public Sub Save()
        dataStr.data.Clear()
        Dim count = 0
        For Each pinout In data
            If count <> 0 Then
                dataStr.data.Add(pinout.myData)
            End If
            count += 1
        Next
        AssemblyDataType.Save(Of PinsData)(dataStr, DirectoryPaths.pinoutDllFile, "Pinout", "Data")
    End Sub

    Public Sub Load(pinModel As Pinout)
        data.Clear()
        dataStr = AssemblyDataType.Load(Of PinsData)(DirectoryPaths.pinoutDllFile, "Pinout", "Data")
        data.Clear()
        data.Add(pinModel)
        For Each pinout In dataStr.data
            Dim newpin As New Pinout()
            newpin.Size = pinModel.Size
            newpin.Anchor = AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Left
            newpin.myData = pinout
            newpin.LoadPin()
            data.Add(newpin)
        Next
    End Sub
End Class

Class PinsData
    Public data As New List(Of PinoutClass)
End Class

