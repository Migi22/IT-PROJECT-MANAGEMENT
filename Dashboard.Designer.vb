<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.panelLeft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.Button6)
        Me.panelLeft.Controls.Add(Me.Button4)
        Me.panelLeft.Controls.Add(Me.Button3)
        Me.panelLeft.Controls.Add(Me.Button2)
        Me.panelLeft.Controls.Add(Me.btnHome)
        Me.panelLeft.Controls.Add(Me.PictureBox1)
        Me.panelLeft.Controls.Add(Me.Label1)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 5)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(268, 646)
        Me.panelLeft.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.icons8_opened_folder_24
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 601)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(268, 45)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "   Logout"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(268, 45)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "   Manage List"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(268, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "   Audit log"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(268, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "   Reports"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.icons8_opened_folder_24
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 183)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(268, 45)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "   Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.CREATE_READ_UPDATE_DELETE.My.Resources.Resources.jmc_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Processing System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 5)
        Me.Panel1.TabIndex = 3
        '
        'panelRight
        '
        Me.panelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRight.Location = New System.Drawing.Point(268, 5)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(1016, 646)
        Me.panelRight.TabIndex = 7
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 651)
        Me.Controls.Add(Me.panelRight)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelLeft.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLeft As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents panelRight As Panel
End Class
