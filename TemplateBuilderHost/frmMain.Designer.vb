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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboFrameRate = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboResolution = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAuthorEMail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ptbSourcePath = New TemplateBuilderHost.ctrPathTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCompile = New TemplateBuilderHost.NiceButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnklblClearChannel = New System.Windows.Forms.LinkLabel()
        Me.lnklblClearLayer = New System.Windows.Forms.LinkLabel()
        Me.btnUpdate = New TemplateBuilderHost.NiceButton()
        Me.cboTemplate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnStop = New TemplateBuilderHost.NiceButton()
        Me.btnNext = New TemplateBuilderHost.NiceButton()
        Me.btnPlay = New TemplateBuilderHost.NiceButton()
        Me.btnLoad = New TemplateBuilderHost.NiceButton()
        Me.btnInvoke2 = New System.Windows.Forms.Button()
        Me.txtInvoke2 = New System.Windows.Forms.TextBox()
        Me.btnInvoke1 = New System.Windows.Forms.Button()
        Me.txtInvoke1 = New System.Windows.Forms.TextBox()
        Me.txtValue8 = New System.Windows.Forms.TextBox()
        Me.txtName8 = New System.Windows.Forms.TextBox()
        Me.txtValue7 = New System.Windows.Forms.TextBox()
        Me.txtName7 = New System.Windows.Forms.TextBox()
        Me.txtValue6 = New System.Windows.Forms.TextBox()
        Me.txtName6 = New System.Windows.Forms.TextBox()
        Me.txtValue5 = New System.Windows.Forms.TextBox()
        Me.txtName5 = New System.Windows.Forms.TextBox()
        Me.txtValue4 = New System.Windows.Forms.TextBox()
        Me.txtName4 = New System.Windows.Forms.TextBox()
        Me.txtValue3 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnklblThumbnail = New System.Windows.Forms.LinkLabel()
        Me.lnklblDocumentation = New System.Windows.Forms.LinkLabel()
        Me.btnRefreshFolders = New System.Windows.Forms.Button()
        Me.btnFile1 = New System.Windows.Forms.Button()
        Me.btnFile2 = New System.Windows.Forms.Button()
        Me.btnFile3 = New System.Windows.Forms.Button()
        Me.btnFile4 = New System.Windows.Forms.Button()
        Me.btnFile5 = New System.Windows.Forms.Button()
        Me.btnFile6 = New System.Windows.Forms.Button()
        Me.btnFile7 = New System.Windows.Forms.Button()
        Me.btnFile8 = New System.Windows.Forms.Button()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(648, 24)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSettings, Me.mnuFileSep1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileSettings
        '
        Me.mnuFileSettings.Name = "mnuFileSettings"
        Me.mnuFileSettings.Size = New System.Drawing.Size(135, 22)
        Me.mnuFileSettings.Text = "&Settings..."
        '
        'mnuFileSep1
        '
        Me.mnuFileSep1.Name = "mnuFileSep1"
        Me.mnuFileSep1.Size = New System.Drawing.Size(132, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(135, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'cboFrameRate
        '
        Me.cboFrameRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrameRate.FormattingEnabled = True
        Me.cboFrameRate.Items.AddRange(New Object() {"23.98", "24", "25", "29.97", "30", "50", "59.94", "60"})
        Me.cboFrameRate.Location = New System.Drawing.Point(409, 193)
        Me.cboFrameRate.Name = "cboFrameRate"
        Me.cboFrameRate.Size = New System.Drawing.Size(72, 21)
        Me.cboFrameRate.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Framerate:"
        '
        'cboResolution
        '
        Me.cboResolution.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResolution.FormattingEnabled = True
        Me.cboResolution.Items.AddRange(New Object() {"PAL 4:3", "NTSC 4:3", "PAL 16:9", "NTSC 16:9", "720", "1080", "4K"})
        Me.cboResolution.Location = New System.Drawing.Point(308, 194)
        Me.cboResolution.Name = "cboResolution"
        Me.cboResolution.Size = New System.Drawing.Size(95, 21)
        Me.cboResolution.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Resolution:"
        '
        'txtAuthorEMail
        '
        Me.txtAuthorEMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAuthorEMail.Location = New System.Drawing.Point(159, 194)
        Me.txtAuthorEMail.Name = "txtAuthorEMail"
        Me.txtAuthorEMail.Size = New System.Drawing.Size(143, 20)
        Me.txtAuthorEMail.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Author E-Mail:"
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAuthorName.Location = New System.Drawing.Point(10, 194)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(143, 20)
        Me.txtAuthorName.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Authorname:"
        '
        'cboDestination
        '
        Me.cboDestination.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(421, 39)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(191, 21)
        Me.cboDestination.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Destination:"
        '
        'ptbSourcePath
        '
        Me.ptbSourcePath.BackColor = System.Drawing.Color.Transparent
        Me.ptbSourcePath.Location = New System.Drawing.Point(10, 40)
        Me.ptbSourcePath.MaximumSize = New System.Drawing.Size(30000, 20)
        Me.ptbSourcePath.Name = "ptbSourcePath"
        Me.ptbSourcePath.Path = ""
        Me.ptbSourcePath.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.ptbSourcePath.ShowClearButton = False
        Me.ptbSourcePath.Size = New System.Drawing.Size(402, 20)
        Me.ptbSourcePath.TabIndex = 4
        Me.ptbSourcePath.ToolTipControl = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Source path:"
        '
        'btnCompile
        '
        Me.btnCompile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompile.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCompile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCompile.ForeColor = System.Drawing.Color.White
        Me.btnCompile.Location = New System.Drawing.Point(536, 177)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.Size = New System.Drawing.Size(111, 45)
        Me.btnCompile.TabIndex = 2
        Me.btnCompile.Tag = "[highlite]"
        Me.btnCompile.Text = "Compile"
        Me.btnCompile.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(10, 79)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(637, 92)
        Me.txtOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Output:"
        '
        'lnklblClearChannel
        '
        Me.lnklblClearChannel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnklblClearChannel.AutoSize = True
        Me.lnklblClearChannel.Location = New System.Drawing.Point(7, 517)
        Me.lnklblClearChannel.Name = "lnklblClearChannel"
        Me.lnklblClearChannel.Size = New System.Drawing.Size(73, 13)
        Me.lnklblClearChannel.TabIndex = 38
        Me.lnklblClearChannel.TabStop = True
        Me.lnklblClearChannel.Text = "Clear Channel"
        '
        'lnklblClearLayer
        '
        Me.lnklblClearLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnklblClearLayer.AutoSize = True
        Me.lnklblClearLayer.Location = New System.Drawing.Point(7, 495)
        Me.lnklblClearLayer.Name = "lnklblClearLayer"
        Me.lnklblClearLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnklblClearLayer.TabIndex = 37
        Me.lnklblClearLayer.TabStop = True
        Me.lnklblClearLayer.Text = "Clear Layer"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(10, 543)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 45)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Tag = ""
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cboTemplate
        '
        Me.cboTemplate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTemplate.FormattingEnabled = True
        Me.cboTemplate.Location = New System.Drawing.Point(10, 237)
        Me.cboTemplate.Name = "cboTemplate"
        Me.cboTemplate.Size = New System.Drawing.Size(632, 21)
        Me.cboTemplate.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Template:"
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(531, 543)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(111, 45)
        Me.btnStop.TabIndex = 33
        Me.btnStop.Tag = "[highlite]"
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(414, 543)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(111, 45)
        Me.btnNext.TabIndex = 32
        Me.btnNext.Tag = "[highlite]"
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(297, 543)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(111, 45)
        Me.btnPlay.TabIndex = 31
        Me.btnPlay.Tag = "[highlite]"
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(180, 543)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(111, 45)
        Me.btnLoad.TabIndex = 30
        Me.btnLoad.Tag = "[highlite]"
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnInvoke2
        '
        Me.btnInvoke2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInvoke2.Location = New System.Drawing.Point(578, 514)
        Me.btnInvoke2.Name = "btnInvoke2"
        Me.btnInvoke2.Size = New System.Drawing.Size(64, 20)
        Me.btnInvoke2.TabIndex = 29
        Me.btnInvoke2.Text = "Invoke"
        Me.btnInvoke2.UseVisualStyleBackColor = True
        '
        'txtInvoke2
        '
        Me.txtInvoke2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoke2.Location = New System.Drawing.Point(183, 514)
        Me.txtInvoke2.Name = "txtInvoke2"
        Me.txtInvoke2.Size = New System.Drawing.Size(389, 20)
        Me.txtInvoke2.TabIndex = 28
        '
        'btnInvoke1
        '
        Me.btnInvoke1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInvoke1.Location = New System.Drawing.Point(578, 488)
        Me.btnInvoke1.Name = "btnInvoke1"
        Me.btnInvoke1.Size = New System.Drawing.Size(64, 20)
        Me.btnInvoke1.TabIndex = 27
        Me.btnInvoke1.Text = "Invoke"
        Me.btnInvoke1.UseVisualStyleBackColor = True
        '
        'txtInvoke1
        '
        Me.txtInvoke1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoke1.Location = New System.Drawing.Point(183, 488)
        Me.txtInvoke1.Name = "txtInvoke1"
        Me.txtInvoke1.Size = New System.Drawing.Size(389, 20)
        Me.txtInvoke1.TabIndex = 26
        '
        'txtValue8
        '
        Me.txtValue8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue8.Location = New System.Drawing.Point(183, 462)
        Me.txtValue8.Name = "txtValue8"
        Me.txtValue8.Size = New System.Drawing.Size(429, 20)
        Me.txtValue8.TabIndex = 24
        '
        'txtName8
        '
        Me.txtName8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName8.Location = New System.Drawing.Point(10, 462)
        Me.txtName8.Name = "txtName8"
        Me.txtName8.Size = New System.Drawing.Size(164, 20)
        Me.txtName8.TabIndex = 23
        '
        'txtValue7
        '
        Me.txtValue7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue7.Location = New System.Drawing.Point(183, 436)
        Me.txtValue7.Name = "txtValue7"
        Me.txtValue7.Size = New System.Drawing.Size(429, 20)
        Me.txtValue7.TabIndex = 21
        '
        'txtName7
        '
        Me.txtName7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName7.Location = New System.Drawing.Point(10, 436)
        Me.txtName7.Name = "txtName7"
        Me.txtName7.Size = New System.Drawing.Size(164, 20)
        Me.txtName7.TabIndex = 20
        '
        'txtValue6
        '
        Me.txtValue6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue6.Location = New System.Drawing.Point(183, 410)
        Me.txtValue6.Name = "txtValue6"
        Me.txtValue6.Size = New System.Drawing.Size(429, 20)
        Me.txtValue6.TabIndex = 18
        '
        'txtName6
        '
        Me.txtName6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName6.Location = New System.Drawing.Point(10, 410)
        Me.txtName6.Name = "txtName6"
        Me.txtName6.Size = New System.Drawing.Size(164, 20)
        Me.txtName6.TabIndex = 17
        '
        'txtValue5
        '
        Me.txtValue5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue5.Location = New System.Drawing.Point(183, 384)
        Me.txtValue5.Name = "txtValue5"
        Me.txtValue5.Size = New System.Drawing.Size(429, 20)
        Me.txtValue5.TabIndex = 15
        '
        'txtName5
        '
        Me.txtName5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName5.Location = New System.Drawing.Point(10, 384)
        Me.txtName5.Name = "txtName5"
        Me.txtName5.Size = New System.Drawing.Size(164, 20)
        Me.txtName5.TabIndex = 14
        '
        'txtValue4
        '
        Me.txtValue4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue4.Location = New System.Drawing.Point(183, 358)
        Me.txtValue4.Name = "txtValue4"
        Me.txtValue4.Size = New System.Drawing.Size(429, 20)
        Me.txtValue4.TabIndex = 12
        '
        'txtName4
        '
        Me.txtName4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName4.Location = New System.Drawing.Point(10, 358)
        Me.txtName4.Name = "txtName4"
        Me.txtName4.Size = New System.Drawing.Size(164, 20)
        Me.txtName4.TabIndex = 11
        '
        'txtValue3
        '
        Me.txtValue3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue3.Location = New System.Drawing.Point(183, 332)
        Me.txtValue3.Name = "txtValue3"
        Me.txtValue3.Size = New System.Drawing.Size(429, 20)
        Me.txtValue3.TabIndex = 9
        '
        'txtName3
        '
        Me.txtName3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName3.Location = New System.Drawing.Point(10, 332)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(164, 20)
        Me.txtName3.TabIndex = 8
        '
        'txtValue2
        '
        Me.txtValue2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue2.Location = New System.Drawing.Point(183, 306)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(429, 20)
        Me.txtValue2.TabIndex = 6
        '
        'txtName2
        '
        Me.txtName2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName2.Location = New System.Drawing.Point(10, 306)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(164, 20)
        Me.txtName2.TabIndex = 5
        '
        'txtValue1
        '
        Me.txtValue1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue1.Location = New System.Drawing.Point(183, 280)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(429, 20)
        Me.txtValue1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Value:"
        '
        'txtName1
        '
        Me.txtName1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtName1.Location = New System.Drawing.Point(10, 280)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(164, 20)
        Me.txtName1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'lnklblThumbnail
        '
        Me.lnklblThumbnail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnklblThumbnail.AutoSize = True
        Me.lnklblThumbnail.Location = New System.Drawing.Point(82, 495)
        Me.lnklblThumbnail.Name = "lnklblThumbnail"
        Me.lnklblThumbnail.Size = New System.Drawing.Size(92, 13)
        Me.lnklblThumbnail.TabIndex = 39
        Me.lnklblThumbnail.TabStop = True
        Me.lnklblThumbnail.Text = "Capture thumbnail"
        '
        'lnklblDocumentation
        '
        Me.lnklblDocumentation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnklblDocumentation.AutoSize = True
        Me.lnklblDocumentation.Location = New System.Drawing.Point(86, 517)
        Me.lnklblDocumentation.Name = "lnklblDocumentation"
        Me.lnklblDocumentation.Size = New System.Drawing.Size(88, 13)
        Me.lnklblDocumentation.TabIndex = 40
        Me.lnklblDocumentation.TabStop = True
        Me.lnklblDocumentation.Text = "Documentation..."
        '
        'btnRefreshFolders
        '
        Me.btnRefreshFolders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshFolders.Image = Global.TemplateBuilderHost.My.Resources.Resources.Refresh12
        Me.btnRefreshFolders.Location = New System.Drawing.Point(622, 39)
        Me.btnRefreshFolders.Name = "btnRefreshFolders"
        Me.btnRefreshFolders.Size = New System.Drawing.Size(20, 20)
        Me.btnRefreshFolders.TabIndex = 7
        Me.btnRefreshFolders.UseVisualStyleBackColor = True
        '
        'btnFile1
        '
        Me.btnFile1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile1.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile1.Location = New System.Drawing.Point(622, 280)
        Me.btnFile1.Name = "btnFile1"
        Me.btnFile1.Size = New System.Drawing.Size(20, 20)
        Me.btnFile1.TabIndex = 4
        Me.btnFile1.UseVisualStyleBackColor = True
        '
        'btnFile2
        '
        Me.btnFile2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile2.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile2.Location = New System.Drawing.Point(622, 306)
        Me.btnFile2.Name = "btnFile2"
        Me.btnFile2.Size = New System.Drawing.Size(20, 20)
        Me.btnFile2.TabIndex = 7
        Me.btnFile2.UseVisualStyleBackColor = True
        '
        'btnFile3
        '
        Me.btnFile3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile3.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile3.Location = New System.Drawing.Point(622, 332)
        Me.btnFile3.Name = "btnFile3"
        Me.btnFile3.Size = New System.Drawing.Size(20, 20)
        Me.btnFile3.TabIndex = 10
        Me.btnFile3.UseVisualStyleBackColor = True
        '
        'btnFile4
        '
        Me.btnFile4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile4.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile4.Location = New System.Drawing.Point(622, 358)
        Me.btnFile4.Name = "btnFile4"
        Me.btnFile4.Size = New System.Drawing.Size(20, 20)
        Me.btnFile4.TabIndex = 13
        Me.btnFile4.UseVisualStyleBackColor = True
        '
        'btnFile5
        '
        Me.btnFile5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile5.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile5.Location = New System.Drawing.Point(622, 384)
        Me.btnFile5.Name = "btnFile5"
        Me.btnFile5.Size = New System.Drawing.Size(20, 20)
        Me.btnFile5.TabIndex = 16
        Me.btnFile5.UseVisualStyleBackColor = True
        '
        'btnFile6
        '
        Me.btnFile6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile6.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile6.Location = New System.Drawing.Point(622, 410)
        Me.btnFile6.Name = "btnFile6"
        Me.btnFile6.Size = New System.Drawing.Size(20, 20)
        Me.btnFile6.TabIndex = 19
        Me.btnFile6.UseVisualStyleBackColor = True
        '
        'btnFile7
        '
        Me.btnFile7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile7.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile7.Location = New System.Drawing.Point(622, 436)
        Me.btnFile7.Name = "btnFile7"
        Me.btnFile7.Size = New System.Drawing.Size(20, 20)
        Me.btnFile7.TabIndex = 22
        Me.btnFile7.UseVisualStyleBackColor = True
        '
        'btnFile8
        '
        Me.btnFile8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile8.Image = Global.TemplateBuilderHost.My.Resources.Resources.TreeDots12
        Me.btnFile8.Location = New System.Drawing.Point(622, 462)
        Me.btnFile8.Name = "btnFile8"
        Me.btnFile8.Size = New System.Drawing.Size(20, 20)
        Me.btnFile8.TabIndex = 25
        Me.btnFile8.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 598)
        Me.Controls.Add(Me.lnklblDocumentation)
        Me.Controls.Add(Me.lnklblThumbnail)
        Me.Controls.Add(Me.lnklblClearChannel)
        Me.Controls.Add(Me.cboFrameRate)
        Me.Controls.Add(Me.lnklblClearLayer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboTemplate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.cboResolution)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.msMain)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnInvoke2)
        Me.Controls.Add(Me.txtAuthorEMail)
        Me.Controls.Add(Me.txtInvoke2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInvoke1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtInvoke1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtValue8)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.txtName8)
        Me.Controls.Add(Me.btnCompile)
        Me.Controls.Add(Me.txtValue7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtName7)
        Me.Controls.Add(Me.ptbSourcePath)
        Me.Controls.Add(Me.txtValue6)
        Me.Controls.Add(Me.btnRefreshFolders)
        Me.Controls.Add(Me.txtName6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtValue5)
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.txtName5)
        Me.Controls.Add(Me.btnFile1)
        Me.Controls.Add(Me.txtValue4)
        Me.Controls.Add(Me.btnFile2)
        Me.Controls.Add(Me.txtName4)
        Me.Controls.Add(Me.btnFile3)
        Me.Controls.Add(Me.txtValue3)
        Me.Controls.Add(Me.btnFile4)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.btnFile5)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.btnFile6)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.btnFile7)
        Me.Controls.Add(Me.txtValue1)
        Me.Controls.Add(Me.btnFile8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.MinimumSize = New System.Drawing.Size(664, 637)
        Me.Name = "frmMain"
        Me.Text = "Template-Builder Host"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSettings As ToolStripMenuItem
    Friend WithEvents mnuFileSep1 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCompile As TemplateBuilderHost.NiceButton
    Friend WithEvents btnFile1 As Button
    Friend WithEvents txtValue1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFile8 As Button
    Friend WithEvents txtValue8 As TextBox
    Friend WithEvents txtName8 As TextBox
    Friend WithEvents btnFile7 As Button
    Friend WithEvents txtValue7 As TextBox
    Friend WithEvents txtName7 As TextBox
    Friend WithEvents btnFile6 As Button
    Friend WithEvents txtValue6 As TextBox
    Friend WithEvents txtName6 As TextBox
    Friend WithEvents btnFile5 As Button
    Friend WithEvents txtValue5 As TextBox
    Friend WithEvents txtName5 As TextBox
    Friend WithEvents btnFile4 As Button
    Friend WithEvents txtValue4 As TextBox
    Friend WithEvents txtName4 As TextBox
    Friend WithEvents btnFile3 As Button
    Friend WithEvents txtValue3 As TextBox
    Friend WithEvents txtName3 As TextBox
    Friend WithEvents btnFile2 As Button
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents btnStop As TemplateBuilderHost.NiceButton
    Friend WithEvents btnNext As TemplateBuilderHost.NiceButton
    Friend WithEvents btnPlay As TemplateBuilderHost.NiceButton
    Friend WithEvents btnLoad As TemplateBuilderHost.NiceButton
    Friend WithEvents btnInvoke2 As Button
    Friend WithEvents txtInvoke2 As TextBox
    Friend WithEvents btnInvoke1 As Button
    Friend WithEvents txtInvoke1 As TextBox
    Friend WithEvents ptbSourcePath As TemplateBuilderHost.ctrPathTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRefreshFolders As Button
    Friend WithEvents cboTemplate As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As TemplateBuilderHost.NiceButton
    Friend WithEvents lnklblClearChannel As LinkLabel
    Friend WithEvents lnklblClearLayer As LinkLabel
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboResolution As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAuthorEMail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboFrameRate As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lnklblThumbnail As LinkLabel
    Friend WithEvents lnklblDocumentation As LinkLabel
End Class
