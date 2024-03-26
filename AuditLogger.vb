Imports MySql.Data.MySqlClient
Module AuditLogger
    Public Sub LogAudit(username As String, action As String, dateTime As DateTime)
        Try
            Dim query As String = "INSERT INTO tbl_audit(user_ID, action, dateTime) 
                                    SELECT user_ID, @action, @dateTime 
                                    FROM tbl_users 
                                    WHERE username = @username"

            ' Create MySqlCommand object and add parameters
            Using cmd As New MySqlCommand(query, strcon)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@action", action)
                cmd.Parameters.AddWithValue("@dateTime", dateTime)

                ' Open connection, execute query, and close connection
                strcon.Open()
                cmd.ExecuteNonQuery()
                strcon.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while logging audit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub
End Module
