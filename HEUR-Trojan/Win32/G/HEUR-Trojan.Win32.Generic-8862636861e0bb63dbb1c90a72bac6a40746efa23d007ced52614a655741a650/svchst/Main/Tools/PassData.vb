Imports System

Namespace Main.Tools
	' Token: 0x0200001E RID: 30
	Public Class PassData
		' Token: 0x17000015 RID: 21
		' (get) Token: 0x060000B4 RID: 180 RVA: 0x0000263C File Offset: 0x0000083C
		' (set) Token: 0x060000B5 RID: 181 RVA: 0x00002644 File Offset: 0x00000844
		Public Property Url As String

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x0000264D File Offset: 0x0000084D
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x00002655 File Offset: 0x00000855
		Public Property Login As String

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x060000B8 RID: 184 RVA: 0x0000265E File Offset: 0x0000085E
		' (set) Token: 0x060000B9 RID: 185 RVA: 0x00002666 File Offset: 0x00000866
		Public Property Password As String

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x060000BA RID: 186 RVA: 0x0000266F File Offset: 0x0000086F
		' (set) Token: 0x060000BB RID: 187 RVA: 0x00002677 File Offset: 0x00000877
		Public Property Program As String

		' Token: 0x060000BC RID: 188 RVA: 0x00007BCC File Offset: 0x00005DCC
		Public Overrides Function ToString() As String
			Return String.Format("Website: {0}" & vbCrLf & "Login: {1}" & vbCrLf & "Password: {2}" & vbCrLf & "Browser : {3}" & vbCrLf & "----------------------" & vbCrLf, New Object() { Me.Url, Me.Login, Me.Password, Me.Program })
		End Function
	End Class
End Namespace
