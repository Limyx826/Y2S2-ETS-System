﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RBDebit = New System.Windows.Forms.RadioButton()
        Me.RBCredit = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RBDebit)
        Me.GroupBox1.Controls.Add(Me.RBCredit)
        Me.GroupBox1.Location = New System.Drawing.Point(187, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RBDebit
        '
        Me.RBDebit.AutoSize = True
        Me.RBDebit.Location = New System.Drawing.Point(293, 57)
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
        Me.RBCredit.Location = New System.Drawing.Point(24, 57)
        Me.RBCredit.Name = "RBCredit"
        Me.RBCredit.Size = New System.Drawing.Size(66, 21)
        Me.RBCredit.TabIndex = 0
        Me.RBCredit.TabStop = True
        Me.RBCredit.Text = "Credit"
        Me.RBCredit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 504)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormConfirm"
        Me.Text = "FormConfirm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RBDebit As RadioButton
    Friend WithEvents RBCredit As RadioButton
    Friend WithEvents Button2 As Button
End Class
