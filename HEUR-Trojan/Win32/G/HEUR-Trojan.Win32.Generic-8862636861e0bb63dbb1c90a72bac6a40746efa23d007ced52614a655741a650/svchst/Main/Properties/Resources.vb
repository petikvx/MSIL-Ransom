Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace Main.Properties
	' Token: 0x02000067 RID: 103
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	Friend Class Resources
		' Token: 0x060001F9 RID: 505 RVA: 0x000023D2 File Offset: 0x000005D2
		Friend Sub New()
		End Sub

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x060001FA RID: 506 RVA: 0x00011FBC File Offset: 0x000101BC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared ReadOnly Property ResourceManager As ResourceManager
			Get
				If Resources.resourceMan Is Nothing Then
					Dim resourceManager As ResourceManager = New ResourceManager("Main.Properties.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x060001FB RID: 507 RVA: 0x00011FFC File Offset: 0x000101FC
		' (set) Token: 0x060001FC RID: 508 RVA: 0x00002B28 File Offset: 0x00000D28
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x060001FD RID: 509 RVA: 0x00012010 File Offset: 0x00010210
		Friend Shared ReadOnly Property ExtensionsToEncrypt As String
			Get
				Return Resources.ResourceManager.GetString("ExtensionsToEncrypt", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x060001FE RID: 510 RVA: 0x00012034 File Offset: 0x00010234
		Friend Shared ReadOnly Property Ionic_Zip As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("Ionic_Zip", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x060001FF RID: 511 RVA: 0x00012060 File Offset: 0x00010260
		Friend Shared ReadOnly Property kernelbas32 As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("kernelbas32", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x06000200 RID: 512 RVA: 0x0001208C File Offset: 0x0001028C
		Friend Shared ReadOnly Property lvl_x64 As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("lvl_x64", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000201 RID: 513 RVA: 0x000120B8 File Offset: 0x000102B8
		Friend Shared ReadOnly Property lvl_x86 As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("lvl_x86", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000202 RID: 514 RVA: 0x000120E4 File Offset: 0x000102E4
		Friend Shared ReadOnly Property Newtonsoft_Json As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("Newtonsoft_Json", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000203 RID: 515 RVA: 0x00012110 File Offset: 0x00010310
		Friend Shared ReadOnly Property registration As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("registration", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000204 RID: 516 RVA: 0x0001213C File Offset: 0x0001033C
		Friend Shared ReadOnly Property registration1 As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("registration1", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x06000205 RID: 517 RVA: 0x00012168 File Offset: 0x00010368
		Friend Shared ReadOnly Property SkinSoft_VisualStyler As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("SkinSoft_VisualStyler", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x06000206 RID: 518 RVA: 0x00012194 File Offset: 0x00010394
		Friend Shared ReadOnly Property smtp As String
			Get
				Return Resources.ResourceManager.GetString("smtp", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000207 RID: 519 RVA: 0x000121B8 File Offset: 0x000103B8
		Friend Shared ReadOnly Property StartModeDebug As String
			Get
				Return Resources.ResourceManager.GetString("StartModeDebug", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000208 RID: 520 RVA: 0x000121DC File Offset: 0x000103DC
		Friend Shared ReadOnly Property USBStarter As Byte()
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject("USBStarter", Resources.resourceCulture)
				Return CType([object], Byte())
			End Get
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000209 RID: 521 RVA: 0x00012208 File Offset: 0x00010408
		Friend Shared ReadOnly Property vanityAddresses As String
			Get
				Return Resources.ResourceManager.GetString("vanityAddresses", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x040001B7 RID: 439
		Private Shared resourceMan As ResourceManager

		' Token: 0x040001B8 RID: 440
		Private Shared resourceCulture As CultureInfo
	End Class
End Namespace
