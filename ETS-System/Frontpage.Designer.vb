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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0 Adult", "1 Adult", "2 Adult", "3 Adult", "4 Adult", "5 Adult", "6 Adult"})
        Me.ComboBox1.Location = New System.Drawing.Point(75, 262)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Adult"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(374, 185)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"12:00 AM - 06:59 AM", "07:00 AM - 11:59 AM", "12:00 PM - 06:59 PM", "07:00 PM - 11:59 PM"})
        Me.ComboBox2.Location = New System.Drawing.Point(633, 183)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.Text = "Travel Time"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0 Child", "1 Child", "2 Children", "3 Children", "4 Children", "5 Children", "6 Children"})
        Me.ComboBox3.Location = New System.Drawing.Point(216, 262)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 4
        Me.ComboBox3.Text = "Child"
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
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Rawang", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox4.Location = New System.Drawing.Point(75, 183)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox4.TabIndex = 6
        Me.ComboBox4.Text = "Origin"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Rawang", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox5.Location = New System.Drawing.Point(216, 183)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox5.TabIndex = 7
        Me.ComboBox5.Text = "Destination"
        '
        'Frontpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Next_button)
        Me.Name = "Frontpage"
        Me.Text = "Express Train System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Next_button As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Title As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
End Class
