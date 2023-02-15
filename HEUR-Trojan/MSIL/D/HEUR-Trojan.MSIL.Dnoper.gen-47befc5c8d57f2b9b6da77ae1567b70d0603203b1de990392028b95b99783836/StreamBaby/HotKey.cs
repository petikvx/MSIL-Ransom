using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StreamBaby;

public class HotKey
{
	[Flags]
	public enum KeyModifiers
	{
		None = 0,
		Alt = 1,
		Ctrl = 2,
		Shift = 4,
		WindowsKey = 8
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
}
