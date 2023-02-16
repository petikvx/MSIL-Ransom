Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WeCry_2._0.My
	' Token: 0x02000007 RID: 7
	<HideModuleName()>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000016 RID: 22 RVA: 0x000023B4 File Offset: 0x000005B4
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
