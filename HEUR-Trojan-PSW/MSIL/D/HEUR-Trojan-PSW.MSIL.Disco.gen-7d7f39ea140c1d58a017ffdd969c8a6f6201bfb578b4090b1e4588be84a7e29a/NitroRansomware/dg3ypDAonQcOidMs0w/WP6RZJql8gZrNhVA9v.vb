Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports rE4lpnT863QnijKQK5
Imports zlqCXdcKao7YZQAGFe

Namespace dg3ypDAonQcOidMs0w
	' Token: 0x02000011 RID: 17
	Friend Class WP6RZJql8gZrNhVA9v
		' Token: 0x06000056 RID: 86 RVA: 0x000051F0 File Offset: 0x000033F0
		Shared Sub New()
			Try
				RSACryptoServiceProvider.UseMachineKeyStore = True
			Catch
			End Try
		End Sub

		' Token: 0x06000057 RID: 87 RVA: 0x000022A0 File Offset: 0x000004A0
		Private Sub V4WF529oAq2Aq()
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x00005360 File Offset: 0x00003560
		Friend Shared Function ab9oDe4UH3(byte_0 As Byte()) As Byte()
			Dim array As UInteger() = New UInteger(15) {}
			Dim num As Integer = 448 - byte_0.Length * 8 Mod 512
			Dim num2 As UInteger = CUInt(((num + 512) Mod 512))
			If num2 = 0UI Then
				num2 = 512UI
			End If
			Dim num3 As UInteger = CUInt((CLng(byte_0.Length) + CLng(CULng((num2 / 8UI))) + 8L))
			Dim num4 As ULong = CULng((CLng(byte_0.Length) * 8L))
			Dim array2 As Byte() = New Byte(num3 - 1) {}
			For i As Integer = 0 To byte_0.Length - 1
				array2(i) = byte_0(i)
			Next
			Dim array3 As Byte() = array2
			Dim num5 As Integer = byte_0.Length
			array3(num5) = array3(num5) Or 128
			For j As Integer = 8 To 0 + 1 Step -1
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				array2(CInt((CType((CULng(num3) - CULng(CLng(j))), IntPtr)))) = CByte(((num4 >> (8 - j) * 8) And 255UL))
			Next
			Dim num6 As UInteger = CUInt((array2.Length * 8 / 32))
			Dim num7 As UInteger = 1732584193UI
			Dim num8 As UInteger = 4023233417UI
			Dim num9 As UInteger = 2562383102UI
			Dim num10 As UInteger = 271733878UI
			For num11 As UInteger = 0UI To num6 / 16UI - 1
				Dim num12 As UInteger = num11 << 6
				For num13 As UInteger = 0UI To 61UI - 1 Step 4UI
					array(CInt(CType((num13 >> 2), UIntPtr))) = CUInt(((CInt(array2(CInt(CType((num12 + (num13 + 3UI)), UIntPtr)))) << 24) Or (CInt(array2(CInt(CType((num12 + (num13 + 2UI)), UIntPtr)))) << 16) Or (CInt(array2(CInt(CType((num12 + (num13 + 1UI)), UIntPtr)))) << 8) Or CInt(array2(CInt(CType((num12 + num13), UIntPtr))))))
				Next
				Dim num14 As UInteger = num7
				Dim num15 As UInteger = num8
				Dim num16 As UInteger = num9
				Dim num17 As UInteger = num10
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num7, num8, num9, num10, 0UI, 7US, 1UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num10, num7, num8, num9, 1UI, 12US, 2UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num9, num10, num7, num8, 2UI, 17US, 3UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num8, num9, num10, num7, 3UI, 22US, 4UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num7, num8, num9, num10, 4UI, 7US, 5UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num10, num7, num8, num9, 5UI, 12US, 6UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num9, num10, num7, num8, 6UI, 17US, 7UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num8, num9, num10, num7, 7UI, 22US, 8UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num7, num8, num9, num10, 8UI, 7US, 9UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num10, num7, num8, num9, 9UI, 12US, 10UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num9, num10, num7, num8, 10UI, 17US, 11UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num8, num9, num10, num7, 11UI, 22US, 12UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num7, num8, num9, num10, 12UI, 7US, 13UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num10, num7, num8, num9, 13UI, 12US, 14UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num9, num10, num7, num8, 14UI, 17US, 15UI, array)
				WP6RZJql8gZrNhVA9v.TAOohhiP7R(num8, num9, num10, num7, 15UI, 22US, 16UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num7, num8, num9, num10, 1UI, 5US, 17UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num10, num7, num8, num9, 6UI, 9US, 18UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num9, num10, num7, num8, 11UI, 14US, 19UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num8, num9, num10, num7, 0UI, 20US, 20UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num7, num8, num9, num10, 5UI, 5US, 21UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num10, num7, num8, num9, 10UI, 9US, 22UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num9, num10, num7, num8, 15UI, 14US, 23UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num8, num9, num10, num7, 4UI, 20US, 24UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num7, num8, num9, num10, 9UI, 5US, 25UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num10, num7, num8, num9, 14UI, 9US, 26UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num9, num10, num7, num8, 3UI, 14US, 27UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num8, num9, num10, num7, 8UI, 20US, 28UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num7, num8, num9, num10, 13UI, 5US, 29UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num10, num7, num8, num9, 2UI, 9US, 30UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num9, num10, num7, num8, 7UI, 14US, 31UI, array)
				WP6RZJql8gZrNhVA9v.zDKosecjaB(num8, num9, num10, num7, 12UI, 20US, 32UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num7, num8, num9, num10, 5UI, 4US, 33UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num10, num7, num8, num9, 8UI, 11US, 34UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num9, num10, num7, num8, 11UI, 16US, 35UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num8, num9, num10, num7, 14UI, 23US, 36UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num7, num8, num9, num10, 1UI, 4US, 37UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num10, num7, num8, num9, 4UI, 11US, 38UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num9, num10, num7, num8, 7UI, 16US, 39UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num8, num9, num10, num7, 10UI, 23US, 40UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num7, num8, num9, num10, 13UI, 4US, 41UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num10, num7, num8, num9, 0UI, 11US, 42UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num9, num10, num7, num8, 3UI, 16US, 43UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num8, num9, num10, num7, 6UI, 23US, 44UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num7, num8, num9, num10, 9UI, 4US, 45UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num10, num7, num8, num9, 12UI, 11US, 46UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num9, num10, num7, num8, 15UI, 16US, 47UI, array)
				WP6RZJql8gZrNhVA9v.ubAof6RgCm(num8, num9, num10, num7, 2UI, 23US, 48UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num7, num8, num9, num10, 0UI, 6US, 49UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num10, num7, num8, num9, 7UI, 10US, 50UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num9, num10, num7, num8, 14UI, 15US, 51UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num8, num9, num10, num7, 5UI, 21US, 52UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num7, num8, num9, num10, 12UI, 6US, 53UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num10, num7, num8, num9, 3UI, 10US, 54UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num9, num10, num7, num8, 10UI, 15US, 55UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num8, num9, num10, num7, 1UI, 21US, 56UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num7, num8, num9, num10, 8UI, 6US, 57UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num10, num7, num8, num9, 15UI, 10US, 58UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num9, num10, num7, num8, 6UI, 15US, 59UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num8, num9, num10, num7, 13UI, 21US, 60UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num7, num8, num9, num10, 4UI, 6US, 61UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num10, num7, num8, num9, 11UI, 10US, 62UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num9, num10, num7, num8, 2UI, 15US, 63UI, array)
				WP6RZJql8gZrNhVA9v.YpJoWsPi7X(num8, num9, num10, num7, 9UI, 21US, 64UI, array)
				num7 += num14
				num8 += num15
				num9 += num16
				num10 += num17
			Next
			Dim array4 As Byte() = New Byte(15) {}
			Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4)
			Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4)
			Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4)
			Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4)
			Return array4
		End Function

		' Token: 0x06000059 RID: 89 RVA: 0x0000244B File Offset: 0x0000064B
		Private Shared Sub TAOohhiP7R(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, uint_6 As UInteger())
			uint_0 = uint_1 + WP6RZJql8gZrNhVA9v.BEVodWAYPB(uint_0 + ((uint_1 And uint_2) Or (Not uint_1 And uint_3)) + uint_6(CInt(CType(uint_4, UIntPtr))) + WP6RZJql8gZrNhVA9v.O1BkIDx0L0(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600005A RID: 90 RVA: 0x00002476 File Offset: 0x00000676
		Private Shared Sub zDKosecjaB(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, uint_6 As UInteger())
			uint_0 = uint_1 + WP6RZJql8gZrNhVA9v.BEVodWAYPB(uint_0 + ((uint_1 And uint_3) Or (uint_2 And Not uint_3)) + uint_6(CInt(CType(uint_4, UIntPtr))) + WP6RZJql8gZrNhVA9v.O1BkIDx0L0(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x000024A1 File Offset: 0x000006A1
		Private Shared Sub ubAof6RgCm(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, uint_6 As UInteger())
			uint_0 = uint_1 + WP6RZJql8gZrNhVA9v.BEVodWAYPB(uint_0 + (uint_1 Xor uint_2 Xor uint_3) + uint_6(CInt(CType(uint_4, UIntPtr))) + WP6RZJql8gZrNhVA9v.O1BkIDx0L0(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600005C RID: 92 RVA: 0x000024C9 File Offset: 0x000006C9
		Private Shared Sub YpJoWsPi7X(ByRef uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger, uint_3 As UInteger, uint_4 As UInteger, ushort_0 As UShort, uint_5 As UInteger, uint_6 As UInteger())
			uint_0 = uint_1 + WP6RZJql8gZrNhVA9v.BEVodWAYPB(uint_0 + (uint_2 Xor (uint_1 Or Not uint_3)) + uint_6(CInt(CType(uint_4, UIntPtr))) + WP6RZJql8gZrNhVA9v.O1BkIDx0L0(CInt(CType((uint_5 - 1UI), UIntPtr))), ushort_0)
		End Sub

		' Token: 0x0600005D RID: 93 RVA: 0x000024F2 File Offset: 0x000006F2
		Private Shared Function BEVodWAYPB(uint_0 As UInteger, ushort_0 As UShort) As UInteger
			Return(uint_0 >> CInt((32US - ushort_0))) Or (uint_0 << CInt(ushort_0))
		End Function

		' Token: 0x0600005E RID: 94 RVA: 0x00002504 File Offset: 0x00000704
		Friend Shared Function gX8onkMSd7() As Boolean
			If Not WP6RZJql8gZrNhVA9v.V9fkgxQPQA Then
				WP6RZJql8gZrNhVA9v.XS8oLZGMXn()
				WP6RZJql8gZrNhVA9v.V9fkgxQPQA = True
			End If
			Return WP6RZJql8gZrNhVA9v.LrEkS2eXQL
		End Function

		' Token: 0x0600005F RID: 95 RVA: 0x00005A04 File Offset: 0x00003C04
		Friend Shared Function PEXoCqmS4w() As SymmetricAlgorithm
			Dim symmetricAlgorithm As SymmetricAlgorithm = Nothing
			If WP6RZJql8gZrNhVA9v.gX8onkMSd7() Then
				symmetricAlgorithm = New AesCryptoServiceProvider()
			Else
				Try
					symmetricAlgorithm = New RijndaelManaged()
				Catch
					symmetricAlgorithm = CType(Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap(), SymmetricAlgorithm)
				End Try
			End If
			Return symmetricAlgorithm
		End Function

		' Token: 0x06000060 RID: 96 RVA: 0x00005A58 File Offset: 0x00003C58
		Friend Shared Sub XS8oLZGMXn()
			Try
				WP6RZJql8gZrNhVA9v.LrEkS2eXQL = CryptoConfig.AllowOnlyFipsAlgorithms
			Catch
			End Try
		End Sub

		' Token: 0x06000061 RID: 97 RVA: 0x0000251D File Offset: 0x0000071D
		Friend Shared Function XEDoeIU7mj(byte_0 As Byte()) As Byte()
			If Not WP6RZJql8gZrNhVA9v.gX8onkMSd7() Then
				Return New MD5CryptoServiceProvider().ComputeHash(byte_0)
			End If
			Return WP6RZJql8gZrNhVA9v.ab9oDe4UH3(byte_0)
		End Function

		' Token: 0x06000062 RID: 98 RVA: 0x00005A84 File Offset: 0x00003C84
		Friend Shared Sub vBuojdip3i(hashAlgorithm_0 As HashAlgorithm, stream_0 As Stream, uint_0 As UInteger, byte_0 As Byte())
			While uint_0 > 0UI
				Dim num As Integer = If((uint_0 > CUInt(byte_0.Length)), byte_0.Length, CInt(uint_0))
				stream_0.Read(byte_0, 0, num)
				WP6RZJql8gZrNhVA9v.NSmolmd79S(hashAlgorithm_0, byte_0, 0, num)
				uint_0 -= CUInt(num)
			End While
		End Sub

		' Token: 0x06000063 RID: 99 RVA: 0x00002538 File Offset: 0x00000738
		Friend Shared Sub NSmolmd79S(hashAlgorithm_0 As HashAlgorithm, byte_0 As Byte(), int_0 As Integer, int_1 As Integer)
			hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0)
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x00005AC0 File Offset: 0x00003CC0
		Friend Shared Function SDQoufkqT0(uint_0 As UInteger, int_0 As Integer, long_0 As Long, binaryReader_0 As BinaryReader) As UInteger
			For i As Integer = 0 To int_0 - 1
				binaryReader_0.BaseStream.Position = long_0 + CLng((i * 40 + 8))
				Dim num As UInteger = binaryReader_0.ReadUInt32()
				Dim num2 As UInteger = binaryReader_0.ReadUInt32()
				binaryReader_0.ReadUInt32()
				Dim num3 As UInteger = binaryReader_0.ReadUInt32()
				If num2 <= uint_0 AndAlso uint_0 < num2 + num Then
					Return num3 + uint_0 - num2
				End If
			Next
			Return 0UI
		End Function

		' Token: 0x06000065 RID: 101 RVA: 0x00005B1C File Offset: 0x00003D1C
		<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
		Friend Shared Sub iXLoKRSpAw()
			Dim num As Integer = 13
			IL_09:
			While WP6RZJql8gZrNhVA9v.onZkkIlVOi Is Nothing
				Dim num2 As Integer = 12
				If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
					GoTo IL_18A
				End If
				Dim flag As Boolean
				Dim text As String
				While True
					IL_25:
					Dim hashAlgorithm As HashAlgorithm
					Dim text2 As String
					Select Case num2
						Case 0
							GoTo IL_23C3
						Case 1
							Try
								Dim vtNVUKGulysZw81C3E As WP6RZJql8gZrNhVA9v.VtNVUKGulysZw81C3E = New WP6RZJql8gZrNhVA9v.VtNVUKGulysZw81C3E(WP6RZJql8gZrNhVA9v.PwucW8jrQnqwO9nksv(WP6RZJql8gZrNhVA9v.x4Dk2IHVmX, "Zolk9kCyJtZSWZwA3H.C5fn7SnRigF4bi1Hkk"))
								Dim cryptoTransform As ICryptoTransform
								Dim num4 As Integer
								Dim stream As Stream
								Dim array5 As Byte()
								While True
									IL_22E6:
									WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(WP6RZJql8gZrNhVA9v.WXOeb5wHIamrsOQSBc(vtNVUKGulysZw81C3E), 0L)
									Dim num3 As Integer = 2
									If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
										GoTo IL_B9D
									End If
									Dim array As Byte()
									Dim num5 As Integer
									Do
										IL_1D58:
										Dim symmetricAlgorithm As SymmetricAlgorithm
										Dim array2 As Byte()
										Dim array3 As Byte()
										Dim array4 As Byte()
										Dim num6 As Integer
										Dim num7 As Integer
										Dim num8 As Integer
										Select Case num3
											Case 0
												GoTo IL_13F7
											Case 1
												GoTo IL_191C
											Case 2
												GoTo IL_11F5
											Case 3
												GoTo IL_136E
											Case 4
												array(13) = 30
												num3 = 170
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_110
												End If
												Continue Do
											Case 5
												GoTo IL_EC0
											Case 6
												GoTo IL_1B30
											Case 7
												cryptoTransform = WP6RZJql8gZrNhVA9v.kjuQwEe5PVurcPZKMQ(symmetricAlgorithm, array2, array3)
												num4 = 96
												GoTo IL_1125
											Case 8
												GoTo IL_2C8
											Case 9
												GoTo IL_2F3
											Case 10
												GoTo IL_F9D
											Case 11
												GoTo IL_14A7
											Case 12
												GoTo IL_5F1
											Case 13
												GoTo IL_B67
											Case 14
												GoTo IL_408
											Case 15
												array4(3) = 205
												GoTo IL_D36
											Case 16
												GoTo IL_1BA7
											Case 17
												GoTo IL_C97
											Case 18
												GoTo IL_483
											Case 19
												GoTo IL_D09
											Case 20
												GoTo IL_F59
											Case 21
												GoTo IL_19A1
											Case 22
												GoTo IL_158C
											Case 23
												num5 = 113
												GoTo IL_1961
											Case 24
												num5 = 136
												num3 = 0
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_13F7
												End If
												Continue Do
											Case 25
												GoTo IL_DF5
											Case 26
												array4(1) = 168
												num4 = 61
												GoTo IL_1C2F
											Case 27
												GoTo IL_212
											Case 28
												GoTo IL_718
											Case 29
												GoTo IL_33F
											Case 30
												GoTo IL_166C
											Case 31
												GoTo IL_A43
											Case 32
											Case 33
												GoTo IL_1BB8
											Case 34
												num6 = 164
												GoTo IL_9AE
											Case 35
												num6 = 87
												GoTo IL_1425
											Case 36
												GoTo IL_1276
											Case 37
												GoTo IL_47D
											Case 38
												GoTo IL_1C35
											Case 39
												GoTo IL_AD1
											Case 40
												GoTo IL_72D
											Case 41
												GoTo IL_121F
											Case 42
												array4(14) = CByte(num6)
												GoTo IL_DE6
											Case 43
												GoTo IL_196F
											Case 44
												GoTo IL_1A47
											Case 45
												GoTo IL_1848
											Case 46
												GoTo IL_1A92
											Case 47
												array(3) = 48
												num3 = 159
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_108
												End If
												Continue Do
											Case 48
												GoTo IL_162F
											Case 49
												GoTo IL_1353
											Case 50
												GoTo IL_4DD
											Case 51
												num7 = 134
												GoTo IL_1321
											Case 52
												GoTo IL_4D1
											Case 53
												GoTo IL_2361
											Case 54
												GoTo IL_B82
											Case 55
												GoTo IL_203
											Case 56
												GoTo IL_FF4
											Case 57
												GoTo IL_D36
											Case 58
												array(12) = CByte(num5)
												num4 = 89
												GoTo IL_1B7E
											Case 59
												GoTo IL_10C1
											Case 60
												GoTo IL_F21
											Case 61
												GoTo IL_1C2F
											Case 62
												GoTo IL_686
											Case 63
												array4(2) = 120
												GoTo IL_1344
											Case 64
												array(9) = CByte(num7)
												num4 = 251
												GoTo IL_1482
											Case 65
												array4(15) = 130
												GoTo IL_16ED
											Case 66
												array4(8) = CByte(num8)
												num3 = 178
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_107
												End If
												Continue Do
											Case 67
												GoTo IL_1392
											Case 68
												GoTo IL_10B3
											Case 69
												GoTo IL_1CA
											Case 70
												GoTo IL_18DC
											Case 71
												GoTo IL_115F
											Case 72
												GoTo IL_864
											Case 73
												num6 = 108
												GoTo IL_1BB8
											Case 74
												GoTo IL_7DA
											Case 75
												GoTo IL_1A35
											Case 76
												GoTo IL_763
											Case 77
												GoTo IL_AEE
											Case 78
												GoTo IL_1251
											Case 79
												GoTo IL_1A55
											Case 80
												GoTo IL_D9F
											Case 81
												GoTo IL_EFA
											Case 82
												array(11) = CByte(num5)
												GoTo IL_1BA7
											Case 83
												GoTo IL_1544
											Case 84
												GoTo IL_1672
											Case 85
												GoTo IL_283
											Case 86
												GoTo IL_2333
											Case 87
												GoTo IL_2310
											Case 88
												GoTo IL_CFB
											Case 89
												GoTo IL_1B7E
											Case 90
												GoTo IL_1243
											Case 91
												GoTo IL_A75
											Case 92
												GoTo IL_73B
											Case 93
												GoTo IL_F4B
											Case 94
												GoTo IL_4FC
											Case 95
												GoTo IL_8D4
											Case 96
												GoTo IL_1125
											Case 97
												GoTo IL_1B02
											Case 98
												num8 = 99
												GoTo IL_816
											Case 99
												array(30) = 160
												GoTo IL_8F5
											Case 100
												GoTo IL_919
											Case 101
												GoTo IL_A58
											Case 102
												GoTo IL_12B3
											Case 103
												GoTo IL_10E8
											Case 104
												GoTo IL_4AE
											Case 105
												num5 = 95
												GoTo IL_B2E
											Case 106
												GoTo IL_D12
											Case 107
												array(8) = 91
												GoTo IL_1B30
											Case 108
												array(18) = 70
												GoTo IL_1109
											Case 109
												GoTo IL_724
											Case 110
												GoTo IL_16C1
											Case 111
												GoTo IL_BC1
											Case 112
												array(7) = 95
												GoTo IL_1B02
											Case 113
												array4(5) = 147
												num3 = 98
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_1A35
												End If
												Continue Do
											Case 114
												GoTo IL_AF7
											Case 115
												GoTo IL_F03
											Case 116
												GoTo IL_F8E
											Case 117
												GoTo IL_5C1
											Case 118
												array4(11) = CByte(num6)
												GoTo IL_12DF
											Case 119
												GoTo IL_803
											Case 120
												GoTo IL_15E5
											Case 121
												GoTo IL_1895
											Case 122
												GoTo IL_B3C
											Case 123
												GoTo IL_C67
											Case 124
												GoTo IL_69A
											Case 125
												GoTo IL_145F
											Case 126
												GoTo IL_10DA
											Case 127
												GoTo IL_1744
											Case 128
												array(2) = CByte(num5)
												GoTo IL_169A
											Case 129
												GoTo IL_B5B
											Case 130
												GoTo IL_181D
											Case 131
												GoTo IL_1362
											Case 132
												array(23) = 164
												GoTo IL_1A92
											Case 133
												GoTo IL_B73
											Case 134
												GoTo IL_2D4
											Case 135
												array(29) = CByte(num5)
												GoTo IL_138C
											Case 136
												GoTo IL_1689
											Case 137
												array4(15) = CByte(num8)
												GoTo IL_1A35
											Case 138
												GoTo IL_1321
											Case 139
												GoTo IL_24B
											Case 140
												GoTo IL_220
											Case 141
												array(29) = 134
												num3 = 161
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_102
												End If
												Continue Do
											Case 142
												GoTo IL_82A
											Case 143
												GoTo IL_53E
											Case 144
												array(31) = 132
												GoTo IL_31F
											Case 145
												GoTo IL_1013
											Case 146
												GoTo IL_459
											Case 147
												GoTo IL_189B
											Case 148
												GoTo IL_1284
											Case 149
												GoTo IL_15B8
											Case 150
												array4(3) = 94
												GoTo IL_12AD
											Case 151
												GoTo IL_1601
											Case 152
												array(12) = CByte(num7)
												num3 = 23
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_101
												End If
												Continue Do
											Case 153
												GoTo IL_994
											Case 154
												GoTo IL_1150
											Case 155
												GoTo IL_1535
											Case 156
												GoTo IL_198A
											Case 157
												GoTo IL_EDE
											Case 158
												GoTo IL_1961
											Case 159
												num7 = 152
												num3 = 172
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_220
												End If
												Continue Do
											Case 160
												num7 = 47
												num4 = 342
												GoTo IL_551
											Case 161
												array(29) = 4
												num3 = 99
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo IL_191C
												End If
												Continue Do
											Case 162
												GoTo IL_794
											Case 163
												GoTo IL_824
											Case 164
												GoTo IL_3A4
											Case 165
												GoTo IL_13A0
											Case 166
												GoTo IL_7AA
											Case 167
												GoTo IL_974
											Case 168
												GoTo IL_D62
											Case 169
												GoTo IL_1042
											Case 170
												array(14) = 81
												GoTo IL_D90
											Case 171
												array(23) = CByte(num5)
												num3 = 191
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_18DC
												End If
												Continue Do
											Case 172
												array(3) = CByte(num7)
												GoTo IL_1895
											Case 173
												GoTo IL_63A
											Case 174
												GoTo IL_A4F
											Case 175
												GoTo IL_6D9
											Case 176
												GoTo IL_233D
											Case 177
												array(0) = 117
												num3 = 328
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_1814
												End If
												Continue Do
											Case 178
												array4(8) = 168
												num4 = 45
												GoTo IL_1848
											Case 179
												GoTo IL_A35
											Case 180
												GoTo IL_12C1
											Case 181
												GoTo IL_10AD
											Case 182
												GoTo IL_666
											Case 183
												GoTo IL_1814
											Case 184
												num5 = 164
												num4 = 319
												GoTo IL_9D1
											Case 185
												GoTo IL_A03
											Case 186
												array(21) = CByte(num5)
												num3 = 190
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo IL_53E
												End If
												Continue Do
											Case 187
												GoTo IL_28F
											Case 188
												GoTo IL_128A
											Case 189
												GoTo IL_986
											Case 190
												num5 = 160
												num3 = 205
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_94
												End If
												Continue Do
											Case 191
												array(23) = 103
												num3 = 132
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_93
												End If
												Continue Do
											Case 192
												GoTo IL_1790
											Case 193
												GoTo IL_2378
											Case 194
												GoTo IL_E12
											Case 195
												GoTo IL_14FD
											Case 196
												GoTo IL_14A1
											Case 197
												GoTo IL_427
											Case 198
												GoTo IL_BB3
											Case 199
												GoTo IL_4BA
											Case 200
												GoTo IL_DA5
											Case 201
												GoTo IL_CA3
											Case 202
												GoTo IL_3EF
											Case 203
												GoTo IL_14C5
											Case 204
												GoTo IL_694
											Case 205
												array(21) = CByte(num5)
												num3 = 51
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_92
												End If
												Continue Do
											Case 206
												num7 = 215
												num3 = 222
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_91
												End If
												Continue Do
											Case 207
												GoTo IL_16FC
											Case 208
												GoTo IL_156E
											Case 209
												GoTo IL_7C8
											Case 210
												array4(10) = 227
												GoTo IL_1744
											Case 211
												GoTo IL_4A0
											Case 212
												num5 = 135
												num3 = 135
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_90
												End If
												Continue Do
											Case 213
												GoTo IL_C58
											Case 214
												GoTo IL_123D
											Case 215
												GoTo IL_16ED
											Case 216
												GoTo IL_E04
											Case 217
												GoTo IL_CD3
											Case 218
												GoTo IL_23F
											Case 219
												num6 = 45
												GoTo IL_786
											Case 220
												GoTo IL_88D
											Case 221
												GoTo IL_395
											Case 222
												array(18) = CByte(num7)
												GoTo IL_16C1
											Case 223
												GoTo IL_AD7
											Case 224
												num5 = 131
												GoTo IL_1F5
											Case 225
												GoTo IL_588
											Case 226
												GoTo IL_631
											Case 227
												GoTo IL_169A
											Case 228
												array4(2) = CByte(num8)
												num3 = 150
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_166C
												End If
												Continue Do
											Case 229
												GoTo IL_514
											Case 230
												symmetricAlgorithm = WP6RZJql8gZrNhVA9v.kw9XV0snA9GhG2xASw()
												GoTo IL_13DF
											Case 231
												GoTo IL_F80
											Case 232
												GoTo IL_D20
											Case 233
												num5 = 185
												num4 = 48
												GoTo IL_162F
											Case 234
												GoTo IL_6A8
											Case 235
												num5 = 60
												GoTo IL_1303
											Case 236
												GoTo IL_6E8
											Case 237
												GoTo IL_7D4
											Case 238
												GoTo IL_22E6
											Case 239
												GoTo IL_387
											Case 240
												array4(4) = CByte(num6)
												GoTo IL_1601
											Case 241
												array(19) = 81
												GoTo IL_15E5
											Case 242
												array4(10) = CByte(num6)
												GoTo IL_15B8
											Case 243
												GoTo IL_34D
											Case 244
												num5 = 130
												GoTo IL_156E
											Case 245
												GoTo IL_254
											Case 246
												GoTo IL_674
											Case 247
												array4(9) = 127
												num4 = 155
												GoTo IL_1535
											Case 248
												GoTo IL_14F7
											Case 249
												GoTo IL_45F
											Case 250
												array4(1) = 72
												num3 = 26
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_83
												End If
												Continue Do
											Case 251
												GoTo IL_1482
											Case 252
												GoTo IL_237F
											Case 253
												GoTo IL_328
											Case 254
												GoTo IL_FB2
											Case 255
												num5 = 84
												GoTo IL_145F
											Case 256
												GoTo IL_9F4
											Case 257
												array4(13) = 102
												GoTo IL_65D
											Case 258
												GoTo IL_1425
											Case 259
												num7 = 103
												num3 = 124
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
													GoTo IL_8C6
												End If
												Continue Do
											Case 260
												GoTo IL_301
											Case 261
												GoTo IL_13DF
											Case 262
												GoTo IL_A0C
											Case 263
												num7 = 162
												num3 = 64
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_79
												End If
												Continue Do
											Case 264
												GoTo IL_138C
											Case 265
												GoTo IL_1344
											Case 266
												GoTo IL_1303
											Case 267
												GoTo IL_2325
											Case 268
												GoTo IL_1260
											Case 269
												GoTo IL_8AB
											Case 270
												GoTo IL_2368
											Case 271
												GoTo IL_EA1
											Case 272
												GoTo IL_11C2
											Case 273
												GoTo IL_12DF
											Case 274
												GoTo IL_12AD
											Case 275
												GoTo IL_E39
											Case 276
												GoTo IL_1216
											Case 277
												array(20) = 198
												GoTo IL_11F5
											Case 278
												GoTo IL_C1F
											Case 279
												array4(7) = CByte(num8)
												num4 = 272
												GoTo IL_11C2
											Case 280
												num5 = 132
												GoTo IL_D7D
											Case 281
												array4(14) = CByte(num8)
												num3 = 65
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_70
												End If
												Continue Do
											Case 282
												GoTo IL_1141
											Case 283
												GoTo IL_C8B
											Case 284
												GoTo IL_9E8
											Case 285
												GoTo IL_1109
											Case 286
												array(15) = 67
												GoTo IL_10AD
											Case 287
												array(30) = CByte(num7)
												num3 = 70
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo IL_4D1
												End If
												Continue Do
											Case 288
												GoTo IL_A66
											Case 289
												GoTo IL_C73
											Case 290
												GoTo IL_1063
											Case 291
												GoTo IL_1034
											Case 292
												array(12) = CByte(num7)
												num3 = 33
												If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_FF4
												End If
												Continue Do
											Case 293
												GoTo IL_F77
											Case 294
												num8 = 148
												GoTo IL_F4B
											Case 295
												array4(0) = CByte(num6)
												GoTo IL_EA1
											Case 296
												GoTo IL_BD0
											Case 297
												GoTo IL_491
											Case 298
												array4(4) = CByte(num6)
												num3 = 113
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_59
												End If
												Continue Do
											Case 299
												array(13) = CByte(num5)
												num3 = 4
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
													GoTo Block_58
												End If
												Continue Do
											Case 300
												GoTo IL_CF2
											Case 301
												GoTo IL_E2D
											Case 302
												GoTo IL_DE6
											Case 303
												num5 = 159
												num3 = 323
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_56
												End If
												Continue Do
											Case 304
												GoTo IL_D90
											Case 305
												GoTo IL_D7D
											Case 306
												array4(13) = CByte(num6)
												GoTo IL_D62
											Case 307
												GoTo IL_CC7
											Case 308
												array(24) = 195
												num4 = 213
												GoTo IL_C58
											Case 309
												array(0) = CByte(num7)
												GoTo IL_C1F
											Case 310
												num7 = 163
												num3 = 309
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_50
												End If
												Continue Do
											Case 311
												GoTo IL_75A
											Case 312
												GoTo IL_B9D
											Case 313
												GoTo IL_B2E
											Case 314
												array(21) = 157
												GoTo IL_7FD
											Case 315
												GoTo IL_AB3
											Case 316
												GoTo IL_336
											Case 317
												GoTo IL_A90
											Case 318
												num5 = 60
												GoTo IL_A35
											Case 319
												GoTo IL_9D1
											Case 320
												GoTo IL_9AE
											Case 321
												array4(8) = 105
												num4 = 167
												GoTo IL_974
											Case 322
												GoTo IL_57A
											Case 323
												array(2) = CByte(num5)
												num3 = 47
												If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo Block_41
												End If
												Continue Do
											Case 324
												num7 = 176
												GoTo IL_919
											Case 325
												GoTo IL_85B
											Case 326
												GoTo IL_8F5
											Case 327
												GoTo IL_8C6
											Case 328
												num5 = 33
												GoTo IL_88D
											Case 329
												array(14) = 215
												GoTo IL_85B
											Case 330
												GoTo IL_816
											Case 331
												GoTo IL_7FD
											Case 332
												GoTo IL_786
											Case 333
												GoTo IL_709
											Case 334
												array(17) = 108
												num4 = 175
												GoTo IL_6D9
											Case 335
												GoTo IL_6B3
											Case 336
												GoTo IL_65D
											Case 337
												array(14) = 152
												num3 = 210
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
													GoTo IL_631
												End If
												Continue Do
											Case 338
												array4(6) = 98
												GoTo IL_5F1
											Case 339
												GoTo IL_4C3
											Case 340
												array(19) = CByte(num5)
												num3 = 43
												If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
													GoTo IL_5C1
												End If
												Continue Do
											Case 341
												GoTo IL_574
											Case 342
												GoTo IL_551
											Case 343
												num7 = 186
												GoTo IL_53E
											Case 344
												GoTo IL_441
											Case 345
												array4(0) = 124
												GoTo IL_3EF
											Case 346
												GoTo IL_3C8
											Case 347
												GoTo IL_36E
											Case 348
												GoTo IL_31F
											Case 349
												array(1) = CByte(num7)
												num3 = 4
												If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
													GoTo IL_2C8
												End If
												Continue Do
											Case 350
												GoTo IL_277
											Case 351
												GoTo IL_1F5
											Case 352
												array(21) = 115
												GoTo IL_1CA
											Case Else
												GoTo IL_13F7
										End Select
										IL_1D6:
										num5 = 87
										num3 = 186
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1CA:
										array(21) = 91
										GoTo IL_1D6
										IL_220:
										array4(0) = 148
										num3 = 345
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_23F
										End If
										Continue Do
										IL_212:
										array4 = New Byte(15) {}
										GoTo IL_220
										IL_203:
										array2 = array
										num4 = 27
										GoTo IL_212
										IL_1F5:
										array(31) = CByte(num5)
										GoTo IL_203
										IL_254:
										array4(2) = CByte(num8)
										num3 = 63
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_24B:
										num8 = 142
										GoTo IL_254
										IL_23F:
										array4(1) = 78
										GoTo IL_24B
										IL_6B3:
										array4(1) = 106
										GoTo IL_23F
										IL_1C35:
										array4(1) = CByte(num6)
										num4 = 335
										GoTo IL_6B3
										IL_1C2F:
										num6 = 122
										GoTo IL_1C35
										IL_28F:
										num5 = 98
										num3 = 171
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_283:
										array(23) = 93
										GoTo IL_28F
										IL_277:
										array(22) = 31
										GoTo IL_283
										IL_427:
										array(22) = 98
										num4 = 350
										GoTo IL_277
										IL_803:
										array(22) = CByte(num5)
										GoTo IL_427
										IL_7FD:
										num5 = 125
										GoTo IL_803
										IL_2D4:
										array(1) = 130
										num3 = 24
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_2F3
										End If
										Continue Do
										IL_2C8:
										array(1) = 111
										GoTo IL_2D4
										IL_301:
										num6 = 154
										num3 = 306
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_2F3:
										array4(13) = CByte(num6)
										GoTo IL_301
										IL_6A8:
										num6 = 90
										GoTo IL_2F3
										IL_69A:
										array4(13) = CByte(num6)
										GoTo IL_6A8
										IL_694:
										num6 = 108
										GoTo IL_69A
										IL_686:
										array4(13) = CByte(num6)
										GoTo IL_694
										IL_674:
										num6 = 170
										num4 = 62
										GoTo IL_686
										IL_666:
										array4(13) = CByte(num6)
										GoTo IL_674
										IL_65D:
										num6 = 152
										GoTo IL_666
										IL_34D:
										array(31) = 106
										num3 = 224
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_33F:
										array(31) = CByte(num7)
										GoTo IL_34D
										IL_336:
										num7 = 155
										GoTo IL_33F
										IL_328:
										array(31) = CByte(num7)
										GoTo IL_336
										IL_31F:
										num7 = 156
										GoTo IL_328
										IL_36E:
										num7 = 161
										num3 = 31
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_387
										End If
										Continue Do
										IL_53E:
										array(17) = CByte(num7)
										GoTo IL_36E
										IL_3A4:
										array(17) = 133
										num3 = 334
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_395:
										array(17) = 156
										GoTo IL_3A4
										IL_387:
										array(17) = CByte(num7)
										GoTo IL_395
										IL_3C8:
										num6 = 84
										num3 = 118
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_1BB8:
										array4(11) = CByte(num6)
										GoTo IL_3C8
										IL_3EF:
										num6 = 168
										num3 = 295
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											Continue Do
										End If
										IL_408:
										array4(0) = 198
										num3 = 250
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_427
										End If
										Continue Do
										IL_45F:
										array(4) = CByte(num5)
										num3 = 14
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_47D
										End If
										Continue Do
										IL_459:
										num5 = 50
										GoTo IL_45F
										IL_441:
										array(4) = 165
										num4 = 146
										GoTo IL_459
										IL_1689:
										array(3) = 32
										GoTo IL_441
										IL_1672:
										array(3) = CByte(num5)
										num4 = 136
										GoTo IL_1689
										IL_166C:
										num5 = 21
										GoTo IL_1672
										IL_4DD:
										array(5) = 243
										num3 = 259
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_4FC
										End If
										Continue Do
										IL_4D1:
										array(5) = 107
										GoTo IL_4DD
										IL_4C3:
										array(5) = CByte(num7)
										GoTo IL_4D1
										IL_4BA:
										num7 = 155
										GoTo IL_4C3
										IL_4AE:
										array(4) = 61
										GoTo IL_4BA
										IL_4A0:
										array(4) = CByte(num5)
										GoTo IL_4AE
										IL_491:
										num5 = 94
										num4 = 211
										GoTo IL_4A0
										IL_483:
										array(4) = CByte(num7)
										GoTo IL_491
										IL_47D:
										num7 = 108
										GoTo IL_483
										IL_514:
										array(16) = 92
										num3 = 343
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_4FC:
										array(16) = 196
										num4 = 229
										GoTo IL_514
										IL_D7D:
										array(16) = CByte(num5)
										GoTo IL_4FC
										IL_551:
										array(6) = CByte(num7)
										num3 = 112
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_588:
										num5 = 94
										num3 = 340
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_57A:
										array(19) = CByte(num7)
										GoTo IL_588
										IL_574:
										num7 = 82
										GoTo IL_57A
										IL_181D:
										array(19) = CByte(num5)
										GoTo IL_574
										IL_1814:
										num5 = 136
										GoTo IL_181D
										IL_5C1:
										array(19) = 157
										num3 = 241
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_5F1:
										array4(6) = 115
										num3 = 219
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_63A:
										array(15) = CByte(num5)
										num3 = 60
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_631:
										num5 = 176
										GoTo IL_63A
										IL_6E8:
										array(18) = 96
										num3 = 206
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_6D9:
										array(17) = 243
										GoTo IL_6E8
										IL_73B:
										array(24) = 151
										num3 = 39
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_75A
										End If
										Continue Do
										IL_72D:
										array(24) = CByte(num7)
										GoTo IL_73B
										IL_724:
										num7 = 193
										GoTo IL_72D
										IL_718:
										array(24) = 75
										GoTo IL_724
										IL_709:
										array(24) = 151
										GoTo IL_718
										IL_1A92:
										array(23) = 27
										num4 = 333
										GoTo IL_709
										IL_763:
										array(24) = CByte(num5)
										num3 = 308
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_75A:
										num5 = 162
										GoTo IL_763
										IL_794:
										num8 = 83
										num3 = 279
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_7AA
										End If
										Continue Do
										IL_786:
										array4(6) = CByte(num6)
										GoTo IL_794
										IL_7AA:
										array4(3) = CByte(num6)
										num3 = 38
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_7C8
										End If
										Continue Do
										IL_7DA:
										array4(3) = CByte(num8)
										num3 = 15
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_408
										End If
										Continue Do
										IL_7D4:
										num8 = 21
										GoTo IL_7DA
										IL_7C8:
										array4(3) = 86
										GoTo IL_7D4
										IL_82A:
										array4(5) = CByte(num6)
										num3 = 338
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo Block_35
										End If
										Continue Do
										IL_824:
										num6 = 46
										GoTo IL_82A
										IL_816:
										array4(5) = CByte(num8)
										GoTo IL_824
										IL_864:
										array(14) = CByte(num7)
										num3 = 337
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_85B:
										num7 = 148
										GoTo IL_864
										IL_88D:
										array(0) = CByte(num5)
										num3 = 38
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Continue Do
										End If
										IL_8AB:
										num7 = 110
										num3 = 349
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_8D4:
										array(6) = 101
										num3 = 324
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_8C6:
										array(6) = CByte(num7)
										GoTo IL_8D4
										IL_8F5:
										num7 = 72
										num3 = 287
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_919:
										array(6) = CByte(num7)
										num3 = 160
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_994:
										num8 = 5
										num3 = 66
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_986:
										array4(8) = CByte(num8)
										GoTo IL_994
										IL_974:
										num8 = 163
										num4 = 189
										GoTo IL_986
										IL_9AE:
										array4(0) = CByte(num6)
										num3 = 14
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_408
										End If
										Continue Do
										IL_A0C:
										array(28) = CByte(num7)
										num3 = 212
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_A03:
										num7 = 219
										GoTo IL_A0C
										IL_9F4:
										array(28) = 168
										GoTo IL_A03
										IL_9E8:
										array(28) = 91
										GoTo IL_9F4
										IL_9D1:
										array(28) = CByte(num5)
										num4 = 284
										GoTo IL_9E8
										IL_A75:
										num5 = 44
										num3 = 82
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_A66:
										array(11) = 156
										GoTo IL_A75
										IL_A58:
										array(11) = CByte(num5)
										GoTo IL_A66
										IL_A4F:
										num5 = 148
										GoTo IL_A58
										IL_A43:
										array(10) = 83
										GoTo IL_A4F
										IL_A35:
										array(10) = CByte(num5)
										GoTo IL_A43
										IL_A90:
										array(2) = CByte(num5)
										num3 = 303
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_169A:
										num5 = 113
										GoTo IL_A90
										IL_AB3:
										array4(11) = CByte(num8)
										num3 = 73
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_AD1
										End If
										Continue Do
										IL_1744:
										num8 = 81
										GoTo IL_AB3
										IL_AF7:
										array(8) = CByte(num7)
										num3 = 107
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_483
										End If
										Continue Do
										IL_AEE:
										num7 = 147
										GoTo IL_AF7
										IL_AD7:
										array(7) = CByte(num7)
										num4 = 77
										GoTo IL_AEE
										IL_AD1:
										num7 = 33
										GoTo IL_AD7
										IL_E39:
										array(7) = 210
										GoTo IL_AD1
										IL_E2D:
										array(7) = 99
										GoTo IL_E39
										IL_1B02:
										array(7) = 111
										GoTo IL_E2D
										IL_B3C:
										array(27) = 138
										num3 = 184
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_B5B
										End If
										Continue Do
										IL_B2E:
										array(27) = CByte(num5)
										GoTo IL_B3C
										IL_B82:
										num6 = 116
										num3 = 242
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_B73:
										array4(10) = 149
										GoTo IL_B82
										IL_B67:
										array4(10) = 79
										GoTo IL_B73
										IL_B5B:
										array4(9) = 54
										GoTo IL_B67
										IL_C1F:
										array(0) = 94
										num3 = 235
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_CA3:
										array(26) = 206
										num3 = 233
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_C97:
										array(25) = 9
										GoTo IL_CA3
										IL_C8B:
										array(25) = 71
										GoTo IL_C97
										IL_C73:
										array(25) = 151
										num4 = 283
										GoTo IL_C8B
										IL_C67:
										array(25) = 63
										GoTo IL_C73
										IL_C58:
										array(25) = 136
										GoTo IL_C67
										IL_CD3:
										array(1) = 143
										num3 = 106
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_CF2
										End If
										Continue Do
										IL_CC7:
										array(1) = 105
										GoTo IL_CD3
										IL_13F7:
										array(1) = CByte(num5)
										GoTo IL_CC7
										IL_D20:
										num5 = 126
										num3 = 128
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_D36
										End If
										Continue Do
										IL_D12:
										array(2) = CByte(num7)
										GoTo IL_D20
										IL_D09:
										num7 = 158
										GoTo IL_D12
										IL_CFB:
										array(2) = CByte(num5)
										GoTo IL_D09
										IL_CF2:
										num5 = 168
										GoTo IL_CFB
										IL_D36:
										num6 = 235
										num3 = 240
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_D62:
										num6 = 126
										num3 = 42
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_DA5:
										array(14) = CByte(num5)
										num3 = 329
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_D9F:
										num5 = 86
										GoTo IL_DA5
										IL_D90:
										array(14) = 144
										GoTo IL_D9F
										IL_E12:
										num8 = 70
										num3 = 281
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_E04:
										array4(14) = CByte(num8)
										GoTo IL_E12
										IL_DF5:
										num8 = 122
										num4 = 216
										GoTo IL_E04
										IL_DE6:
										array4(14) = 133
										GoTo IL_DF5
										IL_EA1:
										array4(0) = 145
										num3 = 34
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Continue Do
										End If
										IL_EC0:
										array(20) = CByte(num5)
										num3 = 88
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_EDE
										End If
										Continue Do
										IL_15E5:
										num5 = 129
										GoTo IL_EC0
										IL_EDE:
										array(20) = 91
										num3 = 71
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_EFA
										End If
										Continue Do
										IL_F03:
										array(20) = CByte(num5)
										num3 = 277
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_F21
										End If
										Continue Do
										IL_EFA:
										num5 = 161
										GoTo IL_F03
										IL_F21:
										array(15) = 94
										num3 = 286
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_F59:
										num8 = 133
										num3 = 1
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_F4B:
										array4(12) = CByte(num8)
										GoTo IL_F59
										IL_FB2:
										array(27) = 152
										num3 = 105
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_F9D:
										array(27) = 99
										num4 = 254
										GoTo IL_FB2
										IL_F8E:
										array(26) = 166
										GoTo IL_F9D
										IL_F80:
										array(26) = CByte(num7)
										GoTo IL_F8E
										IL_F77:
										num7 = 175
										GoTo IL_F80
										IL_162F:
										array(26) = CByte(num5)
										GoTo IL_F77
										IL_FF4:
										array(13) = 151
										num3 = 72
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Continue Do
										End If
										IL_1013:
										array(13) = 122
										num3 = 22
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1042:
										array(30) = 106
										num3 = 144
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1034:
										array(30) = CByte(num5)
										GoTo IL_1042
										IL_1790:
										num5 = 24
										GoTo IL_1034
										IL_18DC:
										array(30) = 167
										GoTo IL_1790
										IL_1063:
										num5 = 39
										num3 = 58
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_19A1:
										array(12) = 106
										num4 = 290
										GoTo IL_1063
										IL_198A:
										array(12) = CByte(num7)
										num4 = 21
										GoTo IL_19A1
										IL_1BA7:
										num7 = 124
										GoTo IL_198A
										IL_10C1:
										num5 = 171
										num3 = 2
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_10DA
										End If
										Continue Do
										IL_10B3:
										array(15) = CByte(num7)
										GoTo IL_10C1
										IL_10AD:
										num7 = 25
										GoTo IL_10B3
										IL_10E8:
										array(16) = 120
										num3 = 280
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_B5B
										End If
										Continue Do
										IL_10DA:
										array(15) = CByte(num5)
										GoTo IL_10E8
										IL_1109:
										array(19) = 75
										num3 = 183
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											Continue Do
										End If
										IL_1125:
										stream = WP6RZJql8gZrNhVA9v.HFrmJl2Alwc9Te6y4t()
										num3 = 87
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_115F:
										num6 = 108
										num3 = 298
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_CFB
										End If
										Continue Do
										IL_1150:
										array4(4) = 151
										GoTo IL_115F
										IL_1141:
										array4(4) = 154
										GoTo IL_1150
										IL_1601:
										array4(4) = 102
										GoTo IL_1141
										IL_11C2:
										array4(7) = 168
										num3 = 35
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_11F5:
										array(20) = 31
										num3 = 352
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_121F:
										array(9) = CByte(num7)
										num3 = 8
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_123D
										End If
										Continue Do
										IL_1216:
										num7 = 209
										GoTo IL_121F
										IL_14C5:
										array(9) = 79
										GoTo IL_1216
										IL_1260:
										num7 = 116
										num3 = 31
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_1276
										End If
										Continue Do
										IL_1251:
										array(10) = 153
										GoTo IL_1260
										IL_1243:
										array(10) = CByte(num7)
										GoTo IL_1251
										IL_123D:
										num7 = 81
										GoTo IL_1243
										IL_128A:
										array(10) = CByte(num7)
										num3 = 318
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1284:
										num7 = 115
										GoTo IL_128A
										IL_1276:
										array(10) = CByte(num7)
										GoTo IL_1284
										IL_12C1:
										num6 = 179
										num3 = 28
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_7AA
										End If
										Continue Do
										IL_12B3:
										array4(3) = CByte(num6)
										GoTo IL_12C1
										IL_12AD:
										num6 = 48
										GoTo IL_12B3
										IL_12DF:
										array4(11) = 157
										num3 = 294
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_1303:
										array(0) = CByte(num5)
										num3 = 177
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Continue Do
										End If
										IL_1321:
										array(21) = CByte(num7)
										num3 = 314
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_1063
										End If
										Continue Do
										IL_136E:
										num8 = 160
										num3 = 228
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_1362:
										array4(2) = 126
										GoTo IL_136E
										IL_1353:
										array4(2) = 158
										GoTo IL_1362
										IL_1344:
										array4(2) = 222
										GoTo IL_1353
										IL_13A0:
										array(29) = 91
										num3 = 255
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_1392:
										array(29) = CByte(num7)
										GoTo IL_13A0
										IL_138C:
										num7 = 57
										GoTo IL_1392
										IL_13DF:
										WP6RZJql8gZrNhVA9v.WBS940x28268jF0EVq(symmetricAlgorithm, CipherMode.CBC)
										num3 = 7
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_13F7
										End If
										Continue Do
										IL_1425:
										array4(7) = CByte(num6)
										num3 = 321
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_145F:
										array(29) = CByte(num5)
										num3 = 141
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1482:
										array(9) = 131
										num3 = 72
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_14A1
										End If
										Continue Do
										IL_14A7:
										array(9) = CByte(num7)
										num3 = 32
										If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo IL_14C5
										End If
										Continue Do
										IL_14A1:
										num7 = 104
										GoTo IL_14A7
										IL_14FD:
										array4(12) = CByte(num8)
										num3 = 257
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_14F7:
										num8 = 21
										GoTo IL_14FD
										IL_191C:
										array4(12) = CByte(num8)
										GoTo IL_14F7
										IL_1544:
										array4(9) = 118
										num3 = 129
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_1535:
										array4(9) = 135
										GoTo IL_1544
										IL_156E:
										array(18) = CByte(num5)
										num3 = 108
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											Continue Do
										End If
										IL_158C:
										num5 = 146
										num3 = 299
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_128A
										End If
										Continue Do
										IL_15B8:
										array4(10) = 106
										num3 = 210
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_16C1:
										array(18) = 68
										num3 = 244
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_16FC:
										num8 = 112
										num3 = 137
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_16ED:
										array4(15) = 134
										GoTo IL_16FC
										IL_1848:
										array4(9) = 108
										num3 = 247
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_189B:
										array(3) = CByte(num5)
										num3 = 30
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1895:
										num5 = 104
										GoTo IL_189B
										IL_196F:
										num7 = 78
										num3 = 292
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											Exit Do
										End If
										Continue Do
										IL_1961:
										array(12) = CByte(num5)
										GoTo IL_196F
										IL_1A55:
										array3 = array4
										num3 = 230
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1A47:
										array4(15) = CByte(num8)
										GoTo IL_1A55
										IL_1A35:
										num8 = 248
										num4 = 44
										GoTo IL_1A47
										IL_1B30:
										array(8) = 186
										num3 = 263
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											Exit Do
										End If
										Continue Do
										IL_1B7E:
										num7 = 96
										num3 = 152
									Loop While WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing
									Block_41:
									Block_50:
									Block_56:
									Block_58:
									Block_59:
									Block_70:
									Block_79:
									Block_83:
									Block_90:
									Block_91:
									Block_92:
									Block_93:
									Block_94:
									Block_101:
									Block_102:
									Block_107:
									Block_108:
									Block_110:
									IL_1EC:
									num3 = num4
									GoTo IL_1D58
									IL_BD0:
									array(0) = CByte(num5)
									num3 = 310
									If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
										GoTo IL_1EC
									End If
									GoTo IL_1D58
									IL_BC1:
									num5 = 118
									num4 = 296
									GoTo IL_BD0
									IL_BB3:
									array = New Byte(31) {}
									GoTo IL_BC1
									IL_B9D:
									array5 = WP6RZJql8gZrNhVA9v.zsgogFH9IX0aLEDDm9(vtNVUKGulysZw81C3E, CInt(WP6RZJql8gZrNhVA9v.KZTrtCf53NZXL4PTtk(WP6RZJql8gZrNhVA9v.WXOeb5wHIamrsOQSBc(vtNVUKGulysZw81C3E))))
									GoTo IL_BB3
								End While
								Block_35:
								GoTo IL_233D
								IL_2310:
								Dim cryptoStream As CryptoStream = New CryptoStream(stream, cryptoTransform, CryptoStreamMode.Write)
								num4 = 267
								IL_2325:
								WP6RZJql8gZrNhVA9v.aBGsYJukCtknOBPdhe(cryptoStream, array5, 0, array5.Length)
								IL_2333:
								WP6RZJql8gZrNhVA9v.Ehl5ahyGm25yJdTcn9(cryptoStream)
								IL_233D:
								WP6RZJql8gZrNhVA9v.Gy5MrBqpDgNC07UXTq(WP6RZJql8gZrNhVA9v.onZkkIlVOi, WP6RZJql8gZrNhVA9v.cwgZ22rDsSHcxkecNY(WP6RZJql8gZrNhVA9v.bC8IdekKvqYj6IlgON(), WP6RZJql8gZrNhVA9v.E323IrFBAerYfQ7ORP(stream)))
								num4 = 53
								IL_2361:
								WP6RZJql8gZrNhVA9v.cOXRIv0aQQDp1vG7i5(stream)
								IL_2368:
								WP6RZJql8gZrNhVA9v.cOXRIv0aQQDp1vG7i5(cryptoStream)
								num4 = 193
								IL_2378:
								WP6RZJql8gZrNhVA9v.AV0fJeBwnY4WbR45iL(vtNVUKGulysZw81C3E)
								IL_237F:
								GoTo IL_23C3
							Catch
								Dim num9 As Integer = 0
								If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									Dim num10 As Integer
									num9 = num10
								End If
								While True
									Select Case num9
										Case Else
											flag = True
											num9 = 1
											If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
												GoTo IL_23B0
											End If
										Case 1
											GoTo IL_23B0
									End Select
								End While
								IL_23B0:
								GoTo IL_23C3
							End Try
							GoTo IL_23B2
						Case 2
							GoTo IL_14F
						Case 3
							GoTo IL_2A60
						Case 4
							GoTo IL_2A5B
						Case 5
							Return
						Case 6
							GoTo IL_15F
						Case 7
							Return
						Case 8
							GoTo IL_2A57
						Case 9
							GoTo IL_155
						Case 10
							GoTo IL_18A
						Case 11
						Case 12
							GoTo IL_14A
						Case 13
							GoTo IL_09
						Case 14
							GoTo IL_82
						Case 15
							Try
								hashAlgorithm = WP6RZJql8gZrNhVA9v.otroNqYfktPuUxqtPs()
								Dim num11 As Integer = 1
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
									GoTo IL_E6
								End If
								While True
									IL_107:
									Select Case num11
										Case 1
											text = WP6RZJql8gZrNhVA9v.b9i2hP1yFCFA0mkXRU("SHA1")
											num11 = 2
											If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
												GoTo Block_15
											End If
											Continue For
										Case 2
											If Not WP6RZJql8gZrNhVA9v.M9asCGJsxO6UEWZN5N(text2) Then
												GoTo IL_122
											End If
											num11 = 0
											If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
												GoTo IL_E6
											End If
											Continue For
										Case 3
											GoTo IL_122
									End Select
									GoTo Block_16
								End While
								Block_15:
								GoTo IL_E6
								Block_16:
								GoTo IL_127
								IL_122:
								Return
								IL_127:
								GoTo IL_A4
								IL_E6:
								Dim num12 As Integer
								num11 = num12
								GoTo IL_107
							Catch
								Dim num13 As Integer = 0
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
									Select Case num13
									End Select
								End If
								Return
							End Try
							GoTo IL_14A
						Case 16
							GoTo IL_A4
						Case 17
							GoTo IL_23D2
						Case 18
							If text2 IsNot Nothing Then
								GoTo IL_82
							End If
							Return
						Case Else
							GoTo IL_23C3
					End Select
					IL_8E:
					hashAlgorithm = Nothing
					num2 = 10
					If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
						GoTo IL_9E
					End If
					Continue For
					IL_A4:
					flag = False
					num2 = 1
					If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
						GoTo Block_4
					End If
					Continue For
					IL_15F:
					text2 = WP6RZJql8gZrNhVA9v.c2UTnFNIs0BonkjSDm(WP6RZJql8gZrNhVA9v.JtnmN8tYQJeNqfcVqt(GetType(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)
					num2 = 18
					If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
						GoTo Block_6
					End If
					Continue For
					IL_155:
					WP6RZJql8gZrNhVA9v.onZkkIlVOi = New RSACryptoServiceProvider()
					GoTo IL_15F
					IL_14F:
					WP6RZJql8gZrNhVA9v.sZNERSiV2XFxGCIxuo(True)
					GoTo IL_155
					IL_14A:
					WP6RZJql8gZrNhVA9v.II4mbg8DI7HcBFm1bf()
					GoTo IL_14F
					IL_23B2:
					num2 = 17
					If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
						Exit For
					End If
					Continue For
					IL_23C3:
					If Not flag Then
						GoTo IL_23B2
					End If
					GoTo IL_2A57
					IL_82:
					If WP6RZJql8gZrNhVA9v.S7AvrlRnL3oEbvTxnV(text2) <> 0 Then
						GoTo IL_8E
					End If
					Return
				End While
				Exit While
				Block_6:
				Block_4:
				GoTo IL_9E
				IL_23D2:
				Try
					Dim text2 As String
					Dim fileStream As FileStream = New FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.Read)
					While True
						IL_2A15:
						Dim binaryReader As BinaryReader = New BinaryReader(fileStream)
						While True
							IL_29F4:
							Dim array6 As Byte() = New Byte(65535) {}
							Dim num14 As Integer = 44
							If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
								GoTo IL_288E
							End If
							Dim hashAlgorithm As HashAlgorithm
							Dim num19 As Integer
							Dim flag2 As Boolean
							Dim num20 As UInteger
							Dim num21 As Long
							Dim num22 As Integer
							Dim num23 As UInteger
							Dim num25 As Integer
							Dim num26 As Long
							While True
								IL_28C5:
								Dim num16 As Long
								Dim num17 As Long
								Dim num15 As UInteger
								Dim num18 As Long
								Dim num24 As UInteger
								Select Case num14
									Case 1
										array6(37) = 0
										num14 = 70
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo Block_137
										End If
										Continue For
									Case 2
										GoTo IL_286B
									Case 3, 39
										GoTo IL_2538
									Case 4, 19
										GoTo IL_2790
									Case 5
										GoTo IL_247E
									Case 6
										GoTo IL_28A6
									Case 7
										GoTo IL_2409
									Case 8, 14, 49
										GoTo IL_24AB
									Case 9
										GoTo IL_2874
									Case 10
										GoTo IL_2688
									Case 11
										GoTo IL_256A
									Case 12
										GoTo IL_26C8
									Case 13
										GoTo IL_2603
									Case 15
										GoTo IL_26F1
									Case 16, 71
										GoTo IL_2452
									Case 17, 47
										GoTo IL_24B0
									Case 18
										GoTo IL_26BF
									Case 20
										GoTo IL_2886
									Case 21
										GoTo IL_23EA
									Case 22
										GoTo IL_288E
									Case 23
										GoTo IL_25EA
									Case 24
										GoTo IL_2712
									Case 25, 40
										GoTo IL_276E
									Case 26
										GoTo IL_2780
									Case 27
										array6(32) = 0
										GoTo IL_2886
									Case 28, 62
										GoTo IL_24B6
									Case 29
										GoTo IL_246C
									Case 30
										num15 = CUInt((num16 - num17))
										num14 = 2
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
											GoTo IL_286B
										End If
										Continue For
									Case 31
										WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, num18)
										GoTo IL_27C3
									Case 32
										GoTo IL_2682
									Case 33
										GoTo IL_2627
									Case 34
										GoTo IL_2675
									Case 35
										If num18 > num17 Then
											GoTo IL_2532
										End If
										num14 = 41
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo Block_136
										End If
										Continue For
									Case 36
										GoTo IL_2709
									Case 37
										GoTo IL_2548
									Case 38
										GoTo IL_2816
									Case 41
										If num17 >= num16 Then
											GoTo IL_2532
										End If
										num14 = 30
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo Block_134
										End If
										Continue For
									Case 42
										WP6RZJql8gZrNhVA9v.g3L1ud53dmLm0QRsAZ(hashAlgorithm, fileStream, CUInt((num19 * 40)), array6)
										num14 = 61
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo Block_132
										End If
										Continue For
									Case 43
										GoTo IL_27C3
									Case 44
										WP6RZJql8gZrNhVA9v.g3L1ud53dmLm0QRsAZ(hashAlgorithm, fileStream, 152UI, array6)
										num14 = 22
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_24AB
										End If
										Continue For
									Case 45
										If Not flag2 Then
											GoTo IL_276E
										End If
										GoTo IL_2780
									Case 46
										GoTo IL_26B2
									Case 48
										GoTo IL_2762
									Case 50
										GoTo IL_2748
									Case 51
										GoTo IL_24F3
									Case 52
										WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, CLng(CULng(num20)))
										GoTo IL_24AB
									Case 53
										GoTo IL_24CE
									Case 54
										GoTo IL_26D1
									Case 55
										GoTo IL_271A
									Case 56
										GoTo IL_26A3
									Case 57
										WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, 152L)
										GoTo IL_2675
									Case 58
										GoTo IL_243A
									Case 59
										GoTo IL_29F4
									Case 60
										GoTo IL_2659
									Case 61
										num21 = WP6RZJql8gZrNhVA9v.AXOUZwIZuxUBMWZHh0(fileStream)
										num14 = 45
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo IL_2627
										End If
										Continue For
									Case 63
										WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, 134L)
										GoTo IL_2603
									Case 64
										GoTo IL_2A15
									Case 65
										GoTo IL_25AA
									Case 66
										WP6RZJql8gZrNhVA9v.PejaI79GYOY8UhfnPZ(fileStream, array6, 0, 128)
										num14 = 27
										If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
											GoTo Block_124
										End If
										Continue For
									Case 67
										GoTo IL_2532
									Case 68
										WP6RZJql8gZrNhVA9v.lTpnE0bAsXkTddG4aT(hashAlgorithm, array6, 0, num22)
										num14 = 66
										If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
											GoTo Block_122
										End If
										Continue For
									Case 69
										num23 -= num24
										GoTo IL_24AB
									Case 70
										array6(38) = 0
										GoTo IL_23E4
									Case 72
										array6(66) = 0
										num25 = 58
										GoTo IL_243A
									Case 73
										GoTo IL_23E4
								End Select
								GoTo Block_138
								IL_23EA:
								WP6RZJql8gZrNhVA9v.lTpnE0bAsXkTddG4aT(hashAlgorithm, array6, 0, 128)
								num14 = 1
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
									GoTo IL_2409
								End If
								Continue For
								IL_23E4:
								array6(39) = 0
								GoTo IL_23EA
								IL_2409:
								num26 = WP6RZJql8gZrNhVA9v.AXOUZwIZuxUBMWZHh0(fileStream)
								num14 = 63
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
									Exit For
								End If
								Continue For
								IL_243A:
								array6(67) = 0
								num14 = 68
								If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									Exit For
								End If
								Continue For
								IL_24F3:
								num17 = WP6RZJql8gZrNhVA9v.AXOUZwIZuxUBMWZHh0(fileStream)
								num14 = 35
								If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									Exit For
								End If
								Continue For
								IL_24AB:
								If num23 <= 0UI Then
									GoTo IL_24B0
								End If
								GoTo IL_24F3
								IL_271A:
								Dim fileStream2 As FileStream = fileStream
								WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream2, WP6RZJql8gZrNhVA9v.AXOUZwIZuxUBMWZHh0(fileStream2) + CLng(CULng(num15)))
								num25 = 49
								GoTo IL_24AB
								IL_2874:
								num23 -= num15
								GoTo IL_271A
								IL_286B:
								If num15 < num23 Then
									GoTo IL_2874
								End If
								GoTo IL_24B0
								IL_2548:
								WP6RZJql8gZrNhVA9v.g3L1ud53dmLm0QRsAZ(hashAlgorithm, fileStream, num24, array6)
								num14 = 69
								If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									Exit For
								End If
								Continue For
								IL_2538:
								num24 = CUInt(WP6RZJql8gZrNhVA9v.F9hfLPEXa6TTj6vidY(num18 - num17, CLng(CULng(num23))))
								GoTo IL_2548
								IL_2532:
								If num17 < num16 Then
									GoTo IL_2538
								End If
								GoTo IL_256A
								IL_25AA:
								Dim array7 As Byte()
								flag = Not WP6RZJql8gZrNhVA9v.bj15SVKnAylKJmoLma(WP6RZJql8gZrNhVA9v.onZkkIlVOi, WP6RZJql8gZrNhVA9v.GYvrQMS8pKiMfMlh1c(hashAlgorithm), text, array7)
								num14 = 0
								If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									GoTo Block_125
								End If
								Continue For
								IL_2659:
								WP6RZJql8gZrNhVA9v.x7GgNxdQoFBb9qdlHj(array7)
								GoTo IL_25AA
								IL_27C3:
								Dim num27 As UInteger
								array7 = WP6RZJql8gZrNhVA9v.AlAGlwWX8fLEnOikJT(binaryReader, CInt(num27))
								GoTo IL_2659
								IL_25EA:
								WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, num26)
								num14 = 42
								If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									Continue For
								End If
								IL_2603:
								num19 = CInt(WP6RZJql8gZrNhVA9v.iN4Rm6COI9q7SRLyMl(binaryReader))
								GoTo IL_25EA
								IL_2688:
								array6(65) = 0
								num14 = 72
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
									Exit For
								End If
								Continue For
								IL_2682:
								array6(64) = 0
								GoTo IL_2688
								IL_2675:
								WP6RZJql8gZrNhVA9v.PejaI79GYOY8UhfnPZ(fileStream, array6, 0, num22)
								GoTo IL_2682
								IL_26D1:
								Dim num28 As UInteger
								num18 = CLng(CULng(WP6RZJql8gZrNhVA9v.YvMOwapfr8H4AmrJhD(num28, num19, num26, binaryReader)))
								num14 = 1
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
									GoTo IL_26F1
								End If
								Continue For
								IL_26C8:
								num27 = WP6RZJql8gZrNhVA9v.JXE4C9cJpC9DrLXLf5(binaryReader)
								GoTo IL_26D1
								IL_26BF:
								num28 = WP6RZJql8gZrNhVA9v.JXE4C9cJpC9DrLXLf5(binaryReader)
								GoTo IL_26C8
								IL_26B2:
								Dim num29 As UInteger
								WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, CLng(CULng((num29 + 32UI))))
								GoTo IL_26BF
								IL_26A3:
								Dim num30 As UInteger
								num29 = WP6RZJql8gZrNhVA9v.YvMOwapfr8H4AmrJhD(num30, num19, num26, binaryReader)
								GoTo IL_26B2
								IL_2790:
								num30 = WP6RZJql8gZrNhVA9v.JXE4C9cJpC9DrLXLf5(binaryReader)
								GoTo IL_26A3
								IL_2780:
								WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, 360L)
								GoTo IL_2790
								IL_276E:
								WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, 376L)
								GoTo IL_2790
								IL_26F1:
								num16 = num18 + CLng(CULng(num27))
								num14 = 11
								If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									GoTo IL_2709
								End If
								Continue For
								IL_2748:
								array6(36) = 0
								num14 = 1
								If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
									GoTo Block_130
								End If
								Continue For
								IL_2762:
								array6(35) = 0
								GoTo IL_2748
								IL_2816:
								array6(34) = 0
								num25 = 48
								GoTo IL_2762
								IL_2886:
								array6(33) = 0
								GoTo IL_2816
							End While
							GoTo IL_2422
							IL_2712:
							Dim num31 As Integer = 0
							GoTo IL_24B6
							IL_2709:
							WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, num21)
							GoTo IL_2712
							IL_28A6:
							Dim num32 As Integer = 112
							GoTo IL_2642
							Block_122:
							Block_124:
							Block_132:
							Block_134:
							Block_136:
							Block_137:
							IL_2422:
							num14 = num25
							GoTo IL_28C5
							IL_247E:
							num20 = WP6RZJql8gZrNhVA9v.JXE4C9cJpC9DrLXLf5(binaryReader)
							num14 = 52
							If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
								GoTo IL_2422
							End If
							GoTo IL_28C5
							IL_246C:
							num23 = WP6RZJql8gZrNhVA9v.JXE4C9cJpC9DrLXLf5(binaryReader)
							num25 = 5
							GoTo IL_247E
							IL_2452:
							WP6RZJql8gZrNhVA9v.VymkpwXddOWY529qU7(fileStream, num26 + CLng((num31 * 40)) + 16L)
							GoTo IL_246C
							IL_24B6:
							If num31 >= num19 Then
								GoTo IL_24CE
							End If
							num14 = 58
							If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() Is Nothing Then
								GoTo IL_2452
							End If
							GoTo IL_28C5
							IL_24B0:
							num31 += 1
							GoTo IL_24B6
							IL_256A:
							WP6RZJql8gZrNhVA9v.g3L1ud53dmLm0QRsAZ(hashAlgorithm, fileStream, num23, array6)
							num25 = 17
							GoTo IL_24B0
							IL_24CE:
							WP6RZJql8gZrNhVA9v.kZ8j1kOIjc9JP5JyjS(hashAlgorithm, New Byte(-1) {}, 0, 0)
							num14 = 31
							If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
								GoTo IL_2422
							End If
							GoTo IL_28C5
							IL_2627:
							If flag2 Then
								num32 = 96
								GoTo IL_2642
							End If
							num14 = 6
							If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
								GoTo IL_2422
							End If
							GoTo IL_28C5
							IL_288E:
							flag2 = WP6RZJql8gZrNhVA9v.iN4Rm6COI9q7SRLyMl(binaryReader) <> 523US
							GoTo IL_2627
							IL_2642:
							num22 = num32
							num14 = 57
							If Not WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
								GoTo IL_256A
							End If
							GoTo IL_28C5
						End While
					End While
					Block_125:
					Block_130:
					Block_138:
				Catch
					Dim num33 As Integer = 0
					If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
						Dim num34 As Integer
						num33 = num34
					End If
					While True
						Select Case num33
							Case Else
								flag = True
								num33 = 1
								If WP6RZJql8gZrNhVA9v.MjUpQTUAyyOAp6C2gO() Then
									GoTo IL_2A55
								End If
							Case 1
								GoTo IL_2A55
						End Select
					End While
					IL_2A55:
				End Try
				IL_2A57:
				If flag Then
					GoTo IL_2A60
				End If
				IL_2A5B:
				flag = False
				Exit While
				IL_2A60:
				Throw New Exception(WP6RZJql8gZrNhVA9v.npZFOvQXD5kPgI2P4g(WP6RZJql8gZrNhVA9v.nW1uWt45ylgAA4v2Tb(WP6RZJql8gZrNhVA9v.xyEln2lHnNyCvSd1Of(WP6RZJql8gZrNhVA9v.JtnmN8tYQJeNqfcVqt(GetType(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)), " is tampered."))
				IL_9E:
				num2 = num
				GoTo IL_25
				IL_18A:
				text = Nothing
				num2 = 15
				If WP6RZJql8gZrNhVA9v.Q8X6PuAZ66pEnQWCMg() IsNot Nothing Then
					GoTo IL_9E
				End If
				GoTo IL_25
			End While
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x00008600 File Offset: 0x00006800
		Public Shared Sub TAJo1U8fio(runtimeTypeHandle_0 As RuntimeTypeHandle)
			Try
				Dim typeFromHandle As Type = Type.GetTypeFromHandle(runtimeTypeHandle_0)
				If WP6RZJql8gZrNhVA9v.Tqek0lIh21 Is Nothing Then
					Dim flag As Boolean = False
					Try
						Dim obj As Object = WP6RZJql8gZrNhVA9v.emjkxI4Yxp
						Dim obj2 As Object = obj
						Monitor.Enter(obj, flag)
						Dim dictionary As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)()
						Dim binaryReader As BinaryReader = New BinaryReader(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554449)).Assembly.GetManifestResourceStream("8YcRZQR7giU19AYvkS.C2FZI3AnQYVdyvPtb4"))
						binaryReader.BaseStream.Position = 0L
						Dim array As Byte() = binaryReader.ReadBytes(CInt(binaryReader.BaseStream.Length))
						binaryReader.Close()
						If array.Length > 0 Then
							Dim num As Integer = array.Length Mod 4
							Dim num2 As Integer = array.Length / 4
							Dim array2 As Byte() = New Byte(array.Length - 1) {}
							Dim num3 As UInteger = 0UI
							If num > 0 Then
								num2 += 1
							End If
							For i As Integer = 0 To num2 - 1
								Dim num4 As Integer = i * 4
								Dim num5 As UInteger = 255UI
								Dim num6 As Integer = 0
								Dim num7 As UInteger
								If i = num2 - 1 AndAlso num > 0 Then
									num7 = 0UI
									For j As Integer = 0 To num - 1
										If j > 0 Then
											num7 <<= 8
										End If
										num7 = num7 Or CUInt(array(array.Length - (1 + j)))
									Next
								Else
									Dim num8 As UInteger = CUInt(num4)
									num7 = CUInt(((CInt(array(CInt(CType((num8 + 3UI), UIntPtr)))) << 24) Or (CInt(array(CInt(CType((num8 + 2UI), UIntPtr)))) << 16) Or (CInt(array(CInt(CType((num8 + 1UI), UIntPtr)))) << 8) Or CInt(array(CInt(CType(num8, UIntPtr))))))
								End If
								num3 = num3
								num3 += WP6RZJql8gZrNhVA9v.EObomOjAWk(num3)
								If i = num2 - 1 AndAlso num > 0 Then
									Dim num9 As UInteger = num3 Xor num7
									For k As Integer = 0 To num - 1
										If k > 0 Then
											num5 <<= 8
											num6 += 8
										End If
										array2(num4 + k) = CByte(((num9 And num5) >> num6))
									Next
								Else
									Dim num10 As UInteger = num3 Xor num7
									array2(num4) = CByte((num10 And 255UI))
									array2(num4 + 1) = CByte(((num10 And 65280UI) >> 8))
									array2(num4 + 2) = CByte(((num10 And 16711680UI) >> 16))
									array2(num4 + 3) = CByte(((num10 And 4278190080UI) >> 24))
								End If
							Next
							array = array2
							Dim num11 As Integer = array.Length / 8
							Dim vtNVUKGulysZw81C3E As WP6RZJql8gZrNhVA9v.VtNVUKGulysZw81C3E = New WP6RZJql8gZrNhVA9v.VtNVUKGulysZw81C3E(New MemoryStream(array))
							For l As Integer = 0 To num11 - 1
								Dim num12 As Integer = vtNVUKGulysZw81C3E.TVtkAMaqpL()
								Dim num13 As Integer = vtNVUKGulysZw81C3E.TVtkAMaqpL()
								dictionary.Add(num12, num13)
							Next
							vtNVUKGulysZw81C3E.VDqkQKyKML()
						End If
						WP6RZJql8gZrNhVA9v.Tqek0lIh21 = dictionary
					Finally
						If flag Then
							Dim obj2 As Object
							Monitor.[Exit](obj2)
						End If
					End Try
				End If
				For Each fieldInfo As FieldInfo In typeFromHandle.GetFields(BindingFlags.[Static] Or BindingFlags.NonPublic Or BindingFlags.GetField)
					Dim metadataToken As Integer = fieldInfo.MetadataToken
					Dim num14 As Integer = WP6RZJql8gZrNhVA9v.Tqek0lIh21(metadataToken)
					Dim flag2 As Boolean = (num14 And 1073741824) > 0
					num14 = num14 And 1073741823
					Dim methodInfo As MethodInfo = CType(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554449)).[Module].ResolveMethod(num14, typeFromHandle.GetGenericArguments(), New Type(-1) {}), MethodInfo)
					If methodInfo.IsStatic Then
						fieldInfo.SetValue(Nothing, [Delegate].CreateDelegate(fieldInfo.FieldType, methodInfo))
					Else
						Dim parameters As ParameterInfo() = methodInfo.GetParameters()
						Dim num15 As Integer = parameters.Length + 1
						Dim array3 As Type() = New Type(num15 - 1) {}
						If methodInfo.DeclaringType.IsValueType Then
							array3(0) = methodInfo.DeclaringType.MakeByRefType()
						Else
							array3(0) = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777237))
						End If
						For n As Integer = 0 To parameters.Length - 1
							array3(n + 1) = parameters(n).ParameterType
						Next
						Dim dynamicMethod As DynamicMethod = New DynamicMethod(String.Empty, methodInfo.ReturnType, array3, typeFromHandle, True)
						Dim ilgenerator As ILGenerator = dynamicMethod.GetILGenerator()
						For num16 As Integer = 0 To num15 - 1
							Select Case num16
								Case 0
									ilgenerator.Emit(OpCodes.Ldarg_0)
								Case 1
									ilgenerator.Emit(OpCodes.Ldarg_1)
								Case 2
									ilgenerator.Emit(OpCodes.Ldarg_2)
								Case 3
									ilgenerator.Emit(OpCodes.Ldarg_3)
								Case Else
									ilgenerator.Emit(OpCodes.Ldarg_S, num16)
							End Select
						Next
						ilgenerator.Emit(OpCodes.Tailcall)
						ilgenerator.Emit(If(flag2, OpCodes.Callvirt, OpCodes.[Call]), methodInfo)
						ilgenerator.Emit(OpCodes.Ret)
						fieldInfo.SetValue(Nothing, dynamicMethod.CreateDelegate(typeFromHandle))
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000067 RID: 103 RVA: 0x00002546 File Offset: 0x00000746
		Private Shared Function vC5oV1W6FK(uint_0 As UInteger) As UInteger
			Return CUInt("{11111-22222-10009-11112}".Length)
		End Function

		' Token: 0x06000068 RID: 104 RVA: 0x00002552 File Offset: 0x00000752
		Private Shared Function EObomOjAWk(uint_0 As UInteger) As UInteger
			Return 0UI
		End Function

		' Token: 0x06000069 RID: 105 RVA: 0x000022A0 File Offset: 0x000004A0
		Friend Shared Sub w65ov7siki()
		End Sub

		' Token: 0x0600006A RID: 106 RVA: 0x00008A80 File Offset: 0x00006C80
		<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
		Friend Shared Function L3hoFlcqP6(int_0 As Integer) As String
			Dim num As Integer = 212
			IL_282D:
			Dim num28 As Integer
			While WP6RZJql8gZrNhVA9v.HkLkNdDPtB.Length = 0
				Dim num2 As Integer = 211
				If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
					GoTo IL_10C
				End If
				Dim array6 As Byte()
				While True
					IL_2157:
					Dim num3 As Integer
					Dim num4 As Integer
					Dim array As Byte()
					Dim array2 As Byte()
					Dim num5 As Integer
					Dim num6 As Integer
					Dim array3 As Byte()
					Dim array4 As Byte()
					Dim num7 As UInteger
					Dim array5 As Byte()
					Dim vtNVUKGulysZw81C3E As WP6RZJql8gZrNhVA9v.VtNVUKGulysZw81C3E
					Dim cryptoStream As CryptoStream
					Dim num8 As Integer
					Dim num9 As Integer
					Dim num10 As UInteger
					Dim num11 As UInteger
					Dim num12 As UInteger
					Dim num13 As Integer
					Select Case num2
						Case 0
							GoTo IL_CF2
						Case 1
							num3 = 119
							num = 288
							GoTo IL_170E
						Case 2
							num3 = 163
							GoTo IL_B8B
						Case 3
							GoTo IL_366
						Case 4
							GoTo IL_95
						Case 5
							GoTo IL_AF9
						Case 6
							GoTo IL_2B1
						Case 7
							GoTo IL_7E
						Case 8
							GoTo IL_2067
						Case 9
							GoTo IL_CC3
						Case 10
							GoTo IL_DAD
						Case 11
							GoTo IL_1317
						Case 12
							GoTo IL_E2B
						Case 13
							GoTo IL_1BED
						Case 14
							num4 = 69
							num2 = 198
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_115
							End If
							Continue For
						Case 15
							GoTo IL_702
						Case 16
							GoTo IL_130E
						Case 17
							GoTo IL_C04
						Case 18
							GoTo IL_134B
						Case 19
							GoTo IL_E62
						Case 20
							GoTo IL_7A8
						Case 21
							GoTo IL_203B
						Case 22
							array(13) = 62
							GoTo IL_1444
						Case 23, 88
							GoTo IL_1DBC
						Case 24
							array(8) = 45
							GoTo IL_181E
						Case 25
							array(25) = CByte(num4)
							num2 = 57
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_114
							End If
							Continue For
						Case 26
							GoTo IL_11D3
						Case 27
							GoTo IL_9E0
						Case 28
							GoTo IL_8CB
						Case 29
							GoTo IL_1CD0
						Case 30, 355
							GoTo IL_914
						Case 31
							GoTo IL_18FC
						Case 32
							GoTo IL_1523
						Case 33
							array2(15) = 162
							GoTo IL_186E
						Case 34
							GoTo IL_E76
						Case 35
							GoTo IL_1157
						Case 36
							GoTo IL_1689
						Case 37
							GoTo IL_15DA
						Case 38
							GoTo IL_1257
						Case 39
							num5 += 1
							GoTo IL_9EA
						Case 40
							GoTo IL_1905
						Case 41
							GoTo IL_D7D
						Case 42
							GoTo IL_4E5
						Case 43
							array(25) = 154
							GoTo IL_17E5
						Case 44
							GoTo IL_BE6
						Case 45
							GoTo IL_113B
						Case 46
							GoTo IL_1A1E
						Case 47
							GoTo IL_3CE
						Case 48
							GoTo IL_117D
						Case 49
							GoTo IL_5F5
						Case 50
							GoTo IL_176A
						Case 51
							GoTo IL_AAA
						Case 52
							GoTo IL_EE
						Case 53
							array2(0) = 18
							GoTo IL_1345
						Case 54
							GoTo IL_DEF
						Case 55
							GoTo IL_288
						Case 56
							GoTo IL_10A9
						Case 57
							num6 = 155
							GoTo IL_1C9F
						Case 58
							GoTo IL_1A4E
						Case 59
							GoTo IL_186E
						Case 60
							GoTo IL_1DF6
						Case 61
							GoTo IL_171C
						Case 62
							GoTo IL_1F3B
						Case 63
							GoTo IL_1CE6
						Case 64
							GoTo IL_C3E
						Case 65
							GoTo IL_1DD2
						Case 66
							GoTo IL_1299
						Case 67
							GoTo IL_384
						Case 68
							GoTo IL_2842
						Case 69
							GoTo IL_415
						Case 70
							GoTo IL_FC7
						Case 71
							num3 = 120
							GoTo IL_21C
						Case 72
							GoTo IL_19C7
						Case 73
							array3(11) = array4(5)
							GoTo IL_2067
						Case 74
							GoTo IL_5C
						Case 75
							GoTo IL_1240
						Case 76
							GoTo IL_1A6A
						Case 77
							num6 = 189
							GoTo IL_203B
						Case 78
							GoTo IL_102F
						Case 79
							num6 = 86
							num = 282
							GoTo IL_174C
						Case 80
							GoTo IL_15AE
						Case 81
							GoTo IL_18CE
						Case 82
							GoTo IL_12E5
						Case 83
							array(21) = CByte(num6)
							num2 = 274
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_112
							End If
							Continue For
						Case 84
							GoTo IL_1165
						Case 85
							GoTo IL_13C
						Case 86
							num4 = 154
							GoTo IL_C27
						Case 87
							GoTo IL_158F
						Case 89
							GoTo IL_8EF
						Case 90
							num3 = 156
							num = 96
							GoTo IL_1FC6
						Case 91
							GoTo IL_6F6
						Case 92, 384
							GoTo IL_941
						Case 93
							GoTo IL_1F0E
						Case 94
							GoTo IL_1334
						Case 95
							GoTo IL_9C0
						Case 96
							GoTo IL_1FC6
						Case 97
							GoTo IL_150C
						Case 98
							GoTo IL_694
						Case 99, 380
							GoTo IL_9EA
						Case 100
							GoTo IL_EBA
						Case 101
							num7 <<= 8
							GoTo IL_8F4
						Case 102
							GoTo IL_1EB5
						Case 103
							num6 = 74
							GoTo IL_1DE8
						Case 104
							GoTo IL_177C
						Case 105
							GoTo IL_1412
						Case 106
							GoTo IL_1D87
						Case 107
							GoTo IL_49B
						Case 108
							GoTo IL_FE4
						Case 109
							array(12) = 180
							GoTo IL_BD1
						Case 110
							GoTo IL_1288
						Case 111
							num6 = 106
							num2 = 83
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_111
							End If
							Continue For
						Case 112
							GoTo IL_141B
						Case 113
							num4 = 99
							num2 = 123
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_110
							End If
							Continue For
						Case 114
							GoTo IL_381
						Case 115
							GoTo IL_1269
						Case 116
							GoTo IL_1365
						Case 117
							num6 = 185
							GoTo IL_D3B
						Case 118
							GoTo IL_13BD
						Case 119
							GoTo IL_1BAC
						Case 120
							GoTo IL_3FE
						Case 121
							GoTo IL_2BF
						Case 122
							GoTo IL_16B4
						Case 123
							array(2) = CByte(num4)
							num2 = 56
							If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_1F3B
							End If
							Continue For
						Case 124
							GoTo IL_1CFD
						Case 125
							GoTo IL_1639
						Case 126
							GoTo IL_2CE
						Case 127
							If array4 Is Nothing Then
								num = 159
								GoTo IL_1DB9
							End If
							GoTo IL_1F0E
						Case 128
							array2(10) = CByte(num3)
							GoTo IL_1B74
						Case 129
							GoTo IL_109A
						Case 130
							GoTo IL_1E86
						Case 131
							GoTo IL_50
						Case 132
							array2(5) = CByte(num3)
							num2 = 271
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_107
							End If
							Continue For
						Case 133
							GoTo IL_28B7
						Case 134
							GoTo IL_7AF
						Case 135
							GoTo IL_1263
						Case 136
							GoTo IL_18DC
						Case 137
							GoTo IL_1A7C
						Case 138
							GoTo IL_19E
						Case 139
							array2(9) = 48
							GoTo IL_1EB5
						Case 140
							num6 = 89
							GoTo IL_1E86
						Case 141
							GoTo IL_FB1
						Case 142
							GoTo IL_DE9
						Case 143
							GoTo IL_E99
						Case 144
							GoTo IL_48C
						Case 145
							GoTo IL_118B
						Case 146
							array2(13) = 84
							num2 = 127
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_1967
							End If
							Continue For
						Case 147
							GoTo IL_A1E
						Case 148
							GoTo IL_727
						Case 149, 159
							GoTo IL_1DB9
						Case 150
							GoTo IL_1E51
						Case 151
							GoTo IL_3E1
						Case 152
							GoTo IL_B6A
						Case 153
							GoTo IL_E68
						Case 154
							array(9) = CByte(num4)
							num2 = 315
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_104
							End If
							Continue For
						Case 155
							GoTo IL_1B7D
						Case 156
							num3 = 115
							num = 195
							GoTo IL_1C15
						Case 157
							GoTo IL_1DE8
						Case 158
							GoTo IL_1AD2
						Case 160
							GoTo IL_3DE
						Case 161
							GoTo IL_1796
						Case 162
							array2(5) = 221
							GoTo IL_2AB
						Case 163
							array(29) = CByte(num4)
							GoTo IL_1D87
						Case 164
							GoTo IL_10CD
						Case 165
							GoTo IL_1226
						Case 166
							GoTo IL_FF2
						Case 167
							array2(11) = CByte(num3)
							GoTo IL_127C
						Case 168
							GoTo IL_390
						Case 169
							GoTo IL_549
						Case 170
							GoTo IL_1D49
						Case 171
							GoTo IL_522
						Case 172
							num6 = 120
							GoTo IL_13A1
						Case 173, 375
							GoTo IL_5AE
						Case 174
							array2(15) = 163
							num2 = 186
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_99
							End If
							Continue For
						Case 175
							GoTo IL_15CE
						Case 176
							GoTo IL_1606
						Case 177
							array(28) = CByte(num6)
							GoTo IL_1CD0
						Case 178
							GoTo IL_1C9F
						Case 179
							GoTo IL_11A4
						Case 180
							GoTo IL_14E7
						Case 181
							GoTo IL_1359
						Case 182
							GoTo IL_1728
						Case 183
							array5 = WP6RZJql8gZrNhVA9v.HkLkNdDPtB
							num2 = 426
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_97
							End If
							Continue For
						Case 184
							GoTo IL_355
						Case 185
							num3 = 88
							GoTo IL_108C
						Case 186
							array2(15) = 96
							num2 = 33
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_96
							End If
							Continue For
						Case 187
							GoTo IL_945
						Case 188
							GoTo IL_15B7
						Case 189
							array(6) = 148
							num2 = 207
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_95
							End If
							Continue For
						Case 190
							GoTo IL_9C4
						Case 191
							GoTo IL_22A
						Case 192
							GoTo IL_1D4
						Case 193
							num6 = 110
							GoTo IL_18A2
						Case 194
							GoTo IL_1174
						Case 195
							GoTo IL_1C15
						Case 196
							array(24) = 102
							num = 336
							GoTo IL_1104
						Case 197
							GoTo IL_1A7
						Case 198
							array(3) = CByte(num4)
							num2 = 2
							If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_1BED
							End If
							Continue For
						Case 199
							num3 = 237
							GoTo IL_1BAC
						Case 200
							GoTo IL_178A
						Case 201
							array = New Byte(31) {}
							GoTo IL_17D7
						Case 202
							GoTo IL_12A7
						Case 203
							GoTo IL_604
						Case 204
							GoTo IL_E82
						Case 205
							GoTo IL_1B74
						Case 206
							array(29) = CByte(num6)
							num2 = 86
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_95
							End If
							Continue For
						Case 207
							num4 = 166
							GoTo IL_15A0
						Case 208
							array4 = WP6RZJql8gZrNhVA9v.u7DAk3lDVkm2JCp36C(WP6RZJql8gZrNhVA9v.m6r2LGxi9aJfd9Wrbl(WP6RZJql8gZrNhVA9v.x4Dk2IHVmX))
							num2 = 127
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_92
							End If
							Continue For
						Case 209
							GoTo IL_1C5
						Case 210
							GoTo IL_1AA8
						Case 211
							vtNVUKGulysZw81C3E = New WP6RZJql8gZrNhVA9v.VtNVUKGulysZw81C3E(WP6RZJql8gZrNhVA9v.lXkgVSwILylAsW3Oyh(WP6RZJql8gZrNhVA9v.x4Dk2IHVmX, "TobEC4hIgCxF0TwsAh.Xg5oMBsggOsrj5CWF8"))
							num2 = 298
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_E68
							End If
							Continue For
						Case 212
							GoTo IL_282D
						Case 213
							GoTo IL_14B
						Case 214
							GoTo IL_CFE
						Case 215
							GoTo IL_157
						Case 216
							GoTo IL_A35
						Case 217
							GoTo IL_1028
						Case 218
							GoTo IL_D9
						Case 219
							GoTo IL_19FD
						Case 220
							array(14) = 207
							GoTo IL_1386
						Case 221
							GoTo IL_41
						Case 222
							WP6RZJql8gZrNhVA9v.dnMS7LsLiubl6a13ds(cryptoStream, array5, 0, array5.Length)
							GoTo IL_1AD2
						Case 223
							GoTo IL_1776
						Case 224
							GoTo IL_478
						Case 225
							GoTo IL_E0D
						Case 226
							GoTo IL_164F
						Case 227
							GoTo IL_16EC
						Case 228
							GoTo IL_69A
						Case 229
							GoTo IL_BD1
						Case 230
							num6 = 157
							num2 = 121
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_1AA8
							End If
							Continue For
						Case 231
							GoTo IL_12DE
						Case 232
							GoTo IL_112F
						Case 233
							GoTo IL_446
						Case 234
							array(23) = 126
							num = 58
							GoTo IL_1A4E
						Case 235
							array2(5) = CByte(num3)
							GoTo IL_1A1E
						Case 236
							num6 = 194
							num2 = 13
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_19FD
							End If
							Continue For
						Case 237
							GoTo IL_37B
						Case 238
							array3(3) = array4(1)
							GoTo IL_19C7
						Case 239
							GoTo IL_239
						Case 240
							GoTo IL_1234
						Case 241
							GoTo IL_711
						Case 242
							num4 = 79
							num = 294
							GoTo IL_166B
						Case 243
							GoTo IL_1487
						Case 244
							array(12) = CByte(num4)
							num2 = 109
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_88
							End If
							Continue For
						Case 245
							GoTo IL_CB5
						Case 246
							GoTo IL_1506
						Case 247
							GoTo IL_1967
						Case 248
							GoTo IL_A27
						Case 249
							GoTo IL_1943
						Case 250
							GoTo IL_1928
						Case 251
							array(14) = 120
							num = 31
							GoTo IL_18FC
						Case 252
							num6 = 142
							GoTo IL_18CE
						Case 253
							GoTo IL_A4D
						Case 254
							GoTo IL_18A2
						Case 255
							GoTo IL_360
						Case 256
							GoTo IL_4B2
						Case 257
							num6 = 140
							num2 = 389
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_82
							End If
							Continue For
						Case 258
							GoTo IL_1456
						Case 259
							GoTo IL_245
						Case 260
							GoTo IL_187C
						Case 261
							GoTo IL_397
						Case 262
							GoTo IL_16FA
						Case 263
							GoTo IL_1850
						Case 264
							array2(8) = 110
							num2 = 329
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_81
							End If
							Continue For
						Case 265
							GoTo IL_5D7
						Case 266
							GoTo IL_181E
						Case 267
							GoTo IL_751
						Case 268
							GoTo IL_80B
						Case 269
							GoTo IL_6A8
						Case 270
							GoTo IL_1532
						Case 271
							num3 = 70
							num2 = 17
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_80
							End If
							Continue For
						Case 272
							GoTo IL_17E5
						Case 273
							GoTo IL_17D7
						Case 274
							array(22) = 160
							num = 299
							GoTo IL_15F7
						Case 275
							GoTo IL_124
						Case 276
							GoTo IL_905
						Case 277
							GoTo IL_829
						Case 278
							GoTo IL_8D1
						Case 279
							GoTo IL_9F3
						Case 280
							GoTo IL_771
						Case 281
							GoTo IL_E8B
						Case 282
							GoTo IL_174C
						Case 283
							GoTo IL_1568
						Case 284
							GoTo IL_24E
						Case 285
							GoTo IL_51B
						Case 286
							GoTo IL_4EB
						Case 287
							GoTo IL_15E6
						Case 288
							GoTo IL_170E
						Case 289
							num4 = 176
							GoTo IL_16EC
						Case 290
							GoTo IL_9CF
						Case 291
							array(3) = 123
							num2 = 252
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_76
							End If
							Continue For
						Case 292, 303
							GoTo IL_387
						Case 293
							array2(8) = CByte(num3)
							GoTo IL_16B4
						Case 294
							GoTo IL_166B
						Case 295
							GoTo IL_1429
						Case 296
							GoTo IL_16E
						Case 297
							GoTo IL_363
						Case 298
							WP6RZJql8gZrNhVA9v.BbVQwB9IAR87wq1gAX(WP6RZJql8gZrNhVA9v.v9NRpbYclbs1msheIb(vtNVUKGulysZw81C3E), 0L)
							GoTo IL_1639
						Case 299
							GoTo IL_15F7
						Case 300
							GoTo IL_15A0
						Case 301
							array(5) = 120
							GoTo IL_158F
						Case 302
							GoTo IL_21C
						Case 304
							GoTo IL_1559
						Case 305
							array2(3) = 144
							GoTo IL_EF8
						Case 306
							GoTo IL_14D0
						Case 307
							GoTo IL_14B8
						Case 308
							array2(14) = CByte(num3)
							GoTo IL_10C4
						Case 309
							GoTo IL_1479
						Case 310
							GoTo IL_1444
						Case 311
							GoTo IL_CB
						Case 312
							array2(13) = 186
							GoTo IL_1412
						Case 313
							GoTo IL_1325
						Case 314
							array2(3) = CByte(num3)
							num2 = 2
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_68
							End If
							Continue For
						Case 315
							num4 = 140
							GoTo IL_13BD
						Case 316
							GoTo IL_AFF
						Case 317
							GoTo IL_1113
						Case 318
							GoTo IL_27F
						Case 319
							GoTo IL_13A1
						Case 320
							GoTo IL_1386
						Case 321
							GoTo IL_1345
						Case 322
							GoTo IL_B55
						Case 323
							array2(9) = CByte(num3)
							GoTo IL_130E
						Case 324
							GoTo IL_E54
						Case 325
							GoTo IL_160
						Case 326
							array(20) = CByte(num6)
							GoTo IL_115
						Case 327
							num7 = 0UI
							GoTo IL_12DE
						Case 328
							GoTo IL_12C8
						Case 329
							num3 = 111
							GoTo IL_1299
						Case 330
							GoTo IL_127C
						Case 331
							GoTo IL_124B
						Case 332
							GoTo IL_F77
						Case 333
							num6 = 141
							GoTo IL_1226
						Case 334
							GoTo IL_11FA
						Case 335
							array(5) = 79
							num2 = 301
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo IL_11D3
							End If
							Continue For
						Case 336
							GoTo IL_1104
						Case 337
							array(26) = 151
							GoTo IL_4D6
						Case 338
							GoTo IL_4A4
						Case 339
							GoTo IL_D30
						Case 340
							GoTo IL_10C4
						Case 341
							GoTo IL_C5A
						Case 342
							GoTo IL_39D
						Case 343
							GoTo IL_108C
						Case 344
							GoTo IL_FDE
						Case 345
							GoTo IL_1078
						Case 346
							GoTo IL_8F4
						Case 347
							GoTo IL_1057
						Case 348
							GoTo IL_342
						Case 349
							GoTo IL_103C
						Case 350
							GoTo IL_31E
						Case 351
							GoTo IL_68
						Case 352
							GoTo IL_5CE
						Case 353
							GoTo IL_E22
						Case 354
							GoTo IL_1021
						Case 356
							GoTo IL_47E
						Case 357
							num6 = 86
							num2 = 383
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_57
							End If
							Continue For
						Case 358
							array(19) = 109
							num2 = 96
							If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_FB1
							End If
							Continue For
						Case 359
							array3(7) = array4(3)
							num2 = 112
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_F77
							End If
							Continue For
						Case 360
							GoTo IL_283B
						Case 361
							GoTo IL_F54
						Case 362
							GoTo IL_A7
						Case 363
							If num8 <= 0 Then
								GoTo IL_3FE
							End If
							num2 = 327
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_A1E
							End If
							Continue For
						Case 364
							GoTo IL_F1C
						Case 365
							GoTo IL_948
						Case 366
							GoTo IL_EF8
						Case 367
							GoTo IL_35D
						Case 368
							GoTo IL_EDD
						Case 369
							GoTo IL_EB4
						Case 370
							num6 = 34
							GoTo IL_E54
						Case 371
							array(31) = CByte(num6)
							num2 = 71
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_DE9
							End If
							Continue For
						Case 372
							GoTo IL_735
						Case 373
							GoTo IL_DA1
						Case 374
							GoTo IL_E8
						Case 376
							GoTo IL_D5E
						Case 377
							GoTo IL_D3B
						Case 378
							GoTo IL_8BD
						Case 379
							GoTo IL_A80
						Case 381
							GoTo IL_763
						Case 382
							GoTo IL_653
						Case 383
							array(27) = CByte(num6)
							GoTo IL_D30
						Case 385
							GoTo IL_6C4
						Case 386
							GoTo IL_CD4
						Case 387
							GoTo IL_CAC
						Case 388
							GoTo IL_B5
						Case 389
							array(27) = CByte(num6)
							num2 = 357
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_43
							End If
							Continue For
						Case 390
							GoTo IL_34A
						Case 391
							array(3) = 147
							num2 = 14
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_42
							End If
							Continue For
						Case 392
							GoTo IL_9E7
						Case 393
							GoTo IL_BE0
						Case 394
							GoTo IL_C27
						Case 395
							GoTo IL_3A3
						Case 396
							array6(num9 + 2) = CByte(((num10 And 16711680UI) >> 16))
							num2 = 416
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_BD1
							End If
							Continue For
						Case 397
							GoTo IL_B8B
						Case 398
							array(25) = 252
							GoTo IL_B55
						Case 399
							GoTo IL_B22
						Case 400
							GoTo IL_AEB
						Case 401
							GoTo IL_ACD
						Case 402
							GoTo IL_AA1
						Case 403
							GoTo IL_A6B
						Case 404
							GoTo IL_A10
						Case 405
							GoTo IL_317
						Case 406
							num3 = 107
							num2 = 175
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_8BD
							End If
							Continue For
						Case 407
							GoTo IL_284F
						Case 408
							num6 = 96
							num2 = 371
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_27
							End If
							Continue For
						Case 409
							num7 = CUInt(((CInt(array5(CInt(CType((num11 + 3UI), UIntPtr)))) << 24) Or (CInt(array5(CInt(CType((num11 + 2UI), UIntPtr)))) << 16) Or (CInt(array5(CInt(CType((num11 + 1UI), UIntPtr)))) << 8) Or CInt(array5(CInt(CType(num11, UIntPtr))))))
							num2 = 92
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
								GoTo Block_26
							End If
							Continue For
						Case 410
							GoTo IL_7F5
						Case 411
							array(2) = CByte(num4)
							num2 = 113
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo Block_24
							End If
							Continue For
						Case 412
							num12 <<= 8
							num2 = 420
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_7A8
							End If
							Continue For
						Case 413
							GoTo IL_6DF
						Case 414
							array(22) = CByte(num4)
							num2 = 14
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_694
							End If
							Continue For
						Case 415
							GoTo IL_64A
						Case 416
							array6(num9 + 3) = CByte(((num10 And 4278190080UI) >> 24))
							num2 = 82
							If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
								GoTo IL_5AE
							End If
							Continue For
						Case 417
							GoTo IL_5B9
						Case 418
							array(22) = CByte(num6)
							num2 = 234
							If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
								GoTo IL_5AE
							End If
							Continue For
						Case 419
							GoTo IL_572
						Case 420
							num13 += 8
							GoTo IL_549
						Case 421
							GoTo IL_50E
						Case 422
							GoTo IL_4D6
						Case 423
							GoTo IL_46A
						Case 424
							GoTo IL_42E
						Case 425
							GoTo IL_206
						Case 426
							GoTo IL_33A
						Case 427
							GoTo IL_302
						Case 428
							array(17) = CByte(num4)
							GoTo IL_192
						Case 429
							GoTo IL_2AB
						Case 430
							array(14) = CByte(num6)
							GoTo IL_27F
						Case 431
							array(2) = 149
							GoTo IL_206
						Case 432
							GoTo IL_192
						Case 433
							GoTo IL_115
						Case 434
						Case Else
							GoTo IL_CF2
					End Select
					IL_23:
					array(29) = CByte(num4)
					num2 = 180
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_41
					End If
					Continue For
					IL_C5A:
					num4 = 47
					GoTo IL_23
					IL_68:
					num6 = 94
					num2 = 4
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_7E
					End If
					Continue For
					IL_5C:
					array(30) = 110
					GoTo IL_68
					IL_50:
					array(30) = 92
					GoTo IL_5C
					IL_41:
					array(30) = 155
					GoTo IL_50
					IL_B5:
					num6 = 45
					num2 = 114
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_CB
					End If
					Continue For
					IL_A7:
					array(30) = CByte(num4)
					GoTo IL_B5
					IL_95:
					num4 = 198
					num = 362
					GoTo IL_A7
					IL_7E:
					array(30) = CByte(num6)
					GoTo IL_95
					IL_EE:
					array(31) = CByte(num6)
					num2 = 408
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_E8:
					num6 = 109
					GoTo IL_EE
					IL_D9:
					array(31) = 198
					GoTo IL_E8
					IL_CB:
					array(30) = CByte(num6)
					GoTo IL_D9
					IL_16E:
					array(21) = 138
					num2 = 111
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_160:
					array(21) = CByte(num6)
					GoTo IL_16E
					IL_157:
					num6 = 215
					GoTo IL_160
					IL_14B:
					array(21) = 102
					GoTo IL_157
					IL_13C:
					array(20) = 167
					GoTo IL_14B
					IL_124:
					array(20) = 235
					num = 85
					GoTo IL_13C
					IL_115:
					array(20) = 230
					GoTo IL_124
					IL_1A7:
					array(17) = CByte(num6)
					num2 = 18
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_1C5
					End If
					Continue For
					IL_19E:
					num6 = 207
					GoTo IL_1A7
					IL_192:
					array(17) = 65
					GoTo IL_19E
					IL_1D4:
					array(17) = CByte(num6)
					num2 = 140
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1C5:
					num6 = 77
					num = 192
					GoTo IL_1D4
					IL_206:
					num4 = 92
					num2 = 411
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_21C
					End If
					Continue For
					IL_24E:
					array2(4) = CByte(num3)
					num2 = 156
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_245:
					num3 = 202
					GoTo IL_24E
					IL_239:
					array2(4) = 95
					GoTo IL_245
					IL_22A:
					array2(4) = 144
					GoTo IL_239
					IL_21C:
					array2(4) = CByte(num3)
					GoTo IL_22A
					IL_288:
					array(14) = CByte(num6)
					num2 = 251
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_27F:
					num6 = 168
					GoTo IL_288
					IL_2CE:
					array2(6) = 90
					num2 = 199
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_2BF:
					array2(6) = 137
					GoTo IL_2CE
					IL_2B1:
					array2(6) = CByte(num3)
					GoTo IL_2BF
					IL_2AB:
					num3 = 126
					GoTo IL_2B1
					IL_31E:
					WP6RZJql8gZrNhVA9v.LhfE587EYIDF6pDy2C(cryptoStream)
					num2 = 183
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_317:
					Dim stream As Stream
					WP6RZJql8gZrNhVA9v.LhfE587EYIDF6pDy2C(stream)
					GoTo IL_31E
					IL_302:
					WP6RZJql8gZrNhVA9v.HkLkNdDPtB = WP6RZJql8gZrNhVA9v.R3CkYYmL0RGTEaInQB(stream)
					num = 405
					GoTo IL_317
					IL_1AD2:
					WP6RZJql8gZrNhVA9v.TrFk4tJ85gYnrRfefj(cryptoStream)
					GoTo IL_302
					IL_366:
					If num8 <= 0 Then
						GoTo IL_381
					End If
					num2 = 158
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_37B
					End If
					Continue For
					IL_363:
					num7 = 0UI
					GoTo IL_366
					IL_360:
					Dim num14 As UInteger = 0UI
					GoTo IL_363
					IL_35D:
					Dim num15 As UInteger = 0UI
					GoTo IL_360
					IL_355:
					Dim array7 As Byte()
					Dim num16 As Integer = array7.Length / 4
					GoTo IL_35D
					IL_34A:
					array6 = New Byte(array5.Length - 1) {}
					GoTo IL_355
					IL_342:
					Dim num17 As Integer = array5.Length / 4
					GoTo IL_34A
					IL_33A:
					num8 = array5.Length Mod 4
					GoTo IL_342
					IL_1021:
					If int_0 = -1 Then
						GoTo IL_1028
					End If
					GoTo IL_33A
					IL_1DBC:
					Dim num18 As Integer
					If num18 >= array3.Length Then
						num = 354
						GoTo IL_1021
					End If
					GoTo IL_1DD2
					IL_1DB9:
					num18 = 0
					GoTo IL_1DBC
					IL_1F0E:
					If array4.Length > 0 Then
						GoTo IL_1D49
					End If
					GoTo IL_1DB9
					IL_1E51:
					array3(15) = array4(7)
					GoTo IL_1DB9
					IL_2067:
					array3(13) = array4(6)
					GoTo IL_1E51
					IL_3E1:
					Dim num19 As Integer
					If num19 <> num17 - 1 Then
						GoTo IL_3FE
					End If
					num2 = 363
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_3DE:
					num13 = 0
					GoTo IL_3E1
					IL_3CE:
					num12 = 255UI
					num = 160
					GoTo IL_3DE
					IL_3A3:
					num14 = CUInt(((CInt(array7(CInt(CType((num11 + 3UI), UIntPtr)))) << 24) Or (CInt(array7(CInt(CType((num11 + 2UI), UIntPtr)))) << 16) Or (CInt(array7(CInt(CType((num11 + 1UI), UIntPtr)))) << 8) Or CInt(array7(CInt(CType(num11, UIntPtr))))))
					GoTo IL_3CE
					IL_39D:
					Dim num20 As Integer
					num11 = CUInt((num20 * 4))
					GoTo IL_3A3
					IL_397:
					num9 = num19 * 4
					GoTo IL_39D
					IL_390:
					num20 = num19 Mod num16
					GoTo IL_397
					IL_387:
					If num19 < num17 Then
						GoTo IL_390
					End If
					GoTo IL_283B
					IL_5AE:
					num19 += 1
					GoTo IL_387
					IL_9EA:
					If num5 < num8 Then
						GoTo IL_9F3
					End If
					GoTo IL_5AE
					IL_9E7:
					num5 = 0
					GoTo IL_9EA
					IL_9E0:
					Dim num21 As UInteger = num15 Xor num7
					GoTo IL_9E7
					IL_9CF:
					If num8 > 0 Then
						num = 27
						GoTo IL_9E0
					End If
					GoTo IL_7A8
					IL_9C4:
					If num19 = num17 - 1 Then
						GoTo IL_9CF
					End If
					GoTo IL_7A8
					IL_9C0:
					Dim num22 As UInteger
					num15 = num22
					GoTo IL_9C4
					IL_948:
					Dim num23 As UInteger = num22
					Dim num24 As UInteger = num22
					num24 = num24 Xor num24 >> 16
					num24 += 1851693862UI
					num24 = num24 Xor num24 << 5
					num24 += 1402132862UI
					num24 = num24 Xor num24 >> 1
					num24 += 437819953UI
					num24 = 1742340096UI - num24
					num22 = num23 + CUInt(num24)
					GoTo IL_9C0
					IL_945:
					num15 = 0UI
					GoTo IL_948
					IL_941:
					num22 = num15
					GoTo IL_945
					IL_384:
					num19 = 0
					GoTo IL_387
					IL_381:
					num11 = 0UI
					GoTo IL_384
					IL_37B:
					num17 += 1
					GoTo IL_381
					IL_3FE:
					num15 += num14
					num2 = 53
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Continue For
					End If
					IL_415:
					num11 = CUInt(num9)
					num2 = 409
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_446:
					array(18) = 160
					num2 = 117
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_42E:
					array(18) = 128
					num = 233
					GoTo IL_446
					IL_13A1:
					array(18) = CByte(num6)
					GoTo IL_42E
					IL_4B2:
					array(2) = 138
					num2 = 431
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_4A4:
					array(1) = CByte(num4)
					GoTo IL_4B2
					IL_49B:
					num4 = 188
					GoTo IL_4A4
					IL_48C:
					array(1) = 160
					GoTo IL_49B
					IL_47E:
					array(1) = CByte(num6)
					GoTo IL_48C
					IL_478:
					num6 = 102
					GoTo IL_47E
					IL_46A:
					array(0) = CByte(num4)
					GoTo IL_478
					IL_1240:
					num4 = 125
					GoTo IL_46A
					IL_1234:
					array(0) = 110
					GoTo IL_1240
					IL_1226:
					array(0) = CByte(num6)
					GoTo IL_1234
					IL_4EB:
					array(26) = CByte(num4)
					num2 = 76
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_4E5:
					num4 = 27
					GoTo IL_4EB
					IL_4D6:
					array(26) = 169
					GoTo IL_4E5
					IL_522:
					Dim cryptoTransform As ICryptoTransform
					cryptoStream = New CryptoStream(stream, cryptoTransform, CryptoStreamMode.Write)
					num2 = 222
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_51B:
					stream = WP6RZJql8gZrNhVA9v.WYCHWd6rXG4ADJKpNx()
					GoTo IL_522
					IL_50E:
					Dim symmetricAlgorithm As SymmetricAlgorithm
					cryptoTransform = WP6RZJql8gZrNhVA9v.PGWIiHb9ViHkZ8Asvw(symmetricAlgorithm, array7, array3)
					GoTo IL_51B
					IL_102F:
					WP6RZJql8gZrNhVA9v.i4j142q6uBmtdQ5mLA(symmetricAlgorithm, CipherMode.CBC)
					GoTo IL_50E
					IL_1028:
					symmetricAlgorithm = WP6RZJql8gZrNhVA9v.cLJaiHhCdXwXtRjq23()
					GoTo IL_102F
					IL_549:
					array6(num9 + num5) = CByte(((num21 And num12) >> num13))
					num2 = 39
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_9F3:
					If num5 <= 0 Then
						GoTo IL_549
					End If
					num2 = 412
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_572:
					num4 = 163
					num2 = 163
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1CFD:
					array(29) = 159
					num = 419
					GoTo IL_572
					IL_1CE6:
					array(28) = CByte(num6)
					GoTo IL_1CFD
					IL_5D7:
					array(0) = CByte(num4)
					num2 = 333
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_5F5
					End If
					Continue For
					IL_5CE:
					num4 = 144
					GoTo IL_5D7
					IL_5B9:
					array(0) = 80
					num = 352
					GoTo IL_5CE
					IL_12C8:
					array(0) = CByte(num6)
					GoTo IL_5B9
					IL_17D7:
					num6 = 168
					GoTo IL_12C8
					IL_604:
					num6 = 180
					num2 = 326
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_5F5:
					array(19) = 161
					GoTo IL_604
					IL_653:
					array(24) = CByte(num4)
					num2 = 196
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_64A:
					num4 = 213
					GoTo IL_653
					IL_1689:
					array(24) = 221
					num = 415
					GoTo IL_64A
					IL_6A8:
					array(22) = 122
					num2 = 372
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_6C4
					End If
					Continue For
					IL_69A:
					array(22) = CByte(num4)
					GoTo IL_6A8
					IL_694:
					num4 = 36
					GoTo IL_69A
					IL_6C4:
					num6 = 10
					num2 = 418
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_711:
					num3 = 119
					num2 = 76
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_727
					End If
					Continue For
					IL_702:
					array2(12) = 159
					GoTo IL_711
					IL_6F6:
					array2(12) = 85
					GoTo IL_702
					IL_6DF:
					array2(12) = CByte(num3)
					num = 91
					GoTo IL_6F6
					IL_1288:
					num3 = 92
					GoTo IL_6DF
					IL_127C:
					array2(12) = 27
					GoTo IL_1288
					IL_735:
					array2(13) = 26
					num2 = 173
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_751
					End If
					Continue For
					IL_727:
					array2(12) = CByte(num3)
					GoTo IL_735
					IL_771:
					array2(13) = 111
					num2 = 146
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_763:
					array2(13) = CByte(num3)
					GoTo IL_771
					IL_751:
					num3 = 133
					num = 381
					GoTo IL_763
					IL_7AF:
					array6(num9) = CByte((num10 And 255UI))
					num2 = 26
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_7A8:
					num10 = num15 Xor num7
					GoTo IL_7AF
					IL_7F5:
					num6 = 56
					num2 = 20
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_80B
					End If
					Continue For
					IL_19FD:
					array(10) = CByte(num6)
					GoTo IL_7F5
					IL_80B:
					array(11) = CByte(num6)
					num2 = 370
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Continue For
					End If
					IL_829:
					array2(8) = CByte(num3)
					num2 = 264
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_16B4:
					num3 = 191
					GoTo IL_829
					IL_8D1:
					array2(5) = CByte(num3)
					num2 = 162
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_8EF
					End If
					Continue For
					IL_8CB:
					num3 = 95
					GoTo IL_8D1
					IL_8BD:
					array2(5) = CByte(num3)
					GoTo IL_8CB
					IL_914:
					Dim num25 As Integer
					If num25 < num8 Then
						GoTo IL_8EF
					End If
					num2 = 247
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_941
					End If
					Continue For
					IL_12E5:
					num25 = 0
					GoTo IL_914
					IL_12DE:
					num15 += num14
					GoTo IL_12E5
					IL_905:
					num25 += 1
					num = 30
					GoTo IL_914
					IL_8F4:
					num7 = num7 Or CUInt(array5(array5.Length - (1 + num25)))
					GoTo IL_905
					IL_8EF:
					If num25 <= 0 Then
						GoTo IL_8F4
					End If
					num2 = 101
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_9E0
					End If
					Continue For
					IL_A4D:
					num6 = 151
					num2 = 177
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_A35:
					array(28) = 133
					num = 253
					GoTo IL_A4D
					IL_A27:
					array(28) = CByte(num4)
					GoTo IL_A35
					IL_A1E:
					num4 = 151
					GoTo IL_A27
					IL_A10:
					array(27) = CByte(num4)
					GoTo IL_A1E
					IL_D30:
					num4 = 70
					GoTo IL_A10
					IL_A80:
					array(6) = 87
					num2 = 189
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_A6B:
					array(6) = 122
					num = 379
					GoTo IL_A80
					IL_158F:
					array(5) = 14
					GoTo IL_A6B
					IL_AAA:
					array(19) = CByte(num6)
					num2 = 49
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_AA1:
					num6 = 154
					GoTo IL_AAA
					IL_FF2:
					array(19) = 155
					GoTo IL_AA1
					IL_FE4:
					array(19) = CByte(num6)
					GoTo IL_FF2
					IL_FDE:
					num6 = 49
					GoTo IL_FE4
					IL_FC7:
					array(19) = CByte(num6)
					num = 344
					GoTo IL_FDE
					IL_ACD:
					num3 = 238
					num2 = 167
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_CC3:
					array2(11) = 105
					GoTo IL_ACD
					IL_CB5:
					array2(11) = CByte(num3)
					GoTo IL_CC3
					IL_CAC:
					num3 = 157
					GoTo IL_CB5
					IL_1B7D:
					array2(11) = CByte(num3)
					GoTo IL_CAC
					IL_1B74:
					num3 = 134
					GoTo IL_1B7D
					IL_AFF:
					array(3) = CByte(num4)
					num2 = 391
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_AF9:
					num4 = 104
					GoTo IL_AFF
					IL_AEB:
					array(3) = CByte(num4)
					GoTo IL_AF9
					IL_18DC:
					num4 = 87
					GoTo IL_AEB
					IL_18CE:
					array(3) = CByte(num6)
					GoTo IL_18DC
					IL_B22:
					array(16) = 171
					num2 = 289
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_B6A:
					array(26) = 124
					num2 = 337
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_B55:
					array(26) = 119
					num = 152
					GoTo IL_B6A
					IL_B8B:
					array2(3) = CByte(num3)
					num2 = 305
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_BE6:
					array(13) = CByte(num4)
					num2 = 22
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_C04
					End If
					Continue For
					IL_BE0:
					num4 = 90
					GoTo IL_BE6
					IL_BD1:
					array(13) = 149
					GoTo IL_BE0
					IL_C04:
					array2(5) = CByte(num3)
					num2 = 406
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_C3E:
					array(29) = 118
					num2 = 45
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_C5A
					End If
					Continue For
					IL_C27:
					array(29) = CByte(num4)
					num = 64
					GoTo IL_C3E
					IL_CD4:
					array(8) = CByte(num4)
					num2 = 0
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_CF2
					End If
					Continue For
					IL_F54:
					num4 = 125
					GoTo IL_CD4
					IL_15E6:
					array(7) = 115
					GoTo IL_F54
					IL_15DA:
					array(7) = 118
					GoTo IL_15E6
					IL_15CE:
					array(7) = 104
					GoTo IL_15DA
					IL_15B7:
					array(7) = CByte(num4)
					num = 175
					GoTo IL_15CE
					IL_15AE:
					num4 = 150
					GoTo IL_15B7
					IL_15A0:
					array(6) = CByte(num4)
					GoTo IL_15AE
					IL_CFE:
					array(8) = 130
					num2 = 24
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_CF2:
					array(8) = 125
					GoTo IL_CFE
					IL_D3B:
					array(18) = CByte(num6)
					num2 = 193
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_D5E:
					array(5) = 194
					num2 = 0
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_D7D
					End If
					Continue For
					IL_1532:
					array(5) = CByte(num6)
					GoTo IL_D5E
					IL_1523:
					num6 = 94
					num = 270
					GoTo IL_1532
					IL_D7D:
					array(5) = 166
					num2 = 335
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_DAD:
					num3 = 164
					num2 = 128
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_DA1:
					array2(10) = 60
					GoTo IL_DAD
					IL_1078:
					array2(10) = 138
					GoTo IL_DA1
					IL_1334:
					array2(10) = 120
					GoTo IL_1078
					IL_1325:
					array2(9) = 207
					GoTo IL_1334
					IL_1317:
					array2(9) = CByte(num3)
					GoTo IL_1325
					IL_130E:
					num3 = 128
					GoTo IL_1317
					IL_DEF:
					array2 = New Byte(15) {}
					num2 = 35
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_E0D
					End If
					Continue For
					IL_DE9:
					array7 = array
					GoTo IL_DEF
					IL_E2B:
					array2(0) = CByte(num3)
					num2 = 53
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_E22:
					num3 = 130
					GoTo IL_E2B
					IL_E0D:
					array2(0) = 114
					num = 353
					GoTo IL_E22
					IL_E99:
					num4 = 108
					num2 = 244
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_E8B:
					array(12) = CByte(num6)
					GoTo IL_E99
					IL_E82:
					num6 = 170
					GoTo IL_E8B
					IL_E76:
					array(12) = 111
					GoTo IL_E82
					IL_E68:
					array(11) = CByte(num6)
					GoTo IL_E76
					IL_E62:
					num6 = 85
					GoTo IL_E68
					IL_E54:
					array(11) = CByte(num6)
					GoTo IL_E62
					IL_EBA:
					array(4) = CByte(num6)
					num2 = 32
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_EB4:
					num6 = 105
					GoTo IL_EBA
					IL_11A4:
					array(4) = CByte(num4)
					GoTo IL_EB4
					IL_EDD:
					num18 += 1
					num2 = 88
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1DD2:
					array7(num18) = array7(num18) Xor array3(num18)
					GoTo IL_EDD
					IL_EF8:
					array2(3) = 162
					num2 = 71
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_CF2
					End If
					Continue For
					IL_F1C:
					num3 = 89
					num2 = 293
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1269:
					array2(7) = CByte(num3)
					GoTo IL_F1C
					IL_1263:
					num3 = 42
					GoTo IL_1269
					IL_1257:
					array2(7) = 92
					GoTo IL_1263
					IL_124B:
					array2(7) = 114
					GoTo IL_1257
					IL_1FC6:
					array2(6) = CByte(num3)
					GoTo IL_124B
					IL_F77:
					array3(9) = array4(4)
					num2 = 73
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_FB1:
					num6 = 79
					num2 = 39
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_FC7
					End If
					Continue For
					IL_103C:
					num4 = 108
					num2 = 428
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_CB5
					End If
					Continue For
					IL_16FA:
					array(17) = 154
					GoTo IL_103C
					IL_16EC:
					array(16) = CByte(num4)
					GoTo IL_16FA
					IL_1057:
					array(10) = 126
					num2 = 236
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1AA8:
					array(10) = CByte(num6)
					num = 347
					GoTo IL_1057
					IL_10A9:
					num3 = 109
					num2 = 314
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_109A:
					array2(2) = 171
					GoTo IL_10A9
					IL_108C:
					array2(2) = CByte(num3)
					GoTo IL_109A
					IL_10CD:
					array2(14) = CByte(num3)
					num2 = 174
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_10C4:
					num3 = 141
					GoTo IL_10CD
					IL_1113:
					array(24) = 86
					num2 = 96
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_112F
					End If
					Continue For
					IL_1104:
					array(24) = 165
					GoTo IL_1113
					IL_113B:
					array(25) = 86
					num2 = 43
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_1157
					End If
					Continue For
					IL_112F:
					array(24) = 78
					GoTo IL_113B
					IL_118B:
					num4 = 168
					num2 = 90
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_11A4
					End If
					Continue For
					IL_117D:
					array(4) = CByte(num4)
					GoTo IL_118B
					IL_1174:
					num4 = 139
					GoTo IL_117D
					IL_1165:
					array(4) = 184
					GoTo IL_1174
					IL_1157:
					array(4) = CByte(num6)
					GoTo IL_1165
					IL_1BED:
					num6 = 163
					GoTo IL_1157
					IL_11D3:
					array6(num9 + 1) = CByte(((num10 And 65280UI) >> 8))
					num2 = 396
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_11FA:
					array(2) = CByte(num4)
					num2 = 291
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1F3B:
					num4 = 83
					num = 334
					GoTo IL_11FA
					IL_12A7:
					array2(8) = 39
					num2 = 139
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1299:
					array2(8) = CByte(num3)
					GoTo IL_12A7
					IL_1365:
					array2(1) = 125
					num2 = 1
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_CF2
					End If
					Continue For
					IL_1359:
					array2(1) = 89
					GoTo IL_1365
					IL_134B:
					array2(1) = CByte(num3)
					GoTo IL_1359
					IL_1345:
					num3 = 92
					GoTo IL_134B
					IL_1386:
					num6 = 77
					num2 = 430
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_13BD:
					array(9) = CByte(num4)
					num2 = 77
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1429:
					num3 = 114
					num2 = 308
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_141B:
					array2(14) = CByte(num3)
					GoTo IL_1429
					IL_1412:
					num3 = 143
					GoTo IL_141B
					IL_1456:
					array(13) = CByte(num4)
					num2 = 103
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1444:
					num4 = 217
					num = 258
					GoTo IL_1456
					IL_1487:
					num3 = 188
					num2 = 235
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1479:
					array2(4) = CByte(num3)
					GoTo IL_1487
					IL_14B8:
					num3 = 114
					num2 = 176
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_1479
					End If
					Continue For
					IL_1C15:
					array2(4) = CByte(num3)
					GoTo IL_14B8
					IL_14E7:
					array2(15) = 253
					num2 = 193
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_1506
					End If
					Continue For
					IL_14D0:
					array2(15) = CByte(num3)
					num = 180
					GoTo IL_14E7
					IL_186E:
					num3 = 163
					GoTo IL_14D0
					IL_150C:
					WP6RZJql8gZrNhVA9v.bNWpfSBNtBwd5N73E5(array3)
					num2 = 208
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_1523
					End If
					Continue For
					IL_1506:
					array3 = array2
					GoTo IL_150C
					IL_1568:
					num4 = 107
					num2 = 154
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1559:
					array(9) = 149
					GoTo IL_1568
					IL_181E:
					array(9) = 119
					GoTo IL_1559
					IL_1606:
					num4 = 145
					num2 = 414
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_15F7:
					array(22) = 143
					GoTo IL_1606
					IL_164F:
					WP6RZJql8gZrNhVA9v.Ep8t8qW3IZakIkoq7L(vtNVUKGulysZw81C3E)
					num2 = 201
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1639:
					array5 = WP6RZJql8gZrNhVA9v.KwXsXILnYT41U9plHC(vtNVUKGulysZw81C3E, CInt(WP6RZJql8gZrNhVA9v.S0nk5gtOZauJTDr7nW(WP6RZJql8gZrNhVA9v.v9NRpbYclbs1msheIb(vtNVUKGulysZw81C3E))))
					GoTo IL_164F
					IL_166B:
					array(23) = CByte(num4)
					num2 = 25
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_1689
					End If
					Continue For
					IL_1728:
					array2(2) = 131
					num2 = 185
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_171C:
					array2(1) = 42
					GoTo IL_1728
					IL_170E:
					array2(1) = CByte(num3)
					GoTo IL_171C
					IL_174C:
					array(15) = CByte(num6)
					num2 = 50
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_176A
					End If
					Continue For
					IL_1796:
					array(16) = 157
					num2 = 292
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_B22
					End If
					Continue For
					IL_178A:
					array(15) = 106
					GoTo IL_1796
					IL_177C:
					array(15) = CByte(num4)
					GoTo IL_178A
					IL_1776:
					num4 = 112
					GoTo IL_177C
					IL_176A:
					array(15) = 94
					GoTo IL_1776
					IL_17E5:
					num4 = 150
					num2 = 25
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_CF2
					End If
					Continue For
					IL_1850:
					array(14) = CByte(num4)
					num2 = 79
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_186E
					End If
					Continue For
					IL_187C:
					num4 = 124
					GoTo IL_1850
					IL_18A2:
					array(18) = CByte(num6)
					num2 = 358
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1905:
					array(14) = CByte(num4)
					num2 = 72
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() Is Nothing Then
						GoTo IL_187C
					End If
					Continue For
					IL_18FC:
					num4 = 147
					GoTo IL_1905
					IL_1928:
					num3 = 98
					num2 = 323
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1EB5:
					array2(9) = 98
					GoTo IL_1928
					IL_1943:
					array(27) = 159
					num2 = 257
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1A7C:
					array(27) = CByte(num6)
					GoTo IL_1943
					IL_1A6A:
					num6 = 154
					num = 137
					GoTo IL_1A7C
					IL_1967:
					array2(13) = 87
					num2 = 312
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_19C7:
					array3(5) = array4(2)
					num2 = 359
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1A1E:
					num3 = 102
					num2 = 132
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_3CE
					End If
					Continue For
					IL_1A4E:
					array(23) = 127
					num2 = 242
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						GoTo IL_1A6A
					End If
					Continue For
					IL_1BAC:
					array2(6) = CByte(num3)
					num2 = 90
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1C9F:
					array(25) = CByte(num6)
					num2 = 398
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1CD0:
					num6 = 55
					num2 = 47
					If WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_1CE6
					End If
					Continue For
					IL_1D49:
					array3(1) = array4(0)
					num2 = 238
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1D87:
					num6 = 131
					num2 = 206
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_1DF6:
					array(13) = 244
					num2 = 220
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Exit For
					End If
					Continue For
					IL_1DE8:
					array(13) = CByte(num6)
					GoTo IL_1DF6
					IL_1E86:
					array(18) = CByte(num6)
					num2 = 172
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						Exit For
					End If
					Continue For
					IL_203B:
					array(9) = CByte(num6)
					num2 = 230
					If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
						GoTo IL_1796
					End If
				End While
				GoTo IL_10C
				IL_283B:
				WP6RZJql8gZrNhVA9v.HkLkNdDPtB = array6
				Exit While
				Block_24:
				Block_26:
				Block_27:
				Block_42:
				Block_43:
				Block_57:
				Block_68:
				Block_76:
				Block_80:
				Block_81:
				Block_82:
				Block_88:
				Block_92:
				Block_95:
				Block_96:
				Block_97:
				Block_99:
				Block_104:
				Block_107:
				Block_110:
				Block_111:
				Block_112:
				Block_114:
				Block_115:
				GoTo IL_10C
				IL_284F:
				Try
					WP6RZJql8gZrNhVA9v.kbTkCZQ96RjLhmXcRR()
					Dim num26 As Integer = 1
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Dim num27 As Integer
						num26 = num27
					End If
					Dim text As String
					While True
						Select Case num26
							Case 1
								text = WP6RZJql8gZrNhVA9v.lqAje1r4lislC4DxXs(WP6RZJql8gZrNhVA9v.QlUoev1pGNFQC4k2mV(), WP6RZJql8gZrNhVA9v.HkLkNdDPtB, int_0 + 4, num28)
								num26 = 0
								If Not WP6RZJql8gZrNhVA9v.VSkvy6KOqcX7hy4yoF() Then
									Continue For
								End If
						End Select
						Exit For
					End While
					Return text
				Catch
					Dim num29 As Integer = 0
					If WP6RZJql8gZrNhVA9v.OmBkQ93oSxysisBy5y() IsNot Nothing Then
						Select Case num29
						End Select
					End If
				End Try
				IL_28B7:
				Return ""
				IL_10C:
				num2 = num
				GoTo IL_2157
			End While
			IL_2842:
			num28 = WP6RZJql8gZrNhVA9v.VmgHenNQrjHDtkBqhR(WP6RZJql8gZrNhVA9v.HkLkNdDPtB, int_0)
			GoTo IL_284F
		End Function

		' Token: 0x0600006B RID: 107 RVA: 0x0000B35C File Offset: 0x0000955C
		<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
		Friend Shared Function hg2oY5yaSM(string_0 As String) As String
			"{11111-22222-50001-00000}".Trim()
			Dim array As Byte() = Convert.FromBase64String(string_0)
			Return Encoding.Unicode.GetString(array, 0, array.Length)
		End Function

		' Token: 0x0600006C RID: 108 RVA: 0x00002555 File Offset: 0x00000755
		Private Shared Function FPvotekByE() As Integer
			Return 5
		End Function

		' Token: 0x0600006D RID: 109 RVA: 0x0000B38C File Offset: 0x0000958C
		Private Shared Sub svloy6EVGc()
			Try
				RSACryptoServiceProvider.UseMachineKeyStore = True
			Catch
			End Try
		End Sub

		' Token: 0x0600006E RID: 110 RVA: 0x0000B3B4 File Offset: 0x000095B4
		Private Shared Function iaKoOg5GGg(intptr_0 As IntPtr, type_0 As Type) As [Delegate]
			Return CType(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777394)).GetMethod("GetDelegateForFunctionPointer", New Type() { Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777275)), Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777293)) }).Invoke(Nothing, New Object() { intptr_0, type_0 }), [Delegate])
		End Function

		' Token: 0x0600006F RID: 111 RVA: 0x0000B428 File Offset: 0x00009628
		Friend Shared Function PvroikJllY(object_0 As Object) As Object
			Try
				If File.Exists(CType(object_0, Assembly).Location) Then
					Return CType(object_0, Assembly).Location
				End If
			Catch
			End Try
			Try
				If File.Exists(CType(object_0, Assembly).GetName().CodeBase.ToString().Replace("file:///", "")) Then
					Return CType(object_0, Assembly).GetName().CodeBase.ToString().Replace("file:///", "")
				End If
			Catch
			End Try
			Try
				If File.Exists(object_0.[GetType]().GetProperty("Location").GetValue(object_0, New Object(-1) {}).ToString()) Then
					Return object_0.[GetType]().GetProperty("Location").GetValue(object_0, New Object(-1) {}).ToString()
				End If
			Catch
			End Try
			Return ""
		End Function

		' Token: 0x06000070 RID: 112
		Public Declare Function LoadLibrary Lib "kernel32" (string_0 As String) As IntPtr

		' Token: 0x06000071 RID: 113
		Public Declare Ansi Function GetProcAddress Lib "kernel32" (intptr_0 As IntPtr, string_0 As String) As IntPtr

		' Token: 0x06000072 RID: 114 RVA: 0x0000B534 File Offset: 0x00009734
		Private Shared Function w3ZoqRBn5p(intptr_0 As IntPtr, string_0 As String, uint_0 As UInteger) As IntPtr
			If WP6RZJql8gZrNhVA9v.BV0kmUIPgx Is Nothing Then
				Dim procAddress As IntPtr = WP6RZJql8gZrNhVA9v.GetProcAddress(WP6RZJql8gZrNhVA9v.umLocehuEC(), "Find ".Trim() + "ResourceA")
				WP6RZJql8gZrNhVA9v.BV0kmUIPgx = CType(Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554458))), WP6RZJql8gZrNhVA9v.MacgPI7JyVeAhNaPvd)
			End If
			Return WP6RZJql8gZrNhVA9v.BV0kmUIPgx(intptr_0, string_0, uint_0)
		End Function

		' Token: 0x06000073 RID: 115 RVA: 0x0000B594 File Offset: 0x00009794
		Private Shared Function YDsoA9ylfU(intptr_0 As IntPtr, uint_0 As UInteger, uint_1 As UInteger, uint_2 As UInteger) As IntPtr
			If WP6RZJql8gZrNhVA9v.yBRkv0eFeZ Is Nothing Then
				Dim procAddress As IntPtr = WP6RZJql8gZrNhVA9v.GetProcAddress(WP6RZJql8gZrNhVA9v.umLocehuEC(), "Virtual ".Trim() + "Alloc")
				WP6RZJql8gZrNhVA9v.yBRkv0eFeZ = CType(Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554459))), WP6RZJql8gZrNhVA9v.GL8NaIwq2KOvLQhMFX)
			End If
			Return WP6RZJql8gZrNhVA9v.yBRkv0eFeZ(intptr_0, uint_0, uint_1, uint_2)
		End Function

		' Token: 0x06000074 RID: 116 RVA: 0x0000B5F4 File Offset: 0x000097F4
		Private Shared Function mTfoQqVbOE(intptr_0 As IntPtr, intptr_1 As IntPtr, <[In]()> <Out()> byte_0 As Byte(), uint_0 As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef intptr_2 As IntPtr) As Integer
			If WP6RZJql8gZrNhVA9v.tTVkFDSO7A Is Nothing Then
				Dim procAddress As IntPtr = WP6RZJql8gZrNhVA9v.GetProcAddress(WP6RZJql8gZrNhVA9v.umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory")
				WP6RZJql8gZrNhVA9v.tTVkFDSO7A = CType(Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554460))), WP6RZJql8gZrNhVA9v.yy2w1VXOQgx806ubre)
			End If
			Return WP6RZJql8gZrNhVA9v.tTVkFDSO7A(intptr_0, intptr_1, byte_0, uint_0, intptr_2)
		End Function

		' Token: 0x06000075 RID: 117 RVA: 0x0000B660 File Offset: 0x00009860
		Private Shared Function YeeoMqaS3J(intptr_0 As IntPtr, int_0 As Integer, int_1 As Integer, ByRef int_2 As Integer) As Integer
			If WP6RZJql8gZrNhVA9v.zIOkYypt1M Is Nothing Then
				Dim procAddress As IntPtr = WP6RZJql8gZrNhVA9v.GetProcAddress(WP6RZJql8gZrNhVA9v.umLocehuEC(), "Virtual ".Trim() + "Protect")
				WP6RZJql8gZrNhVA9v.zIOkYypt1M = CType(Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554461))), WP6RZJql8gZrNhVA9v.N7UlhA3IRW2ugh7tWg)
			End If
			Return WP6RZJql8gZrNhVA9v.zIOkYypt1M(intptr_0, int_0, int_1, int_2)
		End Function

		' Token: 0x06000076 RID: 118 RVA: 0x0000B6C0 File Offset: 0x000098C0
		Private Shared Function tdOo5aPwrv(uint_0 As UInteger, int_0 As Integer, uint_1 As UInteger) As IntPtr
			If WP6RZJql8gZrNhVA9v.tuYkt9D06I Is Nothing Then
				Dim procAddress As IntPtr = WP6RZJql8gZrNhVA9v.GetProcAddress(WP6RZJql8gZrNhVA9v.umLocehuEC(), "Open ".Trim() + "Process")
				WP6RZJql8gZrNhVA9v.tuYkt9D06I = CType(Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554462))), WP6RZJql8gZrNhVA9v.RI754BJF754hNSApRW)
			End If
			Return WP6RZJql8gZrNhVA9v.tuYkt9D06I(uint_0, int_0, uint_1)
		End Function

		' Token: 0x06000077 RID: 119 RVA: 0x0000B720 File Offset: 0x00009920
		Private Shared Function Q2sob65b9D(intptr_0 As IntPtr) As Integer
			If WP6RZJql8gZrNhVA9v.etmkyDG2SG Is Nothing Then
				Dim procAddress As IntPtr = WP6RZJql8gZrNhVA9v.GetProcAddress(WP6RZJql8gZrNhVA9v.umLocehuEC(), "Close ".Trim() + "Handle")
				WP6RZJql8gZrNhVA9v.etmkyDG2SG = CType(Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554463))), WP6RZJql8gZrNhVA9v.YLCGmBEaUwBbEqLM01)
			End If
			Return WP6RZJql8gZrNhVA9v.etmkyDG2SG(intptr_0)
		End Function

		' Token: 0x06000078 RID: 120 RVA: 0x00002558 File Offset: 0x00000758
		Private Shared Function umLocehuEC() As IntPtr
			If WP6RZJql8gZrNhVA9v.K7PkOHxqAd = IntPtr.Zero Then
				WP6RZJql8gZrNhVA9v.K7PkOHxqAd = WP6RZJql8gZrNhVA9v.LoadLibrary("kernel ".Trim() + "32.dll")
			End If
			Return WP6RZJql8gZrNhVA9v.K7PkOHxqAd
		End Function

		' Token: 0x06000079 RID: 121 RVA: 0x0000B780 File Offset: 0x00009980
		<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
		Private Shared Function VZpoRI2LOR(string_0 As String) As Byte()
			Dim array As Byte()
			Using fileStream As FileStream = New FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read)
				Dim num As Integer = 0
				Dim length As Long = fileStream.Length
				Dim i As Integer = CInt(length)
				array = New Byte(i - 1) {}
				While i > 0
					Dim num2 As Integer = fileStream.Read(array, num, i)
					num += num2
					i -= num2
				End While
			End Using
			Return array
		End Function

		' Token: 0x0600007A RID: 122 RVA: 0x0000258E File Offset: 0x0000078E
		Friend Shared Function Njco6C1nc4() As Stream
			Return New MemoryStream()
		End Function

		' Token: 0x0600007B RID: 123 RVA: 0x00002595 File Offset: 0x00000795
		Friend Shared Function rLIoBbVVpm(stream_0 As Stream) As Byte()
			Return CType(stream_0, MemoryStream).ToArray()
		End Function

		' Token: 0x0600007C RID: 124 RVA: 0x0000B7E8 File Offset: 0x000099E8
		<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
		Private Shared Function oN9oGXMAK7(byte_0 As Byte()) As Byte()
			Dim stream As Stream = WP6RZJql8gZrNhVA9v.Njco6C1nc4()
			Dim symmetricAlgorithm As SymmetricAlgorithm = WP6RZJql8gZrNhVA9v.PEXoCqmS4w()
			symmetricAlgorithm.Key = New Byte() { 118, 67, 31, 135, 7, 184, 91, 162, 189, 179, 41, 245, 43, 213, 171, 79, 56, 19, 190, 197, 15, 25, 135, 191, 120, 89, 131, 221, 55, 148, 46, 86 }
			symmetricAlgorithm.IV = New Byte() { 48, 45, 126, 244, 43, 150, 163, 53, 137, 166, 176, 201, 110, 66, 226, 141 }
			Dim cryptoStream As CryptoStream = New CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write)
			cryptoStream.Write(byte_0, 0, byte_0.Length)
			cryptoStream.Close()
			Dim array As Byte() = WP6RZJql8gZrNhVA9v.rLIoBbVVpm(stream)
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Return array
		End Function

		' Token: 0x0600007D RID: 125 RVA: 0x0000B860 File Offset: 0x00009A60
		Private Function JBbo7fndGL() As Byte()
			Return Nothing
		End Function

		' Token: 0x0600007E RID: 126 RVA: 0x0000B870 File Offset: 0x00009A70
		Private Function tM1owh06yH() As Byte()
			Return Nothing
		End Function

		' Token: 0x0600007F RID: 127 RVA: 0x0000B870 File Offset: 0x00009A70
		Private Function HpuoXD9KwB() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000080 RID: 128 RVA: 0x0000B870 File Offset: 0x00009A70
		Private Function vLyo3J8m2E() As Byte()
			Return Nothing
		End Function

		' Token: 0x06000081 RID: 129 RVA: 0x0000B880 File Offset: 0x00009A80
		Private Function fnqoJe2xAG() As Byte()
			Dim text As String = "{11111-22222-30001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000082 RID: 130 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		Private Function IHuoEWDKCc() As Byte()
			Dim text As String = "{11111-22222-30001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000083 RID: 131 RVA: 0x0000B900 File Offset: 0x00009B00
		Friend Function J6JoHkltLH() As Byte()
			Dim text As String = "{11111-22222-40001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000084 RID: 132 RVA: 0x0000B940 File Offset: 0x00009B40
		Friend Function FtroUJNIfo() As Byte()
			Dim text As String = "{11111-22222-40001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000085 RID: 133 RVA: 0x0000B980 File Offset: 0x00009B80
		Friend Function KIxoTLeGZr() As Byte()
			Dim text As String = "{11111-22222-50001-00001}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000086 RID: 134 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		Friend Function S0yo9WrR0W() As Byte()
			Dim text As String = "{11111-22222-50001-00002}"
			If text.Length > 0 Then
				Return New Byte() { 1, 2 }
			End If
			Return New Byte() { 1, 2 }
		End Function

		' Token: 0x06000088 RID: 136 RVA: 0x000025AA File Offset: 0x000007AA
		Friend Shared Function lXkgVSwILylAsW3Oyh(object_0 As Object, object_1 As Object) As Object
			Return object_0.GetManifestResourceStream(object_1)
		End Function

		' Token: 0x06000089 RID: 137 RVA: 0x000025B9 File Offset: 0x000007B9
		Friend Shared Function v9NRpbYclbs1msheIb(object_0 As Object) As Object
			Return object_0.KDikMXewCI()
		End Function

		' Token: 0x0600008A RID: 138 RVA: 0x000025C4 File Offset: 0x000007C4
		Friend Shared Sub BbVQwB9IAR87wq1gAX(object_0 As Object, long_0 As Long)
			object_0.Position = long_0
		End Sub

		' Token: 0x0600008B RID: 139 RVA: 0x000025D3 File Offset: 0x000007D3
		Friend Shared Function S0nk5gtOZauJTDr7nW(object_0 As Object) As Long
			Return object_0.Length
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x000025DE File Offset: 0x000007DE
		Friend Shared Function KwXsXILnYT41U9plHC(object_0 As Object, int_0 As Integer) As Object
			Return object_0.B2XkaLi4dH(int_0)
		End Function

		' Token: 0x0600008D RID: 141 RVA: 0x000025ED File Offset: 0x000007ED
		Friend Shared Sub Ep8t8qW3IZakIkoq7L(object_0 As Object)
			object_0.VDqkQKyKML()
		End Sub

		' Token: 0x0600008E RID: 142 RVA: 0x000025F8 File Offset: 0x000007F8
		Friend Shared Sub bNWpfSBNtBwd5N73E5(object_0 As Object)
			Array.Reverse(object_0)
		End Sub

		' Token: 0x0600008F RID: 143 RVA: 0x00002603 File Offset: 0x00000803
		Friend Shared Function m6r2LGxi9aJfd9Wrbl(object_0 As Object) As Object
			Return object_0.GetName()
		End Function

		' Token: 0x06000090 RID: 144 RVA: 0x0000260E File Offset: 0x0000080E
		Friend Shared Function u7DAk3lDVkm2JCp36C(object_0 As Object) As Object
			Return object_0.GetPublicKeyToken()
		End Function

		' Token: 0x06000091 RID: 145 RVA: 0x00002619 File Offset: 0x00000819
		Friend Shared Function cLJaiHhCdXwXtRjq23() As Object
			Return WP6RZJql8gZrNhVA9v.PEXoCqmS4w()
		End Function

		' Token: 0x06000092 RID: 146 RVA: 0x00002620 File Offset: 0x00000820
		Friend Shared Sub i4j142q6uBmtdQ5mLA(object_0 As Object, cipherMode_0 As CipherMode)
			object_0.Mode = cipherMode_0
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x0000262F File Offset: 0x0000082F
		Friend Shared Function PGWIiHb9ViHkZ8Asvw(object_0 As Object, object_1 As Object, object_2 As Object) As Object
			Return object_0.CreateDecryptor(object_1, object_2)
		End Function

		' Token: 0x06000094 RID: 148 RVA: 0x00002642 File Offset: 0x00000842
		Friend Shared Function WYCHWd6rXG4ADJKpNx() As Object
			Return WP6RZJql8gZrNhVA9v.Njco6C1nc4()
		End Function

		' Token: 0x06000095 RID: 149 RVA: 0x00002649 File Offset: 0x00000849
		Friend Shared Sub dnMS7LsLiubl6a13ds(object_0 As Object, object_1 As Object, int_0 As Integer, int_1 As Integer)
			object_0.Write(object_1, int_0, int_1)
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x00002660 File Offset: 0x00000860
		Friend Shared Sub TrFk4tJ85gYnrRfefj(object_0 As Object)
			object_0.FlushFinalBlock()
		End Sub

		' Token: 0x06000097 RID: 151 RVA: 0x0000266B File Offset: 0x0000086B
		Friend Shared Function R3CkYYmL0RGTEaInQB(object_0 As Object) As Object
			Return WP6RZJql8gZrNhVA9v.rLIoBbVVpm(object_0)
		End Function

		' Token: 0x06000098 RID: 152 RVA: 0x00002676 File Offset: 0x00000876
		Friend Shared Sub LhfE587EYIDF6pDy2C(object_0 As Object)
			object_0.Close()
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x00002681 File Offset: 0x00000881
		Friend Shared Function VmgHenNQrjHDtkBqhR(object_0 As Object, int_0 As Integer) As Integer
			Return BitConverter.ToInt32(object_0, int_0)
		End Function

		' Token: 0x0600009A RID: 154 RVA: 0x00002690 File Offset: 0x00000890
		Friend Shared Sub kbTkCZQ96RjLhmXcRR()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
		End Sub

		' Token: 0x0600009B RID: 155 RVA: 0x00002697 File Offset: 0x00000897
		Friend Shared Function QlUoev1pGNFQC4k2mV() As Object
			Return Encoding.Unicode
		End Function

		' Token: 0x0600009C RID: 156 RVA: 0x0000269E File Offset: 0x0000089E
		Friend Shared Function lqAje1r4lislC4DxXs(object_0 As Object, object_1 As Object, int_0 As Integer, int_1 As Integer) As Object
			Return object_0.GetString(object_1, int_0, int_1)
		End Function

		' Token: 0x0600009D RID: 157 RVA: 0x000026B5 File Offset: 0x000008B5
		Friend Shared Function VSkvy6KOqcX7hy4yoF() As Boolean
			Return Nothing Is Nothing
		End Function

		' Token: 0x0600009E RID: 158 RVA: 0x000026BB File Offset: 0x000008BB
		Friend Shared Function OmBkQ93oSxysisBy5y() As Object
			Return Nothing
		End Function

		' Token: 0x0600009F RID: 159 RVA: 0x00002690 File Offset: 0x00000890
		Friend Shared Sub II4mbg8DI7HcBFm1bf()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
		End Sub

		' Token: 0x060000A0 RID: 160 RVA: 0x000026BE File Offset: 0x000008BE
		Friend Shared Sub sZNERSiV2XFxGCIxuo(bool_0 As Boolean)
			RSACryptoServiceProvider.UseMachineKeyStore = bool_0
		End Sub

		' Token: 0x060000A1 RID: 161 RVA: 0x000026C9 File Offset: 0x000008C9
		Friend Shared Function JtnmN8tYQJeNqfcVqt(runtimeTypeHandle_0 As RuntimeTypeHandle) As Type
			Return Type.GetTypeFromHandle(runtimeTypeHandle_0)
		End Function

		' Token: 0x060000A2 RID: 162 RVA: 0x000026D4 File Offset: 0x000008D4
		Friend Shared Function c2UTnFNIs0BonkjSDm(object_0 As Object) As Object
			Return object_0.Location
		End Function

		' Token: 0x060000A3 RID: 163 RVA: 0x000026DF File Offset: 0x000008DF
		Friend Shared Function S7AvrlRnL3oEbvTxnV(object_0 As Object) As Integer
			Return object_0.Length
		End Function

		' Token: 0x060000A4 RID: 164 RVA: 0x000026EA File Offset: 0x000008EA
		Friend Shared Function otroNqYfktPuUxqtPs() As Object
			Return SHA1.Create()
		End Function

		' Token: 0x060000A5 RID: 165 RVA: 0x000026F1 File Offset: 0x000008F1
		Friend Shared Function b9i2hP1yFCFA0mkXRU(object_0 As Object) As Object
			Return CryptoConfig.MapNameToOID(object_0)
		End Function

		' Token: 0x060000A6 RID: 166 RVA: 0x000026FC File Offset: 0x000008FC
		Friend Shared Function M9asCGJsxO6UEWZN5N(object_0 As Object) As Boolean
			Return File.Exists(object_0)
		End Function

		' Token: 0x060000A7 RID: 167 RVA: 0x000025AA File Offset: 0x000007AA
		Friend Shared Function PwucW8jrQnqwO9nksv(object_0 As Object, object_1 As Object) As Object
			Return object_0.GetManifestResourceStream(object_1)
		End Function

		' Token: 0x060000A8 RID: 168 RVA: 0x000025B9 File Offset: 0x000007B9
		Friend Shared Function WXOeb5wHIamrsOQSBc(object_0 As Object) As Object
			Return object_0.KDikMXewCI()
		End Function

		' Token: 0x060000A9 RID: 169 RVA: 0x000025C4 File Offset: 0x000007C4
		Friend Shared Sub VymkpwXddOWY529qU7(object_0 As Object, long_0 As Long)
			object_0.Position = long_0
		End Sub

		' Token: 0x060000AA RID: 170 RVA: 0x000025D3 File Offset: 0x000007D3
		Friend Shared Function KZTrtCf53NZXL4PTtk(object_0 As Object) As Long
			Return object_0.Length
		End Function

		' Token: 0x060000AB RID: 171 RVA: 0x000025DE File Offset: 0x000007DE
		Friend Shared Function zsgogFH9IX0aLEDDm9(object_0 As Object, int_0 As Integer) As Object
			Return object_0.B2XkaLi4dH(int_0)
		End Function

		' Token: 0x060000AC RID: 172 RVA: 0x00002619 File Offset: 0x00000819
		Friend Shared Function kw9XV0snA9GhG2xASw() As Object
			Return WP6RZJql8gZrNhVA9v.PEXoCqmS4w()
		End Function

		' Token: 0x060000AD RID: 173 RVA: 0x00002620 File Offset: 0x00000820
		Friend Shared Sub WBS940x28268jF0EVq(object_0 As Object, cipherMode_0 As CipherMode)
			object_0.Mode = cipherMode_0
		End Sub

		' Token: 0x060000AE RID: 174 RVA: 0x0000262F File Offset: 0x0000082F
		Friend Shared Function kjuQwEe5PVurcPZKMQ(object_0 As Object, object_1 As Object, object_2 As Object) As Object
			Return object_0.CreateDecryptor(object_1, object_2)
		End Function

		' Token: 0x060000AF RID: 175 RVA: 0x00002642 File Offset: 0x00000842
		Friend Shared Function HFrmJl2Alwc9Te6y4t() As Object
			Return WP6RZJql8gZrNhVA9v.Njco6C1nc4()
		End Function

		' Token: 0x060000B0 RID: 176 RVA: 0x00002649 File Offset: 0x00000849
		Friend Shared Sub aBGsYJukCtknOBPdhe(object_0 As Object, object_1 As Object, int_0 As Integer, int_1 As Integer)
			object_0.Write(object_1, int_0, int_1)
		End Sub

		' Token: 0x060000B1 RID: 177 RVA: 0x00002660 File Offset: 0x00000860
		Friend Shared Sub Ehl5ahyGm25yJdTcn9(object_0 As Object)
			object_0.FlushFinalBlock()
		End Sub

		' Token: 0x060000B2 RID: 178 RVA: 0x00002707 File Offset: 0x00000907
		Friend Shared Function bC8IdekKvqYj6IlgON() As Object
			Return Encoding.UTF8
		End Function

		' Token: 0x060000B3 RID: 179 RVA: 0x0000266B File Offset: 0x0000086B
		Friend Shared Function E323IrFBAerYfQ7ORP(object_0 As Object) As Object
			Return WP6RZJql8gZrNhVA9v.rLIoBbVVpm(object_0)
		End Function

		' Token: 0x060000B4 RID: 180 RVA: 0x0000270E File Offset: 0x0000090E
		Friend Shared Function cwgZ22rDsSHcxkecNY(object_0 As Object, object_1 As Object) As Object
			Return object_0.GetString(object_1)
		End Function

		' Token: 0x060000B5 RID: 181 RVA: 0x0000271D File Offset: 0x0000091D
		Friend Shared Sub Gy5MrBqpDgNC07UXTq(object_0 As Object, object_1 As Object)
			object_0.FromXmlString(object_1)
		End Sub

		' Token: 0x060000B6 RID: 182 RVA: 0x00002676 File Offset: 0x00000876
		Friend Shared Sub cOXRIv0aQQDp1vG7i5(object_0 As Object)
			object_0.Close()
		End Sub

		' Token: 0x060000B7 RID: 183 RVA: 0x000025ED File Offset: 0x000007ED
		Friend Shared Sub AV0fJeBwnY4WbR45iL(object_0 As Object)
			object_0.VDqkQKyKML()
		End Sub

		' Token: 0x060000B8 RID: 184 RVA: 0x0000272C File Offset: 0x0000092C
		Friend Shared Sub g3L1ud53dmLm0QRsAZ(object_0 As Object, object_1 As Object, uint_0 As UInteger, object_2 As Object)
			WP6RZJql8gZrNhVA9v.vBuojdip3i(object_0, object_1, uint_0, object_2)
		End Sub

		' Token: 0x060000B9 RID: 185 RVA: 0x00002743 File Offset: 0x00000943
		Friend Shared Function iN4Rm6COI9q7SRLyMl(object_0 As Object) As UShort
			Return object_0.ReadUInt16()
		End Function

		' Token: 0x060000BA RID: 186 RVA: 0x0000274E File Offset: 0x0000094E
		Friend Shared Function PejaI79GYOY8UhfnPZ(object_0 As Object, object_1 As Object, int_0 As Integer, int_1 As Integer) As Integer
			Return object_0.Read(object_1, int_0, int_1)
		End Function

		' Token: 0x060000BB RID: 187 RVA: 0x00002765 File Offset: 0x00000965
		Friend Shared Sub lTpnE0bAsXkTddG4aT(object_0 As Object, object_1 As Object, int_0 As Integer, int_1 As Integer)
			WP6RZJql8gZrNhVA9v.NSmolmd79S(object_0, object_1, int_0, int_1)
		End Sub

		' Token: 0x060000BC RID: 188 RVA: 0x0000277C File Offset: 0x0000097C
		Friend Shared Function AXOUZwIZuxUBMWZHh0(object_0 As Object) As Long
			Return object_0.Position
		End Function

		' Token: 0x060000BD RID: 189 RVA: 0x00002787 File Offset: 0x00000987
		Friend Shared Function JXE4C9cJpC9DrLXLf5(object_0 As Object) As UInteger
			Return object_0.ReadUInt32()
		End Function

		' Token: 0x060000BE RID: 190 RVA: 0x00002792 File Offset: 0x00000992
		Friend Shared Function YvMOwapfr8H4AmrJhD(uint_0 As UInteger, int_0 As Integer, long_0 As Long, object_0 As Object) As UInteger
			Return WP6RZJql8gZrNhVA9v.SDQoufkqT0(uint_0, int_0, long_0, object_0)
		End Function

		' Token: 0x060000BF RID: 191 RVA: 0x000027A9 File Offset: 0x000009A9
		Friend Shared Function F9hfLPEXa6TTj6vidY(long_0 As Long, long_1 As Long) As Long
			Return Math.Min(long_0, long_1)
		End Function

		' Token: 0x060000C0 RID: 192 RVA: 0x000027B8 File Offset: 0x000009B8
		Friend Shared Function kZ8j1kOIjc9JP5JyjS(object_0 As Object, object_1 As Object, int_0 As Integer, int_1 As Integer) As Object
			Return object_0.TransformFinalBlock(object_1, int_0, int_1)
		End Function

		' Token: 0x060000C1 RID: 193 RVA: 0x000027CF File Offset: 0x000009CF
		Friend Shared Function AlAGlwWX8fLEnOikJT(object_0 As Object, int_0 As Integer) As Object
			Return object_0.ReadBytes(int_0)
		End Function

		' Token: 0x060000C2 RID: 194 RVA: 0x000025F8 File Offset: 0x000007F8
		Friend Shared Sub x7GgNxdQoFBb9qdlHj(object_0 As Object)
			Array.Reverse(object_0)
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x000027DE File Offset: 0x000009DE
		Friend Shared Function GYvrQMS8pKiMfMlh1c(object_0 As Object) As Object
			Return object_0.Hash
		End Function

		' Token: 0x060000C4 RID: 196 RVA: 0x000027E9 File Offset: 0x000009E9
		Friend Shared Function bj15SVKnAylKJmoLma(object_0 As Object, object_1 As Object, object_2 As Object, object_3 As Object) As Boolean
			Return object_0.VerifyHash(object_1, object_2, object_3)
		End Function

		' Token: 0x060000C5 RID: 197 RVA: 0x00002603 File Offset: 0x00000803
		Friend Shared Function xyEln2lHnNyCvSd1Of(object_0 As Object) As Object
			Return object_0.GetName()
		End Function

		' Token: 0x060000C6 RID: 198 RVA: 0x00002800 File Offset: 0x00000A00
		Friend Shared Function nW1uWt45ylgAA4v2Tb(object_0 As Object) As Object
			Return object_0.Name
		End Function

		' Token: 0x060000C7 RID: 199 RVA: 0x0000280B File Offset: 0x00000A0B
		Friend Shared Function npZFOvQXD5kPgI2P4g(object_0 As Object, object_1 As Object) As Object
			Return object_0 + object_1
		End Function

		' Token: 0x060000C8 RID: 200 RVA: 0x000026B5 File Offset: 0x000008B5
		Friend Shared Function MjUpQTUAyyOAp6C2gO() As Boolean
			Return Nothing Is Nothing
		End Function

		' Token: 0x060000C9 RID: 201 RVA: 0x000026BB File Offset: 0x000008BB
		Friend Shared Function Q8X6PuAZ66pEnQWCMg() As Object
			Return Nothing
		End Function

		' Token: 0x04000042 RID: 66
		Friend Shared x4Dk2IHVmX As Assembly = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554449)).Assembly

		' Token: 0x04000043 RID: 67
		Private Shared Tqek0lIh21 As Dictionary(Of Integer, Integer) = Nothing

		' Token: 0x04000044 RID: 68
		Private Shared OObkplyC7t As Byte() = New Byte(-1) {}

		' Token: 0x04000045 RID: 69
		Private Shared aatkD4ZSGk As IntPtr = IntPtr.Zero

		' Token: 0x04000046 RID: 70
		Private Shared Qy5kfBXtEh As Integer = 1

		' Token: 0x04000047 RID: 71
		Friend Shared rNZkehfwNu As WP6RZJql8gZrNhVA9v.QZEOeHRUkDiNqCWT0p = Nothing

		' Token: 0x04000048 RID: 72
		<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
		Private Shared firstrundone As Boolean = False

		' Token: 0x04000049 RID: 73
		Private Shared zIOkYypt1M As WP6RZJql8gZrNhVA9v.N7UlhA3IRW2ugh7tWg = Nothing

		' Token: 0x0400004A RID: 74
		Private Shared BV0kmUIPgx As WP6RZJql8gZrNhVA9v.MacgPI7JyVeAhNaPvd = Nothing

		' Token: 0x0400004B RID: 75
		Private Shared etmkyDG2SG As WP6RZJql8gZrNhVA9v.YLCGmBEaUwBbEqLM01 = Nothing

		' Token: 0x0400004C RID: 76
		Private Shared fMAkKtNIoA As Boolean = False

		' Token: 0x0400004D RID: 77
		Private Shared LrEkS2eXQL As Boolean = False

		' Token: 0x0400004E RID: 78
		Private Shared O1BkIDx0L0 As UInteger() = New UInteger() { 3614090360UI, 3905402710UI, 606105819UI, 3250441966UI, 4118548399UI, 1200080426UI, 2821735955UI, 4249261313UI, 1770035416UI, 2336552879UI, 4294925233UI, 2304563134UI, 1804603682UI, 4254626195UI, 2792965006UI, 1236535329UI, 4129170786UI, 3225465664UI, 643717713UI, 3921069994UI, 3593408605UI, 38016083UI, 3634488961UI, 3889429448UI, 568446438UI, 3275163606UI, 4107603335UI, 1163531501UI, 2850285829UI, 4243563512UI, 1735328473UI, 2368359562UI, 4294588738UI, 2272392833UI, 1839030562UI, 4259657740UI, 2763975236UI, 1272893353UI, 4139469664UI, 3200236656UI, 681279174UI, 3936430074UI, 3572445317UI, 76029189UI, 3654602809UI, 3873151461UI, 530742520UI, 3299628645UI, 4096336452UI, 1126891415UI, 2878612391UI, 4237533241UI, 1700485571UI, 2399980690UI, 4293915773UI, 2240044497UI, 1873313359UI, 4264355552UI, 2734768916UI, 1309151649UI, 4149444226UI, 3174756917UI, 718787259UI, 3951481745UI }

		' Token: 0x0400004F RID: 79
		Private Shared CgSk1JZr60 As Integer = 0

		' Token: 0x04000050 RID: 80
		Private Shared xo4kuDarJK As Boolean = False

		' Token: 0x04000051 RID: 81
		Private Shared zl0ksqgIH1 As Integer() = New Integer(-1) {}

		' Token: 0x04000052 RID: 82
		Private Shared URnkCOceLK As Long = 0L

		' Token: 0x04000053 RID: 83
		Private Shared PRZkZqsNsa As Boolean = False

		' Token: 0x04000054 RID: 84
		Private Shared eXJkjmTXDX As Long = 0L

		' Token: 0x04000055 RID: 85
		Private Shared WaKkhokJrA As Object = New String(-1) {}

		' Token: 0x04000056 RID: 86
		Private Shared s6pkoGoeab As Byte() = New Byte(-1) {}

		' Token: 0x04000057 RID: 87
		Private Shared VM5kd0GoFG As SortedList = New SortedList()

		' Token: 0x04000058 RID: 88
		Private Shared MrkkWebIMK As Boolean = False

		' Token: 0x04000059 RID: 89
		Private Shared tuYkt9D06I As WP6RZJql8gZrNhVA9v.RI754BJF754hNSApRW = Nothing

		' Token: 0x0400005A RID: 90
		Private Shared emjkxI4Yxp As Object = New Object()

		' Token: 0x0400005B RID: 91
		Private Shared K7PkOHxqAd As IntPtr = IntPtr.Zero

		' Token: 0x0400005C RID: 92
		Private Shared wcyk8nIyBt As IntPtr = IntPtr.Zero

		' Token: 0x0400005D RID: 93
		Private Shared tTVkFDSO7A As WP6RZJql8gZrNhVA9v.yy2w1VXOQgx806ubre = Nothing

		' Token: 0x0400005E RID: 94
		Friend Shared lmdkVksVkh As Hashtable = New Hashtable()

		' Token: 0x0400005F RID: 95
		Private Shared VE2k4S5okQ As IntPtr = IntPtr.Zero

		' Token: 0x04000060 RID: 96
		Private Shared wpoklx4RIX As Integer = 0

		' Token: 0x04000061 RID: 97
		Friend Shared onZkkIlVOi As RSACryptoServiceProvider = Nothing

		' Token: 0x04000062 RID: 98
		Friend Shared abxkLGOVrU As WP6RZJql8gZrNhVA9v.QZEOeHRUkDiNqCWT0p = Nothing

		' Token: 0x04000063 RID: 99
		Private Shared yBRkv0eFeZ As WP6RZJql8gZrNhVA9v.GL8NaIwq2KOvLQhMFX = Nothing

		' Token: 0x04000064 RID: 100
		Private Shared HkLkNdDPtB As Byte() = New Byte(-1) {}

		' Token: 0x04000065 RID: 101
		Private Shared V9fkgxQPQA As Boolean = False

		' Token: 0x04000066 RID: 102
		Private Shared XtMknffM5M As Integer = 0

		' Token: 0x02000012 RID: 18
		' (Invoke) Token: 0x060000CB RID: 203
		Private Delegate Sub vXgxlLQcVHhY7dY50X(o As Object)

		' Token: 0x02000013 RID: 19
		Friend Class RJDcsuMfOxrTCYImPe
			Inherits Attribute

			' Token: 0x060000CE RID: 206 RVA: 0x0000281A File Offset: 0x00000A1A
			<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
			Public Sub New(object_0 As Object)
			End Sub

			' Token: 0x02000014 RID: 20
			Friend Class iGR41459RDH4FvPdNk(Of T)
				' Token: 0x060000CF RID: 207 RVA: 0x00002243 File Offset: 0x00000443
				Public Sub New()
					hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
					MyBase..ctor()
				End Sub

				' Token: 0x060000D0 RID: 208 RVA: 0x0000223C File Offset: 0x0000043C
				' Note: this type is marked as 'beforefieldinit'.
				Shared Sub New()
					WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
				End Sub
			End Class
		End Class

		' Token: 0x02000015 RID: 21
		Friend Class qcBC7nbplYPB6DW0yw
			' Token: 0x060000D1 RID: 209 RVA: 0x0000BA00 File Offset: 0x00009C00
			<WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe(GetType(WP6RZJql8gZrNhVA9v.RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk(Of Object)()))>
			Friend Shared Function G9skPDgcXb(string_0 As String, string_1 As String) As String
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(string_0)
				Dim array As Byte() = bytes
				Dim array2 As Byte() = New Byte() { 82, 102, 104, 110, 32, 77, 24, 34, 118, 181, 51, 17, 18, 51, 12, 109, 10, 32, 77, 24, 34, 158, 161, 41, 97, 28, 118, 181, 5, 25, 1, 88 }
				Dim array3 As Byte() = WP6RZJql8gZrNhVA9v.XEDoeIU7mj(Encoding.Unicode.GetBytes(string_1))
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim symmetricAlgorithm As SymmetricAlgorithm = WP6RZJql8gZrNhVA9v.PEXoCqmS4w()
				symmetricAlgorithm.Key = array2
				symmetricAlgorithm.IV = array3
				Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write)
				cryptoStream.Write(array, 0, array.Length)
				cryptoStream.Close()
				Return Convert.ToBase64String(memoryStream.ToArray())
			End Function
		End Class

		' Token: 0x02000016 RID: 22
		' (Invoke) Token: 0x060000D4 RID: 212
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Friend Delegate Function QZEOeHRUkDiNqCWT0p(classthis As IntPtr, comp As IntPtr, info As IntPtr, <MarshalAs(UnmanagedType.U4)> flags As UInteger, nativeEntry As IntPtr, ByRef nativeSizeOfCode As UInteger) As UInteger

		' Token: 0x02000017 RID: 23
		' (Invoke) Token: 0x060000D8 RID: 216
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Private Delegate Function OFfwWh6ZIHjfnqBOWx() As IntPtr

		' Token: 0x02000018 RID: 24
		Friend Structure BIpvxRBRb2dOGl802m
			' Token: 0x04000067 RID: 103
			Friend JDNkifbo3S As Boolean

			' Token: 0x04000068 RID: 104
			Friend jsbkrdexts As Byte()
		End Structure

		' Token: 0x02000019 RID: 25
		Friend Class VtNVUKGulysZw81C3E
			' Token: 0x060000DB RID: 219 RVA: 0x00002822 File Offset: 0x00000A22
			Public Sub New(stream_0 As Stream)
				Me.KPVkbuTpLj = New BinaryReader(stream_0)
			End Sub

			' Token: 0x060000DC RID: 220 RVA: 0x00002836 File Offset: 0x00000A36
			Friend Function KDikMXewCI() As Stream
				Return Me.KPVkbuTpLj.BaseStream
			End Function

			' Token: 0x060000DD RID: 221 RVA: 0x00002843 File Offset: 0x00000A43
			Friend Function B2XkaLi4dH(int_0 As Integer) As Byte()
				Return Me.KPVkbuTpLj.ReadBytes(int_0)
			End Function

			' Token: 0x060000DE RID: 222 RVA: 0x00002851 File Offset: 0x00000A51
			Friend Function hx5kqNgSj4(byte_0 As Byte(), int_0 As Integer, int_1 As Integer) As Integer
				Return Me.KPVkbuTpLj.Read(byte_0, int_0, int_1)
			End Function

			' Token: 0x060000DF RID: 223 RVA: 0x00002861 File Offset: 0x00000A61
			Friend Function TVtkAMaqpL() As Integer
				Return Me.KPVkbuTpLj.ReadInt32()
			End Function

			' Token: 0x060000E0 RID: 224 RVA: 0x0000286E File Offset: 0x00000A6E
			Friend Sub VDqkQKyKML()
				Me.KPVkbuTpLj.Close()
			End Sub

			' Token: 0x04000069 RID: 105
			Private KPVkbuTpLj As BinaryReader
		End Class

		' Token: 0x0200001A RID: 26
		' (Invoke) Token: 0x060000E2 RID: 226
		<UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet := CharSet.Ansi)>
		Private Delegate Function MacgPI7JyVeAhNaPvd(hModule As IntPtr, lpName As String, lpType As UInteger) As IntPtr

		' Token: 0x0200001B RID: 27
		' (Invoke) Token: 0x060000E6 RID: 230
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Private Delegate Function GL8NaIwq2KOvLQhMFX(lpAddress As IntPtr, dwSize As UInteger, flAllocationType As UInteger, flProtect As UInteger) As IntPtr

		' Token: 0x0200001C RID: 28
		' (Invoke) Token: 0x060000EA RID: 234
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Private Delegate Function yy2w1VXOQgx806ubre(hProcess As IntPtr, lpBaseAddress As IntPtr, <[In]()> <Out()> buffer As Byte(), size As UInteger, <System.Runtime.InteropServices.OutAttribute()> ByRef lpNumberOfBytesWritten As IntPtr) As Integer

		' Token: 0x0200001D RID: 29
		' (Invoke) Token: 0x060000EE RID: 238
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Private Delegate Function N7UlhA3IRW2ugh7tWg(lpAddress As IntPtr, dwSize As Integer, flNewProtect As Integer, ByRef lpflOldProtect As Integer) As Integer

		' Token: 0x0200001E RID: 30
		' (Invoke) Token: 0x060000F2 RID: 242
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Private Delegate Function RI754BJF754hNSApRW(dwDesiredAccess As UInteger, bInheritHandle As Integer, dwProcessId As UInteger) As IntPtr

		' Token: 0x0200001F RID: 31
		' (Invoke) Token: 0x060000F6 RID: 246
		<UnmanagedFunctionPointer(CallingConvention.StdCall)>
		Private Delegate Function YLCGmBEaUwBbEqLM01(ptr As IntPtr) As Integer

		' Token: 0x02000020 RID: 32
		<Flags()>
		Private Enum AwgKvrHJUS3TxryUsj
		End Enum
	End Class
End Namespace
