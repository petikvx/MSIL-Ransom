Imports System
Imports System.Net

Namespace Main.Tools
	' Token: 0x02000060 RID: 96
	Friend Class VisitWebSite
		' Token: 0x060001E7 RID: 487 RVA: 0x000024E4 File Offset: 0x000006E4
		Public Shared Sub visitWebsite()
		End Sub

		' Token: 0x060001E8 RID: 488 RVA: 0x0001197C File Offset: 0x0000FB7C
		Public Shared Sub DoVisitWebSite(Optional url As String = "http://www.anywebsite.com")
			Try
				Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
				httpWebRequest.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A"
				httpWebRequest.AllowAutoRedirect = True
				httpWebRequest.Timeout = 10000
				httpWebRequest.Method = "GET"
				Using CType(httpWebRequest.GetResponse(), HttpWebResponse)
				End Using
			Catch
			End Try
		End Sub
	End Class
End Namespace
