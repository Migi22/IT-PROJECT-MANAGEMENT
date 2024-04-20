Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial form when the Dashboard form loads
        SwitchForm(New Form1())

        ' Set the text of lblCurrentUser to the current username
        lblCurrentUser.Text = "Welcome, " & CurrentUser.Username
    End Sub



    Private Sub SwitchForm(ByVal newPanel As Form)
        ' Dispose of previous form(s)
        For Each control As Control In panelRight.Controls
            If TypeOf control Is Form Then
                Dim formToDispose As Form = DirectCast(control, Form)
                formToDispose.Close()
                formToDispose.Dispose()
            End If
        Next

        ' Clear the panel and add the new form
        panelRight.Controls.Clear()
        newPanel.TopLevel = False
        newPanel.Dock = DockStyle.Fill ' Ensure the new form fills the panel
        panelRight.Controls.Add(newPanel)
        newPanel.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        SwitchForm(New Form1())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        SwitchForm(New Reports())
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        SwitchForm(New Member_Management())
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Login.Show()
        Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        CurrentUser.Username = Nothing

        Form_Login.Show()
        Me.Close()
    End Sub

    Private Sub btnAuditLog_Click(sender As Object, e As EventArgs) Handles btnAuditLog.Click
        SwitchForm(New AuditLog())
    End Sub


End Class
