<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editSignature
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
        Me.txtSignature = New System.Windows.Forms.TextBox()
        Me.btnSaveSignature = New System.Windows.Forms.Button()
        Me.btnUpdateSignature = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSignature
        '
        Me.txtSignature.Location = New System.Drawing.Point(19, 339)
        Me.txtSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Size = New System.Drawing.Size(310, 26)
        Me.txtSignature.TabIndex = 40
        '
        'btnSaveSignature
        '
        Me.btnSaveSignature.Location = New System.Drawing.Point(19, 545)
        Me.btnSaveSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSaveSignature.Name = "btnSaveSignature"
        Me.btnSaveSignature.Size = New System.Drawing.Size(312, 74)
        Me.btnSaveSignature.TabIndex = 37
        Me.btnSaveSignature.Text = "Save Signature"
        Me.btnSaveSignature.UseVisualStyleBackColor = True
        '
        'btnUpdateSignature
        '
        Me.btnUpdateSignature.Location = New System.Drawing.Point(19, 462)
        Me.btnUpdateSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateSignature.Name = "btnUpdateSignature"
        Me.btnUpdateSignature.Size = New System.Drawing.Size(312, 74)
        Me.btnUpdateSignature.TabIndex = 38
        Me.btnUpdateSignature.Text = "Update Signature"
        Me.btnUpdateSignature.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(19, 379)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(312, 74)
        Me.btnBrowse.TabIndex = 39
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'picSignature
        '
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(19, 37)
        Me.picSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(311, 276)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 36
        Me.picSignature.TabStop = False
        '
        'editSignature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 657)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.btnSaveSignature)
        Me.Controls.Add(Me.btnUpdateSignature)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picSignature)
        Me.Name = "editSignature"
        Me.Text = "Edit Signature"
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSignature As TextBox
    Friend WithEvents btnSaveSignature As Button
    Friend WithEvents btnUpdateSignature As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picSignature As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
