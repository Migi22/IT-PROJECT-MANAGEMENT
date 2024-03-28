<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frontID
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.picIDFormat = New System.Windows.Forms.PictureBox()
        Me.picStudentPic = New System.Windows.Forms.PictureBox()
        Me.lblTitleStudentNum = New System.Windows.Forms.Label()
        Me.lblFMname = New System.Windows.Forms.Label()
        Me.lblTitleCourseYear = New System.Windows.Forms.Label()
        Me.lblInputCourseYear = New System.Windows.Forms.Label()
        Me.lblInputStudentNum = New System.Windows.Forms.Label()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.lblInputLastName = New System.Windows.Forms.Label()
        CType(Me.picIDFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'picIDFormat
        '
        Me.picIDFormat.BackColor = System.Drawing.Color.Transparent
        Me.picIDFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picIDFormat.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.Green_Simple_Medical_ID_Card
        Me.picIDFormat.Location = New System.Drawing.Point(0, 0)
        Me.picIDFormat.Name = "picIDFormat"
        Me.picIDFormat.Size = New System.Drawing.Size(330, 532)
        Me.picIDFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIDFormat.TabIndex = 0
        Me.picIDFormat.TabStop = False
        '
        'picStudentPic
        '
        Me.picStudentPic.Cursor = System.Windows.Forms.Cursors.Default
        Me.picStudentPic.Location = New System.Drawing.Point(79, 141)
        Me.picStudentPic.Name = "picStudentPic"
        Me.picStudentPic.Size = New System.Drawing.Size(173, 172)
        Me.picStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPic.TabIndex = 3
        Me.picStudentPic.TabStop = False
        '
        'lblTitleStudentNum
        '
        Me.lblTitleStudentNum.AutoSize = True
        Me.lblTitleStudentNum.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleStudentNum.Location = New System.Drawing.Point(88, 431)
        Me.lblTitleStudentNum.Name = "lblTitleStudentNum"
        Me.lblTitleStudentNum.Size = New System.Drawing.Size(149, 16)
        Me.lblTitleStudentNum.TabIndex = 11
        Me.lblTitleStudentNum.Text = "STUDENT NUMBER"
        Me.lblTitleStudentNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFMname
        '
        Me.lblFMname.BackColor = System.Drawing.Color.Transparent
        Me.lblFMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFMname.Location = New System.Drawing.Point(12, 315)
        Me.lblFMname.Name = "lblFMname"
        Me.lblFMname.Size = New System.Drawing.Size(306, 31)
        Me.lblFMname.TabIndex = 12
        Me.lblFMname.Text = "First Name && Middle"
        Me.lblFMname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleCourseYear
        '
        Me.lblTitleCourseYear.AutoSize = True
        Me.lblTitleCourseYear.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleCourseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCourseYear.Location = New System.Drawing.Point(76, 388)
        Me.lblTitleCourseYear.Name = "lblTitleCourseYear"
        Me.lblTitleCourseYear.Size = New System.Drawing.Size(179, 16)
        Me.lblTitleCourseYear.TabIndex = 13
        Me.lblTitleCourseYear.Text = "COURSE && YEAR LEVEL"
        Me.lblTitleCourseYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInputCourseYear
        '
        Me.lblInputCourseYear.AutoSize = True
        Me.lblInputCourseYear.BackColor = System.Drawing.Color.Transparent
        Me.lblInputCourseYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputCourseYear.Location = New System.Drawing.Point(129, 408)
        Me.lblInputCourseYear.Name = "lblInputCourseYear"
        Me.lblInputCourseYear.Size = New System.Drawing.Size(62, 16)
        Me.lblInputCourseYear.TabIndex = 14
        Me.lblInputCourseYear.Text = "BSIT - 3"
        Me.lblInputCourseYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInputStudentNum
        '
        Me.lblInputStudentNum.AutoSize = True
        Me.lblInputStudentNum.BackColor = System.Drawing.Color.Transparent
        Me.lblInputStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputStudentNum.Location = New System.Drawing.Point(134, 453)
        Me.lblInputStudentNum.Name = "lblInputStudentNum"
        Me.lblInputStudentNum.Size = New System.Drawing.Size(55, 16)
        Me.lblInputStudentNum.TabIndex = 15
        Me.lblInputStudentNum.Text = "000000"
        Me.lblInputStudentNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBarcode
        '
        Me.picBarcode.BackColor = System.Drawing.Color.Transparent
        Me.picBarcode.Location = New System.Drawing.Point(27, 472)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(271, 34)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBarcode.TabIndex = 16
        Me.picBarcode.TabStop = False
        '
        'lblInputLastName
        '
        Me.lblInputLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblInputLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputLastName.Location = New System.Drawing.Point(12, 348)
        Me.lblInputLastName.Name = "lblInputLastName"
        Me.lblInputLastName.Size = New System.Drawing.Size(306, 31)
        Me.lblInputLastName.TabIndex = 17
        Me.lblInputLastName.Text = "Last Name"
        Me.lblInputLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frontID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 532)
        Me.Controls.Add(Me.lblInputLastName)
        Me.Controls.Add(Me.picBarcode)
        Me.Controls.Add(Me.lblInputStudentNum)
        Me.Controls.Add(Me.lblInputCourseYear)
        Me.Controls.Add(Me.lblTitleCourseYear)
        Me.Controls.Add(Me.lblFMname)
        Me.Controls.Add(Me.lblTitleStudentNum)
        Me.Controls.Add(Me.picStudentPic)
        Me.Controls.Add(Me.picIDFormat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frontID"
        Me.Text = "frontID"
        CType(Me.picIDFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents picIDFormat As PictureBox
    Friend WithEvents picStudentPic As PictureBox
    Friend WithEvents lblTitleStudentNum As Label
    Friend WithEvents lblFMname As Label
    Friend WithEvents lblTitleCourseYear As Label
    Friend WithEvents lblInputCourseYear As Label
    Friend WithEvents lblInputStudentNum As Label
    Friend WithEvents picBarcode As PictureBox
    Friend WithEvents lblInputLastName As Label
End Class
