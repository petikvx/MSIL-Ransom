Imports System

Namespace Main.Tools
	' Token: 0x02000028 RID: 40
	Public Class UHWIDEngine
		' Token: 0x17000019 RID: 25
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x00009390 File Offset: 0x00007590
		Public ReadOnly Property SimpleUID As String
			Get
				Return Me._uID
			End Get
		End Property

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x060000DA RID: 218 RVA: 0x000093A8 File Offset: 0x000075A8
		Public ReadOnly Property AdvancedUID As String
			Get
				Return Me._uIDW
			End Get
		End Property

		' Token: 0x060000DB RID: 219 RVA: 0x000026C3 File Offset: 0x000008C3
		Public Sub New()
			Me.doUniqueID()
		End Sub

		' Token: 0x060000DC RID: 220 RVA: 0x000093C0 File Offset: 0x000075C0
		Private Sub doUniqueID()
			Dim diskID As String = DiskID.getDiskID()
			Dim cpuID As String = CpuID.getCpuID()
			Dim windowsID As String = WindowsID.getWindowsID()
			Me._uID = diskID + cpuID
			Me._uIDW = Me._uID + windowsID
		End Sub

		' Token: 0x040000C6 RID: 198
		Private _uID As String

		' Token: 0x040000C7 RID: 199
		Private _uIDW As String
	End Class
End Namespace
