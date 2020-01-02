<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCusInfo
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
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(63, 367)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(75, 23)
        Me.Button_Back.TabIndex = 0
        Me.Button_Back.Text = "Back"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Location = New System.Drawing.Point(673, 367)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 1
        Me.Button_Next.Text = "Next"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'FormCusInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_Back)
        Me.Name = "FormCusInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCusInfo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Back As Button
    Friend WithEvents Button_Next As Button
End Class
