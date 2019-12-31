Public Class FormDatabase
    Private Sub FormDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JCLODataSet.Timetable' table. You can move, or remove it, as needed.
        Me.TimetableTableAdapter.Fill(Me.JCLODataSet.Timetable)

    End Sub
End Class