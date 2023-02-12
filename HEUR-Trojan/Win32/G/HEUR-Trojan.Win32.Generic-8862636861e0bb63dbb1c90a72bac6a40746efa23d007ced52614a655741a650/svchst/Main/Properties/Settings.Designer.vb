Imports System
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace Main.Properties
	' Token: 0x02000068 RID: 104
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")>
	<CompilerGenerated()>
	Friend NotInheritable Partial Class Settings
		Inherits ApplicationSettingsBase

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x0600020A RID: 522 RVA: 0x0001222C File Offset: 0x0001042C
		Public Shared ReadOnly Property [Default] As Settings
			Get
				Return Settings.defaultInstance
			End Get
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x0600020B RID: 523 RVA: 0x00012240 File Offset: 0x00010440
		' (set) Token: 0x0600020C RID: 524 RVA: 0x00002B30 File Offset: 0x00000D30
		<UserScopedSetting()>
		<DefaultSettingValue("0")>
		<DebuggerNonUserCode()>
		Public Property doomsday As Integer
			Get
				Return CInt(Me("doomsday"))
			End Get
			Set(value As Integer)
				Me("doomsday") = value
			End Set
		End Property

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x0600020D RID: 525 RVA: 0x00012260 File Offset: 0x00010460
		' (set) Token: 0x0600020E RID: 526 RVA: 0x00002B43 File Offset: 0x00000D43
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		<UserScopedSetting()>
		Public Property EncryptionPassword As String
			Get
				Return CStr(Me("EncryptionPassword"))
			End Get
			Set(value As String)
				Me("EncryptionPassword") = value
			End Set
		End Property

		' Token: 0x040001B9 RID: 441
		Private Shared defaultInstance As Settings = CType(SettingsBase.Synchronized(New Settings()), Settings)
	End Class
End Namespace
