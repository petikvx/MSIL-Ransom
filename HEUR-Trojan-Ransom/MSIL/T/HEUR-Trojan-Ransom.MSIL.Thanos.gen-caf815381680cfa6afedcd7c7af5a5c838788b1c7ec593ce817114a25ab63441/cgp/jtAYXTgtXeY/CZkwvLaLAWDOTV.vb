Imports System
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x0200001D RID: 29
	Public NotInheritable Class CZkwvLaLAWDOTV
		' Token: 0x060000BB RID: 187 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		Public Shared Sub olPlpAvfFEYzMgh(string_0 As String, string_1 As String, string_2 As String, string_3 As String, string_4 As String, string_5 As String, string_6 As String)
			Try
				Dim ltBJgftTQAhMSP As CZkwvLaLAWDOTV.LtBJgftTQAhMSP = CType(CZkwvLaLAWDOTV.tfXnbiPuSzVyb.InvokeMember(JWIADYxDQdhHy.aPAxwuEVwvWnky(CZkwvLaLAWDOTV.getString_0(107399589)), BindingFlags.InvokeMethod, Nothing, CZkwvLaLAWDOTV.dWSkfqPMsqGBFzzB, New Object() { string_0 }), CZkwvLaLAWDOTV.LtBJgftTQAhMSP)
				ltBJgftTQAhMSP.LKnahwuaqXnDuff = string_4
				ltBJgftTQAhMSP.GVClkWQTIjX = string_5
				ltBJgftTQAhMSP.PnsasqAcHTz = string_1
				ltBJgftTQAhMSP.SWWlDKwvUbkWs = string_3
				ltBJgftTQAhMSP.vtioVEpTTYvexunw = string_2
				If Not String.IsNullOrEmpty(string_6) Then
					ltBJgftTQAhMSP.uDMMwVnBKPwf = string_6
				End If
				ltBJgftTQAhMSP.Save()
			Catch ex As Exception
				If JWIADYxDQdhHy.WkkVnLAdbtG Then
					Try
						File.AppendAllText(JWIADYxDQdhHy.PhOHjwgFpwoPkI, CZkwvLaLAWDOTV.getString_0(107399560) + ex.Message + CZkwvLaLAWDOTV.getString_0(107396413))
					Catch ex2 As Exception
					End Try
				End If
			End Try
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x00002B6A File Offset: 0x00000D6A
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(CZkwvLaLAWDOTV))
			CZkwvLaLAWDOTV.tfXnbiPuSzVyb = Type.GetTypeFromProgID(JWIADYxDQdhHy.aPAxwuEVwvWnky(CZkwvLaLAWDOTV.getString_0(107399515)))
			CZkwvLaLAWDOTV.dWSkfqPMsqGBFzzB = Activator.CreateInstance(CZkwvLaLAWDOTV.tfXnbiPuSzVyb)
		End Sub

		' Token: 0x040000B8 RID: 184
		Private Shared tfXnbiPuSzVyb As Type

		' Token: 0x040000B9 RID: 185
		Private Shared dWSkfqPMsqGBFzzB As Object

		' Token: 0x040000BA RID: 186
		<NonSerialized()>
		Friend Shared getString_0 As GetString

		' Token: 0x0200001E RID: 30
		<Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")>
		<TypeLibType(4160S)>
		<ComImport()>
		Private Interface LtBJgftTQAhMSP
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x060000BE RID: 190
			<DispId(0)>
			ReadOnly Property DBQZCsxvtCvoxw As String

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x060000BF RID: 191
			' (set) Token: 0x060000C0 RID: 192
			<DispId(1000)>
			Property vtioVEpTTYvexunw As String

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x060000C1 RID: 193
			' (set) Token: 0x060000C2 RID: 194
			<DispId(1001)>
			Property LKnahwuaqXnDuff As String

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x060000C3 RID: 195
			' (set) Token: 0x060000C4 RID: 196
			<DispId(1002)>
			Property GVClkWQTIjX As String

			' Token: 0x1700000A RID: 10
			' (get) Token: 0x060000C5 RID: 197
			' (set) Token: 0x060000C6 RID: 198
			<DispId(1003)>
			Property uDMMwVnBKPwf As String

			' Token: 0x1700000B RID: 11
			' (set) Token: 0x060000C7 RID: 199
			<DispId(1004)>
			WriteOnly Property EYVkOKjpejG As String

			' Token: 0x1700000C RID: 12
			' (get) Token: 0x060000C8 RID: 200
			' (set) Token: 0x060000C9 RID: 201
			<DispId(1005)>
			Property PnsasqAcHTz As String

			' Token: 0x1700000D RID: 13
			' (get) Token: 0x060000CA RID: 202
			' (set) Token: 0x060000CB RID: 203
			<DispId(1006)>
			Property WmMBUihatUPCMvN As Integer

			' Token: 0x1700000E RID: 14
			' (get) Token: 0x060000CC RID: 204
			' (set) Token: 0x060000CD RID: 205
			<DispId(1007)>
			Property SWWlDKwvUbkWs As String

			' Token: 0x060000CE RID: 206
			<DispId(2000)>
			<TypeLibFunc(64S)>
			Sub Load(<MarshalAs(UnmanagedType.BStr)> <[In]()> PathLink As String)

			' Token: 0x060000CF RID: 207
			<DispId(2001)>
			Sub Save()
		End Interface
	End Class
End Namespace
