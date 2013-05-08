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
        Me.localGreetingLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.italyFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.norwayFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.usaFlagPictureBox_ = New System.Windows.Forms.PictureBox()
        Me.localScenePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.italyFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.norwayFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usaFlagPictureBox_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.localScenePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'localGreetingLabel
        '
        Me.localGreetingLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.localGreetingLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.localGreetingLabel.Location = New System.Drawing.Point(36, 13)
        Me.localGreetingLabel.Name = "localGreetingLabel"
        Me.localGreetingLabel.Size = New System.Drawing.Size(237, 133)
        Me.localGreetingLabel.TabIndex = 0
        Me.localGreetingLabel.Text = "God Dag"
        Me.localGreetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.exitButton.Location = New System.Drawing.Point(573, 236)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 37)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Forlate"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'italyFlagPictureBox
        '
        Me.italyFlagPictureBox.Image = Global.CS540_Assign10.My.Resources.Resources.Italian_flag
        Me.italyFlagPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.italyFlagPictureBox.Location = New System.Drawing.Point(384, 207)
        Me.italyFlagPictureBox.Name = "italyFlagPictureBox"
        Me.italyFlagPictureBox.Size = New System.Drawing.Size(142, 66)
        Me.italyFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.italyFlagPictureBox.TabIndex = 5
        Me.italyFlagPictureBox.TabStop = False
        '
        'norwayFlagPictureBox
        '
        Me.norwayFlagPictureBox.Image = Global.CS540_Assign10.My.Resources.Resources.norwayflag
        Me.norwayFlagPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.norwayFlagPictureBox.Location = New System.Drawing.Point(210, 207)
        Me.norwayFlagPictureBox.Name = "norwayFlagPictureBox"
        Me.norwayFlagPictureBox.Size = New System.Drawing.Size(142, 66)
        Me.norwayFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.norwayFlagPictureBox.TabIndex = 4
        Me.norwayFlagPictureBox.TabStop = False
        '
        'usaFlagPictureBox_
        '
        Me.usaFlagPictureBox_.Image = Global.CS540_Assign10.My.Resources.Resources.usflag
        Me.usaFlagPictureBox_.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.usaFlagPictureBox_.Location = New System.Drawing.Point(39, 207)
        Me.usaFlagPictureBox_.Name = "usaFlagPictureBox_"
        Me.usaFlagPictureBox_.Size = New System.Drawing.Size(142, 66)
        Me.usaFlagPictureBox_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usaFlagPictureBox_.TabIndex = 3
        Me.usaFlagPictureBox_.TabStop = False
        '
        'localScenePictureBox
        '
        Me.localScenePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.localScenePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.localScenePictureBox.Location = New System.Drawing.Point(324, 13)
        Me.localScenePictureBox.Name = "localScenePictureBox"
        Me.localScenePictureBox.Size = New System.Drawing.Size(250, 133)
        Me.localScenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.localScenePictureBox.TabIndex = 1
        Me.localScenePictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 312)
        Me.Controls.Add(Me.italyFlagPictureBox)
        Me.Controls.Add(Me.norwayFlagPictureBox)
        Me.Controls.Add(Me.usaFlagPictureBox_)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.localScenePictureBox)
        Me.Controls.Add(Me.localGreetingLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.italyFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.norwayFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usaFlagPictureBox_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.localScenePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents localGreetingLabel As System.Windows.Forms.Label
    Friend WithEvents localScenePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents usaFlagPictureBox_ As System.Windows.Forms.PictureBox
    Friend WithEvents norwayFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents italyFlagPictureBox As System.Windows.Forms.PictureBox

End Class
