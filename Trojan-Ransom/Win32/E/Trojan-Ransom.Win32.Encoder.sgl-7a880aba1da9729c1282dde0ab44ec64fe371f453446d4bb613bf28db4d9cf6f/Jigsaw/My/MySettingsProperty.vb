Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Jigsaw.My
	' Token: 0x02000007 RID: 7
	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000013 RID: 19 RVA: 0x00002820 File Offset: 0x00000A20
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
