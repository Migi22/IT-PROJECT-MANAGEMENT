Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class editImage
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime
    Public StudentLastName As String
    Public StudentFirstName As String
    Public QueueID As String
    Public Property ReloadFunction As Action

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        Try
            If String.IsNullOrEmpty(txtPhoto.Text) OrElse String.IsNullOrEmpty(StudentLastName) Then
                MessageBox.Show("You need to select a picture of the student first", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Directory.Exists(Application.StartupPath & "\Profile\" & StudentLastName & ".png") Then
                Directory.Delete(StudentLastName)
            Else
                picBrowserPic.Image.Save(Application.StartupPath & "\Profile\" & StudentLastName & ".png")
                updates("UPDATE tbl_queue SET image_file_name='" & StudentLastName & ".png' 
                WHERE queue_ID='" & QueueID & "'")

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

    Private Sub btnDeleteProfile_Click_1(sender As Object, e As EventArgs) Handles btnDeleteProfile.Click
        Try
            If String.IsNullOrEmpty(StudentLastName) Then
                MessageBox.Show("You need to select first a student first", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf String.IsNullOrEmpty(dt.Rows(0).Item("image_file_name").ToString) Then
                MessageBox.Show("There is no image to delete for this student", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                updates("UPDATE tbl_queue SET image_file_name='' 
                WHERE student_number='" & StudentLastName & "'")

                'AUDIT
                Try
                    action = "DELETED STUDENT PICTURE: " & StudentLastName & ", " & StudentFirstName
                    dateTime = DateTime.Now
                    LogAudit(username, Action, DateTime)
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
End Class