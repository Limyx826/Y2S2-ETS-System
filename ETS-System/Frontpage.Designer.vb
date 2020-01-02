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
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ComboBox1Origin = New System.Windows.Forms.ComboBox()
        Me.ComboBox2Destination = New System.Windows.Forms.ComboBox()
        Me.ComboBox4Class = New System.Windows.Forms.ComboBox()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBReturn = New System.Windows.Forms.RadioButton()
        Me.RBOneWay = New System.Windows.Forms.RadioButton()
        Me.LabelDepature = New System.Windows.Forms.Label()
        Me.LabelReturn = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Next_button
        '
        Me.Next_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_button.Location = New System.Drawing.Point(492, 311)
        Me.Next_button.Name = "Next_button"
        Me.Next_button.Size = New System.Drawing.Size(102, 39)
        Me.Next_button.TabIndex = 0
        Me.Next_button.Text = "Search"
        Me.Next_button.UseVisualStyleBackColor = True
        '
        'ComboBox5Adult
        '
        Me.ComboBox5Adult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5Adult.FormattingEnabled = True
        Me.ComboBox5Adult.Items.AddRange(New Object() {"0 Adult", "1 Adult", "2 Adult", "3 Adult", "4 Adult", "5 Adult", "6 Adult"})
        Me.ComboBox5Adult.Location = New System.Drawing.Point(201, 319)
        Me.ComboBox5Adult.Name = "ComboBox5Adult"
        Me.ComboBox5Adult.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox5Adult.TabIndex = 1
        Me.ComboBox5Adult.Text = "Adult"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(36, 256)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(315, 27)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ComboBox3Time
        '
        Me.ComboBox3Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3Time.FormattingEnabled = True
        Me.ComboBox3Time.Items.AddRange(New Object() {"12:00 AM - 06:59 AM", "07:00 AM - 11:59 AM", "12:00 PM - 06:59 PM", "07:00 PM - 11:59 PM"})
        Me.ComboBox3Time.Location = New System.Drawing.Point(438, 183)
        Me.ComboBox3Time.Name = "ComboBox3Time"
        Me.ComboBox3Time.Size = New System.Drawing.Size(194, 28)
        Me.ComboBox3Time.TabIndex = 3
        Me.ComboBox3Time.Text = "Travel Time"
        '
        'ComboBox6Child
        '
        Me.ComboBox6Child.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6Child.FormattingEnabled = True
        Me.ComboBox6Child.Items.AddRange(New Object() {"0 Child", "1 Child", "2 Children", "3 Children", "4 Children", "5 Children", "6 Children"})
        Me.ComboBox6Child.Location = New System.Drawing.Point(328, 319)
        Me.ComboBox6Child.Name = "ComboBox6Child"
        Me.ComboBox6Child.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox6Child.TabIndex = 4
        Me.ComboBox6Child.Text = "Child"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(249, 64)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(304, 36)
        Me.LabelTitle.TabIndex = 5
        Me.LabelTitle.Text = "Express Train System"
        '
        'ComboBox1Origin
        '
        Me.ComboBox1Origin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1Origin.FormattingEnabled = True
        Me.ComboBox1Origin.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox1Origin.Location = New System.Drawing.Point(236, 183)
        Me.ComboBox1Origin.Name = "ComboBox1Origin"
        Me.ComboBox1Origin.Size = New System.Drawing.Size(181, 28)
        Me.ComboBox1Origin.TabIndex = 6
        Me.ComboBox1Origin.Text = "Origin"
        '
        'ComboBox2Destination
        '
        Me.ComboBox2Destination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2Destination.FormattingEnabled = True
        Me.ComboBox2Destination.Items.AddRange(New Object() {"Padang Besar", "Arau", "Anak Bukit", "Alor Star", "Gurun", "Sungai Petani", "Butterworth", "Bukit Mertajam", "Taiping", "Kuala Kangsar", "Ipoh", "Batu Gajah", "Kampar", "Tanjung Malim", "Kuala Lumpur", "KL Sentral"})
        Me.ComboBox2Destination.Location = New System.Drawing.Point(36, 183)
        Me.ComboBox2Destination.Name = "ComboBox2Destination"
        Me.ComboBox2Destination.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox2Destination.TabIndex = 7
        Me.ComboBox2Destination.Text = "Destination"
        '
        'ComboBox4Class
        '
        Me.ComboBox4Class.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4Class.FormattingEnabled = True
        Me.ComboBox4Class.Items.AddRange(New Object() {"Standard Class", "Business Class"})
        Me.ComboBox4Class.Location = New System.Drawing.Point(36, 319)
        Me.ComboBox4Class.Name = "ComboBox4Class"
        Me.ComboBox4Class.Size = New System.Drawing.Size(159, 28)
        Me.ComboBox4Class.TabIndex = 8
        Me.ComboBox4Class.Text = "Class"
        '
        'Login_Button
        '
        Me.Login_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Button.Location = New System.Drawing.Point(627, 12)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(93, 47)
        Me.Login_Button.TabIndex = 9
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 80)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 17)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Database"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBReturn)
        Me.GroupBox1.Controls.Add(Me.RBOneWay)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 58)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'RBReturn
        '
        Me.RBReturn.AutoSize = True
        Me.RBReturn.Location = New System.Drawing.Point(154, 21)
        Me.RBReturn.Name = "RBReturn"
        Me.RBReturn.Size = New System.Drawing.Size(72, 21)
        Me.RBReturn.TabIndex = 12
        Me.RBReturn.TabStop = True
        Me.RBReturn.Text = "Return"
        Me.RBReturn.UseVisualStyleBackColor = True
        '
        'RBOneWay
        '
        Me.RBOneWay.AutoSize = True
        Me.RBOneWay.Checked = True
        Me.RBOneWay.Location = New System.Drawing.Point(20, 21)
        Me.RBOneWay.Name = "RBOneWay"
        Me.RBOneWay.Size = New System.Drawing.Size(88, 21)
        Me.RBOneWay.TabIndex = 0
        Me.RBOneWay.TabStop = True
        Me.RBOneWay.Text = "One Way"
        Me.RBOneWay.UseVisualStyleBackColor = True
        '
        'LabelDepature
        '
        Me.LabelDepature.AutoSize = True
        Me.LabelDepature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDepature.Location = New System.Drawing.Point(34, 233)
        Me.LabelDepature.Name = "LabelDepature"
        Me.LabelDepature.Size = New System.Drawing.Size(119, 20)
        Me.LabelDepature.TabIndex = 13
        Me.LabelDepature.Text = "Depature Date"
        '
        'LabelReturn
        '
        Me.LabelReturn.AutoSize = True
        Me.LabelReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReturn.Location = New System.Drawing.Point(388, 233)
        Me.LabelReturn.Name = "LabelReturn"
        Me.LabelReturn.Size = New System.Drawing.Size(100, 20)
        Me.LabelReturn.TabIndex = 14
        Me.LabelReturn.Text = "Return Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(392, 256)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(316, 27)
        Me.DateTimePicker2.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ETS_System.My.Resources.Resources.ETS
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Frontpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(732, 384)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.LabelReturn)
        Me.Controls.Add(Me.LabelDepature)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.ComboBox4Class)
        Me.Controls.Add(Me.ComboBox2Destination)
        Me.Controls.Add(Me.ComboBox1Origin)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ComboBox6Child)
        Me.Controls.Add(Me.ComboBox3Time)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox5Adult)
        Me.Controls.Add(Me.Next_button)
        Me.Name = "Frontpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Express Train System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Next_button As Button
    Friend WithEvents ComboBox5Adult As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox3Time As ComboBox
    Friend WithEvents ComboBox6Child As ComboBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ComboBox1Origin As ComboBox
    Friend WithEvents ComboBox2Destination As ComboBox
    Friend WithEvents ComboBox4Class As ComboBox
    Friend WithEvents Login_Button As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBReturn As RadioButton
    Friend WithEvents RBOneWay As RadioButton
    Friend WithEvents LabelDepature As Label
    Friend WithEvents LabelReturn As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
End Class
