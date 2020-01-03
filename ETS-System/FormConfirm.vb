Public Class FormConfirm
    Const TrainPrice1S As Double = 7
    Private Sub FormConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentHeight As Integer = Me.Height
        LabelTrainGo.Text = FormSelect.TrainGo
        If Frontpage.ComboBox4Class.SelectedIndex = 0 Then
            LabelClassGo.Text = Frontpage.ComboBox4Class.SelectedItem
        Else
            LabelClassGo.Text = Frontpage.ComboBox4Class.SelectedItem
        End If
        LabelDepartureGo.Text = FormSelect.DepartureGo
        LabelArrivalGo.Text = FormSelect.DepartureGo

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

            LabelTrainBack.Text = FormSelect.TrainGo
            If Frontpage.ComboBox4Class.SelectedIndex = 0 Then
                LabelClassGo.Text = Frontpage.ComboBox4Class.SelectedItem
            Else
                LabelClassGo.Text = Frontpage.ComboBox4Class.SelectedItem
            End If
            LabelDepartureBack.Text = FormSelect.DepartureGo
            LabelArrivalBack.Text = FormSelect.DepartureGo
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

    Private Sub LabelTrainGo_Click(sender As Object, e As EventArgs) Handles LabelTrainGo.Click

    End Sub
End Class