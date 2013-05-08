<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bExit = New System.Windows.Forms.Button()
        Me.bNext = New System.Windows.Forms.Button()
        Me.resizeFontLabel = New System.Windows.Forms.Label()
        Me.resizeFontLabelAlt = New System.Windows.Forms.Label()
        Me.statusBarLabel = New System.Windows.Forms.Label()
        Me.resizeControlLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(321, 10)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(75, 23)
        Me.bExit.TabIndex = 0
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'bNext
        '
        Me.bNext.Location = New System.Drawing.Point(16, 10)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(75, 23)
        Me.bNext.TabIndex = 1
        Me.bNext.Text = "Next"
        Me.bNext.UseVisualStyleBackColor = True
        '
        'resizeFontLabel
        '
        Me.resizeFontLabel.BackColor = System.Drawing.Color.Cyan
        Me.resizeFontLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resizeFontLabel.Location = New System.Drawing.Point(12, 96)
        Me.resizeFontLabel.Name = "resizeFontLabel"
        Me.resizeFontLabel.Size = New System.Drawing.Size(384, 185)
        Me.resizeFontLabel.TabIndex = 2
        Me.resizeFontLabel.Text = "font label"
        '
        'resizeFontLabelAlt
        '
        Me.resizeFontLabelAlt.AutoSize = True
        Me.resizeFontLabelAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.resizeFontLabelAlt.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resizeFontLabelAlt.Location = New System.Drawing.Point(34, 53)
        Me.resizeFontLabelAlt.Name = "resizeFontLabelAlt"
        Me.resizeFontLabelAlt.Size = New System.Drawing.Size(70, 15)
        Me.resizeFontLabelAlt.TabIndex = 3
        Me.resizeFontLabelAlt.Text = "fontlabel alt"
        '
        'statusBarLabel
        '
        Me.statusBarLabel.AutoSize = True
        Me.statusBarLabel.BackColor = System.Drawing.Color.DimGray
        Me.statusBarLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusBarLabel.Location = New System.Drawing.Point(159, 371)
        Me.statusBarLabel.Name = "statusBarLabel"
        Me.statusBarLabel.Size = New System.Drawing.Size(61, 15)
        Me.statusBarLabel.TabIndex = 4
        Me.statusBarLabel.Text = "status bar"
        '
        'resizeControlLabel
        '
        Me.resizeControlLabel.AutoSize = True
        Me.resizeControlLabel.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.resizeControlLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resizeControlLabel.Location = New System.Drawing.Point(218, 53)
        Me.resizeControlLabel.Name = "resizeControlLabel"
        Me.resizeControlLabel.Size = New System.Drawing.Size(77, 23)
        Me.resizeControlLabel.TabIndex = 5
        Me.resizeControlLabel.Text = "control"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 395)
        Me.Controls.Add(Me.resizeControlLabel)
        Me.Controls.Add(Me.statusBarLabel)
        Me.Controls.Add(Me.resizeFontLabelAlt)
        Me.Controls.Add(Me.resizeFontLabel)
        Me.Controls.Add(Me.bNext)
        Me.Controls.Add(Me.bExit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents bNext As System.Windows.Forms.Button
    Friend WithEvents resizeFontLabel As System.Windows.Forms.Label
    Friend WithEvents resizeFontLabelAlt As System.Windows.Forms.Label
    Friend WithEvents statusBarLabel As System.Windows.Forms.Label
    Friend WithEvents resizeControlLabel As System.Windows.Forms.Label

End Class
