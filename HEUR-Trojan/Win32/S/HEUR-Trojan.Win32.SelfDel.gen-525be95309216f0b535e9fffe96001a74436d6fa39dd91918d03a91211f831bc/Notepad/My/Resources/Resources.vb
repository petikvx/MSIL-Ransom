Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader.My.Resources
	' Token: 0x02000005 RID: 5
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	Friend NotInheritable Module Resources
		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00002116 File Offset: 0x00000316
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Resources.resourceMan = New ResourceManager("vHack_Loader.Resources", GetType(Resources).Assembly)
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00002148 File Offset: 0x00000348
		' (set) Token: 0x0600000D RID: 13 RVA: 0x0000214F File Offset: 0x0000034F
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600000E RID: 14 RVA: 0x00002157 File Offset: 0x00000357
		Friend ReadOnly Property _7 As Byte()
			Get
				Return CType(RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_7", Resources.resourceCulture)), Byte())
			End Get
		End Property

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x0600000F RID: 15 RVA: 0x00002177 File Offset: 0x00000377
		Friend ReadOnly Property _8 As Byte()
			Get
				Return CType(RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("_8", Resources.resourceCulture)), Byte())
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000010 RID: 16 RVA: 0x00002197 File Offset: 0x00000397
		Friend ReadOnly Property Clean As Byte()
			Get
				Return CType(RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Clean", Resources.resourceCulture)), Byte())
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000011 RID: 17 RVA: 0x000021B7 File Offset: 0x000003B7
		Friend ReadOnly Property cloud As Byte()
			Get
				Return CType(RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("cloud", Resources.resourceCulture)), Byte())
			End Get
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000012 RID: 18 RVA: 0x000021D7 File Offset: 0x000003D7
		Friend ReadOnly Property MrsnapzNet As Byte()
			Get
				Return CType(RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("MrsnapzNet", Resources.resourceCulture)), Byte())
			End Get
		End Property

		' Token: 0x04000006 RID: 6
		Private resourceMan As ResourceManager

		' Token: 0x04000007 RID: 7
		Private resourceCulture As CultureInfo
	End Module
End Namespace
