Imports System
Imports System.IO
Imports System.Security.Cryptography

Namespace Main.Tools
	' Token: 0x02000014 RID: 20
	Friend Class CryptoClass
		' Token: 0x06000074 RID: 116 RVA: 0x000068D0 File Offset: 0x00004AD0
		Public Function AES_Encrypt(bytesToBeEncrypted As Byte(), passwordBytes As Byte()) As Byte()
			Dim array As Byte() = Nothing
			Dim array2 As Byte() = New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 }
			Using memoryStream As MemoryStream = New MemoryStream()
				Using rijndaelManaged As RijndaelManaged = New RijndaelManaged()
					rijndaelManaged.KeySize = 256
					rijndaelManaged.BlockSize = 128
					Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(passwordBytes, array2, 1000)
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8)
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8)
					rijndaelManaged.Mode = CipherMode.CBC
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write)
						cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length)
						cryptoStream.Close()
					End Using
					array = memoryStream.ToArray()
				End Using
			End Using
			Return array
		End Function

		' Token: 0x06000075 RID: 117 RVA: 0x000069D0 File Offset: 0x00004BD0
		Public Function AES_Decrypt(bytesToBeDecrypted As Byte(), passwordBytes As Byte()) As Byte()
			Dim array As Byte() = Nothing
			Dim array2 As Byte() = New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 }
			Using memoryStream As MemoryStream = New MemoryStream()
				Using rijndaelManaged As RijndaelManaged = New RijndaelManaged()
					rijndaelManaged.KeySize = 256
					rijndaelManaged.BlockSize = 128
					Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(passwordBytes, array2, 1000)
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8)
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8)
					rijndaelManaged.Mode = CipherMode.CBC
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write)
						cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length)
						cryptoStream.Close()
					End Using
					array = memoryStream.ToArray()
				End Using
			End Using
			Return array
		End Function

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000076 RID: 118 RVA: 0x000024EE File Offset: 0x000006EE
		' (set) Token: 0x06000077 RID: 119 RVA: 0x000024F6 File Offset: 0x000006F6
		Public Property EncryptionKey As String

		' Token: 0x06000078 RID: 120 RVA: 0x000024FF File Offset: 0x000006FF
		Public Sub New()
			Me.EncryptionKey = Me.GenerateRandomString(24)
		End Sub

		' Token: 0x06000079 RID: 121 RVA: 0x00002527 File Offset: 0x00000727
		Public Sub New(encryptionKey As String)
			Me.EncryptionKey = encryptionKey
		End Sub

		' Token: 0x0600007A RID: 122 RVA: 0x00006AD0 File Offset: 0x00004CD0
		Public Sub GenerateKeys(keySize As Integer, <System.Runtime.InteropServices.OutAttribute()> ByRef publicKey As String, <System.Runtime.InteropServices.OutAttribute()> ByRef publicAndPrivateKey As String)
			Using rsacryptoServiceProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider(keySize)
				publicKey = rsacryptoServiceProvider.ToXmlString(False)
				publicAndPrivateKey = rsacryptoServiceProvider.ToXmlString(True)
			End Using
		End Sub

		' Token: 0x0600007B RID: 123 RVA: 0x00006B14 File Offset: 0x00004D14
		Public Function RsaEncryption(data As Byte(), keySize As Integer, publicKeyXml As String) As Byte()
			If data Is Nothing OrElse data.Length = 0 Then
				Throw New ArgumentException("Data are empty", "data")
			End If
			Dim maxDataLength As Integer = Me.GetMaxDataLength(keySize)
			If data.Length > maxDataLength Then
				Throw New ArgumentException(String.Format("Maximum data length is {0}", maxDataLength), "data")
			End If
			If Not Me.IsKeySizeValid(keySize) Then
				Throw New ArgumentException("Key size is not valid", "keySize")
			End If
			If String.IsNullOrEmpty(publicKeyXml) Then
				Throw New ArgumentException("Key is null or empty", "publicKeyXml")
			End If
			Dim array As Byte()
			Using rsacryptoServiceProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider(keySize)
				rsacryptoServiceProvider.FromXmlString(publicKeyXml)
				array = rsacryptoServiceProvider.Encrypt(data, Me._optimalAsymmetricEncryptionPadding)
			End Using
			Return array
		End Function

		' Token: 0x0600007C RID: 124 RVA: 0x00006BE0 File Offset: 0x00004DE0
		Public Function RsaDecryption(data As Byte(), keySize As Integer, publicAndPrivateKeyXml As String) As Byte()
			If data Is Nothing OrElse data.Length = 0 Then
				Throw New ArgumentException("Data are empty", "data")
			End If
			If Not Me.IsKeySizeValid(keySize) Then
				Throw New ArgumentException("Key size is not valid", "keySize")
			End If
			If String.IsNullOrEmpty(publicAndPrivateKeyXml) Then
				Throw New ArgumentException("Key is null or empty", "publicAndPrivateKeyXml")
			End If
			Dim array As Byte()
			Using rsacryptoServiceProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider(keySize)
				rsacryptoServiceProvider.FromXmlString(publicAndPrivateKeyXml)
				array = rsacryptoServiceProvider.Decrypt(data, Me._optimalAsymmetricEncryptionPadding)
			End Using
			Return array
		End Function

		' Token: 0x0600007D RID: 125 RVA: 0x00006C7C File Offset: 0x00004E7C
		Public Sub EncryptFileFully(filePath As String)
			Dim stream As Stream = New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
			Dim array As Byte() = New Byte(stream.Length - 1) {}
			Using binaryReader As BinaryReader = New BinaryReader(stream)
				Using binaryWriter As BinaryWriter = New BinaryWriter(stream)
					binaryReader.BaseStream.Position = 0L
					array = binaryReader.ReadBytes(CInt(stream.Length))
					binaryWriter.BaseStream.Position = 0L
					array = Me.EncodeAob(array, Me.GetBytes(Me.EncryptionKey))
					binaryWriter.Write(array)
				End Using
			End Using
			stream.Close()
			stream.Dispose()
		End Sub

		' Token: 0x0600007E RID: 126 RVA: 0x00006D40 File Offset: 0x00004F40
		Public Sub DecryptFileFully(filePath As String)
			Dim stream As Stream = New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
			Dim array As Byte() = New Byte(stream.Length - 1) {}
			Using binaryReader As BinaryReader = New BinaryReader(stream)
				Using binaryWriter As BinaryWriter = New BinaryWriter(stream)
					binaryReader.BaseStream.Position = 0L
					array = binaryReader.ReadBytes(CInt(stream.Length))
					binaryWriter.BaseStream.Position = 0L
					array = Me.DecodeAob(array, Me.GetBytes(Me.EncryptionKey))
					binaryWriter.Write(array)
				End Using
			End Using
			stream.Close()
			stream.Dispose()
		End Sub

		' Token: 0x0600007F RID: 127 RVA: 0x00006E04 File Offset: 0x00005004
		Public Sub EncryptFilePartially(filePath As String)
			Dim stream As Stream = New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
			Dim array As Byte() = New Byte(1023) {}
			Using binaryReader As BinaryReader = New BinaryReader(stream)
				Using binaryWriter As BinaryWriter = New BinaryWriter(stream)
					binaryReader.BaseStream.Position = 0L
					array = binaryReader.ReadBytes(1024)
					binaryWriter.BaseStream.Position = 0L
					array = Me.EncodeAob(array, Me.GetBytes(Me.EncryptionKey))
					binaryWriter.Write(array)
				End Using
			End Using
			stream.Close()
			stream.Dispose()
		End Sub

		' Token: 0x06000080 RID: 128 RVA: 0x00006EC4 File Offset: 0x000050C4
		Public Sub DecryptFilePartially(filePath As String)
			Dim stream As Stream = New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
			Dim array As Byte() = New Byte(1023) {}
			Using binaryReader As BinaryReader = New BinaryReader(stream)
				Using binaryWriter As BinaryWriter = New BinaryWriter(stream)
					binaryReader.BaseStream.Position = 0L
					array = binaryReader.ReadBytes(1024)
					binaryWriter.BaseStream.Position = 0L
					array = Me.DecodeAob(array, Me.GetBytes(Me.EncryptionKey))
					binaryWriter.Write(array)
				End Using
			End Using
			stream.Close()
			stream.Dispose()
		End Sub

		' Token: 0x06000081 RID: 129 RVA: 0x00006F84 File Offset: 0x00005184
		Private Function EncodeAob(aobToEncode As Byte(), passwordBytes As Byte()) As Byte()
			Dim array As Byte() = New Byte(aobToEncode.Length - 1) {}
			Dim num As Integer = 0
			For i As Integer = 0 To aobToEncode.Length - 1
				array(i) = aobToEncode(i) + passwordBytes(num)
				If passwordBytes(num + 1) = 0 Then
					num = 0
				Else
					num += 1
				End If
			Next
			Return array
		End Function

		' Token: 0x06000082 RID: 130 RVA: 0x00006FD0 File Offset: 0x000051D0
		Private Function DecodeAob(aobToDecode As Byte(), passwordBytes As Byte()) As Byte()
			Dim array As Byte() = New Byte(aobToDecode.Length - 1) {}
			Dim num As Integer = 0
			For i As Integer = 0 To aobToDecode.Length - 1
				array(i) = aobToDecode(i) - passwordBytes(num)
				If passwordBytes(num + 1) = 0 Then
					num = 0
				Else
					num += 1
				End If
			Next
			Return array
		End Function

		' Token: 0x06000083 RID: 131 RVA: 0x0000701C File Offset: 0x0000521C
		Private Function GenerateRandomString(length As Integer) As String
			Dim text As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
			Dim text2 As String = ""
			For i As Integer = 0 To length - 1
				text2 += text(Me._rnd.[Next](text.Length)).ToString()
			Next
			Return text2
		End Function

		' Token: 0x06000084 RID: 132 RVA: 0x00007070 File Offset: 0x00005270
		Private Function GetMaxDataLength(keySize As Integer) As Integer
			Dim num As Integer
			If Me._optimalAsymmetricEncryptionPadding Then
				num = (keySize - 384) / 8 + 7
			Else
				num = (keySize - 384) / 8 + 37
			End If
			Return num
		End Function

		' Token: 0x06000085 RID: 133 RVA: 0x000070A4 File Offset: 0x000052A4
		Private Function IsKeySizeValid(keySize As Integer) As Boolean
			Return keySize >= 384 AndAlso keySize <= 16384 AndAlso keySize Mod 8 = 0
		End Function

		' Token: 0x06000086 RID: 134 RVA: 0x000070CC File Offset: 0x000052CC
		Public Function GetBytes(str As String) As Byte()
			Dim array As Byte() = New Byte(str.Length * 2 - 1) {}
			Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length)
			Return array
		End Function

		' Token: 0x06000087 RID: 135 RVA: 0x000070FC File Offset: 0x000052FC
		Private Function GetString(bytes As Byte()) As String
			Dim array As Char() = New Char(bytes.Length / 2 - 1) {}
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length)
			Return New String(array)
		End Function

		' Token: 0x04000095 RID: 149
		Private _rnd As Random = New Random()

		' Token: 0x04000096 RID: 150
		Private _optimalAsymmetricEncryptionPadding As Boolean = False
	End Class
End Namespace
