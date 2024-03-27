<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAuditLog = New System.Windows.Forms.Label()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.DataGridViewAudits = New System.Windows.Forms.DataGridView()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchAudit = New System.Windows.Forms.TextBox()
        Me.PrintDocumentAudit = New System.Drawing.Printing.PrintDocument()
        Me.leftPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewAudits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAuditLog
        '
        Me.lblAuditLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblAuditLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAuditLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuditLog.ForeColor = System.Drawing.Color.White
        Me.lblAuditLog.Location = New System.Drawing.Point(0, 0)
        Me.lblAuditLog.Name = "lblAuditLog"
        Me.lblAuditLog.Size = New System.Drawing.Size(1156, 50)
        Me.lblAuditLog.TabIndex = 1
        Me.lblAuditLog.Text = "AUDIT LOGS"
        Me.lblAuditLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
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
        Me.leftPanel.Size = New System.Drawing.Size(191, 589)
        Me.leftPanel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.lblDateTo)
        Me.GroupBox1.Controls.Add(Me.lblDateFrom)
        Me.GroupBox1.Controls.Add(Me.DTPTo)
        Me.GroupBox1.Controls.Add(Me.DTPFrom)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 202)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FLITER BY DATE"
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.Black
        Me.btnFilter.Location = New System.Drawing.Point(2, 159)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(152, 37)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.Location = New System.Drawing.Point(-1, 99)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(46, 13)
        Me.lblDateTo.TabIndex = 3
        Me.lblDateTo.Text = "Date To"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(-1, 33)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(56, 13)
        Me.lblDateFrom.TabIndex = 2
        Me.lblDateFrom.Text = "Date From"
        '
        'DTPTo
        '
        Me.DTPTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.CustomFormat = "dd-MM-yyyy"
        Me.DTPTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTo.Location = New System.Drawing.Point(-1, 115)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(155, 22)
        Me.DTPTo.TabIndex = 1
        '
        'DTPFrom
        '
        Me.DTPFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.CustomFormat = "dd-MM-yyyy"
        Me.DTPFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFrom.Location = New System.Drawing.Point(1, 49)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(153, 22)
        Me.DTPFrom.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.Location = New System.Drawing.Point(12, 496)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(155, 32)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.Text = "Export Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.Location = New System.Drawing.Point(12, 440)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(155, 32)
        Me.btnPrintPreview.TabIndex = 4
        Me.btnPrintPreview.Text = "Print Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.Location = New System.Drawing.Point(12, 131)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(155, 32)
        Me.btnMonthly.TabIndex = 3
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        '
        'btnWeekly
        '
        Me.btnWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.Location = New System.Drawing.Point(12, 93)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(155, 32)
        Me.btnWeekly.TabIndex = 2
        Me.btnWeekly.Text = "Weekly"
        Me.btnWeekly.UseVisualStyleBackColor = False
        '
        'btnDaily
        '
        Me.btnDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaily.Location = New System.Drawing.Point(12, 55)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(155, 32)
        Me.btnDaily.TabIndex = 1
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.Location = New System.Drawing.Point(12, 17)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(155, 32)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'DataGridViewAudits
        '
        Me.DataGridViewAudits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewAudits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAudits.Location = New System.Drawing.Point(220, 124)
        Me.DataGridViewAudits.Name = "DataGridViewAudits"
        Me.DataGridViewAudits.Size = New System.Drawing.Size(881, 515)
        Me.DataGridViewAudits.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(216, 94)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(80, 24)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Search: "
        '
        'txtSearchAudit
        '
        Me.txtSearchAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAudit.Location = New System.Drawing.Point(290, 89)
        Me.txtSearchAudit.Name = "txtSearchAudit"
        Me.txtSearchAudit.Size = New System.Drawing.Size(811, 29)
        Me.txtSearchAudit.TabIndex = 4
        '
        'PrintDocumentAudit
        '
        '
        'AuditLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 639)
        Me.Controls.Add(Me.txtSearchAudit)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.DataGridViewAudits)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.lblAuditLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AuditLog"
        Me.Text = " "
        Me.leftPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewAudits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAuditLog As Label
    Friend WithEvents leftPanel As Panel
    Friend WithEvents DataGridViewAudits As DataGridView
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearchAudit As TextBox
    Friend WithEvents btnAll As Button
    Friend WithEvents btnDaily As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents btnMonthly As Button
    Friend WithEvents btnWeekly As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTPTo As DateTimePicker
    Friend WithEvents DTPFrom As DateTimePicker
    Friend WithEvents lblDateTo As Label
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents PrintDocumentAudit As Printing.PrintDocument
End Class
