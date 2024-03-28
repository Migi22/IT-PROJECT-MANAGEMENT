Imports System.Drawing.Printing

Public Class Print_ID_Options
    'back ID
    Public Birthday As String
    Public Guardian_Name As String
    Public Guardian_Number As String
    Public Student_Address As String

    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog

    Private Sub Print_ID_Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Transparent
        'Front
        lblFMname.Parent = picFrontIDFormat
        lblTitleStudentNum.Parent = picFrontIDFormat
        lblInputLastName.Parent = picFrontIDFormat
        lblTitleCourseYear.Parent = picFrontIDFormat
        lblInputCourseYear.Parent = picFrontIDFormat
        lblTitleStudentNum.Parent = picFrontIDFormat
        lblInputStudentNum.Parent = picFrontIDFormat

        'Back
        lblInputBirthday.Parent = picBackIDFormat
        picStudentSignature.Parent = picBackIDFormat
        lblStudentAddress.Parent = picBackIDFormat
        lblGuardianName.Parent = picBackIDFormat
        lblInputGuardianNum.Parent = picBackIDFormat
        lblStudentAddress.Parent = picBackIDFormat
        picSchoolLogo.Parent = picBackIDFormat
        lblFirstSem.Parent = picBackIDFormat
        lblSchoolRegistar.Parent = picBackIDFormat
        lblSchoolRegistarName.Parent = picBackIDFormat
        lblTitleStudentSig.Parent = picBackIDFormat


        'Uppercase
        lblFMname.Text = lblFMname.Text.ToUpper()
        lblInputLastName.Text = lblInputLastName.Text.ToUpper()

        'Barcode
        Dim generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            picBarcode.Image = New Bitmap(generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, lblInputStudentNum.Text))
        Catch ex As Exception
            picBarcode.Image = Nothing
        End Try

        LoadProfile()
    End Sub

    Public Sub LoadProfile()
        Try
            reloadtxt("SELECT * FROM tbl_queue WHERE student_number='" & lblInputStudentNum.Text & "'")

            If dt.Rows.Count > 0 Then
                If String.IsNullOrEmpty(dt.Rows(0).Item("image_file_name").ToString) Then
                    picStudentPic.ImageLocation = Application.StartupPath & "\Profile\default.png"
                Else
                    picStudentPic.ImageLocation = Application.StartupPath & "\Profile\" & dt.Rows(0).Item("image_file_name").ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If bitmap IsNot Nothing Then
            e.Graphics.DrawImage(bitmap, 50, 50)
        Else
            MessageBox.Show("Error: Bitmap object is null.")
        End If
    End Sub

    Private Sub btnPrintBack_Click(sender As Object, e As EventArgs) Handles btnPrintBack.Click
        PrintID(panelBackID)
    End Sub

    Private Sub btnPrintFront_Click(sender As Object, e As EventArgs) Handles btnPrintFront.Click
        PrintID(panelFrontID)
    End Sub

    Public Sub PrintID(panel As Panel)
        Try
            Using bitmap As New Bitmap(panel.ClientSize.Width, panel.ClientSize.Height)
                Using grp As Graphics = Graphics.FromImage(bitmap)
                    Dim panelLocation As Point = PointToScreen(panel.Location)
                    grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, panel.ClientSize)
                End Using

                ' Assign the bitmap to the class-level variable
                Me.bitmap = bitmap

                ' Draw the bitmap on the print page
                ppd.Document = PrintDocument1
                ppd.PrintPreviewControl.Zoom = 1.0
                ppd.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class