using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000D RID: 13
	public partial class frmStoreSelection : Form
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00007AC3 File Offset: 0x00005CC3
		public frmStoreSelection()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007ADC File Offset: 0x00005CDC
		private void initialStoreList()
		{
			this.dgvStore.Rows.Clear();
			string text = MyGlobalClass.WebServerHostName + "/rp1/queries/getStoreViewByKeyValue.php";
			List<clsStores> list;
			using (WebClient webClient = new WebClient())
			{
				string text2 = webClient.DownloadString(text + "?keyvalue=" + this.keyvalue);
				list = JsonConvert.DeserializeObject<List<clsStores>>(text2);
			}
			bool flag = list.Count > 0;
			if (flag)
			{
				foreach (clsStores clsStores in list)
				{
					int num = this.dgvStore.Rows.Add();
					this.dgvStore[this.colID.Index, num].Value = clsStores.ID.ToString();
					bool flag2 = clsStores.Name == null;
					if (flag2)
					{
						this.dgvStore[this.colName.Index, num].Value = "Unknown";
					}
					else
					{
						this.dgvStore[this.colName.Index, num].Value = clsStores.Name;
					}
					bool flag3 = clsStores.Address == null;
					if (flag3)
					{
						this.dgvStore[this.colAddress.Index, num].Value = "";
					}
					else
					{
						this.dgvStore[this.colAddress.Index, num].Value = clsStores.Address;
					}
					bool flag4 = clsStores.OrganisationName == null;
					if (flag4)
					{
						this.dgvStore[this.colOrganisation.Index, num].Value = "";
					}
					else
					{
						this.dgvStore[this.colOrganisation.Index, num].Value = clsStores.OrganisationName;
					}
					bool flag5 = clsStores.RegionName == null;
					if (flag5)
					{
						this.dgvStore[this.colRegion.Index, num].Value = "";
					}
					else
					{
						this.dgvStore[this.colRegion.Index, num].Value = clsStores.RegionName;
					}
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007D70 File Offset: 0x00005F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			((frmInitialPage)base.ParentForm).CloseMe();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007D84 File Offset: 0x00005F84
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.SaveSelectedStore();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007D8E File Offset: 0x00005F8E
		private void frmStoreSelection_Load(object sender, EventArgs e)
		{
			this.keyvalue = MyGlobalClass.tmpKeyValue;
			MyGlobalClass.tmpKeyValue = "";
			this.initialStoreList();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007DB0 File Offset: 0x00005FB0
		public void SaveSelectedStore()
		{
			int num = 0;
			int.TryParse(this.dgvStore[this.colID.Index, this.dgvStore.SelectedRows[0].Index].Value.ToString(), out num);
			MyGlobalClass.tmpStoreID = num;
			((frmInitialPage)base.ParentForm).RestartInitialProcess();
		}

		// Token: 0x04000069 RID: 105
		public string keyvalue;
	}
}
