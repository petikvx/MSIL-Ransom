namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000B RID: 11
	public partial class frmInitialPage : global::System.Windows.Forms.Form
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00007430 File Offset: 0x00005630
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00007468 File Offset: 0x00005668
		private void InitializeComponent()
		{
			this.pnlSubSystem = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.pnlSubSystem.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlSubSystem.Location = new global::System.Drawing.Point(0, 0);
			this.pnlSubSystem.Name = "pnlSubSystem";
			this.pnlSubSystem.Size = new global::System.Drawing.Size(700, 500);
			this.pnlSubSystem.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(700, 500);
			base.Controls.Add(this.pnlSubSystem);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmInitialPage";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmInitialPage";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.frmInitialPage_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000062 RID: 98
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Panel pnlSubSystem;
	}
}
