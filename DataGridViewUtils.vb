Module DataGridViewUtils
    Public Sub form1DTG(dgv As DataGridView)
        dgv.Columns("done_printing_date").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_number").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("guardian_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("guardian_contact_num").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_address").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_Birthday").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("student_signature").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv.Columns("image_file_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub


End Module
