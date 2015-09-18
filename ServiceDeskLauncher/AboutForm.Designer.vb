<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lnkConnectUp = New System.Windows.Forms.LinkLabel()
        Me.btnSupport = New System.Windows.Forms.Button()
        Me.pbxTeamViewer = New System.Windows.Forms.PictureBox()
        CType(Me.pbxTeamViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(12, 247)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(49, 21)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lnkConnectUp
        '
        Me.lnkConnectUp.AutoSize = True
        Me.lnkConnectUp.BackColor = System.Drawing.Color.Transparent
        Me.lnkConnectUp.Location = New System.Drawing.Point(344, 0)
        Me.lnkConnectUp.Name = "lnkConnectUp"
        Me.lnkConnectUp.Size = New System.Drawing.Size(118, 13)
        Me.lnkConnectUp.TabIndex = 3
        Me.lnkConnectUp.TabStop = True
        Me.lnkConnectUp.Text = "www.connect-up.co.uk"
        '
        'btnSupport
        '
        Me.btnSupport.BackColor = System.Drawing.Color.Transparent
        Me.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupport.Location = New System.Drawing.Point(12, 218)
        Me.btnSupport.Name = "btnSupport"
        Me.btnSupport.Size = New System.Drawing.Size(120, 23)
        Me.btnSupport.TabIndex = 4
        Me.btnSupport.Text = "Log a support ticket"
        Me.btnSupport.UseVisualStyleBackColor = False
        '
        'pbxTeamViewer
        '
        Me.pbxTeamViewer.BackColor = System.Drawing.Color.Transparent
        Me.pbxTeamViewer.BackgroundImage = CType(resources.GetObject("pbxTeamViewer.BackgroundImage"), System.Drawing.Image)
        Me.pbxTeamViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxTeamViewer.Location = New System.Drawing.Point(332, 214)
        Me.pbxTeamViewer.Name = "pbxTeamViewer"
        Me.pbxTeamViewer.Size = New System.Drawing.Size(134, 73)
        Me.pbxTeamViewer.TabIndex = 5
        Me.pbxTeamViewer.TabStop = False
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(466, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbxTeamViewer)
        Me.Controls.Add(Me.btnSupport)
        Me.Controls.Add(Me.lnkConnectUp)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect Up Supoort"
        CType(Me.pbxTeamViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lnkConnectUp As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSupport As System.Windows.Forms.Button
    Friend WithEvents pbxTeamViewer As PictureBox
End Class
