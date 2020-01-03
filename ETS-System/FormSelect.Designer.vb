<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Back_button = New System.Windows.Forms.Button()
        Me.RB4 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.JCLODataSet = New ETS_System.JCLODataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RB8 = New System.Windows.Forms.RadioButton()
        Me.RB7 = New System.Windows.Forms.RadioButton()
        Me.RB6 = New System.Windows.Forms.RadioButton()
        Me.RB5 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(59, 54)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(663, 86)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Back_button
        '
        Me.Back_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_button.Location = New System.Drawing.Point(59, 421)
        Me.Back_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back_button.Name = "Back_button"
        Me.Back_button.Size = New System.Drawing.Size(75, 28)
        Me.Back_button.TabIndex = 1
        Me.Back_button.Text = "Back"
        Me.Back_button.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.AutoSize = True
        Me.RB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB4.Location = New System.Drawing.Point(7, 161)
        Me.RB4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(131, 24)
        Me.RB4.TabIndex = 24
        Me.RB4.Text = "RadioButton4"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB3.Location = New System.Drawing.Point(7, 113)
        Me.RB3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(131, 24)
        Me.RB3.TabIndex = 23
        Me.RB3.Text = "RadioButton3"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(7, 69)
        Me.RB2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(131, 24)
        Me.RB2.TabIndex = 22
        Me.RB2.Text = "RadioButton2"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(7, 21)
        Me.RB1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(131, 24)
        Me.RB1.TabIndex = 21
        Me.RB1.TabStop = True
        Me.RB1.Text = "RadioButton1"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(681, 421)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 28)
        Me.NextButton.TabIndex = 37
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'JCLODataSet
        '
        Me.JCLODataSet.DataSetName = "JCLODataSet"
        Me.JCLODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ETS_System.My.Resources.Resources.ETS
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(59, 183)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 231)
        Me.TabControl1.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RB2)
        Me.TabPage1.Controls.Add(Me.RB1)
        Me.TabPage1.Controls.Add(Me.RB3)
        Me.TabPage1.Controls.Add(Me.RB4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(656, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "One Way"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RB8)
        Me.TabPage2.Controls.Add(Me.RB7)
        Me.TabPage2.Controls.Add(Me.RB6)
        Me.TabPage2.Controls.Add(Me.RB5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(656, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Return"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RB8
        '
        Me.RB8.AutoSize = True
        Me.RB8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB8.Location = New System.Drawing.Point(7, 160)
        Me.RB8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB8.Name = "RB8"
        Me.RB8.Size = New System.Drawing.Size(131, 24)
        Me.RB8.TabIndex = 28
        Me.RB8.Text = "RadioButton4"
        Me.RB8.UseVisualStyleBackColor = True
        '
        'RB7
        '
        Me.RB7.AutoSize = True
        Me.RB7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB7.Location = New System.Drawing.Point(7, 112)
        Me.RB7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB7.Name = "RB7"
        Me.RB7.Size = New System.Drawing.Size(131, 24)
        Me.RB7.TabIndex = 27
        Me.RB7.Text = "RadioButton3"
        Me.RB7.UseVisualStyleBackColor = True
        '
        'RB6
        '
        Me.RB6.AutoSize = True
        Me.RB6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB6.Location = New System.Drawing.Point(7, 68)
        Me.RB6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB6.Name = "RB6"
        Me.RB6.Size = New System.Drawing.Size(131, 24)
        Me.RB6.TabIndex = 26
        Me.RB6.Text = "RadioButton2"
        Me.RB6.UseVisualStyleBackColor = True
        '
        'RB5
        '
        Me.RB5.AutoSize = True
        Me.RB5.Checked = True
        Me.RB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB5.Location = New System.Drawing.Point(7, 20)
        Me.RB5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(131, 24)
        Me.RB5.TabIndex = 25
        Me.RB5.TabStop = True
        Me.RB5.Text = "RadioButton1"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Train Selection"
        '
        'FormSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ETS_System.My.Resources.Resources._25461_hd_images_for_website_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 501)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Back_button)
        Me.Controls.Add(Me.ListView1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Train"
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Back_button As Button
    Friend WithEvents RB4 As RadioButton
    Friend WithEvents RB3 As RadioButton
    Friend WithEvents RB2 As RadioButton
    Friend WithEvents RB1 As RadioButton
    Friend WithEvents NextButton As Button
    Friend WithEvents JCLODataSet As JCLODataSet
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RB8 As RadioButton
    Friend WithEvents RB7 As RadioButton
    Friend WithEvents RB6 As RadioButton
    Friend WithEvents RB5 As RadioButton
    Friend WithEvents Label1 As Label
End Class
