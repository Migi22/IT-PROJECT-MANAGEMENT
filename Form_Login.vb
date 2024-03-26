Public Class Form_Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        reloadtxt("SELECT * FROM tbl_users WHERE USERNAME='" & txtUsername.Text & "' AND 
                    PASSWORD='" & txtPassword.Text & "'")
        If dt.Rows.Count > 0 Then

            With Dashboard
                .Show()

            End With
            Me.Hide()


        Else
            MessageBox.Show("Username or Password not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class