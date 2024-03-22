Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFname.Text = "" Then
            MessageBox.Show("First Name is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtLname.Text = "" Then
            MessageBox.Show("Student Number is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtMi.Text = "" Then
            MessageBox.Show("Middle Name is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCourse.Text = "" Then
            MessageBox.Show("Course is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtYearLevel.Text = "" Then
            MessageBox.Show("Year Level is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtGuardianName.Text = "" Then
            MessageBox.Show("Guardian's Name is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtStudentAddress.Text = "" Then
            MessageBox.Show("Student's Address is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtGuardianContNum.Text = "" Then
            MessageBox.Show("Guardian's Contact Number is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtStudentBday.Text = "" Then
            MessageBox.Show("Student's Birthday is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                create("INSERT INTO tbl_queue(fname, lname, m_i, course, year_level, guardian_name, guardian_contact_num,
                student_address, student_Birthday, student_number)
                VALUES('" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtMi.Text & "', '" & txtCourse.Text & "', '" & txtYearLevel.Text & "',
                '" & txtGuardianName.Text & "', '" & txtGuardianContNum.Text & "', '" & txtStudentAddress.Text & "', '" & txtStudentBday.Text & "',
                '" & txtStudentNum.Text & "')")

                reload_record()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_record() 'RELOAD THE DATAGRID VIEW UPON START'
    End Sub

    'FUNCTION THAT RELOAD THE DATAGRIDVIEW'S DATA'
    Public Sub reload_record()
        Try
            reload("SELECT * FROM tbl_queue", DataGridView1)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            'reloadtxt("SELECT * FROM tbl_queue WHERE student_number='" & txtStudentNum.Text & "'")
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            strcon.Open()
            sql = "SELECT * FROM tbl_queue WHERE student_number LIKE '%" & txtSearch.Text & "%'"
            cmd.Connection = strcon
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt

            If dt.Rows.Count > 0 Then
                txtFname.Text = dt.Rows(0).Item("fname").ToString
                txtLname.Text = dt.Rows(0).Item("lname").ToString
                txtMi.Text = dt.Rows(0).Item("m_i").ToString
                txtCourse.Text = dt.Rows(0).Item("course").ToString
                txtYearLevel.Text = dt.Rows(0).Item("year_level").ToString
                txtGuardianName.Text = dt.Rows(0).Item("guardian_name").ToString
                txtGuardianContNum.Text = dt.Rows(0).Item("guardian_contact_num").ToString
                txtStudentAddress.Text = dt.Rows(0).Item("student_address").ToString
                txtStudentBday.Text = dt.Rows(0).Item("student_Birthday").ToString
                txtStudentNum.Text = dt.Rows(0).Item("student_number").ToString
                LoadImage()

            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred search text box: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtFname.Text = "" Then
            MessageBox.Show("First Name is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtLname.Text = "" Then
            MessageBox.Show("Student Number is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtMi.Text = "" Then
            MessageBox.Show("Middle Name is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCourse.Text = "" Then
            MessageBox.Show("Course is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtYearLevel.Text = "" Then
            MessageBox.Show("Year Level is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtGuardianName.Text = "" Then
            MessageBox.Show("Guardian's Name is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtStudentAddress.Text = "" Then
            MessageBox.Show("Student's Address is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtGuardianContNum.Text = "" Then
            MessageBox.Show("Guardian's Contact Number is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtStudentBday.Text = "" Then
            MessageBox.Show("Student's Birthday is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                updates("UPDATE tbl_queue SET fname='" & txtFname.Text & "', lname='" & txtLname.Text & "', m_i='" & txtMi.Text & "', course='" & txtCourse.Text & "',
            year_level='" & txtYearLevel.Text & "', guardian_name='" & txtGuardianName.Text & "', guardian_contact_num='" & txtGuardianContNum.Text & "',
            student_address='" & txtStudentAddress.Text & "', student_Birthday='" & txtStudentBday.Text & "'
            WHERE student_number='" & txtStudentNum.Text & "'")

                reload_record()



            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM tbl_queue WHERE student_number='" & txtStudentNum.Text & "'")
            Call Form1_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            With DataGridView1
                txtStudentNum.Text = .CurrentRow.Cells("student_number").Value.ToString
                txtFname.Text = .CurrentRow.Cells("fname").Value.ToString
                txtMi.Text = .CurrentRow.Cells("m_i").Value.ToString
                txtLname.Text = .CurrentRow.Cells("lname").Value.ToString
                txtCourse.Text = .CurrentRow.Cells("course").Value.ToString
                txtYearLevel.Text = .CurrentRow.Cells("year_level").Value.ToString
                txtGuardianName.Text = .CurrentRow.Cells("guardian_name").Value.ToString
                txtGuardianContNum.Text = .CurrentRow.Cells("guardian_contact_num").Value.ToString
                txtStudentAddress.Text = .CurrentRow.Cells("student_address").Value.ToString
                txtStudentBday.Text = .CurrentRow.Cells("student_Birthday").Value.ToString
                LoadImage() 'View the image to the datagridview
            End With

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

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        Try
            If String.IsNullOrEmpty(txtPhoto.Text) OrElse String.IsNullOrEmpty(txtStudentNum.Text) Then
                MessageBox.Show("You need to select first the student before saving a profile picture", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Directory.Exists(Application.StartupPath & "\Profile\" & txtStudentNum.Text & ".png") Then
                Directory.Delete(txtStudentNum.Text)
            Else
                picBrowserPic.Image.Save(Application.StartupPath & "\Profile\" & txtStudentNum.Text & ".png")
                updates("UPDATE tbl_queue SET image_file_name='" & txtStudentNum.Text & ".png' 
                WHERE student_number='" & txtStudentNum.Text & "'")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadImage()
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
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
