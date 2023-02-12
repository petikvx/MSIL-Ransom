using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using M_POST_for_EBDS_Demo_In_CSharp_DotNet.Properties;
using Newtonsoft.Json;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000B RID: 11
	public partial class frmInitialPage : Form
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00006184 File Offset: 0x00004384
		public frmInitialPage()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000619C File Offset: 0x0000439C
		private void frmInitialPage_Load(object sender, EventArgs e)
		{
			MyGlobalClass.CheckDevelopPC();
			MyGlobalClass.isDevelop = true;
			MyGlobalClass.ListOfUsers = new List<clsUsers>();
			MyGlobalClass.ListOfServiceProviders = new List<clsServiceProviders>();
			MyGlobalClass.StoreID = 0;
			MyGlobalClass.StoreName = "";
			MyGlobalClass.initialDirectory = Application.StartupPath;
			MyGlobalClass.isPi = MyGlobalClass.initialDirectory.Contains("home/pi");
			MyGlobalClass.dfgFileName = "dfg.dat";
			MyGlobalClass.WebServerHostName = "http://fernware11.fernware.co.nz";
			MyGlobalClass.FileEncryptDecryptKey = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName.ToLower().Replace(" ", "_");
			MyGlobalClass.dfgKeyFileName = "dfgk.dat";
			MyGlobalClass.StringEncryptDecryptKey = "";
			MyGlobalClass.StringEncryptDecryptIV = "";
			bool isPi = MyGlobalClass.isPi;
			if (isPi)
			{
				MyGlobalClass.dfgDirectory = MyGlobalClass.initialDirectory + "/data";
				MyGlobalClass.dfgFullPath = MyGlobalClass.dfgDirectory + "/" + MyGlobalClass.dfgFileName;
				MyGlobalClass.dfgKeyFullPath = MyGlobalClass.dfgDirectory + "/" + MyGlobalClass.dfgKeyFileName;
				MyGlobalClass.batchDirectory = MyGlobalClass.initialDirectory + "/bankBatches";
				MyGlobalClass.batchUploadDirectory = MyGlobalClass.initialDirectory + "/bankBatches/upload";
				MyGlobalClass.batchArchiveDirectory = MyGlobalClass.initialDirectory + "/bankBatches/archive";
				MyGlobalClass.batchArchiveUploadDirectory = MyGlobalClass.initialDirectory + "/bankBatches/archive/upload";
				MyGlobalClass.batchErrorDirectory = MyGlobalClass.initialDirectory + "/bankBatches/error";
				MyGlobalClass.cashClsDirectory = MyGlobalClass.initialDirectory + "/cashCls";
				MyGlobalClass.cashClsUploadDirectory = MyGlobalClass.initialDirectory + "/cashCls/upload";
				MyGlobalClass.cashClsErrorDirectory = MyGlobalClass.initialDirectory + "/cashCls/error";
			}
			else
			{
				MyGlobalClass.dfgDirectory = MyGlobalClass.initialDirectory + "\\data";
				MyGlobalClass.dfgFullPath = MyGlobalClass.dfgDirectory + "\\" + MyGlobalClass.dfgFileName;
				MyGlobalClass.dfgKeyFullPath = MyGlobalClass.dfgDirectory + "\\" + MyGlobalClass.dfgKeyFileName;
				MyGlobalClass.batchDirectory = MyGlobalClass.initialDirectory + "\\bankBatches";
				MyGlobalClass.batchUploadDirectory = MyGlobalClass.initialDirectory + "\\bankBatches\\upload";
				MyGlobalClass.batchArchiveDirectory = MyGlobalClass.initialDirectory + "\\bankBatches\\archive";
				MyGlobalClass.batchArchiveUploadDirectory = MyGlobalClass.initialDirectory + "\\bankBatches\\archive\\upload";
				MyGlobalClass.batchErrorDirectory = MyGlobalClass.initialDirectory + "\\bankBatches\\error";
				MyGlobalClass.cashClsDirectory = MyGlobalClass.initialDirectory + "\\cashCls";
				MyGlobalClass.cashClsUploadDirectory = MyGlobalClass.initialDirectory + "\\cashCls\\upload";
				MyGlobalClass.cashClsErrorDirectory = MyGlobalClass.initialDirectory + "\\cashCls\\error";
			}
			Directory.CreateDirectory(MyGlobalClass.dfgDirectory);
			Directory.CreateDirectory(MyGlobalClass.batchDirectory);
			Directory.CreateDirectory(MyGlobalClass.batchUploadDirectory);
			Directory.CreateDirectory(MyGlobalClass.batchArchiveDirectory);
			Directory.CreateDirectory(MyGlobalClass.batchArchiveUploadDirectory);
			Directory.CreateDirectory(MyGlobalClass.batchErrorDirectory);
			Directory.CreateDirectory(MyGlobalClass.cashClsDirectory);
			Directory.CreateDirectory(MyGlobalClass.cashClsUploadDirectory);
			Directory.CreateDirectory(MyGlobalClass.cashClsErrorDirectory);
			bool flag = false;
			bool flag2 = false;
			bool flag3 = MyGlobalClass.AcknowledgementToFernware();
			if (flag3)
			{
				this.initialKeyValue();
				this.saveKeyValue();
				this.loadServiceProviders();
				this.initialStoreID();
				bool flag4 = MyGlobalClass.StoreID == 0;
				if (flag4)
				{
					flag2 = true;
					goto IL_3E2;
				}
				this.initialUserAccount();
				this.saveUserAccount();
			}
			else
			{
				this.loadLocalKeyValue();
				bool flag5 = MyGlobalClass.StringEncryptDecryptKey.Length != 32 || MyGlobalClass.StringEncryptDecryptIV.Length != 32;
				if (flag5)
				{
					MessageBox.Show("Unable to process initial setup for the Device. {KeyValue}", "Fail connecting to Server");
					flag = true;
					goto IL_3FE;
				}
				this.loadLocalStoreID();
				bool flag6 = MyGlobalClass.StoreID == 0;
				if (flag6)
				{
					MessageBox.Show("Unable to process initial setup for the Device. {Store}", "Fail connecting to Server");
					flag = true;
					goto IL_3FE;
				}
				this.loadLocalUserAccount();
			}
			bool flag7 = MyGlobalClass.ListOfUsers.Count == 0;
			if (flag7)
			{
				this.loadTempUserAccount();
			}
			this.loadinForm("Login");
			IL_3E2:
			bool flag8 = flag2;
			if (flag8)
			{
				MyGlobalClass.tmpStoreID = 0;
				this.loadinForm("frmStoreSelectionLogin");
			}
			IL_3FE:
			bool flag9 = flag;
			if (flag9)
			{
				base.Close();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000065B8 File Offset: 0x000047B8
		private void loadServiceProviders()
		{
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/getServiceProvider.php";
			List<clsServiceProviders> list;
			using (WebClient webClient = new WebClient())
			{
				string text2 = webClient.DownloadString(text);
				list = JsonConvert.DeserializeObject<List<clsServiceProviders>>(text2);
			}
			bool flag = list.Count > 0;
			if (flag)
			{
				foreach (clsServiceProviders clsServiceProviders in list)
				{
					MyGlobalClass.ListOfServiceProviders.Add(clsServiceProviders);
				}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00006664 File Offset: 0x00004864
		private void initialUserAccount()
		{
			string text = "";
			text = MyGlobalClass.GetRpiSerial();
			string text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getUserByDevice.php";
			List<clsUsers> list;
			using (WebClient webClient = new WebClient())
			{
				string text3 = webClient.DownloadString(text2 + "?serial=" + text);
				list = JsonConvert.DeserializeObject<List<clsUsers>>(text3);
			}
			bool flag = list.Count > 0;
			if (flag)
			{
				foreach (clsUsers clsUsers in list)
				{
					MyGlobalClass.ListOfUsers.Add(clsUsers);
				}
			}
			text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getServiceProviderByDevice.php";
			using (WebClient webClient2 = new WebClient())
			{
				string text4 = webClient2.DownloadString(text2 + "?serial=" + text);
				list = JsonConvert.DeserializeObject<List<clsUsers>>(text4);
			}
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				foreach (clsUsers clsUsers2 in list)
				{
					MyGlobalClass.ListOfUsers.Add(clsUsers2);
				}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000067D4 File Offset: 0x000049D4
		public void saveUserAccount()
		{
			bool flag = MyGlobalClass.ListOfUsers.Count > 0;
			if (flag)
			{
				string text = "";
				foreach (clsUsers clsUsers in MyGlobalClass.ListOfUsers)
				{
					text = text + clsUsers.outputString() + "#";
				}
				text = text.Substring(0, text.Length - 1);
				File.WriteAllText(MyGlobalClass.dfgFullPath, text);
				clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(MyGlobalClass.dfgFullPath, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(MyGlobalClass.dfgFullPath);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000068B0 File Offset: 0x00004AB0
		private void initialStoreID()
		{
			string rpiSerial = MyGlobalClass.GetRpiSerial();
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/getStoreIDByDevice.php";
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection { 
				{
					"serial",
					rpiSerial.ToString()
				} };
				MyGlobalClass.StoreID = int.Parse(Encoding.UTF8.GetString(webClient.UploadValues(text, nameValueCollection)));
				bool flag = MyGlobalClass.StoreID != 0;
				if (flag)
				{
					bool flag2 = Settings.Default["StoreID"].ToString() != MyGlobalClass.StoreID.ToString();
					if (flag2)
					{
						Settings.Default["StoreID"] = MyGlobalClass.StoreID.ToString();
						Settings.Default.Save();
					}
				}
			}
			bool flag3 = MyGlobalClass.StoreID != 0;
			if (flag3)
			{
				text = MyGlobalClass.WebServerHostName + "/rp1/queries/getStoreNameByStoreID.php";
				using (WebClient webClient2 = new WebClient())
				{
					NameValueCollection nameValueCollection2 = new NameValueCollection { 
					{
						"storeid",
						MyGlobalClass.StoreID.ToString()
					} };
					MyGlobalClass.StoreName = Encoding.UTF8.GetString(webClient2.UploadValues(text, nameValueCollection2));
					bool flag4 = Settings.Default["StoreName"].ToString() != MyGlobalClass.StoreName;
					if (flag4)
					{
						Settings.Default["StoreName"] = MyGlobalClass.StoreName;
						Settings.Default.Save();
					}
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006A58 File Offset: 0x00004C58
		private void loadTempUserAccount()
		{
			clsUsers clsUsers = new clsUsers();
			clsUsers.Passcode = "0000";
			clsUsers.DeviceAccess = 1;
			clsUsers.PermissionLevel = 4;
			MyGlobalClass.ListOfUsers.Add(clsUsers);
			clsUsers = new clsUsers();
			clsUsers.Passcode = DateTime.Today.ToString("MMdd");
			clsUsers.DeviceAccess = 1;
			clsUsers.PermissionLevel = 0;
			MyGlobalClass.ListOfUsers.Add(clsUsers);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006AD0 File Offset: 0x00004CD0
		private void loadLocalUserAccount()
		{
			clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
			Cursor.Current = Cursors.WaitCursor;
			Application.DoEvents();
			clsEncryptDecrypt.FileDecrypt(MyGlobalClass.dfgFullPath + ".aes", MyGlobalClass.dfgFullPath, MyGlobalClass.FileEncryptDecryptKey);
			Cursor.Current = Cursors.Default;
			string text = File.ReadAllText(MyGlobalClass.dfgFullPath);
			File.Delete(MyGlobalClass.dfgFullPath);
			string[] array = text.Split(new char[] { '#' });
			foreach (string text2 in array)
			{
				clsUsers clsUsers = new clsUsers(text2);
				bool flag = clsUsers.ID != 0;
				if (flag)
				{
					MyGlobalClass.ListOfUsers.Add(clsUsers);
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006B93 File Offset: 0x00004D93
		private void loadLocalStoreID()
		{
			MyGlobalClass.StoreID = int.Parse((string)Settings.Default["StoreID"]);
			MyGlobalClass.StoreName = (string)Settings.Default["StoreName"];
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006BD0 File Offset: 0x00004DD0
		private void uploadStoreID(int storeid)
		{
			string rpiSerial = MyGlobalClass.GetRpiSerial();
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/setStoreIDByDevice.php";
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection
				{
					{ "serial", rpiSerial },
					{
						"storeid",
						storeid.ToString()
					}
				};
				webClient.UploadValues(text, nameValueCollection);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006C50 File Offset: 0x00004E50
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

		// Token: 0x06000092 RID: 146 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public void CloseMe()
		{
			base.Close();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006CE0 File Offset: 0x00004EE0
		public void RestartInitialProcess()
		{
			bool flag = false;
			bool flag2 = MyGlobalClass.tmpStoreID != 0;
			if (flag2)
			{
				this.uploadStoreID(MyGlobalClass.tmpStoreID);
				MyGlobalClass.tmpStoreID = 0;
				bool flag3 = MyGlobalClass.AcknowledgementToFernware();
				if (flag3)
				{
					this.initialStoreID();
					bool flag4 = MyGlobalClass.StoreID == 0;
					if (flag4)
					{
						flag = true;
						goto IL_101;
					}
					this.initialUserAccount();
					this.saveUserAccount();
				}
				else
				{
					this.loadLocalKeyValue();
					bool flag5 = MyGlobalClass.StringEncryptDecryptKey.Length != 32 || MyGlobalClass.StringEncryptDecryptIV.Length != 32;
					if (flag5)
					{
						MessageBox.Show("Unable to process initial setup for the Device. {KeyValue}", "Fail connecting to Server");
						flag = true;
						goto IL_101;
					}
					this.loadLocalStoreID();
					bool flag6 = MyGlobalClass.StoreID == 0;
					if (flag6)
					{
						flag = true;
						MessageBox.Show("Unable to process initial setup for the Device.", "Fail connecting to Server");
						goto IL_101;
					}
					this.loadLocalUserAccount();
				}
				bool flag7 = MyGlobalClass.ListOfUsers.Count == 0;
				if (flag7)
				{
					this.loadTempUserAccount();
				}
				this.loadinForm("Login");
			}
			else
			{
				flag = true;
			}
			IL_101:
			bool flag8 = flag;
			if (flag8)
			{
				base.Close();
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006E00 File Offset: 0x00005000
		public void ReloadUserAccount()
		{
			MyGlobalClass.ListOfUsersTemp = new List<clsUsers>();
			string text = "";
			text = MyGlobalClass.GetRpiSerial();
			string text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getUserByDevice.php";
			List<clsUsers> list;
			using (WebClient webClient = new WebClient())
			{
				string text3 = webClient.DownloadString(text2 + "?serial=" + text);
				list = JsonConvert.DeserializeObject<List<clsUsers>>(text3);
			}
			bool flag = list.Count > 0;
			if (flag)
			{
				foreach (clsUsers clsUsers in list)
				{
					MyGlobalClass.ListOfUsersTemp.Add(clsUsers);
				}
			}
			text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getServiceProviderByDevice.php";
			using (WebClient webClient2 = new WebClient())
			{
				string text4 = webClient2.DownloadString(text2 + "?serial=" + text);
				list = JsonConvert.DeserializeObject<List<clsUsers>>(text4);
			}
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				foreach (clsUsers clsUsers2 in list)
				{
					MyGlobalClass.ListOfUsersTemp.Add(clsUsers2);
				}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006F7C File Offset: 0x0000517C
		private void initialKeyValue()
		{
			string text = "";
			string text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getKey.php";
			using (WebClient webClient = new WebClient())
			{
				try
				{
					text = Encoding.UTF8.GetString(webClient.UploadValues(text2, new NameValueCollection()));
				}
				catch
				{
				}
			}
			MyGlobalClass.StringEncryptDecryptKey = text;
			string text3 = "";
			text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getValue.php";
			using (WebClient webClient2 = new WebClient())
			{
				try
				{
					text3 = Encoding.UTF8.GetString(webClient2.UploadValues(text2, new NameValueCollection()));
				}
				catch
				{
				}
			}
			MyGlobalClass.StringEncryptDecryptIV = text3;
			string text4 = "";
			text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/getHelp.php";
			using (WebClient webClient3 = new WebClient())
			{
				try
				{
					text4 = Encoding.UTF8.GetString(webClient3.UploadValues(text2, new NameValueCollection()));
				}
				catch
				{
				}
			}
			bool flag = text4.Length == 32;
			if (flag)
			{
				MyGlobalClass.StringEncryptDecryptKey += text4.Substring(0, 16);
				MyGlobalClass.StringEncryptDecryptIV = text4.Substring(16) + MyGlobalClass.StringEncryptDecryptIV;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007110 File Offset: 0x00005310
		public void saveKeyValue()
		{
			bool flag = MyGlobalClass.StringEncryptDecryptKey.Length > 0 && MyGlobalClass.StringEncryptDecryptIV.Length > 0;
			if (flag)
			{
				File.WriteAllText(MyGlobalClass.dfgKeyFullPath, MyGlobalClass.StringEncryptDecryptKey + MyGlobalClass.StringEncryptDecryptIV);
				clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(MyGlobalClass.dfgKeyFullPath, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(MyGlobalClass.dfgKeyFullPath);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000719C File Offset: 0x0000539C
		private void loadLocalKeyValue()
		{
			clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
			Cursor.Current = Cursors.WaitCursor;
			Application.DoEvents();
			clsEncryptDecrypt.FileDecrypt(MyGlobalClass.dfgKeyFullPath + ".aes", MyGlobalClass.dfgKeyFullPath, MyGlobalClass.FileEncryptDecryptKey);
			Cursor.Current = Cursors.Default;
			string text = File.ReadAllText(MyGlobalClass.dfgKeyFullPath);
			File.Delete(MyGlobalClass.dfgKeyFullPath);
			bool flag = text.Length == 64;
			if (flag)
			{
				MyGlobalClass.StringEncryptDecryptKey = text.Substring(0, 32);
				MyGlobalClass.StringEncryptDecryptIV = text.Substring(32);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007234 File Offset: 0x00005434
		public void loadinForm(string FormName)
		{
			this.pnlSubSystem.Controls.Clear();
			string text = FormName.ToLower();
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			Form form;
			if (num <= 1788108677U)
			{
				if (num <= 541892530U)
				{
					if (num != 380372917U)
					{
						if (num == 541892530U)
						{
							if (text == "batchhistorylogin")
							{
								form = new BatchHistoryLogin();
								goto IL_1C3;
							}
						}
					}
					else if (text == "frmstoreselection")
					{
						form = new frmStoreSelection();
						goto IL_1C3;
					}
				}
				else if (num != 1327828866U)
				{
					if (num != 1745255176U)
					{
						if (num == 1788108677U)
						{
							if (text == "mainlogin")
							{
								form = new MainLogin();
								goto IL_1C3;
							}
						}
					}
					else if (text == "settings")
					{
						form = new Settings();
						goto IL_1C3;
					}
				}
				else if (text == "frmstoreselectionlogin")
				{
					form = new frmStoreSelectionLogin();
					goto IL_1C3;
				}
			}
			else if (num <= 2256304657U)
			{
				if (num != 1863811583U)
				{
					if (num == 2256304657U)
					{
						if (text == "frmpreviewdecrypt")
						{
							form = new frmPreviewDecrypt();
							goto IL_1C3;
						}
					}
				}
				else if (text == "cashclslogin")
				{
					form = new CashClsLogin();
					goto IL_1C3;
				}
			}
			else if (num != 2783109957U)
			{
				if (num != 3380555570U)
				{
					if (num == 3935363592U)
					{
						if (text == "main")
						{
							form = new Main();
							goto IL_1C3;
						}
					}
				}
				else if (text == "login")
				{
					form = new Login();
					goto IL_1C3;
				}
			}
			else if (text == "batchhistory")
			{
				form = new BatchHistory();
				goto IL_1C3;
			}
			form = new Login();
			IL_1C3:
			form.TopLevel = false;
			this.pnlSubSystem.Controls.Add(form);
			form.Dock = DockStyle.Fill;
			form.Show();
		}
	}
}
