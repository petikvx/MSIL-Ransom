Imports System
Imports System.Net
Imports Microsoft.VisualBasic

Namespace vHack_Loader
	' Token: 0x0200001E RID: 30
	Public Class myBB
		Inherits Forum

		' Token: 0x06000146 RID: 326 RVA: 0x00008C04 File Offset: 0x00006E04
		Public Sub New(url As String, username As String, password As String)
			MyBase.New(url, url + "/member.php?action=login", username, "mybbuser", "", String.Concat(New String() { "username=", username, "&password=", password, "&submit=Login&action=do_login&url=" }))
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x00008C5C File Offset: 0x00006E5C
		Public Overrides Function isLoggedIn(cookies As CookieContainer) As Boolean
			Return Not Information.IsNothing(cookies.GetCookies(New Uri(MyBase.url))(MyBase.defaultCookieName))
		End Function
	End Class
End Namespace
