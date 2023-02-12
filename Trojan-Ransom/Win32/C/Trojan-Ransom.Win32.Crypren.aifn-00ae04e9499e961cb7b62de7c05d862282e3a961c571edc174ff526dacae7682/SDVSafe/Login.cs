using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000F RID: 15
	public partial class Login : Form
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00009278 File Offset: 0x00007478
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009290 File Offset: 0x00007490
		private void btnHistory_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("BatchHistoryLogin");
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000092A9 File Offset: 0x000074A9
		private void btnLogin_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("MainLogin");
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000092C2 File Offset: 0x000074C2
		private void btnSettings_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Settings");
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000092DC File Offset: 0x000074DC
		private void Login_Load(object sender, EventArgs e)
		{
			this.lblHeader.Text = string.Concat(new string[]
			{
				"SDVSafe - ",
				MyGlobalClass.StoreName,
				" (#",
				MyGlobalClass.StoreID.ToString().PadLeft(4, '0'),
				")"
			});
			this.timer30m.Stop();
			this.timer30m.Start();
			this.RefreshAck();
			this.fnDoorSwitch();
			bool isDevelop = MyGlobalClass.isDevelop;
			if (isDevelop)
			{
				this.btnDoorSwitch.Visible = true;
				this.button1.Visible = true;
				this.button2.Visible = true;
			}
			else
			{
				this.btnDoorSwitch.Visible = false;
				this.button1.Visible = false;
				this.button2.Visible = false;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000093B9 File Offset: 0x000075B9
		private void timer30m_Tick(object sender, EventArgs e)
		{
			this.RefreshAck();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000093C4 File Offset: 0x000075C4
		public void RefreshAck()
		{
			bool flag = MyGlobalClass.AcknowledgementToFernware();
			if (flag)
			{
				this.lblRed.BackColor = Color.Silver;
				this.lblGreen.BackColor = Color.LimeGreen;
				this.myButtonEnableDisable(false);
				this.CheckBankBatchesCashClsPending();
				this.CheckCashClsPending();
				this.CheckBankBatchesPending();
				((frmInitialPage)base.ParentForm).ReloadUserAccount();
				bool flag2 = MyGlobalClass.ListOfUsersTemp.Count > 0;
				if (flag2)
				{
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = MyGlobalClass.ListOfUsersTemp.Count != MyGlobalClass.ListOfUsers.Count;
					if (flag5)
					{
						flag3 = true;
					}
					else
					{
						foreach (clsUsers clsUsers in MyGlobalClass.ListOfUsersTemp)
						{
							flag4 = false;
							foreach (clsUsers clsUsers2 in MyGlobalClass.ListOfUsers)
							{
								bool flag6 = clsUsers.ID == clsUsers2.ID;
								if (flag6)
								{
									flag4 = true;
									bool flag7 = clsUsers.Passcode != clsUsers2.Passcode || clsUsers.PermissionLevel != clsUsers2.PermissionLevel;
									if (flag7)
									{
										flag3 = true;
										goto IL_172;
									}
									break;
								}
							}
							bool flag8 = !flag4;
							if (flag8)
							{
								flag3 = true;
								break;
							}
						}
					}
					IL_172:
					bool flag9 = flag3;
					if (flag9)
					{
						MyGlobalClass.ListOfUsers = MyGlobalClass.ListOfUsersTemp;
						((frmInitialPage)base.ParentForm).saveUserAccount();
					}
				}
				this.myButtonEnableDisable(true);
			}
			else
			{
				this.lblRed.BackColor = Color.LightCoral;
				this.lblGreen.BackColor = Color.Silver;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000095B4 File Offset: 0x000077B4
		private void btnCashCls_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("CashClsLogin");
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000095CD File Offset: 0x000077CD
		private void btnDoorSwitch_Click(object sender, EventArgs e)
		{
			this.fnDoorSwitch();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000095D8 File Offset: 0x000077D8
		public void fnDoorSwitch()
		{
			bool flag = this.btnDoorSwitch.Text == "";
			if (flag)
			{
				this.btnDoorSwitch.Text = "Open";
				this.btnCashCls.Visible = false;
			}
			else
			{
				bool flag2 = this.btnDoorSwitch.Text == "Close";
				if (flag2)
				{
					this.btnDoorSwitch.Text = "Open";
					this.btnCashCls.Visible = false;
				}
				else
				{
					bool flag3 = this.btnDoorSwitch.Text == "Open";
					if (flag3)
					{
						this.btnDoorSwitch.Text = "Close";
						this.btnCashCls.Visible = true;
					}
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009698 File Offset: 0x00007898
		public void CheckCashClsPending()
		{
			clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
			foreach (string text in Directory.GetFiles(MyGlobalClass.cashClsDirectory, "*.aes"))
			{
				FileInfo fileInfo = new FileInfo(text);
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileDecrypt(text, text.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				string text2 = File.ReadAllText(text.Replace(".aes", ""));
				File.Delete(text.Replace(".aes", ""));
				bool flag = text2 == text.Replace(".aes", "");
				if (flag)
				{
					string[] array = fileInfo.Name.Split(new char[] { '_' });
					string text3 = array[1].Replace(".dat.aes", "");
					array = fileInfo.Name.Split(new char[] { '_' });
					string text4 = array[0].Replace("-", "");
					int num;
					bool flag2 = !int.TryParse(text3, out num);
					if (flag2)
					{
						text3 = "0";
					}
					bool flag3 = text4.Length != 14;
					if (flag3)
					{
						text4 = DateTime.Now.ToString("yyyyMMddHHmmss");
					}
					this.SubmitCashClearanceToFernwareEncrypt(text4, text3);
					bool isPi = MyGlobalClass.isPi;
					string text5;
					if (isPi)
					{
						text5 = MyGlobalClass.cashClsUploadDirectory + "/" + fileInfo.Name.Replace(".aes", "");
					}
					else
					{
						text5 = MyGlobalClass.cashClsUploadDirectory + "\\" + fileInfo.Name.Replace(".aes", "");
					}
					File.WriteAllText(text5, text5);
					Cursor.Current = Cursors.WaitCursor;
					Application.DoEvents();
					clsEncryptDecrypt.FileEncrypt(text5, MyGlobalClass.FileEncryptDecryptKey);
					Cursor.Current = Cursors.Default;
					File.Delete(text5);
					File.Delete(text);
				}
				else
				{
					bool isPi2 = MyGlobalClass.isPi;
					if (isPi2)
					{
						File.Move(text, MyGlobalClass.cashClsErrorDirectory + "/" + fileInfo.Name);
					}
					else
					{
						File.Move(text, MyGlobalClass.cashClsErrorDirectory + "\\" + fileInfo.Name);
					}
				}
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009928 File Offset: 0x00007B28
		public void SubmitCashClearanceToFernwareEncrypt(string datetime, string userid)
		{
			string rpiSerial = MyGlobalClass.GetRpiSerial();
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/setStoreCashClearanceEncrypt.php";
			string text2 = string.Concat(new string[]
			{
				rpiSerial,
				"@Q@",
				datetime,
				"@Q@",
				userid,
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

		// Token: 0x060000C7 RID: 199 RVA: 0x00009A04 File Offset: 0x00007C04
		private void button1_Click(object sender, EventArgs e)
		{
			this.myButtonEnableDisable(false);
			clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
			foreach (string text in Directory.GetFiles(MyGlobalClass.batchDirectory, "*.dat"))
			{
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(text, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(text);
			}
			foreach (string text2 in Directory.GetFiles(MyGlobalClass.batchUploadDirectory, "*.dat"))
			{
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(text2, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(text2);
			}
			foreach (string text3 in Directory.GetFiles(MyGlobalClass.batchArchiveDirectory, "*.dat"))
			{
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(text3, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(text3);
			}
			foreach (string text4 in Directory.GetFiles(MyGlobalClass.batchArchiveUploadDirectory, "*.dat"))
			{
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(text4, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(text4);
			}
			this.myButtonEnableDisable(true);
			MessageBox.Show("Encryption Completed.");
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009BA8 File Offset: 0x00007DA8
		public void CheckBankBatchesCashClsPending()
		{
			int num = 0;
			int num2 = 0;
			clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
			try
			{
				foreach (string text in Directory.GetFiles(MyGlobalClass.batchArchiveDirectory, "*.aes"))
				{
					FileInfo fileInfo = new FileInfo(text);
					Cursor.Current = Cursors.WaitCursor;
					Application.DoEvents();
					clsEncryptDecrypt.FileDecrypt(text, text.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
					Cursor.Current = Cursors.Default;
					string[] array = File.ReadAllLines(text.Replace(".aes", ""));
					File.Delete(text.Replace(".aes", ""));
					bool flag = array.Length > 1;
					if (flag)
					{
						bool flag2 = array[0] == text.Replace(".aes", "");
						if (flag2)
						{
							clsBankBatchData clsBankBatchData = new clsBankBatchData();
							string[] array2 = fileInfo.Name.Split(new char[] { '_' });
							string text2 = array2[1].Replace(".dat.aes", "");
							array2 = fileInfo.Name.Split(new char[] { '_' });
							string text3 = array2[0].Replace("-", "");
							int.TryParse(text2, out num);
							bool flag3 = text3.Length != 14;
							if (flag3)
							{
								text3 = DateTime.Now.ToString("yyyyMMddHHmmss");
							}
							clsBankBatchData.DepositDateTime = text3;
							clsBankBatchData.UserID = num;
							for (int j = 1; j < array.Length; j++)
							{
								num2 = 0;
								bool flag4 = array[j].Contains(",");
								if (flag4)
								{
									string text4 = array[j].Split(new char[] { ',' })[0];
									if (!(text4 == "5"))
									{
										if (!(text4 == "10"))
										{
											if (!(text4 == "20"))
											{
												if (!(text4 == "50"))
												{
													if (text4 == "100")
													{
														int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
														clsBankBatchData.Hundred = num2;
													}
												}
												else
												{
													int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
													clsBankBatchData.Fifty = num2;
												}
											}
											else
											{
												int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
												clsBankBatchData.Twenty = num2;
											}
										}
										else
										{
											int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
											clsBankBatchData.Ten = num2;
										}
									}
									else
									{
										int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
										clsBankBatchData.Five = num2;
									}
								}
							}
							clsBankBatchData.RefreshTotal();
							this.SubmitBankBatchesToFernwareEncrypt(clsBankBatchData);
							bool isPi = MyGlobalClass.isPi;
							string text5;
							if (isPi)
							{
								text5 = MyGlobalClass.batchArchiveUploadDirectory + "/" + fileInfo.Name.Replace(".aes", "");
							}
							else
							{
								text5 = MyGlobalClass.batchArchiveUploadDirectory + "\\" + fileInfo.Name.Replace(".aes", "");
							}
							string text6 = text5 + Environment.NewLine + clsBankBatchData.outputString();
							File.WriteAllText(text5, text6);
							Cursor.Current = Cursors.WaitCursor;
							Application.DoEvents();
							clsEncryptDecrypt.FileEncrypt(text5, MyGlobalClass.FileEncryptDecryptKey);
							Cursor.Current = Cursors.Default;
							File.Delete(text5);
							File.Delete(text);
						}
						else
						{
							bool isPi2 = MyGlobalClass.isPi;
							if (isPi2)
							{
								File.Move(text, MyGlobalClass.batchErrorDirectory + "/" + fileInfo.Name);
							}
							else
							{
								File.Move(text, MyGlobalClass.batchErrorDirectory + "\\" + fileInfo.Name);
							}
						}
					}
					else
					{
						bool isPi3 = MyGlobalClass.isPi;
						if (isPi3)
						{
							File.Move(text, MyGlobalClass.batchErrorDirectory + "/" + fileInfo.Name);
						}
						else
						{
							File.Move(text, MyGlobalClass.batchErrorDirectory + "\\" + fileInfo.Name);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000A064 File Offset: 0x00008264
		public void CheckBankBatchesPending()
		{
			int num = 0;
			int num2 = 0;
			clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
			try
			{
				foreach (string text in Directory.GetFiles(MyGlobalClass.batchDirectory, "*.aes"))
				{
					FileInfo fileInfo = new FileInfo(text);
					Cursor.Current = Cursors.WaitCursor;
					Application.DoEvents();
					clsEncryptDecrypt.FileDecrypt(text, text.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
					Cursor.Current = Cursors.Default;
					string[] array = File.ReadAllLines(text.Replace(".aes", ""));
					File.Delete(text.Replace(".aes", ""));
					bool flag = array.Length > 1;
					if (flag)
					{
						bool flag2 = array[0] == text.Replace(".aes", "");
						if (flag2)
						{
							clsBankBatchData clsBankBatchData = new clsBankBatchData();
							string[] array2 = fileInfo.Name.Split(new char[] { '_' });
							string text2 = array2[1].Replace(".dat.aes", "");
							array2 = fileInfo.Name.Split(new char[] { '_' });
							string text3 = array2[0].Replace("-", "");
							int.TryParse(text2, out num);
							bool flag3 = text3.Length != 14;
							if (flag3)
							{
								text3 = DateTime.Now.ToString("yyyyMMddHHmmss");
							}
							clsBankBatchData.DepositDateTime = text3;
							clsBankBatchData.UserID = num;
							for (int j = 1; j < array.Length; j++)
							{
								num2 = 0;
								bool flag4 = array[j].Contains(",");
								if (flag4)
								{
									string text4 = array[j].Split(new char[] { ',' })[0];
									if (!(text4 == "5"))
									{
										if (!(text4 == "10"))
										{
											if (!(text4 == "20"))
											{
												if (!(text4 == "50"))
												{
													if (text4 == "100")
													{
														int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
														clsBankBatchData.Hundred = num2;
													}
												}
												else
												{
													int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
													clsBankBatchData.Fifty = num2;
												}
											}
											else
											{
												int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
												clsBankBatchData.Twenty = num2;
											}
										}
										else
										{
											int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
											clsBankBatchData.Ten = num2;
										}
									}
									else
									{
										int.TryParse(array[j].Split(new char[] { ',' })[1], out num2);
										clsBankBatchData.Five = num2;
									}
								}
							}
							clsBankBatchData.RefreshTotal();
							this.SubmitBankBatchesToFernwareEncrypt(clsBankBatchData);
							bool isPi = MyGlobalClass.isPi;
							string text5;
							if (isPi)
							{
								text5 = MyGlobalClass.batchUploadDirectory + "/" + fileInfo.Name.Replace(".aes", "");
							}
							else
							{
								text5 = MyGlobalClass.batchUploadDirectory + "\\" + fileInfo.Name.Replace(".aes", "");
							}
							string text6 = text5 + Environment.NewLine + clsBankBatchData.outputString();
							File.WriteAllText(text5, text6);
							Cursor.Current = Cursors.WaitCursor;
							Application.DoEvents();
							clsEncryptDecrypt.FileEncrypt(text5, MyGlobalClass.FileEncryptDecryptKey);
							Cursor.Current = Cursors.Default;
							File.Delete(text5);
							File.Delete(text);
						}
						else
						{
							bool isPi2 = MyGlobalClass.isPi;
							if (isPi2)
							{
								File.Move(text, MyGlobalClass.batchErrorDirectory + "/" + fileInfo.Name);
							}
							else
							{
								File.Move(text, MyGlobalClass.batchErrorDirectory + "\\" + fileInfo.Name);
							}
						}
					}
					else
					{
						bool isPi3 = MyGlobalClass.isPi;
						if (isPi3)
						{
							File.Move(text, MyGlobalClass.batchErrorDirectory + "/" + fileInfo.Name);
						}
						else
						{
							File.Move(text, MyGlobalClass.batchErrorDirectory + "\\" + fileInfo.Name);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000A520 File Offset: 0x00008720
		public void SubmitBankBatchesToFernwareEncrypt(clsBankBatchData objBankBatch)
		{
			string text = "";
			text = MyGlobalClass.GetRpiSerial();
			string text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/insertBatchHeaderEncrypt.php";
			string text3 = string.Concat(new string[]
			{
				text,
				"@Q@",
				objBankBatch.DepositDateTime,
				"@Q@",
				objBankBatch.UserID.ToString(),
				"@Q@",
				objBankBatch.DepositTotal.ToString(),
				"@Q@",
				MyGlobalClass.StoreID.ToString(),
				"@Q@",
				DateTime.Now.ToString("yyyyMMddHHmmss")
			});
			string text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection { 
				{
					"data",
					text4.ToString()
				} };
				objBankBatch.ID = int.Parse(Encoding.UTF8.GetString(webClient.UploadValues(text2, nameValueCollection)));
			}
			text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/insertBatchLinesBulkEncrypt.php";
			bool flag = objBankBatch.Five > 0;
			if (flag)
			{
				text3 = string.Concat(new string[]
				{
					text,
					"@Q@",
					objBankBatch.ID.ToString(),
					"@Q@5@Q@",
					objBankBatch.Five.ToString(),
					"@Q@",
					DateTime.Now.ToString("yyyyMMddHHmmss")
				});
				text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
				using (WebClient webClient2 = new WebClient())
				{
					NameValueCollection nameValueCollection2 = new NameValueCollection { 
					{
						"data",
						text4.ToString()
					} };
					webClient2.UploadValues(text2, nameValueCollection2);
				}
			}
			bool flag2 = objBankBatch.Ten > 0;
			if (flag2)
			{
				text3 = string.Concat(new string[]
				{
					text,
					"@Q@",
					objBankBatch.ID.ToString(),
					"@Q@10@Q@",
					objBankBatch.Ten.ToString(),
					"@Q@",
					DateTime.Now.ToString("yyyyMMddHHmmss")
				});
				text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
				using (WebClient webClient3 = new WebClient())
				{
					NameValueCollection nameValueCollection3 = new NameValueCollection { 
					{
						"data",
						text4.ToString()
					} };
					webClient3.UploadValues(text2, nameValueCollection3);
				}
			}
			bool flag3 = objBankBatch.Twenty > 0;
			if (flag3)
			{
				text3 = string.Concat(new string[]
				{
					text,
					"@Q@",
					objBankBatch.ID.ToString(),
					"@Q@20@Q@",
					objBankBatch.Twenty.ToString(),
					"@Q@",
					DateTime.Now.ToString("yyyyMMddHHmmss")
				});
				text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
				using (WebClient webClient4 = new WebClient())
				{
					NameValueCollection nameValueCollection4 = new NameValueCollection { 
					{
						"data",
						text4.ToString()
					} };
					webClient4.UploadValues(text2, nameValueCollection4);
				}
			}
			bool flag4 = objBankBatch.Fifty > 0;
			if (flag4)
			{
				text3 = string.Concat(new string[]
				{
					text,
					"@Q@",
					objBankBatch.ID.ToString(),
					"@Q@50@Q@",
					objBankBatch.Fifty.ToString(),
					"@Q@",
					DateTime.Now.ToString("yyyyMMddHHmmss")
				});
				text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
				using (WebClient webClient5 = new WebClient())
				{
					NameValueCollection nameValueCollection5 = new NameValueCollection { 
					{
						"data",
						text4.ToString()
					} };
					webClient5.UploadValues(text2, nameValueCollection5);
				}
			}
			bool flag5 = objBankBatch.Hundred > 0;
			if (flag5)
			{
				text3 = string.Concat(new string[]
				{
					text,
					"@Q@",
					objBankBatch.ID.ToString(),
					"@Q@100@Q@",
					objBankBatch.Hundred.ToString(),
					"@Q@",
					DateTime.Now.ToString("yyyyMMddHHmmss")
				});
				text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
				using (WebClient webClient6 = new WebClient())
				{
					NameValueCollection nameValueCollection6 = new NameValueCollection { 
					{
						"data",
						text4.ToString()
					} };
					webClient6.UploadValues(text2, nameValueCollection6);
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000AA70 File Offset: 0x00008C70
		private void button2_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("frmPreviewDecrypt");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007D70 File Offset: 0x00005F70
		private void btnClose_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).CloseMe();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000AA8C File Offset: 0x00008C8C
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
	}
}
