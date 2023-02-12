Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Management
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.Devices
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x0200000F RID: 15
	Friend NotInheritable Class SXJylLGRkSghP
		' Token: 0x06000048 RID: 72 RVA: 0x0000286F File Offset: 0x00000A6F
		Public Shared Sub AfvdtDeOuqUqWT()
			If SXJylLGRkSghP.jeNVzYHbQf() OrElse SXJylLGRkSghP.uwPVrcVobWimW() OrElse SXJylLGRkSghP.LiMBvErHaWG() OrElse SXJylLGRkSghP.PcGjaEFrQtsdx() Then
				Process.GetCurrentProcess().Kill()
			End If
			Environment.FailFast(Nothing)
		End Sub

		' Token: 0x06000049 RID: 73 RVA: 0x0000C25C File Offset: 0x0000A45C
		Private Shared Function LiMBvErHaWG() As Boolean
			Try
				If New DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= 61000000000L Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

		' Token: 0x0600004A RID: 74 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		Private Shared Function PcGjaEFrQtsdx() As Boolean
			Try
				If New ComputerInfo().OSFullName.ToLower().Contains(SXJylLGRkSghP.getString_0(107403032)) Then
					Return True
				End If
			Catch
			End Try
			Return False
		End Function

		' Token: 0x0600004B RID: 75 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
		Private Shared Function jeNVzYHbQf() As Boolean
			Try
				Using managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher(SXJylLGRkSghP.getString_0(107403027))
					Using managementObjectCollection As ManagementObjectCollection = managementObjectSearcher.[Get]()
						For Each managementBaseObject As ManagementBaseObject In managementObjectCollection
							Dim text As String = managementBaseObject(SXJylLGRkSghP.getString_0(107403010)).ToString().ToLower()
							If(text = SXJylLGRkSghP.getString_0(107402961) AndAlso managementBaseObject(SXJylLGRkSghP.getString_0(107402932)).ToString().ToUpperInvariant().Contains(SXJylLGRkSghP.getString_0(107402955))) OrElse text.Contains(SXJylLGRkSghP.getString_0(107402942)) OrElse managementBaseObject(SXJylLGRkSghP.getString_0(107402932)).ToString() = SXJylLGRkSghP.getString_0(107402901) Then
								Return True
							End If
						Next
					End Using
				End Using
			Catch
			End Try
			Return False
		End Function

		' Token: 0x0600004C RID: 76 RVA: 0x0000C48C File Offset: 0x0000A68C
		Private Shared Function uwPVrcVobWimW() As Boolean
			Dim flag As Boolean
			Try
				If SXJylLGRkSghP.GetModuleHandle(SXJylLGRkSghP.getString_0(107402916)).ToInt32() <> 0 Then
					flag = True
				Else
					flag = False
				End If
			Catch
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x0600004D RID: 77
		Public Declare Function GetModuleHandle Lib "kernel32.dll" (string_0 As String) As IntPtr

		' Token: 0x0600004F RID: 79 RVA: 0x0000289D File Offset: 0x00000A9D
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(SXJylLGRkSghP))
		End Sub

		' Token: 0x0400008E RID: 142
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
