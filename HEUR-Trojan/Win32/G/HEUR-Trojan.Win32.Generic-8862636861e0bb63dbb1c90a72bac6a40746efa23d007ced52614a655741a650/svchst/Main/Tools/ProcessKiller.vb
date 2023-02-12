Imports System
Imports System.ComponentModel
Imports System.Diagnostics

Namespace Main.Tools
	' Token: 0x02000018 RID: 24
	Public Class ProcessKiller
		' Token: 0x06000099 RID: 153 RVA: 0x0000740C File Offset: 0x0000560C
		Public Shared Function ProcessCompareProductName(p As Process, match As String) As Boolean
			Dim flag As Boolean
			Try
				flag = p.MainModule.FileVersionInfo.ProductName.ToLower().Equals(match.ToLower())
			Catch ex As Win32Exception
				flag = False
			Catch ex2 As InvalidOperationException
				flag = False
			Catch ex3 As NullReferenceException
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x0600009A RID: 154 RVA: 0x0000747C File Offset: 0x0000567C
		Public Shared Sub ClosingCycle(names As String, dnames As String)
			For Each process As Process In Process.GetProcesses()
				If ProcessKiller.ProcessCompareProductName(process, names.ToLower()) <> process.ProcessName.Contains(dnames) Then
					Try
						process.Kill()
					Catch ex As InvalidOperationException
					Catch ex2 As PlatformNotSupportedException
						Exit Try
					End Try
				End If
			Next
		End Sub
	End Class
End Namespace
