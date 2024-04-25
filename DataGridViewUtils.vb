Module DataGridViewUtils
    Public Sub form1DTG(dgv As DataGridView)
        ' ADD sizes for specific columns
        dgv.Columns("queue_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("done_printing_date").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("year_level").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("guardian_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("guardian_contact_num").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_address").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_Birthday").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_signature").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("image_file_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        dgv.Columns("lname").Width = 150
        dgv.Columns("fname").Width = 150

    End Sub

    Public Sub auditDTG(dgv As DataGridView)
        Try
            ' Set auto sizing for other columns
            dgv.Columns("audit_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv.Columns("auditDate").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv.Columns("auditTime").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgv.Columns("username").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            ' Set width for the "action" column
            dgv.Columns("action").Width = 250

            dgv.RowTemplate.Height = 100

            ' Enable text wrapping for the "action" column
            Dim actionColumn As DataGridViewColumn = dgv.Columns("action")
            If actionColumn IsNot Nothing AndAlso TypeOf actionColumn Is DataGridViewTextBoxColumn Then
                Dim textColumn As DataGridViewTextBoxColumn = DirectCast(actionColumn, DataGridViewTextBoxColumn)
                textColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Module
