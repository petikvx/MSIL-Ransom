Imports System
Imports System.Security.Cryptography
Imports System.Text

Namespace Main.Tools
	' Token: 0x0200004D RID: 77
	Public Class PKCSKeyGenerator
		' Token: 0x060001A8 RID: 424 RVA: 0x000029AF File Offset: 0x00000BAF
		Public Sub New()
		End Sub

		' Token: 0x060001A9 RID: 425 RVA: 0x000029DA File Offset: 0x00000BDA
		Public Sub New(keystring As String, salt As Byte(), iterationsMd5 As Integer, segments As Integer)
			Me.Generate(keystring, salt, iterationsMd5, segments)
		End Sub

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x060001AA RID: 426 RVA: 0x0000F884 File Offset: 0x0000DA84
		Public ReadOnly Property Key As Byte()
			Get
				Return Me.key
			End Get
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x060001AB RID: 427 RVA: 0x0000F89C File Offset: 0x0000DA9C
		Public ReadOnly Property IV As Byte()
			Get
				Return Me.iv
			End Get
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x060001AC RID: 428 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		Public ReadOnly Property Encryptor As ICryptoTransform
			Get
				Return Me.des.CreateEncryptor(Me.key, Me.iv)
			End Get
		End Property

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x060001AD RID: 429 RVA: 0x0000F8DC File Offset: 0x0000DADC
		Public ReadOnly Property Decryptor As ICryptoTransform
			Get
				Return Me.des.CreateDecryptor(Me.key, Me.iv)
			End Get
		End Property

		' Token: 0x060001AE RID: 430 RVA: 0x0000F904 File Offset: 0x0000DB04
		Public Function Generate(keystring As String, salt As Byte(), iterationsMd5 As Integer, segments As Integer) As ICryptoTransform
			Dim num As Integer = 16
			Dim array As Byte() = New Byte(16 * segments - 1) {}
			Dim bytes As Byte() = Encoding.UTF8.GetBytes(keystring)
			Dim array2 As Byte() = New Byte(bytes.Length + salt.Length - 1) {}
			Array.Copy(bytes, array2, bytes.Length)
			Array.Copy(salt, 0, array2, bytes.Length, salt.Length)
			Dim md As MD5 = New MD5CryptoServiceProvider()
			Dim array3 As Byte() = Nothing
			Dim array4 As Byte() = New Byte(16 + array2.Length - 1) {}
			For i As Integer = 0 To segments - 1
				If i = 0 Then
					array3 = array2
				Else
					Array.Copy(array3, array4, array3.Length)
					Array.Copy(array2, 0, array4, array3.Length, array2.Length)
					array3 = array4
				End If
				For j As Integer = 0 To iterationsMd5 - 1
					array3 = md.ComputeHash(array3)
				Next
				Array.Copy(array3, 0, array, i * num, array3.Length)
			Next
			Array.Copy(array, 0, Me.key, 0, 8)
			Array.Copy(array, 8, Me.iv, 0, 8)
			Return Me.Encryptor
		End Function

		' Token: 0x04000151 RID: 337
		Private key As Byte() = New Byte(7) {}

		' Token: 0x04000152 RID: 338
		Private iv As Byte() = New Byte(7) {}

		' Token: 0x04000153 RID: 339
		Private des As DESCryptoServiceProvider = New DESCryptoServiceProvider()
	End Class
End Namespace
