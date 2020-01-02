Public Class FormConfirm
    Const TrainPrice1S As Double = 7

    Private Sub FormConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Confirm_Button_Click(sender As Object, e As EventArgs) Handles Confirm_Button.Click
        Frontpage.Show()
        Me.Close()
    End Sub

    Private Sub Return_Button_Click(sender As Object, e As EventArgs) Handles Return_Button.Click
        FormCusInfo.Show()
        Me.Close()
    End Sub
End Class