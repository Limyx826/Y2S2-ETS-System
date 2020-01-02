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
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(58, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(662, 87)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Back_button
        '
        Me.Back_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_button.Location = New System.Drawing.Point(58, 382)
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
        Me.RB4.Location = New System.Drawing.Point(58, 312)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(131, 24)
        Me.RB4.TabIndex = 24
        Me.RB4.TabStop = True
        Me.RB4.Text = "RadioButton4"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB3.Location = New System.Drawing.Point(58, 265)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(131, 24)
        Me.RB3.TabIndex = 23
        Me.RB3.TabStop = True
        Me.RB3.Text = "RadioButton3"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB2.Location = New System.Drawing.Point(58, 220)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(131, 24)
        Me.RB2.TabIndex = 22
        Me.RB2.TabStop = True
        Me.RB2.Text = "RadioButton2"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB1.Location = New System.Drawing.Point(58, 172)
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
        Me.NextButton.Location = New System.Drawing.Point(681, 382)
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
        Me.PictureBox1.Image = Global.ETS_System.My.Resources.Resources.ETS
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'FormSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.RB4)
        Me.Controls.Add(Me.RB3)
        Me.Controls.Add(Me.RB2)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.Back_button)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FormSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSelect"
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
