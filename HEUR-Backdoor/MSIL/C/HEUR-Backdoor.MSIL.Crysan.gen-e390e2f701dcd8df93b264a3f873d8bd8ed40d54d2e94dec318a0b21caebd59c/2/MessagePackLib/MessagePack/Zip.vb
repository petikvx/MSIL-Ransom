Imports System
Imports System.IO
Imports System.IO.Compression

Namespace MessagePackLib.MessagePack
	' Token: 0x02000022 RID: 34
	Public Module Zip
		' Token: 0x060000C1 RID: 193 RVA: 0x00005CA0 File Offset: 0x00003EA0
		Public Function Decompress(input As Byte()) As Byte()
			Dim array3 As Byte()
			Using memoryStream As MemoryStream = New MemoryStream(input)
				Dim array As Byte() = New Byte(3) {}
				memoryStream.Read(array, 0, 4)
				Dim num As Integer = BitConverter.ToInt32(array, 0)
				Using gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
					Dim array2 As Byte() = New Byte(num - 1) {}
					gzipStream.Read(array2, 0, num)
					array3 = array2
				End Using
			End Using
			Return array3
		End Function

		' Token: 0x060000C2 RID: 194 RVA: 0x00005D2C File Offset: 0x00003F2C
		Public Function Compress(input As Byte()) As Byte()
			Dim array As Byte()
			Using memoryStream As MemoryStream = New MemoryStream()
				Dim bytes As Byte() = BitConverter.GetBytes(input.Length)
				memoryStream.Write(bytes, 0, 4)
				Using gzipStream As GZipStream = New GZipStream(memoryStream, CompressionMode.Compress)
					gzipStream.Write(input, 0, input.Length)
					gzipStream.Flush()
				End Using
				array = memoryStream.ToArray()
			End Using
			Return array
		End Function
	End Module
End Namespace
