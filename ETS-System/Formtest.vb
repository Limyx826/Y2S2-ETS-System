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

    Private Sub TimetableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TimetableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TimetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JCLODataSet)

    End Sub

    Private Sub Formtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JCLODataSet.Timetable' table. You can move, or remove it, as needed.
        Me.TimetableTableAdapter.Fill(Me.JCLODataSet.Timetable)

    End Sub
End Class