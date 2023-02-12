Imports System
Imports System.Diagnostics
Imports System.ServiceProcess
Imports System.Text

Namespace Main.Tools
	' Token: 0x0200005B RID: 91
	Friend Class startService
		Inherits ServiceBase

		' Token: 0x060001D4 RID: 468 RVA: 0x000111F0 File Offset: 0x0000F3F0
		Public Shared Sub installService(name As String, displayName As String, binPath As String, userName As String, unecryptedPassword As String, startupType As String)
			Try
				Dim text As String = String.Empty
				If startupType IsNot Nothing Then
					If startupType = "Automatic" Then
						text = "auto"
						GoTo IL_54
					End If
					If startupType = "Disabled" Then
						text = "disabled"
						GoTo IL_54
					End If
					If startupType = "Manual" Then
						text = "demand"
						GoTo IL_54
					End If
				End If
				text = "auto"
				IL_54:
				Dim stringBuilder As StringBuilder = New StringBuilder()
				If name = String.Empty Then
					stringBuilder.AppendFormat("{0} {1} ", "Config", name)
				Else
					stringBuilder.AppendFormat("{0} {1} ", "Create", name)
				End If
				stringBuilder.AppendFormat("binPath= ""{0}""  type= ""interact"" type= ""own"" ", binPath)
				stringBuilder.AppendFormat("displayName= ""{0}""  ", displayName)
				If Not String.IsNullOrEmpty(userName) Then
					stringBuilder.AppendFormat("obj= ""{0}""  ", userName)
				End If
				If Not String.IsNullOrEmpty(unecryptedPassword) AndAlso Not unecryptedPassword.Equals("NT AUTHORITY\Local Service") AndAlso Not unecryptedPassword.Equals("NT AUTHORITY\NetworkService") Then
					stringBuilder.AppendFormat("password= ""{0}""  ", unecryptedPassword)
				End If
				stringBuilder.AppendFormat("start= ""{0}""  ", text)
				Using process As Process = New Process()
					process.StartInfo.FileName = "sc.exe"
					process.StartInfo.Arguments = stringBuilder.ToString()
					process.StartInfo.CreateNoWindow = True
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
					process.StartInfo.UseShellExecute = False
					process.Start()
				End Using
			Catch
			End Try
		End Sub
	End Class
End Namespace
