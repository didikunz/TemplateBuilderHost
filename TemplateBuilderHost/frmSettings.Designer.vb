﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudLayer = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudChannel = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New CommonControls.NiceButton()
        Me.btnOk = New CommonControls.NiceButton()
        Me.ftbCompiler = New CommonControls.ctrFileTextBox()
        Me.ftbCasparCG = New CommonControls.ctrFileTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ptbTemplatePath = New CommonControls.ctrPathTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAddInfoFields = New System.Windows.Forms.ComboBox()
        Me.chkHelper2Root = New System.Windows.Forms.CheckBox()
        CType(Me.nudLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudChannel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Layer:"
        '
        'nudLayer
        '
        Me.nudLayer.Location = New System.Drawing.Point(309, 149)
        Me.nudLayer.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudLayer.Name = "nudLayer"
        Me.nudLayer.Size = New System.Drawing.Size(83, 20)
        Me.nudLayer.TabIndex = 20
        Me.nudLayer.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Channel:"
        '
        'nudChannel
        '
        Me.nudChannel.Location = New System.Drawing.Point(220, 149)
        Me.nudChannel.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudChannel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudChannel.Name = "nudChannel"
        Me.nudChannel.Size = New System.Drawing.Size(83, 20)
        Me.nudChannel.TabIndex = 18
        Me.nudChannel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Compiler-Exe-Path:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(291, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 38)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Tag = "[highlite]"
        Me.btnCancel.Text = "Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(184, 184)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(101, 38)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Tag = "[highlite]"
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'ftbCompiler
        '
        Me.ftbCompiler.BackColor = System.Drawing.Color.Transparent
        Me.ftbCompiler.CustomDialogFilter = "Compiler exe file (Build.exe)|Build.exe|All Files (*.*)|*.*||"
        Me.ftbCompiler.DialogFilter = CommonControls.ctrFileTextBox.DialogFilterType.dtfCustom
        Me.ftbCompiler.DialogType = CommonControls.ctrFileTextBox.enumDialogType.OpenDialog
        Me.ftbCompiler.Filename = ""
        Me.ftbCompiler.IntialDirectory = ""
        Me.ftbCompiler.Location = New System.Drawing.Point(13, 24)
        Me.ftbCompiler.Margin = New System.Windows.Forms.Padding(0)
        Me.ftbCompiler.MaximumSize = New System.Drawing.Size(30000, 20)
        Me.ftbCompiler.MinimumSize = New System.Drawing.Size(75, 20)
        Me.ftbCompiler.Name = "ftbCompiler"
        Me.ftbCompiler.OverwritePrompt = True
        Me.ftbCompiler.ShowClearButton = False
        Me.ftbCompiler.Size = New System.Drawing.Size(379, 20)
        Me.ftbCompiler.TabIndex = 22
        Me.ftbCompiler.ToolTipControl = Nothing
        '
        'ftbCasparCG
        '
        Me.ftbCasparCG.BackColor = System.Drawing.Color.Transparent
        Me.ftbCasparCG.CustomDialogFilter = "Compiler exe file (Build.exe)|Build.exe|All Files (*.*)|*.*||"
        Me.ftbCasparCG.DialogFilter = CommonControls.ctrFileTextBox.DialogFilterType.dtfCustom
        Me.ftbCasparCG.DialogType = CommonControls.ctrFileTextBox.enumDialogType.OpenDialog
        Me.ftbCasparCG.Filename = ""
        Me.ftbCasparCG.IntialDirectory = ""
        Me.ftbCasparCG.Location = New System.Drawing.Point(13, 64)
        Me.ftbCasparCG.Margin = New System.Windows.Forms.Padding(0)
        Me.ftbCasparCG.MaximumSize = New System.Drawing.Size(30000, 20)
        Me.ftbCasparCG.MinimumSize = New System.Drawing.Size(75, 20)
        Me.ftbCasparCG.Name = "ftbCasparCG"
        Me.ftbCasparCG.OverwritePrompt = True
        Me.ftbCasparCG.ShowClearButton = False
        Me.ftbCasparCG.Size = New System.Drawing.Size(379, 20)
        Me.ftbCasparCG.TabIndex = 24
        Me.ftbCasparCG.ToolTipControl = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CasparCG-Exe-Path:"
        '
        'ptbTemplatePath
        '
        Me.ptbTemplatePath.BackColor = System.Drawing.Color.Transparent
        Me.ptbTemplatePath.Location = New System.Drawing.Point(13, 107)
        Me.ptbTemplatePath.MaximumSize = New System.Drawing.Size(30000, 20)
        Me.ptbTemplatePath.Name = "ptbTemplatePath"
        Me.ptbTemplatePath.Path = ""
        Me.ptbTemplatePath.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.ptbTemplatePath.ShowClearButton = False
        Me.ptbTemplatePath.Size = New System.Drawing.Size(379, 20)
        Me.ptbTemplatePath.TabIndex = 25
        Me.ptbTemplatePath.ToolTipControl = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "CasparCG-Template Folder:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Add-Infofields mode:"
        '
        'cboAddInfoFields
        '
        Me.cboAddInfoFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddInfoFields.FormattingEnabled = True
        Me.cboAddInfoFields.Items.AddRange(New Object() {"None", "Standard", "Aveco"})
        Me.cboAddInfoFields.Location = New System.Drawing.Point(13, 148)
        Me.cboAddInfoFields.Name = "cboAddInfoFields"
        Me.cboAddInfoFields.Size = New System.Drawing.Size(201, 21)
        Me.cboAddInfoFields.TabIndex = 28
        '
        'chkHelper2Root
        '
        Me.chkHelper2Root.AutoSize = True
        Me.chkHelper2Root.Location = New System.Drawing.Point(15, 196)
        Me.chkHelper2Root.Name = "chkHelper2Root"
        Me.chkHelper2Root.Size = New System.Drawing.Size(120, 17)
        Me.chkHelper2Root.TabIndex = 29
        Me.chkHelper2Root.Text = "Copy helpers to root"
        Me.chkHelper2Root.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(406, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkHelper2Root)
        Me.Controls.Add(Me.cboAddInfoFields)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ptbTemplatePath)
        Me.Controls.Add(Me.ftbCasparCG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ftbCompiler)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nudLayer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudChannel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.nudLayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudChannel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents nudLayer As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudChannel As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As CommonControls.NiceButton
    Friend WithEvents btnOk As CommonControls.NiceButton
    Friend WithEvents ftbCompiler As CommonControls.ctrFileTextBox
    Friend WithEvents ftbCasparCG As CommonControls.ctrFileTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ptbTemplatePath As CommonControls.ctrPathTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboAddInfoFields As ComboBox
    Friend WithEvents chkHelper2Root As CheckBox
End Class
