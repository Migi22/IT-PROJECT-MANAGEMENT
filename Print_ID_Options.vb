Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports Google.Protobuf.WellKnownTypes
Imports MessagingToolkit.Barcode

Public Class Print_ID_Options
    Public QueueID As String

    Private currentPage As Integer
    Private TotalPages As Integer

    Private bitmap As Bitmap
    ' Class-level variables to hold the front and back bitmaps
    Private bitmapFront As Bitmap
    Private bitmapBack As Bitmap
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
        picStudentPic.Parent = picFrontIDFormat

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
        lblValidFor.Parent = picBackIDFormat
        lblLabelEmergency.Parent = picBackIDFormat


        'Uppercase
        lblFMname.Text = lblFMname.Text.ToUpper()
        lblInputLastName.Text = lblInputLastName.Text.ToUpper()

        'Barcode
        Dim generator As New BarcodeEncoder()
        Try
            ' Encode the barcode
            Dim barcodeBitmap As Bitmap = generator.Encode(BarcodeFormat.Code39, lblInputStudentNum.Text)

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
                If String.IsNullOrEmpty(dt.Rows(0).Item("student_picture").ToString) Then
                    picStudentPic.ImageLocation = System.IO.Path.Combine(Application.StartupPath, "Resources", "default.png")
                Else
                    Dim imageData As Byte() = DirectCast(dt.Rows(0).Item("student_picture"), Byte())

                    ' Convert byte array to image
                    Using ms As New System.IO.MemoryStream(imageData)
                        Dim image As Image = Image.FromStream(ms)
                        picStudentPic.Image = image ' Display the image in PictureBox
                    End Using
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim g As Graphics = e.Graphics
            g.PageUnit = GraphicsUnit.Inch

            ' Draw the image at the correct size in inches
            If currentPage = 1 Then
                If bitmapFront IsNot Nothing Then
                    g.DrawImage(bitmapFront, 0, 0, 2.14F, 3.376F)
                Else
                    MessageBox.Show("Error: Front Bitmap object is null.")
                End If
            ElseIf currentPage = 2 Then
                If bitmapBack IsNot Nothing Then
                    g.DrawImage(bitmapBack, 0, 0, 2.14F, 3.376F)
                Else
                    MessageBox.Show("Error: Back Bitmap object is null.")
                End If
            End If

            ' Increment the current page number
            currentPage += 1

            ' Check if there are more pages to print
            If currentPage <= TotalPages Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                currentPage = 1 ' Reset current page for the next print job
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing: " & ex.Message)
        End Try
    End Sub


    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Try

            Dim currentDate As Date = Date.Now.Date

            Dim formattedDate As String = currentDate.ToString("yyyy-MM-dd")

            ' Update the database with the status and the current date
            updates("UPDATE tbl_queue SET status = 'Done', done_printing_date = '" & formattedDate & "' WHERE queue_ID = '" & QueueID & "'")

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Print_ID_Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RaiseEvent FormClosedEvent(Me, EventArgs.Empty)
    End Sub

    Private Sub btnPrintBoth_Click(sender As Object, e As EventArgs) Handles btnPrintBoth.Click
        ' Calculate the total pages to print
        TotalPages = 2 ' Assuming you are printing both front and back pages

        currentPage = 1

        ' Open the PrintDialog to allow the user to select a printer
        Dim pd As New PrintDialog()
        If pd.ShowDialog() = DialogResult.OK Then
            ' User selected a printer, proceed with printing
            PrintID(panelFrontID, panelBackID, pd.PrinterSettings)
            'PrintDocument1.Print()
        End If
    End Sub


    Public Sub PrintID(frontPanel As Panel, backPanel As Panel, printerSettings As PrinterSettings)
        Try
            ' Desired physical dimensions in inches
            Dim desiredWidthInches As Double = 2.14
            Dim desiredHeightInches As Double = 3.376

            ' Create bitmaps with the dimensions of the panels
            Dim frontBitmap As New Bitmap(frontPanel.ClientSize.Width, frontPanel.ClientSize.Height)
            Dim backBitmap As New Bitmap(backPanel.ClientSize.Width, backPanel.ClientSize.Height)

            ' Create graphics objects from the bitmaps
            Using frontGrp As Graphics = Graphics.FromImage(frontBitmap)
                Using backGrp As Graphics = Graphics.FromImage(backBitmap)
                    ' Clear the graphics with a white background
                    frontGrp.Clear(Color.White)
                    backGrp.Clear(Color.White)

                    ' Draw the panel content onto the bitmaps
                    frontPanel.DrawToBitmap(frontBitmap, frontPanel.ClientRectangle)
                    backPanel.DrawToBitmap(backBitmap, backPanel.ClientRectangle)
                End Using
            End Using

            ' Assign the bitmaps to class-level variables
            Me.bitmapFront = frontBitmap
            Me.bitmapBack = backBitmap

            ' Debug output
            Debug.WriteLine("Front Panel Width: " & frontPanel.ClientSize.Width & " pixels")
            Debug.WriteLine("Front Panel Height: " & frontPanel.ClientSize.Height & " pixels")
            Debug.WriteLine("Back Panel Width: " & backPanel.ClientSize.Width & " pixels")
            Debug.WriteLine("Back Panel Height: " & backPanel.ClientSize.Height & " pixels")
            Debug.WriteLine("Desired Width: " & desiredWidthInches & " inches")
            Debug.WriteLine("Desired Height: " & desiredHeightInches & " inches")

            ' Set up the print preview
            ppd.Document = PrintDocument1
            PrintDocument1.PrinterSettings = printerSettings
            ppd.PrintPreviewControl.Zoom = 1.0
            ppd.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class