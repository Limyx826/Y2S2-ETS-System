Public Class FormLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If StaffIDTextBox.Text = "Admin" And StaffPasswordTextBox.Text = "jclo" Then
            Me.Close()
            Frontpage.Show()
            Frontpage.LinkLabel1.Visible = True
        Else
            MessageBox.Show("Invalid", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Frontpage.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormMemReg.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If StaffPanel.Visible = False Then
            With StaffPanel
                .Visible = True
                .Enabled = True
            End With
            With CustomerPanel
                .Visible = False
                .Enabled = False
            End With
        Else
            With StaffPanel
                .Visible = False
                .Enabled = False
            End With
            With CustomerPanel
                .Visible = True
                .Enabled = True
            End With
        End If
    End Sub
End Class
