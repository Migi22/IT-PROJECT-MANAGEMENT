<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print_ID_Options
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
        Me.lblPrint_Option = New System.Windows.Forms.Label()
        Me.btnPrintFront = New System.Windows.Forms.Button()
        Me.btnPrintBack = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.panelFrontID = New System.Windows.Forms.Panel()
        Me.lblInputStudentNum = New System.Windows.Forms.Label()
        Me.lblInputCourseYear = New System.Windows.Forms.Label()
        Me.lblTitleCourseYear = New System.Windows.Forms.Label()
        Me.lblTitleStudentNum = New System.Windows.Forms.Label()
        Me.lblInputLastName = New System.Windows.Forms.Label()
        Me.lblFMname = New System.Windows.Forms.Label()
        Me.panelBackID = New System.Windows.Forms.Panel()
        Me.lblFirstSem = New System.Windows.Forms.Label()
        Me.lblSchoolRegistarName = New System.Windows.Forms.Label()
        Me.lblSchoolRegistar = New System.Windows.Forms.Label()
        Me.lblStudentAddress = New System.Windows.Forms.Label()
        Me.lblInputGuardianNum = New System.Windows.Forms.Label()
        Me.lblGuardianName = New System.Windows.Forms.Label()
        Me.lblTitleStudentSig = New System.Windows.Forms.Label()
        Me.lblInputBirthday = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.picStudentSignature = New System.Windows.Forms.PictureBox()
        Me.picSchoolLogo = New System.Windows.Forms.PictureBox()
        Me.picBackIDFormat = New System.Windows.Forms.PictureBox()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.picStudentPic = New System.Windows.Forms.PictureBox()
        Me.picFrontIDFormat = New System.Windows.Forms.PictureBox()
        Me.panelFrontID.SuspendLayout()
        Me.panelBackID.SuspendLayout()
        CType(Me.picStudentSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSchoolLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackIDFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrontIDFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrint_Option
        '
        Me.lblPrint_Option.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblPrint_Option.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPrint_Option.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrint_Option.ForeColor = System.Drawing.Color.White
        Me.lblPrint_Option.Location = New System.Drawing.Point(0, 0)
        Me.lblPrint_Option.Name = "lblPrint_Option"
        Me.lblPrint_Option.Size = New System.Drawing.Size(1283, 50)
        Me.lblPrint_Option.TabIndex = 0
        Me.lblPrint_Option.Text = "PRINT ID OPTION"
        Me.lblPrint_Option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrintFront
        '
        Me.btnPrintFront.Location = New System.Drawing.Point(26, 638)
        Me.btnPrintFront.Name = "btnPrintFront"
        Me.btnPrintFront.Size = New System.Drawing.Size(114, 51)
        Me.btnPrintFront.TabIndex = 3
        Me.btnPrintFront.Text = "Print Front ID"
        Me.btnPrintFront.UseVisualStyleBackColor = True
        '
        'btnPrintBack
        '
        Me.btnPrintBack.Location = New System.Drawing.Point(146, 638)
        Me.btnPrintBack.Name = "btnPrintBack"
        Me.btnPrintBack.Size = New System.Drawing.Size(114, 51)
        Me.btnPrintBack.TabIndex = 4
        Me.btnPrintBack.Text = "Print Back ID"
        Me.btnPrintBack.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'panelFrontID
        '
        Me.panelFrontID.Controls.Add(Me.picBarcode)
        Me.panelFrontID.Controls.Add(Me.lblInputStudentNum)
        Me.panelFrontID.Controls.Add(Me.lblInputCourseYear)
        Me.panelFrontID.Controls.Add(Me.lblTitleCourseYear)
        Me.panelFrontID.Controls.Add(Me.lblTitleStudentNum)
        Me.panelFrontID.Controls.Add(Me.lblInputLastName)
        Me.panelFrontID.Controls.Add(Me.picStudentPic)
        Me.panelFrontID.Controls.Add(Me.lblFMname)
        Me.panelFrontID.Controls.Add(Me.picFrontIDFormat)
        Me.panelFrontID.Location = New System.Drawing.Point(40, 53)
        Me.panelFrontID.Name = "panelFrontID"
        Me.panelFrontID.Size = New System.Drawing.Size(330, 532)
        Me.panelFrontID.TabIndex = 36
        '
        'lblInputStudentNum
        '
        Me.lblInputStudentNum.AutoSize = True
        Me.lblInputStudentNum.BackColor = System.Drawing.Color.Transparent
        Me.lblInputStudentNum.Location = New System.Drawing.Point(141, 420)
        Me.lblInputStudentNum.Name = "lblInputStudentNum"
        Me.lblInputStudentNum.Size = New System.Drawing.Size(43, 13)
        Me.lblInputStudentNum.TabIndex = 43
        Me.lblInputStudentNum.Text = "000000"
        '
        'lblInputCourseYear
        '
        Me.lblInputCourseYear.AutoSize = True
        Me.lblInputCourseYear.BackColor = System.Drawing.Color.Transparent
        Me.lblInputCourseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputCourseYear.Location = New System.Drawing.Point(134, 380)
        Me.lblInputCourseYear.Name = "lblInputCourseYear"
        Me.lblInputCourseYear.Size = New System.Drawing.Size(62, 16)
        Me.lblInputCourseYear.TabIndex = 42
        Me.lblInputCourseYear.Text = "BSIT - 3"
        '
        'lblTitleCourseYear
        '
        Me.lblTitleCourseYear.AutoSize = True
        Me.lblTitleCourseYear.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleCourseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCourseYear.Location = New System.Drawing.Point(90, 360)
        Me.lblTitleCourseYear.Name = "lblTitleCourseYear"
        Me.lblTitleCourseYear.Size = New System.Drawing.Size(160, 16)
        Me.lblTitleCourseYear.TabIndex = 41
        Me.lblTitleCourseYear.Text = "COURSE && YEAR LEVEL"
        '
        'lblTitleStudentNum
        '
        Me.lblTitleStudentNum.AutoSize = True
        Me.lblTitleStudentNum.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleStudentNum.Location = New System.Drawing.Point(98, 400)
        Me.lblTitleStudentNum.Name = "lblTitleStudentNum"
        Me.lblTitleStudentNum.Size = New System.Drawing.Size(135, 16)
        Me.lblTitleStudentNum.TabIndex = 40
        Me.lblTitleStudentNum.Text = "STUDENT NUMBER"
        Me.lblTitleStudentNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInputLastName
        '
        Me.lblInputLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblInputLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputLastName.Location = New System.Drawing.Point(30, 324)
        Me.lblInputLastName.Name = "lblInputLastName"
        Me.lblInputLastName.Size = New System.Drawing.Size(282, 30)
        Me.lblInputLastName.TabIndex = 39
        Me.lblInputLastName.Text = "Label1"
        Me.lblInputLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFMname
        '
        Me.lblFMname.BackColor = System.Drawing.Color.Transparent
        Me.lblFMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFMname.Location = New System.Drawing.Point(28, 292)
        Me.lblFMname.Name = "lblFMname"
        Me.lblFMname.Size = New System.Drawing.Size(285, 23)
        Me.lblFMname.TabIndex = 37
        Me.lblFMname.Text = "First && Middle Name"
        Me.lblFMname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelBackID
        '
        Me.panelBackID.Controls.Add(Me.picStudentSignature)
        Me.panelBackID.Controls.Add(Me.picSchoolLogo)
        Me.panelBackID.Controls.Add(Me.lblFirstSem)
        Me.panelBackID.Controls.Add(Me.lblSchoolRegistarName)
        Me.panelBackID.Controls.Add(Me.lblSchoolRegistar)
        Me.panelBackID.Controls.Add(Me.lblStudentAddress)
        Me.panelBackID.Controls.Add(Me.lblInputGuardianNum)
        Me.panelBackID.Controls.Add(Me.lblGuardianName)
        Me.panelBackID.Controls.Add(Me.lblTitleStudentSig)
        Me.panelBackID.Controls.Add(Me.lblInputBirthday)
        Me.panelBackID.Controls.Add(Me.picBackIDFormat)
        Me.panelBackID.Location = New System.Drawing.Point(424, 53)
        Me.panelBackID.Name = "panelBackID"
        Me.panelBackID.Size = New System.Drawing.Size(330, 532)
        Me.panelBackID.TabIndex = 37
        '
        'lblFirstSem
        '
        Me.lblFirstSem.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstSem.Location = New System.Drawing.Point(78, 351)
        Me.lblFirstSem.Name = "lblFirstSem"
        Me.lblFirstSem.Size = New System.Drawing.Size(223, 23)
        Me.lblFirstSem.TabIndex = 19
        Me.lblFirstSem.Text = "1ˢᵗ SEMESTER A.Y. 2023-2024"
        Me.lblFirstSem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSchoolRegistarName
        '
        Me.lblSchoolRegistarName.AutoSize = True
        Me.lblSchoolRegistarName.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolRegistarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolRegistarName.Location = New System.Drawing.Point(53, 490)
        Me.lblSchoolRegistarName.Name = "lblSchoolRegistarName"
        Me.lblSchoolRegistarName.Size = New System.Drawing.Size(226, 18)
        Me.lblSchoolRegistarName.TabIndex = 18
        Me.lblSchoolRegistarName.Text = "MARK S. ALEMANIA, LPT, MAed"
        '
        'lblSchoolRegistar
        '
        Me.lblSchoolRegistar.AutoSize = True
        Me.lblSchoolRegistar.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolRegistar.Location = New System.Drawing.Point(122, 510)
        Me.lblSchoolRegistar.Name = "lblSchoolRegistar"
        Me.lblSchoolRegistar.Size = New System.Drawing.Size(82, 13)
        Me.lblSchoolRegistar.TabIndex = 17
        Me.lblSchoolRegistar.Text = "School Register"
        Me.lblSchoolRegistar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentAddress
        '
        Me.lblStudentAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentAddress.Location = New System.Drawing.Point(18, 256)
        Me.lblStudentAddress.Name = "lblStudentAddress"
        Me.lblStudentAddress.Size = New System.Drawing.Size(288, 58)
        Me.lblStudentAddress.TabIndex = 16
        Me.lblStudentAddress.Text = "Student Address"
        Me.lblStudentAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInputGuardianNum
        '
        Me.lblInputGuardianNum.BackColor = System.Drawing.Color.Transparent
        Me.lblInputGuardianNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputGuardianNum.Location = New System.Drawing.Point(93, 219)
        Me.lblInputGuardianNum.Name = "lblInputGuardianNum"
        Me.lblInputGuardianNum.Size = New System.Drawing.Size(133, 23)
        Me.lblInputGuardianNum.TabIndex = 15
        Me.lblInputGuardianNum.Text = "09000000001"
        Me.lblInputGuardianNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuardianName
        '
        Me.lblGuardianName.BackColor = System.Drawing.Color.Transparent
        Me.lblGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianName.Location = New System.Drawing.Point(15, 189)
        Me.lblGuardianName.Name = "lblGuardianName"
        Me.lblGuardianName.Size = New System.Drawing.Size(291, 23)
        Me.lblGuardianName.TabIndex = 14
        Me.lblGuardianName.Text = """GUARDIAN NAME"""
        Me.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleStudentSig
        '
        Me.lblTitleStudentSig.AutoSize = True
        Me.lblTitleStudentSig.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleStudentSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleStudentSig.Location = New System.Drawing.Point(78, 136)
        Me.lblTitleStudentSig.Name = "lblTitleStudentSig"
        Me.lblTitleStudentSig.Size = New System.Drawing.Size(172, 16)
        Me.lblTitleStudentSig.TabIndex = 13
        Me.lblTitleStudentSig.Text = "STUDENT SIGNATURE"
        Me.lblTitleStudentSig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInputBirthday
        '
        Me.lblInputBirthday.BackColor = System.Drawing.Color.Transparent
        Me.lblInputBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputBirthday.ForeColor = System.Drawing.Color.Black
        Me.lblInputBirthday.Location = New System.Drawing.Point(12, 28)
        Me.lblInputBirthday.Name = "lblInputBirthday"
        Me.lblInputBirthday.Size = New System.Drawing.Size(294, 23)
        Me.lblInputBirthday.TabIndex = 12
        Me.lblInputBirthday.Text = "BIRTHDAY: AUGUST 22 2002"
        Me.lblInputBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(424, 638)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(114, 51)
        Me.btnDone.TabIndex = 38
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'picStudentSignature
        '
        Me.picStudentSignature.BackColor = System.Drawing.Color.Transparent
        Me.picStudentSignature.Location = New System.Drawing.Point(81, 64)
        Me.picStudentSignature.Name = "picStudentSignature"
        Me.picStudentSignature.Size = New System.Drawing.Size(169, 69)
        Me.picStudentSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudentSignature.TabIndex = 21
        Me.picStudentSignature.TabStop = False
        '
        'picSchoolLogo
        '
        Me.picSchoolLogo.BackColor = System.Drawing.Color.Transparent
        Me.picSchoolLogo.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.jmc_logo
        Me.picSchoolLogo.Location = New System.Drawing.Point(56, 351)
        Me.picSchoolLogo.Name = "picSchoolLogo"
        Me.picSchoolLogo.Size = New System.Drawing.Size(25, 23)
        Me.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSchoolLogo.TabIndex = 20
        Me.picSchoolLogo.TabStop = False
        '
        'picBackIDFormat
        '
        Me.picBackIDFormat.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.backID
        Me.picBackIDFormat.Location = New System.Drawing.Point(0, 0)
        Me.picBackIDFormat.Name = "picBackIDFormat"
        Me.picBackIDFormat.Size = New System.Drawing.Size(330, 532)
        Me.picBackIDFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackIDFormat.TabIndex = 11
        Me.picBackIDFormat.TabStop = False
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(26, 437)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(278, 43)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBarcode.TabIndex = 44
        Me.picBarcode.TabStop = False
        '
        'picStudentPic
        '
        Me.picStudentPic.BackColor = System.Drawing.SystemColors.ControlLight
        Me.picStudentPic.Location = New System.Drawing.Point(73, 100)
        Me.picStudentPic.Name = "picStudentPic"
        Me.picStudentPic.Size = New System.Drawing.Size(186, 189)
        Me.picStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPic.TabIndex = 38
        Me.picStudentPic.TabStop = False
        '
        'picFrontIDFormat
        '
        Me.picFrontIDFormat.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.FrontIDJmc
        Me.picFrontIDFormat.Location = New System.Drawing.Point(0, 0)
        Me.picFrontIDFormat.Name = "picFrontIDFormat"
        Me.picFrontIDFormat.Size = New System.Drawing.Size(330, 532)
        Me.picFrontIDFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFrontIDFormat.TabIndex = 36
        Me.picFrontIDFormat.TabStop = False
        '
        'Print_ID_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 726)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.panelBackID)
        Me.Controls.Add(Me.panelFrontID)
        Me.Controls.Add(Me.btnPrintBack)
        Me.Controls.Add(Me.btnPrintFront)
        Me.Controls.Add(Me.lblPrint_Option)
        Me.Name = "Print_ID_Options"
        Me.Text = "Print_ID_Options"
        Me.panelFrontID.ResumeLayout(False)
        Me.panelFrontID.PerformLayout()
        Me.panelBackID.ResumeLayout(False)
        Me.panelBackID.PerformLayout()
        CType(Me.picStudentSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSchoolLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackIDFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrontIDFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrint_Option As Label
    Friend WithEvents btnPrintFront As Button
    Friend WithEvents btnPrintBack As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents panelFrontID As Panel
    Friend WithEvents picBarcode As PictureBox
    Friend WithEvents lblInputStudentNum As Label
    Friend WithEvents lblInputCourseYear As Label
    Friend WithEvents lblTitleCourseYear As Label
    Friend WithEvents lblTitleStudentNum As Label
    Friend WithEvents lblInputLastName As Label
    Friend WithEvents picStudentPic As PictureBox
    Friend WithEvents lblFMname As Label
    Friend WithEvents picFrontIDFormat As PictureBox
    Friend WithEvents panelBackID As Panel
    Friend WithEvents picStudentSignature As PictureBox
    Friend WithEvents picSchoolLogo As PictureBox
    Friend WithEvents lblFirstSem As Label
    Friend WithEvents lblSchoolRegistarName As Label
    Friend WithEvents lblSchoolRegistar As Label
    Friend WithEvents lblStudentAddress As Label
    Friend WithEvents lblInputGuardianNum As Label
    Friend WithEvents lblGuardianName As Label
    Friend WithEvents lblTitleStudentSig As Label
    Friend WithEvents lblInputBirthday As Label
    Friend WithEvents picBackIDFormat As PictureBox
    Friend WithEvents btnDone As Button
End Class
