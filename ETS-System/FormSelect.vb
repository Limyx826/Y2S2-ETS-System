Imports System.Data.OleDb

Public Class FormSelect
    Dim ds As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
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
                .Add(Frontpage.DateTimePicker2.Value.Date)
                .Add(Frontpage.ComboBox3Time.SelectedItem)
                .Add(Frontpage.ComboBox5Adult.SelectedItem)
                .Add(Frontpage.ComboBox6Child.SelectedItem)
            End With
        End With

        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=JCLO.accdb"
        'con.Open()
        'ds = New OleDbDataAdapter("select * from TABLE NAME", con)
        'ds.Fill(dt)
        'con.Close()



        If Frontpage.ComboBox3Time.SelectedIndex = 0 Then


        ElseIf Frontpage.ComboBox3Time.SelectedIndex = 1 Then


        ElseIf Frontpage.ComboBox3Time.SelectedIndex = 2 Then


        Else


        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        FormSeat.Show()
        Me.Close()
    End Sub
End Class