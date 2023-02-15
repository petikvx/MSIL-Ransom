Imports System
Imports System.IO

Namespace MessagePackLib.MessagePack
	' Token: 0x02000021 RID: 33
	Friend Class WriteTools
		' Token: 0x060000B8 RID: 184 RVA: 0x00002693 File Offset: 0x00000893
		Public Shared Sub WriteNull(ms As Stream)
			ms.WriteByte(192)
		End Sub

		' Token: 0x060000B9 RID: 185 RVA: 0x000059C4 File Offset: 0x00003BC4
		Public Shared Sub WriteString(ms As Stream, strVal As String)
			Dim utf8Bytes As Byte() = BytesTools.GetUtf8Bytes(strVal)
			Dim num As Integer = utf8Bytes.Length
			If num <= 31 Then
				Dim b As Byte = 160 + CByte(num)
				ms.WriteByte(b)
			ElseIf num <= 255 Then
				Dim b As Byte = 217
				ms.WriteByte(b)
				b = CByte(num)
				ms.WriteByte(b)
			ElseIf num <= 65535 Then
				Dim b As Byte = 218
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(CShort(num)))
				ms.Write(array, 0, array.Length)
			Else
				Dim b As Byte = 219
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(num))
				ms.Write(array, 0, array.Length)
			End If
			ms.Write(utf8Bytes, 0, utf8Bytes.Length)
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x00005A8C File Offset: 0x00003C8C
		Public Shared Sub WriteBinary(ms As Stream, rawBytes As Byte())
			Dim num As Integer = rawBytes.Length
			If num <= 255 Then
				Dim b As Byte = 196
				ms.WriteByte(b)
				b = CByte(num)
				ms.WriteByte(b)
			ElseIf num <= 65535 Then
				Dim b As Byte = 197
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(CShort(num)))
				ms.Write(array, 0, array.Length)
			Else
				Dim b As Byte = 198
				ms.WriteByte(b)
				Dim array As Byte() = BytesTools.SwapBytes(BitConverter.GetBytes(num))
				ms.Write(array, 0, array.Length)
			End If
			ms.Write(rawBytes, 0, rawBytes.Length)
		End Sub

		' Token: 0x060000BB RID: 187 RVA: 0x000026A0 File Offset: 0x000008A0
		Public Shared Sub WriteFloat(ms As Stream, fVal As Double)
			ms.WriteByte(203)
			ms.Write(BytesTools.SwapDouble(fVal), 0, 8)
		End Sub

		' Token: 0x060000BC RID: 188 RVA: 0x000026BB File Offset: 0x000008BB
		Public Shared Sub WriteSingle(ms As Stream, fVal As Single)
			ms.WriteByte(202)
			ms.Write(BytesTools.SwapBytes(BitConverter.GetBytes(fVal)), 0, 4)
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x000026DB File Offset: 0x000008DB
		Public Shared Sub WriteBoolean(ms As Stream, bVal As Boolean)
			If bVal Then
				ms.WriteByte(195)
				Return
			End If
			ms.WriteByte(194)
		End Sub

		' Token: 0x060000BE RID: 190 RVA: 0x00005B2C File Offset: 0x00003D2C
		Public Shared Sub WriteUInt64(ms As Stream, iVal As ULong)
			ms.WriteByte(207)
			Dim bytes As Byte() = BitConverter.GetBytes(iVal)
			ms.Write(BytesTools.SwapBytes(bytes), 0, 8)
		End Sub

		' Token: 0x060000BF RID: 191 RVA: 0x00005B5C File Offset: 0x00003D5C
		Public Shared Sub WriteInteger(ms As Stream, iVal As Long)
			If iVal >= 0L Then
				If iVal <= 127L Then
					ms.WriteByte(CByte(iVal))
					Return
				End If
				If iVal <= 255L Then
					ms.WriteByte(204)
					ms.WriteByte(CByte(iVal))
					Return
				End If
				If iVal <= 65535L Then
					ms.WriteByte(205)
					ms.Write(BytesTools.SwapInt16(CShort(iVal)), 0, 2)
					Return
				End If
				If iVal <= CLng(CULng((-1))) Then
					ms.WriteByte(206)
					ms.Write(BytesTools.SwapInt32(CInt(iVal)), 0, 4)
					Return
				End If
				ms.WriteByte(211)
				ms.Write(BytesTools.SwapInt64(iVal), 0, 8)
				Return
			Else
				If iVal <= -2147483648L Then
					ms.WriteByte(211)
					ms.Write(BytesTools.SwapInt64(iVal), 0, 8)
					Return
				End If
				If iVal <= -32768L Then
					ms.WriteByte(210)
					ms.Write(BytesTools.SwapInt32(CInt(iVal)), 0, 4)
					Return
				End If
				If iVal <= -128L Then
					ms.WriteByte(209)
					ms.Write(BytesTools.SwapInt16(CShort(iVal)), 0, 2)
					Return
				End If
				If iVal <= -32L Then
					ms.WriteByte(208)
					ms.WriteByte(CByte(iVal))
					Return
				End If
				ms.WriteByte(CByte(iVal))
				Return
			End If
		End Sub
	End Class
End Namespace
