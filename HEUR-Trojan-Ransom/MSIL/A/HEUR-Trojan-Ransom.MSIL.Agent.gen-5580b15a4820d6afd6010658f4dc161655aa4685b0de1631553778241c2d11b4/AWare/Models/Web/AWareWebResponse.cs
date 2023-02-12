using System;

namespace AWare.Models.Web
{
	// Token: 0x02000006 RID: 6
	public class AWareWebResponse
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000024F4 File Offset: 0x000006F4
		public bool success { get; set; } = false;

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000024FD File Offset: 0x000006FD
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002505 File Offset: 0x00000705
		public string SecretKey { get; set; } = null;

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000250E File Offset: 0x0000070E
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002516 File Offset: 0x00000716
		public string EncryptionKey { get; set; } = null;

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000251F File Offset: 0x0000071F
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002527 File Offset: 0x00000727
		public bool Ready { get; set; } = false;

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002530 File Offset: 0x00000730
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002538 File Offset: 0x00000738
		public string SessionID { get; set; }
	}
}
