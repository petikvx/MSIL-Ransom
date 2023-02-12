Imports System
Imports System.IO
Imports System.Security.Cryptography

Namespace SmartAssembly.Zip
	' Token: 0x02000037 RID: 55
	Public Module SimpleZip
		' Token: 0x060000F6 RID: 246 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		Private Function GetAesTransform(byte_0 As Byte(), byte_1 As Byte(), bool_0 As Boolean) As ICryptoTransform
			Dim cryptoTransform As ICryptoTransform
			Using rijndaelManaged As RijndaelManaged = New RijndaelManaged()
				cryptoTransform = If(bool_0, rijndaelManaged.CreateDecryptor(byte_0, byte_1), rijndaelManaged.CreateEncryptor(byte_0, byte_1))
			End Using
			Return cryptoTransform
		End Function

		' Token: 0x060000F7 RID: 247 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		Public Function Unzip(byte_0 As Byte()) As Byte()
			Dim zipStream As SimpleZip.ZipStream = New SimpleZip.ZipStream(byte_0)
			Dim array As Byte() = New Byte(-1) {}
			Dim num As Integer = zipStream.ReadInt()
			Dim num2 As Integer = num >> 24
			If num - (num2 << 24) = 8223355 Then
				Select Case num2
					Case 1
						Dim num3 As Integer = zipStream.ReadInt()
						array = New Byte(num3 - 1) {}
						Dim num5 As Integer
						For i As Integer = 0 To num3 - 1
							Dim num4 As Integer = zipStream.ReadInt()
							num5 = zipStream.ReadInt()
							Dim array2 As Byte() = New Byte(num4 - 1) {}
							zipStream.Read(array2, 0, array2.Length)
							New SimpleZip.Inflater(array2).Inflate(array, i, num5)
						Next
						GoTo IL_116
					Case 3
						Dim array3 As Byte() = New Byte() { 218, 242, 227, 174, 113, 123, 244, 210, 203, 238, 25, 254, 97, Byte.MaxValue, 166, 3 }
						Dim array4 As Byte() = New Byte() { 89, 228, 57, 17, 103, 197, 88, 253, 67, 180, 152, 197, 61, 29, 248, 72 }
						Using aesTransform As ICryptoTransform = SimpleZip.GetAesTransform(array3, array4, True)
							array = SimpleZip.Unzip(aesTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4))
							GoTo IL_116
						End Using
						GoTo IL_10B
				End Select
				Throw New ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.")
				IL_116:
				zipStream.Close()
				zipStream = Nothing
				Return array
			End If
			IL_10B:
			Throw New FormatException("Unknown Header")
		End Function

		' Token: 0x02000038 RID: 56
		Friend NotInheritable Class Inflater
			' Token: 0x060000F8 RID: 248 RVA: 0x00002C77 File Offset: 0x00000E77
			Public Sub New(byte_0 As Byte())
				Me.input = New SimpleZip.StreamManipulator()
				Me.outputWindow = New SimpleZip.OutputWindow()
				Me.mode = 2
				Me.input.SetInput(byte_0, 0, byte_0.Length)
			End Sub

			' Token: 0x060000F9 RID: 249 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
			Private Function DecodeHuffman() As Boolean
				Dim i As Integer = Me.outputWindow.GetFreeSpace()
				While i >= 258
					Dim num As Integer
					Select Case Me.mode
						Case 7
							While True
								Dim symbol As Integer = Me.litlenTree.GetSymbol(Me.input)
								num = symbol
								If(symbol And -256) <> 0 Then
									Exit For
								End If
								Me.outputWindow.Write(num)
								Dim num2 As Integer = i - 1
								i = num2
								If num2 < 258 Then
									Return True
								End If
							End While
							If num >= 257 Then
								Me.repLength = SimpleZip.Inflater.CPLENS(num - 257)
								Me.neededBits = SimpleZip.Inflater.CPLEXT(num - 257)
								GoTo IL_9C
							End If
							If num < 0 Then
								Return False
							End If
							Me.distTree = Nothing
							Me.litlenTree = Nothing
							Me.mode = 2
							Return True
						Case 8
							GoTo IL_9C
						Case 9
							GoTo IL_EC
						Case 10
						Case Else
							Continue While
					End Select
					IL_11F:
					If Me.neededBits > 0 Then
						Me.mode = 10
						Dim num3 As Integer = Me.input.PeekBits(Me.neededBits)
						If num3 < 0 Then
							Return False
						End If
						Me.input.DropBits(Me.neededBits)
						Me.repDist += num3
					End If
					Me.outputWindow.Repeat(Me.repLength, Me.repDist)
					i -= Me.repLength
					Me.mode = 7
					Continue While
					IL_EC:
					num = Me.distTree.GetSymbol(Me.input)
					If num >= 0 Then
						Me.repDist = SimpleZip.Inflater.CPDIST(num)
						Me.neededBits = SimpleZip.Inflater.CPDEXT(num)
						GoTo IL_11F
					End If
					Return False
					IL_9C:
					If Me.neededBits > 0 Then
						Me.mode = 8
						Dim num4 As Integer = Me.input.PeekBits(Me.neededBits)
						If num4 < 0 Then
							Return False
						End If
						Me.input.DropBits(Me.neededBits)
						Me.repLength += num4
					End If
					Me.mode = 9
					GoTo IL_EC
				End While
				Return True
			End Function

			' Token: 0x060000FA RID: 250 RVA: 0x000100C0 File Offset: 0x0000E2C0
			Private Function Decode() As Boolean
				Select Case Me.mode
					Case 2
						If Me.isLastBlock Then
							Me.mode = 12
							Return False
						End If
						Dim num As Integer = Me.input.PeekBits(3)
						If num < 0 Then
							Return False
						End If
						Me.input.DropBits(3)
						If(num And 1) <> 0 Then
							Me.isLastBlock = True
						End If
						Select Case num >> 1
							Case 0
								Me.input.SkipToByteBoundary()
								Me.mode = 3
							Case 1
								Me.litlenTree = SimpleZip.InflaterHuffmanTree.defLitLenTree
								Me.distTree = SimpleZip.InflaterHuffmanTree.defDistTree
								Me.mode = 7
							Case 2
								Me.dynHeader = New SimpleZip.InflaterDynHeader()
								Me.mode = 6
						End Select
						Return True
					Case 3
						Dim num2 As Integer = Me.input.PeekBits(16)
						Dim num3 As Integer = num2
						Me.uncomprLen = num2
						If num3 < 0 Then
							Return False
						End If
						Me.input.DropBits(16)
						Me.mode = 4
					Case 4
					Case 5
						GoTo IL_131
					Case 6
						If Not Me.dynHeader.Decode(Me.input) Then
							Return False
						End If
						Me.litlenTree = Me.dynHeader.BuildLitLenTree()
						Me.distTree = Me.dynHeader.BuildDistTree()
						Me.mode = 7
						GoTo IL_1B5
					Case 7, 8, 9, 10
						GoTo IL_1B5
					Case 11
						Return False
					Case 12
						Return False
					Case Else
						Return False
				End Select
				If Me.input.PeekBits(16) < 0 Then
					Return False
				End If
				Me.input.DropBits(16)
				Me.mode = 5
				IL_131:
				Dim num4 As Integer = Me.outputWindow.CopyStored(Me.input, Me.uncomprLen)
				Me.uncomprLen -= num4
				If Me.uncomprLen = 0 Then
					Me.mode = 2
					Return True
				End If
				Return Not Me.input.IsNeedingInput
				IL_1B5:
				Return Me.DecodeHuffman()
			End Function

			' Token: 0x060000FB RID: 251 RVA: 0x0001028C File Offset: 0x0000E48C
			Public Function Inflate(byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Integer
				Dim num As Integer = 0
				While True
					If Me.mode <> 11 Then
						Dim num2 As Integer = Me.outputWindow.CopyOutput(byte_0, int_0, int_1)
						int_0 += num2
						num += num2
						int_1 -= num2
						If int_1 = 0 Then
							Return num
						End If
					End If
					If Not Me.Decode() Then
						If Me.outputWindow.GetAvailable() <= 0 Then
							Exit For
						End If
						If Me.mode = 11 Then
							Exit For
						End If
					End If
				End While
				Return num
			End Function

			' Token: 0x040000E1 RID: 225
			Private Shared CPLENS As Integer() = New Integer() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 17, 19, 23, 27, 31, 35, 43, 51, 59, 67, 83, 99, 115, 131, 163, 195, 227, 258 }

			' Token: 0x040000E2 RID: 226
			Private Shared CPLEXT As Integer() = New Integer() { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0 }

			' Token: 0x040000E3 RID: 227
			Private Shared CPDIST As Integer() = New Integer() { 1, 2, 3, 4, 5, 7, 9, 13, 17, 25, 33, 49, 65, 97, 129, 193, 257, 385, 513, 769, 1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577 }

			' Token: 0x040000E4 RID: 228
			Private Shared CPDEXT As Integer() = New Integer() { 0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13 }

			' Token: 0x040000E5 RID: 229
			Private mode As Integer

			' Token: 0x040000E6 RID: 230
			Private neededBits As Integer

			' Token: 0x040000E7 RID: 231
			Private repLength As Integer

			' Token: 0x040000E8 RID: 232
			Private repDist As Integer

			' Token: 0x040000E9 RID: 233
			Private uncomprLen As Integer

			' Token: 0x040000EA RID: 234
			Private isLastBlock As Boolean

			' Token: 0x040000EB RID: 235
			Private input As SimpleZip.StreamManipulator

			' Token: 0x040000EC RID: 236
			Private outputWindow As SimpleZip.OutputWindow

			' Token: 0x040000ED RID: 237
			Private dynHeader As SimpleZip.InflaterDynHeader

			' Token: 0x040000EE RID: 238
			Private litlenTree As SimpleZip.InflaterHuffmanTree

			' Token: 0x040000EF RID: 239
			Private distTree As SimpleZip.InflaterHuffmanTree
		End Class

		' Token: 0x02000039 RID: 57
		Friend NotInheritable Class StreamManipulator
			' Token: 0x060000FD RID: 253 RVA: 0x0001035C File Offset: 0x0000E55C
			Public Function PeekBits(int_0 As Integer) As Integer
				If Me.bits_in_buffer < int_0 Then
					If Me.window_start = Me.window_end Then
						Return -1
					End If
					Dim num As UInteger = Me.buffer
					Dim array As Byte() = Me.window
					Dim num2 As Integer = Me.window_start
					Me.window_start = num2 + 1
					Dim num3 As UInteger = array(num2) And 255UI
					Dim array2 As Byte() = Me.window
					num2 = Me.window_start
					Me.window_start = num2 + 1
					Me.buffer = num Or ((num3 Or ((array2(num2) And 255UI) << 8)) << Me.bits_in_buffer)
					Me.bits_in_buffer += 16
				End If
				Return CInt((CULng(Me.buffer) And CULng(CLng(((1 << int_0) - 1)))))
			End Function

			' Token: 0x060000FE RID: 254 RVA: 0x00002CAC File Offset: 0x00000EAC
			Public Sub DropBits(int_0 As Integer)
				Me.buffer >>= int_0
				Me.bits_in_buffer -= int_0
			End Sub

			' Token: 0x1700000F RID: 15
			' (get) Token: 0x060000FF RID: 255 RVA: 0x00002CCD File Offset: 0x00000ECD
			Public ReadOnly Property AvailableBits As Integer
				Get
					Return Me.bits_in_buffer
				End Get
			End Property

			' Token: 0x17000010 RID: 16
			' (get) Token: 0x06000100 RID: 256 RVA: 0x00002CD5 File Offset: 0x00000ED5
			Public ReadOnly Property AvailableBytes As Integer
				Get
					Return Me.window_end - Me.window_start + (Me.bits_in_buffer >> 3)
				End Get
			End Property

			' Token: 0x06000101 RID: 257 RVA: 0x00002CED File Offset: 0x00000EED
			Public Sub SkipToByteBoundary()
				Me.buffer >>= Me.bits_in_buffer And 7
				Me.bits_in_buffer = Me.bits_in_buffer And -8
			End Sub

			' Token: 0x17000011 RID: 17
			' (get) Token: 0x06000102 RID: 258 RVA: 0x00002D16 File Offset: 0x00000F16
			Public ReadOnly Property IsNeedingInput As Boolean
				Get
					Return Me.window_start = Me.window_end
				End Get
			End Property

			' Token: 0x06000103 RID: 259 RVA: 0x000103FC File Offset: 0x0000E5FC
			Public Function CopyBytes(byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Integer
				Dim num As Integer = 0
				While Me.bits_in_buffer > 0 AndAlso int_1 > 0
					Dim num2 As Integer = int_0
					int_0 = num2 + 1
					byte_0(num2) = CByte(Me.buffer)
					Me.buffer >>= 8
					Me.bits_in_buffer -= 8
					int_1 -= 1
					num += 1
				End While
				If int_1 = 0 Then
					Return num
				End If
				Dim num3 As Integer = Me.window_end - Me.window_start
				If int_1 > num3 Then
					int_1 = num3
				End If
				Array.Copy(Me.window, Me.window_start, byte_0, int_0, int_1)
				Me.window_start += int_1
				If((Me.window_start - Me.window_end) And 1) <> 0 Then
					Dim array As Byte() = Me.window
					Dim num4 As Integer = Me.window_start
					Me.window_start = num4 + 1
					Me.buffer = array(num4) And 255UI
					Me.bits_in_buffer = 8
				End If
				Return num + int_1
			End Function

			' Token: 0x06000104 RID: 260 RVA: 0x000104CC File Offset: 0x0000E6CC
			Public Sub SetInput(byte_0 As Byte(), int_0 As Integer, int_1 As Integer)
				If Me.window_start < Me.window_end Then
					Throw New InvalidOperationException()
				End If
				Dim num As Integer = int_0 + int_1
				If 0 <= int_0 AndAlso int_0 <= num AndAlso num <= byte_0.Length Then
					If(int_1 And 1) <> 0 Then
						Dim num2 As UInteger = Me.buffer
						Dim num3 As Integer = int_0
						int_0 = num3 + 1
						Me.buffer = num2 Or CUInt((CUInt((byte_0(num3) And Byte.MaxValue)) << Me.bits_in_buffer))
						Me.bits_in_buffer += 8
					End If
					Me.window = byte_0
					Me.window_start = int_0
					Me.window_end = num
					Return
				End If
				Throw New ArgumentOutOfRangeException()
			End Sub

			' Token: 0x040000F0 RID: 240
			Private window As Byte()

			' Token: 0x040000F1 RID: 241
			Private window_start As Integer

			' Token: 0x040000F2 RID: 242
			Private window_end As Integer

			' Token: 0x040000F3 RID: 243
			Private buffer As UInteger

			' Token: 0x040000F4 RID: 244
			Private bits_in_buffer As Integer
		End Class

		' Token: 0x0200003A RID: 58
		Friend NotInheritable Class OutputWindow
			' Token: 0x06000106 RID: 262 RVA: 0x00010554 File Offset: 0x0000E754
			Public Sub Write(int_0 As Integer)
				Dim num As Integer = Me.windowFilled
				Me.windowFilled = num + 1
				If num = 32768 Then
					Throw New InvalidOperationException()
				End If
				Dim array As Byte() = Me.window
				num = Me.windowEnd
				Me.windowEnd = num + 1
				array(num) = CByte(int_0)
				Me.windowEnd = Me.windowEnd And 32767
			End Sub

			' Token: 0x06000107 RID: 263 RVA: 0x000105AC File Offset: 0x0000E7AC
			Private Sub SlowRepeat(int_0 As Integer, int_1 As Integer)
				While True
					Dim num As Integer = int_1
					int_1 = num - 1
					If num <= 0 Then
						Exit For
					End If
					Dim array As Byte() = Me.window
					Dim num2 As Integer = Me.windowEnd
					Me.windowEnd = num2 + 1
					Dim num3 As Integer = num2
					Dim array2 As Byte() = Me.window
					Dim num4 As Integer = int_0
					int_0 = num4 + 1
					array(num3) = array2(num4)
					Me.windowEnd = Me.windowEnd And 32767
					int_0 = int_0 And 32767
				End While
			End Sub

			' Token: 0x06000108 RID: 264 RVA: 0x00010608 File Offset: 0x0000E808
			Public Sub Repeat(int_0 As Integer, int_1 As Integer)
				Dim num As Integer = Me.windowFilled + int_0
				Dim num2 As Integer = num
				Me.windowFilled = num
				If num2 > 32768 Then
					Throw New InvalidOperationException()
				End If
				Dim num3 As Integer = (Me.windowEnd - int_1) And 32767
				Dim num4 As Integer = 32768 - int_0
				If num3 > num4 OrElse Me.windowEnd >= num4 Then
					Me.SlowRepeat(num3, int_0)
					Return
				End If
				If int_0 <= int_1 Then
					Array.Copy(Me.window, num3, Me.window, Me.windowEnd, int_0)
					Me.windowEnd += int_0
					Return
				End If
				While True
					Dim num5 As Integer = int_0
					int_0 = num5 - 1
					If num5 <= 0 Then
						Exit For
					End If
					Dim array As Byte() = Me.window
					num2 = Me.windowEnd
					Me.windowEnd = num2 + 1
					Dim num6 As Integer = num2
					Dim array2 As Byte() = Me.window
					Dim num7 As Integer = num3
					num3 = num7 + 1
					array(num6) = array2(num7)
				End While
			End Sub

			' Token: 0x06000109 RID: 265 RVA: 0x000106BC File Offset: 0x0000E8BC
			Public Function CopyStored(streamManipulator_0 As SimpleZip.StreamManipulator, int_0 As Integer) As Integer
				int_0 = Math.Min(Math.Min(int_0, 32768 - Me.windowFilled), streamManipulator_0.AvailableBytes)
				Dim num As Integer = 32768 - Me.windowEnd
				Dim num2 As Integer
				If int_0 > num Then
					num2 = streamManipulator_0.CopyBytes(Me.window, Me.windowEnd, num)
					If num2 = num Then
						num2 += streamManipulator_0.CopyBytes(Me.window, 0, int_0 - num)
					End If
				Else
					num2 = streamManipulator_0.CopyBytes(Me.window, Me.windowEnd, int_0)
				End If
				Me.windowEnd = (Me.windowEnd + num2) And 32767
				Me.windowFilled += num2
				Return num2
			End Function

			' Token: 0x0600010A RID: 266 RVA: 0x00002D26 File Offset: 0x00000F26
			Public Function GetFreeSpace() As Integer
				Return 32768 - Me.windowFilled
			End Function

			' Token: 0x0600010B RID: 267 RVA: 0x00002D34 File Offset: 0x00000F34
			Public Function GetAvailable() As Integer
				Return Me.windowFilled
			End Function

			' Token: 0x0600010C RID: 268 RVA: 0x00010760 File Offset: 0x0000E960
			Public Function CopyOutput(byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Integer
				Dim num As Integer = Me.windowEnd
				If int_1 > Me.windowFilled Then
					int_1 = Me.windowFilled
				Else
					num = (Me.windowEnd - Me.windowFilled + int_1) And 32767
				End If
				Dim num2 As Integer = int_1
				Dim num3 As Integer = int_1 - num
				If num3 > 0 Then
					Array.Copy(Me.window, 32768 - num3, byte_0, int_0, num3)
					int_0 += num3
					int_1 = num
				End If
				Array.Copy(Me.window, num - int_1, byte_0, int_0, int_1)
				Me.windowFilled -= num2
				If Me.windowFilled < 0 Then
					Throw New InvalidOperationException()
				End If
				Return num2
			End Function

			' Token: 0x040000F5 RID: 245
			Private window As Byte() = New Byte(32767) {}

			' Token: 0x040000F6 RID: 246
			Private windowEnd As Integer

			' Token: 0x040000F7 RID: 247
			Private windowFilled As Integer
		End Class

		' Token: 0x0200003B RID: 59
		Friend NotInheritable Class InflaterHuffmanTree
			' Token: 0x0600010E RID: 270 RVA: 0x000107F4 File Offset: 0x0000E9F4
			Shared Sub New()
				Dim array As Byte() = New Byte(287) {}
				Dim i As Integer = 0
				While i < 144
					Dim array2 As Byte() = array
					Dim num As Integer = i
					i = num + 1
					array2(num) = 8
				End While
				While i < 256
					Dim array3 As Byte() = array
					Dim num2 As Integer = i
					i = num2 + 1
					array3(num2) = 9
				End While
				While i < 280
					Dim array4 As Byte() = array
					Dim num3 As Integer = i
					i = num3 + 1
					array4(num3) = 7
				End While
				While i < 288
					Dim array5 As Byte() = array
					Dim num4 As Integer = i
					i = num4 + 1
					array5(num4) = 8
				End While
				SimpleZip.InflaterHuffmanTree.defLitLenTree = New SimpleZip.InflaterHuffmanTree(array)
				array = New Byte(31) {}
				i = 0
				While i < 32
					Dim array6 As Byte() = array
					Dim num5 As Integer = i
					i = num5 + 1
					array6(num5) = 5
				End While
				SimpleZip.InflaterHuffmanTree.defDistTree = New SimpleZip.InflaterHuffmanTree(array)
			End Sub

			' Token: 0x0600010F RID: 271 RVA: 0x00002D54 File Offset: 0x00000F54
			Public Sub New(byte_0 As Byte())
				Me.BuildTree(byte_0)
			End Sub

			' Token: 0x06000110 RID: 272 RVA: 0x00010888 File Offset: 0x0000EA88
			Private Sub BuildTree(byte_0 As Byte())
				Dim array As Integer() = New Integer(15) {}
				Dim array2 As Integer() = New Integer(15) {}
				For Each num As Integer In byte_0
					If num > 0 Then
						array(num) += 1
					End If
				Next
				Dim num2 As Integer = 0
				Dim num3 As Integer = 512
				For j As Integer = 1 To 15
					array2(j) = num2
					num2 += array(j) << 16 - j
					If j >= 10 Then
						Dim num4 As Integer = array2(j) And 130944
						Dim num5 As Integer = num2 And 130944
						num3 += num5 - num4 >> 16 - j
					End If
				Next
				Me.tree = New Short(num3 - 1) {}
				Dim num6 As Integer = 512
				For k As Integer = 15 To 10 Step -1
					Dim num7 As Integer = num2 And 130944
					num2 -= array(k) << 16 - k
					For l As Integer = num2 And 130944 To num7 - 1 Step 128
						Me.tree(CInt(SimpleZip.DeflaterHuffman.BitReverse(l))) = CShort(((-num6 << 4) Or k))
						num6 += 1 << k - 9
					Next
				Next
				For m As Integer = 0 To byte_0.Length - 1
					Dim num8 As Integer = CInt(byte_0(m))
					If num8 <> 0 Then
						num2 = array2(num8)
						Dim num9 As Integer = CInt(SimpleZip.DeflaterHuffman.BitReverse(num2))
						If num8 <= 9 Then
							Do
								Me.tree(num9) = CShort(((m << 4) Or num8))
								num9 += 1 << num8
							Loop While num9 < 512
						Else
							Dim num10 As Integer = CInt(Me.tree(num9 And 511))
							Dim num11 As Integer = 1 << (num10 And 15)
							num10 = -(num10 >> 4)
							Do
								Me.tree(num10 Or (num9 >> 9)) = CShort(((m << 4) Or num8))
								num9 += 1 << num8
							Loop While num9 < num11
						End If
						array2(num8) = num2 + (1 << 16 - num8)
					End If
				Next
			End Sub

			' Token: 0x06000111 RID: 273 RVA: 0x00010A68 File Offset: 0x0000EC68
			Public Function GetSymbol(streamManipulator_0 As SimpleZip.StreamManipulator) As Integer
				Dim num As Integer = streamManipulator_0.PeekBits(9)
				Dim num2 As Integer = num
				If num >= 0 Then
					Dim num3 As Short = Me.tree(num2)
					Dim num4 As Integer = CInt(num3)
					If num3 >= 0S Then
						streamManipulator_0.DropBits(num4 And 15)
						Return num4 >> 4
					End If
					Dim num5 As Integer = -(num4 >> 4)
					Dim num6 As Integer = num4 And 15
					Dim num7 As Integer = streamManipulator_0.PeekBits(num6)
					num2 = num7
					If num7 >= 0 Then
						num4 = CInt(Me.tree(num5 Or (num2 >> 9)))
						streamManipulator_0.DropBits(num4 And 15)
						Return num4 >> 4
					End If
					Dim availableBits As Integer = streamManipulator_0.AvailableBits
					num2 = streamManipulator_0.PeekBits(availableBits)
					num4 = CInt(Me.tree(num5 Or (num2 >> 9)))
					If(num4 And 15) <= availableBits Then
						streamManipulator_0.DropBits(num4 And 15)
						Return num4 >> 4
					End If
					Return -1
				Else
					Dim availableBits2 As Integer = streamManipulator_0.AvailableBits
					num2 = streamManipulator_0.PeekBits(availableBits2)
					Dim num4 As Integer = CInt(Me.tree(num2))
					If num4 >= 0 AndAlso (num4 And 15) <= availableBits2 Then
						streamManipulator_0.DropBits(num4 And 15)
						Return num4 >> 4
					End If
					Return -1
				End If
			End Function

			' Token: 0x040000F8 RID: 248
			Private tree As Short()

			' Token: 0x040000F9 RID: 249
			Public Shared defLitLenTree As SimpleZip.InflaterHuffmanTree

			' Token: 0x040000FA RID: 250
			Public Shared defDistTree As SimpleZip.InflaterHuffmanTree
		End Class

		' Token: 0x0200003C RID: 60
		Friend NotInheritable Class InflaterDynHeader
			' Token: 0x06000112 RID: 274 RVA: 0x00010B40 File Offset: 0x0000ED40
			Public Function Decode(streamManipulator_0 As SimpleZip.StreamManipulator) As Boolean
				While True
					Select Case Me.mode
						Case 0
							Me.lnum = streamManipulator_0.PeekBits(5)
							If Me.lnum >= 0 Then
								Me.lnum += 257
								streamManipulator_0.DropBits(5)
								Me.mode = 1
								GoTo IL_1E0
							End If
							Return False
						Case 1
							GoTo IL_1E0
						Case 2
							GoTo IL_192
						Case 3
							GoTo IL_159
						Case 4
						Case 5
							GoTo IL_2A
						Case Else
							Continue For
					End Select
					Dim num As Integer
					While True
						IL_E4:
						Dim symbol As Integer = Me.blTree.GetSymbol(streamManipulator_0)
						num = symbol
						If(symbol And -16) <> 0 Then
							Exit For
						End If
						Dim array As Byte() = Me.litdistLens
						Dim num2 As Integer = Me.ptr
						Me.ptr = num2 + 1
						Dim num3 As Integer = num2
						Dim b As Byte = CByte(num)
						Dim b2 As Byte = b
						Me.lastLen = b
						array(num3) = b2
						If Me.ptr = Me.num Then
							Return True
						End If
					End While
					If num >= 0 Then
						If num >= 17 Then
							Me.lastLen = 0
						End If
						Me.repSymbol = num - 16
						Me.mode = 5
						GoTo IL_2A
					End If
					Return False
					IL_159:
					While Me.ptr < Me.blnum
						Dim num4 As Integer = streamManipulator_0.PeekBits(3)
						If num4 < 0 Then
							Return False
						End If
						streamManipulator_0.DropBits(3)
						Me.blLens(SimpleZip.InflaterDynHeader.BL_ORDER(Me.ptr)) = CByte(num4)
						Me.ptr += 1
					End While
					Me.blTree = New SimpleZip.InflaterHuffmanTree(Me.blLens)
					Me.blLens = Nothing
					Me.ptr = 0
					Me.mode = 4
					GoTo IL_E4
					IL_2A:
					Dim num5 As Integer = SimpleZip.InflaterDynHeader.repBits(Me.repSymbol)
					Dim num6 As Integer = streamManipulator_0.PeekBits(num5)
					If num6 < 0 Then
						Return False
					End If
					streamManipulator_0.DropBits(num5)
					num6 += SimpleZip.InflaterDynHeader.repMin(Me.repSymbol)
					While True
						Dim num7 As Integer = num6
						num6 = num7 - 1
						If num7 <= 0 Then
							Exit For
						End If
						Dim array2 As Byte() = Me.litdistLens
						Dim num2 As Integer = Me.ptr
						Me.ptr = num2 + 1
						array2(num2) = Me.lastLen
					End While
					If Me.ptr = Me.num Then
						Exit For
					End If
					Me.mode = 4
					Continue For
					IL_192:
					Me.blnum = streamManipulator_0.PeekBits(4)
					If Me.blnum >= 0 Then
						Me.blnum += 4
						streamManipulator_0.DropBits(4)
						Me.blLens = New Byte(18) {}
						Me.ptr = 0
						Me.mode = 3
						GoTo IL_159
					End If
					Return False
					IL_1E0:
					Me.dnum = streamManipulator_0.PeekBits(5)
					If Me.dnum >= 0 Then
						Me.dnum += 1
						streamManipulator_0.DropBits(5)
						Me.num = Me.lnum + Me.dnum
						Me.litdistLens = New Byte(Me.num - 1) {}
						Me.mode = 2
						GoTo IL_192
					End If
					Return False
				End While
				Return True
			End Function

			' Token: 0x06000113 RID: 275 RVA: 0x00010DDC File Offset: 0x0000EFDC
			Public Function BuildLitLenTree() As SimpleZip.InflaterHuffmanTree
				Dim array As Byte() = New Byte(Me.lnum - 1) {}
				Array.Copy(Me.litdistLens, 0, array, 0, Me.lnum)
				Return New SimpleZip.InflaterHuffmanTree(array)
			End Function

			' Token: 0x06000114 RID: 276 RVA: 0x00010E10 File Offset: 0x0000F010
			Public Function BuildDistTree() As SimpleZip.InflaterHuffmanTree
				Dim array As Byte() = New Byte(Me.dnum - 1) {}
				Array.Copy(Me.litdistLens, Me.lnum, array, 0, Me.dnum)
				Return New SimpleZip.InflaterHuffmanTree(array)
			End Function

			' Token: 0x040000FB RID: 251
			Private Shared repMin As Integer() = New Integer() { 3, 3, 11 }

			' Token: 0x040000FC RID: 252
			Private Shared repBits As Integer() = New Integer() { 2, 3, 7 }

			' Token: 0x040000FD RID: 253
			Private blLens As Byte()

			' Token: 0x040000FE RID: 254
			Private litdistLens As Byte()

			' Token: 0x040000FF RID: 255
			Private blTree As SimpleZip.InflaterHuffmanTree

			' Token: 0x04000100 RID: 256
			Private mode As Integer

			' Token: 0x04000101 RID: 257
			Private lnum As Integer

			' Token: 0x04000102 RID: 258
			Private dnum As Integer

			' Token: 0x04000103 RID: 259
			Private blnum As Integer

			' Token: 0x04000104 RID: 260
			Private num As Integer

			' Token: 0x04000105 RID: 261
			Private repSymbol As Integer

			' Token: 0x04000106 RID: 262
			Private lastLen As Byte

			' Token: 0x04000107 RID: 263
			Private ptr As Integer

			' Token: 0x04000108 RID: 264
			Private Shared BL_ORDER As Integer() = New Integer() { 16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15 }
		End Class

		' Token: 0x0200003D RID: 61
		Friend NotInheritable Class DeflaterHuffman
			' Token: 0x06000117 RID: 279 RVA: 0x00002D63 File Offset: 0x00000F63
			Public Shared Function BitReverse(int_0 As Integer) As Short
				Return CShort(((CInt(SimpleZip.DeflaterHuffman.bit4Reverse(int_0 And 15)) << 12) Or (CInt(SimpleZip.DeflaterHuffman.bit4Reverse((int_0 >> 4) And 15)) << 8) Or (CInt(SimpleZip.DeflaterHuffman.bit4Reverse((int_0 >> 8) And 15)) << 4) Or CInt(SimpleZip.DeflaterHuffman.bit4Reverse(int_0 >> 12))))
			End Function

			' Token: 0x06000118 RID: 280 RVA: 0x00010E98 File Offset: 0x0000F098
			Shared Sub New()
				Dim i As Integer = 0
				While i < 144
					SimpleZip.DeflaterHuffman.staticLCodes(i) = SimpleZip.DeflaterHuffman.BitReverse(48 + i << 8)
					Dim array As Byte() = SimpleZip.DeflaterHuffman.staticLLength
					Dim num As Integer = i
					i = num + 1
					array(num) = 8
				End While
				While i < 256
					SimpleZip.DeflaterHuffman.staticLCodes(i) = SimpleZip.DeflaterHuffman.BitReverse(256 + i << 7)
					Dim array2 As Byte() = SimpleZip.DeflaterHuffman.staticLLength
					Dim num2 As Integer = i
					i = num2 + 1
					array2(num2) = 9
				End While
				While i < 280
					SimpleZip.DeflaterHuffman.staticLCodes(i) = SimpleZip.DeflaterHuffman.BitReverse(-256 + i << 9)
					Dim array3 As Byte() = SimpleZip.DeflaterHuffman.staticLLength
					Dim num3 As Integer = i
					i = num3 + 1
					array3(num3) = 7
				End While
				While i < 286
					SimpleZip.DeflaterHuffman.staticLCodes(i) = SimpleZip.DeflaterHuffman.BitReverse(-88 + i << 8)
					Dim array4 As Byte() = SimpleZip.DeflaterHuffman.staticLLength
					Dim num4 As Integer = i
					i = num4 + 1
					array4(num4) = 8
				End While
				SimpleZip.DeflaterHuffman.staticDCodes = New Short(29) {}
				SimpleZip.DeflaterHuffman.staticDLength = New Byte(29) {}
				i = 0
				While i < 30
					SimpleZip.DeflaterHuffman.staticDCodes(i) = SimpleZip.DeflaterHuffman.BitReverse(i << 11)
					SimpleZip.DeflaterHuffman.staticDLength(i) = 5
					i += 1
				End While
			End Sub

			' Token: 0x04000109 RID: 265
			Private Shared BL_ORDER As Integer() = New Integer() { 16, 17, 18, 0, 8, 7, 9, 6, 10, 5, 11, 4, 12, 3, 13, 2, 14, 1, 15 }

			' Token: 0x0400010A RID: 266
			Private Shared bit4Reverse As Byte() = New Byte() { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 }

			' Token: 0x0400010B RID: 267
			Private Shared staticLCodes As Short() = New Short(285) {}

			' Token: 0x0400010C RID: 268
			Private Shared staticLLength As Byte() = New Byte(285) {}

			' Token: 0x0400010D RID: 269
			Private Shared staticDCodes As Short()

			' Token: 0x0400010E RID: 270
			Private Shared staticDLength As Byte()
		End Class

		' Token: 0x0200003E RID: 62
		Friend NotInheritable Class ZipStream
			Inherits MemoryStream

			' Token: 0x06000119 RID: 281 RVA: 0x00002D9C File Offset: 0x00000F9C
			Public Function ReadShort() As Integer
				Return Me.ReadByte() Or (Me.ReadByte() << 8)
			End Function

			' Token: 0x0600011A RID: 282 RVA: 0x00002DAD File Offset: 0x00000FAD
			Public Function ReadInt() As Integer
				Return Me.ReadShort() Or (Me.ReadShort() << 16)
			End Function

			' Token: 0x0600011B RID: 283 RVA: 0x00002DBF File Offset: 0x00000FBF
			Public Sub New(byte_0 As Byte())
				MyBase.New(byte_0, False)
			End Sub
		End Class
	End Module
End Namespace
