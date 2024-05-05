Imports System.Diagnostics.Eventing.Reader

Public Class Form_Login
    Dim attempts As Integer = 0

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        reloadtxt("SELECT * FROM tbl_users WHERE USERNAME='" & txtUsername.Text & "' AND 
                    PASSWORD='" & txtPassword.Text & "'")
        If dt.Rows.Count > 0 Then
            Dim isAdmin As Boolean = Convert.ToInt32(dt.Rows(0)("role_ID")) = 1 'True


            With Dashboard
                CurrentUser.Username = txtUsername.Text
                If isAdmin Then
                    ' If user is an admin
                    .btnUserManagement.Visible = True
                    .btnAuditLog.Visible = True


                Else
                    ' If user is not an admin
                    .btnUserManagement.Visible = False
                    .btnAuditLog.Visible = False

                End If
                .Show()
            End With
            Me.Hide()

            'Will Clear the text box
            txtPassword.Clear()
            txtUsername.Clear()
        Else
            attempts += 1
            MessageBox.Show("Username or Password not found! Attempt: " + attempts.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        'Here will check the attempts
        If attempts = 3 Then
            MessageBox.Show("Last chance to enter a correct username and password!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf attempts = 4 Then
            MessageBox.Show("You have exceeded the limit of 3 attempts, the system will close", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub

    Private Sub cbShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowHide.CheckedChanged
        If cbShowHide.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class