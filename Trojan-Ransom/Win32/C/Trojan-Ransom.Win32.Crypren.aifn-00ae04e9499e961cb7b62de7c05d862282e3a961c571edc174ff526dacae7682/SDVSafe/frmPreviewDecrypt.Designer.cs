namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000C RID: 12
	public partial class frmPreviewDecrypt : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00007714 File Offset: 0x00005914
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000774C File Offset: 0x0000594C
		private void InitializeComponent()
		{
			this.rtbContent = new global::System.Windows.Forms.RichTextBox();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnBrowse = new global::System.Windows.Forms.Button();
			this.lblHeader = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.rtbContent.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.rtbContent.Location = new global::System.Drawing.Point(12, 84);
			this.rtbContent.Name = "rtbContent";
			this.rtbContent.ReadOnly = true;
			this.rtbContent.Size = new global::System.Drawing.Size(656, 285);
			this.rtbContent.TabIndex = 0;
			this.rtbContent.Text = "";
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Location = new global::System.Drawing.Point(583, 375);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(85, 39);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "BACK";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnBrowse.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnBrowse.Location = new global::System.Drawing.Point(12, 34);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new global::System.Drawing.Size(124, 39);
			this.btnBrowse.TabIndex = 8;
			this.btnBrowse.Text = "Browse ...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new global::System.EventHandler(this.btnBrowse_Click);
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 27;
			this.lblHeader.Text = "Preview Decrypt";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.btnBrowse);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.rtbContent);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmPreviewDecrypt";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Preview Decrypt";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.frmPreviewDecrypt_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000064 RID: 100
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.RichTextBox rtbContent;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Button btnBrowse;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label lblHeader;
	}
}
