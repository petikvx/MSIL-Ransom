using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000E RID: 14
	public partial class frmStoreSelectionLogin : Form
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000083F1 File Offset: 0x000065F1
		public frmStoreSelectionLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000841B File Offset: 0x0000661B
		private void frmStoreSelectionLogin_Load(object sender, EventArgs e)
		{
			MyGlobalClass.tmpKeyValue = "";
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000843C File Offset: 0x0000663C
		private void drawPIN()
		{
			this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 6 - this.EnteredPIN.Length);
			bool flag = this.EnteredPIN.Length > 5;
			if (flag)
			{
				bool flag2 = false;
				clsServiceProviders clsServiceProviders = new clsServiceProviders();
				foreach (clsServiceProviders clsServiceProviders2 in MyGlobalClass.ListOfServiceProviders)
				{
					bool flag3 = this.EnteredPIN == clsServiceProviders2.KeyValue;
					if (flag3)
					{
						flag2 = true;
						clsServiceProviders = clsServiceProviders2;
						break;
					}
				}
				bool flag4 = flag2;
				if (flag4)
				{
					try
					{
						MyGlobalClass.tmpKeyValue = clsServiceProviders.KeyValue;
						((frmInitialPage)base.ParentForm).loadinForm("frmStoreSelection");
					}
					catch (Exception ex)
					{
					}
				}
				else
				{
					this.IncorrectCount++;
					this.EnteredPIN = "";
					this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 6 - this.EnteredPIN.Length);
				}
			}
			bool flag5 = this.IncorrectCount > 4;
			if (flag5)
			{
				((frmInitialPage)base.ParentForm).CloseMe();
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000085BC File Offset: 0x000067BC
		private void btn_1_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "1";
			this.drawPIN();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000085DC File Offset: 0x000067DC
		private void btn_2_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "2";
			this.drawPIN();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000085FC File Offset: 0x000067FC
		private void btn_3_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "3";
			this.drawPIN();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000861C File Offset: 0x0000681C
		private void btn_4_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "4";
			this.drawPIN();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000863C File Offset: 0x0000683C
		private void btn_5_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "5";
			this.drawPIN();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000865C File Offset: 0x0000685C
		private void btn_6_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "6";
			this.drawPIN();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000867C File Offset: 0x0000687C
		private void btn_7_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "7";
			this.drawPIN();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000869C File Offset: 0x0000689C
		private void btn_8_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "8";
			this.drawPIN();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000086BC File Offset: 0x000068BC
		private void btn_9_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "9";
			this.drawPIN();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000086DC File Offset: 0x000068DC
		private void btn_0_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "0";
			this.drawPIN();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000086FC File Offset: 0x000068FC
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00007D70 File Offset: 0x00005F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).CloseMe();
		}

		// Token: 0x04000074 RID: 116
		private string EnteredPIN = "";

		// Token: 0x04000075 RID: 117
		private int IncorrectCount = 0;
	}
}
