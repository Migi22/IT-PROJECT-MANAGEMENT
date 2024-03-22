Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            create("INSERT INTO tbl_queue(fname, lname, m_i, course, year_level, guardian_name, guardian_contact_num,
            student_address, student_Birthday, student_number)
            VALUES('" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtMi.Text & "', '" & txtCourse.Text & "', '" & txtYearLevel.Text & "',
            '" & txtGuardianName.Text & "', '" & txtGuardianContNum.Text & "', '" & txtStudentAddress.Text & "', '" & txtStudentBday.Text & "',
            '" & txtStudentNum.Text & "')")



        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            sql = "SELECT * FROM tbl_queue WHERE student_number = " & txtSearch.Text & ""
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
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            updates("UPDATE tbl_queue SET fname='" & txtFname.Text & "', lname='" & txtLname.Text & "', m_i='" & txtMi.Text & "', course='" & txtCourse.Text & "',
            year_level='" & txtYearLevel.Text & "', guardian_name='" & txtGuardianName.Text & "', guardian_contact_num='" & txtGuardianContNum.Text & "',
            student_address='" & txtStudentAddress.Text & "', student_Birthday='" & txtStudentBday.Text & "'
            WHERE student_number='" & txtStudentNum.Text & "'")



        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete("DELETE FROM tbl_queue WHERE student_number='" & txtSearch.Text & "'")
            Call Form1_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
