Imports System
Imports System.Diagnostics
Imports System.Linq
Imports System.Windows.Forms
Imports Main.Tools

Namespace Main
	' Token: 0x0200000B RID: 11
	Friend Module Program
		' Token: 0x0600003C RID: 60 RVA: 0x00005578 File Offset: 0x00003778
		<STAThread()>
		Private Sub Main(args As String())
			Try
				If MutexHelper.CreateMutex(Program.appGuid) Then
					Dim thisprocessname As String = Process.GetCurrentProcess().ProcessName
					If Process.GetProcesses().Count(Function(p As Process) p.ProcessName = thisprocessname) <= 1 Then
						If Not FormGame.IsElevated() AndAlso Config.RunElevated Then
							FormGame.ElevateMe()
						End If
						UtilitiesProcess.Dll()
						Hacking.InitSoftware(Config.StartMode, If((args.Length = 1), args(0), Nothing))
						New FormBackground()
						Application.Run()
					End If
				End If
			Catch
			End Try
		End Sub

		' Token: 0x0400007E RID: 126
		Private appGuid As String = "c1a76b5a-12ab-45c5-b9d9-d692faa6e7b9"
	End Module
End Namespace
