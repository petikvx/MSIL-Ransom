using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000011 RID: 17
	public partial class MainLogin : Form
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0000E923 File Offset: 0x0000CB23
		public MainLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002068 File Offset: 0x00000268
		private void button9_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000E94D File Offset: 0x0000CB4D
		private void MainLogin_Load(object sender, EventArgs e)
		{
			MyGlobalClass.TempLoginUser = new clsUsers();
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000E96C File Offset: 0x0000CB6C
		private void btn_Clear_Click(object sender, EventArgs e)
		{
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000E984 File Offset: 0x0000CB84
		private void drawPIN()
		{
			this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 4 - this.EnteredPIN.Length);
			Application.DoEvents();
			bool flag = this.EnteredPIN.Length > 3;
			if (flag)
			{
				bool flag2 = false;
				clsUsers clsUsers = new clsUsers();
				foreach (clsUsers clsUsers2 in MyGlobalClass.ListOfUsers)
				{
					bool flag3 = clsUsers2.PermissionLevel == 2 || clsUsers2.PermissionLevel == 4;
					if (flag3)
					{
						bool flag4 = this.EnteredPIN == clsUsers2.Passcode;
						if (flag4)
						{
							flag2 = true;
							clsUsers = clsUsers2;
							break;
						}
					}
				}
				bool flag5 = flag2;
				if (flag5)
				{
					Main main = new Main();
					try
					{
						MyGlobalClass.TempLoginUser = clsUsers;
						((frmInitialPage)base.ParentForm).loadinForm("Main");
					}
					catch (Exception ex)
					{
						Console.Write(ex.ToString());
					}
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

		// Token: 0x0600010F RID: 271 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		private void btn_0_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "0";
			this.drawPIN();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		private void btn_1_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "1";
			this.drawPIN();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		private void btn_2_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "2";
			this.drawPIN();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		private void btn_3_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "3";
			this.drawPIN();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		private void btn_4_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "4";
			this.drawPIN();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		private void btn_5_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "5";
			this.drawPIN();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		private void btn_6_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "6";
			this.drawPIN();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		private void btn_7_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "7";
			this.drawPIN();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		private void btn_8_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "8";
			this.drawPIN();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000EC5C File Offset: 0x0000CE5C
		private void btn_9_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "9";
			this.drawPIN();
		}

		// Token: 0x040000E1 RID: 225
		private string EnteredPIN = "";

		// Token: 0x040000E2 RID: 226
		private int IncorrectCount = 0;
	}
}
