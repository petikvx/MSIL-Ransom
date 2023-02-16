Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports vHack_Loader.My

Namespace vHack_Loader
	' Token: 0x0200001A RID: 26
	Friend NotInheritable Module Injection
		' Token: 0x0600008E RID: 142
		Public Declare Ansi Function ReadProcessMemory Lib "kernel32" (hProcess As Integer, lpBaseAddress As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpBuffer As String, nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer

		' Token: 0x0600008F RID: 143
		Public Declare Ansi Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpLibFileName As String) As Integer

		' Token: 0x06000090 RID: 144
		Public Declare Ansi Function VirtualAllocEx Lib "kernel32" (hProcess As Integer, lpAddress As Integer, dwSize As Integer, flAllocationType As Integer, flProtect As Integer) As Integer

		' Token: 0x06000091 RID: 145
		Public Declare Ansi Function WriteProcessMemory Lib "kernel32" (hProcess As Integer, lpBaseAddress As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpBuffer As String, nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer

		' Token: 0x06000092 RID: 146
		Public Declare Ansi Function GetProcAddress Lib "kernel32" (hModule As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpProcName As String) As Integer

		' Token: 0x06000093 RID: 147
		Private Declare Ansi Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpModuleName As String) As Integer

		' Token: 0x06000094 RID: 148
		Public Declare Ansi Function CreateRemoteThread Lib "kernel32" (hProcess As Integer, lpThreadAttributes As Integer, dwStackSize As Integer, lpStartAddress As Integer, lpParameter As Integer, dwCreationFlags As Integer, ByRef lpThreadId As Integer) As Integer

		' Token: 0x06000095 RID: 149
		Public Declare Ansi Function OpenProcess Lib "kernel32" (dwDesiredAccess As Integer, bInheritHandle As Integer, dwProcessId As Integer) As Integer

		' Token: 0x06000096 RID: 150
		Private Declare Ansi Function FindWindow Lib "user32" Alias "FindWindowA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpClassName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpWindowName As String) As Integer

		' Token: 0x06000097 RID: 151
		Private Declare Ansi Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (hObject As Integer) As Integer

		' Token: 0x06000098 RID: 152 RVA: 0x00005288 File Offset: 0x00003488
		Public Sub Inject()
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				MyProject.Forms.Main.Timer2.[Stop]()
				Dim processesByName As Process() = Process.GetProcessesByName(Globals.ProcName())
				Injection.TargetProcessHandle = Injection.OpenProcess(42, 0, processesByName(0).Id)
				Injection.pszLibFileRemote = Globals.DLLLocation
				Dim text As String = "Kernel32"
				Dim moduleHandle As Integer = Injection.GetModuleHandle(text)
				Dim text2 As String = "LoadLibraryA"
				Injection.pfnStartAddr = Injection.GetProcAddress(moduleHandle, text2)
				Injection.TargetBufferSize = 1 + Strings.Len(Injection.pszLibFileRemote)
				Dim num2 As Integer = Injection.VirtualAllocEx(Injection.TargetProcessHandle, 0, Injection.TargetBufferSize, 4096, 4)
				Dim targetProcessHandle As Integer = Injection.TargetProcessHandle
				Dim num3 As Integer = num2
				Dim targetBufferSize As Integer = Injection.TargetBufferSize
				Dim num4 As Integer = 0
				Injection.WriteProcessMemory(targetProcessHandle, num3, Injection.pszLibFileRemote, targetBufferSize, num4)
				Dim targetProcessHandle2 As Integer = Injection.TargetProcessHandle
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim num7 As Integer = Injection.pfnStartAddr
				Dim num8 As Integer = num2
				Dim num9 As Integer = 0
				num4 = 0
				Injection.CreateRemoteThread(targetProcessHandle2, num5, num6, num7, num8, num9, num4)
				Injection.CloseHandle(Injection.TargetProcessHandle)
				IL_D0:
				MyProject.Forms.Login.Close()
				GoTo IL_125
				IL_E3:
				num10 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F7:
			Catch obj2 When endfilter((TypeOf obj Is Exception) And (num <> 0) And (num10 = 0))
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E3
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_125:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x04000037 RID: 55
		Private TargetProcessHandle As Integer

		' Token: 0x04000038 RID: 56
		Private pfnStartAddr As Integer

		' Token: 0x04000039 RID: 57
		Private pszLibFileRemote As String

		' Token: 0x0400003A RID: 58
		Private TargetBufferSize As Integer

		' Token: 0x0400003B RID: 59
		Public Const PROCESS_VM_READ As Integer = 16

		' Token: 0x0400003C RID: 60
		Public Const TH32CS_SNAPPROCESS As Integer = 2

		' Token: 0x0400003D RID: 61
		Public Const MEM_COMMIT As Integer = 4096

		' Token: 0x0400003E RID: 62
		Public Const PAGE_READWRITE As Integer = 4

		' Token: 0x0400003F RID: 63
		Public Const PROCESS_CREATE_THREAD As Integer = 2

		' Token: 0x04000040 RID: 64
		Public Const PROCESS_VM_OPERATION As Integer = 8

		' Token: 0x04000041 RID: 65
		Public Const PROCESS_VM_WRITE As Integer = 32

		' Token: 0x04000042 RID: 66
		Private DLLFileName As String

		' Token: 0x04000043 RID: 67
		Private ExeName As String = Path.GetFileNameWithoutExtension(Application.ExecutablePath)
	End Module
End Namespace
