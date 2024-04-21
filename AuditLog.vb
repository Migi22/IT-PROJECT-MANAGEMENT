Imports System.IO
Imports System.Drawing.Printing
Imports Excel = Microsoft.Office.Interop.Excel

Public Class AuditLog
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Private WithEvents ppd As New PrintPreviewDialog


    Private Sub AuditLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAudits()
        DoubleBuffer.DoubleBuffered(DataGridViewAudits, True)
    End Sub

    Public Sub loadAudits()
        Try
            ' Modify your SQL query to fetch the date and time components separately
            Dim query As String = "SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                              "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                              "FROM tbl_audit a " &
                              "INNER JOIN tbl_users u ON a.user_ID = u.user_ID"

            reload(query, DataGridViewAudits)
        Catch ex As Exception
            ' Handle exceptions here
        End Try
    End Sub


    Private Sub txtSearchAudit_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAudit.TextChanged
        Try
            'NOTE: will add a a dropdown box para naay choices for filtering (Fname, Lname, or student number)
            reloadtxt("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                              "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                              "FROM tbl_audit a " &
                              "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                              WHERE a.action LIKE '%" & txtSearchAudit.Text & "%' ")

            If dt.Rows.Count > 0 Then
                DataGridViewAudits.DataSource = dt

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
            loadAudits()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try
            reload("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                   "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                   "FROM tbl_audit a " &
                   "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                    WHERE DATE(dateTime)=DATE(NOW())", DataGridViewAudits)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try
            reload("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                   "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                   "FROM tbl_audit a " &
                   "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                    WHERE WEEK(dateTime)=WEEK(NOW())", DataGridViewAudits)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Try
            reload("SELECT a.audit_ID, a.action, DATE(a.dateTime) AS auditDate, " &
                   "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                   "FROM tbl_audit a " &
                   "INNER JOIN tbl_users u ON a.user_ID = u.user_ID
                   WHERE MONTH(dateTime)=MONTH(NOW())", DataGridViewAudits)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Dim query As String = "SELECT a.audit_ID, a.action, DATE_FORMAT(a.dateTime, '%d/%m/%Y') AS auditDate, " &
                                  "TIME_FORMAT(a.dateTime, '%h:%i:%s %p') AS auditTime, u.user_ID, u.username " &
                                  "FROM tbl_audit a " &
                                  "INNER JOIN tbl_users u ON a.user_ID = u.user_ID " &
                                  "WHERE DATE_FORMAT(a.dateTime, '%Y-%m-%d') BETWEEN '" & DTPFrom.Value.ToString("yyyy-MM-dd") & "' AND '" & DTPTo.Value.ToString("yyyy-MM-dd") & "'"

            ' Reload data into DataGridViewAudits using the updated query
            reload(query, DataGridViewAudits)
        Catch ex As Exception
            MessageBox.Show("An error occurred on filtering date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            row = DataGridViewAudits.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view
                ' skip individual columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)


                    e.Graphics.FillRectangle(New SolidBrush(Claret), rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case DataGridViewAudits.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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

                    e.Graphics.DrawString(DataGridViewAudits.Columns(cell.ColumnIndex).HeaderText,
                                          DataGridViewAudits.Font, New SolidBrush(Sunglow), rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h
        End If

        newpage = False

        'now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridViewAudits.RowCount - 1
            ' no need to try to print the new row
            If DataGridViewAudits.Rows(thisNDX).IsNewRow Then Exit For

            row = DataGridViewAudits.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            'print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridViewAudits.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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
                                          DataGridViewAudits.Font, Brushes.Black, rc, fmt)
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

        For i = 1 To DataGridViewAudits.ColumnCount
            xlWorkSheet.Cells(1, i) = DataGridViewAudits.Columns(i - 1).HeaderText

            'For items

            For j = 1 To DataGridViewAudits.RowCount
                xlWorkSheet.Cells(j + 1, i) = DataGridViewAudits(i - 1, j - 1).Value
            Next
        Next

    End Sub


End Class