Public Class FormSelect

    Private Sub Back_button_Click(sender As Object, e As EventArgs) Handles Back_button.Click
        Frontpage.Show()
        Me.Close()
    End Sub

    Private Sub FormSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListView1
            With .Items
                .Add(Frontpage.ComboBox1Origin.SelectedItem)
                .Add(Frontpage.ComboBox2Destination.SelectedItem)
                .Add(Frontpage.DateTimePicker1.Value.Date)
                .Add(Frontpage.ComboBox3Time.SelectedItem)
                .Add(Frontpage.ComboBox4Adult.SelectedItem)
                .Add(Frontpage.ComboBox5Child.SelectedItem)
            End With
        End With
        If Frontpage.ComboBox3Time.SelectedIndex = 0 Then


        ElseIf Frontpage.ComboBox3Time.SelectedIndex = 1 Then


        ElseIf Frontpage.ComboBox3Time.SelectedIndex = 2 Then


        Else


        End If
    End Sub
End Class