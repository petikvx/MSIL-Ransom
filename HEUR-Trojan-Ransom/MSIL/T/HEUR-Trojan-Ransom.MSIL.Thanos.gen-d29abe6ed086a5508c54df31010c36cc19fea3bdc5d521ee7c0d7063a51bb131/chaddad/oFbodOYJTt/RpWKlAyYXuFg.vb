﻿Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace oFbodOYJTt
	' Token: 0x02000016 RID: 22
	Public NotInheritable Class RpWKlAyYXuFg
		Inherits SymmetricAlgorithm

		' Token: 0x0600006D RID: 109 RVA: 0x0000CC50 File Offset: 0x0000AE50
		Public Shared Function pUQagweWpoRi(byte_0 As Byte(), byte_1 As Byte(), byte_2 As Byte()) As Byte()
			Dim array As Byte() = Nothing
			Using rpWKlAyYXuFg As RpWKlAyYXuFg = New RpWKlAyYXuFg()
				Using memoryStream As MemoryStream = New MemoryStream()
					rpWKlAyYXuFg.Key = byte_1
					rpWKlAyYXuFg.IV = byte_2
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, rpWKlAyYXuFg.CreateEncryptor(), CryptoStreamMode.Write)
						cryptoStream.Write(byte_0, 0, byte_0.Length)
						cryptoStream.FlushFinalBlock()
					End Using
					array = memoryStream.ToArray()
				End Using
			End Using
			Return array
		End Function

		' Token: 0x0600006E RID: 110 RVA: 0x0000CD00 File Offset: 0x0000AF00
		Public Sub New()
			Me.LegalBlockSizesValue = New KeySizes() { New KeySizes(512, 512, 0) }
			Me.LegalKeySizesValue = New KeySizes() { New KeySizes(128, 256, 128) }
			Me.BlockSizeValue = 512
			Me.KeySizeValue = 256
			Me.mYtYDbvgMHIPa = 20
		End Sub

		' Token: 0x17000001 RID: 1
		' (get) Token: 0x0600006F RID: 111 RVA: 0x0000296E File Offset: 0x00000B6E
		' (set) Token: 0x06000070 RID: 112 RVA: 0x00002976 File Offset: 0x00000B76
		Public Overrides Property IV As Byte()
			Get
				Return MyBase.IV
			End Get
			Set(value As Byte())
				RpWKlAyYXuFg.YvOvKSFpZqFm(value, RpWKlAyYXuFg.getString_0(107401099))
				Me.IVValue = CType(value.Clone(), Byte())
			End Set
		End Property

		' Token: 0x06000071 RID: 113 RVA: 0x0000299E File Offset: 0x00000B9E
		Public Overrides Function CreateDecryptor(rgbKey As Byte(), rgbIV As Byte()) As ICryptoTransform
			Return Me.CreateEncryptor(rgbKey, rgbIV)
		End Function

		' Token: 0x06000072 RID: 114 RVA: 0x0000CD78 File Offset: 0x0000AF78
		Public Overrides Function CreateEncryptor(rgbKey As Byte(), rgbIV As Byte()) As ICryptoTransform
			If rgbKey Is Nothing Then
				Throw New ArgumentNullException(RpWKlAyYXuFg.getString_0(107401058))
			End If
			If Not MyBase.ValidKeySize(rgbKey.Length * 8) Then
				Throw New CryptographicException(RpWKlAyYXuFg.getString_0(107401049))
			End If
			RpWKlAyYXuFg.YvOvKSFpZqFm(rgbIV, RpWKlAyYXuFg.getString_0(107400988))
			Return New RpWKlAyYXuFg.WquxYoZJZlnnnK(rgbKey, rgbIV, Me.mYtYDbvgMHIPa)
		End Function

		' Token: 0x06000073 RID: 115 RVA: 0x000029A8 File Offset: 0x00000BA8
		Public Overrides Sub GenerateIV()
			Me.IVValue = RpWKlAyYXuFg.CTDVtXwblPyI(8)
		End Sub

		' Token: 0x06000074 RID: 116 RVA: 0x000029B6 File Offset: 0x00000BB6
		Public Overrides Sub GenerateKey()
			Me.KeyValue = RpWKlAyYXuFg.CTDVtXwblPyI(Me.KeySize / 8)
		End Sub

		' Token: 0x06000075 RID: 117 RVA: 0x000029CB File Offset: 0x00000BCB
		Private Shared Sub YvOvKSFpZqFm(byte_0 As Byte(), string_0 As String)
			If byte_0 Is Nothing Then
				Throw New ArgumentNullException(string_0)
			End If
			If byte_0.Length <> 8 Then
				Throw New CryptographicException(RpWKlAyYXuFg.getString_0(107401011))
			End If
		End Sub

		' Token: 0x06000076 RID: 118 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		Private Shared Function CTDVtXwblPyI(int_0 As Integer) As Byte()
			Dim array As Byte() = New Byte(int_0 - 1) {}
			Using randomNumberGenerator As RandomNumberGenerator = New RNGCryptoServiceProvider()
				randomNumberGenerator.GetBytes(array)
			End Using
			Return array
		End Function

		' Token: 0x06000077 RID: 119 RVA: 0x000029F2 File Offset: 0x00000BF2
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(RpWKlAyYXuFg))
		End Sub

		' Token: 0x04000096 RID: 150
		Private mYtYDbvgMHIPa As Integer

		' Token: 0x04000097 RID: 151
		<NonSerialized()>
		Friend Shared getString_0 As GetString

		' Token: 0x02000017 RID: 23
		Private NotInheritable Class WquxYoZJZlnnnK
			Implements ICryptoTransform, IDisposable

			' Token: 0x06000078 RID: 120 RVA: 0x00002A03 File Offset: 0x00000C03
			Public Sub New(byte_0 As Byte(), byte_1 As Byte(), int_0 As Integer)
				Me.Initialize(byte_0, byte_1)
				Me.mYtYDbvgMHIPa = int_0
			End Sub

			' Token: 0x17000005 RID: 5
			' (get) Token: 0x06000079 RID: 121 RVA: 0x00002A1A File Offset: 0x00000C1A
			Public ReadOnly Property CanReuseTransform As Boolean Implements System.Security.Cryptography.ICryptoTransform.CanReuseTransform
				Get
					Return False
				End Get
			End Property

			' Token: 0x17000004 RID: 4
			' (get) Token: 0x0600007A RID: 122 RVA: 0x00002A1D File Offset: 0x00000C1D
			Public ReadOnly Property CanTransformMultipleBlocks As Boolean Implements System.Security.Cryptography.ICryptoTransform.CanTransformMultipleBlocks
				Get
					Return True
				End Get
			End Property

			' Token: 0x17000002 RID: 2
			' (get) Token: 0x0600007B RID: 123 RVA: 0x00002A20 File Offset: 0x00000C20
			Public ReadOnly Property InputBlockSize As Integer Implements System.Security.Cryptography.ICryptoTransform.InputBlockSize
				Get
					Return 64
				End Get
			End Property

			' Token: 0x17000003 RID: 3
			' (get) Token: 0x0600007C RID: 124 RVA: 0x00002A20 File Offset: 0x00000C20
			Public ReadOnly Property OutputBlockSize As Integer Implements System.Security.Cryptography.ICryptoTransform.OutputBlockSize
				Get
					Return 64
				End Get
			End Property

			' Token: 0x0600007D RID: 125 RVA: 0x0000CE24 File Offset: 0x0000B024
			Public Function TransformBlock(inputBuffer As Byte(), inputOffset As Integer, inputCount As Integer, outputBuffer As Byte(), outputOffset As Integer) As Integer Implements System.Security.Cryptography.ICryptoTransform.TransformBlock
				If inputBuffer Is Nothing Then
					Throw New ArgumentNullException(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400935))
				End If
				If inputOffset < 0 OrElse inputOffset >= inputBuffer.Length Then
					Throw New ArgumentOutOfRangeException(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400950))
				End If
				If inputCount < 0 OrElse inputOffset + inputCount > inputBuffer.Length Then
					Throw New ArgumentOutOfRangeException(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400901))
				End If
				If outputBuffer Is Nothing Then
					Throw New ArgumentNullException(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400916))
				End If
				If outputOffset < 0 OrElse outputOffset + inputCount > outputBuffer.Length Then
					Throw New ArgumentOutOfRangeException(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400867))
				End If
				If Me.pfMgqCfTVqZNTr Is Nothing Then
					Throw New ObjectDisposedException(MyBase.[GetType]().Name)
				End If
				Dim array As Byte() = New Byte(63) {}
				Dim num As Integer = 0
				While inputCount > 0
					Me.Hash(array, Me.pfMgqCfTVqZNTr)
					Me.pfMgqCfTVqZNTr(8) = RpWKlAyYXuFg.WquxYoZJZlnnnK.AddOne(Me.pfMgqCfTVqZNTr(8))
					If Me.pfMgqCfTVqZNTr(8) = 0UI Then
						Me.pfMgqCfTVqZNTr(9) = RpWKlAyYXuFg.WquxYoZJZlnnnK.AddOne(Me.pfMgqCfTVqZNTr(9))
					End If
					Dim num2 As Integer = Math.Min(64, inputCount)
					For i As Integer = 0 To num2 - 1
						outputBuffer(outputOffset + i) = inputBuffer(inputOffset + i) Xor array(i)
					Next
					num += num2
					inputCount -= 64
					outputOffset += 64
					inputOffset += 64
				End While
				Return num
			End Function

			' Token: 0x0600007E RID: 126 RVA: 0x0000CF8C File Offset: 0x0000B18C
			Public Function TransformFinalBlock(inputBuffer As Byte(), inputOffset As Integer, inputCount As Integer) As Byte() Implements System.Security.Cryptography.ICryptoTransform.TransformFinalBlock
				If inputCount < 0 Then
					Throw New ArgumentOutOfRangeException(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400901))
				End If
				Dim array As Byte() = New Byte(inputCount - 1) {}
				Me.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0)
				Return array
			End Function

			' Token: 0x0600007F RID: 127 RVA: 0x00002A24 File Offset: 0x00000C24
			Public Sub Dispose() Implements System.IDisposable.Dispose
				If Me.pfMgqCfTVqZNTr IsNot Nothing Then
					Array.Clear(Me.pfMgqCfTVqZNTr, 0, Me.pfMgqCfTVqZNTr.Length)
				End If
				Me.pfMgqCfTVqZNTr = Nothing
			End Sub

			' Token: 0x06000080 RID: 128 RVA: 0x00002A49 File Offset: 0x00000C49
			Private Shared Function Rotate(uint_0 As UInteger, int_0 As Integer) As UInteger
				Return(uint_0 << int_0) Or (uint_0 >> 32 - int_0)
			End Function

			' Token: 0x06000081 RID: 129 RVA: 0x00002A5B File Offset: 0x00000C5B
			Private Shared Function Add(uint_0 As UInteger, uint_1 As UInteger) As UInteger
				Return uint_0 + uint_1
			End Function

			' Token: 0x06000082 RID: 130 RVA: 0x00002A60 File Offset: 0x00000C60
			Private Shared Function AddOne(uint_0 As UInteger) As UInteger
				Return uint_0 + 1UI
			End Function

			' Token: 0x06000083 RID: 131 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
			Private Sub Hash(byte_0 As Byte(), uint_0 As UInteger())
				Dim array As UInteger() = CType(uint_0.Clone(), UInteger())
				For i As Integer = Me.mYtYDbvgMHIPa To 0 + 1 Step -2
					array(4) = array(4) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(0), array(12)), 7)
					array(8) = array(8) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(4), array(0)), 9)
					array(12) = array(12) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(8), array(4)), 13)
					array(0) = array(0) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(12), array(8)), 18)
					array(9) = array(9) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(5), array(1)), 7)
					array(13) = array(13) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(9), array(5)), 9)
					array(1) = array(1) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(13), array(9)), 13)
					array(5) = array(5) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(1), array(13)), 18)
					array(14) = array(14) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(10), array(6)), 7)
					array(2) = array(2) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(14), array(10)), 9)
					array(6) = array(6) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(2), array(14)), 13)
					array(10) = array(10) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(6), array(2)), 18)
					array(3) = array(3) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(15), array(11)), 7)
					array(7) = array(7) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(3), array(15)), 9)
					array(11) = array(11) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(7), array(3)), 13)
					array(15) = array(15) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(11), array(7)), 18)
					array(1) = array(1) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(0), array(3)), 7)
					array(2) = array(2) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(1), array(0)), 9)
					array(3) = array(3) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(2), array(1)), 13)
					array(0) = array(0) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(3), array(2)), 18)
					array(6) = array(6) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(5), array(4)), 7)
					array(7) = array(7) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(6), array(5)), 9)
					array(4) = array(4) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(7), array(6)), 13)
					array(5) = array(5) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(4), array(7)), 18)
					array(11) = array(11) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(10), array(9)), 7)
					array(8) = array(8) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(11), array(10)), 9)
					array(9) = array(9) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(8), array(11)), 13)
					array(10) = array(10) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(9), array(8)), 18)
					array(12) = array(12) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(15), array(14)), 7)
					array(13) = array(13) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(12), array(15)), 9)
					array(14) = array(14) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(13), array(12)), 13)
					array(15) = array(15) Xor RpWKlAyYXuFg.WquxYoZJZlnnnK.Rotate(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(14), array(13)), 18)
				Next
				For j As Integer = 0 To 16 - 1
					RpWKlAyYXuFg.WquxYoZJZlnnnK.ToBytes(RpWKlAyYXuFg.WquxYoZJZlnnnK.Add(array(j), uint_0(j)), byte_0, 4 * j)
				Next
			End Sub

			' Token: 0x06000084 RID: 132 RVA: 0x0000D4DC File Offset: 0x0000B6DC
			Private Sub Initialize(byte_0 As Byte(), byte_1 As Byte())
				Me.pfMgqCfTVqZNTr = New UInteger(15) {}
				Me.pfMgqCfTVqZNTr(1) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, 0)
				Me.pfMgqCfTVqZNTr(2) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, 4)
				Me.pfMgqCfTVqZNTr(3) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, 8)
				Me.pfMgqCfTVqZNTr(4) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, 12)
				Dim array As Byte() = If((byte_0.Length = 32), RpWKlAyYXuFg.WquxYoZJZlnnnK.qWDvnGKTmVeYpN, RpWKlAyYXuFg.WquxYoZJZlnnnK.cZNtwQkRYK)
				Dim num As Integer = byte_0.Length - 16
				Me.pfMgqCfTVqZNTr(11) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, num)
				Me.pfMgqCfTVqZNTr(12) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, num + 4)
				Me.pfMgqCfTVqZNTr(13) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, num + 8)
				Me.pfMgqCfTVqZNTr(14) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_0, num + 12)
				Me.pfMgqCfTVqZNTr(0) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(array, 0)
				Me.pfMgqCfTVqZNTr(5) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(array, 4)
				Me.pfMgqCfTVqZNTr(10) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(array, 8)
				Me.pfMgqCfTVqZNTr(15) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(array, 12)
				Me.pfMgqCfTVqZNTr(6) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_1, 0)
				Me.pfMgqCfTVqZNTr(7) = RpWKlAyYXuFg.WquxYoZJZlnnnK.ToUInt32(byte_1, 4)
				Me.pfMgqCfTVqZNTr(8) = 0UI
				Me.pfMgqCfTVqZNTr(9) = 0UI
			End Sub

			' Token: 0x06000085 RID: 133 RVA: 0x00002A65 File Offset: 0x00000C65
			Private Shared Function ToUInt32(byte_0 As Byte(), int_0 As Integer) As UInteger
				Return CUInt((CInt(byte_0(int_0)) Or (CInt(byte_0(int_0 + 1)) << 8) Or (CInt(byte_0(int_0 + 2)) << 16) Or (CInt(byte_0(int_0 + 3)) << 24)))
			End Function

			' Token: 0x06000086 RID: 134 RVA: 0x00002A84 File Offset: 0x00000C84
			Private Shared Sub ToBytes(uint_0 As UInteger, byte_0 As Byte(), int_0 As Integer)
				byte_0(int_0) = CByte(uint_0)
				byte_0(int_0 + 1) = CByte((uint_0 >> 8))
				byte_0(int_0 + 2) = CByte((uint_0 >> 16))
				byte_0(int_0 + 3) = CByte((uint_0 >> 24))
			End Sub

			' Token: 0x06000087 RID: 135 RVA: 0x0000D608 File Offset: 0x0000B808
			' Note: this type is marked as 'beforefieldinit'.
			Shared Sub New()
				Strings.CreateGetStringDelegate(GetType(RpWKlAyYXuFg.WquxYoZJZlnnnK))
				RpWKlAyYXuFg.WquxYoZJZlnnnK.qWDvnGKTmVeYpN = Encoding.ASCII.GetBytes(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107400882))
				RpWKlAyYXuFg.WquxYoZJZlnnnK.cZNtwQkRYK = Encoding.ASCII.GetBytes(RpWKlAyYXuFg.WquxYoZJZlnnnK.getString_0(107401369))
			End Sub

			' Token: 0x04000098 RID: 152
			Private Shared qWDvnGKTmVeYpN As Byte()

			' Token: 0x04000099 RID: 153
			Private Shared cZNtwQkRYK As Byte()

			' Token: 0x0400009A RID: 154
			Private mYtYDbvgMHIPa As Integer

			' Token: 0x0400009B RID: 155
			Private pfMgqCfTVqZNTr As UInteger()

			' Token: 0x0400009C RID: 156
			<NonSerialized()>
			Friend Shared getString_0 As GetString
		End Class
	End Class
End Namespace
