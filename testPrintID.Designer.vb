<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class testPrintID
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
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblStudentNum = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.picStudentPic = New System.Windows.Forms.PictureBox()
        Me.picIDFormat = New System.Windows.Forms.PictureBox()
        Me.panelFrontID = New System.Windows.Forms.Panel()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIDFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFrontID.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStudentNum
        '
        Me.txtStudentNum.BackColor = System.Drawing.SystemColors.Control
        Me.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.Location = New System.Drawing.Point(348, 721)
        Me.txtStudentNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.ReadOnly = True
        Me.txtStudentNum.Size = New System.Drawing.Size(296, 19)
        Me.txtStudentNum.TabIndex = 8
        Me.txtStudentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(327, 797)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(344, 19)
        Me.txtName.TabIndex = 9
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStudentNum
        '
        Me.lblStudentNum.AutoSize = True
        Me.lblStudentNum.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNum.Location = New System.Drawing.Point(395, 673)
        Me.lblStudentNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentNum.Name = "lblStudentNum"
        Me.lblStudentNum.Size = New System.Drawing.Size(205, 24)
        Me.lblStudentNum.TabIndex = 6
        Me.lblStudentNum.Text = "STUDENT NUMBER:"
        Me.lblStudentNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(455, 755)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 24)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "NAME:"
        '
        'PrintDocument1
        '
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(88, 1162)
        Me.picBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(728, 108)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBarcode.TabIndex = 4
        Me.picBarcode.TabStop = False
        '
        'picStudentPic
        '
        Me.picStudentPic.Cursor = System.Windows.Forms.Cursors.Default
        Me.picStudentPic.Location = New System.Drawing.Point(81, 221)
        Me.picStudentPic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picStudentPic.Name = "picStudentPic"
        Me.picStudentPic.Size = New System.Drawing.Size(317, 258)
        Me.picStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPic.TabIndex = 3
        Me.picStudentPic.TabStop = False
        '
        'picIDFormat
        '
        Me.picIDFormat.BackColor = System.Drawing.Color.Transparent
        Me.picIDFormat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picIDFormat.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.Green_Simple_Medical_ID_Card
        Me.picIDFormat.Location = New System.Drawing.Point(0, 0)
        Me.picIDFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picIDFormat.Name = "picIDFormat"
        Me.picIDFormat.Size = New System.Drawing.Size(491, 818)
        Me.picIDFormat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIDFormat.TabIndex = 0
        Me.picIDFormat.TabStop = False
        '
        'panelFrontID
        '
        Me.panelFrontID.Controls.Add(Me.picStudentPic)
        Me.panelFrontID.Controls.Add(Me.picIDFormat)
        Me.panelFrontID.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelFrontID.Location = New System.Drawing.Point(0, 0)
        Me.panelFrontID.Name = "panelFrontID"
        Me.panelFrontID.Size = New System.Drawing.Size(491, 818)
        Me.panelFrontID.TabIndex = 10
        '
        'testPrintID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 818)
        Me.Controls.Add(Me.panelFrontID)
        Me.Controls.Add(Me.txtStudentNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStudentNum)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picBarcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "testPrintID"
        Me.Text = "testPrintID"
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIDFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFrontID.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblStudentNum As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents picBarcode As PictureBox
    Friend WithEvents picStudentPic As PictureBox
    Friend WithEvents picIDFormat As PictureBox
    Friend WithEvents panelFrontID As Panel
End Class
