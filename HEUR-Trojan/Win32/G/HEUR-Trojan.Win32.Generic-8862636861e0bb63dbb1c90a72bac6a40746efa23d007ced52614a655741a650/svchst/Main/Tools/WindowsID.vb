Imports System
Imports System.Management
Imports System.Security.Cryptography
Imports System.Text

Namespace Main.Tools
	' Token: 0x0200002B RID: 43
	Friend Class WindowsID
		' Token: 0x060000E8 RID: 232 RVA: 0x00009650 File Offset: 0x00007850
		Public Shared Function getWindowsID() As String
			Return WindowsID.WindowsId()
		End Function

		' Token: 0x060000E9 RID: 233 RVA: 0x00009664 File Offset: 0x00007864
		Private Shared Function WindowsId() As String
			Dim text As String = ""
			Dim managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_OperatingSystem")
			Dim managementObjectCollection As ManagementObjectCollection = managementObjectSearcher.[Get]()
			Dim flag As Boolean = Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))
			Using enumerator As ManagementObjectCollection.ManagementObjectEnumerator = managementObjectCollection.GetEnumerator()
				If enumerator.MoveNext() Then
					Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
					text = managementObject.Properties("Caption").Value.ToString() + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") + managementObject.Properties("Version").Value.ToString()
				End If
			End Using
			text.Replace(" ", "")
			text.Replace("Windows", "")
			text.Replace("windows", "")
			text += If(flag, ":64", "=32")
			Dim md As MD5 = MD5.Create()
			Dim array As Byte() = md.ComputeHash(Encoding.[Default].GetBytes(text))
			Dim text2 As String = BitConverter.ToString(array)
			Return text2.Replace("-", "")
		End Function
	End Class
End Namespace
