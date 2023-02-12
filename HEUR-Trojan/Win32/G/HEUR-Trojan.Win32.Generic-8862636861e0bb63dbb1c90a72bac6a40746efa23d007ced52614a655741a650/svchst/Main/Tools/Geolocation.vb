Imports System
Imports System.Net
Imports System.Text.RegularExpressions

Namespace Main.Tools
	' Token: 0x02000016 RID: 22
	Public Class Geolocation
		' Token: 0x0600008E RID: 142 RVA: 0x000023D2 File Offset: 0x000005D2
		Public Sub New()
		End Sub

		' Token: 0x0600008F RID: 143 RVA: 0x0000256A File Offset: 0x0000076A
		Public Sub New(country As String, city As String)
			Me.Country = country
			Me.City = city
		End Sub

		' Token: 0x06000090 RID: 144 RVA: 0x00007150 File Offset: 0x00005350
		Public Shared Function GetLocation() As Geolocation
			Return Geolocation.GetLocation(String.Empty)
		End Function

		' Token: 0x06000091 RID: 145 RVA: 0x0000716C File Offset: 0x0000536C
		Public Shared Function GetLocation(ip As String) As Geolocation
			Dim geolocation2 As Geolocation
			Try
				Dim text As String = "http://checkip.dyndns.org"
				Dim text2 As String = "http://www.geoplugin.net/xml.gp?ip="
				If String.IsNullOrEmpty(ip) Then
					Using webClient As WebClient = New WebClient()
						ip = webClient.DownloadString(text)
						Dim match As Match = Regex.Match(ip, "\:\s+([^<]+)", RegexOptions.IgnoreCase)
						If match.Success Then
							ip = match.Groups(1).Value
						End If
					End Using
				End If
				Dim geolocation As Geolocation = New Geolocation()
				Using webClient2 As WebClient = New WebClient()
					Dim text3 As String = webClient2.DownloadString(text2 + ip)
					Dim match As Match = Regex.Match(text3, "countryName>([^<]+)", RegexOptions.IgnoreCase)
					If match.Success Then
						geolocation.Country = match.Groups(1).Value
					End If
					match = Regex.Match(text3, "city>([^<]+)", RegexOptions.IgnoreCase)
					If match.Success Then
						geolocation.City = match.Groups(1).Value
					End If
					If geolocation.City Is Nothing AndAlso geolocation.Country = Nothing Then
						geolocation2 = Nothing
					Else
						geolocation2 = geolocation
					End If
				End Using
			Catch
				geolocation2 = Nothing
			End Try
			Return geolocation2
		End Function

		' Token: 0x0400009A RID: 154
		Public City As String

		' Token: 0x0400009B RID: 155
		Public Country As String
	End Class
End Namespace
