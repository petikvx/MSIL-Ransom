Imports System
Imports System.Threading

Namespace Client.Helper
	' Token: 0x02000014 RID: 20
	Public Module MutexControl
		' Token: 0x0600005E RID: 94 RVA: 0x00004334 File Offset: 0x00002534
		Public Function CreateMutex() As Boolean
			Dim flag As Boolean
			MutexControl.currentApp = New Mutex(False, Settings.MTX, flag)
			Return flag
		End Function

		' Token: 0x0600005F RID: 95 RVA: 0x000022E6 File Offset: 0x000004E6
		Public Sub CloseMutex()
			If MutexControl.currentApp IsNot Nothing Then
				MutexControl.currentApp.Close()
				MutexControl.currentApp = Nothing
			End If
		End Sub

		' Token: 0x04000032 RID: 50
		Public currentApp As Mutex
	End Module
End Namespace
