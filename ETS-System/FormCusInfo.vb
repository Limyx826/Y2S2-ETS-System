Public Class FormCusInfo
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        FormSeat.Show()
        Me.Close()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        FormConfirm.Show()
        Me.Close()
    End Sub
End Class