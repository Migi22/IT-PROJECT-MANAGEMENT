Public Class Print_ID_Options
    'front ID
    Public FMname As String
    Public Lname As String
    Public StudentNum As String
    Public CourseYear As String

    'back ID
    Public Birthday As String
    Public Guardian_Name As String
    Public Guardian_Number As String
    Public Student_Address As String

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

    Private Sub panelBackID_Paint(sender As Object, e As PaintEventArgs) Handles panelBackID.Paint
        With backID
            .TopLevel = False
            panelBackID.Controls.Add(backID)

            'Data that has been passed
            .lblInputBirthday.Text = "BIRTHDAY: " & Birthday
            .lblGuardianName.Text = Guardian_Name
            .lblInputGuardianNum.Text = Guardian_Number
            .lblStudentAddress.Text = Student_Address

            .Show()
        End With
    End Sub
End Class