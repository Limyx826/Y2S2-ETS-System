<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class FormLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.CustomerPanel = New System.Windows.Forms.Panel()
        Me.StaffPanel = New System.Windows.Forms.Panel()
        Me.StaffIDLabel = New System.Windows.Forms.Label()
        Me.StaffPasswordLabel = New System.Windows.Forms.Label()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffPasswordTextBox = New System.Windows.Forms.TextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerPanel.SuspendLayout()
        Me.StaffPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(2, 5)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(5, 62)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(5, 31)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 22)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(5, 88)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(197, 163)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 163)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(84, 114)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Not existing member?"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(156, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(307, 3)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(86, 17)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Staff Access"
        '
        'CustomerPanel
        '
        Me.CustomerPanel.BackColor = System.Drawing.Color.Transparent
        Me.CustomerPanel.Controls.Add(Me.UsernameLabel)
        Me.CustomerPanel.Controls.Add(Me.PasswordLabel)
        Me.CustomerPanel.Controls.Add(Me.LinkLabel1)
        Me.CustomerPanel.Controls.Add(Me.UsernameTextBox)
        Me.CustomerPanel.Controls.Add(Me.PasswordTextBox)
        Me.CustomerPanel.Location = New System.Drawing.Point(159, 25)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(237, 135)
        Me.CustomerPanel.TabIndex = 8
        '
        'StaffPanel
        '
        Me.StaffPanel.Controls.Add(Me.StaffIDLabel)
        Me.StaffPanel.Controls.Add(Me.StaffPasswordLabel)
        Me.StaffPanel.Controls.Add(Me.StaffIDTextBox)
        Me.StaffPanel.Controls.Add(Me.StaffPasswordTextBox)
        Me.StaffPanel.Enabled = False
        Me.StaffPanel.Location = New System.Drawing.Point(159, 25)
        Me.StaffPanel.Name = "StaffPanel"
        Me.StaffPanel.Size = New System.Drawing.Size(237, 135)
        Me.StaffPanel.TabIndex = 9
        Me.StaffPanel.Visible = False
        '
        'StaffIDLabel
        '
        Me.StaffIDLabel.Location = New System.Drawing.Point(2, 5)
        Me.StaffIDLabel.Name = "StaffIDLabel"
        Me.StaffIDLabel.Size = New System.Drawing.Size(220, 23)
        Me.StaffIDLabel.TabIndex = 0
        Me.StaffIDLabel.Text = "&Staff ID"
        Me.StaffIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StaffPasswordLabel
        '
        Me.StaffPasswordLabel.Location = New System.Drawing.Point(5, 62)
        Me.StaffPasswordLabel.Name = "StaffPasswordLabel"
        Me.StaffPasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.StaffPasswordLabel.TabIndex = 2
        Me.StaffPasswordLabel.Text = "&Password"
        Me.StaffPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.Location = New System.Drawing.Point(5, 31)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(220, 22)
        Me.StaffIDTextBox.TabIndex = 1
        '
        'StaffPasswordTextBox
        '
        Me.StaffPasswordTextBox.Location = New System.Drawing.Point(5, 88)
        Me.StaffPasswordTextBox.Name = "StaffPasswordTextBox"
        Me.StaffPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.StaffPasswordTextBox.Size = New System.Drawing.Size(220, 22)
        Me.StaffPasswordTextBox.TabIndex = 3
        '
        'FormLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ETS_System.My.Resources.Resources._25461_hd_images_for_website_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.CustomerPanel)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.StaffPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerPanel.ResumeLayout(False)
        Me.CustomerPanel.PerformLayout()
        Me.StaffPanel.ResumeLayout(False)
        Me.StaffPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents CustomerPanel As Panel
    Friend WithEvents StaffPanel As Panel
    Friend WithEvents StaffIDLabel As Label
    Friend WithEvents StaffPasswordLabel As Label
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents StaffPasswordTextBox As TextBox
End Class
