using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000002 RID: 2
	public partial class BatchHistory : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public BatchHistory()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void btnBack_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002084 File Offset: 0x00000284
		private void BatchHistory_Load(object sender, EventArgs e)
		{
			int num = 1;
			try
			{
				string[] files = Directory.GetFiles(MyGlobalClass.batchUploadDirectory, "*.aes");
				Array.Sort<string>(files);
				string[] files2 = Directory.GetFiles(MyGlobalClass.batchDirectory, "*.aes");
				Array.Sort<string>(files2);
				string[] array = new string[files.Length + files2.Length];
				Array.Copy(files, array, files.Length);
				Array.Copy(files2, 0, array, files.Length, files2.Length);
				foreach (string text in array)
				{
					bool flag = !Path.GetFileName(text).Contains("_log");
					if (flag)
					{
						LinkLabel linkLabel = new LinkLabel();
						linkLabel.Font = new Font("Calibri", 16f, FontStyle.Regular);
						linkLabel.Text = this.ConvertFileNameToDateTime(Path.GetFileNameWithoutExtension(text));
						linkLabel.Size = new Size(220, 25);
						linkLabel.Location = new Point(20, 40 * num);
						linkLabel.Tag = text;
						linkLabel.LinkClicked += this.LinkLabel_LinkClicked;
						this.historyPanel.Controls.Add(linkLabel);
						num++;
					}
				}
			}
			catch (Exception ex)
			{
				Console.Write(ex.ToString());
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021F0 File Offset: 0x000003F0
		private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.myButtonEnableDisable(false);
			this.lblRecordHeader.Text = ((LinkLabel)sender).Text;
			string text = (string)((LinkLabel)sender).Tag;
			try
			{
				clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileDecrypt(text, text.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				using (StreamReader streamReader = new StreamReader(text.Replace(".aes", "")))
				{
					List<string> list = new List<string>();
					List<string> list2 = new List<string>();
					while (!streamReader.EndOfStream)
					{
						string text2 = streamReader.ReadLine();
						bool flag = text2.Contains(MyGlobalClass.batchDirectory);
						if (!flag)
						{
							string[] array = text2.Split(new char[] { ',' });
							list.Add(array[0]);
							list2.Add(array[1]);
						}
					}
					this.lbl5Count.Text = list2[0];
					this.lbl10Count.Text = list2[1];
					this.lbl20Count.Text = list2[2];
					this.lbl50Count.Text = list2[3];
					this.lbl100Count.Text = list2[4];
					this.lblTotalCount.Text = "$" + (int.Parse(list2[0]) * 5 + int.Parse(list2[1]) * 10 + int.Parse(list2[2]) * 20 + int.Parse(list2[3]) * 50 + int.Parse(list2[4]) * 100).ToString();
				}
			}
			catch (Exception ex)
			{
				Console.Write(ex.ToString());
			}
			this.myButtonEnableDisable(true);
			bool flag2 = File.Exists(text.Replace(".aes", ""));
			if (flag2)
			{
				File.Delete(text.Replace(".aes", ""));
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002458 File Offset: 0x00000658
		public string ConvertFileNameToDateTime(string strIn)
		{
			string text = strIn;
			bool flag = strIn.Contains("-") && strIn.Contains("_");
			if (flag)
			{
				string[] array = strIn.Split(new char[] { '_' })[0].Split(new char[] { '-' });
				string text2 = array[0];
				string text3 = array[1];
				text3 = text3.Substring(0, 4);
				text2 = text2.Insert(6, "-").Insert(4, "-");
				text3 = text3.Insert(2, ":");
				text = text2 + " " + text3;
			}
			return text;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002508 File Offset: 0x00000708
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
			foreach (object obj2 in this.historyPanel.Controls)
			{
				bool flag2 = obj2.GetType() == new LinkLabel().GetType();
				if (flag2)
				{
					LinkLabel linkLabel = (LinkLabel)obj2;
					linkLabel.Enabled = isEnabled;
				}
			}
			Application.DoEvents();
		}
	}
}
