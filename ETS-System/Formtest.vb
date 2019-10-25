Public Class Formtest
    Private Sub Next_button_Click(sender As Object, e As EventArgs) Handles Next_button.Click

        With ListView1
            With .Items
                .Add(ComboBox4.SelectedItem)
                .Add(ComboBox5.SelectedItem)
                .Add(DateTimePicker1.Value.Date)
                .Add(ComboBox2.SelectedItem)
                .Add(ComboBox1.SelectedItem)
                .Add(ComboBox3.SelectedItem)
            End With
        End With

    End Sub
End Class