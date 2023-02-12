using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000C RID: 12
	public partial class frmPreviewDecrypt : Form
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00007582 File Offset: 0x00005782
		public frmPreviewDecrypt()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002068 File Offset: 0x00000268
		private void btnCancel_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000759C File Offset: 0x0000579C
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = MyGlobalClass.initialDirectory;
			openFileDialog.Filter = "AES Files (*.aes)|*.aes";
			openFileDialog.Title = "Open encrypt file";
			openFileDialog.Multiselect = false;
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.myButtonEnableDisable(false);
				string fileName = openFileDialog.FileName;
				clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileDecrypt(fileName, fileName.Replace(".aes", ""), MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				string text = File.ReadAllText(fileName.Replace(".aes", ""));
				File.Delete(fileName.Replace(".aes", ""));
				this.rtbContent.Text = text;
				this.myButtonEnableDisable(true);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000768B File Offset: 0x0000588B
		private void frmPreviewDecrypt_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007690 File Offset: 0x00005890
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
