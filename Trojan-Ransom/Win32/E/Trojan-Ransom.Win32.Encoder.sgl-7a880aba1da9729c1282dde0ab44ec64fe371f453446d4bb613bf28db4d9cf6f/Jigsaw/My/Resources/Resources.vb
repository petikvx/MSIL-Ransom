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

Namespace Jigsaw.My.Resources
	' Token: 0x02000005 RID: 5
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	<HideModuleName()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	Friend NotInheritable Module Resources
		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000B RID: 11 RVA: 0x000026FC File Offset: 0x000008FC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim resourceManager As ResourceManager = New ResourceManager("Jigsaw.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00002740 File Offset: 0x00000940
		' (set) Token: 0x0600000D RID: 13 RVA: 0x000020C3 File Offset: 0x000002C3
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
		' (get) Token: 0x0600000E RID: 14 RVA: 0x00002754 File Offset: 0x00000954
		Friend ReadOnly Property Jigsaw As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Jigsaw", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x04000006 RID: 6
		Private resourceMan As ResourceManager

		' Token: 0x04000007 RID: 7
		Private resourceCulture As CultureInfo
	End Module
End Namespace
