Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace vHack_Loader.My
	' Token: 0x02000002 RID: 2
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase

		' Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		<STAThread()>
		<DebuggerHidden()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Friend Shared Sub Main(Args As String())
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			MyProject.Application.Run(Args)
		End Sub

		' Token: 0x06000002 RID: 2 RVA: 0x00002067 File Offset: 0x00000267
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			MyBase.IsSingleInstance = False
			MyBase.EnableVisualStyles = True
			MyBase.SaveMySettingsOnExit = True
			MyBase.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x0000208C File Offset: 0x0000028C
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			MyBase.MainForm = MyProject.Forms.Login
		End Sub
	End Class
End Namespace
