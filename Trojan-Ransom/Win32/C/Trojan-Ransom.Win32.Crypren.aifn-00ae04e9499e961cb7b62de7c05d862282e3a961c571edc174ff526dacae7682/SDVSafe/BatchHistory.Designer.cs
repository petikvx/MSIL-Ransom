namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000002 RID: 2
	public partial class BatchHistory : global::System.Windows.Forms.Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002604 File Offset: 0x00000804
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000263C File Offset: 0x0000083C
		private void InitializeComponent()
		{
			this.noteCountBox = new global::System.Windows.Forms.GroupBox();
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
			this.btnBack = new global::System.Windows.Forms.Button();
			this.historyPanel = new global::System.Windows.Forms.GroupBox();
			this.lblHeader = new global::System.Windows.Forms.Label();
			this.lblRecordHeader = new global::System.Windows.Forms.Label();
			this.noteCountBox.SuspendLayout();
			base.SuspendLayout();
			this.noteCountBox.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left;
			this.noteCountBox.Controls.Add(this.lblRecordHeader);
			this.noteCountBox.Controls.Add(this.label11);
			this.noteCountBox.Controls.Add(this.lblTotalCount);
			this.noteCountBox.Controls.Add(this.label13);
			this.noteCountBox.Controls.Add(this.label6);
			this.noteCountBox.Controls.Add(this.label7);
			this.noteCountBox.Controls.Add(this.label8);
			this.noteCountBox.Controls.Add(this.label9);
			this.noteCountBox.Controls.Add(this.label10);
			this.noteCountBox.Controls.Add(this.lbl5Count);
			this.noteCountBox.Controls.Add(this.lbl10Count);
			this.noteCountBox.Controls.Add(this.lbl20Count);
			this.noteCountBox.Controls.Add(this.lbl100Count);
			this.noteCountBox.Controls.Add(this.lbl50Count);
			this.noteCountBox.Controls.Add(this.label5);
			this.noteCountBox.Controls.Add(this.label4);
			this.noteCountBox.Controls.Add(this.label3);
			this.noteCountBox.Controls.Add(this.label2);
			this.noteCountBox.Controls.Add(this.label1);
			this.noteCountBox.Font = new global::System.Drawing.Font("Calibri", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.noteCountBox.Location = new global::System.Drawing.Point(12, 28);
			this.noteCountBox.Name = "noteCountBox";
			this.noteCountBox.Size = new global::System.Drawing.Size(300, 386);
			this.noteCountBox.TabIndex = 1;
			this.noteCountBox.TabStop = false;
			this.noteCountBox.Text = "Note Count";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(125, 336);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(23, 33);
			this.label11.TabIndex = 17;
			this.label11.Text = "-";
			this.lblTotalCount.AutoSize = true;
			this.lblTotalCount.Location = new global::System.Drawing.Point(191, 336);
			this.lblTotalCount.Name = "lblTotalCount";
			this.lblTotalCount.Size = new global::System.Drawing.Size(43, 33);
			this.lblTotalCount.TabIndex = 16;
			this.lblTotalCount.Text = "$0";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(11, 336);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(68, 33);
			this.label13.TabIndex = 15;
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
			this.btnBack.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnBack.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnBack.Location = new global::System.Drawing.Point(583, 375);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new global::System.Drawing.Size(85, 39);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "BACK";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new global::System.EventHandler(this.btnBack_Click);
			this.historyPanel.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.historyPanel.Font = new global::System.Drawing.Font("Calibri", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.historyPanel.Location = new global::System.Drawing.Point(404, 28);
			this.historyPanel.Name = "historyPanel";
			this.historyPanel.Size = new global::System.Drawing.Size(264, 338);
			this.historyPanel.TabIndex = 4;
			this.historyPanel.TabStop = false;
			this.historyPanel.Text = "History";
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 18;
			this.lblHeader.Text = "Batch History";
			this.lblRecordHeader.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblRecordHeader.Location = new global::System.Drawing.Point(6, 36);
			this.lblRecordHeader.Name = "lblRecordHeader";
			this.lblRecordHeader.Size = new global::System.Drawing.Size(288, 26);
			this.lblRecordHeader.TabIndex = 18;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.historyPanel);
			base.Controls.Add(this.btnBack);
			base.Controls.Add(this.noteCountBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BatchHistory";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Batch History";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.BatchHistory_Load);
			this.noteCountBox.ResumeLayout(false);
			this.noteCountBox.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.GroupBox noteCountBox;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label lbl5Count;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label lbl10Count;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label lbl20Count;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label lbl100Count;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label lbl50Count;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button btnBack;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.GroupBox historyPanel;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label lblTotalCount;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label lblHeader;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label lblRecordHeader;
	}
}
