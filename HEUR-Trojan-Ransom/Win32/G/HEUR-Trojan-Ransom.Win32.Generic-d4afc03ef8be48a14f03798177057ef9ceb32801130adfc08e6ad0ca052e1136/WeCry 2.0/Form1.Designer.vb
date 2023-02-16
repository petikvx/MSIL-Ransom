Namespace WeCry_2._0
	' Token: 0x02000008 RID: 8
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600002D RID: 45 RVA: 0x00003F48 File Offset: 0x00002148
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

		' Token: 0x0600002E RID: 46 RVA: 0x00003F98 File Offset: 0x00002198
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.WeCry_2._0.Form1))
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.btnCopy = New Global.System.Windows.Forms.Button()
			Me.btnCheck = New Global.System.Windows.Forms.Button()
			Me.btnDecrypt = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.LinkLabel1 = New Global.System.Windows.Forms.LinkLabel()
			Me.LinkLabel2 = New Global.System.Windows.Forms.LinkLabel()
			Me.LinkLabel3 = New Global.System.Windows.Forms.LinkLabel()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.lblRaised = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.lblLost = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.PictureBox3 = New Global.System.Windows.Forms.PictureBox()
			Me.Timer2 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer3 = New Global.System.Windows.Forms.Timer(Me.components)
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.RichTextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RichTextBox1.Location = New Global.System.Drawing.Point(224, 40)
			Me.RichTextBox1.Name = "RichTextBox1"
			Me.RichTextBox1.[ReadOnly] = True
			Me.RichTextBox1.Size = New Global.System.Drawing.Size(531, 382)
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = componentResourceManager.GetString("RichTextBox1.Text")
			Me.btnCopy.FlatStyle = Global.System.Windows.Forms.FlatStyle.System
			Me.btnCopy.Location = New Global.System.Drawing.Point(718, 458)
			Me.btnCopy.Name = "btnCopy"
			Me.btnCopy.Size = New Global.System.Drawing.Size(33, 34)
			Me.btnCopy.TabIndex = 2
			Me.btnCopy.Text = "Copy"
			Me.btnCopy.UseVisualStyleBackColor = True
			Me.btnCheck.AutoSize = True
			Me.btnCheck.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnCheck.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCheck.Location = New Global.System.Drawing.Point(224, 508)
			Me.btnCheck.Name = "btnCheck"
			Me.btnCheck.Size = New Global.System.Drawing.Size(252, 31)
			Me.btnCheck.TabIndex = 3
			Me.btnCheck.Text = "&Check Payment"
			Me.btnCheck.UseVisualStyleBackColor = True
			Me.btnDecrypt.AutoSize = True
			Me.btnDecrypt.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.btnDecrypt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDecrypt.Location = New Global.System.Drawing.Point(503, 508)
			Me.btnDecrypt.Name = "btnDecrypt"
			Me.btnDecrypt.Size = New Global.System.Drawing.Size(251, 31)
			Me.btnDecrypt.TabIndex = 4
			Me.btnDecrypt.Text = "&Decrypt"
			Me.btnDecrypt.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.SystemColors.Info
			Me.TextBox1.Location = New Global.System.Drawing.Point(360, 460)
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.Size = New Global.System.Drawing.Size(355, 30)
			Me.TextBox1.TabIndex = 5
			Me.TextBox1.Text = "129B2FSzorAbRrD2jf9rDMZ5sWU2bZBM6M"
			Me.LinkLabel1.AutoSize = True
			Me.LinkLabel1.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.LinkLabel1.LinkColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.LinkLabel1.Location = New Global.System.Drawing.Point(23, 452)
			Me.LinkLabel1.Name = "LinkLabel1"
			Me.LinkLabel1.Size = New Global.System.Drawing.Size(69, 13)
			Me.LinkLabel1.TabIndex = 6
			Me.LinkLabel1.TabStop = True
			Me.LinkLabel1.Text = "About bitcoin"
			Me.LinkLabel2.AutoSize = True
			Me.LinkLabel2.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.LinkLabel2.LinkColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.LinkLabel2.Location = New Global.System.Drawing.Point(23, 478)
			Me.LinkLabel2.Name = "LinkLabel2"
			Me.LinkLabel2.Size = New Global.System.Drawing.Size(106, 13)
			Me.LinkLabel2.TabIndex = 7
			Me.LinkLabel2.TabStop = True
			Me.LinkLabel2.Text = "How to buy bitcoins?"
			Me.LinkLabel3.AutoSize = True
			Me.LinkLabel3.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.LinkLabel3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.LinkLabel3.LinkColor = Global.System.Drawing.Color.FromArgb(128, 128, 255)
			Me.LinkLabel3.Location = New Global.System.Drawing.Point(22, 508)
			Me.LinkLabel3.Name = "LinkLabel3"
			Me.LinkLabel3.Size = New Global.System.Drawing.Size(99, 20)
			Me.LinkLabel3.TabIndex = 8
			Me.LinkLabel3.TabStop = True
			Me.LinkLabel3.Text = "Contact Us"
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "Chinese(Simplified)", "English", "German", "Italian", "Polish", "Russian", "Spanish" })
			Me.ComboBox1.Location = New Global.System.Drawing.Point(650, 11)
			Me.ComboBox1.Name = "ComboBox1"
			Me.ComboBox1.Size = New Global.System.Drawing.Size(104, 21)
			Me.ComboBox1.Sorted = True
			Me.ComboBox1.TabIndex = 9
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.White
			Me.Label1.Location = New Global.System.Drawing.Point(240, 8)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(378, 24)
			Me.Label1.TabIndex = 10
			Me.Label1.Text = "Ooops, your files have been encrypted!"
			Me.Label4.AutoSize = True
			Me.Label4.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.Gold
			Me.Label4.Location = New Global.System.Drawing.Point(360, 433)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(334, 16)
			Me.Label4.TabIndex = 13
			Me.Label4.Text = "Donate to SHUHackSoc at this bitcoin address:"
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.Gold
			Me.Label2.Location = New Global.System.Drawing.Point(20, 153)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(185, 16)
			Me.Label2.TabIndex = 14
			Me.Label2.Text = "Payment will be raised on"
			Me.Label3.AutoSize = True
			Me.Label3.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.Gold
			Me.Label3.Location = New Global.System.Drawing.Point(23, 297)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(171, 16)
			Me.Label3.TabIndex = 15
			Me.Label3.Text = "Your files will be lost on"
			Me.lblRaised.AutoSize = True
			Me.lblRaised.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.lblRaised.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRaised.ForeColor = Global.System.Drawing.Color.White
			Me.lblRaised.Location = New Global.System.Drawing.Point(20, 232)
			Me.lblRaised.Name = "lblRaised"
			Me.lblRaised.Size = New Global.System.Drawing.Size(167, 33)
			Me.lblRaised.TabIndex = 16
			Me.lblRaised.Text = "00:00:00:00"
			Me.Timer1.Interval = 1000
			Me.lblLost.AutoSize = True
			Me.lblLost.BackColor = Global.System.Drawing.Color.FromArgb(133, 18, 18)
			Me.lblLost.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 21.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblLost.ForeColor = Global.System.Drawing.Color.White
			Me.lblLost.Location = New Global.System.Drawing.Point(21, 378)
			Me.lblLost.Name = "lblLost"
			Me.lblLost.Size = New Global.System.Drawing.Size(167, 33)
			Me.lblLost.TabIndex = 17
			Me.lblLost.Text = "00:00:00:00"
			Me.Label5.AutoSize = True
			Me.Label5.BackColor = Global.System.Drawing.Color.FromArgb(132, 18, 18)
			Me.Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.White
			Me.Label5.Location = New Global.System.Drawing.Point(44, 179)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(122, 13)
			Me.Label5.TabIndex = 18
			Me.Label5.Text = "5/16/2017 00:47:55"
			Me.Label6.AutoSize = True
			Me.Label6.BackColor = Global.System.Drawing.Color.FromArgb(132, 18, 18)
			Me.Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Global.System.Drawing.Color.White
			Me.Label6.Location = New Global.System.Drawing.Point(44, 326)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(122, 13)
			Me.Label6.TabIndex = 19
			Me.Label6.Text = "5/16/2017 00:47:55"
			Me.Label7.AutoSize = True
			Me.Label7.BackColor = Global.System.Drawing.Color.FromArgb(132, 18, 18)
			Me.Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.ForeColor = Global.System.Drawing.Color.White
			Me.Label7.Location = New Global.System.Drawing.Point(75, 356)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(60, 13)
			Me.Label7.TabIndex = 20
			Me.Label7.Text = "Time Left"
			Me.Label8.AutoSize = True
			Me.Label8.BackColor = Global.System.Drawing.Color.FromArgb(132, 18, 18)
			Me.Label8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.ForeColor = Global.System.Drawing.Color.White
			Me.Label8.Location = New Global.System.Drawing.Point(74, 213)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(60, 13)
			Me.Label8.TabIndex = 21
			Me.Label8.Text = "Time Left"
			Me.PictureBox2.BackColor = Global.System.Drawing.Color.FromArgb(132, 18, 18)
			Me.PictureBox2.Location = New Global.System.Drawing.Point(82, 229)
			Me.PictureBox2.Name = "PictureBox2"
			Me.PictureBox2.Size = New Global.System.Drawing.Size(115, 42)
			Me.PictureBox2.TabIndex = 22
			Me.PictureBox2.TabStop = False
			Me.PictureBox1.Image = Global.WeCry_2._0.My.Resources.Resources.wannacry_05_1024x774
			Me.PictureBox1.Location = New Global.System.Drawing.Point(-6, -27)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(768, 580)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.PictureBox3.Image = CType(componentResourceManager.GetObject("PictureBox3.Image"), Global.System.Drawing.Image)
			Me.PictureBox3.Location = New Global.System.Drawing.Point(761, 0)
			Me.PictureBox3.Name = "PictureBox3"
			Me.PictureBox3.Size = New Global.System.Drawing.Size(800, 600)
			Me.PictureBox3.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.PictureBox3.TabIndex = 23
			Me.PictureBox3.TabStop = False
			Me.PictureBox3.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(756, 545)
			MyBase.Controls.Add(Me.PictureBox3)
			MyBase.Controls.Add(Me.lblRaised)
			MyBase.Controls.Add(Me.PictureBox2)
			MyBase.Controls.Add(Me.Label8)
			MyBase.Controls.Add(Me.Label7)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.lblLost)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.ComboBox1)
			MyBase.Controls.Add(Me.LinkLabel3)
			MyBase.Controls.Add(Me.LinkLabel2)
			MyBase.Controls.Add(Me.LinkLabel1)
			MyBase.Controls.Add(Me.TextBox1)
			MyBase.Controls.Add(Me.btnDecrypt)
			MyBase.Controls.Add(Me.btnCheck)
			MyBase.Controls.Add(Me.btnCopy)
			MyBase.Controls.Add(Me.RichTextBox1)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Form1"
			Me.Text = "WeCry 2.0 - Sponsored by Sheffield Hallam University"
			MyBase.TopMost = True
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400001F RID: 31
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
