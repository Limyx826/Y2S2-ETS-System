Public Class Frontpage
    Private Sub Frontpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Visible = False
        LabelReturn.Visible = False
        DateTimePicker2.Visible = False
        DateTimePicker2.Enabled = False

        DateTimePicker1.MinDate = Today.Date
        DateTimePicker2.MinDate = Today.Date
    End Sub

    Private Sub Next_button_Click(sender As Object, e As EventArgs) Handles Next_button.Click
        If ComboBox1Origin.Text = "Origin" Then
            MessageBox.Show("Invalid origin", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox2Destination.Text = "Destination" Then
            MessageBox.Show("Invalid destination", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            'ElseIf DateTimePicker1.Value.Date = Today.Date Then
            'MessageBox.Show("Invalid date", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox3Time.Text = "Travel Time" Then
            MessageBox.Show("Invalid time", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox5Adult.Text = "Adult" Then
            MessageBox.Show("Invalid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf ComboBox6Child.Text = "Child" Then
            MessageBox.Show("Invalid input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            If ComboBox2Destination.SelectedItem = ComboBox1Origin.SelectedItem Then
                MessageBox.Show("Invalid destination", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf DateTimePicker1.Value.Date < Today.Date Then
                MessageBox.Show("Invalid date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            ElseIf ComboBox5Adult.SelectedIndex = 0 And ComboBox6Child.SelectedIndex = 0 Then
                MessageBox.Show("No passenger selected", "Invalid Passenger", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                FormSelect.Show()
                Me.Hide()
            End If

        End If

    End Sub

    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormDatabase.Show()
        Me.Hide()
    End Sub

    Private Sub RBOneWay_CheckedChanged(sender As Object, e As EventArgs) Handles RBOneWay.CheckedChanged
        LabelReturn.Visible = False
        DateTimePicker2.Visible = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub RBReturn_CheckedChanged(sender As Object, e As EventArgs) Handles RBReturn.CheckedChanged
        LabelReturn.Visible = True
        DateTimePicker2.Visible = True
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'If DateTimePicker1.Value = Today.Date Then
        '    If Today.TimeOfDay < New DateTime(0, 0, 0, Hour.6) Then

        '    End If
        'End If

    End Sub

    Private Sub ComboBox5Adult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5Adult.SelectedIndexChanged

    End Sub
End Class
