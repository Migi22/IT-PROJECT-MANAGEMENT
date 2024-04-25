<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDocumentAudit = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFilterDate = New System.Windows.Forms.CheckBox()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewReports = New System.Windows.Forms.DataGridView()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFilterCourseYear = New System.Windows.Forms.CheckBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbFilterReport = New System.Windows.Forms.ComboBox()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.lblFilterInfo = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchReport = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.leftPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocumentAudit
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFilterDate)
        Me.GroupBox1.Controls.Add(Me.lblDateTo)
        Me.GroupBox1.Controls.Add(Me.lblDateFrom)
        Me.GroupBox1.Controls.Add(Me.DTPTo)
        Me.GroupBox1.Controls.Add(Me.DTPFrom)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 181)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FLITER BY DATE"
        '
        'cbFilterDate
        '
        Me.cbFilterDate.AutoSize = True
        Me.cbFilterDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterDate.Location = New System.Drawing.Point(4, 19)
        Me.cbFilterDate.Name = "cbFilterDate"
        Me.cbFilterDate.Size = New System.Drawing.Size(69, 20)
        Me.cbFilterDate.TabIndex = 5
        Me.cbFilterDate.Text = "Check"
        Me.cbFilterDate.UseVisualStyleBackColor = True
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTo.Location = New System.Drawing.Point(6, 116)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(61, 18)
        Me.lblDateTo.TabIndex = 3
        Me.lblDateTo.Text = "Date To"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFrom.Location = New System.Drawing.Point(7, 51)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(79, 18)
        Me.lblDateFrom.TabIndex = 2
        Me.lblDateFrom.Text = "Date From"
        '
        'DTPTo
        '
        Me.DTPTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.CustomFormat = "dd-MM-yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(0, 137)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(191, 26)
        Me.DTPTo.TabIndex = 1
        '
        'DTPFrom
        '
        Me.DTPFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.CustomFormat = "dd-MM-yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(2, 72)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(189, 26)
        Me.DTPFrom.TabIndex = 0
        '
        'DataGridViewReports
        '
        Me.DataGridViewReports.AllowUserToAddRows = False
        Me.DataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewReports.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewReports.Location = New System.Drawing.Point(242, 136)
        Me.DataGridViewReports.Name = "DataGridViewReports"
        Me.DataGridViewReports.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewReports.Size = New System.Drawing.Size(1147, 515)
        Me.DataGridViewReports.TabIndex = 5
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(18, 737)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(190, 42)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.Text = "Export Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.Location = New System.Drawing.Point(18, 681)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(190, 42)
        Me.btnPrintPreview.TabIndex = 4
        Me.btnPrintPreview.Text = "Print Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.Location = New System.Drawing.Point(18, 167)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(190, 42)
        Me.btnMonthly.TabIndex = 3
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        '
        'btnWeekly
        '
        Me.btnWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.Location = New System.Drawing.Point(18, 119)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(190, 42)
        Me.btnWeekly.TabIndex = 2
        Me.btnWeekly.Text = "Weekly"
        Me.btnWeekly.UseVisualStyleBackColor = False
        '
        'btnDaily
        '
        Me.btnDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaily.Location = New System.Drawing.Point(18, 71)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(190, 42)
        Me.btnDaily.TabIndex = 1
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(18, 23)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(190, 42)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.leftPanel.Controls.Add(Me.GroupBox2)
        Me.leftPanel.Controls.Add(Me.GroupBox1)
        Me.leftPanel.Controls.Add(Me.btnExcel)
        Me.leftPanel.Controls.Add(Me.btnPrintPreview)
        Me.leftPanel.Controls.Add(Me.btnMonthly)
        Me.leftPanel.Controls.Add(Me.btnWeekly)
        Me.leftPanel.Controls.Add(Me.btnDaily)
        Me.leftPanel.Controls.Add(Me.btnAll)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 50)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(236, 810)
        Me.leftPanel.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbFilterCourseYear)
        Me.GroupBox2.Controls.Add(Me.cbYear)
        Me.GroupBox2.Controls.Add(Me.cbCourse)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(18, 493)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 169)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTER BY COURSE && YEAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Course"
        '
        'cbFilterCourseYear
        '
        Me.cbFilterCourseYear.AutoSize = True
        Me.cbFilterCourseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilterCourseYear.Location = New System.Drawing.Point(3, 19)
        Me.cbFilterCourseYear.Name = "cbFilterCourseYear"
        Me.cbFilterCourseYear.Size = New System.Drawing.Size(69, 20)
        Me.cbFilterCourseYear.TabIndex = 6
        Me.cbFilterCourseYear.Text = "Check"
        Me.cbFilterCourseYear.UseVisualStyleBackColor = True
        '
        'cbYear
        '
        Me.cbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbYear.Location = New System.Drawing.Point(0, 131)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(190, 28)
        Me.cbYear.Sorted = True
        Me.cbYear.TabIndex = 1
        Me.cbYear.Text = "YEAR"
        '
        'cbCourse
        '
        Me.cbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Items.AddRange(New Object() {"BEEd", "BSA", "BSMA", "BSTM", "BSE-CE", "BSE-SE", "BSCrim", "BSIT", "BSEMC", "BSN", "BSP", "BSA", "BSBio", "BSPsych", "BSSW"})
        Me.cbCourse.Location = New System.Drawing.Point(0, 66)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(190, 28)
        Me.cbCourse.TabIndex = 0
        Me.cbCourse.Text = "COURSE"
        '
        'lblReports
        '
        Me.lblReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.ForeColor = System.Drawing.Color.White
        Me.lblReports.Location = New System.Drawing.Point(0, 0)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(1433, 50)
        Me.lblReports.TabIndex = 7
        Me.lblReports.Text = "GENERATE REPORTS"
        Me.lblReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(853, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 25)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "FILTER:"
        '
        'cmbFilterReport
        '
        Me.cmbFilterReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilterReport.FormattingEnabled = True
        Me.cmbFilterReport.Items.AddRange(New Object() {"No Filter", "On Queue", "Needs Verification", "Done"})
        Me.cmbFilterReport.Location = New System.Drawing.Point(949, 102)
        Me.cmbFilterReport.Name = "cmbFilterReport"
        Me.cmbFilterReport.Size = New System.Drawing.Size(216, 28)
        Me.cmbFilterReport.TabIndex = 37
        Me.cmbFilterReport.Text = "No Filter"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'lblFilterInfo
        '
        Me.lblFilterInfo.AutoSize = True
        Me.lblFilterInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterInfo.Location = New System.Drawing.Point(261, 663)
        Me.lblFilterInfo.Name = "lblFilterInfo"
        Me.lblFilterInfo.Size = New System.Drawing.Size(97, 24)
        Me.lblFilterInfo.TabIndex = 39
        Me.lblFilterInfo.Text = "Showing:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(266, 106)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(75, 24)
        Me.lblSearch.TabIndex = 8
        Me.lblSearch.Text = "Search:"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSearchReport
        '
        Me.txtSearchReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchReport.Location = New System.Drawing.Point(347, 101)
        Me.txtSearchReport.Name = "txtSearchReport"
        Me.txtSearchReport.Size = New System.Drawing.Size(495, 29)
        Me.txtSearchReport.TabIndex = 9
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1433, 860)
        Me.Controls.Add(Me.lblFilterInfo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbFilterReport)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearchReport)
        Me.Controls.Add(Me.DataGridViewReports)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.lblReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.leftPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocumentAudit As Printing.PrintDocument
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDateTo As Label
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents DTPTo As DateTimePicker
    Friend WithEvents DTPFrom As DateTimePicker
    Friend WithEvents DataGridViewReports As DataGridView
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents btnMonthly As Button
    Friend WithEvents btnWeekly As Button
    Friend WithEvents btnDaily As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents leftPanel As Panel
    Friend WithEvents lblReports As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbFilterReport As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents lblFilterInfo As Label
    Friend WithEvents cbFilterDate As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFilterCourseYear As CheckBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchReport As TextBox
End Class
