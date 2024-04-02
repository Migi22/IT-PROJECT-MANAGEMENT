Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports MessagingToolkit.Barcode

Public Class Print_ID_Options
    Public QueueID As String

    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog

    Public Event FormClosedEvent As EventHandler

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
        picBarcode.Parent = picFrontIDFormat

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
        Dim generator As New BarcodeEncoder()
        Try
            ' Encode the barcode
            Dim barcodeBitmap As Bitmap = generator.Encode(BarcodeFormat.Code128, lblInputStudentNum.Text)

            ' Make the background color transparent (assuming white is the background color)
            barcodeBitmap.MakeTransparent(Color.White)

            ' Assign the transparent barcode image to the PictureBox
            picBarcode.Image = barcodeBitmap
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error generating barcode: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Try
            updates("UPDATE tbl_queue SET status = 'Done' WHERE queue_ID = '" & QueueID & "'")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Print_ID_Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RaiseEvent FormClosedEvent(Me, EventArgs.Empty)
    End Sub


End Class