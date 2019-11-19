<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeatTest
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
        Me.components = New System.ComponentModel.Container()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(355, 160)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 23)
        Me.SetButton.TabIndex = 0
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"B1A", "B2A", "B3A", "B4A", "B5A", "B6A", "B7A", "B8A", "B9A", "B1B", "B2B", "B3B", "B4B", "B5B", "B6B", "B7B", "B8B", "B9B", "B1C", "B2C", "B3C", "B4C", "B5C", "B6C", "B7C", "B8C", "B9C", "B1D", "B2D", "B3D", "B4D", "B5D", "B6D", "B7D", "B8D", "B9D"})
        Me.ListBox1.Location = New System.Drawing.Point(97, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 292)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(587, 46)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 292)
        Me.ListBox2.TabIndex = 2
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(355, 226)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 3
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'FormSeatTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SetButton)
        Me.Name = "FormSeatTest"
        Me.Text = "FormSeatTest"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SetButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RemoveButton As Button
End Class
