Module GerenciaFerramentasIOMonitor
    Public Sub VisibilidadePaineis(type As Byte)
        If (type < 2) Then
            Ferramentas.GroupBox3.Visible = False
            Ferramentas.GroupBox4.Visible = False
            Ferramentas.GroupBox5.Visible = False
        ElseIf (Type <> 3) Then
            Ferramentas.GroupBox3.Visible = True
            Ferramentas.GroupBox4.Visible = True
            Ferramentas.GroupBox5.Visible = True
        End If
    End Sub
    Public Sub VisibilidadeAnalogicas(type As Byte)
        If (type = 1) Then
            Ferramentas.GroupBox6.Location = New Point(Ferramentas.GroupBox6.Location.X, 172)
            Ferramentas.LabelA6.Visible = False
            Ferramentas.LabelA7.Visible = False
            Ferramentas.LabelA8.Visible = False
            Ferramentas.LabelA9.Visible = False
            Ferramentas.LabelA10.Visible = False
            Ferramentas.LabelA11.Visible = False
            Ferramentas.LabelA12.Visible = False
            Ferramentas.LabelA13.Visible = False
            Ferramentas.LabelA14.Visible = False
            Ferramentas.LabelA15.Visible = False
            Ferramentas.TextBox76.Visible = False
            Ferramentas.TextBox77.Visible = False
            Ferramentas.TextBox78.Visible = False
            Ferramentas.TextBox79.Visible = False
            Ferramentas.TextBox80.Visible = False
            Ferramentas.TextBox81.Visible = False
            Ferramentas.TextBox82.Visible = False
            Ferramentas.TextBox83.Visible = False
            Ferramentas.TextBox84.Visible = False
            Ferramentas.TextBox85.Visible = False
        End If
    End Sub
    Public Sub VisibilidadePWM(type As Byte)
        If (type = 1) Then
            Ferramentas.GroupBox7.Location = New Point(Ferramentas.GroupBox7.Location.X, 247)
            Ferramentas.LabelPWM2.Visible = False
            Ferramentas.LabelPWM4.Visible = False
            Ferramentas.LabelPWM7.Visible = False
            Ferramentas.LabelPWM8.Visible = False
            Ferramentas.LabelPWM12.Visible = False
            Ferramentas.LabelPWM13.Visible = False
            Ferramentas.LabelPWM43.Visible = False
            Ferramentas.LabelPWM44.Visible = False
            Ferramentas.LabelPWM45.Visible = False
            Ferramentas.TextBox92.Visible = False
            Ferramentas.TextBox94.Visible = False
            Ferramentas.TextBox97.Visible = False
            Ferramentas.TextBox98.Visible = False
            Ferramentas.TextBox102.Visible = False
            Ferramentas.TextBox103.Visible = False
            Ferramentas.TextBox143.Visible = False
            Ferramentas.TextBox144.Visible = False
            Ferramentas.TextBox145.Visible = False
        End If
    End Sub
    Public Sub visibilidadeEstados(type As Byte)
        If (type = 1) Then
            Ferramentas.Label23.Visible = False
        Ferramentas.Label24.Visible = False
        Ferramentas.Label25.Visible = False
        Ferramentas.Label26.Visible = False
        Ferramentas.Label27.Visible = False
        Ferramentas.Label28.Visible = False
        Ferramentas.Label29.Visible = False
        Ferramentas.Label30.Visible = False
        Ferramentas.Label31.Visible = False
        Ferramentas.Label32.Visible = False
        Ferramentas.Label33.Visible = False
        Ferramentas.Label34.Visible = False
        Ferramentas.Label35.Visible = False
        Ferramentas.Label36.Visible = False
        Ferramentas.TextBox20.Visible = False
        Ferramentas.TextBox21.Visible = False
        Ferramentas.TextBox22.Visible = False
        Ferramentas.TextBox23.Visible = False
        Ferramentas.TextBox24.Visible = False
        Ferramentas.TextBox25.Visible = False
        Ferramentas.TextBox26.Visible = False
        Ferramentas.TextBox27.Visible = False
        Ferramentas.TextBox28.Visible = False
        Ferramentas.TextBox29.Visible = False
        Ferramentas.TextBox30.Visible = False
        Ferramentas.TextBox31.Visible = False
        Ferramentas.TextBox32.Visible = False
            Ferramentas.TextBox33.Visible = False
        End If
    End Sub
    Public Sub escreveTextBoxWord0(bits As String)
        bits = StrReverse(bits)
        Ferramentas.TextBox2.Text = bits(0)
        Ferramentas.TextBox3.Text = bits(1)
        Ferramentas.TextBox4.Text = bits(2)
        Ferramentas.TextBox5.Text = bits(3)
        Ferramentas.TextBox6.Text = bits(4)
        Ferramentas.TextBox7.Text = bits(5)
        Ferramentas.TextBox8.Text = bits(6)
        Ferramentas.TextBox9.Text = bits(7)
        Ferramentas.TextBox10.Text = bits(8)
        Ferramentas.TextBox11.Text = bits(9)
        Ferramentas.TextBox12.Text = bits(10)
        Ferramentas.TextBox13.Text = bits(11)
        Ferramentas.TextBox14.Text = bits(12)
        Ferramentas.TextBox15.Text = bits(13)
        Ferramentas.TextBox16.Text = bits(14)
        Ferramentas.TextBox17.Text = bits(15)
    End Sub
    Public Sub escreveTextBoxWord1(bits As String)
        bits = StrReverse(bits)
        Ferramentas.TextBox18.Text = bits(0)
        Ferramentas.TextBox19.Text = bits(1)
        Ferramentas.TextBox20.Text = bits(2)
        Ferramentas.TextBox21.Text = bits(3)
        Ferramentas.TextBox22.Text = bits(4)
        Ferramentas.TextBox23.Text = bits(5)
        Ferramentas.TextBox24.Text = bits(6)
        Ferramentas.TextBox25.Text = bits(7)
        Ferramentas.TextBox26.Text = bits(8)
        Ferramentas.TextBox27.Text = bits(9)
        Ferramentas.TextBox28.Text = bits(10)
        Ferramentas.TextBox29.Text = bits(11)
        Ferramentas.TextBox30.Text = bits(12)
        Ferramentas.TextBox31.Text = bits(13)
        Ferramentas.TextBox32.Text = bits(14)
        Ferramentas.TextBox33.Text = bits(15)
    End Sub
    Public Sub escreveTextBoxWord2(bits As String)
        bits = StrReverse(bits)
        Ferramentas.TextBox34.Text = bits(0)
        Ferramentas.TextBox35.Text = bits(1)
        Ferramentas.TextBox36.Text = bits(2)
        Ferramentas.TextBox37.Text = bits(3)
        Ferramentas.TextBox38.Text = bits(4)
        Ferramentas.TextBox39.Text = bits(5)
        Ferramentas.TextBox40.Text = bits(6)
        Ferramentas.TextBox41.Text = bits(7)
        Ferramentas.TextBox42.Text = bits(8)
        Ferramentas.TextBox43.Text = bits(9)
        Ferramentas.TextBox44.Text = bits(10)
        Ferramentas.TextBox45.Text = bits(11)
        Ferramentas.TextBox46.Text = bits(12)
        Ferramentas.TextBox47.Text = bits(13)
        Ferramentas.TextBox48.Text = bits(14)
        Ferramentas.TextBox49.Text = bits(15)
    End Sub
    Public Sub escreveTextBoxWord3(bits As String)
        bits = StrReverse(bits)
        Ferramentas.TextBox50.Text = bits(0)
        Ferramentas.TextBox51.Text = bits(1)
        Ferramentas.TextBox52.Text = bits(2)
        Ferramentas.TextBox53.Text = bits(3)
        Ferramentas.TextBox54.Text = bits(4)
        Ferramentas.TextBox55.Text = bits(5)
        Ferramentas.TextBox56.Text = bits(6)
        Ferramentas.TextBox57.Text = bits(7)
        Ferramentas.TextBox58.Text = bits(8)
        Ferramentas.TextBox59.Text = bits(9)
        Ferramentas.TextBox60.Text = bits(10)
        Ferramentas.TextBox61.Text = bits(11)
        Ferramentas.TextBox62.Text = bits(12)
        Ferramentas.TextBox63.Text = bits(13)
        Ferramentas.TextBox64.Text = bits(14)
        Ferramentas.TextBox65.Text = bits(15)
    End Sub
    Public Sub escreveTextBoxWord4(bits As String)
        bits = StrReverse(bits)
        Ferramentas.TextBox66.Text = bits(0)
        Ferramentas.TextBox67.Text = bits(1)
        Ferramentas.TextBox68.Text = bits(2)
        Ferramentas.TextBox69.Text = bits(3)
        'Ferramentas.TextBox70.Text = bits(4)
        'Ferramentas.TextBox71.Text = bits(5)
        'Ferramentas.TextBox72.Text = bits(6)
        'Ferramentas.TextBox73.Text = bits(7)
        'Ferramentas.TextBox74.Text = bits(8)
        'Ferramentas.TextBox75.Text = bits(9)
        'Ferramentas.TextBox76.Text = bits(10)
        'Ferramentas.TextBox77.Text = bits(11)
        'Ferramentas.TextBox78.Text = bits(12)
        'Ferramentas.TextBox79.Text = bits(13)
        'Ferramentas.TextBox80.Text = bits(14)
        'Ferramentas.TextBox81.Text = bits(15)
    End Sub
    Public Sub escreveTextBoxAnalogicasUNO(valores() As String)
        Ferramentas.TextBox70.Text = valores(0)
        Ferramentas.TextBox71.Text = valores(1)
        Ferramentas.TextBox72.Text = valores(2)
        Ferramentas.TextBox73.Text = valores(3)
        Ferramentas.TextBox74.Text = valores(4)
        Ferramentas.TextBox75.Text = valores(5)
    End Sub
    Public Sub escreveTextBoxAnalogicas(valores() As String)
        Ferramentas.TextBox70.Text = valores(0)
        Ferramentas.TextBox71.Text = valores(1)
        Ferramentas.TextBox72.Text = valores(2)
        Ferramentas.TextBox73.Text = valores(3)
        Ferramentas.TextBox74.Text = valores(4)
        Ferramentas.TextBox75.Text = valores(5)
        Ferramentas.TextBox76.Text = valores(6)
        Ferramentas.TextBox77.Text = valores(7)
        Ferramentas.TextBox78.Text = valores(8)
        Ferramentas.TextBox79.Text = valores(9)
        Ferramentas.TextBox80.Text = valores(10)
        Ferramentas.TextBox81.Text = valores(11)
        Ferramentas.TextBox82.Text = valores(12)
        Ferramentas.TextBox83.Text = valores(13)
        Ferramentas.TextBox84.Text = valores(14)
        Ferramentas.TextBox85.Text = valores(15)
    End Sub
    Public Sub escreveTextBoxPWMsUNO(valores() As String)
        Ferramentas.TextBox93.Text = valores(0)
        Ferramentas.TextBox95.Text = valores(1)
        Ferramentas.TextBox96.Text = valores(2)
        Ferramentas.TextBox99.Text = valores(3)
        Ferramentas.TextBox100.Text = valores(4)
        Ferramentas.TextBox101.Text = valores(5)
    End Sub
End Module
