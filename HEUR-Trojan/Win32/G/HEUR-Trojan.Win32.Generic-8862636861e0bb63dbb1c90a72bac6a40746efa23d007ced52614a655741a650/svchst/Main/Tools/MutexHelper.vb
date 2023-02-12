Imports System
Imports System.Threading

Namespace Main.Tools
	' Token: 0x0200001D RID: 29
	Public Module MutexHelper
		' Token: 0x060000B2 RID: 178 RVA: 0x00007B88 File Offset: 0x00005D88
		Public Function CreateMutex(name As String) As Boolean
			Dim flag As Boolean
			MutexHelper._appMutex = New Mutex(False, name, flag)
			Return flag
		End Function

		' Token: 0x060000B3 RID: 179 RVA: 0x00007BA4 File Offset: 0x00005DA4
		Public Sub CloseMutex()
			If MutexHelper._appMutex IsNot Nothing Then
				MutexHelper._appMutex.Close()
				MutexHelper._appMutex = Nothing
			End If
		End Sub

		' Token: 0x040000A8 RID: 168
		Private _appMutex As Mutex
	End Module
End Namespace
