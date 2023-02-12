Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace Jigsaw.My
	' Token: 0x02000002 RID: 2
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase

		' Token: 0x06000001 RID: 1 RVA: 0x00002638 File Offset: 0x00000838
		<STAThread()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerHidden()>
		<MethodImpl(MethodImplOptions.NoOptimization)>
		Friend Shared Sub Main(args As String())
			Try
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Finally
			End Try
			MyProject.Application.Run(args)
		End Sub

		' Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			MyBase.IsSingleInstance = False
			MyBase.EnableVisualStyles = True
			MyBase.SaveMySettingsOnExit = True
			MyBase.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x00002075 File Offset: 0x00000275
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			MyBase.MainForm = MyProject.Forms.Form2
		End Sub
	End Class
End Namespace
