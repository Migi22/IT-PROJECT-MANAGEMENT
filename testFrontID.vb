Imports System.Drawing.Printing

Public Class testFrontID
    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog
    Private Sub FormIDCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will make the labels transparent
        lblFMname.Parent = picIDFormat
        lblTitleStudentNum.Parent = picIDFormat
        lblInputLastName.Parent = picIDFormat
        lblTitleCourseYear.Parent = picIDFormat
        lblInputCourseYear.Parent = picIDFormat
        lblTitleStudentNum.Parent = picIDFormat
        lblInputStudentNum.Parent = picIDFormat



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

    Private Sub txtStudentNum_TextChanged(sender As Object, e As EventArgs)
        LoadProfile()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If bitmap IsNot Nothing Then
            e.Graphics.DrawImage(bitmap, 50, 50)
        Else
            ' Handle the case where bitmap is null (optional)
            e.Graphics.DrawString("Image not available", New Font("Arial", 12), Brushes.Black, New PointF(50, 50))
        End If
    End Sub

    Public Sub Print()
        Dim panel As Panel = Panel1 ' Directly reference the Panel1 control

        ' Check if Panel1 is not null
        If panel IsNot Nothing Then
            Dim formsize As Size = panel.ClientSize

            Using bitmap As New Bitmap(formsize.Width, formsize.Height)
                Using grp As Graphics = Graphics.FromImage(bitmap)
                    grp.CopyFromScreen(panel.PointToScreen(Point.Empty), Point.Empty, formsize)

                    ' Debugging: Draw a border around the captured area
                    Using pen As New Pen(Color.Red, 2)
                        grp.DrawRectangle(pen, New Rectangle(0, 0, formsize.Width - 1, formsize.Height - 1))
                    End Using

                    Using ppd As New PrintPreviewDialog()
                        ppd.Document = PrintDocument1

                        AddHandler PrintDocument1.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                                                 e.Graphics.DrawImage(bitmap, 50, 50)
                                                             End Sub

                        ppd.PrintPreviewControl.Zoom = 1.0
                        ppd.ShowDialog()
                    End Using
                End Using
            End Using
        Else
            MessageBox.Show("Panel1 is not found or is null.")
        End If
    End Sub





    Private Sub picStudentPic_Click(sender As Object, e As EventArgs) Handles picStudentPic.Click
        Print()

    End Sub

    Private Sub lblsToUpper_TextChanged(sender As Object, e As EventArgs) Handles lblFMname.TextChanged, lblInputLastName.TextChanged
        lblFMname.Text = lblFMname.Text.ToUpper()
        lblInputLastName.Text = lblInputLastName.Text.ToUpper()
    End Sub
End Class