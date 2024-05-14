Imports System.IO
Imports MySql.Data.MySqlClient

Public Class editImage
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime
    Public StudentLastName As String
    Public StudentFirstName As String
    Public QueueID As String
    Public Property ReloadFunction As Action

    Private Sub btnUpdateImage_Click(sender As Object, e As EventArgs) Handles btnUpdateImage.Click
        Try
            If String.IsNullOrEmpty(txtPhoto.Text) OrElse String.IsNullOrEmpty(StudentLastName) Then
                MessageBox.Show("You need to select a picture of the student first", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim fileName As String = txtPhoto.Text
                Dim fileData As Byte() = File.ReadAllBytes(fileName)

                ' Update the database with the new image data
                updates("UPDATE tbl_queue SET student_picture = @fileData WHERE queue_ID = @QueueID",
                           New MySqlParameter("@fileData", fileData),
                           New MySqlParameter("@QueueID", QueueID))

                'AUDIT
                Try
                    action = "SAVED STUDENT PICTURE: " & StudentLastName & ", " & StudentFirstName
                    dateTime = DateTime.Now
                    LogAudit(username, action, dateTime)
                Catch ex As Exception
                    MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                'END AUDIT

                ReloadFunction.Invoke() 'Reload the datagrid
                Close() 'Close After
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "jpg"
                .DereferenceLinks = True
                .FileName = ""
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All Files|*.*"
                .Multiselect = False

                .RestoreDirectory = True
                .Title = "SELECT FILE TO OPEN"
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Dim fileName As String = .FileName
                    Try
                        txtPhoto.Text = .FileName
                        picBrowserPic.ImageLocation = .FileName
                        picBrowserPic.SizeMode = PictureBoxSizeMode.StretchImage
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteProfile_Click(sender As Object, e As EventArgs) Handles btnDeleteProfile.Click
        Try
            If String.IsNullOrEmpty(StudentLastName) Then
                MessageBox.Show("You need to select a student first", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' Update the database to set the image data to NULL
                updates("UPDATE tbl_queue SET student_picture = NULL WHERE queue_ID = @QueueID",
                        New MySqlParameter("@QueueID", QueueID))

                ' AUDIT
                Try
                    action = "DELETED STUDENT PICTURE: " & StudentLastName & ", " & StudentFirstName
                    dateTime = DateTime.Now
                    LogAudit(username, action, dateTime)
                Catch ex As Exception
                    MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                ' END AUDIT

                ReloadFunction.Invoke() ' Reload the datagrid
                Close() ' Close After
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class