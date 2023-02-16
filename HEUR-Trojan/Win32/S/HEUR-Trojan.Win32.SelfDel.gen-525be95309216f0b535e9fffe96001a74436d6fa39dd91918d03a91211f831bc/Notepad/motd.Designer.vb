Namespace vHack_Loader
	' Token: 0x0200001D RID: 29
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class motd
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600013A RID: 314 RVA: 0x000087F4 File Offset: 0x000069F4
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x0600013B RID: 315 RVA: 0x00008834 File Offset: 0x00006A34
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.vHack_Loader.motd))
			Me.ExcisionTheme1 = New Global.vHack_Loader.ExcisionTheme()
			Me.ExcisionButtonDefault1 = New Global.vHack_Loader.ExcisionButtonDefault()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.ExcisionTheme1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ExcisionTheme1.BackColor = Global.System.Drawing.Color.FromArgb(25, 25, 25)
			Me.ExcisionTheme1.Controls.Add(Me.ExcisionButtonDefault1)
			Me.ExcisionTheme1.Controls.Add(Me.RichTextBox1)
			Me.ExcisionTheme1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.ExcisionTheme1.Location = New Global.System.Drawing.Point(0, 0)
			Me.ExcisionTheme1.MaximumSize = New Global.System.Drawing.Size(321, 198)
			Me.ExcisionTheme1.MinimumSize = New Global.System.Drawing.Size(321, 198)
			Me.ExcisionTheme1.Name = "ExcisionTheme1"
			Me.ExcisionTheme1.Size = New Global.System.Drawing.Size(321, 198)
			Me.ExcisionTheme1.TabIndex = 0
			Me.ExcisionTheme1.Text = "Message Of The Day"
			Me.ExcisionButtonDefault1.BackColor = Global.System.Drawing.Color.Transparent
			Me.ExcisionButtonDefault1.ForeColor = Global.System.Drawing.Color.FromArgb(205, 205, 205)
			Me.ExcisionButtonDefault1.Location = New Global.System.Drawing.Point(12, 164)
			Me.ExcisionButtonDefault1.Name = "ExcisionButtonDefault1"
			Me.ExcisionButtonDefault1.Size = New Global.System.Drawing.Size(297, 23)
			Me.ExcisionButtonDefault1.TabIndex = 2
			Me.ExcisionButtonDefault1.Text = "Close"
			Me.RichTextBox1.Location = New Global.System.Drawing.Point(12, 47)
			Me.RichTextBox1.Name = "RichTextBox1"
			Me.RichTextBox1.[ReadOnly] = True
			Me.RichTextBox1.Size = New Global.System.Drawing.Size(297, 111)
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = ""
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(321, 198)
			MyBase.Controls.Add(Me.ExcisionTheme1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximumSize = New Global.System.Drawing.Size(321, 198)
			Me.MinimumSize = New Global.System.Drawing.Size(321, 198)
			MyBase.Name = "motd"
			Me.Text = "News !"
			MyBase.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.ExcisionTheme1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000089 RID: 137
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
