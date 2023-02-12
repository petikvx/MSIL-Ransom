namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000010 RID: 16
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000D624 File Offset: 0x0000B824
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnAddHundred = new global::System.Windows.Forms.Button();
			this.btnAddFifty = new global::System.Windows.Forms.Button();
			this.btnAddTwenty = new global::System.Windows.Forms.Button();
			this.btnAddTen = new global::System.Windows.Forms.Button();
			this.btnAddFive = new global::System.Windows.Forms.Button();
			this.label11 = new global::System.Windows.Forms.Label();
			this.lblTotalCount = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.lbl5Count = new global::System.Windows.Forms.Label();
			this.lbl10Count = new global::System.Windows.Forms.Label();
			this.lbl20Count = new global::System.Windows.Forms.Label();
			this.lbl100Count = new global::System.Windows.Forms.Label();
			this.lbl50Count = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnDone = new global::System.Windows.Forms.Button();
			this.DeviceStateLabel = new global::System.Windows.Forms.Label();
			this.label120 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.timer3 = new global::System.Windows.Forms.Timer(this.components);
			this.lblHeader = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.btnAddHundred);
			this.groupBox1.Controls.Add(this.btnAddFifty);
			this.groupBox1.Controls.Add(this.btnAddTwenty);
			this.groupBox1.Controls.Add(this.btnAddTen);
			this.groupBox1.Controls.Add(this.btnAddFive);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.lblTotalCount);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.lbl5Count);
			this.groupBox1.Controls.Add(this.lbl10Count);
			this.groupBox1.Controls.Add(this.lbl20Count);
			this.groupBox1.Controls.Add(this.lbl100Count);
			this.groupBox1.Controls.Add(this.lbl50Count);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new global::System.Drawing.Font("Calibri", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(300, 386);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Note Count";
			this.btnAddHundred.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddHundred.Location = new global::System.Drawing.Point(261, 282);
			this.btnAddHundred.Name = "btnAddHundred";
			this.btnAddHundred.Size = new global::System.Drawing.Size(33, 33);
			this.btnAddHundred.TabIndex = 24;
			this.btnAddHundred.Text = "+";
			this.btnAddHundred.UseVisualStyleBackColor = true;
			this.btnAddHundred.Visible = false;
			this.btnAddHundred.Click += new global::System.EventHandler(this.btnAddHundred_Click);
			this.btnAddFifty.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddFifty.Location = new global::System.Drawing.Point(261, 228);
			this.btnAddFifty.Name = "btnAddFifty";
			this.btnAddFifty.Size = new global::System.Drawing.Size(33, 33);
			this.btnAddFifty.TabIndex = 23;
			this.btnAddFifty.Text = "+";
			this.btnAddFifty.UseVisualStyleBackColor = true;
			this.btnAddFifty.Visible = false;
			this.btnAddFifty.Click += new global::System.EventHandler(this.btnAddFifty_Click);
			this.btnAddTwenty.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddTwenty.Location = new global::System.Drawing.Point(261, 174);
			this.btnAddTwenty.Name = "btnAddTwenty";
			this.btnAddTwenty.Size = new global::System.Drawing.Size(33, 33);
			this.btnAddTwenty.TabIndex = 22;
			this.btnAddTwenty.Text = "+";
			this.btnAddTwenty.UseVisualStyleBackColor = true;
			this.btnAddTwenty.Visible = false;
			this.btnAddTwenty.Click += new global::System.EventHandler(this.btnAddTwenty_Click);
			this.btnAddTen.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddTen.Location = new global::System.Drawing.Point(261, 120);
			this.btnAddTen.Name = "btnAddTen";
			this.btnAddTen.Size = new global::System.Drawing.Size(33, 33);
			this.btnAddTen.TabIndex = 21;
			this.btnAddTen.Text = "+";
			this.btnAddTen.UseVisualStyleBackColor = true;
			this.btnAddTen.Visible = false;
			this.btnAddTen.Click += new global::System.EventHandler(this.btnAddTen_Click);
			this.btnAddFive.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddFive.Location = new global::System.Drawing.Point(261, 66);
			this.btnAddFive.Name = "btnAddFive";
			this.btnAddFive.Size = new global::System.Drawing.Size(33, 33);
			this.btnAddFive.TabIndex = 17;
			this.btnAddFive.Text = "+";
			this.btnAddFive.UseVisualStyleBackColor = true;
			this.btnAddFive.Visible = false;
			this.btnAddFive.Click += new global::System.EventHandler(this.btnAddFive_Click);
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(125, 336);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(23, 33);
			this.label11.TabIndex = 20;
			this.label11.Text = "-";
			this.lblTotalCount.AutoSize = true;
			this.lblTotalCount.Location = new global::System.Drawing.Point(191, 336);
			this.lblTotalCount.Name = "lblTotalCount";
			this.lblTotalCount.Size = new global::System.Drawing.Size(43, 33);
			this.lblTotalCount.TabIndex = 19;
			this.lblTotalCount.Text = "$0";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(11, 336);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(68, 33);
			this.label13.TabIndex = 18;
			this.label13.Text = "Total";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(125, 66);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(23, 33);
			this.label6.TabIndex = 14;
			this.label6.Text = "-";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(125, 120);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(23, 33);
			this.label7.TabIndex = 13;
			this.label7.Text = "-";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(125, 174);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(23, 33);
			this.label8.TabIndex = 12;
			this.label8.Text = "-";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(125, 282);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(23, 33);
			this.label9.TabIndex = 11;
			this.label9.Text = "-";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(125, 228);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(23, 33);
			this.label10.TabIndex = 10;
			this.label10.Text = "-";
			this.lbl5Count.AutoSize = true;
			this.lbl5Count.Location = new global::System.Drawing.Point(191, 66);
			this.lbl5Count.Name = "lbl5Count";
			this.lbl5Count.Size = new global::System.Drawing.Size(29, 33);
			this.lbl5Count.TabIndex = 9;
			this.lbl5Count.Text = "0";
			this.lbl10Count.AutoSize = true;
			this.lbl10Count.Location = new global::System.Drawing.Point(191, 120);
			this.lbl10Count.Name = "lbl10Count";
			this.lbl10Count.Size = new global::System.Drawing.Size(29, 33);
			this.lbl10Count.TabIndex = 8;
			this.lbl10Count.Text = "0";
			this.lbl20Count.AutoSize = true;
			this.lbl20Count.Location = new global::System.Drawing.Point(191, 174);
			this.lbl20Count.Name = "lbl20Count";
			this.lbl20Count.Size = new global::System.Drawing.Size(29, 33);
			this.lbl20Count.TabIndex = 7;
			this.lbl20Count.Text = "0";
			this.lbl100Count.AutoSize = true;
			this.lbl100Count.Location = new global::System.Drawing.Point(191, 282);
			this.lbl100Count.Name = "lbl100Count";
			this.lbl100Count.Size = new global::System.Drawing.Size(29, 33);
			this.lbl100Count.TabIndex = 6;
			this.lbl100Count.Text = "0";
			this.lbl50Count.AutoSize = true;
			this.lbl50Count.Location = new global::System.Drawing.Point(191, 228);
			this.lbl50Count.Name = "lbl50Count";
			this.lbl50Count.Size = new global::System.Drawing.Size(29, 33);
			this.lbl50Count.TabIndex = 5;
			this.lbl50Count.Text = "0";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(11, 66);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(43, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "$5";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(11, 120);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(57, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "$10";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(11, 174);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(57, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "$20";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(11, 282);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(71, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "$100";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(11, 228);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(57, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "$50";
			this.btnDone.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnDone.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDone.Location = new global::System.Drawing.Point(583, 375);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new global::System.Drawing.Size(85, 39);
			this.btnDone.TabIndex = 1;
			this.btnDone.Text = "DONE";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new global::System.EventHandler(this.btnDone_Click);
			this.DeviceStateLabel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.DeviceStateLabel.AutoSize = true;
			this.DeviceStateLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DeviceStateLabel.Location = new global::System.Drawing.Point(459, 398);
			this.DeviceStateLabel.Name = "DeviceStateLabel";
			this.DeviceStateLabel.Size = new global::System.Drawing.Size(74, 19);
			this.DeviceStateLabel.TabIndex = 16;
			this.DeviceStateLabel.Text = "-------------";
			this.label120.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.label120.AutoSize = true;
			this.label120.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label120.Location = new global::System.Drawing.Point(358, 398);
			this.label120.Name = "label120";
			this.label120.Size = new global::System.Drawing.Size(94, 19);
			this.label120.TabIndex = 15;
			this.label120.Text = "Device State:";
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick_1);
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.timer3.Tick += new global::System.EventHandler(this.timer3_Tick);
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 17;
			this.lblHeader.Text = "Main";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.DeviceStateLabel);
			base.Controls.Add(this.label120);
			base.Controls.Add(this.btnDone);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			base.Load += new global::System.EventHandler(this.Main_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000C1 RID: 193
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Button btnDone;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label lbl5Count;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label lbl10Count;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.Label lbl20Count;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Label lbl100Count;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Label lbl50Count;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Label DeviceStateLabel;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Label label120;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Timer timer3;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Label lblTotalCount;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Button btnAddHundred;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Button btnAddFifty;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button btnAddTwenty;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Button btnAddTen;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button btnAddFive;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Label lblHeader;
	}
}
