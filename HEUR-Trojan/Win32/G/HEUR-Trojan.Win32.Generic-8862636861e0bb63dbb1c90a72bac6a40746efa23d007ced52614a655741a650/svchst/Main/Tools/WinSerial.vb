Imports System
Imports System.Collections
Imports Microsoft.Win32

Namespace Main.Tools
	' Token: 0x02000065 RID: 101
	Friend Class WinSerial
		' Token: 0x060001F4 RID: 500 RVA: 0x00011D0C File Offset: 0x0000FF0C
		Public Function GetWindowsProductKeyFromRegistry() As String
			Try
				Dim registryKey As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Environment.MachineName)
				Dim registryKey2 As RegistryKey = registryKey.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion")
				Dim obj As Object = If((registryKey2 IsNot Nothing), registryKey2.GetValue("DigitalProductId"), Nothing)
				If obj Is Nothing Then
					Return "Failed to get DigitalProductId from registry"
				End If
				Dim array As Byte() = CType(obj, Byte())
				registryKey.Close()
				Dim flag As Boolean = (Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 2) OrElse Environment.OSVersion.Version.Major > 6
				Return Me.GetWindowsProductKeyFromDigitalProductId(array, If(flag, WinSerial.DigitalProductIdVersion.Windows8AndUp, WinSerial.DigitalProductIdVersion.UpToWindows7))
			Catch
			End Try
			Return String.Empty
		End Function

		' Token: 0x060001F5 RID: 501 RVA: 0x00011DCC File Offset: 0x0000FFCC
		Public Function GetWindowsProductKeyFromDigitalProductId(digitalProductId As Byte(), digitalProductIdVersion As WinSerial.DigitalProductIdVersion) As String
			Return If((digitalProductIdVersion = WinSerial.DigitalProductIdVersion.Windows8AndUp), Me.DecodeProductKeyWin8AndUp(digitalProductId), Me.DecodeProductKey(digitalProductId))
		End Function

		' Token: 0x060001F6 RID: 502 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		Private Function DecodeProductKey(digitalProductId As Byte()) As String
			Dim array As Char() = New Char() { "B"c, "C"c, "D"c, "F"c, "G"c, "H"c, "J"c, "K"c, "M"c, "P"c, "Q"c, "R"c, "T"c, "V"c, "W"c, "X"c, "Y"c, "2"c, "3"c, "4"c, "6"c, "7"c, "8"c, "9"c }
			Dim array2 As Char() = New Char(28) {}
			Dim arrayList As ArrayList = New ArrayList()
			For i As Integer = 52 To 67
				arrayList.Add(digitalProductId(i))
			Next
			For j As Integer = 28 To 0 Step -1
				If(j + 1) Mod 6 = 0 Then
					array2(j) = "-"c
				Else
					Dim num As Integer = 0
					For k As Integer = 14 To 0 Step -1
						Dim num2 As Integer = (num << 8) Or CInt(CByte(arrayList(k)))
						arrayList(k) = CByte((num2 / 24))
						num = num2 Mod 24
						array2(j) = array(num)
					Next
				End If
			Next
			Return New String(array2)
		End Function

		' Token: 0x060001F7 RID: 503 RVA: 0x00011EC8 File Offset: 0x000100C8
		Public Function DecodeProductKeyWin8AndUp(digitalProductId As Byte()) As String
			Dim text As String = String.Empty
			digitalProductId(66) = (digitalProductId(66) And 247) Or 0
			Dim num As Integer = 0
			For i As Integer = 24 To 0 Step -1
				Dim num2 As Integer = 0
				For j As Integer = 14 To 0 Step -1
					num2 *= 256
					num2 = CInt(digitalProductId(j + 52)) + num2
					digitalProductId(j + 52) = CByte((num2 / 24))
					num2 = num2 Mod 24
					num = num2
				Next
				text = "BCDFGHJKMPQRTVWXY2346789"(num2).ToString() + text
			Next
			Dim text2 As String = text.Substring(1, num)
			Dim text3 As String = text.Substring(num + 1, text.Length - (num + 1))
			text = text2 + "N" + text3
			For k As Integer = 5 To text.Length - 1 Step 6
				text = text.Insert(k, "-")
			Next
			Return text
		End Function

		' Token: 0x02000066 RID: 102
		Public Enum DigitalProductIdVersion
			' Token: 0x040001B5 RID: 437
			UpToWindows7
			' Token: 0x040001B6 RID: 438
			Windows8AndUp
		End Enum
	End Class
End Namespace
