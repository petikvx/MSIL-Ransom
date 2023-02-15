Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Client.Connection
	' Token: 0x02000007 RID: 7
	Friend Class Win32
		' Token: 0x0600002C RID: 44
		Public Declare Function LoadLibraryA Lib "kernel32" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef Name As String) As IntPtr

		' Token: 0x0600002D RID: 45
		Public Declare Ansi Function GetProcAddress Lib "kernel32" (hProcess As IntPtr, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef Name As String) As IntPtr

		' Token: 0x0600002E RID: 46 RVA: 0x000021A1 File Offset: 0x000003A1
		Public Shared Function LoadApi(Of CreateApi)(name As String, method As String) As CreateApi
			Return CType(CObj(Marshal.GetDelegateForFunctionPointer(Win32.GetProcAddress(Win32.LoadLibraryA(name), method), GetType(CreateApi))), CreateApi)
		End Function

		' Token: 0x04000021 RID: 33
		Public Shared VirtualAllocEx As Win32.DelegateVirtualProtect = Win32.LoadApi(Of Win32.DelegateVirtualProtect)("kernel32", Encoding.[Default].GetString(Convert.FromBase64String("VmlydHVhbFByb3RlY3Q=")))

		' Token: 0x02000008 RID: 8
		' (Invoke) Token: 0x06000032 RID: 50
		Public Delegate Function DelegateVirtualProtect(lpAddress As IntPtr, dwSize As UIntPtr, flNewProtect As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef lpflOldProtect As UInteger) As Integer
	End Class
End Namespace
