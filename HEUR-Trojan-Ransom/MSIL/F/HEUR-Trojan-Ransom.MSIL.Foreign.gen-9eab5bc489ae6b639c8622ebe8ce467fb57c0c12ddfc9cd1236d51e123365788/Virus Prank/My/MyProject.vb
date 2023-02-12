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

Namespace Virus_Prank.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000210C File Offset: 0x0000030C
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00002128 File Offset: 0x00000328
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C
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

		' Token: 0x02000009 RID: 9
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x0600001A RID: 26 RVA: 0x000025B0 File Offset: 0x000007B0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return New T()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x0600001B RID: 27 RVA: 0x000026D8 File Offset: 0x000008D8
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x0600001C RID: 28 RVA: 0x000026EF File Offset: 0x000008EF
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0600001D RID: 29 RVA: 0x000026FC File Offset: 0x000008FC
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600001E RID: 30 RVA: 0x0000271C File Offset: 0x0000091C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600001F RID: 31 RVA: 0x00002734 File Offset: 0x00000934
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000020 RID: 32 RVA: 0x00002750 File Offset: 0x00000950
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x1700000B RID: 11
			' (get) Token: 0x06000021 RID: 33 RVA: 0x00002768 File Offset: 0x00000968
			' (set) Token: 0x06000022 RID: 34 RVA: 0x00002783 File Offset: 0x00000983
			Public Property Form1 As Form1
				<DebuggerHidden()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerHidden()>
				Set(value As Form1)
					If value IsNot Me.m_Form1 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x0400000D RID: 13
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x0400000E RID: 14
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form1 As Form1
		End Class

		' Token: 0x0200000A RID: 10
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000023 RID: 35 RVA: 0x000027B0 File Offset: 0x000009B0
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000024 RID: 36 RVA: 0x000027D0 File Offset: 0x000009D0
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000025 RID: 37 RVA: 0x000027E8 File Offset: 0x000009E8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x06000026 RID: 38 RVA: 0x00002804 File Offset: 0x00000A04
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06000027 RID: 39 RVA: 0x0000281C File Offset: 0x00000A1C
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

			' Token: 0x06000028 RID: 40 RVA: 0x00002845 File Offset: 0x00000A45
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06000029 RID: 41 RVA: 0x000026EF File Offset: 0x000008EF
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x0200000B RID: 11
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x1700000C RID: 12
			' (get) Token: 0x0600002A RID: 42 RVA: 0x00002850 File Offset: 0x00000A50
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

			' Token: 0x0600002B RID: 43 RVA: 0x000026EF File Offset: 0x000008EF
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0400000F RID: 15
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
