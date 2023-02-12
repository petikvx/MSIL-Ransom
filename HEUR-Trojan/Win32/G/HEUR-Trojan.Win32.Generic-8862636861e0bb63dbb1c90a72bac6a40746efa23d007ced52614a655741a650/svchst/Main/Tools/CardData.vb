Imports System

Namespace Main.Tools
	' Token: 0x02000011 RID: 17
	Public Class CardData
		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00002429 File Offset: 0x00000629
		' (set) Token: 0x06000050 RID: 80 RVA: 0x00002431 File Offset: 0x00000631
		Public Property Name As String

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x06000051 RID: 81 RVA: 0x0000243A File Offset: 0x0000063A
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00002442 File Offset: 0x00000642
		Public Property Exp_m As String

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x06000053 RID: 83 RVA: 0x0000244B File Offset: 0x0000064B
		' (set) Token: 0x06000054 RID: 84 RVA: 0x00002453 File Offset: 0x00000653
		Public Property Exp_y As String

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000055 RID: 85 RVA: 0x0000245C File Offset: 0x0000065C
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00002464 File Offset: 0x00000664
		Public Property Number As String

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000057 RID: 87 RVA: 0x0000246D File Offset: 0x0000066D
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00002475 File Offset: 0x00000675
		Public Property Billing As String

		' Token: 0x06000059 RID: 89 RVA: 0x0000631C File Offset: 0x0000451C
		Public Overrides Function ToString() As String
			Return String.Format("{0}" & vbTab & "{1}/{2}" & vbTab & "{3}" & vbTab & "{4}" & vbCrLf & "******************************" & vbCrLf, New Object() { Me.Name, Me.Exp_m, Me.Exp_y, Me.Number, Me.Billing })
		End Function
	End Class
End Namespace
