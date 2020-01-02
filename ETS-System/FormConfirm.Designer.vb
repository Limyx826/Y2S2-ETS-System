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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Confirm_Button)
        Me.GroupBox1.Controls.Add(Me.Return_Button)
        Me.GroupBox1.Controls.Add(Me.RBDebit)
        Me.GroupBox1.Controls.Add(Me.RBCredit)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 181)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'Confirm_Button
        '
        Me.Confirm_Button.Location = New System.Drawing.Point(305, 89)
        Me.Confirm_Button.Name = "Confirm_Button"
        Me.Confirm_Button.Size = New System.Drawing.Size(75, 23)
        Me.Confirm_Button.TabIndex = 2
        Me.Confirm_Button.Text = "Pay"
        Me.Confirm_Button.UseVisualStyleBackColor = True
        '
        'Return_Button
        '
        Me.Return_Button.Location = New System.Drawing.Point(305, 139)
        Me.Return_Button.Name = "Return_Button"
        Me.Return_Button.Size = New System.Drawing.Size(75, 23)
        Me.Return_Button.TabIndex = 1
        Me.Return_Button.Text = "Return"
        Me.Return_Button.UseVisualStyleBackColor = True
        '
        'RBDebit
        '
        Me.RBDebit.AutoSize = True
        Me.RBDebit.Location = New System.Drawing.Point(415, 34)
        Me.RBDebit.Name = "RBDebit"
        Me.RBDebit.Size = New System.Drawing.Size(62, 21)
        Me.RBDebit.TabIndex = 1
        Me.RBDebit.TabStop = True
        Me.RBDebit.Text = "Debit"
        Me.RBDebit.UseVisualStyleBackColor = True
        '
        'RBCredit
        '
        Me.RBCredit.AutoSize = True
        Me.RBCredit.Location = New System.Drawing.Point(7, 34)
        Me.RBCredit.Name = "RBCredit"
        Me.RBCredit.Size = New System.Drawing.Size(66, 21)
        Me.RBCredit.TabIndex = 0
        Me.RBCredit.TabStop = True
        Me.RBCredit.Text = "Credit"
        Me.RBCredit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(704, 305)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Journey Summary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'FormConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormConfirm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Confirm_Button As Button
    Friend WithEvents RBDebit As RadioButton
    Friend WithEvents RBCredit As RadioButton
    Friend WithEvents Return_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
