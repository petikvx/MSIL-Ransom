Imports System
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text

Namespace Client.Algorithm
	' Token: 0x0200001A RID: 26
	Public Class Aes256
		' Token: 0x0600006C RID: 108 RVA: 0x00004580 File Offset: 0x00002780
		Public Sub New(masterKey As String)
			If String.IsNullOrEmpty(masterKey) Then
				Throw New ArgumentException("masterKey can not be null or empty.")
			End If
			Using rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(masterKey, Aes256.Salt, 50000)
				Me._key = rfc2898DeriveBytes.GetBytes(32)
				Me._authKey = rfc2898DeriveBytes.GetBytes(64)
			End Using
		End Sub

		' Token: 0x0600006D RID: 109 RVA: 0x0000234E File Offset: 0x0000054E
		Public Function Encrypt(input As String) As String
			Return Convert.ToBase64String(Me.Encrypt(Encoding.UTF8.GetBytes(input)))
		End Function

		' Token: 0x0600006E RID: 110 RVA: 0x000045F8 File Offset: 0x000027F8
		Public Function Encrypt(input As Byte()) As Byte()
			If input Is Nothing Then
				Throw New ArgumentNullException("input can not be null.")
			End If
			Dim array2 As Byte()
			Using memoryStream As MemoryStream = New MemoryStream()
				memoryStream.Position = 32L
				Using aesCryptoServiceProvider As AesCryptoServiceProvider = New AesCryptoServiceProvider()
					aesCryptoServiceProvider.KeySize = 256
					aesCryptoServiceProvider.BlockSize = 128
					aesCryptoServiceProvider.Mode = CipherMode.CBC
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7
					aesCryptoServiceProvider.Key = Me._key
					aesCryptoServiceProvider.GenerateIV()
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write)
						memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length)
						cryptoStream.Write(input, 0, input.Length)
						cryptoStream.FlushFinalBlock()
						Using hmacsha As HMACSHA256 = New HMACSHA256(Me._authKey)
							Dim array As Byte() = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32)
							memoryStream.Position = 0L
							memoryStream.Write(array, 0, array.Length)
						End Using
					End Using
				End Using
				array2 = memoryStream.ToArray()
			End Using
			Return array2
		End Function

		' Token: 0x0600006F RID: 111 RVA: 0x00002366 File Offset: 0x00000566
		Public Function Decrypt(input As String) As String
			Return Encoding.UTF8.GetString(Me.Decrypt(Convert.FromBase64String(input)))
		End Function

		' Token: 0x06000070 RID: 112 RVA: 0x00004750 File Offset: 0x00002950
		Public Function Decrypt(input As Byte()) As Byte()
			If input Is Nothing Then
				Throw New ArgumentNullException("input can not be null.")
			End If
			Dim array6 As Byte()
			Using memoryStream As MemoryStream = New MemoryStream(input)
				Using aesCryptoServiceProvider As AesCryptoServiceProvider = New AesCryptoServiceProvider()
					aesCryptoServiceProvider.KeySize = 256
					aesCryptoServiceProvider.BlockSize = 128
					aesCryptoServiceProvider.Mode = CipherMode.CBC
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7
					aesCryptoServiceProvider.Key = Me._key
					Using hmacsha As HMACSHA256 = New HMACSHA256(Me._authKey)
						Dim array As Byte() = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32)
						Dim array2 As Byte() = New Byte(31) {}
						memoryStream.Read(array2, 0, array2.Length)
						If Not Me.AreEqual(array, array2) Then
							Throw New CryptographicException("Invalid message authentication code (MAC).")
						End If
					End Using
					Dim array3 As Byte() = New Byte(15) {}
					memoryStream.Read(array3, 0, 16)
					aesCryptoServiceProvider.IV = array3
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read)
						Dim array4 As Byte() = New Byte(memoryStream.Length - 16L + 1L - 1) {}
						Dim array5 As Byte() = New Byte(cryptoStream.Read(array4, 0, array4.Length) - 1) {}
						Buffer.BlockCopy(array4, 0, array5, 0, array5.Length)
						array6 = array5
					End Using
				End Using
			End Using
			Return array6
		End Function

		' Token: 0x06000071 RID: 113 RVA: 0x00004910 File Offset: 0x00002B10
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Function AreEqual(a1 As Byte(), a2 As Byte()) As Boolean
			Dim flag As Boolean = True
			For i As Integer = 0 To a1.Length - 1
				If a1(i) <> a2(i) Then
					flag = False
				End If
			Next
			Return flag
		End Function

		' Token: 0x0400003B RID: 59
		Private Const KeyLength As Integer = 32

		' Token: 0x0400003C RID: 60
		Private Const AuthKeyLength As Integer = 64

		' Token: 0x0400003D RID: 61
		Private Const IvLength As Integer = 16

		' Token: 0x0400003E RID: 62
		Private Const HmacSha256Length As Integer = 32

		' Token: 0x0400003F RID: 63
		Private _key As Byte()

		' Token: 0x04000040 RID: 64
		Private _authKey As Byte()

		' Token: 0x04000041 RID: 65
		Private Shared Salt As Byte() = Encoding.ASCII.GetBytes("DcRatByqwqdanchun")
	End Class
End Namespace
