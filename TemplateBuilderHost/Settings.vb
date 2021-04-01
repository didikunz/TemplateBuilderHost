Imports System.IO
Imports System.Xml.Serialization

<Serializable>
Public Class Settings

   Public Property CompilerPath As String = ""

   Public Property CasparExePath As String
   Public Property Channel As Integer = 1
   Public Property Layer As Integer = 20
   Public Property CasparTemplatePath As String = ""

   Public Property TemplateSourcePath As String = ""
   Public Property TemplateDestinationFolder As String = ""
   Public Property CopyHelperToRoot As Boolean = True



   Public Property AddInfoFieldsMode As CasparObjects.CasparCG.enumAddInfoFieldsType = CasparObjects.CasparCG.enumAddInfoFieldsType.itAveco

   Public Property Name1 As String = "f0"
   Public Property Name2 As String = "f1"
   Public Property Name3 As String = "f2"
   Public Property Name4 As String = "f3"
   Public Property Name5 As String = "f4"
   Public Property Name6 As String = "f5"
   Public Property Name7 As String = "f6"
   Public Property Name8 As String = "f7"

   Public Property Value1 As String = ""
   Public Property Value2 As String = ""
   Public Property Value3 As String = ""
   Public Property Value4 As String = ""
   Public Property Value5 As String = ""
   Public Property Value6 As String = ""
   Public Property Value7 As String = ""
   Public Property Value8 As String = ""

   Public Property Invoke1 As String = "Show"
   Public Property Invoke2 As String = "Hide"

   Public Property AuthorName As String = ""
   Public Property AuthorEMail As String = ""
   Public Property Resolution As Integer = 5
   Public Property Rate As Integer = 5

   Public Property MainLocation() As System.Drawing.Point = New System.Drawing.Point(0, 0)
   Public Property MainSize() As System.Drawing.Size = New System.Drawing.Size(660, 480)
   Public Property MainWindowstate() As System.Windows.Forms.FormWindowState = FormWindowState.Normal

   Public ReadOnly Property Width As Integer
      Get
         Select Case Resolution
            Case 0
               Return 768
            Case 1
               Return 848
            Case 2
               Return 1024
            Case 3
               Return 864
            Case 4
               Return 1280
            Case 5
               Return 1920
            Case 6
               Return 3840
            Case Else
               Return 0
         End Select
      End Get
   End Property

   Public ReadOnly Property Height As Integer
      Get
         Select Case Resolution
            Case 0
               Return 576
            Case 1
               Return 486
            Case 2
               Return 579
            Case 3
               Return 486
            Case 4
               Return 720
            Case 5
               Return 1080
            Case 6
               Return 2160
            Case Else
               Return 0
         End Select
      End Get
   End Property

   Public ReadOnly Property FrameRate As String
      Get
         Select Case Rate
            Case 0
               Return "23.98"
            Case 1
               Return "24"
            Case 2
               Return "25"
            Case 3
               Return "29.98"
            Case 4
               Return "30"
            Case 5
               Return "50"
            Case 6
               Return "59.94"
            Case 7
               Return "60"
            Case Else
               Return "0"
         End Select
      End Get
   End Property

   Public Sub Save(ByVal XMLFile As String)

      Dim wr As StreamWriter = Nothing

      Try
         Dim ser As XmlSerializer = New XmlSerializer(GetType(Settings))
         wr = New StreamWriter(XMLFile)
         ser.Serialize(wr, Me)
      Catch ex As Exception
         Throw (New Exception("WriteToXML: " + ex.Message, ex))
      Finally
         wr.Close()
      End Try

   End Sub

   Private Function ReadFromXML(ByVal XMLFile As String) As Object

      Dim fs As FileStream = Nothing
      Dim obj As Object

      Try
         Dim ser As XmlSerializer = New XmlSerializer(GetType(Settings))
         fs = New FileStream(XMLFile, FileMode.Open)
         obj = ser.Deserialize(fs)
      Catch ex As Exception
         Throw (New Exception("ReadFromXML: " + ex.Message, ex))
      Finally
         fs.Close()
      End Try

      Return obj

   End Function

   Public Sub New()
   End Sub

   Sub New(ByVal XMLFile As String)

      Dim sets As Settings = ReadFromXML(XMLFile)

      CompilerPath = sets.CompilerPath
      CasparExePath = sets.CasparExePath
      Channel = sets.Channel
      Layer = sets.Layer
      CasparTemplatePath = sets.CasparTemplatePath

      TemplateSourcePath = sets.TemplateSourcePath
      TemplateDestinationFolder = sets.TemplateDestinationFolder
      CopyHelperToRoot = sets.CopyHelperToRoot

      AddInfoFieldsMode = sets.AddInfoFieldsMode

      Name1 = sets.Name1
      Name2 = sets.Name2
      Name3 = sets.Name3
      Name4 = sets.Name4
      Name5 = sets.Name5
      Name6 = sets.Name6
      Name7 = sets.Name7
      Name8 = sets.Name8

      Value1 = sets.Value1
      Value2 = sets.Value2
      Value3 = sets.Value3
      Value4 = sets.Value4
      Value5 = sets.Value5
      Value6 = sets.Value6
      Value7 = sets.Value7
      Value8 = sets.Value8

      Invoke1 = sets.Invoke1
      Invoke2 = sets.Invoke2

      AuthorName = sets.AuthorName
      AuthorEMail = sets.AuthorEMail
      Resolution = sets.Resolution
      Rate = sets.Rate

      MainLocation = sets.MainLocation
      MainSize = sets.MainSize
      MainWindowstate = sets.MainWindowstate

   End Sub

End Class
