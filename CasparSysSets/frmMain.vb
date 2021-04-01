Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frmMain

   Private closeProgram As Boolean = False

   Private WithEvents _timAfterStartup As Timer = New Timer()
   Private WithEvents _timAfterClick As Timer = New Timer()


   Public Enum SPI
      SPI_GETBEEP = &H1
      SPI_SETBEEP = &H2
      SPI_GETMOUSE = &H3
      SPI_SETMOUSE = &H4
      SPI_GETBORDER = &H5
      SPI_SETBORDER = &H6
      SPI_GETKEYBOARDSPEED = &HA
      SPI_SETKEYBOARDSPEED = &HB
      SPI_LANGDRIVER = &HC
      SPI_ICONHORIZONTALSPACING = &HD
      SPI_GETSCREENSAVETIMEOUT = &HE
      SPI_SETSCREENSAVETIMEOUT = &HF
      SPI_GETSCREENSAVEACTIVE = &H10
      SPI_SETSCREENSAVEACTIVE = &H11
      SPI_GETGRIDGRANULARITY = &H12
      SPI_SETGRIDGRANULARITY = &H13
      SPI_SETDESKWALLPAPER = &H14
      SPI_SETDESKPATTERN = &H15
      SPI_GETKEYBOARDDELAY = &H16
      SPI_SETKEYBOARDDELAY = &H17
      SPI_ICONVERTICALSPACING = &H18
      SPI_GETICONTITLEWRAP = &H19
      SPI_SETICONTITLEWRAP = &H1A
      SPI_GETMENUDROPALIGNMENT = &H1B
      SPI_SETMENUDROPALIGNMENT = &H1C
      SPI_SETDOUBLECLKWIDTH = &H1D
      SPI_SETDOUBLECLKHEIGHT = &H1E
      SPI_GETICONTITLELOGFONT = &H1F
      SPI_SETDOUBLECLICKTIME = &H20
      SPI_SETMOUSEBUTTONSWAP = &H21
      SPI_SETICONTITLELOGFONT = &H22
      SPI_GETFASTTASKSWITCH = &H23
      SPI_SETFASTTASKSWITCH = &H24
      SPI_SETDRAGFULLWINDOWS = &H25
      SPI_GETDRAGFULLWINDOWS = &H26
      SPI_GETNONCLIENTMETRICS = &H29
      SPI_SETNONCLIENTMETRICS = &H2A
      SPI_GETMINIMIZEDMETRICS = &H2B
      SPI_SETMINIMIZEDMETRICS = &H2C
      SPI_GETICONMETRICS = &H2D
      SPI_SETICONMETRICS = &H2E
      SPI_SETWORKAREA = &H2F
      SPI_GETWORKAREA = &H30
      SPI_SETPENWINDOWS = &H31
      SPI_GETHIGHCONTRAST = &H42
      SPI_SETHIGHCONTRAST = &H43
      SPI_GETKEYBOARDPREF = &H44
      SPI_SETKEYBOARDPREF = &H45
      SPI_GETSCREENREADER = &H46
      SPI_SETSCREENREADER = &H47
      SPI_GETANIMATION = &H48
      SPI_SETANIMATION = &H49
      SPI_GETFONTSMOOTHING = &H4A
      SPI_SETFONTSMOOTHING = &H4B
      SPI_SETDRAGWIDTH = &H4C
      SPI_SETDRAGHEIGHT = &H4D
      SPI_SETHANDHELD = &H4E
      SPI_GETLOWPOWERTIMEOUT = &H4F
      SPI_GETPOWEROFFTIMEOUT = &H50
      SPI_SETLOWPOWERTIMEOUT = &H51
      SPI_SETPOWEROFFTIMEOUT = &H52
      SPI_GETLOWPOWERACTIVE = &H53
      SPI_GETPOWEROFFACTIVE = &H54
      SPI_SETLOWPOWERACTIVE = &H55
      SPI_SETPOWEROFFACTIVE = &H56
      SPI_SETICONS = &H58
      SPI_GETDEFAULTINPUTLANG = &H59
      SPI_SETDEFAULTINPUTLANG = &H5A
      SPI_SETLANGTOGGLE = &H5B
      SPI_GETWINDOWSEXTENSION = &H5C
      SPI_SETMOUSETRAILS = &H5D
      SPI_GETMOUSETRAILS = &H5E
      SPI_SCREENSAVERRUNNING = &H61
      SPI_GETFILTERKEYS = &H32
      SPI_SETFILTERKEYS = &H33
      SPI_GETTOGGLEKEYS = &H34
      SPI_SETTOGGLEKEYS = &H35
      SPI_GETMOUSEKEYS = &H36
      SPI_SETMOUSEKEYS = &H37
      SPI_GETSHOWSOUNDS = &H38
      SPI_SETSHOWSOUNDS = &H39
      SPI_GETSTICKYKEYS = &H3A
      SPI_SETSTICKYKEYS = &H3B
      SPI_GETACCESSTIMEOUT = &H3C
      SPI_SETACCESSTIMEOUT = &H3D
      SPI_GETSERIALKEYS = &H3E
      SPI_SETSERIALKEYS = &H3F
      SPI_GETSOUNDSENTRY = &H40
      SPI_SETSOUNDSENTRY = &H41
      SPI_GETSNAPTODEFBUTTON = &H5F
      SPI_SETSNAPTODEFBUTTON = &H60
      SPI_GETMOUSEHOVERWIDTH = &H62
      SPI_SETMOUSEHOVERWIDTH = &H63
      SPI_GETMOUSEHOVERHEIGHT = &H64
      SPI_SETMOUSEHOVERHEIGHT = &H65
      SPI_GETMOUSEHOVERTIME = &H66
      SPI_SETMOUSEHOVERTIME = &H67
      SPI_GETWHEELSCROLLLINES = &H68
      SPI_SETWHEELSCROLLLINES = &H69
      SPI_GETMENUSHOWDELAY = &H6A
      SPI_SETMENUSHOWDELAY = &H6B
      SPI_GETSHOWIMEUI = &H6E
      SPI_SETSHOWIMEUI = &H6F
      SPI_GETMOUSESPEED = &H70
      SPI_SETMOUSESPEED = &H71
      SPI_GETSCREENSAVERRUNNING = &H72
      SPI_GETDESKWALLPAPER = &H73
      SPI_GETACTIVEWINDOWTRACKING = &H1000
      SPI_SETACTIVEWINDOWTRACKING = &H1001
      SPI_GETMENUANIMATION = &H1002
      SPI_SETMENUANIMATION = &H1003
      SPI_GETCOMBOBOXANIMATION = &H1004
      SPI_SETCOMBOBOXANIMATION = &H1005
      SPI_GETLISTBOXSMOOTHSCROLLING = &H1006
      SPI_SETLISTBOXSMOOTHSCROLLING = &H1007
      SPI_GETGRADIENTCAPTIONS = &H1008
      SPI_SETGRADIENTCAPTIONS = &H1009
      SPI_GETKEYBOARDCUES = &H100A
      SPI_SETKEYBOARDCUES = &H100B
      SPI_GETMENUUNDERLINES = SPI_GETKEYBOARDCUES
      SPI_SETMENUUNDERLINES = SPI_SETKEYBOARDCUES
      SPI_GETACTIVEWNDTRKZORDER = &H100C
      SPI_SETACTIVEWNDTRKZORDER = &H100D
      SPI_GETHOTTRACKING = &H100E
      SPI_SETHOTTRACKING = &H100F
      SPI_GETMENUFADE = &H1012
      SPI_SETMENUFADE = &H1013
      SPI_GETSELECTIONFADE = &H1014
      SPI_SETSELECTIONFADE = &H1015
      SPI_GETTOOLTIPANIMATION = &H1016
      SPI_SETTOOLTIPANIMATION = &H1017
      SPI_GETTOOLTIPFADE = &H1018
      SPI_SETTOOLTIPFADE = &H1019
      SPI_GETCURSORSHADOW = &H101A
      SPI_SETCURSORSHADOW = &H101B
      SPI_GETMOUSESONAR = &H101C
      SPI_SETMOUSESONAR = &H101D
      SPI_GETMOUSECLICKLOCK = &H101E
      SPI_SETMOUSECLICKLOCK = &H101F
      SPI_GETMOUSEVANISH = &H1020
      SPI_SETMOUSEVANISH = &H1021
      SPI_GETFLATMENU = &H1022
      SPI_SETFLATMENU = &H1023
      SPI_GETDROPSHADOW = &H1024
      SPI_SETDROPSHADOW = &H1025
      SPI_GETBLOCKSENDINPUTRESETS = &H1026
      SPI_SETBLOCKSENDINPUTRESETS = &H1027
      SPI_GETUIEFFECTS = &H103E
      SPI_SETUIEFFECTS = &H103F
      SPI_GETFOREGROUNDLOCKTIMEOUT = &H2000
      SPI_SETFOREGROUNDLOCKTIMEOUT = &H2001
      SPI_GETACTIVEWNDTRKTIMEOUT = &H2002
      SPI_SETACTIVEWNDTRKTIMEOUT = &H2003
      SPI_GETFOREGROUNDFLASHCOUNT = &H2004
      SPI_SETFOREGROUNDFLASHCOUNT = &H2005
      SPI_GETCARETWIDTH = &H2006
      SPI_SETCARETWIDTH = &H2007
      SPI_GETMOUSECLICKLOCKTIME = &H2008
      SPI_SETMOUSECLICKLOCKTIME = &H2009
      SPI_GETFONTSMOOTHINGTYPE = &H200A
      SPI_SETFONTSMOOTHINGTYPE = &H200B
      SPI_GETFONTSMOOTHINGCONTRAST = &H200C
      SPI_SETFONTSMOOTHINGCONTRAST = &H200D
      SPI_GETFOCUSBORDERWIDTH = &H200E
      SPI_SETFOCUSBORDERWIDTH = &H200F
      SPI_GETFOCUSBORDERHEIGHT = &H2010
      SPI_SETFOCUSBORDERHEIGHT = &H2011
      SPI_GETFONTSMOOTHINGORIENTATION = &H2012
      SPI_SETFONTSMOOTHINGORIENTATION = &H2013
   End Enum

   <Flags>
   Public Enum SPIF
      None = &H0
      SPIF_UPDATEINIFILE = &H1  ' Writes the new system-wide parameter setting to the user profile.
      SPIF_SENDCHANGE = &H2  ' Broadcasts the WM_SETTINGCHANGE message after updating the user profile.
      SPIF_SENDWININICHANGE = &H2  ' Same as SPIF_SENDCHANGE.
   End Enum

   Const FE_FONTSMOOTHINGCLEARTYPE = &H2

   Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer,
      ByVal uParam As Integer, ByVal lpvParam As Integer,
      ByVal fuWinIni As Integer) As Integer

   <DllImport("user32", CharSet:=CharSet.Auto)>
   Public Shared Function SystemParametersInfo(
            ByVal intAction As Integer,
            ByVal intParam As Integer,
            ByVal strParam As String,
            ByVal intWinIniFlag As Integer) As Integer
      ' returns non-zero value if function succeeds
   End Function

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

      If SystemInformation.IsFontSmoothingEnabled Then

         btnOn.Enabled = False
         btnOff.Enabled = True
         niTaskbarIcon.BalloonTipText = "Smoothing is ON, used for HTML5."
         niTaskbarIcon.Text = "Smoothing is ON, used for HTML5."

      Else

         btnOff.Enabled = False
         btnOn.Enabled = True
         niTaskbarIcon.BalloonTipText = "Smoothing is OFF, used for Flash."
         niTaskbarIcon.Text = "Smoothing is OFF, used for Flash."

      End If

      _timAfterStartup.Interval = 50
      _timAfterStartup.Start()

   End Sub

   Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
      If WindowState = FormWindowState.Minimized Then
         Hide()
         niTaskbarIcon.Visible = True
      End If
   End Sub

   Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click

      Cursor = Cursors.WaitCursor
      Application.DoEvents()
      btnOff.Enabled = False

      Dim intRet As Integer = SystemParametersInfo(SPI.SPI_SETFONTSMOOTHING, CInt(False), 0, SPIF.SPIF_UPDATEINIFILE Or SPIF.SPIF_SENDCHANGE)
      niTaskbarIcon.BalloonTipText = "Smoothing is OFF, used for Flash."
      niTaskbarIcon.Text = "Smoothing is OFF, used for Flash."

      btnOn.Enabled = True
      Cursor = Cursors.Default
      WindowState = FormWindowState.Minimized

   End Sub

   Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click

      Cursor = Cursors.WaitCursor
      Application.DoEvents()
      btnOn.Enabled = False

      Dim intRet As Integer = SystemParametersInfo(SPI.SPI_SETFONTSMOOTHING, CInt(True), 0, SPIF.SPIF_UPDATEINIFILE Or SPIF.SPIF_SENDCHANGE)
      intRet = SystemParametersInfo(SPI.SPI_SETFONTSMOOTHINGTYPE, 0, FE_FONTSMOOTHINGCLEARTYPE, SPIF.SPIF_UPDATEINIFILE Or SPIF.SPIF_SENDCHANGE)

      btnOff.Enabled = True
      Cursor = Cursors.Default
      WindowState = FormWindowState.Minimized
      niTaskbarIcon.BalloonTipText = "Smoothing is ON, used for HTML5."
      niTaskbarIcon.Text = "Smoothing is ON, used for HTML5."

   End Sub

   Private Sub cntmnuTrayShowUserInterface_Click(sender As Object, e As EventArgs) Handles cntmnuTrayShowUserInterface.Click
      Show()
      WindowState = FormWindowState.Normal
   End Sub

   Private Sub cntmnuTrayExit_Click(sender As Object, e As EventArgs) Handles cntmnuTrayExit.Click
      closeProgram = True
      Close()
   End Sub

   Private Sub niTaskbarIcon_MouseUp(sender As Object, e As MouseEventArgs) Handles niTaskbarIcon.MouseUp

      Dim intRet As Integer

      If e.Button = MouseButtons.Left Then

         Cursor = Cursors.WaitCursor
         Application.DoEvents()

         If SystemInformation.IsFontSmoothingEnabled Then

            intRet = SystemParametersInfo(SPI.SPI_SETFONTSMOOTHING, CInt(False), 0, SPIF.SPIF_UPDATEINIFILE Or SPIF.SPIF_SENDCHANGE)
            niTaskbarIcon.BalloonTipText = "Smoothing is OFF, used for Flash."
            niTaskbarIcon.Text = "Smoothing is OFF, used for Flash."

         Else

            intRet = SystemParametersInfo(SPI.SPI_SETFONTSMOOTHING, CInt(True), 0, SPIF.SPIF_UPDATEINIFILE Or SPIF.SPIF_SENDCHANGE)
            intRet = SystemParametersInfo(SPI.SPI_SETFONTSMOOTHINGTYPE, 0, FE_FONTSMOOTHINGCLEARTYPE, SPIF.SPIF_UPDATEINIFILE Or SPIF.SPIF_SENDCHANGE)
            niTaskbarIcon.BalloonTipText = "Smoothing is ON, used for HTML5."
            niTaskbarIcon.Text = "Smoothing is ON, used for HTML5."

         End If

         Cursor = Cursors.Default

         _timAfterClick.Interval = 50
         _timAfterClick.Start()

      End If

   End Sub

   Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason <> CloseReason.WindowsShutDown Then
         If Not closeProgram Then
            e.Cancel = True
            Hide()
         End If
      End If
   End Sub

   Private Sub _timAfterStartup_Tick(sender As Object, e As EventArgs) Handles _timAfterStartup.Tick
      _timAfterStartup.Stop()
      WindowState = FormWindowState.Minimized
   End Sub

End Class
