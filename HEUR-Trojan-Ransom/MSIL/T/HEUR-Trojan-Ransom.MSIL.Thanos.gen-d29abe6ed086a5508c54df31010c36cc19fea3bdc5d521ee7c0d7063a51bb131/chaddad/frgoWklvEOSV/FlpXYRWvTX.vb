Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000015 RID: 21
	Public Module FlpXYRWvTX
		' Token: 0x06000067 RID: 103 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		Public Function ZTvekdOmyg(string_0 As String) As String
			Dim num As Integer = 0
			Dim text As String = FlpXYRWvTX.getString_0(107388735)
			FlpXYRWvTX.MkdigCRsEEMOX(FlpXYRWvTX.XLDTHwKdmajt, num, text)
			Dim array As Byte() = FlpXYRWvTX.YEURKxvgnTup(Encoding.UTF8.GetBytes(string_0), num, text)
			Return Convert.ToBase64String(array)
		End Function

		' Token: 0x06000068 RID: 104 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		Private Function YEURKxvgnTup(byte_0 As Byte(), int_0 As Integer, string_0 As String) As Byte()
			If byte_0 IsNot Nothing AndAlso byte_0.Length <> 0 Then
				Dim num As Integer = FlpXYRWvTX.NmEJfVQfRMcT(int_0)
				If byte_0.Length > num Then
					Throw New ArgumentException(String.Format(FlpXYRWvTX.getString_0(107402553), num), FlpXYRWvTX.getString_0(107402562))
				End If
				If Not FlpXYRWvTX.KNJuZPxStl(int_0) Then
					Throw New ArgumentException(FlpXYRWvTX.getString_0(107402548), FlpXYRWvTX.getString_0(107402487))
				End If
				If String.IsNullOrEmpty(string_0) Then
					Throw New ArgumentException(FlpXYRWvTX.getString_0(107402506), FlpXYRWvTX.getString_0(107402477))
				End If
				Using rsacryptoServiceProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider(int_0)
					rsacryptoServiceProvider.FromXmlString(string_0)
					Return rsacryptoServiceProvider.Encrypt(byte_0, FlpXYRWvTX.QHqhUxmYNLgFw)
				End Using
			End If
			Throw New ArgumentException(FlpXYRWvTX.getString_0(107402583), FlpXYRWvTX.getString_0(107402562))
		End Function

		' Token: 0x06000069 RID: 105 RVA: 0x00002908 File Offset: 0x00000B08
		Private Function NmEJfVQfRMcT(int_0 As Integer) As Integer
			If FlpXYRWvTX.QHqhUxmYNLgFw Then
				Return(int_0 - 384) / 8 + 7
			End If
			Return(int_0 - 384) / 8 + 37
		End Function

		' Token: 0x0600006A RID: 106 RVA: 0x00002929 File Offset: 0x00000B29
		Private Function KNJuZPxStl(int_0 As Integer) As Boolean
			Return int_0 >= 384 AndAlso int_0 <= 16384 AndAlso int_0 Mod 8 = 0
		End Function

		' Token: 0x0600006B RID: 107 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		Private Sub MkdigCRsEEMOX(IZpTbvGgqiuQ As String, <System.Runtime.InteropServices.OutAttribute()> ByRef OPfmSiyNGzFxTlOi As Integer, <System.Runtime.InteropServices.OutAttribute()> ByRef fPzbhtlmbDZXN As String)
			OPfmSiyNGzFxTlOi = 0
			fPzbhtlmbDZXN = FlpXYRWvTX.getString_0(107388735)
			If IZpTbvGgqiuQ IsNot Nothing AndAlso IZpTbvGgqiuQ.Length > 0 Then
				Dim array As Byte() = Convert.FromBase64String(IZpTbvGgqiuQ)
				Dim [string] As String = Encoding.UTF8.GetString(array)
				If [string].Contains(FlpXYRWvTX.getString_0(107402428)) Then
					Dim array2 As String() = [string].Split(New Char() { "!"c }, 2)
					Try
						OPfmSiyNGzFxTlOi = Integer.Parse(array2(0))
						fPzbhtlmbDZXN = array2(1)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600006C RID: 108 RVA: 0x00002943 File Offset: 0x00000B43
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(FlpXYRWvTX))
			FlpXYRWvTX.QHqhUxmYNLgFw = False
			FlpXYRWvTX.XLDTHwKdmajt = FlpXYRWvTX.getString_0(107402423)
		End Sub

		' Token: 0x04000093 RID: 147
		Private QHqhUxmYNLgFw As Boolean

		' Token: 0x04000094 RID: 148
		Private XLDTHwKdmajt As String

		' Token: 0x04000095 RID: 149
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
