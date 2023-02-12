using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000003 RID: 3
	public partial class BatchHistoryLogin : Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000345E File Offset: 0x0000165E
		public BatchHistoryLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002068 File Offset: 0x00000268
		private void button9_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003488 File Offset: 0x00001688
		private void BatchHistoryLogin_Load(object sender, EventArgs e)
		{
			MyGlobalClass.TempLoginUser = new clsUsers();
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000034A7 File Offset: 0x000016A7
		private void button10_Click(object sender, EventArgs e)
		{
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000034BC File Offset: 0x000016BC
		private void drawPIN()
		{
			this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 4 - this.EnteredPIN.Length);
			bool flag = this.EnteredPIN.Length > 3;
			if (flag)
			{
				bool flag2 = false;
				clsUsers clsUsers = new clsUsers();
				foreach (clsUsers clsUsers2 in MyGlobalClass.ListOfUsers)
				{
					bool flag3 = clsUsers2.PermissionLevel == 3 || clsUsers2.PermissionLevel == 4;
					if (flag3)
					{
						bool flag4 = this.EnteredPIN == clsUsers2.Passcode;
						if (flag4)
						{
							flag2 = true;
							break;
						}
					}
				}
				bool flag5 = flag2;
				if (flag5)
				{
					((frmInitialPage)base.ParentForm).loadinForm("BatchHistory");
				}
				else
				{
					this.IncorrectCount++;
					this.EnteredPIN = "";
					this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 4 - this.EnteredPIN.Length);
				}
			}
			bool flag6 = this.IncorrectCount > 4;
			if (flag6)
			{
				((frmInitialPage)base.ParentForm).loadinForm("Login");
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003640 File Offset: 0x00001840
		private void btn_0_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "0";
			this.drawPIN();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003660 File Offset: 0x00001860
		private void btn_1_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "1";
			this.drawPIN();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003680 File Offset: 0x00001880
		private void btn_2_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "2";
			this.drawPIN();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000036A0 File Offset: 0x000018A0
		private void btn_3_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "3";
			this.drawPIN();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000036C0 File Offset: 0x000018C0
		private void button8_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "4";
			this.drawPIN();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000036E0 File Offset: 0x000018E0
		private void btn_5_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "5";
			this.drawPIN();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003700 File Offset: 0x00001900
		private void btn_6_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "6";
			this.drawPIN();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003720 File Offset: 0x00001920
		private void btn_7_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "7";
			this.drawPIN();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003740 File Offset: 0x00001940
		private void btn_8_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "8";
			this.drawPIN();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003760 File Offset: 0x00001960
		private void btn_9_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "9";
			this.drawPIN();
		}

		// Token: 0x04000019 RID: 25
		private string EnteredPIN = "";

		// Token: 0x0400001A RID: 26
		private int IncorrectCount = 0;
	}
}
