using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace AWare.Helper
{
	// Token: 0x02000008 RID: 8
	public class UidHelper
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002845 File Offset: 0x00000A45
		public string Id { get; }

		// Token: 0x0600001F RID: 31 RVA: 0x0000284D File Offset: 0x00000A4D
		public UidHelper()
		{
			this.Id = UidHelper.GetMachineGuid();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002864 File Offset: 0x00000A64
		private static string GetMachineGuid()
		{
			string text;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography"))
				{
					bool flag = registryKey2 == null;
					if (flag)
					{
						throw new KeyNotFoundException("Key Not Found: SOFTWARE\\Microsoft\\Cryptography");
					}
					object value = registryKey2.GetValue("MachineGuid");
					bool flag2 = value == null;
					if (flag2)
					{
						throw new IndexOutOfRangeException("Index Not Found: MachineGuid");
					}
					text = value.ToString();
				}
			}
			return text;
		}
	}
}
