<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIDCard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picStudentPic = New System.Windows.Forms.PictureBox()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStudentNum = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "identification card"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 445)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 5)
        Me.Panel1.TabIndex = 1
        '
        'picStudentPic
        '
        Me.picStudentPic.Cursor = System.Windows.Forms.Cursors.Default
        Me.picStudentPic.Location = New System.Drawing.Point(21, 139)
        Me.picStudentPic.Name = "picStudentPic"
        Me.picStudentPic.Size = New System.Drawing.Size(162, 143)
        Me.picStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudentPic.TabIndex = 2
        Me.picStudentPic.TabStop = False
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(166, 368)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(485, 70)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBarcode.TabIndex = 3
        Me.picBarcode.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(190, 139)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 24)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "NAME:"
        '
        'lblStudentNum
        '
        Me.lblStudentNum.AutoSize = True
        Me.lblStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNum.Location = New System.Drawing.Point(190, 199)
        Me.lblStudentNum.Name = "lblStudentNum"
        Me.lblStudentNum.Size = New System.Drawing.Size(205, 24)
        Me.lblStudentNum.TabIndex = 4
        Me.lblStudentNum.Text = "STUDENT NUMBER:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(272, 137)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(229, 19)
        Me.txtName.TabIndex = 5
        '
        'txtStudentNum
        '
        Me.txtStudentNum.BackColor = System.Drawing.SystemColors.Control
        Me.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.Location = New System.Drawing.Point(401, 197)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.ReadOnly = True
        Me.txtStudentNum.Size = New System.Drawing.Size(197, 19)
        Me.txtStudentNum.TabIndex = 5
        '
        'PrintDocument1
        '
        '
        'FormIDCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 450)
        Me.Controls.Add(Me.txtStudentNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStudentNum)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picBarcode)
        Me.Controls.Add(Me.picStudentPic)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormIDCard"
        Me.Text = "FormIDCard"
        CType(Me.picStudentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picStudentPic As PictureBox
    Friend WithEvents picBarcode As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblStudentNum As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
