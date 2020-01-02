<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfirm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Confirm_Button = New System.Windows.Forms.Button()
        Me.Return_Button = New System.Windows.Forms.Button()
        Me.RBDebit = New System.Windows.Forms.RadioButton()
        Me.RBCredit = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelArrivalBack = New System.Windows.Forms.Label()
        Me.LabelDepartureBack = New System.Windows.Forms.Label()
        Me.LabelClassBack = New System.Windows.Forms.Label()
        Me.LabelTrainBack = New System.Windows.Forms.Label()
        Me.LabelArrivalGo = New System.Windows.Forms.Label()
        Me.LabelDepartureGo = New System.Windows.Forms.Label()
        Me.LabelClassGo = New System.Windows.Forms.Label()
        Me.LabelTrainGo = New System.Windows.Forms.Label()
        Me.LabelLine2 = New System.Windows.Forms.Label()
        Me.LabelLine1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Confirm_Button)
        Me.GroupBox1.Controls.Add(Me.Return_Button)
        Me.GroupBox1.Controls.Add(Me.RBDebit)
        Me.GroupBox1.Controls.Add(Me.RBCredit)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 588)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'Confirm_Button
        '
        Me.Confirm_Button.Location = New System.Drawing.Point(432, 100)
        Me.Confirm_Button.Name = "Confirm_Button"
        Me.Confirm_Button.Size = New System.Drawing.Size(75, 36)
        Me.Confirm_Button.TabIndex = 2
        Me.Confirm_Button.Text = "Pay"
        Me.Confirm_Button.UseVisualStyleBackColor = True
        '
        'Return_Button
        '
        Me.Return_Button.Location = New System.Drawing.Point(247, 100)
        Me.Return_Button.Name = "Return_Button"
        Me.Return_Button.Size = New System.Drawing.Size(89, 36)
        Me.Return_Button.TabIndex = 1
        Me.Return_Button.Text = "Return"
        Me.Return_Button.UseVisualStyleBackColor = True
        '
        'RBDebit
        '
        Me.RBDebit.AutoSize = True
        Me.RBDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDebit.Location = New System.Drawing.Point(430, 38)
        Me.RBDebit.Name = "RBDebit"
        Me.RBDebit.Size = New System.Drawing.Size(70, 24)
        Me.RBDebit.TabIndex = 1
        Me.RBDebit.TabStop = True
        Me.RBDebit.Text = "Debit"
        Me.RBDebit.UseVisualStyleBackColor = True
        '
        'RBCredit
        '
        Me.RBCredit.AutoSize = True
        Me.RBCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCredit.Location = New System.Drawing.Point(189, 38)
        Me.RBCredit.Name = "RBCredit"
        Me.RBCredit.Size = New System.Drawing.Size(75, 24)
        Me.RBCredit.TabIndex = 0
        Me.RBCredit.TabStop = True
        Me.RBCredit.Text = "Credit"
        Me.RBCredit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LabelArrivalBack)
        Me.GroupBox2.Controls.Add(Me.LabelDepartureBack)
        Me.GroupBox2.Controls.Add(Me.LabelClassBack)
        Me.GroupBox2.Controls.Add(Me.LabelTrainBack)
        Me.GroupBox2.Controls.Add(Me.LabelArrivalGo)
        Me.GroupBox2.Controls.Add(Me.LabelDepartureGo)
        Me.GroupBox2.Controls.Add(Me.LabelClassGo)
        Me.GroupBox2.Controls.Add(Me.LabelTrainGo)
        Me.GroupBox2.Controls.Add(Me.LabelLine2)
        Me.GroupBox2.Controls.Add(Me.LabelLine1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LabelTotal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(780, 542)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Journey Summary"
        '
        'LabelArrivalBack
        '
        Me.LabelArrivalBack.AutoSize = True
        Me.LabelArrivalBack.Location = New System.Drawing.Point(202, 494)
        Me.LabelArrivalBack.Name = "LabelArrivalBack"
        Me.LabelArrivalBack.Size = New System.Drawing.Size(103, 24)
        Me.LabelArrivalBack.TabIndex = 22
        Me.LabelArrivalBack.Text = "ArrivalBack"
        Me.LabelArrivalBack.Visible = False
        '
        'LabelDepartureBack
        '
        Me.LabelDepartureBack.AutoSize = True
        Me.LabelDepartureBack.Location = New System.Drawing.Point(202, 456)
        Me.LabelDepartureBack.Name = "LabelDepartureBack"
        Me.LabelDepartureBack.Size = New System.Drawing.Size(134, 24)
        Me.LabelDepartureBack.TabIndex = 21
        Me.LabelDepartureBack.Text = "DepartureBack"
        Me.LabelDepartureBack.Visible = False
        '
        'LabelClassBack
        '
        Me.LabelClassBack.AutoSize = True
        Me.LabelClassBack.Location = New System.Drawing.Point(202, 418)
        Me.LabelClassBack.Name = "LabelClassBack"
        Me.LabelClassBack.Size = New System.Drawing.Size(96, 24)
        Me.LabelClassBack.TabIndex = 20
        Me.LabelClassBack.Text = "ClassBack"
        Me.LabelClassBack.Visible = False
        '
        'LabelTrainBack
        '
        Me.LabelTrainBack.AutoSize = True
        Me.LabelTrainBack.Location = New System.Drawing.Point(202, 380)
        Me.LabelTrainBack.Name = "LabelTrainBack"
        Me.LabelTrainBack.Size = New System.Drawing.Size(94, 24)
        Me.LabelTrainBack.TabIndex = 19
        Me.LabelTrainBack.Text = "TrainBack"
        Me.LabelTrainBack.Visible = False
        '
        'LabelArrivalGo
        '
        Me.LabelArrivalGo.AutoSize = True
        Me.LabelArrivalGo.Location = New System.Drawing.Point(202, 280)
        Me.LabelArrivalGo.Name = "LabelArrivalGo"
        Me.LabelArrivalGo.Size = New System.Drawing.Size(87, 24)
        Me.LabelArrivalGo.TabIndex = 18
        Me.LabelArrivalGo.Text = "ArrivalGo"
        '
        'LabelDepartureGo
        '
        Me.LabelDepartureGo.AutoSize = True
        Me.LabelDepartureGo.Location = New System.Drawing.Point(202, 242)
        Me.LabelDepartureGo.Name = "LabelDepartureGo"
        Me.LabelDepartureGo.Size = New System.Drawing.Size(118, 24)
        Me.LabelDepartureGo.TabIndex = 17
        Me.LabelDepartureGo.Text = "DepartureGo"
        '
        'LabelClassGo
        '
        Me.LabelClassGo.AutoSize = True
        Me.LabelClassGo.Location = New System.Drawing.Point(202, 204)
        Me.LabelClassGo.Name = "LabelClassGo"
        Me.LabelClassGo.Size = New System.Drawing.Size(80, 24)
        Me.LabelClassGo.TabIndex = 16
        Me.LabelClassGo.Text = "ClassGo"
        '
        'LabelTrainGo
        '
        Me.LabelTrainGo.AutoSize = True
        Me.LabelTrainGo.Location = New System.Drawing.Point(202, 166)
        Me.LabelTrainGo.Name = "LabelTrainGo"
        Me.LabelTrainGo.Size = New System.Drawing.Size(78, 24)
        Me.LabelTrainGo.TabIndex = 15
        Me.LabelTrainGo.Text = "TrainGo"
        '
        'LabelLine2
        '
        Me.LabelLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLine2.Location = New System.Drawing.Point(6, 321)
        Me.LabelLine2.Name = "LabelLine2"
        Me.LabelLine2.Size = New System.Drawing.Size(768, 2)
        Me.LabelLine2.TabIndex = 14
        '
        'LabelLine1
        '
        Me.LabelLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLine1.Location = New System.Drawing.Point(6, 107)
        Me.LabelLine1.Name = "LabelLine1"
        Me.LabelLine1.Size = New System.Drawing.Size(768, 2)
        Me.LabelLine1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Arrival :"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Departure :"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Class :"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 380)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 24)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Train No :"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 24)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Destination - Origin"
        Me.Label12.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Arrival :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Departure :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Class :"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(27, 73)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(61, 24)
        Me.LabelTotal.TabIndex = 1
        Me.LabelTotal.Text = "Total :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Train No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grand Total (MYR)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Origin - Destination"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ETS_System.My.Resources.Resources.master
        Me.PictureBox2.Location = New System.Drawing.Point(506, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ETS_System.My.Resources.Resources.visa
        Me.PictureBox1.Location = New System.Drawing.Point(269, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FormConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ETS_System.My.Resources.Resources._25461_hd_images_for_website_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 758)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "FormConfirm"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormConfirm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Confirm_Button As Button
    Friend WithEvents RBDebit As RadioButton
    Friend WithEvents RBCredit As RadioButton
    Friend WithEvents Return_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelLine2 As Label
    Friend WithEvents LabelLine1 As Label
    Friend WithEvents LabelArrivalBack As Label
    Friend WithEvents LabelDepartureBack As Label
    Friend WithEvents LabelClassBack As Label
    Friend WithEvents LabelTrainBack As Label
    Friend WithEvents LabelArrivalGo As Label
    Friend WithEvents LabelDepartureGo As Label
    Friend WithEvents LabelClassGo As Label
    Friend WithEvents LabelTrainGo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
