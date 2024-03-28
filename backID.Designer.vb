<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backID
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
        Me.picBackIDFormat = New System.Windows.Forms.PictureBox()
        Me.lblInputBirthday = New System.Windows.Forms.Label()
        Me.lblTitleStudentSig = New System.Windows.Forms.Label()
        Me.lblGuardianName = New System.Windows.Forms.Label()
        Me.lblInputGuardianNum = New System.Windows.Forms.Label()
        Me.lblStudentAddress = New System.Windows.Forms.Label()
        Me.lblSchoolRegistar = New System.Windows.Forms.Label()
        Me.lblSchoolRegistarName = New System.Windows.Forms.Label()
        Me.lblFirstSem = New System.Windows.Forms.Label()
        Me.picSchoolLogo = New System.Windows.Forms.PictureBox()
        Me.picStudentSignature = New System.Windows.Forms.PictureBox()
        CType(Me.picBackIDFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSchoolLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudentSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackIDFormat
        '
        Me.picBackIDFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackIDFormat.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.backID
        Me.picBackIDFormat.Location = New System.Drawing.Point(0, 0)
        Me.picBackIDFormat.Name = "picBackIDFormat"
        Me.picBackIDFormat.Size = New System.Drawing.Size(330, 532)
        Me.picBackIDFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackIDFormat.TabIndex = 0
        Me.picBackIDFormat.TabStop = False
        '
        'lblInputBirthday
        '
        Me.lblInputBirthday.BackColor = System.Drawing.Color.Transparent
        Me.lblInputBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputBirthday.ForeColor = System.Drawing.Color.Black
        Me.lblInputBirthday.Location = New System.Drawing.Point(12, 28)
        Me.lblInputBirthday.Name = "lblInputBirthday"
        Me.lblInputBirthday.Size = New System.Drawing.Size(294, 23)
        Me.lblInputBirthday.TabIndex = 1
        Me.lblInputBirthday.Text = "BIRTHDAY: AUGUST 22 2002"
        Me.lblInputBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitleStudentSig
        '
        Me.lblTitleStudentSig.AutoSize = True
        Me.lblTitleStudentSig.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleStudentSig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleStudentSig.Location = New System.Drawing.Point(78, 136)
        Me.lblTitleStudentSig.Name = "lblTitleStudentSig"
        Me.lblTitleStudentSig.Size = New System.Drawing.Size(172, 16)
        Me.lblTitleStudentSig.TabIndex = 2
        Me.lblTitleStudentSig.Text = "STUDENT SIGNATURE"
        Me.lblTitleStudentSig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuardianName
        '
        Me.lblGuardianName.BackColor = System.Drawing.Color.Transparent
        Me.lblGuardianName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardianName.Location = New System.Drawing.Point(15, 189)
        Me.lblGuardianName.Name = "lblGuardianName"
        Me.lblGuardianName.Size = New System.Drawing.Size(291, 23)
        Me.lblGuardianName.TabIndex = 3
        Me.lblGuardianName.Text = """GUARDIAN NAME"""
        Me.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInputGuardianNum
        '
        Me.lblInputGuardianNum.BackColor = System.Drawing.Color.Transparent
        Me.lblInputGuardianNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputGuardianNum.Location = New System.Drawing.Point(93, 219)
        Me.lblInputGuardianNum.Name = "lblInputGuardianNum"
        Me.lblInputGuardianNum.Size = New System.Drawing.Size(133, 23)
        Me.lblInputGuardianNum.TabIndex = 4
        Me.lblInputGuardianNum.Text = "09000000001"
        Me.lblInputGuardianNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentAddress
        '
        Me.lblStudentAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentAddress.Location = New System.Drawing.Point(18, 256)
        Me.lblStudentAddress.Name = "lblStudentAddress"
        Me.lblStudentAddress.Size = New System.Drawing.Size(288, 58)
        Me.lblStudentAddress.TabIndex = 5
        Me.lblStudentAddress.Text = "Student Address"
        Me.lblStudentAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSchoolRegistar
        '
        Me.lblSchoolRegistar.AutoSize = True
        Me.lblSchoolRegistar.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolRegistar.Location = New System.Drawing.Point(122, 510)
        Me.lblSchoolRegistar.Name = "lblSchoolRegistar"
        Me.lblSchoolRegistar.Size = New System.Drawing.Size(82, 13)
        Me.lblSchoolRegistar.TabIndex = 6
        Me.lblSchoolRegistar.Text = "School Register"
        Me.lblSchoolRegistar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSchoolRegistarName
        '
        Me.lblSchoolRegistarName.AutoSize = True
        Me.lblSchoolRegistarName.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolRegistarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolRegistarName.Location = New System.Drawing.Point(53, 490)
        Me.lblSchoolRegistarName.Name = "lblSchoolRegistarName"
        Me.lblSchoolRegistarName.Size = New System.Drawing.Size(226, 18)
        Me.lblSchoolRegistarName.TabIndex = 7
        Me.lblSchoolRegistarName.Text = "MARK S. ALEMANIA, LPT, MAed"
        '
        'lblFirstSem
        '
        Me.lblFirstSem.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstSem.Location = New System.Drawing.Point(78, 351)
        Me.lblFirstSem.Name = "lblFirstSem"
        Me.lblFirstSem.Size = New System.Drawing.Size(223, 23)
        Me.lblFirstSem.TabIndex = 8
        Me.lblFirstSem.Text = "1ˢᵗ SEMESTER A.Y. 2023-2024"
        Me.lblFirstSem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picSchoolLogo
        '
        Me.picSchoolLogo.BackColor = System.Drawing.Color.Transparent
        Me.picSchoolLogo.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.jmc_logo
        Me.picSchoolLogo.Location = New System.Drawing.Point(56, 351)
        Me.picSchoolLogo.Name = "picSchoolLogo"
        Me.picSchoolLogo.Size = New System.Drawing.Size(25, 23)
        Me.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSchoolLogo.TabIndex = 9
        Me.picSchoolLogo.TabStop = False
        '
        'picStudentSignature
        '
        Me.picStudentSignature.BackColor = System.Drawing.Color.Transparent
        Me.picStudentSignature.Location = New System.Drawing.Point(81, 64)
        Me.picStudentSignature.Name = "picStudentSignature"
        Me.picStudentSignature.Size = New System.Drawing.Size(169, 69)
        Me.picStudentSignature.TabIndex = 10
        Me.picStudentSignature.TabStop = False
        '
        'backID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 532)
        Me.Controls.Add(Me.picStudentSignature)
        Me.Controls.Add(Me.picSchoolLogo)
        Me.Controls.Add(Me.lblFirstSem)
        Me.Controls.Add(Me.lblSchoolRegistarName)
        Me.Controls.Add(Me.lblSchoolRegistar)
        Me.Controls.Add(Me.lblStudentAddress)
        Me.Controls.Add(Me.lblInputGuardianNum)
        Me.Controls.Add(Me.lblGuardianName)
        Me.Controls.Add(Me.lblTitleStudentSig)
        Me.Controls.Add(Me.lblInputBirthday)
        Me.Controls.Add(Me.picBackIDFormat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backID"
        Me.Text = "backID"
        CType(Me.picBackIDFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSchoolLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudentSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackIDFormat As PictureBox
    Friend WithEvents lblInputBirthday As Label
    Friend WithEvents lblTitleStudentSig As Label
    Friend WithEvents lblGuardianName As Label
    Friend WithEvents lblInputGuardianNum As Label
    Friend WithEvents lblStudentAddress As Label
    Friend WithEvents lblSchoolRegistar As Label
    Friend WithEvents lblSchoolRegistarName As Label
    Friend WithEvents lblFirstSem As Label
    Friend WithEvents picSchoolLogo As PictureBox
    Friend WithEvents picStudentSignature As PictureBox
End Class
