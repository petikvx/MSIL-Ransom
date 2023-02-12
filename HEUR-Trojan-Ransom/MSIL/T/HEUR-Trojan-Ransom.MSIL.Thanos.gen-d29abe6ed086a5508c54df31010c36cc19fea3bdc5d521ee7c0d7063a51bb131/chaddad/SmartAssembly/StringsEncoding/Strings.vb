Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports SmartAssembly.Zip

Namespace SmartAssembly.StringsEncoding
	' Token: 0x02000033 RID: 51
	Public NotInheritable Class Strings
		' Token: 0x060000EF RID: 239 RVA: 0x00002C4F File Offset: 0x00000E4F
		Public Shared Function [Get](int_0 As Integer) As String
			int_0 = int_0 Xor 107396847
			int_0 -= Strings.offset
			If Not Strings.cacheStrings Then
				Return Strings.GetFromResource(int_0)
			End If
			Return Strings.GetCachedOrResource(int_0)
		End Function

		' Token: 0x060000F0 RID: 240 RVA: 0x0000FB30 File Offset: 0x0000DD30
		Public Shared Function GetCachedOrResource(int_0 As Integer) As String
			Dim obj As Object = Strings.hashtableLock
			SyncLock obj
				Dim text As String
				Strings.hashtable.TryGetValue(int_0, text)
				If text IsNot Nothing Then
					Return text
				End If
			End SyncLock
			Return Strings.GetFromResource(int_0)
		End Function

		' Token: 0x060000F1 RID: 241 RVA: 0x0000FB80 File Offset: 0x0000DD80
		Public Shared Function GetFromResource(int_0 As Integer) As String
			Dim array As Byte() = Strings.bytes
			Dim num As Integer = int_0 + 1
			Dim num2 As Integer = array(int_0)
			Dim num3 As Integer
			If(num2 And 128) = 0 Then
				num3 = num2
				If num3 = 0 Then
					Return String.Empty
				End If
			ElseIf(num2 And 64) = 0 Then
				Dim num4 As Integer = (num2 And 63) << 8
				Dim array2 As Byte() = Strings.bytes
				Dim num5 As Integer = num
				num = num5 + 1
				num3 = num4 + array2(num5)
			Else
				Dim num6 As Integer = (num2 And 31) << 24
				Dim array3 As Byte() = Strings.bytes
				Dim num7 As Integer = num
				num = num7 + 1
				Dim num8 As Integer = num6 + (array3(num7) << 16)
				Dim array4 As Byte() = Strings.bytes
				Dim num9 As Integer = num
				num = num9 + 1
				Dim num10 As Integer = num8 + (array4(num9) << 8)
				Dim array5 As Byte() = Strings.bytes
				Dim num11 As Integer = num
				num = num11 + 1
				num3 = num10 + array5(num11)
			End If
			Dim text2 As String
			Try
				Dim array6 As Byte() = Convert.FromBase64String(Encoding.UTF8.GetString(Strings.bytes, num, num3))
				Dim text As String = String.Intern(Encoding.UTF8.GetString(array6, 0, array6.Length))
				If Strings.cacheStrings Then
					Strings.CacheString(int_0, text)
				End If
				text2 = text
			Catch
				text2 = Nothing
			End Try
			Return text2
		End Function

		' Token: 0x060000F2 RID: 242 RVA: 0x0000FC58 File Offset: 0x0000DE58
		Public Shared Sub CacheString(int_0 As Integer, string_0 As String)
			Try
				Dim obj As Object = Strings.hashtableLock
				SyncLock obj
					Strings.hashtable.Add(int_0, string_0)
				End SyncLock
			Catch
			End Try
		End Sub

		' Token: 0x060000F3 RID: 243 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		Shared Sub New()
			If Strings.MustUseCache = "1" Then
				Strings.cacheStrings = True
				Strings.hashtable = New Dictionary(Of Integer, String)()
			End If
			Strings.offset = Convert.ToInt32(Strings.OffsetValue)
			Using manifestResourceStream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("{4b195894-0f06-4fdd-afb4-b17fb9246a59}")
				Dim num As Integer = Convert.ToInt32(manifestResourceStream.Length)
				Dim array As Byte() = New Byte(num - 1) {}
				manifestResourceStream.Read(array, 0, num)
				Strings.bytes = SimpleZip.Unzip(array)
			End Using
		End Sub

		' Token: 0x040000D5 RID: 213
		Private Shared MustUseCache As String = "1"

		' Token: 0x040000D6 RID: 214
		Private Shared OffsetValue As String = "101"

		' Token: 0x040000D7 RID: 215
		Private Shared bytes As Byte() = Nothing

		' Token: 0x040000D8 RID: 216
		Private Shared hashtable As Dictionary(Of Integer, String)

		' Token: 0x040000D9 RID: 217
		Private Shared hashtableLock As Object = New Object()

		' Token: 0x040000DA RID: 218
		Private Shared cacheStrings As Boolean = False

		' Token: 0x040000DB RID: 219
		Private Shared offset As Integer = 0
	End Class
End Namespace
