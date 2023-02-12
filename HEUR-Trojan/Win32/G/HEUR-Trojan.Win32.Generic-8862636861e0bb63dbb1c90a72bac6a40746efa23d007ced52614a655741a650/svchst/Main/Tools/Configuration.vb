Imports System

Namespace Main.Tools
	' Token: 0x02000034 RID: 52
	Friend Class Configuration
		' Token: 0x040000DB RID: 219
		Public Shared MessageBoxHeader As String = "Eternal Blues"

		' Token: 0x040000DC RID: 220
		Public Shared MaxComputersToScan As Integer = 16384

		' Token: 0x040000DD RID: 221
		Public Shared RandomId As Integer = New Random().[Next]()

		' Token: 0x040000DE RID: 222
		Public Shared IS_DEBUG As Boolean = False

		' Token: 0x040000DF RID: 223
		Public Shared ReportUsage As Boolean = True
	End Class
End Namespace
