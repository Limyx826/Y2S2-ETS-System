Public Class FormSeat
    'B1A.BackColor = Color.Gainsboro
    'B1A.ForeColor = Color.IndianRed
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        FormSeatTest.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        FormCusInfo.Show()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        FormSelect.Show()
        Me.Close()
    End Sub

    Dim seatpass As Integer = 0
    Sub Choose(ByRef B As Object)
        If seatpass = TotalPass Then
            If B.BackColor <> Color.Gainsboro Then
                If seatpass = TotalPass Then
                    If B.BackColor = Color.CornflowerBlue Then
                        B.BackColor = Color.DarkOrange
                        seatpass += 1
                    Else
                        B.BackColor = Color.CornflowerBlue
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub B1A_Click(sender As Object, e As EventArgs) Handles B1A.Click
        If seatpass = TotalPass Then
            If B1A.BackColor <> Color.Gainsboro Then
                If B1A.BackColor = Color.CornflowerBlue Then
                    B1A.BackColor = Color.DarkOrange
                    seatpass += 1
                Else
                    B1A.BackColor = Color.CornflowerBlue
                End If
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

    Private Sub B1C_Click(sender As Object, e As EventArgs) Handles B1C.Click
        Choose(B1C)
    End Sub

    Private Sub B2C_Click(sender As Object, e As EventArgs) Handles B2C.Click
        Choose(B2C)
    End Sub

    Private Sub B3C_Click(sender As Object, e As EventArgs) Handles B3C.Click
        Choose(B3C)
    End Sub

    Private Sub B4C_Click(sender As Object, e As EventArgs) Handles B4C.Click
        Choose(B4C)
    End Sub

    Private Sub B5C_Click(sender As Object, e As EventArgs) Handles B5C.Click
        Choose(B5C)
    End Sub

    Private Sub B6C_Click(sender As Object, e As EventArgs) Handles B6C.Click
        Choose(B6C)
    End Sub

    Private Sub B7C_Click(sender As Object, e As EventArgs) Handles B7C.Click
        Choose(B7C)
    End Sub

    Private Sub B8C_Click(sender As Object, e As EventArgs) Handles B8C.Click
        Choose(B8C)
    End Sub

    Private Sub B9C_Click(sender As Object, e As EventArgs) Handles B9C.Click
        Choose(B9C)
    End Sub

    Private Sub B1D_Click(sender As Object, e As EventArgs) Handles B1D.Click
        Choose(B1D)
    End Sub

    Private Sub B2D_Click(sender As Object, e As EventArgs) Handles B2D.Click
        Choose(B2D)
    End Sub

    Private Sub B3D_Click(sender As Object, e As EventArgs) Handles B3D.Click
        Choose(B3D)
    End Sub

    Private Sub B4D_Click(sender As Object, e As EventArgs) Handles B4D.Click
        Choose(B4D)
    End Sub

    Private Sub B5D_Click(sender As Object, e As EventArgs) Handles B5D.Click
        Choose(B5D)
    End Sub

    Private Sub B6D_Click(sender As Object, e As EventArgs) Handles B6D.Click
        Choose(B6D)
    End Sub

    Private Sub B7D_Click(sender As Object, e As EventArgs) Handles B7D.Click
        Choose(B7D)
    End Sub

    Private Sub B8D_Click(sender As Object, e As EventArgs) Handles B8D.Click
        Choose(B8D)
    End Sub

    Private Sub B9D_Click(sender As Object, e As EventArgs) Handles B9D.Click
        Choose(B9D)
    End Sub

    Public TotalPass As Integer
    Private Sub FormSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalPass = Frontpage.NumAdult + Frontpage.NumChild


    End Sub
End Class

