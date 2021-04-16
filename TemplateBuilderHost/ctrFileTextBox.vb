Imports System.ComponentModel

<DefaultBindingProperty("Filename"), _
DefaultProperty("Filename"), _
DefaultEvent("OpenFile")> _
Public Class ctrFileTextBox

#Region "Public Declares"

   Public Enum DialogFilterType
      dftImages
      dftInscriberLayouts
      dftXMLFiles
      dftAll
      dftVideoClips
      dftImagesAndVideoClips
      dftTextFiles
      dftAnimations
      dtfNetExtractions
      dtfCustom
      dftNETImages
      dftAccessDB
   End Enum

   Public Enum FileTypes
      ftOther
      ftVideoClips
      ftImages
      ftInscriberLayouts
      ftXMLFiles
      ftTextFiles
      ftAnimations
      ftNetExtractions
   End Enum

   Public Enum enumDialogType
      OpenDialog
      SaveDialog
   End Enum

   'EventArg
   Public Class OpenFileEventArg
      Inherits EventArgs

      Public Filename As String

      Public Sub New(ByVal Filename As String)
         Me.Filename = Filename
      End Sub

   End Class

   Public Delegate Sub OpenFileEventHandler(ByVal sender As Object, ByVal e As OpenFileEventArg)

   Public Event OpenFile As OpenFileEventHandler

#End Region

#Region "Private Vars"

   Private _DialogFilter As DialogFilterType
   Private _CustomDialogFilter As String
   Private _DialogType As enumDialogType = enumDialogType.OpenDialog
   Private _ShowClearButton As Boolean = True
   Private _ToolTipControl As Windows.Forms.ToolTip = Nothing

#End Region

#Region "Accessor Properties"

   Public Property Filename() As String
      Get
         Return txtFileName.Text
      End Get
      Set(ByVal Value As String)
         txtFileName.Text = Value
      End Set
   End Property

   Public Property IntialDirectory() As String
      Get
         Return dlgOpenFile.InitialDirectory
      End Get
      Set(ByVal value As String)
         dlgOpenFile.InitialDirectory = value
         dlgSaveFile.InitialDirectory = value
      End Set
   End Property

   Public Property DialogFilter() As DialogFilterType
      Get
         Return _DialogFilter
      End Get
      Set(ByVal Value As DialogFilterType)
         _DialogFilter = Value
      End Set
   End Property

   Public Property CustomDialogFilter() As String
      Get
         Return _CustomDialogFilter
      End Get
      Set(ByVal value As String)
         _CustomDialogFilter = value
      End Set
   End Property

   Public Property DialogType() As enumDialogType
      Get
         Return _DialogType
      End Get
      Set(ByVal Value As enumDialogType)
         _DialogType = Value
      End Set
   End Property

   Public Property OverwritePrompt() As Boolean
      Get
         Return dlgSaveFile.OverwritePrompt
      End Get
      Set(ByVal Value As Boolean)
         dlgSaveFile.OverwritePrompt = Value
      End Set
   End Property

   Public Property ShowClearButton() As Boolean
      Get
         Return _ShowClearButton
      End Get
      Set(ByVal value As Boolean)
         _ShowClearButton = value
         ctrFileTextBox_Resize(Me, System.EventArgs.Empty)
      End Set
   End Property

   Public Property ToolTipControl() As Windows.Forms.ToolTip
      Get
         Return _ToolTipControl
      End Get
      Set(ByVal value As Windows.Forms.ToolTip)
         _ToolTipControl = value
         If _ToolTipControl IsNot Nothing Then
            If _ToolTipControl.GetToolTip(Me) IsNot Nothing Then
               _ToolTipControl.SetToolTip(txtFileName, _ToolTipControl.GetToolTip(Me))
               _ToolTipControl.SetToolTip(btnClear, _ToolTipControl.GetToolTip(Me))
               _ToolTipControl.SetToolTip(btnFileOpen, _ToolTipControl.GetToolTip(Me))
            End If
         End If
      End Set
   End Property

