namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000011 RID: 17
	public partial class MainLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		private void InitializeComponent()
		{
			this.button9 = new global::System.Windows.Forms.Button();
			this.btn_Clear = new global::System.Windows.Forms.Button();
			this.btn_9 = new global::System.Windows.Forms.Button();
			this.btn_8 = new global::System.Windows.Forms.Button();
			this.btn_7 = new global::System.Windows.Forms.Button();
			this.btn_6 = new global::System.Windows.Forms.Button();
			this.btn_5 = new global::System.Windows.Forms.Button();
			this.btn_4 = new global::System.Windows.Forms.Button();
			this.btn_3 = new global::System.Windows.Forms.Button();
			this.btn_2 = new global::System.Windows.Forms.Button();
			this.btn_1 = new global::System.Windows.Forms.Button();
			this.btn_0 = new global::System.Windows.Forms.Button();
			this.lblPin = new global::System.Windows.Forms.Label();
			this.lblHeader = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.button9.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.ForeColor = global::System.Drawing.Color.Red;
			this.button9.Location = new global::System.Drawing.Point(535, 321);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(90, 65);
			this.button9.TabIndex = 25;
			this.button9.Text = "CANCEL";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.btn_Clear.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_Clear.ForeColor = global::System.Drawing.Color.DarkKhaki;
			this.btn_Clear.Location = new global::System.Drawing.Point(535, 250);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new global::System.Drawing.Size(90, 65);
			this.btn_Clear.TabIndex = 24;
			this.btn_Clear.Text = "CLEAR";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new global::System.EventHandler(this.btn_Clear_Click);
			this.btn_9.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_9.Location = new global::System.Drawing.Point(343, 321);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new global::System.Drawing.Size(90, 65);
			this.btn_9.TabIndex = 23;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new global::System.EventHandler(this.btn_9_Click);
			this.btn_8.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_8.Location = new global::System.Drawing.Point(247, 321);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new global::System.Drawing.Size(90, 65);
			this.btn_8.TabIndex = 22;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new global::System.EventHandler(this.btn_8_Click);
			this.btn_7.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_7.Location = new global::System.Drawing.Point(151, 321);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new global::System.Drawing.Size(90, 65);
			this.btn_7.TabIndex = 21;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new global::System.EventHandler(this.btn_7_Click);
			this.btn_6.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_6.Location = new global::System.Drawing.Point(55, 321);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new global::System.Drawing.Size(90, 65);
			this.btn_6.TabIndex = 20;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new global::System.EventHandler(this.btn_6_Click);
			this.btn_5.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_5.Location = new global::System.Drawing.Point(439, 250);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new global::System.Drawing.Size(90, 65);
			this.btn_5.TabIndex = 19;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new global::System.EventHandler(this.btn_5_Click);
			this.btn_4.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_4.Location = new global::System.Drawing.Point(343, 250);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new global::System.Drawing.Size(90, 65);
			this.btn_4.TabIndex = 18;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new global::System.EventHandler(this.btn_4_Click);
			this.btn_3.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_3.Location = new global::System.Drawing.Point(247, 250);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new global::System.Drawing.Size(90, 65);
			this.btn_3.TabIndex = 17;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new global::System.EventHandler(this.btn_3_Click);
			this.btn_2.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_2.Location = new global::System.Drawing.Point(151, 250);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new global::System.Drawing.Size(90, 65);
			this.btn_2.TabIndex = 16;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new global::System.EventHandler(this.btn_2_Click);
			this.btn_1.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_1.Location = new global::System.Drawing.Point(55, 250);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new global::System.Drawing.Size(90, 65);
			this.btn_1.TabIndex = 15;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new global::System.EventHandler(this.btn_1_Click);
			this.btn_0.Font = new global::System.Drawing.Font("Calibri", 27.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btn_0.Location = new global::System.Drawing.Point(439, 321);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new global::System.Drawing.Size(90, 65);
			this.btn_0.TabIndex = 14;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new global::System.EventHandler(this.btn_0_Click);
			this.lblPin.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblPin.Font = new global::System.Drawing.Font("Calibri", 99.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPin.Location = new global::System.Drawing.Point(55, 60);
			this.lblPin.Name = "lblPin";
			this.lblPin.Size = new global::System.Drawing.Size(570, 163);
			this.lblPin.TabIndex = 13;
			this.lblPin.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 26;
			this.lblHeader.Text = "Main - Enter Pin";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.btn_Clear);
			base.Controls.Add(this.btn_9);
			base.Controls.Add(this.btn_8);
			base.Controls.Add(this.btn_7);
			base.Controls.Add(this.btn_6);
			base.Controls.Add(this.btn_5);
			base.Controls.Add(this.btn_4);
			base.Controls.Add(this.btn_3);
			base.Controls.Add(this.btn_2);
			base.Controls.Add(this.btn_1);
			base.Controls.Add(this.btn_0);
			base.Controls.Add(this.lblPin);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainLogin";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main - Enter Pin";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.MainLogin_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040000E3 RID: 227
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Button button9;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Button btn_Clear;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Button btn_9;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Button btn_8;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Button btn_7;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Button btn_6;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.Button btn_5;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Button btn_4;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Button btn_3;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Button btn_2;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Button btn_1;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Button btn_0;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.Label lblPin;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.Label lblHeader;
	}
}
