namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000014 RID: 20
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		private void InitializeComponent()
		{
			this.RefreshBtn = new global::System.Windows.Forms.Button();
			this.PortSelect = new global::System.Windows.Forms.ComboBox();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.lblCurrentPort = new global::System.Windows.Forms.Label();
			this.lblHeader = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.RefreshBtn.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RefreshBtn.Location = new global::System.Drawing.Point(227, 96);
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new global::System.Drawing.Size(96, 35);
			this.RefreshBtn.TabIndex = 5;
			this.RefreshBtn.Text = "REFRESH";
			this.RefreshBtn.UseVisualStyleBackColor = true;
			this.RefreshBtn.Click += new global::System.EventHandler(this.RefreshBtn_Click);
			this.PortSelect.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.PortSelect.FormattingEnabled = true;
			this.PortSelect.Location = new global::System.Drawing.Point(27, 97);
			this.PortSelect.Name = "PortSelect";
			this.PortSelect.Size = new global::System.Drawing.Size(194, 34);
			this.PortSelect.TabIndex = 4;
			this.PortSelect.Text = "Select a port.";
			this.PortSelect.SelectedIndexChanged += new global::System.EventHandler(this.PortSelect_SelectedIndexChanged);
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Location = new global::System.Drawing.Point(583, 375);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(85, 39);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "BACK";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(21, 41);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(232, 33);
			this.label1.TabIndex = 7;
			this.label1.Text = "Configure COM Port";
			this.btnSave.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnSave.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.Location = new global::System.Drawing.Point(492, 375);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(85, 39);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.button2_Click);
			this.lblCurrentPort.AutoSize = true;
			this.lblCurrentPort.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCurrentPort.Location = new global::System.Drawing.Point(23, 143);
			this.lblCurrentPort.Name = "lblCurrentPort";
			this.lblCurrentPort.Size = new global::System.Drawing.Size(76, 19);
			this.lblCurrentPort.TabIndex = 9;
			this.lblCurrentPort.Text = "Current is ";
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 27;
			this.lblHeader.Text = "Settings";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.lblCurrentPort);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.RefreshBtn);
			base.Controls.Add(this.PortSelect);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Settings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.Settings_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400010E RID: 270
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Button RefreshBtn;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.ComboBox PortSelect;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Label lblCurrentPort;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.Label lblHeader;
	}
}
