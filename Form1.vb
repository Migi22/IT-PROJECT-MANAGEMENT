Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Reflection
Imports System.Security.Policy

Public Class Form1
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime

    Private isAddingStudent As Boolean = True ' Variable to track the state of the button

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isAddingStudent Then
            ' Clear textboxes and change button text
            ClearText()
            btnSave.Text = "Save Student"
            isAddingStudent = False
        Else
            ' Check if all required fields are filled
            Dim requiredFields As New List(Of TextBox) From {txtFname, txtLname, txtMi, txtCourse, txtYearLevel, txtGuardianName, txtStudentAddress, txtGuardianContNum, txtStudentBday}
            Dim requiredFieldNames As New List(Of String) From {"First Name", "Last Name", "Middle Name", "Course", "Year Level", "Guardian's Name", "Student's Address", "Guardian's Contact Number", "Student's Birthday"}

            For i As Integer = 0 To requiredFields.Count - 1
                If requiredFields(i).Text = "" Then
                    MessageBox.Show(requiredFieldNames(i) & " is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

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
                    create("INSERT INTO tbl_queue(fname, lname, m_i, course, year_level, guardian_name, guardian_contact_num, student_address, student_Birthday, student_number) VALUES('" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtMi.Text & "', '" & txtCourse.Text & "', '" & txtYearLevel.Text & "', '" & txtGuardianName.Text & "', '" & txtGuardianContNum.Text & "', '" & txtStudentAddress.Text & "', '" & txtStudentBday.Text & "', '" & txtStudentNum.Text & "')")
                    ' Clear textboxes and change button text back to "Add Student"
                    ClearText()
                    btnSave.Text = "Add Student"
                    isAddingStudent = True
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
        End If
    End Sub

    Private Sub ClearText()
        txtQueueNum.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtMi.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()
        txtGuardianName.Clear()
        txtGuardianContNum.Clear()
        txtStudentAddress.Clear()
        txtStudentBday.Clear()
        txtStudentNum.Clear()
        txtSearch.Clear()
        picStudentPic.Image = Nothing

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_record() ' Reload the DataGridView upon form start
        DoubleBuffer.DoubleBuffered(DataGridView1, True)
        cmbFilterSearch.SelectedIndex = 0
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        DisableTextboxes()


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnEdit.Enabled = False

        EnableTextboxes()
    End Sub

    'FUNCTION THAT RELOAD THE DATAGRIDVIEW'S DATA'
    Public Sub reload_record()

        Try
            reload("SELECT * FROM tbl_queue", DataGridView1)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt

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


                dt.Columns.Add("Picture", GetType(Byte()))
                For Each row As DataRow In dt.Rows
                    If row("image_file_name").ToString = "" Then
                        row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\default.png")
                    Else
                        row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\" & Path.GetFileName(row("image_file_name").ToString()))
                    End If
                Next



                Dim pictureColumn As New DataGridViewImageColumn()
                pictureColumn = CType(DataGridView1.Columns("Picture"), DataGridViewImageColumn)
                pictureColumn.ImageLayout = DataGridViewImageCellLayout.Stretch


                Dim signatureColumn As New DataGridViewImageColumn()
                signatureColumn = CType(DataGridView1.Columns("student_signature"), DataGridViewImageColumn)
                signatureColumn.ImageLayout = DataGridViewImageCellLayout.Zoom


            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred reload record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            ReloadData()

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

                LoadStudentImage(dt)


            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred search text box: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub LoadStudentImage(ByVal dt As DataTable)
        ' The one to show the student picture
        If dt.Rows.Count > 0 Then
            If String.IsNullOrEmpty(dt.Rows(0).Item("image_file_name").ToString) Then
                picStudentPic.ImageLocation = Application.StartupPath & "\Profile\default.png"
            Else
                picStudentPic.ImageLocation = Application.StartupPath & "\Profile\" & dt.Rows(0).Item("image_file_name").ToString
            End If
        End If

        ' Checks if the column Picture already exists. To avoid creating it again after updating the student's picture
        If Not dt.Columns.Contains("Picture") Then
            dt.Columns.Add("Picture", GetType(Byte()))
        End If

        ' Add the picture of the student to the DataTable
        For Each row As DataRow In dt.Rows
            If row("image_file_name").ToString = "" Then
                row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\default.png")
            Else
                row("Picture") = File.ReadAllBytes(Application.StartupPath & "\Profile\" & Path.GetFileName(row("image_file_name").ToString()))
            End If
        Next

        ' Set the properties of the Picture column on the DataGridView
        Dim img As New DataGridViewImageColumn()
        img = DataGridView1.Columns(15)
        img.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub


    Private Sub cmbFilterSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterSearch.SelectedIndexChanged
        ' Call the method to reload data based on the selected filter
        ReloadData()
    End Sub

    Private Sub ReloadData()
        Try
            Dim statusFilter As String = ""

            'Determine the status filter based on the selected item in cmbFilterSearch
            Select Case cmbFilterSearch.SelectedItem.ToString()
                Case "On Queue"
                    statusFilter = "status = 'On Queue'"
                Case "Needs Verification"
                    statusFilter = "status = 'Needs Verification'"
                Case "Done"
                    statusFilter = "status = 'Done'"
                Case Else
                    statusFilter = "" ' No specific status filter if a different option is selected
            End Select

            'Build the dynamic SQL query with the status filter and search text
            Dim query As String = "SELECT * FROM tbl_queue"

            'Append the status filter to the WHERE clause if a specific status is selected
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE " & statusFilter
            End If

            'Apply additional filter based on the search text (if any)
            If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                Dim filterColumn As String = ""
                Select Case cmbFilterSearch.SelectedItem.ToString()
                    Case "Student Number"
                        filterColumn = "student_number"
                    Case "First Name"
                        filterColumn = "fname"
                    Case "Last Name"
                        filterColumn = "lname"
                    Case "Queue ID"
                        filterColumn = "queue_id"
                    Case "Full Name"
                        filterColumn = "CONCAT(fname, ' ', lname)"
                End Select

                If Not String.IsNullOrEmpty(filterColumn) Then
                    query &= If(String.IsNullOrEmpty(statusFilter), " WHERE ", " AND ") & filterColumn & " LIKE '%" & txtSearch.Text.Trim() & "%'"
                End If
            End If

            'Debugging output to display the constructed SQL query
            'MessageBox.Show("Generated Query: " & query)

            'Query and reload the data
            reloadtxt(query)

            'Reload the DataGridView with the filtered results
            DataGridView1.DataSource = dt
            LoadStudentImage(dt)
        Catch ex As Exception
            MessageBox.Show("An error occurred while reloading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            'Enable and disable certain buttons and textboxes
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = True
            DisableTextboxes()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM tbl_queue WHERE student_number='" & txtStudentNum.Text & "'")


            reload_record()
            'AUDIT
            Try
                action = "DELETED STUDENT: " & txtLname.Text & ", " & txtFname.Text
                dateTime = DateTime.Now
                LogAudit(username, action, dateTime)
            Catch ex As Exception
                MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'END AUDIT

            'Enable and disable certain buttons and textboxes
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnEdit.Enabled = True
            DisableTextboxes()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadImage()
        Try
            reloadtxt("SELECT * FROM tbl_queue WHERE queue_ID='" & txtQueueNum.Text & "'")

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
            .QueueID = txtQueueNum.Text
            .Show()

        End With
    End Sub

    Private Sub btnPrintID_Click(sender As Object, e As EventArgs) Handles btnPrintID.Click
        Using optionsForm As New Print_ID_Options
            'Fill the labels in the options form
            optionsForm.lblFMname.Text = DataGridView1.CurrentRow.Cells("fname").Value.ToString & " " &
                                            DataGridView1.CurrentRow.Cells("m_i").Value.ToString
            optionsForm.lblInputLastName.Text = DataGridView1.CurrentRow.Cells("lname").Value.ToString
            optionsForm.lblInputCourseYear.Text = DataGridView1.CurrentRow.Cells("course").Value.ToString & " - " &
                                                    DataGridView1.CurrentRow.Cells("year_level").Value.ToString
            optionsForm.lblInputStudentNum.Text = DataGridView1.CurrentRow.Cells("student_number").Value.ToString

            optionsForm.lblInputBirthday.Text = "BIRTHDAY: " & DataGridView1.CurrentRow.Cells("student_Birthday").Value.ToString
            optionsForm.lblGuardianName.Text = DataGridView1.CurrentRow.Cells("guardian_name").Value.ToString
            optionsForm.lblInputGuardianNum.Text = DataGridView1.CurrentRow.Cells("guardian_contact_num").Value.ToString
            optionsForm.lblStudentAddress.Text = DataGridView1.CurrentRow.Cells("student_address").Value.ToString

            optionsForm.QueueID = DataGridView1.CurrentRow.Cells("queue_ID").Value.ToString

            ' Retrieve the image data from the "Picture" column of the current row
            Dim imageData As Byte() = CType(DataGridView1.CurrentRow.Cells("student_signature").Value, Byte())
            If imageData IsNot Nothing Then
                ' Create a MemoryStream to hold the image data
                Using ms As New MemoryStream(imageData)
                    ' Load the image from the MemoryStream
                    Dim image As Image = Image.FromStream(ms)

                    ' Display the image in the PictureBox of the options form
                    optionsForm.picStudentSignature.Image = image
                End Using
            Else
                ' If the image data is null, display a message or handle it as needed
                MessageBox.Show("No image data available.")
            End If

            AddHandler optionsForm.FormClosedEvent, AddressOf Print_ID_Options_FormClosed

            optionsForm.ShowDialog()
        End Using
    End Sub

    'Reload the DataGridView after Print_ID_Options form is closed
    Private Sub Print_ID_Options_FormClosed(sender As Object, e As EventArgs)
        reload_record()
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

    Private Sub btnNeedVerify_Click(sender As Object, e As EventArgs) Handles btnNeedVerify.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the status of this queue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Try
                updates("UPDATE tbl_queue SET status= 'Needs Verification'
                    WHERE queue_ID ='" & txtQueueNum.Text & "'")

                reload_record()

                MessageBox.Show("Queue status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try
                    'AUDIT
                    action = "UPDATED STUDENT status (Needs Verification): " & txtLname.Text & ", " & txtFname.Text
                    dateTime = DateTime.Now
                    LogAudit(username, action, dateTime)
                    'END AUDIT
                Catch ex As Exception
                    MessageBox.Show("An error occurred during saving audit log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If


    End Sub

    Private Sub DisableTextboxes()
        ' Disable all textboxes
        txtFname.Enabled = False
        txtLname.Enabled = False
        txtMi.Enabled = False
        txtCourse.Enabled = False
        txtYearLevel.Enabled = False
        txtGuardianName.Enabled = False
        txtGuardianContNum.Enabled = False
        txtStudentAddress.Enabled = False
        txtStudentBday.Enabled = False
        txtStudentNum.Enabled = False
        txtSearch.Enabled = False
        btnEditImage.Enabled = False
    End Sub

    Private Sub EnableTextboxes()
        ' Enable all textboxes
        txtFname.Enabled = True
        txtLname.Enabled = True
        txtMi.Enabled = True
        txtCourse.Enabled = True
        txtYearLevel.Enabled = True
        txtGuardianName.Enabled = True
        txtGuardianContNum.Enabled = True
        txtStudentAddress.Enabled = True
        txtStudentBday.Enabled = True
        txtStudentNum.Enabled = True
        txtSearch.Enabled = True
        btnEditImage.Enabled = True
    End Sub


End Class
