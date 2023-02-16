Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader.My
	' Token: 0x02000007 RID: 7
	<HideModuleName()>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000017 RID: 23 RVA: 0x000022AC File Offset: 0x000004AC
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
