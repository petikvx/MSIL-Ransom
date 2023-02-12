Namespace Virus_Prank
	' Token: 0x02000008 RID: 8
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000016 RID: 22 RVA: 0x0000245C File Offset: 0x0000065C
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000017 RID: 23 RVA: 0x000024AC File Offset: 0x000006AC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			MyBase.SuspendLayout()
			Me.Timer1.Enabled = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(284, 262)
			MyBase.Name = "Form1"
			MyBase.Opacity = 0.0
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "Form1"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400000B RID: 11
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
