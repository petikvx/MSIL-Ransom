Imports System

Namespace Main.Tools
	' Token: 0x02000012 RID: 18
	Public Class CookieData
		' Token: 0x1700000B RID: 11
		' (get) Token: 0x0600005B RID: 91 RVA: 0x0000247E File Offset: 0x0000067E
		' (set) Token: 0x0600005C RID: 92 RVA: 0x00002486 File Offset: 0x00000686
		Public Property host_key As String

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x0600005D RID: 93 RVA: 0x0000248F File Offset: 0x0000068F
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00002497 File Offset: 0x00000697
		Public Property name As String

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x0600005F RID: 95 RVA: 0x000024A0 File Offset: 0x000006A0
		' (set) Token: 0x06000060 RID: 96 RVA: 0x000024A8 File Offset: 0x000006A8
		Public Property value As String

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000061 RID: 97 RVA: 0x000024B1 File Offset: 0x000006B1
		' (set) Token: 0x06000062 RID: 98 RVA: 0x000024B9 File Offset: 0x000006B9
		Public Property path As String

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000063 RID: 99 RVA: 0x000024C2 File Offset: 0x000006C2
		' (set) Token: 0x06000064 RID: 100 RVA: 0x000024CA File Offset: 0x000006CA
		Public Property expires_utc As String

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x06000065 RID: 101 RVA: 0x000024D3 File Offset: 0x000006D3
		' (set) Token: 0x06000066 RID: 102 RVA: 0x000024DB File Offset: 0x000006DB
		Public Property secure As String

		' Token: 0x06000067 RID: 103 RVA: 0x00006368 File Offset: 0x00004568
		Public Overrides Function ToString() As String
			Return String.Format("{0}" & vbTab & "FALSE" & vbTab & "{1}" & vbTab & "{2}" & vbTab & "{3}" & vbTab & "{4}" & vbTab & "{5}" & vbCrLf, New Object() { Me.host_key, Me.path, Me.secure.ToUpper(), Me.expires_utc, Me.name, Me.value })
		End Function
	End Class
End Namespace
