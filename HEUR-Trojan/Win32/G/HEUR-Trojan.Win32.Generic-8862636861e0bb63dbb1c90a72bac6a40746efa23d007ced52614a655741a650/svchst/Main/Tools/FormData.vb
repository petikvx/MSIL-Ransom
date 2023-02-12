Imports System

Namespace Main.Tools
	' Token: 0x02000015 RID: 21
	Public Class FormData
		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000088 RID: 136 RVA: 0x00002548 File Offset: 0x00000748
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00002550 File Offset: 0x00000750
		Public Property Name As String

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x0600008A RID: 138 RVA: 0x00002559 File Offset: 0x00000759
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00002561 File Offset: 0x00000761
		Public Property Value As String

		' Token: 0x0600008C RID: 140 RVA: 0x00007128 File Offset: 0x00005328
		Public Overrides Function ToString() As String
			Return String.Format("Name: {0}" & vbCrLf & "Value: {1}" & vbCrLf & "----------------------------" & vbCrLf, Me.Name, Me.Value)
		End Function
	End Class
End Namespace
