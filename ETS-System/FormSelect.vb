Public Class FormSelect

    Private Sub Back_button_Click(sender As Object, e As EventArgs) Handles Back_button.Click
        Frontpage.Show()
        Me.Close()
    End Sub

    Private Sub FormSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListView1
            With .Items
                .Add(Frontpage.ComboBox4Origin.SelectedItem)
                .Add(Frontpage.ComboBox5Destination.SelectedItem)
                .Add(Frontpage.DateTimePicker1.Value.Date)
                .Add(Frontpage.ComboBox2Time.SelectedItem)
                .Add(Frontpage.ComboBox1Adult.SelectedItem)
                .Add(Frontpage.ComboBox3Child.SelectedItem)
            End With
        End With
    End Sub
End Class