Imports System
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Namespace Main.Tools
	' Token: 0x0200004E RID: 78
	Public Class LastLogin
		' Token: 0x060001AF RID: 431 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		Public Shared Function GetMinecraftPath() As String
			Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft")
		End Function

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x060001B0 RID: 432 RVA: 0x0000FA00 File Offset: 0x0000DC00
		Public Shared ReadOnly Property LastLoginFile As String
			Get
				Return Path.Combine(LastLogin.GetMinecraftPath(), "lastlogin")
			End Get
		End Property

		' Token: 0x060001B1 RID: 433 RVA: 0x0000FA20 File Offset: 0x0000DC20
		Public Shared Function GetLastLogin() As LastLogin
			Return LastLogin.GetLastLogin(LastLogin.LastLoginFile)
		End Function

		' Token: 0x060001B2 RID: 434 RVA: 0x0000FA3C File Offset: 0x0000DC3C
		Public Shared Function GetLastLogin(lastLoginFile As String) As LastLogin
			Dim lastLogin As LastLogin
			Try
				Dim array As Byte() = File.ReadAllBytes(lastLoginFile)
				Dim pkcskeyGenerator As PKCSKeyGenerator = New PKCSKeyGenerator("passwordfile", LastLogin.LastLoginSalt, 5, 1)
				Dim decryptor As ICryptoTransform = pkcskeyGenerator.Decryptor
				Dim array2 As Byte() = decryptor.TransformFinalBlock(array, 0, array.Length)
				Dim num As Short = IPAddress.HostToNetworkOrder(BitConverter.ToInt16(array2, 0))
				Dim array3 As Byte() = New Byte(CInt(num) - 1) {}
				Dim array4 As Byte() = New Byte(array2.Length - 4 - CInt(num) - 1) {}
				For i As Integer = 0 To CInt(num) - 1
					array3(i) = array2(i + 2)
				Next
				For j As Integer = 0 To array2.Length - 4 - CInt(num) - 1
					array4(j) = array2(CInt((4S + num)) + j)
				Next
				lastLogin = New LastLogin() With { .Username = Encoding.UTF8.GetString(array3), .Password = Encoding.UTF8.GetString(array4) }
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
				lastLogin = Nothing
			End Try
			Return lastLogin
		End Function

		' Token: 0x04000154 RID: 340
		Private Shared LastLoginSalt As Byte() = New Byte() { 12, 157, 74, 228, 30, 131, 21, 252 }

		' Token: 0x04000155 RID: 341
		Private Const LastLoginPassword As String = "passwordfile"

		' Token: 0x04000156 RID: 342
		Public Username As String = String.Empty

		' Token: 0x04000157 RID: 343
		Public Password As String = String.Empty
	End Class
End Namespace
