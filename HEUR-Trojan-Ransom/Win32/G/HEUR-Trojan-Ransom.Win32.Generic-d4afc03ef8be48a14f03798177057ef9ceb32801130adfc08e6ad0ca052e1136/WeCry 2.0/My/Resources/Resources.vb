Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WeCry_2._0.My.Resources
	' Token: 0x02000005 RID: 5
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	Public NotInheritable Module Resources
		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00002198 File Offset: 0x00000398
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Public ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("WeCry_2._0.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000C RID: 12 RVA: 0x000021E0 File Offset: 0x000003E0
		' (set) Token: 0x0600000D RID: 13 RVA: 0x000021F7 File Offset: 0x000003F7
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Public Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600000E RID: 14 RVA: 0x00002200 File Offset: 0x00000400
		Public ReadOnly Property _WanaDecryptor__0000 As Icon
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_WanaDecryptor__0000", Resources.resourceCulture))
				Return CType(objectValue, Icon)
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x0600000F RID: 15 RVA: 0x00002234 File Offset: 0x00000434
		Public ReadOnly Property led_counter As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("led_counter", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000010 RID: 16 RVA: 0x00002268 File Offset: 0x00000468
		Public ReadOnly Property wannacry_05_1024x774 As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("wannacry_05_1024x774", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000011 RID: 17 RVA: 0x0000229C File Offset: 0x0000049C
		Public ReadOnly Property wannacry_wallpaper As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("wannacry_wallpaper", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x04000006 RID: 6
		Private resourceMan As ResourceManager

		' Token: 0x04000007 RID: 7
		Private resourceCulture As CultureInfo
	End Module
End Namespace
