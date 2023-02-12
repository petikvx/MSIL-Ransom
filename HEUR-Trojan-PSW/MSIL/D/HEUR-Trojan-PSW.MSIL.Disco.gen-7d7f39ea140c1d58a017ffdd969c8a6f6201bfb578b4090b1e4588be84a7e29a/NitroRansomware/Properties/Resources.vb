Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports dg3ypDAonQcOidMs0w
Imports rE4lpnT863QnijKQK5
Imports zlqCXdcKao7YZQAGFe

Namespace NitroRansomware.Properties
	' Token: 0x0200000D RID: 13
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")>
	<DebuggerNonUserCode()>
	Friend Class Resources
		' Token: 0x06000047 RID: 71 RVA: 0x00002243 File Offset: 0x00000443
		Friend Sub New()
			hHEYokUTtehNq5ji0d.LQgF529zBT6Ox()
			MyBase..ctor()
		End Sub

		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000048 RID: 72 RVA: 0x000050FC File Offset: 0x000032FC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared ReadOnly Property ResourceManager As ResourceManager
			Get
				If Resources.resourceMan Is Nothing Then
					Dim resourceManager As ResourceManager = New ResourceManager("NitroRansomware.Properties.Resources", Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554445)).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000049 RID: 73 RVA: 0x00005140 File Offset: 0x00003340
		' (set) Token: 0x0600004A RID: 74 RVA: 0x00002419 File Offset: 0x00000619
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600004B RID: 75 RVA: 0x00005154 File Offset: 0x00003354
		Friend Shared ReadOnly Property wl As Bitmap
			Get
				Dim [object] As Object = Resources.ResourceManager.GetObject(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5600), Resources.resourceCulture)
				Return CType([object], Bitmap)
			End Get
		End Property

		' Token: 0x0600004C RID: 76 RVA: 0x0000223C File Offset: 0x0000043C
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw()
		End Sub

		' Token: 0x0400003F RID: 63
		Private Shared resourceMan As ResourceManager

		' Token: 0x04000040 RID: 64
		Private Shared resourceCulture As CultureInfo
	End Class
End Namespace
