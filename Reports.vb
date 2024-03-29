Imports System.IO
Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Public Class Reports
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Private WithEvents ppd As New PrintPreviewDialog

    Private statusFilter As String = ""


    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusFilter = ""

        'cmbFilterReport.SelectedIndex = 0

        loadReports()


        DoubleBuffer.DoubleBuffered(DataGridViewReports, True)
        cbCourse.SelectedIndex = 0
        cbYear.SelectedIndex = 0




    End Sub

    Private Sub UpdateFilterInfoLabel(ByVal filterInfo As String)
        If Not String.IsNullOrEmpty(statusFilter) Then
            lblFilterInfo.Text &= filterInfo & statusFilter
        End If
    End Sub

    Public Sub loadReports()
        Try
            lblFilterInfo.Text = "Showing All records"
            UpdateFilterInfoLabel(" with Status Filter: ")

            ' Modify your SQL query to fetch the date and time components separately
            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE status = '" & statusFilter & "'"
            End If

            reload(query, DataGridViewReports)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading reports: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtSearchReport_TextChanged(sender As Object, e As EventArgs) Handles txtSearchReport.TextChanged
        Try
            ReloadData()

            If dt.Rows.Count > 0 Then
                DataGridViewReports.DataSource = dt

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred searching audit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Try

            lblFilterInfo.Text = "Showing All records"
            UpdateFilterInfoLabel(" with Status Filter: ")

            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE status = '" & statusFilter & "'"
            End If

            reload(query, DataGridViewReports)
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading ALL reports: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try

            lblFilterInfo.Text = "Showing Daily records"
            UpdateFilterInfoLabel(" with Status Filter: ")

            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue WHERE done_printing_date = DATE(NOW())"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND status = '" & statusFilter & "'"
            End If

            reload(query, DataGridViewReports)
        Catch ex As Exception
            MessageBox.Show("An error occurred on Daily: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try

            lblFilterInfo.Text = "Showing Weekly records"
            UpdateFilterInfoLabel(" with Status Filter: ")

            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue WHERE WEEK(done_printing_date) = WEEK(NOW())"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND status = '" & statusFilter & "'"
            End If

            reload(query, DataGridViewReports)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Try

            lblFilterInfo.Text = "Showing Monthly records"
            UpdateFilterInfoLabel(" with Status Filter: ")

            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue WHERE MONTH(done_printing_date) = MONTH(NOW())"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND status = '" & statusFilter & "'"
            End If

            reload(query, DataGridViewReports)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnFilterDate_Click(sender As Object, e As EventArgs) Handles btnFilterDate.Click
        Try

            lblFilterInfo.Text = "Showing All records from " & DTPFrom.Value.ToString("dd-MM-yyyy") & " and " & DTPTo.Value.ToString("dd-MM-yyyy")
            UpdateFilterInfoLabel(" with Status Filter: ")

            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue WHERE DATE_FORMAT(done_printing_date, '%Y-%m-%d') BETWEEN '" & DTPFrom.Value.ToString("yyyy-MM-dd") & "' AND '" & DTPTo.Value.ToString("yyyy-MM-dd") & "'"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND status = '" & statusFilter & "'"
            End If

            ' Reload data into DataGridViewAudits using the updated query
            reload(query, DataGridViewReports)
        Catch ex As Exception
            MessageBox.Show("An error occurred on filtering date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cmbFilterReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterReport.SelectedIndexChanged
        ' Call the method to reload data based on the selected filter
        ReloadData()

        lblFilterInfo.Text = "Showing All records"
        UpdateFilterInfoLabel(" with Status Filter: ")

    End Sub

    Private Sub ReloadData()
        Try

            'Determine the status filter based on the selected item in cmbFilterSearch
            Select Case cmbFilterReport.SelectedItem.ToString()
                Case "On Queue"
                    statusFilter = "On Queue"
                Case "Needs Verification"
                    statusFilter = "Needs Verification"
                Case "Done"
                    statusFilter = "Done"
                Case "No Filter"
                    statusFilter = ""
                Case Else
                    statusFilter = "" ' No specific status filter if a different option is selected
            End Select

            'Build the dynamic SQL query with the status filter and search text
            Dim query As String = "SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue"

            'Append the status filter to the WHERE clause if a specific status is selected
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE status = '" & statusFilter & "'"
            End If

            'Query and reload the data
            reloadtxt(query)

            'Reload the DataGridView with the filtered results
            DataGridViewReports.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred while reloading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFilterCourseYear_Click(sender As Object, e As EventArgs) Handles btnFilterCourseYear.Click
        Try
            ' Construct the SQL query based on the selected values from ComboBoxes
            Dim selectedCourse As String = cbCourse.SelectedItem.ToString()
            Dim selectedYear As String = cbYear.SelectedItem.ToString()

            ' Assuming reload is a method to reload data into DataGridView
            Dim query As String = $"SELECT student_number, fname, lname, m_i, course, year_level, status, done_printing_date FROM tbl_queue WHERE course = '{selectedCourse}' AND year_level = '{selectedYear}'"

            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND status = '" & statusFilter & "'"
            End If

            reload(query, DataGridViewReports)
        Catch ex As Exception
            MessageBox.Show("An error occurred on filtering Course and Year: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        ppd.Document = PrintDocumentAudit
        ppd.ShowDialog()
    End Sub

    Private Sub PrintDocumentAudit_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentAudit.PrintPage
        ' sets it to show '...' for long text'
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        Dim Claret As Color = Color.FromArgb(137, 49, 69) ' RGB values for #892145
        Dim Sunglow As Color = Color.FromArgb(255, 197, 59) ' RGB values for #FFC53B


        ' Print the header text for a new page
        ' use a grey bg just like the control
        If newpage Then
            row = DataGridViewReports.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view
                ' skip individual columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)


                    e.Graphics.FillRectangle(New SolidBrush(Claret), rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case DataGridViewReports.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                             DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(DataGridViewReports.Columns(cell.ColumnIndex).HeaderText,
                                          DataGridViewReports.Font, New SolidBrush(Sunglow), rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newpage = False

        'now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridViewReports.RowCount - 1
            ' no need to try to print the new row
            If DataGridViewReports.Rows(thisNDX).IsNewRow Then Exit For

            row = DataGridViewReports.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            'print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridViewReports.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                            DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                             DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                          DataGridViewReports.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1 causes last row to rePrint on Next page
                newpage = True
                Return
            End If

        Next

    End Sub

    Private Sub PrintDocumentAudit_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocumentAudit.BeginPrint
        mRow = 0
        newpage = True
        ppd.PrintPreviewControl.StartPage = 0
        ppd.PrintPreviewControl.Zoom = 1.0

    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing

        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()

        End Try

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim xlApplication As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApplication = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlApplication.Visible = True
        xlWorkBook = xlApplication.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        'For header

        For i = 1 To DataGridViewReports.ColumnCount
            xlWorkSheet.Cells(1, i) = DataGridViewReports.Columns(i - 1).HeaderText

            'For items

            For j = 1 To DataGridViewReports.RowCount
                xlWorkSheet.Cells(j + 1, i) = DataGridViewReports(i - 1, j - 1).Value
            Next
        Next

    End Sub


End Class