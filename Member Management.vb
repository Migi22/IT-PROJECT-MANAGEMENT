Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Member_Management
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime

    Private Sub Member_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUser()

    End Sub

    Public Sub loadUser()
        Try
            reload("SELECT * FROM tbl_users", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            create("INSERT INTO tbl_users(USERNAME, PASSWORD, ROLE) 
                    VALUES('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cbRoleType.Text & "')")
            'AUDIT
            Try
                action = "ADDED NEW USER: " & txtUsername.Text
                dateTime = DateTime.Now
                LogAudit(username, Action, DateTime)
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
            updates("UPDATE tbl_user SET USERNAME='" & txtUsername.Text & "', PASSWORD='" & txtPassword.Text & "', ROLE='" & cbRoleType.Text & "'
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
            delete("DELETE FROM tbl_user WHERE user_ID='" & txtID.Text & "'")
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
        cbRoleType.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtID.Clear()
        cbRoleType.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtUsername.Text = DataGridView1.CurrentRow.Cells("USERNAME").Value
        txtPassword.Text = DataGridView1.CurrentRow.Cells("PASSWORD").Value
        txtID.Text = DataGridView1.CurrentRow.Cells("user_ID").Value
        cbRoleType.Text = DataGridView1.CurrentRow.Cells("ROLE").Value

    End Sub
End Class