Public Class FormMemReg
    Private Sub FormMemReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        If String.Compare(ConPassTextBox.Text, PasswordTextBox.Text) = 0 Then
            If String.Compare(ICTextBox.Text, "") <> 0 And String.Compare(UsernameTextBox.Text, "") <> 0 And
            String.Compare(PasswordTextBox.Text, "") <> 0 And String.Compare(ConPassTextBox.Text, "") <> 0 Then

                Register_Button.Enabled = True
            End If
        End If
    End Sub

    Private Sub ICTextBox_TextChanged(sender As Object, e As EventArgs) Handles ICTextBox.TextChanged
        If String.Compare(ConPassTextBox.Text, PasswordTextBox.Text) = 0 Then
            If String.Compare(EmailTextBox.Text, "") <> 0 And String.Compare(UsernameTextBox.Text, "") <> 0 And
            String.Compare(PasswordTextBox.Text, "") <> 0 And String.Compare(ConPassTextBox.Text, "") <> 0 Then

                Register_Button.Enabled = True
            End If
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        If String.Compare(ConPassTextBox.Text, PasswordTextBox.Text) = 0 Then
            If String.Compare(ICTextBox.Text, "") <> 0 And String.Compare(EmailTextBox.Text, "") <> 0 And
            String.Compare(PasswordTextBox.Text, "") <> 0 And String.Compare(ConPassTextBox.Text, "") <> 0 Then

                Register_Button.Enabled = True
            End If
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If String.Compare(ConPassTextBox.Text, PasswordTextBox.Text) = 0 Then
            If String.Compare(ICTextBox.Text, "") <> 0 And String.Compare(UsernameTextBox.Text, "") <> 0 And
            String.Compare(EmailTextBox.Text, "") <> 0 And String.Compare(ConPassTextBox.Text, "") <> 0 Then

                Register_Button.Enabled = True
            End If
        End If
    End Sub

    Private Sub ConPassTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConPassTextBox.TextChanged
        If String.Compare(ConPassTextBox.Text, PasswordTextBox.Text) = 0 Then
            'Dim balloonToolTip As New ToolTip()
            'balloonToolTip.UseFading = True
            'balloonToolTip.UseAnimation = True
            'balloonToolTip.IsBalloon = True
            'balloonToolTip.ShowAlways = True
            'balloonToolTip.AutoPopDelay = 5000
            'balloonToolTip.InitialDelay = 1000
            'balloonToolTip.ReshowDelay = 500
            'balloonToolTip.IsBalloon = True
            'balloonToolTip.SetToolTip(ConPassTextBox, "Password don't match")

            If String.Compare(ICTextBox.Text, "") <> 0 And String.Compare(UsernameTextBox.Text, "") <> 0 And
            String.Compare(PasswordTextBox.Text, "") <> 0 And String.Compare(EmailTextBox.Text, "") <> 0 Then

                Register_Button.Enabled = True
            End If

        End If
    End Sub
End Class