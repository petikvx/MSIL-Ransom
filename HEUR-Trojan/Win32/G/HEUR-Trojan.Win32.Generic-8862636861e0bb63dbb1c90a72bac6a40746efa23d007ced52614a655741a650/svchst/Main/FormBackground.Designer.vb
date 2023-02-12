Namespace Main
	' Token: 0x02000007 RID: 7
	Public Partial Class FormBackground
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000015 RID: 21 RVA: 0x00003320 File Offset: 0x00001520
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000016 RID: 22 RVA: 0x00003350 File Offset: 0x00001550
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Main.FormBackground))
			Me.timerActivateChecker = New Global.System.Windows.Forms.Timer(Me.components)
			MyBase.SuspendLayout()
			Me.timerActivateChecker.Enabled = True
			AddHandler Me.timerActivateChecker.Tick, AddressOf Me.timerActivateChecker_Tick
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(284, 262)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormBackground"
			Me.Text = "Form1"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000051 RID: 81
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000052 RID: 82
		Private timerActivateChecker As Global.System.Windows.Forms.Timer
	End Class
End Namespace
