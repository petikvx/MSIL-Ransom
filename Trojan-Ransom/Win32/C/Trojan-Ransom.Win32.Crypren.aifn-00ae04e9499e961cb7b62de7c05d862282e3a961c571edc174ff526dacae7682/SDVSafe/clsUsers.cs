using System;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000A RID: 10
	public class clsUsers
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005FAB File Offset: 0x000041AB
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00005FB3 File Offset: 0x000041B3
		public int ID { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005FBC File Offset: 0x000041BC
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00005FC4 File Offset: 0x000041C4
		public string Username { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005FCD File Offset: 0x000041CD
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00005FD5 File Offset: 0x000041D5
		public string Password { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005FDE File Offset: 0x000041DE
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005FE6 File Offset: 0x000041E6
		public int? DefaultPage { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005FEF File Offset: 0x000041EF
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00005FF7 File Offset: 0x000041F7
		public int isDelete { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00006000 File Offset: 0x00004200
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00006008 File Offset: 0x00004208
		public string Passcode { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00006011 File Offset: 0x00004211
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00006019 File Offset: 0x00004219
		public int WebAccess { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00006022 File Offset: 0x00004222
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000602A File Offset: 0x0000422A
		public int DeviceAccess { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00006033 File Offset: 0x00004233
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000603B File Offset: 0x0000423B
		public int PermissionLevel { get; set; }

		// Token: 0x06000084 RID: 132 RVA: 0x00006044 File Offset: 0x00004244
		public clsUsers()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00006050 File Offset: 0x00004250
		public clsUsers(string str)
		{
			string[] array = str.Split(new char[] { ',' });
			bool flag = array.Length == 6;
			if (flag)
			{
				this.ID = int.Parse(array[0]);
				this.isDelete = int.Parse(array[1]);
				this.Passcode = array[2];
				this.WebAccess = int.Parse(array[3]);
				this.DeviceAccess = int.Parse(array[4]);
				this.PermissionLevel = int.Parse(array[5]);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000060D8 File Offset: 0x000042D8
		public string outputString()
		{
			string text = this.ID.ToString() + ",";
			text = text + this.isDelete.ToString() + ",";
			text = text + this.Passcode.ToString() + ",";
			text = text + this.WebAccess.ToString() + ",";
			text = text + this.DeviceAccess.ToString() + ",";
			return text + this.PermissionLevel.ToString();
		}
	}
}
