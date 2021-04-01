<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnOff = New CommonControls.NiceButton()
        Me.btnOn = New CommonControls.NiceButton()
        Me.cntmnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cntmnuTrayShowUserInterface = New System.Windows.Forms.ToolStripMenuItem()
        Me.cntmnuTraySep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cntmnuTrayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.niTaskbarIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cntmnuTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOff
        '
        Me.btnOff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOff.ForeColor = System.Drawing.Color.White
        Me.btnOff.Location = New System.Drawing.Point(12, 12)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(283, 50)
        Me.btnOff.TabIndex = 2
        Me.btnOff.Text = "Flash font smoothing OFF"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'btnOn
        '
        Me.btnOn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOn.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOn.ForeColor = System.Drawing.Color.White
        Me.btnOn.Location = New System.Drawing.Point(12, 68)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(283, 50)
        Me.btnOn.TabIndex = 3
        Me.btnOn.Text = "HTML font smoothing ON"
        Me.btnOn.UseVisualStyleBackColor = False
        '
        'cntmnuTray
        '
        Me.cntmnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cntmnuTrayShowUserInterface, Me.cntmnuTraySep1, Me.cntmnuTrayExit})
        Me.cntmnuTray.Name = "cntmnuTray"
        Me.cntmnuTray.Size = New System.Drawing.Size(187, 54)
        '
        'cntmnuTrayShowUserInterface
        '
        Me.cntmnuTrayShowUserInterface.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cntmnuTrayShowUserInterface.Name = "cntmnuTrayShowUserInterface"
        Me.cntmnuTrayShowUserInterface.Size = New System.Drawing.Size(186, 22)
        Me.cntmnuTrayShowUserInterface.Text = "Show user interface"
        '
        'cntmnuTraySep1
        '
        Me.cntmnuTraySep1.Name = "cntmnuTraySep1"
        Me.cntmnuTraySep1.Size = New System.Drawing.Size(183, 6)
        '
        'cntmnuTrayExit
        '
        Me.cntmnuTrayExit.Name = "cntmnuTrayExit"
        Me.cntmnuTrayExit.Size = New System.Drawing.Size(186, 22)
        Me.cntmnuTrayExit.Text = "Exit"
        '
        'niTaskbarIcon
        '
        Me.niTaskbarIcon.BalloonTipTitle = "CasparCG Font Smoothing"
        Me.niTaskbarIcon.ContextMenuStrip = Me.cntmnuTray
        Me.niTaskbarIcon.Icon = CType(resources.GetObject("niTaskbarIcon.Icon"), System.Drawing.Icon)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(307, 130)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.btnOff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CasparCG Font Smoothing"
        Me.cntmnuTray.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOff As CommonControls.NiceButton
    Friend WithEvents btnOn As CommonControls.NiceButton
    Friend WithEvents cntmnuTray As ContextMenuStrip
    Friend WithEvents cntmnuTrayShowUserInterface As ToolStripMenuItem
    Friend WithEvents cntmnuTraySep1 As ToolStripSeparator
    Friend WithEvents cntmnuTrayExit As ToolStripMenuItem
    Friend WithEvents niTaskbarIcon As NotifyIcon
End Class
