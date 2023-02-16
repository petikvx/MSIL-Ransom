Namespace vHack_Loader
	' Token: 0x02000020 RID: 32
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Updater
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000157 RID: 343 RVA: 0x000092B0 File Offset: 0x000074B0
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

		' Token: 0x06000158 RID: 344 RVA: 0x000092F0 File Offset: 0x000074F0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.vHack_Loader.Updater))
			Me.ExcisionTheme1 = New Global.vHack_Loader.ExcisionTheme()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ExcisionProgressBar1 = New Global.vHack_Loader.ExcisionProgressBar()
			Me.BackgroundWorker1 = New Global.System.ComponentModel.BackgroundWorker()
			Me.ExcisionTheme1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ExcisionTheme1.BackColor = Global.System.Drawing.Color.FromArgb(25, 25, 25)
			Me.ExcisionTheme1.Controls.Add(Me.Label1)
			Me.ExcisionTheme1.Controls.Add(Me.ExcisionProgressBar1)
			Me.ExcisionTheme1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.ExcisionTheme1.Location = New Global.System.Drawing.Point(0, 0)
			Me.ExcisionTheme1.MaximumSize = New Global.System.Drawing.Size(375, 103)
			Me.ExcisionTheme1.MinimumSize = New Global.System.Drawing.Size(375, 103)
			Me.ExcisionTheme1.Name = "ExcisionTheme1"
			Me.ExcisionTheme1.Size = New Global.System.Drawing.Size(375, 103)
			Me.ExcisionTheme1.TabIndex = 0
			Me.ExcisionTheme1.Text = "vCheat Loader - Update"
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Verdana", 11F)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Me.Label1.Location = New Global.System.Drawing.Point(12, 74)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(92, 18)
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Visit site !!!"
			Me.ExcisionProgressBar1.BackColor = Global.System.Drawing.Color.Transparent
			Me.ExcisionProgressBar1.Location = New Global.System.Drawing.Point(12, 48)
			Me.ExcisionProgressBar1.Maximum = 100
			Me.ExcisionProgressBar1.Name = "ExcisionProgressBar1"
			Me.ExcisionProgressBar1.ShowPercentage = False
			Me.ExcisionProgressBar1.Size = New Global.System.Drawing.Size(351, 23)
			Me.ExcisionProgressBar1.TabIndex = 0
			Me.ExcisionProgressBar1.Text = "ExcisionProgressBar1"
			Me.ExcisionProgressBar1.Value = 0
			Me.BackgroundWorker1.WorkerReportsProgress = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(375, 103)
			MyBase.Controls.Add(Me.ExcisionTheme1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximumSize = New Global.System.Drawing.Size(375, 103)
			Me.MinimumSize = New Global.System.Drawing.Size(375, 103)
			MyBase.Name = "Updater"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Notepad"
			MyBase.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.ExcisionTheme1.ResumeLayout(False)
			Me.ExcisionTheme1.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400008F RID: 143
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
