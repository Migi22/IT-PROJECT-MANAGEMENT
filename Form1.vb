﻿Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports System.Security.Policy

Public Class Form1
    Private username As String = CurrentUser.Username
    Private action As String
    Private dateTime As DateTime

    Private isAddingStudent As Boolean = True ' Variable to track the state of the button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DoubleBuffer.DoubleBuffered(DataGridView1, True)
        cmbFilterSearch.SelectedIndex = 0
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEditSignature.Enabled = False
        reload_record() ' Reload the DataGridView upon form start
        DisableTextboxes()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isAddingStudent Then
            ' Clear textboxes, enable buttons and disable some
            ClearText() ' Clear textboxes and change button text
            EnableTextboxes()
            btnSave.Text = "Save Student"
            btnEdit.Enabled = False
            btnCancelSave.Visible = True ' Show the Cancel button
            btnEditSignature.Enabled = True
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

    Private Sub btnCancelSave_Click(sender As Object, e As EventArgs) Handles btnCancelSave.Click
        ClearText()
        DisableTextboxes()
        btnSave.Text = "Add Student"
        isAddingStudent = True
        btnCancelSave.Visible = False
        btnEdit.Enabled = True
        btnEditSignature.Enabled = False
    End Sub

    ' Clear Textboxes
    Private Sub ClearText()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
        'picStudentPic.Image = Nothing
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Checks first if the txtQueueNum is empty or not to make sure there is something to edit
        If txtQueueNum.Text = "" Then
            MessageBox.Show("Please select first a queue entry before editing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            btnCancelEdit.Visible = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = False
            btnEditSignature.Enabled = True

            EnableTextboxes()
        End If
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        btnCancelEdit.Visible = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnSave.Enabled = True
        btnEditSignature.Enabled = False

        DisableTextboxes()
    End Sub



    'FUNCTION THAT RELOAD THE DATAGRIDVIEW'S DATA'
    Public Sub reload_record()

        Try
            'reloadtxtFilterSignature("SELECT * From tbl_queue")
            ReloadData()
            form1DTG(DataGridView1) ' Formats the cells for the Datagridview1
            If dt.Rows.Count > 0 Then
                'DataGridView1.DataSource = dt



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

                ' Set the image of the Picture column into zoom
                'Dim pictureColumn As New DataGridViewImageColumn()
                'pictureColumn = CType(DataGridView1.Columns("Picture"), DataGridViewImageColumn)
                'pictureColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

                ' Set the image of the student_signature column into zoom
                Dim signatureColumn As New DataGridViewImageColumn()
                signatureColumn = CType(DataGridView1.Columns("student_signature"), DataGridViewImageColumn)
                signatureColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            Else
                ClearText()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred reload record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Reload The TextBoxes Without updating DataGridView
    Public Sub reload_TextBoxes()
        Dim i As Integer
        Try
            With DataGridView1
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
                LoadImage()
            End With

        Catch ex As Exception
            MessageBox.Show("An error occurred on refreshing TextBoxes and Pictures: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            'temporary off
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

    Private Sub cmbFilterSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterSearch.SelectedIndexChanged
        ' Call the method to reload data based on the selected filter

        'temporary
        ReloadData()
        reload_record()
    End Sub

    Private Sub ReloadData()
        Try
            'Build the dynamic SQL query with the status filter and search text
            Dim query As String = "SELECT * FROM tbl_queue"
            Dim statusFilter As String = ""

            'Determine the status filter based on the selected item in cmbFilterSearch
            Select Case cmbFilterSearch.SelectedItem.ToString()
                Case "Verified"
                    statusFilter = "status = 'Verified' AND CONCAT(fname, ' ', lname) LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case "Needs Verification"
                    statusFilter = "status = 'Needs Verification' AND CONCAT(fname, ' ', lname) LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case "Done"
                    statusFilter = "status = 'Done' AND CONCAT(fname, ' ', lname) LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case "Student Number"
                    statusFilter = "student_number LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case "First Name"
                    statusFilter = "fname LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case "Last Name"
                    statusFilter = "lname LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case "Queue ID"
                    statusFilter = "queue_id = '" & txtSearch.Text.Trim() & "'"
                Case "Full Name"
                    statusFilter = "CONCAT(fname, ' ', lname) LIKE '%" & txtSearch.Text.Trim() & "%'"
                Case Else
                    statusFilter = "" ' No specific status filter if a different option is selected
            End Select

            'Append the status filter to the WHERE clause if a specific status is selected
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE " & statusFilter
            End If

            'Debugging output to display the constructed SQL query
            'MessageBox.Show("Generated Query: " & query)

            'Query and reload the data
            reloadtxtFilterSignatureAndPicture(query)

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
            btnSave.Enabled = True
            btnCancelEdit.Visible = False
            btnEditSignature.Enabled = False
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
            btnSave.Enabled = True
            btnCancelEdit.Visible = False
            btnEditSignature.Enabled = False
            DisableTextboxes()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load Student Pictures with paraameter DataTable
    Private Sub LoadStudentImage(ByVal dt As DataTable)

        If dt.Rows.Count > 0 AndAlso Not String.IsNullOrEmpty(dt.Rows(0).Item("student_picture").ToString) Then
            Dim imageData As Byte() = DirectCast(dt.Rows(0).Item("student_picture"), Byte())

            ' Convert byte array to image
            Using ms As New System.IO.MemoryStream(imageData)
                Dim image As Image = Image.FromStream(ms)
                picStudentPic.Image = image ' Display the image in PictureBox
            End Using
        Else
            ' If "student_signature" is null or empty, display a default image
            picStudentPic.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "Resources", "default.png")) ' DefaultImage is a placeholder for your default image
        End If


        ' Testing May 5 2024, This is for Signature
        If dt.Rows.Count > 0 AndAlso Not String.IsNullOrEmpty(dt.Rows(0).Item("student_signature").ToString) Then
            Dim imageData As Byte() = DirectCast(dt.Rows(0).Item("student_signature"), Byte())

            ' Convert byte array to image
            Using ms As New System.IO.MemoryStream(imageData)
                Dim image As Image = Image.FromStream(ms)
                picStudentSignature.Image = image ' Display the image in PictureBox
            End Using
        Else
            ' If "student_signature" is null or empty, display a default image
            picStudentSignature.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "Resources", "NoSignature.jpg")) ' DefaultImage is a placeholder for your default image
        End If


    End Sub

    ' Load Image of the student both Picture and Signature with no Parameters
    Public Sub LoadImage()
        Try
            reloadtxtFilterSignatureAndPicture("SELECT * FROM tbl_queue WHERE queue_ID='" & txtQueueNum.Text & "'")

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

                ' Testing 20/4/24

                If dt.Rows.Count > 0 AndAlso Not String.IsNullOrEmpty(dt.Rows(0).Item("student_signature").ToString) Then
                    Dim imageData As Byte() = DirectCast(dt.Rows(0).Item("student_signature"), Byte())

                    ' Convert byte array to image
                    Using ms As New System.IO.MemoryStream(imageData)
                        Dim image As Image = Image.FromStream(ms)
                        picStudentSignature.Image = image ' Display the image in PictureBox
                    End Using
                Else
                    ' If "student_signature" is null or empty, display a default image
                    picStudentSignature.Image = Image.FromFile(System.IO.Path.Combine(Application.StartupPath, "Resources", "NoSignature.jpg")) ' DefaultImage is a placeholder for your default image
                End If

                ' Testing 20/4/24
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditImage_Click(sender As Object, e As EventArgs) Handles btnEditImage.Click
        With editImage
            .StudentLastName = txtLname.Text
            .StudentFirstName = txtFname.Text
            .ReloadFunction = AddressOf reload_TextBoxes
            .QueueID = txtQueueNum.Text
            .ShowDialog()

        End With
    End Sub

    Private Sub btnEditSignature_Click(sender As Object, e As EventArgs) Handles btnEditSignature.Click
        With editSignature
            .StudentLastName = txtLname.Text
            .StudentFirstName = txtFname.Text
            .ReloadFunction = AddressOf reload_TextBoxes
            .QueueID = txtQueueNum.Text
            .ShowDialog()

        End With
    End Sub

    Private Sub btnPrintID_Click(sender As Object, e As EventArgs) Handles btnPrintID.Click
        ' Check if DataGridView1 is not null and has at least one row
        If DataGridView1 IsNot Nothing AndAlso DataGridView1.CurrentRow IsNot Nothing Then
            If Not ValidateData() Then
                MessageBox.Show("Some data is missing or empty. Please fill in all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Exit the method without showing the options form
            End If

            If isDoneOrNeedVerify() Then
                Return ' Exit the method without showing the options form
            End If

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
        Else
            MessageBox.Show("The DataGridView is null or has no current row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to check if there is a null or empty details that needed for ID processing
    Private Function ValidateData() As Boolean
        ' Validate that all required data is present
        Dim requiredFields As String() = {"fname", "lname", "course", "year_level", "student_number", "student_Birthday", "guardian_name", "guardian_contact_num", "student_address"}
        For Each field As String In requiredFields
            If String.IsNullOrEmpty(DataGridView1.CurrentRow.Cells(field).Value?.ToString()) Then
                Return False ' Return false if any required field is empty
            End If
        Next
        Return True ' Return true if all required fields are filled
    End Function
    ' Check if the status is Done or Needs Verification
    Private Function isDoneOrNeedVerify() As Boolean
        Dim status As String = DataGridView1.CurrentRow.Cells("status").Value.ToString()

        If status.Equals("Done") Then
            MessageBox.Show("Cannot Print because the Status is Done.", "Status Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True ' Return true if Done
        ElseIf status.Equals("Needs Verification") Then
            MessageBox.Show("Cannot Print because the status needs verification.", "Status Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True ' Return true if Needs Verification
        End If

        Return False ' Return false if status is neither Done nor Needs Verification
    End Function


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
                    LoadImage()

                End If
            End With

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnChangeStatus_Click(sender As Object, e As EventArgs) Handles btnChangeStatus.Click
        ' Show the ContextMenuStrip at the location of the button
        SelectStatus.Show(btnChangeStatus, 0, btnChangeStatus.Height)
    End Sub

    ' Next line of codes are for the btnChangeStatus
    Private Sub VerifiedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifiedToolStripMenuItem.Click
        ChangeStatus("Verified")
    End Sub

    Private Sub NeedsVerificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeedsVerificationToolStripMenuItem.Click
        ChangeStatus("Needs Verification")
    End Sub

    Private Sub DoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoneToolStripMenuItem.Click
        ChangeStatus("Done")
    End Sub

    Private Sub ChangeStatus(newStatus As String)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the status of this queue to " & newStatus & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Validate queue ID
                If Not Integer.TryParse(txtQueueNum.Text, Nothing) Then
                    MessageBox.Show("Invalid queue ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Perform the status update with parameterized query
                updates("UPDATE tbl_queue SET status = @NewStatus WHERE queue_ID = @QueueID",
                    New MySqlParameter("@NewStatus", newStatus),
                    New MySqlParameter("@QueueID", txtQueueNum.Text))

                ' Reload the record
                reload_record()

                MessageBox.Show("Status updated successfully to " & newStatus & ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try
                    'AUDIT
                    Dim action As String = "UPDATED STUDENT status (" & newStatus & "): " & txtLname.Text & ", " & txtFname.Text
                    Dim dateTime As DateTime = DateTime.Now
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


    'End of btnChangeStatus

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
        btnEditImage.Enabled = True
    End Sub
End Class
