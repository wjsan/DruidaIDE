Imports System.Windows.Forms
Imports System.IO.Ports
Public Class BqBus
    Private mySerial As SerialPort
    Private mySerialMonitor As TextBox
    Private previousRegs As String()
    Private regs As String()
    Private changedRegs As New List(Of UInt16)
    Private currentError As String = ""
    Private msg As String = ""
    WithEvents timerTryOpen As New Timer()

    Public Event DataReceived()

    Public Sub New(serial As SerialPort)
        mySerial = serial
        timerTryOpen.Interval = 500
    End Sub

    Public Sub SetSerialMonitor(mserial As TextBox)
        mySerialMonitor = mserial
    End Sub

    Private Sub SerialAvailable(sender As Object, e As SerialDataReceivedEventArgs)
        RaiseEvent DataReceived()
        timerTryOpen.Stop()
        previousRegs = regs
        Try
            msg = mySerial.ReadTo("_")
            AppendMessage(msg)
            regs = msg.Split(".")
        Catch ex As Exception
            currentError = ex.Message
            RaiseEvent SerialError()
        End Try
        MantainChangedRegs()
        Response()
    End Sub

    Private Sub MantainChangedRegs()
        For i = 0 To changedRegs.Count - 1
            Dim changedReg = changedRegs(i)
            regs(changedReg) = previousRegs(changedReg)
        Next
        changedRegs.Clear()
    End Sub

    Private Sub Response()
        Dim serialResponse As String = ""
        If regs Is Nothing Then Exit Sub
        For i = 0 To regs.Length - 1
            Dim reg = regs(i)
            serialResponse &= reg
            If i <> regs.Length - 1 Then
                serialResponse &= "."
            Else
                serialResponse &= "_"
            End If
        Next
        If mySerial.IsOpen Then
            mySerial.Write(serialResponse)
        End If
    End Sub

    Public Event SerialError()

    Public Sub Begin()
        AddHandler mySerial.DataReceived, AddressOf SerialAvailable
        Try
            mySerial.Open()
            mySerial.Write("_")
            timerTryOpen.Start()
        Catch ex As Exception
            currentError = ex.Message
            RaiseEvent SerialError()
        End Try
    End Sub

    Public Sub timerTryOpen_Tick() Handles timerTryOpen.Tick
        Static Dim cont = 0
        mySerial.Write("_")
        Response()
        If cont = 3 Then
            timerTryOpen.Stop()
            Interrupt()
            cont = 0
            MessageBox.Show("Não houve resposta da rede BqBus")
        End If
        cont += 1
    End Sub

    Public Sub Interrupt()
        If mySerial.IsOpen Then
            Try
                RemoveHandler mySerial.DataReceived, AddressOf SerialAvailable
                System.Threading.Thread.Sleep(1000)
                mySerial.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub SetReg(reg As UInt16, value As String)
        regs(reg) = value
        changedRegs.Add(reg)
    End Sub

    Public Sub SetRegByte(reg As UInt16, byteN As Byte, value As String)
        If mySerial.IsOpen Then
            Dim regValue As Int16 = regs(reg)
            Dim bytes() As Byte = BitConverter.GetBytes(regValue)
            bytes(byteN) = value
            regValue = BitConverter.ToInt16(bytes, 0)
            regs(reg) = regValue
            changedRegs.Add(reg)
        End If
    End Sub

    Public Sub SetRegBit(reg As UInt16, bit As Byte, value As Boolean)
        If mySerial.IsOpen Then
            Try
                If value Then
                    regs(reg) = regs(reg) Or 2 ^ (bit)
                Else
                    regs(reg) = regs(reg) Or 2 ^ (bit)
                    regs(reg) = regs(reg) Xor 2 ^ (bit)
                End If
                changedRegs.Add(reg)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub ReverseBit(reg As UInt16, bit As Byte)
        If mySerial.IsOpen Then
            Try
                regs(reg) = regs(reg) Xor 2 ^ (bit)
                changedRegs.Add(reg)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Function GetReg(reg As UInt16) As String
        If mySerial.IsOpen Then
            Try
                Return regs(reg)
            Catch ex As Exception

            End Try
        End If
    End Function

    Public Function GetRegByte(reg As UInt16, byteN As Byte) As String
        If mySerial.IsOpen Then
            Try
                Dim regVal As Int16 = regs(reg)
                Dim bytes() As Byte = BitConverter.GetBytes(regVal)
                Dim byteVal As Byte = bytes(byteN)
                Return byteVal
            Catch ex As Exception

            End Try
        End If
    End Function

    Public Function GetRegBit(reg As UInt16, bit As Byte)
        If mySerial.IsOpen Then
            Try
                Dim val As Int32 = regs(reg)
                Dim newVal As String = Convert.ToString(val, 2).PadLeft(32, "0"c) '32 bits
                newVal = StrReverse(newVal)
                Dim bitR As Boolean
                bitR = newVal(bit) = "1"
                Return bitR
            Catch ex As Exception

            End Try
        End If
    End Function

    Public Function GetRegsCount() As UInt16
        If regs IsNot Nothing Then
            Return regs.Count
        Else
            Return 0
        End If
    End Function

    Public Function GetMsg() As String
        Return msg
    End Function

    Public Function GetRegAddres(index As UInt16)
        If index < 0 Then Return Nothing
        Dim reg As UInt16 = index \ 16
        Return reg
    End Function

    Public Function GetBitAddres(index As UInt16)
        If index < 0 Then Return Nothing
        Dim reg As UInt16 = index \ 16
        Dim bit As UInt16 = index - reg * 16
        Return bit
    End Function

    Public Sub GetAddres(index As UInt16, ByRef reg As String, ByRef bit As String)
        If index < 0 Then Exit Sub
        reg = index \ 16
        bit = index - reg * 16
    End Sub

    Private Sub AppendMessage(text As String)
        If mySerialMonitor Is Nothing Then Exit Sub
        Try
            mySerialMonitor.Invoke(Sub()
                                       Try
                                           mySerialMonitor.AppendText(text & vbCrLf)
                                       Catch ex As Exception

                                       End Try
                                   End Sub)
        Catch ex As Exception

        End Try
        'SerialMonitorTool.SerialMonitor.Invoke(Sub()
        '                                           SerialMonitorTool.SerialMonitor.AppendText(text)
        '                                       End Sub)
    End Sub

End Class