#End Region

#Region "Private Functions"

#End Region

#Region "Methods"

   Public Shared Function GetFileType(ByVal Filename As String) As FileTypes
      Dim ext As String = Filename.Substring(Filename.LastIndexOf(".") + 1)
      Select Case ext
         Case "bmp", "png", "psd", "jpg", "tga", "lgo", "tif", "vii", "hkf", "rle", "pcd", "vm", "pcx"
            Return FileTypes.ftImages
         Case "ins", "ipacked", "templates", "sly", "icg"
            Return FileTypes.ftInscriberLayouts
         Case "xml"
            Return FileTypes.ftXMLFiles
         Case "avi", "mpg", "mpeg", "wmv"
            Return FileTypes.ftVideoClips
         Case "txt", "asc"
            Return FileTypes.ftTextFiles
         Case "via"
            Return FileTypes.ftAnimations
         Case "nxf"
            Return FileTypes.ftNetExtractions
         Case Else
            Return FileTypes.ftOther
      End Select
   End Function

#End Region

#Region "Form/UserControl Stuff"

   Private Sub btnFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileOpen.Click

      If Me.DialogType = enumDialogType.OpenDialog Then

         dlgOpenFile.FileName = Me.Filename
         Select Case Me.DialogFilter
            Case DialogFilterType.dftImages
               dlgOpenFile.Filter = "Image Files|*.bmp;*.png;*.psd;*.jpg;*.tga;*.lgo;*.tif;*.vii;*.hkf;*.rle;*.pcd;*.vm;*.pcx|All Files (*.*)|*.*||"
            Case DialogFilterType.dftInscriberLayouts
               dlgOpenFile.Filter = "Inscriber Layout Files|*.ins;*.ipacked;*.templates;*.sly;*.icg|All Files (*.*)|*.*||"
            Case DialogFilterType.dftXMLFiles
               dlgOpenFile.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*||"
            Case DialogFilterType.dftAll
               dlgOpenFile.Filter = "All Files (*.*)|*.*||"
            Case DialogFilterType.dftVideoClips
               dlgOpenFile.Filter = "Video Files|*.avi;*.mpg;*.mpeg;*.wmv|All Files (*.*)|*.*||"
            Case DialogFilterType.dftImagesAndVideoClips
               dlgOpenFile.Filter = "Image and Video Files|*.avi;*.mpg;*.mpeg;*.wmv*.bmp;*.png;*.psd;*.jpg;*.tga;*.lgo;*.tif;*.vii;*.hkf;*.rle;*.pcd;*.vm;*.pcx|Video Files|*.avi;*.mpg;*.mpeg;*.wmv|Image Files|*.bmp;*.png;*.psd;*.jpg;*.tga;*.lgo;*.tif;*.vii;*.hkf;*.rle;*.pcd;*.vm;*.pcx|All Files (*.*)|*.*||"
            Case DialogFilterType.dftTextFiles
               dlgOpenFile.Filter = "Text Files (*.txt*)|*.txt|All Files (*.*)|*.*||"
            Case DialogFilterType.dftAnimations
               dlgOpenFile.Filter = "Inscriber Animation Files (*.via)|*.via|All Files (*.*)|*.*||"
            Case DialogFilterType.dtfNetExtractions
               dlgOpenFile.Filter = "NXF Files (*.nxf)|*.nxf|All Files (*.*)|*.*||"
            Case DialogFilterType.dftNETImages
               dlgOpenFile.Filter = "Image Files|*.bmp;*.png;*.jpg;*.tif|All Files (*.*)|*.*||"
            Case DialogFilterType.dftAccessDB
               dlgOpenFile.Filter = "Microsoft-Access-Dateien (*.mdb)|*.mdb|Alle Dateien (*.*)|*.*||"
            Case DialogFilterType.dtfCustom
               dlgOpenFile.Filter = _CustomDialogFilter

         End Select
         dlgOpenFile.FilterIndex = 1

         If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Filename = dlgOpenFile.FileName
            Dim ofea As OpenFileEventArg = New OpenFileEventArg(dlgOpenFile.FileName)
            RaiseEvent OpenFile(Me, ofea)
         End If

      Else

         dlgSaveFile.FileName = Me.Filename
         Select Case Me.DialogFilter
            Case DialogFilterType.dftImages
               dlgSaveFile.Filter = "Image Files|*.bmp;*.png;*.psd;*.jpg;*.tga;*.lgo;*.tif;*.vii;*.hkf;*.rle;*.pcd;*.vm;*.pcx|All Files (*.*)|*.*||"
            Case DialogFilterType.dftInscriberLayouts
               dlgSaveFile.Filter = "Inscriber Layout Files|*.ins;*.ipacked;*.templates;*.sly;*.icg|All Files (*.*)|*.*||"
            Case DialogFilterType.dftXMLFiles
               dlgSaveFile.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*||"
            Case DialogFilterType.dftAll
               dlgSaveFile.Filter = "All Files (*.*)|*.*||"
            Case DialogFilterType.dftVideoClips
               dlgOpenFile.Filter = "Video Files|*.avi;*.mpg;*.mpeg;*.wmv|All Files (*.*)|*.*||"
            Case DialogFilterType.dftImagesAndVideoClips
               dlgOpenFile.Filter = "Image and Video Files|*.avi;*.mpg;*.mpeg;*.wmv*.bmp;*.png;*.psd;*.jpg;*.tga;*.lgo;*.tif;*.vii;*.hkf;*.rle;*.pcd;*.vm;*.pcx|Video Files|*.avi;*.mpg;*.mpeg;*.wmv|Image Files|*.bmp;*.png;*.psd;*.jpg;*.tga;*.lgo;*.tif;*.vii;*.hkf;*.rle;*.pcd;*.vm;*.pcx|All Files (*.*)|*.*||"
            Case DialogFilterType.dftAnimations
               dlgOpenFile.Filter = "Inscriber Animation Files (*.via)|*.via|All Files (*.*)|*.*||"
            Case DialogFilterType.dtfNetExtractions
               dlgOpenFile.Filter = "NXF Files (*.nxf)|*.nxf|All Files (*.*)|*.*||"
            Case DialogFilterType.dftNETImages
               dlgOpenFile.Filter = "Image Files|*.bmp;*.png;*.jpg;*.tif|All Files (*.*)|*.*||"
            Case DialogFilterType.dftAccessDB
               dlgOpenFile.Filter = "Microsoft-Access-Dateien (*.mdb)|*.mdb|Alle Dateien (*.*)|*.*||"
            Case DialogFilterType.dtfCustom
               dlgOpenFile.Filter = _CustomDialogFilter

         End Select
         dlgSaveFile.FilterIndex = 1

         If dlgSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Filename = dlgSaveFile.FileName
            Dim ofea As OpenFileEventArg = New OpenFileEventArg(Me.Filename)
            RaiseEvent OpenFile(Me, ofea)
         End If

      End If

   End Sub

   Private Sub txtFileName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.TextChanged
      Me.Filename = txtFileName.Text
   End Sub

   Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
      Me.Filename = ""
      Dim ofea As OpenFileEventArg = New OpenFileEventArg("")
      RaiseEvent OpenFile(Me, ofea)
   End Sub

   Private Sub ctrFileTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

      btnFileOpen.Left = Me.ClientRectangle.Width - btnFileOpen.Width
      btnClear.Left = btnFileOpen.Left - btnClear.Width - 3
      If _ShowClearButton Then
         btnClear.Visible = True
         txtFileName.Width = btnClear.Left - 3
      Else
         btnClear.Visible = False
         txtFileName.Width = btnFileOpen.Left - 3
      End If

   End Sub

#End Region

#Region "Constructors"

#End Region

End Class
