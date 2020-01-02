<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SeatNumLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ICLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ICTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SeatNumLabel
        '
        Me.SeatNumLabel.AutoSize = True
        Me.SeatNumLabel.Location = New System.Drawing.Point(46, 36)
        Me.SeatNumLabel.Name = "SeatNumLabel"
        Me.SeatNumLabel.Size = New System.Drawing.Size(51, 17)
        Me.SeatNumLabel.TabIndex = 0
        Me.SeatNumLabel.Text = "Label1"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(46, 85)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 17)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'ICLabel
        '
        Me.ICLabel.AutoSize = True
        Me.ICLabel.Location = New System.Drawing.Point(46, 158)
        Me.ICLabel.Name = "ICLabel"
        Me.ICLabel.Size = New System.Drawing.Size(20, 17)
        Me.ICLabel.TabIndex = 2
        Me.ICLabel.Text = "IC"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(160, 82)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(328, 22)
        Me.NameTextBox.TabIndex = 3
        '
        'ICTextBox
        '
        Me.ICTextBox.Location = New System.Drawing.Point(160, 158)
        Me.ICTextBox.Name = "ICTextBox"
        Me.ICTextBox.Size = New System.Drawing.Size(328, 22)
        Me.ICTextBox.TabIndex = 4
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ICTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.ICLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SeatNumLabel)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(533, 241)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeatNumLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents ICLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ICTextBox As TextBox
End Class
