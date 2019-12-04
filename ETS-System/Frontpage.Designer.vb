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
        Me.ComboBox5Adult = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox3Time = New System.Windows.Forms.ComboBox()
        Me.ComboBox6Child = New System.Windows.Forms.ComboBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.ComboBox1Origin = New System.Windows.Forms.ComboBox()
        Me.ComboBox2Destination = New System.Windows.Forms.ComboBox()
        Me.ComboBox4Class = New System.Windows.Forms.ComboBox()
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
        'ComboBox5Adult
        '
        Me.ComboBox5Adult.FormattingEnabled = True
        Me.ComboBox5Adult.Items.AddRange(New Object() {"0 Adult", "1 Adult", "2 Adult", "3 Adult", "4 Adult", "5 Adult", "6 Adult"})
        Me.ComboBox5Adult.Location = New System.Drawing.Point(174, 262)
        Me.ComboBox5Adult.Name = "ComboBox5Adult"
        Me.ComboBox5Adult.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox5Adult.TabIndex = 1
        Me.ComboBox5Adult.Text = "Adult"
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
        'ComboBox6Child
        '
        Me.ComboBox6Child.FormattingEnabled = True
        Me.ComboBox6Child.Items.AddRange(New Object() {"0 Child", "1 Child", "2 Children", "3 Children", "4 Children", "5 Children", "6 Children"})
        Me.ComboBox6Child.Location = New System.Drawing.Point(310, 262)
        Me.ComboBox6Child.Name = "ComboBox6Child"
        Me.ComboBox6Child.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox6Child.TabIndex = 4
        Me.ComboBox6Child.Text = "Child"
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
        'ComboBox4Class
        '
        Me.ComboBox4Class.FormattingEnabled = True
        Me.ComboBox4Class.Items.AddRange(New Object() {"Standard Class", "Business Class"})
        Me.ComboBox4Class.Location = New System.Drawing.Point(38, 262)
        Me.ComboBox4Class.Name = "ComboBox4Class"
        Me.ComboBox4Class.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox4Class.TabIndex = 8
        Me.ComboBox4Class.Text = "Class"
        '
        'Frontpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox4Class)
        Me.Controls.Add(Me.ComboBox2Destination)
        Me.Controls.Add(Me.ComboBox1Origin)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ComboBox6Child)
        Me.Controls.Add(Me.ComboBox3Time)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox5Adult)
        Me.Controls.Add(Me.Next_button)
        Me.Name = "Frontpage"
        Me.Text = "Express Train System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Next_button As Button
    Friend WithEvents ComboBox5Adult As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox3Time As ComboBox
    Friend WithEvents ComboBox6Child As ComboBox
    Friend WithEvents Title As Label
    Friend WithEvents ComboBox1Origin As ComboBox
    Friend WithEvents ComboBox2Destination As ComboBox
    Friend WithEvents ComboBox4Class As ComboBox
End Class
