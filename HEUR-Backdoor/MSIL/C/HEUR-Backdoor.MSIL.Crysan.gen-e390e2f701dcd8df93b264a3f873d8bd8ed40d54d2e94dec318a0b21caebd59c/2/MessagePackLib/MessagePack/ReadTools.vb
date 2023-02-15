Imports System
Imports System.IO

Namespace MessagePackLib.MessagePack
	' Token: 0x02000020 RID: 32
	Friend Class ReadTools
		' Token: 0x060000B4 RID: 180 RVA: 0x000058E0 File Offset: 0x00003AE0
		Public Shared Function ReadString(ms As Stream, len As Integer) As String
			Dim array As Byte() = New Byte(len - 1) {}
			ms.Read(array, 0, len)
			Return BytesTools.GetString(array)
		End Function

		' Token: 0x060000B5 RID: 181 RVA: 0x00002684 File Offset: 0x00000884
		Public Shared Function ReadString(ms As Stream) As String
			Return ReadTools.ReadString(CByte(ms.ReadByte()), ms)
		End Function

		' Token: 0x060000B6 RID: 182 RVA: 0x00005904 File Offset: 0x00003B04
		Public Shared Function ReadString(strFlag As Byte, ms As Stream) As String
			Dim num As Integer = 0
			Dim array As Byte()
			If strFlag >= 160 AndAlso strFlag <= 191 Then
				num = CInt((strFlag - 160))
			ElseIf strFlag = 217 Then
				num = ms.ReadByte()
			ElseIf strFlag = 218 Then
				array = New Byte(1) {}
				ms.Read(array, 0, 2)
				array = BytesTools.SwapBytes(array)
				num = CInt(BitConverter.ToUInt16(array, 0))
			ElseIf strFlag = 219 Then
				array = New Byte(3) {}
				ms.Read(array, 0, 4)
				array = BytesTools.SwapBytes(array)
				num = BitConverter.ToInt32(array, 0)
			End If
			array = New Byte(num - 1) {}
			ms.Read(array, 0, num)
			Return BytesTools.GetString(array)
		End Function
	End Class
End Namespace
