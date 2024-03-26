Imports System.Drawing.Printing

Public Class testPrintID
    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog
    Private Sub FormIDCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Parent = picIDFormat
        lblStudentNum.Parent = picIDFormat


        Dim generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            picBarcode.Image = New Bitmap(generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, txtStudentNum.Text))
        Catch ex As Exception
            picBarcode.Image = Nothing
        End Try

        LoadProfile()

    End Sub

    Public Sub LoadProfile()
        Try
            reloadtxt("SELECT * FROM tbl_queue WHERE student_number='" & txtStudentNum.Text & "'")

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

    Private Sub txtStudentNum_TextChanged(sender As Object, e As EventArgs) Handles txtStudentNum.TextChanged
        LoadProfile()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 50, 50)
    End Sub

    Public Sub Print()
        Dim panel As Panel = New Panel()
        Me.Controls.Add(panel)
        Dim grp As Graphics = panel.CreateGraphics
        Dim formsize As Size = Me.ClientSize
        bitmap = New Bitmap(formsize.Width, formsize.Height, grp)
        grp = Graphics.FromImage(bitmap)
        Dim panelLocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formsize)
        ppd.Document = PrintDocument1
        ppd.PrintPreviewControl.Zoom = 1.0
        ppd.ShowDialog()
        Return
    End Sub

    Private Sub picStudentPic_Click(sender As Object, e As EventArgs) Handles picStudentPic.Click
        Print()

    End Sub


End Class