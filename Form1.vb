Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Reflection

Public Class Form1
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Loop method to check individually the text box if it is a blank
        Dim requiredFields As New List(Of TextBox) From {txtFname, txtLname, txtMi, txtCourse, txtYearLevel, txtGuardianName, txtStudentAddress, txtGuardianContNum, txtStudentBday}
        Dim requiredFieldNames As New List(Of String) From {"First Name", "Last Name", "Middle Name", "Course", "Year Level", "Guardian's Name", "Student's Address", "Guardian's Contact Number", "Student's Birthday"}

        For i As Integer = 0 To requiredFields.Count - 1
            If requiredFields(i).Text = "" Then
                MessageBox.Show(requiredFieldNames(i) & " is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Next
        'End of loop

        Try
            ' Check if the student number already exists
            Dim cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM tbl_queue WHERE student_number='" & txtStudentNum.Text & "'", strcon)
            strcon.Open()
            Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            strcon.Close()

            If count > 0 Then
                MessageBox.Show("Student number already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' Insert the new record into the database
                create("INSERT INTO tbl_queue(fname, lname, m_i, course, year_level, guardian_name, guardian_contact_num,
                        student_address, student_Birthday, student_number)
                        VALUES('" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtMi.Text & "', '" & txtCourse.Text & "', '" & txtYearLevel.Text & "',
                        '" & txtGuardianName.Text & "', '" & txtGuardianContNum.Text & "', '" & txtStudentAddress.Text & "', '" & txtStudentBday.Text & "',
                        '" & txtStudentNum.Text & "')")
                Try
                    'AUDIT
                    action = "CREATED STUDENT: " & txtLname.Text & ", " & txtFname.Text
                    dateTime = DateTime.Now
                    LogAudit(username, action, dateTime)
                    'END AUDIT
                Catch ex As Exception
                    MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


                ' Reload records after inserting the new record
                reload_record()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_record() 'RELOAD THE DATAGRID VIEW UPON START'
        DoubleBuffer.DoubleBuffered(DataGridView1, True)
    End Sub

    'FUNCTION THAT RELOAD THE DATAGRIDVIEW'S DATA'
    Public Sub reload_record()
        Try
            reload("SELECT * FROM tbl_queue", DataGridView1)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt

                dt.Columns.Add("Picture", GetType(Byte()))
                For Each row As DataRow In dt.Rows
                    If row("image_file_name").ToString = "" Then
                        row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\default.png")
                    Else
                        row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\" & Path.GetFileName(row("image_file_name").ToString()))
                    End If
                Next

                Dim img As New DataGridViewImageColumn()
                img = DataGridView1.Columns(12)
                img.ImageLayout = DataGridViewImageCellLayout.Stretch

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            'NOTE: will add a a dropdown box para naay choices for filtering (Fname, Lname, or student number)
            reloadtxt("SELECT * FROM tbl_queue WHERE fname LIKE '%" & txtSearch.Text & "%' OR lname LIKE '%" & txtSearch.Text & "'")
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt

                'Will load the Information of the students
                txtQueueNum.Text = dt.Rows(0).Item("queue_ID").ToString
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

                ' The one to show the student picture
                If dt.Rows.Count > 0 Then
                    If String.IsNullOrEmpty(dt.Rows(0).Item("image_file_name").ToString) Then
                        picStudentPic.ImageLocation = Application.StartupPath & "\Profile\default.png"
                    Else
                        picStudentPic.ImageLocation = Application.StartupPath & "\Profile\" & dt.Rows(0).Item("image_file_name").ToString
                    End If
                End If

                'Checks if the column Picture already exist. To avoid creating it again after updating picture of student
                If Not dt.Columns.Contains("Picture") Then
                    dt.Columns.Add("Picture", GetType(Byte()))
                End If

                'Add picture of the student to the datagrid
                For Each row As DataRow In dt.Rows
                    If row("image_file_name").ToString = "" Then
                        row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\default.png")
                    Else
                        row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\" & Path.GetFileName(row("image_file_name").ToString()))
                    End If
                Next

                'Property of Picture column on datagridview
                Dim img As New DataGridViewImageColumn()
                img = DataGridView1.Columns(12)
                img.ImageLayout = DataGridViewImageCellLayout.Stretch


            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred search text box: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Loop method to check individually the text box if it is a blank
        Dim requiredFields As New List(Of TextBox) From {txtFname, txtLname, txtMi, txtCourse, txtYearLevel, txtGuardianName, txtStudentAddress, txtGuardianContNum, txtStudentBday}
        Dim requiredFieldNames As New List(Of String) From {"First Name", "Last Name", "Middle Name", "Course", "Year Level", "Guardian's Name", "Student's Address", "Guardian's Contact Number", "Student's Birthday"}

        For i As Integer = 0 To requiredFields.Count - 1
            If requiredFields(i).Text = "" Then
                MessageBox.Show(requiredFieldNames(i) & " is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Next
        'End of loop

        Try
            updates("UPDATE tbl_queue SET student_number='" & txtStudentNum.Text & "', fname='" & txtFname.Text & "', lname='" & txtLname.Text & "', m_i='" & txtMi.Text & "', course='" & txtCourse.Text & "',
            year_level='" & txtYearLevel.Text & "', guardian_name='" & txtGuardianName.Text & "', guardian_contact_num='" & txtGuardianContNum.Text & "',
            student_address='" & txtStudentAddress.Text & "', student_Birthday='" & txtStudentBday.Text & "'
            WHERE queue_ID ='" & txtQueueNum.Text & "'")

            reload_record()

            Try
                'AUDIT
                action = "UPDATED STUDENT: " & txtLname.Text & ", " & txtFname.Text
                dateTime = DateTime.Now
                LogAudit(username, action, dateTime)
                'END AUDIT
            Catch ex As Exception
                MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM tbl_queue WHERE student_number='" & txtStudentNum.Text & "'")
            Call Form1_Load(sender, e)

            'AUDIT
            Try
                action = "DELETED STUDENT: " & txtLname.Text & ", " & txtFname.Text
                dateTime = DateTime.Now
                LogAudit(username, action, dateTime)
            Catch ex As Exception
                MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'END AUDIT

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

    Private Sub btnEditImage_Click(sender As Object, e As EventArgs) Handles btnEditImage.Click
        With editImage
            .StudentLastName = txtLname.Text
            .StudentFirstName = txtFname.Text
            .ReloadFunction = AddressOf reload_record
            .Show()

        End With
    End Sub

    Private Sub btnPrintID_Click(sender As Object, e As EventArgs) Handles btnPrintID.Click
        With testPrintID
            .txtStudentNum.Text = DataGridView1.CurrentRow.Cells("student_number").Value.ToString
            .txtName.Text = DataGridView1.CurrentRow.Cells("fname").Value.ToString & " " &
                            DataGridView1.CurrentRow.Cells("m_i").Value.ToString & " " &
                            DataGridView1.CurrentRow.Cells("lname").Value.ToString
            .Show()
        End With
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Dim item As String
        Dim i As Integer
        Try
            With DataGridView1
                If e.RowIndex >= 0 Then
                    i = .CurrentRow.Index

                    txtQueueNum.Text = .Rows(i).Cells("queue_ID").Value.ToString
                    txtStudentNum.Text = .Rows(i).Cells("student_number").Value.ToString
                    txtFname.Text = .Rows(i).Cells("fname").Value.ToString
                    txtMi.Text = .Rows(i).Cells("m_i").Value.ToString
                    txtLname.Text = .Rows(i).Cells("lname").Value.ToString
                    txtCourse.Text = .Rows(i).Cells("course").Value.ToString
                    txtYearLevel.Text = .Rows(i).Cells("year_level").Value.ToString
                    txtGuardianName.Text = .Rows(i).Cells("guardian_name").Value.ToString
                    txtGuardianContNum.Text = .Rows(i).Cells("guardian_contact_num").Value.ToString
                    txtStudentAddress.Text = .Rows(i).Cells("student_address").Value.ToString
                    txtStudentBday.Text = .Rows(i).Cells("student_Birthday").Value.ToString
                    LoadImage() 'View the image to the datagridview

                End If




            End With

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
