<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frontpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Next_button = New System.Windows.Forms.Button()
        Me.ComboBox4Adult = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox3Time = New System.Windows.Forms.ComboBox()
        Me.ComboBox5Child = New System.Windows.Forms.ComboBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.ComboBox1Origin = New System.Windows.Forms.ComboBox()
        Me.ComboBox2Destination = New System.Windows.Forms.ComboBox()
        Me.ComboBox6Class = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Next_button
        '
        Me.Next_button.Location = New System.Drawing.Point(590, 323)
        Me.Next_button.Name = "Next_button"
        Me.Next_button.Size = New System.Drawing.Size(75, 23)
        Me.Next_button.TabIndex = 0
        Me.Next_button.Text = "Search"
        Me.Next_button.UseVisualStyleBackColor = True
        '
        'ComboBox4Adult
        '
        Me.ComboBox4Adult.FormattingEnabled = True
        Me.ComboBox4Adult.Items.AddRange(New Object() {"0 Adult", "1 Adult", "2 Adult", "3 Adult", "4 Adult", "5 Adult", "6 Adult"})
        Me.ComboBox4Adult.Location = New System.Drawing.Point(38, 262)
        Me.ComboBox4Adult.Name = "ComboBox4Adult"
        Me.ComboBox4Adult.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox4Adult.TabIndex = 1
        Me.ComboBox4Adult.Text = "Adult"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 185)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(246, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ComboBox3Time
        '
        Me.ComboBox3Time.FormattingEnabled = True
        Me.ComboBox3Time.Items.AddRange(New Object() {"12:00 AM - 06:59 AM", "07:00 AM - 11:59 AM", "12:00 PM - 06:59 PM", "07:00 PM - 11:59 PM"})
        Me.ComboBox3Time.Location = New System.Drawing.Point(576, 183)
        Me.ComboBox3Time.Name = "ComboBox3Time"
        Me.ComboBox3Time.Size = New System.Drawing.Size(194, 24)
        Me.ComboBox3Time.TabIndex = 3
        Me.ComboBox3Time.Text = "Travel Time"
        '
        'ComboBox5Child
        '
        Me.ComboBox5Child.FormattingEnabled = True
        Me.ComboBox5Child.Items.AddRange(New Object() {"0 Child", "1 Child", "2 Children", "3 Children", "4 Children", "5 Children", "6 Children"})
        Me.ComboBox5Child.Location = New System.Drawing.Point(174, 262)
        Me.ComboBox5Child.Name = "ComboBox5Child"
        Me.ComboBox5Child.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox5Child.TabIndex = 4
        Me.ComboBox5Child.Text = "Child"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(335, 73)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(145, 17)
        Me.Title.TabIndex = 5
        Me.Title.Text = "Express Train System"
        '
        'ComboBox1Origin
        '
        Me.ComboBox1Origin.FormattingEnabled = True
        Me.ComboBox1Origin.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox1Origin.Location = New System.Drawing.Point(38, 183)
        Me.ComboBox1Origin.Name = "ComboBox1Origin"
        Me.ComboBox1Origin.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1Origin.TabIndex = 6
        Me.ComboBox1Origin.Text = "Origin"
        '
        'ComboBox2Destination
        '
        Me.ComboBox2Destination.FormattingEnabled = True
        Me.ComboBox2Destination.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox2Destination.Location = New System.Drawing.Point(174, 183)
        Me.ComboBox2Destination.Name = "ComboBox2Destination"
        Me.ComboBox2Destination.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2Destination.TabIndex = 7
        Me.ComboBox2Destination.Text = "Destination"
        '
        'ComboBox6Class
        '
        Me.ComboBox6Class.FormattingEnabled = True
        Me.ComboBox6Class.Location = New System.Drawing.Point(311, 260)
        Me.ComboBox6Class.Name = "ComboBox6Class"
        Me.ComboBox6Class.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox6Class.TabIndex = 8
        '
        'Frontpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox6Class)
        Me.Controls.Add(Me.ComboBox2Destination)
        Me.Controls.Add(Me.ComboBox1Origin)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ComboBox5Child)
        Me.Controls.Add(Me.ComboBox3Time)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox4Adult)
        Me.Controls.Add(Me.Next_button)
        Me.Name = "Frontpage"
        Me.Text = "Express Train System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Next_button As Button
    Friend WithEvents ComboBox4Adult As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox3Time As ComboBox
    Friend WithEvents ComboBox5Child As ComboBox
    Friend WithEvents Title As Label
    Friend WithEvents ComboBox1Origin As ComboBox
    Friend WithEvents ComboBox2Destination As ComboBox
    Friend WithEvents ComboBox6Class As ComboBox
End Class
