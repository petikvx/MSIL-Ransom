Imports System
Imports System.Runtime.InteropServices

Namespace Main.Tools
	' Token: 0x02000029 RID: 41
	Public Module CpuID
		' Token: 0x060000DD RID: 221 RVA: 0x00009400 File Offset: 0x00007600
		Public Function getCpuID() As String
			Return CpuID.ProcessorId()
		End Function

		' Token: 0x060000DE RID: 222
		Private Declare Unicode Function CallWindowProcW Lib "user32" (<[In]()> bytes As Byte(), hWnd As IntPtr, msg As Integer, <[In]()> <Out()> wParam As Byte(), lParam As IntPtr) As IntPtr

		' Token: 0x060000DF RID: 223
		Public Declare Unicode Function VirtualProtect Lib "kernel32" (<[In]()> bytes As Byte(), size As IntPtr, newProtect As Integer, <System.Runtime.InteropServices.OutAttribute()> ByRef oldProtect As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x060000E0 RID: 224 RVA: 0x00009414 File Offset: 0x00007614
		Private Function ProcessorId() As String
			Dim array As Byte() = New Byte(7) {}
			Dim text As String
			If Not CpuID.ExecuteCode(array) Then
				text = "ND"
			Else
				text = String.Format("{0}{1}", BitConverter.ToUInt32(array, 4).ToString("X8"), BitConverter.ToUInt32(array, 0).ToString("X8"))
			End If
			Return text
		End Function

		' Token: 0x060000E1 RID: 225 RVA: 0x00009470 File Offset: 0x00007670
		Private Function ExecuteCode(ByRef result As Byte()) As Boolean
			Dim array As Byte() = New Byte() { 85, 137, 229, 87, 139, 125, 16, 106, 1, 88, 83, 15, 162, 137, 7, 137, 87, 4, 91, 95, 137, 236, 93, 194, 16, 0 }
			Dim array2 As Byte() = New Byte() { 83, 72, 199, 192, 1, 0, 0, 0, 15, 162, 65, 137, 0, 65, 137, 80, 4, 91, 195 }
			Dim flag As Boolean
			If CpuID.IsX64Process() Then
				Dim intPtr As IntPtr = New IntPtr(array2.Length)
				Dim num As Integer
				If Not CpuID.VirtualProtect(array2, intPtr, 64, num) Then
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error())
				End If
				intPtr = New IntPtr(result.Length)
				flag = CpuID.CallWindowProcW(array2, IntPtr.Zero, 0, result, intPtr) <> IntPtr.Zero
			Else
				Dim intPtr2 As IntPtr = New IntPtr(array.Length)
				Dim num As Integer
				If Not CpuID.VirtualProtect(array, intPtr2, 64, num) Then
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error())
				End If
				intPtr2 = New IntPtr(result.Length)
				flag = CpuID.CallWindowProcW(array, IntPtr.Zero, 0, result, intPtr2) <> IntPtr.Zero
			End If
			Return flag
		End Function

		' Token: 0x060000E2 RID: 226 RVA: 0x00009548 File Offset: 0x00007748
		Private Function IsX64Process() As Boolean
			Return IntPtr.Size = 8
		End Function

		' Token: 0x040000C8 RID: 200
		Private Const PAGE_EXECUTE_READWRITE As Integer = 64
	End Module
End Namespace
