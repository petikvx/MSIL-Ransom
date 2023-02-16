Imports System
Imports System.Net

Namespace vHack_Loader
	' Token: 0x02000017 RID: 23
	Public MustInherit Class Forum
		' Token: 0x06000076 RID: 118 RVA: 0x00004F88 File Offset: 0x00003188
		Public Sub New(url As String, loginUrl As String, username As String, cookieName As String, cookieSearch As String, Optional data As String = "")
			Me._url = url
			Me.loginUrl = loginUrl
			Me.logindata = data
			Me.username = username
			Me._defaultCookieName = cookieName
			Me._defaultCookieSearch = cookieSearch
		End Sub

		' Token: 0x06000077 RID: 119
		Public MustOverride Function isLoggedIn(cookies As CookieContainer) As Boolean

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00004FBD File Offset: 0x000031BD
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00004FC5 File Offset: 0x000031C5
		Public Property logindata As String
			Get
				Return Me._logindata
			End Get
			Set(value As String)
				Me._logindata = value
			End Set
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00004FCE File Offset: 0x000031CE
		' (set) Token: 0x0600007B RID: 123 RVA: 0x00004FD6 File Offset: 0x000031D6
		Public Property url As String
			Get
				Return Me._url
			End Get
			Set(value As String)
				Me._url = value
			End Set
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00004FDF File Offset: 0x000031DF
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00004FE7 File Offset: 0x000031E7
		Public Property loginUrl As String
			Get
				Return Me._loginUrl
			End Get
			Set(value As String)
				Me._loginUrl = value
			End Set
		End Property

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600007E RID: 126 RVA: 0x00004FF0 File Offset: 0x000031F0
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00004FF8 File Offset: 0x000031F8
		Public Property username As String
			Get
				Return Me._username
			End Get
			Set(value As String)
				Me._username = value
			End Set
		End Property

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00005001 File Offset: 0x00003201
		' (set) Token: 0x06000081 RID: 129 RVA: 0x00005009 File Offset: 0x00003209
		Public Property defaultCookieName As String
			Get
				Return Me._defaultCookieName
			End Get
			Set(value As String)
				Me._defaultCookieName = value
			End Set
		End Property

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000082 RID: 130 RVA: 0x00005012 File Offset: 0x00003212
		' (set) Token: 0x06000083 RID: 131 RVA: 0x0000501A File Offset: 0x0000321A
		Public Property defaultCookieSearch As String
			Get
				Return Me._defaultCookieSearch
			End Get
			Set(value As String)
				Me._defaultCookieSearch = value
			End Set
		End Property

		' Token: 0x0400002D RID: 45
		Private _logindata As String

		' Token: 0x0400002E RID: 46
		Private _loginUrl As String

		' Token: 0x0400002F RID: 47
		Private _url As String

		' Token: 0x04000030 RID: 48
		Private _username As String

		' Token: 0x04000031 RID: 49
		Private _defaultCookieName As String

		' Token: 0x04000032 RID: 50
		Private _defaultCookieSearch As String
	End Class
End Namespace
