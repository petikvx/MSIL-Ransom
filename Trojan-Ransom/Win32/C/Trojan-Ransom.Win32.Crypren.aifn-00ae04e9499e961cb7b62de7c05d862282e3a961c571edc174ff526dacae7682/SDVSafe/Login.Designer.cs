namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000F RID: 15
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CE RID: 206 RVA: 0x0000AB10 File Offset: 0x00008D10
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000AB48 File Offset: 0x00008D48
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.btnLogin = new global::System.Windows.Forms.Button();
			this.btnHistory = new global::System.Windows.Forms.Button();
			this.btnSettings = new global::System.Windows.Forms.Button();
			this.lblRed = new global::System.Windows.Forms.Label();
			this.lblGreen = new global::System.Windows.Forms.Label();
			this.timer30m = new global::System.Windows.Forms.Timer(this.components);
			this.btnCashCls = new global::System.Windows.Forms.Button();
			this.btnDoorSwitch = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.lblHeader = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.btnLogin.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnLogin.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLogin.Location = new global::System.Drawing.Point(287, 181);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(106, 65);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.btnHistory.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnHistory.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnHistory.Location = new global::System.Drawing.Point(562, 38);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new global::System.Drawing.Size(106, 65);
			this.btnHistory.TabIndex = 1;
			this.btnHistory.Text = "HISTORY";
			this.btnHistory.UseVisualStyleBackColor = true;
			this.btnHistory.Click += new global::System.EventHandler(this.btnHistory_Click);
			this.btnSettings.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnSettings.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSettings.Location = new global::System.Drawing.Point(562, 109);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new global::System.Drawing.Size(106, 65);
			this.btnSettings.TabIndex = 2;
			this.btnSettings.Text = "SETTINGS";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new global::System.EventHandler(this.btnSettings_Click);
			this.lblRed.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
			this.lblRed.BackColor = global::System.Drawing.Color.Silver;
			this.lblRed.Location = new global::System.Drawing.Point(5, 401);
			this.lblRed.Name = "lblRed";
			this.lblRed.Size = new global::System.Drawing.Size(8, 8);
			this.lblRed.TabIndex = 3;
			this.lblGreen.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
			this.lblGreen.BackColor = global::System.Drawing.Color.Silver;
			this.lblGreen.Location = new global::System.Drawing.Point(14, 401);
			this.lblGreen.Name = "lblGreen";
			this.lblGreen.Size = new global::System.Drawing.Size(8, 8);
			this.lblGreen.TabIndex = 4;
			this.timer30m.Interval = 1800000;
			this.timer30m.Tick += new global::System.EventHandler(this.timer30m_Tick);
			this.btnCashCls.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnCashCls.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCashCls.Location = new global::System.Drawing.Point(562, 180);
			this.btnCashCls.Name = "btnCashCls";
			this.btnCashCls.Size = new global::System.Drawing.Size(106, 65);
			this.btnCashCls.TabIndex = 5;
			this.btnCashCls.Text = "CASH CLEAR";
			this.btnCashCls.UseVisualStyleBackColor = true;
			this.btnCashCls.Visible = false;
			this.btnCashCls.Click += new global::System.EventHandler(this.btnCashCls_Click);
			this.btnDoorSwitch.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDoorSwitch.Location = new global::System.Drawing.Point(12, 34);
			this.btnDoorSwitch.Name = "btnDoorSwitch";
			this.btnDoorSwitch.Size = new global::System.Drawing.Size(106, 30);
			this.btnDoorSwitch.TabIndex = 6;
			this.btnDoorSwitch.UseVisualStyleBackColor = true;
			this.btnDoorSwitch.Visible = false;
			this.btnDoorSwitch.Click += new global::System.EventHandler(this.btnDoorSwitch_Click);
			this.button1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(12, 70);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(106, 30);
			this.button1.TabIndex = 7;
			this.button1.Text = "Encrypt Batch";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(12, 106);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(106, 30);
			this.button2.TabIndex = 8;
			this.button2.Text = "Preview Decrypt";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.btnClose.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnClose.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.Location = new global::System.Drawing.Point(562, 349);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(106, 65);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 27;
			this.lblHeader.Text = "SDVSafe";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btnDoorSwitch);
			base.Controls.Add(this.btnCashCls);
			base.Controls.Add(this.lblGreen);
			base.Controls.Add(this.lblRed);
			base.Controls.Add(this.btnSettings);
			base.Controls.Add(this.btnHistory);
			base.Controls.Add(this.btnLogin);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000085 RID: 133
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button btnLogin;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Button btnHistory;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Button btnSettings;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label lblRed;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label lblGreen;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Timer timer30m;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Button btnCashCls;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Button btnDoorSwitch;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label lblHeader;
	}
}
