using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000004 RID: 4
	public partial class CashClsLogin : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000042DB File Offset: 0x000024DB
		public CashClsLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000431B File Offset: 0x0000251B
		private void CashClsLogin_Load(object sender, EventArgs e)
		{
			MyGlobalClass.TempLoginUser = new clsUsers();
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002068 File Offset: 0x00000268
		private void button9_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000433A File Offset: 0x0000253A
		private void btn_Clear_Click(object sender, EventArgs e)
		{
			this.EnteredPIN = "";
			this.drawPIN();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004350 File Offset: 0x00002550
		private void drawPIN()
		{
			this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 4 - this.EnteredPIN.Length);
			bool flag = this.EnteredPIN.Length > 3;
			if (flag)
			{
				bool flag2 = false;
				clsUsers clsUsers = new clsUsers();
				DateTime now = DateTime.Now;
				foreach (clsUsers clsUsers2 in MyGlobalClass.ListOfUsers)
				{
					bool flag3 = clsUsers2.PermissionLevel == 0;
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
					this.myButtonEnableDisable(false);
					clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
					bool isPi = MyGlobalClass.isPi;
					if (isPi)
					{
						this.cashClsFullPath = string.Concat(new object[]
						{
							MyGlobalClass.cashClsDirectory,
							"/",
							now.ToString("yyyyMMdd-HHmmss"),
							"_",
							clsUsers.ID,
							".dat"
						});
						this.cashClsUploadFullPath = string.Concat(new object[]
						{
							MyGlobalClass.cashClsUploadDirectory,
							"/",
							now.ToString("yyyyMMdd-HHmmss"),
							"_",
							clsUsers.ID,
							".dat"
						});
					}
					else
					{
						this.cashClsFullPath = string.Concat(new object[]
						{
							MyGlobalClass.cashClsDirectory,
							"\\",
							now.ToString("yyyyMMdd-HHmmss"),
							"_",
							clsUsers.ID,
							".dat"
						});
						this.cashClsUploadFullPath = string.Concat(new object[]
						{
							MyGlobalClass.cashClsUploadDirectory,
							"\\",
							now.ToString("yyyyMMdd-HHmmss"),
							"_",
							clsUsers.ID,
							".dat"
						});
					}
					File.WriteAllText(this.cashClsFullPath, this.cashClsFullPath);
					Cursor.Current = Cursors.WaitCursor;
					Application.DoEvents();
					clsEncryptDecrypt.FileEncrypt(this.cashClsFullPath, MyGlobalClass.FileEncryptDecryptKey);
					Cursor.Current = Cursors.Default;
					File.Delete(this.cashClsFullPath);
					bool flag6 = MyGlobalClass.AcknowledgementToFernware();
					if (flag6)
					{
						this.SubmitCashClearanceToFernwareEncrypt(now.ToString("yyyyMMddHHmmss"), clsUsers);
						File.WriteAllText(this.cashClsUploadFullPath, this.cashClsUploadFullPath);
						Cursor.Current = Cursors.WaitCursor;
						Application.DoEvents();
						clsEncryptDecrypt.FileEncrypt(this.cashClsUploadFullPath, MyGlobalClass.FileEncryptDecryptKey);
						Cursor.Current = Cursors.Default;
						File.Delete(this.cashClsUploadFullPath);
						File.Delete(this.cashClsFullPath + ".aes");
					}
					foreach (string text in Directory.GetFiles(MyGlobalClass.batchDirectory, "*.aes"))
					{
						FileInfo fileInfo = new FileInfo(text);
						bool isPi2 = MyGlobalClass.isPi;
						string text2;
						if (isPi2)
						{
							text2 = MyGlobalClass.batchArchiveDirectory + "/" + fileInfo.Name.Replace(".aes", "");
						}
						else
						{
							text2 = MyGlobalClass.batchArchiveDirectory + "\\" + fileInfo.Name.Replace(".aes", "");
						}
						Cursor.Current = Cursors.WaitCursor;
						Application.DoEvents();
						clsEncryptDecrypt.FileDecrypt(text, text.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
						Cursor.Current = Cursors.Default;
						string[] array = File.ReadAllLines(text.Replace(".aes", ""));
						File.Delete(text.Replace(".aes", ""));
						array[0] = text2;
						File.WriteAllLines(text2, array);
						Cursor.Current = Cursors.WaitCursor;
						Application.DoEvents();
						clsEncryptDecrypt.FileEncrypt(text2, MyGlobalClass.FileEncryptDecryptKey);
						Cursor.Current = Cursors.Default;
						File.Delete(text2);
						File.Delete(text);
					}
					foreach (string text3 in Directory.GetFiles(MyGlobalClass.batchUploadDirectory, "*.aes"))
					{
						FileInfo fileInfo2 = new FileInfo(text3);
						bool isPi3 = MyGlobalClass.isPi;
						string text2;
						if (isPi3)
						{
							text2 = MyGlobalClass.batchArchiveUploadDirectory + "/" + fileInfo2.Name.Replace(".aes", "");
						}
						else
						{
							text2 = MyGlobalClass.batchArchiveUploadDirectory + "\\" + fileInfo2.Name.Replace(".aes", "");
						}
						Cursor.Current = Cursors.WaitCursor;
						Application.DoEvents();
						clsEncryptDecrypt.FileDecrypt(text3, text3.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
						Cursor.Current = Cursors.Default;
						string[] array = File.ReadAllLines(text3.Replace(".aes", ""));
						File.Delete(text3.Replace(".aes", ""));
						array[0] = text2;
						File.WriteAllLines(text2, array);
						Cursor.Current = Cursors.WaitCursor;
						Application.DoEvents();
						clsEncryptDecrypt.FileEncrypt(text2, MyGlobalClass.FileEncryptDecryptKey);
						Cursor.Current = Cursors.Default;
						File.Delete(text2);
						File.Delete(text3);
					}
					this.myButtonEnableDisable(true);
					MessageBox.Show("Cash Clearance completed.");
					((frmInitialPage)base.ParentForm).loadinForm("Login");
				}
				else
				{
					this.IncorrectCount++;
					this.EnteredPIN = "";
					this.lblPin.Text = new string('*', this.EnteredPIN.Length) + new string('-', 4 - this.EnteredPIN.Length);
				}
			}
			bool flag7 = this.IncorrectCount > 4;
			if (flag7)
			{
				((frmInitialPage)base.ParentForm).loadinForm("Login");
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000049B4 File Offset: 0x00002BB4
		private void btn_0_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "0";
			this.drawPIN();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000049D4 File Offset: 0x00002BD4
		private void btn_1_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "1";
			this.drawPIN();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000049F4 File Offset: 0x00002BF4
		private void btn_2_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "2";
			this.drawPIN();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004A14 File Offset: 0x00002C14
		private void btn_3_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "3";
			this.drawPIN();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004A34 File Offset: 0x00002C34
		private void btn_4_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "4";
			this.drawPIN();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004A54 File Offset: 0x00002C54
		private void btn_5_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "5";
			this.drawPIN();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004A74 File Offset: 0x00002C74
		private void btn_6_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "6";
			this.drawPIN();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004A94 File Offset: 0x00002C94
		private void btn_7_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "7";
			this.drawPIN();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004AB4 File Offset: 0x00002CB4
		private void btn_8_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "8";
			this.drawPIN();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004AD4 File Offset: 0x00002CD4
		private void btn_9_Click(object sender, EventArgs e)
		{
			this.EnteredPIN += "9";
			this.drawPIN();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004AF4 File Offset: 0x00002CF4
		public void SubmitCashClearanceToFernwareEncrypt(string datetime, clsUsers objUser)
		{
			string rpiSerial = MyGlobalClass.GetRpiSerial();
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/setStoreCashClearanceEncrypt.php";
			string text2 = string.Concat(new string[]
			{
				rpiSerial,
				"@Q@",
				datetime,
				"@Q@",
				objUser.ID.ToString(),
				"@Q@",
				DateTime.Now.ToString("yyyyMMddHHmmss")
			});
			string text3 = clsEncryptDecrypt.StringEncrypt(text2, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection { 
				{
					"data",
					text3.ToString()
				} };
				webClient.UploadValues(text, nameValueCollection);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004BDC File Offset: 0x00002DDC
		public void myButtonEnableDisable(bool isEnabled)
		{
			foreach (object obj in base.Controls)
			{
				bool flag = obj.GetType() == new Button().GetType();
				if (flag)
				{
					Button button = (Button)obj;
					button.Enabled = isEnabled;
				}
			}
			Application.DoEvents();
		}

		// Token: 0x0400002A RID: 42
		private string EnteredPIN = "";

		// Token: 0x0400002B RID: 43
		private int IncorrectCount = 0;

		// Token: 0x0400002C RID: 44
		private string cashClsFullPath = "";

		// Token: 0x0400002D RID: 45
		private string cashClsUploadFullPath = "";
	}
}
