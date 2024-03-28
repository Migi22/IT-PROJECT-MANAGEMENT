Public Class Print_ID_Options
    Public FMname As String
    Public Lname As String
    Public StudentNum As String
    Public CourseYear As String
    Private Sub panelFrontID_Paint(sender As Object, e As PaintEventArgs) Handles panelFrontID.Paint
        With frontID
            .TopLevel = False
            panelFrontID.Controls.Add(frontID)
            '.Dock = DockStyle.Fill

            'Data that has been passed
            .lblFMname.Text = FMname
            .lblInputLastName.Text = Lname
            .lblInputCourseYear.Text = CourseYear
            .lblInputStudentNum.Text = StudentNum

            .Show()
        End With

    End Sub
End Class