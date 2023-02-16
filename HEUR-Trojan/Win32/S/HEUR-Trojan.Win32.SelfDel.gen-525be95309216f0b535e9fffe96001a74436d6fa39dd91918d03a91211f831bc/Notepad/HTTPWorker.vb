Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Namespace vHack_Loader
	' Token: 0x02000019 RID: 25
	Public Class HTTPWorker
		' Token: 0x0600008A RID: 138 RVA: 0x00005158 File Offset: 0x00003358
		Public Function login(forumInstance As Forum) As Boolean
			HTTPWorker.cookies = New CookieContainer()
			Try
				Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(forumInstance.loginUrl), HttpWebRequest)
				Me.setConnectionParameters(httpWebRequest)
				Me.data = Encoding.ASCII.GetBytes(forumInstance.logindata)
				httpWebRequest.ContentLength = CLng(Me.data.Length)
				Dim requestStream As Stream = httpWebRequest.GetRequestStream()
				requestStream.Write(Me.data, 0, Me.data.Length)
				requestStream.Flush()
				requestStream.Close()
				Dim httpWebResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
				If forumInstance.isLoggedIn(HTTPWorker.cookies) Then
					Return True
				End If
			Catch ex As Exception
			End Try
			Return False
		End Function

		' Token: 0x0600008B RID: 139 RVA: 0x00005214 File Offset: 0x00003414
		Public Sub setConnectionParameters(ByRef request As HttpWebRequest)
			Dim httpWebRequest As HttpWebRequest = request
			httpWebRequest.Method = "POST"
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
			httpWebRequest.ContentType = "application/x-www-form-urlencoded"
			httpWebRequest.Proxy = Nothing
			httpWebRequest.CookieContainer = HTTPWorker.cookies
			httpWebRequest.KeepAlive = True
			httpWebRequest.ServicePoint.Expect100Continue = False
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8) Gecko/20051111 Firefox/1.5; FBI-version/0.07"
		End Sub

		' Token: 0x0600008C RID: 140 RVA: 0x00005275 File Offset: 0x00003475
		Public Sub navTo()
		End Sub

		' Token: 0x04000035 RID: 53
		Public Shared cookies As CookieContainer

		' Token: 0x04000036 RID: 54
		Private data As Byte()
	End Class
End Namespace
