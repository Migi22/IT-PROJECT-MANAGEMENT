Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Member_Management
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime
    Private roleId As Integer = 0

    Private Sub Member_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUser()

    End Sub

    Public Sub loadUser()
        Try
            ' Modify your SQL query to fetch the role names instead of role IDs
            Dim query As String = "SELECT u.user_ID, u.username, u.password, r.role_name " &
                              "FROM tbl_users u " &
                              "INNER JOIN tbl_roles r ON u.role_ID = r.role_ID"

            reload(query, DataGridView1)
        Catch ex As Exception
            ' Handle exceptions here
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Converts the value
            If cbRoleType.Text = "Admin" Then
                roleId = 1
            ElseIf cbRoleType.Text = "Member" Then
                roleId = 2
            End If
            'End of converting

            'Insert data to the db
            create("INSERT INTO tbl_users(username, password, role_ID) 
                    VALUES('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & roleId & "')")

            'AUDIT
            Try
                action = "ADDED NEW USER: " & txtUsername.Text
                dateTime = DateTime.Now
                LogAudit(username, action, dateTime)
            Catch ex As Exception
                MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'END AUDIT

            Call Member_Management_Load(sender, e)
            clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'Converts the value
            If cbRoleType.Text = "Admin" Then
                roleId = 1
            ElseIf cbRoleType.Text = "Member" Then
                roleId = 2
            End If
            'End of converting
            updates("UPDATE tbl_users SET username='" & txtUsername.Text & "', password='" & txtPassword.Text & "', role_ID='" & roleId & "'
                    WHERE user_ID='" & txtID.Text & "'")

            'AUDIT
            Try
                action = "UPDATED USER: " & txtUsername.Text
                dateTime = DateTime.Now
                LogAudit(username, action, dateTime)
            Catch ex As Exception
                MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'END AUDIT

            Call Member_Management_Load(sender, e)
            clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM tbl_users WHERE user_ID='" & txtID.Text & "'")
            'AUDIT
            Try
                action = "DELETED USER: " & txtUsername.Text
                dateTime = DateTime.Now
                LogAudit(username, action, dateTime)
            Catch ex As Exception
                MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'END AUDIT

            Call Member_Management_Load(sender, e)
            clear()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtID.Clear()
        cbRoleType.SelectedIndex = -1
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtID.Text = DataGridView1.CurrentRow.Cells("user_ID").Value
        txtUsername.Text = DataGridView1.CurrentRow.Cells("username").Value
        txtPassword.Text = DataGridView1.CurrentRow.Cells("password").Value
        cbRoleType.Text = DataGridView1.CurrentRow.Cells("role_name").Value

    End Sub
End Class