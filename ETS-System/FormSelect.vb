Imports System.Configuration
Imports System.Data.OleDb

Public Class FormSelect

    ''' <summary>
    ''' Function to retrieve the connection from the app.config
    ''' </summary>
    ''' <param name="conName">Name of the connectionString to retrieve</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetConnectionString(ByVal conName As String) As String
        'variable to hold our connection string for returning it
        Dim strReturn As New String("")
        'check to see if the user provided a connection string name
        'this is for if your application has more than one connection string
        If Not String.IsNullOrEmpty(conName) Then
            'a connection string name was provided
            'get the connection string by the name provided
            strReturn = ConfigurationManager.ConnectionStrings(conName).ConnectionString
        Else
            'no connection string name was provided
            'get the default connection string
            strReturn = ConfigurationManager.ConnectionStrings("JCLO").ConnectionString
        End If
        'return the connection string to the calling method
        Return strReturn
    End Function

    ''' <summary>
    ''' Returns a BindingSource, which is used with, for example, a DataGridView control
    ''' </summary>
    ''' <param name="cmd">"pre-Loaded" command, ready to be executed</param>
    ''' <returns>BindingSource</returns>
    ''' <remarks>Use this function to ease populating controls that use a BindingSource</remarks>
    Public Shared Function GetBindingSource(ByVal cmd As OleDbCommand) As BindingSource
        'declare our binding source
        Dim oBindingSource As New BindingSource()
        ' Create a new data adapter based on the specified query.
        Dim daGet As New OleDbDataAdapter(cmd)
        ' Populate a new data table and bind it to the BindingSource.
        Dim dtGet As New DataTable()
        'set the timeout of the OleDbCommandObject
        cmd.CommandTimeout = 240
        dtGet.Locale = System.Globalization.CultureInfo.InvariantCulture
        Try
            'fill the DataTable with the OleDbDataAdapter
            daGet.Fill(dtGet)
        Catch ex As Exception
            'check for errors
            MsgBox(ex.Message, "Error in GetBindingSource")
            Return Nothing
        End Try
        'set the DataSource for the BindingSource to the DataTable
        oBindingSource.DataSource = dtGet
        'return the BindingSource to the calling method or control
        Return oBindingSource
    End Function

    ''' <summary>
    ''' Method for handling the ConnectionState of 
    ''' the connection object passed to it
    ''' </summary>
    ''' <param name="conn">The OleDbConnection Object</param>
    ''' <remarks></remarks>
    Public Shared Sub HandleConnection(ByVal conn As OleDbConnection)
        With conn
            'do a switch on the state of the connection
            Select Case .State
                Case ConnectionState.Open
                    'the connection is open
                    'close then re-open
                    .Close()
                    .Open()
                    Exit Select
                Case ConnectionState.Closed
                    'connection is open
                    'open the connection
                    .Open()
                    Exit Select
                Case Else
                    .Close()
                    .Open()
                    Exit Select
            End Select
        End With
    End Sub

    Public Shared Function GetRecords() As BindingSource
        'The value that will be passed to the Command Object (this is a query)
        Dim query As String = "SELECT * FROM YourTableName"
        Dim cnGetRecords As New OleDbConnection(GetConnectionString("JCLO"))
        'OleDbConnection Object to use
        Dim cmdGetRecords As New OleDbCommand()
        'OleDbCommand Object to use
        Dim daGetRecords As New OleDbDataAdapter()
        Dim dsGetRecords As New DataSet()
        'Clear any parameters
        cmdGetRecords.Parameters.Clear()
        Try
            With cmdGetRecords
                'set the OleDbCommand Object Parameters
                .CommandText = query
                'tell it what to execute
                .CommandType = CommandType.Text
                'Set the Connection for the Command Object
                .Connection = cnGetRecords
            End With
            'set the state of the OleDbConnection Object
            HandleConnection(cnGetRecords)
            'create BindingSource to return for our DataGrid Control
            Dim oBindingSource As BindingSource = GetBindingSource(cmdGetRecords)
            'now check to make sure a BindingSource was returned
            If Not oBindingSource Is Nothing Then
                'return the binding source to the calling method
                Return oBindingSource
            Else
                'no binding source was returned
                'let the user know the error
                Throw New Exception("There was no BindingSource returned")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error Retrieving Data")
            Return Nothing
        Finally
            HandleConnection(cnGetRecords)
        End Try
    End Function

    Public Shared Function GetRecordsByID(ByVal value As Integer) As BindingSource
        'The value that will be passed to the Command Object (this is a query)
        Dim query As String = "SELECT value1,value2,value3 FROM YourTable WHERE YourValue = @value"
        Dim cnGetRecords As New OleDbConnection(GetConnectionString("YourConnectionName"))
        'OleDbConnection Object to use
        Dim cmdGetRecords As New OleDbCommand()
        'OleDbCommand Object to use
        Dim daGetRecords As New OleDbDataAdapter()
        Dim dsGetRecords As New DataSet()
        'Clear any parameters
        cmdGetRecords.Parameters.Clear()
        Try
            With cmdGetRecords
                'set the OleDbCommand Object Parameters
                .CommandText = query
                'tell it what to execute
                .CommandType = CommandType.Text
                'tell it its executing a text query
                'heres the difference from the last method
                'here we are adding a parameter to send to our query
                'you use the AddWithValue, then the name of the parameter in your query
                'then the variable that holds that value
                .Parameters.AddWithValue("@id", value)
                'Set the Connection for the Command Object
                .Connection = cnGetRecords
            End With
            'set the state of the OleDbConnection Object
            HandleConnection(cnGetRecords)
            'create BindingSource to return for our DataGrid Control
            Dim oBindingSource As BindingSource = GetBindingSource(cmdGetRecords)
            'now check to make sure a BindingSource was returned
            If Not oBindingSource Is Nothing Then
                'return the binding source to the calling method
                Return oBindingSource
            Else
                'no binding source was returned
                'let the user know the error
                Throw New Exception("There was no BindingSource returned")
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Error Retrieving Data")
            Return Nothing
        Finally
            'Close the connection
            HandleConnection(cnGetRecords)
        End Try
    End Function

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



        If Frontpage.ComboBox3Time.SelectedIndex = 0 Then
            RB1.Text = "ES1201 , departure time 6.00AM,"
            RB2.Text = "ES1202 , departure time 4.00AM,"
            RB3.Text = "ES1203 , departure time 2.00AM,"
            RB4.Text = "ES1204 , departure time 1.00AM,"
        ElseIf Frontpage.ComboBox3Time.SelectedIndex = 1 Then
            RB1.Text = "ES1205 , departure time 11.00AM,"
            RB2.Text = "ES1206 , departure time 9.00AM,"
            RB3.Text = "ES1207 , departure time 8.00AM,"
            RB4.Text = "ES1208 , departure time 7.00AM,"
        ElseIf Frontpage.ComboBox3Time.SelectedIndex = 2 Then
            RB1.Text = "ES1209 , departure time 6.00PM,"
            RB2.Text = "ES1210 , departure time 4.00PM,"
            RB3.Text = "ES1211 , departure time 2.00PM,"
            RB4.Text = "ES1212 , departure time 11.00PM,"
        Else
            RB1.Text = "ES1213 , departure time 11.00PM,"
            RB2.Text = "ES1214 , departure time 9.00PM,"
            RB3.Text = "ES1215 , departure time 7.00PM,"
            RB4.Text = "ES1216 , departure time 2.00PM,"
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If 
        FormSeat.Show()
        Me.Close()
    End Sub
End Class