Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x000020DA File Offset: 0x000002DA
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x000020E6 File Offset: 0x000002E6
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x000020F2 File Offset: 0x000002F2
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x000020FE File Offset: 0x000002FE
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000210A File Offset: 0x0000030A
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
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000005 RID: 5
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000021 RID: 33
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x06000168 RID: 360 RVA: 0x0000999C File Offset: 0x00007B9C
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				If Instance Is Nothing OrElse Instance.IsDisposed Then
					If MyProject.MyForms.m_FormBeingCreated IsNot Nothing Then
						If MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return New T()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x06000169 RID: 361 RVA: 0x00009AA0 File Offset: 0x00007CA0
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x0600016A RID: 362 RVA: 0x000024D7 File Offset: 0x000006D7
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0600016B RID: 363 RVA: 0x00009AB5 File Offset: 0x00007CB5
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600016C RID: 364 RVA: 0x00009AC3 File Offset: 0x00007CC3
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600016D RID: 365 RVA: 0x00009ACB File Offset: 0x00007CCB
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x0600016E RID: 366 RVA: 0x00009AD7 File Offset: 0x00007CD7
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000062 RID: 98
			' (get) Token: 0x0600016F RID: 367 RVA: 0x00009ADF File Offset: 0x00007CDF
			' (set) Token: 0x06000173 RID: 371 RVA: 0x00009B43 File Offset: 0x00007D43
			Public Property Login As Login
				Get
					Me.m_Login = MyProject.MyForms.Create__Instance__(Of Login)(Me.m_Login)
					Return Me.m_Login
				End Get
				Set(value As Login)
					If value IsNot Me.m_Login Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Login)(Me.m_Login)
					End If
				End Set
			End Property

			' Token: 0x17000063 RID: 99
			' (get) Token: 0x06000170 RID: 368 RVA: 0x00009AF8 File Offset: 0x00007CF8
			' (set) Token: 0x06000174 RID: 372 RVA: 0x00009B68 File Offset: 0x00007D68
			Public Property Main As Main
				Get
					Me.m_Main = MyProject.MyForms.Create__Instance__(Of Main)(Me.m_Main)
					Return Me.m_Main
				End Get
				Set(value As Main)
					If value IsNot Me.m_Main Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Main)(Me.m_Main)
					End If
				End Set
			End Property

			' Token: 0x17000064 RID: 100
			' (get) Token: 0x06000171 RID: 369 RVA: 0x00009B11 File Offset: 0x00007D11
			' (set) Token: 0x06000175 RID: 373 RVA: 0x00009B8D File Offset: 0x00007D8D
			Public Property motd As motd
				Get
					Me.m_motd = MyProject.MyForms.Create__Instance__(Of motd)(Me.m_motd)
					Return Me.m_motd
				End Get
				Set(value As motd)
					If value IsNot Me.m_motd Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of motd)(Me.m_motd)
					End If
				End Set
			End Property

			' Token: 0x17000065 RID: 101
			' (get) Token: 0x06000172 RID: 370 RVA: 0x00009B2A File Offset: 0x00007D2A
			' (set) Token: 0x06000176 RID: 374 RVA: 0x00009BB2 File Offset: 0x00007DB2
			Public Property Updater As Updater
				Get
					Me.m_Updater = MyProject.MyForms.Create__Instance__(Of Updater)(Me.m_Updater)
					Return Me.m_Updater
				End Get
				Set(value As Updater)
					If value IsNot Me.m_Updater Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Updater)(Me.m_Updater)
					End If
				End Set
			End Property

			' Token: 0x04000096 RID: 150
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x04000097 RID: 151
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Login As Login

			' Token: 0x04000098 RID: 152
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Main As Main

			' Token: 0x04000099 RID: 153
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_motd As motd

			' Token: 0x0400009A RID: 154
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Updater As Updater
		End Class

		' Token: 0x02000022 RID: 34
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000177 RID: 375 RVA: 0x00009AB5 File Offset: 0x00007CB5
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000178 RID: 376 RVA: 0x00009AC3 File Offset: 0x00007CC3
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000179 RID: 377 RVA: 0x00009BD7 File Offset: 0x00007DD7
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x0600017A RID: 378 RVA: 0x00009AD7 File Offset: 0x00007CD7
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600017B RID: 379 RVA: 0x00009BE4 File Offset: 0x00007DE4
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim t As T
				If instance Is Nothing Then
					t = New T()
				Else
					t = instance
				End If
				Return t
			End Function

			' Token: 0x0600017C RID: 380 RVA: 0x00009C04 File Offset: 0x00007E04
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x0600017D RID: 381 RVA: 0x000024D7 File Offset: 0x000006D7
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000023 RID: 35
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000066 RID: 102
			' (get) Token: 0x0600017E RID: 382 RVA: 0x00009C0D File Offset: 0x00007E0D
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = New T()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x0600017F RID: 383 RVA: 0x000024D7 File Offset: 0x000006D7
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0400009B RID: 155
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
