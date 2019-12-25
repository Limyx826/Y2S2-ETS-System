Public Class FormSeat
    'B1A.BackColor = Color.Gainsboro
    'B1A.ForeColor = Color.IndianRed
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        FormSeatTest.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

    End Sub

    Sub Choose(ByRef B As Object)
        If B.BackColor <> Color.Gainsboro Then
            If B.BackColor = Color.CornflowerBlue Then
                B.BackColor = Color.DarkOrange
            Else
                B.BackColor = Color.CornflowerBlue
            End If
        End If
    End Sub

    Private Sub B1A_Click(sender As Object, e As EventArgs) Handles B1A.Click
        If B1A.BackColor <> Color.Gainsboro Then
            If B1A.BackColor = Color.CornflowerBlue Then
                B1A.BackColor = Color.DarkOrange
            Else
                B1A.BackColor = Color.CornflowerBlue
            End If
        End If

    End Sub

    Private Sub B2A_Click(sender As Object, e As EventArgs) Handles B2A.Click
        Choose(B2A)
    End Sub

    Private Sub B3A_Click(sender As Object, e As EventArgs) Handles B3A.Click
        Choose(B3A)
    End Sub

    Private Sub B4A_Click(sender As Object, e As EventArgs) Handles B4A.Click
        Choose(B4A)
    End Sub

    Private Sub B5A_Click(sender As Object, e As EventArgs) Handles B5A.Click
        Choose(B5A)
    End Sub

    Private Sub B6A_Click(sender As Object, e As EventArgs) Handles B6A.Click
        Choose(B6A)
    End Sub

    Private Sub B7A_Click(sender As Object, e As EventArgs) Handles B7A.Click
        Choose(B7A)
    End Sub

    Private Sub B8A_Click(sender As Object, e As EventArgs) Handles B8A.Click
        Choose(B8A)
    End Sub

    Private Sub B9A_Click(sender As Object, e As EventArgs) Handles B9A.Click
        Choose(B9A)
    End Sub

    Private Sub B1B_Click(sender As Object, e As EventArgs) Handles B1B.Click
        Choose(B1B)
    End Sub

    Private Sub B2B_Click(sender As Object, e As EventArgs) Handles B2B.Click
        Choose(B2B)
    End Sub

    Private Sub B3B_Click(sender As Object, e As EventArgs) Handles B3B.Click
        Choose(B3B)
    End Sub

    Private Sub B4B_Click(sender As Object, e As EventArgs) Handles B4B.Click
        Choose(B4B)
    End Sub

    Private Sub B5B_Click(sender As Object, e As EventArgs) Handles B5B.Click
        Choose(B5B)
    End Sub

    Private Sub B6B_Click(sender As Object, e As EventArgs) Handles B6B.Click
        Choose(B6B)
    End Sub

    Private Sub B7B_Click(sender As Object, e As EventArgs) Handles B7B.Click
        Choose(B7B)
    End Sub

    Private Sub B8B_Click(sender As Object, e As EventArgs) Handles B8B.Click
        Choose(B8B)
    End Sub

    Private Sub B9B_Click(sender As Object, e As EventArgs) Handles B9B.Click
        Choose(B9B)
    End Sub
End Class

