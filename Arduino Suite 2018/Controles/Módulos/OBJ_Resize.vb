Module OBJ_Resize

	Private AlowHS As Boolean = False
	Private AlowVS As Boolean = False
	Private AlowVHS As Boolean = False
	Private MXtmp As Integer = 0
	Private MYtmp As Integer = 0
	Private GMXtmp As Integer = 0
	Private GMYtmp As Integer = 0

    Function ResizeOBJ(ByRef Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs, ByVal formX As Object, Optional ByVal Offset As Integer = 10) As Boolean

        If e.Button = Windows.Forms.MouseButtons.None Then
            If e.Y > Sender.Height - Offset And e.Y < Sender.Height And
            e.X > Sender.Width - Offset And e.X < Sender.Width Then

                Sender.Cursor = Cursors.SizeNWSE
                AlowHS = False
                AlowVS = False
                AlowVHS = True

            ElseIf e.Y > Sender.Height - Offset And e.Y < Sender.Height And
            e.X < Sender.Width - 1 Then

                Sender.Cursor = Cursors.SizeNS
                AlowVS = True
                AlowHS = False
                AlowVHS = False
            ElseIf e.X > Sender.Width - Offset And e.X < Sender.Width And
            e.Y < Sender.Height - 1 Then
                Sender.Cursor = Cursors.SizeWE
                AlowHS = True
                AlowVS = False
                AlowVHS = False

            Else


                If Sender.Cursor <> Cursors.Hand Then
                    Sender.Cursor = Cursors.Hand
                End If
                AlowHS = False
                AlowVS = False
                AlowVHS = False

            End If



        End If

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If Cursor.Position.X < formX.Left + formX.Width And Cursor.Position.Y < formX.Top + formX.Height Then

                If AlowHS = True Then
                    If Sender.Width > 1 Then
                        Sender.Width = Sender.Width - (MXtmp - e.X)
                    Else
                        Sender.Width += 1
                    End If
                ElseIf AlowVS = True Then

                    If Sender.Height > 1 Then
                        Sender.Height = Sender.Height - (MYtmp - e.Y)
                    Else
                        Sender.Height += 1
                    End If

                ElseIf AlowVHS = True Then

                    If Sender.Height > 1 And Sender.Width > 1 Then
                        Sender.Width = Sender.Width - (MXtmp - e.X)
                        Sender.Height = Sender.Height - (MYtmp - e.Y)

                    Else
                        Sender.Height += 1
                        Sender.Width += 1
                    End If

                Else

                    If Sender.Top > 0 And Sender.Top < formX.Height - 50 Then

                        Sender.Top = Sender.Top - (GMYtmp - Cursor.Position.Y)

                    Else

                        If Sender.Top <= 0 Then
                            Sender.Top += 1
                        Else
                            Sender.Top -= 1
                        End If


                    End If

                    If Sender.Left > 0 And Sender.Left < formX.Width - 30 Then
                        Sender.Left = Sender.Left - (GMXtmp - Cursor.Position.X)
                    Else

                        If Sender.Left <= 0 Then
                            Sender.Left += 1
                        Else
                            Sender.Left -= 1
                        End If

                    End If

                End If

            End If

        End If

        MXtmp = e.X
        MYtmp = e.Y
        GMXtmp = Cursor.Position.X
        GMYtmp = Cursor.Position.Y

        Return (0)
    End Function

End Module
