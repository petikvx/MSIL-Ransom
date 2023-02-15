Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace w.My
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000004 RID: 4 RVA: 0x00002090 File Offset: 0x00000290
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000005 RID: 5 RVA: 0x000020AC File Offset: 0x000002AC
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000006 RID: 6 RVA: 0x000020C8 File Offset: 0x000002C8
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000007 RID: 7 RVA: 0x000020E4 File Offset: 0x000002E4
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000002 RID: 2
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000003 RID: 3
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000008 RID: 8 RVA: 0x00002100 File Offset: 0x00000300
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000009 RID: 9 RVA: 0x00002120 File Offset: 0x00000320
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600000A RID: 10 RVA: 0x00002138 File Offset: 0x00000338
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x0600000B RID: 11 RVA: 0x00002154 File Offset: 0x00000354
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600000C RID: 12 RVA: 0x0000216C File Offset: 0x0000036C
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim t As T
				If flag Then
					t = New T()
				Else
					t = instance
				End If
				Return t
			End Function

			' Token: 0x0600000D RID: 13 RVA: 0x00002198 File Offset: 0x00000398
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x0600000E RID: 14 RVA: 0x000021B6 File Offset: 0x000003B6
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000006 RID: 6
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000005 RID: 5
			' (get) Token: 0x0600000F RID: 15 RVA: 0x000021C4 File Offset: 0x000003C4
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = New T()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06000010 RID: 16 RVA: 0x000021F6 File Offset: 0x000003F6
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x04000005 RID: 5
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
