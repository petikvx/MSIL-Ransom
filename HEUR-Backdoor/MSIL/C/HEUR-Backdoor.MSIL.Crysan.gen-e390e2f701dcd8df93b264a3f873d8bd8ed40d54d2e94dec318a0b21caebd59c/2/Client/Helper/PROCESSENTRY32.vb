Imports System
Imports System.Runtime.InteropServices

Namespace Client.Helper
	' Token: 0x0200000B RID: 11
	Public Structure PROCESSENTRY32
		' Token: 0x04000024 RID: 36
		Public dwSize As UInteger

		' Token: 0x04000025 RID: 37
		Public cntUsage As UInteger

		' Token: 0x04000026 RID: 38
		Public th32ProcessID As UInteger

		' Token: 0x04000027 RID: 39
		Public th32DefaultHeapID As IntPtr

		' Token: 0x04000028 RID: 40
		Public th32ModuleID As UInteger

		' Token: 0x04000029 RID: 41
		Public cntThreads As UInteger

		' Token: 0x0400002A RID: 42
		Public th32ParentProcessID As UInteger

		' Token: 0x0400002B RID: 43
		Public pcPriClassBase As Integer

		' Token: 0x0400002C RID: 44
		Public dwFlags As UInteger

		' Token: 0x0400002D RID: 45
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 260)>
		Public szExeFile As String
	End Structure
End Namespace
