Imports System.IO
Imports MySql.Data.MySqlClient

Public Class editSignature
    'Next lines of codes are for the Audit Log
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime

    ' Next lines of codes are for this form function
    Public StudentLastName As String
    Public StudentFirstName As String
    Public QueueID As String
    Public Property ReloadFunction As Action

    Private Sub editSignature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reloadtxtFilterSignature("SELECT student_signature FROM tbl_queue WHERE queue_ID = '" & QueueID & "'")
            If dt.Rows.Count > 0 AndAlso Not String.IsNullOrEmpty(dt.Rows(0).Item("student_signature").ToString) Then
                Dim imageData As Byte() = DirectCast(dt.Rows(0).Item("student_signature"), Byte())

                ' Convert byte array to image
                Using ms As New System.IO.MemoryStream(imageData)
                    Dim image As Image = Image.FromStream(ms)
                    picSignature.Image = image ' Display the image in PictureBox
                End Using

            Else
                ' If "student_signature" is null or empty, display a default image
                picSignature.Image = Image.FromFile(Application.StartupPath & "\Profile\default.png") ' DefaultImage is a placeholder for your default image
            End If
        Catch ex As Exception
            MessageBox.Show("Error on loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "png"
                .DereferenceLinks = True
                .FileName = ""
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All Files|*.*"
                .Multiselect = False

                .RestoreDirectory = True
                .Title = "SELECT FILE TO OPEN"
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        txtSignature.Text = .FileName
                        picSignature.ImageLocation = .FileName
                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateSignature_Click(sender As Object, e As EventArgs) Handles btnUpdateSignature.Click
        Try
            If Not String.IsNullOrEmpty(txtSignature.Text) Then
                Dim imagePath As String = txtSignature.Text

                ' Check if the file exists at the specified path
                If File.Exists(imagePath) Then
                    ' Read the image file into a byte array
                    Dim imageData As Byte() = File.ReadAllBytes(imagePath)

                    ' Update the database with the new image data
                    updates("UPDATE tbl_queue SET student_signature = @ImageData WHERE queue_ID = @QueueID",
                           New MySqlParameter("@ImageData", imageData),
                           New MySqlParameter("@QueueID", QueueID))

                    ' update the PictureBox on the form
                    picSignature.Image = Image.FromFile(imagePath)

                    ' Reload the parent form
                    ReloadFunction?.Invoke()

                    ' Log the action in the audit log
                    action = "Updated signature for: " & StudentLastName & ", " & StudentFirstName
                    dateTime = DateTime.Now
                    LogAudit(username, action, dateTime)

                    MessageBox.Show("Signature updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("The selected image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please select an image file to update the signature.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error on updating signature: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveSignature_Click(sender As Object, e As EventArgs) Handles btnSaveSignature.Click
        Try
            ' Check if there is an image to save
            checkSignature("SELECT student_signature FROM tbl_queue WHERE queue_ID = '" & QueueID & "'")

            ' If there is no image to save, exit the function
            If dt.Rows.Count <= 0 OrElse IsDBNull(dt.Rows(0).Item("student_signature")) OrElse DirectCast(dt.Rows(0).Item("student_signature"), Byte()).Length <= 0 Then
                Exit Sub
            Else
                Dim imageData As Byte() = DirectCast(dt.Rows(0).Item("student_signature"), Byte())

                Using ms As New System.IO.MemoryStream(imageData)
                    Dim image As Image = Image.FromStream(ms)

                    ' Save the image to a file
                    Dim saveDialog As New SaveFileDialog()
                    saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|GIF Image|*.gif|Bitmap Image|*.bmp"
                    saveDialog.Title = "Save Image"
                    saveDialog.FileName = "saved_image" ' Default file name
                    saveDialog.RestoreDirectory = True

                    If saveDialog.ShowDialog() = DialogResult.OK Then
                        Dim filePath As String = saveDialog.FileName
                        image.Save(filePath) ' Save the image to the specified file path
                        MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error on saving image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





End Class