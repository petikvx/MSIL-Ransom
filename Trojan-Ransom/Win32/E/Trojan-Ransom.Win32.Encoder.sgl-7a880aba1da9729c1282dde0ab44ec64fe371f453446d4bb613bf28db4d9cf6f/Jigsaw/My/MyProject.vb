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

Namespace Jigsaw.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x00002670 File Offset: 0x00000870
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x0000268C File Offset: 0x0000088C
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x000026A8 File Offset: 0x000008A8
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x000026C4 File Offset: 0x000008C4
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x000026E0 File Offset: 0x000008E0
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

		' Token: 0x0200000B RID: 11
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyForms
			' Token: 0x060000CB RID: 203 RVA: 0x0000B430 File Offset: 0x00009630
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
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x060000CC RID: 204 RVA: 0x00002546 File Offset: 0x00000746
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x060000CD RID: 205 RVA: 0x0000255B File Offset: 0x0000075B
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x060000CE RID: 206 RVA: 0x0000B540 File Offset: 0x00009740
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x060000CF RID: 207 RVA: 0x0000B55C File Offset: 0x0000975C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x060000D0 RID: 208 RVA: 0x0000B574 File Offset: 0x00009774
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x060000D1 RID: 209 RVA: 0x0000B590 File Offset: 0x00009790
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000052 RID: 82
			' (get) Token: 0x060000D2 RID: 210 RVA: 0x00002563 File Offset: 0x00000763
			' (set) Token: 0x060000D5 RID: 213 RVA: 0x000025AE File Offset: 0x000007AE
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

			' Token: 0x17000053 RID: 83
			' (get) Token: 0x060000D3 RID: 211 RVA: 0x0000257C File Offset: 0x0000077C
			' (set) Token: 0x060000D6 RID: 214 RVA: 0x000025D8 File Offset: 0x000007D8
			Public Property Form2 As Form2
				<DebuggerHidden()>
				Get
					Me.m_Form2 = MyProject.MyForms.Create__Instance__(Of Form2)(Me.m_Form2)
					Return Me.m_Form2
				End Get
				<DebuggerHidden()>
				Set(value As Form2)
					If value IsNot Me.m_Form2 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form2)(Me.m_Form2)
					End If
				End Set
			End Property

			' Token: 0x17000054 RID: 84
			' (get) Token: 0x060000D4 RID: 212 RVA: 0x00002595 File Offset: 0x00000795
			' (set) Token: 0x060000D7 RID: 215 RVA: 0x00002602 File Offset: 0x00000802
			Public Property Form3 As Form3
				<DebuggerHidden()>
				Get
					Me.m_Form3 = MyProject.MyForms.Create__Instance__(Of Form3)(Me.m_Form3)
					Return Me.m_Form3
				End Get
				<DebuggerHidden()>
				Set(value As Form3)
					If value IsNot Me.m_Form3 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form3)(Me.m_Form3)
					End If
				End Set
			End Property

			' Token: 0x04000062 RID: 98
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x04000063 RID: 99
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form1 As Form1

			' Token: 0x04000064 RID: 100
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form2 As Form2

			' Token: 0x04000065 RID: 101
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form3 As Form3
		End Class

		' Token: 0x0200000C RID: 12
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices
			' Token: 0x060000D8 RID: 216 RVA: 0x0000B540 File Offset: 0x00009740
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x060000D9 RID: 217 RVA: 0x0000B55C File Offset: 0x0000975C
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x060000DA RID: 218 RVA: 0x0000B5A8 File Offset: 0x000097A8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x060000DB RID: 219 RVA: 0x0000B590 File Offset: 0x00009790
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x060000DC RID: 220 RVA: 0x0000B5C4 File Offset: 0x000097C4
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

			' Token: 0x060000DD RID: 221 RVA: 0x0000262C File Offset: 0x0000082C
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x060000DE RID: 222 RVA: 0x0000255B File Offset: 0x0000075B
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x0200000D RID: 13
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000055 RID: 85
			' (get) Token: 0x060000DF RID: 223 RVA: 0x0000B5E8 File Offset: 0x000097E8
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = New T()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x060000E0 RID: 224 RVA: 0x0000255B File Offset: 0x0000075B
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x04000066 RID: 102
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
