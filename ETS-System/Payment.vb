Public Class Payment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        FormLogin.Close()
        FormSeat.Close()
        FormSelect.Close()
        Frontpage.Show()
        FormCusInfo.Close()
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If String.Compare(MaskedTextBox2.Text, "") <> 0 And String.Compare(MaskedTextBox3.Text, "") <> 0 And
        String.Compare(ComboBox1.SelectedItem, "") <> 0 And String.Compare(ComboBox2.SelectedItem, "") <> 0 And String.Compare(MaskedTextBox6.Text, "") <> 0 Then

            Button1.Enabled = True
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub MaskedTextBox6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox6.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNum.Text = FormConfirm.LabelTotal.Text
    End Sub
End Class