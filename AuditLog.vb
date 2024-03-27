Imports System.IO

Public Class AuditLog
    Private Sub AuditLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAudits()
        DoubleBuffer.DoubleBuffered(DataGridViewAudits, True)
    End Sub

    Public Sub loadAudits()
        Try
            ' Modify your SQL query to fetch the date and time components separately
            Dim query As String = "SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                              "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                              "FROM tbl_audit a " &
                              "INNER JOIN tbl_users u ON a.user_ID = u.user_ID"

            reload(query, DataGridViewAudits)
        Catch ex As Exception
            ' Handle exceptions here
        End Try
    End Sub


    Private Sub txtSearchAudit_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAudit.TextChanged
        Try
            'NOTE: will add a a dropdown box para naay choices for filtering (Fname, Lname, or student number)
            reloadtxt("SELECT * FROM tbl_audit WHERE audit_ID LIKE '%" & txtSearchAudit.Text & "%' OR action LIKE '%" & txtSearchAudit.Text & "'")
            If dt.Rows.Count > 0 Then
                DataGridViewAudits.DataSource = dt

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred searching audit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Try
            loadAudits()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try
            reload("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                   "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                   "FROM tbl_audit a " &
                   "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                    WHERE DATE(dateTime)=DATE(NOW())", DataGridViewAudits)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try
            reload("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                   "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                   "FROM tbl_audit a " &
                   "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                    WHERE WEEK(dateTime)=WEEK(NOW())", DataGridViewAudits)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Try
            reload("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                   "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                   "FROM tbl_audit a " &
                   "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                   WHERE MONTH(dateTime)=MONTH(NOW())", DataGridViewAudits)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            ' Construct the SQL query with hard-coded date values for testing
            Dim query As String = "SELECT a.audit_ID, a.action, DATE_FORMAT(a.dateTime, '%d/%m/%Y') AS auditDate, " &
                                  "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                                  "FROM tbl_audit a " &
                                  "INNER JOIN tbl_users u ON a.user_ID = u.user_ID " &
                                  "WHERE DATE_FORMAT(a.dateTime, '%Y-%m-%d') BETWEEN '" & DTPFrom.Value.ToString("yyyy-MM-dd") & "' AND '" & DTPTo.Value.ToString("yyyy-MM-dd") & "'"

            ' Reload data into DataGridViewAudits using the updated query
            reload(query, DataGridViewAudits)
        Catch ex As Exception
            MessageBox.Show("An error occurred on filtering date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class