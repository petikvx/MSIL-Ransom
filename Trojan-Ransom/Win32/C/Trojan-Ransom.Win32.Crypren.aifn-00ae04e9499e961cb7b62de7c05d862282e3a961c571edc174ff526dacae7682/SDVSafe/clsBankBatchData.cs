using System;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000005 RID: 5
	public class clsBankBatchData
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000057C4 File Offset: 0x000039C4
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000057CC File Offset: 0x000039CC
		public int ID { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000057D5 File Offset: 0x000039D5
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000057DD File Offset: 0x000039DD
		public int UserID { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000057E6 File Offset: 0x000039E6
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000057EE File Offset: 0x000039EE
		public string DepositDateTime { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000057F7 File Offset: 0x000039F7
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000057FF File Offset: 0x000039FF
		public int Five { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005808 File Offset: 0x00003A08
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00005810 File Offset: 0x00003A10
		public int Ten { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00005819 File Offset: 0x00003A19
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00005821 File Offset: 0x00003A21
		public int Twenty { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000582A File Offset: 0x00003A2A
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00005832 File Offset: 0x00003A32
		public int Fifty { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000583B File Offset: 0x00003A3B
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00005843 File Offset: 0x00003A43
		public int Hundred { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000584C File Offset: 0x00003A4C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00005854 File Offset: 0x00003A54
		public int DepositTotal { get; set; }

		// Token: 0x0600003F RID: 63 RVA: 0x0000585D File Offset: 0x00003A5D
		public void RefreshTotal()
		{
			this.DepositTotal = this.Five * 5 + this.Ten * 10 + this.Twenty * 20 + this.Fifty * 50 + this.Hundred * 100;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005898 File Offset: 0x00003A98
		public string outputString()
		{
			string text = "";
			text = text + "5," + this.Five.ToString() + Environment.NewLine;
			text = text + "10," + this.Ten.ToString() + Environment.NewLine;
			text = text + "20," + this.Twenty.ToString() + Environment.NewLine;
			text = text + "50," + this.Fifty.ToString() + Environment.NewLine;
			return text + "100," + this.Hundred.ToString();
		}
	}
}
