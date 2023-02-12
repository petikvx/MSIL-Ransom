Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000015 RID: 21
	Public Module iWQFPqIegPgO
		' Token: 0x06000067 RID: 103 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		Public Function JgyQdoAVxtGA(string_0 As String) As String
			Dim num As Integer = 0
			Dim text As String = iWQFPqIegPgO.getString_0(107388843)
			iWQFPqIegPgO.YLUZRRmVBSER(iWQFPqIegPgO.bgENoIdCObJJqen, num, text)
			Dim array As Byte() = iWQFPqIegPgO.InNVJPhwvyklMu(Encoding.UTF8.GetBytes(string_0), num, text)
			Return Convert.ToBase64String(array)
		End Function

		' Token: 0x06000068 RID: 104 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		Private Function InNVJPhwvyklMu(byte_0 As Byte(), int_0 As Integer, string_0 As String) As Byte()
			If byte_0 IsNot Nothing AndAlso byte_0.Length <> 0 Then
				Dim num As Integer = iWQFPqIegPgO.SKwlWlLTeiy(int_0)
				If byte_0.Length > num Then
					Throw New ArgumentException(String.Format(iWQFPqIegPgO.getString_0(107402661), num), iWQFPqIegPgO.getString_0(107402670))
				End If
				If Not iWQFPqIegPgO.VKBzhkpFlX(int_0) Then
					Throw New ArgumentException(iWQFPqIegPgO.getString_0(107402080), iWQFPqIegPgO.getString_0(107402051))
				End If
				If String.IsNullOrEmpty(string_0) Then
					Throw New ArgumentException(iWQFPqIegPgO.getString_0(107402038), iWQFPqIegPgO.getString_0(107402009))
				End If
				Using rsacryptoServiceProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider(int_0)
					rsacryptoServiceProvider.FromXmlString(string_0)
					Return rsacryptoServiceProvider.Encrypt(byte_0, iWQFPqIegPgO.FgplFcpRDZRmRv)
				End Using
			End If
			Throw New ArgumentException(iWQFPqIegPgO.getString_0(107402659), iWQFPqIegPgO.getString_0(107402670))
		End Function

		' Token: 0x06000069 RID: 105 RVA: 0x00002908 File Offset: 0x00000B08
		Private Function SKwlWlLTeiy(int_0 As Integer) As Integer
			If iWQFPqIegPgO.FgplFcpRDZRmRv Then
				Return(int_0 - 384) / 8 + 7
			End If
			Return(int_0 - 384) / 8 + 37
		End Function

		' Token: 0x0600006A RID: 106 RVA: 0x00002929 File Offset: 0x00000B29
		Private Function VKBzhkpFlX(int_0 As Integer) As Boolean
			Return int_0 >= 384 AndAlso int_0 <= 16384 AndAlso int_0 Mod 8 = 0
		End Function

		' Token: 0x0600006B RID: 107 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		Private Sub YLUZRRmVBSER(HRUntMtfYqIFF As String, <System.Runtime.InteropServices.OutAttribute()> ByRef UxtEVVVmubPueT As Integer, <System.Runtime.InteropServices.OutAttribute()> ByRef zHblLRsjCvrCb As String)
			UxtEVVVmubPueT = 0
			zHblLRsjCvrCb = iWQFPqIegPgO.getString_0(107388843)
			If HRUntMtfYqIFF IsNot Nothing AndAlso HRUntMtfYqIFF.Length > 0 Then
				Dim array As Byte() = Convert.FromBase64String(HRUntMtfYqIFF)
				Dim [string] As String = Encoding.UTF8.GetString(array)
				If [string].Contains(iWQFPqIegPgO.getString_0(107402024)) Then
					Dim array2 As String() = [string].Split(New Char() { "!"c }, 2)
					Try
						UxtEVVVmubPueT = Integer.Parse(array2(0))
						zHblLRsjCvrCb = array2(1)
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600006C RID: 108 RVA: 0x00002943 File Offset: 0x00000B43
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(iWQFPqIegPgO))
			iWQFPqIegPgO.FgplFcpRDZRmRv = False
			iWQFPqIegPgO.bgENoIdCObJJqen = iWQFPqIegPgO.getString_0(107401987)
		End Sub

		' Token: 0x04000093 RID: 147
		Private FgplFcpRDZRmRv As Boolean

		' Token: 0x04000094 RID: 148
		Private bgENoIdCObJJqen As String

		' Token: 0x04000095 RID: 149
		<NonSerialized()>
		Friend getString_0 As GetString
	End Module
End Namespace
