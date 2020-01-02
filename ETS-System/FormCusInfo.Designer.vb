<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCusInfo
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
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ICTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ICLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SeatNumLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(41, 400)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 23)
        Me.Button_Back.TabIndex = 0
        Me.Button_Back.Text = "Back"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Location = New System.Drawing.Point(693, 400)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 1
        Me.Button_Next.Text = "Next"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ICTextBox)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(Me.ICLabel)
        Me.Panel1.Controls.Add(Me.NameLabel)
        Me.Panel1.Controls.Add(Me.SeatNumLabel)
        Me.Panel1.Location = New System.Drawing.Point(13, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 175)
        Me.Panel1.TabIndex = 2
        '
        'ICTextBox
        '
        Me.ICTextBox.Location = New System.Drawing.Point(157, 126)
        Me.ICTextBox.Name = "ICTextBox"
        Me.ICTextBox.Size = New System.Drawing.Size(328, 22)
        Me.ICTextBox.TabIndex = 9
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(157, 50)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(328, 22)
        Me.NameTextBox.TabIndex = 8
        '
        'ICLabel
        '
        Me.ICLabel.AutoSize = True
        Me.ICLabel.Location = New System.Drawing.Point(43, 126)
        Me.ICLabel.Name = "ICLabel"
        Me.ICLabel.Size = New System.Drawing.Size(20, 17)
        Me.ICLabel.TabIndex = 7
        Me.ICLabel.Text = "IC"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(43, 53)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        '
        'SeatNumLabel
        '
        Me.SeatNumLabel.AutoSize = True
        Me.SeatNumLabel.Location = New System.Drawing.Point(43, 19)
        Me.SeatNumLabel.Name = "SeatNumLabel"
        Me.SeatNumLabel.Size = New System.Drawing.Size(51, 17)
        Me.SeatNumLabel.TabIndex = 5
        Me.SeatNumLabel.Text = "Label1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(50, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10, 5, 5, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(722, 359)
        Me.FlowLayoutPanel1.TabIndex = 3
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(370, 400)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 4
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'FormCusInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_Back)
        Me.Name = "FormCusInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCusInfo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Back As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ICTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ICLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents SeatNumLabel As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button_Add As Button
End Class
