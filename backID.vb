Public Class backID
    Private Sub backID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInputBirthday.Parent = picBackIDFormat
        lblGuardianName.Parent = picBackIDFormat
        lblInputGuardianNum.Parent = picBackIDFormat
        lblStudentAddress.Parent = picBackIDFormat
        lblFirstSem.Parent = picBackIDFormat
        lblSchoolRegistar.Parent = picBackIDFormat
        lblSchoolRegistarName.Parent = picBackIDFormat
        lblTitleStudentSig.Parent = picBackIDFormat
        picStudentSignature.Parent = picBackIDFormat
        picSchoolLogo.Parent = picBackIDFormat
    End Sub
End Class