Public Class Payment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frontpage.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

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
        LabelNum.Text = FormConfirm.Text
    End Sub
End Class