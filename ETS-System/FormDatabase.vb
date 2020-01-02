Public Class FormDatabase
    Private Sub FormDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JCLODataSet.Timetable' table. You can move, or remove it, as needed.
        Me.TimetableTableAdapter.Fill(Me.JCLODataSet.Timetable)
        'TODO: This line of code loads data into the 'JCLODataSet.Timetable' table. You can move, or remove it, as needed.
        Me.TimetableTableAdapter.Fill(Me.JCLODataSet.Timetable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Frontpage.Show()
    End Sub

    Private Sub TimetableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TimetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JCLODataSet)

    End Sub

    Private Sub TimetableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TimetableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TimetableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JCLODataSet)

    End Sub
End Class