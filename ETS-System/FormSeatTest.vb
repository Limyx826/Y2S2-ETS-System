Public Class FormSeatTest
    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
        Dim temp As String = ListBox1.SelectedItem
        FormSeat.Controls(temp).BackColor = Color.Gainsboro
        FormSeat.Controls(temp).ForeColor = Color.IndianRed
        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        ListBox1.Items.Add(ListBox2.SelectedItem)
        Dim temp As String = ListBox2.SelectedItem
        FormSeat.Controls(temp).BackColor = Color.CornflowerBlue
        FormSeat.Controls(temp).ForeColor = Color.White
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class