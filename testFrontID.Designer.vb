<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testFrontID
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.lblInputStudentNum = New System.Windows.Forms.Label()
        Me.lblTitleStudentNum = New System.Windows.Forms.Label()
        Me.lblTitleCourseYear = New System.Windows.Forms.Label()
        Me.lblInputCourseYear = New System.Windows.Forms.Label()
        Me.lblInputLastName = New System.Windows.Forms.Label()
        Me.lblFMname = New System.Windows.Forms.Label()
        Me.picStudentPic = New System.Windows.Forms.PictureBox()
        Me.picIDFormat = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIDFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picBarcode)
        Me.Panel1.Controls.Add(Me.lblInputStudentNum)
        Me.Panel1.Controls.Add(Me.lblTitleStudentNum)
        Me.Panel1.Controls.Add(Me.lblTitleCourseYear)
        Me.Panel1.Controls.Add(Me.lblInputCourseYear)
        Me.Panel1.Controls.Add(Me.lblInputLastName)
        Me.Panel1.Controls.Add(Me.lblFMname)
        Me.Panel1.Controls.Add(Me.picStudentPic)
        Me.Panel1.Controls.Add(Me.picIDFormat)
        Me.Panel1.Location = New System.Drawing.Point(66, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 532)
        Me.Panel1.TabIndex = 0
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(49, 451)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(245, 50)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBarcode.TabIndex = 8
        Me.picBarcode.TabStop = False
        '
        'lblInputStudentNum
        '
        Me.lblInputStudentNum.AutoSize = True
        Me.lblInputStudentNum.Location = New System.Drawing.Point(176, 435)
        Me.lblInputStudentNum.Name = "lblInputStudentNum"
        Me.lblInputStudentNum.Size = New System.Drawing.Size(39, 13)
        Me.lblInputStudentNum.TabIndex = 7
        Me.lblInputStudentNum.Text = "Label2"
        '
        'lblTitleStudentNum
        '
        Me.lblTitleStudentNum.AutoSize = True
        Me.lblTitleStudentNum.Location = New System.Drawing.Point(131, 421)
        Me.lblTitleStudentNum.Name = "lblTitleStudentNum"
        Me.lblTitleStudentNum.Size = New System.Drawing.Size(39, 13)
        Me.lblTitleStudentNum.TabIndex = 6
        Me.lblTitleStudentNum.Text = "Label1"
        '
        'lblTitleCourseYear
        '
        Me.lblTitleCourseYear.AutoSize = True
        Me.lblTitleCourseYear.Location = New System.Drawing.Point(141, 395)
        Me.lblTitleCourseYear.Name = "lblTitleCourseYear"
        Me.lblTitleCourseYear.Size = New System.Drawing.Size(39, 13)
        Me.lblTitleCourseYear.TabIndex = 5
        Me.lblTitleCourseYear.Text = "Label2"
        '
        'lblInputCourseYear
        '
        Me.lblInputCourseYear.AutoSize = True
        Me.lblInputCourseYear.Location = New System.Drawing.Point(131, 364)
        Me.lblInputCourseYear.Name = "lblInputCourseYear"
        Me.lblInputCourseYear.Size = New System.Drawing.Size(39, 13)
        Me.lblInputCourseYear.TabIndex = 4
        Me.lblInputCourseYear.Text = "Label1"
        '
        'lblInputLastName
        '
        Me.lblInputLastName.AutoSize = True
        Me.lblInputLastName.Location = New System.Drawing.Point(116, 343)
        Me.lblInputLastName.Name = "lblInputLastName"
        Me.lblInputLastName.Size = New System.Drawing.Size(39, 13)
        Me.lblInputLastName.TabIndex = 3
        Me.lblInputLastName.Text = "Label2"
        '
        'lblFMname
        '
        Me.lblFMname.AutoSize = True
        Me.lblFMname.Location = New System.Drawing.Point(116, 321)
        Me.lblFMname.Name = "lblFMname"
        Me.lblFMname.Size = New System.Drawing.Size(39, 13)
        Me.lblFMname.TabIndex = 2
        Me.lblFMname.Text = "Label1"
        '
        'picStudentPic
        '
        Me.picStudentPic.Location = New System.Drawing.Point(74, 149)
        Me.picStudentPic.Name = "picStudentPic"
        Me.picStudentPic.Size = New System.Drawing.Size(179, 169)
        Me.picStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPic.TabIndex = 1
        Me.picStudentPic.TabStop = False
        '
        'picIDFormat
        '
        Me.picIDFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picIDFormat.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.Green_Simple_Medical_ID_Card
        Me.picIDFormat.Location = New System.Drawing.Point(0, 0)
        Me.picIDFormat.Name = "picIDFormat"
        Me.picIDFormat.Size = New System.Drawing.Size(330, 532)
        Me.picIDFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIDFormat.TabIndex = 0
        Me.picIDFormat.TabStop = False
        '
        'PrintDocument1
        '
        '
        'testFrontID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "testFrontID"
        Me.Text = "testFrontID"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIDFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picIDFormat As PictureBox
    Friend WithEvents picStudentPic As PictureBox
    Friend WithEvents lblInputLastName As Label
    Friend WithEvents lblFMname As Label
    Friend WithEvents lblTitleCourseYear As Label
    Friend WithEvents lblInputCourseYear As Label
    Friend WithEvents lblInputStudentNum As Label
    Friend WithEvents lblTitleStudentNum As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents picBarcode As PictureBox
End Class
