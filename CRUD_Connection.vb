Imports System.IO
Imports MySql.Data.MySqlClient
Module CRUD_Connection
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
            End With
            If result = 0 Then
                MessageBox.Show("Data failed to insert", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Data has been inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearText()

            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    'GET RECORD TO THE DATABASE' 
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            strcon.Open()

            dt = New DataTable
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.Datasource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred on reloading: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub ClearText()
        Form1.txtQueueNum.Clear()
        Form1.txtFname.Clear()
        Form1.txtLname.Clear()
        Form1.txtMi.Clear()
        Form1.txtCourse.Clear()
        Form1.txtYearLevel.Clear()
        Form1.txtGuardianName.Clear()
        Form1.txtGuardianContNum.Clear()
        Form1.txtStudentAddress.Clear()
        Form1.txtStudentBday.Clear()
        Form1.txtStudentNum.Clear()
        Form1.txtSearch.Clear()
        Form1.picStudentPic.Image = Nothing
        Form1.picStudentSignature.Image = Nothing

    End Sub

    Public Sub updates(ByVal SQL As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = SQL
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Data failed to update to the database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Data has been updated successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearText()

                End If
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    ' Updates with mysql parameter
    Public Sub updates(ByVal SQL As String, ByVal ParamArray parameters() As MySqlParameter)
        Try
            strcon.Open()
            Using cmd As New MySqlCommand(SQL, strcon)
                cmd.Parameters.AddRange(parameters)
                result = cmd.ExecuteNonQuery()

                If result = 0 Then
                    MessageBox.Show("Data failed to update to the database", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'MessageBox.Show("Data has been updated successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearText()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
        End Try
    End Sub


    Public Sub reloadtxt(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With

            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)
        Catch ex As Exception
            'MessageBox.Show("An error occurred reloadtext(): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub reloadtxtFilterSignature(ByVal sql As String)
        Try
            strcon.Open()
            cmd.Connection = strcon
            cmd.CommandText = sql

            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)

            ' Load default image as byte array
            Dim defaultImageBytes As Byte() = File.ReadAllBytes(Application.StartupPath & "\Default\NoSignature.jpg")

            ' Check and update "student_signature" column in DataTable
            For Each row As DataRow In dt.Rows
                Dim signatureBytes As Byte() = TryCast(row("student_signature"), Byte())

                ' Check if "student_signature" is null or empty
                If signatureBytes Is Nothing OrElse signatureBytes.Length = 0 Then
                    row("student_signature") = defaultImageBytes
                End If
            Next
        Catch ex As Exception
            ' Handle exceptions as needed
            'MessageBox.Show("An error occurred reloadtext(): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub checkSignature(ByVal sql As String)
        Try
            strcon.Open()
            cmd.Connection = strcon
            cmd.CommandText = sql

            dt = New DataTable
            da = New MySqlDataAdapter(sql, strcon)
            da.Fill(dt)

            ' Check if the DataTable has rows and the "student_signature" is not null or empty
            If dt.Rows.Count <= 0 OrElse IsDBNull(dt.Rows(0).Item("student_signature")) OrElse DirectCast(dt.Rows(0).Item("student_signature"), Byte()).Length <= 0 Then
                MessageBox.Show("There is no image to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Handle exceptions as needed
            'MessageBox.Show("An error occurred reloadtext(): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub



    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery

                If result = 0 Then
                    MessageBox.Show("Data failed to delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Data has been deleted successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearText()

                End If
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
End Module
