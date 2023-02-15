Imports System
Imports System.Text

Namespace MessagePackLib.MessagePack
	' Token: 0x0200001B RID: 27
	Public Class BytesTools
		' Token: 0x06000073 RID: 115 RVA: 0x00002394 File Offset: 0x00000594
		Public Shared Function GetUtf8Bytes(s As String) As Byte()
			Return BytesTools.utf8Encode.GetBytes(s)
		End Function

		' Token: 0x06000074 RID: 116 RVA: 0x000023A1 File Offset: 0x000005A1
		Public Shared Function GetString(utf8Bytes As Byte()) As String
			Return BytesTools.utf8Encode.GetString(utf8Bytes)
		End Function

		' Token: 0x06000075 RID: 117 RVA: 0x00004940 File Offset: 0x00002B40
		Public Shared Function BytesAsString(bytes As Byte()) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			For Each b As Byte In bytes
				stringBuilder.Append(String.Format("{0:D3} ", b))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x06000076 RID: 118 RVA: 0x00004988 File Offset: 0x00002B88
		Public Shared Function BytesAsHexString(bytes As Byte()) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			For Each b As Byte In bytes
				stringBuilder.Append(String.Format("{0:X2} ", b))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x06000077 RID: 119 RVA: 0x000049D0 File Offset: 0x00002BD0
		Public Shared Function SwapBytes(v As Byte()) As Byte()
			Dim array As Byte() = New Byte(v.Length - 1) {}
			Dim num As Integer = v.Length - 1
			For i As Integer = 0 To array.Length - 1
				array(i) = v(num)
				num -= 1
			Next
			Return array
		End Function

		' Token: 0x06000078 RID: 120 RVA: 0x000023AE File Offset: 0x000005AE
		Public Shared Function SwapInt64(v As Long) As Byte()
			Return BytesTools.SwapBytes(BitConverter.GetBytes(v))
		End Function

		' Token: 0x06000079 RID: 121 RVA: 0x000023BB File Offset: 0x000005BB
		Public Shared Function SwapInt32(v As Integer) As Byte()
			Dim array As Byte() = New Byte() { 0, 0, 0, CByte(v) }
			array(2) = CByte((v >> 8))
			array(1) = CByte((v >> 16))
			array(0) = CByte((v >> 24))
			Return array
		End Function

		' Token: 0x0600007A RID: 122 RVA: 0x000023DF File Offset: 0x000005DF
		Public Shared Function SwapInt16(v As Short) As Byte()
			Dim array As Byte() = New Byte() { 0, CByte(v) }
			array(0) = CByte((v >> 8))
			Return array
		End Function

		' Token: 0x0600007B RID: 123 RVA: 0x000023F3 File Offset: 0x000005F3
		Public Shared Function SwapDouble(v As Double) As Byte()
			Return BytesTools.SwapBytes(BitConverter.GetBytes(v))
		End Function

		' Token: 0x04000042 RID: 66
		Private Shared utf8Encode As UTF8Encoding = New UTF8Encoding()
	End Class
End Namespace
