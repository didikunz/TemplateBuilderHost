Imports System.IO
Imports System.Diagnostics
Imports System.ComponentModel
Imports CasparObjects
Imports System.Threading
Imports System.Xml
Imports System.Text

Public Class frmMain

   Private _settings As Settings = Nothing
   Private isLoaded As Boolean = False
   Private WithEvents _Caspar As CasparCG = Nothing
   Private _Middleware_Proc As Process = Nothing

#Region "Forms handling"

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

      Loader.Load(Me, Loader.CreateDarkTheme)

      Dim cap As CommonApplicationData = New CommonApplicationData("MediaSupport", "TemplateBuilderHost", True)

      If IO.File.Exists(Path.Combine(cap.ApplicationFolderPath, "Settings.xml")) Then
         _settings = New Settings(Path.Combine(cap.ApplicationFolderPath, "Settings.xml"))
      Else
         _settings = New Settings
         _settings.Save(Path.Combine(cap.ApplicationFolderPath, "Settings.xml"))
      End If

      Location = _settings.MainLocation
      Size = _settings.MainSize
      WindowState = _settings.MainWindowstate

      If Not IO.File.Exists(_settings.CasparExePath) Then

         MsgBox("Please provide the path to CasparCG's exe file", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Missing path")

         Dim dlg As OpenFileDialog = New OpenFileDialog
         dlg.RestoreDirectory = True
         dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
         dlg.Filter = "CasparCG exe file (CasparCG*.exe)|CasparCG*.exe|All Files (*.*)|*.*||"
         dlg.FilterIndex = 0

         If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            _settings.CasparExePath = dlg.FileName
            _settings.Save(IO.Path.Combine(cap.ApplicationFolderPath, "Settings.xml"))
         End If

      End If

      Try
         _Caspar = New CasparCG
         _Caspar.CasparExePath = _settings.CasparExePath
         _Caspar.Retries = 20
         _Caspar.Connect()
      Catch ex As Exception
         MsgBox(String.Format("Connection to CasparCG ({0}) was not possible.", _Caspar.Name), "Connection error")
         End
      End Try

      _Caspar.AddInfoFields = _settings.AddInfoFieldsMode

      If Not IO.File.Exists(_settings.CompilerPath) Then

         MsgBox("Please provide the path to the compilers's exe file", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Missing path")

         Dim dlg As OpenFileDialog = New OpenFileDialog
         dlg.RestoreDirectory = True
         dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
         dlg.Filter = "Compiler exe file (Build.exe)|Build.exe|All Files (*.*)|*.*||"
         dlg.FilterIndex = 0

         If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            _settings.CompilerPath = dlg.FileName
            _settings.Save(IO.Path.Combine(cap.ApplicationFolderPath, "Settings.xml"))
         End If

      End If

      FillTemplateFolderCombo()

      ptbSourcePath.Path = _settings.TemplateSourcePath
      cboDestination.Text = _settings.TemplateDestinationFolder

      txtAuthorName.Text = _settings.AuthorName
      txtAuthorEMail.Text = _settings.AuthorEMail
      cboResolution.SelectedIndex = _settings.Resolution
      cboFrameRate.SelectedIndex = _settings.Rate

      txtName1.Text = _settings.Name1
      txtName2.Text = _settings.Name2
      txtName3.Text = _settings.Name3
      txtName4.Text = _settings.Name4
      txtName5.Text = _settings.Name5
      txtName6.Text = _settings.Name6
      txtName7.Text = _settings.Name7
      txtName8.Text = _settings.Name8

      txtValue1.Text = _settings.Value1
      txtValue2.Text = _settings.Value2
      txtValue3.Text = _settings.Value3
      txtValue4.Text = _settings.Value4
      txtValue5.Text = _settings.Value5
      txtValue6.Text = _settings.Value6
      txtValue7.Text = _settings.Value7
      txtValue8.Text = _settings.Value8

      txtInvoke1.Text = _settings.Invoke1
      txtInvoke2.Text = _settings.Invoke2

      If _Caspar.Connected Then

         _Middleware_Proc = New Process
         _Middleware_Proc.StartInfo.FileName = _settings.MiddlewarePath
         _Middleware_Proc.StartInfo.WorkingDirectory = IO.Path.GetDirectoryName(_settings.MiddlewarePath)
         _Middleware_Proc.StartInfo.CreateNoWindow = False
         _Middleware_Proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
         _Middleware_Proc.Start()

      End If

   End Sub

   Private Sub SaveData()

      If _settings IsNot Nothing Then

         _settings.TemplateSourcePath = ptbSourcePath.Path
         If cboDestination.SelectedIndex > -1 Then
            _settings.TemplateDestinationFolder = cboDestination.Items(cboDestination.SelectedIndex)
         End If

         _settings.Name1 = txtName1.Text
         _settings.Name2 = txtName2.Text
         _settings.Name3 = txtName3.Text
         _settings.Name4 = txtName4.Text
         _settings.Name5 = txtName5.Text
         _settings.Name6 = txtName6.Text
         _settings.Name7 = txtName7.Text
         _settings.Name8 = txtName8.Text

         _settings.Value1 = txtValue1.Text
         _settings.Value2 = txtValue2.Text
         _settings.Value3 = txtValue3.Text
         _settings.Value4 = txtValue4.Text
         _settings.Value5 = txtValue5.Text
         _settings.Value6 = txtValue6.Text
         _settings.Value7 = txtValue7.Text
         _settings.Value8 = txtValue8.Text

         _settings.Invoke1 = txtInvoke1.Text
         _settings.Invoke2 = txtInvoke2.Text

         Dim cap As CommonApplicationData = New CommonApplicationData("MediaSupport", "TemplateBuilderHost", True)
         _settings.Save(IO.Path.Combine(cap.ApplicationFolderPath, "Settings.xml"))

      End If

   End Sub

   Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

      If _Middleware_Proc IsNot Nothing Then
         Try
            _Middleware_Proc.Kill()
         Catch ex As Exception
            'ignore
         Finally
            _Middleware_Proc.Dispose()
         End Try
      End If

      If _settings IsNot Nothing Then

         If Me.WindowState = FormWindowState.Normal Then
            _settings.MainLocation = Me.Location
            _settings.MainSize = Me.Size
            _settings.MainWindowstate = Me.WindowState
         ElseIf Me.WindowState = FormWindowState.Maximized Then
            _settings.MainWindowstate = Me.WindowState
         End If

         SaveData()

      End If

   End Sub

   Private Sub cboDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestination.SelectedIndexChanged
      FillTemplateCombo()
   End Sub

   Private Sub btnRefreshFolders_Click(sender As Object, e As EventArgs) Handles btnRefreshFolders.Click
      FillTemplateFolderCombo()
   End Sub

   Private Sub mnuFileSettings_Click(sender As Object, e As EventArgs) Handles mnuFileSettings.Click

      Dim dlg As frmSettings = New frmSettings
      dlg.Settings = _settings

      dlg.ShowDialog(Me)

   End Sub

   Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
      Close()
   End Sub

#End Region

#Region "Compiler"

   Private Sub ClearPath(sourcePath As String)

      Dim files() As String = IO.Directory.GetFiles(sourcePath, "*.*")
      For Each fn As String In files
         If IO.File.Exists(fn) Then
            IO.File.Delete(fn)
         End If
      Next

      Dim dirs() As String = IO.Directory.GetDirectories(sourcePath)
      If dirs.Length > 0 Then

         For Each dir As String In dirs
            IO.Directory.Delete(dir, True)
         Next

      End If

   End Sub

   Private Sub CopyPath(sourcePath As String, destPath As String)

      Dim files() As String = IO.Directory.GetFiles(sourcePath, "*.*")
      For Each fn As String In files
         Dim dest As String = IO.Path.Combine(destPath, IO.Path.GetFileName(fn))
         If IO.File.Exists(dest) Then
            IO.File.Delete(dest)
         End If
         IO.File.Copy(fn, dest)
      Next

      Dim dirs() As String = IO.Directory.GetDirectories(sourcePath)
      If dirs.Length > 0 Then

         For Each dir As String In dirs

            Dim newDir As String = IO.Path.Combine(destPath, dir.Substring(sourcePath.Length + 1))
            If Not IO.Directory.Exists(newDir) Then
               IO.Directory.CreateDirectory(newDir)
            End If

            CopyPath(dir, newDir)

         Next

      End If

   End Sub

   Private Sub CopyHelpersToRoot(sourcePath As String, rootPath As String)

      Dim files() As String = IO.Directory.GetFiles(sourcePath, "*_helper.htm*")
      For Each fn As String In files
         Dim dest As String = IO.Path.Combine(rootPath, IO.Path.GetFileName(fn))
         If IO.File.Exists(dest) Then
            IO.File.Delete(dest)
         End If
         IO.File.Copy(fn, dest)
      Next

      Dim dirs() As String = IO.Directory.GetDirectories(sourcePath)
      If dirs.Length > 0 Then

         For Each dir As String In dirs

            CopyHelpersToRoot(dir, rootPath)

         Next

      End If

   End Sub

   Private Sub UpdateXML(sourcePath As String)

      Dim files() As String = IO.Directory.GetFiles(sourcePath, "*.xml")
      For Each fn As String In files
         Try
            Dim doc As XmlDocument = New XmlDocument
            doc.Load(fn)

            For Each root As XmlNode In doc.ChildNodes
               If root.Name.ToLower = "template" Then

                  For Each attr As XmlAttribute In root.Attributes
                     Select Case attr.Name
                        Case "authorName"
                           attr.Value = _settings.AuthorName
                        Case "authorEmail"
                           attr.Value = _settings.AuthorEMail
                        Case "originalWidth"
                           attr.Value = _settings.Width.ToString
                        Case "originalHeight"
                           attr.Value = _settings.Height.ToString
                        Case "originalFrameRate"
                           attr.Value = _settings.FrameRate
                     End Select
                  Next

               End If
            Next

            doc.Save(fn)

         Catch ex As Exception
            txtOutput.Text += vbNewLine + "Error writing XML: " + ex.Message
         End Try

      Next

      Dim dirs() As String = IO.Directory.GetDirectories(sourcePath)
      If dirs.Length > 0 Then

         For Each dir As String In dirs
            UpdateXML(dir)
         Next

      End If

   End Sub

   Private Sub btnCompile_Click(sender As Object, e As EventArgs) Handles btnCompile.Click

      If IO.File.Exists(_settings.CompilerPath) AndAlso IO.Directory.Exists(ptbSourcePath.Path) Then

         Dim complierSourcePath As String = IO.Path.Combine(IO.Path.GetDirectoryName(_settings.CompilerPath), "src")
         ClearPath(complierSourcePath)

         CopyPath(ptbSourcePath.Path, complierSourcePath)

         Dim complierBuildPath As String = IO.Path.Combine(IO.Path.GetDirectoryName(_settings.CompilerPath), "build")
         ClearPath(complierBuildPath)

         Using proc As Process = New Process

            proc.StartInfo.FileName = _settings.CompilerPath
            proc.StartInfo.WorkingDirectory = IO.Path.GetDirectoryName(_settings.CompilerPath)
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            proc.StartInfo.RedirectStandardOutput = True
            proc.StartInfo.RedirectStandardError = True
            proc.Start()

            Dim outStream As StreamReader = proc.StandardOutput
            Dim out As String = outStream.ReadToEnd()

            Dim errStream As StreamReader = proc.StandardError
            Dim err As String = errStream.ReadToEnd()

            If out <> "" Then
               txtOutput.Text = out + vbNewLine + err
            Else
               txtOutput.Text = err
            End If

            proc.WaitForExit()

         End Using

         UpdateXML(complierBuildPath)

         Dim templateDestPath As String = IO.Path.Combine(_settings.CasparTemplatePath, cboDestination.Text.Replace("/", "\"))
         CopyPath(complierBuildPath, templateDestPath)
         If _settings.CopyHelperToRoot Then
            CopyHelpersToRoot(complierBuildPath, _settings.CasparTemplatePath)
         End If

         FillTemplateCombo()

      End If

   End Sub

   Private Sub txtAuthorName_TextChanged(sender As Object, e As EventArgs) Handles txtAuthorName.TextChanged
      _settings.AuthorName = txtAuthorName.Text
   End Sub

   Private Sub txtAuthorEMail_TextChanged(sender As Object, e As EventArgs) Handles txtAuthorEMail.TextChanged
      _settings.AuthorEMail = txtAuthorEMail.Text
   End Sub

   Private Sub cboResolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboResolution.SelectedIndexChanged
      _settings.Resolution = cboResolution.SelectedIndex
   End Sub

   Private Sub cboFrameRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFrameRate.SelectedIndexChanged
      _settings.Rate = cboFrameRate.SelectedIndex
   End Sub


   Private Function GetImageFilename() As String

      Dim dlg As OpenFileDialog = New OpenFileDialog
      dlg.Title = "Load Image"
      dlg.Filter = "Image Files|*.bmp;*.png;*.jpg;*.tif|All Files (*.*)|*.*||"
      dlg.FilterIndex = 0

      If dlg.ShowDialog(Me) = DialogResult.OK Then
         Return New Uri(dlg.FileName).ToString
      Else
         Return ""
      End If

   End Function

   Private Sub btnFile1_Click(sender As Object, e As EventArgs) Handles btnFile1.Click
      txtValue1.Text = GetImageFilename()
   End Sub

   Private Sub btnFile2_Click(sender As Object, e As EventArgs) Handles btnFile2.Click
      txtValue2.Text = GetImageFilename()
   End Sub

   Private Sub btnFile3_Click(sender As Object, e As EventArgs) Handles btnFile3.Click
      txtValue3.Text = GetImageFilename()
   End Sub

   Private Sub btnFile4_Click(sender As Object, e As EventArgs) Handles btnFile4.Click
      txtValue4.Text = GetImageFilename()
   End Sub

   Private Sub btnFile5_Click(sender As Object, e As EventArgs) Handles btnFile5.Click
      txtValue5.Text = GetImageFilename()
   End Sub

   Private Sub btnFile6_Click(sender As Object, e As EventArgs) Handles btnFile6.Click
      txtValue6.Text = GetImageFilename()
   End Sub

   Private Sub btnFile7_Click(sender As Object, e As EventArgs) Handles btnFile7.Click
      txtValue7.Text = GetImageFilename()
   End Sub

   Private Sub btnFile8_Click(sender As Object, e As EventArgs) Handles btnFile8.Click
      txtValue8.Text = GetImageFilename()
   End Sub

#End Region

#Region "CasparCG"

   Private Sub FillTemplateFolderCombo()

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then

         Dim fld As List(Of String) = _Caspar.GetAllTemplateFolderNames()

         cboDestination.Items.Clear()
         For Each s As String In fld
            cboDestination.Items.Add(s)
         Next

      End If

   End Sub

   Private Sub FillTemplateCombo()

      Dim lastIndex As Integer = cboTemplate.SelectedIndex

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected AndAlso cboDestination.SelectedIndex > -1 Then

         Thread.Sleep(250)

         Dim tmps As List(Of String) = _Caspar.GetTemplateNames(cboDestination.Items(cboDestination.SelectedIndex), True, False)
         cboTemplate.Items.Clear()
         For Each s As String In tmps
            cboTemplate.Items.Add(s)
         Next

         If cboTemplate.Items.Count > 1 Then
            If lastIndex >= 0 And lastIndex < cboTemplate.Items.Count Then
               cboTemplate.SelectedIndex = lastIndex
            Else
               cboTemplate.SelectedIndex = 1
            End If
         End If

      End If

   End Sub

   Private Function FillTemplate() As Template

      Dim tmpl As Template = New Template

      tmpl.AddField(txtName1.Text, txtValue1.Text)
      tmpl.AddField(txtName2.Text, txtValue2.Text)
      tmpl.AddField(txtName3.Text, txtValue3.Text)
      tmpl.AddField(txtName4.Text, txtValue4.Text)
      tmpl.AddField(txtName5.Text, txtValue5.Text)
      tmpl.AddField(txtName6.Text, txtValue6.Text)
      tmpl.AddField(txtName7.Text, txtValue7.Text)
      tmpl.AddField(txtName8.Text, txtValue8.Text)

      Return tmpl

   End Function

   Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.CG_Add(_settings.Channel, _settings.Layer, cboTemplate.Items(cboTemplate.SelectedIndex), FillTemplate(), False)
         isLoaded = True
      End If

   End Sub

   Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         If Not isLoaded Then
            _Caspar.CG_Add(_settings.Channel, _settings.Layer, cboTemplate.Items(cboTemplate.SelectedIndex), FillTemplate(), True)
         Else
            _Caspar.CG_Play(_settings.Channel, _settings.Layer)
         End If
         isLoaded = False
      End If

   End Sub

   Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.CG_Next(_settings.Channel, _settings.Layer)
      End If

   End Sub

   Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.CG_Stop(_settings.Channel, _settings.Layer)
      End If

   End Sub

   Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.CG_Update(_settings.Channel, _settings.Layer, FillTemplate())
      End If

   End Sub

   Private Sub lnklblClearLayer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblClearLayer.LinkClicked

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.Clear(_settings.Channel, _settings.Layer)
      End If

   End Sub

   Private Sub lnklblClearChannel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblClearChannel.LinkClicked

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.ClearChannel(_settings.Channel)
      End If

   End Sub


   Private Sub btnInvoke1_Click(sender As Object, e As EventArgs) Handles btnInvoke1.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.CG_Invoke(_settings.Channel, _settings.Layer, txtInvoke1.Text)
      End If

   End Sub

   Private Sub btnInvoke2_Click(sender As Object, e As EventArgs) Handles btnInvoke2.Click

      If _Caspar IsNot Nothing AndAlso _Caspar.Connected Then
         _Caspar.CG_Invoke(_settings.Channel, _settings.Layer, txtInvoke2.Text)
      End If

   End Sub
#End Region

#Region "Utils"

   Private Sub lnklblThumbnail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblThumbnail.LinkClicked
      Cursor = Cursors.WaitCursor
      _Caspar.StartGrab(_settings.Channel, "GRAB", 500, True)
   End Sub


   Private Sub _Caspar_GrabFinish(sender As Object, e As CasparCG.GrabFinishEventArgs) Handles _Caspar.GrabFinish

      Dim bmp As Bitmap = e.Image

      Dim filename As String = IO.Path.Combine(_settings.CasparTemplatePath, cboTemplate.Text.Replace("/", "\"))
      bmp.Save(filename + ".png", Imaging.ImageFormat.Png)

      Dim thumbnail As Bitmap = New Bitmap(177, 100, Imaging.PixelFormat.Format32bppArgb)
      Using graph = Graphics.FromImage(thumbnail)

         graph.DrawImage(bmp, 0, 0, 177, 100)
         thumbnail.Save(filename + "_thumbnail.png", Imaging.ImageFormat.Png)

      End Using

      Cursor = Cursors.Default

   End Sub

   Private Function DocumentPath(sourcePath As String, sb As StringBuilder) As StringBuilder

      Dim imageFilename As String = ""
      Dim metadataFilename As String = ""

      Dim files() As String = Directory.GetFiles(sourcePath, "*.*")
      For Each fn As String In files

         If Not fn.Contains("_thumbnail") Then
            If fn.EndsWith(".png") Then
               imageFilename = fn
            ElseIf fn.EndsWith(".xml") Then
               metadataFilename = fn
            End If
         End If
      Next

      If imageFilename <> "" Or metadataFilename <> "" Then

         If metadataFilename <> "" Then
            sb.AppendLine(String.Format("<h1 style='font-size:16pt;'>{0}</h1>", Path.GetFileNameWithoutExtension(metadataFilename)))
         End If

         If imageFilename <> "" Then
            Dim url As String = New System.Uri(imageFilename).ToString
            sb.Append(String.Format("<img src='{0}' width='320' height='180'>", url))
         End If

         If metadataFilename <> "" Then

            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(metadataFilename)
            Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("parameters/parameter")
            If nodes.Count > 0 Then

               sb.AppendLine("<h2 style='font-size:14pt;'>Data Fields</h2>")
               sb.AppendLine("<table>")

               For Each nd As XmlNode In nodes

                  If Not nd.Attributes.Item(0).Value.StartsWith("astra_") Then

                     sb.AppendLine("<tr>")
                     For Each attr As XmlAttribute In nd.Attributes
                        If attr.Name = "id" Then
                           sb.AppendLine(String.Format("<td style='width:180px;'>{0}</td>", attr.Value))
                        End If
                        If attr.Name = "info" Then
                           sb.AppendLine(String.Format("<td style='width:500px;'>{0}</td>", attr.Value))
                        End If
                     Next
                     sb.AppendLine("</tr>")

                  End If

               Next

               sb.AppendLine("</table>")
               sb.AppendLine("<h2 style='font-size:14pt;'>Description</h2>")
               sb.AppendLine("<p style='font-size:12pt;'>Description goes here.</p>")

            End If

         End If

      End If

      Dim dirs() As String = IO.Directory.GetDirectories(sourcePath)
      If dirs.Length > 0 Then

         For Each dir As String In dirs
            sb = DocumentPath(dir, sb)
         Next

      End If

      Return sb

   End Function

   Private Sub lnklblDocumentation_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblDocumentation.LinkClicked

      Dim dlg As SaveFileDialog = New SaveFileDialog
      dlg.Filter = "HTML Document (*.html)|All Files (*.*)|*.*|"
      dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
      dlg.FilterIndex = 0
      dlg.DefaultExt = ".html"

      If dlg.ShowDialog(Me) = DialogResult.OK Then

         Dim fn As String = dlg.FileName

         Dim templateDestPath As String = IO.Path.Combine(_settings.CasparTemplatePath, cboDestination.Text.Replace("/", "\"))
         Dim sb As StringBuilder = New StringBuilder

         sb.AppendLine("<!DOCTYPE html>")
         sb.AppendLine("<html>")
         sb.AppendLine("   <head>")
         sb.AppendLine("      <meta charset='utf-8'>")
         sb.AppendLine("      <title>Documentation</title>")
         sb.AppendLine("      <style>")
         sb.AppendLine("      img {")
         sb.AppendLine("         border: 1px solid black;")
         sb.AppendLine("      }")
         sb.AppendLine("      table, th, td {")
         sb.AppendLine("         border: 1px solid black;")
         sb.AppendLine("         border-collapse: collapse;")
         sb.AppendLine("      }")
         sb.AppendLine("      </style>")
         sb.AppendLine("   </head>")
         sb.AppendLine("   <body>")

         sb = DocumentPath(templateDestPath, sb)

         sb.AppendLine("   </body>")
         sb.AppendLine("</html>")

         File.WriteAllText(fn, sb.ToString)

      End If

   End Sub


#End Region

End Class
