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
        Me.ComboBox1Adult = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2Time = New System.Windows.Forms.ComboBox()
        Me.ComboBox3Child = New System.Windows.Forms.ComboBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.ComboBox4Origin = New System.Windows.Forms.ComboBox()
        Me.ComboBox5Destination = New System.Windows.Forms.ComboBox()
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
        'ComboBox1Adult
        '
        Me.ComboBox1Adult.FormattingEnabled = True
        Me.ComboBox1Adult.Items.AddRange(New Object() {"0 Adult", "1 Adult", "2 Adult", "3 Adult", "4 Adult", "5 Adult", "6 Adult"})
        Me.ComboBox1Adult.Location = New System.Drawing.Point(38, 262)
        Me.ComboBox1Adult.Name = "ComboBox1Adult"
        Me.ComboBox1Adult.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1Adult.TabIndex = 1
        Me.ComboBox1Adult.Text = "Adult"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 185)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(246, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ComboBox2Time
        '
        Me.ComboBox2Time.FormattingEnabled = True
        Me.ComboBox2Time.Items.AddRange(New Object() {"12:00 AM - 06:59 AM", "07:00 AM - 11:59 AM", "12:00 PM - 06:59 PM", "07:00 PM - 11:59 PM"})
        Me.ComboBox2Time.Location = New System.Drawing.Point(576, 183)
        Me.ComboBox2Time.Name = "ComboBox2Time"
        Me.ComboBox2Time.Size = New System.Drawing.Size(194, 24)
        Me.ComboBox2Time.TabIndex = 3
        Me.ComboBox2Time.Text = "Travel Time"
        '
        'ComboBox3Child
        '
        Me.ComboBox3Child.FormattingEnabled = True
        Me.ComboBox3Child.Items.AddRange(New Object() {"0 Child", "1 Child", "2 Children", "3 Children", "4 Children", "5 Children", "6 Children"})
        Me.ComboBox3Child.Location = New System.Drawing.Point(174, 262)
        Me.ComboBox3Child.Name = "ComboBox3Child"
        Me.ComboBox3Child.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3Child.TabIndex = 4
        Me.ComboBox3Child.Text = "Child"
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
        'ComboBox4Origin
        '
        Me.ComboBox4Origin.FormattingEnabled = True
        Me.ComboBox4Origin.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox4Origin.Location = New System.Drawing.Point(38, 183)
        Me.ComboBox4Origin.Name = "ComboBox4Origin"
        Me.ComboBox4Origin.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox4Origin.TabIndex = 6
        Me.ComboBox4Origin.Text = "Origin"
        '
        'ComboBox5Destination
        '
        Me.ComboBox5Destination.FormattingEnabled = True
        Me.ComboBox5Destination.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox5Destination.Location = New System.Drawing.Point(174, 183)
        Me.ComboBox5Destination.Name = "ComboBox5Destination"
        Me.ComboBox5Destination.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox5Destination.TabIndex = 7
        Me.ComboBox5Destination.Text = "Destination"
        '
        'Frontpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox5Destination)
        Me.Controls.Add(Me.ComboBox4Origin)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ComboBox3Child)
        Me.Controls.Add(Me.ComboBox2Time)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1Adult)
        Me.Controls.Add(Me.Next_button)
        Me.Name = "Frontpage"
        Me.Text = "Express Train System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Next_button As Button
    Friend WithEvents ComboBox1Adult As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2Time As ComboBox
    Friend WithEvents ComboBox3Child As ComboBox
    Friend WithEvents Title As Label
    Friend WithEvents ComboBox4Origin As ComboBox
    Friend WithEvents ComboBox5Destination As ComboBox
End Class
