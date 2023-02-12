Imports System
Imports System.Text

Namespace Main.Tools
	' Token: 0x02000055 RID: 85
	Friend Class Account
		' Token: 0x17000029 RID: 41
		' (get) Token: 0x060001BC RID: 444 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		' (set) Token: 0x060001BD RID: 445 RVA: 0x00002A47 File Offset: 0x00000C47
		Public Property Username As String
			Get
				Return Me._username
			End Get
			Set(value As String)
				Me._username = value
			End Set
		End Property

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x060001BE RID: 446 RVA: 0x0000FB54 File Offset: 0x0000DD54
		' (set) Token: 0x060001BF RID: 447 RVA: 0x00002A50 File Offset: 0x00000C50
		Public Property Password As String
			Get
				Return Me._password
			End Get
			Set(value As String)
				Me._password = value
			End Set
		End Property

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x060001C0 RID: 448 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		' (set) Token: 0x060001C1 RID: 449 RVA: 0x00002A59 File Offset: 0x00000C59
		Public Property Domain As String
			Get
				Return Me._domain
			End Get
			Set(value As String)
				Me._domain = value
			End Set
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x060001C2 RID: 450 RVA: 0x0000FB84 File Offset: 0x0000DD84
		' (set) Token: 0x060001C3 RID: 451 RVA: 0x00002A62 File Offset: 0x00000C62
		Public Property Type As AccountType
			Get
				Return Me._type
			End Get
			Set(value As AccountType)
				Me._type = value
			End Set
		End Property

		' Token: 0x060001C4 RID: 452 RVA: 0x00002A6B File Offset: 0x00000C6B
		Public Sub New(Type As AccountType, Username As String, Password As String)
			Me.Type = Type
			Me.Username = Username
			Me.Password = Password
		End Sub

		' Token: 0x060001C5 RID: 453 RVA: 0x00002A88 File Offset: 0x00000C88
		Public Sub New(Type As AccountType, Username As String, Password As String, Domain As String)
			Me.Type = Type
			Me.Username = Username
			Me.Password = Password
			Me.Domain = Domain
		End Sub

		' Token: 0x060001C6 RID: 454 RVA: 0x00002AAD File Offset: 0x00000CAD
		Public Sub New(Type As AccountType)
			Me.Type = Type
		End Sub

		' Token: 0x060001C7 RID: 455 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		Public Overrides Function ToString() As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			stringBuilder.AppendLine("PREC.Account {")
			stringBuilder.AppendLine("Type:        " + Me.Type.ToString())
			stringBuilder.AppendLine("Domain:      " + Me.Domain)
			stringBuilder.AppendLine("Username:    " + Me.Username)
			stringBuilder.AppendLine("Password:    " + Me.Password)
			stringBuilder.AppendLine("}")
			Return stringBuilder.ToString()
		End Function

		' Token: 0x04000186 RID: 390
		Private _username As String

		' Token: 0x04000187 RID: 391
		Private _password As String

		' Token: 0x04000188 RID: 392
		Private _domain As String

		' Token: 0x04000189 RID: 393
		Private _type As AccountType
	End Class
End Namespace
