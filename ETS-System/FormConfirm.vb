Public Class FormConfirm
    Const TrainPrice1S As Double = 7

    Private Sub FormConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentHeight As Integer = Me.Height
        If Frontpage.RBReturn.Checked = True Then
            Label12.Visible = True
            Label11.Visible = True
            Label10.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            LabelTrainBack.Visible = True
            LabelClassBack.Visible = True
            LabelDepartureBack.Visible = True
            LabelArrivalBack.Visible = True
        End If



        If Label8.Visible = False Then
            Me.Height = CurrentHeight - 150
        End If
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