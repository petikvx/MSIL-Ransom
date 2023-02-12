using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using M_POST_for_EBDS_Demo_In_CSharp_DotNet.Properties;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000014 RID: 20
	public partial class Settings : Form
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public Settings()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		private void RefreshPortList()
		{
			string[] portNames = SerialPort.GetPortNames();
			Array.Sort<string>(portNames);
			this.PortSelect.DataSource = portNames;
			this.lblCurrentPort.Text = "Current is " + (string)Settings.Default["COMPort"];
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000FB5E File Offset: 0x0000DD5E
		private void RefreshBtn_Click(object sender, EventArgs e)
		{
			this.RefreshPortList();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000768B File Offset: 0x0000588B
		private void PortSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000FB5E File Offset: 0x0000DD5E
		private void Settings_Load(object sender, EventArgs e)
		{
			this.RefreshPortList();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002068 File Offset: 0x00000268
		private void button1_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000FB68 File Offset: 0x0000DD68
		private void button2_Click(object sender, EventArgs e)
		{
			Settings.Default["COMPort"] = (string)this.PortSelect.SelectedItem;
			Settings.Default.Save();
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}
	}
}
