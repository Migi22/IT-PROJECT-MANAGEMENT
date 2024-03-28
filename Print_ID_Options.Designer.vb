<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_ID_Options
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
        Me.lblPrint_Option = New System.Windows.Forms.Label()
        Me.panelFrontID = New System.Windows.Forms.Panel()
        Me.panelBackID = New System.Windows.Forms.Panel()
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
        'panelFrontID
        '
        Me.panelFrontID.Location = New System.Drawing.Point(26, 53)
        Me.panelFrontID.Name = "panelFrontID"
        Me.panelFrontID.Size = New System.Drawing.Size(374, 559)
        Me.panelFrontID.TabIndex = 1
        '
        'panelBackID
        '
        Me.panelBackID.Location = New System.Drawing.Point(422, 53)
        Me.panelBackID.Name = "panelBackID"
        Me.panelBackID.Size = New System.Drawing.Size(374, 559)
        Me.panelBackID.TabIndex = 2
        '
        'Print_ID_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 726)
        Me.Controls.Add(Me.panelBackID)
        Me.Controls.Add(Me.panelFrontID)
        Me.Controls.Add(Me.lblPrint_Option)
        Me.Name = "Print_ID_Options"
        Me.Text = "Print_ID_Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrint_Option As Label
    Friend WithEvents panelFrontID As Panel
    Friend WithEvents panelBackID As Panel
End Class
