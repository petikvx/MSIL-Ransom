Namespace WeCry_2._0
	' Token: 0x02000009 RID: 9
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form2
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000062 RID: 98 RVA: 0x000054B8 File Offset: 0x000036B8
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

		' Token: 0x06000063 RID: 99 RVA: 0x00005508 File Offset: 0x00003708
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.ListBox1 = New Global.System.Windows.Forms.ListBox()
			MyBase.SuspendLayout()
			Me.ListBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.ListBox1.FormattingEnabled = True
			Me.ListBox1.Location = New Global.System.Drawing.Point(0, 0)
			Me.ListBox1.Name = "ListBox1"
			Me.ListBox1.Size = New Global.System.Drawing.Size(409, 453)
			Me.ListBox1.TabIndex = 0
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(409, 453)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.ListBox1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.SizableToolWindow
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Form2"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "Debugging"
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000039 RID: 57
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
