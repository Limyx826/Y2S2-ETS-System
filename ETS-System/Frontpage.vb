Public Class Frontpage
    Private Sub Next_button_Click(sender As Object, e As EventArgs) Handles Next_button.Click
        If ComboBox4Origin.Text = "Origin" Then
            MessageBox.Show("Invalid origin", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox5Destination.Text = "Destination" Then
            MessageBox.Show("Invalid destination", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf DateTimePicker1.Value.Date = Today.Date Then
            MessageBox.Show("Invalid date", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox2Time.Text = "Travel Time" Then
            MessageBox.Show("Invalid time", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox1Adult.Text = "Adult" Then
            MessageBox.Show("Invalid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox3Child.Text = "Child" Then
            MessageBox.Show("Invalid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            If ComboBox5Destination.SelectedItem = ComboBox4Origin.SelectedItem Then
                MessageBox.Show("Invalid destination", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf DateTimePicker1.Value.Date < Today.Date Then
                MessageBox.Show("Invalid date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf ComboBox1Adult.SelectedIndex = 0 And ComboBox3Child.SelectedIndex = 0 Then
                MessageBox.Show("No passenger selected", "Invalid Passenger", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                FormSelect.Show()
                Me.Hide()
            End If

        End If

    End Sub
End Class
