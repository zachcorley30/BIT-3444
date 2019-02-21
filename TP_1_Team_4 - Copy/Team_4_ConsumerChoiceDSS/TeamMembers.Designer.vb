<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeamMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamMembers))
        Me.pbxJohnHoffman = New System.Windows.Forms.PictureBox()
        Me.pbxMarkCurry = New System.Windows.Forms.PictureBox()
        Me.lblMarkCurry = New System.Windows.Forms.Label()
        Me.lblJohnHoffman = New System.Windows.Forms.Label()
        CType(Me.pbxJohnHoffman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMarkCurry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxJohnHoffman
        '
        Me.pbxJohnHoffman.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxJohnHoffman.Image = CType(resources.GetObject("pbxJohnHoffman.Image"), System.Drawing.Image)
        Me.pbxJohnHoffman.Location = New System.Drawing.Point(37, 12)
        Me.pbxJohnHoffman.Name = "pbxJohnHoffman"
        Me.pbxJohnHoffman.Size = New System.Drawing.Size(376, 478)
        Me.pbxJohnHoffman.TabIndex = 0
        Me.pbxJohnHoffman.TabStop = False
        '
        'pbxMarkCurry
        '
        Me.pbxMarkCurry.Image = CType(resources.GetObject("pbxMarkCurry.Image"), System.Drawing.Image)
        Me.pbxMarkCurry.Location = New System.Drawing.Point(512, 210)
        Me.pbxMarkCurry.Name = "pbxMarkCurry"
        Me.pbxMarkCurry.Size = New System.Drawing.Size(181, 280)
        Me.pbxMarkCurry.TabIndex = 3
        Me.pbxMarkCurry.TabStop = False
        '
        'lblMarkCurry
        '
        Me.lblMarkCurry.AutoSize = True
        Me.lblMarkCurry.BackColor = System.Drawing.Color.White
        Me.lblMarkCurry.Location = New System.Drawing.Point(512, 518)
        Me.lblMarkCurry.Name = "lblMarkCurry"
        Me.lblMarkCurry.Size = New System.Drawing.Size(181, 50)
        Me.lblMarkCurry.TabIndex = 4
        Me.lblMarkCurry.Text = "Mark Curry" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mcurry16@vt.edu"
        '
        'lblJohnHoffman
        '
        Me.lblJohnHoffman.AutoSize = True
        Me.lblJohnHoffman.BackColor = System.Drawing.Color.White
        Me.lblJohnHoffman.Location = New System.Drawing.Point(137, 518)
        Me.lblJohnHoffman.Name = "lblJohnHoffman"
        Me.lblJohnHoffman.Size = New System.Drawing.Size(174, 50)
        Me.lblJohnHoffman.TabIndex = 5
        Me.lblJohnHoffman.Text = "John Hoffman" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jmhoff98@vt.edu"
        '
        'TeamMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1387, 790)
        Me.Controls.Add(Me.lblJohnHoffman)
        Me.Controls.Add(Me.lblMarkCurry)
        Me.Controls.Add(Me.pbxMarkCurry)
        Me.Controls.Add(Me.pbxJohnHoffman)
        Me.Name = "TeamMembers"
        Me.Text = "Team Members"
        CType(Me.pbxJohnHoffman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMarkCurry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxJohnHoffman As PictureBox
    Friend WithEvents pbxMarkCurry As PictureBox
    Friend WithEvents lblMarkCurry As Label
    Friend WithEvents lblJohnHoffman As Label
End Class
