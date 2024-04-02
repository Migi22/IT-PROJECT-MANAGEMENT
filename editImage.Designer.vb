<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editImage
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
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.btnDeleteProfile = New System.Windows.Forms.Button()
        Me.btnUpdateImage = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picBrowserPic = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picBrowserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(12, 232)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(208, 20)
        Me.txtPhoto.TabIndex = 35
        '
        'btnDeleteProfile
        '
        Me.btnDeleteProfile.Location = New System.Drawing.Point(12, 366)
        Me.btnDeleteProfile.Name = "btnDeleteProfile"
        Me.btnDeleteProfile.Size = New System.Drawing.Size(208, 48)
        Me.btnDeleteProfile.TabIndex = 32
        Me.btnDeleteProfile.Text = "Delete Profile"
        Me.btnDeleteProfile.UseVisualStyleBackColor = True
        '
        'btnUpdateImage
        '
        Me.btnUpdateImage.Location = New System.Drawing.Point(12, 312)
        Me.btnUpdateImage.Name = "btnUpdateImage"
        Me.btnUpdateImage.Size = New System.Drawing.Size(208, 48)
        Me.btnUpdateImage.TabIndex = 33
        Me.btnUpdateImage.Text = "Update Profile"
        Me.btnUpdateImage.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(12, 258)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(208, 48)
        Me.btnBrowse.TabIndex = 34
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'picBrowserPic
        '
        Me.picBrowserPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrowserPic.Location = New System.Drawing.Point(12, 36)
        Me.picBrowserPic.Name = "picBrowserPic"
        Me.picBrowserPic.Size = New System.Drawing.Size(208, 180)
        Me.picBrowserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrowserPic.TabIndex = 31
        Me.picBrowserPic.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'editImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 427)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.btnDeleteProfile)
        Me.Controls.Add(Me.btnUpdateImage)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picBrowserPic)
        Me.Name = "editImage"
        Me.Text = "Edit Image"
        CType(Me.picBrowserPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhoto As TextBox
    Friend WithEvents btnDeleteProfile As Button
    Friend WithEvents btnUpdateImage As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picBrowserPic As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
