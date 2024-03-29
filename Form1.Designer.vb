<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentBday = New System.Windows.Forms.TextBox()
        Me.txtGuardianContNum = New System.Windows.Forms.TextBox()
        Me.txtStudentAddress = New System.Windows.Forms.TextBox()
        Me.txtGuardianName = New System.Windows.Forms.TextBox()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMi = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.lblStudentInfo = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblQueue = New System.Windows.Forms.Label()
        Me.txtQueueNum = New System.Windows.Forms.TextBox()
        Me.btnEditImage = New System.Windows.Forms.Button()
        Me.picStudentPic = New System.Windows.Forms.PictureBox()
        Me.btnPrintID = New System.Windows.Forms.Button()
        Me.cmbFilterSearch = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnNeedVerify = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 590)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 100
        Me.DataGridView1.Size = New System.Drawing.Size(1396, 356)
        Me.DataGridView1.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(378, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "STUDENT BIRTHDAY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(699, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "GUARDIAN CONTACT NUMBER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "STUDENT ADDRESS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(699, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "GUARDIAN NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "YEAR LEVEL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(378, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "COURSE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "LAST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "MI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "STUDENT NUMBER"
        '
        'txtStudentBday
        '
        Me.txtStudentBday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentBday.Location = New System.Drawing.Point(382, 114)
        Me.txtStudentBday.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStudentBday.Name = "txtStudentBday"
        Me.txtStudentBday.Size = New System.Drawing.Size(302, 26)
        Me.txtStudentBday.TabIndex = 12
        '
        'txtGuardianContNum
        '
        Me.txtGuardianContNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianContNum.Location = New System.Drawing.Point(703, 114)
        Me.txtGuardianContNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGuardianContNum.Name = "txtGuardianContNum"
        Me.txtGuardianContNum.Size = New System.Drawing.Size(302, 26)
        Me.txtGuardianContNum.TabIndex = 11
        '
        'txtStudentAddress
        '
        Me.txtStudentAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentAddress.Location = New System.Drawing.Point(45, 357)
        Me.txtStudentAddress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStudentAddress.Name = "txtStudentAddress"
        Me.txtStudentAddress.Size = New System.Drawing.Size(639, 26)
        Me.txtStudentAddress.TabIndex = 10
        '
        'txtGuardianName
        '
        Me.txtGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianName.Location = New System.Drawing.Point(703, 167)
        Me.txtGuardianName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.Size = New System.Drawing.Size(302, 26)
        Me.txtGuardianName.TabIndex = 9
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearLevel.Location = New System.Drawing.Point(382, 231)
        Me.txtYearLevel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.Size = New System.Drawing.Size(302, 26)
        Me.txtYearLevel.TabIndex = 8
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(382, 167)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(302, 26)
        Me.txtCourse.TabIndex = 7
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(46, 231)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(302, 26)
        Me.txtLname.TabIndex = 6
        '
        'txtMi
        '
        Me.txtMi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMi.Location = New System.Drawing.Point(382, 292)
        Me.txtMi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMi.Name = "txtMi"
        Me.txtMi.Size = New System.Drawing.Size(302, 26)
        Me.txtMi.TabIndex = 5
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(45, 292)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(302, 26)
        Me.txtFname.TabIndex = 13
        '
        'txtStudentNum
        '
        Me.txtStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.Location = New System.Drawing.Point(45, 167)
        Me.txtStudentNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(302, 26)
        Me.txtStudentNum.TabIndex = 4
        '
        'lblStudentInfo
        '
        Me.lblStudentInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblStudentInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentInfo.ForeColor = System.Drawing.Color.White
        Me.lblStudentInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblStudentInfo.Name = "lblStudentInfo"
        Me.lblStudentInfo.Size = New System.Drawing.Size(1505, 52)
        Me.lblStudentInfo.TabIndex = 25
        Me.lblStudentInfo.Text = "STUDENT INFORMATION"
        Me.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(45, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 46)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(135, 400)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 46)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(226, 400)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 46)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(150, 559)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(931, 26)
        Me.txtSearch.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(41, 494)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1400, 52)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "LISTT OF RECORDS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 560)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 25)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "SEARCH:"
        '
        'lblQueue
        '
        Me.lblQueue.AutoSize = True
        Me.lblQueue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueue.Location = New System.Drawing.Point(41, 92)
        Me.lblQueue.Name = "lblQueue"
        Me.lblQueue.Size = New System.Drawing.Size(141, 20)
        Me.lblQueue.TabIndex = 32
        Me.lblQueue.Text = "QUEUE NUMBER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtQueueNum
        '
        Me.txtQueueNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQueueNum.Location = New System.Drawing.Point(46, 114)
        Me.txtQueueNum.Name = "txtQueueNum"
        Me.txtQueueNum.ReadOnly = True
        Me.txtQueueNum.Size = New System.Drawing.Size(301, 26)
        Me.txtQueueNum.TabIndex = 33
        '
        'btnEditImage
        '
        Me.btnEditImage.Location = New System.Drawing.Point(862, 323)
        Me.btnEditImage.Name = "btnEditImage"
        Me.btnEditImage.Size = New System.Drawing.Size(85, 46)
        Me.btnEditImage.TabIndex = 26
        Me.btnEditImage.Text = "Edit Image"
        Me.btnEditImage.UseVisualStyleBackColor = True
        '
        'picStudentPic
        '
        Me.picStudentPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudentPic.Location = New System.Drawing.Point(703, 231)
        Me.picStudentPic.Name = "picStudentPic"
        Me.picStudentPic.Size = New System.Drawing.Size(153, 138)
        Me.picStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPic.TabIndex = 27
        Me.picStudentPic.TabStop = False
        '
        'btnPrintID
        '
        Me.btnPrintID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintID.Location = New System.Drawing.Point(382, 400)
        Me.btnPrintID.Name = "btnPrintID"
        Me.btnPrintID.Size = New System.Drawing.Size(102, 46)
        Me.btnPrintID.TabIndex = 34
        Me.btnPrintID.Text = "PRINT ID"
        Me.btnPrintID.UseVisualStyleBackColor = False
        '
        'cmbFilterSearch
        '
        Me.cmbFilterSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilterSearch.FormattingEnabled = True
        Me.cmbFilterSearch.Items.AddRange(New Object() {"On Queue", "Needs Verification", "Done", "Full Name", "Student Number", "First Name", "Last Name", "Queue ID"})
        Me.cmbFilterSearch.Location = New System.Drawing.Point(1257, 557)
        Me.cmbFilterSearch.Name = "cmbFilterSearch"
        Me.cmbFilterSearch.Size = New System.Drawing.Size(184, 28)
        Me.cmbFilterSearch.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1161, 560)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 25)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "FILTER:"
        '
        'btnNeedVerify
        '
        Me.btnNeedVerify.BackColor = System.Drawing.Color.IndianRed
        Me.btnNeedVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNeedVerify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNeedVerify.Location = New System.Drawing.Point(504, 400)
        Me.btnNeedVerify.Name = "btnNeedVerify"
        Me.btnNeedVerify.Size = New System.Drawing.Size(101, 46)
        Me.btnNeedVerify.TabIndex = 37
        Me.btnNeedVerify.Text = "Needs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verification"
        Me.btnNeedVerify.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1505, 894)
        Me.Controls.Add(Me.btnNeedVerify)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbFilterSearch)
        Me.Controls.Add(Me.btnPrintID)
        Me.Controls.Add(Me.txtQueueNum)
        Me.Controls.Add(Me.lblQueue)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.picStudentPic)
        Me.Controls.Add(Me.btnEditImage)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStudentInfo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtStudentBday)
        Me.Controls.Add(Me.txtGuardianContNum)
        Me.Controls.Add(Me.txtStudentAddress)
        Me.Controls.Add(Me.txtGuardianName)
        Me.Controls.Add(Me.txtYearLevel)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtMi)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtStudentNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentBday As TextBox
    Friend WithEvents txtGuardianContNum As TextBox
    Friend WithEvents txtStudentAddress As TextBox
    Friend WithEvents txtGuardianName As TextBox
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtMi As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents lblStudentInfo As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents picStudentPic As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblQueue As Label
    Friend WithEvents txtQueueNum As TextBox
    Friend WithEvents btnEditImage As Button
    Friend WithEvents btnPrintID As Button
    Friend WithEvents cmbFilterSearch As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnNeedVerify As Button
End Class
