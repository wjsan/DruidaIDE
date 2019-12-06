Imports System.Windows.Forms

Public Class AddKeypad
    Public matrix As String
    Public pinosLinhas As String
    Public pinosColunas As String
    Public declaration As String
    Private l As Byte
    Private c As Byte
    Private tb1() As TextBox
    Private tb2() As TextBox

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        GetPinosLinhas()
        GetPinosColunas()
        GetDeclaration()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBoxModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModelo.SelectedIndexChanged
        If ComboBoxModelo.SelectedIndex = 0 Then
            PictureBoxModelo.Image = My.Resources.kb_4x3_
            TextBox8.Hide()
            TextBox16.Hide()
            l = 4
            c = 3
            GetMatrix3x4()
        End If
        If ComboBoxModelo.SelectedIndex = 1 Then
            PictureBoxModelo.Image = My.Resources.kb_4x4_
            TextBox8.Show()
            TextBox16.Show()
            l = 4
            c = 4
            GetMatrix4x4()
        End If
    End Sub

    Private Sub GetMatrix3x4()
        matrix = "char teclas[4][3] = " & vbLf &
                 "{" & vbLf &
                 vbTab & "{'1','2','3'}," & vbLf &
                 vbTab & "{'4','5','6'}," & vbLf &
                 vbTab & "{'7','8','9'}," & vbLf &
                 vbTab & "{'*','0','#'}" & vbLf &
                 "};" & vbLf
    End Sub

    Private Sub GetMatrix4x4()
        matrix = "char teclas[4][4] = " & vbLf &
                 "{" & vbLf &
                 vbTab & "{'1','2','3','A'}," & vbLf &
                 vbTab & "{'4','5','6','B'}," & vbLf &
                 vbTab & "{'7','8','9','C'}," & vbLf &
                 vbTab & "{'*','0','#','D'}" & vbLf &
                 "};" & vbLf
    End Sub

    Private Sub GetPinosLinhas()
        Dim p() As String = {TextBox1.Text,
                             TextBox2.Text,
                             TextBox3.Text,
                             TextBox4.Text}
        pinosLinhas = "byte pinLinhas[" & l & "] = {" & p(0) & ", " & p(1) & ", " & p(2) & ", " & p(3) & "};"
    End Sub

    Private Sub GetPinosColunas()
        If ComboBoxModelo.SelectedIndex = 0 Then
            Dim p() As String = {TextBox4.Text,
                                 TextBox5.Text,
                                 TextBox6.Text}
            pinosColunas = "byte pinColunas[" & c & "] = {" & p(0) & ", " & p(1) & ", " & p(2) & "};"
        End If
        If ComboBoxModelo.SelectedIndex = 1 Then
            Dim p() As String = {TextBox4.Text,
                                 TextBox5.Text,
                                 TextBox6.Text,
                                 TextBox7.Text}
            pinosColunas = "byte pinColunas[" & c & "] = {" & p(0) & ", " & p(1) & ", " & p(2) & ", " & p(3) & "};"
        End If
    End Sub

    Private Sub GetDeclaration()
        declaration = "Keypad " & TextBoxNome.Text & "= Keypad(makeKeymap(teclas), pinLinhas, pinColunas, " & l & ", " & c & ");"
    End Sub

    Private Sub AddKeypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxModelo.SelectedIndex = 0
        tb1 = {TextBox1,
            TextBox2,
            TextBox3,
            TextBox4,
            TextBox5,
            TextBox6,
            TextBox7,
            TextBox8}
        tb2 = {TextBox9,
            TextBox10,
            TextBox11,
            TextBox12,
            TextBox13,
            TextBox14,
            TextBox15,
            TextBox16}
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(tb1(0).Text) And CheckBoxAuto.Checked Then
            Dim n As UInt16 = tb1(0).Text
            For i = 0 To 7
                tb1(i).Text = i + n
                tb2(i).Text = i + n
            Next
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If IsNumeric(tb2(0).Text) And CheckBoxAuto.Checked Then
            Dim n As UInt16 = tb2(0).Text
            For i = 0 To 7
                tb1(i).Text = i + n
                tb2(i).Text = i + n
            Next
        End If
    End Sub
End Class
