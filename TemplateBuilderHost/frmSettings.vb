Public Class frmSettings

   Public Property Settings As Settings

   Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Loader.Load(Me, Loader.CreateDarkTheme)

      If Settings IsNot Nothing Then
         ftbCompiler.Filename = Settings.CompilerPath
         ftbCasparCG.Filename = Settings.CasparExePath
         ptbTemplatePath.Path = Settings.CasparTemplatePath
         cboAddInfoFields.SelectedIndex = Settings.AddInfoFieldsMode
         nudChannel.Value = Settings.Channel
         nudLayer.Value = Settings.Layer
         chkHelper2Root.Checked = Settings.CopyHelperToRoot
      End If

   End Sub

   Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

      Settings.CompilerPath = ftbCompiler.Filename
      Settings.CasparExePath = ftbCasparCG.Filename
      Settings.CasparTemplatePath = ptbTemplatePath.Path
      Settings.AddInfoFieldsMode = cboAddInfoFields.SelectedIndex
      Settings.Channel = nudChannel.Value
      Settings.Layer = nudLayer.Value
      Settings.CopyHelperToRoot = chkHelper2Root.Checked

      Close()

   End Sub
   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      Close()
   End Sub

End Class